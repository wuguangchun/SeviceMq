using System; 
using System.Text; 
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration; 
using System.Xml; 
using System.Xml.Serialization;
using SubSonic; 
using SubSonic.Utilities;
// <auto-generated />
namespace Model
{
	#region Tables Struct
	public partial struct Tables
	{
		
		public static readonly string BCutterSet = @"B_CutterSet";
        
		public static readonly string BISOFileSet = @"B_ISOFileSet";
        
		public static readonly string BWorkTimeSet = @"B_WorkTimeSet";
        
		public static readonly string BWorkTimeSetCopy = @"B_WorkTimeSetCopy";
        
		public static readonly string BPMOrder = @"BPMOrders";
        
		public static readonly string Dictionary = @"Dictionaries";
        
		public static readonly string Factory = @"Factory";
        
		public static readonly string FactoryOrderTran = @"FactoryOrderTrans";
        
		public static readonly string HljtExecuteProc = @"HLJT_ExecuteProc";
        
		public static readonly string HljtTaskList = @"HLJT_TaskList";
        
		public static readonly string Isypb = @"ISYPB";
        
		public static readonly string OrderTest = @"OrderTest";
        
		public static readonly string ProcessedOrder = @"ProcessedOrder";
        
		public static readonly string SCM06 = @"SCM06";
        
		public static readonly string SCM13 = @"SCM13";
        
		public static readonly string SCT02 = @"SCT02";
        
		public static readonly string SCT12 = @"SCT12";
        
		public static readonly string SCT26 = @"SCT26";
        
		public static readonly string SCT262 = @"SCT262";
        
		public static readonly string SCT27 = @"SCT27";
        
		public static readonly string SCT271 = @"SCT271";
        
		public static readonly string SCT272 = @"SCT272";
        
		public static readonly string SCT28 = @"SCT28";
        
		public static readonly string SCT282 = @"SCT282";
        
		public static readonly string SCT31 = @"SCT31";
        
		public static readonly string SCT32 = @"SCT32";
        
		public static readonly string SCT33 = @"SCT33";
        
		public static readonly string SCT51 = @"SCT51";
        
		public static readonly string SCT52 = @"SCT52";
        
		public static readonly string SCT55 = @"SCT55";
        
		public static readonly string SCT56 = @"SCT56";
        
		public static readonly string TAnalysisCyMTMJh = @"T_Analysis_CyMTMJh";
        
		public static readonly string TAnalysisCyTZJh = @"T_Analysis_CyTZJh";
        
		public static readonly string TAnalysisDelivery = @"T_Analysis_Delivery";
        
		public static readonly string TAnalysisErpList = @"T_Analysis_ErpList";
        
		public static readonly string TAnalysisErpOrderList = @"T_Analysis_ErpOrderList";
        
		public static readonly string TAnalysisMTMXFJh = @"T_Analysis_MTMXFJh";
        
		public static readonly string TAnalysisOrderList = @"T_Analysis_OrderList";
        
		public static readonly string TAnalysisOrderList1706 = @"T_Analysis_OrderList@1706";
        
		public static readonly string TAnalysisOrderListByCF = @"T_Analysis_OrderListByCF";
        
		public static readonly string TAnalysisOrderListByDH = @"T_Analysis_OrderListByDH";
        
		public static readonly string TAnalysisOutputList = @"T_Analysis_OutputList";
        
		public static readonly string TAnalysisOutPutListByCF = @"T_Analysis_OutPutListByCF";
        
		public static readonly string TAnalysisOutPutListByFZ = @"T_Analysis_OutPutListByFZ";
        
		public static readonly string TAnalysisOutputListTzWithCode = @"T_Analysis_OutputListTzWithCode";
        
		public static readonly string TAnalysisOutputListWithCode = @"T_Analysis_OutputListWithCode";
        
		public static readonly string TAnalysisOutputListWithCodeCopy = @"T_Analysis_OutputListWithCode_copy";
        
		public static readonly string TAnalysisOutputListWithCodeCopyTest = @"T_Analysis_OutputListWithCode_copyTest";
        
		public static readonly string TAnalysisOutputListWithCodeShirt = @"T_Analysis_OutputListWithCode_Shirt";
        
		public static readonly string TAnalysisOutputListWithCodeTZShirt = @"T_Analysis_OutputListWithCode_TZShirt";
        
		public static readonly string TAnalysisOutputListWithCodeL = @"T_Analysis_OutputListWithCodeLS";
        
