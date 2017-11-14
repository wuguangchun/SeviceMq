using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;


namespace Kute.Helper
{
    public class JsonHelper
    {
        /// <summary>
        /// 返回状态 Success成功，Error失败
        /// </summary>
        public string RetCode { get; set; }

        /// <summary>
        /// 返回附加信息
        /// </summary>
        public string RetMessage { get; set; }

        /// <summary>
        /// 返回 结果 对象 。
        /// </summary>
        public object RetObj { get; set; }


        /// <summary>
        /// 快速序列化对象的
        /// </summary>
        /// <param name="o"></param>
        /// <returns></returns>
        public static string GetJsonO(Object o)
        {
            string s = JsonConvert.SerializeObject(o, Newtonsoft.Json.Formatting.Indented);
            return s;
        }

        /// <summary>
        ///  快速反序列化对象
        /// </summary>
        /// <param name="json"></param>
        /// <returns></returns>
        public static object ReturnObject(string json, Type T)
        {
            return JsonConvert.DeserializeObject(json, T);
        }

    }
}