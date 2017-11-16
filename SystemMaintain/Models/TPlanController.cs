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
    /// Controller class for T_PlanS
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class TPlanController
    {
        // Preload our schema..
        TPlan thisSchemaLoad = new TPlan();
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
        public TPlanCollection FetchAll()
        {
            TPlanCollection coll = new TPlanCollection();
            Query qry = new Query(TPlan.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public TPlanCollection FetchByID(object Khdh)
        {
            TPlanCollection coll = new TPlanCollection().Where("KHDH", Khdh).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public TPlanCollection FetchByQuery(Query qry)
        {
            TPlanCollection coll = new TPlanCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object Khdh)
        {
            return (TPlan.Delete(Khdh) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object Khdh)
        {
            return (TPlan.Destroy(Khdh) == 1);
        }
        
        
        
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(string Khdh,string Wlbm,decimal Wlfk,decimal Wlhy,string Tgsx,string Wlbw)
        {
            Query qry = new Query(TPlan.Schema);
            qry.QueryType = QueryType.Delete;
            qry.AddWhere("Khdh", Khdh).AND("Wlbm", Wlbm).AND("Wlfk", Wlfk).AND("Wlhy", Wlhy).AND("Tgsx", Tgsx).AND("Wlbw", Wlbw);
            qry.Execute();
            return (true);
        }        
       
    	
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(int? Planmid,string Sczsbh,string Khdh,string Gyfl,string Sldl,string Cpzl,int? Pbxh,int? Wlxh,string Wlbm,decimal Wlfk,decimal Wlhy,string Tgsx,decimal? Tgkd,string Wlbw,bool? Isaps,string ChildKHDDBH,string Wlks)
	    {
		    TPlan item = new TPlan();
		    
            item.Planmid = Planmid;
            
            item.Sczsbh = Sczsbh;
            
            item.Khdh = Khdh;
            
            item.Gyfl = Gyfl;
            
            item.Sldl = Sldl;
            
            item.Cpzl = Cpzl;
            
            item.Pbxh = Pbxh;
            
            item.Wlxh = Wlxh;
            
            item.Wlbm = Wlbm;
            
            item.Wlfk = Wlfk;
            
            item.Wlhy = Wlhy;
            
            item.Tgsx = Tgsx;
            
            item.Tgkd = Tgkd;
            
            item.Wlbw = Wlbw;
            
            item.Isaps = Isaps;
            
            item.ChildKHDDBH = ChildKHDDBH;
            
            item.Wlks = Wlks;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(int Plansid,int? Planmid,string Sczsbh,string Khdh,string Gyfl,string Sldl,string Cpzl,int? Pbxh,int? Wlxh,string Wlbm,decimal Wlfk,decimal Wlhy,string Tgsx,decimal? Tgkd,string Wlbw,bool? Isaps,string ChildKHDDBH,string Wlks)
	    {
		    TPlan item = new TPlan();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.Plansid = Plansid;
				
			item.Planmid = Planmid;
				
			item.Sczsbh = Sczsbh;
				
			item.Khdh = Khdh;
				
			item.Gyfl = Gyfl;
				
			item.Sldl = Sldl;
				
			item.Cpzl = Cpzl;
				
			item.Pbxh = Pbxh;
				
			item.Wlxh = Wlxh;
				
			item.Wlbm = Wlbm;
				
			item.Wlfk = Wlfk;
				
			item.Wlhy = Wlhy;
				
			item.Tgsx = Tgsx;
				
			item.Tgkd = Tgkd;
				
			item.Wlbw = Wlbw;
				
			item.Isaps = Isaps;
				
			item.ChildKHDDBH = ChildKHDDBH;
				
			item.Wlks = Wlks;
				
	        item.Save(UserName);
	    }
    }
}
