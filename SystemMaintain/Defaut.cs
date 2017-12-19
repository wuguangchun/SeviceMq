using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SystemMaintain.DailyQuery.Basicdata;
using SystemMaintain.Improt;
using SystemMaintain.ServiceLog;
using SystemMaintain.WebService;

namespace SystemMaintain
{
    public partial class Defaut : Form
    {
        public static NotifyIcon Notify;
        public Defaut()
        {
            InitializeComponent();
            Notify = notifyIcon;
            notifyIcon.ContextMenu = new ContextMenu();
            notifyIcon.BalloonTipClicked += notifyIcon_DoubleClick;
        }


        #region 基础数据查询

        //基础数据查询首页
        private void Select_Basicdata_Click(object sender, EventArgs e)
        {
            //新增TAB页面 
            TabPage tabPage = AddTabPage(@"基础数据", "Tab_Basicdata");

            //实例化基础数据窗口
            var fromBasicdata = new From_Basicdata
            {
                TopLevel = false,
                Parent = tabPage
            };

            fromBasicdata.DataGrid.DataSource = new DataTable();
            fromBasicdata.Show();

        }
        #endregion

        #region 接口处理

        //调试BL基础数据推送到APS
        private void Push_BlToAps_Click(object sender, EventArgs e)
        {
            /* 数据走向
             * BL材料库定稿 → APSData数据库
             * 实现过程：BL材料库定稿 → APS消息接受 → Handle处理消息
             */

            //新增TAB页面 
            TabPage tabPage = AddTabPage(@"BL数据推送", "Tab_Push_BlToAps");

            var form = new Form_BlToApsOrderData { TopLevel = false, Parent = tabPage };
            form.Show();
        }

        //西服排程结果推送到BL
        private void Push_CadToBlXf_Click(object sender, EventArgs e)
        {
            /* 数据走向
             * CAD排程完成后的输出数据 → BL数据库
             * 实现过程： Asprova 排程结束 调用客户端通知 → WebService接口准备数据到MQ  →  Handle将队列数据推送到BL接口
             */
            //新增TAB页面 
            TabPage tabPage = AddTabPage(@"西服排程数据", "Tab_Push_CadToBlXf");

            var form = new From_Push_CadToBlXf() { TopLevel = false, Parent = tabPage };
            form.Show();
        }

        //衬衣排程结果推送到BL
        private void Push_CadToBlCy_Click(object sender, EventArgs e)
        {
            /* 数据走向
             * CAD排程完成后的输出数据 → BL数据库
             * 实现过程： Asprova 排程结束 调用客户端通知 → WebService接口准备数据到MQ  →  Handle将队列数据推送到BL接口
             */
            //新增TAB页面 
            TabPage tabPage = AddTabPage(@"衬衣排程数据", "Tab_Push_CadToBlCy");

            var form = new From_Push_CadToBlCy { TopLevel = false, Parent = tabPage };
            form.Show();
        }

        //完工汇报
        private void Push_Completion_Click(object sender, EventArgs e)
        {
            /* 数据走向
             * BL-CAD 在页面操作定稿/发送到PAD/关闭/锁定/提交CAD 分别推送 106/102/105/104/103
             * 计划下达 推送201 并制造一条生成裁剪数据的通知
             * 段料的处理打印完毕 推送301 并制造一条生成Banking的数据通知
             * 裁剪末工序MES打卡 推送302
             */

            //新增TAB页面 
            TabPage tabPage = AddTabPage(@"完工汇报推送", "Tab_Push_Completion");

            var form = new Form_PushCompletion { TopLevel = false, Parent = tabPage };
            form.Show();
        }

        //生成裁剪数据通知
        private void New_CjData_Click(object sender, EventArgs e)
        {
            /* 数据走向
            * 计划下达后 → 生成裁剪数据
            */

            //新增TAB页面 
            TabPage tabPage = AddTabPage(@"生成裁剪数据", "Tab_New_CjData");

            var form = new Form_New_CjData { TopLevel = false, Parent = tabPage };
            form.Show();
        }

