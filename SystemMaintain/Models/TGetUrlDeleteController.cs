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
    /// Controller class for T_getUrl_delete
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class TGetUrlDeleteController
    {
        // Preload our schema..
        TGetUrlDelete thisSchemaLoad = new TGetUrlDelete();
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
        public TGetUrlDeleteCollection FetchAll()
        {
            TGetUrlDeleteCollection coll = new TGetUrlDeleteCollection();
            Query qry = new Query(TGetUrlDelete.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public TGetUrlDeleteCollection FetchByID(object PkId)
        {
            TGetUrlDeleteCollection coll = new TGetUrlDeleteCollection().Where("pkId", PkId).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public TGetUrlDeleteCollection FetchByQuery(Query qry)
        {
            TGetUrlDeleteCollection coll = new TGetUrlDeleteCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object PkId)
        {
            return (TGetUrlDelete.Delete(PkId) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object PkId)
        {
            return (TGetUrlDelete.Destroy(PkId) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(string Name,string Url)
	    {
		    TGetUrlDelete item = new TGetUrlDelete();
		    
            item.Name = Name;
            
            item.Url = Url;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(int PkId,string Name,string Url)
	    {
		    TGetUrlDelete item = new TGetUrlDelete();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.PkId = PkId;
				
			item.Name = Name;
				
			item.Url = Url;
				
	        item.Save(UserName);
	    }
    }
}
