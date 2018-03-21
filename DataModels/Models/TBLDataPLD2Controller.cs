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
    /// Controller class for T_BLData_PLD2
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class TBLDataPLD2Controller
    {
        // Preload our schema..
        TBLDataPLD2 thisSchemaLoad = new TBLDataPLD2();
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
        public TBLDataPLD2Collection FetchAll()
        {
            TBLDataPLD2Collection coll = new TBLDataPLD2Collection();
            Query qry = new Query(TBLDataPLD2.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public TBLDataPLD2Collection FetchByID(object Scggdh)
        {
            TBLDataPLD2Collection coll = new TBLDataPLD2Collection().Where("SCGGDH", Scggdh).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public TBLDataPLD2Collection FetchByQuery(Query qry)
        {
            TBLDataPLD2Collection coll = new TBLDataPLD2Collection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object Scggdh)
        {
            return (TBLDataPLD2.Delete(Scggdh) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object Scggdh)
        {
            return (TBLDataPLD2.Destroy(Scggdh) == 1);
        }
        
        
        
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(string Scggdh,int Wlxh)
        {
            Query qry = new Query(TBLDataPLD2.Schema);
            qry.QueryType = QueryType.Delete;
            qry.AddWhere("Scggdh", Scggdh).AND("Wlxh", Wlxh);
            qry.Execute();
            return (true);
        }        
       
    	
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(string Scggdh,string Khdh,int? Pbxh,string Wlbm,decimal? Wlfk,decimal? Wlhy,string Tgsx,decimal? Tgkd,string Wlks,int Wlxh,int? XH1,string Wlbw,string Gyfl,string Sldl,string Cpzl,string Sfhd,string Hdh)
	    {
		    TBLDataPLD2 item = new TBLDataPLD2();
		    
            item.Scggdh = Scggdh;
            
            item.Khdh = Khdh;
            
            item.Pbxh = Pbxh;
            
            item.Wlbm = Wlbm;
            
            item.Wlfk = Wlfk;
            
            item.Wlhy = Wlhy;
            
            item.Tgsx = Tgsx;
            
            item.Tgkd = Tgkd;
            
            item.Wlks = Wlks;
            
            item.Wlxh = Wlxh;
            
            item.XH1 = XH1;
            
            item.Wlbw = Wlbw;
            
            item.Gyfl = Gyfl;
            
            item.Sldl = Sldl;
            
            item.Cpzl = Cpzl;
            
            item.Sfhd = Sfhd;
            
            item.Hdh = Hdh;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(int Id,string Scggdh,string Khdh,int? Pbxh,string Wlbm,decimal? Wlfk,decimal? Wlhy,string Tgsx,decimal? Tgkd,string Wlks,int Wlxh,int? XH1,string Wlbw,string Gyfl,string Sldl,string Cpzl,string Sfhd,string Hdh)
	    {
		    TBLDataPLD2 item = new TBLDataPLD2();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.Id = Id;
				
			item.Scggdh = Scggdh;
				
			item.Khdh = Khdh;
				
			item.Pbxh = Pbxh;
				
			item.Wlbm = Wlbm;
				
			item.Wlfk = Wlfk;
				
			item.Wlhy = Wlhy;
				
			item.Tgsx = Tgsx;
				
			item.Tgkd = Tgkd;
				
			item.Wlks = Wlks;
				
			item.Wlxh = Wlxh;
				
			item.XH1 = XH1;
				
			item.Wlbw = Wlbw;
				
			item.Gyfl = Gyfl;
				
			item.Sldl = Sldl;
				
			item.Cpzl = Cpzl;
				
			item.Sfhd = Sfhd;
				
			item.Hdh = Hdh;
				
	        item.Save(UserName);
	    }
    }
}