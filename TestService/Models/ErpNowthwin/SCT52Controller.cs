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
    /// Controller class for SCT52
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class SCT52Controller
    {
        // Preload our schema..
        SCT52 thisSchemaLoad = new SCT52();
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
        public SCT52Collection FetchAll()
        {
            SCT52Collection coll = new SCT52Collection();
            Query qry = new Query(SCT52.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public SCT52Collection FetchByID(object Scggdh)
        {
            SCT52Collection coll = new SCT52Collection().Where("SCGGDH", Scggdh).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public SCT52Collection FetchByQuery(Query qry)
        {
            SCT52Collection coll = new SCT52Collection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object Scggdh)
        {
            return (SCT52.Delete(Scggdh) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object Scggdh)
        {
            return (SCT52.Destroy(Scggdh) == 1);
        }
        
        
        
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(string Scggdh,decimal Scggxh)
        {
            Query qry = new Query(SCT52.Schema);
            qry.QueryType = QueryType.Delete;
            qry.AddWhere("Scggdh", Scggdh).AND("Scggxh", Scggxh);
            qry.Execute();
            return (true);
        }        
       
    	
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(string Sckgks,string Sckgml,decimal? Scwpsl,string Xtwpbm,string Fzfl,string Scggdh,decimal Scggxh,string Schtbh,decimal? Schtxh,string Xtwpks,string Xtwpys,string Xtxmdm,decimal? Schtsl,decimal? Scjgdj,DateTime? Scjhrq,string Scjhdd,string Xtwplj,string Scczbz,string Scggbz)
	    {
		    SCT52 item = new SCT52();
		    
            item.Sckgks = Sckgks;
            
            item.Sckgml = Sckgml;
            
            item.Scwpsl = Scwpsl;
            
            item.Xtwpbm = Xtwpbm;
            
            item.Fzfl = Fzfl;
            
            item.Scggdh = Scggdh;
            
            item.Scggxh = Scggxh;
            
            item.Schtbh = Schtbh;
            
            item.Schtxh = Schtxh;
            
            item.Xtwpks = Xtwpks;
            
            item.Xtwpys = Xtwpys;
            
            item.Xtxmdm = Xtxmdm;
            
            item.Schtsl = Schtsl;
            
            item.Scjgdj = Scjgdj;
            
            item.Scjhrq = Scjhrq;
            
            item.Scjhdd = Scjhdd;
            
            item.Xtwplj = Xtwplj;
            
            item.Scczbz = Scczbz;
            
            item.Scggbz = Scggbz;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(string Sckgks,string Sckgml,decimal? Scwpsl,string Xtwpbm,string Fzfl,string Scggdh,decimal Scggxh,string Schtbh,decimal? Schtxh,string Xtwpks,string Xtwpys,string Xtxmdm,decimal? Schtsl,decimal? Scjgdj,DateTime? Scjhrq,string Scjhdd,string Xtwplj,string Scczbz,string Scggbz)
	    {
		    SCT52 item = new SCT52();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.Sckgks = Sckgks;
				
			item.Sckgml = Sckgml;
				
			item.Scwpsl = Scwpsl;
				
			item.Xtwpbm = Xtwpbm;
				
			item.Fzfl = Fzfl;
				
			item.Scggdh = Scggdh;
				
			item.Scggxh = Scggxh;
				
			item.Schtbh = Schtbh;
				
			item.Schtxh = Schtxh;
				
			item.Xtwpks = Xtwpks;
				
			item.Xtwpys = Xtwpys;
				
			item.Xtxmdm = Xtxmdm;
				
			item.Schtsl = Schtsl;
				
			item.Scjgdj = Scjgdj;
				
			item.Scjhrq = Scjhrq;
				
			item.Scjhdd = Scjhdd;
				
			item.Xtwplj = Xtwplj;
				
			item.Scczbz = Scczbz;
				
			item.Scggbz = Scggbz;
				
	        item.Save(UserName);
	    }
    }
}
