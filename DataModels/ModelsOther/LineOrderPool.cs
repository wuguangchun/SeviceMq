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
        public string Khdh { get; set; }
        public string Sex { get; set; }
        public string Tmw { get; set; }
        public string Khzb { get; set; }
        public string Mlwg { get; set; }
        public string TypeId { get; set; }


    }
}
