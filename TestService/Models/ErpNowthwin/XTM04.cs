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
	/// Strongly-typed collection for the XTM04 class.
	/// </summary>
    [Serializable]
	public partial class XTM04Collection : ActiveList<XTM04, XTM04Collection>
	{	   
		public XTM04Collection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>XTM04Collection</returns>
		public XTM04Collection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                XTM04 o = this[i];
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
	/// This is an ActiveRecord class which wraps the XTM04 table.
	/// </summary>
	[Serializable]
	public partial class XTM04 : ActiveRecord<XTM04>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public XTM04()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public XTM04(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public XTM04(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public XTM04(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("XTM04", TableType.Table, DataService.GetInstance("ErpNowthwin"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"FYERP";
				//columns
				
				TableSchema.TableColumn colvarXtcznd = new TableSchema.TableColumn(schema);
				colvarXtcznd.ColumnName = "XTCZND";
				colvarXtcznd.DataType = DbType.Decimal;
				colvarXtcznd.MaxLength = 0;
				colvarXtcznd.AutoIncrement = false;
				colvarXtcznd.IsNullable = false;
				colvarXtcznd.IsPrimaryKey = true;
				colvarXtcznd.IsForeignKey = false;
				colvarXtcznd.IsReadOnly = false;
				colvarXtcznd.DefaultSetting = @"";
				colvarXtcznd.ForeignKeyTableName = "";
				schema.Columns.Add(colvarXtcznd);
				
				TableSchema.TableColumn colvarXthsqi = new TableSchema.TableColumn(schema);
				colvarXthsqi.ColumnName = "XTHSQI";
				colvarXthsqi.DataType = DbType.Decimal;
				colvarXthsqi.MaxLength = 0;
				colvarXthsqi.AutoIncrement = false;
				colvarXthsqi.IsNullable = false;
				colvarXthsqi.IsPrimaryKey = true;
				colvarXthsqi.IsForeignKey = false;
				colvarXthsqi.IsReadOnly = false;
				colvarXthsqi.DefaultSetting = @"";
				colvarXthsqi.ForeignKeyTableName = "";
				schema.Columns.Add(colvarXthsqi);
				
				TableSchema.TableColumn colvarXtqsrq = new TableSchema.TableColumn(schema);
				colvarXtqsrq.ColumnName = "XTQSRQ";
				colvarXtqsrq.DataType = DbType.DateTime;
				colvarXtqsrq.MaxLength = 0;
				colvarXtqsrq.AutoIncrement = false;
				colvarXtqsrq.IsNullable = true;
				colvarXtqsrq.IsPrimaryKey = false;
				colvarXtqsrq.IsForeignKey = false;
				colvarXtqsrq.IsReadOnly = false;
				colvarXtqsrq.DefaultSetting = @"";
				colvarXtqsrq.ForeignKeyTableName = "";
				schema.Columns.Add(colvarXtqsrq);
				
				TableSchema.TableColumn colvarXtjzrq = new TableSchema.TableColumn(schema);
				colvarXtjzrq.ColumnName = "XTJZRQ";
				colvarXtjzrq.DataType = DbType.DateTime;
				colvarXtjzrq.MaxLength = 0;
				colvarXtjzrq.AutoIncrement = false;
				colvarXtjzrq.IsNullable = true;
				colvarXtjzrq.IsPrimaryKey = false;
				colvarXtjzrq.IsForeignKey = false;
				colvarXtjzrq.IsReadOnly = false;
				colvarXtjzrq.DefaultSetting = @"";
				colvarXtjzrq.ForeignKeyTableName = "";
				schema.Columns.Add(colvarXtjzrq);
				
				TableSchema.TableColumn colvarXtzhbz = new TableSchema.TableColumn(schema);
				colvarXtzhbz.ColumnName = "XTZHBZ";
				colvarXtzhbz.DataType = DbType.String;
				colvarXtzhbz.MaxLength = 1;
				colvarXtzhbz.AutoIncrement = false;
				colvarXtzhbz.IsNullable = true;
				colvarXtzhbz.IsPrimaryKey = false;
				colvarXtzhbz.IsForeignKey = false;
				colvarXtzhbz.IsReadOnly = false;
				colvarXtzhbz.DefaultSetting = @"";
				colvarXtzhbz.ForeignKeyTableName = "";
				schema.Columns.Add(colvarXtzhbz);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["ErpNowthwin"].AddSchema("XTM04",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("Xtcznd")]
		[Bindable(true)]
		public decimal Xtcznd 
		{
			get { return GetColumnValue<decimal>(Columns.Xtcznd); }
			set { SetColumnValue(Columns.Xtcznd, value); }
		}
		  
		[XmlAttribute("Xthsqi")]
		[Bindable(true)]
		public decimal Xthsqi 
		{
			get { return GetColumnValue<decimal>(Columns.Xthsqi); }
			set { SetColumnValue(Columns.Xthsqi, value); }
		}
		  
		[XmlAttribute("Xtqsrq")]
		[Bindable(true)]
		public DateTime? Xtqsrq 
		{
			get { return GetColumnValue<DateTime?>(Columns.Xtqsrq); }
			set { SetColumnValue(Columns.Xtqsrq, value); }
		}
		  
		[XmlAttribute("Xtjzrq")]
		[Bindable(true)]
		public DateTime? Xtjzrq 
		{
			get { return GetColumnValue<DateTime?>(Columns.Xtjzrq); }
			set { SetColumnValue(Columns.Xtjzrq, value); }
		}
		  
		[XmlAttribute("Xtzhbz")]
		[Bindable(true)]
		public string Xtzhbz 
		{
			get { return GetColumnValue<string>(Columns.Xtzhbz); }
			set { SetColumnValue(Columns.Xtzhbz, value); }
		}
		
		#endregion
		
		
			
		
		//no foreign key tables defined (0)
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(decimal varXtcznd,decimal varXthsqi,DateTime? varXtqsrq,DateTime? varXtjzrq,string varXtzhbz)
		{
			XTM04 item = new XTM04();
			
			item.Xtcznd = varXtcznd;
			
			item.Xthsqi = varXthsqi;
			
			item.Xtqsrq = varXtqsrq;
			
			item.Xtjzrq = varXtjzrq;
			
			item.Xtzhbz = varXtzhbz;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(decimal varXtcznd,decimal varXthsqi,DateTime? varXtqsrq,DateTime? varXtjzrq,string varXtzhbz)
		{
			XTM04 item = new XTM04();
			
				item.Xtcznd = varXtcznd;
			
				item.Xthsqi = varXthsqi;
			
				item.Xtqsrq = varXtqsrq;
			
				item.Xtjzrq = varXtjzrq;
			
				item.Xtzhbz = varXtzhbz;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn XtczndColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn XthsqiColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        public static TableSchema.TableColumn XtqsrqColumn
        {
            get { return Schema.Columns[2]; }
        }
        
        
        
        public static TableSchema.TableColumn XtjzrqColumn
        {
            get { return Schema.Columns[3]; }
        }
        
        
        
        public static TableSchema.TableColumn XtzhbzColumn
        {
            get { return Schema.Columns[4]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string Xtcznd = @"XTCZND";
			 public static string Xthsqi = @"XTHSQI";
			 public static string Xtqsrq = @"XTQSRQ";
			 public static string Xtjzrq = @"XTJZRQ";
			 public static string Xtzhbz = @"XTZHBZ";
						
		}
		#endregion
		
		#region Update PK Collections
		
        #endregion
    
        #region Deep Save
		
        #endregion
	}
}
