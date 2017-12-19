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
    /// Controller class for T_FZfirstOut
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class TFZfirstOutController
    {
        // Preload our schema..
        TFZfirstOut thisSchemaLoad = new TFZfirstOut();
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
        public TFZfirstOutCollection FetchAll()
        {
            TFZfirstOutCollection coll = new TFZfirstOutCollection();
            Query qry = new Query(TFZfirstOut.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public TFZfirstOutCollection FetchByID(object Pkid)
        {
            TFZfirstOutCollection coll = new TFZfirstOutCollection().Where("pkid", Pkid).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public TFZfirstOutCollection FetchByQuery(Query qry)
        {
            TFZfirstOutCollection coll = new TFZfirstOutCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object Pkid)
        {
            return (TFZfirstOut.Delete(Pkid) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object Pkid)
        {
            return (TFZfirstOut.Destroy(Pkid) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(int Pkid,string CustomerId,DateTime? BeginTime,DateTime? EndTime,string Gylx,string CoatCode,string Resoure,int? Num,string TypeT,string Ismtm)
	    {
		    TFZfirstOut item = new TFZfirstOut();
		    
            item.Pkid = Pkid;
            
            item.CustomerId = CustomerId;
            
            item.BeginTime = BeginTime;
            
            item.EndTime = EndTime;
            
            item.Gylx = Gylx;
            
            item.CoatCode = CoatCode;
            
            item.Resoure = Resoure;
            
            item.Num = Num;
            
            item.TypeT = TypeT;
            
            item.Ismtm = Ismtm;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(int Pkid,string CustomerId,DateTime? BeginTime,DateTime? EndTime,string Gylx,string CoatCode,string Resoure,int? Num,string TypeT,string Ismtm)
	    {
		    TFZfirstOut item = new TFZfirstOut();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.Pkid = Pkid;
				
			item.CustomerId = CustomerId;
				
			item.BeginTime = BeginTime;
				
			item.EndTime = EndTime;
				
			item.Gylx = Gylx;
				
			item.CoatCode = CoatCode;
				
			item.Resoure = Resoure;
				
			item.Num = Num;
				
			item.TypeT = TypeT;
				
			item.Ismtm = Ismtm;
				
	        item.Save(UserName);
	    }
    }
}
