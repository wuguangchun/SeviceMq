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
    /// Controller class for XTT00
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class XTT00Controller
    {
        // Preload our schema..
        XTT00 thisSchemaLoad = new XTT00();
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
        public XTT00Collection FetchAll()
        {
            XTT00Collection coll = new XTT00Collection();
            Query qry = new Query(XTT00.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public XTT00Collection FetchByID(object Xtjqhm)
        {
            XTT00Collection coll = new XTT00Collection().Where("XTJQHM", Xtjqhm).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public XTT00Collection FetchByQuery(Query qry)
        {
            XTT00Collection coll = new XTT00Collection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object Xtjqhm)
        {
            return (XTT00.Delete(Xtjqhm) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object Xtjqhm)
        {
            return (XTT00.Destroy(Xtjqhm) == 1);
        }
        
        
        
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(string Xtjqhm,string Xtcsfx)
        {
            Query qry = new Query(XTT00.Schema);
            qry.QueryType = QueryType.Delete;
            qry.AddWhere("Xtjqhm", Xtjqhm).AND("Xtcsfx", Xtcsfx);
            qry.Execute();
            return (true);
        }        
       
    	
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(string Xtjqhm,string Xtcsfx)
	    {
		    XTT00 item = new XTT00();
		    
            item.Xtjqhm = Xtjqhm;
            
            item.Xtcsfx = Xtcsfx;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(string Xtjqhm,string Xtcsfx)
	    {
		    XTT00 item = new XTT00();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.Xtjqhm = Xtjqhm;
				
			item.Xtcsfx = Xtcsfx;
				
	        item.Save(UserName);
	    }
    }
}
