using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModels.ModelsOther;
using Kute.Helper;
using Model;
using Newtonsoft.Json;
using ServiceHandle.ModelsOther;
using SubSonic;

namespace CompletionPlugs
{

    public class CompletionHelper
    {
        JsonHelper Json = new JsonHelper();

        public string EditCompletion(string json)
        {
            try
            {
                //反序列化生成对象--Completion
                var objCompletion = (Completion)JsonHelper.ReturnObject(json, typeof(Completion));

                var data = new Select("count(*)").From<TBLDataOrder>().Where(TBLDataOrder.KhdhColumn)
                    .IsEqualTo(objCompletion.CustmerId).ExecuteScalar();


                if (int.Parse(data.ToString()) > 0)
                {
                    //订单暂停
                    if (objCompletion.OrderSrate == "7776")
                    {
                        //过渡过程需要同时在新/旧表中更新状态
                        var orderStatus = new TBasisOrderStatus(objCompletion.CustmerId)
                        {
                            CreateDate = DateTime.Now,
                            CustomerId = objCompletion.CustmerId
                        };
                        orderStatus.OrderStatus += "-P";
                        orderStatus.Save();
                    }
                    //订单恢复
                    else if (objCompletion.OrderSrate == "7777")
                    {
                        //过渡过程需要同时在新/旧表中更新状态
                        var orderStatus = new TBasisOrderStatus(objCompletion.CustmerId)
                        {
                            CreateDate = DateTime.Now,
                            CustomerId = objCompletion.CustmerId,
                        };
                        orderStatus.OrderStatus = orderStatus.OrderStatus.Replace("-P", "");
                        orderStatus.Save();
                    }
                    //订单状态更新
                    else
                    {

                        //过渡过程需要同时在新/旧表中更新状态
                        var orderStatus = new TBasisOrderStatus(objCompletion.CustmerId)
                        {
                            CreateDate = DateTime.Now,
                            CustomerId = objCompletion.CustmerId,
                            OrderStatus = objCompletion.OrderSrate
                        };
                        orderStatus.Save();
                    }

                    //如果完工汇报是计划审核下达则触发新消息队列NewByCF获取排版长度及生成表OrderListByCF
                    if (objCompletion.OrderSrate == "201")
                    {
                        var msmqList = new List<MsmqModel>
                        {
                            new MsmqModel{Path = "CaiJianOrder",Label = "NewOrder",Body = objCompletion.CustmerId,CallBackUrl = null},
                            new MsmqModel{Path = "PlanInfo",Label = "NewPlan",Body = objCompletion.CustmerId,CallBackUrl = null}
                        };

                        Json.RetMessage = JsonConvert.SerializeObject(msmqList);
                        Json.RetCode = "Proceed";
                    }

                    //如果完工汇报是裁床排程成功则出发新消息队列BlankingData生成断料数据(老APS给的完工汇报)
                    else if (objCompletion.OrderSrate == "300")
                    {

                        var msmqList = new List<MsmqModel>
                        {
                            new MsmqModel{Path = "BlankingData",Label = "NewOrder",Body = objCompletion.CustmerId,CallBackUrl = null}
                        };

                        Json.RetMessage = JsonConvert.SerializeObject(msmqList);
                        Json.RetCode = "Proceed";
                    }
                    else
                    {
                        Json.RetMessage = $@"操作成功！{objCompletion.CustmerId}";
                        Json.RetCode = "success";
                    }


                }
                else
                {
                    throw new Exception($@"操作失败，APS无基础订单信息！{objCompletion.CustmerId}");
                }
            }
            catch (Exception exception)
            {
                Json.RetMessage = exception.Message;
                Json.RetCode = "error";
            }
            return JsonConvert.SerializeObject(Json);
        }

    }
}
