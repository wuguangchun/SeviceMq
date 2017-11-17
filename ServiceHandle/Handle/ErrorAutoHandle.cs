using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Timers;
using System.Web;
using Model;
using SubSonic;
using Timer = System.Timers.Timer;

namespace ServiceHandle.Handle
{
    public class ErrorAutoHandle
    {
        public static void ErrorAuto()
        {
            Timer time = new Timer(1000 * 60 * 3);
            time.AutoReset = true;
            time.Elapsed += ErrorHandle;
            time.Start();
        }

        private static void ErrorHandle(object sender, ElapsedEventArgs e)
        {
            try
            {
                var errList = new Select().From<TLogError>().ExecuteTypedList<TLogError>();
                foreach (var logError in errList)
                {
                    var log = new Select().From<TLogService>()
                        .Where(TLogService.MessageIDColumn).IsEqualTo(logError.MessageId)
                        .ExecuteTypedList<TLogService>().FirstOrDefault();

                    var service = new ApsMessageService.NewMassgeServiceClient();
                    service.InsertMessage(log?.MessagePath, log?.Lable, log?.Context, null);


                    new Delete().From<TLogError>().Where(TLogError.MessageIdColumn).IsEqualTo(logError.MessageId).Execute();
                }


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

    }
}