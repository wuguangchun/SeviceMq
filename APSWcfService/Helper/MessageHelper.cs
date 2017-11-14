using System;
using System.Collections.Generic;
using System.Linq;
using System.Messaging;
using System.Web;

namespace APSWcfService.Helper
{
    public class MessageHelper
    {
        /// <summary>
        /// 新增消息到消息队列，有队列则增加消息，没有队列则新增队列后增加消息
        /// </summary>
        /// <param name="path">.\\private$\\NewOrder</param>
        /// <param name="label">消息列表标签</param>
        /// <param name="body">消息队列内容</param> 
        public static string AddMessageQueue(string path, string label, string body)
        {
            try
            {
                var mq = MessageQueue.Exists(path) ? new MessageQueue(path) : MessageQueue.Create(path);
                Message message = new Message();
                message.Label = label;
                message.Formatter = new XmlMessageFormatter(new Type[] { typeof(string) });
                message.Body = body;
                mq.Send(message);

                return message.Id;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}