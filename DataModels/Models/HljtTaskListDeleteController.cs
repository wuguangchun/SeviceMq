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
    /// Controller class for HLJT_TaskList_delete
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class HljtTaskListDeleteController
    {
        // Preload our schema..
        HljtTaskListDelete thisSchemaLoad = new HljtTaskListDelete();
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
        public HljtTaskListDeleteCollection FetchAll()
        {
            HljtTaskListDeleteCollection coll = new HljtTaskListDeleteCollection();
            Query qry = new Query(HljtTaskListDelete.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public HljtTaskListDeleteCollection FetchByID(object ModelType)
        {
            HljtTaskListDeleteCollection coll = new HljtTaskListDeleteCollection().Where("ModelType", ModelType).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public HljtTaskListDeleteCollection FetchByQuery(Query qry)
        {
            HljtTaskListDeleteCollection coll = new HljtTaskListDeleteCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object ModelType)
        {
            return (HljtTaskListDelete.Delete(ModelType) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object ModelType)
        {
            return (HljtTaskListDelete.Destroy(ModelType) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(string ModelType,string Flag,string UpdateSource,DateTime? UpdateTime)
	    {
		    HljtTaskListDelete item = new HljtTaskListDelete();
		    
            item.ModelType = ModelType;
            
            item.Flag = Flag;
            
            item.UpdateSource = UpdateSource;
            
            item.UpdateTime = UpdateTime;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(string ModelType,string Flag,string UpdateSource,DateTime? UpdateTime)
	    {
		    HljtTaskListDelete item = new HljtTaskListDelete();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.ModelType = ModelType;
				
			item.Flag = Flag;
				
			item.UpdateSource = UpdateSource;
				
			item.UpdateTime = UpdateTime;
				
	        item.Save(UserName);
	    }
    }
}