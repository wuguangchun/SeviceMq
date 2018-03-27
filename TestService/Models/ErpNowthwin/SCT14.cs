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
	/// Strongly-typed collection for the SCT14 class.
	/// </summary>
    [Serializable]
	public partial class SCT14Collection : ActiveList<SCT14, SCT14Collection>
	{	   
		public SCT14Collection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>SCT14Collection</returns>
		public SCT14Collection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                SCT14 o = this[i];
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
	/// This is an ActiveRecord class which wraps the SCT14 table.
	/// </summary>
	[Serializable]
	public partial class SCT14 : ActiveRecord<SCT14>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public SCT14()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public SCT14(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public SCT14(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public SCT14(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("SCT14", TableType.Table, DataService.GetInstance("ErpNowthwin"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"FYERP";
				//columns
				
				TableSchema.TableColumn colvarSchtbh = new TableSchema.TableColumn(schema);
				colvarSchtbh.ColumnName = "SCHTBH";
				colvarSchtbh.DataType = DbType.String;
				colvarSchtbh.MaxLength = 12;
				colvarSchtbh.AutoIncrement = false;
				colvarSchtbh.IsNullable = false;
				colvarSchtbh.IsPrimaryKey = true;
				colvarSchtbh.IsForeignKey = false;
				colvarSchtbh.IsReadOnly = false;
				colvarSchtbh.DefaultSetting = @"";
				colvarSchtbh.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSchtbh);
				
				TableSchema.TableColumn colvarSchtxh = new TableSchema.TableColumn(schema);
				colvarSchtxh.ColumnName = "SCHTXH";
				colvarSchtxh.DataType = DbType.Decimal;
				colvarSchtxh.MaxLength = 0;
				colvarSchtxh.AutoIncrement = false;
				colvarSchtxh.IsNullable = false;
				colvarSchtxh.IsPrimaryKey = true;
				colvarSchtxh.IsForeignKey = false;
				colvarSchtxh.IsReadOnly = false;
				colvarSchtxh.DefaultSetting = @"";
				colvarSchtxh.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSchtxh);
				
				TableSchema.TableColumn colvarScclxh = new TableSchema.TableColumn(schema);
				colvarScclxh.ColumnName = "SCCLXH";
				colvarScclxh.DataType = DbType.Decimal;
				colvarScclxh.MaxLength = 0;
				colvarScclxh.AutoIncrement = false;
				colvarScclxh.IsNullable = false;
				colvarScclxh.IsPrimaryKey = true;
				colvarScclxh.IsForeignKey = false;
				colvarScclxh.IsReadOnly = false;
				colvarScclxh.DefaultSetting = @"";
				colvarScclxh.ForeignKeyTableName = "";
				schema.Columns.Add(colvarScclxh);
				
				TableSchema.TableColumn colvarXtwpys = new TableSchema.TableColumn(schema);
				colvarXtwpys.ColumnName = "XTWPYS";
				colvarXtwpys.DataType = DbType.String;
				colvarXtwpys.MaxLength = 20;
				colvarXtwpys.AutoIncrement = false;
				colvarXtwpys.IsNullable = false;
				colvarXtwpys.IsPrimaryKey = true;
				colvarXtwpys.IsForeignKey = false;
				colvarXtwpys.IsReadOnly = false;
				colvarXtwpys.DefaultSetting = @"";
				colvarXtwpys.ForeignKeyTableName = "";
				schema.Columns.Add(colvarXtwpys);
				
				TableSchema.TableColumn colvarXtwpks = new TableSchema.TableColumn(schema);
				colvarXtwpks.ColumnName = "XTWPKS";
				colvarXtwpks.DataType = DbType.String;
				colvarXtwpks.MaxLength = 20;
				colvarXtwpks.AutoIncrement = false;
				colvarXtwpks.IsNullable = false;
				colvarXtwpks.IsPrimaryKey = true;
				colvarXtwpks.IsForeignKey = false;
				colvarXtwpks.IsReadOnly = false;
				colvarXtwpks.DefaultSetting = @"";
				colvarXtwpks.ForeignKeyTableName = "";
				schema.Columns.Add(colvarXtwpks);
				
				TableSchema.TableColumn colvarXtxmdm = new TableSchema.TableColumn(schema);
				colvarXtxmdm.ColumnName = "XTXMDM";
				colvarXtxmdm.DataType = DbType.String;
				colvarXtxmdm.MaxLength = 10;
				colvarXtxmdm.AutoIncrement = false;
				colvarXtxmdm.IsNullable = false;
				colvarXtxmdm.IsPrimaryKey = true;
				colvarXtxmdm.IsForeignKey = false;
				colvarXtxmdm.IsReadOnly = false;
				colvarXtxmdm.DefaultSetting = @"";
				colvarXtxmdm.ForeignKeyTableName = "";
				schema.Columns.Add(colvarXtxmdm);
				
				TableSchema.TableColumn colvarScfddm = new TableSchema.TableColumn(schema);
				colvarScfddm.ColumnName = "SCFDDM";
				colvarScfddm.DataType = DbType.String;
				colvarScfddm.MaxLength = 10;
				colvarScfddm.AutoIncrement = false;
				colvarScfddm.IsNullable = true;
				colvarScfddm.IsPrimaryKey = false;
				colvarScfddm.IsForeignKey = false;
				colvarScfddm.IsReadOnly = false;
				colvarScfddm.DefaultSetting = @"";
				colvarScfddm.ForeignKeyTableName = "";
				schema.Columns.Add(colvarScfddm);
				
				TableSchema.TableColumn colvarXttxhm = new TableSchema.TableColumn(schema);
				colvarXttxhm.ColumnName = "XTTXHM";
				colvarXttxhm.DataType = DbType.String;
				colvarXttxhm.MaxLength = 18;
				colvarXttxhm.AutoIncrement = false;
				colvarXttxhm.IsNullable = true;
				colvarXttxhm.IsPrimaryKey = false;
				colvarXttxhm.IsForeignKey = false;
				colvarXttxhm.IsReadOnly = false;
				colvarXttxhm.DefaultSetting = @"";
				colvarXttxhm.ForeignKeyTableName = "";
				schema.Columns.Add(colvarXttxhm);
				
				TableSchema.TableColumn colvarScgxsl = new TableSchema.TableColumn(schema);
				colvarScgxsl.ColumnName = "SCGXSL";
				colvarScgxsl.DataType = DbType.Decimal;
				colvarScgxsl.MaxLength = 0;
				colvarScgxsl.AutoIncrement = false;
				colvarScgxsl.IsNullable = true;
				colvarScgxsl.IsPrimaryKey = false;
				colvarScgxsl.IsForeignKey = false;
				colvarScgxsl.IsReadOnly = false;
				colvarScgxsl.DefaultSetting = @"";
				colvarScgxsl.ForeignKeyTableName = "";
				schema.Columns.Add(colvarScgxsl);
				
				TableSchema.TableColumn colvarScytdm = new TableSchema.TableColumn(schema);
				colvarScytdm.ColumnName = "SCYTDM";
				colvarScytdm.DataType = DbType.String;
				colvarScytdm.MaxLength = 2;
				colvarScytdm.AutoIncrement = false;
				colvarScytdm.IsNullable = true;
				colvarScytdm.IsPrimaryKey = false;
				colvarScytdm.IsForeignKey = false;
				colvarScytdm.IsReadOnly = false;
				colvarScytdm.DefaultSetting = @"";
				colvarScytdm.ForeignKeyTableName = "";
				schema.Columns.Add(colvarScytdm);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["ErpNowthwin"].AddSchema("SCT14",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("Schtbh")]
		[Bindable(true)]
		public string Schtbh 
		{
			get { return GetColumnValue<string>(Columns.Schtbh); }
			set { SetColumnValue(Columns.Schtbh, value); }
		}
		  
		[XmlAttribute("Schtxh")]
		[Bindable(true)]
		public decimal Schtxh 
		{
			get { return GetColumnValue<decimal>(Columns.Schtxh); }
			set { SetColumnValue(Columns.Schtxh, value); }
		}
		  
		[XmlAttribute("Scclxh")]
		[Bindable(true)]
		public decimal Scclxh 
		{
			get { return GetColumnValue<decimal>(Columns.Scclxh); }
			set { SetColumnValue(Columns.Scclxh, value); }
		}
		  
		[XmlAttribute("Xtwpys")]
		[Bindable(true)]
		public string Xtwpys 
		{
			get { return GetColumnValue<string>(Columns.Xtwpys); }
			set { SetColumnValue(Columns.Xtwpys, value); }
		}
		  
		[XmlAttribute("Xtwpks")]
		[Bindable(true)]
		public string Xtwpks 
		{
			get { return GetColumnValue<string>(Columns.Xtwpks); }
			set { SetColumnValue(Columns.Xtwpks, value); }
		}
		  
		[XmlAttribute("Xtxmdm")]
		[Bindable(true)]
		public string Xtxmdm 
		{
			get { return GetColumnValue<string>(Columns.Xtxmdm); }
			set { SetColumnValue(Columns.Xtxmdm, value); }
		}
		  
		[XmlAttribute("Scfddm")]
		[Bindable(true)]
		public string Scfddm 
		{
			get { return GetColumnValue<string>(Columns.Scfddm); }
			set { SetColumnValue(Columns.Scfddm, value); }
		}
		  
		[XmlAttribute("Xttxhm")]
		[Bindable(true)]
		public string Xttxhm 
		{
			get { return GetColumnValue<string>(Columns.Xttxhm); }
			set { SetColumnValue(Columns.Xttxhm, value); }
		}
		  
		[XmlAttribute("Scgxsl")]
		[Bindable(true)]
		public decimal? Scgxsl 
		{
			get { return GetColumnValue<decimal?>(Columns.Scgxsl); }
			set { SetColumnValue(Columns.Scgxsl, value); }
		}
		  
		[XmlAttribute("Scytdm")]
		[Bindable(true)]
		public string Scytdm 
		{
			get { return GetColumnValue<string>(Columns.Scytdm); }
			set { SetColumnValue(Columns.Scytdm, value); }
		}
		
		#endregion
		
		
			
		
		//no foreign key tables defined (0)
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(string varSchtbh,decimal varSchtxh,decimal varScclxh,string varXtwpys,string varXtwpks,string varXtxmdm,string varScfddm,string varXttxhm,decimal? varScgxsl,string varScytdm)
		{
			SCT14 item = new SCT14();
			
			item.Schtbh = varSchtbh;
			
			item.Schtxh = varSchtxh;
			
			item.Scclxh = varScclxh;
			
			item.Xtwpys = varXtwpys;
			
			item.Xtwpks = varXtwpks;
			
			item.Xtxmdm = varXtxmdm;
			
			item.Scfddm = varScfddm;
			
			item.Xttxhm = varXttxhm;
			
			item.Scgxsl = varScgxsl;
			
			item.Scytdm = varScytdm;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(string varSchtbh,decimal varSchtxh,decimal varScclxh,string varXtwpys,string varXtwpks,string varXtxmdm,string varScfddm,string varXttxhm,decimal? varScgxsl,string varScytdm)
		{
			SCT14 item = new SCT14();
			
				item.Schtbh = varSchtbh;
			
				item.Schtxh = varSchtxh;
			
				item.Scclxh = varScclxh;
			
				item.Xtwpys = varXtwpys;
			
				item.Xtwpks = varXtwpks;
			
				item.Xtxmdm = varXtxmdm;
			
				item.Scfddm = varScfddm;
			
				item.Xttxhm = varXttxhm;
			
				item.Scgxsl = varScgxsl;
			
				item.Scytdm = varScytdm;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn SchtbhColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn SchtxhColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        public static TableSchema.TableColumn ScclxhColumn
        {
            get { return Schema.Columns[2]; }
        }
        
        
        
        public static TableSchema.TableColumn XtwpysColumn
        {
            get { return Schema.Columns[3]; }
        }
        
        
        
        public static TableSchema.TableColumn XtwpksColumn
        {
            get { return Schema.Columns[4]; }
        }
        
        
        
        public static TableSchema.TableColumn XtxmdmColumn
        {
            get { return Schema.Columns[5]; }
        }
        
        
        
        public static TableSchema.TableColumn ScfddmColumn
        {
            get { return Schema.Columns[6]; }
        }
        
        
        
        public static TableSchema.TableColumn XttxhmColumn
        {
            get { return Schema.Columns[7]; }
        }
        
        
        
        public static TableSchema.TableColumn ScgxslColumn
        {
            get { return Schema.Columns[8]; }
        }
        
        
        
        public static TableSchema.TableColumn ScytdmColumn
        {
            get { return Schema.Columns[9]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string Schtbh = @"SCHTBH";
			 public static string Schtxh = @"SCHTXH";
			 public static string Scclxh = @"SCCLXH";
			 public static string Xtwpys = @"XTWPYS";
			 public static string Xtwpks = @"XTWPKS";
			 public static string Xtxmdm = @"XTXMDM";
			 public static string Scfddm = @"SCFDDM";
			 public static string Xttxhm = @"XTTXHM";
			 public static string Scgxsl = @"SCGXSL";
			 public static string Scytdm = @"SCYTDM";
						
		}
		#endregion
		
		#region Update PK Collections
		
        #endregion
    
        #region Deep Save
		
        #endregion
	}
}
