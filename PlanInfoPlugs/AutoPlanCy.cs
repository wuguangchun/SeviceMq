using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using SubSonic;
using TestService.ModelsOther;

namespace PlanInfoPlugs
{
    public class AutoPlanCy
    {
        public List<string> ListOrder { get; set; }
        public DateTime BeginTime { get; set; }
        public List<TWorkTime> WorkTimes { get; set; }
        public List<TBasisLinesFz> Lines { get; set; }
        public List<LineOrderPool> LineOrder { get; set; }
        public List<VOrderDatapoolCy> OrderDatapool { get; set; }
        public List<TBasisLinesRestriction> Restriction { get; set; }
        public List<VOrderDatapoolCy> ListXjOrder { get; set; }
        public List<VOrderDatapoolCy> ListPjOrder { get; set; }

        public AutoPlanCy()
        {
            ListOrder = new List<string>();
            ListXjOrder = new List<VOrderDatapoolCy>();
            ListPjOrder = new List<VOrderDatapoolCy>();
            Lines = new Select().From<TBasisLinesFz>().Where(TBasisLinesFz.LineTypeColumn).IsEqualTo("CY").ExecuteTypedList<TBasisLinesFz>();
            Restriction = new Select().From<TBasisLinesRestriction>().ExecuteTypedList<TBasisLinesRestriction>();
            OrderDatapool = new Select().From<VOrderDatapoolCy>().ExecuteTypedList<VOrderDatapoolCy>();
            LineOrder = new List<LineOrderPool>();
        }

