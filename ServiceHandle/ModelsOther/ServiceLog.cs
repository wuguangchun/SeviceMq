using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestService.ModelsOther
{
   public class ServiceLog
    {
        public string Lable { get; set; }
        public string Context { get; set; }
        public string CallBackUrl { get; set; }
        public string MessageID { get; set; }
        public string MessagePath { get; set; }
        public DateTime CreateTime { get; set; }
    }
    
}
