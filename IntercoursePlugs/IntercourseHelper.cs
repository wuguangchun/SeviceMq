using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kute.Helper;
using Model;
using Newtonsoft.Json;

namespace IntercoursePlugs
{
    public class IntercourseHelper
    {
        public string EditIntercourse(string data)
        {
            var json = new JsonHelper();
            try
            {
                //反序列化生成对象
                var intercourse = (TBasisIntercourse)JsonConvert.DeserializeObject(data, typeof(TBasisIntercourse));

                //数据库对象--  这样才能 实现  有就更新 没有就新增
                var now = new TBasisIntercourse(TBasisIntercourse.XtwldmColumn.ColumnName, intercourse.Xtwldm);

                now.Xtwldm = intercourse.Xtwldm;
                now.Xtwlmc = intercourse.Xtwlmc;
                now.Xtdqdm = intercourse.Xtdqdm;
                now.Xtbmdm = intercourse.Xtbmdm;
                now.Xtwlzt = intercourse.Xtwlzt;
                now.Xskhzb = intercourse.Xskhzb;
                now.Bmscsj = intercourse.Bmscsj;
                now.Save();

                json.RetMessage = $@"操作成功！{now.Xtwldm}";
                json.RetCode = "success";
            }
            catch (Exception e)
            {
                json.RetMessage = e.Message;
                json.RetCode = "error";
            }
            return JsonConvert.SerializeObject(json);
        }
    }
}
