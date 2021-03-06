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
    /// Controller class for T_PlanM
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class TPlanMController
    {
        // Preload our schema..
        TPlanM thisSchemaLoad = new TPlanM();
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
        public TPlanMCollection FetchAll()
        {
            TPlanMCollection coll = new TPlanMCollection();
            Query qry = new Query(TPlanM.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public TPlanMCollection FetchByID(object Scggdh)
        {
            TPlanMCollection coll = new TPlanMCollection().Where("SCGGDH", Scggdh).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public TPlanMCollection FetchByQuery(Query qry)
        {
            TPlanMCollection coll = new TPlanMCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object Scggdh)
        {
            return (TPlanM.Delete(Scggdh) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object Scggdh)
        {
            return (TPlanM.Destroy(Scggdh) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(string Scggdh,string Khdh,string Sczsbh,string Schtbh,string Scgcmc,string Sczsdl,int Scnlzy,string Wlbm,short Status,string PlanType,DateTime? Ddjhrq,short Isypb,short MESStatus,int Cutternum,short BPMStatus,short FactoryStatus)
	    {
		    TPlanM item = new TPlanM();
		    
            item.Scggdh = Scggdh;
            
            item.Khdh = Khdh;
            
            item.Sczsbh = Sczsbh;
            
            item.Schtbh = Schtbh;
            
            item.Scgcmc = Scgcmc;
            
            item.Sczsdl = Sczsdl;
            
            item.Scnlzy = Scnlzy;
            
            item.Wlbm = Wlbm;
            
            item.Status = Status;
            
            item.PlanType = PlanType;
            
            item.Ddjhrq = Ddjhrq;
            
            item.Isypb = Isypb;
            
            item.MESStatus = MESStatus;
            
            item.Cutternum = Cutternum;
            
            item.BPMStatus = BPMStatus;
            
            item.FactoryStatus = FactoryStatus;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(int PlanMID,string Scggdh,string Khdh,string Sczsbh,string Schtbh,string Scgcmc,string Sczsdl,int Scnlzy,string Wlbm,short Status,string PlanType,DateTime? Ddjhrq,short Isypb,short MESStatus,int Cutternum,short BPMStatus,short FactoryStatus)
	    {
		    TPlanM item = new TPlanM();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.PlanMID = PlanMID;
				
			item.Scggdh = Scggdh;
				
			item.Khdh = Khdh;
				
			item.Sczsbh = Sczsbh;
				
			item.Schtbh = Schtbh;
				
			item.Scgcmc = Scgcmc;
				
			item.Sczsdl = Sczsdl;
				
			item.Scnlzy = Scnlzy;
				
			item.Wlbm = Wlbm;
				
			item.Status = Status;
				
			item.PlanType = PlanType;
				
			item.Ddjhrq = Ddjhrq;
				
			item.Isypb = Isypb;
				
			item.MESStatus = MESStatus;
				
			item.Cutternum = Cutternum;
				
			item.BPMStatus = BPMStatus;
				
			item.FactoryStatus = FactoryStatus;
				
	        item.Save(UserName);
	    }
    }
}
