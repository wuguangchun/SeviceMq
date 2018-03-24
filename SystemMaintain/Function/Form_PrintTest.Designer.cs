namespace SystemMaintain.Function
{
    partial class Form_PrintTest
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
            this.btn_OutPrint = new System.Windows.Forms.Button();
            this.txt_PrintContent = new System.Windows.Forms.TextBox();
            this.pd1 = new System.Drawing.Printing.PrintDocument();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_OutPrint
            // 
            this.btn_OutPrint.Location = new System.Drawing.Point(722, 237);
            this.btn_OutPrint.Name = "btn_OutPrint";
            this.btn_OutPrint.Size = new System.Drawing.Size(105, 36);
            this.btn_OutPrint.TabIndex = 0;
            this.btn_OutPrint.Text = "输出打印";
            this.btn_OutPrint.UseVisualStyleBackColor = true;
            this.btn_OutPrint.Click += new System.EventHandler(this.btn_OutPrint_Click);
            // 
            // txt_PrintContent
            // 
            this.txt_PrintContent.Location = new System.Drawing.Point(12, 12);
            this.txt_PrintContent.Multiline = true;
            this.txt_PrintContent.Name = "txt_PrintContent";
            this.txt_PrintContent.Size = new System.Drawing.Size(704, 261);
            this.txt_PrintContent.TabIndex = 1;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(760, 37);
            this.maskedTextBox1.Mask = "000099";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(67, 21);
            this.maskedTextBox1.TabIndex = 2;
            this.maskedTextBox1.ValidatingType = typeof(int);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(722, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "号牌：";
            // 
            // Form_PrintTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 285);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.txt_PrintContent);
            this.Controls.Add(this.btn_OutPrint);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_PrintTest";
            this.Text = "Form_PrintTest";
            this.Load += new System.EventHandler(this.Form_PrintTest_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_OutPrint;
        private System.Windows.Forms.TextBox txt_PrintContent;
        private System.Drawing.Printing.PrintDocument pd1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label label1;
    }
}