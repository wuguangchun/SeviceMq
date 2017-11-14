using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfService1.OrderModel
{
    public class Ordermx
    {
        public string Hxjg { get; set; }
        public string Mlbm { get; set; }
        public string Gyxx { get; set; }
        public string Gylx { get; set; }
        public string Sfbcpsy { get; set; }
        public string Ddsl { get; set; }
        public string CodeType { get; set; }
        public string Ksh { get; set; }
        public string Fzfl { get; set; }
        public string Ksjg { get; set; }
        public List<Mflxx> mflxx { get; set; }
    }
}