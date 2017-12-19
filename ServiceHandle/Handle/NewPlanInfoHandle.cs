using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Messaging;
using System.Web;
using Kute.Helper;
using Model;
using Newtonsoft.Json;
using ServiceHandle.Helper;
using ServiceHelper.Helper;
using SubSonic;

namespace ServiceHandle.Handle
{
    public class NewPlanInfoHandle
    {


        public static MessageQueue messageQueue { get; set; }
        public static JsonHelper json { get; set; }

        //读取消息队列
        public static void GetMessageQueues()
        {
            try
            {
                var path = ".\\private$\\PlanInfo";
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
                if (message.Label.ToLower().Trim() == "NewPlan".ToLower())
                {//计划下达获取计划详细信息
                    reMeg = new PlanInfo().GetPlanMx(message.Body.ToString());
                }
                else if (message.Label.ToLower().Trim() == "NewPlanMain".ToLower())
                {//计划下达获取计划主信息

                    reMeg = new PlanInfo().GetPlanInfo(message.Body.ToString());
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

    public class PlanInfo
    {
        public string GetPlanMx(string khdh)
        {
            var obj = new JsonHelper();
            try
            {
                var dataOrder = new Select().From<TBLDataOrder>().Where(TBLDataOrder.KhdhColumn).IsEqualTo(khdh).ExecuteTypedList<TBLDataOrder>().FirstOrDefault();

                if (dataOrder == null)
                    throw new Exception("没有找到订单的基础信息");

                var dataTable = new DataHelper().OtherBaseSelect("fyerp", $"select * from sct27 where scggdh = ''{dataOrder.Scggdh}''");

                foreach (DataRow row in dataTable.Rows)
                {
                    SCT27 sct27 = new SCT27
                    {
                        Sczsbh = row["SCZSBH"].ToString(),
                        Schtbh = row["SCHTBH"].ToString(),
                        Schtxh = int.Parse(row["SCHTXH"].ToString()),
                        Scggdh = row["SCGGDH"].ToString(),
                        Scggxh = int.Parse(row["SCGGXH"].ToString()),
                        Xtwpks = row["XTWPKS"].ToString(),
                        Xtwpys = row["XTWPYS"].ToString(),
                        Xtxmdm = row["XTXMDM"].ToString(),
                        Sczssl = int.Parse(row["SCZSSL"].ToString()),
                        Sczsbz = row["SCZSBZ"].ToString(),
                        Sczsph = row["SCZSPH"].ToString(),
                        Scgybz = row["SCGYBZ"].ToString(),
                    };
                    sct27.Save();
                }


                var service = new ApsMessageService.NewMassgeServiceClient();
                service.InsertMessage("PlanInfo", "NewPlanMain", dataTable.Rows[0]["SCZSBH"].ToString(), null);

                obj.RetCode = "success";
                obj.RetMessage = "获取成功";
            }
            catch (Exception e)
            {
                throw;
            }
            return JsonConvert.SerializeObject(obj);
        }

        public string GetPlanInfo(string sczsbh)
        {
            var obj = new JsonHelper();
            try
            {
                var dataOrder = new Select().From<SCT26>().Where(SCT26.SczsbhColumn).IsEqualTo(sczsbh).ExecuteTypedList<SCT26>();

                if (dataOrder.Count < 1)
                {
                    var dataTable = new DataHelper().OtherBaseSelect("fyerp", $"select * from sct26 where sczsbh = ''{sczsbh}''");

                    foreach (DataRow row in dataTable.Rows)
                    {
                        SCT26 sct26 = new SCT26
                        {
                            Sczsbh = row["SCZSBH"].ToString(),
                            Scgcdm = row["SCGCDM"].ToString(),
                            Scjhry = row["SCJHRY"].ToString(),
                            Sczsbz = row["SCZSBZ"].ToString(),
                            Sczszt = row["SCZSZT"].ToString(),
                            Scjqsm = row["SCJQSM"].ToString(),
                            Sclrry = row["SCLRRY"].ToString(),
                            Scshry = row["SCSHRY"].ToString(),
                            Schtbh = row["SCHTBH"].ToString(),
                        };

                        if (!string.IsNullOrEmpty(row["SCXDRQ"].ToString()))
                            sct26.Scxdrq = DateTime.Parse(row["SCXDRQ"].ToString());

                        if (!string.IsNullOrEmpty(row["Sccjjq"].ToString()))
                            sct26.Sccjjq = DateTime.Parse(row["Sccjjq"].ToString());

                        if (!string.IsNullOrEmpty(row["Scfzjq"].ToString()))
                            sct26.Scfzjq = DateTime.Parse(row["Scfzjq"].ToString());

                        if (!string.IsNullOrEmpty(row["Scjhrq"].ToString()))
                            sct26.Scjhrq = DateTime.Parse(row["Scjhrq"].ToString());

                        if (!string.IsNullOrEmpty(row["Scjqrq"].ToString()))
                            sct26.Scjqrq = DateTime.Parse(row["Scjqrq"].ToString());

                        if (!string.IsNullOrEmpty(row["Sclrrq"].ToString()))
                            sct26.Sclrrq = DateTime.Parse(row["Sclrrq"].ToString());

                        if (!string.IsNullOrEmpty(row["Scshrq"].ToString()))
                            sct26.Scshrq = DateTime.Parse(row["Scshrq"].ToString());

                        if (!string.IsNullOrEmpty(row["Scztjq"].ToString()))
                            sct26.Scztjq = DateTime.Parse(row["Scztjq"].ToString());

                        if (!string.IsNullOrEmpty(row["Scbzjq"].ToString()))
                            sct26.Scbzjq = DateTime.Parse(row["Scbzjq"].ToString());

                        if (!string.IsNullOrEmpty(row["Sctcrq"].ToString()))
                            sct26.Sctcrq = DateTime.Parse(row["Sctcrq"].ToString());

                        sct26.Save();

                        break;
                    }
                }

                obj.RetCode = "success";
                obj.RetMessage = "获取成功";
            }
            catch (Exception e)
            {
                throw;
            }
            return JsonConvert.SerializeObject(obj);
        }
    }
}