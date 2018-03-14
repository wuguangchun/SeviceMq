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
	/// Strongly-typed collection for the TBasisExcelTemplate class.
	/// </summary>
    [Serializable]
	public partial class TBasisExcelTemplateCollection : ActiveList<TBasisExcelTemplate, TBasisExcelTemplateCollection>
	{	   
		public TBasisExcelTemplateCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>TBasisExcelTemplateCollection</returns>
		public TBasisExcelTemplateCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                TBasisExcelTemplate o = this[i];
                foreach (SubSonic.Where w in this.wheres)
                {
                    bool remove = false;
                    System.Reflection.PropertyInfo pi = o.GetType().GetProperty(w.ColumnName);
                    if (pi.CanRead)
                    {
                        object val = pi.GetValue(o, null);
                        switch (w.Comparison)
                        {
                            case SubSonic.Comparison.Equals:
                                if (!val.Equals(w.ParameterValue))
                                {
                                    remove = true;
                                }
                                break;
                        }
                    }
                    if (remove)
                    {
                        this.Remove(o);
                        break;
                    }
                }
            }
            return this;
        }
		
		
	}
	/// <summary>
	/// This is an ActiveRecord class which wraps the T_Basis_ExcelTemplate table.
	/// </summary>
	[Serializable]
	public partial class TBasisExcelTemplate : ActiveRecord<TBasisExcelTemplate>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public TBasisExcelTemplate()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public TBasisExcelTemplate(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public TBasisExcelTemplate(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public TBasisExcelTemplate(string columnName, object columnValue)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByParam(columnName,columnValue);
		}
		
		protected static void SetSQLProps() { GetTableSchema(); }
		
		#endregion
		
		#region Schema and Query Accessor	
		public static Query CreateQuery() { return new Query(Schema); }
		public static TableSchema.Table Schema
		{
			get
			{
				if (BaseSchema == null)
					SetSQLProps();
				return BaseSchema;
			}
		}
		
		private static void GetTableSchema() 
		{
			if(!IsSchemaInitialized)
			{
				//Schema declaration
				TableSchema.Table schema = new TableSchema.Table("T_Basis_ExcelTemplate", TableType.Table, DataService.GetInstance("Nowthwin"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarFileName = new TableSchema.TableColumn(schema);
				colvarFileName.ColumnName = "FileName";
				colvarFileName.DataType = DbType.String;
				colvarFileName.MaxLength = 200;
				colvarFileName.AutoIncrement = false;
				colvarFileName.IsNullable = false;
				colvarFileName.IsPrimaryKey = true;
				colvarFileName.IsForeignKey = false;
				colvarFileName.IsReadOnly = false;
				colvarFileName.DefaultSetting = @"";
				colvarFileName.ForeignKeyTableName = "";
				schema.Columns.Add(colvarFileName);
				
				TableSchema.TableColumn colvarFileContext = new TableSchema.TableColumn(schema);
				colvarFileContext.ColumnName = "FileContext";
				colvarFileContext.DataType = DbType.Binary;
				colvarFileContext.MaxLength = -1;
				colvarFileContext.AutoIncrement = false;
				colvarFileContext.IsNullable = false;
				colvarFileContext.IsPrimaryKey = false;
				colvarFileContext.IsForeignKey = false;
				colvarFileContext.IsReadOnly = false;
				colvarFileContext.DefaultSetting = @"";
				colvarFileContext.ForeignKeyTableName = "";
				schema.Columns.Add(colvarFileContext);
				
				TableSchema.TableColumn colvarCreateTime = new TableSchema.TableColumn(schema);
				colvarCreateTime.ColumnName = "CreateTime";
				colvarCreateTime.DataType = DbType.DateTime;
				colvarCreateTime.MaxLength = 0;
				colvarCreateTime.AutoIncrement = false;
				colvarCreateTime.IsNullable = false;
				colvarCreateTime.IsPrimaryKey = false;
				colvarCreateTime.IsForeignKey = false;
				colvarCreateTime.IsReadOnly = false;
				
						colvarCreateTime.DefaultSetting = @"(getdate())";
				colvarCreateTime.ForeignKeyTableName = "";
				schema.Columns.Add(colvarCreateTime);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["Nowthwin"].AddSchema("T_Basis_ExcelTemplate",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("FileName")]
		[Bindable(true)]
		public string FileName 
		{
			get { return GetColumnValue<string>(Columns.FileName); }
			set { SetColumnValue(Columns.FileName, value); }
		}
		  
		[XmlAttribute("FileContext")]
		[Bindable(true)]
		public byte[] FileContext 
		{
			get { return GetColumnValue<byte[]>(Columns.FileContext); }
			set { SetColumnValue(Columns.FileContext, value); }
		}
		  
		[XmlAttribute("CreateTime")]
		[Bindable(true)]
		public DateTime CreateTime 
		{
			get { return GetColumnValue<DateTime>(Columns.CreateTime); }
			set { SetColumnValue(Columns.CreateTime, value); }
		}
		
		#endregion
		
		
			
		
		//no foreign key tables defined (0)
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(string varFileName,byte[] varFileContext,DateTime varCreateTime)
		{
			TBasisExcelTemplate item = new TBasisExcelTemplate();
			
			item.FileName = varFileName;
			
			item.FileContext = varFileContext;
			
			item.CreateTime = varCreateTime;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(string varFileName,byte[] varFileContext,DateTime varCreateTime)
		{
			TBasisExcelTemplate item = new TBasisExcelTemplate();
			
				item.FileName = varFileName;
			
				item.FileContext = varFileContext;
			
				item.CreateTime = varCreateTime;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn FileNameColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn FileContextColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        public static TableSchema.TableColumn CreateTimeColumn
        {
            get { return Schema.Columns[2]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string FileName = @"FileName";
			 public static string FileContext = @"FileContext";
			 public static string CreateTime = @"CreateTime";
						
		}
		#endregion
		
		#region Update PK Collections
		
        #endregion
    
        #region Deep Save
		
        #endregion
	}
}
