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
    /// Controller class for T_Basis_resource
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class TBasisResourceController
    {
        // Preload our schema..
        TBasisResource thisSchemaLoad = new TBasisResource();
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
        public TBasisResourceCollection FetchAll()
        {
            TBasisResourceCollection coll = new TBasisResourceCollection();
            Query qry = new Query(TBasisResource.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public TBasisResourceCollection FetchByID(object Resources)
        {
            TBasisResourceCollection coll = new TBasisResourceCollection().Where("resources", Resources).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public TBasisResourceCollection FetchByQuery(Query qry)
        {
            TBasisResourceCollection coll = new TBasisResourceCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object Resources)
        {
            return (TBasisResource.Delete(Resources) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object Resources)
        {
            return (TBasisResource.Destroy(Resources) == 1);
        }
        
        
        
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(string Resources,string ResourcesCode)
        {
            Query qry = new Query(TBasisResource.Schema);
            qry.QueryType = QueryType.Delete;
            qry.AddWhere("Resources", Resources).AND("ResourcesCode", ResourcesCode);
            qry.Execute();
            return (true);
        }        
       
    	
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(string Resources,string ResourcesCode,string ResourcesName)
	    {
		    TBasisResource item = new TBasisResource();
		    
            item.Resources = Resources;
            
            item.ResourcesCode = ResourcesCode;
            
            item.ResourcesName = ResourcesName;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(string Resources,string ResourcesCode,string ResourcesName)
	    {
		    TBasisResource item = new TBasisResource();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.Resources = Resources;
				
			item.ResourcesCode = ResourcesCode;
				
			item.ResourcesName = ResourcesName;
				
	        item.Save(UserName);
	    }
    }
}
