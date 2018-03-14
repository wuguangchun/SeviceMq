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
    /// Controller class for T_Basis_ExcelTemplate
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class TBasisExcelTemplateController
    {
        // Preload our schema..
        TBasisExcelTemplate thisSchemaLoad = new TBasisExcelTemplate();
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
        public TBasisExcelTemplateCollection FetchAll()
        {
            TBasisExcelTemplateCollection coll = new TBasisExcelTemplateCollection();
            Query qry = new Query(TBasisExcelTemplate.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public TBasisExcelTemplateCollection FetchByID(object FileName)
        {
            TBasisExcelTemplateCollection coll = new TBasisExcelTemplateCollection().Where("FileName", FileName).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public TBasisExcelTemplateCollection FetchByQuery(Query qry)
        {
            TBasisExcelTemplateCollection coll = new TBasisExcelTemplateCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object FileName)
        {
            return (TBasisExcelTemplate.Delete(FileName) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object FileName)
        {
            return (TBasisExcelTemplate.Destroy(FileName) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(string FileName,byte[] FileContext,DateTime CreateTime)
	    {
		    TBasisExcelTemplate item = new TBasisExcelTemplate();
		    
            item.FileName = FileName;
            
            item.FileContext = FileContext;
            
            item.CreateTime = CreateTime;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(string FileName,byte[] FileContext,DateTime CreateTime)
	    {
		    TBasisExcelTemplate item = new TBasisExcelTemplate();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.FileName = FileName;
				
			item.FileContext = FileContext;
				
			item.CreateTime = CreateTime;
				
	        item.Save(UserName);
	    }
    }
}
