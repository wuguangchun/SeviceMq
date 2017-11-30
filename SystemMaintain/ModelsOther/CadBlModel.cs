using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemMaintain.ModelsOther
{
    public class CadBlModelList
    {
        public List<CadBlModel> ds { get; set; }
    }

    public class CadBlModel
    {
        public string customerId { get; set; }
        public string jobCode { get; set; }
        public string project { get; set; }
        public string abnormal { get; set; }
        public string note { get; set; }
        public string resources { get; set; }
        public string beginTime { get; set; }
        public string endTime { get; set; }
        public string makeTime { get; set; }
        public string createDate { get; set; }
        public string mtmortz { get; set; }
        public string grabTime { get; set; }
    }
}
