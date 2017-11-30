using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestService.ModelsOther
{
    public class MesModels
    {
        public string SysCode { get; set; }
        public string Sort { get; set; }
        public string FabricType { get; set; }
        public string ReturnState { get; set; }
        public string FailureReason { get; set; }

        public List<ListStepCodes> listStepCode { get; set; }
        public List<String> ListOrderArts { get; set; }


    }
     
    public class ListStepCodes
    {
        public string StepCode { get; set; }
        public int StepHour { get; set; }

    }



}
