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
	/// Strongly-typed collection for the TBLDataOrdermx class.
	/// </summary>
    [Serializable]
	public partial class TBLDataOrdermxCollection : ActiveList<TBLDataOrdermx, TBLDataOrdermxCollection>
	{	   
		public TBLDataOrdermxCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>TBLDataOrdermxCollection</returns>
		public TBLDataOrdermxCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                TBLDataOrdermx o = this[i];
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
	/// This is an ActiveRecord class which wraps the T_BLData_Ordermx table.
	/// </summary>
	[Serializable]
	public partial class TBLDataOrdermx : ActiveRecord<TBLDataOrdermx>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public TBLDataOrdermx()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public TBLDataOrdermx(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public TBLDataOrdermx(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public TBLDataOrdermx(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("T_BLData_Ordermx", TableType.Table, DataService.GetInstance("Nowthwin"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarMxid = new TableSchema.TableColumn(schema);
				colvarMxid.ColumnName = "mxid";
				colvarMxid.DataType = DbType.Int32;
				colvarMxid.MaxLength = 0;
				colvarMxid.AutoIncrement = true;
				colvarMxid.IsNullable = false;
				colvarMxid.IsPrimaryKey = true;
				colvarMxid.IsForeignKey = false;
				colvarMxid.IsReadOnly = false;
				colvarMxid.DefaultSetting = @"";
				colvarMxid.ForeignKeyTableName = "";
				schema.Columns.Add(colvarMxid);
				
				TableSchema.TableColumn colvarOrderid = new TableSchema.TableColumn(schema);
				colvarOrderid.ColumnName = "orderid";
				colvarOrderid.DataType = DbType.Int32;
				colvarOrderid.MaxLength = 0;
				colvarOrderid.AutoIncrement = false;
				colvarOrderid.IsNullable = true;
				colvarOrderid.IsPrimaryKey = false;
				colvarOrderid.IsForeignKey = false;
				colvarOrderid.IsReadOnly = false;
				colvarOrderid.DefaultSetting = @"";
				colvarOrderid.ForeignKeyTableName = "";
				schema.Columns.Add(colvarOrderid);
				
				TableSchema.TableColumn colvarKhdh = new TableSchema.TableColumn(schema);
				colvarKhdh.ColumnName = "khdh";
				colvarKhdh.DataType = DbType.String;
				colvarKhdh.MaxLength = 250;
				colvarKhdh.AutoIncrement = false;
				colvarKhdh.IsNullable = true;
				colvarKhdh.IsPrimaryKey = false;
				colvarKhdh.IsForeignKey = false;
				colvarKhdh.IsReadOnly = false;
				colvarKhdh.DefaultSetting = @"";
				colvarKhdh.ForeignKeyTableName = "";
				schema.Columns.Add(colvarKhdh);
				
				TableSchema.TableColumn colvarKsh = new TableSchema.TableColumn(schema);
				colvarKsh.ColumnName = "ksh";
				colvarKsh.DataType = DbType.String;
				colvarKsh.MaxLength = 250;
				colvarKsh.AutoIncrement = false;
				colvarKsh.IsNullable = true;
				colvarKsh.IsPrimaryKey = false;
				colvarKsh.IsForeignKey = false;
				colvarKsh.IsReadOnly = false;
				colvarKsh.DefaultSetting = @"";
				colvarKsh.ForeignKeyTableName = "";
				schema.Columns.Add(colvarKsh);
				
				TableSchema.TableColumn colvarFzfl = new TableSchema.TableColumn(schema);
				colvarFzfl.ColumnName = "fzfl";
				colvarFzfl.DataType = DbType.String;
				colvarFzfl.MaxLength = 250;
				colvarFzfl.AutoIncrement = false;
				colvarFzfl.IsNullable = true;
				colvarFzfl.IsPrimaryKey = false;
				colvarFzfl.IsForeignKey = false;
				colvarFzfl.IsReadOnly = false;
				colvarFzfl.DefaultSetting = @"";
				colvarFzfl.ForeignKeyTableName = "";
				schema.Columns.Add(colvarFzfl);
				
				TableSchema.TableColumn colvarMlbm = new TableSchema.TableColumn(schema);
				colvarMlbm.ColumnName = "mlbm";
				colvarMlbm.DataType = DbType.String;
				colvarMlbm.MaxLength = 250;
				colvarMlbm.AutoIncrement = false;
				colvarMlbm.IsNullable = true;
				colvarMlbm.IsPrimaryKey = false;
				colvarMlbm.IsForeignKey = false;
				colvarMlbm.IsReadOnly = false;
				colvarMlbm.DefaultSetting = @"";
				colvarMlbm.ForeignKeyTableName = "";
				schema.Columns.Add(colvarMlbm);
				
				TableSchema.TableColumn colvarDdsl = new TableSchema.TableColumn(schema);
				colvarDdsl.ColumnName = "ddsl";
				colvarDdsl.DataType = DbType.Int32;
				colvarDdsl.MaxLength = 0;
				colvarDdsl.AutoIncrement = false;
				colvarDdsl.IsNullable = true;
				colvarDdsl.IsPrimaryKey = false;
				colvarDdsl.IsForeignKey = false;
				colvarDdsl.IsReadOnly = false;
				colvarDdsl.DefaultSetting = @"";
				colvarDdsl.ForeignKeyTableName = "";
				schema.Columns.Add(colvarDdsl);
				
				TableSchema.TableColumn colvarHxjg = new TableSchema.TableColumn(schema);
				colvarHxjg.ColumnName = "hxjg";
				colvarHxjg.DataType = DbType.String;
				colvarHxjg.MaxLength = 250;
				colvarHxjg.AutoIncrement = false;
				colvarHxjg.IsNullable = true;
				colvarHxjg.IsPrimaryKey = false;
				colvarHxjg.IsForeignKey = false;
				colvarHxjg.IsReadOnly = false;
				colvarHxjg.DefaultSetting = @"";
				colvarHxjg.ForeignKeyTableName = "";
				schema.Columns.Add(colvarHxjg);
				
				TableSchema.TableColumn colvarKsjg = new TableSchema.TableColumn(schema);
				colvarKsjg.ColumnName = "ksjg";
				colvarKsjg.DataType = DbType.String;
				colvarKsjg.MaxLength = 250;
				colvarKsjg.AutoIncrement = false;
				colvarKsjg.IsNullable = true;
				colvarKsjg.IsPrimaryKey = false;
				colvarKsjg.IsForeignKey = false;
				colvarKsjg.IsReadOnly = false;
				colvarKsjg.DefaultSetting = @"";
				colvarKsjg.ForeignKeyTableName = "";
				schema.Columns.Add(colvarKsjg);
				
				TableSchema.TableColumn colvarGylx = new TableSchema.TableColumn(schema);
				colvarGylx.ColumnName = "gylx";
				colvarGylx.DataType = DbType.String;
				colvarGylx.MaxLength = 250;
				colvarGylx.AutoIncrement = false;
				colvarGylx.IsNullable = true;
				colvarGylx.IsPrimaryKey = false;
				colvarGylx.IsForeignKey = false;
				colvarGylx.IsReadOnly = false;
				colvarGylx.DefaultSetting = @"";
				colvarGylx.ForeignKeyTableName = "";
				schema.Columns.Add(colvarGylx);
				
				TableSchema.TableColumn colvarSfbcpsy = new TableSchema.TableColumn(schema);
				colvarSfbcpsy.ColumnName = "sfbcpsy";
				colvarSfbcpsy.DataType = DbType.String;
				colvarSfbcpsy.MaxLength = 250;
				colvarSfbcpsy.AutoIncrement = false;
				colvarSfbcpsy.IsNullable = true;
				colvarSfbcpsy.IsPrimaryKey = false;
				colvarSfbcpsy.IsForeignKey = false;
				colvarSfbcpsy.IsReadOnly = false;
				colvarSfbcpsy.DefaultSetting = @"";
				colvarSfbcpsy.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSfbcpsy);
				
				TableSchema.TableColumn colvarGyxx = new TableSchema.TableColumn(schema);
				colvarGyxx.ColumnName = "gyxx";
				colvarGyxx.DataType = DbType.String;
				colvarGyxx.MaxLength = -1;
				colvarGyxx.AutoIncrement = false;
				colvarGyxx.IsNullable = true;
				colvarGyxx.IsPrimaryKey = false;
				colvarGyxx.IsForeignKey = false;
				colvarGyxx.IsReadOnly = false;
				colvarGyxx.DefaultSetting = @"";
				colvarGyxx.ForeignKeyTableName = "";
				schema.Columns.Add(colvarGyxx);
				
				TableSchema.TableColumn colvarXh = new TableSchema.TableColumn(schema);
				colvarXh.ColumnName = "xh";
				colvarXh.DataType = DbType.String;
				colvarXh.MaxLength = 250;
				colvarXh.AutoIncrement = false;
				colvarXh.IsNullable = true;
				colvarXh.IsPrimaryKey = false;
				colvarXh.IsForeignKey = false;
				colvarXh.IsReadOnly = false;
				colvarXh.DefaultSetting = @"";
				colvarXh.ForeignKeyTableName = "";
				schema.Columns.Add(colvarXh);
				
				TableSchema.TableColumn colvarXhsy = new TableSchema.TableColumn(schema);
				colvarXhsy.ColumnName = "xhsy";
				colvarXhsy.DataType = DbType.String;
				colvarXhsy.MaxLength = 250;
				colvarXhsy.AutoIncrement = false;
				colvarXhsy.IsNullable = true;
				colvarXhsy.IsPrimaryKey = false;
				colvarXhsy.IsForeignKey = false;
				colvarXhsy.IsReadOnly = false;
				colvarXhsy.DefaultSetting = @"";
				colvarXhsy.ForeignKeyTableName = "";
				schema.Columns.Add(colvarXhsy);
				
				TableSchema.TableColumn colvarXhnz = new TableSchema.TableColumn(schema);
				colvarXhnz.ColumnName = "xhnz";
				colvarXhnz.DataType = DbType.String;
				colvarXhnz.MaxLength = 250;
				colvarXhnz.AutoIncrement = false;
				colvarXhnz.IsNullable = true;
				colvarXhnz.IsPrimaryKey = false;
				colvarXhnz.IsForeignKey = false;
				colvarXhnz.IsReadOnly = false;
				colvarXhnz.DefaultSetting = @"";
				colvarXhnz.ForeignKeyTableName = "";
				schema.Columns.Add(colvarXhnz);
				
				TableSchema.TableColumn colvarXhwz = new TableSchema.TableColumn(schema);
				colvarXhwz.ColumnName = "xhwz";
				colvarXhwz.DataType = DbType.String;
				colvarXhwz.MaxLength = 250;
				colvarXhwz.AutoIncrement = false;
				colvarXhwz.IsNullable = true;
				colvarXhwz.IsPrimaryKey = false;
				colvarXhwz.IsForeignKey = false;
				colvarXhwz.IsReadOnly = false;
				colvarXhwz.DefaultSetting = @"";
				colvarXhwz.ForeignKeyTableName = "";
				schema.Columns.Add(colvarXhwz);
				
				TableSchema.TableColumn colvarMlsx = new TableSchema.TableColumn(schema);
				colvarMlsx.ColumnName = "mlsx";
				colvarMlsx.DataType = DbType.String;
				colvarMlsx.MaxLength = 250;
				colvarMlsx.AutoIncrement = false;
				colvarMlsx.IsNullable = true;
				colvarMlsx.IsPrimaryKey = false;
				colvarMlsx.IsForeignKey = false;
				colvarMlsx.IsReadOnly = false;
				colvarMlsx.DefaultSetting = @"";
				colvarMlsx.ForeignKeyTableName = "";
				schema.Columns.Add(colvarMlsx);
				
				TableSchema.TableColumn colvarFlagDelete = new TableSchema.TableColumn(schema);
				colvarFlagDelete.ColumnName = "flagDelete";
				colvarFlagDelete.DataType = DbType.Int32;
				colvarFlagDelete.MaxLength = 0;
				colvarFlagDelete.AutoIncrement = false;
				colvarFlagDelete.IsNullable = true;
				colvarFlagDelete.IsPrimaryKey = false;
				colvarFlagDelete.IsForeignKey = false;
				colvarFlagDelete.IsReadOnly = false;
				colvarFlagDelete.DefaultSetting = @"";
				colvarFlagDelete.ForeignKeyTableName = "";
				schema.Columns.Add(colvarFlagDelete);
				
				TableSchema.TableColumn colvarNum = new TableSchema.TableColumn(schema);
				colvarNum.ColumnName = "num";
				colvarNum.DataType = DbType.Int32;
				colvarNum.MaxLength = 0;
				colvarNum.AutoIncrement = false;
				colvarNum.IsNullable = true;
				colvarNum.IsPrimaryKey = false;
				colvarNum.IsForeignKey = false;
				colvarNum.IsReadOnly = false;
				colvarNum.DefaultSetting = @"";
				colvarNum.ForeignKeyTableName = "";
				schema.Columns.Add(colvarNum);
				
				TableSchema.TableColumn colvarFlagStatus = new TableSchema.TableColumn(schema);
				colvarFlagStatus.ColumnName = "flagStatus";
				colvarFlagStatus.DataType = DbType.Int32;
				colvarFlagStatus.MaxLength = 0;
				colvarFlagStatus.AutoIncrement = false;
				colvarFlagStatus.IsNullable = true;
				colvarFlagStatus.IsPrimaryKey = false;
				colvarFlagStatus.IsForeignKey = false;
				colvarFlagStatus.IsReadOnly = false;
				
						colvarFlagStatus.DefaultSetting = @"((0))";
				colvarFlagStatus.ForeignKeyTableName = "";
				schema.Columns.Add(colvarFlagStatus);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["Nowthwin"].AddSchema("T_BLData_Ordermx",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("Mxid")]
		[Bindable(true)]
		public int Mxid 
		{
			get { return GetColumnValue<int>(Columns.Mxid); }
			set { SetColumnValue(Columns.Mxid, value); }
		}
		  
		[XmlAttribute("Orderid")]
		[Bindable(true)]
		public int? Orderid 
		{
			get { return GetColumnValue<int?>(Columns.Orderid); }
			set { SetColumnValue(Columns.Orderid, value); }
		}
		  
		[XmlAttribute("Khdh")]
		[Bindable(true)]
		public string Khdh 
		{
			get { return GetColumnValue<string>(Columns.Khdh); }
			set { SetColumnValue(Columns.Khdh, value); }
		}
		  
		[XmlAttribute("Ksh")]
		[Bindable(true)]
		public string Ksh 
		{
			get { return GetColumnValue<string>(Columns.Ksh); }
			set { SetColumnValue(Columns.Ksh, value); }
		}
		  
		[XmlAttribute("Fzfl")]
		[Bindable(true)]
		public string Fzfl 
		{
			get { return GetColumnValue<string>(Columns.Fzfl); }
			set { SetColumnValue(Columns.Fzfl, value); }
		}
		  
		[XmlAttribute("Mlbm")]
		[Bindable(true)]
		public string Mlbm 
		{
			get { return GetColumnValue<string>(Columns.Mlbm); }
			set { SetColumnValue(Columns.Mlbm, value); }
		}
		  
		[XmlAttribute("Ddsl")]
		[Bindable(true)]
		public int? Ddsl 
		{
			get { return GetColumnValue<int?>(Columns.Ddsl); }
			set { SetColumnValue(Columns.Ddsl, value); }
		}
		  
		[XmlAttribute("Hxjg")]
		[Bindable(true)]
		public string Hxjg 
		{
			get { return GetColumnValue<string>(Columns.Hxjg); }
			set { SetColumnValue(Columns.Hxjg, value); }
		}
		  
		[XmlAttribute("Ksjg")]
		[Bindable(true)]
		public string Ksjg 
		{
			get { return GetColumnValue<string>(Columns.Ksjg); }
			set { SetColumnValue(Columns.Ksjg, value); }
		}
		  
		[XmlAttribute("Gylx")]
		[Bindable(true)]
		public string Gylx 
		{
			get { return GetColumnValue<string>(Columns.Gylx); }
			set { SetColumnValue(Columns.Gylx, value); }
		}
		  
		[XmlAttribute("Sfbcpsy")]
		[Bindable(true)]
		public string Sfbcpsy 
		{
			get { return GetColumnValue<string>(Columns.Sfbcpsy); }
			set { SetColumnValue(Columns.Sfbcpsy, value); }
		}
		  
		[XmlAttribute("Gyxx")]
		[Bindable(true)]
		public string Gyxx 
		{
			get { return GetColumnValue<string>(Columns.Gyxx); }
			set { SetColumnValue(Columns.Gyxx, value); }
		}
		  
		[XmlAttribute("Xh")]
		[Bindable(true)]
		public string Xh 
		{
			get { return GetColumnValue<string>(Columns.Xh); }
			set { SetColumnValue(Columns.Xh, value); }
		}
		  
		[XmlAttribute("Xhsy")]
		[Bindable(true)]
		public string Xhsy 
		{
			get { return GetColumnValue<string>(Columns.Xhsy); }
			set { SetColumnValue(Columns.Xhsy, value); }
		}
		  
		[XmlAttribute("Xhnz")]
		[Bindable(true)]
		public string Xhnz 
		{
			get { return GetColumnValue<string>(Columns.Xhnz); }
			set { SetColumnValue(Columns.Xhnz, value); }
		}
		  
		[XmlAttribute("Xhwz")]
		[Bindable(true)]
		public string Xhwz 
		{
			get { return GetColumnValue<string>(Columns.Xhwz); }
			set { SetColumnValue(Columns.Xhwz, value); }
		}
		  
		[XmlAttribute("Mlsx")]
		[Bindable(true)]
		public string Mlsx 
		{
			get { return GetColumnValue<string>(Columns.Mlsx); }
			set { SetColumnValue(Columns.Mlsx, value); }
		}
		  
		[XmlAttribute("FlagDelete")]
		[Bindable(true)]
		public int? FlagDelete 
		{
			get { return GetColumnValue<int?>(Columns.FlagDelete); }
			set { SetColumnValue(Columns.FlagDelete, value); }
		}
		  
		[XmlAttribute("Num")]
		[Bindable(true)]
		public int? Num 
		{
			get { return GetColumnValue<int?>(Columns.Num); }
			set { SetColumnValue(Columns.Num, value); }
		}
		  
		[XmlAttribute("FlagStatus")]
		[Bindable(true)]
		public int? FlagStatus 
		{
			get { return GetColumnValue<int?>(Columns.FlagStatus); }
			set { SetColumnValue(Columns.FlagStatus, value); }
		}
		
		#endregion
		
		
			
		
		//no foreign key tables defined (0)
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(int? varOrderid,string varKhdh,string varKsh,string varFzfl,string varMlbm,int? varDdsl,string varHxjg,string varKsjg,string varGylx,string varSfbcpsy,string varGyxx,string varXh,string varXhsy,string varXhnz,string varXhwz,string varMlsx,int? varFlagDelete,int? varNum,int? varFlagStatus)
		{
			TBLDataOrdermx item = new TBLDataOrdermx();
			
			item.Orderid = varOrderid;
			
			item.Khdh = varKhdh;
			
			item.Ksh = varKsh;
			
			item.Fzfl = varFzfl;
			
			item.Mlbm = varMlbm;
			
			item.Ddsl = varDdsl;
			
			item.Hxjg = varHxjg;
			
			item.Ksjg = varKsjg;
			
			item.Gylx = varGylx;
			
			item.Sfbcpsy = varSfbcpsy;
			
			item.Gyxx = varGyxx;
			
			item.Xh = varXh;
			
			item.Xhsy = varXhsy;
			
			item.Xhnz = varXhnz;
			
			item.Xhwz = varXhwz;
			
			item.Mlsx = varMlsx;
			
			item.FlagDelete = varFlagDelete;
			
			item.Num = varNum;
			
			item.FlagStatus = varFlagStatus;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varMxid,int? varOrderid,string varKhdh,string varKsh,string varFzfl,string varMlbm,int? varDdsl,string varHxjg,string varKsjg,string varGylx,string varSfbcpsy,string varGyxx,string varXh,string varXhsy,string varXhnz,string varXhwz,string varMlsx,int? varFlagDelete,int? varNum,int? varFlagStatus)
		{
			TBLDataOrdermx item = new TBLDataOrdermx();
			
				item.Mxid = varMxid;
			
				item.Orderid = varOrderid;
			
				item.Khdh = varKhdh;
			
				item.Ksh = varKsh;
			
				item.Fzfl = varFzfl;
			
				item.Mlbm = varMlbm;
			
				item.Ddsl = varDdsl;
			
				item.Hxjg = varHxjg;
			
				item.Ksjg = varKsjg;
			
				item.Gylx = varGylx;
			
				item.Sfbcpsy = varSfbcpsy;
			
				item.Gyxx = varGyxx;
			
				item.Xh = varXh;
			
				item.Xhsy = varXhsy;
			
				item.Xhnz = varXhnz;
			
				item.Xhwz = varXhwz;
			
				item.Mlsx = varMlsx;
			
				item.FlagDelete = varFlagDelete;
			
				item.Num = varNum;
			
				item.FlagStatus = varFlagStatus;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn MxidColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn OrderidColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        public static TableSchema.TableColumn KhdhColumn
        {
            get { return Schema.Columns[2]; }
        }
        
        
        
        public static TableSchema.TableColumn KshColumn
        {
            get { return Schema.Columns[3]; }
        }
        
        
        
        public static TableSchema.TableColumn FzflColumn
        {
            get { return Schema.Columns[4]; }
        }
        
        
        
        public static TableSchema.TableColumn MlbmColumn
        {
            get { return Schema.Columns[5]; }
        }
        
        
        
        public static TableSchema.TableColumn DdslColumn
        {
            get { return Schema.Columns[6]; }
        }
        
        
        
        public static TableSchema.TableColumn HxjgColumn
        {
            get { return Schema.Columns[7]; }
        }
        
        
        
        public static TableSchema.TableColumn KsjgColumn
        {
            get { return Schema.Columns[8]; }
        }
        
        
        
        public static TableSchema.TableColumn GylxColumn
        {
            get { return Schema.Columns[9]; }
        }
        
        
        
        public static TableSchema.TableColumn SfbcpsyColumn
        {
            get { return Schema.Columns[10]; }
        }
        
        
        
        public static TableSchema.TableColumn GyxxColumn
        {
            get { return Schema.Columns[11]; }
        }
        
        
        
        public static TableSchema.TableColumn XhColumn
        {
            get { return Schema.Columns[12]; }
        }
        
        
        
        public static TableSchema.TableColumn XhsyColumn
        {
            get { return Schema.Columns[13]; }
        }
        
        
        
        public static TableSchema.TableColumn XhnzColumn
        {
            get { return Schema.Columns[14]; }
        }
        
        
        
        public static TableSchema.TableColumn XhwzColumn
        {
            get { return Schema.Columns[15]; }
        }
        
        
        
        public static TableSchema.TableColumn MlsxColumn
        {
            get { return Schema.Columns[16]; }
        }
        
        
        
        public static TableSchema.TableColumn FlagDeleteColumn
        {
            get { return Schema.Columns[17]; }
        }
        
        
        
        public static TableSchema.TableColumn NumColumn
        {
            get { return Schema.Columns[18]; }
        }
        
        
        
        public static TableSchema.TableColumn FlagStatusColumn
        {
            get { return Schema.Columns[19]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string Mxid = @"mxid";
			 public static string Orderid = @"orderid";
			 public static string Khdh = @"khdh";
			 public static string Ksh = @"ksh";
			 public static string Fzfl = @"fzfl";
			 public static string Mlbm = @"mlbm";
			 public static string Ddsl = @"ddsl";
			 public static string Hxjg = @"hxjg";
			 public static string Ksjg = @"ksjg";
			 public static string Gylx = @"gylx";
			 public static string Sfbcpsy = @"sfbcpsy";
			 public static string Gyxx = @"gyxx";
			 public static string Xh = @"xh";
			 public static string Xhsy = @"xhsy";
			 public static string Xhnz = @"xhnz";
			 public static string Xhwz = @"xhwz";
			 public static string Mlsx = @"mlsx";
			 public static string FlagDelete = @"flagDelete";
			 public static string Num = @"num";
			 public static string FlagStatus = @"flagStatus";
						
		}
		#endregion
		
		#region Update PK Collections
		
        #endregion
    
        #region Deep Save
		
        #endregion
	}
}
