using DataModels.ModelsOther;
using Kute.Helper;
using Model;
using Newtonsoft.Json;
using ServiceHelper.Helper;
using SubSonic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewAnalysisPlugs
{
    public class NewAnalysisHelper
    {

        public string NewData(string dataJson)
        {
            try
            {

                var blData = (BLData)JsonHelper.ReturnObject(dataJson, typeof(BLData));
                string coatType = blData.order.OrderType == "1" ? "BLMTM" : "BL团装";
                int specialTime = 0;
                string specialCode = "";
                new HelperClass().GetSpecialTime(blData.ordermx, ref specialTime, ref specialCode);

                //特殊体型的判别标准
                string tstx = "";
                if (!string.IsNullOrWhiteSpace(blData.order.Tstx))
                {
                    tstx = "TSTX";
                }

                //生成订单数据主表
                TAnalysisOrder tAnalysisOrderList = new TAnalysisOrder
                {
                    OrderId = tstx + new DataHelper().GenerateOrderNumber(),
                    CustomerId = blData.order.Khdh,
                    OrderType = coatType,
                    BodyType = new HelperClass().GetMinBodyType(blData.order.Txtz).ToString(),
                    CreateDate = DateTime.Now,
                    CoatType = coatType + "-" + new HelperClass().GetCoatType(blData.ordermx),
                    SpecialTime = specialTime,
                    SpecialCode = specialCode,
                    Sfbcpsy = string.IsNullOrWhiteSpace(blData.ordermx.First().Sfbcpsy) ? "0" : blData.ordermx.First().Sfbcpsy
                };

                //避免数据重复先删除
                new Delete().From<TAnalysisOrder>().Where(TAnalysisOrder.CustomerIdColumn)
                    .IsEqualTo(tAnalysisOrderList.CustomerId).Execute();

                tAnalysisOrderList.Save();



                //生成订单数据字表
                var mxList = new List<TAnalysisOrderMx>();
                foreach (var ordermx in blData.ordermx)
                {
                    var orderMx = new TAnalysisOrderMx
                    {
                        Khdh = blData.order.Khdh,
                        Fzfl = ordermx.Fzfl,
                        SpecialCode = new HelperClass().GetFZSpecialCode(ordermx.Gyxx.Split(','), ordermx.Fzfl).Replace("[", "").Replace("]", "").Replace("\"", "")
                    };

                    mxList.Add(orderMx);
                }

                //避免数据重复先删除
                new Delete().From<TAnalysisOrderMx>().Where(TAnalysisOrderMx.KhdhColumn)
                    .IsEqualTo(blData.order.Khdh).Execute();

                mxList.ForEach(x => x.Save());
                return JsonConvert.SerializeObject(new JsonHelper { RetCode = "success", RetMessage = "保存成功" });
            }
            catch (Exception e)
            {
                throw;
            }
        }
    }
}
