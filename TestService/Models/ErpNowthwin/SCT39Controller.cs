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
    /// Controller class for SCT39
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class SCT39Controller
    {
        // Preload our schema..
        SCT39 thisSchemaLoad = new SCT39();
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
        public SCT39Collection FetchAll()
        {
            SCT39Collection coll = new SCT39Collection();
            Query qry = new Query(SCT39.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public SCT39Collection FetchByID(object Schtbh)
        {
            SCT39Collection coll = new SCT39Collection().Where("SCHTBH", Schtbh).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public SCT39Collection FetchByQuery(Query qry)
        {
            SCT39Collection coll = new SCT39Collection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object Schtbh)
        {
            return (SCT39.Delete(Schtbh) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object Schtbh)
        {
            return (SCT39.Destroy(Schtbh) == 1);
        }
        
        
        
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(string Schtbh,string Xttxhm)
        {
            Query qry = new Query(SCT39.Schema);
            qry.QueryType = QueryType.Delete;
            qry.AddWhere("Schtbh", Schtbh).AND("Xttxhm", Xttxhm);
            qry.Execute();
            return (true);
        }        
       
    	
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(string Schtbh,string Xttxhm,decimal? Sczysl)
	    {
		    SCT39 item = new SCT39();
		    
            item.Schtbh = Schtbh;
            
            item.Xttxhm = Xttxhm;
            
            item.Sczysl = Sczysl;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(string Schtbh,string Xttxhm,decimal? Sczysl)
	    {
		    SCT39 item = new SCT39();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.Schtbh = Schtbh;
				
			item.Xttxhm = Xttxhm;
				
			item.Sczysl = Sczysl;
				
	        item.Save(UserName);
	    }
    }
}