		public static readonly string TApsClientLog = @"T_ApsClientLog";
        
		public static readonly string TApsClientLog1706 = @"T_ApsClientLog@1706";
        
		public static readonly string TApsClientLog1712 = @"T_ApsClientLog@1712";
        
		public static readonly string TAPSCount = @"T_APSCount";
        
		public static readonly string TAttendance = @"T_Attendance";
        
		public static readonly string TAttendanceMode = @"T_AttendanceMode";
        
		public static readonly string TBackupsMtmJH = @"T_backups_MtmJH";
        
		public static readonly string TBasisBodyList = @"T_Basis_BodyList";
        
		public static readonly string TBasisCoatList = @"T_Basis_CoatList";
        
		public static readonly string TBasisCoatType = @"T_Basis_CoatType";
        
		public static readonly string TBasisGetDataSet = @"T_Basis_GetDataSet";
        
		public static readonly string TBasisLinerType = @"T_Basis_LinerType";
        
		public static readonly string TBasisOrderStatus = @"T_Basis_OrderStatus";
        
		public static readonly string TBasisResource = @"T_Basis_resource";
        
		public static readonly string TBasisSewingProcess = @"T_Basis_SewingProcess";
        
		public static readonly string TBasisSpecialList = @"T_Basis_SpecialList";
        
		public static readonly string TBasisSystemInfo = @"T_Basis_SystemInfo";
        
		public static readonly string TBasisTechnique = @"T_Basis_Technique";
        
		public static readonly string TBlankingDetaile = @"T_BlankingDetailes";
        
		public static readonly string TBLCADTemp = @"T_BLCADTemp";
        
		public static readonly string TBLCADTempCopy = @"T_BLCADTemp_copy";
        
		public static readonly string TBlcadtempbca = @"T_BLCADTEMPBCA";
        
		public static readonly string TBLCADTempHistory = @"T_BLCADTempHistory";
        
		public static readonly string TBLDataMflxx = @"T_BLData_Mflxx";
        
		public static readonly string TBLDataOrder = @"T_BLData_Order";
        
		public static readonly string TBLDataOrdermx = @"T_BLData_Ordermx";
        
		public static readonly string TBom = @"T_BOM";
        
		public static readonly string TCategoryProcessFlow = @"T_CategoryProcessFlow";
        
		public static readonly string TCutterAP = @"T_CutterAPS";
        
		public static readonly string TCutterME = @"T_CutterMES";
        
		public static readonly string TErpOrder = @"T_ERP_Order";
        
		public static readonly string TERPDataOrder = @"T_ERPData_Order";
        
		public static readonly string TErrorLog = @"T_ErrorLog";
        
		public static readonly string TFZfirstOrder = @"T_FZfirstOrder";
        
		public static readonly string TFZfirstOut = @"T_FZfirstOut";
        
		public static readonly string TFZOver = @"T_FZOver";
        
		public static readonly string TFZsecondOrder = @"T_FZsecondOrder";
        
		public static readonly string TFZsecondOut = @"T_FZsecondOut";
        
		public static readonly string TFzthirdOrder = @"T_fzthirdOrder";
        
		public static readonly string TGetUrl = @"T_getUrl";
        
		public static readonly string TLog = @"T_Log";
        
		public static readonly string TLogError = @"T_Log_Error";
        
		public static readonly string TLogService = @"T_Log_Service";
        
		public static readonly string TMessage = @"T_Message";
        
		public static readonly string TMflSearch = @"T_Mfl_search";
        
		public static readonly string TMLCodeList = @"T_MLCodeList";
        
		public static readonly string TOldApsByCf = @"T_OldApsByCf";
        
		public static readonly string TOldApsByCf1706 = @"T_OldApsByCf@1706";
        
		public static readonly string TOldApsByCf1712 = @"T_OldApsByCf@1712";
        
		public static readonly string TOperationLog = @"T_Operation_Log";
        
		public static readonly string TOrderProcessHour = @"T_OrderProcessHour";
        
		public static readonly string TPlanM = @"T_PlanM";
        
		public static readonly string TPlanMAdd = @"T_PlanM_Add";
        
		public static readonly string TPlan = @"T_PlanS";
        
		public static readonly string TPlanSAdd = @"T_PlanS_Add";
        
		public static readonly string TPushBlOutputList = @"T_PushBlOutputList";
        
		public static readonly string TResultMsg = @"T_ResultMsg";
        
