using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using SubSonic;
using TestService.ModelsOther;

namespace PlanInfoPlugs
{
    public class AutoPlanCy
    {
        public DateTime BeginTime { get; set; }
        public List<TWorkTime> WorkTimes { get; set; }
        public List<TBasisLinesFz> Lines { get; set; }
        public List<LineOrderPool> LineOrder { get; set; }
        public List<TBasisLinesRestriction> Restriction { get; set; }

        public AutoPlanCy()
        {
            Lines = new Select().From<TBasisLinesFz>().Where(TBasisLinesFz.LineTypeColumn).IsEqualTo("XF").ExecuteTypedList<TBasisLinesFz>();
            Restriction = new Select().From<TBasisLinesRestriction>().ExecuteTypedList<TBasisLinesRestriction>();
        }

        public string OrderScreen(DateTime beginTime)
        {
            try
            {

                return "";
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
