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
    public partial class Form_BlToApsOrderData : Form
    {
        public Form_BlToApsOrderData()
        {
            InitializeComponent();
        }

        //推送到正式接口
        private void btn_Service214_Click(object sender, EventArgs e)
        {
            var service = new ServiceMq.NewMassgeServiceClient();
            var result = service.InsertMessage("NewOrderData", "BlPutData", txt_Json.Text, null);
            MessageBox.Show(result, @"接口返回提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //推送到测试接口
        private void btn_Service213_Click(object sender, EventArgs e)
        {
            var service = new ServiceMqTest.NewMassgeServiceClient();
            var result = service.InsertMessage("NewOrderData", "BlPutData", txt_Json.Text, null);
            MessageBox.Show(result, @"接口返回提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //推送到本地接口 
        private void btn_ServiceLocal_Click(object sender, EventArgs e)
        {
            var service = new ServiceMqLocal.NewMassgeServiceClient();
            var result = service.InsertMessage("NewOrderData", "BlPutData", txt_Json.Text, null);
            MessageBox.Show(result, @"接口返回提示", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }


    }
}
