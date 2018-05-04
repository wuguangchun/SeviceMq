using System;
using System.Collections.Generic;
using System.Linq;
using System.Timers;
using System.Web;
using DataModels.ModelsOther;
using IntelligentLogHelper;
using Model;
using Newtonsoft.Json;
using ServiceHandle.ModelsOther;
using SubSonic;

namespace ServiceHandle.Handle
{
    public class IntelligentLogHandle
    {
        public void LogParsing()
        {
            try
            {
                Timer time = new Timer(1000 * 60 * 1);
                time.Elapsed += LogParsingElapsed;
                time.AutoReset = true;
                time.Start();

                new IntelligentLog().LogParsing();

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        private void LogParsingElapsed(object sender, ElapsedEventArgs e)
        {

            new IntelligentLog().LogParsing();

        }

    }
}