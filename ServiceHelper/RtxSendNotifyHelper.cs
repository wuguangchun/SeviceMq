using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using ServiceHandle.Helper;
using SubSonic; 

namespace ServiceHelper
{
    public class RtxSendNotifyHelper
    {
        public void SendNotifyError(string msgType, string msg)
        {
            try
            {
                string retMsg = string.Empty;

                var rtxMsg = new Select().From<TBasisRTXMsg>()
                    .Where(TBasisRTXMsg.MsgTypeColumn).IsEqualTo(msgType)
                    .ExecuteTypedList<TBasisRTXMsg>()
                    .FirstOrDefault();

                var msgStr = rtxMsg.MsgTemplate.Replace("{msg}", msg);

                PushWebHelper.PostToGet($"http://172.16.7.23:8012/SendNotify.cgi?msg={Unicode(msgStr)}&receiver={rtxMsg.UsersId}&title={Unicode(rtxMsg.MsgName)}&delaytime={rtxMsg.Delaytime}", ref retMsg, Encoding.Unicode);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public string Unicode(string text)
        {
            StringBuilder sb = new StringBuilder();
            byte[] byStr = System.Text.Encoding.Default.GetBytes(text); //默认System.Text.Encoding.Default.GetBytes(str)
            for (int i = 0; i < byStr.Length; i++)
            {
                sb.Append(@"%" + Convert.ToString(byStr[i], 16));
            }
            return sb.ToString();
        }

    }
}
