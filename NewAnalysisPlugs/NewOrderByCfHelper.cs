using Kute.Helper;
using Model;
using ServiceHandle.ModelsOther;
using ServiceHelper.Helper;
using SubSonic;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using ServiceHelper;

namespace NewAnalysisPlugs
{
    public class NewOrderByCfHelper
    {
        private JsonHelper json = new JsonHelper();

        public string SavaData(string order)
        {
            try
            {
                SqlQuery query = new Select().From<TAnalysisOrderList>()
                    .Where(TAnalysisOrderList.Columns.CustomerId).IsEqualTo(order);
                var obj = query.ExecuteTypedList<TAnalysisOrderList>().FirstOrDefault();
                if (null != obj)
                {
                    if (obj.OrderType != "BLMTM")
                    {
                        json.RetCode = "success";
                        json.RetMessage = "非MTM大类，不需要生成。事由：智能排程中不考虑";
                        return JsonHelper.GetJsonO(json);
                    }

                    if (ExistsData(obj.CustomerId) > 0)
                    {
                        throw new Exception("数据已存在");
                    }

                    string type = "", tgcode = "", flagMl = "", pbcd = "", fgml = "", sccjjq = "", sctcrq = "";

                    //从ERP获取订单面料信息及各个节点日期
                    GetErpMsg(order, ref sccjjq, ref sctcrq, ref type, ref tgcode, ref flagMl);

                    TAnalysisOrderListByCF orderListByCf = new TAnalysisOrderListByCF();
                    orderListByCf.OrderId = new DataHelper().GenerateOrderNumber();
                    orderListByCf.CustomerId = obj.CustomerId;
                    orderListByCf.Project = "CF";
                    orderListByCf.OrderType = obj.OrderType;
                    orderListByCf.CoatType = obj.CoatType;
                    orderListByCf.BodyType = obj.BodyType;
                    orderListByCf.Fabric = obj.Fabric;
                    orderListByCf.Mflxx = obj.Mflxx;
                    orderListByCf.OrderTime = obj.OrderTime;
                    orderListByCf.DeliveryTime = obj.DeliveryTime;
                    orderListByCf.SpecialTime = obj.SpecialTime;
                    orderListByCf.SpecialCode = obj.SpecialCode;
                    orderListByCf.Styles = obj.Styles;
                    orderListByCf.StylesResult = obj.StylesResult;
                    orderListByCf.Numbers = obj.Numbers;
                    orderListByCf.SupportingWay = obj.SupportingWay;
                    orderListByCf.Sizes = obj.Sizes;
                    orderListByCf.Customer = obj.Customer;
                    orderListByCf.CreateTime = obj.CreateTime;
                    orderListByCf.OrderStatus = obj.OrderStatus;
                    orderListByCf.CreateDate = DateTime.Now;
                    orderListByCf.Pbcd = pbcd; //从BL接口帮助类，获取排版长度
                    orderListByCf.Gydm = obj.Gydm;
                    orderListByCf.Audittime = obj.Audittime;
                    orderListByCf.Sfbcpsy = obj.Sfbcpsy;
                    orderListByCf.Tzecode = obj.Tzecode;
                    orderListByCf.Scggdh = obj.Scggdh;
                    orderListByCf.ModifyTime = obj.ModifyTime;
                    orderListByCf.Type = type;
                    orderListByCf.TGCode = string.IsNullOrWhiteSpace(tgcode) ? 0 : int.Parse(tgcode);
                    orderListByCf.FlagML = string.IsNullOrWhiteSpace(flagMl) ? 0 : int.Parse(flagMl);
                    orderListByCf.Fgml = fgml;
                    orderListByCf.Gylx = obj.Gylx;
                    orderListByCf.Sccjjq = DateTime.Parse(sccjjq);
                    orderListByCf.Sctcrq = DateTime.Parse(sctcrq);

                    //预防重复，先删再增
                    new Delete().From<TAnalysisOrderListByCF>().Where(TAnalysisOrderListByCF.CustomerIdColumn)
                        .IsEqualTo(orderListByCf.CustomerId).Execute();

                    orderListByCf.Save();
                    if (string.IsNullOrWhiteSpace(orderListByCf.OrderId) || orderListByCf.OrderId == "0")
                    {
                        throw new Exception("生成成功，但存储失败");
                    }
                    else
                    {
                        json.RetCode = "success";
                        json.RetMessage = "生成成功";
                    }
                }
                else
                {
                    throw new Exception($"OrderList表没有{order}该数据");
                }

            }
            catch (Exception e)
            {
                json.RetCode = "error";
                json.RetMessage = "存储失败," + e.Message;
            }
            return JsonHelper.GetJsonO(json);
        }

