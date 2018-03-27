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
    /// Controller class for XST19
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class XST19Controller
    {
        // Preload our schema..
        XST19 thisSchemaLoad = new XST19();
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
        public XST19Collection FetchAll()
        {
            XST19Collection coll = new XST19Collection();
            Query qry = new Query(XST19.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public XST19Collection FetchByID(object Kcczxh)
        {
            XST19Collection coll = new XST19Collection().Where("KCCZXH", Kcczxh).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public XST19Collection FetchByQuery(Query qry)
        {
            XST19Collection coll = new XST19Collection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object Kcczxh)
        {
            return (XST19.Delete(Kcczxh) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object Kcczxh)
        {
            return (XST19.Destroy(Kcczxh) == 1);
        }
        
        
        
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(decimal Kcczxh,decimal Kckjyf,decimal Kckjnd,decimal Kcczhh)
        {
            Query qry = new Query(XST19.Schema);
            qry.QueryType = QueryType.Delete;
            qry.AddWhere("Kcczxh", Kcczxh).AND("Kckjyf", Kckjyf).AND("Kckjnd", Kckjnd).AND("Kcczhh", Kcczhh);
            qry.Execute();
            return (true);
        }        
       
    	
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(string Biaosh,decimal Kcczxh,decimal Kckjyf,decimal Kckjnd,decimal Kcczhh,string Kcckdh,string Kcckdm,string Xtbmdm,string Xsphdh,string Xtwpdm,decimal? Xsphsl,string Xtjldw,string Xtysfs,DateTime? Xsfhrq,DateTime? Xsyjdh,string Kcshck,decimal? Xsphhh,string Xsthbz,decimal? Xsfhdj,decimal? Xsfhje,string Xsyhdh,decimal? Xsfhzk,string Scggdh,decimal? Scggxh)
	    {
		    XST19 item = new XST19();
		    
            item.Biaosh = Biaosh;
            
            item.Kcczxh = Kcczxh;
            
            item.Kckjyf = Kckjyf;
            
            item.Kckjnd = Kckjnd;
            
            item.Kcczhh = Kcczhh;
            
            item.Kcckdh = Kcckdh;
            
            item.Kcckdm = Kcckdm;
            
            item.Xtbmdm = Xtbmdm;
            
            item.Xsphdh = Xsphdh;
            
            item.Xtwpdm = Xtwpdm;
            
            item.Xsphsl = Xsphsl;
            
            item.Xtjldw = Xtjldw;
            
            item.Xtysfs = Xtysfs;
            
            item.Xsfhrq = Xsfhrq;
            
            item.Xsyjdh = Xsyjdh;
            
            item.Kcshck = Kcshck;
            
            item.Xsphhh = Xsphhh;
            
            item.Xsthbz = Xsthbz;
            
            item.Xsfhdj = Xsfhdj;
            
            item.Xsfhje = Xsfhje;
            
            item.Xsyhdh = Xsyhdh;
            
            item.Xsfhzk = Xsfhzk;
            
            item.Scggdh = Scggdh;
            
            item.Scggxh = Scggxh;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(string Biaosh,decimal Kcczxh,decimal Kckjyf,decimal Kckjnd,decimal Kcczhh,string Kcckdh,string Kcckdm,string Xtbmdm,string Xsphdh,string Xtwpdm,decimal? Xsphsl,string Xtjldw,string Xtysfs,DateTime? Xsfhrq,DateTime? Xsyjdh,string Kcshck,decimal? Xsphhh,string Xsthbz,decimal? Xsfhdj,decimal? Xsfhje,string Xsyhdh,decimal? Xsfhzk,string Scggdh,decimal? Scggxh)
	    {
		    XST19 item = new XST19();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.Biaosh = Biaosh;
				
			item.Kcczxh = Kcczxh;
				
			item.Kckjyf = Kckjyf;
				
			item.Kckjnd = Kckjnd;
				
			item.Kcczhh = Kcczhh;
				
			item.Kcckdh = Kcckdh;
				
			item.Kcckdm = Kcckdm;
				
			item.Xtbmdm = Xtbmdm;
				
			item.Xsphdh = Xsphdh;
				
			item.Xtwpdm = Xtwpdm;
				
			item.Xsphsl = Xsphsl;
				
			item.Xtjldw = Xtjldw;
				
			item.Xtysfs = Xtysfs;
				
			item.Xsfhrq = Xsfhrq;
				
			item.Xsyjdh = Xsyjdh;
				
			item.Kcshck = Kcshck;
				
			item.Xsphhh = Xsphhh;
				
			item.Xsthbz = Xsthbz;
				
			item.Xsfhdj = Xsfhdj;
				
			item.Xsfhje = Xsfhje;
				
			item.Xsyhdh = Xsyhdh;
				
			item.Xsfhzk = Xsfhzk;
				
			item.Scggdh = Scggdh;
				
			item.Scggxh = Scggxh;
				
	        item.Save(UserName);
	    }
    }
}
