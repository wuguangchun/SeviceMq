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
	/// Strongly-typed collection for the TBLDataPLD1 class.
	/// </summary>
    [Serializable]
	public partial class TBLDataPLD1Collection : ActiveList<TBLDataPLD1, TBLDataPLD1Collection>
	{	   
		public TBLDataPLD1Collection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>TBLDataPLD1Collection</returns>
		public TBLDataPLD1Collection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                TBLDataPLD1 o = this[i];
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
	/// This is an ActiveRecord class which wraps the T_BLData_PLD1 table.
	/// </summary>
	[Serializable]
	public partial class TBLDataPLD1 : ActiveRecord<TBLDataPLD1>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public TBLDataPLD1()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public TBLDataPLD1(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public TBLDataPLD1(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public TBLDataPLD1(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("T_BLData_PLD1", TableType.Table, DataService.GetInstance("Nowthwin"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarId = new TableSchema.TableColumn(schema);
				colvarId.ColumnName = "ID";
				colvarId.DataType = DbType.Int32;
				colvarId.MaxLength = 0;
				colvarId.AutoIncrement = true;
				colvarId.IsNullable = false;
				colvarId.IsPrimaryKey = false;
				colvarId.IsForeignKey = false;
				colvarId.IsReadOnly = false;
				colvarId.DefaultSetting = @"";
				colvarId.ForeignKeyTableName = "";
				schema.Columns.Add(colvarId);
				
				TableSchema.TableColumn colvarScggdh = new TableSchema.TableColumn(schema);
				colvarScggdh.ColumnName = "SCGGDH";
				colvarScggdh.DataType = DbType.AnsiString;
				colvarScggdh.MaxLength = 50;
				colvarScggdh.AutoIncrement = false;
				colvarScggdh.IsNullable = false;
				colvarScggdh.IsPrimaryKey = true;
				colvarScggdh.IsForeignKey = false;
				colvarScggdh.IsReadOnly = false;
				
						colvarScggdh.DefaultSetting = @"('')";
				colvarScggdh.ForeignKeyTableName = "";
				schema.Columns.Add(colvarScggdh);
				
				TableSchema.TableColumn colvarKhdh = new TableSchema.TableColumn(schema);
				colvarKhdh.ColumnName = "KHDH";
				colvarKhdh.DataType = DbType.AnsiString;
				colvarKhdh.MaxLength = 30;
				colvarKhdh.AutoIncrement = false;
				colvarKhdh.IsNullable = true;
				colvarKhdh.IsPrimaryKey = false;
				colvarKhdh.IsForeignKey = false;
				colvarKhdh.IsReadOnly = false;
				
						colvarKhdh.DefaultSetting = @"('')";
				colvarKhdh.ForeignKeyTableName = "";
				schema.Columns.Add(colvarKhdh);
				
				TableSchema.TableColumn colvarPbxh = new TableSchema.TableColumn(schema);
				colvarPbxh.ColumnName = "PBXH";
				colvarPbxh.DataType = DbType.Int32;
				colvarPbxh.MaxLength = 0;
				colvarPbxh.AutoIncrement = false;
				colvarPbxh.IsNullable = true;
				colvarPbxh.IsPrimaryKey = false;
				colvarPbxh.IsForeignKey = false;
				colvarPbxh.IsReadOnly = false;
				
						colvarPbxh.DefaultSetting = @"((0))";
				colvarPbxh.ForeignKeyTableName = "";
				schema.Columns.Add(colvarPbxh);
				
				TableSchema.TableColumn colvarWlbm = new TableSchema.TableColumn(schema);
				colvarWlbm.ColumnName = "WLBM";
				colvarWlbm.DataType = DbType.AnsiString;
				colvarWlbm.MaxLength = 50;
				colvarWlbm.AutoIncrement = false;
				colvarWlbm.IsNullable = true;
				colvarWlbm.IsPrimaryKey = false;
				colvarWlbm.IsForeignKey = false;
				colvarWlbm.IsReadOnly = false;
				
						colvarWlbm.DefaultSetting = @"('')";
				colvarWlbm.ForeignKeyTableName = "";
				schema.Columns.Add(colvarWlbm);
				
				TableSchema.TableColumn colvarWlfk = new TableSchema.TableColumn(schema);
				colvarWlfk.ColumnName = "WLFK";
				colvarWlfk.DataType = DbType.Decimal;
				colvarWlfk.MaxLength = 0;
				colvarWlfk.AutoIncrement = false;
				colvarWlfk.IsNullable = true;
				colvarWlfk.IsPrimaryKey = false;
				colvarWlfk.IsForeignKey = false;
				colvarWlfk.IsReadOnly = false;
				
						colvarWlfk.DefaultSetting = @"((0))";
				colvarWlfk.ForeignKeyTableName = "";
				schema.Columns.Add(colvarWlfk);
				
				TableSchema.TableColumn colvarWlhy = new TableSchema.TableColumn(schema);
				colvarWlhy.ColumnName = "WLHY";
				colvarWlhy.DataType = DbType.Decimal;
				colvarWlhy.MaxLength = 0;
				colvarWlhy.AutoIncrement = false;
				colvarWlhy.IsNullable = true;
				colvarWlhy.IsPrimaryKey = false;
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
				colvarTgsx.IsNullable = true;
				colvarTgsx.IsPrimaryKey = false;
				colvarTgsx.IsForeignKey = false;
				colvarTgsx.IsReadOnly = false;
				
						colvarTgsx.DefaultSetting = @"('')";
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
				
						colvarTgkd.DefaultSetting = @"((0))";
				colvarTgkd.ForeignKeyTableName = "";
				schema.Columns.Add(colvarTgkd);
				
				TableSchema.TableColumn colvarWlks = new TableSchema.TableColumn(schema);
				colvarWlks.ColumnName = "WLKS";
				colvarWlks.DataType = DbType.AnsiString;
				colvarWlks.MaxLength = 50;
				colvarWlks.AutoIncrement = false;
				colvarWlks.IsNullable = true;
				colvarWlks.IsPrimaryKey = false;
				colvarWlks.IsForeignKey = false;
				colvarWlks.IsReadOnly = false;
				
						colvarWlks.DefaultSetting = @"('')";
				colvarWlks.ForeignKeyTableName = "";
				schema.Columns.Add(colvarWlks);
				
				TableSchema.TableColumn colvarWlxh = new TableSchema.TableColumn(schema);
				colvarWlxh.ColumnName = "WLXH";
				colvarWlxh.DataType = DbType.Int32;
				colvarWlxh.MaxLength = 0;
				colvarWlxh.AutoIncrement = false;
				colvarWlxh.IsNullable = false;
				colvarWlxh.IsPrimaryKey = true;
				colvarWlxh.IsForeignKey = false;
				colvarWlxh.IsReadOnly = false;
				
						colvarWlxh.DefaultSetting = @"((0))";
				colvarWlxh.ForeignKeyTableName = "";
				schema.Columns.Add(colvarWlxh);
				
				TableSchema.TableColumn colvarXH1 = new TableSchema.TableColumn(schema);
				colvarXH1.ColumnName = "XH1";
				colvarXH1.DataType = DbType.Int32;
				colvarXH1.MaxLength = 0;
				colvarXH1.AutoIncrement = false;
				colvarXH1.IsNullable = true;
				colvarXH1.IsPrimaryKey = false;
				colvarXH1.IsForeignKey = false;
				colvarXH1.IsReadOnly = false;
				
						colvarXH1.DefaultSetting = @"((0))";
				colvarXH1.ForeignKeyTableName = "";
				schema.Columns.Add(colvarXH1);
				
				TableSchema.TableColumn colvarWlbw = new TableSchema.TableColumn(schema);
				colvarWlbw.ColumnName = "WLBW";
				colvarWlbw.DataType = DbType.AnsiString;
				colvarWlbw.MaxLength = 200;
				colvarWlbw.AutoIncrement = false;
				colvarWlbw.IsNullable = true;
				colvarWlbw.IsPrimaryKey = false;
				colvarWlbw.IsForeignKey = false;
				colvarWlbw.IsReadOnly = false;
				
						colvarWlbw.DefaultSetting = @"('')";
				colvarWlbw.ForeignKeyTableName = "";
				schema.Columns.Add(colvarWlbw);
				
				TableSchema.TableColumn colvarGyfl = new TableSchema.TableColumn(schema);
				colvarGyfl.ColumnName = "GYFL";
				colvarGyfl.DataType = DbType.AnsiString;
				colvarGyfl.MaxLength = 30;
				colvarGyfl.AutoIncrement = false;
				colvarGyfl.IsNullable = true;
				colvarGyfl.IsPrimaryKey = false;
				colvarGyfl.IsForeignKey = false;
				colvarGyfl.IsReadOnly = false;
				
						colvarGyfl.DefaultSetting = @"('')";
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
				
						colvarSldl.DefaultSetting = @"('')";
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
				
						colvarCpzl.DefaultSetting = @"('')";
				colvarCpzl.ForeignKeyTableName = "";
				schema.Columns.Add(colvarCpzl);
				
				TableSchema.TableColumn colvarSfhd = new TableSchema.TableColumn(schema);
				colvarSfhd.ColumnName = "SFHD";
				colvarSfhd.DataType = DbType.AnsiString;
				colvarSfhd.MaxLength = 10;
				colvarSfhd.AutoIncrement = false;
				colvarSfhd.IsNullable = true;
				colvarSfhd.IsPrimaryKey = false;
				colvarSfhd.IsForeignKey = false;
				colvarSfhd.IsReadOnly = false;
				
						colvarSfhd.DefaultSetting = @"((0))";
				colvarSfhd.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSfhd);
				
				TableSchema.TableColumn colvarHdh = new TableSchema.TableColumn(schema);
				colvarHdh.ColumnName = "HDH";
				colvarHdh.DataType = DbType.AnsiString;
				colvarHdh.MaxLength = 50;
				colvarHdh.AutoIncrement = false;
				colvarHdh.IsNullable = true;
				colvarHdh.IsPrimaryKey = false;
				colvarHdh.IsForeignKey = false;
				colvarHdh.IsReadOnly = false;
				
						colvarHdh.DefaultSetting = @"('')";
				colvarHdh.ForeignKeyTableName = "";
				schema.Columns.Add(colvarHdh);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["Nowthwin"].AddSchema("T_BLData_PLD1",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("Id")]
		[Bindable(true)]
		public int Id 
		{
			get { return GetColumnValue<int>(Columns.Id); }
			set { SetColumnValue(Columns.Id, value); }
		}
		  
		[XmlAttribute("Scggdh")]
		[Bindable(true)]
		public string Scggdh 
		{
			get { return GetColumnValue<string>(Columns.Scggdh); }
			set { SetColumnValue(Columns.Scggdh, value); }
		}
		  
		[XmlAttribute("Khdh")]
		[Bindable(true)]
		public string Khdh 
		{
			get { return GetColumnValue<string>(Columns.Khdh); }
			set { SetColumnValue(Columns.Khdh, value); }
		}
		  
		[XmlAttribute("Pbxh")]
		[Bindable(true)]
		public int? Pbxh 
		{
			get { return GetColumnValue<int?>(Columns.Pbxh); }
			set { SetColumnValue(Columns.Pbxh, value); }
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
		public decimal? Wlfk 
		{
			get { return GetColumnValue<decimal?>(Columns.Wlfk); }
			set { SetColumnValue(Columns.Wlfk, value); }
		}
		  
		[XmlAttribute("Wlhy")]
		[Bindable(true)]
		public decimal? Wlhy 
		{
			get { return GetColumnValue<decimal?>(Columns.Wlhy); }
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
		  
		[XmlAttribute("Wlks")]
		[Bindable(true)]
		public string Wlks 
		{
			get { return GetColumnValue<string>(Columns.Wlks); }
			set { SetColumnValue(Columns.Wlks, value); }
		}
		  
		[XmlAttribute("Wlxh")]
		[Bindable(true)]
		public int Wlxh 
		{
			get { return GetColumnValue<int>(Columns.Wlxh); }
			set { SetColumnValue(Columns.Wlxh, value); }
		}
		  
		[XmlAttribute("XH1")]
		[Bindable(true)]
		public int? XH1 
		{
			get { return GetColumnValue<int?>(Columns.XH1); }
			set { SetColumnValue(Columns.XH1, value); }
		}
		  
		[XmlAttribute("Wlbw")]
		[Bindable(true)]
		public string Wlbw 
		{
			get { return GetColumnValue<string>(Columns.Wlbw); }
			set { SetColumnValue(Columns.Wlbw, value); }
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
		  
		[XmlAttribute("Sfhd")]
		[Bindable(true)]
		public string Sfhd 
		{
			get { return GetColumnValue<string>(Columns.Sfhd); }
			set { SetColumnValue(Columns.Sfhd, value); }
		}
		  
		[XmlAttribute("Hdh")]
		[Bindable(true)]
		public string Hdh 
		{
			get { return GetColumnValue<string>(Columns.Hdh); }
			set { SetColumnValue(Columns.Hdh, value); }
		}
		
		#endregion
		
		
			
		
		//no foreign key tables defined (0)
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(string varScggdh,string varKhdh,int? varPbxh,string varWlbm,decimal? varWlfk,decimal? varWlhy,string varTgsx,decimal? varTgkd,string varWlks,int varWlxh,int? varXH1,string varWlbw,string varGyfl,string varSldl,string varCpzl,string varSfhd,string varHdh)
		{
			TBLDataPLD1 item = new TBLDataPLD1();
			
			item.Scggdh = varScggdh;
			
			item.Khdh = varKhdh;
			
			item.Pbxh = varPbxh;
			
			item.Wlbm = varWlbm;
			
			item.Wlfk = varWlfk;
			
			item.Wlhy = varWlhy;
			
			item.Tgsx = varTgsx;
			
			item.Tgkd = varTgkd;
			
			item.Wlks = varWlks;
			
			item.Wlxh = varWlxh;
			
			item.XH1 = varXH1;
			
			item.Wlbw = varWlbw;
			
			item.Gyfl = varGyfl;
			
			item.Sldl = varSldl;
			
			item.Cpzl = varCpzl;
			
			item.Sfhd = varSfhd;
			
			item.Hdh = varHdh;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varId,string varScggdh,string varKhdh,int? varPbxh,string varWlbm,decimal? varWlfk,decimal? varWlhy,string varTgsx,decimal? varTgkd,string varWlks,int varWlxh,int? varXH1,string varWlbw,string varGyfl,string varSldl,string varCpzl,string varSfhd,string varHdh)
		{
			TBLDataPLD1 item = new TBLDataPLD1();
			
				item.Id = varId;
			
				item.Scggdh = varScggdh;
			
				item.Khdh = varKhdh;
			
				item.Pbxh = varPbxh;
			
				item.Wlbm = varWlbm;
			
				item.Wlfk = varWlfk;
			
				item.Wlhy = varWlhy;
			
				item.Tgsx = varTgsx;
			
				item.Tgkd = varTgkd;
			
				item.Wlks = varWlks;
			
				item.Wlxh = varWlxh;
			
				item.XH1 = varXH1;
			
				item.Wlbw = varWlbw;
			
				item.Gyfl = varGyfl;
			
				item.Sldl = varSldl;
			
				item.Cpzl = varCpzl;
			
				item.Sfhd = varSfhd;
			
				item.Hdh = varHdh;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn IdColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn ScggdhColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        public static TableSchema.TableColumn KhdhColumn
        {
            get { return Schema.Columns[2]; }
        }
        
        
        
        public static TableSchema.TableColumn PbxhColumn
        {
            get { return Schema.Columns[3]; }
        }
        
        
        
        public static TableSchema.TableColumn WlbmColumn
        {
            get { return Schema.Columns[4]; }
        }
        
        
        
        public static TableSchema.TableColumn WlfkColumn
        {
            get { return Schema.Columns[5]; }
        }
        
        
        
        public static TableSchema.TableColumn WlhyColumn
        {
            get { return Schema.Columns[6]; }
        }
        
        
        
        public static TableSchema.TableColumn TgsxColumn
        {
            get { return Schema.Columns[7]; }
        }
        
        
        
        public static TableSchema.TableColumn TgkdColumn
        {
            get { return Schema.Columns[8]; }
        }
        
        
        
        public static TableSchema.TableColumn WlksColumn
        {
            get { return Schema.Columns[9]; }
        }
        
        
        
        public static TableSchema.TableColumn WlxhColumn
        {
            get { return Schema.Columns[10]; }
        }
        
        
        
        public static TableSchema.TableColumn XH1Column
        {
            get { return Schema.Columns[11]; }
        }
        
        
        
        public static TableSchema.TableColumn WlbwColumn
        {
            get { return Schema.Columns[12]; }
        }
        
        
        
        public static TableSchema.TableColumn GyflColumn
        {
            get { return Schema.Columns[13]; }
        }
        
        
        
        public static TableSchema.TableColumn SldlColumn
        {
            get { return Schema.Columns[14]; }
        }
        
        
        
        public static TableSchema.TableColumn CpzlColumn
        {
            get { return Schema.Columns[15]; }
        }
        
        
        
        public static TableSchema.TableColumn SfhdColumn
        {
            get { return Schema.Columns[16]; }
        }
        
        
        
        public static TableSchema.TableColumn HdhColumn
        {
            get { return Schema.Columns[17]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string Id = @"ID";
			 public static string Scggdh = @"SCGGDH";
			 public static string Khdh = @"KHDH";
			 public static string Pbxh = @"PBXH";
			 public static string Wlbm = @"WLBM";
			 public static string Wlfk = @"WLFK";
			 public static string Wlhy = @"WLHY";
			 public static string Tgsx = @"TGSX";
			 public static string Tgkd = @"TGKD";
			 public static string Wlks = @"WLKS";
			 public static string Wlxh = @"WLXH";
			 public static string XH1 = @"XH1";
			 public static string Wlbw = @"WLBW";
			 public static string Gyfl = @"GYFL";
			 public static string Sldl = @"SLDL";
			 public static string Cpzl = @"CPZL";
			 public static string Sfhd = @"SFHD";
			 public static string Hdh = @"HDH";
						
		}
		#endregion
		
		#region Update PK Collections
		
        #endregion
    
        #region Deep Save
		
        #endregion
	}
}
