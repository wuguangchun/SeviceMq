namespace SystemMaintain.Improt
{
    partial class Form_Improt_Template
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
            this.btn_SaveBase = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_bytes = new System.Windows.Forms.TextBox();
            this.txt_FileName = new System.Windows.Forms.TextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.btn_SelectFile = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_SaveBase
            // 
            this.btn_SaveBase.Location = new System.Drawing.Point(713, 241);
            this.btn_SaveBase.Name = "btn_SaveBase";
            this.btn_SaveBase.Size = new System.Drawing.Size(119, 29);
            this.btn_SaveBase.TabIndex = 12;
            this.btn_SaveBase.Text = "上传到数据库";
            this.btn_SaveBase.UseVisualStyleBackColor = true;
            this.btn_SaveBase.Click += new System.EventHandler(this.btn_SaveBase_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_bytes);
            this.groupBox1.Location = new System.Drawing.Point(7, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(701, 270);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "文件的数据流信息";
            // 
            // txt_bytes
            // 
            this.txt_bytes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_bytes.Location = new System.Drawing.Point(3, 17);
            this.txt_bytes.Multiline = true;
            this.txt_bytes.Name = "txt_bytes";
            this.txt_bytes.Size = new System.Drawing.Size(695, 250);
            this.txt_bytes.TabIndex = 0;
            // 
            // txt_FileName
            // 
            this.txt_FileName.Location = new System.Drawing.Point(714, 201);
            this.txt_FileName.Name = "txt_FileName";
            this.txt_FileName.Size = new System.Drawing.Size(118, 21);
            this.txt_FileName.TabIndex = 13;
            this.txt_FileName.Text = "文件名称";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            this.openFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog_FileOk);
            // 
            // btn_SelectFile
            // 
            this.btn_SelectFile.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_SelectFile.Location = new System.Drawing.Point(714, 126);
            this.btn_SelectFile.Name = "btn_SelectFile";
            this.btn_SelectFile.Size = new System.Drawing.Size(113, 69);
            this.btn_SelectFile.TabIndex = 14;
            this.btn_SelectFile.Text = "选择模板文件";
            this.btn_SelectFile.UseVisualStyleBackColor = true;
            this.btn_SelectFile.Click += new System.EventHandler(this.btn_SelectFile_Click);
            // 
            // Form_Improt_Template
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 285);
            this.Controls.Add(this.btn_SelectFile);
            this.Controls.Add(this.txt_FileName);
            this.Controls.Add(this.btn_SaveBase);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Improt_Template";
            this.Text = "Form_Improt_Template";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_SaveBase;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_bytes;
        private System.Windows.Forms.TextBox txt_FileName;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button btn_SelectFile;
    }
}