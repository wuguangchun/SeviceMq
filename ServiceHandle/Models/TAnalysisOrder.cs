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
	/// Strongly-typed collection for the TAnalysisOrder class.
	/// </summary>
    [Serializable]
	public partial class TAnalysisOrderCollection : ActiveList<TAnalysisOrder, TAnalysisOrderCollection>
	{	   
		public TAnalysisOrderCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>TAnalysisOrderCollection</returns>
		public TAnalysisOrderCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                TAnalysisOrder o = this[i];
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
	/// This is an ActiveRecord class which wraps the T_Analysis_Order table.
	/// </summary>
	[Serializable]
	public partial class TAnalysisOrder : ActiveRecord<TAnalysisOrder>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public TAnalysisOrder()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public TAnalysisOrder(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public TAnalysisOrder(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public TAnalysisOrder(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("T_Analysis_Order", TableType.Table, DataService.GetInstance("Nowthwin"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarOrderId = new TableSchema.TableColumn(schema);
				colvarOrderId.ColumnName = "orderId";
				colvarOrderId.DataType = DbType.String;
				colvarOrderId.MaxLength = 50;
				colvarOrderId.AutoIncrement = false;
				colvarOrderId.IsNullable = false;
				colvarOrderId.IsPrimaryKey = true;
				colvarOrderId.IsForeignKey = false;
				colvarOrderId.IsReadOnly = false;
				colvarOrderId.DefaultSetting = @"";
				colvarOrderId.ForeignKeyTableName = "";
				schema.Columns.Add(colvarOrderId);
				
				TableSchema.TableColumn colvarCustomerId = new TableSchema.TableColumn(schema);
				colvarCustomerId.ColumnName = "customerId";
				colvarCustomerId.DataType = DbType.String;
				colvarCustomerId.MaxLength = 100;
				colvarCustomerId.AutoIncrement = false;
				colvarCustomerId.IsNullable = true;
				colvarCustomerId.IsPrimaryKey = false;
				colvarCustomerId.IsForeignKey = false;
				colvarCustomerId.IsReadOnly = false;
				colvarCustomerId.DefaultSetting = @"";
				colvarCustomerId.ForeignKeyTableName = "";
				schema.Columns.Add(colvarCustomerId);
				
				TableSchema.TableColumn colvarOrderType = new TableSchema.TableColumn(schema);
				colvarOrderType.ColumnName = "orderType";
				colvarOrderType.DataType = DbType.String;
				colvarOrderType.MaxLength = 100;
				colvarOrderType.AutoIncrement = false;
				colvarOrderType.IsNullable = true;
				colvarOrderType.IsPrimaryKey = false;
				colvarOrderType.IsForeignKey = false;
				colvarOrderType.IsReadOnly = false;
				colvarOrderType.DefaultSetting = @"";
				colvarOrderType.ForeignKeyTableName = "";
				schema.Columns.Add(colvarOrderType);
				
				TableSchema.TableColumn colvarCoatType = new TableSchema.TableColumn(schema);
				colvarCoatType.ColumnName = "coatType";
				colvarCoatType.DataType = DbType.String;
				colvarCoatType.MaxLength = 100;
				colvarCoatType.AutoIncrement = false;
				colvarCoatType.IsNullable = true;
				colvarCoatType.IsPrimaryKey = false;
				colvarCoatType.IsForeignKey = false;
				colvarCoatType.IsReadOnly = false;
				colvarCoatType.DefaultSetting = @"";
				colvarCoatType.ForeignKeyTableName = "";
				schema.Columns.Add(colvarCoatType);
				
				TableSchema.TableColumn colvarBodyType = new TableSchema.TableColumn(schema);
				colvarBodyType.ColumnName = "bodyType";
				colvarBodyType.DataType = DbType.String;
				colvarBodyType.MaxLength = 100;
				colvarBodyType.AutoIncrement = false;
				colvarBodyType.IsNullable = true;
				colvarBodyType.IsPrimaryKey = false;
				colvarBodyType.IsForeignKey = false;
				colvarBodyType.IsReadOnly = false;
				colvarBodyType.DefaultSetting = @"";
				colvarBodyType.ForeignKeyTableName = "";
				schema.Columns.Add(colvarBodyType);
				
				TableSchema.TableColumn colvarSpecialTime = new TableSchema.TableColumn(schema);
				colvarSpecialTime.ColumnName = "specialTime";
				colvarSpecialTime.DataType = DbType.Int32;
				colvarSpecialTime.MaxLength = 0;
				colvarSpecialTime.AutoIncrement = false;
				colvarSpecialTime.IsNullable = true;
				colvarSpecialTime.IsPrimaryKey = false;
				colvarSpecialTime.IsForeignKey = false;
				colvarSpecialTime.IsReadOnly = false;
				colvarSpecialTime.DefaultSetting = @"";
				colvarSpecialTime.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSpecialTime);
				
				TableSchema.TableColumn colvarSpecialCode = new TableSchema.TableColumn(schema);
				colvarSpecialCode.ColumnName = "specialCode";
				colvarSpecialCode.DataType = DbType.String;
				colvarSpecialCode.MaxLength = 100;
				colvarSpecialCode.AutoIncrement = false;
				colvarSpecialCode.IsNullable = true;
				colvarSpecialCode.IsPrimaryKey = false;
				colvarSpecialCode.IsForeignKey = false;
				colvarSpecialCode.IsReadOnly = false;
				colvarSpecialCode.DefaultSetting = @"";
				colvarSpecialCode.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSpecialCode);
				
				TableSchema.TableColumn colvarCreateDate = new TableSchema.TableColumn(schema);
				colvarCreateDate.ColumnName = "createDate";
				colvarCreateDate.DataType = DbType.DateTime;
				colvarCreateDate.MaxLength = 0;
				colvarCreateDate.AutoIncrement = false;
				colvarCreateDate.IsNullable = true;
				colvarCreateDate.IsPrimaryKey = false;
				colvarCreateDate.IsForeignKey = false;
				colvarCreateDate.IsReadOnly = false;
				colvarCreateDate.DefaultSetting = @"";
				colvarCreateDate.ForeignKeyTableName = "";
				schema.Columns.Add(colvarCreateDate);
				
				TableSchema.TableColumn colvarSfbcpsy = new TableSchema.TableColumn(schema);
				colvarSfbcpsy.ColumnName = "sfbcpsy";
				colvarSfbcpsy.DataType = DbType.String;
				colvarSfbcpsy.MaxLength = 100;
				colvarSfbcpsy.AutoIncrement = false;
				colvarSfbcpsy.IsNullable = true;
				colvarSfbcpsy.IsPrimaryKey = false;
				colvarSfbcpsy.IsForeignKey = false;
				colvarSfbcpsy.IsReadOnly = false;
				colvarSfbcpsy.DefaultSetting = @"";
				colvarSfbcpsy.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSfbcpsy);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["Nowthwin"].AddSchema("T_Analysis_Order",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("OrderId")]
		[Bindable(true)]
		public string OrderId 
		{
			get { return GetColumnValue<string>(Columns.OrderId); }
			set { SetColumnValue(Columns.OrderId, value); }
		}
		  
		[XmlAttribute("CustomerId")]
		[Bindable(true)]
		public string CustomerId 
		{
			get { return GetColumnValue<string>(Columns.CustomerId); }
			set { SetColumnValue(Columns.CustomerId, value); }
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
		  
		[XmlAttribute("BodyType")]
		[Bindable(true)]
		public string BodyType 
		{
			get { return GetColumnValue<string>(Columns.BodyType); }
			set { SetColumnValue(Columns.BodyType, value); }
		}
		  
		[XmlAttribute("SpecialTime")]
		[Bindable(true)]
		public int? SpecialTime 
		{
			get { return GetColumnValue<int?>(Columns.SpecialTime); }
			set { SetColumnValue(Columns.SpecialTime, value); }
		}
		  
		[XmlAttribute("SpecialCode")]
		[Bindable(true)]
		public string SpecialCode 
		{
			get { return GetColumnValue<string>(Columns.SpecialCode); }
			set { SetColumnValue(Columns.SpecialCode, value); }
		}
		  
		[XmlAttribute("CreateDate")]
		[Bindable(true)]
		public DateTime? CreateDate 
		{
			get { return GetColumnValue<DateTime?>(Columns.CreateDate); }
			set { SetColumnValue(Columns.CreateDate, value); }
		}
		  
		[XmlAttribute("Sfbcpsy")]
		[Bindable(true)]
		public string Sfbcpsy 
		{
			get { return GetColumnValue<string>(Columns.Sfbcpsy); }
			set { SetColumnValue(Columns.Sfbcpsy, value); }
		}
		
		#endregion
		
		
			
		
		//no foreign key tables defined (0)
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(string varOrderId,string varCustomerId,string varOrderType,string varCoatType,string varBodyType,int? varSpecialTime,string varSpecialCode,DateTime? varCreateDate,string varSfbcpsy)
		{
			TAnalysisOrder item = new TAnalysisOrder();
			
			item.OrderId = varOrderId;
			
			item.CustomerId = varCustomerId;
			
			item.OrderType = varOrderType;
			
			item.CoatType = varCoatType;
			
			item.BodyType = varBodyType;
			
			item.SpecialTime = varSpecialTime;
			
			item.SpecialCode = varSpecialCode;
			
			item.CreateDate = varCreateDate;
			
			item.Sfbcpsy = varSfbcpsy;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(string varOrderId,string varCustomerId,string varOrderType,string varCoatType,string varBodyType,int? varSpecialTime,string varSpecialCode,DateTime? varCreateDate,string varSfbcpsy)
		{
			TAnalysisOrder item = new TAnalysisOrder();
			
				item.OrderId = varOrderId;
			
				item.CustomerId = varCustomerId;
			
				item.OrderType = varOrderType;
			
				item.CoatType = varCoatType;
			
				item.BodyType = varBodyType;
			
				item.SpecialTime = varSpecialTime;
			
				item.SpecialCode = varSpecialCode;
			
				item.CreateDate = varCreateDate;
			
				item.Sfbcpsy = varSfbcpsy;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn OrderIdColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn CustomerIdColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        public static TableSchema.TableColumn OrderTypeColumn
        {
            get { return Schema.Columns[2]; }
        }
        
        
        
        public static TableSchema.TableColumn CoatTypeColumn
        {
            get { return Schema.Columns[3]; }
        }
        
        
        
        public static TableSchema.TableColumn BodyTypeColumn
        {
            get { return Schema.Columns[4]; }
        }
        
        
        
        public static TableSchema.TableColumn SpecialTimeColumn
        {
            get { return Schema.Columns[5]; }
        }
        
        
        
        public static TableSchema.TableColumn SpecialCodeColumn
        {
            get { return Schema.Columns[6]; }
        }
        
        
        
        public static TableSchema.TableColumn CreateDateColumn
        {
            get { return Schema.Columns[7]; }
        }
        
        
        
        public static TableSchema.TableColumn SfbcpsyColumn
        {
            get { return Schema.Columns[8]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string OrderId = @"orderId";
			 public static string CustomerId = @"customerId";
			 public static string OrderType = @"orderType";
			 public static string CoatType = @"coatType";
			 public static string BodyType = @"bodyType";
			 public static string SpecialTime = @"specialTime";
			 public static string SpecialCode = @"specialCode";
			 public static string CreateDate = @"createDate";
			 public static string Sfbcpsy = @"sfbcpsy";
						
		}
		#endregion
		
		#region Update PK Collections
		
        #endregion
    
        #region Deep Save
		
        #endregion
	}
}
