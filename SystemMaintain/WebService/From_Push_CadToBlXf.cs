using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SystemMaintain.Helpler;
using Model;
using SubSonic;

namespace SystemMaintain.WebService
{
    public partial class From_Push_CadToBlXf : Form
    {
        public From_Push_CadToBlXf()
        {
            InitializeComponent();
            LoadData();
        }

        public void LoadData()
        {
            try
            {

                var query = new Select().From<TAnalysisOutputList>()
                    .Where(TAnalysisOutputList.ProjectColumn).IsEqualTo("CAD西服");

                GridResult.AutoGenerateColumns = false;


                GridResult.DataSource = query.ExecuteTypedList<TAnalysisOutputList>();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        //推送到本地接口
        private void btn_ServiceLocal_Click(object sender, EventArgs e)
        {
            var service = new ServiceMqLocal.NewMassgeServiceClient();
            var result = service.InsertMessage("PutCadBL", "SchedulingReady", "CADXfPushToBL", null);
            MessageBox.Show(result, @"接口返回提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //推送到测试接口
        private void btn_Service213_Click(object sender, EventArgs e)
        {
            var service = new ServiceMqTest.NewMassgeServiceClient();
            var result = service.InsertMessage("PutCadBL", "SchedulingReady", "CADXfPushToBL", null);
            MessageBox.Show(result, @"接口返回提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //推送到正式接口
        private void btn_Service214_Click(object sender, EventArgs e)
        {
            var service = new ServiceMq.NewMassgeServiceClient();
            var result = service.InsertMessage("PutCadBL", "SchedulingReady", "CADXfPushToBL", null);
            MessageBox.Show(result, @"接口返回提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
