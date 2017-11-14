using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace APSWcfService.Helper
{
    public class LogHelper
    {
        private static readonly string _filePath = System.Web.HttpContext.Current.Request.MapPath("/") + $@"logs\{DateTime.Now.ToShortDateString().Replace("/", "-")}.txt";

        //文件储存日志
        public static string SaveLogs(string logsStr)
        {
            try
            {
                //在LOG文件夹下创建文件,一天一个文件，没有就创建
                if (!File.Exists(_filePath))
                {
                    using (StreamWriter sw = File.CreateText(_filePath))
                    {
                        sw.Flush();
                    }
                }

                using (StreamWriter sw = new StreamWriter(_filePath, true))
                {
                    sw.WriteLine(UsersLogTemp(logsStr));
                    sw.Flush();
                }

            }
            catch (Exception exception)
            {
                return _filePath + exception.Message;
            }
            return _filePath;
        }

        //日志格式
        public static string UsersLogTemp(string log)
        {
            return $"时间：{DateTime.Now}\r" +
                   $"记录事件：{log}\r\n";

        }

    }
}