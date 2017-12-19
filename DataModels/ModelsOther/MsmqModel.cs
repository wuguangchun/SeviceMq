using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModels.ModelsOther
{
    public class MsmqModel
    {
        public string Path { get; set; }
        public string Label { get; set; }
        public string Body { get; set; }
        public string CallBackUrl { get; set; }
    }
}