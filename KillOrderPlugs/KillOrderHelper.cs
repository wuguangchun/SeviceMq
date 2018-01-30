using Kute.Helper;
using Model;
using SubSonic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModels.ModelsOther;
using Newtonsoft.Json;
using ServiceHandle.ModelsOther;

namespace KillOrderPlugs
{
    public class KillOrderHelper
    {
        public string KillOrder(string json)
        {
            var resultJson = new JsonHelper();
            try
            {
                //获取明细ID
                var mxlist = new Select().From<TBLDataOrdermx>().Where(TBLDataOrdermx.KhdhColumn).IsEqualTo(json).ExecuteTypedList<TBLDataOrdermx>();

                //循环删除MES工时数据
                foreach (var ordermx in mxlist)
                {
                    //T_OrderKeyProcess
                    new Delete().From<TOrderKeyProcess>().Where(TOrderKeyProcess.MxidColumn).IsEqualTo(ordermx.Mxid).Execute();

                    //T_OrderMESArtInfo
                    new Delete().From<TOrderMESArtInfo>().Where(TOrderMESArtInfo.MxIdColumn).IsEqualTo(ordermx.Mxid).Execute();
                }

                new Delete().From<TAnalysisOrder>().Where(TAnalysisOrder.CustomerIdColumn).IsEqualTo(json).Execute();
                new Delete().From<TAnalysisOrderMx>().Where(TAnalysisOrderMx.KhdhColumn).IsEqualTo(json).Execute();
                new Delete().From<TAnalysisOrderList>().Where(TAnalysisOrderList.CustomerIdColumn).IsEqualTo(json).Execute();
                new Delete().From<TAnalysisOrderListByCF>().Where(TAnalysisOrderListByCF.CustomerIdColumn).IsEqualTo(json).Execute();
                new Delete().From<TAnalysisOutputList>().Where(TAnalysisOutputList.OrderNoColumn).IsEqualTo(json).Execute();
                new Delete().From<TAnalysisOutPutListByCF>().Where(TAnalysisOutPutListByCF.CustomerIdColumn).IsEqualTo(json).Execute();
                new Delete().From<TAnalysisOutPutListByFZ>().Where(TAnalysisOutPutListByFZ.CustomerIdColumn).IsEqualTo(json).Execute();
                new Delete().From<TBlankingDetaile>().Where(TBlankingDetaile.CustumerIdColumn).IsEqualTo(json).Execute();
                new Delete().From<TBLDataOrder>().Where(TBLDataOrder.KhdhColumn).IsEqualTo(json).Execute();
                new Delete().From<TBLDataOrdermx>().Where(TBLDataOrdermx.KhdhColumn).IsEqualTo(json).Execute();
                new Delete().From<TBLDataMflxx>().Where(TBLDataMflxx.KhdhColumn).IsEqualTo(json).Execute();
                new Delete().From<TOldApsByCf>().Where(TOldApsByCf.OrderIDColumn).IsEqualTo(json).Execute();
                new Delete().From<TBasisOrderStatus>().Where(TBasisOrderStatus.CustomerIdColumn).IsEqualTo(json).Execute();


                //调用存储过程删已经圈起来的计划
                try
                {
                    var spd = new StoredProcedure("proc_DelERPData");
                    spd.CommandTimeout = 300;
                    spd.Command.AddParameter("@OrderID", json);
                    spd.Execute();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }


                resultJson.RetCode = "success";
                resultJson.RetMessage = "撤单成功";
            }
            catch (Exception e)
            {
                //撤单异常后系统自动执行撤单
                var msmqList = new List<MsmqModel>
                {
                    new MsmqModel{Path = "BlankingData",Label = "NewOrder",Body = json,CallBackUrl = "ErrorAuto-Local"}
                };

                resultJson.RetMessage = JsonConvert.SerializeObject(msmqList);
                resultJson.RetCode = "Proceed";
            }

            return JsonConvert.SerializeObject(resultJson);
        }

