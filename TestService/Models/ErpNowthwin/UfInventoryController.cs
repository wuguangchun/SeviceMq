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
namespace OracleDataDomain
{
    /// <summary>
    /// Controller class for UF_INVENTORY
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class UfInventoryController
    {
        // Preload our schema..
        UfInventory thisSchemaLoad = new UfInventory();
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
        public UfInventoryCollection FetchAll()
        {
            UfInventoryCollection coll = new UfInventoryCollection();
            Query qry = new Query(UfInventory.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public UfInventoryCollection FetchByID(object Autoid)
        {
            UfInventoryCollection coll = new UfInventoryCollection().Where("AUTOID", Autoid).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public UfInventoryCollection FetchByQuery(Query qry)
        {
            UfInventoryCollection coll = new UfInventoryCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object Autoid)
        {
            return (UfInventory.Delete(Autoid) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object Autoid)
        {
            return (UfInventory.Destroy(Autoid) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(decimal Autoid,string Cinvcode,string Cinvname,string Cinvstd,string Ccomunitname,string Cinvccode,string Bpurchase,string Bcomsume,string Bself,string Bsale,string Optype,DateTime Createdate,decimal Status,DateTime? Exedate)
	    {
		    UfInventory item = new UfInventory();
		    
            item.Autoid = Autoid;
            
            item.Cinvcode = Cinvcode;
            
            item.Cinvname = Cinvname;
            
            item.Cinvstd = Cinvstd;
            
            item.Ccomunitname = Ccomunitname;
            
            item.Cinvccode = Cinvccode;
            
            item.Bpurchase = Bpurchase;
            
            item.Bcomsume = Bcomsume;
            
            item.Bself = Bself;
            
            item.Bsale = Bsale;
            
            item.Optype = Optype;
            
            item.Createdate = Createdate;
            
            item.Status = Status;
            
            item.Exedate = Exedate;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(decimal Autoid,string Cinvcode,string Cinvname,string Cinvstd,string Ccomunitname,string Cinvccode,string Bpurchase,string Bcomsume,string Bself,string Bsale,string Optype,DateTime Createdate,decimal Status,DateTime? Exedate)
	    {
		    UfInventory item = new UfInventory();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.Autoid = Autoid;
				
			item.Cinvcode = Cinvcode;
				
			item.Cinvname = Cinvname;
				
			item.Cinvstd = Cinvstd;
				
			item.Ccomunitname = Ccomunitname;
				
			item.Cinvccode = Cinvccode;
				
			item.Bpurchase = Bpurchase;
				
			item.Bcomsume = Bcomsume;
				
			item.Bself = Bself;
				
			item.Bsale = Bsale;
				
			item.Optype = Optype;
				
			item.Createdate = Createdate;
				
			item.Status = Status;
				
			item.Exedate = Exedate;
				
	        item.Save(UserName);
	    }
    }
}
