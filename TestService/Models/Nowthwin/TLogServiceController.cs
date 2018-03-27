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
    /// Controller class for T_Log_Service
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class TLogServiceController
    {
        // Preload our schema..
        TLogService thisSchemaLoad = new TLogService();
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
        public TLogServiceCollection FetchAll()
        {
            TLogServiceCollection coll = new TLogServiceCollection();
            Query qry = new Query(TLogService.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public TLogServiceCollection FetchByID(object Id)
        {
            TLogServiceCollection coll = new TLogServiceCollection().Where("ID", Id).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public TLogServiceCollection FetchByQuery(Query qry)
        {
            TLogServiceCollection coll = new TLogServiceCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object Id)
        {
            return (TLogService.Delete(Id) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object Id)
        {
            return (TLogService.Destroy(Id) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(string Khdh,string Lable,string MessagePath,string CallBackUrl,DateTime? CreateTime,string Context,string MessageID)
	    {
		    TLogService item = new TLogService();
		    
            item.Khdh = Khdh;
            
            item.Lable = Lable;
            
            item.MessagePath = MessagePath;
            
            item.CallBackUrl = CallBackUrl;
            
            item.CreateTime = CreateTime;
            
            item.Context = Context;
            
            item.MessageID = MessageID;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(int Id,string Khdh,string Lable,string MessagePath,string CallBackUrl,DateTime? CreateTime,string Context,string MessageID)
	    {
		    TLogService item = new TLogService();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.Id = Id;
				
			item.Khdh = Khdh;
				
			item.Lable = Lable;
				
			item.MessagePath = MessagePath;
				
			item.CallBackUrl = CallBackUrl;
				
			item.CreateTime = CreateTime;
				
			item.Context = Context;
				
			item.MessageID = MessageID;
				
	        item.Save(UserName);
	    }
    }
}
