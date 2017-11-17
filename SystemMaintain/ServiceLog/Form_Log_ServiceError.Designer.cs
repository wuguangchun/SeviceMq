namespace SystemMaintain.ServiceLog
{
    partial class Form_Log_ServiceError
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
            this.Grid_ErrList = new System.Windows.Forms.DataGridView();
            this.MessageId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Message = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_ErrList)).BeginInit();
            this.SuspendLayout();
            // 
            // Grid_ErrList
            // 
            this.Grid_ErrList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_ErrList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MessageId,
            this.Message,
            this.CreateTime});
            this.Grid_ErrList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Grid_ErrList.Location = new System.Drawing.Point(0, 0);
            this.Grid_ErrList.Name = "Grid_ErrList";
            this.Grid_ErrList.ReadOnly = true;
            this.Grid_ErrList.RowTemplate.Height = 23;
            this.Grid_ErrList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Grid_ErrList.Size = new System.Drawing.Size(839, 285);
            this.Grid_ErrList.TabIndex = 0;
            this.Grid_ErrList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid_ErrList_CellDoubleClick);
            // 
            // MessageId
            // 
            this.MessageId.DataPropertyName = "MessageId";
            this.MessageId.HeaderText = "消息ID";
            this.MessageId.Name = "MessageId";
            // 
            // Message
            // 
            this.Message.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Message.DataPropertyName = "Message";
            this.Message.HeaderText = "错误提示";
            this.Message.Name = "Message";
            // 
            // CreateTime
            // 
            this.CreateTime.DataPropertyName = "CreateTime";
            this.CreateTime.HeaderText = " 发生时间";
            this.CreateTime.Name = "CreateTime";
            // 
            // Form_Log_ServiceError
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 285);
            this.Controls.Add(this.Grid_ErrList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Log_ServiceError";
            this.Text = "Form_Log_ServiceError";
            ((System.ComponentModel.ISupportInitialize)(this.Grid_ErrList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Grid_ErrList;
        private System.Windows.Forms.DataGridViewTextBoxColumn MessageId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Message;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreateTime;
    }
}