		public static readonly string TSendLog = @"T_sendLog";
        
		public static readonly string TSql = @"T_SQL";
        
		public static readonly string TTemp = @"T_Temp";
        
		public static readonly string TTempInfo = @"T_TempInfo";
        
		public static readonly string TTempME = @"T_TempMES";
        
		public static readonly string TTsgy = @"T_TSGY";
        
		public static readonly string TTzwf = @"T_TZWF";
        
		public static readonly string TUsersGroup = @"T_UsersGroup";
        
		public static readonly string TUsersInfo = @"T_UsersInfo";
        
		public static readonly string TUsersPage = @"T_UsersPages";
        
		public static readonly string TWorkTime = @"T_WorkTime";
        
		public static readonly string TWorkTimeShirt = @"T_WorkTimeShirt";
        
		public static readonly string WmsSyncCutterAP = @"WMS_SYNC_CutterAPS";
        
		public static readonly string WmsSyncPlanm = @"WMS_SYNC_planm";
        
		public static readonly string WmsSyncPlan = @"WMS_SYNC_plans";
        
		public static readonly string XTM12 = @"XTM12";
        
		public static readonly string XTM124 = @"XTM124";
        
		public static readonly string XTM14 = @"XTM14";
        
		public static readonly string XTM22 = @"XTM22";
        
		public static readonly string XTM32 = @"XTM32";
        
	}
	#endregion
    #region Schemas
    public partial class Schemas {
		
		public static TableSchema.Table BCutterSet
		{
            get { return DataService.GetSchema("B_CutterSet", "Nowthwin"); }
		}
        
		public static TableSchema.Table BISOFileSet
		{
            get { return DataService.GetSchema("B_ISOFileSet", "Nowthwin"); }
		}
        
		public static TableSchema.Table BWorkTimeSet
		{
            get { return DataService.GetSchema("B_WorkTimeSet", "Nowthwin"); }
		}
        
		public static TableSchema.Table BWorkTimeSetCopy
		{
            get { return DataService.GetSchema("B_WorkTimeSetCopy", "Nowthwin"); }
		}
        
		public static TableSchema.Table BPMOrder
		{
            get { return DataService.GetSchema("BPMOrders", "Nowthwin"); }
		}
        
		public static TableSchema.Table Dictionary
		{
            get { return DataService.GetSchema("Dictionaries", "Nowthwin"); }
		}
        
		public static TableSchema.Table Factory
		{
            get { return DataService.GetSchema("Factory", "Nowthwin"); }
		}
        
		public static TableSchema.Table FactoryOrderTran
		{
            get { return DataService.GetSchema("FactoryOrderTrans", "Nowthwin"); }
		}
        
		public static TableSchema.Table HljtExecuteProc
		{
            get { return DataService.GetSchema("HLJT_ExecuteProc", "Nowthwin"); }
		}
        
		public static TableSchema.Table HljtTaskList
		{
            get { return DataService.GetSchema("HLJT_TaskList", "Nowthwin"); }
		}
        
		public static TableSchema.Table Isypb
		{
            get { return DataService.GetSchema("ISYPB", "Nowthwin"); }
		}
        
		public static TableSchema.Table OrderTest
		{
            get { return DataService.GetSchema("OrderTest", "Nowthwin"); }
		}
        
		public static TableSchema.Table ProcessedOrder
		{
            get { return DataService.GetSchema("ProcessedOrder", "Nowthwin"); }
		}
        
		public static TableSchema.Table SCM06
		{
            get { return DataService.GetSchema("SCM06", "Nowthwin"); }
		}
        
		public static TableSchema.Table SCM13
		{
            get { return DataService.GetSchema("SCM13", "Nowthwin"); }
		}
        
		public static TableSchema.Table SCT02
		{
            get { return DataService.GetSchema("SCT02", "Nowthwin"); }
		}
        
		public static TableSchema.Table SCT12
		{
            get { return DataService.GetSchema("SCT12", "Nowthwin"); }
		}
        
		public static TableSchema.Table SCT26
		{
            get { return DataService.GetSchema("SCT26", "Nowthwin"); }
		}
        
		public static TableSchema.Table SCT262
		{
            get { return DataService.GetSchema("SCT262", "Nowthwin"); }
		}
        
		public static TableSchema.Table SCT27
		{
            get { return DataService.GetSchema("SCT27", "Nowthwin"); }
		}
        
