using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kute.Helper;
using Model;
using Newtonsoft.Json;
using ServiceHandle.ModelsOther;
using SubSonic;

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

                new Delete().From<TBLDataPld>().Where(TBLDataPld.KhdhColumn).IsEqualTo(blpldList.Khdh).Execute();

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

                    json.RetMessage = "排料单新增成功";
                    json.RetCode = "Success";

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
