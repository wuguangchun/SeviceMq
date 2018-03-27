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
    /// Controller class for SCT13
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class SCT13Controller
    {
        // Preload our schema..
        SCT13 thisSchemaLoad = new SCT13();
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
        public SCT13Collection FetchAll()
        {
            SCT13Collection coll = new SCT13Collection();
            Query qry = new Query(SCT13.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public SCT13Collection FetchByID(object Schtbh)
        {
            SCT13Collection coll = new SCT13Collection().Where("SCHTBH", Schtbh).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public SCT13Collection FetchByQuery(Query qry)
        {
            SCT13Collection coll = new SCT13Collection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object Schtbh)
        {
            return (SCT13.Delete(Schtbh) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object Schtbh)
        {
            return (SCT13.Destroy(Schtbh) == 1);
        }
        
        
        
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(string Schtbh,decimal Schtxh,string Xtwpys,string Xtwpks,decimal Scclxh,string Xtxmdm)
        {
            Query qry = new Query(SCT13.Schema);
            qry.QueryType = QueryType.Delete;
            qry.AddWhere("Schtbh", Schtbh).AND("Schtxh", Schtxh).AND("Xtwpys", Xtwpys).AND("Xtwpks", Xtwpks).AND("Scclxh", Scclxh).AND("Xtxmdm", Xtxmdm);
            qry.Execute();
            return (true);
        }        
       
    	
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(string Schtbh,decimal Schtxh,string Xtwpys,string Xtwpks,decimal Scclxh,string Xtxmdm,decimal? Scgxsl)
	    {
		    SCT13 item = new SCT13();
		    
            item.Schtbh = Schtbh;
            
            item.Schtxh = Schtxh;
            
            item.Xtwpys = Xtwpys;
            
            item.Xtwpks = Xtwpks;
            
            item.Scclxh = Scclxh;
            
            item.Xtxmdm = Xtxmdm;
            
            item.Scgxsl = Scgxsl;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(string Schtbh,decimal Schtxh,string Xtwpys,string Xtwpks,decimal Scclxh,string Xtxmdm,decimal? Scgxsl)
	    {
		    SCT13 item = new SCT13();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.Schtbh = Schtbh;
				
			item.Schtxh = Schtxh;
				
			item.Xtwpys = Xtwpys;
				
			item.Xtwpks = Xtwpks;
				
			item.Scclxh = Scclxh;
				
			item.Xtxmdm = Xtxmdm;
				
			item.Scgxsl = Scgxsl;
				
	        item.Save(UserName);
	    }
    }
}
