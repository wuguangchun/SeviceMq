using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using DataModels.ModelsOther;
using Kute.Helper;
using Model;
using Newtonsoft.Json;
using ServiceHandle.ModelsOther;
using SubSonic;

namespace IntelligentLogHelper
{
    public class IntelligentLog
    {
        public void LogParsing()
        {
            try
            {
                var query = new Select("top 2000 id").From<TLogService>()
                    .Where(TLogService.KhdhColumn).IsEqualTo("")
                    .And(TLogService.MessagePathColumn).In("Intercourse", "OrderGetMesHour", "PlanInfo", "AnalysisOrder", "CadOrder", "KillOrder", "BlankingData", "PlanInfo", "NewOrderData", "PutCadBL", "OrderGetMesHour", "KillOrder", "AnalysisOrder", "PlanInfo", "NewOrderData", "Completion", "CallBackMsg", "AnalysisOrder", "CaiJianOrder", "CreateScjhbz", "GenerateFile", "CreateScjhbz", "KillOrder", "KillOrder", "GenerateFile")
                    .And(TLogService.LableColumn).In("NewCustomer", "NewOrder", "NewPlan", "NewFlBom", "NewOrder", "MoveOld", "NewOrder", "NewSewPlan", "UpdateDelivery", "CADScheduling", "KeyProcess", "KillSingleERP", "NewOrderPld", "NewPlanMain", "BlPutData", "Completion", "Message", "NewOrder", "NewOrder", "SCJHBZ", "TZ", "NewOrder", "KillOrder", "KillSingle", "MTM");
                
                var logList = query.ExecuteTypedList<TLogService>();

               logList=new Select().From<TLogService>()
                    .Where(TLogService.IdColumn).In(logList.ConvertAll(x=>x.Id))
                    .ExecuteTypedList<TLogService>();

                int okRow = 0;
                foreach (var logService in logList.FindAll(x => 1 == 1))
                {

                    //BL主动推送的订单数据
                    if (logService.MessagePath == "NewOrderData" && logService.Lable == "BlPutData")
                    {
                        var obj = (List<BLData>)JsonConvert.DeserializeObject(logService.Context, typeof(List<BLData>));
                        okRow += UpdateLogs(logService.Id, obj?.First().order.Khdh) ? 1 : 0;
                    }
                    //新订单数据生成CAD排程数据/生成APS基础数据
                    else if ((logService.MessagePath == "CadOrder" || logService.MessagePath == "AnalysisOrder") && logService.Lable == "NewOrder")
                    {
                        var obj = (BLData)JsonConvert.DeserializeObject(logService.Context, typeof(BLData));
                        okRow += UpdateLogs(logService.Id, obj.order.Khdh) ? 1 : 0;
                    }
                    //CAD排程数据准备推送给BL
                    else if (logService.MessagePath == "PutCadBL" && logService.Lable == "SchedulingReady")
                    {
                        //无效，不需要解析，不包含所需要的关键索引
                    }
                    //CAD排程数据推送给BL
                    else if (logService.MessagePath == "PutCadBL" && logService.Lable == "CADScheduling")
                    {
                        var obj = (CadBlModelList)JsonConvert.DeserializeObject(logService.Context, typeof(CadBlModelList));
                        okRow += UpdateLogs(logService.Id, obj.ds?.First().customerId) ? 1 : 0;
                    }
                    //接受Bl推送得排料单
                    else if (logService.MessagePath == "AnalysisOrder" && logService.Lable == "NewOrderPld")
                    {
                        var obj = (Blpld)JsonConvert.DeserializeObject(logService.Context, typeof(Blpld));
                        okRow += UpdateLogs(logService.Id, obj.Khdh) ? 1 : 0;
                    }
                    //计划下达生成裁剪排程数据
                    else if (logService.MessagePath == "CaiJianOrder" && logService.Lable == "NewOrder")
                    {
                        okRow += UpdateLogs(logService.Id, logService.Context) ? 1 : 0;
                    }
                    //订单在各系统中流转的完工汇报
                    else if (logService.MessagePath == "Completion" && logService.Lable == "Completion")
                    {
                        var obj = (Completion)JsonConvert.DeserializeObject(logService.Context, typeof(Completion));
                        okRow += UpdateLogs(logService.Id, obj.CustmerId) ? 1 : 0;
                    }
                    //订单裁床定稿后生成Blank数据
                    else if (logService.MessagePath == "BlankingData" && logService.Lable == "NewOrder")
                    {
                        okRow += UpdateLogs(logService.Id, logService.Context) ? 1 : 0;
                    }
                    //回调接口的日志
                    else if (logService.MessagePath == "CallBackMsg" && logService.Lable == "Message")
                    {
                        //以处理信息得消息ID作为主键KHDH 
                        var json = (JsonHelper)JsonConvert.DeserializeObject(logService.Context, typeof(JsonHelper));
                        okRow += UpdateLogs(logService.Id, json.RetObj.ToString()) ? 1 : 0;
                    }
                    //撤单
                    else if (logService.MessagePath == "KillOrder" && (logService.Lable == "KillOrder"|| logService.Lable == "MoveOld"))
                    {
                        okRow += UpdateLogs(logService.Id, logService.Context) ? 1 : 0;
                    }
                    else if (logService.MessagePath == "KillOrder" && logService.Lable == "KillSingle")
                    {
                        var killOrder = (OrderKill)JsonConvert.DeserializeObject(logService.Context, typeof(OrderKill));
                        okRow += UpdateLogs(logService.Id, killOrder.CustmerId) ? 1 : 0;
                    }
                    else if (logService.MessagePath == "KillOrder" && logService.Lable == "KillSingleERP")
                    {
                        var killOrder = (OrderKill)JsonConvert.DeserializeObject(logService.Context, typeof(OrderKill));
                        okRow += UpdateLogs(logService.Id, killOrder.CustmerId) ? 1 : 0;
                    }
                    //增加日志
                    else if (logService.MessagePath == "LogService" && logService.Lable == "AddLog")
                    {
                        //无效，不需要解析，不包含所需要的关键索引
                    }
                    //增加异常/错误日志
                    else if (logService.MessagePath == "LogService" && logService.Lable == "AddErrLog")
                    {
                        //无效，不需要解析，不包含所需要的关键索引
                    }
                    //获取MES工时日志
                    else if (logService.MessagePath == "OrderGetMesHour" && logService.Lable == "NewOrder")
                    {
                        okRow += UpdateLogs(logService.Id, logService.Context) ? 1 : 0;
                    }
                    //计算关键工序时间日志
                    else if (logService.MessagePath == "OrderGetMesHour" && logService.Lable == "KeyProcess")
                    {
                        okRow += UpdateLogs(logService.Id, new TBLDataOrdermx(TBLDataOrdermx.MxidColumn.ColumnName, logService.Context).Khdh) ? 1 : 0;
                    }
                    //从ERP获取计划数据 --根据裁剪完工汇报 计算是否排缝制
                    else if (logService.MessagePath == "PlanInfo" && (logService.Lable == "NewPlan" || logService.Lable == "NewPlanMain" || logService.Lable == "NewSewPlan"))
                    {
                        okRow += UpdateLogs(logService.Id, logService.Context) ? 1 : 0;
                    }
                    //等待获取面辅料外观匹配
                    else if (logService.MessagePath == "CreateScjhbz" && logService.Lable == "NewOrder")
                    {
                        okRow += UpdateLogs(logService.Id, logService.Context) ? 1 : 0;
                    }
                    //往来户数据
                    else if (logService.MessagePath == "Intercourse" && logService.Lable == "NewCustomer")
                    {
                        var intercourse = (TBasisIntercourse)JsonConvert.DeserializeObject(logService.Context, typeof(TBasisIntercourse));
                        okRow += UpdateLogs(logService.Id, intercourse.Xtwldm) ? 1 : 0;
                    }
                    //计划Excle文件生成队列
                    else if (logService.MessagePath == "GenerateFile" && (logService.Lable == "TZ" || logService.Lable == "MTM"))
                    {
                        okRow += UpdateLogs(logService.Id, logService.Context) ? 1 : 0;
                    }
                    //修改订单交期
                    else if (logService.MessagePath == "NewOrderData" && logService.Lable == "UpdateDelivery")
                    {

                        var delivery = (Delivery)JsonConvert.DeserializeObject(logService.Context, typeof(Delivery));
                        okRow += UpdateLogs(logService.Id, delivery.Khdh) ? 1 : 0;
                    }//接受新辅料BOM信息
                    else if (logService.MessagePath == "AnalysisOrder" && logService.Lable == "NewFlBom")
                    {
                        var bomList = (List<FlBom>)JsonConvert.DeserializeObject(logService.Context, typeof(List<FlBom>));
                        okRow += UpdateLogs(logService.Id, bomList.First().Khdh) ? 1 : 0;
                    }


                    //执行后删除日志信息
                    logList.Remove(logService);

                }
            }
            catch (Exception e)
            {
                throw;
            }
        }
        private bool UpdateLogs(int logId, string khdh)
        {
            try
            {
                var row = new Update(TLogService.Schema)
                    .Set(TLogService.KhdhColumn).EqualTo(khdh)
                    .Where(TLogService.IdColumn).IsEqualTo(logId).Execute();

                return row > 0;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public string MoveOld(string khdh)
        {
            var result = new JsonHelper();
            try
            {
                //查询原始数据
                var logList = new Select().From<TLogService>().Where(TLogService.KhdhColumn).IsEqualTo(khdh).ExecuteTypedList<TLogService>();

                //移动到历史表
                foreach (var log in logList)
                {
                    new TLogServiceOld
                    {

                        Id = log.Id,
                        Khdh = log.Khdh,
                        Lable = log.Lable,
                        MessagePath = log.MessagePath,
                        CallBackUrl = log.CallBackUrl,
                        CreateTime = log.CreateTime,
                        Context = log.Context,
                        MessageID = log.MessageID

                    }.Save();
                }

                //删掉历史数据
                new Delete().From<TLogService>().Where(TLogService.KhdhColumn).IsEqualTo(khdh).Execute();


                result.RetCode = RetCode.Success;
                result.RetMessage = "移动成功";
            }
            catch (Exception e)
            {
                result.RetCode = RetCode.Error;
                result.RetMessage = e.Message;
            }
            return JsonConvert.SerializeObject(result);
        }
    }
}
