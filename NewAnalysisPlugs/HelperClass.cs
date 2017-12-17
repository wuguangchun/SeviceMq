using DataModels.ModelsOther;
using Model;
using Newtonsoft.Json;
using SubSonic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewAnalysisPlugs
{
    public class HelperClass
    {
        //生成SpecialTime字段
        public void GetSpecialTime(List<Ordermx> list, ref int specialTime, ref string specialCodess)
        {
            try
            {
                string specialCode = "";
                foreach (var ordermx in list)
                {
                    specialCode += ordermx.Gyxx;
                }
                string[] specialCodes = specialCode.Split(',');

                SqlQuery q = new Select().From<TBasisSpecialList>()
                    .Where(TBasisSpecialList.Columns.SpecialCode).In(specialCodes);

                var oList = q.ExecuteTypedList<TBasisSpecialList>();
                foreach (var basisSpecialList in oList)
                {
                    specialTime += int.Parse(basisSpecialList.SpecialTime.ToString());
                    specialCodess += basisSpecialList.SpecialCode;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        //生成BodyType字段
        public double GetMinBodyType(string bodytype)
        {
            try
            {
                SqlQuery q = new Select(new string[] { "Efficiency" }).From<TBasisBodyList>()
                    .Where(TBasisBodyList.Columns.Id).IsNotNull();

                string[] bodytupes = bodytype.Split(',');

                for (int i = 0; i < bodytupes.Length; i++)
                {
                    if (i == 0)
                        q.And(TBasisBodyList.Columns.BodyCode).IsEqualTo(bodytupes[i]);
                    else
                        q.Or(TBasisBodyList.Columns.BodyCode).IsEqualTo(bodytupes[i]);
                }
                q.OrderAsc(new string[] { "Efficiency" });
                double bodype = q.ExecuteScalar<double>();
                return bodype > 0 ? bodype : 1.0;
            }
            catch (Exception)
            {

                throw;
            }
        }

        //生成Ylbm字段
        public string GetYlbmStr(List<Ordermx> objectrdermxes)
        {
            List<string> list = new List<string>();
            string ylbm = "";

            list.Add(objectrdermxes.First().mflxx.First().Ylbm);
            foreach (var obj in objectrdermxes)
            {
                foreach (var mflxx in obj.mflxx)
                {
                    if (list.IndexOf(mflxx.Ylbm) == -1) list.Add(mflxx.Ylbm);
                }

            }

            foreach (var str in list)
            {
                ylbm += str + ",";
            }

            return ylbm.Substring(0, ylbm.Length - 1);
        }

        //生成CoatType字段
        public string GetCoatType(List<Ordermx> list)
        {
            try
            {
                List<string> str = new List<string>();
                string fzfls = "";
                //Fzfl服装分类
                str.Add(list.First().Fzfl);

                foreach (var ordermx in list)
                {
                    if (str.IndexOf(ordermx.Fzfl) == -1)
                    {
                        str.Add(ordermx.Fzfl);
                    }
                }

                foreach (var fzfl in str)
                {
                    fzfls += fzfl + ",";
                }

                SqlQuery q = new Select(new string[] { "CoatCode" }).From<TBasisCoatList>()
                    .Where(TBasisCoatList.Columns.CoatAlias).IsEqualTo(fzfls.Substring(0, fzfls.Length - 1));
                return q.ExecuteScalar<string>();
            }
            catch (Exception)
            {
                throw;
            }
        }

        //生成StylesResult字段
        public string GetStylesResult(List<Ordermx> list)
        {
            try
            {
                List<string> listStyle = new List<string>();
                string styles = "";//处理结果后的值

                listStyle.Add(list.First().Ksjg);
                foreach (var ordermx in list)
                {
                    if (listStyle.IndexOf(ordermx.Ksjg) == -1)
                    {
                        listStyle.Add(ordermx.Ksjg);
                    }
                }

                foreach (var str in listStyle)
                {
                    styles += str + ",";
                }

                return styles.Substring(0, styles.Length - 1);

            }
            catch (Exception)
            {
                throw;
            }
        }

        //生成Styles字段
        public string GetStyles(List<Ordermx> list)
        {
            try
            {
                List<string> listStyle = new List<string>();
                string styles = "";//处理结果后的值

                if (!string.IsNullOrWhiteSpace(list.First().Ksh))
                    listStyle.Add(list.First().Ksh);
                foreach (var ordermx in list)
                {
                    if (listStyle.IndexOf(ordermx.Ksjg) == -1)
                    {
                        if (!string.IsNullOrWhiteSpace(list.First().Ksh))
                            listStyle.Add(ordermx.Ksh);
                    }
                }


                foreach (var str in listStyle)
                {
                    if (!string.IsNullOrWhiteSpace(str))
                        styles += str + ",";
                }
                if (!string.IsNullOrWhiteSpace(list.First().Ksh))
                    return styles.Substring(0, styles.Length - 1);
                return null;
            }
            catch (Exception)
            {
                throw;
            }
        }
        
        //生成FzSpecial字段 缝制特殊工艺订单
        public string GetFZSpecialCode(string[] gyxx, string sType)
        {
            try
            {
                var specials = new Select().From<TBasisSpecialCode>()
                     .Where(TBasisSpecialCode.ModelColumn).IsEqualTo("缝制")
                     .And(TBasisSpecialCode.SpecialTypeColumn).IsEqualTo(sType)
                     .And(TBasisSpecialCode.SpecialCodeColumn).In(gyxx)
                     .ExecuteTypedList<TBasisSpecialCode>();

                var listcode = specials.ConvertAll(x => x.SpecialCode);
                return JsonConvert.SerializeObject(listcode);

            }
            catch (Exception e)
            {
                throw;
            }
        }
    }
}
