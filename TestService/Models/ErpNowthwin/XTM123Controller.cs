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
    /// Controller class for XTM123
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class XTM123Controller
    {
        // Preload our schema..
        XTM123 thisSchemaLoad = new XTM123();
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
        public XTM123Collection FetchAll()
        {
            XTM123Collection coll = new XTM123Collection();
            Query qry = new Query(XTM123.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public XTM123Collection FetchByID(object Wplbdm)
        {
            XTM123Collection coll = new XTM123Collection().Where("WPLBDM", Wplbdm).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public XTM123Collection FetchByQuery(Query qry)
        {
            XTM123Collection coll = new XTM123Collection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object Wplbdm)
        {
            return (XTM123.Delete(Wplbdm) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object Wplbdm)
        {
            return (XTM123.Destroy(Wplbdm) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(string Wplbdm,string Wplbmc,string Wpsxzd,string Sxqybz,string Sxxsbz)
	    {
		    XTM123 item = new XTM123();
		    
            item.Wplbdm = Wplbdm;
            
            item.Wplbmc = Wplbmc;
            
            item.Wpsxzd = Wpsxzd;
            
            item.Sxqybz = Sxqybz;
            
            item.Sxxsbz = Sxxsbz;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(string Wplbdm,string Wplbmc,string Wpsxzd,string Sxqybz,string Sxxsbz)
	    {
		    XTM123 item = new XTM123();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.Wplbdm = Wplbdm;
				
			item.Wplbmc = Wplbmc;
				
			item.Wpsxzd = Wpsxzd;
				
			item.Sxqybz = Sxqybz;
				
			item.Sxxsbz = Sxxsbz;
				
	        item.Save(UserName);
	    }
    }
}
