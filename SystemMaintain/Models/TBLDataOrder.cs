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
	/// Strongly-typed collection for the TBLDataOrder class.
	/// </summary>
    [Serializable]
	public partial class TBLDataOrderCollection : ActiveList<TBLDataOrder, TBLDataOrderCollection>
	{	   
		public TBLDataOrderCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>TBLDataOrderCollection</returns>
		public TBLDataOrderCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                TBLDataOrder o = this[i];
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
	/// This is an ActiveRecord class which wraps the T_BLData_Order table.
	/// </summary>
	[Serializable]
	public partial class TBLDataOrder : ActiveRecord<TBLDataOrder>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public TBLDataOrder()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public TBLDataOrder(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public TBLDataOrder(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public TBLDataOrder(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("T_BLData_Order", TableType.Table, DataService.GetInstance("Nowthwin"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarOrderid = new TableSchema.TableColumn(schema);
				colvarOrderid.ColumnName = "orderid";
				colvarOrderid.DataType = DbType.Int32;
				colvarOrderid.MaxLength = 0;
				colvarOrderid.AutoIncrement = true;
				colvarOrderid.IsNullable = false;
				colvarOrderid.IsPrimaryKey = true;
				colvarOrderid.IsForeignKey = false;
				colvarOrderid.IsReadOnly = false;
				colvarOrderid.DefaultSetting = @"";
				colvarOrderid.ForeignKeyTableName = "";
				schema.Columns.Add(colvarOrderid);
				
				TableSchema.TableColumn colvarKhdh = new TableSchema.TableColumn(schema);
				colvarKhdh.ColumnName = "khdh";
				colvarKhdh.DataType = DbType.String;
				colvarKhdh.MaxLength = 50;
				colvarKhdh.AutoIncrement = false;
				colvarKhdh.IsNullable = true;
				colvarKhdh.IsPrimaryKey = false;
				colvarKhdh.IsForeignKey = false;
				colvarKhdh.IsReadOnly = false;
				colvarKhdh.DefaultSetting = @"";
				colvarKhdh.ForeignKeyTableName = "";
				schema.Columns.Add(colvarKhdh);
				
				TableSchema.TableColumn colvarTrantime = new TableSchema.TableColumn(schema);
				colvarTrantime.ColumnName = "trantime";
				colvarTrantime.DataType = DbType.DateTime;
				colvarTrantime.MaxLength = 0;
				colvarTrantime.AutoIncrement = false;
				colvarTrantime.IsNullable = true;
				colvarTrantime.IsPrimaryKey = false;
				colvarTrantime.IsForeignKey = false;
				colvarTrantime.IsReadOnly = false;
				colvarTrantime.DefaultSetting = @"";
				colvarTrantime.ForeignKeyTableName = "";
				schema.Columns.Add(colvarTrantime);
				
				TableSchema.TableColumn colvarJhrq = new TableSchema.TableColumn(schema);
				colvarJhrq.ColumnName = "jhrq";
				colvarJhrq.DataType = DbType.DateTime;
				colvarJhrq.MaxLength = 0;
				colvarJhrq.AutoIncrement = false;
				colvarJhrq.IsNullable = true;
				colvarJhrq.IsPrimaryKey = false;
				colvarJhrq.IsForeignKey = false;
				colvarJhrq.IsReadOnly = false;
				colvarJhrq.DefaultSetting = @"";
				colvarJhrq.ForeignKeyTableName = "";
				schema.Columns.Add(colvarJhrq);
				
				TableSchema.TableColumn colvarCreatetime = new TableSchema.TableColumn(schema);
				colvarCreatetime.ColumnName = "createtime";
				colvarCreatetime.DataType = DbType.DateTime;
				colvarCreatetime.MaxLength = 0;
				colvarCreatetime.AutoIncrement = false;
				colvarCreatetime.IsNullable = true;
				colvarCreatetime.IsPrimaryKey = false;
				colvarCreatetime.IsForeignKey = false;
				colvarCreatetime.IsReadOnly = false;
				colvarCreatetime.DefaultSetting = @"";
				colvarCreatetime.ForeignKeyTableName = "";
				schema.Columns.Add(colvarCreatetime);
				
				TableSchema.TableColumn colvarSldl = new TableSchema.TableColumn(schema);
				colvarSldl.ColumnName = "sldl";
				colvarSldl.DataType = DbType.String;
				colvarSldl.MaxLength = 50;
				colvarSldl.AutoIncrement = false;
				colvarSldl.IsNullable = true;
				colvarSldl.IsPrimaryKey = false;
				colvarSldl.IsForeignKey = false;
				colvarSldl.IsReadOnly = false;
				colvarSldl.DefaultSetting = @"";
				colvarSldl.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSldl);
				
				TableSchema.TableColumn colvarCustomername = new TableSchema.TableColumn(schema);
				colvarCustomername.ColumnName = "customername";
				colvarCustomername.DataType = DbType.String;
				colvarCustomername.MaxLength = 100;
				colvarCustomername.AutoIncrement = false;
				colvarCustomername.IsNullable = true;
				colvarCustomername.IsPrimaryKey = false;
				colvarCustomername.IsForeignKey = false;
				colvarCustomername.IsReadOnly = false;
				colvarCustomername.DefaultSetting = @"";
				colvarCustomername.ForeignKeyTableName = "";
				schema.Columns.Add(colvarCustomername);
				
				TableSchema.TableColumn colvarTxtz = new TableSchema.TableColumn(schema);
				colvarTxtz.ColumnName = "txtz";
				colvarTxtz.DataType = DbType.String;
				colvarTxtz.MaxLength = 100;
				colvarTxtz.AutoIncrement = false;
				colvarTxtz.IsNullable = true;
				colvarTxtz.IsPrimaryKey = false;
				colvarTxtz.IsForeignKey = false;
				colvarTxtz.IsReadOnly = false;
				colvarTxtz.DefaultSetting = @"";
				colvarTxtz.ForeignKeyTableName = "";
				schema.Columns.Add(colvarTxtz);
				
				TableSchema.TableColumn colvarXhSyKh = new TableSchema.TableColumn(schema);
				colvarXhSyKh.ColumnName = "xh_sy_kh";
				colvarXhSyKh.DataType = DbType.String;
				colvarXhSyKh.MaxLength = -1;
				colvarXhSyKh.AutoIncrement = false;
				colvarXhSyKh.IsNullable = true;
				colvarXhSyKh.IsPrimaryKey = false;
				colvarXhSyKh.IsForeignKey = false;
				colvarXhSyKh.IsReadOnly = false;
				colvarXhSyKh.DefaultSetting = @"";
				colvarXhSyKh.ForeignKeyTableName = "";
				schema.Columns.Add(colvarXhSyKh);
				
				TableSchema.TableColumn colvarPbcd = new TableSchema.TableColumn(schema);
				colvarPbcd.ColumnName = "pbcd";
				colvarPbcd.DataType = DbType.String;
				colvarPbcd.MaxLength = 50;
				colvarPbcd.AutoIncrement = false;
				colvarPbcd.IsNullable = true;
				colvarPbcd.IsPrimaryKey = false;
				colvarPbcd.IsForeignKey = false;
				colvarPbcd.IsReadOnly = false;
				colvarPbcd.DefaultSetting = @"";
				colvarPbcd.ForeignKeyTableName = "";
				schema.Columns.Add(colvarPbcd);
				
				TableSchema.TableColumn colvarAudittime = new TableSchema.TableColumn(schema);
				colvarAudittime.ColumnName = "audittime";
				colvarAudittime.DataType = DbType.DateTime;
				colvarAudittime.MaxLength = 0;
				colvarAudittime.AutoIncrement = false;
				colvarAudittime.IsNullable = true;
				colvarAudittime.IsPrimaryKey = false;
				colvarAudittime.IsForeignKey = false;
				colvarAudittime.IsReadOnly = false;
				colvarAudittime.DefaultSetting = @"";
				colvarAudittime.ForeignKeyTableName = "";
				schema.Columns.Add(colvarAudittime);
				
				TableSchema.TableColumn colvarTzecode = new TableSchema.TableColumn(schema);
				colvarTzecode.ColumnName = "tzecode";
				colvarTzecode.DataType = DbType.String;
				colvarTzecode.MaxLength = 50;
				colvarTzecode.AutoIncrement = false;
				colvarTzecode.IsNullable = true;
				colvarTzecode.IsPrimaryKey = false;
				colvarTzecode.IsForeignKey = false;
				colvarTzecode.IsReadOnly = false;
				colvarTzecode.DefaultSetting = @"";
				colvarTzecode.ForeignKeyTableName = "";
				schema.Columns.Add(colvarTzecode);
				
				TableSchema.TableColumn colvarScggdh = new TableSchema.TableColumn(schema);
				colvarScggdh.ColumnName = "SCGGDH";
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
				
				TableSchema.TableColumn colvarOrderType = new TableSchema.TableColumn(schema);
				colvarOrderType.ColumnName = "orderType";
				colvarOrderType.DataType = DbType.Int32;
				colvarOrderType.MaxLength = 0;
				colvarOrderType.AutoIncrement = false;
				colvarOrderType.IsNullable = true;
				colvarOrderType.IsPrimaryKey = false;
				colvarOrderType.IsForeignKey = false;
				colvarOrderType.IsReadOnly = false;
				colvarOrderType.DefaultSetting = @"";
				colvarOrderType.ForeignKeyTableName = "";
				schema.Columns.Add(colvarOrderType);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["Nowthwin"].AddSchema("T_BLData_Order",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("Orderid")]
		[Bindable(true)]
		public int Orderid 
		{
			get { return GetColumnValue<int>(Columns.Orderid); }
			set { SetColumnValue(Columns.Orderid, value); }
		}
		  
		[XmlAttribute("Khdh")]
		[Bindable(true)]
		public string Khdh 
		{
			get { return GetColumnValue<string>(Columns.Khdh); }
			set { SetColumnValue(Columns.Khdh, value); }
		}
		  
		[XmlAttribute("Trantime")]
		[Bindable(true)]
		public DateTime? Trantime 
		{
			get { return GetColumnValue<DateTime?>(Columns.Trantime); }
			set { SetColumnValue(Columns.Trantime, value); }
		}
		  
		[XmlAttribute("Jhrq")]
		[Bindable(true)]
		public DateTime? Jhrq 
		{
			get { return GetColumnValue<DateTime?>(Columns.Jhrq); }
			set { SetColumnValue(Columns.Jhrq, value); }
		}
		  
		[XmlAttribute("Createtime")]
		[Bindable(true)]
		public DateTime? Createtime 
		{
			get { return GetColumnValue<DateTime?>(Columns.Createtime); }
			set { SetColumnValue(Columns.Createtime, value); }
		}
		  
		[XmlAttribute("Sldl")]
		[Bindable(true)]
		public string Sldl 
		{
			get { return GetColumnValue<string>(Columns.Sldl); }
			set { SetColumnValue(Columns.Sldl, value); }
		}
		  
		[XmlAttribute("Customername")]
		[Bindable(true)]
		public string Customername 
		{
			get { return GetColumnValue<string>(Columns.Customername); }
			set { SetColumnValue(Columns.Customername, value); }
		}
		  
		[XmlAttribute("Txtz")]
		[Bindable(true)]
		public string Txtz 
		{
			get { return GetColumnValue<string>(Columns.Txtz); }
			set { SetColumnValue(Columns.Txtz, value); }
		}
		  
		[XmlAttribute("XhSyKh")]
		[Bindable(true)]
		public string XhSyKh 
		{
			get { return GetColumnValue<string>(Columns.XhSyKh); }
			set { SetColumnValue(Columns.XhSyKh, value); }
		}
		  
		[XmlAttribute("Pbcd")]
		[Bindable(true)]
		public string Pbcd 
		{
			get { return GetColumnValue<string>(Columns.Pbcd); }
			set { SetColumnValue(Columns.Pbcd, value); }
		}
		  
		[XmlAttribute("Audittime")]
		[Bindable(true)]
		public DateTime? Audittime 
		{
			get { return GetColumnValue<DateTime?>(Columns.Audittime); }
			set { SetColumnValue(Columns.Audittime, value); }
		}
		  
		[XmlAttribute("Tzecode")]
		[Bindable(true)]
		public string Tzecode 
		{
			get { return GetColumnValue<string>(Columns.Tzecode); }
			set { SetColumnValue(Columns.Tzecode, value); }
		}
		  
		[XmlAttribute("Scggdh")]
		[Bindable(true)]
		public string Scggdh 
		{
			get { return GetColumnValue<string>(Columns.Scggdh); }
			set { SetColumnValue(Columns.Scggdh, value); }
		}
		  
		[XmlAttribute("FlagDelete")]
		[Bindable(true)]
		public int? FlagDelete 
		{
			get { return GetColumnValue<int?>(Columns.FlagDelete); }
			set { SetColumnValue(Columns.FlagDelete, value); }
		}
		  
		[XmlAttribute("OrderType")]
		[Bindable(true)]
		public int? OrderType 
		{
			get { return GetColumnValue<int?>(Columns.OrderType); }
			set { SetColumnValue(Columns.OrderType, value); }
		}
		
		#endregion
		
		
			
		
		//no foreign key tables defined (0)
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(string varKhdh,DateTime? varTrantime,DateTime? varJhrq,DateTime? varCreatetime,string varSldl,string varCustomername,string varTxtz,string varXhSyKh,string varPbcd,DateTime? varAudittime,string varTzecode,string varScggdh,int? varFlagDelete,int? varOrderType)
		{
			TBLDataOrder item = new TBLDataOrder();
			
			item.Khdh = varKhdh;
			
			item.Trantime = varTrantime;
			
			item.Jhrq = varJhrq;
			
			item.Createtime = varCreatetime;
			
			item.Sldl = varSldl;
			
			item.Customername = varCustomername;
			
			item.Txtz = varTxtz;
			
			item.XhSyKh = varXhSyKh;
			
			item.Pbcd = varPbcd;
			
			item.Audittime = varAudittime;
			
			item.Tzecode = varTzecode;
			
			item.Scggdh = varScggdh;
			
			item.FlagDelete = varFlagDelete;
			
			item.OrderType = varOrderType;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varOrderid,string varKhdh,DateTime? varTrantime,DateTime? varJhrq,DateTime? varCreatetime,string varSldl,string varCustomername,string varTxtz,string varXhSyKh,string varPbcd,DateTime? varAudittime,string varTzecode,string varScggdh,int? varFlagDelete,int? varOrderType)
		{
			TBLDataOrder item = new TBLDataOrder();
			
				item.Orderid = varOrderid;
			
				item.Khdh = varKhdh;
			
				item.Trantime = varTrantime;
			
				item.Jhrq = varJhrq;
			
				item.Createtime = varCreatetime;
			
				item.Sldl = varSldl;
			
				item.Customername = varCustomername;
			
				item.Txtz = varTxtz;
			
				item.XhSyKh = varXhSyKh;
			
				item.Pbcd = varPbcd;
			
				item.Audittime = varAudittime;
			
				item.Tzecode = varTzecode;
			
				item.Scggdh = varScggdh;
			
				item.FlagDelete = varFlagDelete;
			
				item.OrderType = varOrderType;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn OrderidColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn KhdhColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        public static TableSchema.TableColumn TrantimeColumn
        {
            get { return Schema.Columns[2]; }
        }
        
        
        
        public static TableSchema.TableColumn JhrqColumn
        {
            get { return Schema.Columns[3]; }
        }
        
        
        
        public static TableSchema.TableColumn CreatetimeColumn
        {
            get { return Schema.Columns[4]; }
        }
        
        
        
        public static TableSchema.TableColumn SldlColumn
        {
            get { return Schema.Columns[5]; }
        }
        
        
        
        public static TableSchema.TableColumn CustomernameColumn
        {
            get { return Schema.Columns[6]; }
        }
        
        
        
        public static TableSchema.TableColumn TxtzColumn
        {
            get { return Schema.Columns[7]; }
        }
        
        
        
        public static TableSchema.TableColumn XhSyKhColumn
        {
            get { return Schema.Columns[8]; }
        }
        
        
        
        public static TableSchema.TableColumn PbcdColumn
        {
            get { return Schema.Columns[9]; }
        }
        
        
        
        public static TableSchema.TableColumn AudittimeColumn
        {
            get { return Schema.Columns[10]; }
        }
        
        
        
        public static TableSchema.TableColumn TzecodeColumn
        {
            get { return Schema.Columns[11]; }
        }
        
        
        
        public static TableSchema.TableColumn ScggdhColumn
        {
            get { return Schema.Columns[12]; }
        }
        
        
        
        public static TableSchema.TableColumn FlagDeleteColumn
        {
            get { return Schema.Columns[13]; }
        }
        
        
        
        public static TableSchema.TableColumn OrderTypeColumn
        {
            get { return Schema.Columns[14]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string Orderid = @"orderid";
			 public static string Khdh = @"khdh";
			 public static string Trantime = @"trantime";
			 public static string Jhrq = @"jhrq";
			 public static string Createtime = @"createtime";
			 public static string Sldl = @"sldl";
			 public static string Customername = @"customername";
			 public static string Txtz = @"txtz";
			 public static string XhSyKh = @"xh_sy_kh";
			 public static string Pbcd = @"pbcd";
			 public static string Audittime = @"audittime";
			 public static string Tzecode = @"tzecode";
			 public static string Scggdh = @"SCGGDH";
			 public static string FlagDelete = @"flagDelete";
			 public static string OrderType = @"orderType";
						
		}
		#endregion
		
		#region Update PK Collections
		
        #endregion
    
        #region Deep Save
		
        #endregion
	}
}
