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
using ServiceHelper.Helper;

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
                new Delete().From<TBLDataPld>().Where(TBLDataPld.KhdhColumn).IsEqualTo(json).Execute();

                if (FindErpOrder(json))
                {
                    // 撤单后通知ERP进行同步撤单
                    var msmqList = new List<MsmqModel>();
                    foreach (var ordermx in mxlist)
                    {
                        msmqList.Add(new MsmqModel
                        {
                            Path = "KillOrder",
                            Label = "KillSingleERP",
                            Body = JsonConvert.SerializeObject(new OrderKill
                            {
                                CustmerId = ordermx.Khdh,
                                OrderFl = ordermx.Fzfl,
                                CallingParty = "Auto"
                            }),
                            CallBackUrl = null
                        });
                    }

                    resultJson.RetMessage = JsonConvert.SerializeObject(msmqList);
                    resultJson.RetCode = "Proceed";
                }
                else
                {
                    resultJson.RetMessage = "APS系统撤单成功";
                    resultJson.RetCode = RetCode.Success;

                }


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

                //只有一条明细，并且服装大类一致，系统内关于此订单的信息全部删掉
                if (ordermx.Count == 1 && ordermx.First().Fzfl == killOrder.OrderFl)
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

                // 撤单后通知ERP进行同步撤单
                var msmqList = new List<MsmqModel>
                {
                    new MsmqModel{Path = "KillOrder",Label = "KillSingleERP",Body = json,CallBackUrl = null}
                };

                resultJson.RetMessage = JsonConvert.SerializeObject(msmqList);
                resultJson.RetCode = "Proceed";
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


        public bool FindErpOrder(string khdh)
        {
            var f = false;
            try
            {
                var result = new DataHelper().OtherBaseSelect("fyerp", $"select * from sct51 where scyspd='{khdh}'");
                return result.Rows.Count > 0;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return f;
        }
    }
}
