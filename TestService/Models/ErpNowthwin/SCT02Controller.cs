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
    /// Controller class for SCT02
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class SCT02Controller
    {
        // Preload our schema..
        SCT02 thisSchemaLoad = new SCT02();
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
        public SCT02Collection FetchAll()
        {
            SCT02Collection coll = new SCT02Collection();
            Query qry = new Query(SCT02.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public SCT02Collection FetchByID(object Xtwpks)
        {
            SCT02Collection coll = new SCT02Collection().Where("XTWPKS", Xtwpks).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public SCT02Collection FetchByQuery(Query qry)
        {
            SCT02Collection coll = new SCT02Collection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object Xtwpks)
        {
            return (SCT02.Delete(Xtwpks) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object Xtwpks)
        {
            return (SCT02.Destroy(Xtwpks) == 1);
        }
        
        
        
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(string Xtwpks,string Xtwpys,decimal Scclxh)
        {
            Query qry = new Query(SCT02.Schema);
            qry.QueryType = QueryType.Delete;
            qry.AddWhere("Xtwpks", Xtwpks).AND("Xtwpys", Xtwpys).AND("Scclxh", Scclxh);
            qry.Execute();
            return (true);
        }        
       
    	
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(string Xtwpks,string Xtwpys,decimal Scclxh,string Scytdm,string Xttxhm,decimal? Scgxsl,string Scfddm,string Scjgbz)
	    {
		    SCT02 item = new SCT02();
		    
            item.Xtwpks = Xtwpks;
            
            item.Xtwpys = Xtwpys;
            
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
	    public void Update(string Xtwpks,string Xtwpys,decimal Scclxh,string Scytdm,string Xttxhm,decimal? Scgxsl,string Scfddm,string Scjgbz)
	    {
		    SCT02 item = new SCT02();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.Xtwpks = Xtwpks;
				
			item.Xtwpys = Xtwpys;
				
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
