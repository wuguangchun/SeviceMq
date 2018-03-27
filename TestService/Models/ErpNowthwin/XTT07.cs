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
	/// Strongly-typed collection for the XTT07 class.
	/// </summary>
    [Serializable]
	public partial class XTT07Collection : ActiveList<XTT07, XTT07Collection>
	{	   
		public XTT07Collection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>XTT07Collection</returns>
		public XTT07Collection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                XTT07 o = this[i];
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
	/// This is an ActiveRecord class which wraps the XTT07 table.
	/// </summary>
	[Serializable]
	public partial class XTT07 : ActiveRecord<XTT07>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public XTT07()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public XTT07(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public XTT07(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public XTT07(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("XTT07", TableType.Table, DataService.GetInstance("ErpNowthwin"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"FYERP";
				//columns
				
				TableSchema.TableColumn colvarXtyhdm = new TableSchema.TableColumn(schema);
				colvarXtyhdm.ColumnName = "XTYHDM";
				colvarXtyhdm.DataType = DbType.String;
				colvarXtyhdm.MaxLength = 8;
				colvarXtyhdm.AutoIncrement = false;
				colvarXtyhdm.IsNullable = false;
				colvarXtyhdm.IsPrimaryKey = true;
				colvarXtyhdm.IsForeignKey = false;
				colvarXtyhdm.IsReadOnly = false;
				colvarXtyhdm.DefaultSetting = @"";
				colvarXtyhdm.ForeignKeyTableName = "";
				schema.Columns.Add(colvarXtyhdm);
				
				TableSchema.TableColumn colvarXtbmdm = new TableSchema.TableColumn(schema);
				colvarXtbmdm.ColumnName = "XTBMDM";
				colvarXtbmdm.DataType = DbType.String;
				colvarXtbmdm.MaxLength = 8;
				colvarXtbmdm.AutoIncrement = false;
				colvarXtbmdm.IsNullable = false;
				colvarXtbmdm.IsPrimaryKey = true;
				colvarXtbmdm.IsForeignKey = false;
				colvarXtbmdm.IsReadOnly = false;
				colvarXtbmdm.DefaultSetting = @"";
				colvarXtbmdm.ForeignKeyTableName = "";
				schema.Columns.Add(colvarXtbmdm);
				
				TableSchema.TableColumn colvarXtlrqx = new TableSchema.TableColumn(schema);
				colvarXtlrqx.ColumnName = "XTLRQX";
				colvarXtlrqx.DataType = DbType.String;
				colvarXtlrqx.MaxLength = 1;
				colvarXtlrqx.AutoIncrement = false;
				colvarXtlrqx.IsNullable = true;
				colvarXtlrqx.IsPrimaryKey = false;
				colvarXtlrqx.IsForeignKey = false;
				colvarXtlrqx.IsReadOnly = false;
				colvarXtlrqx.DefaultSetting = @"";
				colvarXtlrqx.ForeignKeyTableName = "";
				schema.Columns.Add(colvarXtlrqx);
				
				TableSchema.TableColumn colvarXtshqx = new TableSchema.TableColumn(schema);
				colvarXtshqx.ColumnName = "XTSHQX";
				colvarXtshqx.DataType = DbType.String;
				colvarXtshqx.MaxLength = 1;
				colvarXtshqx.AutoIncrement = false;
				colvarXtshqx.IsNullable = true;
				colvarXtshqx.IsPrimaryKey = false;
				colvarXtshqx.IsForeignKey = false;
				colvarXtshqx.IsReadOnly = false;
				colvarXtshqx.DefaultSetting = @"";
				colvarXtshqx.ForeignKeyTableName = "";
				schema.Columns.Add(colvarXtshqx);
				
				TableSchema.TableColumn colvarXtcxqx = new TableSchema.TableColumn(schema);
				colvarXtcxqx.ColumnName = "XTCXQX";
				colvarXtcxqx.DataType = DbType.String;
				colvarXtcxqx.MaxLength = 1;
				colvarXtcxqx.AutoIncrement = false;
				colvarXtcxqx.IsNullable = true;
				colvarXtcxqx.IsPrimaryKey = false;
				colvarXtcxqx.IsForeignKey = false;
				colvarXtcxqx.IsReadOnly = false;
				colvarXtcxqx.DefaultSetting = @"";
				colvarXtcxqx.ForeignKeyTableName = "";
				schema.Columns.Add(colvarXtcxqx);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["ErpNowthwin"].AddSchema("XTT07",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("Xtyhdm")]
		[Bindable(true)]
		public string Xtyhdm 
		{
			get { return GetColumnValue<string>(Columns.Xtyhdm); }
			set { SetColumnValue(Columns.Xtyhdm, value); }
		}
		  
		[XmlAttribute("Xtbmdm")]
		[Bindable(true)]
		public string Xtbmdm 
		{
			get { return GetColumnValue<string>(Columns.Xtbmdm); }
			set { SetColumnValue(Columns.Xtbmdm, value); }
		}
		  
		[XmlAttribute("Xtlrqx")]
		[Bindable(true)]
		public string Xtlrqx 
		{
			get { return GetColumnValue<string>(Columns.Xtlrqx); }
			set { SetColumnValue(Columns.Xtlrqx, value); }
		}
		  
		[XmlAttribute("Xtshqx")]
		[Bindable(true)]
		public string Xtshqx 
		{
			get { return GetColumnValue<string>(Columns.Xtshqx); }
			set { SetColumnValue(Columns.Xtshqx, value); }
		}
		  
		[XmlAttribute("Xtcxqx")]
		[Bindable(true)]
		public string Xtcxqx 
		{
			get { return GetColumnValue<string>(Columns.Xtcxqx); }
			set { SetColumnValue(Columns.Xtcxqx, value); }
		}
		
		#endregion
		
		
			
		
		//no foreign key tables defined (0)
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(string varXtyhdm,string varXtbmdm,string varXtlrqx,string varXtshqx,string varXtcxqx)
		{
			XTT07 item = new XTT07();
			
			item.Xtyhdm = varXtyhdm;
			
			item.Xtbmdm = varXtbmdm;
			
			item.Xtlrqx = varXtlrqx;
			
			item.Xtshqx = varXtshqx;
			
			item.Xtcxqx = varXtcxqx;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(string varXtyhdm,string varXtbmdm,string varXtlrqx,string varXtshqx,string varXtcxqx)
		{
			XTT07 item = new XTT07();
			
				item.Xtyhdm = varXtyhdm;
			
				item.Xtbmdm = varXtbmdm;
			
				item.Xtlrqx = varXtlrqx;
			
				item.Xtshqx = varXtshqx;
			
				item.Xtcxqx = varXtcxqx;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn XtyhdmColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn XtbmdmColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        public static TableSchema.TableColumn XtlrqxColumn
        {
            get { return Schema.Columns[2]; }
        }
        
        
        
        public static TableSchema.TableColumn XtshqxColumn
        {
            get { return Schema.Columns[3]; }
        }
        
        
        
        public static TableSchema.TableColumn XtcxqxColumn
        {
            get { return Schema.Columns[4]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string Xtyhdm = @"XTYHDM";
			 public static string Xtbmdm = @"XTBMDM";
			 public static string Xtlrqx = @"XTLRQX";
			 public static string Xtshqx = @"XTSHQX";
			 public static string Xtcxqx = @"XTCXQX";
						
		}
		#endregion
		
		#region Update PK Collections
		
        #endregion
    
        #region Deep Save
		
        #endregion
	}
}
