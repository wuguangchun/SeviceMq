namespace SystemMaintain.WebService
{
    partial class Form_BlToApsOrderData
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Service214 = new System.Windows.Forms.Button();
            this.btn_Service213 = new System.Windows.Forms.Button();
            this.btn_ServiceLocal = new System.Windows.Forms.Button();
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_Json);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(701, 270);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "BL推送的Json数据";
            // 
            // btn_Service214
            // 
            this.btn_Service214.Location = new System.Drawing.Point(718, 246);
            this.btn_Service214.Name = "btn_Service214";
            this.btn_Service214.Size = new System.Drawing.Size(119, 29);
            this.btn_Service214.TabIndex = 2;
            this.btn_Service214.Text = "推送到正式(7.214)";
            this.btn_Service214.UseVisualStyleBackColor = true;
            this.btn_Service214.Click += new System.EventHandler(this.btn_Service214_Click);
            // 
            // btn_Service213
            // 
            this.btn_Service213.Location = new System.Drawing.Point(718, 211);
            this.btn_Service213.Name = "btn_Service213";
            this.btn_Service213.Size = new System.Drawing.Size(119, 29);
            this.btn_Service213.TabIndex = 2;
            this.btn_Service213.Text = "推送到测试(7.213)";
            this.btn_Service213.UseVisualStyleBackColor = true;
            this.btn_Service213.Click += new System.EventHandler(this.btn_Service213_Click);
            // 
            // btn_ServiceLocal
            // 
            this.btn_ServiceLocal.Location = new System.Drawing.Point(719, 176);
            this.btn_ServiceLocal.Name = "btn_ServiceLocal";
            this.btn_ServiceLocal.Size = new System.Drawing.Size(119, 29);
            this.btn_ServiceLocal.TabIndex = 2;
            this.btn_ServiceLocal.Text = "推送到本地(local)";
            this.btn_ServiceLocal.UseVisualStyleBackColor = true;
            this.btn_ServiceLocal.Click += new System.EventHandler(this.btn_ServiceLocal_Click);
            // 
            // Form_BlToApsOrderData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 285);
            this.Controls.Add(this.btn_ServiceLocal);
            this.Controls.Add(this.btn_Service213);
            this.Controls.Add(this.btn_Service214);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_BlToApsOrderData";
            this.Text = "Form_BlToApsOrderData";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Json;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Service214;
        private System.Windows.Forms.Button btn_Service213;
        private System.Windows.Forms.Button btn_ServiceLocal;
    }
}