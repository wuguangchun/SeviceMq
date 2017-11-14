using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;

namespace ServiceHandle.Helper
{
    public class PushWebHelper
    {
        /// <summary>
        /// .net 模拟发送Get请求
        /// </summary>
        /// <param name="postUrl">请求地址+参数</param>
        /// <param name="result">请求返回/回调结果</param>
        public static void PostToGet(string postUrl, ref string result)
        {
            /*使用Get方法进行推送数据*/
            try
            {
                HttpWebRequest req = (HttpWebRequest)WebRequest.Create(postUrl);
                req.Method = "GET";
                req.UserAgent = "Opera/9.25 (Windows NT 6.0;U;en)";
                req.KeepAlive = true;
                req.Timeout = 60000;//超时1分钟算失效
                HttpWebResponse resp = (HttpWebResponse)req.GetResponse();
                StreamReader sr = new StreamReader(resp.GetResponseStream(), Encoding.UTF8);

                /*得到返回的值*/
                result = sr.ReadToEnd().Trim().Replace("null", "\"\"");
                resp.Close();
                sr.Close();
            }
            catch (Exception e)
            {
                e.StackTrace.ToString();
                System.Diagnostics.Trace.WriteLine(e.Message);
                throw;
            }
        }

        /// <summary>
        ///  .net 模拟发送Post请求
        /// </summary>
        /// <param name="postUrl">请求地址</param>
        /// <param name="postdata">参数</param>
        /// <param name="result">请求返回/回调结果</param>
        public static void PostToPost(string postUrl, string postdata, ref string result)
        {
            try
            {
                HttpWebRequest requestScore = (HttpWebRequest)WebRequest.Create(postUrl);
                //ASCIIEncoding encoding = new ASCIIEncoding();
                Encoding u8 = Encoding.UTF8;
                byte[] data = u8.GetBytes(postdata); //encoding.GetBytes(postdata);
                requestScore.Method = "PUT";
                requestScore.ContentType = "application/x-www-form-urlencoded";
                requestScore.ContentLength = data.Length;
                requestScore.KeepAlive = true;
                requestScore.Date = DateTime.Now;

                Stream stream = requestScore.GetRequestStream();
                stream.Write(data, 0, data.Length);
                stream.Close();

                HttpWebResponse responseSorce;
                try
                {
                    responseSorce = (HttpWebResponse)requestScore.GetResponse();
                }
                catch (WebException ex)
                {
                    responseSorce = (HttpWebResponse)ex.Response;//得到请求网站的详细错误提示  
                }
                StreamReader reader = new StreamReader(responseSorce.GetResponseStream(), Encoding.UTF8);
                result = reader.ReadToEnd();

                requestScore.Abort();
                responseSorce.Close();
                responseSorce.Close();
                reader.Dispose();
                stream.Dispose();
            }
            catch (Exception e)
            {
                e.StackTrace.ToString();
                System.Diagnostics.Trace.WriteLine(e.Message);
                throw;
            }
        }
    }
}