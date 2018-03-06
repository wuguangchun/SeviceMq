using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Management;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.ServiceModel;
using System.Text;
using System.Threading;
using System.Timers;
using DataModels.ModelsOther;
using Kute.Helper;
using Model;
using Newtonsoft.Json;
using ServiceHandle.Helper;
using ServiceHandle.ModelsOther;
using ServiceHelper;
using SubSonic;
using TestService.Helper;
using TestService.ModelsOther;

namespace TestService
{
    class Program
    {
        static void Main(string[] args)
        {
            string result = string.Empty;

            while (true)
            {
                //测试计划生成
                var beginTime = DateTime.Parse("2018-02-23 15:00");
                result = new AutoPlanXf().OrderScreen(beginTime);
                // DateTime.Now.Date.AddHours(10);

                //var service = new PlanService.SystemPlanServiceClient();
                //result = service.AutoXfPlan(beginTime);
                //service.Close();


                //var service=new ServiceTest.NewMassgeServiceClient();
                //result=service.InsertMessage("KillOrder", "KillSingle", "{\"remark\":\"{ 撤单类型：bfcx; 产品大类：MXF; 撤单数量：3; 撤单原因不想要了}\",\"CustmerId\":\"YEQ518010012\",\"CallingParty\":\"BPM\",\"OrderFl\":\"MXF\"}",null);


                Console.WriteLine(result);
                Console.ReadLine();
            }
        }
    }
}
