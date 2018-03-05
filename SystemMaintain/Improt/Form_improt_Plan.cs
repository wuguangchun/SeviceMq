using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ApsAdmin.Helper;
using Newtonsoft.Json;
using TestService.ModelsOther;

namespace SystemMaintain.Improt
{
    public partial class Form_improt_Plan : Form
    {
        public Form_improt_Plan()
        {
            InitializeComponent();
        }

        private void btn_ServiceERP_Click(object sender, EventArgs e)
        {
            try
            {

                Sczsbh s = new Sczsbh();
                s = new Sczsbh();
                s.sczsbh = $"Jh-{DateTime.Now.ToString("yyyy")}{DateTime.Now.ToString("MM")}{DateTime.Now.ToString("dd")}";
                s.scjhry = "APS";
                s.scshry = "00903";
                s.scgcdm = "01";
                s.scxdrq = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss").Replace('/', '-');
                s.scjhrq = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss").Replace('/', '-');
                s.scshrq = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss").Replace('/', '-');
                s.sclrrq = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss").Replace('/', '-');
                s.sczsbz = "2000计划";
                s.type = "4";
                s.scggdhs = new List<string>();

                var scggdhs = txt_Scggdh.Text.Replace("\r\n", "&").Split('&').ToList();
                scggdhs.ForEach(x => s.scggdhs.Add(x));
                var service = new ErpService.ServiceToFyerpClient();
                var result = service.doSavePlan(JsonConvert.SerializeObject(s));


                StringBuilder sb = new StringBuilder();
                //foreach (var scggdh in s.scggdhs)
                //{
                //    sb.Append(scggdh + ",");
                //}
                //string scggdhList = sb.ToString().Substring(0, sb.ToString().Length - 1);

                //Dictionary<string, string> dict = new Dictionary<string, string>();
                //dict.Add("sczsbh", s.sczsbh);
                //dict.Add("scjhry", s.scjhry);
                //dict.Add("scshry", s.scshry);
                //dict.Add("scgcdm", s.scgcdm);
                //dict.Add("scxdrq", s.scxdrq);
                //dict.Add("scjhrq", s.scjhrq);
                //dict.Add("scshrq", s.scshrq);
                //dict.Add("sczsbz", s.sczsbz);
                //dict.Add("sclrrq", s.sclrrq);
                //dict.Add("type", s.type);
                //dict.Add("scggdhs", scggdhList);
                //string ip = "http://172.16.7.214:8196/";
                //string requestURL = "api/aps/computejq";
                //var httphelper = new HttpHelper(ip);
                //string result = httphelper.PostDic(dict, requestURL);


                MessageBox.Show(result);

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}
