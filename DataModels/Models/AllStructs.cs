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
        
		public static readonly string BPMOrder = @"BPMOrders";
        
		public static readonly string Dictionary = @"Dictionaries";
        
		public static readonly string FactoryOrderTran = @"FactoryOrderTrans";
        
		public static readonly string HljtTaskList = @"HLJT_TaskList";
        
		public static readonly string SCM06 = @"SCM06";
        
		public static readonly string SCT26 = @"SCT26";
        
		public static readonly string SCT26Test = @"SCT26_test";
        
		public static readonly string SCT27 = @"SCT27";
        
		public static readonly string SCT27Test = @"SCT27_test";
        
		public static readonly string SCT28 = @"SCT28";
        
		public static readonly string TAnalysisCyMTMJh = @"T_Analysis_CyMTMJh";
        
		public static readonly string TAnalysisCyTZJhDelete = @"T_Analysis_CyTZJh_delete";
        
		public static readonly string TAnalysisDelivery = @"T_Analysis_Delivery";
        
		public static readonly string TAnalysisOrder = @"T_Analysis_Order";
        
		public static readonly string TAnalysisOrderList = @"T_Analysis_OrderList";
        
		public static readonly string TAnalysisOrderListHistory = @"T_Analysis_OrderList@History";
        
		public static readonly string TAnalysisOrderListByCF = @"T_Analysis_OrderListByCF";
        
		public static readonly string TAnalysisOrderListByCFHistory = @"T_Analysis_OrderListByCF@History";
        
		public static readonly string TAnalysisOrderListByDH = @"T_Analysis_OrderListByDH";
        
		public static readonly string TAnalysisOrderMx = @"T_Analysis_OrderMx";
        
		public static readonly string TAnalysisOutputList = @"T_Analysis_OutputList";
        
		public static readonly string TAnalysisOutPutListByCF = @"T_Analysis_OutPutListByCF";
        
		public static readonly string TAnalysisOutPutListByFZ = @"T_Analysis_OutPutListByFZ";
        
		public static readonly string TAnalysisOutputListTzWithCodeDelete = @"T_Analysis_OutputListTzWithCode_delete";
        
		public static readonly string TAnalysisOutputListWithCodeCopy = @"T_Analysis_OutputListWithCode_copy";
        
		public static readonly string TAnalysisOutputListWithCodeShirt = @"T_Analysis_OutputListWithCode_Shirt";
        
		public static readonly string TAnalysisOutputListWithCodeTZShirt = @"T_Analysis_OutputListWithCode_TZShirt";
        
		public static readonly string TApsClientLog = @"T_ApsClientLog";
        
		public static readonly string TApsClientLogHistory = @"T_ApsClientLog@History";
        
		public static readonly string TAPSCount = @"T_APSCount";
        
		public static readonly string TAttendance = @"T_Attendance";
        
		public static readonly string TAttendanceMode = @"T_AttendanceMode";
        
		public static readonly string TBackupsMtmJH = @"T_backups_MtmJH";
        
		public static readonly string TBasisBodyList = @"T_Basis_BodyList";
        
		public static readonly string TBasisCoatList = @"T_Basis_CoatList";
        
		public static readonly string TBasisCoatType = @"T_Basis_CoatType";
        
		public static readonly string TBasisIntercourse = @"T_Basis_Intercourse";
        
		public static readonly string TBasisLinerType = @"T_Basis_LinerType";
        
		public static readonly string TBasisLinesFz = @"T_Basis_LinesFz";
        
		public static readonly string TBasisLinesRestriction = @"T_Basis_LinesRestriction";
        
		public static readonly string TBasisOrderStatus = @"T_Basis_OrderStatus";
        
		public static readonly string TBasisOrderStatusHistory = @"T_Basis_OrderStatus@History";
        
		public static readonly string TBasisResource = @"T_Basis_resource";
        
		public static readonly string TBasisRTXMsg = @"T_Basis_RTXMsg";
        
		public static readonly string TBasisScgcmc = @"T_Basis_SCGCMC";
        
		public static readonly string TBasisSewingProcess = @"T_Basis_SewingProcess";
        
		public static readonly string TBasisSpecialCode = @"T_Basis_SpecialCode";
        
		public static readonly string TBasisSpecialList = @"T_Basis_SpecialList";
        
		public static readonly string TBasisSystemInfo = @"T_Basis_SystemInfo";
        
		public static readonly string TBasisTechnique = @"T_Basis_Technique";
        
		public static readonly string TBlankingDetaile = @"T_BlankingDetailes";
        
		public static readonly string TBlankingDetailesHistory = @"T_BlankingDetailes@History";
        
		public static readonly string TBLCADTemp = @"T_BLCADTemp";
        
		public static readonly string TBLCADTempHistory = @"T_BLCADTemp@History";
        
		public static readonly string TBLDataMflxx = @"T_BLData_Mflxx";
        
		public static readonly string TBLDataMflxxHistory = @"T_BLData_Mflxx@History";
        
		public static readonly string TBLDataOrder = @"T_BLData_Order";
        
		public static readonly string TBLDataOrderHistory = @"T_BLData_Order@History";
        
		public static readonly string TBLDataOrdermx = @"T_BLData_Ordermx";
        
		public static readonly string TBLDataOrdermxHistory = @"T_BLData_Ordermx@History";
        
		public static readonly string TBLDataPld = @"T_BLData_PLD";
        
		public static readonly string TBLDataPLD2 = @"T_BLData_PLD2";
        
		public static readonly string TBom = @"T_BOM";
        
		public static readonly string TCategoryProcessFlowDelete = @"T_CategoryProcessFlow_delete";
        
		public static readonly string TCutterAP = @"T_CutterAPS";
        
		public static readonly string TCutterME = @"T_CutterMES";
        
		public static readonly string TErrorLog = @"T_ErrorLog";
        
		public static readonly string TFZfirstOrder = @"T_FZfirstOrder";
        
		public static readonly string TFZfirstOut = @"T_FZfirstOut";
        
		public static readonly string TLog = @"T_Log";
        
		public static readonly string TLogErpSct27 = @"T_Log_ErpSct27";
        
		public static readonly string TLogError = @"T_Log_Error";
        
		public static readonly string TLogService = @"T_Log_Service";
        
		public static readonly string TLogAPSToSAP = @"T_LogAPSToSAP";
        
		public static readonly string TMessage = @"T_Message";
        
		public static readonly string TMflSearch = @"T_Mfl_search";
        
		public static readonly string TMixedPlan = @"T_Mixed_Plan";
        
		public static readonly string TOldApsByCf = @"T_OldApsByCf";
        
		public static readonly string TOldApsByCfHistory = @"T_OldApsByCf@History";
        
		public static readonly string TOrderdatapoolxf = @"T_orderdatapoolxf";
        
		public static readonly string TOrderKeyProcess = @"T_OrderKeyProcess";
        
		public static readonly string TOrderMESArtInfo = @"T_OrderMESArtInfo";
        
		public static readonly string TOrderProcessHourDelete = @"T_OrderProcessHour_delete";
        
		public static readonly string TPlanM = @"T_PlanM";
        
		public static readonly string TResultMsg = @"T_ResultMsg";
        
		public static readonly string TTempLineOrderPool = @"T_Temp_LineOrderPool";
        
		public static readonly string TTempME = @"T_TempMES";
        
		public static readonly string TTsgy = @"T_TSGY";
        
		public static readonly string TUsersGroup = @"T_UsersGroup";
        
		public static readonly string TUsersInfo = @"T_UsersInfo";
        
		public static readonly string TUsersPage = @"T_UsersPages";
        
		public static readonly string TWorkTime = @"T_WorkTime";
        
		public static readonly string TWorkTimeShirt = @"T_WorkTimeShirt";
        
		public static readonly string WmsSyncCutterAP = @"WMS_SYNC_CutterAPS";
        
		public static readonly string WmsSyncPlanm = @"WMS_SYNC_planm";
        
		public static readonly string WmsSyncPlan = @"WMS_SYNC_plans";
        
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
        
		public static TableSchema.Table BPMOrder
		{
            get { return DataService.GetSchema("BPMOrders", "Nowthwin"); }
		}
        
		public static TableSchema.Table Dictionary
		{
            get { return DataService.GetSchema("Dictionaries", "Nowthwin"); }
		}
        
		public static TableSchema.Table FactoryOrderTran
		{
            get { return DataService.GetSchema("FactoryOrderTrans", "Nowthwin"); }
		}
        
		public static TableSchema.Table HljtTaskList
		{
            get { return DataService.GetSchema("HLJT_TaskList", "Nowthwin"); }
		}
        
		public static TableSchema.Table SCM06
		{
            get { return DataService.GetSchema("SCM06", "Nowthwin"); }
		}
        
		public static TableSchema.Table SCT26
		{
            get { return DataService.GetSchema("SCT26", "Nowthwin"); }
		}
        
		public static TableSchema.Table SCT26Test
		{
            get { return DataService.GetSchema("SCT26_test", "Nowthwin"); }
		}
        
		public static TableSchema.Table SCT27
		{
            get { return DataService.GetSchema("SCT27", "Nowthwin"); }
		}
        
		public static TableSchema.Table SCT27Test
		{
            get { return DataService.GetSchema("SCT27_test", "Nowthwin"); }
		}
        
		public static TableSchema.Table SCT28
		{
            get { return DataService.GetSchema("SCT28", "Nowthwin"); }
		}
        
		public static TableSchema.Table TAnalysisCyMTMJh
		{
            get { return DataService.GetSchema("T_Analysis_CyMTMJh", "Nowthwin"); }
		}
        
		public static TableSchema.Table TAnalysisCyTZJhDelete
		{
            get { return DataService.GetSchema("T_Analysis_CyTZJh_delete", "Nowthwin"); }
		}
        
		public static TableSchema.Table TAnalysisDelivery
		{
            get { return DataService.GetSchema("T_Analysis_Delivery", "Nowthwin"); }
		}
        
		public static TableSchema.Table TAnalysisOrder
		{
            get { return DataService.GetSchema("T_Analysis_Order", "Nowthwin"); }
		}
        
		public static TableSchema.Table TAnalysisOrderList
		{
            get { return DataService.GetSchema("T_Analysis_OrderList", "Nowthwin"); }
		}
        
		public static TableSchema.Table TAnalysisOrderListHistory
		{
            get { return DataService.GetSchema("T_Analysis_OrderList@History", "Nowthwin"); }
		}
        
		public static TableSchema.Table TAnalysisOrderListByCF
		{
            get { return DataService.GetSchema("T_Analysis_OrderListByCF", "Nowthwin"); }
		}
        
		public static TableSchema.Table TAnalysisOrderListByCFHistory
		{
            get { return DataService.GetSchema("T_Analysis_OrderListByCF@History", "Nowthwin"); }
		}
        
		public static TableSchema.Table TAnalysisOrderListByDH
		{
            get { return DataService.GetSchema("T_Analysis_OrderListByDH", "Nowthwin"); }
		}
        
		public static TableSchema.Table TAnalysisOrderMx
		{
            get { return DataService.GetSchema("T_Analysis_OrderMx", "Nowthwin"); }
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
        
		public static TableSchema.Table TAnalysisOutputListTzWithCodeDelete
		{
            get { return DataService.GetSchema("T_Analysis_OutputListTzWithCode_delete", "Nowthwin"); }
		}
        
		public static TableSchema.Table TAnalysisOutputListWithCodeCopy
		{
            get { return DataService.GetSchema("T_Analysis_OutputListWithCode_copy", "Nowthwin"); }
		}
        
		public static TableSchema.Table TAnalysisOutputListWithCodeShirt
		{
            get { return DataService.GetSchema("T_Analysis_OutputListWithCode_Shirt", "Nowthwin"); }
		}
        
		public static TableSchema.Table TAnalysisOutputListWithCodeTZShirt
		{
            get { return DataService.GetSchema("T_Analysis_OutputListWithCode_TZShirt", "Nowthwin"); }
		}
        
		public static TableSchema.Table TApsClientLog
		{
            get { return DataService.GetSchema("T_ApsClientLog", "Nowthwin"); }
		}
        
		public static TableSchema.Table TApsClientLogHistory
		{
            get { return DataService.GetSchema("T_ApsClientLog@History", "Nowthwin"); }
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
        
		public static TableSchema.Table TBasisIntercourse
		{
            get { return DataService.GetSchema("T_Basis_Intercourse", "Nowthwin"); }
		}
        
		public static TableSchema.Table TBasisLinerType
		{
            get { return DataService.GetSchema("T_Basis_LinerType", "Nowthwin"); }
		}
        
		public static TableSchema.Table TBasisLinesFz
		{
            get { return DataService.GetSchema("T_Basis_LinesFz", "Nowthwin"); }
		}
        
		public static TableSchema.Table TBasisLinesRestriction
		{
            get { return DataService.GetSchema("T_Basis_LinesRestriction", "Nowthwin"); }
		}
        
		public static TableSchema.Table TBasisOrderStatus
		{
            get { return DataService.GetSchema("T_Basis_OrderStatus", "Nowthwin"); }
		}
        
		public static TableSchema.Table TBasisOrderStatusHistory
		{
            get { return DataService.GetSchema("T_Basis_OrderStatus@History", "Nowthwin"); }
		}
        
		public static TableSchema.Table TBasisResource
		{
            get { return DataService.GetSchema("T_Basis_resource", "Nowthwin"); }
		}
        
		public static TableSchema.Table TBasisRTXMsg
		{
            get { return DataService.GetSchema("T_Basis_RTXMsg", "Nowthwin"); }
		}
        
		public static TableSchema.Table TBasisScgcmc
		{
            get { return DataService.GetSchema("T_Basis_SCGCMC", "Nowthwin"); }
		}
        
		public static TableSchema.Table TBasisSewingProcess
		{
            get { return DataService.GetSchema("T_Basis_SewingProcess", "Nowthwin"); }
		}
        
		public static TableSchema.Table TBasisSpecialCode
		{
            get { return DataService.GetSchema("T_Basis_SpecialCode", "Nowthwin"); }
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
        
		public static TableSchema.Table TBlankingDetailesHistory
		{
            get { return DataService.GetSchema("T_BlankingDetailes@History", "Nowthwin"); }
		}
        
		public static TableSchema.Table TBLCADTemp
		{
            get { return DataService.GetSchema("T_BLCADTemp", "Nowthwin"); }
		}
        
		public static TableSchema.Table TBLCADTempHistory
		{
            get { return DataService.GetSchema("T_BLCADTemp@History", "Nowthwin"); }
		}
        
		public static TableSchema.Table TBLDataMflxx
		{
            get { return DataService.GetSchema("T_BLData_Mflxx", "Nowthwin"); }
		}
        
		public static TableSchema.Table TBLDataMflxxHistory
		{
            get { return DataService.GetSchema("T_BLData_Mflxx@History", "Nowthwin"); }
		}
        
		public static TableSchema.Table TBLDataOrder
		{
            get { return DataService.GetSchema("T_BLData_Order", "Nowthwin"); }
		}
        
		public static TableSchema.Table TBLDataOrderHistory
		{
            get { return DataService.GetSchema("T_BLData_Order@History", "Nowthwin"); }
		}
        
		public static TableSchema.Table TBLDataOrdermx
		{
            get { return DataService.GetSchema("T_BLData_Ordermx", "Nowthwin"); }
		}
        
		public static TableSchema.Table TBLDataOrdermxHistory
		{
            get { return DataService.GetSchema("T_BLData_Ordermx@History", "Nowthwin"); }
		}
        
		public static TableSchema.Table TBLDataPld
		{
            get { return DataService.GetSchema("T_BLData_PLD", "Nowthwin"); }
		}
        
		public static TableSchema.Table TBLDataPLD2
		{
            get { return DataService.GetSchema("T_BLData_PLD2", "Nowthwin"); }
		}
        
		public static TableSchema.Table TBom
		{
            get { return DataService.GetSchema("T_BOM", "Nowthwin"); }
		}
        
		public static TableSchema.Table TCategoryProcessFlowDelete
		{
            get { return DataService.GetSchema("T_CategoryProcessFlow_delete", "Nowthwin"); }
		}
        
		public static TableSchema.Table TCutterAP
		{
            get { return DataService.GetSchema("T_CutterAPS", "Nowthwin"); }
		}
        
		public static TableSchema.Table TCutterME
		{
            get { return DataService.GetSchema("T_CutterMES", "Nowthwin"); }
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
        
		public static TableSchema.Table TLog
		{
            get { return DataService.GetSchema("T_Log", "Nowthwin"); }
		}
        
		public static TableSchema.Table TLogErpSct27
		{
            get { return DataService.GetSchema("T_Log_ErpSct27", "Nowthwin"); }
		}
        
		public static TableSchema.Table TLogError
		{
            get { return DataService.GetSchema("T_Log_Error", "Nowthwin"); }
		}
        
		public static TableSchema.Table TLogService
		{
            get { return DataService.GetSchema("T_Log_Service", "Nowthwin"); }
		}
        
		public static TableSchema.Table TLogAPSToSAP
		{
            get { return DataService.GetSchema("T_LogAPSToSAP", "Nowthwin"); }
		}
        
		public static TableSchema.Table TMessage
		{
            get { return DataService.GetSchema("T_Message", "Nowthwin"); }
		}
        
		public static TableSchema.Table TMflSearch
		{
            get { return DataService.GetSchema("T_Mfl_search", "Nowthwin"); }
		}
        
		public static TableSchema.Table TMixedPlan
		{
            get { return DataService.GetSchema("T_Mixed_Plan", "Nowthwin"); }
		}
        
		public static TableSchema.Table TOldApsByCf
		{
            get { return DataService.GetSchema("T_OldApsByCf", "Nowthwin"); }
		}
        
		public static TableSchema.Table TOldApsByCfHistory
		{
            get { return DataService.GetSchema("T_OldApsByCf@History", "Nowthwin"); }
		}
        
		public static TableSchema.Table TOrderdatapoolxf
		{
            get { return DataService.GetSchema("T_orderdatapoolxf", "Nowthwin"); }
		}
        
		public static TableSchema.Table TOrderKeyProcess
		{
            get { return DataService.GetSchema("T_OrderKeyProcess", "Nowthwin"); }
		}
        
		public static TableSchema.Table TOrderMESArtInfo
		{
            get { return DataService.GetSchema("T_OrderMESArtInfo", "Nowthwin"); }
		}
        
		public static TableSchema.Table TOrderProcessHourDelete
		{
            get { return DataService.GetSchema("T_OrderProcessHour_delete", "Nowthwin"); }
		}
        
		public static TableSchema.Table TPlanM
		{
            get { return DataService.GetSchema("T_PlanM", "Nowthwin"); }
		}
        
		public static TableSchema.Table TResultMsg
		{
            get { return DataService.GetSchema("T_ResultMsg", "Nowthwin"); }
		}
        
		public static TableSchema.Table TTempLineOrderPool
		{
            get { return DataService.GetSchema("T_Temp_LineOrderPool", "Nowthwin"); }
		}
        
		public static TableSchema.Table TTempME
		{
            get { return DataService.GetSchema("T_TempMES", "Nowthwin"); }
		}
        
		public static TableSchema.Table TTsgy
		{
            get { return DataService.GetSchema("T_TSGY", "Nowthwin"); }
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
        
		public static readonly string VCadOrderlistBackup = @"V_CAD_ORDERLIST_backup";
        
		public static readonly string VCADResourceNum = @"V_CADResourceNum";
        
		public static readonly string VCyjh = @"V_CYJH";
        
		public static readonly string VErpOrderXf = @"V_ErpOrderXf";
        
		public static readonly string VFactoryCalendar = @"V_FactoryCalendar";
        
		public static readonly string VFzScjh = @"V_FZ_SCJH";
        
		public static readonly string VJh = @"V_JH";
        
		public static readonly string VNoKeyProcess = @"V_NoKeyProcess";
        
		public static readonly string VOderArtHour = @"V_OderArtHour";
        
		public static readonly string VOrderDatapoolXf = @"V_OrderDatapoolXf";
        
		public static readonly string VOrderDatapoolXfTest = @"V_OrderDatapoolXf_Test";
        
		public static readonly string VOrderKeyProcessRow = @"V_OrderKeyProcessRow";
        
		public static readonly string VOrderListCJAll = @"V_OrderListCJ_ALL";
        
		public static readonly string VOrderListFZXf = @"V_OrderListFZ_XF";
        
		public static readonly string VOutPutByCAD = @"V_OutPutByCAD";
        
		public static readonly string VOutPutListByCFBackup = @"V_outPutListByCF_Backup";
        
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
        
		public static readonly string ViewErpSct51 = @"View_ErpSct51";
        
		public static readonly string ViewErrorLog = @"View_ErrorLogs";
        
		public static readonly string ViewFzCoatlist = @"View_FZ_Coatlist";
        
		public static readonly string ViewFzerpCoatlist = @"View_FZERP_Coatlist";
        
		public static readonly string ViewGylx = @"view_gylx";
        
		public static readonly string ViewLookOutPutTable = @"View_LookOutPutTable";
        
		public static readonly string ViewOrderList = @"View_orderList";
        
		public static readonly string ViewOrderListWithoutmflxx = @"View_orderListWithoutmflxx";
        
		public static readonly string ViewOutPutListByCF = @"View_outPutListByCF";
        
		public static readonly string ViewOutputListCFBackup = @"View_outputListCF_Backup";
        
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