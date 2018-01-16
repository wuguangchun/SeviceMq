namespace SystemMaintain
{
    partial class Defaut
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Defaut));
            this.tool_menu = new System.Windows.Forms.ToolStrip();
            this.select = new System.Windows.Forms.ToolStripSplitButton();
            this.Select_Basicdata = new System.Windows.Forms.ToolStripMenuItem();
            this.Select_CADData = new System.Windows.Forms.ToolStripMenuItem();
            this.Select_CADSchedulingData = new System.Windows.Forms.ToolStripMenuItem();
            this.Select_CADResultData = new System.Windows.Forms.ToolStripMenuItem();
            this.计划数据ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Select_PlanXfMtm = new System.Windows.Forms.ToolStripMenuItem();
            this.Select_PlanXfTz = new System.Windows.Forms.ToolStripMenuItem();
            this.Select_PlanCyMtm = new System.Windows.Forms.ToolStripMenuItem();
            this.Select_PlanCyTz = new System.Windows.Forms.ToolStripMenuItem();
            this.裁剪数据ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Select_SchedulingCjData = new System.Windows.Forms.ToolStripMenuItem();
            this.Select_ResultCjData = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.Push_BlToAps = new System.Windows.Forms.ToolStripMenuItem();
            this.Push_CadToBl = new System.Windows.Forms.ToolStripMenuItem();
            this.Push_CadToBlXf = new System.Windows.Forms.ToolStripMenuItem();
            this.Push_CadToBlCy = new System.Windows.Forms.ToolStripMenuItem();
            this.Push_Completion = new System.Windows.Forms.ToolStripMenuItem();
            this.生成CAD数据ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.New_CadData = new System.Windows.Forms.ToolStripMenuItem();
            this.New_CjData = new System.Windows.Forms.ToolStripMenuItem();
            this.New_DlData = new System.Windows.Forms.ToolStripMenuItem();
            this.KillOrder = new System.Windows.Forms.ToolStripMenuItem();
            this.KillOrderAll = new System.Windows.Forms.ToolStripMenuItem();
            this.单品撤单ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Intercourse = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSplitButton3 = new System.Windows.Forms.ToolStripSplitButton();
            this.Excel_To_Db = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSplitButton2 = new System.Windows.Forms.ToolStripSplitButton();
            this.log_Service = new System.Windows.Forms.ToolStripMenuItem();
            this.log_serviceError = new System.Windows.Forms.ToolStripMenuItem();
            this.老接口日志log_serviceOld = new System.Windows.Forms.ToolStripMenuItem();
            this.log_serviceErrorOld = new System.Windows.Forms.ToolStripMenuItem();
            this.log_serviceAuto = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPageDefault = new System.Windows.Forms.TabPage();
            this.tab_box = new System.Windows.Forms.TabControl();
            this.tabBoxMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.BlSendPld = new System.Windows.Forms.ToolStripMenuItem();
            this.tool_menu.SuspendLayout();
            this.tab_box.SuspendLayout();
            this.SuspendLayout();
            // 
            // tool_menu
            // 
            this.tool_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.select,
            this.toolStripSplitButton1,
            this.toolStripSplitButton3,
            this.toolStripSplitButton2});
            this.tool_menu.Location = new System.Drawing.Point(0, 0);
            this.tool_menu.Name = "tool_menu";
            this.tool_menu.Size = new System.Drawing.Size(847, 25);
            this.tool_menu.TabIndex = 0;
            this.tool_menu.Text = "toolStrip1";
            // 
            // select
            // 
            this.select.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.select.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Select_Basicdata,
            this.Select_CADData,
            this.计划数据ToolStripMenuItem,
            this.裁剪数据ToolStripMenuItem});
            this.select.Image = ((System.Drawing.Image)(resources.GetObject("select.Image")));
            this.select.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.select.Name = "select";
            this.select.Size = new System.Drawing.Size(72, 22);
            this.select.Text = "日常查询";
            // 
            // Select_Basicdata
            // 
            this.Select_Basicdata.Name = "Select_Basicdata";
            this.Select_Basicdata.Size = new System.Drawing.Size(125, 22);
            this.Select_Basicdata.Text = "基础数据";
            this.Select_Basicdata.Click += new System.EventHandler(this.Select_Basicdata_Click);
            // 
            // Select_CADData
            // 
            this.Select_CADData.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Select_CADSchedulingData,
            this.Select_CADResultData});
            this.Select_CADData.Name = "Select_CADData";
            this.Select_CADData.Size = new System.Drawing.Size(125, 22);
            this.Select_CADData.Text = "CAD数据";
            // 
            // Select_CADSchedulingData
            // 
            this.Select_CADSchedulingData.Name = "Select_CADSchedulingData";
            this.Select_CADSchedulingData.Size = new System.Drawing.Size(124, 22);
            this.Select_CADSchedulingData.Text = "排程数据";
            // 
            // Select_CADResultData
            // 
            this.Select_CADResultData.Name = "Select_CADResultData";
            this.Select_CADResultData.Size = new System.Drawing.Size(124, 22);
            this.Select_CADResultData.Text = "排程结果";
            // 
            // 计划数据ToolStripMenuItem
            // 
            this.计划数据ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Select_PlanXfMtm,
            this.Select_PlanXfTz,
            this.Select_PlanCyMtm,
            this.Select_PlanCyTz});
            this.计划数据ToolStripMenuItem.Name = "计划数据ToolStripMenuItem";
            this.计划数据ToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.计划数据ToolStripMenuItem.Text = "计划数据";
            // 
            // Select_PlanXfMtm
            // 
            this.Select_PlanXfMtm.Name = "Select_PlanXfMtm";
            this.Select_PlanXfMtm.Size = new System.Drawing.Size(136, 22);
            this.Select_PlanXfMtm.Text = "西服/MTM";
            // 
            // Select_PlanXfTz
            // 
            this.Select_PlanXfTz.Name = "Select_PlanXfTz";
            this.Select_PlanXfTz.Size = new System.Drawing.Size(136, 22);
            this.Select_PlanXfTz.Text = "西服/团装";
            // 
            // Select_PlanCyMtm
            // 
            this.Select_PlanCyMtm.Name = "Select_PlanCyMtm";
            this.Select_PlanCyMtm.Size = new System.Drawing.Size(136, 22);
            this.Select_PlanCyMtm.Text = "衬衣/MTM";
            // 
            // Select_PlanCyTz
            // 
            this.Select_PlanCyTz.Name = "Select_PlanCyTz";
            this.Select_PlanCyTz.Size = new System.Drawing.Size(136, 22);
            this.Select_PlanCyTz.Text = "衬衣/团装";
            // 
            // 裁剪数据ToolStripMenuItem
            // 
            this.裁剪数据ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Select_SchedulingCjData,
            this.Select_ResultCjData});
            this.裁剪数据ToolStripMenuItem.Name = "裁剪数据ToolStripMenuItem";
            this.裁剪数据ToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.裁剪数据ToolStripMenuItem.Text = "裁剪数据";
            // 
            // Select_SchedulingCjData
            // 
            this.Select_SchedulingCjData.Name = "Select_SchedulingCjData";
            this.Select_SchedulingCjData.Size = new System.Drawing.Size(124, 22);
            this.Select_SchedulingCjData.Text = "排程数据";
            // 
            // Select_ResultCjData
            // 
            this.Select_ResultCjData.Name = "Select_ResultCjData";
            this.Select_ResultCjData.Size = new System.Drawing.Size(124, 22);
            this.Select_ResultCjData.Text = "排程结果";
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Push_BlToAps,
            this.Push_CadToBl,
            this.Push_Completion,
            this.生成CAD数据ToolStripMenuItem,
            this.KillOrder,
            this.Intercourse,
            this.BlSendPld});
            this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(72, 22);
            this.toolStripSplitButton1.Text = "接口处理";
            this.toolStripSplitButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // Push_BlToAps
            // 
            this.Push_BlToAps.Name = "Push_BlToAps";
            this.Push_BlToAps.Size = new System.Drawing.Size(152, 22);
            this.Push_BlToAps.Text = "BL订单推送";
            this.Push_BlToAps.Click += new System.EventHandler(this.Push_BlToAps_Click);
            // 
            // Push_CadToBl
            // 
            this.Push_CadToBl.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Push_CadToBlXf,
            this.Push_CadToBlCy});
            this.Push_CadToBl.Name = "Push_CadToBl";
            this.Push_CadToBl.Size = new System.Drawing.Size(152, 22);
            this.Push_CadToBl.Text = "排程CAD推送";
            // 
            // Push_CadToBlXf
            // 
            this.Push_CadToBlXf.Name = "Push_CadToBlXf";
            this.Push_CadToBlXf.Size = new System.Drawing.Size(148, 22);
            this.Push_CadToBlXf.Text = "西服数据推送";
            this.Push_CadToBlXf.Click += new System.EventHandler(this.Push_CadToBlXf_Click);
            // 
            // Push_CadToBlCy
            // 
            this.Push_CadToBlCy.Name = "Push_CadToBlCy";
            this.Push_CadToBlCy.Size = new System.Drawing.Size(148, 22);
            this.Push_CadToBlCy.Text = "衬衣数据推送";
            this.Push_CadToBlCy.Click += new System.EventHandler(this.Push_CadToBlCy_Click);
            // 
            // Push_Completion
            // 
            this.Push_Completion.Name = "Push_Completion";
            this.Push_Completion.Size = new System.Drawing.Size(152, 22);
            this.Push_Completion.Text = "完工汇报";
            this.Push_Completion.Click += new System.EventHandler(this.Push_Completion_Click);
            // 
            // 生成CAD数据ToolStripMenuItem
            // 
            this.生成CAD数据ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.New_CadData,
            this.New_CjData,
            this.New_DlData});
            this.生成CAD数据ToolStripMenuItem.Name = "生成CAD数据ToolStripMenuItem";
            this.生成CAD数据ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.生成CAD数据ToolStripMenuItem.Text = "生成数据";
            // 
            // New_CadData
            // 
            this.New_CadData.Name = "New_CadData";
            this.New_CadData.Size = new System.Drawing.Size(101, 22);
            this.New_CadData.Text = "CAD";
            // 
            // New_CjData
            // 
            this.New_CjData.Name = "New_CjData";
            this.New_CjData.Size = new System.Drawing.Size(101, 22);
            this.New_CjData.Text = "裁剪";
            this.New_CjData.Click += new System.EventHandler(this.New_CjData_Click);
            // 
            // New_DlData
            // 
            this.New_DlData.Name = "New_DlData";
            this.New_DlData.Size = new System.Drawing.Size(101, 22);
            this.New_DlData.Text = "段料";
            this.New_DlData.Click += new System.EventHandler(this.New_DlData_Click);
            // 
            // KillOrder
            // 
            this.KillOrder.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.KillOrderAll,
            this.单品撤单ToolStripMenuItem});
            this.KillOrder.Name = "KillOrder";
            this.KillOrder.Size = new System.Drawing.Size(152, 22);
            this.KillOrder.Text = "订单撤单";
            // 
            // KillOrderAll
            // 
            this.KillOrderAll.Name = "KillOrderAll";
            this.KillOrderAll.Size = new System.Drawing.Size(124, 22);
            this.KillOrderAll.Text = "客户撤单";
            this.KillOrderAll.Click += new System.EventHandler(this.KillOrderAll_Click);
            // 
            // 单品撤单ToolStripMenuItem
            // 
            this.单品撤单ToolStripMenuItem.Name = "单品撤单ToolStripMenuItem";
            this.单品撤单ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.单品撤单ToolStripMenuItem.Text = "单品撤单";
            // 
            // Intercourse
            // 
            this.Intercourse.Name = "Intercourse";
            this.Intercourse.Size = new System.Drawing.Size(152, 22);
            this.Intercourse.Text = "往来户通知";
            this.Intercourse.Click += new System.EventHandler(this.Intercourse_Click);
            // 
            // toolStripSplitButton3
            // 
            this.toolStripSplitButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripSplitButton3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Excel_To_Db});
            this.toolStripSplitButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton3.Image")));
            this.toolStripSplitButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton3.Name = "toolStripSplitButton3";
            this.toolStripSplitButton3.Size = new System.Drawing.Size(72, 22);
            this.toolStripSplitButton3.Text = "数据导入";
            // 
            // Excel_To_Db
            // 
            this.Excel_To_Db.Name = "Excel_To_Db";
            this.Excel_To_Db.Size = new System.Drawing.Size(136, 22);
            this.Excel_To_Db.Text = "EXCEL导入";
            this.Excel_To_Db.Click += new System.EventHandler(this.Excel_To_Db_Click);
            // 
            // toolStripSplitButton2
            // 
            this.toolStripSplitButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripSplitButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.log_Service,
            this.log_serviceError,
            this.老接口日志log_serviceOld,
            this.log_serviceErrorOld,
            this.log_serviceAuto});
            this.toolStripSplitButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton2.Image")));
            this.toolStripSplitButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton2.Name = "toolStripSplitButton2";
            this.toolStripSplitButton2.Size = new System.Drawing.Size(72, 22);
            this.toolStripSplitButton2.Text = "日志处理";
            // 
            // log_Service
            // 
            this.log_Service.Name = "log_Service";
            this.log_Service.Size = new System.Drawing.Size(160, 22);
            this.log_Service.Text = "系统日志";
            // 
            // log_serviceError
            // 
            this.log_serviceError.Name = "log_serviceError";
            this.log_serviceError.Size = new System.Drawing.Size(160, 22);
            this.log_serviceError.Text = "异常日志";
            this.log_serviceError.Click += new System.EventHandler(this.log_serviceError_Click);
            // 
            // 老接口日志log_serviceOld
            // 
            this.老接口日志log_serviceOld.Name = "老接口日志log_serviceOld";
            this.老接口日志log_serviceOld.Size = new System.Drawing.Size(160, 22);
            this.老接口日志log_serviceOld.Text = "老接口日志";
            // 
            // log_serviceErrorOld
            // 
            this.log_serviceErrorOld.Name = "log_serviceErrorOld";
            this.log_serviceErrorOld.Size = new System.Drawing.Size(160, 22);
            this.log_serviceErrorOld.Text = "老接口异常日志";
            // 
            // log_serviceAuto
            // 
            this.log_serviceAuto.Name = "log_serviceAuto";
            this.log_serviceAuto.Size = new System.Drawing.Size(160, 22);
            this.log_serviceAuto.Text = "日志标识处理";
            this.log_serviceAuto.Click += new System.EventHandler(this.log_serviceAuto_Click);
            // 
            // tabPageDefault
            // 
            this.tabPageDefault.Location = new System.Drawing.Point(4, 22);
            this.tabPageDefault.Name = "tabPageDefault";
            this.tabPageDefault.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDefault.Size = new System.Drawing.Size(839, 307);
            this.tabPageDefault.TabIndex = 0;
            this.tabPageDefault.Text = "操作须知";
            this.tabPageDefault.UseVisualStyleBackColor = true;
            // 
            // tab_box
            // 
            this.tab_box.ContextMenuStrip = this.tabBoxMenu;
            this.tab_box.Controls.Add(this.tabPageDefault);
            this.tab_box.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tab_box.Location = new System.Drawing.Point(0, 25);
            this.tab_box.Name = "tab_box";
            this.tab_box.SelectedIndex = 0;
            this.tab_box.Size = new System.Drawing.Size(847, 333);
            this.tab_box.TabIndex = 1;
            // 
            // tabBoxMenu
            // 
            this.tabBoxMenu.Name = "tabBoxMenu";
            this.tabBoxMenu.Size = new System.Drawing.Size(61, 4);
            this.tabBoxMenu.Text = "关闭TAB";
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "异常快速处理程序";
            this.notifyIcon.Visible = true;
            this.notifyIcon.DoubleClick += new System.EventHandler(this.notifyIcon_DoubleClick);
            // 
            // BlSendPld
            // 
            this.BlSendPld.Name = "BlSendPld";
            this.BlSendPld.Size = new System.Drawing.Size(152, 22);
            this.BlSendPld.Text = "BL排料单推送";
            this.BlSendPld.Click += new System.EventHandler(this.BlSendPld_Click);
            // 
            // Defaut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 358);
            this.Controls.Add(this.tab_box);
            this.Controls.Add(this.tool_menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Defaut";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "APS 系统维护";
            this.SizeChanged += new System.EventHandler(this.Defaut_SizeChanged);
            this.tool_menu.ResumeLayout(false);
            this.tool_menu.PerformLayout();
            this.tab_box.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tool_menu;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripMenuItem Push_BlToAps;
        private System.Windows.Forms.ToolStripMenuItem Push_CadToBl;
        private System.Windows.Forms.ToolStripMenuItem Push_Completion;
        private System.Windows.Forms.ToolStripMenuItem 生成CAD数据ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem New_CadData;
        private System.Windows.Forms.ToolStripMenuItem New_CjData;
        private System.Windows.Forms.ToolStripMenuItem New_DlData;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton2;
        private System.Windows.Forms.ToolStripMenuItem log_Service;
        private System.Windows.Forms.ToolStripMenuItem log_serviceError;
        private System.Windows.Forms.ToolStripMenuItem 老接口日志log_serviceOld;
        private System.Windows.Forms.ToolStripMenuItem log_serviceErrorOld;
        private System.Windows.Forms.ToolStripSplitButton select;
        private System.Windows.Forms.ToolStripMenuItem Select_Basicdata;
        private System.Windows.Forms.ToolStripMenuItem Select_CADData;
        private System.Windows.Forms.ToolStripMenuItem Select_CADSchedulingData;
        private System.Windows.Forms.ToolStripMenuItem Select_CADResultData;
        private System.Windows.Forms.ToolStripMenuItem 计划数据ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Select_PlanXfMtm;
        private System.Windows.Forms.ToolStripMenuItem Select_PlanXfTz;
        private System.Windows.Forms.ToolStripMenuItem Select_PlanCyMtm;
        private System.Windows.Forms.ToolStripMenuItem Select_PlanCyTz;
        private System.Windows.Forms.ToolStripMenuItem 裁剪数据ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Select_SchedulingCjData;
        private System.Windows.Forms.ToolStripMenuItem Select_ResultCjData;
        private System.Windows.Forms.TabPage tabPageDefault;
        private System.Windows.Forms.TabControl tab_box;
        private System.Windows.Forms.ContextMenuStrip tabBoxMenu;
        private System.Windows.Forms.ToolStripMenuItem Push_CadToBlXf;
        private System.Windows.Forms.ToolStripMenuItem Push_CadToBlCy;
        private System.Windows.Forms.ToolStripMenuItem log_serviceAuto;
        public System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton3;
        private System.Windows.Forms.ToolStripMenuItem Excel_To_Db;
        private System.Windows.Forms.ToolStripMenuItem KillOrder;
        private System.Windows.Forms.ToolStripMenuItem KillOrderAll;
        private System.Windows.Forms.ToolStripMenuItem 单品撤单ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Intercourse;
        private System.Windows.Forms.ToolStripMenuItem BlSendPld;
    }
}

