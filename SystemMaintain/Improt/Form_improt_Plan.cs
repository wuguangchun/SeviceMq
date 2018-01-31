using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
                s.sczsbh = $"Jh-{DateTime.Now.ToString("s")}";
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
                MessageBox.Show(result);

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}
