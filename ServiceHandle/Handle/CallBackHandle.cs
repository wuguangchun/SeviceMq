﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Messaging;
using System.Web;
using Kute.Helper;
using Model;
using ServiceHandle.Helper;
using TestService.ModelsOther;

namespace ServiceHandle.Handle
{
    public class CallBackHandle
    {

        public static MessageQueue messageQueue { get; set; }
        public static JsonHelper json { get; set; }

        //读取消息队列
        public static void GetMessageQueues()
        {
            try
            {
                var path = ".\\private$\\CallBackMsg";
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
                if (message.Label.ToLower().Trim() == "Message".ToLower())
                {
                    //接收BL传入数据源
                    reMeg = CallBackHelper.CallBackGet(message.Body.ToString());
                }
                else
                {
                    //无法识别标签内容
                    throw new ApplicationException("无法识别标签内容");
                }

                //程序处理返回的结果
                json = (JsonHelper)JsonHelper.ReturnObject(reMeg, typeof(JsonHelper));

                if (json.RetCode.ToLower() == "error") //程序处理失败
                {

                    throw new ApplicationException($"程序处理失败,{json.RetMessage}");
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

    public class CallBackHelper
    {
        public static string CallBackGet(string json)
        {
            JsonHelper jsons = new JsonHelper();
            try
            {
                var callBack = (JsonHelper)JsonHelper.ReturnObject(json, typeof(JsonHelper));
                var logService = new TLogService(TLogService.Columns.MessageID, callBack.RetObj);

                //如果回调地址不为空，则执行回调通知
                if (!string.IsNullOrWhiteSpace(logService.CallBackUrl))
                {
                    var url = $"{logService.CallBackUrl}?RetCode={callBack.RetCode}&MessageID={callBack.RetObj}&dt={DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss")}";
                    string result = string.Empty;
                    PushWebHelper.PostToGet(url, ref result);

                    //回调后写入回调日志
                    var service = new ApsMessageService.NewMassgeServiceClient();
                    var log = new ServiceLog { Lable = "AddLog", Context = result, CallBackUrl = url, MessageID = callBack.RetObj.ToString(), MessagePath = "LogService", CreateTime = DateTime.Now };
                    service.InsertMessage(log.MessagePath, log.Lable, JsonHelper.GetJsonO(log), null);
                }


                jsons.RetCode = "Success";
                jsons.RetMessage = "处理完毕";
            }
            catch (Exception e)
            {
                jsons.RetCode = "Error";
                jsons.RetMessage = e.Message;
            }
            return JsonHelper.GetJsonO(jsons);
        }
    }
}