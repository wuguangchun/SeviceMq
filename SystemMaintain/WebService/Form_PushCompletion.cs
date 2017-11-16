using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using Newtonsoft.Json;
using ServiceHandle.ModelsOther;
using SubSonic;

namespace SystemMaintain.WebService
{
    public partial class Form_PushCompletion : Form
    {
        public Form_PushCompletion()
        {
            InitializeComponent();
            BandingCmb();
        }

        public void BandingCmb()
        {
            try
            {
                var modeList = new Select().From<TResultMsg>().ExecuteTypedList<TResultMsg>();

                cmb_ConpMode.ValueMember = "Id";
                cmb_ConpMode.DisplayMember = "Schema";
                cmb_ConpMode.DataSource = modeList;

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        //推送到正式接口
        private void btn_Service214_Click(object sender, EventArgs e)
        {
            var khdhList = txt_Json.Text.Replace("\r\n", "&").Split('&');
            int ok = 0;
            foreach (var khdh in khdhList)
            {
                var comp = new Completion { CustmerId = khdh, CallingParty = "TestClient", OrderSrate = cmb_ConpMode.SelectedValue.ToString() };

                var service = new ServiceMq.NewMassgeServiceClient();
                var result = service.InsertMessage("Completion", "Completion", JsonConvert.SerializeObject(comp), null);
                if (result.ToLower().Contains("success"))
                {
                    ok += 1;
                }
            }

            MessageBox.Show($@"列表一共{khdhList.Length}条数据，推送成功{ok}条数据！", @"接口返回比对提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //推送到测试接口
        private void btn_Service213_Click(object sender, EventArgs e)
        {
            var khdhList = txt_Json.Text.Replace("\r\n", "&").Split('&');
            int ok = 0;
            foreach (var khdh in khdhList)
            {
                var comp = new Completion { CustmerId = khdh, CallingParty = "TestClient", OrderSrate = cmb_ConpMode.SelectedValue.ToString() };

                var service = new ServiceMqTest.NewMassgeServiceClient();
                var result = service.InsertMessage("Completion", "Completion", JsonConvert.SerializeObject(comp), null);
                if (result.ToLower().Contains("success"))
                {
                    ok += 1;
                }
            }

            MessageBox.Show($@"列表一共{khdhList.Length}条数据，推送成功{ok}条数据！", @"接口返回比对提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //推送到本地接口
        private void btn_ServiceLocal_Click(object sender, EventArgs e)
        {
            var khdhList = txt_Json.Text.Replace("\r\n", "&").Split('&');
            int ok = 0;
            foreach (var khdh in khdhList)
            {
                var comp = new Completion { CustmerId = khdh, CallingParty = "TestClient", OrderSrate = cmb_ConpMode.SelectedValue.ToString() };

                var service = new ServiceMqLocal.NewMassgeServiceClient();
                var result = service.InsertMessage("Completion", "Completion", JsonConvert.SerializeObject(comp), null);
                if (result.ToLower().Contains("success"))
                {
                    ok += 1;
                }
            }

            MessageBox.Show($@"列表一共{khdhList.Length}条数据，推送成功{ok}条数据！", @"接口返回比对提示", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
