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
    /// Controller class for T_Analysis_OutPutListByCF
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class TAnalysisOutPutListByCFController
    {
        // Preload our schema..
        TAnalysisOutPutListByCF thisSchemaLoad = new TAnalysisOutPutListByCF();
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
        public TAnalysisOutPutListByCFCollection FetchAll()
        {
            TAnalysisOutPutListByCFCollection coll = new TAnalysisOutPutListByCFCollection();
            Query qry = new Query(TAnalysisOutPutListByCF.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public TAnalysisOutPutListByCFCollection FetchByID(object OrderId)
        {
            TAnalysisOutPutListByCFCollection coll = new TAnalysisOutPutListByCFCollection().Where("orderId", OrderId).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public TAnalysisOutPutListByCFCollection FetchByQuery(Query qry)
        {
            TAnalysisOutPutListByCFCollection coll = new TAnalysisOutPutListByCFCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object OrderId)
        {
            return (TAnalysisOutPutListByCF.Delete(OrderId) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object OrderId)
        {
            return (TAnalysisOutPutListByCF.Destroy(OrderId) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(string OrderId,string CustomerId,string Project,string OrderType,string CoatType,string BodyType,string Fabric,string Mflxx,DateTime? OrderTime,DateTime? DeliveryTime,int? SpecialTime,string SpecialCode,string Styles,string StylesResult,int? Numbers,string SupportingWay,string Sizes,string Customer,DateTime? CreateTime,string OrderStatus,DateTime? CreateDate,string Pbcd,string Gydm,DateTime? Audittime,string Sfbcpsy,string Tzecode,string Scggdh,DateTime? ModifyTime,string PbcdName,DateTime? EndTime,int? FlagStatus,string Resources,DateTime? Cuttime,string Resourcesnum,string JobId,string Res,string ClothType,string CjDate,string CjTime)
	    {
		    TAnalysisOutPutListByCF item = new TAnalysisOutPutListByCF();
		    
            item.OrderId = OrderId;
            
            item.CustomerId = CustomerId;
            
            item.Project = Project;
            
            item.OrderType = OrderType;
            
            item.CoatType = CoatType;
            
            item.BodyType = BodyType;
            
            item.Fabric = Fabric;
            
            item.Mflxx = Mflxx;
            
            item.OrderTime = OrderTime;
            
            item.DeliveryTime = DeliveryTime;
            
            item.SpecialTime = SpecialTime;
            
            item.SpecialCode = SpecialCode;
            
            item.Styles = Styles;
            
            item.StylesResult = StylesResult;
            
            item.Numbers = Numbers;
            
            item.SupportingWay = SupportingWay;
            
            item.Sizes = Sizes;
            
            item.Customer = Customer;
            
            item.CreateTime = CreateTime;
            
            item.OrderStatus = OrderStatus;
            
            item.CreateDate = CreateDate;
            
            item.Pbcd = Pbcd;
            
            item.Gydm = Gydm;
            
            item.Audittime = Audittime;
            
            item.Sfbcpsy = Sfbcpsy;
            
            item.Tzecode = Tzecode;
            
            item.Scggdh = Scggdh;
            
            item.ModifyTime = ModifyTime;
            
            item.PbcdName = PbcdName;
            
            item.EndTime = EndTime;
            
            item.FlagStatus = FlagStatus;
            
            item.Resources = Resources;
            
            item.Cuttime = Cuttime;
            
            item.Resourcesnum = Resourcesnum;
            
            item.JobId = JobId;
            
            item.Res = Res;
            
            item.ClothType = ClothType;
            
            item.CjDate = CjDate;
            
            item.CjTime = CjTime;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(string OrderId,string CustomerId,string Project,string OrderType,string CoatType,string BodyType,string Fabric,string Mflxx,DateTime? OrderTime,DateTime? DeliveryTime,int? SpecialTime,string SpecialCode,string Styles,string StylesResult,int? Numbers,string SupportingWay,string Sizes,string Customer,DateTime? CreateTime,string OrderStatus,DateTime? CreateDate,string Pbcd,string Gydm,DateTime? Audittime,string Sfbcpsy,string Tzecode,string Scggdh,DateTime? ModifyTime,string PbcdName,DateTime? EndTime,int? FlagStatus,string Resources,DateTime? Cuttime,string Resourcesnum,string JobId,string Res,string ClothType,string CjDate,string CjTime)
	    {
		    TAnalysisOutPutListByCF item = new TAnalysisOutPutListByCF();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.OrderId = OrderId;
				
			item.CustomerId = CustomerId;
				
			item.Project = Project;
				
			item.OrderType = OrderType;
				
			item.CoatType = CoatType;
				
			item.BodyType = BodyType;
				
			item.Fabric = Fabric;
				
			item.Mflxx = Mflxx;
				
			item.OrderTime = OrderTime;
				
			item.DeliveryTime = DeliveryTime;
				
			item.SpecialTime = SpecialTime;
				
			item.SpecialCode = SpecialCode;
				
			item.Styles = Styles;
				
			item.StylesResult = StylesResult;
				
			item.Numbers = Numbers;
				
			item.SupportingWay = SupportingWay;
				
			item.Sizes = Sizes;
				
			item.Customer = Customer;
				
			item.CreateTime = CreateTime;
				
			item.OrderStatus = OrderStatus;
				
			item.CreateDate = CreateDate;
				
			item.Pbcd = Pbcd;
				
			item.Gydm = Gydm;
				
			item.Audittime = Audittime;
				
			item.Sfbcpsy = Sfbcpsy;
				
			item.Tzecode = Tzecode;
				
			item.Scggdh = Scggdh;
				
			item.ModifyTime = ModifyTime;
				
			item.PbcdName = PbcdName;
				
			item.EndTime = EndTime;
				
			item.FlagStatus = FlagStatus;
				
			item.Resources = Resources;
				
			item.Cuttime = Cuttime;
				
			item.Resourcesnum = Resourcesnum;
				
			item.JobId = JobId;
				
			item.Res = Res;
				
			item.ClothType = ClothType;
				
			item.CjDate = CjDate;
				
			item.CjTime = CjTime;
				
	        item.Save(UserName);
	    }
    }
}