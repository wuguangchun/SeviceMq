using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using SubSonic;

namespace SystemMaintain.ServiceLog
{
    public partial class Form_Log_ServiceError : Form
    {
        public Form_Log_ServiceError()
        {
            InitializeComponent();
            LoadData();
        }

        //加载错误日志的数据
        private void LoadData()
        {
            try
            {
                var errList = new Select().From<TLogError>().ExecuteTypedList<TLogError>();
                Grid_ErrList.AutoGenerateColumns = false;

                Grid_ErrList.DataSource = errList;

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        //用户双击单元格获取错误提示的完整弹窗
        private void Grid_ErrList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (Grid_ErrList.SelectedRows.Count < 1)
                    return;

                var result = MessageBox.Show(Grid_ErrList.SelectedRows[0].Cells["Message"].Value.ToString(), @"错误日志提示明细", MessageBoxButtons.RetryCancel);

                if (result == DialogResult.Retry)
                {
                    var yes = MessageBox.Show(@"继续操作正式服务将重新处理！", @"继续操作提示", MessageBoxButtons.OKCancel);
                    if (yes == DialogResult.OK)
                    {
                        ResetMessage(Grid_ErrList.SelectedRows[0].Cells["MessageId"].Value.ToString());
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        //重新队列消息
        private void ResetMessage(string messageId)
        {
            try
            {
                var logList = new Select().From<TLogService>()
                    .Where(TLogService.MessageIDColumn).IsEqualTo(messageId).ExecuteTypedList<TLogService>();

                if (logList.Count > 1)
                {
                    var yes = MessageBox.Show(@"队列ID有多条数据", @"提示", MessageBoxButtons.YesNo);
                    if (yes == DialogResult.No)
                    {
                        return;
                    }
                }

                int ok = 0;
                foreach (var log in logList)
                {
                    var service = new ServiceMq.NewMassgeServiceClient();
                    var result = service.InsertMessage(log.MessagePath, log.Lable, log.Context, null);
                    if (result.ToLower().Contains("success"))
                    {
                        new Delete().From<TLogError>().Where(TLogError.MessageIdColumn).IsEqualTo(log.MessageID).Execute();
                        ok += 1;
                    }
                }

                MessageBox.Show($@"将{logList.Count}条消息重新处理，{ok}条处理成功！");
                LoadData();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}
