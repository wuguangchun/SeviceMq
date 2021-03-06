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
	/// Strongly-typed collection for the TAnalysisOrderListByDH class.
	/// </summary>
    [Serializable]
	public partial class TAnalysisOrderListByDHCollection : ActiveList<TAnalysisOrderListByDH, TAnalysisOrderListByDHCollection>
	{	   
		public TAnalysisOrderListByDHCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>TAnalysisOrderListByDHCollection</returns>
		public TAnalysisOrderListByDHCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                TAnalysisOrderListByDH o = this[i];
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
	/// This is an ActiveRecord class which wraps the T_Analysis_OrderListByDH table.
	/// </summary>
	[Serializable]
	public partial class TAnalysisOrderListByDH : ActiveRecord<TAnalysisOrderListByDH>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public TAnalysisOrderListByDH()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public TAnalysisOrderListByDH(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public TAnalysisOrderListByDH(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public TAnalysisOrderListByDH(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("T_Analysis_OrderListByDH", TableType.Table, DataService.GetInstance("Nowthwin"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarSchtbh = new TableSchema.TableColumn(schema);
				colvarSchtbh.ColumnName = "schtbh";
				colvarSchtbh.DataType = DbType.AnsiString;
				colvarSchtbh.MaxLength = 50;
				colvarSchtbh.AutoIncrement = false;
				colvarSchtbh.IsNullable = false;
				colvarSchtbh.IsPrimaryKey = true;
				colvarSchtbh.IsForeignKey = false;
				colvarSchtbh.IsReadOnly = false;
				colvarSchtbh.DefaultSetting = @"";
				colvarSchtbh.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSchtbh);
				
				TableSchema.TableColumn colvarSchtxh = new TableSchema.TableColumn(schema);
				colvarSchtxh.ColumnName = "schtxh";
				colvarSchtxh.DataType = DbType.AnsiString;
				colvarSchtxh.MaxLength = 50;
				colvarSchtxh.AutoIncrement = false;
				colvarSchtxh.IsNullable = false;
				colvarSchtxh.IsPrimaryKey = true;
				colvarSchtxh.IsForeignKey = false;
				colvarSchtxh.IsReadOnly = false;
				colvarSchtxh.DefaultSetting = @"";
				colvarSchtxh.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSchtxh);
				
				TableSchema.TableColumn colvarXtwpdm = new TableSchema.TableColumn(schema);
				colvarXtwpdm.ColumnName = "xtwpdm";
				colvarXtwpdm.DataType = DbType.AnsiString;
				colvarXtwpdm.MaxLength = 50;
				colvarXtwpdm.AutoIncrement = false;
				colvarXtwpdm.IsNullable = false;
				colvarXtwpdm.IsPrimaryKey = false;
				colvarXtwpdm.IsForeignKey = false;
				colvarXtwpdm.IsReadOnly = false;
				colvarXtwpdm.DefaultSetting = @"";
				colvarXtwpdm.ForeignKeyTableName = "";
				schema.Columns.Add(colvarXtwpdm);
				
				TableSchema.TableColumn colvarXtwpks = new TableSchema.TableColumn(schema);
				colvarXtwpks.ColumnName = "xtwpks";
				colvarXtwpks.DataType = DbType.AnsiString;
				colvarXtwpks.MaxLength = 50;
				colvarXtwpks.AutoIncrement = false;
				colvarXtwpks.IsNullable = true;
				colvarXtwpks.IsPrimaryKey = false;
				colvarXtwpks.IsForeignKey = false;
				colvarXtwpks.IsReadOnly = false;
				colvarXtwpks.DefaultSetting = @"";
				colvarXtwpks.ForeignKeyTableName = "";
				schema.Columns.Add(colvarXtwpks);
				
				TableSchema.TableColumn colvarXtwpys = new TableSchema.TableColumn(schema);
				colvarXtwpys.ColumnName = "xtwpys";
				colvarXtwpys.DataType = DbType.AnsiString;
				colvarXtwpys.MaxLength = 50;
				colvarXtwpys.AutoIncrement = false;
				colvarXtwpys.IsNullable = true;
				colvarXtwpys.IsPrimaryKey = false;
				colvarXtwpys.IsForeignKey = false;
				colvarXtwpys.IsReadOnly = false;
				colvarXtwpys.DefaultSetting = @"";
				colvarXtwpys.ForeignKeyTableName = "";
				schema.Columns.Add(colvarXtwpys);
				
				TableSchema.TableColumn colvarSchtsl = new TableSchema.TableColumn(schema);
				colvarSchtsl.ColumnName = "schtsl";
				colvarSchtsl.DataType = DbType.Int32;
				colvarSchtsl.MaxLength = 0;
				colvarSchtsl.AutoIncrement = false;
				colvarSchtsl.IsNullable = true;
				colvarSchtsl.IsPrimaryKey = false;
				colvarSchtsl.IsForeignKey = false;
				colvarSchtsl.IsReadOnly = false;
				colvarSchtsl.DefaultSetting = @"";
				colvarSchtsl.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSchtsl);
				
				TableSchema.TableColumn colvarSckhjq = new TableSchema.TableColumn(schema);
				colvarSckhjq.ColumnName = "sckhjq";
				colvarSckhjq.DataType = DbType.DateTime;
				colvarSckhjq.MaxLength = 0;
				colvarSckhjq.AutoIncrement = false;
				colvarSckhjq.IsNullable = true;
				colvarSckhjq.IsPrimaryKey = false;
				colvarSckhjq.IsForeignKey = false;
				colvarSckhjq.IsReadOnly = false;
				colvarSckhjq.DefaultSetting = @"";
				colvarSckhjq.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSckhjq);
				
				TableSchema.TableColumn colvarYlbm = new TableSchema.TableColumn(schema);
				colvarYlbm.ColumnName = "ylbm";
				colvarYlbm.DataType = DbType.AnsiString;
				colvarYlbm.MaxLength = 50;
				colvarYlbm.AutoIncrement = false;
				colvarYlbm.IsNullable = true;
				colvarYlbm.IsPrimaryKey = false;
				colvarYlbm.IsForeignKey = false;
				colvarYlbm.IsReadOnly = false;
				colvarYlbm.DefaultSetting = @"";
				colvarYlbm.ForeignKeyTableName = "";
				schema.Columns.Add(colvarYlbm);
				
				TableSchema.TableColumn colvarScggdh = new TableSchema.TableColumn(schema);
				colvarScggdh.ColumnName = "scggdh";
				colvarScggdh.DataType = DbType.AnsiString;
				colvarScggdh.MaxLength = 50;
				colvarScggdh.AutoIncrement = false;
				colvarScggdh.IsNullable = true;
				colvarScggdh.IsPrimaryKey = false;
				colvarScggdh.IsForeignKey = false;
				colvarScggdh.IsReadOnly = false;
				colvarScggdh.DefaultSetting = @"";
				colvarScggdh.ForeignKeyTableName = "";
				schema.Columns.Add(colvarScggdh);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["Nowthwin"].AddSchema("T_Analysis_OrderListByDH",schema);
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
		public string Schtxh 
		{
			get { return GetColumnValue<string>(Columns.Schtxh); }
			set { SetColumnValue(Columns.Schtxh, value); }
		}
		  
		[XmlAttribute("Xtwpdm")]
		[Bindable(true)]
		public string Xtwpdm 
		{
			get { return GetColumnValue<string>(Columns.Xtwpdm); }
			set { SetColumnValue(Columns.Xtwpdm, value); }
		}
		  
		[XmlAttribute("Xtwpks")]
		[Bindable(true)]
		public string Xtwpks 
		{
			get { return GetColumnValue<string>(Columns.Xtwpks); }
			set { SetColumnValue(Columns.Xtwpks, value); }
		}
		  
		[XmlAttribute("Xtwpys")]
		[Bindable(true)]
		public string Xtwpys 
		{
			get { return GetColumnValue<string>(Columns.Xtwpys); }
			set { SetColumnValue(Columns.Xtwpys, value); }
		}
		  
		[XmlAttribute("Schtsl")]
		[Bindable(true)]
		public int? Schtsl 
		{
			get { return GetColumnValue<int?>(Columns.Schtsl); }
			set { SetColumnValue(Columns.Schtsl, value); }
		}
		  
		[XmlAttribute("Sckhjq")]
		[Bindable(true)]
		public DateTime? Sckhjq 
		{
			get { return GetColumnValue<DateTime?>(Columns.Sckhjq); }
			set { SetColumnValue(Columns.Sckhjq, value); }
		}
		  
		[XmlAttribute("Ylbm")]
		[Bindable(true)]
		public string Ylbm 
		{
			get { return GetColumnValue<string>(Columns.Ylbm); }
			set { SetColumnValue(Columns.Ylbm, value); }
		}
		  
		[XmlAttribute("Scggdh")]
		[Bindable(true)]
		public string Scggdh 
		{
			get { return GetColumnValue<string>(Columns.Scggdh); }
			set { SetColumnValue(Columns.Scggdh, value); }
		}
		
		#endregion
		
		
			
		
		//no foreign key tables defined (0)
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(string varSchtbh,string varSchtxh,string varXtwpdm,string varXtwpks,string varXtwpys,int? varSchtsl,DateTime? varSckhjq,string varYlbm,string varScggdh)
		{
			TAnalysisOrderListByDH item = new TAnalysisOrderListByDH();
			
			item.Schtbh = varSchtbh;
			
			item.Schtxh = varSchtxh;
			
			item.Xtwpdm = varXtwpdm;
			
			item.Xtwpks = varXtwpks;
			
			item.Xtwpys = varXtwpys;
			
			item.Schtsl = varSchtsl;
			
			item.Sckhjq = varSckhjq;
			
			item.Ylbm = varYlbm;
			
			item.Scggdh = varScggdh;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(string varSchtbh,string varSchtxh,string varXtwpdm,string varXtwpks,string varXtwpys,int? varSchtsl,DateTime? varSckhjq,string varYlbm,string varScggdh)
		{
			TAnalysisOrderListByDH item = new TAnalysisOrderListByDH();
			
				item.Schtbh = varSchtbh;
			
				item.Schtxh = varSchtxh;
			
				item.Xtwpdm = varXtwpdm;
			
				item.Xtwpks = varXtwpks;
			
				item.Xtwpys = varXtwpys;
			
				item.Schtsl = varSchtsl;
			
				item.Sckhjq = varSckhjq;
			
				item.Ylbm = varYlbm;
			
				item.Scggdh = varScggdh;
			
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
        
        
        
        public static TableSchema.TableColumn XtwpdmColumn
        {
            get { return Schema.Columns[2]; }
        }
        
        
        
        public static TableSchema.TableColumn XtwpksColumn
        {
            get { return Schema.Columns[3]; }
        }
        
        
        
        public static TableSchema.TableColumn XtwpysColumn
        {
            get { return Schema.Columns[4]; }
        }
        
        
        
        public static TableSchema.TableColumn SchtslColumn
        {
            get { return Schema.Columns[5]; }
        }
        
        
        
        public static TableSchema.TableColumn SckhjqColumn
        {
            get { return Schema.Columns[6]; }
        }
        
        
        
        public static TableSchema.TableColumn YlbmColumn
        {
            get { return Schema.Columns[7]; }
        }
        
        
        
        public static TableSchema.TableColumn ScggdhColumn
        {
            get { return Schema.Columns[8]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string Schtbh = @"schtbh";
			 public static string Schtxh = @"schtxh";
			 public static string Xtwpdm = @"xtwpdm";
			 public static string Xtwpks = @"xtwpks";
			 public static string Xtwpys = @"xtwpys";
			 public static string Schtsl = @"schtsl";
			 public static string Sckhjq = @"sckhjq";
			 public static string Ylbm = @"ylbm";
			 public static string Scggdh = @"scggdh";
						
		}
		#endregion
		
		#region Update PK Collections
		
        #endregion
    
        #region Deep Save
		
        #endregion
	}
}
