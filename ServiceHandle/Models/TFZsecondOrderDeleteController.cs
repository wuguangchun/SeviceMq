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
    /// Controller class for T_FZsecondOrder_delete
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class TFZsecondOrderDeleteController
    {
        // Preload our schema..
        TFZsecondOrderDelete thisSchemaLoad = new TFZsecondOrderDelete();
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
        public TFZsecondOrderDeleteCollection FetchAll()
        {
            TFZsecondOrderDeleteCollection coll = new TFZsecondOrderDeleteCollection();
            Query qry = new Query(TFZsecondOrderDelete.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public TFZsecondOrderDeleteCollection FetchByID(object PkId)
        {
            TFZsecondOrderDeleteCollection coll = new TFZsecondOrderDeleteCollection().Where("pkId", PkId).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public TFZsecondOrderDeleteCollection FetchByQuery(Query qry)
        {
            TFZsecondOrderDeleteCollection coll = new TFZsecondOrderDeleteCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object PkId)
        {
            return (TFZsecondOrderDelete.Delete(PkId) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object PkId)
        {
            return (TFZsecondOrderDelete.Destroy(PkId) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(int PkId,string CustomerId,string Resourse,int? Sx,string CoatCode,string Num,int? TypeT,int? Typenum)
	    {
		    TFZsecondOrderDelete item = new TFZsecondOrderDelete();
		    
            item.PkId = PkId;
            
            item.CustomerId = CustomerId;
            
            item.Resourse = Resourse;
            
            item.Sx = Sx;
            
            item.CoatCode = CoatCode;
            
            item.Num = Num;
            
            item.TypeT = TypeT;
            
            item.Typenum = Typenum;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(int PkId,string CustomerId,string Resourse,int? Sx,string CoatCode,string Num,int? TypeT,int? Typenum)
	    {
		    TFZsecondOrderDelete item = new TFZsecondOrderDelete();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.PkId = PkId;
				
			item.CustomerId = CustomerId;
				
			item.Resourse = Resourse;
				
			item.Sx = Sx;
				
			item.CoatCode = CoatCode;
				
			item.Num = Num;
				
			item.TypeT = TypeT;
				
			item.Typenum = Typenum;
				
	        item.Save(UserName);
	    }
    }
}
