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
    /// Controller class for SCT28
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class SCT28Controller
    {
        // Preload our schema..
        SCT28 thisSchemaLoad = new SCT28();
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
        public SCT28Collection FetchAll()
        {
            SCT28Collection coll = new SCT28Collection();
            Query qry = new Query(SCT28.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public SCT28Collection FetchByID(object Sczsbh)
        {
            SCT28Collection coll = new SCT28Collection().Where("SCZSBH", Sczsbh).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public SCT28Collection FetchByQuery(Query qry)
        {
            SCT28Collection coll = new SCT28Collection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object Sczsbh)
        {
            return (SCT28.Delete(Sczsbh) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object Sczsbh)
        {
            return (SCT28.Destroy(Sczsbh) == 1);
        }
        
        
        
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(string Sczsbh,string Schtbh,string Xtwpks,string Xtwpys,int Scclxh)
        {
            Query qry = new Query(SCT28.Schema);
            qry.QueryType = QueryType.Delete;
            qry.AddWhere("Sczsbh", Sczsbh).AND("Schtbh", Schtbh).AND("Xtwpks", Xtwpks).AND("Xtwpys", Xtwpys).AND("Scclxh", Scclxh);
            qry.Execute();
            return (true);
        }        
       
    	
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(string Sczsbh,string Schtbh,string Xtwpks,string Xtwpys,int Scclxh,string Scfddm,string Xttxhm,int? Scbzyl,int? Scgcsh,int? Scyfsl,string Scytdm,string Scylbz,string Scglbz)
	    {
		    SCT28 item = new SCT28();
		    
            item.Sczsbh = Sczsbh;
            
            item.Schtbh = Schtbh;
            
            item.Xtwpks = Xtwpks;
            
            item.Xtwpys = Xtwpys;
            
            item.Scclxh = Scclxh;
            
            item.Scfddm = Scfddm;
            
            item.Xttxhm = Xttxhm;
            
            item.Scbzyl = Scbzyl;
            
            item.Scgcsh = Scgcsh;
            
            item.Scyfsl = Scyfsl;
            
            item.Scytdm = Scytdm;
            
            item.Scylbz = Scylbz;
            
            item.Scglbz = Scglbz;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(string Sczsbh,string Schtbh,string Xtwpks,string Xtwpys,int Scclxh,string Scfddm,string Xttxhm,int? Scbzyl,int? Scgcsh,int? Scyfsl,string Scytdm,string Scylbz,string Scglbz)
	    {
		    SCT28 item = new SCT28();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.Sczsbh = Sczsbh;
				
			item.Schtbh = Schtbh;
				
			item.Xtwpks = Xtwpks;
				
			item.Xtwpys = Xtwpys;
				
			item.Scclxh = Scclxh;
				
			item.Scfddm = Scfddm;
				
			item.Xttxhm = Xttxhm;
				
			item.Scbzyl = Scbzyl;
				
			item.Scgcsh = Scgcsh;
				
			item.Scyfsl = Scyfsl;
				
			item.Scytdm = Scytdm;
				
			item.Scylbz = Scylbz;
				
			item.Scglbz = Scglbz;
				
	        item.Save(UserName);
	    }
    }
}