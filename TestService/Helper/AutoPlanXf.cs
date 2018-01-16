using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI.WebControls;
using Model;
using SubSonic;
using SubSonic.Extensions;
using TestService.ModelsOther;

namespace TestService.Helper
{
    public class AutoPlanXf
    {

        public List<string> ListOrder { get; set; }
        public List<TBasisLinesFz> Lines { get; set; }
        public List<LineOrderPool> LineOrder { get; set; }
        public List<string> ListXjOrder { get; set; }
        public List<string> AllCategorys { get; set; }
        public List<VErpOrderXf> ErpOrder { get; set; }

        /// <summary>
        ///     构造函数，初始化三大集合
        /// </summary>
        public AutoPlanXf()
        {
            ListOrder = new List<string>();
            Lines = new List<TBasisLinesFz>();
            LineOrder = new List<LineOrderPool>();
            ListXjOrder = new List<string>();
            AllCategorys = new List<string>();
            ErpOrder = new List<VErpOrderXf>();
        }

        /// <summary>
        ///     筛选订单
        /// </summary>
        public void OrderScreen()
        {
            try
            {
                var lines = new Select().From<TBasisLinesFz>()
                    .Where(TBasisLinesFz.LineTypeColumn).IsEqualTo("XF")
                    .ExecuteTypedList<TBasisLinesFz>();

                //当前车间的产能品类
                foreach (var categorys in lines.ConvertAll(x => x.Categorys))
                {
                    var nowCategorys = categorys.Split(',');
                    foreach (var category in nowCategorys)
                        if (!AllCategorys.Contains(category))
                            AllCategorys.Add(category);
                }

                //当前车间的产线
                ErpOrder = new Select().From<VErpOrderXf>().ExecuteTypedList<VErpOrderXf>();

                ErpOrder.RemoveAll(x => string.IsNullOrEmpty(x.Jqts));

                //线上加急订单
                ListXjOrder.AddRange(ErpOrder.FindAll(x => x.Jqts == "6").ConvertAll(x => x.Khdh));
                ErpOrder.RemoveAll(x => x.Jqts == "6");

                //先将多余的裙子和马甲过滤出去
                var orderData = RemoveC_DMore(ErpOrder,
                    lines.FindAll(x => x.Abbreviation == "C" || x.Abbreviation == "D"));

                //将马甲线和裙子线删掉（不考虑）
                var maQun = lines.FindAll(x => x.Abbreviation == "C" || x.Abbreviation == "D");
                lines.RemoveAll(x => x.Abbreviation == "C" || x.Abbreviation == "D");

                //订单池数据
                foreach (var category in AllCategorys)
                {
                    //前期使用ERP数据源关联自有数据，原因：已生成计划订单不明确
                    var orderList = ErpOrder.FindAll(x => x.Fzfl == category);

                    //每个品类每次只取1000条就够了
                    if (orderList.Count > 1000)
                        orderList = orderList.OrderBy(x => x.Jhrq).Take(1000).ToList();
                    //自有数据源
                    //var orderListSql = new Select().From<TBLDataOrdermx>()
                    //    .InnerJoin(TBasisOrderStatus.CustomerIdColumn, TBLDataOrdermx.KhdhColumn)
                    //    .InnerJoin(TBLDataOrder.OrderidColumn, TBLDataOrdermx.OrderidColumn)
                    //    .Where(TBasisOrderStatus.OrderStatusColumn).IsEqualTo("103")
                    //    .And(TBLDataOrdermx.FzflColumn).IsEqualTo(category);
                    //orderListSql.Paged(1, 2000);
                    //orderListSql.OrderAsc(TBLDataOrder.JhrqColumn.ColumnName);
                    //var orderList = orderListSql.ExecuteTypedList<TBLDataOrdermx>();


                    //去除还没有计划标注的订单
                    var mxObj = new Select().From<TAnalysisOrderMx>()
                        .Where(TAnalysisOrderMx.KhdhColumn).In(orderList.ConvertAll(x => x.Khdh))
                        .And(TAnalysisOrderMx.ScjhbzColumn).IsNull()
                        .ExecuteTypedList<TAnalysisOrderMx>();

                    mxObj.ForEach(x => orderList.RemoveAll(y => y.Khdh == x.Khdh));

                    ListOrder.AddRange(orderList.ConvertAll(x => x.Khdh));
                }

                //添加的订单明细客户单号去重
                ListOrder = ListOrder.Distinct().ToList();


                //产线产能倒序(同品类要在一起) 
                var lineCapacity = new Dictionary<string, int>();
                foreach (var key in lines.GroupBy(x => x.Abbreviation).ToList())
                    lineCapacity.Add(key.Key,
                        int.Parse(lines.FindAll(x => x.Abbreviation == key.Key).Sum(x => x.Capacity).ToString()));
                var objlist = lineCapacity.OrderBy(x => x.Value).ToList();
                objlist.ForEach(
                    x => Lines.AddRange(lines.FindAll(y => y.Abbreviation == x.Key).OrderBy(y => y.Capacity)));

                //分配订单算法--初步分配
                LineOrder = ScheduingOrderUnion(Lines, ListOrder);

                //待分配订单去除已分配订单
                LineOrder.ForEach(x => ListOrder.RemoveAll(y => y == x.Khdh));


                lines.ForEach(x => Console.WriteLine(x.LineName + "::" + LineOrder.FindAll(y => y.LineName == x.LineName).Sum(y => y.Num)));


                //订单分配后产能检测,产能不饱和记录List
                var lineUnSaturated = new List<TBasisLinesFz>();

                //产线品类分组  检测是否饱和
                foreach (var liner in Lines.GroupBy(x => x.Abbreviation))
                {
                    var baohe = true;
                    //按照同品类的订单检测是否饱和
                    foreach (var line in Lines.FindAll(x => x.Abbreviation == liner.Key))
                        //订单不饱和
                        if (line.Capacity - LineOrder.FindAll(x => x.LineName == line.LineName).Sum(x => x.Num) > 5)
                        {
                            lineUnSaturated.Add(line);
                            baohe = false;
                        }

                    //如果品类订单全部饱和则 进行特殊订单检测
                    if (baohe)
                        Lines.FindAll(x => x.Abbreviation == liner.Key).ForEach(FullScreen);
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
                            /**
                                 * 公式计算规则
                                 * 现有同品类数量总和 * （所有同品类的总和/当前产线的所需数量）
                                 * **/
                            linesFz.Capacity = nowOrder * (sum / linesFz.Capacity);
                    }

                    //从已分配的集合中删除等待重新分配订单数据
                    listOrder.ForEach(
                        x => LineOrder.RemoveAll(y => y.LineName == x.LineName && y.Khdh == x.Khdh));

                    //将产能能不饱和的生产线聚合重新分配
                    LineOrder.AddRange(ScheduingOrder(lineUnSaturated, listOrder.ConvertAll(x => x.Khdh)));
                }

                //重新计算需要补单裙子和马甲
                foreach (var linesFz in maQun)
                {
                    linesFz.Capacity = linesFz.Capacity - LineOrder.FindAll(x => x.LineName == linesFz.LineName)
                                           .Sum(x => x.Num);
                }

                //最后分配马甲和裙子线(不能包含上衣和裤子)
                LineOrder.ForEach(x => orderData.RemoveAll(y => y.Khdh == x.Khdh));
                var maQunList = orderData.FindAll(x => x.Fzfl == "MMJ" || x.Fzfl == "TMJ" || x.Fzfl == "WMJ" || x.Fzfl == "WXQ");
                maQunList.RemoveAll(x => x.Sldl.ToUpper().Contains("W") || x.Sldl.ToUpper().Contains("E") || x.Sldl.ToUpper().Contains("K")
                                         || x.Sldl.ToUpper().Contains("A") || x.Sldl.ToUpper().Contains("B") || x.Sldl.ToUpper().Contains("W"));

                //订单分配  
                LineOrder.AddRange(ScheduingOrderUnion(maQun, maQunList.ConvertAll(x => x.Khdh)));

                //---LineOrder订单集合
                var linesName = LineOrder.GroupBy(x => x.LineName);

                foreach (var line in linesName)
                {
                    var num = LineOrder.FindAll(x => x.LineName == line.Key).Sum(x => x.Num);
                    Console.WriteLine($"{line.Key}:{num}");
                }

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
            }
            catch (Exception e)
            {
                throw;
            }
        }

