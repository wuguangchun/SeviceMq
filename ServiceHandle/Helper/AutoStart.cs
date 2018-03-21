using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Web;
using ServiceHandle.Handle;

namespace ServiceHandle.Helper
{
    public class AutoStart
    {
        public static List<Thread> threads = new List<Thread>();
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

            //处理结果回调(需要下一版本优化，效率太慢)
            Thread threadCallBack = new Thread(CallBackHandle.GetMessageQueues) { IsBackground = true };
            threadCallBack.Start();

            //数据重复/撤单
            Thread threadKillOrder = new Thread(KillOrderHandle.GetMessageQueues) { IsBackground = true, Name = "KillOrder" };
            threadKillOrder.Start();

            //将排程数据推送给BL
            Thread threadPushBl = new Thread(PutCadHandle.GetMessageQueues) { IsBackground = true };
            threadPushBl.Start();

            //智能解析日志添加标识
            Thread threadAutoLog = new Thread(new IntelligentLogHandle().LogParsing) { IsBackground = true };
            threadAutoLog.Start();

            //获取MES工时
            Thread threadArtHour = new Thread(OrderMESArtInfoHandle.GetMessageQueues) { IsBackground = true };
            threadArtHour.Start();

            //计算订单APS所需数据
            Thread threadAnalysisLis = new Thread(NewAnalysisOrderHandle.GetMessageQueues) { IsBackground = true };
            threadAnalysisLis.Start();

            //计划下达后获取计划的信息
            Thread threadPlan = new Thread(NewPlanInfoHandle.GetMessageQueues) { IsBackground = true };
            threadPlan.Start();


            //线上队列测试
            Thread threadOnlineTest = new Thread(OnlineTestHandle.GetMessageQueues) { IsBackground = true };
            threadOnlineTest.Start();

            //往来户差异更新接口
            Thread threadIntercourse = new Thread(IntercourseHandle.GetMessageQueues) { IsBackground = true };
            threadIntercourse.Start();

            //文件生成
            Thread threadGenerateFile = new Thread(GenerateFileHandle.GetMessageQueues) { IsBackground = true };
            threadGenerateFile.Start();

            //线程集合
            threads = new List<Thread>
            {
                threadLog,threadNewOrder,threadComp,threadNewCadOrder,threadNewCaiJianOrder,threadBlanking,
                threadKillOrder,threadPushBl,threadAutoLog,threadArtHour,threadAnalysisLis,threadCallBack,
                threadPlan,threadOnlineTest,threadIntercourse,threadGenerateFile
            };

            ////检测以上自启动线程状态
            Thread threadTestThread = new Thread(TestThread) { IsBackground = true };
            threadTestThread.Start();
        }

        public static void TestThread()
        {
            try
            {
                while (true)
                {
                    foreach (var thread in threads)
                    {
                        if (thread.ThreadState != ThreadState.Running)
                        {
                            thread.Start();
                        }
                    }

                    //系统每分钟检测一次 多线程任务是否有效
                    Thread.Sleep(1000 * 60);

                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}