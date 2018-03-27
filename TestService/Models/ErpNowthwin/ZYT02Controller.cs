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
    /// Controller class for ZYT02
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class ZYT02Controller
    {
        // Preload our schema..
        ZYT02 thisSchemaLoad = new ZYT02();
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
        public ZYT02Collection FetchAll()
        {
            ZYT02Collection coll = new ZYT02Collection();
            Query qry = new Query(ZYT02.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public ZYT02Collection FetchByID(object Xtczxh)
        {
            ZYT02Collection coll = new ZYT02Collection().Where("XTCZXH", Xtczxh).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public ZYT02Collection FetchByQuery(Query qry)
        {
            ZYT02Collection coll = new ZYT02Collection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object Xtczxh)
        {
            return (ZYT02.Delete(Xtczxh) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object Xtczxh)
        {
            return (ZYT02.Destroy(Xtczxh) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(string Schtbh,string Scyspd,decimal Xtczxh,string Xtlybz,string Xtyhdm,string Xttxhm,string Xtjldw,decimal? Xtzysl,decimal? Xtcxsl,string Xtzysj,string Xtsfsj,string Xtxxzt,string Xtzybz)
	    {
		    ZYT02 item = new ZYT02();
		    
            item.Schtbh = Schtbh;
            
            item.Scyspd = Scyspd;
            
            item.Xtczxh = Xtczxh;
            
            item.Xtlybz = Xtlybz;
            
            item.Xtyhdm = Xtyhdm;
            
            item.Xttxhm = Xttxhm;
            
            item.Xtjldw = Xtjldw;
            
            item.Xtzysl = Xtzysl;
            
            item.Xtcxsl = Xtcxsl;
            
            item.Xtzysj = Xtzysj;
            
            item.Xtsfsj = Xtsfsj;
            
            item.Xtxxzt = Xtxxzt;
            
            item.Xtzybz = Xtzybz;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(string Schtbh,string Scyspd,decimal Xtczxh,string Xtlybz,string Xtyhdm,string Xttxhm,string Xtjldw,decimal? Xtzysl,decimal? Xtcxsl,string Xtzysj,string Xtsfsj,string Xtxxzt,string Xtzybz)
	    {
		    ZYT02 item = new ZYT02();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.Schtbh = Schtbh;
				
			item.Scyspd = Scyspd;
				
			item.Xtczxh = Xtczxh;
				
			item.Xtlybz = Xtlybz;
				
			item.Xtyhdm = Xtyhdm;
				
			item.Xttxhm = Xttxhm;
				
			item.Xtjldw = Xtjldw;
				
			item.Xtzysl = Xtzysl;
				
			item.Xtcxsl = Xtcxsl;
				
			item.Xtzysj = Xtzysj;
				
			item.Xtsfsj = Xtsfsj;
				
			item.Xtxxzt = Xtxxzt;
				
			item.Xtzybz = Xtzybz;
				
	        item.Save(UserName);
	    }
    }
}
