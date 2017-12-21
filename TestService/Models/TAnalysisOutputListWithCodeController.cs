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
namespace APSData
{
    /// <summary>
    /// Controller class for T_Analysis_OutputListWithCode
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class TAnalysisOutputListWithCodeController
    {
        // Preload our schema..
        TAnalysisOutputListWithCode thisSchemaLoad = new TAnalysisOutputListWithCode();
        private string userName = String.Empty;
        protected string UserName
        {
            get
            {
				if (userName.Length == 0) 
				{
    				if (System.Web.HttpContext.Current != null)
    				{
						userName=System.Web.HttpContext.Current.User.Identity.Name;
					}
					else
					{
						userName=System.Threading.Thread.CurrentPrincipal.Identity.Name;
					}
				}
				return userName;
            }
        }
        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public TAnalysisOutputListWithCodeCollection FetchAll()
        {
            TAnalysisOutputListWithCodeCollection coll = new TAnalysisOutputListWithCodeCollection();
            Query qry = new Query(TAnalysisOutputListWithCode.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public TAnalysisOutputListWithCodeCollection FetchByID(object PkId)
        {
            TAnalysisOutputListWithCodeCollection coll = new TAnalysisOutputListWithCodeCollection().Where("pkId", PkId).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public TAnalysisOutputListWithCodeCollection FetchByQuery(Query qry)
        {
            TAnalysisOutputListWithCodeCollection coll = new TAnalysisOutputListWithCodeCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object PkId)
        {
            return (TAnalysisOutputListWithCode.Delete(PkId) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object PkId)
        {
            return (TAnalysisOutputListWithCode.Destroy(PkId) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(string PkId,string PlanId,string JobCode,string Project,string OrderType,string CoatType,string BodyType,string Fabric,DateTime? OrderTime,DateTime? DeliveryTime,int? SpecialTime,string SpecialCode,string Styles,string StylesResult,int? Numbers,int? PlanNum,string SupportingWay,int? Workinfo,string OrderNo,string Customer,string OriginalCode,string Abnormal,string Note,string Resources,DateTime? BeginTime,DateTime? EndTime,string MakeTime,DateTime? CreateDate,string Scjhdd,string Scggdh,string Scgcdm,string ClothType,string Tzecode)
	    {
		    TAnalysisOutputListWithCode item = new TAnalysisOutputListWithCode();
		    
            item.PkId = PkId;
            
            item.PlanId = PlanId;
            
            item.JobCode = JobCode;
            
            item.Project = Project;
            
            item.OrderType = OrderType;
            
            item.CoatType = CoatType;
            
            item.BodyType = BodyType;
            
            item.Fabric = Fabric;
            
            item.OrderTime = OrderTime;
            
            item.DeliveryTime = DeliveryTime;
            
            item.SpecialTime = SpecialTime;
            
            item.SpecialCode = SpecialCode;
            
            item.Styles = Styles;
            
            item.StylesResult = StylesResult;
            
            item.Numbers = Numbers;
            
            item.PlanNum = PlanNum;
            
            item.SupportingWay = SupportingWay;
            
            item.Workinfo = Workinfo;
            
            item.OrderNo = OrderNo;
            
            item.Customer = Customer;
            
            item.OriginalCode = OriginalCode;
            
            item.Abnormal = Abnormal;
            
            item.Note = Note;
            
            item.Resources = Resources;
            
            item.BeginTime = BeginTime;
            
            item.EndTime = EndTime;
            
            item.MakeTime = MakeTime;
            
            item.CreateDate = CreateDate;
            
            item.Scjhdd = Scjhdd;
            
            item.Scggdh = Scggdh;
            
            item.Scgcdm = Scgcdm;
            
            item.ClothType = ClothType;
            
            item.Tzecode = Tzecode;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(string PkId,string PlanId,string JobCode,string Project,string OrderType,string CoatType,string BodyType,string Fabric,DateTime? OrderTime,DateTime? DeliveryTime,int? SpecialTime,string SpecialCode,string Styles,string StylesResult,int? Numbers,int? PlanNum,string SupportingWay,int? Workinfo,string OrderNo,string Customer,string OriginalCode,string Abnormal,string Note,string Resources,DateTime? BeginTime,DateTime? EndTime,string MakeTime,DateTime? CreateDate,string Scjhdd,string Scggdh,string Scgcdm,string ClothType,string Tzecode)
	    {
		    TAnalysisOutputListWithCode item = new TAnalysisOutputListWithCode();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.PkId = PkId;
				
			item.PlanId = PlanId;
				
			item.JobCode = JobCode;
				
			item.Project = Project;
				
			item.OrderType = OrderType;
				
			item.CoatType = CoatType;
				
			item.BodyType = BodyType;
				
			item.Fabric = Fabric;
				
			item.OrderTime = OrderTime;
				
			item.DeliveryTime = DeliveryTime;
				
			item.SpecialTime = SpecialTime;
				
			item.SpecialCode = SpecialCode;
				
			item.Styles = Styles;
				
			item.StylesResult = StylesResult;
				
			item.Numbers = Numbers;
				
			item.PlanNum = PlanNum;
				
			item.SupportingWay = SupportingWay;
				
			item.Workinfo = Workinfo;
				
			item.OrderNo = OrderNo;
				
			item.Customer = Customer;
				
			item.OriginalCode = OriginalCode;
				
			item.Abnormal = Abnormal;
				
			item.Note = Note;
				
			item.Resources = Resources;
				
			item.BeginTime = BeginTime;
				
			item.EndTime = EndTime;
				
			item.MakeTime = MakeTime;
				
			item.CreateDate = CreateDate;
				
			item.Scjhdd = Scjhdd;
				
			item.Scggdh = Scggdh;
				
			item.Scgcdm = Scgcdm;
				
			item.ClothType = ClothType;
				
			item.Tzecode = Tzecode;
				
	        item.Save(UserName);
	    }
    }
}