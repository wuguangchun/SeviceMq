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
    /// <summary>
    /// Controller class for T_Analysis_ErpList
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class TAnalysisErpListController
    {
        // Preload our schema..
        TAnalysisErpList thisSchemaLoad = new TAnalysisErpList();
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
        public TAnalysisErpListCollection FetchAll()
        {
            TAnalysisErpListCollection coll = new TAnalysisErpListCollection();
            Query qry = new Query(TAnalysisErpList.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public TAnalysisErpListCollection FetchByID(object OrderId)
        {
            TAnalysisErpListCollection coll = new TAnalysisErpListCollection().Where("orderId", OrderId).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public TAnalysisErpListCollection FetchByQuery(Query qry)
        {
            TAnalysisErpListCollection coll = new TAnalysisErpListCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object OrderId)
        {
            return (TAnalysisErpList.Delete(OrderId) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object OrderId)
        {
            return (TAnalysisErpList.Destroy(OrderId) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(string OrderId,string CustomerId,string Project,string OrderType,string CoatType,string BodyType,string Fabric,string Mflxx,DateTime? OrderTime,DateTime? DeliveryTime,int? SpecialTime,string SpecialCode,string Styles,string StylesResult,int? Numbers,string SupportingWay,string Sizes,string Customer,DateTime? CreateTime,string OrderStatus,DateTime? CreateDate,int? MaxNumber,int? TotalNumber,string Hand,string Type,string Scjhdd,string Scggdh,DateTime? ModifyTime)
	    {
		    TAnalysisErpList item = new TAnalysisErpList();
		    
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
            
            item.MaxNumber = MaxNumber;
            
            item.TotalNumber = TotalNumber;
            
            item.Hand = Hand;
            
            item.Type = Type;
            
            item.Scjhdd = Scjhdd;
            
            item.Scggdh = Scggdh;
            
            item.ModifyTime = ModifyTime;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(string OrderId,string CustomerId,string Project,string OrderType,string CoatType,string BodyType,string Fabric,string Mflxx,DateTime? OrderTime,DateTime? DeliveryTime,int? SpecialTime,string SpecialCode,string Styles,string StylesResult,int? Numbers,string SupportingWay,string Sizes,string Customer,DateTime? CreateTime,string OrderStatus,DateTime? CreateDate,int? MaxNumber,int? TotalNumber,string Hand,string Type,string Scjhdd,string Scggdh,DateTime? ModifyTime)
	    {
		    TAnalysisErpList item = new TAnalysisErpList();
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
				
			item.MaxNumber = MaxNumber;
				
			item.TotalNumber = TotalNumber;
				
			item.Hand = Hand;
				
			item.Type = Type;
				
			item.Scjhdd = Scjhdd;
				
			item.Scggdh = Scggdh;
				
			item.ModifyTime = ModifyTime;
				
	        item.Save(UserName);
	    }
    }
}
