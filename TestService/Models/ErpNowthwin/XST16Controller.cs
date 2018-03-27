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
    /// Controller class for XST16
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class XST16Controller
    {
        // Preload our schema..
        XST16 thisSchemaLoad = new XST16();
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
        public XST16Collection FetchAll()
        {
            XST16Collection coll = new XST16Collection();
            Query qry = new Query(XST16.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public XST16Collection FetchByID(object Xsdpxh)
        {
            XST16Collection coll = new XST16Collection().Where("XSDPXH", Xsdpxh).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public XST16Collection FetchByQuery(Query qry)
        {
            XST16Collection coll = new XST16Collection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object Xsdpxh)
        {
            return (XST16.Delete(Xsdpxh) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object Xsdpxh)
        {
            return (XST16.Destroy(Xsdpxh) == 1);
        }
        
        
        
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(decimal Xsdpxh,string Xscphm,string Xsdjlx,string Xsphdh)
        {
            Query qry = new Query(XST16.Schema);
            qry.QueryType = QueryType.Delete;
            qry.AddWhere("Xsdpxh", Xsdpxh).AND("Xscphm", Xscphm).AND("Xsdjlx", Xsdjlx).AND("Xsphdh", Xsphdh);
            qry.Execute();
            return (true);
        }        
       
    	
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(decimal Xsdpxh,string Xscphm,string Xsdjlx,string Xsphdh,string Xsjqbz,string Xsjsry,string Xsqrbz,string Xslxdm,string Xspcry,DateTime? Xspcrq)
	    {
		    XST16 item = new XST16();
		    
            item.Xsdpxh = Xsdpxh;
            
            item.Xscphm = Xscphm;
            
            item.Xsdjlx = Xsdjlx;
            
            item.Xsphdh = Xsphdh;
            
            item.Xsjqbz = Xsjqbz;
            
            item.Xsjsry = Xsjsry;
            
            item.Xsqrbz = Xsqrbz;
            
            item.Xslxdm = Xslxdm;
            
            item.Xspcry = Xspcry;
            
            item.Xspcrq = Xspcrq;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(decimal Xsdpxh,string Xscphm,string Xsdjlx,string Xsphdh,string Xsjqbz,string Xsjsry,string Xsqrbz,string Xslxdm,string Xspcry,DateTime? Xspcrq)
	    {
		    XST16 item = new XST16();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.Xsdpxh = Xsdpxh;
				
			item.Xscphm = Xscphm;
				
			item.Xsdjlx = Xsdjlx;
				
			item.Xsphdh = Xsphdh;
				
			item.Xsjqbz = Xsjqbz;
				
			item.Xsjsry = Xsjsry;
				
			item.Xsqrbz = Xsqrbz;
				
			item.Xslxdm = Xslxdm;
				
			item.Xspcry = Xspcry;
				
			item.Xspcrq = Xspcrq;
				
	        item.Save(UserName);
	    }
    }
}
