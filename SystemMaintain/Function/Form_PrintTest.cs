using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemMaintain.Function
{
    public partial class Form_PrintTest : Form
    {
        public Form_PrintTest()
        {
            InitializeComponent();
        }

        private void Form_PrintTest_Load(object sender, EventArgs e)
        {

        }

        private void btn_OutPrint_Click(object sender, EventArgs e)
        {
            pd1.DocumentName = "打印测试";
            pd1.Print(); 
        }
        
    }
}
