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
    /// Controller class for XTM221
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class XTM221Controller
    {
        // Preload our schema..
        XTM221 thisSchemaLoad = new XTM221();
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
        public XTM221Collection FetchAll()
        {
            XTM221Collection coll = new XTM221Collection();
            Query qry = new Query(XTM221.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public XTM221Collection FetchByID(object Xtwpjb)
        {
            XTM221Collection coll = new XTM221Collection().Where("XTWPJB", Xtwpjb).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public XTM221Collection FetchByQuery(Query qry)
        {
            XTM221Collection coll = new XTM221Collection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object Xtwpjb)
        {
            return (XTM221.Delete(Xtwpjb) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object Xtwpjb)
        {
            return (XTM221.Destroy(Xtwpjb) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(decimal Xtwpjb,decimal? Xtjbqs,decimal? Xtjbzz,string Xtjbyy,string Xtjbsm)
	    {
		    XTM221 item = new XTM221();
		    
            item.Xtwpjb = Xtwpjb;
            
            item.Xtjbqs = Xtjbqs;
            
            item.Xtjbzz = Xtjbzz;
            
            item.Xtjbyy = Xtjbyy;
            
            item.Xtjbsm = Xtjbsm;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(decimal Xtwpjb,decimal? Xtjbqs,decimal? Xtjbzz,string Xtjbyy,string Xtjbsm)
	    {
		    XTM221 item = new XTM221();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.Xtwpjb = Xtwpjb;
				
			item.Xtjbqs = Xtjbqs;
				
			item.Xtjbzz = Xtjbzz;
				
			item.Xtjbyy = Xtjbyy;
				
			item.Xtjbsm = Xtjbsm;
				
	        item.Save(UserName);
	    }
    }
}
