using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestService.ModelsOther
{
    public class LineOrderPool
    {
        public string LineName { get; set; }
        public string Khdh { get; set; }
        public string Fzfl { get; set; }
        public int Num { get; set; }
    }

    public class PlanInfo
    {
        public string Sczsbh { get; set; }
        public string Scjhry { get; set; }
        public string Scshry { get; set; }
        public string Scgcdm { get; set; }
        public string Scxdrq { get; set; }
        public string Scjhrq { get; set; }
        public string Scshrq { get; set; }
        public string Sczsbz { get; set; }
        public string Sclrrq { get; set; }
        public string Type { get; set; }
        public List<LineOrderPool> OrderPools { get; set; }
    }

    public class DataPool
    {
        public string LineName { get; set; }
        public string Fzfl { get; set; }
        public string Jqts { get; set; }
        public string Khdh { get; set; }
        public string Sex { get; set; }
        public string Khzb { get; set; }
        public string Mlwg { get; set; }
        public string TypeId { get; set; }


    }

    public class Sczsbh
    {
        public string sczsbh { get; set; }
        public string scjhry { get; set; }
        public string scshry { get; set; }
        public string scgcdm { get; set; }
        public string scxdrq { get; set; }
        public string scjhrq { get; set; }
        public string scshrq { get; set; }
        public string sczsbz { get; set; }
        public string sclrrq { get; set; }
        public string type { get; set; }
        public List<string> scggdhs { get; set; }

    }
}
