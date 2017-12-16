using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using SubSonic;

namespace ServiceHandle.Helper
{
    public class DataHelper
    {
        /// <summary>
        /// 唯一订单号生成
        /// </summary>
        /// <returns></returns>
        public static string GenerateOrderNumber()
        {
            string strDateTimeNumber = DateTime.Now.ToString("yyyyMMddHHmmssms");
            string strRandomResult = NextRandom(100000, 1).ToString();
            return strDateTimeNumber + strRandomResult;
        }

        private static string NextRandom(int numSeeds, int length)
        {
            Guid guid = new Guid();
            guid = Guid.NewGuid();
            return guid.ToString().Substring(0, guid.ToString().IndexOf('-'));
        }

        public static DataTable OtherBaseSelect(string name, string sql)
        {
            try
            {
                QueryCommand qc = new QueryCommand($@"select * from OPENQUERY({name}, '{sql}')", null);
                return DataService.GetDataSet(qc).Tables[0];
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}