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
    /// Controller class for XTM125
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class XTM125Controller
    {
        // Preload our schema..
        XTM125 thisSchemaLoad = new XTM125();
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
        public XTM125Collection FetchAll()
        {
            XTM125Collection coll = new XTM125Collection();
            Query qry = new Query(XTM125.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public XTM125Collection FetchByID(object Sn)
        {
            XTM125Collection coll = new XTM125Collection().Where("SN", Sn).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public XTM125Collection FetchByQuery(Query qry)
        {
            XTM125Collection coll = new XTM125Collection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object Sn)
        {
            return (XTM125.Delete(Sn) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object Sn)
        {
            return (XTM125.Destroy(Sn) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(string Old,string Pp,string Dl,string Nd,string Ls,string Ml,string Cm,string NEW1,string Mc,string Jldw,decimal? Wphsjg,decimal? Wpxsdj,decimal? Sl,string Kcckdm,decimal Sn)
	    {
		    XTM125 item = new XTM125();
		    
            item.Old = Old;
            
            item.Pp = Pp;
            
            item.Dl = Dl;
            
            item.Nd = Nd;
            
            item.Ls = Ls;
            
            item.Ml = Ml;
            
            item.Cm = Cm;
            
            item.NEW1 = NEW1;
            
            item.Mc = Mc;
            
            item.Jldw = Jldw;
            
            item.Wphsjg = Wphsjg;
            
            item.Wpxsdj = Wpxsdj;
            
            item.Sl = Sl;
            
            item.Kcckdm = Kcckdm;
            
            item.Sn = Sn;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(string Old,string Pp,string Dl,string Nd,string Ls,string Ml,string Cm,string NEW1,string Mc,string Jldw,decimal? Wphsjg,decimal? Wpxsdj,decimal? Sl,string Kcckdm,decimal Sn)
	    {
		    XTM125 item = new XTM125();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.Old = Old;
				
			item.Pp = Pp;
				
			item.Dl = Dl;
				
			item.Nd = Nd;
				
			item.Ls = Ls;
				
			item.Ml = Ml;
				
			item.Cm = Cm;
				
			item.NEW1 = NEW1;
				
			item.Mc = Mc;
				
			item.Jldw = Jldw;
				
			item.Wphsjg = Wphsjg;
				
			item.Wpxsdj = Wpxsdj;
				
			item.Sl = Sl;
				
			item.Kcckdm = Kcckdm;
				
			item.Sn = Sn;
				
	        item.Save(UserName);
	    }
    }
}
