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
	/// Strongly-typed collection for the SCT95 class.
	/// </summary>
    [Serializable]
	public partial class SCT95Collection : ActiveList<SCT95, SCT95Collection>
	{	   
		public SCT95Collection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>SCT95Collection</returns>
		public SCT95Collection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                SCT95 o = this[i];
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
	/// This is an ActiveRecord class which wraps the SCT95 table.
	/// </summary>
	[Serializable]
	public partial class SCT95 : ActiveRecord<SCT95>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public SCT95()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public SCT95(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public SCT95(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public SCT95(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("SCT95", TableType.Table, DataService.GetInstance("ErpNowthwin"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"FYERP";
				//columns
				
				TableSchema.TableColumn colvarSclldh = new TableSchema.TableColumn(schema);
				colvarSclldh.ColumnName = "SCLLDH";
				colvarSclldh.DataType = DbType.String;
				colvarSclldh.MaxLength = 12;
				colvarSclldh.AutoIncrement = false;
				colvarSclldh.IsNullable = false;
				colvarSclldh.IsPrimaryKey = true;
				colvarSclldh.IsForeignKey = false;
				colvarSclldh.IsReadOnly = false;
				colvarSclldh.DefaultSetting = @"";
				colvarSclldh.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSclldh);
				
				TableSchema.TableColumn colvarScllxh = new TableSchema.TableColumn(schema);
				colvarScllxh.ColumnName = "SCLLXH";
				colvarScllxh.DataType = DbType.Decimal;
				colvarScllxh.MaxLength = 0;
				colvarScllxh.AutoIncrement = false;
				colvarScllxh.IsNullable = false;
				colvarScllxh.IsPrimaryKey = true;
				colvarScllxh.IsForeignKey = false;
				colvarScllxh.IsReadOnly = false;
				colvarScllxh.DefaultSetting = @"";
				colvarScllxh.ForeignKeyTableName = "";
				schema.Columns.Add(colvarScllxh);
				
				TableSchema.TableColumn colvarXttxhm = new TableSchema.TableColumn(schema);
				colvarXttxhm.ColumnName = "XTTXHM";
				colvarXttxhm.DataType = DbType.String;
				colvarXttxhm.MaxLength = 20;
				colvarXttxhm.AutoIncrement = false;
				colvarXttxhm.IsNullable = true;
				colvarXttxhm.IsPrimaryKey = false;
				colvarXttxhm.IsForeignKey = false;
				colvarXttxhm.IsReadOnly = false;
				colvarXttxhm.DefaultSetting = @"";
				colvarXttxhm.ForeignKeyTableName = "";
				schema.Columns.Add(colvarXttxhm);
				
				TableSchema.TableColumn colvarScllsl = new TableSchema.TableColumn(schema);
				colvarScllsl.ColumnName = "SCLLSL";
				colvarScllsl.DataType = DbType.Decimal;
				colvarScllsl.MaxLength = 0;
				colvarScllsl.AutoIncrement = false;
				colvarScllsl.IsNullable = true;
				colvarScllsl.IsPrimaryKey = false;
				colvarScllsl.IsForeignKey = false;
				colvarScllsl.IsReadOnly = false;
				colvarScllsl.DefaultSetting = @"";
				colvarScllsl.ForeignKeyTableName = "";
				schema.Columns.Add(colvarScllsl);
				
				TableSchema.TableColumn colvarScllbz = new TableSchema.TableColumn(schema);
				colvarScllbz.ColumnName = "SCLLBZ";
				colvarScllbz.DataType = DbType.String;
				colvarScllbz.MaxLength = 255;
				colvarScllbz.AutoIncrement = false;
				colvarScllbz.IsNullable = true;
				colvarScllbz.IsPrimaryKey = false;
				colvarScllbz.IsForeignKey = false;
				colvarScllbz.IsReadOnly = false;
				colvarScllbz.DefaultSetting = @"";
				colvarScllbz.ForeignKeyTableName = "";
				schema.Columns.Add(colvarScllbz);
				
				TableSchema.TableColumn colvarSczsbh = new TableSchema.TableColumn(schema);
				colvarSczsbh.ColumnName = "SCZSBH";
				colvarSczsbh.DataType = DbType.String;
				colvarSczsbh.MaxLength = 12;
				colvarSczsbh.AutoIncrement = false;
				colvarSczsbh.IsNullable = true;
				colvarSczsbh.IsPrimaryKey = false;
				colvarSczsbh.IsForeignKey = false;
				colvarSczsbh.IsReadOnly = false;
				colvarSczsbh.DefaultSetting = @"";
				colvarSczsbh.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSczsbh);
				
				TableSchema.TableColumn colvarSczsxh = new TableSchema.TableColumn(schema);
				colvarSczsxh.ColumnName = "SCZSXH";
				colvarSczsxh.DataType = DbType.Decimal;
				colvarSczsxh.MaxLength = 0;
				colvarSczsxh.AutoIncrement = false;
				colvarSczsxh.IsNullable = true;
				colvarSczsxh.IsPrimaryKey = false;
				colvarSczsxh.IsForeignKey = false;
				colvarSczsxh.IsReadOnly = false;
				colvarSczsxh.DefaultSetting = @"";
				colvarSczsxh.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSczsxh);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["ErpNowthwin"].AddSchema("SCT95",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("Sclldh")]
		[Bindable(true)]
		public string Sclldh 
		{
			get { return GetColumnValue<string>(Columns.Sclldh); }
			set { SetColumnValue(Columns.Sclldh, value); }
		}
		  
		[XmlAttribute("Scllxh")]
		[Bindable(true)]
		public decimal Scllxh 
		{
			get { return GetColumnValue<decimal>(Columns.Scllxh); }
			set { SetColumnValue(Columns.Scllxh, value); }
		}
		  
		[XmlAttribute("Xttxhm")]
		[Bindable(true)]
		public string Xttxhm 
		{
			get { return GetColumnValue<string>(Columns.Xttxhm); }
			set { SetColumnValue(Columns.Xttxhm, value); }
		}
		  
		[XmlAttribute("Scllsl")]
		[Bindable(true)]
		public decimal? Scllsl 
		{
			get { return GetColumnValue<decimal?>(Columns.Scllsl); }
			set { SetColumnValue(Columns.Scllsl, value); }
		}
		  
		[XmlAttribute("Scllbz")]
		[Bindable(true)]
		public string Scllbz 
		{
			get { return GetColumnValue<string>(Columns.Scllbz); }
			set { SetColumnValue(Columns.Scllbz, value); }
		}
		  
		[XmlAttribute("Sczsbh")]
		[Bindable(true)]
		public string Sczsbh 
		{
			get { return GetColumnValue<string>(Columns.Sczsbh); }
			set { SetColumnValue(Columns.Sczsbh, value); }
		}
		  
		[XmlAttribute("Sczsxh")]
		[Bindable(true)]
		public decimal? Sczsxh 
		{
			get { return GetColumnValue<decimal?>(Columns.Sczsxh); }
			set { SetColumnValue(Columns.Sczsxh, value); }
		}
		
		#endregion
		
		
			
		
		//no foreign key tables defined (0)
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(string varSclldh,decimal varScllxh,string varXttxhm,decimal? varScllsl,string varScllbz,string varSczsbh,decimal? varSczsxh)
		{
			SCT95 item = new SCT95();
			
			item.Sclldh = varSclldh;
			
			item.Scllxh = varScllxh;
			
			item.Xttxhm = varXttxhm;
			
			item.Scllsl = varScllsl;
			
			item.Scllbz = varScllbz;
			
			item.Sczsbh = varSczsbh;
			
			item.Sczsxh = varSczsxh;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(string varSclldh,decimal varScllxh,string varXttxhm,decimal? varScllsl,string varScllbz,string varSczsbh,decimal? varSczsxh)
		{
			SCT95 item = new SCT95();
			
				item.Sclldh = varSclldh;
			
				item.Scllxh = varScllxh;
			
				item.Xttxhm = varXttxhm;
			
				item.Scllsl = varScllsl;
			
				item.Scllbz = varScllbz;
			
				item.Sczsbh = varSczsbh;
			
				item.Sczsxh = varSczsxh;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn SclldhColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn ScllxhColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        public static TableSchema.TableColumn XttxhmColumn
        {
            get { return Schema.Columns[2]; }
        }
        
        
        
        public static TableSchema.TableColumn ScllslColumn
        {
            get { return Schema.Columns[3]; }
        }
        
        
        
        public static TableSchema.TableColumn ScllbzColumn
        {
            get { return Schema.Columns[4]; }
        }
        
        
        
        public static TableSchema.TableColumn SczsbhColumn
        {
            get { return Schema.Columns[5]; }
        }
        
        
        
        public static TableSchema.TableColumn SczsxhColumn
        {
            get { return Schema.Columns[6]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string Sclldh = @"SCLLDH";
			 public static string Scllxh = @"SCLLXH";
			 public static string Xttxhm = @"XTTXHM";
			 public static string Scllsl = @"SCLLSL";
			 public static string Scllbz = @"SCLLBZ";
			 public static string Sczsbh = @"SCZSBH";
			 public static string Sczsxh = @"SCZSXH";
						
		}
		#endregion
		
		#region Update PK Collections
		
        #endregion
    
        #region Deep Save
		
        #endregion
	}
}
