using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using DataModels.ModelsOther;
using Kute.Helper;
using Model;
using Newtonsoft.Json;
using ServiceHelper.Helper;
using SubSonic;

namespace ServiceHandle.API
{
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码、svc 和配置文件中的类名“DataQueryService”。
    // 注意: 为了启动 WCF 测试客户端以测试此服务，请在解决方案资源管理器中选择 DataQueryService.svc 或 DataQueryService.svc.cs，然后开始调试。
    public class DataQueryService : IDataQueryService
    {
        public string GetWorkShop(string khdh, string fzfl)
        {
            var json = new JsonHelper();
            try
            {
                var blData = new Select().From<TBLDataOrder>().Where(TBLDataOrder.KhdhColumn).IsEqualTo(khdh).ExecuteTypedList<TBLDataOrder>().FirstOrDefault();
                var blDatamx = new Select().From<TBLDataOrdermx>().Where(TBLDataOrdermx.KhdhColumn).IsEqualTo(khdh).ExecuteTypedList<TBLDataOrdermx>();
                var workShop = new DataHelper().OtherBaseSelect("FYERP", $@"SELECT scddbz FROM OPENQUERY(FYERP,'select scddbz from sct27 where scggdh = ''{blData?.Scggdh}'' and fzfl=''{fzfl}''')");

                var work = new OrderWorkShop
                {
                    Fzfl = fzfl,
                    Scggdh = blData?.Scggdh,
                    scyspd = khdh,
                    Scddbz = workShop.Rows[0][""].ToString(),
                    Scggxh = "0"
                };

                json.RetCode = "Error";
                json.RetMessage = "获取成功";
            }
            catch (Exception e)
            {
                json.RetCode = "Error";
                json.RetMessage = e.Message;
            }

            return JsonConvert.SerializeObject(json);
        }
    }
}
