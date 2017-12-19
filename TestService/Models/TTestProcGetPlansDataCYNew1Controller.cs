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
    /// Controller class for t_Test_Proc_GetPlansDataCY_New1
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class TTestProcGetPlansDataCYNew1Controller
    {
        // Preload our schema..
        TTestProcGetPlansDataCYNew1 thisSchemaLoad = new TTestProcGetPlansDataCYNew1();
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
        public TTestProcGetPlansDataCYNew1Collection FetchAll()
        {
            TTestProcGetPlansDataCYNew1Collection coll = new TTestProcGetPlansDataCYNew1Collection();
            Query qry = new Query(TTestProcGetPlansDataCYNew1.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public TTestProcGetPlansDataCYNew1Collection FetchByID(object Scyspd)
        {
            TTestProcGetPlansDataCYNew1Collection coll = new TTestProcGetPlansDataCYNew1Collection().Where("SCYSPD", Scyspd).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public TTestProcGetPlansDataCYNew1Collection FetchByQuery(Query qry)
        {
            TTestProcGetPlansDataCYNew1Collection coll = new TTestProcGetPlansDataCYNew1Collection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object Scyspd)
        {
            return (TTestProcGetPlansDataCYNew1.Delete(Scyspd) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object Scyspd)
        {
            return (TTestProcGetPlansDataCYNew1.Destroy(Scyspd) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(string Plans,string Scgydm,DateTime? Scjhrq,string Scyspd,string Schtbh,string Scggdh,string Scggbz,string Schtsl,string Schtxh,string Xtwpmc,string Xtwpks,string Xtwpys,string Ptfs,string Xtwldm,string Sckhxm,string Scjhdd,string Scjhbz,int Clothtype,int CM35,int Jiaji,int Guowai,int Miantang,int Yangpinban,int Peijian,int Isfangge,string Banzu)
	    {
		    TTestProcGetPlansDataCYNew1 item = new TTestProcGetPlansDataCYNew1();
		    
            item.Plans = Plans;
            
            item.Scgydm = Scgydm;
            
            item.Scjhrq = Scjhrq;
            
            item.Scyspd = Scyspd;
            
            item.Schtbh = Schtbh;
            
            item.Scggdh = Scggdh;
            
            item.Scggbz = Scggbz;
            
            item.Schtsl = Schtsl;
            
            item.Schtxh = Schtxh;
            
            item.Xtwpmc = Xtwpmc;
            
            item.Xtwpks = Xtwpks;
            
            item.Xtwpys = Xtwpys;
            
            item.Ptfs = Ptfs;
            
            item.Xtwldm = Xtwldm;
            
            item.Sckhxm = Sckhxm;
            
            item.Scjhdd = Scjhdd;
            
            item.Scjhbz = Scjhbz;
            
            item.Clothtype = Clothtype;
            
            item.CM35 = CM35;
            
            item.Jiaji = Jiaji;
            
            item.Guowai = Guowai;
            
            item.Miantang = Miantang;
            
            item.Yangpinban = Yangpinban;
            
            item.Peijian = Peijian;
            
            item.Isfangge = Isfangge;
            
            item.Banzu = Banzu;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(string Plans,string Scgydm,DateTime? Scjhrq,string Scyspd,string Schtbh,string Scggdh,string Scggbz,string Schtsl,string Schtxh,string Xtwpmc,string Xtwpks,string Xtwpys,string Ptfs,string Xtwldm,string Sckhxm,string Scjhdd,string Scjhbz,int Clothtype,int CM35,int Jiaji,int Guowai,int Miantang,int Yangpinban,int Peijian,int Isfangge,string Banzu)
	    {
		    TTestProcGetPlansDataCYNew1 item = new TTestProcGetPlansDataCYNew1();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.Plans = Plans;
				
			item.Scgydm = Scgydm;
				
			item.Scjhrq = Scjhrq;
				
			item.Scyspd = Scyspd;
				
			item.Schtbh = Schtbh;
				
			item.Scggdh = Scggdh;
				
			item.Scggbz = Scggbz;
				
			item.Schtsl = Schtsl;
				
			item.Schtxh = Schtxh;
				
			item.Xtwpmc = Xtwpmc;
				
			item.Xtwpks = Xtwpks;
				
			item.Xtwpys = Xtwpys;
				
			item.Ptfs = Ptfs;
				
			item.Xtwldm = Xtwldm;
				
			item.Sckhxm = Sckhxm;
				
			item.Scjhdd = Scjhdd;
				
			item.Scjhbz = Scjhbz;
				
			item.Clothtype = Clothtype;
				
			item.CM35 = CM35;
				
			item.Jiaji = Jiaji;
				
			item.Guowai = Guowai;
				
			item.Miantang = Miantang;
				
			item.Yangpinban = Yangpinban;
				
			item.Peijian = Peijian;
				
			item.Isfangge = Isfangge;
				
			item.Banzu = Banzu;
				
	        item.Save(UserName);
	    }
    }
}
