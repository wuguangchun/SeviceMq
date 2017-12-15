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
	/// Strongly-typed collection for the TFZfirstOutDelete class.
	/// </summary>
    [Serializable]
	public partial class TFZfirstOutDeleteCollection : ActiveList<TFZfirstOutDelete, TFZfirstOutDeleteCollection>
	{	   
		public TFZfirstOutDeleteCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>TFZfirstOutDeleteCollection</returns>
		public TFZfirstOutDeleteCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                TFZfirstOutDelete o = this[i];
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
	/// This is an ActiveRecord class which wraps the T_FZfirstOut_delete table.
	/// </summary>
	[Serializable]
	public partial class TFZfirstOutDelete : ActiveRecord<TFZfirstOutDelete>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public TFZfirstOutDelete()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public TFZfirstOutDelete(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public TFZfirstOutDelete(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public TFZfirstOutDelete(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("T_FZfirstOut_delete", TableType.Table, DataService.GetInstance("Nowthwin"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarPkid = new TableSchema.TableColumn(schema);
				colvarPkid.ColumnName = "pkid";
				colvarPkid.DataType = DbType.Int32;
				colvarPkid.MaxLength = 0;
				colvarPkid.AutoIncrement = false;
				colvarPkid.IsNullable = false;
				colvarPkid.IsPrimaryKey = true;
				colvarPkid.IsForeignKey = false;
				colvarPkid.IsReadOnly = false;
				colvarPkid.DefaultSetting = @"";
				colvarPkid.ForeignKeyTableName = "";
				schema.Columns.Add(colvarPkid);
				
				TableSchema.TableColumn colvarCustomerId = new TableSchema.TableColumn(schema);
				colvarCustomerId.ColumnName = "customerId";
				colvarCustomerId.DataType = DbType.AnsiString;
				colvarCustomerId.MaxLength = 50;
				colvarCustomerId.AutoIncrement = false;
				colvarCustomerId.IsNullable = true;
				colvarCustomerId.IsPrimaryKey = false;
				colvarCustomerId.IsForeignKey = false;
				colvarCustomerId.IsReadOnly = false;
				colvarCustomerId.DefaultSetting = @"";
				colvarCustomerId.ForeignKeyTableName = "";
				schema.Columns.Add(colvarCustomerId);
				
				TableSchema.TableColumn colvarBeginTime = new TableSchema.TableColumn(schema);
				colvarBeginTime.ColumnName = "beginTime";
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
				colvarEndTime.ColumnName = "endTime";
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
				
				TableSchema.TableColumn colvarGylx = new TableSchema.TableColumn(schema);
				colvarGylx.ColumnName = "gylx";
				colvarGylx.DataType = DbType.AnsiString;
				colvarGylx.MaxLength = -1;
				colvarGylx.AutoIncrement = false;
				colvarGylx.IsNullable = true;
				colvarGylx.IsPrimaryKey = false;
				colvarGylx.IsForeignKey = false;
				colvarGylx.IsReadOnly = false;
				colvarGylx.DefaultSetting = @"";
				colvarGylx.ForeignKeyTableName = "";
				schema.Columns.Add(colvarGylx);
				
				TableSchema.TableColumn colvarCoatCode = new TableSchema.TableColumn(schema);
				colvarCoatCode.ColumnName = "coatCode";
				colvarCoatCode.DataType = DbType.AnsiString;
				colvarCoatCode.MaxLength = 50;
				colvarCoatCode.AutoIncrement = false;
				colvarCoatCode.IsNullable = true;
				colvarCoatCode.IsPrimaryKey = false;
				colvarCoatCode.IsForeignKey = false;
				colvarCoatCode.IsReadOnly = false;
				colvarCoatCode.DefaultSetting = @"";
				colvarCoatCode.ForeignKeyTableName = "";
				schema.Columns.Add(colvarCoatCode);
				
				TableSchema.TableColumn colvarResoure = new TableSchema.TableColumn(schema);
				colvarResoure.ColumnName = "resoure";
				colvarResoure.DataType = DbType.AnsiString;
				colvarResoure.MaxLength = 50;
				colvarResoure.AutoIncrement = false;
				colvarResoure.IsNullable = true;
				colvarResoure.IsPrimaryKey = false;
				colvarResoure.IsForeignKey = false;
				colvarResoure.IsReadOnly = false;
				colvarResoure.DefaultSetting = @"";
				colvarResoure.ForeignKeyTableName = "";
				schema.Columns.Add(colvarResoure);
				
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
				
				TableSchema.TableColumn colvarTypeT = new TableSchema.TableColumn(schema);
				colvarTypeT.ColumnName = "typeT";
				colvarTypeT.DataType = DbType.Int32;
				colvarTypeT.MaxLength = 0;
				colvarTypeT.AutoIncrement = false;
				colvarTypeT.IsNullable = true;
				colvarTypeT.IsPrimaryKey = false;
				colvarTypeT.IsForeignKey = false;
				colvarTypeT.IsReadOnly = false;
				colvarTypeT.DefaultSetting = @"";
				colvarTypeT.ForeignKeyTableName = "";
				schema.Columns.Add(colvarTypeT);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["Nowthwin"].AddSchema("T_FZfirstOut_delete",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("Pkid")]
		[Bindable(true)]
		public int Pkid 
		{
			get { return GetColumnValue<int>(Columns.Pkid); }
			set { SetColumnValue(Columns.Pkid, value); }
		}
		  
		[XmlAttribute("CustomerId")]
		[Bindable(true)]
		public string CustomerId 
		{
			get { return GetColumnValue<string>(Columns.CustomerId); }
			set { SetColumnValue(Columns.CustomerId, value); }
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
		  
		[XmlAttribute("Gylx")]
		[Bindable(true)]
		public string Gylx 
		{
			get { return GetColumnValue<string>(Columns.Gylx); }
			set { SetColumnValue(Columns.Gylx, value); }
		}
		  
		[XmlAttribute("CoatCode")]
		[Bindable(true)]
		public string CoatCode 
		{
			get { return GetColumnValue<string>(Columns.CoatCode); }
			set { SetColumnValue(Columns.CoatCode, value); }
		}
		  
		[XmlAttribute("Resoure")]
		[Bindable(true)]
		public string Resoure 
		{
			get { return GetColumnValue<string>(Columns.Resoure); }
			set { SetColumnValue(Columns.Resoure, value); }
		}
		  
		[XmlAttribute("Num")]
		[Bindable(true)]
		public int? Num 
		{
			get { return GetColumnValue<int?>(Columns.Num); }
			set { SetColumnValue(Columns.Num, value); }
		}
		  
		[XmlAttribute("TypeT")]
		[Bindable(true)]
		public int? TypeT 
		{
			get { return GetColumnValue<int?>(Columns.TypeT); }
			set { SetColumnValue(Columns.TypeT, value); }
		}
		
		#endregion
		
		
			
		
		//no foreign key tables defined (0)
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(int varPkid,string varCustomerId,DateTime? varBeginTime,DateTime? varEndTime,string varGylx,string varCoatCode,string varResoure,int? varNum,int? varTypeT)
		{
			TFZfirstOutDelete item = new TFZfirstOutDelete();
			
			item.Pkid = varPkid;
			
			item.CustomerId = varCustomerId;
			
			item.BeginTime = varBeginTime;
			
			item.EndTime = varEndTime;
			
			item.Gylx = varGylx;
			
			item.CoatCode = varCoatCode;
			
			item.Resoure = varResoure;
			
			item.Num = varNum;
			
			item.TypeT = varTypeT;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varPkid,string varCustomerId,DateTime? varBeginTime,DateTime? varEndTime,string varGylx,string varCoatCode,string varResoure,int? varNum,int? varTypeT)
		{
			TFZfirstOutDelete item = new TFZfirstOutDelete();
			
				item.Pkid = varPkid;
			
				item.CustomerId = varCustomerId;
			
				item.BeginTime = varBeginTime;
			
				item.EndTime = varEndTime;
			
				item.Gylx = varGylx;
			
				item.CoatCode = varCoatCode;
			
				item.Resoure = varResoure;
			
				item.Num = varNum;
			
				item.TypeT = varTypeT;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn PkidColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn CustomerIdColumn
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
        
        
        
        public static TableSchema.TableColumn GylxColumn
        {
            get { return Schema.Columns[4]; }
        }
        
        
        
        public static TableSchema.TableColumn CoatCodeColumn
        {
            get { return Schema.Columns[5]; }
        }
        
        
        
        public static TableSchema.TableColumn ResoureColumn
        {
            get { return Schema.Columns[6]; }
        }
        
        
        
        public static TableSchema.TableColumn NumColumn
        {
            get { return Schema.Columns[7]; }
        }
        
        
        
        public static TableSchema.TableColumn TypeTColumn
        {
            get { return Schema.Columns[8]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string Pkid = @"pkid";
			 public static string CustomerId = @"customerId";
			 public static string BeginTime = @"beginTime";
			 public static string EndTime = @"endTime";
			 public static string Gylx = @"gylx";
			 public static string CoatCode = @"coatCode";
			 public static string Resoure = @"resoure";
			 public static string Num = @"num";
			 public static string TypeT = @"typeT";
						
		}
		#endregion
		
		#region Update PK Collections
		
        #endregion
    
        #region Deep Save
		
        #endregion
	}
}
