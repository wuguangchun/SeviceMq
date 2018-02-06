using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServiceHandle.ModelsOther
{
    public class Completion
    {
        public string OrderSrate { get; set; }
        public string CustmerId { get; set; }
        public string CallingParty { get; set; }
    }

    public class OrderKill
    {
        public string OrderFl { get; set; }
        public string CustmerId { get; set; }
        public string CallingParty { get; set; }
        public string Note { get; set; }
}
}