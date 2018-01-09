using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
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
                    var orderListSql = new Select().From<TBLDataOrdermx>()
                        .InnerJoin(TBasisOrderStatus.CustomerIdColumn, TBLDataOrdermx.KhdhColumn)
                        .InnerJoin(TBLDataOrder.KhdhColumn, TBLDataOrdermx.KhdhColumn)
                        .Where(TBasisOrderStatus.OrderStatusColumn).IsEqualTo("103")
                        .And(TBLDataOrdermx.FzflColumn).IsEqualTo(category);
                    orderListSql.Paged(1, 2000);
                    orderListSql.OrderAsc(TBLDataOrder.JhrqColumn.ColumnName);
                    var orderList = orderListSql.ExecuteTypedList<TBLDataOrdermx>();

                    //去除还没有计划标注的订单
                    var mxObj = new Select().From<TAnalysisOrderMx>()
                        .Where(TAnalysisOrderMx.KhdhColumn).In(orderList.ConvertAll(x => x.Khdh))
                        .And(TAnalysisOrderMx.ScjhbzColumn).IsNull()
                        .ExecuteTypedList<TAnalysisOrderMx>();
                    mxObj.ForEach(x => orderList.RemoveAll(y => y.Khdh == x.Khdh));

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

                //待分配订单去除已分配订单
                LineOrder.ForEach(x => ListOrder.RemoveAll(y => y == x.Khdh));

                //订单分配后产能检测,产能不饱和记录List
                List<TBasisLinesFz> lineUnSaturated = new List<TBasisLinesFz>();
                foreach (var line in Lines)
                {
                    //订单不饱和
                    if (line.Capacity - LineOrder.FindAll(x => x.LineName == line.LineName).Sum(x => x.Num) > 5)
                    {
                        lineUnSaturated.Add(line);
                    }
                    else
                    {
                        //产线产能饱和的需要检测特殊订单
                        FullScreen(line);
                    }
                }

                //如果有产线的产能没有达到饱和
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

                //---LineOrder订单集合
                var linesName = LineOrder.GroupBy(x => x.LineName);

                foreach (var line in linesName)
                {
                    var num = LineOrder.FindAll(x => x.LineName == line.Key).Sum(x => x.Num);
                    Console.WriteLine($"{line.Key}:{num}");
                }

                var khdhNull = LineOrder.FindAll(x => x.Khdh == null);
                var numNull = LineOrder.FindAll(x => x.Khdh == null);
                var fzflNull = LineOrder.FindAll(x => x.Khdh == null);
                var lineNameNull = LineOrder.FindAll(x => x.Khdh == null);

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

                    //当前已分配完产线的品类
                    groupList.ForEach(y => categorysHaving.AddRange(lines.Find(x => x.LineName == y.Key).Categorys.Split(',').ToList()));

                    //除当前正在分配的产线类型
                    categorys.ForEach(x => categorysHaving.RemoveAll(y => y == x));
                    categorysHaving = categorysHaving.Distinct().ToList();

                    //遍历出已有的订单套装
                    foreach (var order in lineOrders.FindAll(x => true))
                    {
                        //判断产线产能是否饱和
                        if (lineOrders.FindAll(x => x.LineName == line.LineName).Sum(x => x.Num) >= line.Capacity)
                        {
                            break;
                        }

                        //如果同品类中已分配则不需要再次分配
                        bool having = false;
                        foreach (var linesFz in lines.FindAll(x => x.Abbreviation == line.Abbreviation))
                        {
                            if (lineOrders.FindAll(x => x.Khdh == order.Khdh && x.LineName == linesFz.LineName).Count > 0)
                            {
                                having = true;
                                break;
                            }

                        }

                        if (having)
                            continue;

                        //获取订单的明细信息（套装信息）
                        var ordermx = new Select().From<TBLDataOrdermx>().Where(TBLDataOrdermx.KhdhColumn).IsEqualTo(order.Khdh).ExecuteTypedList<TBLDataOrdermx>();

                        //遍历该订单下的所有明细
                        foreach (var dataOrdermx in ordermx)
                        {
                            //如果该订单符合该产线的品类
                            if (categorys.Contains(dataOrdermx.Fzfl.ToUpper()))
                            {
                                if (lineOrders.FindAll(x => x.Khdh == dataOrdermx.Khdh && x.Fzfl == dataOrdermx.Fzfl).Count > 0)
                                {
                                    Console.WriteLine($"数据重复,订单已分配。{dataOrdermx.Khdh}");
                                }

                                //分配订单 
                                lineOrders.Add(new LineOrderPool { Khdh = dataOrdermx.Khdh, LineName = line.LineName, Fzfl = dataOrdermx.Fzfl, Num = int.Parse(dataOrdermx.Ddsl.ToString()) });
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

                        //如果当前是套装并且包含已分配完产线的品类就踢出去，避免超出
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
                                lineOrders.Add(new LineOrderPool { Khdh = dataOrdermx.Khdh, LineName = line.LineName, Fzfl = dataOrdermx.Fzfl, Num = int.Parse(dataOrdermx.Ddsl.ToString()) });

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
                                lineOrders.Add(new LineOrderPool { Khdh = dataOrdermx.Khdh, LineName = line.LineName, Fzfl = dataOrdermx.Fzfl, Num = int.Parse(dataOrdermx.Ddsl.ToString()) });

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

        //产线筛选特殊订单 补正常订单后序算法
        public void FullScreen(TBasisLinesFz line)
        {
            try
            {
                //--当前筛选条件集合获取
                var restriction = new Select().From<TBasisLinesRestriction>()
                    .Where(TBasisLinesRestriction.LineNameColumn).IsEqualTo(line.LineName)
                    .ExecuteTypedList<TBasisLinesRestriction>();

                //--当前产线分配的订单
                var nowLineOrder = LineOrder.FindAll(x => x.LineName == line.LineName);

                //当前已有订单明细
                var mxList = new Select().From<TBLDataOrdermx>()
                    .Where(TBLDataOrdermx.KhdhColumn).In(nowLineOrder.ConvertAll(x => x.Khdh))
                    .ExecuteTypedList<TBLDataOrdermx>();

                //--筛选出来的订单集合
                List<LineOrderPool> outOrders = new List<LineOrderPool>();

                //---LineOrder
                //根据不同的规则筛选
                foreach (var linesRestriction in restriction)
                {
                    //当前的设限分类类型
                    var sXList = linesRestriction.Restriction.Split(',');

                    //当前的设限分类类型订单
                    List<TBLDataOrdermx> nowOutOrders = new List<TBLDataOrdermx>();

                    //-- MLWG 面料外观
                    if (linesRestriction.Identifies == "MLWG")
                    {
                        //匹配订单的面料外观
                        var waiGuanList = new Select(new string[] { TAnalysisOrderMx.KhdhColumn.ColumnName, TAnalysisOrderMx.ScjhbzColumn.ColumnName }).From<TAnalysisOrderMx>()
                            .Where(TAnalysisOrderMx.KhdhColumn).In(mxList.ConvertAll(x => x.Khdh))
                            .ExecuteTypedList<TAnalysisOrderMx>();

                        //查找符合当前面料外观的订单
                        var nowWg = waiGuanList.Distinct().ToList().FindAll(x => x.Scjhbz.ToUpper().Contains(linesRestriction.Restriction.ToUpper()));

                        //筛选当前的分类订单
                        nowWg.ForEach(x => nowOutOrders.AddRange(mxList.FindAll(y => y.Khdh == x.Khdh)));

                    }

                    //-- FZFL 服装分类
                    if (linesRestriction.Identifies == "FZFL")
                    {
                        //筛选当前的分类订单
                        sXList.ToList().ForEach(y => nowOutOrders.AddRange(mxList.FindAll(x => x.Fzfl == y)));
                    }

                    //-- GYXX 工艺信息
                    if (linesRestriction.Identifies == "GYXX")
                    {
                        //筛选当前的工艺订单
                        sXList.ToList().ForEach(y => nowOutOrders.AddRange(mxList.FindAll(x => x.Gyxx.ToLower().Contains(y.ToLower()))));
                    }

                    //-- MLBM 面料编码
                    if (linesRestriction.Identifies == "MLBM")
                    {
                        //筛选当前的工艺订单
                        sXList.ToList().ForEach(y => nowOutOrders.AddRange(mxList.FindAll(x => x.Mlbm == y)));
                    }

                    //-- GYLX 工艺类型
                    if (linesRestriction.Identifies == "GYLX")
                    {
                        sXList.ToList().ForEach(y => nowOutOrders.AddRange(mxList.FindAll(x => x.Gylx == y)));
                    }

                    //标准设限，如允许有出入 则修改判断的值就可以了
                    var outNum = nowOutOrders.Sum(x => x.Ddsl) - linesRestriction.Capacity;
                    if (outNum > 0)
                    {
                        RemoveOrder(nowOutOrders, outOrders, line, nowLineOrder, (int)outNum);
                    }

                }

                if (outOrders.Count < 2)
                {
                    return;
                }

                //将多余的特殊订单替换成正常的订单
                var replaceOrder = AlternateOrders(outOrders);
                foreach (var key in replaceOrder)
                {
                    //替补订单的明细
                    var replaceOrderMx = new Select()
                        .From<TBLDataOrdermx>()
                        .Where(TBLDataOrdermx.KhdhColumn).IsEqualTo(key.Value)
                        .ExecuteTypedList<TBLDataOrdermx>();

                    //循环替补订单信息 替换掉原有的订单
                    foreach (var ordermx in replaceOrderMx)
                    {
                        //根据原有订单的客户单号和现有的服装大类匹配出将要被替换的订单
                        var order = LineOrder.Find(x => x.Khdh == key.Key && x.Fzfl == ordermx.Fzfl);

                        //将替补订单添加到集合
                        LineOrder.Add(new LineOrderPool { Fzfl = ordermx.Fzfl, Khdh = ordermx.Khdh, LineName = order.LineName, Num = int.Parse(ordermx.Ddsl.ToString()) });

                        //去除原有订单
                        LineOrder.RemoveAll(x => x.Khdh == key.Key && x.Fzfl == ordermx.Fzfl);
                    }
                }


                FullScreen(line);

            }
            catch (Exception e)
            {
                throw;
            }
        }

        /// <summary>
        /// 特殊订单超出后删减订单
        /// </summary>
        /// <param name="nowOutOrders">当前的特殊类型订单集合</param>
        /// <param name="outOrders">超出的订单集合</param>
        /// <param name="line">当前产线对象</param>
        /// <param name="nowLineOrder">当前产线已分配的订单</param>
        /// <param name="outNum">超出的数量</param>
        public void RemoveOrder(List<TBLDataOrdermx> nowOutOrders, List<LineOrderPool> outOrders, TBasisLinesFz line, List<LineOrderPool> nowLineOrder, int outNum)
        {
            try
            {
                //查询订单信息获取交期排序，筛掉超出的订单
                var order = new Select().From<TBLDataOrder>().Where(TBLDataOrder.KhdhColumn)
                    .In(nowOutOrders.ConvertAll(x => x.Khdh))
                    .ExecuteTypedList<TBLDataOrder>();

                order = order.OrderByDescending(x => x.Jhrq).ToList();
                foreach (var dataOrder in order)
                {
                    outOrders.Add(
                        new LineOrderPool
                        {
                            Khdh = dataOrder.Khdh,
                            LineName = line.LineName,
                            Num = nowLineOrder.FindAll(x => x.Khdh == dataOrder.Khdh).Sum(x => x.Num)
                        });
                    //如果挑出来的数量和超出的数量一致则结束筛选
                    if (outOrders.Sum(x => x.Num) == outNum)
                    {
                        break;
                    }
                    //如果跳出来的订单大于超出的数量，挑多了，那就去掉上一个订单并结束筛选
                    else if (outOrders.Sum(x => x.Num) > outNum)
                    {
                        outOrders.RemoveAll(x => x.Khdh == dataOrder.Khdh);
                        break;
                    }
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        /// <summary>
        /// 特殊订单超出后，替换正常订单
        /// </summary>
        public Dictionary<string, string> AlternateOrders(List<LineOrderPool> outOrders)
        {
            try
            {
                //订单替换对照  key：被替换  value 替补订单
                Dictionary<string, string> replaceOrder = new Dictionary<string, string>();


                //--ListOrder 订单集合
                var listOrder = new Select().From<TBLDataOrder>()
                    .Where(TBLDataOrder.KhdhColumn).In(ListOrder)
                    .ExecuteTypedList<TBLDataOrder>();

                foreach (var order in outOrders)
                {
                    //等待被替换的订单明细
                    var orderMain = new Select().From<TBLDataOrder>()
                        .Where(TBLDataOrder.KhdhColumn).IsEqualTo(order.Khdh)
                        .ExecuteTypedList<TBLDataOrder>()
                        .FirstOrDefault();

                    //但品类订单集合
                    var orderOne = new List<TBLDataOrder>();

                    //按照单品类查找订单
                    orderMain?.Sldl.Split('+').ToList().ForEach(x => orderOne.Add(listOrder.OrderBy(y => y.Jhrq).ToList().Find(y => y.Sldl == orderMain?.Sldl)));

                    //查找配套方式一致的订单
                    var ptOrder = listOrder.OrderBy(x => x.Jhrq).ToList().Find(x => x.Sldl == orderMain?.Sldl);

                    #region 按照交期 匹配用单品类替换或 配套

                    //多条件 模拟规则挑选优先于那一类筛选
                    if (orderOne.Count != orderMain?.Sldl.Split('+').Length)
                    {//如果 单品里替换 匹配不成功 就依照 配套来
                        replaceOrder.Add(order.Khdh, ptOrder.Khdh);
                    }
                    if (ptOrder == null)
                    {//如果 配套里替换 匹配不成功 就依照单品来
                     /**可能有问题的  疑问点
                      * ??????????????????????????????????????????????????????????
                      * 如果套装替换成单品 那么对应的 产线里分配的订单应该怎么去匹配？？                         * 
                      * 解决方案 0.0.0.1：
                      * 已分配订单集合增加服装分类字段，对应替换（嘛来个比，操蛋的规则）
                      **/

                        orderOne.ForEach(x => replaceOrder.Add(order.Khdh, x.Khdh));
                    }
                    else if (orderOne.OrderBy(x => x.Jhrq).First().Jhrq < ptOrder.Jhrq)
                    {//比较如果 单品类 交期靠前
                        //???????????????????
                        //如果套装替换成单品 那么对应的 产线里分配的订单应该怎么去匹配？？
                        orderOne.ForEach(x => replaceOrder.Add(order.Khdh, x.Khdh));
                    }
                    else if (orderOne.OrderBy(x => x.Jhrq).First().Jhrq > ptOrder.Jhrq)
                    {//比较如果 配套方式一致类 交期靠前
                        replaceOrder.Add(order.Khdh, ptOrder.Khdh);
                    }
                    #endregion  

                }

                return replaceOrder;

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

    }
}
