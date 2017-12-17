using DataModels.ModelsOther;
using Kute.Helper;
using Model;
using ServiceHandle.Helper;
using ServiceHelper.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewAnalysisPlugs
{
   public class NewCadHelper
    {

        public bool CreateOrderList(string blDateJson)
        {
            try
            {
                var blDate = (BLData)JsonHelper.ReturnObject(blDateJson, typeof(BLData));

                string coatType = blDate.order.OrderType == "1" ? "BLMTM" : "BL团装";
                int specialTime = 0;
                string specialCode = "";
                new HelperClass().GetSpecialTime(blDate.ordermx, ref specialTime, ref specialCode);

                //特殊体型的判别标准
                string tstx = "";
                if (!string.IsNullOrWhiteSpace(blDate.order.Tstx))
                {
                    tstx = "TSTX";
                }

                TAnalysisOrderList tAnalysisOrderList = new TAnalysisOrderList
                {
                    OrderId = tstx + new DataHelper().GenerateOrderNumber(),
                    CustomerId = blDate.order.Khdh,
                    Project = "CAD",
                    OrderType = coatType,
                    BodyType = new HelperClass().GetMinBodyType(blDate.order.Txtz).ToString(),
                    OrderTime = blDate.order.Trantime == null ? DateTime.Now : DateTime.Parse(blDate.order.Trantime),
                    DeliveryTime = blDate.order.Jhrq == null ? DateTime.Now : DateTime.Parse(blDate.order.Jhrq),
                    SupportingWay = blDate.order.Sldl,
                    Sizes = blDate.ordermx.First().Hxjg,
                    Customer = blDate.order.Customername,
                    CreateTime = blDate.order.Createtime == null ? DateTime.Now : DateTime.Parse(blDate.order.Createtime),
                    CreateDate = DateTime.Now,
                    Gydm = blDate.order.Txtz,
                    Audittime = blDate.order.Audittime == null ? DateTime.Now : DateTime.Parse(blDate.order.Audittime),
                    Scggdh = blDate.order.Ecode,
                    Mflxx = new HelperClass().GetYlbmStr(blDate.ordermx),
                    Numbers = 1,  //全部为1？？？？
                    CoatType = coatType + "-" + new HelperClass().GetCoatType(blDate.ordermx),
                    Fabric = blDate.ordermx.First().Mlbm,
                    SpecialTime = specialTime,
                    SpecialCode = specialCode,
                    StylesResult = new HelperClass().GetStylesResult(blDate.ordermx),
                    Styles = new HelperClass().GetStyles(blDate.ordermx),
                    OrderStatus = "0",
                    Pbcd = blDate.order.Pbcd,
                    Tzecode = blDate.order.Tzecode,
                    Sfbcpsy = string.IsNullOrWhiteSpace(blDate.ordermx.First().Sfbcpsy) ? "0" : blDate.ordermx.First().Sfbcpsy,
                    Gylx = blDate.ordermx.First().Gylx
                };

                tAnalysisOrderList.Save();
            }
            catch (Exception)
            {
                throw;
            }
            return true;
        }
    }
}
