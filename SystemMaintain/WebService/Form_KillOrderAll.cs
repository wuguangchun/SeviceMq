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
using ServiceHandle.ModelsOther;

namespace SystemMaintain.WebService
{
    public partial class Form_KillOrderAll : Form
    {
        public Form_KillOrderAll()
        {
            InitializeComponent();
        }

        private void btn_ServiceLocal_Click(object sender, EventArgs e)
        {
            var khdhList = txt_Json.Text.Replace("\r\n", "&").Split('&');
            int ok = 0;
            foreach (var khdh in khdhList)
            {

                var service = new ServiceMqLocal.NewMassgeServiceClient();
                var result = service.InsertMessage("KillOrder", "KillOrder", khdh.Trim(), null);
                if (result.ToLower().Contains("success"))
                {
                    ok += 1;
                }
            }

            MessageBox.Show($@"列表一共{khdhList.Length}条数据，推送成功{ok}条数据！", @"接口返回比对提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_Service213_Click(object sender, EventArgs e)
        {
            var khdhList = txt_Json.Text.Replace("\r\n", "&").Split('&');
            int ok = 0;
            foreach (var khdh in khdhList)
            {

                var service = new ServiceMqTest.NewMassgeServiceClient();
                var result = service.InsertMessage("KillOrder", "KillOrder", khdh.Trim(), null);
                if (result.ToLower().Contains("success"))
                {
                    ok += 1;
                }
            }

            MessageBox.Show($@"列表一共{khdhList.Length}条数据，推送成功{ok}条数据！", @"接口返回比对提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_Service214_Click(object sender, EventArgs e)
        {
            var khdhList = txt_Json.Text.Replace("\r\n", "&").Split('&');
            int ok = 0;
            foreach (var khdh in khdhList)
            {

                var service = new ServiceMq.NewMassgeServiceClient();
                var result = service.InsertMessage("KillOrder", "KillOrder", khdh.Trim(), null);
                if (result.ToLower().Contains("success"))
                {
                    ok += 1;
                }
            }

            MessageBox.Show($@"列表一共{khdhList.Length}条数据，推送成功{ok}条数据！", @"接口返回比对提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
