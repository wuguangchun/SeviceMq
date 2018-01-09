using Kute.Helper;
using Model;
using SubSonic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace KillOrderPlugs
{
    public class KillOrderHelper
    {
        public string KillOrder(string json)
        {
            var resultJson = new JsonHelper();
            try
            {
                string result = string.Empty;


                //T_Analysis_Order
                var killAnalysisOrder = new Delete().From<TAnalysisOrder>()
                    .Where(TAnalysisOrder.CustomerIdColumn).IsEqualTo(json);

                //T_Analysis_OrderMx
                var killAnalysisOrderMx = new Delete().From<TAnalysisOrderMx>()
                    .Where(TAnalysisOrderMx.KhdhColumn).IsEqualTo(json);

                //T_Analysis_OrderList
                var killOrderList = new Delete().From<TAnalysisOrderList>()
                 .Where(TAnalysisOrderList.CustomerIdColumn).IsEqualTo(json);

                //获取明细ID
                var mxlist = new Select().From<TBLDataOrdermx>().Where(TBLDataOrdermx.KhdhColumn).IsEqualTo(json).ExecuteTypedList<TBLDataOrdermx>();

                //循环删除MES工时数据
                foreach (var ordermx in mxlist)
                {

                    //T_OrderKeyProcess
                    new Delete().From<TOrderKeyProcess>()
                         .Where(TOrderKeyProcess.MxidColumn).IsEqualTo(ordermx.Mxid)
                         .Execute();

                    //T_OrderMESArtInfo
                    new Delete().From<TOrderMESArtInfo>()
                        .Where(TOrderMESArtInfo.MxIdColumn).IsEqualTo(ordermx.Mxid)
                        .Execute();
                }

                //T_Analysis_OrderListByDH
                //var killOrderList=new Delete().From<TAnalysisOrderListByDH>()
                //    .Where(TAnalysisOrderListByDH.CustomerIdColumn).IsEqualTo(json);

                //T_Analysis_OrderListByCF
                var killOrderListByCf = new Delete().From<TAnalysisOrderListByCF>()
                    .Where(TAnalysisOrderListByCF.CustomerIdColumn).IsEqualTo(json);

                //T_Analysis_OutputList
                var killOrderListOut = new Delete().From<TAnalysisOutputList>()
                    .Where(TAnalysisOutputList.OrderNoColumn).IsEqualTo(json);

                //T_Analysis_OutPutListByCF
                var killOrderListOutByCf = new Delete().From<TAnalysisOutPutListByCF>()
                    .Where(TAnalysisOutPutListByCF.CustomerIdColumn).IsEqualTo(json);

                //T_Analysis_OutPutListByFZ
                var killOrderListOutByfz = new Delete().From<TAnalysisOutPutListByFZ>()
                    .Where(TAnalysisOutPutListByFZ.CustomerIdColumn).IsEqualTo(json);

                //T_BlankingDetailes
                var killBlankingDetaile = new Delete().From<TBlankingDetaile>()
                    .Where(TBlankingDetaile.CustumerIdColumn).IsEqualTo(json);

                //T_BLData_Order
                var killBLOrder = new Delete().From<TBLDataOrder>()
                    .Where(TBLDataOrder.KhdhColumn).IsEqualTo(json);

                //T_BLData_Ordermx
                var killBLOrdermx = new Delete().From<TBLDataOrdermx>()
                    .Where(TBLDataOrdermx.KhdhColumn).IsEqualTo(json);

                //T_BLData_Mflxx
                var killBLMflxx = new Delete().From<TBLDataMflxx>()
                    .Where(TBLDataMflxx.KhdhColumn).IsEqualTo(json);

                //T_OldApsByCf
                var killOldApsByCf = new Delete().From<TOldApsByCf>()
                    .Where(TOldApsByCf.OrderIDColumn).IsEqualTo(json);

                //T_Basis_OrderStatus
                var killOrderStatus = new Delete().From<TBasisOrderStatus>()
                    .Where(TBasisOrderStatus.CustomerIdColumn).IsEqualTo(json);

                result += $"T_Analysis_OrderList撤回{killOrderList.Execute()}条数据，";
                result += $"T_Analysis_OrderListByCF撤回{killOrderListByCf.Execute()}条数据，";
                result += $"T_Analysis_OutputList撤回{killOrderListOut.Execute()}条数据，";
                result += $"T_Analysis_OutPutListByCF撤回{killOrderListOutByCf.Execute()}条数据，";
                result += $"T_Analysis_OutPutListByFZ撤回{killOrderListOutByfz.Execute()}条数据，";
                result += $"T_BlankingDetailes撤回{killBlankingDetaile.Execute()}条数据，";
                result += $"T_BLData_Order撤回{killBLOrder.Execute()}条数据，";
                result += $"T_BLData_Ordermx撤回{killBLOrdermx.Execute()}条数据，";
                result += $"T_BLData_Mflxx撤回{killBLMflxx.Execute()}条数据，";
                result += $"T_OldApsByCf撤回{killOldApsByCf.Execute()}条数据。";
                result += $"T_Basis_OrderStatus撤回{killOrderStatus.Execute()}条数据。";
                result += $"T_Analysis_Order撤回{killAnalysisOrder.Execute()}条数据。";
                result += $"T_Analysis_OrderMx撤回{killAnalysisOrderMx.Execute()}条数据。";



                resultJson.RetCode = "success";
                resultJson.RetMessage = result;
            }
            catch (Exception e)
            {
                resultJson.RetCode = "error";
                resultJson.RetMessage = e.Message;

            }

            return JsonConvert.SerializeObject(resultJson);
        }

        public string killSingle(string json)
        {
            var resultJson = new JsonHelper();
            try
            {
                string result = string.Empty;

                //T_Analysis_OrderListByDH
                //var killOrderList=new Delete().From<TAnalysisOrderListByDH>()
                //    .Where(TAnalysisOrderListByDH.CustomerIdColumn).IsEqualTo(json);


                //T_Analysis_OutPutListByFZ
                var killOrderListOutByfz = new Delete().From<TAnalysisOutPutListByFZ>()
                    .Where(TAnalysisOutPutListByFZ.CustomerIdColumn).IsEqualTo(json);

                //T_BlankingDetailes
                var killBlankingDetaile = new Delete().From<TBlankingDetaile>()
                    .Where(TBlankingDetaile.CustumerIdColumn).IsEqualTo(json);


                //T_BLData_Ordermx
                var killBLOrdermx = new Delete().From<TBLDataOrdermx>()
                    .Where(TBLDataOrdermx.KhdhColumn).IsEqualTo(json);

                //T_BLData_Mflxx
                var killBLMflxx = new Delete().From<TBLDataMflxx>()
                    .Where(TBLDataMflxx.KhdhColumn).IsEqualTo(json);


                //result += $"T_Analysis_OrderList撤回{killOrderList.Execute()}条数据，";
                //result += $"T_Analysis_OrderListByCF撤回{killOrderListByCf.Execute()}条数据，";
                //result += $"T_Analysis_OutputList撤回{killOrderListOut.Execute()}条数据，";
                //result += $"T_Analysis_OutPutListByCF撤回{killOrderListOutByCf.Execute()}条数据，";
                //result += $"T_Analysis_OutPutListByFZ撤回{killOrderListOutByfz.Execute()}条数据，";
                //result += $"T_BlankingDetailes撤回{killBlankingDetaile.Execute()}条数据，";
                //result += $"T_BLData_Order撤回{killBLOrder.Execute()}条数据，";
                //result += $"T_BLData_Ordermx撤回{killBLOrdermx.Execute()}条数据，";
                //result += $"T_BLData_Mflxx撤回{killBLMflxx.Execute()}条数据，";
                //result += $"T_OldApsByCf撤回{killOldApsByCf.Execute()}条数据。";
                //result += $"T_Basis_OrderStatus撤回{killOrderStatus.Execute()}条数据。";

                resultJson.RetCode = "success";
                resultJson.RetMessage = result;
            }
            catch (Exception e)
            {
                resultJson.RetCode = "error";
                resultJson.RetMessage = e.Message;

            }

            return JsonConvert.SerializeObject(resultJson);
        }
    }
}
