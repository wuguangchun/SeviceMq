using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApsAdmin.EFModel.TempModels;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Kute.Helper;
using Model;
using Newtonsoft.Json;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using ServiceHandle.Helper;
using Spire.Xls;
using SubSonic;

namespace PlanInfoPlugs
{
    public class GeneratePdf
    {
        public string GeneratePdfMtm(string planCode)
        {
            var json = new JsonHelper();
            try
            {
                string planStr = string.Empty;
                PushWebHelper.PostToGet($"http://172.16.7.55/PlanOperate/MTMOrdersForPDF?sczsbh={planCode}", ref planStr, Encoding.UTF8);
                var data = (MtmPdf)JsonConvert.DeserializeObject(planStr, typeof(MtmPdf));

                string path = ($@"D:\excle\{planCode}.xls");

                #region 创建Excle文件

                //从数据库获取模板文件数据流
                var templtenew = new Select().From(TBasisExcelTemplate.Schema).Where(TBasisExcelTemplate.FileNameColumn).IsEqualTo("单体计划输出模板1")
                    .ExecuteTypedList<TBasisExcelTemplate>().First().FileContext;

                //将数据流转换成文件实例
                FileStream stream = new FileStream(path, FileMode.OpenOrCreate);
                stream.Write(templtenew, 0, templtenew.Length);
                stream.Flush();
                stream.Dispose();

                //读取文件
                stream = new FileStream(path, FileMode.OpenOrCreate);

                //创建Excel
                IWorkbook wk = new HSSFWorkbook(stream);
                ISheet sheet = wk.GetSheetAt(0);

                #endregion

                #region 设置页眉/页脚

                sheet.Header.Left = $"计划编号：{planCode.ToUpper()} 工厂名称：{data.sct26PDF.SCGCMC}"; 
                sheet.Header.Right = $"                             备注：{data.sct26PDF.SCZSBZ}";
                sheet.Footer.Center = $" 执行车间 :    计划员:{data.sct26PDF.SCJHRY}  制单日期:{DateTime.Now}  审核:{data.sct26PDF.SCSHRY}  审核日期：{data.sct26PDF.SCSHRQ.ToString()}";

                #endregion

                IRow row;
                ICell cell;
                #region 修改交期日期等信息


                row = sheet.GetRow(3);

                //投产日期
                cell = row.GetCell(0);
                cell.SetCellValue($"投产日期:{DateTime.Parse(data.sct26PDF.SCTCRQ.ToString()).ToString("yy-MM-dd HH:mm")}      " +
                                  $"裁剪交期:{DateTime.Parse(data.sct26PDF.SCCJJQ.ToString()).ToString("yy-MM-dd HH:mm")}      " +
                                  $"缝制日期:{DateTime.Parse(data.sct26PDF.SCFZJQ.ToString()).ToString("yy-MM-dd HH:mm")}      " +
                                  $"整烫交期:{DateTime.Parse(data.sct26PDF.SCZTJQ.ToString()).ToString("yy-MM-dd HH:mm")}      " +
                                  $"包装交期:{DateTime.Parse(data.sct26PDF.SCBZJQ.ToString()).ToString("yy-MM-dd HH:mm")}      " +
                                  $"成品交期:{DateTime.Parse(data.sct26PDF.SCBZJQ.ToString()).ToString("yy-MM-dd HH:mm")}      ");
                #endregion

                #region 填充数据表信息
                var i = 7;
                foreach (var mtmPdF in data.mtmPDFs)
                {
                    Console.WriteLine($"正在写入...（总共{data.mtmPDFs.Count}：已写入：{i}）");
                    if (i == 25 || (i - 25) % 24 == 0)
                    {
                        i += 3;
                        row = sheet.GetRow(i) ?? sheet.CreateRow(i);
                        for (int j = 0; j < 14; j++)
                        {
                            var cells = row.CreateCell(j);

                            ICellStyle style = wk.CreateCellStyle();
                            style.BorderBottom = BorderStyle.Thin;
                            style.BorderLeft = BorderStyle.Thin;
                            style.BorderRight = BorderStyle.Thin;
                            style.BorderTop = BorderStyle.Thin;

                            IFont font = wk.CreateFont();
                            font.FontHeightInPoints = 12;
                            font.FontName = "宋体";

                            style.SetFont(font);//HEAD 样式

                            cells.CellStyle = style;
                        }

                        #region 填充表头信息
                        //客户订单 
                        cell = row.GetCell(0);
                        cell.SetCellValue("客户订单");
                        //客户名 
                        cell = row.GetCell(1);
                        cell.SetCellValue("客户名");
                        //面料 
                        cell = row.GetCell(2);
                        cell.SetCellValue("面料");
                        //款式  
                        cell = row.GetCell(3);
                        cell.SetCellValue("款式");
                        //设计编号 
                        cell = row.GetCell(4);
                        cell.SetCellValue("设计编号");
                        //大类  
                        cell = row.GetCell(5);
                        cell.SetCellValue("大类");
                        //数量 
                        cell = row.GetCell(6);
                        cell.SetCellValue("数量");
                        //备注  
                        cell = row.GetCell(7);
                        cell.SetCellValue("备注");
                        //辅料 
                        cell = row.GetCell(8);
                        cell.SetCellValue("辅料");
                        //衬   
                        cell = row.GetCell(9);
                        cell.SetCellValue("衬");
                        //扣号 
                        cell = row.GetCell(10);
                        cell.SetCellValue("扣号");
                        //线号  
                        cell = row.GetCell(11);
                        cell.SetCellValue("线号");
                        //锁眼线 
                        cell = row.GetCell(12);
                        cell.SetCellValue("锁眼线");
                        //珠边线
                        cell = row.GetCell(13);
                        cell.SetCellValue("珠边线");
                        #endregion

                        row.Height = 24 * 20;
                        i++;
                        continue;
                    }

                    row = sheet.GetRow(i);
                    if (row == null)
                    {
                        row = sheet.CreateRow(i);
                    }

                    for (int j = 0; j < 14; j++)
                    {
                        var cells = row.CreateCell(j);

                        ICellStyle style = wk.CreateCellStyle();
                        style.BorderBottom = BorderStyle.Thin;
                        style.BorderLeft = BorderStyle.Thin;
                        style.BorderRight = BorderStyle.Thin;
                        style.BorderTop = BorderStyle.Thin;

                        IFont font = wk.CreateFont();
                        font.FontHeightInPoints = 10;
                        font.FontName = "宋体";
                        style.SetFont(font);//HEAD 样式 
                        cells.CellStyle = style;
                    }

                    row.Height = 24 * 20;

                    //客户订单 
                    cell = row.GetCell(0);
                    cell.SetCellValue(mtmPdF.SCYSPD);
                    //客户名 
                    cell = row.GetCell(1);
                    cell.SetCellValue(mtmPdF.SCKHXM);
                    //面料 
                    cell = row.GetCell(2);
                    cell.SetCellValue(mtmPdF.XTWPYS);
                    //款式  
                    cell = row.GetCell(3);
                    cell.SetCellValue(mtmPdF.XTWPKS);
                    //设计编号 
                    cell = row.GetCell(4);
                    cell.SetCellValue(mtmPdF.XTSJBH);
                    //大类  
                    cell = row.GetCell(5);
                    cell.SetCellValue(mtmPdF.WPSXMC);
                    //数量 
                    cell = row.GetCell(6);
                    cell.SetCellValue(mtmPdF.SCZSSL);
                    //备注  
                    cell = row.GetCell(7);
                    cell.SetCellValue(mtmPdF.SCJHDD);
                    //辅料 
                    cell = row.GetCell(8);
                    cell.SetCellValue(mtmPdF.FULIAO);
                    //衬   
                    cell = row.GetCell(9);
                    cell.SetCellValue(mtmPdF.CHENLX);
                    //扣号 
                    cell = row.GetCell(10);
                    cell.SetCellValue(mtmPdF.KOUHAO);
                    //线号  
                    cell = row.GetCell(11);
                    cell.SetCellValue(mtmPdF.XIANHAO);
                    //锁眼线 
                    cell = row.GetCell(12);
                    cell.SetCellValue(mtmPdF.SUOYX);
                    //珠边线
                    cell = row.GetCell(13);
                    cell.SetCellValue(mtmPdF.ZHUBX);
                    i++;
                }

                #endregion

                #region 需要读取文件流，暂存Excle文件到服务器

                FileStream fs2 = File.Create(path);
                wk.Write(fs2);
                fs2.Dispose();
                #endregion

                #region 读取文件得文件流存到数据库
                var pFileStream = new FileStream(path, FileMode.Open, FileAccess.Read);
                BinaryReader r = new BinaryReader(pFileStream);
                r.BaseStream.Seek(0, SeekOrigin.Begin);    //将文件指针设置到文件开
                var fileBytes = r.ReadBytes((int)r.BaseStream.Length);
                new TBasisExcelTemplate(planCode + "-MTM")
                {
                    FileName = planCode + "-MTM",
                    FileContext = fileBytes,
                    CreateTime = DateTime.Now,
                    FileType = "MTM"
                }.Save();
                pFileStream.Flush();
                pFileStream.Dispose();
                #endregion

                #region 操作成功后删除服务器临时文件
                //删除文件
                FileInfo file = new FileInfo(path);//指定文件路径
                if (file.Exists)//判断文件是否存在
                {
                    file.Attributes = FileAttributes.Normal;//将文件属性设置为普通,比方说只读文件设置为普通
                    file.Delete();//删除文件
                }
                #endregion

                json.RetCode = RetCode.Success;
                json.RetMessage = "生成成功，文件以存放到数据库！";
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                json.RetCode = RetCode.Error;
                json.RetMessage = e.Message;
            }
            return JsonConvert.SerializeObject(json);
        }

