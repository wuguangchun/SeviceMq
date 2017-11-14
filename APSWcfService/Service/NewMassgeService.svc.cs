using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Text;
using System.Threading;
using APSWcfService.Helper;

namespace APSWcfService.Service
{
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码、svc 和配置文件中的类名“NewMassgeService”。
    // 注意: 为了启动 WCF 测试客户端以测试此服务，请在解决方案资源管理器中选择 NewMassgeService.svc 或 NewMassgeService.svc.cs，然后开始调试。
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Required)]
    public class NewMassgeService : INewMassgeService
    {
        JsonHelper json = new JsonHelper();
        public string InsertMessage(string messgePath, string label, string body, string callBackUrl = null)
        {
            string messageId = string.Empty;
            try
            {
                //添加消息队列消息
                messageId = MessageHelper.AddMessageQueue($".\\private$\\{messgePath}", label, body);

                //添加服务日志队列
                var log = new TLogService { Lable = label, Context = body, CallBackUrl = callBackUrl, MessageID = messageId, MessagePath = messgePath, CreateTime = DateTime.Now };
                MessageHelper.AddMessageQueue($".\\private$\\LogService", "AddLog", JsonHelper.GetJsonO(log));

                json.RetCode = "Success";
                json.RetObj = messageId;
                json.RetMessage = $"加入消息成功,处理结果会异步通知到回调地址！";

                #region 激活处理程序
                Thread threadLog = new Thread(TestServiceHandle) { IsBackground = true };
                threadLog.Start();
                #endregion

            }
            catch (Exception e)
            {
                json.RetCode = "Error";
                json.RetMessage = e.Message;
                new MailHelper().SendMail(e.Message, "NewMsmqSevice接口异常-APS预警", "wuguangchunn@foxmail.com");
                LogHelper.SaveLogs(e.Message);
            }

            return JsonHelper.GetJsonO(json);
        }

        private void TestServiceHandle()
        {
            try
            {
                var service = new ServiceHandle.ActivationServiceClient();
                service.DoWork();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }



    public class TLogService
    {
        public string Lable { get; set; }
        public string Context { get; set; }
        public string CallBackUrl { get; set; }
        public string MessageID { get; set; }
        public string MessagePath { get; set; }
        public DateTime CreateTime { get; set; }

    }
}
