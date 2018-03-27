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
    /// Controller class for XTM16
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class XTM16Controller
    {
        // Preload our schema..
        XTM16 thisSchemaLoad = new XTM16();
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
        public XTM16Collection FetchAll()
        {
            XTM16Collection coll = new XTM16Collection();
            Query qry = new Query(XTM16.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public XTM16Collection FetchByID(object Xtdhhb)
        {
            XTM16Collection coll = new XTM16Collection().Where("XTDHHB", Xtdhhb).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public XTM16Collection FetchByQuery(Query qry)
        {
            XTM16Collection coll = new XTM16Collection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object Xtdhhb)
        {
            return (XTM16.Delete(Xtdhhb) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object Xtdhhb)
        {
            return (XTM16.Destroy(Xtdhhb) == 1);
        }
        
        
        
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(string Xtdhhb,string Xtdhbb,decimal Xtcznd,decimal Xtczyf)
        {
            Query qry = new Query(XTM16.Schema);
            qry.QueryType = QueryType.Delete;
            qry.AddWhere("Xtdhhb", Xtdhhb).AND("Xtdhbb", Xtdhbb).AND("Xtcznd", Xtcznd).AND("Xtczyf", Xtczyf);
            qry.Execute();
            return (true);
        }        
       
    	
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(string Xtdhhb,string Xtdhbb,decimal Xtcznd,decimal Xtczyf,decimal? Xtdhhl)
	    {
		    XTM16 item = new XTM16();
		    
            item.Xtdhhb = Xtdhhb;
            
            item.Xtdhbb = Xtdhbb;
            
            item.Xtcznd = Xtcznd;
            
            item.Xtczyf = Xtczyf;
            
            item.Xtdhhl = Xtdhhl;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(string Xtdhhb,string Xtdhbb,decimal Xtcznd,decimal Xtczyf,decimal? Xtdhhl)
	    {
		    XTM16 item = new XTM16();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.Xtdhhb = Xtdhhb;
				
			item.Xtdhbb = Xtdhbb;
				
			item.Xtcznd = Xtcznd;
				
			item.Xtczyf = Xtczyf;
				
			item.Xtdhhl = Xtdhhl;
				
	        item.Save(UserName);
	    }
    }
}
