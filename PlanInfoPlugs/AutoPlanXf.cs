using Model;
using SubSonic;
using SubSonic.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using TestService.ModelsOther;

namespace TestService.Helper
{
    public class AutoPlanXf
    {

        public List<string> ListOrder { get; set; }
        public List<TBasisLinesFz> Lines { get; set; }
        public List<LineOrderPool> LineOrder { get; set; }
        public List<VOrderDatapoolXf> ListXjOrder { get; set; }
        public List<VOrderDatapoolXf> ListPjOrder { get; set; }
        public List<string> AllCategorys { get; set; }
        public List<VOrderDatapoolXf> OrderDatapool { get; set; }
        public List<TBasisLinesRestriction> Restriction { get; set; }


        //构造函数，初始化数据集合
        public AutoPlanXf()
        {
            ListOrder = new List<string>();
            Lines = new Select().From<TBasisLinesFz>().Where(TBasisLinesFz.LineTypeColumn).IsEqualTo("XF").ExecuteTypedList<TBasisLinesFz>();
            LineOrder = new List<LineOrderPool>();
            ListXjOrder = new List<VOrderDatapoolXf>();
            ListPjOrder = new List<VOrderDatapoolXf>();
            AllCategorys = new List<string>();
            OrderDatapool = new Select().From<VOrderDatapoolXf>().ExecuteTypedList<VOrderDatapoolXf>();
            Restriction = new Select().From<TBasisLinesRestriction>().ExecuteTypedList<TBasisLinesRestriction>();
        }

