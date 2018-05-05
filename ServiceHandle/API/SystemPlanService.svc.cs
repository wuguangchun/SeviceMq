using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Text;
using Kute.Helper;
using Newtonsoft.Json;
using PlanInfoPlugs;
using ServiceHelper.Helper;
using TestService.Helper;

namespace ServiceHandle.API
{
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码、svc 和配置文件中的类名“SystemPlanService”。
    // 注意: 为了启动 WCF 测试客户端以测试此服务，请在解决方案资源管理器中选择 SystemPlanService.svc 或 SystemPlanService.svc.cs，然后开始调试。
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Required)]
    public class SystemPlanService : ISystemPlanService
    {
        public string AutoCyPlan(DateTime beginTime)
        {
            var json = new JsonHelper();
            try
            {
                var result = new AutoPlanCy().OrderScreen(beginTime);
                json.RetCode = RetCode.Success;
                json.RetMessage = result;
                json.RetObj = new DataHelper().GetTimeStamp();//时间戳
            }
            catch (Exception e)
            {
                json.RetCode = RetCode.Error;
                json.RetMessage = e.Message;
                json.RetObj = new DataHelper().GetTimeStamp();//时间戳
            }

            return JsonConvert.SerializeObject(json);
        }

        public string AutoXfPlan(DateTime beginTime)
        {
            var json = new JsonHelper();
            try
            {
                var result = new AutoPlanXf().OrderScreen(beginTime);
                json.RetCode = RetCode.Success;
                json.RetMessage = result;
                json.RetObj = new DataHelper().GetTimeStamp();//时间戳
            }
            catch (Exception e)
            {
                json.RetCode = RetCode.Error;
                json.RetMessage = e.Message;
                json.RetObj = new DataHelper().GetTimeStamp();//时间戳
            }

            return JsonConvert.SerializeObject(json);
        }
    }
}
