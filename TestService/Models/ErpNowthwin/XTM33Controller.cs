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
    /// Controller class for XTM33
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class XTM33Controller
    {
        // Preload our schema..
        XTM33 thisSchemaLoad = new XTM33();
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
        public XTM33Collection FetchAll()
        {
            XTM33Collection coll = new XTM33Collection();
            Query qry = new Query(XTM33.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public XTM33Collection FetchByID(object Xtwpys)
        {
            XTM33Collection coll = new XTM33Collection().Where("XTWPYS", Xtwpys).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public XTM33Collection FetchByQuery(Query qry)
        {
            XTM33Collection coll = new XTM33Collection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object Xtwpys)
        {
            return (XTM33.Delete(Xtwpys) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object Xtwpys)
        {
            return (XTM33.Destroy(Xtwpys) == 1);
        }
        
        
        
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(string Xtwpys,string Sccpdl)
        {
            Query qry = new Query(XTM33.Schema);
            qry.QueryType = QueryType.Delete;
            qry.AddWhere("Xtwpys", Xtwpys).AND("Sccpdl", Sccpdl);
            qry.Execute();
            return (true);
        }        
       
    	
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(string Xtwpys,string Sccpdl,decimal? Wpxsdj)
	    {
		    XTM33 item = new XTM33();
		    
            item.Xtwpys = Xtwpys;
            
            item.Sccpdl = Sccpdl;
            
            item.Wpxsdj = Wpxsdj;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(string Xtwpys,string Sccpdl,decimal? Wpxsdj)
	    {
		    XTM33 item = new XTM33();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.Xtwpys = Xtwpys;
				
			item.Sccpdl = Sccpdl;
				
			item.Wpxsdj = Wpxsdj;
				
	        item.Save(UserName);
	    }
    }
}
