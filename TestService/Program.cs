using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.ServiceModel;
using System.Text;
using System.Threading;
using System.Timers;
using APSWcfService.Helper;
using Model;
using Newtonsoft.Json;
using ServiceHandle.Helper;
using ServiceHandle.ModelsOther;
using SubSonic;
using TestService.ModelsOther;

namespace TestService
{
    class Program
    {
        static void Main(string[] args)
        {

            //var comp = new Completion
            //{
            //    CustmerId = "SAE417110077",
            //    CallingParty = "MES",
            //    OrderSrate = "302"
            //};

            //var service=new ServiceOld.NewMessageQueuesClient();
            //var result=service.DoWork("Completion", JsonConvert.SerializeObject(comp));

            //while (true)
            //{
            //    TestMethod();
            //    Console.ReadLine();
            //}

            string result = string.Empty; 
            MesModels mesM = new MesModels
            {
                SysCode = "EUR711230043",//系统单号
                Sort = "MXF",//大类
                FabricType = "素色",//面料外观  Tg
                ReturnState = "",
                FailureReason = "",
                ListOrderArts = new List<string> { "000B", "0001", "00B1", "0521", "0101", "0531", "0541", "0300", "0310", "05A1", "0234", "0851", "085A", "0671", "0012", "0301", "00W5", "0313", "0320", "0640", "0643", "0571", "0648", "064A", "06M1", "04N2", "064C", "05C1", "0621", "06C1", "0638", "0597", "05D1", "0702", "05X1", "057A", "0601", "0731", "0714", "060K", "0724", "0742", "0801", "0612", "0862", "0619", "086A", "061B", "0875", "087H", "087A", "0891", "088D", "0881", "087P", "06S1", "055K", "066A", "0569", "08U2", "09L9", "086Z", "XL25", "XB30", "0728", "XD05", "X016", "X018", "0855", "X02L", "00G3", "00F7", "0X0K", "0413", "0X0Z", "0X10", "0X11", "0X15", "073D", "0X16", "0X17", "00JS", "0X1A", "00V4", "XX0A", "XXX01", "XXX02", "XXX03", "XXX04", "XXX06", "0X23", "XX0B", "0A23", "0X26" },
                listStepCode = new List<ListStepCodes>
                {//工序 工时集合
                    new ListStepCodes{StepCode = "182",StepHour = 0},
                    new ListStepCodes{StepCode = "187",StepHour = 0},
                    new ListStepCodes{StepCode = "175",StepHour = 0},
                    new ListStepCodes{StepCode = "171",StepHour = 0},
                    new ListStepCodes{StepCode = "148",StepHour = 0},
                    new ListStepCodes{StepCode = "132",StepHour = 0},
                    new ListStepCodes{StepCode = "217",StepHour = 0},
                    new ListStepCodes{StepCode = "117",StepHour = 0},
                    new ListStepCodes{StepCode = "75",StepHour = 0},
                    new ListStepCodes{StepCode = "82",StepHour = 0},
                    new ListStepCodes{StepCode = "80",StepHour = 0},
                    new ListStepCodes{StepCode = "959",StepHour = 0},
                    new ListStepCodes{StepCode = "68",StepHour = 0},
                    new ListStepCodes{StepCode = "63",StepHour = 0}
                }
            };
            List<MesModels> list=new List<MesModels>{ mesM };
            var json = JsonConvert.SerializeObject(list);

            PushWebHelper.PostToPost($"http://172.16.7.3:10010//api/QueryEstimateSalary", json, ref result);
            var obj = (MesModels)JsonConvert.DeserializeObject(result, typeof(MesModels));
            Console.WriteLine(result);
            Console.ReadLine();
        }




        
        public static void New201()
        {
            try
            {
                SqlQuery query = new Select().From<TAnalysisOrderList>()
                    .Where(TAnalysisOrderList.OrderStatusColumn).IsEqualTo("201")
                    .And(TAnalysisOrderList.DeliveryTimeColumn).IsGreaterThanOrEqualTo("2017-11-6");

                var list = query.ExecuteTypedList<TAnalysisOrderList>();
                foreach (var orderList in list)
                {
                    var comp = new Completion
                    {
                        CustmerId = orderList.CustomerId,
                        CallingParty = "ERP",
                        OrderSrate = "201"
                    };

                    var service = new APSService.NewMessageQueuesClient();
                    var json = service.DoWork("Completion", JsonConvert.SerializeObject(comp));
                    Console.WriteLine(json);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }

        private static void TestMethod()
        {

            //Thread threadNewOrder = new Thread(ServiceHelper.NewOrderTest) { IsBackground = true };
            //threadNewOrder.Start();

            //Thread thread103 = new Thread(ServiceHelper.CompletionTest103) { IsBackground = true };
            //thread103.Start();

            //Thread thread201 = new Thread(ServiceHelper.CompletionTest201) { IsBackground = true };
            //thread201.Start();

            //Thread thread300 = new Thread(ServiceHelper.CompletionTest300) { IsBackground = true };
            //thread300.Start();

            //Thread thread302 = new Thread(ServiceHelper.CompletionTest302) { IsBackground = true };
            //thread302.Start();
        }


        public class ServiceHelper
        {
            public static void NewOrderTest()
            {
                try
                {
                    String line = string.Empty;
                    using (StreamReader sr = new StreamReader("d:/Json.txt", Encoding.ASCII))
                    {
                        line = sr.ReadToEnd();
                    }

                    List<BLDate> blDateList = (List<BLDate>)JsonConvert.DeserializeObject(line, typeof(List<BLDate>));

                    for (int i = 0; i < 100; i++)
                    {
                        blDateList.First().order.Khdh = DataHelper.GenerateOrderNumber();
                        BLDate bldata = blDateList.First();

                        List<BLDate> list = new List<BLDate>();
                        list.Add(bldata);

                        var service = new ServiceTest.NewMassgeServiceClient();
                        var o = service.InsertMessage("NewOrderData", "BlPutData", JsonConvert.SerializeObject(list),
                            "http://172.16.7.127:8000/rest/aps/dlxxmx");
                        Console.WriteLine(o);
                        Console.WriteLine($"新增订单数据成功，客户单号：{bldata.order.Khdh}");

                    }



                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }

            }

            public static void CompletionTest103()
            {
                try
                {
                    var list = new Select().From<TAnalysisOrderList>()
                        .Where(TAnalysisOrderList.OrderStatusColumn).IsEqualTo("0")
                        .ExecuteTypedList<TAnalysisOrderList>();

                    foreach (var order in list)
                    {
                        var comp = new Completion
                        {
                            CustmerId = order.CustomerId,
                            CallingParty = "BL",
                            OrderSrate = "103"
                        };
                        var service = new ServiceTest.NewMassgeServiceClient();
                        service.InsertMessage("Completion", "Completion", JsonConvert.SerializeObject(comp),
                            "http://172.16.7.127:8000/rest/aps/dlxxmx");

                        Console.WriteLine($"{order.CustomerId}订单更新状态成功,状态更改为{comp.OrderSrate}");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }

            public static void CompletionTest201()
            {
                try
                {
                    var list = new Select().From<TAnalysisOrderList>()
                        //.Where(TAnalysisOrderList.OrderStatusColumn).IsEqualTo("103")
                        //.And(TAnalysisOrderList.OrderTypeColumn).IsEqualTo("BLMTM")
                        .Where(TAnalysisOrderList.CustomerIdColumn).IsEqualTo("17B02546-CY")
                        .OrderDesc(TAnalysisOrderList.DeliveryTimeColumn.ColumnName)
                        .ExecuteTypedList<TAnalysisOrderList>();

                    foreach (var order in list)
                    {
                        var comp = new Completion
                        {
                            CustmerId = order.CustomerId,
                            CallingParty = "ERP",
                            OrderSrate = "201"
                        };
                        var service = new ServiceTest.NewMassgeServiceClient();
                        service.InsertMessage("Completion", "Completion", JsonConvert.SerializeObject(comp),
                            "http://172.16.7.127:8000/rest/aps/dlxxmx");

                        Console.WriteLine($"{order.CustomerId}订单更新状态成功,状态更改为{comp.OrderSrate}");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }

            public static void CompletionTest300()
            {
                try
                {
                    var list = new Select().From<TAnalysisOrderList>()
                        .Where(TAnalysisOrderList.CustomerIdColumn).IsEqualTo("CVSA17100126")
                        //.Where(TAnalysisOrderList.OrderStatusColumn).IsEqualTo("201")
                        .ExecuteTypedList<TAnalysisOrderList>();

                    foreach (var order in list)
                    {
                        var comp = new Completion
                        {
                            CustmerId = order.CustomerId,
                            CallingParty = "OldAPS",
                            OrderSrate = "300"
                        };
                        var service = new ServiceTest.NewMassgeServiceClient();
                        service.InsertMessage("Completion", "Completion", JsonConvert.SerializeObject(comp),
                            "http://172.16.7.127:8000/rest/aps/dlxxmx");

                        Console.WriteLine($"{order.CustomerId}订单更新状态成功,状态更改为{comp.OrderSrate}");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }

            public static void CompletionTest302()
            {
                try
                {
                    var list = new Select().From<TAnalysisOrderList>()
                        .Where(TAnalysisOrderList.OrderStatusColumn).IsEqualTo("300")
                        .ExecuteTypedList<TAnalysisOrderList>();

                    foreach (var order in list)
                    {
                        var comp = new Completion
                        {
                            CustmerId = order.CustomerId,
                            CallingParty = "MES",
                            OrderSrate = "302"
                        };
                        var service = new ServiceTest.NewMassgeServiceClient();
                        service.InsertMessage("Completion", "Completion", JsonConvert.SerializeObject(comp),
                            "http://172.16.7.127:8000/rest/aps/dlxxmx");

                        Console.WriteLine($"{order.CustomerId}订单更新状态成功,状态更改为{comp.OrderSrate}");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }

        }

        public class DataHelper
        {
            /// <summary>
            /// 唯一订单号生成
            /// </summary>
            /// <returns></returns>
            public static string GenerateOrderNumber()
            {
                string strDateTimeNumber = DateTime.Now.ToString("yyyyMMddHHmmssms");
                string strRandomResult = NextRandom(100000, 1).ToString();
                return strDateTimeNumber + strRandomResult;
            }

            private static string NextRandom(int numSeeds, int length)
            {
                Guid guid = new Guid();
                guid = Guid.NewGuid();
                return guid.ToString().Substring(0, guid.ToString().IndexOf('-'));
            }
        }


    }
}
