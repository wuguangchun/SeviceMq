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

    public class Blpld
    {
        public string Khdh { get; set; }
        public string Scggdh { get; set; }
        public List<Wlmx> Wlmxs { get; set; }
    }

    public class Wlmx
    {

        public int Pbxh { get; set; }
        public string Wlbm { get; set; }
        public decimal Wlfk { get; set; }
        public decimal Wlhy { get; set; }
        public string Tgsx { get; set; }
        public decimal Tgkd { get; set; }
        public string Wlks { get; set; }
        public int Wlxh { get; set; }
        public int XH1 { get; set; }
        public string Gyfl { get; set; }
        public string Sldl { get; set; }
        public string Cpzl { get; set; }
        public string Sfhd { get; set; }
        public string Hdh { get; set; }
        public string Wlbw { get; set; }


    }
}