        //筛选订单 
        public void OrderScreen()
        {
            try
            {
                var lines = new List<TBasisLinesFz>();
                lines.AddRange(Lines);

                //当前车间的产能品类
                foreach (var categorys in lines.ConvertAll(x => x.Categorys))
                {
                    var nowCategorys = categorys.Split(',');
                    foreach (var category in nowCategorys)
                    {
                        if (!AllCategorys.Contains(category))
                        {
                            AllCategorys.Add(category);
                        }
                    }
                }

                //去掉没有交期天数得订单
                OrderDatapool.RemoveAll(x => string.IsNullOrEmpty(x.Jqts));

                //去除还没有计划标注的订单
                OrderDatapool.RemoveAll(x => string.IsNullOrEmpty(x.Scjhbz) || x.Scjhbz.Contains("未"));

                //线上加急订单
                ListXjOrder.AddRange(OrderDatapool.FindAll(x => x.Jqts == "6"));
                OrderDatapool.RemoveAll(x => x.Jqts == "6");
                //配件
                ListPjOrder.AddRange(OrderDatapool.FindAll(x => x.Fzfl == "P0"));
                OrderDatapool.RemoveAll(x => x.Fzfl == "P0");


                var orders = new List<VOrderDatapoolXf>();

                //订单池数据
                foreach (var category in AllCategorys)
                {
                    //前期使用ERP数据源关联自有数据，原因：已生成计划订单不明确
                    var orderList = OrderDatapool.FindAll(x => x.Fzfl == category);

                    //如果是裙子品类，产能最大每小时是3左右，取50就够了
                    if (category.Contains("XQ"))
                    {
                        orderList = orderList.OrderBy(x => x.Jhrq).Take(50).ToList();
                    }//如果是马甲品类，产能最大每小时是40左右，取100就够了
                    else if (category.Contains("MJ"))
                    {
                        orderList = orderList.OrderBy(x => x.Jhrq).Take(100).ToList();
                    }//每个品类每次只取300条就够了
                    else if (orderList.Count > 300)
                    {
                        orderList = orderList.OrderBy(x => x.Jhrq).Take(300).ToList();
                    }


                    orders.AddRange(orderList);
                }
                OrderDatapool.Clear();
                OrderDatapool.AddRange(orders);

                //过滤裙子和马甲订单，只留需求的数量就好
                var datapool = RemoveC_DMore(OrderDatapool, lines.FindAll(x => x.Abbreviation == "C" || x.Abbreviation == "D"));

                //添加的订单客户单号去重
                ListOrder.AddRange(orders.OrderBy(x => x.Jhrq).ToList().ConvertAll(x => x.Khdh).Distinct());


                //产线排序  以西服为主
                Lines.Clear();
                Lines.AddRange(lines.FindAll(x => x.Abbreviation == "F"));
                Lines.AddRange(lines.FindAll(x => x.Abbreviation == "B"));
                Lines.AddRange(lines.FindAll(x => x.Abbreviation == "D"));
                Lines.AddRange(lines.FindAll(x => x.Abbreviation == "C"));


                //分配订单算法--初步分配
                LineOrder = ScheduingOrderUnion(Lines, ListOrder);

                //待分配订单去除已分配订单
                LineOrder.ForEach(x => ListOrder.RemoveAll(y => y == x.Khdh));

                //控制台输出查看当前分了多少
                lines.ForEach(x => Console.WriteLine(x.LineName + "::" + LineOrder.FindAll(y => y.LineName == x.LineName).Sum(y => y.Num)));

                //订单分配后产能检测,产能不饱和记录List
                var lineUnSaturated = new List<TBasisLinesFz>();

                //产线品类分组  检测是否饱和
                foreach (var liner in Lines.GroupBy(x => x.Abbreviation))
                {
                    //按照同品类的订单检测是否饱和
                    foreach (var line in Lines.FindAll(x => x.Abbreviation == liner.Key))
                        //订单不饱和
                        if (line.Capacity - LineOrder.FindAll(x => x.LineName == line.LineName).Sum(x => x.Num) > 5)
                        {
                            if (!lineUnSaturated.Contains(line))
                                lineUnSaturated.AddRange(Lines.FindAll(x => x.Abbreviation == liner.Key));
                        }

                }

                //如果有产线的产能没有达到饱和
                if (lineUnSaturated.Count > 0)
                {
                    //1.把所有的订单拿出来
                    var listOrder = new List<LineOrderPool>();
                    lineUnSaturated.ForEach(x => listOrder.AddRange(LineOrder.FindAll(y => y.LineName == x.LineName)));

                    //2.计算重新分配比例
                    var group = lineUnSaturated.GroupBy(x => x.Abbreviation);
                    foreach (var fzes in group)
                    {
                        //所需同品类订单的总和
                        var sum = lineUnSaturated.FindAll(x => x.Abbreviation == fzes.Key).Sum(x => x.Capacity);

                        //现有同品类订单的数量总和
                        var nowOrder = 0;
                        foreach (var linesFz in lineUnSaturated.FindAll(x => x.Abbreviation == fzes.Key))
                            nowOrder += LineOrder.FindAll(x => x.LineName == linesFz.LineName).Sum(x => x.Num);

                        //计算现有数量的订单比例数量
                        foreach (var linesFz in lineUnSaturated.FindAll(x => x.Abbreviation == fzes.Key))
                        {
                            /**
                                 * 公式计算规则
                                 * 现有同品类数量总和 * （所有同品类的总和/当前产线的所需数量）
                                 * **/
                            var num = (float)linesFz.Capacity / (float)sum * nowOrder;
                            linesFz.Capacity = int.Parse(Math.Round(num).ToString());
                        }

                    }

                    //从已分配的集合中删除等待重新分配订单数据
                    listOrder.ForEach(x => LineOrder.RemoveAll(y => y.LineName == x.LineName && y.Khdh == x.Khdh));

                    //将产能能不饱和的生产线聚合重新分配
                    LineOrder.AddRange(ScheduingOrderUnion(lineUnSaturated, listOrder.ConvertAll(x => x.Khdh)));
                }

                //控制台输出查看当前分了多少
                Console.WriteLine(" 最终分配订单");
                lines.ForEach(x => Console.WriteLine(x.LineName + "::" + LineOrder.FindAll(y => y.LineName == x.LineName).Sum(y => y.Num)));


                #region 加急订单分配


                //----马甲全部给缝制1  ListXjOrder
                ListXjOrder.FindAll(x => x.Fzfl.Contains("MJ")).ForEach(x => LineOrder.Add(new LineOrderPool { Khdh = x.Khdh, LineName = "马甲缝制1", Fzfl = x.Fzfl, Num = int.Parse(x.Ddsl.ToString()) }));

                //----西裙全部给缝制1
                ListXjOrder.FindAll(x => x.Fzfl == "WXQ").ForEach(x => LineOrder.Add(new LineOrderPool { Khdh = x.Khdh, LineName = "西裙缝制1", Fzfl = x.Fzfl, Num = int.Parse(x.Ddsl.ToString()) }));

                //----西裤平分
                var xjXk = ListXjOrder.FindAll(x => x.Fzfl.Contains("XK"));
                foreach (var linesFz in Lines.FindAll(x => x.Abbreviation == "B"))
                {
                    //计算平均应分多少
                    var num = (double)xjXk.Sum(x => x.Ddsl) / Lines.FindAll(x => x.Abbreviation == "B").Count;
                    var nowCount = 0;
                    num = num > 1 && num > 0 ? num : 1;
                    //分配订单
                    foreach (var datapoolXf in xjXk.FindAll(x => true).Take(int.Parse(Math.Round(num).ToString())))
                    {
                        nowCount += int.Parse(datapoolXf.Ddsl.ToString());
                        if (num < nowCount)
                        {
                            break;
                        }

                        LineOrder.Add(new LineOrderPool
                        {
                            Khdh = datapoolXf.Khdh,
                            LineName = linesFz.LineName,
                            Fzfl = datapoolXf.Fzfl,
                            Num = int.Parse(datapoolXf.Ddsl.ToString())
                        });

                        xjXk.Remove(datapoolXf);
                    }
                }

                //----西服平分
                var xjXf = ListXjOrder.FindAll(x => !x.Fzfl.Contains("XK") && !x.Fzfl.Contains("MJ") && x.Fzfl != "WXQ");
                foreach (var linesFz in Lines.FindAll(x => true).FindAll(x => x.Abbreviation == "F"))
                {
                    //计算平均应分多少
                    var num = (double)xjXf.Sum(x => x.Ddsl) / Lines.FindAll(x => x.Abbreviation == "F").Count;
                    var nowCount = 0;
                    num = num > 1 && num > 0 ? num : 1;

                    //分配订单
                    foreach (var datapoolXf in xjXf.Take(int.Parse(Math.Round(num).ToString())))
                    {
                        nowCount += int.Parse(datapoolXf.Ddsl.ToString());
                        if (num > nowCount)
                        {
                            break;
                        }

                        LineOrder.Add(new LineOrderPool
                        {
                            Khdh = datapoolXf.Khdh,
                            LineName = linesFz.LineName,
                            Fzfl = datapoolXf.Fzfl,
                            Num = int.Parse(datapoolXf.Ddsl.ToString())
                        });

                        xjXf.Remove(datapoolXf);

                    }
                }

                //--配件订单分配（默认全部F2）
                ListPjOrder.ForEach(x => LineOrder.Add(new LineOrderPool { Khdh = x.Khdh, LineName = "西服缝制2", Fzfl = x.Fzfl, Num = int.Parse(x.Ddsl.ToString()) }));

                #endregion

                new Delete().From<TTempLineOrderPool>().Execute();

                //暂存到数据库
                foreach (var orderPool in LineOrder)
                {
                    try
                    {
                        var obj = new TTempLineOrderPool
                        {
                            Khdh = orderPool.Khdh,
                            Fzfl = orderPool.Fzfl,
                            Num = orderPool.Num,
                            LineName = orderPool.LineName
                        };
                        obj.Save();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e);
                    }
                }


                //筛选订单完成
                //new CreatePlanNo(LineOrder).AutoPlanNo();
            }
            catch (Exception e)
            {
                throw;
            }
        }

