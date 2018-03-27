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
    /// Controller class for SCT12
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class SCT12Controller
    {
        // Preload our schema..
        SCT12 thisSchemaLoad = new SCT12();
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
        public SCT12Collection FetchAll()
        {
            SCT12Collection coll = new SCT12Collection();
            Query qry = new Query(SCT12.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public SCT12Collection FetchByID(object Schtbh)
        {
            SCT12Collection coll = new SCT12Collection().Where("SCHTBH", Schtbh).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public SCT12Collection FetchByQuery(Query qry)
        {
            SCT12Collection coll = new SCT12Collection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object Schtbh)
        {
            return (SCT12.Delete(Schtbh) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object Schtbh)
        {
            return (SCT12.Destroy(Schtbh) == 1);
        }
        
        
        
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(string Schtbh,decimal Schtxh,decimal Scclxh)
        {
            Query qry = new Query(SCT12.Schema);
            qry.QueryType = QueryType.Delete;
            qry.AddWhere("Schtbh", Schtbh).AND("Schtxh", Schtxh).AND("Scclxh", Scclxh);
            qry.Execute();
            return (true);
        }        
       
    	
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(string Schtbh,decimal Schtxh,decimal Scclxh,string Scytdm,string Xttxhm,decimal? Scgxsl,string Scfddm,string Scjgbz)
	    {
		    SCT12 item = new SCT12();
		    
            item.Schtbh = Schtbh;
            
            item.Schtxh = Schtxh;
            
            item.Scclxh = Scclxh;
            
            item.Scytdm = Scytdm;
            
            item.Xttxhm = Xttxhm;
            
            item.Scgxsl = Scgxsl;
            
            item.Scfddm = Scfddm;
            
            item.Scjgbz = Scjgbz;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(string Schtbh,decimal Schtxh,decimal Scclxh,string Scytdm,string Xttxhm,decimal? Scgxsl,string Scfddm,string Scjgbz)
	    {
		    SCT12 item = new SCT12();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.Schtbh = Schtbh;
				
			item.Schtxh = Schtxh;
				
			item.Scclxh = Scclxh;
				
			item.Scytdm = Scytdm;
				
			item.Xttxhm = Xttxhm;
				
			item.Scgxsl = Scgxsl;
				
			item.Scfddm = Scfddm;
				
			item.Scjgbz = Scjgbz;
				
	        item.Save(UserName);
	    }
    }
}
