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
    /// Controller class for T_Basis_SystemInfo
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class TBasisSystemInfoController
    {
        // Preload our schema..
        TBasisSystemInfo thisSchemaLoad = new TBasisSystemInfo();
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
        public TBasisSystemInfoCollection FetchAll()
        {
            TBasisSystemInfoCollection coll = new TBasisSystemInfoCollection();
            Query qry = new Query(TBasisSystemInfo.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public TBasisSystemInfoCollection FetchByID(object Id)
        {
            TBasisSystemInfoCollection coll = new TBasisSystemInfoCollection().Where("id", Id).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public TBasisSystemInfoCollection FetchByQuery(Query qry)
        {
            TBasisSystemInfoCollection coll = new TBasisSystemInfoCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object Id)
        {
            return (TBasisSystemInfo.Delete(Id) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object Id)
        {
            return (TBasisSystemInfo.Destroy(Id) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(string SystemName,string SubsystemName,DateTime? LastTime,bool? IsSuccess)
	    {
		    TBasisSystemInfo item = new TBasisSystemInfo();
		    
            item.SystemName = SystemName;
            
            item.SubsystemName = SubsystemName;
            
            item.LastTime = LastTime;
            
            item.IsSuccess = IsSuccess;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(int Id,string SystemName,string SubsystemName,DateTime? LastTime,bool? IsSuccess)
	    {
		    TBasisSystemInfo item = new TBasisSystemInfo();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.Id = Id;
				
			item.SystemName = SystemName;
				
			item.SubsystemName = SubsystemName;
				
			item.LastTime = LastTime;
				
			item.IsSuccess = IsSuccess;
				
	        item.Save(UserName);
	    }
    }
}