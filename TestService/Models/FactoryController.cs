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
    /// Controller class for Factory
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class FactoryController
    {
        // Preload our schema..
        Factory thisSchemaLoad = new Factory();
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
        public FactoryCollection FetchAll()
        {
            FactoryCollection coll = new FactoryCollection();
            Query qry = new Query(Factory.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public FactoryCollection FetchByID(object Scgcmc)
        {
            FactoryCollection coll = new FactoryCollection().Where("SCGCMC", Scgcmc).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public FactoryCollection FetchByQuery(Query qry)
        {
            FactoryCollection coll = new FactoryCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object Scgcmc)
        {
            return (Factory.Delete(Scgcmc) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object Scgcmc)
        {
            return (Factory.Destroy(Scgcmc) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(string Scgcmc)
	    {
		    Factory item = new Factory();
		    
            item.Scgcmc = Scgcmc;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(string Scgcmc)
	    {
		    Factory item = new Factory();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.Scgcmc = Scgcmc;
				
	        item.Save(UserName);
	    }
    }
}
