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
namespace APSData
{
    /// <summary>
    /// Controller class for T_TempMES_delete
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class TTempMESDeleteController
    {
        // Preload our schema..
        TTempMESDelete thisSchemaLoad = new TTempMESDelete();
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
        public TTempMESDeleteCollection FetchAll()
        {
            TTempMESDeleteCollection coll = new TTempMESDeleteCollection();
            Query qry = new Query(TTempMESDelete.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public TTempMESDeleteCollection FetchByID(object Scggdh)
        {
            TTempMESDeleteCollection coll = new TTempMESDeleteCollection().Where("SCGGDH", Scggdh).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public TTempMESDeleteCollection FetchByQuery(Query qry)
        {
            TTempMESDeleteCollection coll = new TTempMESDeleteCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object Scggdh)
        {
            return (TTempMESDelete.Delete(Scggdh) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object Scggdh)
        {
            return (TTempMESDelete.Destroy(Scggdh) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(string Sczsbh,string Scggdh,string Khddbh,int? Pcccbh,string Pcccsj,DateTime? Sccjjq,DateTime? Scjhrq,string Sclsbh,string Scfzxh,string Status,string Wrong)
	    {
		    TTempMESDelete item = new TTempMESDelete();
		    
            item.Sczsbh = Sczsbh;
            
            item.Scggdh = Scggdh;
            
            item.Khddbh = Khddbh;
            
            item.Pcccbh = Pcccbh;
            
            item.Pcccsj = Pcccsj;
            
            item.Sccjjq = Sccjjq;
            
            item.Scjhrq = Scjhrq;
            
            item.Sclsbh = Sclsbh;
            
            item.Scfzxh = Scfzxh;
            
            item.Status = Status;
            
            item.Wrong = Wrong;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(int Id,string Sczsbh,string Scggdh,string Khddbh,int? Pcccbh,string Pcccsj,DateTime? Sccjjq,DateTime? Scjhrq,string Sclsbh,string Scfzxh,string Status,string Wrong)
	    {
		    TTempMESDelete item = new TTempMESDelete();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.Id = Id;
				
			item.Sczsbh = Sczsbh;
				
			item.Scggdh = Scggdh;
				
			item.Khddbh = Khddbh;
				
			item.Pcccbh = Pcccbh;
				
			item.Pcccsj = Pcccsj;
				
			item.Sccjjq = Sccjjq;
				
			item.Scjhrq = Scjhrq;
				
			item.Sclsbh = Sclsbh;
				
			item.Scfzxh = Scfzxh;
				
			item.Status = Status;
				
			item.Wrong = Wrong;
				
	        item.Save(UserName);
	    }
    }
}