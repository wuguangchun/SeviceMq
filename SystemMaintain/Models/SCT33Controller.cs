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
namespace Model
{
    /// <summary>
    /// Controller class for SCT33
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class SCT33Controller
    {
        // Preload our schema..
        SCT33 thisSchemaLoad = new SCT33();
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
        public SCT33Collection FetchAll()
        {
            SCT33Collection coll = new SCT33Collection();
            Query qry = new Query(SCT33.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public SCT33Collection FetchByID(object Schtbh)
        {
            SCT33Collection coll = new SCT33Collection().Where("SCHTBH", Schtbh).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public SCT33Collection FetchByQuery(Query qry)
        {
            SCT33Collection coll = new SCT33Collection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object Schtbh)
        {
            return (SCT33.Delete(Schtbh) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object Schtbh)
        {
            return (SCT33.Destroy(Schtbh) == 1);
        }
        
        
        
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(string Schtbh,int Schtxh)
        {
            Query qry = new Query(SCT33.Schema);
            qry.QueryType = QueryType.Delete;
            qry.AddWhere("Schtbh", Schtbh).AND("Schtxh", Schtxh);
            qry.Execute();
            return (true);
        }        
       
    	
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(string Schtbh,int Schtxh,string Scggdh,int Scggxh,string Xtwpks,string Xtwpys,string Xtxmdm,int? Schtsl,string Scshbz)
	    {
		    SCT33 item = new SCT33();
		    
            item.Schtbh = Schtbh;
            
            item.Schtxh = Schtxh;
            
            item.Scggdh = Scggdh;
            
            item.Scggxh = Scggxh;
            
            item.Xtwpks = Xtwpks;
            
            item.Xtwpys = Xtwpys;
            
            item.Xtxmdm = Xtxmdm;
            
            item.Schtsl = Schtsl;
            
            item.Scshbz = Scshbz;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(string Schtbh,int Schtxh,string Scggdh,int Scggxh,string Xtwpks,string Xtwpys,string Xtxmdm,int? Schtsl,string Scshbz)
	    {
		    SCT33 item = new SCT33();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.Schtbh = Schtbh;
				
			item.Schtxh = Schtxh;
				
			item.Scggdh = Scggdh;
				
			item.Scggxh = Scggxh;
				
			item.Xtwpks = Xtwpks;
				
			item.Xtwpys = Xtwpys;
				
			item.Xtxmdm = Xtxmdm;
				
			item.Schtsl = Schtsl;
				
			item.Scshbz = Scshbz;
				
	        item.Save(UserName);
	    }
    }
}