		public static TableSchema.Table SCT271
		{
            get { return DataService.GetSchema("SCT271", "Nowthwin"); }
		}
        
		public static TableSchema.Table SCT272
		{
            get { return DataService.GetSchema("SCT272", "Nowthwin"); }
		}
        
		public static TableSchema.Table SCT28
		{
            get { return DataService.GetSchema("SCT28", "Nowthwin"); }
		}
        
		public static TableSchema.Table SCT282
		{
            get { return DataService.GetSchema("SCT282", "Nowthwin"); }
		}
        
		public static TableSchema.Table SCT31
		{
            get { return DataService.GetSchema("SCT31", "Nowthwin"); }
		}
        
		public static TableSchema.Table SCT32
		{
            get { return DataService.GetSchema("SCT32", "Nowthwin"); }
		}
        
		public static TableSchema.Table SCT33
		{
            get { return DataService.GetSchema("SCT33", "Nowthwin"); }
		}
        
		public static TableSchema.Table SCT51
		{
            get { return DataService.GetSchema("SCT51", "Nowthwin"); }
		}
        
		public static TableSchema.Table SCT52
		{
            get { return DataService.GetSchema("SCT52", "Nowthwin"); }
		}
        
		public static TableSchema.Table SCT55
		{
            get { return DataService.GetSchema("SCT55", "Nowthwin"); }
		}
        
		public static TableSchema.Table SCT56
		{
            get { return DataService.GetSchema("SCT56", "Nowthwin"); }
		}
        
		public static TableSchema.Table TAnalysisCyMTMJh
		{
            get { return DataService.GetSchema("T_Analysis_CyMTMJh", "Nowthwin"); }
		}
        
		public static TableSchema.Table TAnalysisCyTZJh
		{
            get { return DataService.GetSchema("T_Analysis_CyTZJh", "Nowthwin"); }
		}
        
		public static TableSchema.Table TAnalysisDelivery
		{
            get { return DataService.GetSchema("T_Analysis_Delivery", "Nowthwin"); }
		}
        
		public static TableSchema.Table TAnalysisErpList
		{
            get { return DataService.GetSchema("T_Analysis_ErpList", "Nowthwin"); }
		}
        
		public static TableSchema.Table TAnalysisErpOrderList
		{
            get { return DataService.GetSchema("T_Analysis_ErpOrderList", "Nowthwin"); }
		}
        
		public static TableSchema.Table TAnalysisMTMXFJh
		{
            get { return DataService.GetSchema("T_Analysis_MTMXFJh", "Nowthwin"); }
		}
        
		public static TableSchema.Table TAnalysisOrderList
		{
            get { return DataService.GetSchema("T_Analysis_OrderList", "Nowthwin"); }
		}
        
		public static TableSchema.Table TAnalysisOrderList1706
		{
            get { return DataService.GetSchema("T_Analysis_OrderList@1706", "Nowthwin"); }
		}
        
		public static TableSchema.Table TAnalysisOrderListByCF
		{
            get { return DataService.GetSchema("T_Analysis_OrderListByCF", "Nowthwin"); }
		}
        
		public static TableSchema.Table TAnalysisOrderListByDH
		{
            get { return DataService.GetSchema("T_Analysis_OrderListByDH", "Nowthwin"); }
		}
        
		public static TableSchema.Table TAnalysisOutputList
		{
            get { return DataService.GetSchema("T_Analysis_OutputList", "Nowthwin"); }
		}
        
		public static TableSchema.Table TAnalysisOutPutListByCF
		{
            get { return DataService.GetSchema("T_Analysis_OutPutListByCF", "Nowthwin"); }
		}
        
		public static TableSchema.Table TAnalysisOutPutListByFZ
		{
            get { return DataService.GetSchema("T_Analysis_OutPutListByFZ", "Nowthwin"); }
		}
        
		public static TableSchema.Table TAnalysisOutputListTzWithCode
		{
            get { return DataService.GetSchema("T_Analysis_OutputListTzWithCode", "Nowthwin"); }
		}
        
		public static TableSchema.Table TAnalysisOutputListWithCode
		{
            get { return DataService.GetSchema("T_Analysis_OutputListWithCode", "Nowthwin"); }
		}
        
		public static TableSchema.Table TAnalysisOutputListWithCodeCopy
		{
            get { return DataService.GetSchema("T_Analysis_OutputListWithCode_copy", "Nowthwin"); }
		}
        
