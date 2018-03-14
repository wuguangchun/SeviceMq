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
using NPOI.XSSF.Streaming;
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
                #region 创建PDF文件


                //Document docPDF = new Document(PageSize.A4, 0, 0, 0, 0);//创建一个pdf文档的对象，设置纸张大小为A4，页边距为0
                //PageSize.A4.Rotate(); //纸张设置为横向时，使用PageSize.A4.Rotate()
                //PdfWriter write = PdfWriter.GetInstance(docPDF, new FileStream(@"C:\Users\kute\Desktop\pdffile.pdf", FileMode.OpenOrCreate, FileAccess.Write));//创建一个写入PDF的对象， BaseFont bsFont = BaseFont.CreateFont(@"C:\Windows\Fonts\simsun.ttc,0", BaseFont.IDENTITY_H, BaseFont.EMBEDDED); Font font = new Font(bsFont);//在这里需要注意的是，itextsharp不支持中文字符，想要显示中文字符的话需要自己设置字体 docPDF.Open();//打开
                //write.Open();
                //docPDF.Open();
                //PdfPTable tablerow1 = new PdfPTable(new float[] { 20, 20, 20 });
                //for (int i = 0; i <= 27; i++)//表示创建一个3列9行的表格
                //{
                //    var cell1 = new PdfPCell(new Paragraph(i.ToString()));

                //    // tablerow1.AddCell(
                //    tablerow1.AddCell(cell1);//将单元格添加到表格中

                //}
                //docPDF.Add(tablerow1);//将表格添加到pdf文档中

                //PdfPTable tablerow2 = new PdfPTable(new float[] { 20, 20, 20 });
                //var cell = new PdfPCell(new Paragraph("表格跨行 row1 col1"));
                //tablerow2.AddCell(cell);
                //docPDF.Add(tablerow2);


                //write.Flush();
                //docPDF.Close();//关闭 

                #endregion

                string planStr = string.Empty;
                PushWebHelper.PostToGet($"http://172.16.7.55/PlanOperate/TZOrdersForPDF?sczsbh={planCode}", ref planStr, Encoding.UTF8);
                var data = (TzPdf)JsonConvert.DeserializeObject(planStr, typeof(TzPdf));

                string path = $@"C:\Users\kute\Desktop\{planCode}.xlsx";

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
                IWorkbook wk = new XSSFWorkbook(stream);
                ISheet sheet = wk.GetSheetAt(0);

                #endregion

                #region 修改计划编号信息 / 工厂名称
                IRow row = sheet.GetRow(2);
                ICell cell = row.GetCell(1);
                cell.SetCellValue(planCode.ToUpper());

                cell = row.GetCell(3);
                cell.SetCellValue(data.sct26PDF.SCGCMC);
                #endregion

                #region 修改交期日期等信息
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
                cell.SetCellValue(data.tzPDF.XTWLMC);

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

                #region 页尾信息

                row = sheet.GetRow(39);

                //计划备注
                cell = row.GetCell(1);
                cell.SetCellValue(data.sct26PDF.SCZSBZ);



                row = sheet.GetRow(42);

                //执行车间
                cell = row.GetCell(2);
                cell.SetCellValue("");

                //计划员
                cell = row.GetCell(4);
                cell.SetCellValue(data.sct26PDF.SCJHRY);

                //制单日期
                cell = row.GetCell(6);
                cell.SetCellValue(DateTime.Now);

                //审核
                cell = row.GetCell(8);
                cell.SetCellValue(data.sct26PDF.SCSHRY);

                //审核日期：
                cell = row.GetCell(10);
                cell.SetCellValue(data.sct26PDF.SCSHRQ.ToString());

                #endregion


                //保存Excel 
                FileStream fs2 = File.Create(path);
                wk.Write(fs2);
                fs2.Dispose();

                Workbook workbook = new Workbook();
                workbook.LoadFromFile(path, ExcelVersion.Version2010);
                workbook.SaveToFile($@"C:\Users\kute\Desktop\{planCode}.pdf", Spire.Xls.FileFormat.PDF);
                //System.Diagnostics.Process.Start($@"C:\Users\kute\Desktop\{planCode}.pdf");

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
