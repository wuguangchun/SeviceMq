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
    /// Controller class for T_Analysis_OrderListByDH
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class TAnalysisOrderListByDHController
    {
        // Preload our schema..
        TAnalysisOrderListByDH thisSchemaLoad = new TAnalysisOrderListByDH();
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
        public TAnalysisOrderListByDHCollection FetchAll()
        {
            TAnalysisOrderListByDHCollection coll = new TAnalysisOrderListByDHCollection();
            Query qry = new Query(TAnalysisOrderListByDH.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public TAnalysisOrderListByDHCollection FetchByID(object Schtbh)
        {
            TAnalysisOrderListByDHCollection coll = new TAnalysisOrderListByDHCollection().Where("schtbh", Schtbh).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public TAnalysisOrderListByDHCollection FetchByQuery(Query qry)
        {
            TAnalysisOrderListByDHCollection coll = new TAnalysisOrderListByDHCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object Schtbh)
        {
            return (TAnalysisOrderListByDH.Delete(Schtbh) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object Schtbh)
        {
            return (TAnalysisOrderListByDH.Destroy(Schtbh) == 1);
        }
        
        
        
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(string Schtbh,string Schtxh)
        {
            Query qry = new Query(TAnalysisOrderListByDH.Schema);
            qry.QueryType = QueryType.Delete;
            qry.AddWhere("Schtbh", Schtbh).AND("Schtxh", Schtxh);
            qry.Execute();
            return (true);
        }        
       
    	
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(string Schtbh,string Schtxh,string Xtwpdm,string Xtwpks,string Xtwpys,int? Schtsl,DateTime? Sckhjq,string Ylbm,string Scggdh)
	    {
		    TAnalysisOrderListByDH item = new TAnalysisOrderListByDH();
		    
            item.Schtbh = Schtbh;
            
            item.Schtxh = Schtxh;
            
            item.Xtwpdm = Xtwpdm;
            
            item.Xtwpks = Xtwpks;
            
            item.Xtwpys = Xtwpys;
            
            item.Schtsl = Schtsl;
            
            item.Sckhjq = Sckhjq;
            
            item.Ylbm = Ylbm;
            
            item.Scggdh = Scggdh;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(string Schtbh,string Schtxh,string Xtwpdm,string Xtwpks,string Xtwpys,int? Schtsl,DateTime? Sckhjq,string Ylbm,string Scggdh)
	    {
		    TAnalysisOrderListByDH item = new TAnalysisOrderListByDH();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.Schtbh = Schtbh;
				
			item.Schtxh = Schtxh;
				
			item.Xtwpdm = Xtwpdm;
				
			item.Xtwpks = Xtwpks;
				
			item.Xtwpys = Xtwpys;
				
			item.Schtsl = Schtsl;
				
			item.Sckhjq = Sckhjq;
				
			item.Ylbm = Ylbm;
				
			item.Scggdh = Scggdh;
				
	        item.Save(UserName);
	    }
    }
}