		public static TableSchema.Table TAnalysisOutputListWithCodeCopyTest
		{
            get { return DataService.GetSchema("T_Analysis_OutputListWithCode_copyTest", "Nowthwin"); }
		}
        
		public static TableSchema.Table TAnalysisOutputListWithCodeShirt
		{
            get { return DataService.GetSchema("T_Analysis_OutputListWithCode_Shirt", "Nowthwin"); }
		}
        
		public static TableSchema.Table TAnalysisOutputListWithCodeTZShirt
		{
            get { return DataService.GetSchema("T_Analysis_OutputListWithCode_TZShirt", "Nowthwin"); }
		}
        
		public static TableSchema.Table TAnalysisOutputListWithCodeL
		{
            get { return DataService.GetSchema("T_Analysis_OutputListWithCodeLS", "Nowthwin"); }
		}
        
		public static TableSchema.Table TApsClientLog
		{
            get { return DataService.GetSchema("T_ApsClientLog", "Nowthwin"); }
		}
        
		public static TableSchema.Table TApsClientLog1706
		{
            get { return DataService.GetSchema("T_ApsClientLog@1706", "Nowthwin"); }
		}
        
		public static TableSchema.Table TApsClientLog1712
		{
            get { return DataService.GetSchema("T_ApsClientLog@1712", "Nowthwin"); }
		}
        
		public static TableSchema.Table TAPSCount
		{
            get { return DataService.GetSchema("T_APSCount", "Nowthwin"); }
		}
        
		public static TableSchema.Table TAttendance
		{
            get { return DataService.GetSchema("T_Attendance", "Nowthwin"); }
		}
        
		public static TableSchema.Table TAttendanceMode
		{
            get { return DataService.GetSchema("T_AttendanceMode", "Nowthwin"); }
		}
        
		public static TableSchema.Table TBackupsMtmJH
		{
            get { return DataService.GetSchema("T_backups_MtmJH", "Nowthwin"); }
		}
        
		public static TableSchema.Table TBasisBodyList
		{
            get { return DataService.GetSchema("T_Basis_BodyList", "Nowthwin"); }
		}
        
		public static TableSchema.Table TBasisCoatList
		{
            get { return DataService.GetSchema("T_Basis_CoatList", "Nowthwin"); }
		}
        
		public static TableSchema.Table TBasisCoatType
		{
            get { return DataService.GetSchema("T_Basis_CoatType", "Nowthwin"); }
		}
        
		public static TableSchema.Table TBasisGetDataSet
		{
            get { return DataService.GetSchema("T_Basis_GetDataSet", "Nowthwin"); }
		}
        
		public static TableSchema.Table TBasisLinerType
		{
            get { return DataService.GetSchema("T_Basis_LinerType", "Nowthwin"); }
		}
        
		public static TableSchema.Table TBasisOrderStatus
		{
            get { return DataService.GetSchema("T_Basis_OrderStatus", "Nowthwin"); }
		}
        
		public static TableSchema.Table TBasisResource
		{
            get { return DataService.GetSchema("T_Basis_resource", "Nowthwin"); }
		}
        
		public static TableSchema.Table TBasisSewingProcess
		{
            get { return DataService.GetSchema("T_Basis_SewingProcess", "Nowthwin"); }
		}
        
		public static TableSchema.Table TBasisSpecialList
		{
            get { return DataService.GetSchema("T_Basis_SpecialList", "Nowthwin"); }
		}
        
		public static TableSchema.Table TBasisSystemInfo
		{
            get { return DataService.GetSchema("T_Basis_SystemInfo", "Nowthwin"); }
		}
        
		public static TableSchema.Table TBasisTechnique
		{
            get { return DataService.GetSchema("T_Basis_Technique", "Nowthwin"); }
		}
        
		public static TableSchema.Table TBlankingDetaile
		{
            get { return DataService.GetSchema("T_BlankingDetailes", "Nowthwin"); }
		}
        
		public static TableSchema.Table TBLCADTemp
		{
            get { return DataService.GetSchema("T_BLCADTemp", "Nowthwin"); }
		}
        
		public static TableSchema.Table TBLCADTempCopy
		{
            get { return DataService.GetSchema("T_BLCADTemp_copy", "Nowthwin"); }
		}
        
		public static TableSchema.Table TBlcadtempbca
		{
            get { return DataService.GetSchema("T_BLCADTEMPBCA", "Nowthwin"); }
		}
        
