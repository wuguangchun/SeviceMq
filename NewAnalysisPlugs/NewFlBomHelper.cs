using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModels.ModelsOther;
using Kute.Helper;
using Model;
using Newtonsoft.Json;
using SubSonic;
using SubSonic.Extensions;

namespace NewAnalysisPlugs
{
    public class NewFlBomHelper
    {
        public string NewFlBom(string json)
        {
            var result = new JsonHelper();
            try
            {
                var bomList = (List<FlBom>)JsonConvert.DeserializeObject(json, typeof(List<FlBom>));

                //检测该订单的辅料BOM是否已存在
                var khdh = bomList.First().Khdh;
                var exitRow = new Select().From<TBlflbom>().Where(TBlflbom.KhdhColumn).IsEqualTo(khdh).ExecuteTypedList<TBlflbom>().Count;
                if (exitRow > 0)
                {
                    var row = new Delete().From<TBlflbom>().Where(TBlflbom.KhdhColumn).IsEqualTo(khdh).Execute();
                    if (row < exitRow)
                    {
                        throw new Exception($"{khdh},该订单的辅料BOM通过检测已存在，但再删除时失败了，请手动处理。");
                    }
                }

                //将数据存到数据库
                foreach (var flBom in bomList)
                {
                    var bom = new TBlflbom { Khdh = flBom.Khdh, Hy = int.Parse(flBom.Hy), Ylbm = flBom.Ylbm, Clflmc = flBom.Clflmx };
                    bom.Save();
                }

                //检测数据是否已经成功存入到数据库
                exitRow = new Select().From<TBlflbom>().Where(TBlflbom.KhdhColumn).IsEqualTo(khdh).ExecuteTypedList<TBlflbom>().Count;
                if (exitRow == bomList.Count)
                {
                    result.RetCode = RetCode.Success;
                    result.RetMessage = $"执行成功,接受的{bomList.Count}条辅料BOM已成功存入到数据库";
                }
                else
                {
                    var row = new Delete().From<TBlflbom>().Where(TBlflbom.KhdhColumn).IsEqualTo(khdh).Execute();
                    result.RetCode = RetCode.Error;
                    result.RetMessage = $"执行失败,接受的{bomList.Count}条辅料BOM成功存入到数据库{exitRow}条。已清除掉本次的执行结果{row}条，请重试。";

                }

            }
            catch (Exception e)
            {
                result.RetCode = RetCode.Error;
                result.RetMessage = e.Message;
            }
            return JsonConvert.SerializeObject(result);
        }
    }
}
