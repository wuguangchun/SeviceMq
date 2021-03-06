﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Management;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.ServiceModel;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using DataModels.ModelsOther;
using Kute.Helper;
using Model;
using Newtonsoft.Json;
using PlanInfoPlugs;
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
                Console.ReadLine();
                //测试计划生成
                //new AutoPlanXf().OrderScreen(DateTime.Parse("2018-03-27 17:00"));

                var khdh = new List<string>()
                {
                    "SV7M18050328", "SV8M18050695", "SV8M18050694", "SV8M18050693", "SV8M18050333", "SV7M18050333", "SV7M18050336", "SV3M18050453", "SV7M18050382", "SV8M18050437"
                };

                foreach (var dh in khdh)
                {
                    var de = new Delivery { DateTime = DateTime.Parse("2018-06-01 00:00"), Khdh = dh };
                    var json = JsonConvert.SerializeObject(de);
                    var service = new APSService.NewMassgeServiceClient();
                    result += "\r\n" + service.InsertMessage("NewOrderData", "UpdateDelivery", json, null);

                }
                //交期修改

                Console.WriteLine("已全部执行完：" + result);
            }
        }
    }

    public class AutoPlan
    {
        public void AutoPlanAsync()
        {

            var beginTime = DateTime.Parse("2018-03-27 09:00");
            var service = new PlanService.SystemPlanServiceClient();

            string s = service.AutoXfPlanAsync(beginTime).Result;
            Console.WriteLine(s);
        }
    }

    public class CreateFile
    {
        public void CreateAll()
        {
            string result = string.Empty;
            //所有已下达的计划重新生成Excle
            var list = new Select().From<SCT26>()
                .Where(SCT26.SczsztColumn).IsEqualTo("X")
                .And(SCT26.SczsbhColumn).Like("XM%")
                .Or(SCT26.SczsbhColumn).Like("XS%")
                .Or(SCT26.SczsbhColumn).Like("CM%")
                .Or(SCT26.SczsbhColumn).Like("CS%")
                .ExecuteTypedList<SCT26>();
            string lable = string.Empty;
            foreach (var str in list)
            {
                lable = "TZ";
                if (str.Sczsbh.Contains("XM") || str.Sczsbh.Contains("XS") || str.Sczsbh.Contains("CM") ||
                    str.Sczsbh.Contains("CS"))
                {
                    lable = "MTM";
                }

                var service = new LocalService.NewMassgeServiceClient();
                result = service.InsertMessage("GenerateFile", lable, str.Sczsbh, null);

                Console.WriteLine(result);
            }

        }
    }
}