		public static TableSchema.Table TBLCADTempHistory
		{
            get { return DataService.GetSchema("T_BLCADTempHistory", "Nowthwin"); }
		}
        
		public static TableSchema.Table TBLDataMflxx
		{
            get { return DataService.GetSchema("T_BLData_Mflxx", "Nowthwin"); }
		}
        
		public static TableSchema.Table TBLDataOrder
		{
            get { return DataService.GetSchema("T_BLData_Order", "Nowthwin"); }
		}
        
		public static TableSchema.Table TBLDataOrdermx
		{
            get { return DataService.GetSchema("T_BLData_Ordermx", "Nowthwin"); }
		}
        
		public static TableSchema.Table TBom
		{
            get { return DataService.GetSchema("T_BOM", "Nowthwin"); }
		}
        
		public static TableSchema.Table TCategoryProcessFlow
		{
            get { return DataService.GetSchema("T_CategoryProcessFlow", "Nowthwin"); }
		}
        
		public static TableSchema.Table TCutterAP
		{
            get { return DataService.GetSchema("T_CutterAPS", "Nowthwin"); }
		}
        
		public static TableSchema.Table TCutterME
		{
            get { return DataService.GetSchema("T_CutterMES", "Nowthwin"); }
		}
        
		public static TableSchema.Table TErpOrder
		{
            get { return DataService.GetSchema("T_ERP_Order", "Nowthwin"); }
		}
        
		public static TableSchema.Table TERPDataOrder
		{
            get { return DataService.GetSchema("T_ERPData_Order", "Nowthwin"); }
		}
        
		public static TableSchema.Table TErrorLog
		{
            get { return DataService.GetSchema("T_ErrorLog", "Nowthwin"); }
		}
        
		public static TableSchema.Table TFZfirstOrder
		{
            get { return DataService.GetSchema("T_FZfirstOrder", "Nowthwin"); }
		}
        
		public static TableSchema.Table TFZfirstOut
		{
            get { return DataService.GetSchema("T_FZfirstOut", "Nowthwin"); }
		}
        
		public static TableSchema.Table TFZOver
		{
            get { return DataService.GetSchema("T_FZOver", "Nowthwin"); }
		}
        
		public static TableSchema.Table TFZsecondOrder
		{
            get { return DataService.GetSchema("T_FZsecondOrder", "Nowthwin"); }
		}
        
		public static TableSchema.Table TFZsecondOut
		{
            get { return DataService.GetSchema("T_FZsecondOut", "Nowthwin"); }
		}
        
		public static TableSchema.Table TFzthirdOrder
		{
            get { return DataService.GetSchema("T_fzthirdOrder", "Nowthwin"); }
		}
        
		public static TableSchema.Table TGetUrl
		{
            get { return DataService.GetSchema("T_getUrl", "Nowthwin"); }
		}
        
		public static TableSchema.Table TLog
		{
            get { return DataService.GetSchema("T_Log", "Nowthwin"); }
		}
        
		public static TableSchema.Table TLogError
		{
            get { return DataService.GetSchema("T_Log_Error", "Nowthwin"); }
		}
        
		public static TableSchema.Table TLogService
		{
            get { return DataService.GetSchema("T_Log_Service", "Nowthwin"); }
		}
        
		public static TableSchema.Table TMessage
		{
            get { return DataService.GetSchema("T_Message", "Nowthwin"); }
		}
        
		public static TableSchema.Table TMflSearch
		{
            get { return DataService.GetSchema("T_Mfl_search", "Nowthwin"); }
		}
        
		public static TableSchema.Table TMLCodeList
		{
            get { return DataService.GetSchema("T_MLCodeList", "Nowthwin"); }
		}
        
		public static TableSchema.Table TOldApsByCf
		{
            get { return DataService.GetSchema("T_OldApsByCf", "Nowthwin"); }
		}
        
		public static TableSchema.Table TOldApsByCf1706
		{
            get { return DataService.GetSchema("T_OldApsByCf@1706", "Nowthwin"); }
		}
        
		public static TableSchema.Table TOldApsByCf1712
		{
            get { return DataService.GetSchema("T_OldApsByCf@1712", "Nowthwin"); }
		}
        
		public static TableSchema.Table TOperationLog
		{
            get { return DataService.GetSchema("T_Operation_Log", "Nowthwin"); }
		}
        
		public static TableSchema.Table TOrderProcessHour
		{
            get { return DataService.GetSchema("T_OrderProcessHour", "Nowthwin"); }
		}
        
