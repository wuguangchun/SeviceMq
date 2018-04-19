using Kute.Helper;
using Model;
using Newtonsoft.Json;
using ServiceHelper.Helper;
using SubSonic;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModels.ModelsOther;

namespace PlanInfoPlugs
{
    public class PlanInfoHelper
    {

        public string GetPlanMx(string khdh)
        {
            var json = new JsonHelper();
            try
            {
                var dataOrder = new Select().From<TBLDataOrder>().Where(TBLDataOrder.KhdhColumn).IsEqualTo(khdh).ExecuteTypedList<TBLDataOrder>().FirstOrDefault();

                if (dataOrder == null)
                    throw new Exception("没有找到订单的基础信息");

                var dataTable = new DataHelper().OtherBaseSelect("fyerp", $"select * from sct27 where scggdh = ''{dataOrder.Scggdh}''");

                foreach (DataRow row in dataTable.Rows)
                {
                    SCT27 sct27 = new SCT27
                    {
                        Sczsbh = row["SCZSBH"].ToString(),
                        Schtbh = row["SCHTBH"].ToString(),
                        Schtxh = int.Parse(row["SCHTXH"].ToString()),
                        Scggdh = row["SCGGDH"].ToString(),
                        Scggxh = int.Parse(row["SCGGXH"].ToString()),
                        Xtwpks = row["XTWPKS"].ToString(),
                        Xtwpys = row["XTWPYS"].ToString(),
                        Xtxmdm = row["XTXMDM"].ToString(),
                        Sczssl = int.Parse(row["SCZSSL"].ToString()),
                        Sczsbz = row["SCZSBZ"].ToString(),
                        Sczsph = row["SCZSPH"].ToString(),
                        Scgybz = row["SCGYBZ"].ToString(),
                    };
                    //预防重复，先删再加
                    new Delete().From<SCT27>()
                        .Where(SCT27.ScggdhColumn).IsEqualTo(sct27.Scggdh)
                        .Execute();
                    sct27.Save();
                }
                var msmqList = new List<MsmqModel>
                {
                    new MsmqModel{Path = "PlanInfo",Label = "NewPlanMain",Body = dataTable.Rows[0]["SCZSBH"].ToString(),CallBackUrl = null}
                };

                json.RetMessage = JsonConvert.SerializeObject(msmqList);
                json.RetCode = "Proceed";
                return GetPlanInfo(dataTable.Rows[0]["SCZSBH"].ToString());
            }
            catch (Exception e)
            {
                throw;
            }
        }

        public string GetPlanInfo(string sczsbh)
        {
            var obj = new JsonHelper();
            try
            {
                var dataOrder = new Select().From<SCT26>().Where(SCT26.SczsbhColumn).IsEqualTo(sczsbh).ExecuteTypedList<SCT26>();

                if (dataOrder.Count < 1)
                {
                    var dataTable = new DataHelper().OtherBaseSelect("fyerp", $"select * from sct26 where sczsbh = ''{sczsbh}''");

                    foreach (DataRow row in dataTable.Rows)
                    {
                        SCT26 sct26 = new SCT26
                        {
                            Sczsbh = row["SCZSBH"].ToString(),
                            Scgcdm = row["SCGCDM"].ToString(),
                            Scjhry = row["SCJHRY"].ToString(),
                            Sczsbz = row["SCZSBZ"].ToString(),
                            Sczszt = row["SCZSZT"].ToString(),
                            Scjqsm = row["SCJQSM"].ToString(),
                            Sclrry = row["SCLRRY"].ToString(),
                            Scshry = row["SCSHRY"].ToString(),
                            Schtbh = row["SCHTBH"].ToString(),
                        };

                        if (!string.IsNullOrEmpty(row["SCXDRQ"].ToString()))
                            sct26.Scxdrq = DateTime.Parse(row["SCXDRQ"].ToString());

                        if (!string.IsNullOrEmpty(row["Sccjjq"].ToString()))
                            sct26.Sccjjq = DateTime.Parse(row["Sccjjq"].ToString());

                        if (!string.IsNullOrEmpty(row["Scfzjq"].ToString()))
                            sct26.Scfzjq = DateTime.Parse(row["Scfzjq"].ToString());

                        if (!string.IsNullOrEmpty(row["Scjhrq"].ToString()))
                            sct26.Scjhrq = DateTime.Parse(row["Scjhrq"].ToString());

                        if (!string.IsNullOrEmpty(row["Scjqrq"].ToString()))
                            sct26.Scjqrq = DateTime.Parse(row["Scjqrq"].ToString());

                        if (!string.IsNullOrEmpty(row["Sclrrq"].ToString()))
                            sct26.Sclrrq = DateTime.Parse(row["Sclrrq"].ToString());

                        if (!string.IsNullOrEmpty(row["Scshrq"].ToString()))
                            sct26.Scshrq = DateTime.Parse(row["Scshrq"].ToString());

                        if (!string.IsNullOrEmpty(row["Scztjq"].ToString()))
                            sct26.Scztjq = DateTime.Parse(row["Scztjq"].ToString());

                        if (!string.IsNullOrEmpty(row["Scbzjq"].ToString()))
                            sct26.Scbzjq = DateTime.Parse(row["Scbzjq"].ToString());

                        if (!string.IsNullOrEmpty(row["Sctcrq"].ToString()))
                            sct26.Sctcrq = DateTime.Parse(row["Sctcrq"].ToString());

                        sct26.Save();

                        break;
                    }
                }

                obj.RetCode = "success";
                obj.RetMessage = "获取成功";
            }
            catch (Exception e)
            {
                throw;
            }
            return JsonConvert.SerializeObject(obj);
        }

        public string NewSewPlan(string khdh)
        {
            var result = new JsonHelper();
            try
            {
                var sctcrqquery = new Select().From<SCT26>()
                    .InnerJoin(SCT27.Schema.TableName, SCT27.SczsbhColumn.ColumnName, SCT26.Schema.TableName,
                        SCT26.SczsbhColumn.ColumnName)
                    .InnerJoin(TBLDataOrder.Schema.TableName, TBLDataOrder.ScggdhColumn.ColumnName, SCT27.Schema.TableName, SCT27.ScggdhColumn.ColumnName)
                    .Where(TBLDataOrder.KhdhColumn).IsEqualTo(khdh);

                var sct26 = sctcrqquery.ExecuteTypedList<SCT26>().FirstOrDefault();
                if (sct26 == null)
                {
                    throw new Exception($@"数据库中没有【{khdh}】的计划信息。请手动确认数据库中SCT26/SCT27/T_BLDATA_ORDER中的数据。此此异常回影响缝制排程的结果，请尽快排查原因！");
                }

                if (sct26.Scgcdm == "01")
                {
                    var planTimeExit = new Select().From<TBasisPlanTime>()
                        .Where(TBasisPlanTime.SctcrqColumn).IsEqualTo(sct26.Sctcrq)
                        .ExecuteTypedList<TBasisPlanTime>().Count < 1;
                    if (planTimeExit)
                    {
                        //将计划执行点新增到数据库
                        var planTime = new TBasisPlanTime { CrateTime = DateTime.Now, State = "0", Sctcrq = sct26.Sctcrq };
                        planTime.Save();

                        //将模型排程状态 修改成排产模式
                        new HljtTaskList(HljtTaskList.ModelTypeColumn.ColumnName, "缝制") { Flag = "Y" }
                        .Save("缝制");

                    }
                }

                result.RetCode = RetCode.Success;
                result.RetMessage = "获取成功";
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            return JsonConvert.SerializeObject(result);
        }
    }
}
