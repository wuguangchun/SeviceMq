using System;
using System.Collections.Generic;
using System.Linq;
using System.Messaging;
using System.Web;
using Kute.Helper;
using Model;
using NewAnalysisPlugs;
using Newtonsoft.Json;
using ServiceHelper.Helper;
using SubSonic;

namespace ServiceHandle.Handle
{
    public class NewAnalysisOrderHandle
    {
        public static MessageQueue messageQueue { get; set; }
        public static JsonHelper json { get; set; }

        //读取消息队列
        public static void GetMessageQueues()
        {
            try
            {
                var path = ".\\private$\\AnalysisOrder";
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
                if (message.Label.ToLower().Trim() == "NewOrder".ToLower())
                {//收到新订单命令

                    reMeg = new NewAnalysisHelper().NewData(message.Body.ToString());
                }
                else if (message.Label.ToLower().Trim() == "NewOrderPld".ToLower())
                {//收到新订单命令

                    reMeg = new BlPldHelper().ReceiveBlPldHelper(message.Body.ToString());
                }
                else if (message.Label.ToLower().Trim() == "NewFlBom".ToLower())
                {
                    reMeg = new NewFlBomHelper().NewFlBom(message.Body.ToString());
                }
                else
                {
                    //无法识别标签内容
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
                    service.InsertMessage("CallBackMsg", "Message", JsonHelper.GetJsonO(new JsonHelper { RetCode = "Success", RetMessage = "处理成功", RetObj = message.Id }), null);
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

}