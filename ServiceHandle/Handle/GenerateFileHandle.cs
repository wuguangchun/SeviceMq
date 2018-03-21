using System;
using System.Collections.Generic;
using System.Linq;
using System.Messaging;
using System.Web;
using DataModels.ModelsOther;
using Kute.Helper;
using Model;
using Newtonsoft.Json;
using PlanInfoPlugs;

namespace ServiceHandle.Handle
{
    public class GenerateFileHandle
    {
        public static MessageQueue messageQueue { get; set; }
        public static JsonHelper json { get; set; }

        //读取消息队列
        public static void GetMessageQueues()
        {
            try
            {
                var path = ".\\private$\\GenerateFile";
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
                reMeg = new GeneratePdf().GeneratePdfMtm(message.Body.ToString());

                if (message.Label.ToLower().Trim() == "tz")
                {
                    reMeg = new GeneratePdf().GeneratePdfTz(message.Body.ToString());
                }


                //程序处理返回的结果
                json = (JsonHelper)JsonHelper.ReturnObject(reMeg, typeof(JsonHelper));

                if (json.RetCode.ToLower() == "error") //程序处理失败
                {
                    throw new ApplicationException($"程序处理失败,{json.RetMessage}");
                }
                else if (json.RetCode.ToLower() == "proceed")//投诉异常：需要新增队列通知
                {
                    var msmqList = (List<MsmqModel>)JsonConvert.DeserializeObject(json.RetMessage, typeof(List<MsmqModel>));
                    foreach (var msmq in msmqList)
                    {
                        var service = new ApsMessageService.NewMassgeServiceClient();
                        service.InsertMessage(msmq.Path, msmq.Label, msmq.Body, msmq.CallBackUrl);
                        service.Close();
                    }
                }

                //处理成功，回调URL通知
                var serviceCallBack = new ApsMessageService.NewMassgeServiceClient();
                json.RetObj = message.Id;
                serviceCallBack.InsertMessage("CallBackMsg", "Message", JsonHelper.GetJsonO(json), null);
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