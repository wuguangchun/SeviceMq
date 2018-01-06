using System;
using System.Collections.Generic;
using System.Linq;
using System.Messaging;
using System.Web;
using Kute.Helper;
using ServiceHelper;

namespace ServiceHandle.Handle
{
    public class OnlineTestHandle
    {
        public static MessageQueue messageQueue { get; set; }
        public static JsonHelper json { get; set; }

        //读取消息队列
        public static void GetMessageQueues()
        {
            try
            {
                var path = ".\\private$\\OnlineTest";
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
                //消息实体
                var mq = (MessageQueue)sender;

                //测试RTX推送
                new RtxSendNotifyHelper().SendNotifyError("Scjhbz", "ERP取计划标注信息异常，ERP无信息返回。请确认计划标注信息及订单信息是否正确。原始凭单：测试发送");

            }
            catch (Exception ex)
            {

            }
            finally
            {
                //继续下一条消息
                messageQueue.BeginReceive();
            }
        }
    }

}