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
    /// Controller class for T_ApsClientLog
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class TApsClientLogController
    {
        // Preload our schema..
        TApsClientLog thisSchemaLoad = new TApsClientLog();
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
        public TApsClientLogCollection FetchAll()
        {
            TApsClientLogCollection coll = new TApsClientLogCollection();
            Query qry = new Query(TApsClientLog.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public TApsClientLogCollection FetchByID(object Id)
        {
            TApsClientLogCollection coll = new TApsClientLogCollection().Where("id", Id).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public TApsClientLogCollection FetchByQuery(Query qry)
        {
            TApsClientLogCollection coll = new TApsClientLogCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object Id)
        {
            return (TApsClientLog.Delete(Id) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object Id)
        {
            return (TApsClientLog.Destroy(Id) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(string Project,string Content,DateTime? CreateTime,string Khdh)
	    {
		    TApsClientLog item = new TApsClientLog();
		    
            item.Project = Project;
            
            item.Content = Content;
            
            item.CreateTime = CreateTime;
            
            item.Khdh = Khdh;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(int Id,string Project,string Content,DateTime? CreateTime,string Khdh)
	    {
		    TApsClientLog item = new TApsClientLog();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.Id = Id;
				
			item.Project = Project;
				
			item.Content = Content;
				
			item.CreateTime = CreateTime;
				
			item.Khdh = Khdh;
				
	        item.Save(UserName);
	    }
    }
}