        public void GetPbcd(string orderId, ref string type, ref string tgcode, ref string flagMl, ref string pbcd, ref string fgml, string orderType)
        {
            try
            {
                string url = $"http://172.16.7.127:8000/rest/aps/pldwlmx?khdh={orderId}";
                WebRequest request = WebRequest.Create(url);
                WebResponse response = request.GetResponse();
                StreamReader reader = new StreamReader(response.GetResponseStream());

                string context = reader.ReadToEnd().Replace("\"[", "[").Replace("]\"", "]").Replace(@"\", "");
                reader.Close();
                reader.Dispose();
                response.Close();

                var obj = (BlPbcd)JsonHelper.ReturnObject(context, typeof(BlPbcd));
                pbcd = "1";
                type = "1";
                foreach (var pbcdMx in obj.Rs)
                {
                    pbcdMx.Yllx = pbcdMx.Yllx.ToLower();
                    if (!string.IsNullOrWhiteSpace(pbcdMx.Hy))
                    {
                        if (orderType.ToLower().IndexOf("cy") > -1)
                        {
                            #region 衬衣生成规则

                            if (pbcdMx.Tg == "横条纹纬向弹力" || pbcdMx.Tg == "阴阳纹" || pbcdMx.Tg == "条纹倒顺毛" ||
                                pbcdMx.Tg == "条纹" || pbcdMx.Tg == "横条纹" || pbcdMx.Tg == "阴阳纹倒顺毛" ||
                                pbcdMx.Tg == "横阴阳条纹" || pbcdMx.Tg == "阴阳纹经向弹力" || pbcdMx.Tg == "阴阳纹纬向弹力" ||
                                pbcdMx.Tg == "横条纹经向弹力" || pbcdMx.Tg == "斜纹经向弹力" || pbcdMx.Tg == "条纹经向弹力"
                                || pbcdMx.Tg == "条纹纬向弹力")
                            {

                                if (double.Parse(pbcdMx.Mltgkd) <= 0.5)
                                {//小于等于0.5的算素面料
                                    if (pbcdMx.Ylbwflid == "1")
                                        flagMl = "1";
                                }
                                else if (double.Parse(pbcdMx.Mltgkd) <= 3)
                                {//小于等于3的算条面料
                                    if (pbcdMx.Ylbwflid == "1")
                                        tgcode = "1";
                                }
                                else
                                {//剩余的算格面料
                                    if (pbcdMx.Ylbwflid == "1")
                                        tgcode = "2";
                                }
                            }
                            else if (pbcdMx.Tg == "方格经向弹力" || pbcdMx.Tg == "方格" || pbcdMx.Tg == "方格纬向弹力" || pbcdMx.Tg == "方格倒顺毛")
                            {
                                if (double.Parse(pbcdMx.Mltgkd) <= 0.3 && pbcdMx.Mltgkd != "0")
                                {//小于等于0.3的算素面料
                                    if (pbcdMx.Ylbwflid == "1")
                                        flagMl = "1";
                                }
                                else
                                {//剩余的算格面料
                                    if (pbcdMx.Ylbwflid == "1")
                                        tgcode = "2";
                                }
                            }
                            else if (pbcdMx.Tg == "格(针织料)")
                            {
                                if (pbcdMx.Ylbwflid == "1")
                                    tgcode = "2";
                            }
                            else
                            {//剩下的都算素面料
                                if (pbcdMx.Ylbwflid == "1")
                                    flagMl = "1";
                            }


                            #endregion
                        }
                        else
                        {
                            #region 西服生成规则
                            if (double.Parse(pbcdMx.Mltgkd) >= 20)
                            { //特殊面料
                                type = "2";
                            }
                            else
                            {
                                if (pbcdMx.Tg == "方格" || pbcdMx.Tg == "方格纬向弹力" || pbcdMx.Tg == "方格倒顺毛" || pbcdMx.Tg == "方格经向弹力" || pbcdMx.Tg == "格(针织料)")
                                {//方格 方格,方格纬向弹力,方格倒顺毛

                                    if (double.Parse(pbcdMx.Mltgkd) <= 0.4 && pbcdMx.Mltgkd != "0")
                                    {
                                        flagMl = "1";
                                    }
                                    else
                                    {
                                        tgcode = "1";
                                        fgml += pbcdMx.Ylbm + ",";
                                    }
                                }
                                else if (pbcdMx.Tg == "横条纹纬向弹力" || pbcdMx.Tg == "阴阳纹" || pbcdMx.Tg == "条纹倒顺毛" ||
                                         pbcdMx.Tg == "条纹" || pbcdMx.Tg == "横条纹" ||
                                         pbcdMx.Tg == "阴阳纹倒顺毛" || pbcdMx.Tg == "横阴阳条纹" || pbcdMx.Tg == "阴阳纹经向弹力" ||
                                         pbcdMx.Tg == "阴阳纹纬向弹力" ||
                                         pbcdMx.Tg == "横条纹经向弹力" || pbcdMx.Tg == "斜纹经向弹力" || pbcdMx.Tg == "条纹经向弹力" ||
                                         pbcdMx.Tg == "条纹纬向弹力" || pbcdMx.Tg == " 斜纹纬向弹力")
                                {//条间距小于3的算素色  横条纹,横阴阳条纹,条纹,条纹倒顺毛,条纹纬向弹力,阴阳纹,阴阳纹倒顺毛

                                    if (double.Parse(pbcdMx.Mltgkd) >= 3)
                                    {
                                        //大于等于3的
                                        //if (pbcdMx.Ylbwflid == "1")
                                        {
                                            tgcode = "1";
                                        }
                                        fgml += pbcdMx.Ylbm + ",";
                                    }
                                    else
                                    {
                                        //if (pbcdMx.Ylbwflid == "1")
                                        {
                                            flagMl = "1";
                                        }
                                    }
                                }
                                else
                                {//剩余的为素面料
                                    //if (pbcdMx.Ylbwflid == "1")
                                    {
                                        flagMl = "1";
                                    }
                                }
                            }
                            #endregion

                        }
                    }
                }

            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void GetErpMsg(string orderId, ref string sccjjq, ref string sctcrq, ref string type, ref string tgcode, ref string flagMl)
        {
            try
            {
                //获取ERP数据
                string sql =
                    $@"select  a.sczsbh,b.sctcrq, b.sccjjq ,b.scgcdm,scjhbz,b.sczsbz,a.schtbh,scyspd ,a.xtwpks from sct27 a
                        inner join SCT26 b on a.sczsbh = b.sczsbh
                        inner join sct32 on  sct32.schtbh=a.schtbh
                        inner join  sct51 on a.scggdh=sct51.scggdh
                        where sct51.scyspd=''{orderId}''  and scjhbz not like ''%未%''
                        order by sccjjq desc ,scjhbz";
                var erpTables = new DataHelper().OtherBaseSelect("FYERP", sql);

                if (erpTables.Rows.Count < 1)
                {
                    new RtxSendNotifyHelper().SendNotifyError("Scjhbz", "ERP取计划标注信息异常，ERP无信息返回。请确认计划标注信息及订单信息是否正确。原始凭单：" + orderId);
                    throw new Exception("ERP取计划标注信息异常，ERP无信息返回。请确认计划标注信息及订单信息是否正确。");
                }

                var erpTable = erpTables.Rows[0].ItemArray.ToList();

                if (orderId.ToLower().Contains("jjj") || orderId.ToLower().Contains("test") ||
                    erpTable[8].ToString().ToLower().Contains("p0"))
                {
                    //订单为测试或者配件时，不用考虑其计划备注面料属性
                }
                else
                {
                    //裁剪交期，计划日期，计划面料备注为重要不可缺失字段不能为空，如果为空则抛出异常
                    if (string.IsNullOrWhiteSpace(erpTable[1].ToString()) ||
                        string.IsNullOrWhiteSpace(erpTable[2].ToString()) ||
                        erpTable[4].ToString().Contains("未配料") ||
                        erpTable[4].ToString().Contains("未BL"))
                    {
                        new RtxSendNotifyHelper().SendNotifyError("Scjhbz", "ERP取计划标注信息异常，ERP信息异常返回。请确认裁剪交期，计划日期，计划面料备注信息及订单信息是否正确。原始凭单：" + orderId);
                        throw new Exception("ERP重要字段为空值");
                    }

                    //如果订单不是团装计划备注应必须有
                    if (!erpTable[6].ToString().ToLower().Contains("gm") && string.IsNullOrWhiteSpace(erpTable[4].ToString()))
                    {
                        throw new Exception("ERP面料属性字段为空值,原始凭单：" + erpTable[6]);
                    }
                }


                //返回字段值
                sccjjq = erpTable[2].ToString();
                sctcrq = erpTable[1].ToString();
                type = erpTable[5].ToString().Contains("加急") ? "加急" : "";
                tgcode = (erpTable[4].ToString().Contains("MTM/") || erpTable[4].ToString().Contains("绘纸皮")) ? "1" : "0";
                flagMl = (erpTable[4].ToString().Contains("新裁床") || erpTable[4].ToString().Contains("新/")) ? "1" : "0";
            }
            catch (Exception)
            {
                throw;
            }
        }

        public int ExistsData(string id)
        {
            try
            {
                SqlQuery query = new SqlQuery().From<TAnalysisOrderListByCF>()
                    .Where(TAnalysisOrderListByCF.CustomerIdColumn).IsEqualTo(id);
                int row = query.ExecuteTypedList<TAnalysisOrderListByCF>().Count;
                return row;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