		public static TableSchema.Table TPlanM
		{
            get { return DataService.GetSchema("T_PlanM", "Nowthwin"); }
		}
        
		public static TableSchema.Table TPlanMAdd
		{
            get { return DataService.GetSchema("T_PlanM_Add", "Nowthwin"); }
		}
        
		public static TableSchema.Table TPlan
		{
            get { return DataService.GetSchema("T_PlanS", "Nowthwin"); }
		}
        
		public static TableSchema.Table TPlanSAdd
		{
            get { return DataService.GetSchema("T_PlanS_Add", "Nowthwin"); }
		}
        
		public static TableSchema.Table TPushBlOutputList
		{
            get { return DataService.GetSchema("T_PushBlOutputList", "Nowthwin"); }
		}
        
		public static TableSchema.Table TResultMsg
		{
            get { return DataService.GetSchema("T_ResultMsg", "Nowthwin"); }
		}
        
		public static TableSchema.Table TSendLog
		{
            get { return DataService.GetSchema("T_sendLog", "Nowthwin"); }
		}
        
		public static TableSchema.Table TSql
		{
            get { return DataService.GetSchema("T_SQL", "Nowthwin"); }
		}
        
		public static TableSchema.Table TTemp
		{
            get { return DataService.GetSchema("T_Temp", "Nowthwin"); }
		}
        
		public static TableSchema.Table TTempInfo
		{
            get { return DataService.GetSchema("T_TempInfo", "Nowthwin"); }
		}
        
		public static TableSchema.Table TTempME
		{
            get { return DataService.GetSchema("T_TempMES", "Nowthwin"); }
		}
        
		public static TableSchema.Table TTsgy
		{
            get { return DataService.GetSchema("T_TSGY", "Nowthwin"); }
		}
        
		public static TableSchema.Table TTzwf
		{
            get { return DataService.GetSchema("T_TZWF", "Nowthwin"); }
		}
        
		public static TableSchema.Table TUsersGroup
		{
            get { return DataService.GetSchema("T_UsersGroup", "Nowthwin"); }
		}
        
		public static TableSchema.Table TUsersInfo
		{
            get { return DataService.GetSchema("T_UsersInfo", "Nowthwin"); }
		}
        
		public static TableSchema.Table TUsersPage
		{
            get { return DataService.GetSchema("T_UsersPages", "Nowthwin"); }
		}
        
		public static TableSchema.Table TWorkTime
		{
            get { return DataService.GetSchema("T_WorkTime", "Nowthwin"); }
		}
        
		public static TableSchema.Table TWorkTimeShirt
		{
            get { return DataService.GetSchema("T_WorkTimeShirt", "Nowthwin"); }
		}
        
		public static TableSchema.Table WmsSyncCutterAP
		{
            get { return DataService.GetSchema("WMS_SYNC_CutterAPS", "Nowthwin"); }
		}
        
		public static TableSchema.Table WmsSyncPlanm
		{
            get { return DataService.GetSchema("WMS_SYNC_planm", "Nowthwin"); }
		}
        
		public static TableSchema.Table WmsSyncPlan
		{
            get { return DataService.GetSchema("WMS_SYNC_plans", "Nowthwin"); }
		}
        
		public static TableSchema.Table XTM12
		{
            get { return DataService.GetSchema("XTM12", "Nowthwin"); }
		}
        
		public static TableSchema.Table XTM124
		{
            get { return DataService.GetSchema("XTM124", "Nowthwin"); }
		}
        
		public static TableSchema.Table XTM14
		{
            get { return DataService.GetSchema("XTM14", "Nowthwin"); }
		}
        
		public static TableSchema.Table XTM22
		{
            get { return DataService.GetSchema("XTM22", "Nowthwin"); }
		}
        
		public static TableSchema.Table XTM32
		{
            get { return DataService.GetSchema("XTM32", "Nowthwin"); }
		}
        
	
    }
    #endregion
    #region View Struct
    public partial struct Views 
    {
		
		public static readonly string CadSchedulingResault = @"CadSchedulingResault";
        
		public static readonly string CAD衬衣特殊款式每人分组 = @"CAD衬衣特殊款式每人分组";
        
		public static readonly string Kkk = @"kkk";
        
		public static readonly string ResourcesCAD = @"ResourcesCAD";
        
		public static readonly string ResourcesCADAll = @"ResourcesCADAll";
        
