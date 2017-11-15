using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CADXfSchedulingEnd
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var service = new ServiceMq.NewMassgeServiceClient();
                var result = service.InsertMessage("PutCadBL", "SchedulingReady", "CADXfPushToBL", null);
                Console.WriteLine(result);
                Thread.Sleep(3000);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
