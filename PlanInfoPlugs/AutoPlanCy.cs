using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Newtonsoft.Json;
using ServiceHandle.Helper;
using ServiceHelper;
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
        public List<VOrderDatapoolCy> ListXj3Order { get; set; }
        public List<VOrderDatapoolCy> ListPjOrder { get; set; }
        public List<VOrderDatapoolCy> ListTestOrder { get; set; }

        public AutoPlanCy()
        {
            ListOrder = new List<string>();
            ListXjOrder = new List<VOrderDatapoolCy>();
            ListPjOrder = new List<VOrderDatapoolCy>();
            Lines = new Select().From<TBasisLinesFz>().Where(TBasisLinesFz.LineTypeColumn).IsEqualTo("CY").ExecuteTypedList<TBasisLinesFz>();
            Restriction = new Select().From<TBasisLinesRestriction>().ExecuteTypedList<TBasisLinesRestriction>();
            OrderDatapool = new Select().From<VOrderDatapoolCy>().ExecuteTypedList<VOrderDatapoolCy>();
            LineOrder = new List<LineOrderPool>();
            ListTestOrder = new List<VOrderDatapoolCy>();
            ListXj3Order = new List<VOrderDatapoolCy>();
        }

        public string OrderScreen(DateTime beginTime)
        {
            try
            {
                //按照交期排序
                OrderDatapool = OrderDatapool.OrderBy(x => x.Jhrq).ToList();

                //移除还没有计划标注的
                OrderDatapool.RemoveAll(x => string.IsNullOrEmpty(x.Scjhbz) || x.Scjhbz.Contains("未"));

                #region 按照订单类型提取订单


                //配件
                ListPjOrder.AddRange(OrderDatapool.FindAll(x => x.Fzfl == "P0"));
                OrderDatapool.RemoveAll(x => x.Fzfl == "P0");

                //测试订单
                ListTestOrder.AddRange(OrderDatapool.FindAll(x => x.Khdh.ToUpper().IndexOf("JJJ", StringComparison.Ordinal) == 0 || x.Khdh.ToUpper().IndexOf("TEST", StringComparison.Ordinal) == 0 || x.Khdh.ToUpper().IndexOf("XXX", StringComparison.Ordinal) == 0));

                OrderDatapool.RemoveAll(x => x.Khdh.ToUpper().IndexOf("JJJ", StringComparison.Ordinal) == 0 || x.Khdh.ToUpper().IndexOf("TEST", StringComparison.Ordinal) == 0 || x.Khdh.ToUpper().IndexOf("XXX", StringComparison.Ordinal) == 0);

                //线上加急订单5/6天
                ListXjOrder.AddRange(OrderDatapool.FindAll(x => x.Jqts == "6"));
                ListXjOrder.AddRange(OrderDatapool.FindAll(x => x.Jqts == "5"));
                OrderDatapool.RemoveAll(x => x.Jqts == "6" || x.Jqts == "5");

                //线上 加急3天得订单
                ListXj3Order.AddRange(OrderDatapool.FindAll(x => x.Jqts == "3"));
                OrderDatapool.RemoveAll(x => x.Jqts == "3");

                #endregion

                #region 订单初次分配

                var orders = new List<VOrderDatapoolCy>();

                //优化数据量支取按照交期排序的前500条订单 
                var orderList = OrderDatapool.OrderBy(x => x.Jhrq).Take(2000).ToList();

                orders.AddRange(orderList);
                OrderDatapool.Clear();
                OrderDatapool.AddRange(orders);

                //添加的订单客户单号去重
                ListOrder.AddRange(orders.OrderBy(x => x.Jhrq).ToList().ConvertAll(x => x.Khdh).Distinct());

                //分配订单算法--初步分配
                LineOrder = ScheduingOrder(Lines, ListOrder);

                //待分配订单去除已分配订单
                LineOrder.ForEach(x => ListOrder.RemoveAll(y => y == x.Khdh));

                #endregion

                #region 检测产线本次分配的饱和度，如不饱和则按照现有数量计算比例重新分配

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
                    LineOrder.AddRange(ScheduingOrder(lineUnSaturated, listOrder.ConvertAll(x => x.Khdh)));

                    //将全局的产线信息更新
                    Lines = lineUnSaturated;
                }

                #endregion

                #region 加胶条/免烫订单产线平均分配

                //最终分完后将免烫订单和夹胶条的2/6，平分
                var gyxxOrder = new Select("khdh,ddsl,gyxx").From<TBLDataOrdermx>()
                    .Where(TBLDataOrdermx.KhdhColumn).In(LineOrder.Where(x => x.LineName == "衬衣缝制2" || x.LineName == "衬衣缝制6").ToList().ConvertAll(x => x.Khdh))
                    .ExecuteTypedList<TBLDataOrdermx>();
                //加胶条，免烫，高级免烫5B42 58U1 58U2
                var gjmtList = gyxxOrder.Where(x => x.Gyxx.Contains("5B42") ||
                                                    x.Gyxx.Contains("9357") ||
                                                    x.Gyxx.Contains("58U1") ||
                                                    x.Gyxx.Contains("58U2")
                                              ).ToList();

                var puList = gyxxOrder.Where(x => !x.Gyxx.Contains("5B42") &&
                                                !x.Gyxx.Contains("9357") &&
                                                !x.Gyxx.Contains("58U1") &&
                                                !x.Gyxx.Contains("58U2")
                                             ).ToList();

                //只有特殊类型订单大于3件时再平分
                if (gjmtList.Sum(x => x.Ddsl) > 3)
                {

                    //清除掉产线分配的订单
                    LineOrder.RemoveAll(x => x.LineName == "衬衣缝制2" || x.LineName == "衬衣缝制6");

                    //按平均分配加胶条，免烫订单
                    var mtLines = new List<TBasisLinesFz>
                    {
                        new TBasisLinesFz{LineName = "衬衣缝制2",Capacity = int.Parse((gjmtList.Sum(x=>x.Ddsl)/2).ToString()),LineNumber =2,LineType = "CY",Categorys = "MCY,WCY",Abbreviation = "2"},
                        new TBasisLinesFz{LineName = "衬衣缝制6",Capacity = gjmtList.Sum(x=>x.Ddsl)-int.Parse((gjmtList.Sum(x=>x.Ddsl)/2).ToString()),LineNumber =6,LineType = "CY",Categorys = "MCY,WCY",Abbreviation = "6"}
                    };
                    var gjmtFp = ScheduingOrder(mtLines, gjmtList.ConvertAll(x => x.Khdh));
                    LineOrder.AddRange(gjmtFp);

                    //按照之前的比例去重新分配正常的订单
                    foreach (var line in mtLines)
                    {
                        var capacity = Lines.Find(x => x.LineName == line.LineName).Capacity;
                        line.Capacity = capacity - gjmtFp.Where(x => x.LineName == line.LineName).Sum(x => x.Num);
                    }
                    var zcFp = ScheduingOrder(mtLines, puList.ConvertAll(x => x.Khdh));
                    LineOrder.AddRange(zcFp);
                }

                #endregion

                #region 配件分配

                var gyxxP0Order = new Select("khdh,ddsl,gyxx").From<TBLDataOrdermx>()
                    .Where(TBLDataOrdermx.KhdhColumn).In(ListPjOrder.ConvertAll(x => x.Khdh))
                    .ExecuteTypedList<TBLDataOrdermx>();

                //加胶条，免烫，高级免烫5B42 58U1 58U2
                var gjmtP0List = gyxxP0Order.Where(x => x.Gyxx.Contains("5B42") ||
                                                        x.Gyxx.Contains("58U1") ||
                                                        x.Gyxx.Contains("9357") ||
                                                        x.Gyxx.Contains("58U2")
                                                    ).ToList();

                var puP0List = gyxxP0Order.Where(x => !x.Gyxx.Contains("5B42") &&
                                                    !x.Gyxx.Contains("58U1") &&
                                                    !x.Gyxx.Contains("9357") &&
                                                    !x.Gyxx.Contains("58U2")
                                                ).ToList();

                //分配全部的正常配件给1
                puP0List.ForEach(x => LineOrder.Add(new LineOrderPool { Khdh = x.Khdh, Fzfl = x.Fzfl, LineName = "衬衣缝制1", Num = int.Parse(x.Ddsl.ToString()) }));

                if (gyxxP0Order.Count > 2)
                {
                    var mtpjLines = new List<TBasisLinesFz>
                    {
                        new TBasisLinesFz
                        {
                            LineName = "衬衣缝制2",
                            Capacity = gyxxP0Order.Sum(x => x.Ddsl)-int.Parse((gyxxP0Order.Sum(x => x.Ddsl) / 2).ToString()),
                            LineNumber = 2,
                            LineType = "CY",
                            Categorys = "MCY,WCY,P0",
                            Abbreviation = "2"
                        },
                        new TBasisLinesFz
                        {
                            LineName = "衬衣缝制6",
                            Capacity = int.Parse((gyxxP0Order.Sum(x => x.Ddsl) / 2).ToString()),
                            LineNumber = 6,
                            LineType = "CY",
                            Categorys = "MCY,WCY,P0",
                            Abbreviation = "6"
                        }
                    };

                    //分配特殊订单给2，6
                    var pjFp = ScheduingOrder(mtpjLines, gjmtP0List.ConvertAll(x => x.Khdh));
                    LineOrder.AddRange(pjFp);
                }
                else
                {
                    var lineName = DateTime.Now.Hour % 2 > 0 ? "衬衣缝制6" : "衬衣缝制2";

                    puP0List.ForEach(x => LineOrder.Add(new LineOrderPool { Khdh = x.Khdh, Fzfl = x.Fzfl, LineName = lineName, Num = int.Parse(x.Ddsl.ToString()) }));

                    ListXjOrder.ForEach(x => LineOrder.Add(new LineOrderPool { Khdh = x.Khdh, Fzfl = x.Fzfl, LineName = lineName, Num = int.Parse(x.Ddsl.ToString()) }));

                }



                #endregion

                #region 测试订单分配
                ListTestOrder.ForEach(x => LineOrder.Add(new LineOrderPool { Khdh = x.Khdh, Fzfl = x.Fzfl, LineName = "样品班", Num = int.Parse(x.Ddsl.ToString()) }));
                #endregion

                #region 线上加急3天得分配
                ListXj3Order.ForEach(x => LineOrder.Add(new LineOrderPool { Khdh = x.Khdh, Fzfl = x.Fzfl, LineName = "样品班", Num = int.Parse(x.Ddsl.ToString()) }));
                #endregion

                return new CreatePlanNo(LineOrder, OrderDatapool, beginTime).AutoPlanNo();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public List<LineOrderPool> ScheduingOrder(List<TBasisLinesFz> lines, List<string> listOrder)
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

    public class CreatePlanNo
    {
        public List<LineOrderPool> LineOrder { get; set; }
        public List<TBLDataOrder> DataOrder { get; set; }
        public List<TBLDataOrdermx> DataOrderMx { get; set; }
        public List<TAnalysisOrderMx> OrderAnalyMx { get; set; }
        public List<VOrderDatapoolCy> OrderDatapool { get; set; }
        public DateTime BeginTime { get; set; }
        public List<TWorkTimeShirt> WorkTimes { get; set; }
        public List<TBasisLinesFz> Lines { get; set; }


        //构造函数，初始化集合
        public CreatePlanNo(List<LineOrderPool> lineOrder, List<VOrderDatapoolCy> orderDatapool, DateTime beginTime)
        {
            //初始化数据DateTime 
            BeginTime = beginTime;
            OrderDatapool = orderDatapool;
            LineOrder = lineOrder;
            WorkTimes = new Select().From<TWorkTimeShirt>().OrderAsc(TWorkTimeShirt.WorktimeColumn.ColumnName).Where(TWorkTimeShirt.WorktimeColumn).IsBetweenAnd(beginTime, beginTime.AddDays(30)).ExecuteTypedList<TWorkTimeShirt>();
            DataOrder = new Select().From<TBLDataOrder>().Where(TBLDataOrder.KhdhColumn).In(lineOrder.ConvertAll(x => x.Khdh)).ExecuteTypedList<TBLDataOrder>();
            DataOrderMx = new Select().From<TBLDataOrdermx>().Where(TBLDataOrdermx.KhdhColumn).In(lineOrder.ConvertAll(x => x.Khdh)).ExecuteTypedList<TBLDataOrdermx>();
            OrderAnalyMx = new Select().From<TAnalysisOrderMx>().Where(TAnalysisOrderMx.KhdhColumn).In(lineOrder.ConvertAll(x => x.Khdh)).ExecuteTypedList<TAnalysisOrderMx>();
            Lines = new Select().From<TBasisLinesFz>().ExecuteTypedList<TBasisLinesFz>();

        }

        public string AutoPlanNo()
        {

            OrderAnalyMx.ForEach(x => x.Scjhbz.Replace("绘纸皮/", "MTM/"));

            //数据库中得最大计划号
            var xmbh = new Select(SCT27.SczsbhColumn).From<SCT27>().Where(SCT27.SczsbhColumn).Like($"CM{DateTime.Now.ToString("yyMM")}%").OrderDesc(SCT27.SczsbhColumn.ColumnName).ExecuteScalar();//国外
            var xsbh = new Select(SCT27.SczsbhColumn).From<SCT27>().Where(SCT27.SczsbhColumn).Like($"CS{DateTime.Now.ToString("yyMM")}%").OrderDesc(SCT27.SczsbhColumn.ColumnName).ExecuteScalar();//国内 

            var xmbhNum = xmbh == null ? int.Parse(DateTime.Now.ToString("yyMM") + "0000") : int.Parse(xmbh.ToString().Replace("CM", ""));
            var xsbhNum = xsbh == null ? int.Parse(DateTime.Now.ToString("yyMM") + "0000") : int.Parse(xsbh.ToString().Replace("CS", ""));

            //数据库中得日历
            var workTime = new Select().From<TWorkTimeShirt>().Where(TWorkTimeShirt.WorktimeColumn).IsBetweenAnd(BeginTime, BeginTime.AddDays(30)).ExecuteTypedList<TWorkTimeShirt>();

            //填充待生成计划订单
            var list = new List<DataPool>();

            LineOrder.RemoveAll(x => string.IsNullOrEmpty(x.Fzfl));

            LineOrder.ForEach(x =>
                list.Add(
                    new DataPool
                    {
                        Khdh = x.Khdh,
                        LineName = x.LineName,
                        Fzfl = x.Fzfl,
                        Jqts = "",//OrderDatapool.Find(y => y.Khdh == x.Khdh).Jqts,
                        Sex = x.Fzfl.IndexOf("W", StringComparison.Ordinal) == 0 ? "女" : "男",
                        Mlwg = OrderAnalyMx.Find(y => y.Khdh == x.Khdh).Scjhbz.Contains("新裁床/") ? "素" : "格",
                        Khzb = DataOrder.Find(y => y.Khdh == x.Khdh).Khzb,
                        TypeId = "9"
                    })
            );

            int i = 0;

            //填充集合得交期类型
            foreach (var dataPool in list)
            {
                try
                {

                    var jhrq = DataOrder.Find(x => x.Khdh == dataPool.Khdh).Jhrq;
                    var day = workTime.Where(x => x.Worktime >= BeginTime && x.Worktime <= jhrq).ToList().ConvertAll(x => x.Worktime.ToShortDateString()).Distinct().ToList().Count;

                    var ordermx = DataOrderMx.Find(x => x.Khdh == dataPool.Khdh);

                    #region 测试订单填充
                    if (dataPool.Khdh.ToUpper().IndexOf("JJJ") == 0 || dataPool.Khdh.ToUpper().IndexOf("TEST") == 0 || dataPool.Khdh.ToUpper().IndexOf("XXX") == 0)
                    {
                        dataPool.TypeId = "57";
                        continue;
                    }
                    #endregion

                    #region 配件订单填充

                    if (dataPool.Fzfl == "P0")
                    {
                        dataPool.TypeId = "21";
                        continue;
                    }
                    #endregion

                    #region 加急标识填充

                    if (day == 5)
                    {
                        dataPool.TypeId = "15";
                        continue;
                    }
                    else if (day <= 4)
                    {
                        dataPool.TypeId = "16";
                        continue;
                    }
                    else if (day <= 3)
                    {
                        dataPool.TypeId = "48";
                        continue;
                    }
                    #endregion


                    //将同一订单下得全部更新成统一得交期计算类型
                    list.Where(x => x.Khdh == dataPool.Khdh).ToList().ForEach(x => x.TypeId = dataPool.TypeId);

                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw;
                }
                i++;
            }


            //计划号不区分产线，可以合并产线，标识都打在明细了 , x.LineName
            var keys = list.GroupBy(x => new { x.Khzb, x.Mlwg, x.Sex, x.TypeId, x.LineName });


            //生成填充计划号
            foreach (var key in keys)
            {
                //&& x.LineName == key.Key.LineName     && x.LineName == key.Key.LineName
                var planList = list.FindAll(x => x.Khzb == key.Key.Khzb && x.Mlwg == key.Key.Mlwg && x.Sex == key.Key.Sex && x.TypeId == key.Key.TypeId && x.LineName == key.Key.LineName);
                list.RemoveAll(x => x.Khzb == key.Key.Khzb && x.Mlwg == key.Key.Mlwg && x.Sex == key.Key.Sex && x.TypeId == key.Key.TypeId && x.LineName == key.Key.LineName);

                var planCode = string.Empty;
                if (key.Key.Khzb == "国外")
                {
                    planCode = $@"CM{xmbhNum += 1}";
                }
                else
                {
                    planCode = $@"CS{xsbhNum += 1}";
                }

                planList.ForEach(x => x.PlanCode = planCode);
                list.AddRange(planList);
            }


            var planInfos = new List<PlanInfo>();
            var planGroup = list.GroupBy(x => x.PlanCode);
            foreach (var key in planGroup)
            {
                var orders = list.FindAll(x => x.PlanCode == key.Key);

                //面料外观
                var mlwg = orders.First().Mlwg == "素" ? " 新裁床" : " 单裁";

                //加急标识 
                mlwg += (orders.First().TypeId == "15" || orders.First().TypeId == "16" || orders.First().TypeId == "48") ? " 加急" : "";

                //测试订单
                if (orders.First().Khdh.ToLower().IndexOf("jjj", StringComparison.Ordinal) == 0 ||
                    orders.First().Khdh.ToLower().IndexOf("test", StringComparison.Ordinal) == 0 ||
                    orders.First().Khdh.ToLower().IndexOf("xxx", StringComparison.Ordinal) == 0)
                {
                    mlwg = " 测试订单";
                }

                //填充计划信息
                var planinfo = new PlanInfo
                {
                    Sczsbh = orders.First().PlanCode,
                    Scjhry = "APS",
                    Scshry = "00903",
                    Scgcdm = "02",
                    Scxdrq = BeginTime.ToString("yyyy-MM-dd HH:mm:ss"),
                    Scjhrq = DataOrder.Find(x => x.Khdh == orders.First().Khdh).Jhrq.ToString(),
                    Scshrq = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss").Replace('/', '-'),
                    Sczsbz = $"{Lines.Find(y => y.LineName == orders.First().LineName).LineNumber} {mlwg}",
                    Sclrrq = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss").Replace('/', '-'),
                    Type = orders.First().TypeId,
                    OrderPools = new List<LineOrderPool>()
                };

                orders.ForEach(x => planinfo.OrderPools.Add(new LineOrderPool { Fzfl = x.Fzfl, Khdh = x.Khdh, LineName = $"{Lines.Find(y => y.LineName == x.LineName).LineNumber}" }));

                planInfos.Add(planinfo);
            }

            //循环输出计划信息，推送到计划时间节点计算接口
            planInfos.ForEach(x => Console.WriteLine($"{x.Sczsbh}--{x.Type}--{x.Scjhry}--{x.Scshry}--{x.Sczsbh}--{x.Scxdrq}--{JsonConvert.SerializeObject(x.OrderPools)}\r\n"));

            int successCount = 0;
            string resultRtx = string.Empty;
            foreach (var planInfo in planInfos)
            {
                var result = string.Empty;

                var url = "http://172.16.7.214:8196/api/aps/CalculateDelivery";//正式地址
                //var url = "http://172.16.7.214:8093/api/aps/CalculateDelivery";//测试地址
                PushWebHelper.PostToPost(url, JsonConvert.SerializeObject(planInfo), ref result);


                if (result.Contains("成功"))
                {
                    resultRtx += planInfo.Sczsbh + ",";
                    successCount++;
                }
                else
                {
                    new RtxSendNotifyHelper().SendNotifyError("AutoPlanCYErr", planInfo.Sczsbh + "," + result);
                }

            }
            new RtxSendNotifyHelper().SendNotifyError("AutoPlanCY", resultRtx.Length > 0 ? resultRtx : "计划生成不成功，请重新发起请求重试。");

            string rmark = successCount == planInfos.Count ? "" : $"计算交期时失败{planInfos.Count - successCount}个";
            return $"{BeginTime}共生成计划{planGroup?.Count()}个  {rmark}";
        }

    }

}
