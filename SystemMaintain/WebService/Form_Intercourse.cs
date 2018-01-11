using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemMaintain.WebService
{
    public partial class Form_Intercourse : Form
    {
        public Form_Intercourse()
        {
            InitializeComponent();
        }
        private void btn_ServiceLocal_Click(object sender, EventArgs e)
        {

            var service = new ServiceMqLocal.NewMassgeServiceClient();
            var result = service.InsertMessage("Intercourse", "NewCustomer", txt_Json.Text, null);
            MessageBox.Show(result, @"接口返回提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_Service213_Click(object sender, EventArgs e)
        {

            var service = new ServiceMqTest.NewMassgeServiceClient();
            var result = service.InsertMessage("Intercourse", "NewCustomer", txt_Json.Text, null);
            MessageBox.Show(result, @"接口返回提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_Service214_Click(object sender, EventArgs e)
        {
            var service = new ServiceMq.NewMassgeServiceClient();
            var result = service.InsertMessage("Intercourse", "NewCustomer", txt_Json.Text, null);
            MessageBox.Show(result, @"接口返回提示", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
