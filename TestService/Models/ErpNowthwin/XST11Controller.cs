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
    /// Controller class for XST11
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class XST11Controller
    {
        // Preload our schema..
        XST11 thisSchemaLoad = new XST11();
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
        public XST11Collection FetchAll()
        {
            XST11Collection coll = new XST11Collection();
            Query qry = new Query(XST11.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public XST11Collection FetchByID(object Xsfyhm)
        {
            XST11Collection coll = new XST11Collection().Where("XSFYHM", Xsfyhm).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public XST11Collection FetchByQuery(Query qry)
        {
            XST11Collection coll = new XST11Collection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object Xsfyhm)
        {
            return (XST11.Delete(Xsfyhm) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object Xsfyhm)
        {
            return (XST11.Destroy(Xsfyhm) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(string Xsfyhm,string Xtjsfs,string Xtwldm,string Xtbmdm,decimal? Xsfyje,DateTime? Xsfyrq,decimal? Xskjnd,decimal? Xskjyf,string Xszphm,string Xsfylx,string Xsfyzt,string Xslrry,DateTime? Xslrrq,string Xsshry,DateTime? Xsshrq,string Xsfybz)
	    {
		    XST11 item = new XST11();
		    
            item.Xsfyhm = Xsfyhm;
            
            item.Xtjsfs = Xtjsfs;
            
            item.Xtwldm = Xtwldm;
            
            item.Xtbmdm = Xtbmdm;
            
            item.Xsfyje = Xsfyje;
            
            item.Xsfyrq = Xsfyrq;
            
            item.Xskjnd = Xskjnd;
            
            item.Xskjyf = Xskjyf;
            
            item.Xszphm = Xszphm;
            
            item.Xsfylx = Xsfylx;
            
            item.Xsfyzt = Xsfyzt;
            
            item.Xslrry = Xslrry;
            
            item.Xslrrq = Xslrrq;
            
            item.Xsshry = Xsshry;
            
            item.Xsshrq = Xsshrq;
            
            item.Xsfybz = Xsfybz;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(string Xsfyhm,string Xtjsfs,string Xtwldm,string Xtbmdm,decimal? Xsfyje,DateTime? Xsfyrq,decimal? Xskjnd,decimal? Xskjyf,string Xszphm,string Xsfylx,string Xsfyzt,string Xslrry,DateTime? Xslrrq,string Xsshry,DateTime? Xsshrq,string Xsfybz)
	    {
		    XST11 item = new XST11();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.Xsfyhm = Xsfyhm;
				
			item.Xtjsfs = Xtjsfs;
				
			item.Xtwldm = Xtwldm;
				
			item.Xtbmdm = Xtbmdm;
				
			item.Xsfyje = Xsfyje;
				
			item.Xsfyrq = Xsfyrq;
				
			item.Xskjnd = Xskjnd;
				
			item.Xskjyf = Xskjyf;
				
			item.Xszphm = Xszphm;
				
			item.Xsfylx = Xsfylx;
				
			item.Xsfyzt = Xsfyzt;
				
			item.Xslrry = Xslrry;
				
			item.Xslrrq = Xslrrq;
				
			item.Xsshry = Xsshry;
				
			item.Xsshrq = Xsshrq;
				
			item.Xsfybz = Xsfybz;
				
	        item.Save(UserName);
	    }
    }
}
