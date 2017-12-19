using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using APSData;
using SubSonic;

namespace TestService.Helper
{
    public class AutoPlanXf
    {
        public List<String> ListOrder { get; set; }
        public List<TBasisLinesFz> Lines { get; set; }
        public List<string> orderPool { get; set; }

        /// <summary>
        /// 构造函数，初始化三大集合
        /// </summary>
        public AutoPlanXf()
        {
            ListOrder = new List<string>();
            Lines = new List<TBasisLinesFz>();
            orderPool = new List<string>();
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


            }
            catch (Exception e)
            {
                throw;
            }
        }
    }
}