        //根据产线和分配订单(检索其他产线的套装信息,优先并且必须包含在内)
        public List<LineOrderPool> ScheduingOrderUnion(List<TBasisLinesFz> lines, List<string> listOrder)
        {
            var lineOrders = new List<LineOrderPool>();
            try
            {
                //遍历当前产线分配订单
                foreach (var line in lines)
                {
                    //当前产线产能的所有品类
                    var categorys = line.Categorys.ToUpper().Split(',').ToList();

                    //当前已分配完的产线
                    var groupList = lineOrders.GroupBy(x => x.LineName).ToList();
                    var categorysHaving = new List<string>();

                    //当前已分配完产线的品类
                    groupList.ForEach(y => categorysHaving.AddRange(lines
                        .Find(x => x.LineName == y.Key).Categorys.Split(',').ToList()));

                    //除当前正在分配的产线类型
                    categorys.ForEach(x => categorysHaving.RemoveAll(y => y == x));
                    categorysHaving = categorysHaving.Distinct().ToList();

                    //遍历出已有的订单套装
                    foreach (var order in lineOrders.FindAll(x => true))
                    {
                        //判断产线产能是否饱和
                        if (lineOrders.FindAll(x => x.LineName == line.LineName).Sum(x => x.Num) >=
                            line.Capacity)
                            break;


                        //如果同品类中已分配则不需要再次分配
                        var having = false;
                        foreach (var linesFz in lines.FindAll(
                            x => x.Abbreviation == line.Abbreviation))
                            if (lineOrders.FindAll(x => x.Khdh == order.Khdh &&
                                                        x.LineName == linesFz.LineName).Count > 0)
                            {
                                having = true;
                                break;
                            }

                        if (having)
                            continue;

                        //获取订单的明细信息（套装信息）
                        var ordermx = new Select().From<TBLDataOrdermx>()
                            .Where(TBLDataOrdermx.KhdhColumn).IsEqualTo(order.Khdh)
                            .ExecuteTypedList<TBLDataOrdermx>();

                        //遍历该订单下的所有明细
                        foreach (var dataOrdermx in ordermx)
                        {

                            //如果该订单符合该产线的品类
                            if (categorys.Contains(dataOrdermx.Fzfl.ToUpper()))
                            {
                                if (lineOrders.FindAll(x => x.Khdh == dataOrdermx.Khdh &&
                                                            x.Fzfl == dataOrdermx.Fzfl).Count > 0)
                                    Console.WriteLine($"数据重复,订单已分配。{dataOrdermx.Khdh}");

                                //分配订单 
                                lineOrders.Add(new LineOrderPool
                                {
                                    Khdh = dataOrdermx.Khdh,
                                    LineName = line.LineName,
                                    Fzfl = dataOrdermx.Fzfl,
                                    Num = int.Parse(dataOrdermx.Ddsl.ToString())
                                });
                            }
                        }
                    }

                    //遍历订单池订单
                    foreach (var order in listOrder.FindAll(x => true))
                    {
                        //获取订单的明细信息（套装信息）
                        var ordermx = OrderDatapool.FindAll(x => x.Khdh == order);

                        //判断产线产能是否饱和
                        if (lineOrders.FindAll(x => x.LineName == line.LineName).Sum(x => x.Num) >= line.Capacity)
                            break;

                        //如果当前是套装并且包含已分配完产线的品类就踢出去，避免超出
                        var having = false;
                        ordermx.ForEach(x => having = categorysHaving.FindAll(y => y.ToLower() == x.Fzfl.ToLower()).Count > 0);
                        if (having)
                            continue;

                        //遍历该订单下的所有明细
                        foreach (var dataOrdermx in ordermx)
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
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

            return lineOrders;
        }

        //根据产线和分配订单(不检索其他产线的套装信息)
        public List<LineOrderPool> ScheduingOrder(List<TBasisLinesFz> lines, List<string> listOrder)
        {
            var lineOrders = new List<LineOrderPool>();
            try
            {
                //遍历当前产线分配订单
                foreach (var line in lines)
                {
                    //当前产线产能的所有品类
                    var categorys = line.Categorys.ToUpper().Split(',').ToList();

                    //遍历订单
                    foreach (var order in listOrder.FindAll(x => true))
                    {
                        //获取订单的明细信息（套装信息）
                        var ordermx = new Select().From<TBLDataOrdermx>()
                            .Where(TBLDataOrdermx.KhdhColumn).IsEqualTo(order)
                            .ExecuteTypedList<TBLDataOrdermx>();

                        //判断产线产能是否饱和
                        if (lineOrders.FindAll(x => x.LineName == line.LineName).Sum(x => x.Num) >=
                            line.Capacity)
                            break;

                        //遍历该订单下的所有明细
                        foreach (var dataOrdermx in ordermx)
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

                                //将已分配的数据从主数据中移除
                                listOrder.RemoveAll(x => x == dataOrdermx.Khdh);
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

        //检测当前产线特殊规则得订单是否超出
        public bool TestRule(TBasisLinesFz line, List<LineOrderPool> lineOrders)
        {
            try
            {
                //--当前筛选条件集合获取
                var restriction = Restriction.FindAll(x => x.LineName == line.LineName);

                //--当前产线分配的订单
                var nowLineOrder = lineOrders.FindAll(x => x.LineName == line.LineName);

                var mxList = new List<VOrderDatapoolXf>();
                nowLineOrder.ForEach(x => mxList.AddRange(OrderDatapool.FindAll(y => y.Khdh == x.Khdh && y.Fzfl == x.Fzfl)));
                //---LineOrder
                //根据不同的规则筛选
                foreach (var linesRestriction in restriction)
                {
                    //当前的设限分类类型
                    var sXList = linesRestriction.Restriction.Split(',');

                    //当前的设限分类类型订单
                    var nowOutOrders = new List<VOrderDatapoolXf>();

                    //-- MLWG 面料外观
                    if (linesRestriction.Identifies == "MLWG")
                    {

                        /**
                         * 要只计算当前产线得格子订单
                         * **/

                        //匹配订单的面料外观
                        var waiGuanList = new List<VOrderDatapoolXf>();
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

                return false;
            }
            catch (Exception e)
            {
                throw;
            }
        }

        //检测裙子和马甲得数量
        public List<VOrderDatapoolXf> RemoveC_DMore(List<VOrderDatapoolXf> orders, List<TBasisLinesFz> lins)
        {
            var orderList = new List<VOrderDatapoolXf>();
            try
            {
                //备份原数据传出
                orderList.AddRange(orders);

                //裙子马甲需要得总数量
                var cCount = lins.FindAll(x => x.Abbreviation == "C").Sum(x => x.Capacity);
                var dCount = lins.FindAll(x => x.Abbreviation == "D").Sum(x => x.Capacity);

                //裙子马甲得订单集合
                var list = orders.FindAll(x => x.Sldl.Contains("C") || x.Sldl.Contains("D"));

                //遍历集合如果马甲数量超出
                foreach (var order in list.OrderByDescending(x => x.Jhrq))
                {
                    int mjNum = orders.FindAll(x => x.Fzfl == "MMJ" || x.Fzfl == "WMJ" || x.Fzfl == "TMJ").Sum(x => int.Parse(x.Ddsl.ToString()));
                    int xqNum = orders.FindAll(x => x.Fzfl == "WXQ").Sum(x => int.Parse(x.Ddsl.ToString()));
                    if (mjNum > cCount && order.Sldl.Contains("C"))
                    {
                        orders.RemoveAll(x => x.Khdh == order.Khdh);
                    }
                    else if (xqNum > dCount && order.Sldl.Contains("D"))
                    {
                        orders.RemoveAll(x => x.Khdh == order.Khdh);
                    }
                    else
                    {
                        break;
                    }

                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return orderList;
        }

    }

    public class CreatePlanNo
    {
        public List<LineOrderPool> LineOrder { get; set; }
        public List<TBLDataOrder> DataOrder { get; set; }
        public List<TBLDataOrdermx> DataOrderMx { get; set; }
        public List<TAnalysisOrderMx> OrderAnalyMx { get; set; }

        //构造函数，初始化集合
        public CreatePlanNo(List<LineOrderPool> lineOrder)
        {
            //初始化数据
            LineOrder = lineOrder;
            DataOrder = new Select().From<TBLDataOrder>().Where(TBLDataOrder.KhdhColumn).In(lineOrder.ConvertAll(x => x.Khdh)).ExecuteTypedList<TBLDataOrder>();
            DataOrderMx = new Select().From<TBLDataOrdermx>().Where(TBLDataOrdermx.KhdhColumn).In(lineOrder.ConvertAll(x => x.Khdh)).ExecuteTypedList<TBLDataOrdermx>();
            OrderAnalyMx = new Select().From<TAnalysisOrderMx>().Where(TAnalysisOrderMx.KhdhColumn).In(lineOrder.ConvertAll(x => x.Khdh)).ExecuteTypedList<TAnalysisOrderMx>();

        }

        public void AutoPlanNo()
        {
            foreach (var tmw in "TMW,other".Split(','))
            {

                var lineGroup = LineOrder.FindAll(x => x.Khdh.IndexOf(tmw, StringComparison.Ordinal) == 0).GroupBy(x => x.LineName);
                if (tmw != "TMW")
                {
                    lineGroup = LineOrder.FindAll(x => x.Khdh.IndexOf(tmw, StringComparison.Ordinal) != 0).GroupBy(x => x.LineName);
                }

                //根据产线分组
                foreach (var line in lineGroup)
                {
                    //国别筛选
                    foreach (var gb in "国内,国外".Split(','))
                    {

                        var list = DataOrder.Where(x => LineOrder.FindAll(y => y.LineName == line.Key).Exists(t => t.Khdh == x.Khdh) && x.Khzb == gb).ToList().ConvertAll(x => x.Khdh);

                        //面料外观筛选
                        foreach (var mlwg in "MTM/,新/".Split(','))
                        {
                            OrderAnalyMx.ForEach(x=>x.Scjhbz.Replace("",""));
                            list = OrderAnalyMx.Where(x => list.Contains(x.Khdh) && x.Scjhbz.IndexOf(mlwg, StringComparison.Ordinal) == 0).ToList()
                                .ConvertAll(x => x.Khdh).Distinct().ToList();

                            //性别筛选
                            //测试订单
                            //筛选加急的订单
                            //筛选8天的订单
                            //筛选9天的顶大
                            //筛选TMW的订单
                            //筛选普通的订单

                        }

                    }

                }
            }
        }

    }

}