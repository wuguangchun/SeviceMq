using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.ServiceModel;
using System.Text;
using System.Threading;
using System.Timers;
using APSData;
using APSWcfService.Helper;
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
            string result = string.Empty;

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

            //var list = new Select().From<VNoKeyProcess>().ExecuteTypedList<VNoKeyProcess>();
            //foreach (var keyProcess in list)
            //{
            //    var service = new ServiceTest.NewMassgeServiceClient();
            //    service.InsertMessage("OrderGetMesHour", "KeyProcess", keyProcess.MxId.ToString(), null); 
            //}

            //var list=new Select().From<VOrderListFZXf>().ExecuteTypedList<VOrderListFZXf>();

            //foreach (var artInfo in list)
            //{
            //    try
            //    { 
            //            var service = new ServiceTest.NewMassgeServiceClient();
            //            service.InsertMessage("PlanInfo", "NewPlan", artInfo.Khdh, null); 
            //    }
            //    catch (Exception e)
            //    {
            //        Console.WriteLine(e); 
            //    }
            //}

            var list = new Select().From<VOrderListFZXf>().ExecuteTypedList<VOrderListFZXf>();

            //生成订单数据字表
            var ordermxList = new Select().From<TBLDataOrdermx>().Where(TBLDataOrdermx.KhdhColumn).In(list.ConvertAll(x => x.Khdh))
                .ExecuteTypedList<TBLDataOrdermx>();

            var mxList = new List<TAnalysisOrderMx>();
            foreach (var ordermx in ordermxList)
            {
                var orderMx = new TAnalysisOrderMx
                {
                    Khdh = ordermx.Khdh,
                    Fzfl = ordermx.Fzfl,
                    SpecialCode = GetFZSpecialCode(ordermx.Gyxx.Split(','), ordermx.Fzfl).Replace("[", "").Replace("]", "").Replace("\"", "")
                };

                mxList.Add(orderMx);
            }

            //避免数据重复先删除
            new Delete().From<TAnalysisOrderMx>().Where(TAnalysisOrderMx.KhdhColumn)
                .In(mxList.ConvertAll(x => x.Khdh)).Execute();

            mxList.ForEach(x => x.Save());


            Console.WriteLine(result);
            Console.ReadLine();
        }


        //生成FzSpecial字段 缝制特殊工艺订单
        public static string GetFZSpecialCode(string[] gyxx, string sType)
        {
            try
            {
                var specials = new Select().From<TBasisSpecialCode>()
                    .Where(TBasisSpecialCode.ModelColumn).IsEqualTo("缝制")
                    .And(TBasisSpecialCode.SpecialTypeColumn).IsEqualTo(sType)
                    .And(TBasisSpecialCode.SpecialCodeColumn).In(gyxx)
                    .ExecuteTypedList<TBasisSpecialCode>();

                var listcode = specials.ConvertAll(x => x.SpecialCode);
                return JsonConvert.SerializeObject(listcode);

            }
            catch (Exception e)
            {
                throw;
            }
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

            Thread thread302 = new Thread(ServiceHelper.CompletionTest302) { IsBackground = true };
            thread302.Start();
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
                        .Where(TAnalysisOrderList.OrderStatusColumn).IsEqualTo("302")
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
