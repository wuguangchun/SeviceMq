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
    /// Controller class for T_ERP_Order
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class TErpOrderController
    {
        // Preload our schema..
        TErpOrder thisSchemaLoad = new TErpOrder();
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
        public TErpOrderCollection FetchAll()
        {
            TErpOrderCollection coll = new TErpOrderCollection();
            Query qry = new Query(TErpOrder.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public TErpOrderCollection FetchByID(object Id)
        {
            TErpOrderCollection coll = new TErpOrderCollection().Where("ID", Id).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public TErpOrderCollection FetchByQuery(Query qry)
        {
            TErpOrderCollection coll = new TErpOrderCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object Id)
        {
            return (TErpOrder.Delete(Id) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object Id)
        {
            return (TErpOrder.Destroy(Id) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(string Id,string CustomerId,int? Numbers,int? RowNumber,string Size,string Sjbh,string Style,string Type,decimal? FlagStatus,string Scjhdd)
	    {
		    TErpOrder item = new TErpOrder();
		    
            item.Id = Id;
            
            item.CustomerId = CustomerId;
            
            item.Numbers = Numbers;
            
            item.RowNumber = RowNumber;
            
            item.Size = Size;
            
            item.Sjbh = Sjbh;
            
            item.Style = Style;
            
            item.Type = Type;
            
            item.FlagStatus = FlagStatus;
            
            item.Scjhdd = Scjhdd;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(string Id,string CustomerId,int? Numbers,int? RowNumber,string Size,string Sjbh,string Style,string Type,decimal? FlagStatus,string Scjhdd)
	    {
		    TErpOrder item = new TErpOrder();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.Id = Id;
				
			item.CustomerId = CustomerId;
				
			item.Numbers = Numbers;
				
			item.RowNumber = RowNumber;
				
			item.Size = Size;
				
			item.Sjbh = Sjbh;
				
			item.Style = Style;
				
			item.Type = Type;
				
			item.FlagStatus = FlagStatus;
				
			item.Scjhdd = Scjhdd;
				
	        item.Save(UserName);
	    }
    }
}