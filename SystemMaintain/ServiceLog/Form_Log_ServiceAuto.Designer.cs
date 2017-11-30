namespace SystemMaintain.ServiceLog
{
    partial class Form_Log_ServiceAuto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Grid_Log_NoHandle = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MessagePath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Context = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_AutoHandleTimer = new System.Windows.Forms.Button();
            this.btn_AutoHandle = new System.Windows.Forms.Button();
            this.lbl_msg = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Log_NoHandle)).BeginInit();
            this.SuspendLayout();
            // 
            // Grid_Log_NoHandle
            // 
            this.Grid_Log_NoHandle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_Log_NoHandle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Lable,
            this.MessagePath,
            this.Context});
            this.Grid_Log_NoHandle.Dock = System.Windows.Forms.DockStyle.Left;
            this.Grid_Log_NoHandle.Location = new System.Drawing.Point(0, 0);
            this.Grid_Log_NoHandle.Name = "Grid_Log_NoHandle";
            this.Grid_Log_NoHandle.ReadOnly = true;
            this.Grid_Log_NoHandle.RowTemplate.Height = 23;
            this.Grid_Log_NoHandle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Grid_Log_NoHandle.Size = new System.Drawing.Size(687, 285);
            this.Grid_Log_NoHandle.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "标识";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Lable
            // 
            this.Lable.DataPropertyName = "Lable";
            this.Lable.HeaderText = "标签";
            this.Lable.Name = "Lable";
            this.Lable.ReadOnly = true;
            // 
            // MessagePath
            // 
            this.MessagePath.DataPropertyName = "MessagePath";
            this.MessagePath.HeaderText = "路径";
            this.MessagePath.Name = "MessagePath";
            this.MessagePath.ReadOnly = true;
            // 
            // Context
            // 
            this.Context.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Context.DataPropertyName = "Context";
            this.Context.HeaderText = "内容";
            this.Context.Name = "Context";
            this.Context.ReadOnly = true;
            // 
            // btn_AutoHandleTimer
            // 
            this.btn_AutoHandleTimer.Location = new System.Drawing.Point(694, 232);
            this.btn_AutoHandleTimer.Name = "btn_AutoHandleTimer";
            this.btn_AutoHandleTimer.Size = new System.Drawing.Size(133, 41);
            this.btn_AutoHandleTimer.TabIndex = 1;
            this.btn_AutoHandleTimer.Text = "自动智能解析";
            this.btn_AutoHandleTimer.UseVisualStyleBackColor = true;
            this.btn_AutoHandleTimer.Click += new System.EventHandler(this.btn_AutoHandleTimer_Click);
            // 
            // btn_AutoHandle
            // 
            this.btn_AutoHandle.Location = new System.Drawing.Point(694, 185);
            this.btn_AutoHandle.Name = "btn_AutoHandle";
            this.btn_AutoHandle.Size = new System.Drawing.Size(133, 41);
            this.btn_AutoHandle.TabIndex = 1;
            this.btn_AutoHandle.Text = "智能解析处理";
            this.btn_AutoHandle.UseVisualStyleBackColor = true;
            this.btn_AutoHandle.Click += new System.EventHandler(this.btn_AutoHandle_Click);
            // 
            // lbl_msg
            // 
            this.lbl_msg.AutoSize = true;
            this.lbl_msg.Location = new System.Drawing.Point(702, 152);
            this.lbl_msg.Name = "lbl_msg";
            this.lbl_msg.Size = new System.Drawing.Size(125, 12);
            this.lbl_msg.TabIndex = 2;
            this.lbl_msg.Text = "自动解析正在运行中..";
            this.lbl_msg.Visible = false;
            // 
            // Form_Log_ServiceAuto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 285);
            this.Controls.Add(this.lbl_msg);
            this.Controls.Add(this.btn_AutoHandle);
            this.Controls.Add(this.btn_AutoHandleTimer);
            this.Controls.Add(this.Grid_Log_NoHandle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Log_ServiceAuto";
            this.Text = "Form_Log_ServiceAuto";
            this.Load += new System.EventHandler(this.Form_Log_ServiceAuto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Log_NoHandle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Grid_Log_NoHandle;
        private System.Windows.Forms.Button btn_AutoHandleTimer;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lable;
        private System.Windows.Forms.DataGridViewTextBoxColumn MessagePath;
        private System.Windows.Forms.DataGridViewTextBoxColumn Context;
        private System.Windows.Forms.Button btn_AutoHandle;
        private System.Windows.Forms.Label lbl_msg;
    }
}