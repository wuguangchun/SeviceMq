using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemMaintain.UserControls
{
    public partial class SplitPage : UserControl
    {
        public SplitPage()
        {
            InitializeComponent();
        }

        private void SplitPage_Load(object sender, EventArgs e)
        {
            Height = 30;
        }
    }
}
