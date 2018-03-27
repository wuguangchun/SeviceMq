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
namespace OracleDataDomain
{
	/// <summary>
	/// Strongly-typed collection for the ZLM21 class.
	/// </summary>
    [Serializable]
	public partial class ZLM21Collection : ActiveList<ZLM21, ZLM21Collection>
	{	   
		public ZLM21Collection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>ZLM21Collection</returns>
		public ZLM21Collection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                ZLM21 o = this[i];
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
	/// This is an ActiveRecord class which wraps the ZLM21 table.
	/// </summary>
	[Serializable]
	public partial class ZLM21 : ActiveRecord<ZLM21>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public ZLM21()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public ZLM21(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public ZLM21(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public ZLM21(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("ZLM21", TableType.Table, DataService.GetInstance("ErpNowthwin"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"FYERP";
				//columns
				
				TableSchema.TableColumn colvarZlxmdm = new TableSchema.TableColumn(schema);
				colvarZlxmdm.ColumnName = "ZLXMDM";
				colvarZlxmdm.DataType = DbType.String;
				colvarZlxmdm.MaxLength = 12;
				colvarZlxmdm.AutoIncrement = false;
				colvarZlxmdm.IsNullable = false;
				colvarZlxmdm.IsPrimaryKey = true;
				colvarZlxmdm.IsForeignKey = false;
				colvarZlxmdm.IsReadOnly = false;
				colvarZlxmdm.DefaultSetting = @"";
				colvarZlxmdm.ForeignKeyTableName = "";
				schema.Columns.Add(colvarZlxmdm);
				
				TableSchema.TableColumn colvarZlxmmc = new TableSchema.TableColumn(schema);
				colvarZlxmmc.ColumnName = "ZLXMMC";
				colvarZlxmmc.DataType = DbType.String;
				colvarZlxmmc.MaxLength = 100;
				colvarZlxmmc.AutoIncrement = false;
				colvarZlxmmc.IsNullable = false;
				colvarZlxmmc.IsPrimaryKey = false;
				colvarZlxmmc.IsForeignKey = false;
				colvarZlxmmc.IsReadOnly = false;
				colvarZlxmmc.DefaultSetting = @"";
				colvarZlxmmc.ForeignKeyTableName = "";
				schema.Columns.Add(colvarZlxmmc);
				
				TableSchema.TableColumn colvarZlzjdm = new TableSchema.TableColumn(schema);
				colvarZlzjdm.ColumnName = "ZLZJDM";
				colvarZlzjdm.DataType = DbType.String;
				colvarZlzjdm.MaxLength = 12;
				colvarZlzjdm.AutoIncrement = false;
				colvarZlzjdm.IsNullable = false;
				colvarZlzjdm.IsPrimaryKey = false;
				colvarZlzjdm.IsForeignKey = false;
				colvarZlzjdm.IsReadOnly = false;
				colvarZlzjdm.DefaultSetting = @"";
				colvarZlzjdm.ForeignKeyTableName = "";
				schema.Columns.Add(colvarZlzjdm);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["ErpNowthwin"].AddSchema("ZLM21",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("Zlxmdm")]
		[Bindable(true)]
		public string Zlxmdm 
		{
			get { return GetColumnValue<string>(Columns.Zlxmdm); }
			set { SetColumnValue(Columns.Zlxmdm, value); }
		}
		  
		[XmlAttribute("Zlxmmc")]
		[Bindable(true)]
		public string Zlxmmc 
		{
			get { return GetColumnValue<string>(Columns.Zlxmmc); }
			set { SetColumnValue(Columns.Zlxmmc, value); }
		}
		  
		[XmlAttribute("Zlzjdm")]
		[Bindable(true)]
		public string Zlzjdm 
		{
			get { return GetColumnValue<string>(Columns.Zlzjdm); }
			set { SetColumnValue(Columns.Zlzjdm, value); }
		}
		
		#endregion
		
		
			
		
		//no foreign key tables defined (0)
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(string varZlxmdm,string varZlxmmc,string varZlzjdm)
		{
			ZLM21 item = new ZLM21();
			
			item.Zlxmdm = varZlxmdm;
			
			item.Zlxmmc = varZlxmmc;
			
			item.Zlzjdm = varZlzjdm;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(string varZlxmdm,string varZlxmmc,string varZlzjdm)
		{
			ZLM21 item = new ZLM21();
			
				item.Zlxmdm = varZlxmdm;
			
				item.Zlxmmc = varZlxmmc;
			
				item.Zlzjdm = varZlzjdm;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn ZlxmdmColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn ZlxmmcColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        public static TableSchema.TableColumn ZlzjdmColumn
        {
            get { return Schema.Columns[2]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string Zlxmdm = @"ZLXMDM";
			 public static string Zlxmmc = @"ZLXMMC";
			 public static string Zlzjdm = @"ZLZJDM";
						
		}
		#endregion
		
		#region Update PK Collections
		
        #endregion
    
        #region Deep Save
		
        #endregion
	}
}
