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
    /// Controller class for T_BLData_Order
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class TBLDataOrderController
    {
        // Preload our schema..
        TBLDataOrder thisSchemaLoad = new TBLDataOrder();
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
        public TBLDataOrderCollection FetchAll()
        {
            TBLDataOrderCollection coll = new TBLDataOrderCollection();
            Query qry = new Query(TBLDataOrder.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public TBLDataOrderCollection FetchByID(object Orderid)
        {
            TBLDataOrderCollection coll = new TBLDataOrderCollection().Where("orderid", Orderid).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public TBLDataOrderCollection FetchByQuery(Query qry)
        {
            TBLDataOrderCollection coll = new TBLDataOrderCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object Orderid)
        {
            return (TBLDataOrder.Delete(Orderid) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object Orderid)
        {
            return (TBLDataOrder.Destroy(Orderid) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(string Khdh,DateTime? Trantime,DateTime? Jhrq,DateTime? Createtime,string Sldl,string Customername,string Txtz,string XhSyKh,string Pbcd,DateTime? Audittime,string Tzecode,string Scggdh,int? FlagDelete,int? OrderType)
	    {
		    TBLDataOrder item = new TBLDataOrder();
		    
            item.Khdh = Khdh;
            
            item.Trantime = Trantime;
            
            item.Jhrq = Jhrq;
            
            item.Createtime = Createtime;
            
            item.Sldl = Sldl;
            
            item.Customername = Customername;
            
            item.Txtz = Txtz;
            
            item.XhSyKh = XhSyKh;
            
            item.Pbcd = Pbcd;
            
            item.Audittime = Audittime;
            
            item.Tzecode = Tzecode;
            
            item.Scggdh = Scggdh;
            
            item.FlagDelete = FlagDelete;
            
            item.OrderType = OrderType;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(int Orderid,string Khdh,DateTime? Trantime,DateTime? Jhrq,DateTime? Createtime,string Sldl,string Customername,string Txtz,string XhSyKh,string Pbcd,DateTime? Audittime,string Tzecode,string Scggdh,int? FlagDelete,int? OrderType)
	    {
		    TBLDataOrder item = new TBLDataOrder();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.Orderid = Orderid;
				
			item.Khdh = Khdh;
				
			item.Trantime = Trantime;
				
			item.Jhrq = Jhrq;
				
			item.Createtime = Createtime;
				
			item.Sldl = Sldl;
				
			item.Customername = Customername;
				
			item.Txtz = Txtz;
				
			item.XhSyKh = XhSyKh;
				
			item.Pbcd = Pbcd;
				
			item.Audittime = Audittime;
				
			item.Tzecode = Tzecode;
				
			item.Scggdh = Scggdh;
				
			item.FlagDelete = FlagDelete;
				
			item.OrderType = OrderType;
				
	        item.Save(UserName);
	    }
    }
}
