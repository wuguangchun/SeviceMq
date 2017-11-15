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
    /// Controller class for T_OldApsByCf_3
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class TOldApsByCf3Controller
    {
        // Preload our schema..
        TOldApsByCf3 thisSchemaLoad = new TOldApsByCf3();
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
        public TOldApsByCf3Collection FetchAll()
        {
            TOldApsByCf3Collection coll = new TOldApsByCf3Collection();
            Query qry = new Query(TOldApsByCf3.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public TOldApsByCf3Collection FetchByID(object Id)
        {
            TOldApsByCf3Collection coll = new TOldApsByCf3Collection().Where("ID", Id).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public TOldApsByCf3Collection FetchByQuery(Query qry)
        {
            TOldApsByCf3Collection coll = new TOldApsByCf3Collection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object Id)
        {
            return (TOldApsByCf3.Delete(Id) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object Id)
        {
            return (TOldApsByCf3.Destroy(Id) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(string OrderID,DateTime? BeginTime,DateTime? EndTime,string CutDate,string CutTime,int? CutNo,DateTime? CreateTime,string Scggdh,string OrderType,string CoatType,string StylesResult)
	    {
		    TOldApsByCf3 item = new TOldApsByCf3();
		    
            item.OrderID = OrderID;
            
            item.BeginTime = BeginTime;
            
            item.EndTime = EndTime;
            
            item.CutDate = CutDate;
            
            item.CutTime = CutTime;
            
            item.CutNo = CutNo;
            
            item.CreateTime = CreateTime;
            
            item.Scggdh = Scggdh;
            
            item.OrderType = OrderType;
            
            item.CoatType = CoatType;
            
            item.StylesResult = StylesResult;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(int Id,string OrderID,DateTime? BeginTime,DateTime? EndTime,string CutDate,string CutTime,int? CutNo,DateTime? CreateTime,string Scggdh,string OrderType,string CoatType,string StylesResult)
	    {
		    TOldApsByCf3 item = new TOldApsByCf3();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.Id = Id;
				
			item.OrderID = OrderID;
				
			item.BeginTime = BeginTime;
				
			item.EndTime = EndTime;
				
			item.CutDate = CutDate;
				
			item.CutTime = CutTime;
				
			item.CutNo = CutNo;
				
			item.CreateTime = CreateTime;
				
			item.Scggdh = Scggdh;
				
			item.OrderType = OrderType;
				
			item.CoatType = CoatType;
				
			item.StylesResult = StylesResult;
				
	        item.Save(UserName);
	    }
    }
}
