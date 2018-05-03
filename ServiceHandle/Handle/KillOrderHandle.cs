using System;
using System.Collections.Generic;
using System.Linq;
using System.Messaging;
using System.Threading;
using System.Web;
using DataModels.ModelsOther;
using IntelligentLogHelper;
using Kute.Helper;
using Model;
using SubSonic;
using KillOrderPlugs;
using Newtonsoft.Json;
using ServiceHandle.ModelsOther;

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
                //撤单前暂停所有进程，避免锁表删数据超时 ---也不用考虑启用进程，因为在全局中有进程自检类
                Helper.AutoStart.threads.FindAll(x => x.Name != "KillOrder" && x.ThreadState == ThreadState.Running).ForEach(x => x.Suspend());

                var mq = (MessageQueue)sender;
                message = mq.EndReceive(e.AsyncResult);

                //根据消息标签执行相应的命令
                if (message.Label.ToLower().Trim() == "KillOrder".ToLower())
                {


                    reMeg = new KillOrderHelper().KillOrder(message.Body.ToString());

                }
                else if (message.Label.ToLower().Trim() == "KillSingle".ToLower())
                {
                    reMeg = new KillOrderHelper().KillSingle(message.Body.ToString());
                }
                else if (message.Label.ToLower().Trim() == "KillSingleERP".ToLower())//投诉异常：需要新增队列通知
                {
                    try
                    {
                        var killOrder = (OrderKill)JsonConvert.DeserializeObject(message.Body.ToString(), typeof(OrderKill));

                        var service = new EepPlanService.DdcxMainDelegateClient();
                        var result = service.ddcx(@"{'SCYSPD':'" + killOrder.CustmerId + "','FZFL':'" + killOrder.OrderFl + "'}");
                        if (!result.ToLower().Contains("true"))
                        {
                            throw new Exception(result);
                        }
                        else
                        {
                            json.RetCode = "success";
                            json.RetMessage = result;
                        }
                    }
                    catch (Exception exception)
                    {
                        throw;

                    }
                }
                else if (message.Label.ToLower().Trim() == "MoveOld".ToLower())
                {
                    reMeg = new IntelligentLog().MoveOld(message.Body.ToString());
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


}