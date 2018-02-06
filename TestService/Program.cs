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
                var beginTime = DateTime.Now.Date.AddHours(10);
                new AutoPlanXf().OrderScreen(beginTime);

                Console.WriteLine(result);
                Console.ReadLine();

            }

        }
    }
}
