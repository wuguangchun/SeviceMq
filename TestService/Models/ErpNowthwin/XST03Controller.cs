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
    /// Controller class for XST03
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class XST03Controller
    {
        // Preload our schema..
        XST03 thisSchemaLoad = new XST03();
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
        public XST03Collection FetchAll()
        {
            XST03Collection coll = new XST03Collection();
            Query qry = new Query(XST03.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public XST03Collection FetchByID(object Xsthdh)
        {
            XST03Collection coll = new XST03Collection().Where("XSTHDH", Xsthdh).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public XST03Collection FetchByQuery(Query qry)
        {
            XST03Collection coll = new XST03Collection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object Xsthdh)
        {
            return (XST03.Delete(Xsthdh) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object Xsthdh)
        {
            return (XST03.Destroy(Xsthdh) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(string Scdzbz,string Xtxsdm,string Xthbdm,decimal? Xtdhhl,string Xsthdh,string Xtwldm,string Xtbmdm,string Xsxsdb,string Xsddhm,string Kcckdm,string Xsddth,string Xtjhdd,string Xsysfs,DateTime? Xsxqrq,decimal? Xstdze,DateTime? Xsthrq,decimal? Xskjnd,decimal? Xskjyf,string Xstdzt,string Xsthbz,string Xslrry,DateTime? Xslrrq,string Xsshry,DateTime? Xsshrq,string Xsxslx)
	    {
		    XST03 item = new XST03();
		    
            item.Scdzbz = Scdzbz;
            
            item.Xtxsdm = Xtxsdm;
            
            item.Xthbdm = Xthbdm;
            
            item.Xtdhhl = Xtdhhl;
            
            item.Xsthdh = Xsthdh;
            
            item.Xtwldm = Xtwldm;
            
            item.Xtbmdm = Xtbmdm;
            
            item.Xsxsdb = Xsxsdb;
            
            item.Xsddhm = Xsddhm;
            
            item.Kcckdm = Kcckdm;
            
            item.Xsddth = Xsddth;
            
            item.Xtjhdd = Xtjhdd;
            
            item.Xsysfs = Xsysfs;
            
            item.Xsxqrq = Xsxqrq;
            
            item.Xstdze = Xstdze;
            
            item.Xsthrq = Xsthrq;
            
            item.Xskjnd = Xskjnd;
            
            item.Xskjyf = Xskjyf;
            
            item.Xstdzt = Xstdzt;
            
            item.Xsthbz = Xsthbz;
            
            item.Xslrry = Xslrry;
            
            item.Xslrrq = Xslrrq;
            
            item.Xsshry = Xsshry;
            
            item.Xsshrq = Xsshrq;
            
            item.Xsxslx = Xsxslx;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(string Scdzbz,string Xtxsdm,string Xthbdm,decimal? Xtdhhl,string Xsthdh,string Xtwldm,string Xtbmdm,string Xsxsdb,string Xsddhm,string Kcckdm,string Xsddth,string Xtjhdd,string Xsysfs,DateTime? Xsxqrq,decimal? Xstdze,DateTime? Xsthrq,decimal? Xskjnd,decimal? Xskjyf,string Xstdzt,string Xsthbz,string Xslrry,DateTime? Xslrrq,string Xsshry,DateTime? Xsshrq,string Xsxslx)
	    {
		    XST03 item = new XST03();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.Scdzbz = Scdzbz;
				
			item.Xtxsdm = Xtxsdm;
				
			item.Xthbdm = Xthbdm;
				
			item.Xtdhhl = Xtdhhl;
				
			item.Xsthdh = Xsthdh;
				
			item.Xtwldm = Xtwldm;
				
			item.Xtbmdm = Xtbmdm;
				
			item.Xsxsdb = Xsxsdb;
				
			item.Xsddhm = Xsddhm;
				
			item.Kcckdm = Kcckdm;
				
			item.Xsddth = Xsddth;
				
			item.Xtjhdd = Xtjhdd;
				
			item.Xsysfs = Xsysfs;
				
			item.Xsxqrq = Xsxqrq;
				
			item.Xstdze = Xstdze;
				
			item.Xsthrq = Xsthrq;
				
			item.Xskjnd = Xskjnd;
				
			item.Xskjyf = Xskjyf;
				
			item.Xstdzt = Xstdzt;
				
			item.Xsthbz = Xsthbz;
				
			item.Xslrry = Xslrry;
				
			item.Xslrrq = Xslrrq;
				
			item.Xsshry = Xsshry;
				
			item.Xsshrq = Xsshrq;
				
			item.Xsxslx = Xsxslx;
				
	        item.Save(UserName);
	    }
    }
}
