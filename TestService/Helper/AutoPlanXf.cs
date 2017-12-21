using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using APSData;
using SubSonic;
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
        /// 第一步，筛选订单
        /// </summary>
        public void OrderScreen()
        {
            try
            {
                //当前车间的产线
                Lines = new Select().From<TBasisLinesFz>()
                    .Where(TBasisLinesFz.LineTypeColumn).IsEqualTo("XF")
                    .ExecuteTypedList<TBasisLinesFz>();

                //当前车间的产能品类
                var allCategorys = new List<string>();
                foreach (var categorys in Lines.ConvertAll(x => x.Categorys))
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

                //产线产能倒序
                Lines = Lines.OrderBy(x => x.Capacity).ToList();



                //订单分配后产能检测,产能不饱和记录List
                List<TBasisLinesFz> lineUnSaturated = new List<TBasisLinesFz>();
                foreach (var line in Lines)
                {
                    if (line.Capacity - LineOrder.FindAll(x => x.LineName == line.LineName).Sum(x => x.Num) > 5)
                    {
                        lineUnSaturated.Add(line);
                    }
                }

                //将产能能不饱和的生产线聚合重新分配


            }
            catch (Exception e)
            {
                throw;
            }
        }

        //根据产线和分配订单
        public List<LineOrderPool> ScheduingOrder()
        {
            var lineOrders = new List<LineOrderPool>();
            try
            {
                //遍历当前产线分配订单
                foreach (var line in Lines)
                {
                    //当前产线产能的所有品类
                    var categorys = line.Categorys.ToUpper().Split(',').ToList();

                    //怎么遍历出已有的订单套装？？

                    //遍历订单
                    foreach (var order in ListOrder.FindAll(x => true))
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
                                ListOrder.RemoveAll(x => x == dataOrdermx.Khdh);
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
