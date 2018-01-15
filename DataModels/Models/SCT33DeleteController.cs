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
    /// Controller class for SCT33_delete
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class SCT33DeleteController
    {
        // Preload our schema..
        SCT33Delete thisSchemaLoad = new SCT33Delete();
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
        public SCT33DeleteCollection FetchAll()
        {
            SCT33DeleteCollection coll = new SCT33DeleteCollection();
            Query qry = new Query(SCT33Delete.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public SCT33DeleteCollection FetchByID(object Schtbh)
        {
            SCT33DeleteCollection coll = new SCT33DeleteCollection().Where("SCHTBH", Schtbh).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public SCT33DeleteCollection FetchByQuery(Query qry)
        {
            SCT33DeleteCollection coll = new SCT33DeleteCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object Schtbh)
        {
            return (SCT33Delete.Delete(Schtbh) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object Schtbh)
        {
            return (SCT33Delete.Destroy(Schtbh) == 1);
        }
        
        
        
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(string Schtbh,int Schtxh)
        {
            Query qry = new Query(SCT33Delete.Schema);
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
		    SCT33Delete item = new SCT33Delete();
		    
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
		    SCT33Delete item = new SCT33Delete();
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