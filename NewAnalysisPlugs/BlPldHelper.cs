using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kute.Helper;
using Model;
using Newtonsoft.Json;
using ServiceHandle.ModelsOther;

namespace NewAnalysisPlugs
{
    public class BlPldHelper
    {
        public string ReceiveBlPldHelper(string dataJson)
        {
            JsonHelper json = new JsonHelper();
            try
            {
                var blpldList = (Blpld)JsonConvert.DeserializeObject(dataJson, typeof(Blpld));
                foreach (var pldmx in blpldList.Wlmxs)
                {
                    var data = new TBLDataPld
                    {
                        Khdh = blpldList.Khdh,
                        Scggdh = blpldList.Scggdh,
                        Pbxh = pldmx.Pbxh,
                        Wlbm = pldmx.Wlbm,
                        Wlfk = pldmx.Wlfk,
                        Wlhy = pldmx.Wlhy,
                        Tgsx = pldmx.Tgsx,
                        Tgkd = pldmx.Tgkd,
                        Wlks = pldmx.Wlks,
                        Wlxh = pldmx.Wlxh,
                        XH1 = pldmx.XH1,
                        Gyfl = pldmx.Gyfl,
                        Sldl = pldmx.Sldl,
                        Cpzl = pldmx.Cpzl,
                        Sfhd = pldmx.Sfhd,
                        Hdh = pldmx.Hdh,
                        Wlbw = pldmx.Wlbw
                    };
                    data.Save();
                    if (data.Id < 1)
                        throw new Exception("系统无异常，排料单插入数据库失败！");
                    else
                    {
                        json.RetMessage = "排料单新增成功";
                        json.RetCode = "Success";
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

            return JsonConvert.SerializeObject(json);
        }
    }
}
