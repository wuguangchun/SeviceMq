using System;
using System.Collections.Generic;
using System.Linq;
using System.Messaging;
using System.Text;
using System.Web;
using Kute.Helper;
using Model;
using ServiceHandle.Helper;
using SubSonic;

namespace ServiceHandle.Handle
{
    public class PutCadHandle
    {
        public static MessageQueue messageQueue { get; set; }
        public static JsonHelper json { get; set; }

        //读取消息队列
        public static void GetMessageQueues()
        {
            try
            {
                var path = ".\\private$\\PutCadBL";
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
                if (message.Label.ToLower().Trim() == "CADScheduling".ToLower())
                {
                    //接收BL传入数据源
                    reMeg = ApsCadDataPushToBLHelper.PushToBl(message.Body.ToString());
                }
                else if (message.Label.ToLower().Trim() == "SchedulingReady".ToLower())
                {
                    //接收BL传入数据源
                    reMeg = ApsCadDataPushToBLHelper.PushToMq(message.Body.ToString());
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

    public class ApsCadDataPushToBLHelper
    {
        private static JsonHelper json = new JsonHelper();

        //将排程数据给BL
        public static string PushToBl(string jsonBody)
        {
            try
            {
                json.RetMessage = "";
                string s = "";

                //这里写引用提交到BL

                //测试接口
                //PushWebHelper.PostToPost("http://172.16.7.124:8083/rest/aps/apspcsj", jsonBody, ref s);

                //正式接口
                PushWebHelper.PostToPut("http://172.16.7.127:8000/rest/aps/apspcsj", jsonBody, ref s);

                var blObj = (BlReturnMsg)JsonHelper.ReturnObject(s, typeof(BlReturnMsg));

                if (blObj.S == "1")
                {
                    ////Json解析，获取客户单号
                    //var orderId =
                    //    ((CadBlModelList)JsonHelper.ReturnObject(jsonBody, typeof(CadBlModelList))).ds.First()
                    //    .customerId;

                    ////更新CAD排程表
                    //new Update(TBLCADTemp.Schema)
                    //    .Set(TBLCADTemp.StateColumn).EqualTo(0)
                    //    .Where(TBLCADTemp.CustomerIDColumn).IsEqualTo(orderId)
                    //    .Execute();

                    json.RetCode = "error";
                    json.RetMessage = blObj.Rs;

                }
                else
                {
                    json.RetCode = "success";
                    json.RetMessage = blObj.Rs;

                }

                return JsonHelper.GetJsonO(json);
            }
            catch (Exception)
            {
                throw;
            }
        }

        //检索数据插入到队列
        public static string PushToMq(string project)
        {
            JsonHelper json = new JsonHelper();
            try
            {
                var resource = new Select().From<TBasisResource>().ExecuteTypedList<TBasisResource>();
                var query = new Select().From<TAnalysisOutputList>()
                    .Where(TAnalysisOutputList.ProjectColumn).IsEqualTo(project.ToLower().Contains("cy") ? "CY" : "CAD西服");
                var orderResult = query.ExecuteTypedList<TAnalysisOutputList>();
                foreach (var outputList in orderResult)
                {
                    CadBlModelList ds = new CadBlModelList
                    {
                        ds = new List<CadBlModel>
                        {
                            new CadBlModel{
                                customerId = outputList.OrderNo,
                                jobCode = outputList.JobCode,
                                project = outputList.Project,
                                abnormal = outputList.Abnormal,
                                note = outputList.Note,
                                resources = resource.Find(x=>x.ResourcesCode==outputList.Resources).Resources ,
                                beginTime = outputList.BeginTime.ToString().Replace("/","-"),
                                endTime = outputList.EndTime.ToString().Replace("/","-"),
                                makeTime = outputList.MakeTime,
                                createDate =DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss"),
                                mtmortz = outputList.OrderType.ToLower().Contains("mtm")?"1":"0",
                                grabTime =DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss")
                            }
                        }
                    };

                    //将数据插入到消息队列，等待推送
                    var service = new ApsMessageService.NewMassgeServiceClient();
                    service.InsertMessage("PutCadBL", "CADScheduling", JsonHelper.GetJsonO(ds), null);

                    //测试用只传输一条
                    //break;
                }

                json.RetCode = "success";
                json.RetMessage = $"加入队列无异常，共{orderResult.Count}条数据！";
            }
            catch (Exception e)
            {
                json.RetCode = "error";
                json.RetMessage = e.Message;
            }
            return JsonHelper.GetJsonO(json);
        }
    }

    public class BlReturnMsg
    {
        public string S { get; set; }
        public string Rs { get; set; }
    }

    public class CadBlModel
    {
        public string customerId { get; set; }
        public string jobCode { get; set; }
        public string project { get; set; }
        public string abnormal { get; set; }
        public string note { get; set; }
        public string resources { get; set; }
        public string beginTime { get; set; }
        public string endTime { get; set; }
        public string makeTime { get; set; }
        public string createDate { get; set; }
        public string mtmortz { get; set; }
        public string grabTime { get; set; }
    }

    public class CadBlModelList
    {
        public List<CadBlModel> ds { get; set; }
    }

}