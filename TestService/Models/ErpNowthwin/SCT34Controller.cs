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
    /// Controller class for SCT34
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class SCT34Controller
    {
        // Preload our schema..
        SCT34 thisSchemaLoad = new SCT34();
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
        public SCT34Collection FetchAll()
        {
            SCT34Collection coll = new SCT34Collection();
            Query qry = new Query(SCT34.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public SCT34Collection FetchByID(object Schtbh)
        {
            SCT34Collection coll = new SCT34Collection().Where("SCHTBH", Schtbh).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public SCT34Collection FetchByQuery(Query qry)
        {
            SCT34Collection coll = new SCT34Collection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object Schtbh)
        {
            return (SCT34.Delete(Schtbh) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object Schtbh)
        {
            return (SCT34.Destroy(Schtbh) == 1);
        }
        
        
        
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(string Schtbh,decimal Scglxh)
        {
            Query qry = new Query(SCT34.Schema);
            qry.QueryType = QueryType.Delete;
            qry.AddWhere("Schtbh", Schtbh).AND("Scglxh", Scglxh);
            qry.Execute();
            return (true);
        }        
       
    	
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(string Schtbh,decimal Scglxh,string Scclsm,string Scclgg,string Scclcf,string Scclys,string Xttxhm,decimal? Scglsl,DateTime? Scdhrq,string Scglbz)
	    {
		    SCT34 item = new SCT34();
		    
            item.Schtbh = Schtbh;
            
            item.Scglxh = Scglxh;
            
            item.Scclsm = Scclsm;
            
            item.Scclgg = Scclgg;
            
            item.Scclcf = Scclcf;
            
            item.Scclys = Scclys;
            
            item.Xttxhm = Xttxhm;
            
            item.Scglsl = Scglsl;
            
            item.Scdhrq = Scdhrq;
            
            item.Scglbz = Scglbz;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(string Schtbh,decimal Scglxh,string Scclsm,string Scclgg,string Scclcf,string Scclys,string Xttxhm,decimal? Scglsl,DateTime? Scdhrq,string Scglbz)
	    {
		    SCT34 item = new SCT34();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.Schtbh = Schtbh;
				
			item.Scglxh = Scglxh;
				
			item.Scclsm = Scclsm;
				
			item.Scclgg = Scclgg;
				
			item.Scclcf = Scclcf;
				
			item.Scclys = Scclys;
				
			item.Xttxhm = Xttxhm;
				
			item.Scglsl = Scglsl;
				
			item.Scdhrq = Scdhrq;
				
			item.Scglbz = Scglbz;
				
	        item.Save(UserName);
	    }
    }
}
