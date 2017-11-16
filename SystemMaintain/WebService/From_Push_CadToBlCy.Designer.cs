namespace SystemMaintain.WebService
{
    partial class From_Push_CadToBlCy
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
            this.GridResult = new System.Windows.Forms.DataGridView();
            this.project = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StyleResult = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supportingWay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resources = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scggdh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_ServiceLocal = new System.Windows.Forms.Button();
            this.btn_Service213 = new System.Windows.Forms.Button();
            this.btn_Service214 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GridResult)).BeginInit();
            this.SuspendLayout();
            // 
            // GridResult
            // 
            this.GridResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridResult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.project,
            this.orderType,
            this.StyleResult,
            this.supportingWay,
            this.orderNo,
            this.resources,
            this.scggdh});
            this.GridResult.Dock = System.Windows.Forms.DockStyle.Left;
            this.GridResult.Location = new System.Drawing.Point(0, 0);
            this.GridResult.Name = "GridResult";
            this.GridResult.ReadOnly = true;
            this.GridResult.RowTemplate.Height = 23;
            this.GridResult.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridResult.Size = new System.Drawing.Size(711, 285);
            this.GridResult.TabIndex = 6;
            // 
            // project
            // 
            this.project.DataPropertyName = "project";
            this.project.HeaderText = "项目";
            this.project.Name = "project";
            this.project.ReadOnly = true;
            // 
            // orderType
            // 
            this.orderType.DataPropertyName = "orderType";
            this.orderType.HeaderText = "订单类型";
            this.orderType.Name = "orderType";
            this.orderType.ReadOnly = true;
            // 
            // StyleResult
            // 
            this.StyleResult.DataPropertyName = "StyleResult";
            this.StyleResult.HeaderText = "样式";
            this.StyleResult.Name = "StyleResult";
            this.StyleResult.ReadOnly = true;
            // 
            // supportingWay
            // 
            this.supportingWay.DataPropertyName = "supportingWay";
            this.supportingWay.HeaderText = "配套方式";
            this.supportingWay.Name = "supportingWay";
            this.supportingWay.ReadOnly = true;
            // 
            // orderNo
            // 
            this.orderNo.DataPropertyName = "orderNo";
            this.orderNo.HeaderText = "客户单号";
            this.orderNo.Name = "orderNo";
            this.orderNo.ReadOnly = true;
            // 
            // resources
            // 
            this.resources.DataPropertyName = "resources";
            this.resources.HeaderText = "人员编号";
            this.resources.Name = "resources";
            this.resources.ReadOnly = true;
            // 
            // scggdh
            // 
            this.scggdh.DataPropertyName = "scggdh";
            this.scggdh.HeaderText = "规格单号";
            this.scggdh.Name = "scggdh";
            this.scggdh.ReadOnly = true;
            // 
            // btn_ServiceLocal
            // 
            this.btn_ServiceLocal.Location = new System.Drawing.Point(719, 180);
            this.btn_ServiceLocal.Name = "btn_ServiceLocal";
            this.btn_ServiceLocal.Size = new System.Drawing.Size(119, 29);
            this.btn_ServiceLocal.TabIndex = 7;
            this.btn_ServiceLocal.Text = "推送到本地(local)";
            this.btn_ServiceLocal.UseVisualStyleBackColor = true;
            this.btn_ServiceLocal.Click += new System.EventHandler(this.btn_ServiceLocal_Click);
            // 
            // btn_Service213
            // 
            this.btn_Service213.Location = new System.Drawing.Point(718, 215);
            this.btn_Service213.Name = "btn_Service213";
            this.btn_Service213.Size = new System.Drawing.Size(119, 29);
            this.btn_Service213.TabIndex = 8;
            this.btn_Service213.Text = "推送到测试(7.213)";
            this.btn_Service213.UseVisualStyleBackColor = true;
            this.btn_Service213.Click += new System.EventHandler(this.btn_Service213_Click);
            // 
            // btn_Service214
            // 
            this.btn_Service214.Location = new System.Drawing.Point(718, 250);
            this.btn_Service214.Name = "btn_Service214";
            this.btn_Service214.Size = new System.Drawing.Size(119, 29);
            this.btn_Service214.TabIndex = 9;
            this.btn_Service214.Text = "推送到正式(7.214)";
            this.btn_Service214.UseVisualStyleBackColor = true;
            this.btn_Service214.Click += new System.EventHandler(this.btn_Service214_Click);
            // 
            // From_Push_CadToBlCy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 285);
            this.Controls.Add(this.GridResult);
            this.Controls.Add(this.btn_ServiceLocal);
            this.Controls.Add(this.btn_Service213);
            this.Controls.Add(this.btn_Service214);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "From_Push_CadToBlCy";
            this.Text = "From_Push_CadToBlCy";
            ((System.ComponentModel.ISupportInitialize)(this.GridResult)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView GridResult;
        private System.Windows.Forms.DataGridViewTextBoxColumn project;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderType;
        private System.Windows.Forms.DataGridViewTextBoxColumn StyleResult;
        private System.Windows.Forms.DataGridViewTextBoxColumn supportingWay;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn resources;
        private System.Windows.Forms.DataGridViewTextBoxColumn scggdh;
        private System.Windows.Forms.Button btn_ServiceLocal;
        private System.Windows.Forms.Button btn_Service213;
        private System.Windows.Forms.Button btn_Service214;
    }
}