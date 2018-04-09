using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Model;
using SubSonic;

namespace FZSchedulingEnd
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                Console.WriteLine("正在获取当前排程得计划执行点...");
                var outList = new Select().From<TAnalysisOutPutListByFZ>().ExecuteTypedList<TAnalysisOutPutListByFZ>();
                Console.WriteLine($"当前排程执行点：{outList.FirstOrDefault()?.Sctcrq},排程数据条数：{outList.Count}");


                Console.WriteLine($"正在更改执行点数据状态，将状态修改为已排程，时间节点为：{outList.FirstOrDefault()?.Sctcrq}...");
                var row = new Update(TBasisPlanTime.Schema)
                    .Set(TBasisPlanTime.StateColumn).EqualTo("1")
                    .Where(TBasisPlanTime.SctcrqColumn).IsEqualTo(outList.FirstOrDefault()?.Sctcrq)
                    .Execute();

                Console.WriteLine($"更改完成，受影响行数:{row}条");


                Console.WriteLine($"正在检测是否需要继续排程...");

                var timelist = new Select().From<TBasisPlanTime>().Where(TBasisPlanTime.StateColumn).IsEqualTo("0").ExecuteTypedList<TBasisPlanTime>();

                Thread.Sleep(1000 * 20);

                if (timelist.Count > 0)
                {
                    Console.WriteLine($"正在通知下一次排程...");
                    row = new Update(HljtTaskList.Schema)
                        .Set(HljtTaskList.FlagColumn).EqualTo("Y")
                        .Where(HljtTaskList.ModelTypeColumn).IsEqualTo("缝制")
                        .Execute();

                    Console.WriteLine(row > 0 ? "通知成功" : "通知失败");
                }
                else
                {
                    Console.WriteLine($"排程完毕，暂无需排程,等待下一次排程...");
                }

            }
            catch (Exception e)
            {
                Console.WriteLine($"程序异常：{e.Message}");
            }
        }
    }
}
