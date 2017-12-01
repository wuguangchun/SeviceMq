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
namespace Test1
{
	/// <summary>
	/// Strongly-typed collection for the TPlan class.
	/// </summary>
    [Serializable]
	public partial class TPlanCollection : ActiveList<TPlan, TPlanCollection>
	{	   
		public TPlanCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>TPlanCollection</returns>
		public TPlanCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                TPlan o = this[i];
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
	/// This is an ActiveRecord class which wraps the T_PlanS table.
	/// </summary>
	[Serializable]
	public partial class TPlan : ActiveRecord<TPlan>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public TPlan()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public TPlan(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public TPlan(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public TPlan(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("T_PlanS", TableType.Table, DataService.GetInstance("Test1"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarPlansid = new TableSchema.TableColumn(schema);
				colvarPlansid.ColumnName = "PLANSID";
				colvarPlansid.DataType = DbType.Int32;
				colvarPlansid.MaxLength = 0;
				colvarPlansid.AutoIncrement = true;
				colvarPlansid.IsNullable = false;
				colvarPlansid.IsPrimaryKey = false;
				colvarPlansid.IsForeignKey = false;
				colvarPlansid.IsReadOnly = false;
				colvarPlansid.DefaultSetting = @"";
				colvarPlansid.ForeignKeyTableName = "";
				schema.Columns.Add(colvarPlansid);
				
				TableSchema.TableColumn colvarPlanmid = new TableSchema.TableColumn(schema);
				colvarPlanmid.ColumnName = "PLANMID";
				colvarPlanmid.DataType = DbType.Int32;
				colvarPlanmid.MaxLength = 0;
				colvarPlanmid.AutoIncrement = false;
				colvarPlanmid.IsNullable = true;
				colvarPlanmid.IsPrimaryKey = false;
				colvarPlanmid.IsForeignKey = false;
				colvarPlanmid.IsReadOnly = false;
				colvarPlanmid.DefaultSetting = @"";
				colvarPlanmid.ForeignKeyTableName = "";
				schema.Columns.Add(colvarPlanmid);
				
				TableSchema.TableColumn colvarSczsbh = new TableSchema.TableColumn(schema);
				colvarSczsbh.ColumnName = "SCZSBH";
				colvarSczsbh.DataType = DbType.AnsiString;
				colvarSczsbh.MaxLength = 12;
				colvarSczsbh.AutoIncrement = false;
				colvarSczsbh.IsNullable = true;
				colvarSczsbh.IsPrimaryKey = false;
				colvarSczsbh.IsForeignKey = false;
				colvarSczsbh.IsReadOnly = false;
				colvarSczsbh.DefaultSetting = @"";
				colvarSczsbh.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSczsbh);
				
				TableSchema.TableColumn colvarKhdh = new TableSchema.TableColumn(schema);
				colvarKhdh.ColumnName = "KHDH";
				colvarKhdh.DataType = DbType.AnsiString;
				colvarKhdh.MaxLength = 30;
				colvarKhdh.AutoIncrement = false;
				colvarKhdh.IsNullable = false;
				colvarKhdh.IsPrimaryKey = true;
				colvarKhdh.IsForeignKey = false;
				colvarKhdh.IsReadOnly = false;
				colvarKhdh.DefaultSetting = @"";
				colvarKhdh.ForeignKeyTableName = "";
				schema.Columns.Add(colvarKhdh);
				
				TableSchema.TableColumn colvarGyfl = new TableSchema.TableColumn(schema);
				colvarGyfl.ColumnName = "GYFL";
				colvarGyfl.DataType = DbType.AnsiString;
				colvarGyfl.MaxLength = 30;
				colvarGyfl.AutoIncrement = false;
				colvarGyfl.IsNullable = true;
				colvarGyfl.IsPrimaryKey = false;
				colvarGyfl.IsForeignKey = false;
				colvarGyfl.IsReadOnly = false;
				colvarGyfl.DefaultSetting = @"";
				colvarGyfl.ForeignKeyTableName = "";
				schema.Columns.Add(colvarGyfl);
				
				TableSchema.TableColumn colvarSldl = new TableSchema.TableColumn(schema);
				colvarSldl.ColumnName = "SLDL";
				colvarSldl.DataType = DbType.AnsiString;
				colvarSldl.MaxLength = 50;
				colvarSldl.AutoIncrement = false;
				colvarSldl.IsNullable = true;
				colvarSldl.IsPrimaryKey = false;
				colvarSldl.IsForeignKey = false;
				colvarSldl.IsReadOnly = false;
				colvarSldl.DefaultSetting = @"";
				colvarSldl.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSldl);
				
				TableSchema.TableColumn colvarCpzl = new TableSchema.TableColumn(schema);
				colvarCpzl.ColumnName = "CPZL";
				colvarCpzl.DataType = DbType.AnsiString;
				colvarCpzl.MaxLength = 30;
				colvarCpzl.AutoIncrement = false;
				colvarCpzl.IsNullable = true;
				colvarCpzl.IsPrimaryKey = false;
				colvarCpzl.IsForeignKey = false;
				colvarCpzl.IsReadOnly = false;
				colvarCpzl.DefaultSetting = @"";
				colvarCpzl.ForeignKeyTableName = "";
				schema.Columns.Add(colvarCpzl);
				
				TableSchema.TableColumn colvarPbxh = new TableSchema.TableColumn(schema);
				colvarPbxh.ColumnName = "PBXH";
				colvarPbxh.DataType = DbType.Int32;
				colvarPbxh.MaxLength = 0;
				colvarPbxh.AutoIncrement = false;
				colvarPbxh.IsNullable = true;
				colvarPbxh.IsPrimaryKey = false;
				colvarPbxh.IsForeignKey = false;
				colvarPbxh.IsReadOnly = false;
				colvarPbxh.DefaultSetting = @"";
				colvarPbxh.ForeignKeyTableName = "";
				schema.Columns.Add(colvarPbxh);
				
				TableSchema.TableColumn colvarWlxh = new TableSchema.TableColumn(schema);
				colvarWlxh.ColumnName = "WLXH";
				colvarWlxh.DataType = DbType.Int32;
				colvarWlxh.MaxLength = 0;
				colvarWlxh.AutoIncrement = false;
				colvarWlxh.IsNullable = true;
				colvarWlxh.IsPrimaryKey = false;
				colvarWlxh.IsForeignKey = false;
				colvarWlxh.IsReadOnly = false;
				
						colvarWlxh.DefaultSetting = @"((10))";
				colvarWlxh.ForeignKeyTableName = "";
				schema.Columns.Add(colvarWlxh);
				
				TableSchema.TableColumn colvarWlbm = new TableSchema.TableColumn(schema);
				colvarWlbm.ColumnName = "WLBM";
				colvarWlbm.DataType = DbType.AnsiString;
				colvarWlbm.MaxLength = 50;
				colvarWlbm.AutoIncrement = false;
				colvarWlbm.IsNullable = false;
				colvarWlbm.IsPrimaryKey = true;
				colvarWlbm.IsForeignKey = false;
				colvarWlbm.IsReadOnly = false;
				colvarWlbm.DefaultSetting = @"";
				colvarWlbm.ForeignKeyTableName = "";
				schema.Columns.Add(colvarWlbm);
				
				TableSchema.TableColumn colvarWlfk = new TableSchema.TableColumn(schema);
				colvarWlfk.ColumnName = "WLFK";
				colvarWlfk.DataType = DbType.Decimal;
				colvarWlfk.MaxLength = 0;
				colvarWlfk.AutoIncrement = false;
				colvarWlfk.IsNullable = false;
				colvarWlfk.IsPrimaryKey = true;
				colvarWlfk.IsForeignKey = false;
				colvarWlfk.IsReadOnly = false;
				colvarWlfk.DefaultSetting = @"";
				colvarWlfk.ForeignKeyTableName = "";
				schema.Columns.Add(colvarWlfk);
				
				TableSchema.TableColumn colvarWlhy = new TableSchema.TableColumn(schema);
				colvarWlhy.ColumnName = "WLHY";
				colvarWlhy.DataType = DbType.Decimal;
				colvarWlhy.MaxLength = 0;
				colvarWlhy.AutoIncrement = false;
				colvarWlhy.IsNullable = false;
				colvarWlhy.IsPrimaryKey = true;
				colvarWlhy.IsForeignKey = false;
				colvarWlhy.IsReadOnly = false;
				
						colvarWlhy.DefaultSetting = @"((0))";
				colvarWlhy.ForeignKeyTableName = "";
				schema.Columns.Add(colvarWlhy);
				
				TableSchema.TableColumn colvarTgsx = new TableSchema.TableColumn(schema);
				colvarTgsx.ColumnName = "TGSX";
				colvarTgsx.DataType = DbType.AnsiString;
				colvarTgsx.MaxLength = 30;
				colvarTgsx.AutoIncrement = false;
				colvarTgsx.IsNullable = false;
				colvarTgsx.IsPrimaryKey = true;
				colvarTgsx.IsForeignKey = false;
				colvarTgsx.IsReadOnly = false;
				colvarTgsx.DefaultSetting = @"";
				colvarTgsx.ForeignKeyTableName = "";
				schema.Columns.Add(colvarTgsx);
				
				TableSchema.TableColumn colvarTgkd = new TableSchema.TableColumn(schema);
				colvarTgkd.ColumnName = "TGKD";
				colvarTgkd.DataType = DbType.Decimal;
				colvarTgkd.MaxLength = 0;
				colvarTgkd.AutoIncrement = false;
				colvarTgkd.IsNullable = true;
				colvarTgkd.IsPrimaryKey = false;
				colvarTgkd.IsForeignKey = false;
				colvarTgkd.IsReadOnly = false;
				colvarTgkd.DefaultSetting = @"";
				colvarTgkd.ForeignKeyTableName = "";
				schema.Columns.Add(colvarTgkd);
				
				TableSchema.TableColumn colvarWlbw = new TableSchema.TableColumn(schema);
				colvarWlbw.ColumnName = "WLBW";
				colvarWlbw.DataType = DbType.AnsiString;
				colvarWlbw.MaxLength = 200;
				colvarWlbw.AutoIncrement = false;
				colvarWlbw.IsNullable = false;
				colvarWlbw.IsPrimaryKey = true;
				colvarWlbw.IsForeignKey = false;
				colvarWlbw.IsReadOnly = false;
				colvarWlbw.DefaultSetting = @"";
				colvarWlbw.ForeignKeyTableName = "";
				schema.Columns.Add(colvarWlbw);
				
				TableSchema.TableColumn colvarIsaps = new TableSchema.TableColumn(schema);
				colvarIsaps.ColumnName = "ISAPS";
				colvarIsaps.DataType = DbType.Boolean;
				colvarIsaps.MaxLength = 0;
				colvarIsaps.AutoIncrement = false;
				colvarIsaps.IsNullable = true;
				colvarIsaps.IsPrimaryKey = false;
				colvarIsaps.IsForeignKey = false;
				colvarIsaps.IsReadOnly = false;
				
						colvarIsaps.DefaultSetting = @"((1))";
				colvarIsaps.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIsaps);
				
				TableSchema.TableColumn colvarChildKHDDBH = new TableSchema.TableColumn(schema);
				colvarChildKHDDBH.ColumnName = "ChildKHDDBH";
				colvarChildKHDDBH.DataType = DbType.AnsiString;
				colvarChildKHDDBH.MaxLength = 60;
				colvarChildKHDDBH.AutoIncrement = false;
				colvarChildKHDDBH.IsNullable = true;
				colvarChildKHDDBH.IsPrimaryKey = false;
				colvarChildKHDDBH.IsForeignKey = false;
				colvarChildKHDDBH.IsReadOnly = false;
				colvarChildKHDDBH.DefaultSetting = @"";
				colvarChildKHDDBH.ForeignKeyTableName = "";
				schema.Columns.Add(colvarChildKHDDBH);
				
				TableSchema.TableColumn colvarWlks = new TableSchema.TableColumn(schema);
				colvarWlks.ColumnName = "WLKS";
				colvarWlks.DataType = DbType.AnsiString;
				colvarWlks.MaxLength = 50;
				colvarWlks.AutoIncrement = false;
				colvarWlks.IsNullable = true;
				colvarWlks.IsPrimaryKey = false;
				colvarWlks.IsForeignKey = false;
				colvarWlks.IsReadOnly = false;
				colvarWlks.DefaultSetting = @"";
				colvarWlks.ForeignKeyTableName = "";
				schema.Columns.Add(colvarWlks);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["Test1"].AddSchema("T_PlanS",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("Plansid")]
		[Bindable(true)]
		public int Plansid 
		{
			get { return GetColumnValue<int>(Columns.Plansid); }
			set { SetColumnValue(Columns.Plansid, value); }
		}
		  
		[XmlAttribute("Planmid")]
		[Bindable(true)]
		public int? Planmid 
		{
			get { return GetColumnValue<int?>(Columns.Planmid); }
			set { SetColumnValue(Columns.Planmid, value); }
		}
		  
		[XmlAttribute("Sczsbh")]
		[Bindable(true)]
		public string Sczsbh 
		{
			get { return GetColumnValue<string>(Columns.Sczsbh); }
			set { SetColumnValue(Columns.Sczsbh, value); }
		}
		  
		[XmlAttribute("Khdh")]
		[Bindable(true)]
		public string Khdh 
		{
			get { return GetColumnValue<string>(Columns.Khdh); }
			set { SetColumnValue(Columns.Khdh, value); }
		}
		  
		[XmlAttribute("Gyfl")]
		[Bindable(true)]
		public string Gyfl 
		{
			get { return GetColumnValue<string>(Columns.Gyfl); }
			set { SetColumnValue(Columns.Gyfl, value); }
		}
		  
		[XmlAttribute("Sldl")]
		[Bindable(true)]
		public string Sldl 
		{
			get { return GetColumnValue<string>(Columns.Sldl); }
			set { SetColumnValue(Columns.Sldl, value); }
		}
		  
		[XmlAttribute("Cpzl")]
		[Bindable(true)]
		public string Cpzl 
		{
			get { return GetColumnValue<string>(Columns.Cpzl); }
			set { SetColumnValue(Columns.Cpzl, value); }
		}
		  
		[XmlAttribute("Pbxh")]
		[Bindable(true)]
		public int? Pbxh 
		{
			get { return GetColumnValue<int?>(Columns.Pbxh); }
			set { SetColumnValue(Columns.Pbxh, value); }
		}
		  
		[XmlAttribute("Wlxh")]
		[Bindable(true)]
		public int? Wlxh 
		{
			get { return GetColumnValue<int?>(Columns.Wlxh); }
			set { SetColumnValue(Columns.Wlxh, value); }
		}
		  
		[XmlAttribute("Wlbm")]
		[Bindable(true)]
		public string Wlbm 
		{
			get { return GetColumnValue<string>(Columns.Wlbm); }
			set { SetColumnValue(Columns.Wlbm, value); }
		}
		  
		[XmlAttribute("Wlfk")]
		[Bindable(true)]
		public decimal Wlfk 
		{
			get { return GetColumnValue<decimal>(Columns.Wlfk); }
			set { SetColumnValue(Columns.Wlfk, value); }
		}
		  
		[XmlAttribute("Wlhy")]
		[Bindable(true)]
		public decimal Wlhy 
		{
			get { return GetColumnValue<decimal>(Columns.Wlhy); }
			set { SetColumnValue(Columns.Wlhy, value); }
		}
		  
		[XmlAttribute("Tgsx")]
		[Bindable(true)]
		public string Tgsx 
		{
			get { return GetColumnValue<string>(Columns.Tgsx); }
			set { SetColumnValue(Columns.Tgsx, value); }
		}
		  
		[XmlAttribute("Tgkd")]
		[Bindable(true)]
		public decimal? Tgkd 
		{
			get { return GetColumnValue<decimal?>(Columns.Tgkd); }
			set { SetColumnValue(Columns.Tgkd, value); }
		}
		  
		[XmlAttribute("Wlbw")]
		[Bindable(true)]
		public string Wlbw 
		{
			get { return GetColumnValue<string>(Columns.Wlbw); }
			set { SetColumnValue(Columns.Wlbw, value); }
		}
		  
		[XmlAttribute("Isaps")]
		[Bindable(true)]
		public bool? Isaps 
		{
			get { return GetColumnValue<bool?>(Columns.Isaps); }
			set { SetColumnValue(Columns.Isaps, value); }
		}
		  
		[XmlAttribute("ChildKHDDBH")]
		[Bindable(true)]
		public string ChildKHDDBH 
		{
			get { return GetColumnValue<string>(Columns.ChildKHDDBH); }
			set { SetColumnValue(Columns.ChildKHDDBH, value); }
		}
		  
		[XmlAttribute("Wlks")]
		[Bindable(true)]
		public string Wlks 
		{
			get { return GetColumnValue<string>(Columns.Wlks); }
			set { SetColumnValue(Columns.Wlks, value); }
		}
		
		#endregion
		
		
			
		
		//no foreign key tables defined (0)
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(int? varPlanmid,string varSczsbh,string varKhdh,string varGyfl,string varSldl,string varCpzl,int? varPbxh,int? varWlxh,string varWlbm,decimal varWlfk,decimal varWlhy,string varTgsx,decimal? varTgkd,string varWlbw,bool? varIsaps,string varChildKHDDBH,string varWlks)
		{
			TPlan item = new TPlan();
			
			item.Planmid = varPlanmid;
			
			item.Sczsbh = varSczsbh;
			
			item.Khdh = varKhdh;
			
			item.Gyfl = varGyfl;
			
			item.Sldl = varSldl;
			
			item.Cpzl = varCpzl;
			
			item.Pbxh = varPbxh;
			
			item.Wlxh = varWlxh;
			
			item.Wlbm = varWlbm;
			
			item.Wlfk = varWlfk;
			
			item.Wlhy = varWlhy;
			
			item.Tgsx = varTgsx;
			
			item.Tgkd = varTgkd;
			
			item.Wlbw = varWlbw;
			
			item.Isaps = varIsaps;
			
			item.ChildKHDDBH = varChildKHDDBH;
			
			item.Wlks = varWlks;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varPlansid,int? varPlanmid,string varSczsbh,string varKhdh,string varGyfl,string varSldl,string varCpzl,int? varPbxh,int? varWlxh,string varWlbm,decimal varWlfk,decimal varWlhy,string varTgsx,decimal? varTgkd,string varWlbw,bool? varIsaps,string varChildKHDDBH,string varWlks)
		{
			TPlan item = new TPlan();
			
				item.Plansid = varPlansid;
			
				item.Planmid = varPlanmid;
			
				item.Sczsbh = varSczsbh;
			
				item.Khdh = varKhdh;
			
				item.Gyfl = varGyfl;
			
				item.Sldl = varSldl;
			
				item.Cpzl = varCpzl;
			
				item.Pbxh = varPbxh;
			
				item.Wlxh = varWlxh;
			
				item.Wlbm = varWlbm;
			
				item.Wlfk = varWlfk;
			
				item.Wlhy = varWlhy;
			
				item.Tgsx = varTgsx;
			
				item.Tgkd = varTgkd;
			
				item.Wlbw = varWlbw;
			
				item.Isaps = varIsaps;
			
				item.ChildKHDDBH = varChildKHDDBH;
			
				item.Wlks = varWlks;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn PlansidColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn PlanmidColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        public static TableSchema.TableColumn SczsbhColumn
        {
            get { return Schema.Columns[2]; }
        }
        
        
        
        public static TableSchema.TableColumn KhdhColumn
        {
            get { return Schema.Columns[3]; }
        }
        
        
        
        public static TableSchema.TableColumn GyflColumn
        {
            get { return Schema.Columns[4]; }
        }
        
        
        
        public static TableSchema.TableColumn SldlColumn
        {
            get { return Schema.Columns[5]; }
        }
        
        
        
        public static TableSchema.TableColumn CpzlColumn
        {
            get { return Schema.Columns[6]; }
        }
        
        
        
        public static TableSchema.TableColumn PbxhColumn
        {
            get { return Schema.Columns[7]; }
        }
        
        
        
        public static TableSchema.TableColumn WlxhColumn
        {
            get { return Schema.Columns[8]; }
        }
        
        
        
        public static TableSchema.TableColumn WlbmColumn
        {
            get { return Schema.Columns[9]; }
        }
        
        
        
        public static TableSchema.TableColumn WlfkColumn
        {
            get { return Schema.Columns[10]; }
        }
        
        
        
        public static TableSchema.TableColumn WlhyColumn
        {
            get { return Schema.Columns[11]; }
        }
        
        
        
        public static TableSchema.TableColumn TgsxColumn
        {
            get { return Schema.Columns[12]; }
        }
        
        
        
        public static TableSchema.TableColumn TgkdColumn
        {
            get { return Schema.Columns[13]; }
        }
        
        
        
        public static TableSchema.TableColumn WlbwColumn
        {
            get { return Schema.Columns[14]; }
        }
        
        
        
        public static TableSchema.TableColumn IsapsColumn
        {
            get { return Schema.Columns[15]; }
        }
        
        
        
        public static TableSchema.TableColumn ChildKHDDBHColumn
        {
            get { return Schema.Columns[16]; }
        }
        
        
        
        public static TableSchema.TableColumn WlksColumn
        {
            get { return Schema.Columns[17]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string Plansid = @"PLANSID";
			 public static string Planmid = @"PLANMID";
			 public static string Sczsbh = @"SCZSBH";
			 public static string Khdh = @"KHDH";
			 public static string Gyfl = @"GYFL";
			 public static string Sldl = @"SLDL";
			 public static string Cpzl = @"CPZL";
			 public static string Pbxh = @"PBXH";
			 public static string Wlxh = @"WLXH";
			 public static string Wlbm = @"WLBM";
			 public static string Wlfk = @"WLFK";
			 public static string Wlhy = @"WLHY";
			 public static string Tgsx = @"TGSX";
			 public static string Tgkd = @"TGKD";
			 public static string Wlbw = @"WLBW";
			 public static string Isaps = @"ISAPS";
			 public static string ChildKHDDBH = @"ChildKHDDBH";
			 public static string Wlks = @"WLKS";
						
		}
		#endregion
		
		#region Update PK Collections
		
        #endregion
    
        #region Deep Save
		
        #endregion
	}
}
