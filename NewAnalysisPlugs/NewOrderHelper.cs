using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModels.ModelsOther;
using KillOrderPlugs;
using Kute.Helper;
using Model;
using Newtonsoft.Json;
using SubSonic;
using TestService.ModelsOther;

namespace NewAnalysisPlugs
{
    public class NewOrderHelper
    {

        //实例化数帮助类（包含直接获取Json反序列化，静态调用反序列化需传入对象）
        private JsonHelper json = new JsonHelper();
        public string SavaData(string order)
        {
            try
            {
                var msmqList = new List<MsmqModel>();
                //Json反序列化生成对象
                List<BLData> blDateList = (List<BLData>)JsonHelper.ReturnObject(order, typeof(List<BLData>));

                //判断对象长度
                if (blDateList.Count < 0)
                {
                    //执行失败
                    json.RetCode = "error";
                    json.RetMessage = "添加失败，事由：没有传入对象";
                    return JsonConvert.SerializeObject(json);
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
                        var killJson = new KillOrderHelper().KillOrder(blDate.order.Khdh);
                        var log = new ServiceLog
                        {
                            CallBackUrl = null,
                            Context = killJson,
                            CreateTime = DateTime.Now,
                            Lable = "AutoKill",
                            MessageID = "NoMessageId",
                            MessagePath = blDate.order.Khdh
                        };

                        //记录自动撤单日志
                        msmqList.Add(new MsmqModel { Path = "LogService", Label = "AddLog", Body = JsonConvert.SerializeObject(log), CallBackUrl = null });

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
                        OrderType = int.Parse(blDate.order.OrderType),
                        Mddm = blDate.order.Mddm,
                        Mdmc = blDate.order.Mdmc,
                        Htbh = blDate.order.Htbh
                    };

                    if (blDate.order.OrderType == "1")
                    {
                        tblDataOrder.Khzb = new HelperClass().GetKhzb(blDate.order.Mddm) == "13" ? "国外" : "国内";
                    }

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

                    //生成OrderList表队列接口
                    msmqList.Add(new MsmqModel { Path = "CadOrder", Label = "NewOrder", Body = JsonConvert.SerializeObject(blDate), CallBackUrl = null });

                    //生成AnalysisOrder表队列接口
                    msmqList.Add(new MsmqModel { Path = "AnalysisOrder", Label = "NewOrder", Body = JsonConvert.SerializeObject(blDate), CallBackUrl = null });

                    //生成 新订单获取MES工时 队列命令
                    msmqList.Add(new MsmqModel { Path = "OrderGetMesHour", Label = "NewOrder", Body = blDate.order.Khdh, CallBackUrl = null });

                    json.RetMessage = JsonConvert.SerializeObject(msmqList);
                    json.RetCode = "Proceed";
                    return JsonConvert.SerializeObject(json);
                }
            }
            catch (Exception e)
            {
                json.RetCode = "error";
                json.RetMessage = "存储异常," + e.Message;
            }
            return JsonConvert.SerializeObject(json);
        }
    }
}
