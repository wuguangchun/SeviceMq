using System;
using System.Collections.Generic;
using System.Linq;
using System.Messaging;
using System.Web;
using Kute.Helper;
using Model;
using Newtonsoft.Json;
using ServiceHandle.Helper;
using SubSonic;
using TestService.ModelsOther;

namespace ServiceHandle.Handle
{
    public class OrderMESArtInfoHandle
    {
        public static MessageQueue messageQueue { get; set; }
        public static JsonHelper json { get; set; }

        //读取消息队列
        public static void GetMessageQueues()
        {
            try
            {
                var path = ".\\private$\\ordergetmeshour";
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
                {//接收BL传入数据源
                    reMeg = ArtInfo.GetMesArtInfo(message.Body.ToString());
                }
                else
                {//无法识别标签内容
                    throw new Exception("无法识别标签内容");
                }

                //程序处理返回的结果
                json = (JsonHelper)JsonHelper.ReturnObject(reMeg, typeof(JsonHelper));


                //处理成功，回调URL通知
                var service = new ApsMessageService.NewMassgeServiceClient();
                service.InsertMessage("CallBackMsg", "Message", JsonHelper.GetJsonO(new JsonHelper { RetCode = "Success", RetMessage = "处理成功", RetObj = message.Id }), null);

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


    public class ArtInfo
    {
        public static string GetMesArtInfo(string khdh)
        {
            try
            {
                var orders = new TBLDataOrder(TBLDataOrder.KhdhColumn.ToString(), khdh);
                var ordermx = new Select().From<TBLDataOrdermx>().Where(TBLDataOrdermx.OrderidColumn).IsEqualTo(orders.Orderid).ExecuteTypedList<TBLDataOrdermx>();


                List<MesModels> list = new List<MesModels>();
                foreach (var order in ordermx)
                {
                    var mfl = new Select().From<TBLDataMflxx>().Where(TBLDataMflxx.MxidColumn).IsEqualTo(order.Mxid).And(TBLDataMflxx.YllxColumn).IsEqualTo("ML").ExecuteTypedList<TBLDataMflxx>().FirstOrDefault();

                    //实例化参数对象
                    MesModels mesM = new MesModels
                    {
                        SysCode = orders.Scggdh,//系统单号
                        Sort = order.Fzfl,//大类
                        FabricType = mfl.Tg,//面料外观  Tg
                        ReturnState = "",
                        FailureReason = "",
                        ListOrderArts = order.Gyxx.Split(',').ToList(),
                        listStepCode = new List<ListStepCodes>
                        {//工序 工时集合
                            new ListStepCodes{StepCode = "182",StepHour = 0}
                        }
                    };

                    //实例化参数所需的工序工时对象
                    var listStepCodes = new List<ListStepCodes>();
                    var gxList = new Select().From<TBasisSewingProcess>().Where(TBasisSewingProcess.CodeTypeColumn).IsEqualTo(order.Fzfl).ExecuteTypedList<TBasisSewingProcess>();
                    foreach (var sewing in gxList)
                    {
                        listStepCodes.Add(new ListStepCodes { StepCode = sewing.Procedure, StepHour = 0 });
                    }

                    mesM.listStepCode = listStepCodes;
                    list.Add(mesM);

                    var json = JsonConvert.SerializeObject(list);
                    string result = string.Empty;

                    //Pust请求Mes接口
                    PushWebHelper.PostToPost($"http://172.16.7.3:10010/api/QueryEstimateSalary", json, ref result);

                    var obj = (List<MesModels>)JsonConvert.DeserializeObject(result, typeof(List<MesModels>));

                    var listStepCode = obj.FirstOrDefault()?.listStepCode;
                    List<TOrderMESArtInfo> listart = new List<TOrderMESArtInfo>();
                    foreach (var stepCodese in listStepCode ?? new List<ListStepCodes>())
                    {
                        //先清空下该条明细的工时信息（预防重复）
                        new Delete().From<TOrderMESArtInfo>()
                            .Where(TOrderMESArtInfo.MxIdColumn).IsEqualTo(order.Mxid)
                            .Execute();

                        TOrderMESArtInfo artInfo = new TOrderMESArtInfo
                        {
                            MxId = order.Mxid,
                            Code = stepCodese.StepCode,
                            Hour = stepCodese.StepHour.ToString(),
                            OrderArtslist = string.Join(",", stepCodese.OrderArtslist.ToArray()),
                            IsNew = true
                        };
                        listart.Add(artInfo); 
                    }

                    //保存到数据库
                    listart.ForEach(x=> x.Clone().Save());

                }
                return JsonHelper.GetJsonO(new JsonHelper { RetCode = "success", RetMessage = "获取成功" });
            }
            catch (Exception e)
            {
                throw;
            }
        }
    }
}