        //根据产线和分配订单(检索其他产线的套装信息,优先并且必须包含在内)
        public List<LineOrderPool> ScheduingOrderUnion(List<TBasisLinesFz> lines,
            List<string> listOrder)
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

                    //遍历订单池订单
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

                        //如果当前是套装并且包含已分配完产线的品类就踢出去，避免超出
                        var having = false;
                        ordermx.ForEach(x => having =
                            categorysHaving.FindAll(y => y.ToLower() == x.Fzfl.ToLower()).Count >
                            0);
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

        //产线筛选特殊订单 补正常订单后序算法
        public void FullScreen(TBasisLinesFz line)
        {
            try
            {
                int forCount = 0;

                //--当前筛选条件集合获取
                Label: var restriction = new Select().From<TBasisLinesRestriction>()
                     .Where(TBasisLinesRestriction.LineNameColumn).IsEqualTo(line.LineName)
                     .ExecuteTypedList<TBasisLinesRestriction>();

                //--当前产线分配的订单
                var nowLineOrder = LineOrder.FindAll(x => x.LineName == line.LineName);

                //当前已有订单明细
                var mxList = new Select().From<TBLDataOrdermx>()
                    .Where(TBLDataOrdermx.KhdhColumn).In(nowLineOrder.ConvertAll(x => x.Khdh))
                    .ExecuteTypedList<TBLDataOrdermx>();

                //--筛选出来的订单集合
                var outOrders = new List<LineOrderPool>();

                //---LineOrder
                //根据不同的规则筛选
                foreach (var linesRestriction in restriction)
                {
                    //当前的设限分类类型
                    var sXList = linesRestriction.Restriction.Split(',');

                    //当前的设限分类类型订单
                    var nowOutOrders = new List<TBLDataOrdermx>();

                    //-- MLWG 面料外观
                    if (linesRestriction.Identifies == "MLWG")
                    {
                        //匹配订单的面料外观
                        var waiGuanList =
                            new Select(TAnalysisOrderMx.KhdhColumn.ColumnName,
                                    TAnalysisOrderMx.ScjhbzColumn.ColumnName)
                                .From<TAnalysisOrderMx>()
                                .Where(TAnalysisOrderMx.KhdhColumn)
                                .In(mxList.ConvertAll(x => x.Khdh))
                                .ExecuteTypedList<TAnalysisOrderMx>();

                        //查找符合当前面料外观的订单
                        var nowWg = waiGuanList.Distinct().ToList()
                            .FindAll(x => x.Scjhbz.ToUpper()
                                .Contains(linesRestriction.Restriction.ToUpper()));

                        //筛选当前的分类订单
                        nowWg.ForEach(
                            x => nowOutOrders.AddRange(mxList.FindAll(y => y.Khdh == x.Khdh)));
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
                    var outNum = nowOutOrders.Sum(x => x.Ddsl) - linesRestriction.Capacity;
                    if (outNum > 0)
                        RemoveOrder(nowOutOrders, outOrders, line, nowLineOrder, (int)outNum);
                }



                var orders = new Select().From<TBLDataOrdermx>()
                    .InnerJoin(TBLDataOrder.OrderidColumn, TBLDataOrdermx.OrderidColumn)
                    .Where(TBLDataOrder.KhdhColumn).In(ListOrder.Take(1000).ToList())
                    .OrderAsc(TBLDataOrder.JhrqColumn.ColumnName)
                    .ExecuteTypedList<TBLDataOrdermx>();

                var nCount = outOrders.Sum(x => x.Num); //---需要替补的数量
                var num = 0; //--已经替补的数量
                foreach (var order in orders)
                {
                    //如果替换数量和被替换订单的数量一致就跳出   替换完毕
                    if (num == nCount || num + order.Num == nCount)
                        break;

                    //如果是上衣超限，替换时可以不考虑裤子
                    if (line.Abbreviation == "F")
                    {
                        //如果改产线的订单大类包含此订单的大类说明可以分配
                        if (line.Categorys.Contains(order.Fzfl))
                        {
                            //添加到分配订单集合
                            LineOrder.Add(
                                new LineOrderPool
                                {
                                    Fzfl = order.Fzfl,
                                    Khdh = order.Khdh,
                                    LineName = line.LineName,
                                    Num = int.Parse(order.Ddsl.ToString())
                                });

                            //记录被替换的数量
                            num += int.Parse(order.Ddsl.ToString());
                        }
                    }
                    else //如果是裤子超限，替换时套装包含上衣，否则就超限了）
                    {
                        if (orders.FindAll(x => x.Orderid == order.Orderid).Count > 1)
                        {
                            //检测是否包含上衣大类
                            var fzfl = orders.FindAll(x => x.Orderid == order.Orderid)
                                .FindAll(x => x.Fzfl == "MDY" || x.Fzfl == "MJK" ||
                                              x.Fzfl == "MLF" || x.Fzfl == "MMJ" || x.Fzfl == "MXF"
                                              || x.Fzfl == "TDY" || x.Fzfl == "TMJ" ||
                                              x.Fzfl == "TXF" || x.Fzfl == "WDY" || x.Fzfl == "WMJ"
                                              || x.Fzfl == "WXF" || x.Fzfl == "XXF" ||
                                              x.Fzfl == "MFL" || x.Fzfl == "WFL" || x.Fzfl == "MFS"
                                              || x.Fzfl == "WFS" || x.Fzfl == "QMF");

                            if (fzfl.Count > 0)
                                continue;
                        }
                        //如果改产线的订单大类包含此订单的大类说明可以分配
                        if (line.Categorys.Contains(order.Fzfl))
                        {
                            //添加到分配订单集合
                            LineOrder.Add(
                                new LineOrderPool
                                {
                                    Fzfl = order.Fzfl,
                                    Khdh = order.Khdh,
                                    LineName = line.LineName,
                                    Num = int.Parse(order.Ddsl.ToString())
                                });

                            //记录被替换的数量
                            num += int.Parse(order.Ddsl.ToString());
                        }
                    }
                }


                //将被替换的订单重新加到订单池中
                outOrders.ConvertAll(x => x.Khdh).Distinct().ToList().ForEach(x => ListOrder.Add(x));

                //将已替换的订单从订单池中移除
                LineOrder.ForEach(x => ListOrder.RemoveAll(y => y == x.Khdh));
                forCount++;

                //重新检测  重复五遍检测 排除特殊订单
                if (forCount <= 5 && outOrders.Count > 1)
                    goto Label;
            }
            catch (Exception e)
            {
                throw;
            }
        }

        /// <summary>
        ///     特殊订单超出后删减订单
        /// </summary>
        /// <param name="nowOutOrders">当前的特殊类型订单集合</param>
        /// <param name="outOrders">超出的订单集合</param>
        /// <param name="line">当前产线对象</param>
        /// <param name="nowLineOrder">当前产线已分配的订单</param>
        /// <param name="outNum">超出的数量</param>
        public void RemoveOrder(List<TBLDataOrdermx> nowOutOrders, List<LineOrderPool> outOrders,
            TBasisLinesFz line, List<LineOrderPool> nowLineOrder, int outNum)
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
                            Num = nowLineOrder.FindAll(x => x.Khdh == dataOrder.Khdh)
                                .Sum(x => x.Num)
                        });
                    //如果挑出来的数量和超出的数量一致则结束筛选
                    if (outOrders.Sum(x => x.Num) == outNum)
                        break;
                    //如果跳出来的订单大于超出的数量，挑多了，那就去掉上一个订单并结束筛选
                    if (outOrders.Sum(x => x.Num) > outNum)
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

        public List<VErpOrderXf> RemoveC_DMore(List<VErpOrderXf> orders, List<TBasisLinesFz> lins)
        {
            var orderList = new List<VErpOrderXf>();
            try
            {
                //备份原数据传出
                orders.CopyTo(orderList);

                var rMore = new List<string>();
                var cCount = lins.FindAll(x => x.Abbreviation == "C").Sum(x => x.Capacity);
                var dCount = lins.FindAll(x => x.Abbreviation == "D").Sum(x => x.Capacity);

                var cNum = 0;
                var dNum = 0;

                foreach (var order in orders.FindAll(
                    x => x.Sldl.Contains("C") || x.Sldl.Contains("D")))
                {
                    if (cNum >= cCount || dNum >= dCount)
                        rMore.Add(order.Khdh);

                    if (order.Sldl.Contains("C"))
                        cNum += int.Parse(order.Ddsl.ToString());
                    if (order.Sldl.Contains("D"))
                        dNum += int.Parse(order.Ddsl.ToString());
                }
                rMore.Distinct().ToList().ForEach(x => orders.RemoveAll(y => y.Khdh == x));
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return orderList;
        }

    }
}