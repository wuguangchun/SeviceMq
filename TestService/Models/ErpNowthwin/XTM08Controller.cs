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
    /// Controller class for XTM08
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class XTM08Controller
    {
        // Preload our schema..
        XTM08 thisSchemaLoad = new XTM08();
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
        public XTM08Collection FetchAll()
        {
            XTM08Collection coll = new XTM08Collection();
            Query qry = new Query(XTM08.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public XTM08Collection FetchByID(object Xtyhdm)
        {
            XTM08Collection coll = new XTM08Collection().Where("XTYHDM", Xtyhdm).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public XTM08Collection FetchByQuery(Query qry)
        {
            XTM08Collection coll = new XTM08Collection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object Xtyhdm)
        {
            return (XTM08.Delete(Xtyhdm) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object Xtyhdm)
        {
            return (XTM08.Destroy(Xtyhdm) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(string Xttybz,DateTime? Bmscsj,string Wlzybz,string Xtyhdm,string Xtyhxm,string Xtzgdm,string Xtyhmm,string Xtcjbz,string Xtcbqx)
	    {
		    XTM08 item = new XTM08();
		    
            item.Xttybz = Xttybz;
            
            item.Bmscsj = Bmscsj;
            
            item.Wlzybz = Wlzybz;
            
            item.Xtyhdm = Xtyhdm;
            
            item.Xtyhxm = Xtyhxm;
            
            item.Xtzgdm = Xtzgdm;
            
            item.Xtyhmm = Xtyhmm;
            
            item.Xtcjbz = Xtcjbz;
            
            item.Xtcbqx = Xtcbqx;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(string Xttybz,DateTime? Bmscsj,string Wlzybz,string Xtyhdm,string Xtyhxm,string Xtzgdm,string Xtyhmm,string Xtcjbz,string Xtcbqx)
	    {
		    XTM08 item = new XTM08();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.Xttybz = Xttybz;
				
			item.Bmscsj = Bmscsj;
				
			item.Wlzybz = Wlzybz;
				
			item.Xtyhdm = Xtyhdm;
				
			item.Xtyhxm = Xtyhxm;
				
			item.Xtzgdm = Xtzgdm;
				
			item.Xtyhmm = Xtyhmm;
				
			item.Xtcjbz = Xtcjbz;
				
			item.Xtcbqx = Xtcbqx;
				
	        item.Save(UserName);
	    }
    }
}
