﻿using System;
using System.Collections.Generic; 

namespace DataModels.ModelsOther
{
    public class BLData
    {
        public List<Ordermx> ordermx { get; set; }
        public Order order { get; set; }
    }

    public class Order
    {
        public string Createtime { get; set; }
        public string Pbcd { get; set; }
        public string Khdh { get; set; }
        public string Ecode { get; set; }
        public string Sldl { get; set; }
        public string Tzecode { get; set; }
        public string Txtz { get; set; }
        public string Xh_sy_kh { get; set; }
        public string Jhrq { get; set; }
        public string Trantime { get; set; }
        public string Customername { get; set; }
        public string Audittime { get; set; }
        public string OrderType { get; set; }
        public string Tstx { get; set; }

    }

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
        public string Xh { get; set; }
        public List<Mflxx> mflxx { get; set; }
    }

    public class Mflxx
    {
        public string Yllx { get; set; }
        public string Ylbm { get; set; }
        public string Mtml { get; set; }
        public string Yllxmc { get; set; }
        public string Tg { get; set; }
        public string Mltgkd { get; set; }
    }
}