		public static readonly string TViewOutputResuorce = @"T_View_OutputResuorces";
        
		public static readonly string TViewOutputtzresoure = @"T_View_Outputtzresoure";
        
		public static readonly string VBlankingOut = @"V_BlankingOut";
        
		public static readonly string VCadOrderlist = @"V_CAD_ORDERLIST";
        
		public static readonly string VCadOrderlistCy = @"V_CAD_ORDERLIST_CY";
        
		public static readonly string VCadOrderlistXf = @"V_CAD_ORDERLIST_XF";
        
		public static readonly string VCADResourceNum = @"V_CADResourceNum";
        
		public static readonly string VCyjh = @"V_CYJH";
        
		public static readonly string VFactoryCalendar = @"V_FactoryCalendar";
        
		public static readonly string VFzScjh = @"V_FZ_SCJH";
        
		public static readonly string VJh = @"V_JH";
        
		public static readonly string VOutPutByCAD = @"V_OutPutByCAD";
        
		public static readonly string VOutPutListByCF = @"V_outPutListByCF";
        
		public static readonly string VPlanDetail = @"V_Plan_Detail";
        
		public static readonly string VPlanSDetail = @"V_PlanS_Detail";
        
		public static readonly string VTempMESCad = @"V_TempMES_CAD";
        
		public static readonly string VTempPlan = @"V_TempPlanS";
        
		public static readonly string VTzjh = @"v_tzjh";
        
		public static readonly string VWorkTimeCy = @"V_workTimeCy";
        
		public static readonly string VWorktimexf = @"v_worktimexf";
        
		public static readonly string VXfmtmjh = @"v_xfmtmjh";
        
		public static readonly string VZbNowMTM = @"V_ZbNowMTM";
        
		public static readonly string VZbNowTZ = @"V_ZbNowTZ";
        
		public static readonly string View1 = @"View_1";
        
		public static readonly string View2 = @"View_2";
        
		public static readonly string View3 = @"View_3";
        
		public static readonly string ViewBLDataOrder = @"View_BLData_order";
        
		public static readonly string ViewCFByMTM = @"View_CFByMTM";
        
		public static readonly string ViewErrorLog = @"View_ErrorLogs";
        
		public static readonly string ViewFzCoatlist = @"View_FZ_Coatlist";
        
		public static readonly string ViewFzerpCoatlist = @"View_FZERP_Coatlist";
        
		public static readonly string ViewLookOutPutTable = @"View_LookOutPutTable";
        
		public static readonly string ViewOrderList = @"View_orderList";
        
		public static readonly string ViewOrderListWithoutmflxx = @"View_orderListWithoutmflxx";
        
		public static readonly string ViewOutPutListByCF = @"View_outPutListByCF";
        
		public static readonly string ViewOutputListCF = @"View_outputListCF";
        
		public static readonly string ViewUsersList = @"View_UsersList";
        
		public static readonly string ViewBomList = @"ViewBomList";
        
		public static readonly string ViewUnPerson = @"ViewUnPerson";
        
    }
    #endregion
    
    #region Query Factories
	public static partial class DB
	{
        public static DataProvider _provider = DataService.Providers["Nowthwin"];
        static ISubSonicRepository _repository;
        public static ISubSonicRepository Repository 
        {
            get 
            {
                if (_repository == null)
                    return new SubSonicRepository(_provider);
                return _repository; 
            }
            set { _repository = value; }
        }
        public static Select SelectAllColumnsFrom<T>() where T : RecordBase<T>, new()
	    {
            return Repository.SelectAllColumnsFrom<T>();
	    }
	    public static Select Select()
	    {
            return Repository.Select();
	    }
	    
		public static Select Select(params string[] columns)
		{
            return Repository.Select(columns);
        }
	    
		public static Select Select(params Aggregate[] aggregates)
		{
            return Repository.Select(aggregates);
        }
   
	    public static Update Update<T>() where T : RecordBase<T>, new()
	    {
            return Repository.Update<T>();
	    }
	    
	    public static Insert Insert()
	    {
            return Repository.Insert();
	    }
	    
	    public static Delete Delete()
	    {
            return Repository.Delete();
	    }
	    
	    public static InlineQuery Query()
	    {
            return Repository.Query();
	    }
	    	    
	    
	}
    #endregion
    
}
#region Databases
public partial struct Databases 
{
	
	public static readonly string Nowthwin = @"Nowthwin";
    
}
#endregion