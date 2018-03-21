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
                var beginTime = DateTime.Parse("2018-02-23 15:00");
                //result = new AutoPlanXf().OrderScreen(beginTime);
                // DateTime.Now.Date.AddHours(10);




                //所有已下达的计划重新生成Excle
                //var list = new Select().From<SCT26>()
                //    .Where(SCT26.SczsztColumn).IsEqualTo("X")
                //    .ExecuteTypedList<SCT26>();
                //string lable = string.Empty;
                //foreach (var str in list)
                //{
                //    lable = "TZ";
                //    if (str.Sczsbz.Contains("XM") || str.Sczsbz.Contains("XS") || str.Sczsbz.Contains("CM") ||
                //        str.Sczsbz.Contains("CS"))
                //    {
                //        lable = "MTM";
                //    }
                //    else
                //    {
                //        continue;
                //    }
                //    var service = new LocalService.NewMassgeServiceClient();
                //    result = service.InsertMessage("GenerateFile", lable, str.Sczsbh, null);

                //    Console.ReadLine();
                //    //Console.WriteLine(result);
                //}

                var service = new APSService.NewMassgeServiceClient();
                result = service.InsertMessage("GenerateFile", "MTM", "CM180300763", null);

                Console.WriteLine("已全部执行完：" + result);
            }
        }
    }
}
