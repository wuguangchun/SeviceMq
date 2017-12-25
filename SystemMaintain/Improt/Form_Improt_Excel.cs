using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using SubSonic.Extensions;

namespace SystemMaintain.Improt
{
    public partial class Form_Improt_Excel : Form
    {

        List<Object> list = new List<object>();

        public Form_Improt_Excel()
        {
            InitializeComponent();
            badingCmb();
        }

        //选择文件
        private void btn_SelectFile_Click(object sender, EventArgs e)
        {
            try
            {
                FileDialog.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //成功选择文件
        private void FileDialog_FileOk(object sender, CancelEventArgs e)
        {
            try
            {
                var fileName = FileDialog.FileName;



                var extension = System.IO.Path.GetExtension(fileName);//获取文件后缀
                if (extension == (".xls") || extension == (".xlsx"))
                {
                    txt_FilePath.Text = fileName;
                }
                else
                {
                    MessageBox.Show(@"不支持该格式");
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        //执行导入
        private void Btn_Analysis_Click(object sender, EventArgs e)
        {
            try
            {
                IWorkbook wk = null;

                var extension = System.IO.Path.GetExtension(txt_FilePath.Text);//获取文件后缀
                using (FileStream fs = File.OpenRead(txt_FilePath.Text))
                {
                    if (extension == ".xls")
                    {
                        //把xls文件中的数据写入wk中
                        wk = new HSSFWorkbook(fs);
                    }
                    else
                    {
                        //把xlsx文件中的数据写入wk中
                        wk = new XSSFWorkbook(fs);
                    }

                    fs.Close();
                }


                //读取当前表数据
                ISheet sheet = wk.GetSheetAt(0);

                //行对象
                IRow row = sheet.GetRow(0);

                //Excle列名集合
                Dictionary<int, string> nameList = new Dictionary<int, string>();
                for (int i = 0; i < row.Cells.Count; i++)
                {
                    nameList.Add(i, row.GetCell(i).ToString());
                }

                //填充实体类属性集合
                Dictionary<string, object> dictionary = new Dictionary<string, object>();

                //遍历其他行
                for (int i = 1; i <= sheet.LastRowNum; i++)
                {
                    dictionary.Clear();
                    row = sheet.GetRow(i);  //读取当前行数据
                    if (row != null)
                    {
                        foreach (var names in nameList)
                        {
                            var key = row.GetCell(names.Key).ToString();
                            dictionary.Add(names.Value, string.IsNullOrEmpty(key) ? null : key);
                        }
                    }


                    UpdateData("Model." + cmb_tableList.SelectedValue.ToString(), "", dictionary);

                }

                Grid_Excle.DataSource = list;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //生成的实体类，绑定下拉框，
        private void badingCmb()
        {
            try
            {
                var shux = typeof(Tables).GetFields();
                List<string> list = new List<string>();
                foreach (var fieldInfo in shux)
                {
                    list.Add(fieldInfo.Name);
                }

                cmb_tableList.DataSource = list;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        /// <summary>
        /// 根据主键适配增加/更新
        /// </summary> 
        /// <param name="tableClassName">类的完全限定名</param>
        /// <param name="id">主键</param>
        /// <param name="dictionary">对象属性对应值,Key必须跟对象属性一致</param>
        /// <returns></returns>
        public bool UpdateData(string tableClassName, object id, Dictionary<string, object> dictionary)
        {
            try
            {

                //根据ID判断新增或修改 生成有参数或无参实例对象
                object obj;
                if (string.IsNullOrWhiteSpace(id.ToString()))
                {

                    obj = Assembly.Load("APS系统维护").CreateInstance(tableClassName, false); //类的完全限定名（即包括命名空间）
                }
                else
                {
                    object[] parameters = new object[1];
                    parameters[0] = id;

                    obj = Assembly.Load("APS系统维护").CreateInstance(tableClassName, true, System.Reflection.BindingFlags.Default, null, parameters, null, null);// 创建类的实例
                }

                //获取反射类所有方法
                var mi = obj.GetType().GetMethods();


                //筛选属性的SET方法
                var miSet = mi.ToList().FindAll(x => x.Name.ToLower().Contains("set"));
                var keys = dictionary.Keys.ToList();
                foreach (var key in keys)
                {
                    var setMethod = miSet.Find(x => x.Name.Replace("set_", "").ToLower() == key.ToLower());
                    if (setMethod != null)
                    {
                        //需要先看属性的返回类型，然后做转换
                        var method = setMethod.Name.Replace("set_", "get_");
                        var getMethod = mi.ToList().Find(x => x.Name.ToLower() == method.ToLower());

                        var typeName = getMethod.ReturnType.FullName;

                        var keyValue = ObjParse(typeName, dictionary[key]);

                        object[] parameter = { keyValue };
                        setMethod.Invoke(obj, parameter);
                    }
                    else
                    {
                        throw new Exception($"异常没找到与{key}对应的字段");
                    }
                }

                //添加到集合
                list.Add(obj);

                //筛选过滤执行Save方法
                foreach (var methodInfo in mi)
                {
                    //指定执行方法
                    if (methodInfo.Name.Equals("Save", StringComparison.Ordinal))
                    {
                        if (methodInfo.GetParameters().Length < 1)
                        {
                            methodInfo.Invoke(obj, null);
                            return true;
                        }
                    }
                }
                return false;
            }
            catch (Exception)
            {
                throw;
            }
        }

        //根据方法的返回值，转换对应的类型
        public object ObjParse(string type, object obj)
        {
            object o = null;
            try
            {
                obj = obj ?? "";

                if (type.ToLower().Contains("string"))
                {
                    o = obj.ToString();
                }
                else if (type.ToLower().Contains("int"))
                {
                    o = int.Parse(string.IsNullOrEmpty(obj.ToString()) ? "0" : obj.ToString());
                }
                else if (type.ToLower().Contains("datatime"))
                {
                    o = DateTime.Parse(string.IsNullOrEmpty(obj.ToString()) ? DateTime.Now.ToString() : obj.ToString());
                }
                else if (type.ToLower().Contains("double"))
                {
                    o = Double.Parse(string.IsNullOrEmpty(obj.ToString()) ? "0.0" : obj.ToString());
                }
                return o;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                throw;
            }

        }

        //根据下拉框选择的表，生成Excle 
        private void saveFile_FileOk(object sender, CancelEventArgs e)
        {
            var path = saveFile.FileName;

            try
            {
                //获取选择的表
                var tableClass = cmb_tableList.SelectedValue.ToString();

                 
                var obj1 = typeof(TTest).Assembly; 
                //反射生成类
                var obj = Assembly.Load("APS系统维护").CreateInstance("Model." + tableClass, false);

                //获取反射类所有方法
                var mi = obj.GetType().GetProperties().ToList();

                mi.RemoveAll(x => x.Name == "Schema" || x.Name == "ValidateWhenSaving" || x.Name == "IsLoaded" || x.Name == "IsDirty" || x.Name == "IsNew"
                                  || x.Name == "TableName" || x.Name == "ProviderName" || x.Name == "NullExceptionMessage" || x.Name == "InvalidTypeExceptionMessage"
                                  || x.Name == "LengthExceptionMessage" || x.Name == "Errors" || x.Name == "DirtyColumns" || x.Name.Contains("Column"));

                IWorkbook book = new HSSFWorkbook();
                var sheet = book.CreateSheet(tableClass);
                var row = sheet.CreateRow(0);
                for (int i = 0; i < mi.Count; i++)
                {
                    var cell=row.CreateCell(i);
                    cell.SetCellValue(mi[i].Name); ;
                }


                FileStream fs = File.OpenWrite(path);
                book.Write(fs);   //向打开的这个xls文件中写入表并保存。  
                fs.Close();


            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        //到处模板时，弹框选择保存位置
        private void btn_outTemplte_Click(object sender, EventArgs e)
        {
            saveFile.FileName = cmb_tableList.SelectedValue.ToString();
            saveFile.ShowDialog();
        }

    }
}
