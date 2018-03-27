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
    /// Controller class for SCT81
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class SCT81Controller
    {
        // Preload our schema..
        SCT81 thisSchemaLoad = new SCT81();
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
        public SCT81Collection FetchAll()
        {
            SCT81Collection coll = new SCT81Collection();
            Query qry = new Query(SCT81.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public SCT81Collection FetchByID(object Scsfbh)
        {
            SCT81Collection coll = new SCT81Collection().Where("SCSFBH", Scsfbh).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public SCT81Collection FetchByQuery(Query qry)
        {
            SCT81Collection coll = new SCT81Collection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object Scsfbh)
        {
            return (SCT81.Delete(Scsfbh) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object Scsfbh)
        {
            return (SCT81.Destroy(Scsfbh) == 1);
        }
        
        
        
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(string Scsfbh,decimal Scsfxh)
        {
            Query qry = new Query(SCT81.Schema);
            qry.QueryType = QueryType.Delete;
            qry.AddWhere("Scsfbh", Scsfbh).AND("Scsfxh", Scsfxh);
            qry.Execute();
            return (true);
        }        
       
    	
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(string Scsfbh,decimal Scsfxh,string Sczsbh,string Schtbh,decimal? Schtxh,string Scggdh,decimal? Scggxh,string Xtwpks,string Xtwpys,string Xtxmdm,string Sccpxh,decimal? Scsfsl,string Scsfbz)
	    {
		    SCT81 item = new SCT81();
		    
            item.Scsfbh = Scsfbh;
            
            item.Scsfxh = Scsfxh;
            
            item.Sczsbh = Sczsbh;
            
            item.Schtbh = Schtbh;
            
            item.Schtxh = Schtxh;
            
            item.Scggdh = Scggdh;
            
            item.Scggxh = Scggxh;
            
            item.Xtwpks = Xtwpks;
            
            item.Xtwpys = Xtwpys;
            
            item.Xtxmdm = Xtxmdm;
            
            item.Sccpxh = Sccpxh;
            
            item.Scsfsl = Scsfsl;
            
            item.Scsfbz = Scsfbz;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(string Scsfbh,decimal Scsfxh,string Sczsbh,string Schtbh,decimal? Schtxh,string Scggdh,decimal? Scggxh,string Xtwpks,string Xtwpys,string Xtxmdm,string Sccpxh,decimal? Scsfsl,string Scsfbz)
	    {
		    SCT81 item = new SCT81();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.Scsfbh = Scsfbh;
				
			item.Scsfxh = Scsfxh;
				
			item.Sczsbh = Sczsbh;
				
			item.Schtbh = Schtbh;
				
			item.Schtxh = Schtxh;
				
			item.Scggdh = Scggdh;
				
			item.Scggxh = Scggxh;
				
			item.Xtwpks = Xtwpks;
				
			item.Xtwpys = Xtwpys;
				
			item.Xtxmdm = Xtxmdm;
				
			item.Sccpxh = Sccpxh;
				
			item.Scsfsl = Scsfsl;
				
			item.Scsfbz = Scsfbz;
				
	        item.Save(UserName);
	    }
    }
}
