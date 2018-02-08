using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using SubSonic;

namespace ServiceHelper.Helper
{
    public class DataHelper
    {
        /// <summary>
        /// 唯一订单号生成
        /// </summary>
        /// <returns></returns>
        public string GenerateOrderNumber()
        {
            string strDateTimeNumber = DateTime.Now.ToString("yyyyMMddHHmmssms");
            string strRandomResult = NextRandom(100000, 1).ToString();
            return strDateTimeNumber + strRandomResult;
        }

        private string NextRandom(int numSeeds, int length)
        {
            Guid guid = new Guid();
            guid = Guid.NewGuid();
            return guid.ToString().Substring(0, guid.ToString().IndexOf('-'));
        }

        /// <summary>
        /// 通过DBLink 查询
        /// </summary>
        /// <param name="name">DBLink 名称</param>
        /// <param name="sql">SQL语句</param>
        /// <returns></returns>
        public DataTable OtherBaseSelect(string name, string sql)
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
        
        // 获取时间戳 
        public string GetTimeStamp()
        {
            TimeSpan ts = DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0, 0);
            return Convert.ToInt64(ts.TotalSeconds).ToString();
        }
    }
}