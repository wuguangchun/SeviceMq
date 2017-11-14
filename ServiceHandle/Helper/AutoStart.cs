using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using ServiceHandle.Handle;

namespace ServiceHandle.Helper
{
    public class AutoStart
    {
        public static void AutoStartHandle()
        {
            /*******************************
                    启动监听队列线程
             *******************************/

            //监听日志消息队列
            Thread threadLog = new Thread(LogHandleHandle.GetMessageQueues) { IsBackground = true };
            threadLog.Start();

            //监听新订单队列
            Thread threadNewOrder = new Thread(NewOrderHandle.GetMessageQueues) { IsBackground = true };
            threadNewOrder.Start();

            //监听完工汇报队列
            Thread threadComp = new Thread(CompletionHandle.GetMessageQueues) { IsBackground = true };
            threadComp.Start();

            //生成APS所需的CAD订单数据
            Thread threadNewCadOrder = new Thread(CreateCadOrderHandle.GetMessageQueues) { IsBackground = true };
            threadNewCadOrder.Start();

            //生成APS所需的裁剪订单数据
            Thread threadNewCaiJianOrder = new Thread(NewCaiJianOrderHandle.GetMessageQueues) { IsBackground = true };
            threadNewCaiJianOrder.Start();

            //生成段料所需数据
            Thread threadBlanking = new Thread(BlankingHandle.GetMessageQueues) { IsBackground = true };
            threadBlanking.Start();

            //处理结果回调
            Thread threadCallBack = new Thread(CallBackHandle.GetMessageQueues) { IsBackground = true };
            threadCallBack.Start();

            //数据重复撤单
            Thread threadKillOrder = new Thread(KillOrderHandle.GetMessageQueues) { IsBackground = true };
            threadKillOrder.Start();

        }
    }
}