using System;
using System.Collections.Generic;
using System.Linq;
using System.Messaging;
using System.Web;
using APSWcfService.Helper;
using Kute.Helper;
using Model;
using SubSonic;
using TestService.ModelsOther;

namespace ServiceHandle.Handle
{
    public class NewOrderHandle
    {
        public static MessageQueue messageQueue { get; set; }
        public static JsonHelper json { get; set; }

        //读取消息队列
        public static void GetMessageQueues()
        {
            try
            {
                var path = ".\\private$\\NewOrderData";
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
                if (message.Label.ToLower().Trim() == "BlPutData".ToLower())
                {//接收BL传入数据源
                    reMeg = NewBLOrder.SavaData(message.Body.ToString());
                }
                else
                {//无法识别标签内容
                    throw new ApplicationException("无法识别标签内容");
                }

                //程序处理返回的结果
                json = (JsonHelper)JsonHelper.ReturnObject(reMeg, typeof(JsonHelper));

                if (json.RetCode.ToLower() == "error")//程序处理失败
                {

                    throw new ApplicationException($"程序处理失败,{json.RetMessage}");
                }
                else
                {
                    //处理成功，回调URL通知
                    var service = new ApsMessageService.NewMassgeServiceClient();
                    service.InsertMessage("CallBackMsg", "Message", JsonHelper.GetJsonO(new JsonHelper { RetCode = "Success", RetMessage = "处理成功", RetObj = message.Id }), null);
                }
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

    #region 新订单处理方案
    /// <summary>
    /// 新订单数据
    /// </summary>
    public class NewBLOrder
    {
        //实例化数帮助类（包含直接获取Json反序列化，静态调用反序列化需传入对象）
        private static JsonHelper json = new JsonHelper();
        public static string SavaData(string order)
        {
            try
            {
                //Json反序列化生成对象
                List<BLData> blDateList = (List<BLData>)JsonHelper.ReturnObject(order, typeof(List<BLData>));

                //判断对象长度
                if (blDateList.Count < 0)
                {
                    //执行失败
                    json.RetCode = "error";
                    json.RetMessage = "添加失败，事由：没有传入对象";
                    return JsonHelper.GetJsonO(json);
                }

                //循环整个对象
                foreach (var blDate in blDateList)
                {
                    #region 判断数据库是否已存在

                    var query = new Select().From<TBLDataOrder>()
                        .Where(TBLDataOrder.KhdhColumn).IsEqualTo(blDate.order.Khdh)
                        .ExecuteTypedList<TBLDataOrder>();

                    //返回数据带入KHDH
                    json.RetObj = blDate.order.Khdh;

                    if (query.Count > 0)
                    {

                        //执行撤单操作后在添加
                        var killJson = KillOrderHelper.KillOrder(blDate.order.Khdh);
                        var log = new ServiceLog
                        {
                            CallBackUrl = null,
                            Context = killJson,
                            CreateTime = DateTime.Now,
                            Lable = "AutoKill",
                            MessageID = "NoMessageId",
                            MessagePath = "none"
                        };

                        var serviceMq = new ApsMessageService.NewMassgeServiceClient();
                        serviceMq.InsertMessage("LogService", "AddLog", JsonHelper.GetJsonO(log), null);
                    }

                    #endregion

                    #region 拆分三张表存入数据库 

                    //TBLDataOrder添加
                    TBLDataOrder tblDataOrder = new TBLDataOrder
                    {
                        Khdh = blDate.order.Khdh,
                        Trantime = blDate.order.Trantime == null ? DateTime.Now : DateTime.Parse(blDate.order.Trantime),
                        Jhrq = blDate.order.Jhrq == null ? DateTime.Now : DateTime.Parse(blDate.order.Jhrq),
                        Createtime = blDate.order.Createtime == null ? DateTime.Now : DateTime.Parse(blDate.order.Createtime),
                        Sldl = blDate.order.Sldl,
                        Customername = blDate.order.Customername,
                        Txtz = blDate.order.Txtz,
                        XhSyKh = blDate.order.Xh_sy_kh,
                        Pbcd = blDate.order.Pbcd,
                        Audittime = blDate.order.Audittime == null ? DateTime.Now : DateTime.Parse(blDate.order.Audittime),
                        Tzecode = blDate.order.Tzecode,
                        Scggdh = blDate.order.Ecode,
                        OrderType = int.Parse(blDate.order.OrderType)
                    };
                    tblDataOrder.Save();
                    if (tblDataOrder.Orderid > 0)
                    {
                        foreach (var ordermx in blDate.ordermx)
                        {
                            //TBLDataMflxx表添加
                            TBLDataOrdermx tblDataOrdermx = new TBLDataOrdermx
                            {
                                Orderid = tblDataOrder.Orderid,
                                Khdh = blDate.order.Khdh,
                                Ksh = ordermx.Ksh,
                                Fzfl = ordermx.Fzfl,
                                Mlbm = ordermx.Mlbm,
                                Ddsl = int.Parse(ordermx.Ddsl),
                                Hxjg = ordermx.Hxjg,
                                Ksjg = ordermx.Ksjg,
                                Gylx = ordermx.Gylx,
                                Sfbcpsy = ordermx.Sfbcpsy,
                                Gyxx = ordermx.Gyxx,
                                Xh = ordermx.Xh
                            };


                            tblDataOrdermx.Save();
                            foreach (var mflxx in ordermx.mflxx)
                            {
                                if (tblDataOrdermx.Mxid > 0)
                                {
                                    TBLDataMflxx tblDataMflxx = new TBLDataMflxx
                                    {
                                        Mxid = tblDataOrdermx.Mxid,
                                        Orderid = tblDataOrdermx.Orderid.ToString(),
                                        Khdh = tblDataOrdermx.Khdh,
                                        Ylbm = mflxx.Ylbm,
                                        Mtml = mflxx.Mtml,
                                        Yllx = mflxx.Yllx,
                                        Yllxmc = mflxx.Yllxmc,
                                        Tg = mflxx.Tg,
                                        Mltgkd = decimal.Parse(mflxx.Mltgkd)

                                    };
                                    tblDataMflxx.Save();

                                    if (tblDataMflxx.Mflxxid > 0)
                                    {
                                        json.RetCode = "success";
                                        json.RetMessage = "添加成功";
                                    }
                                    else
                                    {
                                        json.RetCode = "error";
                                        json.RetMessage = "添加失败：tblDataMflxx表插入失败";
                                        return JsonHelper.GetJsonO(json);
                                    }
                                }
                                else
                                {
                                    json.RetCode = "error";
                                    json.RetMessage = "添加失败：tblDataOrdermx表插入失败";
                                    return JsonHelper.GetJsonO(json);
                                }
                            }
                        }
                    }
                    else
                    {
                        json.RetCode = "error";
                        json.RetMessage = "添加失败：tblDataOrder表插入失败";
                        return JsonHelper.GetJsonO(json);
                    }

                    #endregion

                    #region 生成OrderList表队列命令
                    //生成OrderList表队列接口
                    var service = new ApsMessageService.NewMassgeServiceClient();
                    service.InsertMessage("CadOrder", "NewOrder", JsonHelper.GetJsonO(blDate), null);
                    #endregion

                    #region 生成APS所需字段的基础数据表（新增优化排程所需数据时的计算及数据使用逻辑）
                    //生成OrderList表队列接口
                    var serviceAnalysisOrder = new ApsMessageService.NewMassgeServiceClient();
                    serviceAnalysisOrder.InsertMessage("AnalysisOrder", "NewOrder", JsonHelper.GetJsonO(blDate), null);
                    #endregion

                    #region 生成 新订单获取MES工时 队列命令
                    //现在只计算西服的
                    if (!blDate.ordermx.First().Fzfl.ToLower().Contains("cy"))
                    {
                        var serviceMes = new ApsMessageService.NewMassgeServiceClient();
                        serviceMes.InsertMessage("OrderGetMesHour", "NewOrder", blDate.order.Khdh, null);
                    }
                    #endregion

                }
            }
            catch (Exception e)
            {
                json.RetCode = "error";
                json.RetMessage = "存储异常," + e.Message;
            }
            return JsonHelper.GetJsonO(json);
        }
    }
    #endregion
}