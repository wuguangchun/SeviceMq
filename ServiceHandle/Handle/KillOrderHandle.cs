using System;
using System.Collections.Generic;
using System.Linq;
using System.Messaging;
using System.Web;
using Kute.Helper;
using Model;
using SubSonic;

namespace ServiceHandle.Handle
{
    public class KillOrderHandle
    {
        public static MessageQueue messageQueue { get; set; }
        public static JsonHelper json { get; set; }

        //读取消息队列
        public static void GetMessageQueues()
        {
            try
            {
                var path = ".\\private$\\KillOrder";
                messageQueue = MessageQueue.Exists(path) ? new MessageQueue(path) : MessageQueue.Create(path);
                messageQueue.Formatter = new XmlMessageFormatter(new[] { typeof(string) });
                messageQueue.ReceiveCompleted += mq_ReceiveCompleted;
                messageQueue.BeginReceive();
            }
            catch (Exception)
            {
                throw;
            }
        }

        //处理消息队列事件
        public static void mq_ReceiveCompleted(object sender, ReceiveCompletedEventArgs e)
        {
            json = new JsonHelper();
            string reMeg = "";
            Message message = null;
            try
            {
                var mq = (MessageQueue)sender;
                message = mq.EndReceive(e.AsyncResult);

                //根据消息标签执行相应的命令
                if (message.Label.ToLower().Trim() == "KillOrder".ToLower())
                {//接收BL传入数据源
                    reMeg = KillOrderHelper.KillOrder(message.Body.ToString());
                }
                else
                {//无法识别标签内容
                    throw new ApplicationException("无法识别标签内容");
                }

                //程序处理返回的结果
                json = (JsonHelper)JsonHelper.ReturnObject(reMeg, typeof(JsonHelper));

                if (json.RetCode.ToLower() == "error")//程序处理失败
                {

                    throw new ApplicationException($"程序处理失败,{json.RetMessage}");
                }
                else
                {
                    //处理成功，回调URL通知
                    var service = new ApsMessageService.NewMassgeServiceClient();
                    json.RetObj = message.Id;
                    service.InsertMessage("CallBackMsg", "Message", JsonHelper.GetJsonO(json), null);
                }
            }
            catch (Exception ex)
            {
                var service = new ApsMessageService.NewMassgeServiceClient();
                var errLog = new TLogError { CreateTime = DateTime.Now, MessageId = message.Id, Message = ex.Message };
                service.InsertMessage("LogService", "AddErrLog", JsonHelper.GetJsonO(errLog), null);


                //回调URL通知
                service.InsertMessage("CallBackMsg", "Message", JsonHelper.GetJsonO(new JsonHelper { RetCode = "Error", RetMessage = ex.Message, RetObj = message.Id }), null);
            }
            finally
            {
                //继续下一条消息
                messageQueue.BeginReceive();
            }
        }

    }


    public class KillOrderHelper
    {
        public static string KillOrder(string json)
        {
            var resultJson = new JsonHelper();
            try
            {
                string result = string.Empty;
                //T_Analysis_OrderList
                var killOrderList = new Delete().From<TAnalysisOrderList>()
                 .Where(TAnalysisOrderList.CustomerIdColumn).IsEqualTo(json);

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

                //T_BLCADTemp
                var killBLCADTemp = new Delete().From<TBLCADTemp>()
                    .Where(TBLCADTemp.CustomerIDColumn).IsEqualTo(json);

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

                result += $"T_Analysis_OrderList撤回{killOrderList.Execute()}条数据，";
                result += $"T_Analysis_OrderListByCF撤回{killOrderListByCf.Execute()}条数据，";
                result += $"T_Analysis_OutputList撤回{killOrderListOut.Execute()}条数据，";
                result += $"T_Analysis_OutPutListByCF撤回{killOrderListOutByCf.Execute()}条数据，";
                result += $"T_Analysis_OutPutListByFZ撤回{killOrderListOutByfz.Execute()}条数据，";
                result += $"T_BlankingDetailes撤回{killBlankingDetaile.Execute()}条数据，";
                result += $"T_BLCADTemp撤回{killBLCADTemp.Execute()}条数据，";
                result += $"T_BLData_Order撤回{killBLOrder.Execute()}条数据，";
                result += $"T_BLData_Ordermx撤回{killBLOrdermx.Execute()}条数据，";
                result += $"T_BLData_Mflxx撤回{killBLMflxx.Execute()}条数据，";
                result += $"T_OldApsByCf撤回{killOldApsByCf.Execute()}条数据。";

                resultJson.RetCode = "success";
                resultJson.RetMessage = result;
            }
            catch (Exception e)
            {
                resultJson.RetCode = "error";
                resultJson.RetMessage = e.Message;

            }

            return JsonHelper.GetJsonO(resultJson);
        }

    }
}