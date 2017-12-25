using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using APSData;
using SubSonic;
using SubSonic.Extensions;
using TestService.ModelsOther;

namespace TestService.Helper
{
    public class AutoPlanXf
    {
        public List<String> ListOrder { get; set; }
        public List<TBasisLinesFz> Lines { get; set; }
        public List<LineOrderPool> LineOrder { get; set; }

        /// <summary>
        /// 构造函数，初始化三大集合
        /// </summary>
        public AutoPlanXf()
        {
            ListOrder = new List<string>();
            Lines = new List<TBasisLinesFz>();
            LineOrder = new List<LineOrderPool>();
        }

        /// <summary>
        /// 筛选订单
        /// </summary>
        public void OrderScreen()
        {
            try
            {
                //当前车间的产线
                var lines = new Select().From<TBasisLinesFz>()
                    .Where(TBasisLinesFz.LineTypeColumn).IsEqualTo("XF")
                    .ExecuteTypedList<TBasisLinesFz>();

                //当前车间的产能品类
                var allCategorys = new List<string>();
                foreach (var categorys in lines.ConvertAll(x => x.Categorys))
                {
                    var nowCategorys = categorys.Split(',');
                    foreach (var category in nowCategorys)
                    {
                        if (!allCategorys.Contains(category))
                        {
                            allCategorys.Add(category);
                        }

                    }
                }

                //订单池数据
                foreach (var category in allCategorys)
                {
                    var orderList = new Select().From<TBLDataOrdermx>()
                        .InnerJoin(TBasisOrderStatus.CustomerIdColumn, TBLDataOrdermx.KhdhColumn)
                        .Where(TBasisOrderStatus.OrderStatusColumn).IsEqualTo("103")
                        .Or(TBLDataOrdermx.FzflColumn).IsEqualTo(category)
                        .ExecuteTypedList<TBLDataOrdermx>();
                    ListOrder.AddRange(orderList.ConvertAll(x => x.Khdh));
                }
                //添加的订单明细客户单号去重
                ListOrder = ListOrder.Distinct<string>().ToList();

                //产线产能倒序(同品类要在一起) 
                Dictionary<string, int> lineCapacity = new Dictionary<string, int>();
                foreach (var key in lines.GroupBy(x => x.Abbreviation).ToList())
                {
                    lineCapacity.Add(key.Key, int.Parse(lines.FindAll(x => x.Abbreviation == key.Key).Sum(x => x.Capacity).ToString()));
                }
                var objlist = lineCapacity.OrderBy(x => x.Value).ToList();
                objlist.ForEach(x => Lines.AddRange(lines.FindAll(y => y.Abbreviation == x.Key).OrderBy(y => y.Capacity)));


                //分配订单算法--初步分配
                LineOrder = ScheduingOrderUnion(Lines, ListOrder);

                //订单分配后产能检测,产能不饱和记录List
                List<TBasisLinesFz> lineUnSaturated = new List<TBasisLinesFz>();
                foreach (var line in Lines)
                {
                    if (line.Capacity - LineOrder.FindAll(x => x.LineName == line.LineName).Sum(x => x.Num) > 5)
                    {
                        lineUnSaturated.Add(line);
                    }
                }

                //如果又产线的产能没有达到饱和
                if (lineUnSaturated.Count > 0)
                {
                    //1.把所有的订单拿出来
                    List<LineOrderPool> listOrder = new List<LineOrderPool>();
                    lineUnSaturated.ForEach(x => listOrder.AddRange(LineOrder.FindAll(y => y.LineName == x.LineName)));

                    //2.计算重新分配比例
                    var group = lineUnSaturated.GroupBy(x => x.Abbreviation);
                    foreach (var fzes in group)
                    {
                        //所需同品类订单的总和
                        var sum = lineUnSaturated.FindAll(x => x.Abbreviation == fzes.Key).Sum(x => x.Capacity);

                        //现有同品类订单的数量总和
                        int nowOrder = 0;
                        foreach (var linesFz in lineUnSaturated.FindAll(x => x.Abbreviation == fzes.Key))
                        {
                            nowOrder += LineOrder.FindAll(x => x.LineName == linesFz.LineName).Sum(x => x.Num);
                        }

                        //计算现有数量的订单比例数量
                        foreach (var linesFz in lineUnSaturated.FindAll(x => x.Abbreviation == fzes.Key))
                        {
                            /**
                             * 公式计算规则
                             * 现有同品类数量总和 * （所有同品类的总和/当前产线的所需数量）
                             * **/
                            linesFz.Capacity = nowOrder * (sum / linesFz.Capacity);
                        }
                    }

                    //从已分配的集合中删除等待重新分配订单数据
                    listOrder.ForEach(x => LineOrder.RemoveAll(y => y.LineName == x.LineName && y.Khdh == x.Khdh));

                    //将产能能不饱和的生产线聚合重新分配
                    LineOrder.AddRange(ScheduingOrder(lineUnSaturated, listOrder.ConvertAll(x => x.Khdh)));
                }

            }
            catch (Exception e)
            {
                throw;
            }
        }

