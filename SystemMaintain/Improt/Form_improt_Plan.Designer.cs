namespace SystemMaintain.Improt
{
    partial class Form_improt_Plan
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
            this.txt_Scggdh = new System.Windows.Forms.TextBox();
            this.btn_ServiceERP = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_Scggdh
            // 
            this.txt_Scggdh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_Scggdh.Location = new System.Drawing.Point(3, 17);
            this.txt_Scggdh.Multiline = true;
            this.txt_Scggdh.Name = "txt_Scggdh";
            this.txt_Scggdh.Size = new System.Drawing.Size(695, 250);
            this.txt_Scggdh.TabIndex = 0;
            // 
            // btn_ServiceERP
            // 
            this.btn_ServiceERP.Location = new System.Drawing.Point(712, 241);
            this.btn_ServiceERP.Name = "btn_ServiceERP";
            this.btn_ServiceERP.Size = new System.Drawing.Size(119, 29);
            this.btn_ServiceERP.TabIndex = 10;
            this.btn_ServiceERP.Text = "推送到ERP接口";
            this.btn_ServiceERP.UseVisualStyleBackColor = true;
            this.btn_ServiceERP.Click += new System.EventHandler(this.btn_ServiceERP_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_Scggdh);
            this.groupBox1.Location = new System.Drawing.Point(6, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(701, 270);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SCGGDH 每行一个";
            // 
            // Form_improt_Plan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 285);
            this.Controls.Add(this.btn_ServiceERP);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_improt_Plan";
            this.Text = "Form_improt_Plan";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Scggdh;
        private System.Windows.Forms.Button btn_ServiceERP;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}