        public string GeneratePdfTz(string planCode)
        {
            var json = new JsonHelper();
            try
            {
                string planStr = string.Empty;
                PushWebHelper.PostToGet($"http://172.16.7.55/PlanOperate/TZOrdersForPDF?sczsbh={planCode}", ref planStr, Encoding.UTF8);
                var data = (TzPdf)JsonConvert.DeserializeObject(planStr, typeof(TzPdf));

                string path = ($@"D:\excle\{planCode}.xls");

                #region 创建Excle文件

                //从数据库获取模板文件数据流
                var templtenew = new Select().From(TBasisExcelTemplate.Schema).Where(TBasisExcelTemplate.FileNameColumn).IsEqualTo("团装计划输出模板")
                    .ExecuteTypedList<TBasisExcelTemplate>().First().FileContext;

                //将数据流转换成文件实例
                FileStream stream = new FileStream(path, FileMode.OpenOrCreate);
                stream.Write(templtenew, 0, templtenew.Length);
                stream.Flush();
                stream.Dispose();

                //读取文件
                stream = new FileStream(path, FileMode.OpenOrCreate);

                //创建Excel
                IWorkbook wk = new HSSFWorkbook(stream);
                ISheet sheet = wk.GetSheetAt(0);

                #endregion

                #region 设置页眉/页脚

                sheet.Header.Left = $"计划编号：{planCode.ToUpper()} 工厂名称：{data.sct26PDF.SCGCMC}";
                sheet.Header.Right = $"备注：{data.sct26PDF.SCZSBZ}";

                sheet.Footer.Center = $" 执行车间 :    计划员:{data.sct26PDF.SCJHRY}  制单日期:{DateTime.Now}  审核:{data.sct26PDF.SCSHRY}  审核日期：{data.sct26PDF.SCSHRQ.ToString()}";

                #endregion

                #region 修改交期日期等信息

                IRow row;
                ICell cell;

                row = sheet.GetRow(3);

                //投产日期
                cell = row.GetCell(1);
                cell.SetCellValue(DateTime.Parse(data.sct26PDF.SCTCRQ.ToString()).ToString("yy/MM/dd hh:mm"));

                //裁剪交期
                cell = row.GetCell(3);
                cell.SetCellValue(DateTime.Parse(data.sct26PDF.SCCJJQ.ToString()).ToString("yy/MM/dd hh:mm"));

                //缝制日期
                cell = row.GetCell(5);
                cell.SetCellValue(DateTime.Parse(data.sct26PDF.SCFZJQ.ToString()).ToString("yy/MM/dd hh:mm"));

                //整烫交期
                cell = row.GetCell(7);
                cell.SetCellValue(DateTime.Parse(data.sct26PDF.SCZTJQ.ToString()).ToString("yy/MM/dd hh:mm"));

                //包装交期
                cell = row.GetCell(9);
                cell.SetCellValue(DateTime.Parse(data.sct26PDF.SCBZJQ.ToString()).ToString("yy/MM/dd hh:mm"));

                //成品交期
                cell = row.GetCell(11);
                cell.SetCellValue(DateTime.Parse(data.sct26PDF.SCBZJQ.ToString()).ToString("yy/MM/dd hh:mm"));
                #endregion

                #region 订单主信息修改

                #region 第一行

                row = sheet.GetRow(6);

                //订单编号
                cell = row.GetCell(1);
                cell.SetCellValue(data.tzPDF.SCHTBH);

                //客户代码
                cell = row.GetCell(3);
                cell.SetCellValue(data.tzPDF.XTWLDM);

                //客户名称
                cell = row.GetCell(5);
                cell.SetCellValue(data.tzPDF.XTWLDM);

                //款式
                cell = row.GetCell(9);
                cell.SetCellValue(data.tzPDF.XTWPKS);

                #endregion

                #region 第二行

                row = sheet.GetRow(7);

                //原始凭单
                cell = row.GetCell(1);
                cell.SetCellValue(data.tzPDF.SCZSPH);

                //业务部门
                cell = row.GetCell(3);
                cell.SetCellValue(data.tzPDF.XTBMDM);

                //部门名称
                cell = row.GetCell(5);
                cell.SetCellValue(data.tzPDF.BMMC);

                //设计号
                cell = row.GetCell(9);
                cell.SetCellValue(data.tzPDF.XTSJBH);

                #endregion

                #region 第三行

                row = sheet.GetRow(8);
                //面料
                cell = row.GetCell(1);
                cell.SetCellValue(data.tzPDF.XTWPYS);

                //缝制线
                cell = row.GetCell(3);
                cell.SetCellValue(data.tzPDF.FZX);

                //纽扣
                cell = row.GetCell(5);
                cell.SetCellValue(data.tzPDF.NKX);

                //衬类型
                cell = row.GetCell(7);
                cell.SetCellValue(data.tzPDF.CLX);

                //数量
                cell = row.GetCell(9);
                cell.SetCellValue(data.tzPDF.Num);
                #endregion

                row = sheet.GetRow(9);
                //备注信息
                cell = row.GetCell(1);
                cell.SetCellValue(data.tzPDF.SCHTBZ);

                #endregion

                #region 需要读取文件流，暂存Excle文件到服务器

                FileStream fs2 = File.Create(path);
                wk.Write(fs2);
                fs2.Dispose();
                #endregion

                #region 生成PDF（需购买版权，停用）
                //Workbook workbook = new Workbook();
                //workbook.LoadFromFile(path, ExcelVersion.Version2010);
                //workbook.SaveToFile($@"Excel\{planCode}.pdf", Spire.Xls.FileFormat.PDF); 

                #endregion

                #region 读取文件得文件流存到数据库
                var pFileStream = new FileStream(path, FileMode.Open, FileAccess.Read);
                BinaryReader r = new BinaryReader(pFileStream);
                r.BaseStream.Seek(0, SeekOrigin.Begin);    //将文件指针设置到文件开
                var fileBytes = r.ReadBytes((int)r.BaseStream.Length);
                new TBasisExcelTemplate(planCode + "-TZ")
                {
                    FileName = planCode + "-TZ",
                    FileContext = fileBytes,
                    CreateTime = DateTime.Now,
                    FileType = "TZ"
                }.Save();
                pFileStream.Flush();
                pFileStream.Dispose();
                #endregion

                #region 操作成功后删除服务器临时文件
                //删除文件
                FileInfo file = new FileInfo(path);//指定文件路径
                if (file.Exists)//判断文件是否存在
                {
                    file.Attributes = FileAttributes.Normal;//将文件属性设置为普通,比方说只读文件设置为普通
                    file.Delete();//删除文件
                }
                #endregion

                json.RetCode = RetCode.Success;
                json.RetMessage = "生成成功，文件以存放到数据库！";
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                json.RetCode = RetCode.Error;
                json.RetMessage = e.Message;
            }
            return JsonConvert.SerializeObject(json);
        }
    }
}
