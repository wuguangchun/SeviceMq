using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;

namespace SystemMaintain.Improt
{
    public partial class Form_Improt_Template : Form
    {
        private byte[] readContext;
        public Form_Improt_Template()
        {
            InitializeComponent();
        }

        private void btn_SelectFile_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
        }

        private void openFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            try
            {
                var fileName = openFileDialog.FileName;
                var extension = System.IO.Path.GetExtension(fileName);//获取文件后缀
                if (extension == (".xls") || extension == (".xlsx"))
                {

                    var pFileStream = new FileStream(fileName, FileMode.Open, FileAccess.Read);

                    BinaryReader r = new BinaryReader(pFileStream);
                    r.BaseStream.Seek(0, SeekOrigin.Begin);    //将文件指针设置到文件开
                    readContext = r.ReadBytes((int)r.BaseStream.Length);

                    txt_FileName.Text = openFileDialog.SafeFileName.Replace(".xlsx", "").Replace(".xls", "");
                    txt_bytes.Text = $"文件已读取成功\r\n文件地址：{fileName}\r\n文件字节数：{readContext.Length}";

                }
                else
                {
                    MessageBox.Show(@"滚犊子，不支持该格式。选择Excel文件");
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void btn_SaveBase_Click(object sender, EventArgs e)
        {
            var template = new TBasisExcelTemplate(txt_FileName.Text) { FileName = txt_FileName.Text, FileContext = readContext, CreateTime = DateTime.Now };
            template.Save();
        }
    }
}
