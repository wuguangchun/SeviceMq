using System;
using System.Collections.Generic;
using System.Linq;
using System.Messaging;
using System.Web;
using Kute.Helper;
using Model;
using ServiceHelper;
using TestService.ModelsOther;

namespace ServiceHandle.Handle
{
    public class LogHandleHandle
    {
        public static MessageQueue messageQueue { get; set; }
        public static JsonHelper json { get; set; }

        //读取消息队列
        public static void GetMessageQueues()
        {
            try
            {
                var path = ".\\private$\\LogService";
                messageQueue = MessageQueue.Exists(path) ? new MessageQueue(path) : MessageQueue.Create(path);
                messageQueue.Formatter = new XmlMessageFormatter(new[] { typeof(string) });
                messageQueue.ReceiveCompleted += mq_ReceiveCompleted;
                messageQueue.BeginReceive();
            }
            catch (Exception e)
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
                if (message.Label.ToLower().Trim() == "AddLog".ToLower())
                {//新增服务日志
                    var sLog = (ServiceLog)JsonHelper.ReturnObject(message.Body.ToString(), typeof(ServiceLog));
                    var log = new TLogService() { CallBackUrl = sLog.CallBackUrl, Context = sLog.Context, CreateTime = sLog.CreateTime, MessagePath = sLog.MessagePath, Lable = sLog.Lable, MessageID = sLog.MessageID };
                    log.Save();
                    json.RetCode = "success";
                    json.RetMessage = "添加系统日志成功";
                }
                else if (message.Label.ToLower().Trim() == "AddErrLog".ToLower())
                {//新增服务日志
                    var logError = (TLogError)JsonHelper.ReturnObject(message.Body.ToString(), typeof(TLogError));
                    logError.Save();
                    json.RetCode = "success";
                    json.RetMessage = "添加系统错误日志成功";

                    //系统异常通知RTX
                    new RtxSendNotifyHelper().SendNotifyError("systemError", logError.Message);
                }
                else
                {//无法识别标签内容
                    throw new ApplicationException("无法识别标签内容");
                }

            }
            catch (Exception ex)
            {
                var service = new ApsMessageService.NewMassgeServiceClient();
                var errLog = new TLogError { CreateTime = DateTime.Now, MessageId = message.Id, Message = ex.Message };
                service.InsertMessage("LogService", "AddErrLog", JsonHelper.GetJsonO(errLog), null);

            }
            finally
            {
                //继续下一条消息
                messageQueue.BeginReceive();
            }
        }
    }
}