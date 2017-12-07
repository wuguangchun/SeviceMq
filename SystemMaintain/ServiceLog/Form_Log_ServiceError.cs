using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using Model;
using SubSonic;
using Timer = System.Timers.Timer;

namespace SystemMaintain.ServiceLog
{
    public partial class Form_Log_ServiceError : Form
    {
        public Form_Log_ServiceError()
        {
            InitializeComponent();
            TimerTest();
            LoadData(null, null);
        }

        //加载错误日志的数据
        private void LoadData(object sender, ElapsedEventArgs e)
        {
            try
            {
                var errList = new Select().From<TLogError>().ExecuteTypedList<TLogError>();
                Grid_ErrList.AutoGenerateColumns = false;

                if (Grid_ErrList.InvokeRequired)
                {
                    Action actionDelegate = () =>
                    {
                        Grid_ErrList.DataSource = errList;
                    };
                    Grid_ErrList.Invoke(actionDelegate);
                }
                else
                {

                    Grid_ErrList.DataSource = errList;
                }

                if (errList.Count > 0)
                    Defaut.Notify.ShowBalloonTip(30, "错误日志提示", $"现有有错误日志{errList.Count}条,请处理。以免影响生产", ToolTipIcon.Info);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //用户双击单元格获取错误提示的完整弹窗
        private void Grid_ErrList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (Grid_ErrList.SelectedRows.Count < 1)
                    return;
                var log = new Select().From<TLogService>().Where(TLogService.MessageIDColumn)
                    .IsEqualTo(Grid_ErrList.SelectedRows[0].Cells["MessageId"].Value.ToString()).ExecuteTypedList<TLogService>().FirstOrDefault();

                var result = MessageBox.Show($"路径：{log?.MessagePath} \r  标签：{log?.Lable} \r {log?.Context}", @"错误日志提示明细", MessageBoxButtons.RetryCancel);

                if (result == DialogResult.Retry)
                {
                    var yes = MessageBox.Show(@"继续操作正式服务将重新处理！", @"继续操作提示", MessageBoxButtons.OKCancel);
                    if (yes == DialogResult.OK)
                    {
                        ResetMessage(Grid_ErrList.SelectedRows[0].Cells["MessageId"].Value.ToString());
                    }
                }
                else
                {
                    var yes = MessageBox.Show(@"放弃操作将清除此条错误日志！", @"继续操作提示", MessageBoxButtons.OKCancel);
                    if (yes == DialogResult.OK)
                    {
                        new Delete().From<TLogError>().Where(TLogError.MessageIdColumn)
                            .IsEqualTo(Grid_ErrList.SelectedRows[0].Cells["MessageId"].Value.ToString())
                            .Execute();
                        LoadData(null, null);
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

                //MessageBox.Show($@"将{logList.Count}条消息重新处理，{ok}条处理成功！");
                LoadData(null, null);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void TimerTest()
        {
            Timer timer = new Timer(1000 * 60);
            timer.Elapsed += LoadData;
            timer.Start();
        }

        private void btn_resetAll_Click(object sender, EventArgs e)
        {
            try
            {
                while (true)
                {
                    var row = Grid_ErrList.SelectedRows[0];
                    if (row == null)
                    {
                        break;
                    }
                    var messageId = row.Cells[0].Value.ToString();
                    ResetMessage(messageId);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void btn_delAll_Click(object sender, EventArgs e)
        {
            try
            {
                var list = Grid_ErrList.SelectedRows;
                foreach (DataGridViewRow row in list)
                {
                    new Delete().From<TLogError>().Where(TLogError.MessageIdColumn).IsEqualTo(row.Cells["MessageId"].ToString()).Execute();
                }

                LoadData(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_reset_local_Click(object sender, EventArgs e)
        {

            try
            {
                var messageId = Grid_ErrList.SelectedRows[0].Cells["MessageId"].Value.ToString();

                var logList = new Select().From<TLogService>()
                    .Where(TLogService.MessageIDColumn).IsEqualTo(messageId).ExecuteTypedList<TLogService>();

                int ok = 0;
                foreach (var log in logList)
                {
                    var service = new ServiceMqLocal.NewMassgeServiceClient();
                    var result = service.InsertMessage(log.MessagePath, log.Lable, log.Context, null);
                    if (result.ToLower().Contains("success"))
                    {
                        new Delete().From<TLogError>().Where(TLogError.MessageIdColumn).IsEqualTo(log.MessageID).Execute();
                        ok += 1;
                    }
                }

                LoadData(null, null);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}
