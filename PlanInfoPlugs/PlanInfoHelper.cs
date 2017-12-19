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
                    sct27.Save();
                }

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

    }
}
