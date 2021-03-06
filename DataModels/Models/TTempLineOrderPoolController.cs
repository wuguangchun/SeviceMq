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
    /// Controller class for T_Temp_LineOrderPool
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class TTempLineOrderPoolController
    {
        // Preload our schema..
        TTempLineOrderPool thisSchemaLoad = new TTempLineOrderPool();
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
        public TTempLineOrderPoolCollection FetchAll()
        {
            TTempLineOrderPoolCollection coll = new TTempLineOrderPoolCollection();
            Query qry = new Query(TTempLineOrderPool.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public TTempLineOrderPoolCollection FetchByID(object Khdh)
        {
            TTempLineOrderPoolCollection coll = new TTempLineOrderPoolCollection().Where("Khdh", Khdh).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public TTempLineOrderPoolCollection FetchByQuery(Query qry)
        {
            TTempLineOrderPoolCollection coll = new TTempLineOrderPoolCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object Khdh)
        {
            return (TTempLineOrderPool.Delete(Khdh) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object Khdh)
        {
            return (TTempLineOrderPool.Destroy(Khdh) == 1);
        }
        
        
        
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(string Khdh,string Fzfl)
        {
            Query qry = new Query(TTempLineOrderPool.Schema);
            qry.QueryType = QueryType.Delete;
            qry.AddWhere("Khdh", Khdh).AND("Fzfl", Fzfl);
            qry.Execute();
            return (true);
        }        
       
    	
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(string Khdh,string Fzfl,string LineName,int? Num,string Plan)
	    {
		    TTempLineOrderPool item = new TTempLineOrderPool();
		    
            item.Khdh = Khdh;
            
            item.Fzfl = Fzfl;
            
            item.LineName = LineName;
            
            item.Num = Num;
            
            item.Plan = Plan;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(string Khdh,string Fzfl,string LineName,int? Num,string Plan)
	    {
		    TTempLineOrderPool item = new TTempLineOrderPool();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.Khdh = Khdh;
				
			item.Fzfl = Fzfl;
				
			item.LineName = LineName;
				
			item.Num = Num;
				
			item.Plan = Plan;
				
	        item.Save(UserName);
	    }
    }
}
