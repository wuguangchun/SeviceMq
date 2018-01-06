using Kute.Helper;
using Model;
using ServiceHandle.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CallBackPlugs
{

    public class CallBackHelper
    {
        public static List<Thread> ListThreads = new List<Thread>();

        public delegate void PostEventHandler(string uri, ref string ret);

        public static string CallBackGet(string json)
        {
            JsonHelper jsons = new JsonHelper();
            try
            {

                var callBack = (JsonHelper)JsonHelper.ReturnObject(json, typeof(JsonHelper));
                var logService = new TLogService(TLogService.Columns.MessageID, callBack.RetObj);

                //如果回调地址不为空，则执行回调通知
                if (!string.IsNullOrWhiteSpace(logService.CallBackUrl))
                {
                    var url = $"{logService.CallBackUrl}?RetCode={callBack.RetCode}&MessageID={callBack.RetObj}&dt={DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss")}";
                    start: string result = string.Empty;

                    //多线程去通知请求的系统
                    if (ListThreads.FindAll(x => x.ThreadState == ThreadState.Running).Count > 10)
                    {
                        //Thread.Sleep(1000 * 10);  存在异常，暂停
                        goto start;
                    }
                    else
                    {
                        //线程记录器中删除已停止的线程
                        ListThreads.RemoveAll(x => x.ThreadState == ThreadState.Stopped || x.ThreadState == ThreadState.Aborted);

                        Thread thread = new Thread(delegate ()
                        {
                            PushWebHelper.PostToGet(url, ref result, Encoding.UTF8);
                        })
                        { IsBackground = true };
                        thread.Start();

                        //线程记录器 追加记录的新线程
                        ListThreads.Add(thread);
                    }
                    
                }


                jsons.RetCode = "Success";
                jsons.RetMessage = "处理完毕";
            }
            catch (Exception e)
            {
                jsons.RetCode = "Error";
                jsons.RetMessage = e.Message;
            }
            return JsonHelper.GetJsonO(jsons);
        }
    }
}
