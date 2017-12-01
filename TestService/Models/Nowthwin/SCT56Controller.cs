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
    /// Controller class for SCT56
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class SCT56Controller
    {
        // Preload our schema..
        SCT56 thisSchemaLoad = new SCT56();
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
        public SCT56Collection FetchAll()
        {
            SCT56Collection coll = new SCT56Collection();
            Query qry = new Query(SCT56.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public SCT56Collection FetchByID(object Schtbh)
        {
            SCT56Collection coll = new SCT56Collection().Where("SCHTBH", Schtbh).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public SCT56Collection FetchByQuery(Query qry)
        {
            SCT56Collection coll = new SCT56Collection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object Schtbh)
        {
            return (SCT56.Delete(Schtbh) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object Schtbh)
        {
            return (SCT56.Destroy(Schtbh) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(string Schtbh,string Schtzt,string Xtyhdm)
	    {
		    SCT56 item = new SCT56();
		    
            item.Schtbh = Schtbh;
            
            item.Schtzt = Schtzt;
            
            item.Xtyhdm = Xtyhdm;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(string Schtbh,string Schtzt,string Xtyhdm)
	    {
		    SCT56 item = new SCT56();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.Schtbh = Schtbh;
				
			item.Schtzt = Schtzt;
				
			item.Xtyhdm = Xtyhdm;
				
	        item.Save(UserName);
	    }
    }
}
