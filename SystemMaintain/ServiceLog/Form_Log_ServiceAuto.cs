using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using SystemMaintain.ModelsOther;
using APSWcfService.Helper;
using Model;
using Newtonsoft.Json;
using ServiceHandle.ModelsOther;
using SubSonic;
using SubSonic.Extensions;
using WcfService1.OrderModel;
using Timer = System.Timers.Timer;

namespace SystemMaintain.ServiceLog
{
    public partial class Form_Log_ServiceAuto : Form
    {
        private List<TLogService> logList;
        public Form_Log_ServiceAuto()
        {
            InitializeComponent();
            LoadNoHandleData();
        }

        private void LoadNoHandleData()
        {
            try
            {
                logList = new Select().From<TLogService>()
                    .Where(TLogService.KhdhColumn).IsEqualTo("")
                    .And(TLogService.MessagePathColumn).IsNotEqualTo("CallBackMsg")
                    .And(TLogService.MessagePathColumn).IsNotEqualTo("LogService")
                    .And(TLogService.MessagePathColumn).IsNotEqualTo("computejq")
                    .And(TLogService.LableColumn).IsNotEqualTo("SchedulingReady")
                    .And(TLogService.LableColumn).IsNotEqualTo("AutoKill") 
                    .ExecuteTypedList<TLogService>();

                if (this.InvokeRequired)
                {
                    Action actionDelegate = () =>
                    {
                        Grid_Log_NoHandle.DataSource = logList;
                    };

                    this.Grid_Log_NoHandle.Invoke(actionDelegate);
                }
                else
                {
                    Grid_Log_NoHandle.AutoGenerateColumns = false;
                    Grid_Log_NoHandle.AllowUserToAddRows = false;
                    Grid_Log_NoHandle.DataSource = logList;
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void btn_AutoHandle_Click(object sender, EventArgs e)
        {
            LoadNoHandleData();
            Thread thread = new Thread(AutoHandle) { IsBackground = true };
            thread.Start();
        }

        private void AutoHandle()

        {
            try
            {
                int okRow = 0;

                foreach (var logService in logList.FindAll(x => 1 == 1))
                {

                    //BL主动推送的订单数据
                    if (logService.MessagePath == "NewOrderData" && logService.Lable == "BlPutData")
                    {
                        var obj = (List<BLDate>)JsonConvert.DeserializeObject(logService.Context, typeof(List<BLDate>));
                        okRow += UpdateLogs(logService.Id, obj?.First().order.Khdh) ? 1 : 0;
                    }
                    //新订单数据生成CAD排程数据/生成APS基础数据
                    else if ((logService.MessagePath == "CadOrder" || logService.MessagePath == "AnalysisOrder") && logService.Lable == "NewOrder")
                    {
                        var obj = (BLDate)JsonConvert.DeserializeObject(logService.Context, typeof(BLDate));
                        okRow += UpdateLogs(logService.Id, obj.order.Khdh) ? 1 : 0;
                    }
                    //CAD排程数据准备推送给BL
                    else if (logService.MessagePath == "PutCadBL" && logService.Lable == "SchedulingReady")
                    {
                        //无效，不需要解析，不包含所需要的关键索引
                    }
                    //CAD排程数据推送给BL
                    else if (logService.MessagePath == "PutCadBL" && logService.Lable == "CADScheduling")
                    {
                        var obj = (CadBlModelList)JsonConvert.DeserializeObject(logService.Context, typeof(CadBlModelList));
                        okRow += UpdateLogs(logService.Id, obj.ds?.First().customerId) ? 1 : 0;
                    }
                    //计划下达生成裁剪排程数据
                    else if (logService.MessagePath == "CaiJianOrder" && logService.Lable == "NewOrder")
                    {
                        okRow += UpdateLogs(logService.Id, logService.Context) ? 1 : 0;
                    }
                    //订单在各系统中流转的完工汇报
                    else if (logService.MessagePath == "Completion" && logService.Lable == "Completion")
                    {
                        var obj = (Completion)JsonConvert.DeserializeObject(logService.Context, typeof(Completion));
                        okRow += UpdateLogs(logService.Id, obj.CustmerId) ? 1 : 0;
                    }
                    //订单裁床定稿后生成Blank数据
                    else if (logService.MessagePath == "BlankingData" && logService.Lable == "NewOrder")
                    {
                        okRow += UpdateLogs(logService.Id, logService.Context) ? 1 : 0;
                    }
                    //回调接口的日志
                    else if (logService.MessagePath == "CallBackMsg" && logService.Lable == "Message")
                    {
                        //无效，不需要解析，不包含所需要的关键索引
                    }
                    //撤单
                    else if (logService.MessagePath == "KillOrder" && logService.Lable == "KillOrder")
                    {
                        okRow += UpdateLogs(logService.Id, logService.Context) ? 1 : 0;
                    }
                    //增加日志
                    else if (logService.MessagePath == "LogService" && logService.Lable == "AddLog")
                    {
                        //无效，不需要解析，不包含所需要的关键索引
                    }
                    //增加异常/错误日志
                    else if (logService.MessagePath == "LogService" && logService.Lable == "AddErrLog")
                    {
                        //无效，不需要解析，不包含所需要的关键索引
                    }
                    //获取MES工时日志
                    else if (logService.MessagePath == "OrderGetMesHour" && logService.Lable == "NewOrder")
                    {
                        okRow += UpdateLogs(logService.Id, logService.Context) ? 1 : 0;
                    }
                    //计算关键工序时间日志
                    else if (logService.MessagePath == "OrderGetMesHour" && logService.Lable == "KeyProcess")
                    {
                        okRow += UpdateLogs(logService.Id, new TBLDataOrdermx(TBLDataOrdermx.MxidColumn.ColumnName, logService.Context).Khdh) ? 1 : 0;
                    }
                    //从ERP获取计划数据
                    else if (logService.MessagePath == "PlanInfo" && (logService.Lable == "NewPlan"|| logService.Lable == "NewPlanMain"))
                    {
                        okRow += UpdateLogs(logService.Id, logService.Context) ? 1 : 0;
                    }

                    //执行后删除日志信息
                    logList.Remove(logService);

                    //每次执行，都刷新一下前端的数据，由于开启的是多线程，所以要解决跨线程访问控件

                    if (this.InvokeRequired)
                    {
                        Action actionDelegate = () =>
                        {
                            Grid_Log_NoHandle.DataSource = null;
                            Grid_Log_NoHandle.DataSource = logList;
                            Grid_Log_NoHandle.Refresh();
                        };

                        this.Grid_Log_NoHandle.Invoke(actionDelegate);
                    }
                    else
                    {
                        if (logList.Count > 11)
                            Grid_Log_NoHandle.Refresh();
                    }
                }

                Defaut.Notify.ShowBalloonTip(30, "智能解析日志处理提示", $"已有日志处理完毕，此次处理{okRow}条", ToolTipIcon.Info);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private bool UpdateLogs(int logId, string khdh)
        {
            try
            {
                if (string.IsNullOrEmpty(khdh))
                {
                    return false;
                }

                var row = new Update(TLogService.Schema)
                    .Set(TLogService.KhdhColumn).EqualTo(khdh)
                    .Where(TLogService.IdColumn).IsEqualTo(logId).Execute();

                return row > 0;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }

        private void btn_AutoHandleTimer_Click(object sender, EventArgs e)
        {
            Timer time = new Timer(1000 * 60 * 5);
            time.Elapsed += AutoHandleTimer;
            time.Start();
            lbl_msg.Visible = true;
            btn_AutoHandle.Enabled = false;
            btn_AutoHandleTimer.Enabled = false;
        }

        private void AutoHandleTimer(object sender, ElapsedEventArgs e)
        {
            LoadNoHandleData();
            Thread thread = new Thread(AutoHandle) { IsBackground = true };
            thread.Start();
        }

        private void Form_Log_ServiceAuto_Load(object sender, EventArgs e)
        {
            var item = new MenuItem("自动解析日志");
            item.Click += btn_AutoHandle_Click;
            Defaut.Notify.ContextMenu.MenuItems.Add(item);
        }
    }
}
