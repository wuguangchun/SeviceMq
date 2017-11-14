using System;
using System.Collections.Generic;
using System.Linq;
using System.Messaging;
using System.Web;
using APSWcfService.Helper;
using Kute.Helper;
using Model;
using ServiceHandle.Helper;
using SubSonic;
using WcfService1.OrderModel;

namespace ServiceHandle.Handle
{
    public class CreateCadOrderHandle
    {

        public static MessageQueue messageQueue { get; set; }
        public static JsonHelper json { get; set; }

        //读取消息队列
        public static void GetMessageQueues()
        {
            try
            {
                var path = ".\\private$\\CadOrder"; 
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
                if (message.Label.ToLower().Trim() == "NewOrder".ToLower())
                {//收到新订单命令
                    if (OrderListHelper.CreateOrderList(message.Body.ToString()))
                    {
                        json.RetCode = "success";
                        json.RetMessage = "生成CAD排程数据成功！";
                    }
                    else
                    {
                        json.RetCode = "success";
                        json.RetMessage = "生成CAD排程数据失败！";
                    }
                }
                else
                {//无法识别标签内容
                    throw new ApplicationException("无法识别标签内容");
                }

                //程序处理返回的结果
                //json = (JsonHelper)JsonHelper.ReturnObject(reMeg, typeof(JsonHelper));

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


    public class OrderListHelper
    {
        public static bool CreateOrderList(string blDateJson)
        {
            try
            {
                var blDate = (BLDate)JsonHelper.ReturnObject(blDateJson, typeof(BLDate));

                string coatType = blDate.order.OrderType == "1" ? "BLMTM" : "BL团装";
                int specialTime = 0;
                string specialCode = "";
                GetSpecialTime(blDate.ordermx, ref specialTime, ref specialCode);

                //特殊体型的判别标准
                string tstx = "";
                if (!string.IsNullOrWhiteSpace(blDate.order.Tstx))
                {
                    tstx = "TSTX";
                }

                TAnalysisOrderList tAnalysisOrderList = new TAnalysisOrderList
                {
                    OrderId = tstx + DataHelper.GenerateOrderNumber(),
                    CustomerId = blDate.order.Khdh,
                    Project = "CAD",
                    OrderType = coatType,
                    BodyType = GetMinBodyType(blDate.order.Txtz).ToString(),
                    OrderTime = blDate.order.Trantime == null ? DateTime.Now : DateTime.Parse(blDate.order.Trantime),
                    DeliveryTime = blDate.order.Jhrq == null ? DateTime.Now : DateTime.Parse(blDate.order.Jhrq),
                    SupportingWay = blDate.order.Sldl,
                    Sizes = blDate.ordermx.First().Hxjg,
                    Customer = blDate.order.Customername,
                    CreateTime = blDate.order.Createtime == null ? DateTime.Now : DateTime.Parse(blDate.order.Createtime),
                    CreateDate = DateTime.Now,
                    Gydm = blDate.order.Txtz,
                    Audittime = blDate.order.Audittime == null ? DateTime.Now : DateTime.Parse(blDate.order.Audittime),
                    Scggdh = blDate.order.Ecode,
                    Mflxx = GetYlbmStr(blDate.ordermx),
                    Numbers = 1,  //全部为1？？？？
                    CoatType = coatType + "-" + GetCoatType(blDate.ordermx),
                    Fabric = blDate.ordermx.First().Mlbm,
                    SpecialTime = specialTime,
                    SpecialCode = specialCode,
                    StylesResult = GetStylesResult(blDate.ordermx),
                    Styles = GetStyles(blDate.ordermx),
                    OrderStatus = "0",
                    Pbcd = blDate.order.Pbcd,
                    Tzecode = blDate.order.Tzecode,
                    Sfbcpsy = string.IsNullOrWhiteSpace(blDate.ordermx.First().Sfbcpsy) ? "0" : blDate.ordermx.First().Sfbcpsy,
                    Gylx = blDate.ordermx.First().Gylx
                };

                tAnalysisOrderList.Save();
            }
            catch (Exception)
            {
                throw;
            }
            return true;
        }

        //生成SpecialTime字段
        public static void GetSpecialTime(List<Ordermx> list, ref int specialTime, ref string specialCodess)
        {
            try
            {
                string specialCode = "";
                foreach (var ordermx in list)
                {
                    specialCode += ordermx.Gyxx;
                }
                string[] specialCodes = specialCode.Split(',');

                SqlQuery q = new Select().From<TBasisSpecialList>()
                    .Where(TBasisSpecialList.Columns.SpecialCode).In(specialCodes);

                var oList = q.ExecuteTypedList<TBasisSpecialList>();
                foreach (var basisSpecialList in oList)
                {
                    specialTime += int.Parse(basisSpecialList.SpecialTime.ToString());
                    specialCodess += basisSpecialList.SpecialCode;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        //生成BodyType字段
        public static double GetMinBodyType(string bodytype)
        {
            try
            {
                SqlQuery q = new Select(new string[] { "Efficiency" }).From<TBasisBodyList>()
                    .Where(TBasisBodyList.Columns.Id).IsNotNull();

                string[] bodytupes = bodytype.Split(',');

                for (int i = 0; i < bodytupes.Length; i++)
                {
                    if (i == 0)
                        q.And(TBasisBodyList.Columns.BodyCode).IsEqualTo(bodytupes[i]);
                    else
                        q.Or(TBasisBodyList.Columns.BodyCode).IsEqualTo(bodytupes[i]);
                }
                q.OrderAsc(new string[] { "Efficiency" });
                double bodype = q.ExecuteScalar<double>();
                return bodype > 0 ? bodype : 1.0;
            }
            catch (Exception)
            {

                throw;
            }
        }

        //生成Ylbm字段
        public static string GetYlbmStr(List<Ordermx> objectrdermxes)
        {
            List<string> list = new List<string>();
            string ylbm = "";

            list.Add(objectrdermxes.First().mflxx.First().Ylbm);
            foreach (var obj in objectrdermxes)
            {
                foreach (var mflxx in obj.mflxx)
                {
                    if (list.IndexOf(mflxx.Ylbm) == -1) list.Add(mflxx.Ylbm);
                }

            }

            foreach (var str in list)
            {
                ylbm += str + ",";
            }

            return ylbm.Substring(0, ylbm.Length - 1);
        }

        //生成CoatType字段
        public static string GetCoatType(List<Ordermx> list)
        {
            try
            {
                List<string> str = new List<string>();
                string fzfls = "";
                //Fzfl服装分类
                str.Add(list.First().Fzfl);

                foreach (var ordermx in list)
                {
                    if (str.IndexOf(ordermx.Fzfl) == -1)
                    {
                        str.Add(ordermx.Fzfl);
                    }
                }

                foreach (var fzfl in str)
                {
                    fzfls += fzfl + ",";
                }

                SqlQuery q = new Select(new string[] { "CoatCode" }).From<TBasisCoatList>()
                    .Where(TBasisCoatList.Columns.CoatAlias).IsEqualTo(fzfls.Substring(0, fzfls.Length - 1));
                return q.ExecuteScalar<string>();
            }
            catch (Exception)
            {
                throw;
            }
        }

        //生成StylesResult字段
        public static string GetStylesResult(List<Ordermx> list)
        {
            try
            {
                List<string> listStyle = new List<string>();
                string styles = "";//处理结果后的值

                listStyle.Add(list.First().Ksjg);
                foreach (var ordermx in list)
                {
                    if (listStyle.IndexOf(ordermx.Ksjg) == -1)
                    {
                        listStyle.Add(ordermx.Ksjg);
                    }
                }

                foreach (var str in listStyle)
                {
                    styles += str + ",";
                }

                return styles.Substring(0, styles.Length - 1);

            }
            catch (Exception)
            {
                throw;
            }
        }

        //生成Styles字段
        public static string GetStyles(List<Ordermx> list)
        {
            try
            {
                List<string> listStyle = new List<string>();
                string styles = "";//处理结果后的值

                if (!string.IsNullOrWhiteSpace(list.First().Ksh))
                    listStyle.Add(list.First().Ksh);
                foreach (var ordermx in list)
                {
                    if (listStyle.IndexOf(ordermx.Ksjg) == -1)
                    {
                        if (!string.IsNullOrWhiteSpace(list.First().Ksh))
                            listStyle.Add(ordermx.Ksh);
                    }
                }


                foreach (var str in listStyle)
                {
                    if (!string.IsNullOrWhiteSpace(str))
                        styles += str + ",";
                }
                if (!string.IsNullOrWhiteSpace(list.First().Ksh))
                    return styles.Substring(0, styles.Length - 1);
                return null;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}