        public string OrderScreen(DateTime beginTime)
        {
            try
            {
                //按照交期排序
                OrderDatapool = OrderDatapool.OrderBy(x => x.Jhrq).ToList();

                //移除还没有计划标注的
                OrderDatapool.RemoveAll(x => string.IsNullOrEmpty(x.Scjhbz) || x.Scjhbz.Contains("未"));

                //配件
                ListPjOrder.AddRange(OrderDatapool.FindAll(x => x.Fzfl == "P0"));
                OrderDatapool.RemoveAll(x => x.Fzfl == "P0");

                //线上加急订单
                ListXjOrder.AddRange(OrderDatapool.FindAll(x => x.Jqts == "6"));
                ListXjOrder.AddRange(OrderDatapool.FindAll(x => x.Jqts == "5"));
                OrderDatapool.RemoveAll(x => x.Jqts == "6" || x.Jqts == "5");

                var orders = new List<VOrderDatapoolCy>();

                //优化数据量支取按照交期排序的前500条订单 
                var orderList = OrderDatapool.OrderBy(x => x.Jhrq).Take(500).ToList();

                //夹胶条，免烫，高级免烫5B42 58U1 58U2

                orders.AddRange(orderList);
                OrderDatapool.Clear();
                OrderDatapool.AddRange(orders);

                //添加的订单客户单号去重
                ListOrder.AddRange(orders.OrderBy(x => x.Jhrq).ToList().ConvertAll(x => x.Khdh).Distinct());

                //分配订单算法--初步分配
                LineOrder = ScheduingOrderUnion(Lines, ListOrder);


                return "";
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public List<LineOrderPool> ScheduingOrderUnion(List<TBasisLinesFz> lines, List<string> listOrder)
        {
            var lineOrders = new List<LineOrderPool>();
            try
            {
                foreach (var line in lines)
                {
                    //当前产线产能的所有品类
                    var categorys = line.Categorys.ToUpper().Split(',').ToList();

                    foreach (var order in listOrder.FindAll(x => true))
                    {
                        //获取订单的明细信息（套装信息）
                        var ordermx = OrderDatapool.FindAll(x => x.Khdh == order);

                        //判断产线产能是否饱和
                        if (lineOrders.FindAll(x => x.LineName == line.LineName).Sum(x => x.Num) >= line.Capacity)
                            break;

                        foreach (var dataOrdermx in ordermx)
                        {

                            //如果该订单符合该产线的品类
                            if (categorys.Contains(dataOrdermx.Fzfl.ToUpper()))
                            {
                                //分配订单 
                                lineOrders.Add(new LineOrderPool
                                {
                                    Khdh = dataOrdermx.Khdh,
                                    LineName = line.LineName,
                                    Fzfl = dataOrdermx.Fzfl,
                                    Num = int.Parse(dataOrdermx.Ddsl.ToString())
                                });

                                //检测分配后特殊订单是否超出,如果超出就去掉这个订单
                                if (TestRule(line, lineOrders))
                                {
                                    lineOrders.RemoveAll(x => x.Khdh == dataOrdermx.Khdh);
                                }
                                else
                                {
                                    //将已分配的数据从主数据中移除
                                    listOrder.RemoveAll(x => x == dataOrdermx.Khdh);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            return lineOrders;
        }


        public bool TestRule(TBasisLinesFz line, List<LineOrderPool> lineOrders)
        {
            try
            {
                //--当前筛选条件集合获取
                var restriction = Restriction.FindAll(x => x.LineName == line.LineName);

                //--当前产线分配的订单
                var nowLineOrder = lineOrders.FindAll(x => x.LineName == line.LineName);

                var mxList = new List<VOrderDatapoolCy>();
                nowLineOrder.ForEach(x => mxList.AddRange(OrderDatapool.FindAll(y => y.Khdh == x.Khdh && y.Fzfl == x.Fzfl)));

                foreach (var linesRestriction in restriction)
                {
                    //当前的设限分类类型
                    var sXList = linesRestriction.Restriction.Split(',');

                    //当前的设限分类类型订单
                    var nowOutOrders = new List<VOrderDatapoolCy>();

                    //-- MLWG 面料外观
                    if (linesRestriction.Identifies == "MLWG")
                    {

                        /**
                         * 要只计算当前产线得格子订单
                         * **/

                        //匹配订单的面料外观
                        var waiGuanList = new List<VOrderDatapoolCy>();
                        OrderDatapool.ForEach(x => x.Scjhbz.Replace("绘纸皮/", "MTM/"));
                        nowLineOrder.ForEach(x => waiGuanList.AddRange(OrderDatapool.FindAll(y => y.Khdh == x.Khdh && y.Fzfl == x.Fzfl && y.Scjhbz.ToUpper().Contains(linesRestriction.Restriction == "GZ" ? "MTM/" : "新/"))));

                        //将已有订单添加到集合
                        waiGuanList.ForEach(x => nowOutOrders.AddRange(mxList.FindAll(y => y.Khdh == x.Khdh && y.Fzfl == x.Fzfl)));


                    }
                    //-- FZFL 服装分类
                    else if (linesRestriction.Identifies == "FZFL")
                    {
                        //筛选当前的分类订单
                        sXList.ToList()
                            .ForEach(y => nowOutOrders.AddRange(mxList.FindAll(x => x.Fzfl == y)));
                    }

                    //-- GYXX 工艺信息
                    else if (linesRestriction.Identifies == "GYXX")
                    {
                        //筛选当前的工艺订单
                        sXList.ToList()
                            .ForEach(y => nowOutOrders.AddRange(mxList.FindAll(x => x.Gyxx.ToLower()
                                .Contains(y.ToLower()))));
                    }

                    //-- MLBM 面料编码
                    else if (linesRestriction.Identifies == "MLBM")
                    {
                        //筛选当前的工艺订单
                        sXList.ToList()
                            .ForEach(y => nowOutOrders.AddRange(mxList.FindAll(x => x.Mlbm == y)));
                    }

                    //-- GYLX 工艺类型
                    else if (linesRestriction.Identifies == "GYLX")
                    {
                        sXList.ToList()
                            .ForEach(y => nowOutOrders.AddRange(mxList.FindAll(x => x.Gylx == y)));
                    }

                    //标准设限，如允许有出入 则修改判断的值就可以了 
                    if (nowOutOrders.Sum(x => x.Ddsl) - linesRestriction.Capacity > 0)
                        return true;
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

            return false;
        }

    }
}
