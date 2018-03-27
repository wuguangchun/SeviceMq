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
    /// Controller class for XSM08
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class XSM08Controller
    {
        // Preload our schema..
        XSM08 thisSchemaLoad = new XSM08();
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
        public XSM08Collection FetchAll()
        {
            XSM08Collection coll = new XSM08Collection();
            Query qry = new Query(XSM08.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public XSM08Collection FetchByID(object Xtbmdm)
        {
            XSM08Collection coll = new XSM08Collection().Where("XTBMDM", Xtbmdm).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public XSM08Collection FetchByQuery(Query qry)
        {
            XSM08Collection coll = new XSM08Collection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object Xtbmdm)
        {
            return (XSM08.Delete(Xtbmdm) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object Xtbmdm)
        {
            return (XSM08.Destroy(Xtbmdm) == 1);
        }
        
        
        
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(string Xtbmdm,decimal Xsxsxh)
        {
            Query qry = new Query(XSM08.Schema);
            qry.QueryType = QueryType.Delete;
            qry.AddWhere("Xtbmdm", Xtbmdm).AND("Xsxsxh", Xsxsxh);
            qry.Execute();
            return (true);
        }        
       
    	
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(string Xtbmdm,decimal Xsxsxh,decimal? Xsqsje,decimal? Xsjzje,decimal? Xstcxs)
	    {
		    XSM08 item = new XSM08();
		    
            item.Xtbmdm = Xtbmdm;
            
            item.Xsxsxh = Xsxsxh;
            
            item.Xsqsje = Xsqsje;
            
            item.Xsjzje = Xsjzje;
            
            item.Xstcxs = Xstcxs;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(string Xtbmdm,decimal Xsxsxh,decimal? Xsqsje,decimal? Xsjzje,decimal? Xstcxs)
	    {
		    XSM08 item = new XSM08();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.Xtbmdm = Xtbmdm;
				
			item.Xsxsxh = Xsxsxh;
				
			item.Xsqsje = Xsqsje;
				
			item.Xsjzje = Xsjzje;
				
			item.Xstcxs = Xstcxs;
				
	        item.Save(UserName);
	    }
    }
}
