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
	/// Strongly-typed collection for the TOldApsByCf3 class.
	/// </summary>
    [Serializable]
	public partial class TOldApsByCf3Collection : ActiveList<TOldApsByCf3, TOldApsByCf3Collection>
	{	   
		public TOldApsByCf3Collection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>TOldApsByCf3Collection</returns>
		public TOldApsByCf3Collection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                TOldApsByCf3 o = this[i];
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
	/// This is an ActiveRecord class which wraps the T_OldApsByCf_3 table.
	/// </summary>
	[Serializable]
	public partial class TOldApsByCf3 : ActiveRecord<TOldApsByCf3>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public TOldApsByCf3()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public TOldApsByCf3(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public TOldApsByCf3(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public TOldApsByCf3(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("T_OldApsByCf_3", TableType.Table, DataService.GetInstance("Nowthwin"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarId = new TableSchema.TableColumn(schema);
				colvarId.ColumnName = "ID";
				colvarId.DataType = DbType.Int32;
				colvarId.MaxLength = 0;
				colvarId.AutoIncrement = true;
				colvarId.IsNullable = false;
				colvarId.IsPrimaryKey = true;
				colvarId.IsForeignKey = false;
				colvarId.IsReadOnly = false;
				colvarId.DefaultSetting = @"";
				colvarId.ForeignKeyTableName = "";
				schema.Columns.Add(colvarId);
				
				TableSchema.TableColumn colvarOrderID = new TableSchema.TableColumn(schema);
				colvarOrderID.ColumnName = "OrderID";
				colvarOrderID.DataType = DbType.String;
				colvarOrderID.MaxLength = 50;
				colvarOrderID.AutoIncrement = false;
				colvarOrderID.IsNullable = true;
				colvarOrderID.IsPrimaryKey = false;
				colvarOrderID.IsForeignKey = false;
				colvarOrderID.IsReadOnly = false;
				colvarOrderID.DefaultSetting = @"";
				colvarOrderID.ForeignKeyTableName = "";
				schema.Columns.Add(colvarOrderID);
				
				TableSchema.TableColumn colvarBeginTime = new TableSchema.TableColumn(schema);
				colvarBeginTime.ColumnName = "BeginTime";
				colvarBeginTime.DataType = DbType.DateTime;
				colvarBeginTime.MaxLength = 0;
				colvarBeginTime.AutoIncrement = false;
				colvarBeginTime.IsNullable = true;
				colvarBeginTime.IsPrimaryKey = false;
				colvarBeginTime.IsForeignKey = false;
				colvarBeginTime.IsReadOnly = false;
				colvarBeginTime.DefaultSetting = @"";
				colvarBeginTime.ForeignKeyTableName = "";
				schema.Columns.Add(colvarBeginTime);
				
				TableSchema.TableColumn colvarEndTime = new TableSchema.TableColumn(schema);
				colvarEndTime.ColumnName = "EndTime";
				colvarEndTime.DataType = DbType.DateTime;
				colvarEndTime.MaxLength = 0;
				colvarEndTime.AutoIncrement = false;
				colvarEndTime.IsNullable = true;
				colvarEndTime.IsPrimaryKey = false;
				colvarEndTime.IsForeignKey = false;
				colvarEndTime.IsReadOnly = false;
				colvarEndTime.DefaultSetting = @"";
				colvarEndTime.ForeignKeyTableName = "";
				schema.Columns.Add(colvarEndTime);
				
				TableSchema.TableColumn colvarCutDate = new TableSchema.TableColumn(schema);
				colvarCutDate.ColumnName = "CutDate";
				colvarCutDate.DataType = DbType.AnsiString;
				colvarCutDate.MaxLength = 0;
				colvarCutDate.AutoIncrement = false;
				colvarCutDate.IsNullable = true;
				colvarCutDate.IsPrimaryKey = false;
				colvarCutDate.IsForeignKey = false;
				colvarCutDate.IsReadOnly = false;
				colvarCutDate.DefaultSetting = @"";
				colvarCutDate.ForeignKeyTableName = "";
				schema.Columns.Add(colvarCutDate);
				
				TableSchema.TableColumn colvarCutTime = new TableSchema.TableColumn(schema);
				colvarCutTime.ColumnName = "CutTime";
				colvarCutTime.DataType = DbType.String;
				colvarCutTime.MaxLength = 50;
				colvarCutTime.AutoIncrement = false;
				colvarCutTime.IsNullable = true;
				colvarCutTime.IsPrimaryKey = false;
				colvarCutTime.IsForeignKey = false;
				colvarCutTime.IsReadOnly = false;
				colvarCutTime.DefaultSetting = @"";
				colvarCutTime.ForeignKeyTableName = "";
				schema.Columns.Add(colvarCutTime);
				
				TableSchema.TableColumn colvarCutNo = new TableSchema.TableColumn(schema);
				colvarCutNo.ColumnName = "CutNo";
				colvarCutNo.DataType = DbType.Int32;
				colvarCutNo.MaxLength = 0;
				colvarCutNo.AutoIncrement = false;
				colvarCutNo.IsNullable = true;
				colvarCutNo.IsPrimaryKey = false;
				colvarCutNo.IsForeignKey = false;
				colvarCutNo.IsReadOnly = false;
				colvarCutNo.DefaultSetting = @"";
				colvarCutNo.ForeignKeyTableName = "";
				schema.Columns.Add(colvarCutNo);
				
				TableSchema.TableColumn colvarCreateTime = new TableSchema.TableColumn(schema);
				colvarCreateTime.ColumnName = "CreateTime";
				colvarCreateTime.DataType = DbType.DateTime;
				colvarCreateTime.MaxLength = 0;
				colvarCreateTime.AutoIncrement = false;
				colvarCreateTime.IsNullable = true;
				colvarCreateTime.IsPrimaryKey = false;
				colvarCreateTime.IsForeignKey = false;
				colvarCreateTime.IsReadOnly = false;
				colvarCreateTime.DefaultSetting = @"";
				colvarCreateTime.ForeignKeyTableName = "";
				schema.Columns.Add(colvarCreateTime);
				
				TableSchema.TableColumn colvarScggdh = new TableSchema.TableColumn(schema);
				colvarScggdh.ColumnName = "Scggdh";
				colvarScggdh.DataType = DbType.String;
				colvarScggdh.MaxLength = 50;
				colvarScggdh.AutoIncrement = false;
				colvarScggdh.IsNullable = true;
				colvarScggdh.IsPrimaryKey = false;
				colvarScggdh.IsForeignKey = false;
				colvarScggdh.IsReadOnly = false;
				colvarScggdh.DefaultSetting = @"";
				colvarScggdh.ForeignKeyTableName = "";
				schema.Columns.Add(colvarScggdh);
				
				TableSchema.TableColumn colvarOrderType = new TableSchema.TableColumn(schema);
				colvarOrderType.ColumnName = "OrderType";
				colvarOrderType.DataType = DbType.String;
				colvarOrderType.MaxLength = 255;
				colvarOrderType.AutoIncrement = false;
				colvarOrderType.IsNullable = true;
				colvarOrderType.IsPrimaryKey = false;
				colvarOrderType.IsForeignKey = false;
				colvarOrderType.IsReadOnly = false;
				colvarOrderType.DefaultSetting = @"";
				colvarOrderType.ForeignKeyTableName = "";
				schema.Columns.Add(colvarOrderType);
				
				TableSchema.TableColumn colvarCoatType = new TableSchema.TableColumn(schema);
				colvarCoatType.ColumnName = "CoatType";
				colvarCoatType.DataType = DbType.String;
				colvarCoatType.MaxLength = 255;
				colvarCoatType.AutoIncrement = false;
				colvarCoatType.IsNullable = true;
				colvarCoatType.IsPrimaryKey = false;
				colvarCoatType.IsForeignKey = false;
				colvarCoatType.IsReadOnly = false;
				colvarCoatType.DefaultSetting = @"";
				colvarCoatType.ForeignKeyTableName = "";
				schema.Columns.Add(colvarCoatType);
				
				TableSchema.TableColumn colvarStylesResult = new TableSchema.TableColumn(schema);
				colvarStylesResult.ColumnName = "StylesResult";
				colvarStylesResult.DataType = DbType.String;
				colvarStylesResult.MaxLength = 255;
				colvarStylesResult.AutoIncrement = false;
				colvarStylesResult.IsNullable = true;
				colvarStylesResult.IsPrimaryKey = false;
				colvarStylesResult.IsForeignKey = false;
				colvarStylesResult.IsReadOnly = false;
				colvarStylesResult.DefaultSetting = @"";
				colvarStylesResult.ForeignKeyTableName = "";
				schema.Columns.Add(colvarStylesResult);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["Nowthwin"].AddSchema("T_OldApsByCf_3",schema);
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
		  
		[XmlAttribute("OrderID")]
		[Bindable(true)]
		public string OrderID 
		{
			get { return GetColumnValue<string>(Columns.OrderID); }
			set { SetColumnValue(Columns.OrderID, value); }
		}
		  
		[XmlAttribute("BeginTime")]
		[Bindable(true)]
		public DateTime? BeginTime 
		{
			get { return GetColumnValue<DateTime?>(Columns.BeginTime); }
			set { SetColumnValue(Columns.BeginTime, value); }
		}
		  
		[XmlAttribute("EndTime")]
		[Bindable(true)]
		public DateTime? EndTime 
		{
			get { return GetColumnValue<DateTime?>(Columns.EndTime); }
			set { SetColumnValue(Columns.EndTime, value); }
		}
		  
		[XmlAttribute("CutDate")]
		[Bindable(true)]
		public string CutDate 
		{
			get { return GetColumnValue<string>(Columns.CutDate); }
			set { SetColumnValue(Columns.CutDate, value); }
		}
		  
		[XmlAttribute("CutTime")]
		[Bindable(true)]
		public string CutTime 
		{
			get { return GetColumnValue<string>(Columns.CutTime); }
			set { SetColumnValue(Columns.CutTime, value); }
		}
		  
		[XmlAttribute("CutNo")]
		[Bindable(true)]
		public int? CutNo 
		{
			get { return GetColumnValue<int?>(Columns.CutNo); }
			set { SetColumnValue(Columns.CutNo, value); }
		}
		  
		[XmlAttribute("CreateTime")]
		[Bindable(true)]
		public DateTime? CreateTime 
		{
			get { return GetColumnValue<DateTime?>(Columns.CreateTime); }
			set { SetColumnValue(Columns.CreateTime, value); }
		}
		  
		[XmlAttribute("Scggdh")]
		[Bindable(true)]
		public string Scggdh 
		{
			get { return GetColumnValue<string>(Columns.Scggdh); }
			set { SetColumnValue(Columns.Scggdh, value); }
		}
		  
		[XmlAttribute("OrderType")]
		[Bindable(true)]
		public string OrderType 
		{
			get { return GetColumnValue<string>(Columns.OrderType); }
			set { SetColumnValue(Columns.OrderType, value); }
		}
		  
		[XmlAttribute("CoatType")]
		[Bindable(true)]
		public string CoatType 
		{
			get { return GetColumnValue<string>(Columns.CoatType); }
			set { SetColumnValue(Columns.CoatType, value); }
		}
		  
		[XmlAttribute("StylesResult")]
		[Bindable(true)]
		public string StylesResult 
		{
			get { return GetColumnValue<string>(Columns.StylesResult); }
			set { SetColumnValue(Columns.StylesResult, value); }
		}
		
		#endregion
		
		
			
		
		//no foreign key tables defined (0)
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(string varOrderID,DateTime? varBeginTime,DateTime? varEndTime,string varCutDate,string varCutTime,int? varCutNo,DateTime? varCreateTime,string varScggdh,string varOrderType,string varCoatType,string varStylesResult)
		{
			TOldApsByCf3 item = new TOldApsByCf3();
			
			item.OrderID = varOrderID;
			
			item.BeginTime = varBeginTime;
			
			item.EndTime = varEndTime;
			
			item.CutDate = varCutDate;
			
			item.CutTime = varCutTime;
			
			item.CutNo = varCutNo;
			
			item.CreateTime = varCreateTime;
			
			item.Scggdh = varScggdh;
			
			item.OrderType = varOrderType;
			
			item.CoatType = varCoatType;
			
			item.StylesResult = varStylesResult;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varId,string varOrderID,DateTime? varBeginTime,DateTime? varEndTime,string varCutDate,string varCutTime,int? varCutNo,DateTime? varCreateTime,string varScggdh,string varOrderType,string varCoatType,string varStylesResult)
		{
			TOldApsByCf3 item = new TOldApsByCf3();
			
				item.Id = varId;
			
				item.OrderID = varOrderID;
			
				item.BeginTime = varBeginTime;
			
				item.EndTime = varEndTime;
			
				item.CutDate = varCutDate;
			
				item.CutTime = varCutTime;
			
				item.CutNo = varCutNo;
			
				item.CreateTime = varCreateTime;
			
				item.Scggdh = varScggdh;
			
				item.OrderType = varOrderType;
			
				item.CoatType = varCoatType;
			
				item.StylesResult = varStylesResult;
			
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
        
        
        
        public static TableSchema.TableColumn OrderIDColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        public static TableSchema.TableColumn BeginTimeColumn
        {
            get { return Schema.Columns[2]; }
        }
        
        
        
        public static TableSchema.TableColumn EndTimeColumn
        {
            get { return Schema.Columns[3]; }
        }
        
        
        
        public static TableSchema.TableColumn CutDateColumn
        {
            get { return Schema.Columns[4]; }
        }
        
        
        
        public static TableSchema.TableColumn CutTimeColumn
        {
            get { return Schema.Columns[5]; }
        }
        
        
        
        public static TableSchema.TableColumn CutNoColumn
        {
            get { return Schema.Columns[6]; }
        }
        
        
        
        public static TableSchema.TableColumn CreateTimeColumn
        {
            get { return Schema.Columns[7]; }
        }
        
        
        
        public static TableSchema.TableColumn ScggdhColumn
        {
            get { return Schema.Columns[8]; }
        }
        
        
        
        public static TableSchema.TableColumn OrderTypeColumn
        {
            get { return Schema.Columns[9]; }
        }
        
        
        
        public static TableSchema.TableColumn CoatTypeColumn
        {
            get { return Schema.Columns[10]; }
        }
        
        
        
        public static TableSchema.TableColumn StylesResultColumn
        {
            get { return Schema.Columns[11]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string Id = @"ID";
			 public static string OrderID = @"OrderID";
			 public static string BeginTime = @"BeginTime";
			 public static string EndTime = @"EndTime";
			 public static string CutDate = @"CutDate";
			 public static string CutTime = @"CutTime";
			 public static string CutNo = @"CutNo";
			 public static string CreateTime = @"CreateTime";
			 public static string Scggdh = @"Scggdh";
			 public static string OrderType = @"OrderType";
			 public static string CoatType = @"CoatType";
			 public static string StylesResult = @"StylesResult";
						
		}
		#endregion
		
		#region Update PK Collections
		
        #endregion
    
        #region Deep Save
		
        #endregion
	}
}