        public string KillSingle(string json)
        {
            var resultJson = new JsonHelper();
            try
            {
                var killOrder = (OrderKill)JsonConvert.DeserializeObject(json, typeof(OrderKill));

                //获取原始数据
                var order = new TBLDataOrder(TBLDataOrder.KhdhColumn.ColumnName, killOrder.CustmerId);
                var ordermx = new Select().From<TBLDataOrdermx>().Where(TBLDataOrdermx.OrderidColumn).IsEqualTo(order.Orderid).ExecuteTypedList<TBLDataOrdermx>();

                //只有一条明细，系统内关于此订单的信息全部删掉
                if (ordermx.Count == 1)
                {
                    new Delete().From<TBLDataOrder>().Where(TBLDataOrder.KhdhColumn).IsEqualTo(killOrder.CustmerId).Execute();
                    new Delete().From<TBLDataOrdermx>().Where(TBLDataOrdermx.KhdhColumn).IsEqualTo(killOrder.CustmerId).Execute();
                    new Delete().From<TBLDataMflxx>().Where(TBLDataMflxx.KhdhColumn).IsEqualTo(killOrder.CustmerId).Execute();
                    new Delete().From<TOldApsByCf>().Where(TOldApsByCf.OrderIDColumn).IsEqualTo(killOrder.CustmerId).Execute();
                    new Delete().From<TBasisOrderStatus>().Where(TBasisOrderStatus.CustomerIdColumn).IsEqualTo(killOrder.CustmerId).Execute();
                    new Delete().From<TBlankingDetaile>().Where(TBlankingDetaile.CustumerIdColumn).IsEqualTo(killOrder.CustmerId).Execute();
                    new Delete().From<TAnalysisOrderListByCF>().Where(TAnalysisOrderListByCF.CustomerIdColumn).IsEqualTo(killOrder.CustmerId).Execute();
                    new Delete().From<TAnalysisOrderList>().Where(TAnalysisOrderList.CustomerIdColumn).IsEqualTo(killOrder.CustmerId).Execute();
                    new Delete().From<TAnalysisOrder>().Where(TAnalysisOrder.CustomerIdColumn).IsEqualTo(killOrder.CustmerId).Execute();
                    new Delete().From<TAnalysisOrderMx>().Where(TAnalysisOrderMx.KhdhColumn).IsEqualTo(killOrder.CustmerId).Execute();
                    new Delete().From<TOrderKeyProcess>().Where(TOrderKeyProcess.MxidColumn).IsEqualTo(ordermx.FirstOrDefault()?.Mxid).Execute();
                    new Delete().From<TOrderMESArtInfo>().Where(TOrderMESArtInfo.MxIdColumn).IsEqualTo(ordermx.FirstOrDefault()?.Mxid).Execute();
                    new Delete().From<TBLDataPld>().Where(TBLDataPld.KhdhColumn).IsEqualTo(killOrder.CustmerId).Execute();
                    new Delete().From<TBLDataPld>().Where(TBLDataPld.KhdhColumn).IsEqualTo(killOrder.CustmerId).Execute();


                }//有多条明细，只删除此条明细的信息
                else if (ordermx.Count > 1)
                {
                    var mx = ordermx.Find(x => x.Khdh == killOrder.CustmerId && x.Fzfl == killOrder.OrderFl);
                    new Delete().From<TBLDataOrdermx>().Where(TBLDataOrdermx.MxidColumn).IsEqualTo(mx.Mxid).Execute();
                    new Delete().From<TBLDataMflxx>().Where(TBLDataMflxx.MxidColumn).IsEqualTo(mx.Mxid).Execute();
                    new Delete().From<TAnalysisOrderMx>().Where(TAnalysisOrderMx.KhdhColumn).IsEqualTo(killOrder.CustmerId).And(TAnalysisOrderMx.FzflColumn).IsEqualTo(killOrder.OrderFl).Execute();
                    new Delete().From<TOrderKeyProcess>().Where(TOrderKeyProcess.MxidColumn).IsEqualTo(ordermx.FirstOrDefault()?.Mxid).Execute();
                    new Delete().From<TOrderMESArtInfo>().Where(TOrderMESArtInfo.MxIdColumn).IsEqualTo(ordermx.FirstOrDefault()?.Mxid).Execute();
                }

                // 撤单异常后系统自动执行撤单
                var msmqList = new List<MsmqModel>
                {
                    new MsmqModel{Path = "KillOrder",Label = "KillSingleERP",Body = json,CallBackUrl = null}
                };

                resultJson.RetMessage = JsonConvert.SerializeObject(msmqList);
                resultJson.RetCode = "Proceed";

                //resultJson.RetCode = "success";
                //resultJson.RetMessage = result;
            }
            catch (Exception e)
            {
                // 撤单异常后系统自动执行撤单
                var msmqList = new List<MsmqModel>
                {
                    new MsmqModel{Path = "KillOrder",Label = "KillSingle",Body = json,CallBackUrl = "ErrorAuto-Local"}
                };

                resultJson.RetMessage = JsonConvert.SerializeObject(msmqList);
                resultJson.RetCode = "Proceed";

            }

            return JsonConvert.SerializeObject(resultJson);
        }
    }
}
