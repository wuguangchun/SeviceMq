using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServiceHandle.ModelsOther
{
    public class BlPbcd
    {
        public string S { get; set; }
        public List<BlPbcdMx> Rs { get; set; }
    }

    public class BlPbcdMx
    {
        public string Yllx { get; set; }
        public string Ylbm { get; set; }
        public string Mlfk { get; set; }
        public string Tg { get; set; }
        public string Hy { get; set; }
        public string Mltgkd { get; set; }
        public string Ylbwflid { get; set; }
    }
}