        //生成段料数据通知
        private void New_DlData_Click(object sender, EventArgs e)
        {
            /* 数据走向
            * 裁床定稿 → 生成段料数据
            */

            //新增TAB页面 
            TabPage tabPage = AddTabPage(@"生成段料数据", "Tab_New_DlData");

            var form = new Form_New_CjData { TopLevel = false, Parent = tabPage };
            form.Show();

        }

        //智能解析日志的客户单号，更新
        private void log_serviceAuto_Click(object sender, EventArgs e)
        {
            /* 数据走向
            * 读取没有解析的日志，解析日志，添入客户单号
            */

            //新增TAB页面 
            TabPage tabPage = AddTabPage(@"日志标识", "Tab_log_serviceAuto");

            var form = new Form_Log_ServiceAuto() { TopLevel = false, Parent = tabPage };
            form.Show();
        }
        #endregion

        #region 数据导入
        //西服排程结果推送到BL
        private void Excel_To_Db_Click(object sender, EventArgs e)
        {
            /* 数据走向
             * CAD排程完成后的输出数据 → BL数据库
             * 实现过程： Asprova 排程结束 调用客户端通知 → WebService接口准备数据到MQ  →  Handle将队列数据推送到BL接口
             */
            //新增TAB页面 
            TabPage tabPage = AddTabPage(@"Excle数据导入", "Tab_Excel_To_Db");

            var form = new Form_Improt_Excel { TopLevel = false, Parent = tabPage };
            form.Show();
        }
        #endregion

        #region 日志处理
        private void log_serviceError_Click(object sender, EventArgs e)
        {
            TabPage tabPage = AddTabPage(@"异常日志", "Tab_serviceError");

            //实例化基础数据窗口
            var fromBasicdata = new Form_Log_ServiceError
            {
                TopLevel = false,
                Parent = tabPage
            };

            fromBasicdata.Show();
        }
        #endregion

        #region 新增TAB帮助类

        public TabPage AddTabPage(string tabTitle, string tabName)
        {
            foreach (TabPage page in tab_box.TabPages)
            {
                if (page.Name == tabName)
                {
                    tab_box.SelectedTab = page;
                    return page;
                }
            }

            //新增一个TAB页
            var tabPage = new TabPage { Text = tabTitle, Name = tabName };

            //将新TAB添加到Box并取得焦点
            tab_box.TabPages.Add(tabPage);
            tab_box.SelectedTab = tabPage;

            //将新窗口添加到右键菜单
            var toolStrip = new ToolStripMenuItem { Text = tabTitle, Tag = tabName };
            toolStrip.Click += tabBoxMenus_Click;
            toolStrip.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
            toolStrip.Image = SystemMaintain.Properties.Resources.timg;


            tabBoxMenu.Items.Add(toolStrip);

            return tabPage;
        }

        #endregion

        #region 菜单点击事件

        private void tabBoxMenus_Click(object sender, EventArgs e)
        {
            var obj = (ToolStripMenuItem)sender;
            foreach (TabPage page in tab_box.TabPages)
            {
                if (page.Name == obj.Tag)
                {
                    tab_box.TabPages.Remove(page);
                    break;
                }
            }

            var menu = tabBoxMenu.Items;
            foreach (ToolStripMenuItem item in menu)
            {
                if (item.Tag == obj.Tag)
                {
                    tabBoxMenu.Items.Remove(item);
                    break;
                }
            }
        }




        #endregion

        #region 窗口大小改变时监听

        private void Defaut_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                if (this.notifyIcon.Visible != true)
                {
                    this.notifyIcon.Visible = true;
                }
            }
        }

        //双击托盘图标时事件
        private void notifyIcon_DoubleClick(object sender, EventArgs e)
        {
            this.Visible = true;
            this.WindowState = FormWindowState.Normal;
            //this.notifyIcon.Visible = false;

        }


        #endregion


    }
}
