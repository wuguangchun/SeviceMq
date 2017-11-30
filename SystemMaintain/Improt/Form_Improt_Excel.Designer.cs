namespace SystemMaintain.Improt
{
    partial class Form_Improt_Excel
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Grid_Excle = new System.Windows.Forms.DataGridView();
            this.btn_SelectFile = new System.Windows.Forms.Button();
            this.FileDialog = new System.Windows.Forms.OpenFileDialog();
            this.Btn_Analysis = new System.Windows.Forms.Button();
            this.cmb_tableList = new System.Windows.Forms.ComboBox();
            this.txt_FilePath = new System.Windows.Forms.TextBox();
            this.btn_outTemplte = new System.Windows.Forms.Button();
            this.saveFile = new System.Windows.Forms.SaveFileDialog();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Excle)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Grid_Excle);
            this.groupBox1.Location = new System.Drawing.Point(9, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(821, 231);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "文档内容";
            // 
            // Grid_Excle
            // 
            this.Grid_Excle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_Excle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Grid_Excle.Location = new System.Drawing.Point(3, 17);
            this.Grid_Excle.Name = "Grid_Excle";
            this.Grid_Excle.RowTemplate.Height = 23;
            this.Grid_Excle.Size = new System.Drawing.Size(815, 211);
            this.Grid_Excle.TabIndex = 0;
            // 
            // btn_SelectFile
            // 
            this.btn_SelectFile.Location = new System.Drawing.Point(365, 11);
            this.btn_SelectFile.Name = "btn_SelectFile";
            this.btn_SelectFile.Size = new System.Drawing.Size(75, 23);
            this.btn_SelectFile.TabIndex = 2;
            this.btn_SelectFile.Text = "选择文件";
            this.btn_SelectFile.UseVisualStyleBackColor = true;
            this.btn_SelectFile.Click += new System.EventHandler(this.btn_SelectFile_Click);
            // 
            // FileDialog
            // 
            this.FileDialog.FileName = "null";
            this.FileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.FileDialog_FileOk);
            // 
            // Btn_Analysis
            // 
            this.Btn_Analysis.Location = new System.Drawing.Point(655, 11);
            this.Btn_Analysis.Name = "Btn_Analysis";
            this.Btn_Analysis.Size = new System.Drawing.Size(91, 23);
            this.Btn_Analysis.TabIndex = 4;
            this.Btn_Analysis.Text = "解析并执行导入";
            this.Btn_Analysis.UseVisualStyleBackColor = true;
            this.Btn_Analysis.Click += new System.EventHandler(this.Btn_Analysis_Click);
            // 
            // cmb_tableList
            // 
            this.cmb_tableList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_tableList.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmb_tableList.FormattingEnabled = true;
            this.cmb_tableList.Location = new System.Drawing.Point(446, 12);
            this.cmb_tableList.Name = "cmb_tableList";
            this.cmb_tableList.Size = new System.Drawing.Size(203, 22);
            this.cmb_tableList.TabIndex = 5;
            // 
            // txt_FilePath
            // 
            this.txt_FilePath.Location = new System.Drawing.Point(12, 13);
            this.txt_FilePath.Name = "txt_FilePath";
            this.txt_FilePath.ReadOnly = true;
            this.txt_FilePath.Size = new System.Drawing.Size(347, 21);
            this.txt_FilePath.TabIndex = 1;
            // 
            // btn_outTemplte
            // 
            this.btn_outTemplte.Location = new System.Drawing.Point(752, 11);
            this.btn_outTemplte.Name = "btn_outTemplte";
            this.btn_outTemplte.Size = new System.Drawing.Size(75, 23);
            this.btn_outTemplte.TabIndex = 6;
            this.btn_outTemplte.Text = "导出模板";
            this.btn_outTemplte.UseVisualStyleBackColor = true;
            this.btn_outTemplte.Click += new System.EventHandler(this.btn_outTemplte_Click);
            // 
            // saveFile
            // 
            this.saveFile.Filter = "Excle|*.xls";
            this.saveFile.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFile_FileOk);
            // 
            // Form_Improt_Excel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 285);
            this.Controls.Add(this.btn_outTemplte);
            this.Controls.Add(this.cmb_tableList);
            this.Controls.Add(this.Btn_Analysis);
            this.Controls.Add(this.btn_SelectFile);
            this.Controls.Add(this.txt_FilePath);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Improt_Excel";
            this.Text = "Form_Improt_Excel";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Excle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_SelectFile;
        private System.Windows.Forms.DataGridView Grid_Excle;
        private System.Windows.Forms.OpenFileDialog FileDialog;
        private System.Windows.Forms.Button Btn_Analysis;
        private System.Windows.Forms.ComboBox cmb_tableList;
        private System.Windows.Forms.TextBox txt_FilePath;
        private System.Windows.Forms.Button btn_outTemplte;
        private System.Windows.Forms.SaveFileDialog saveFile;
    }
}