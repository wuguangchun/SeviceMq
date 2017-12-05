using System;
using System.Collections.Generic;
using System.Linq;
using System.Messaging;
using System.Web;
using Kute.Helper;
using Model;
using ServiceHandle.ModelsOther;
using SubSonic;
using SubSonic.Linq.Structure;

namespace ServiceHandle.Handle
{
    public class CompletionHandle
    {
        public static MessageQueue messageQueue { get; set; }
        public static JsonHelper json { get; set; }

        //读取消息队列
        public static void GetMessageQueues()
        {
            try
            {
                var path = ".\\private$\\Completion";
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
                if (message.Label.ToLower().Trim() == "Completion".ToLower())
                {//接收BL传入数据源
                    reMeg = CompletionHelper.EditCompletion(message.Body.ToString());
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


    public class CompletionHelper
    {
        static JsonHelper Json = new JsonHelper();

        public static string EditCompletion(string json)
        {
            try
            {
                //反序列化生成对象--Completion
                var objCompletion = (Completion)JsonHelper.ReturnObject(json, typeof(Completion));

                var data = new Select("count(*)").From<TBLDataOrder>().Where(TBLDataOrder.KhdhColumn)
                    .IsEqualTo(objCompletion.CustmerId).ExecuteScalar();


                if (int.Parse(data.ToString()) > 0)
                {
                    new Update(TAnalysisOrderList.Schema)
                        .Set(TAnalysisOrderList.Columns.OrderStatus).EqualTo(objCompletion.OrderSrate)
                        .Where(TAnalysisOrderList.Columns.CustomerId).IsEqualTo(objCompletion.CustmerId)
                        .Execute();

                    //过渡过程需要同时在新/旧表中更新状态
                    var orderStatus = new TBasisOrderStatus(objCompletion.CustmerId)
                    {
                        CreateDate = DateTime.Now,
                        CustomerId = objCompletion.CustmerId,
                        OrderStatus = objCompletion.OrderSrate
                    };
                    orderStatus.Save();

                    //如果完工汇报是计划审核下达则触发新消息队列NewByCF获取排版长度及生成表OrderListByCF
                    if (objCompletion.OrderSrate == "201")
                    {
                        //初始化接口
                        var service = new ApsMessageService.NewMassgeServiceClient();
                        service.InsertMessage("CaiJianOrder", "NewOrder", objCompletion.CustmerId, null);
                    }

                    //如果完工汇报是裁床排程成功则出发新消息队列BlankingData生成断料数据(老APS给的完工汇报)
                    else if (objCompletion.OrderSrate == "300")
                    {
                        //初始化接口
                        var service = new ApsMessageService.NewMassgeServiceClient();
                        service.InsertMessage("BlankingData", "NewOrder", objCompletion.CustmerId, null);
                    }


                    Json.RetMessage = $@"操作成功！{objCompletion.CustmerId}";
                    Json.RetCode = "success";
                }
                else
                {
                    throw new Exception($@"操作失败，APS无基础订单信息！{objCompletion.CustmerId}");
                }
            }
            catch (Exception exception)
            {
                Json.RetMessage = exception.Message;
                Json.RetCode = "error";
            }
            return JsonHelper.GetJsonO(Json);
        }

    }
}