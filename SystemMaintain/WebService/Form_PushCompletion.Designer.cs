namespace SystemMaintain.WebService
{
    partial class Form_PushCompletion
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
            this.txt_Json = new System.Windows.Forms.TextBox();
            this.btn_ServiceLocal = new System.Windows.Forms.Button();
            this.btn_Service213 = new System.Windows.Forms.Button();
            this.btn_Service214 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmb_ConpMode = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_Json
            // 
            this.txt_Json.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_Json.Location = new System.Drawing.Point(3, 17);
            this.txt_Json.Multiline = true;
            this.txt_Json.Name = "txt_Json";
            this.txt_Json.Size = new System.Drawing.Size(695, 250);
            this.txt_Json.TabIndex = 0;
            // 
            // btn_ServiceLocal
            // 
            this.btn_ServiceLocal.Location = new System.Drawing.Point(713, 172);
            this.btn_ServiceLocal.Name = "btn_ServiceLocal";
            this.btn_ServiceLocal.Size = new System.Drawing.Size(119, 29);
            this.btn_ServiceLocal.TabIndex = 4;
            this.btn_ServiceLocal.Text = "推送到本地(local)";
            this.btn_ServiceLocal.UseVisualStyleBackColor = true;
            this.btn_ServiceLocal.Click += new System.EventHandler(this.btn_ServiceLocal_Click);
            // 
            // btn_Service213
            // 
            this.btn_Service213.Location = new System.Drawing.Point(712, 206);
            this.btn_Service213.Name = "btn_Service213";
            this.btn_Service213.Size = new System.Drawing.Size(119, 29);
            this.btn_Service213.TabIndex = 5;
            this.btn_Service213.Text = "推送到测试(7.213)";
            this.btn_Service213.UseVisualStyleBackColor = true;
            this.btn_Service213.Click += new System.EventHandler(this.btn_Service213_Click);
            // 
            // btn_Service214
            // 
            this.btn_Service214.Location = new System.Drawing.Point(712, 240);
            this.btn_Service214.Name = "btn_Service214";
            this.btn_Service214.Size = new System.Drawing.Size(119, 29);
            this.btn_Service214.TabIndex = 6;
            this.btn_Service214.Text = "推送到正式(7.214)";
            this.btn_Service214.UseVisualStyleBackColor = true;
            this.btn_Service214.Click += new System.EventHandler(this.btn_Service214_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_Json);
            this.groupBox1.Location = new System.Drawing.Point(6, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(701, 270);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "要操作订单的客户单号,每行一个";
            // 
            // cmb_ConpMode
            // 
            this.cmb_ConpMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_ConpMode.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmb_ConpMode.FormattingEnabled = true;
            this.cmb_ConpMode.Items.AddRange(new object[] {
            "选择要执行状态"});
            this.cmb_ConpMode.Location = new System.Drawing.Point(713, 145);
            this.cmb_ConpMode.Name = "cmb_ConpMode";
            this.cmb_ConpMode.Size = new System.Drawing.Size(119, 22);
            this.cmb_ConpMode.TabIndex = 7;
            // 
            // Form_PushCompletion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 285);
            this.Controls.Add(this.cmb_ConpMode);
            this.Controls.Add(this.btn_ServiceLocal);
            this.Controls.Add(this.btn_Service213);
            this.Controls.Add(this.btn_Service214);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_PushCompletion";
            this.Text = "Form_PushCompletion";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Json;
        private System.Windows.Forms.Button btn_ServiceLocal;
        private System.Windows.Forms.Button btn_Service213;
        private System.Windows.Forms.Button btn_Service214;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmb_ConpMode;
    }
}