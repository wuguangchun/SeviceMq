using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestService.ModelsOther
{
    public class MesModels
    {
        public string sysCode { get; set; }
        public List<ModelSort> listModelSort { get; set; }


    }

    public class ModelSort
    {
        public string strSort { get; set; }
        public List<ListStepCodes> listStepCode { get; set; }


    }
    public class ListStepCodes
    {
        public string StepCode { get; set; }
        public int StepHour { get; set; }

    }



}