        //根据产线和分配订单(检索其他产线的套装信息,优先并且必须包含在内)
        public List<LineOrderPool> ScheduingOrderUnion(List<TBasisLinesFz> lines, List<String> listOrder)
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

                    //当前已分配完产线的品类，
                    groupList.ForEach(y => categorysHaving.AddRange(lines.Find(x => x.LineName == y.Key).Categorys.Split(',').ToList()));

                    //除当前正在分配的产线类型
                    categorys.ForEach(x => categorysHaving.RemoveAll(y => y == x));
                    categorysHaving = categorysHaving.Distinct().ToList();

                    //怎么遍历出已有的订单套装
                    foreach (var order in lineOrders.FindAll(x => 1 == 1))
                    {
                        //判断产线产能是否饱和
                        if (lineOrders.FindAll(x => x.LineName == line.LineName).Sum(x => x.Num) >= line.Capacity)
                        {
                            break;
                        }

                        //如果同品类中已分配则不需要再次分配
                        foreach (var linesFz in lines.FindAll(x => x.Abbreviation == line.Abbreviation))
                        {
                            if (lineOrders.FindAll(x => x.Khdh == order.Khdh && x.LineName == linesFz.LineName).Count > 0)
                            {
                                continue;
                            }

                        }

                        //获取订单的明细信息（套装信息）
                        var ordermx = new Select().From<TBLDataOrdermx>().Where(TBLDataOrdermx.KhdhColumn).IsEqualTo(order.Khdh).ExecuteTypedList<TBLDataOrdermx>();

                        //遍历该订单下的所有明细
                        foreach (var dataOrdermx in ordermx)
                        {
                            //如果该订单符合该产线的品类
                            if (categorys.Contains(dataOrdermx.Fzfl.ToUpper()))
                            {
                                //分配订单 
                                lineOrders.Add(new LineOrderPool { Khdh = dataOrdermx.Khdh, LineName = line.LineName, Num = int.Parse(dataOrdermx.Ddsl.ToString()) });
                            }
                        }
                    }



                    //遍历订单池订单
                    foreach (var order in listOrder.FindAll(x => true))
                    {
                        //获取订单的明细信息（套装信息）
                        var ordermx = new Select().From<TBLDataOrdermx>().Where(TBLDataOrdermx.KhdhColumn).IsEqualTo(order).ExecuteTypedList<TBLDataOrdermx>();

                        //判断产线产能是否饱和
                        if (lineOrders.FindAll(x => x.LineName == line.LineName).Sum(x => x.Num) >= line.Capacity)
                        {
                            break;
                        }

                        //如果当前时套装就踢出去，避免超出
                        var having = false;
                        ordermx.ForEach(x => having = categorysHaving.FindAll(y => y.ToLower() == x.Fzfl.ToLower()).Count > 0);
                        if (having)
                        {
                            continue;
                        }

                        //遍历该订单下的所有明细
                        foreach (var dataOrdermx in ordermx)
                        {
                            //如果该订单符合该产线的品类
                            if (categorys.Contains(dataOrdermx.Fzfl.ToUpper()))
                            {
                                //分配订单 
                                lineOrders.Add(new LineOrderPool { Khdh = dataOrdermx.Khdh, LineName = line.LineName, Num = int.Parse(dataOrdermx.Ddsl.ToString()) });

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
        public List<LineOrderPool> ScheduingOrder(List<TBasisLinesFz> lines, List<String> listOrder)
        {
            var lineOrders = new List<LineOrderPool>();
            try
            {
                //遍历当前产线分配订单
                foreach (var line in lines)
                {
                    //当前产线产能的所有品类
                    var categorys = line.Categorys.ToUpper().Split(',').ToList();

                    //怎么遍历出已有的订单套装？？

                    //遍历订单
                    foreach (var order in listOrder.FindAll(x => true))
                    {
                        //获取订单的明细信息（套装信息）
                        var ordermx = new Select().From<TBLDataOrdermx>().Where(TBLDataOrdermx.KhdhColumn).IsEqualTo(order).ExecuteTypedList<TBLDataOrdermx>();

                        //判断产线产能是否饱和
                        if (lineOrders.FindAll(x => x.LineName == line.LineName).Sum(x => x.Num) >= line.Capacity)
                        {
                            break;
                        }

                        //遍历该订单下的所有明细
                        foreach (var dataOrdermx in ordermx)
                        {
                            //如果该订单符合该产线的品类
                            if (categorys.Contains(dataOrdermx.Fzfl.ToUpper()))
                            {
                                //分配订单 
                                lineOrders.Add(new LineOrderPool { Khdh = dataOrdermx.Khdh, LineName = line.LineName, Num = int.Parse(dataOrdermx.Ddsl.ToString()) });

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

        //产线饱和后序算法
        public void FullScreen()
        {
            try
            {

            }
            catch (Exception e)
            {
                throw;
            }
        }

        //产线不饱和后续算法
        public void NotFullScreen()
        {
            try
            {

            }
            catch (Exception e)
            {
                throw;
            }
        }
    }
}
