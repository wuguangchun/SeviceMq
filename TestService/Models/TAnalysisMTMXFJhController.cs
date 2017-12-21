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
    /// Controller class for T_Analysis_MTMXFJh
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class TAnalysisMTMXFJhController
    {
        // Preload our schema..
        TAnalysisMTMXFJh thisSchemaLoad = new TAnalysisMTMXFJh();
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
        public TAnalysisMTMXFJhCollection FetchAll()
        {
            TAnalysisMTMXFJhCollection coll = new TAnalysisMTMXFJhCollection();
            Query qry = new Query(TAnalysisMTMXFJh.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public TAnalysisMTMXFJhCollection FetchByID(object Id)
        {
            TAnalysisMTMXFJhCollection coll = new TAnalysisMTMXFJhCollection().Where("ID", Id).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public TAnalysisMTMXFJhCollection FetchByQuery(Query qry)
        {
            TAnalysisMTMXFJhCollection coll = new TAnalysisMTMXFJhCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object Id)
        {
            return (TAnalysisMTMXFJh.Delete(Id) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object Id)
        {
            return (TAnalysisMTMXFJh.Destroy(Id) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(long Id,string Xtwpks,string Xtwpys,DateTime? Scjhrq,string Xtwplj,string Schtsl,string Scggdh,string Scyspd,string Xtwldm,string Scgydm,string Scjhbz,string Xtwpmc,string Scjhdd,int Clothtype,int Jiaji,int Fangge,int Woman,int Shiyi,int Peijian,int Shougong,int Huizhipi,int Nabotou,int Ceshi,int Tmw,int? Guowai,int? Banzu)
	    {
		    TAnalysisMTMXFJh item = new TAnalysisMTMXFJh();
		    
            item.Id = Id;
            
            item.Xtwpks = Xtwpks;
            
            item.Xtwpys = Xtwpys;
            
            item.Scjhrq = Scjhrq;
            
            item.Xtwplj = Xtwplj;
            
            item.Schtsl = Schtsl;
            
            item.Scggdh = Scggdh;
            
            item.Scyspd = Scyspd;
            
            item.Xtwldm = Xtwldm;
            
            item.Scgydm = Scgydm;
            
            item.Scjhbz = Scjhbz;
            
            item.Xtwpmc = Xtwpmc;
            
            item.Scjhdd = Scjhdd;
            
            item.Clothtype = Clothtype;
            
            item.Jiaji = Jiaji;
            
            item.Fangge = Fangge;
            
            item.Woman = Woman;
            
            item.Shiyi = Shiyi;
            
            item.Peijian = Peijian;
            
            item.Shougong = Shougong;
            
            item.Huizhipi = Huizhipi;
            
            item.Nabotou = Nabotou;
            
            item.Ceshi = Ceshi;
            
            item.Tmw = Tmw;
            
            item.Guowai = Guowai;
            
            item.Banzu = Banzu;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(long Id,string Xtwpks,string Xtwpys,DateTime? Scjhrq,string Xtwplj,string Schtsl,string Scggdh,string Scyspd,string Xtwldm,string Scgydm,string Scjhbz,string Xtwpmc,string Scjhdd,int Clothtype,int Jiaji,int Fangge,int Woman,int Shiyi,int Peijian,int Shougong,int Huizhipi,int Nabotou,int Ceshi,int Tmw,int? Guowai,int? Banzu)
	    {
		    TAnalysisMTMXFJh item = new TAnalysisMTMXFJh();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.Id = Id;
				
			item.Xtwpks = Xtwpks;
				
			item.Xtwpys = Xtwpys;
				
			item.Scjhrq = Scjhrq;
				
			item.Xtwplj = Xtwplj;
				
			item.Schtsl = Schtsl;
				
			item.Scggdh = Scggdh;
				
			item.Scyspd = Scyspd;
				
			item.Xtwldm = Xtwldm;
				
			item.Scgydm = Scgydm;
				
			item.Scjhbz = Scjhbz;
				
			item.Xtwpmc = Xtwpmc;
				
			item.Scjhdd = Scjhdd;
				
			item.Clothtype = Clothtype;
				
			item.Jiaji = Jiaji;
				
			item.Fangge = Fangge;
				
			item.Woman = Woman;
				
			item.Shiyi = Shiyi;
				
			item.Peijian = Peijian;
				
			item.Shougong = Shougong;
				
			item.Huizhipi = Huizhipi;
				
			item.Nabotou = Nabotou;
				
			item.Ceshi = Ceshi;
				
			item.Tmw = Tmw;
				
			item.Guowai = Guowai;
				
			item.Banzu = Banzu;
				
	        item.Save(UserName);
	    }
    }
}