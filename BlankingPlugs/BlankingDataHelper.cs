using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using Kute.Helper;
using Model;
using ServiceHandle.Helper;
using ServiceHandle.ModelsOther;
using ServiceHelper.Helper;
using SubSonic;

namespace BlankingPlugs
{
   public class BlankingDataHelper
    {
        private JsonHelper json = new JsonHelper();

        //生成Blanking表数据
        public  string CreateBlankingData(string customerId)
        {
            try
            {

                var blanking = GetOldApsByCfAtOrderId(customerId);
                //初始化此订单生成状态
                bool status = false;

                //查询数据是否已存在
                if (ExistsDate(blanking.OrderID))
                {

                    //T_BlankingDetailes  如果存在就删除
                    var rowCount = new Delete().From<TBlankingDetaile>()
                        .Where(TBlankingDetaile.CustumerIdColumn).IsEqualTo(blanking.OrderID).Execute();
                }

                //没有裁床号的订单跳过
                if (string.IsNullOrWhiteSpace(blanking.CutNo.ToString()))
                {
                    throw new Exception("生成Blanking表数据,没有裁床号");
                }

                #region 获取ERP数据

                //获取ERP数据
                string sql =
                    $@"select a.sczsbh,b.sccjjq ,b.scgcdm from aps_sct27 a
                                left join SCT26 b on a.sczsbh = b.sczsbh
                                where a.scyspd = ''{blanking.OrderID}''";
                var datatable = new DataHelper().OtherBaseSelect("FYERP", sql);

                if (datatable == null || datatable.Rows.Count < 1)
                {
                    throw new Exception($"在ERP里没有找到【{blanking.OrderID}数据信息");
                }
                var erpTable = new DataHelper().OtherBaseSelect("FYERP", sql).Rows[0].ItemArray.ToList();

                #endregion

                TBlankingDetaile blankingNew = null;
                try
                {
                    #region 生成blanking表


                    //获取BL数据
                    var blankings = GetBlSources(blanking.OrderID);

                    //遍历从BL取回的数据
                    foreach (var blBlanking in blankings)
                    {
                        blankingNew = new TBlankingDetaile
                        {
                            CreateTime = blanking.BeginTime,
                            WmsStatus = 0,
                            PrintNo = 0,
                            PrintStatus = 0,
                            CustumerId = blanking.OrderID,
                            IsOk = blBlanking.Hgf,
                            Technology = blBlanking.Gyfl,
                            Count = blBlanking.Sldl,
                            MaterialCode = blBlanking.Ylbm,
                            Length = double.Parse(blBlanking.Hy ?? "0"),
                            Width = double.Parse(blBlanking.Mlfk ?? "0"),
                            GridAttribute = blBlanking.Tg,
                            Grid = double.Parse(blBlanking.Mltgkd ?? "0"),
                            MaterialParts = blBlanking.Ename,
                            LineNum = blBlanking.Xianh,
                            LreceiveTime = "", //到货时间
                            Note = blBlanking.Tranmemo,
                            TailoringDeliveryDate = DateTime.Parse(erpTable[1].ToString()), //裁剪交期
                            ResourceNum = int.Parse(blanking.CutNo.ToString()),
                            Scgcdm = erpTable[2].ToString(), //工厂代码
                            //CutTime = duanLiaoTime.ToString("yyyy-MM-dd hh:mm:ss"),
                            ProjectNumber = erpTable[0].ToString(), //计划单号
                            Cjdate = blanking.CutDate,
                            Cjtime = blanking.CutTime,
                            OrderType = blanking.OrderType

                        };

                        //存到数据库
                        blankingNew.Save();

                        //成功拿到数据后更新状态
                        if (blankingNew.Id < 0)
                        {
                            throw new Exception($"存入数据库时失败！");
                        }

                        json.RetCode = "success";
                        json.RetMessage = "增加Banking数据成功";
                    }

                    #endregion

                }
                catch (Exception ex)
                {
                    throw new Exception($"异常信息{ex.Message} 客户单号：{blanking.OrderID}");
                }
            }
            catch (Exception ex)
            {
                json.RetCode = "error";
                json.RetMessage = ex.Message;
            }

            return JsonHelper.GetJsonO(json);
        }

        //调用BL接口接收数据
        private  List<BlBlanking> GetBlSources(string customerId)
        {
            try
            {
                string url = $"http://172.16.7.127:8000/rest/aps/dlxxmx?khdh={customerId}";
                WebRequest request = WebRequest.Create(url);
                WebResponse response = request.GetResponse();
                StreamReader reader = new StreamReader(response.GetResponseStream()); //获得回应的数据流

                string context = reader.ReadToEnd();
                //.Replace("\"[", "[").Replace("]\"", "]").Replace(@"\", "");//将数据流转成String
                reader.Close();
                reader.Dispose();
                response.Close();

                string listjson = ((Bladata)JsonHelper.ReturnObject(context, typeof(Bladata))).Rs;
                return (List<BlBlanking>)JsonHelper.ReturnObject(listjson, typeof(List<BlBlanking>));
            }
            catch (Exception)
            {
                throw;
            }
        }

        //获取该订单的裁床信息
        private  TOldApsByCf GetOldApsByCfAtOrderId(string customerId)
        {
            try
            {
                SqlQuery query = new Select().From<TOldApsByCf>()
                    .Where(TOldApsByCf.OrderIDColumn).IsEqualTo(customerId);
                var oldApsByCf = query.ExecuteTypedList<TOldApsByCf>().FirstOrDefault();
                if (oldApsByCf != null)
                {
                    return oldApsByCf;
                }
                else
                {
                    throw new Exception($"未在表【TOldApsByCf】找到该订单的排程信息，客户单号为：{customerId}");
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        //查询数据是否已存在
        public  bool ExistsDate(string khdh)
        {
            try
            {
                SqlQuery query = new Select().From<TBlankingDetaile>()
                    .Where(TBlankingDetaile.CustumerIdColumn).IsEqualTo(khdh);
                return query.ExecuteTypedList<TBlankingDetaile>().Count > 0;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
