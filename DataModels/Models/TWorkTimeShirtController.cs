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
    /// Controller class for T_WorkTimeShirt
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class TWorkTimeShirtController
    {
        // Preload our schema..
        TWorkTimeShirt thisSchemaLoad = new TWorkTimeShirt();
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
        public TWorkTimeShirtCollection FetchAll()
        {
            TWorkTimeShirtCollection coll = new TWorkTimeShirtCollection();
            Query qry = new Query(TWorkTimeShirt.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public TWorkTimeShirtCollection FetchByID(object Id)
        {
            TWorkTimeShirtCollection coll = new TWorkTimeShirtCollection().Where("id", Id).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public TWorkTimeShirtCollection FetchByQuery(Query qry)
        {
            TWorkTimeShirtCollection coll = new TWorkTimeShirtCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object Id)
        {
            return (TWorkTimeShirt.Delete(Id) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object Id)
        {
            return (TWorkTimeShirt.Destroy(Id) == 1);
        }
        
        
        
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(int Id,DateTime Worktime)
        {
            Query qry = new Query(TWorkTimeShirt.Schema);
            qry.QueryType = QueryType.Delete;
            qry.AddWhere("Id", Id).AND("Worktime", Worktime);
            qry.Execute();
            return (true);
        }        
       
    	
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(DateTime Worktime)
	    {
		    TWorkTimeShirt item = new TWorkTimeShirt();
		    
            item.Worktime = Worktime;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(int Id,DateTime Worktime)
	    {
		    TWorkTimeShirt item = new TWorkTimeShirt();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.Id = Id;
				
			item.Worktime = Worktime;
				
	        item.Save(UserName);
	    }
    }
}
