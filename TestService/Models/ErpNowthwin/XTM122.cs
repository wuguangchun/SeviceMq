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
	/// Strongly-typed collection for the XTM122 class.
	/// </summary>
    [Serializable]
	public partial class XTM122Collection : ActiveList<XTM122, XTM122Collection>
	{	   
		public XTM122Collection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>XTM122Collection</returns>
		public XTM122Collection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                XTM122 o = this[i];
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
	/// This is an ActiveRecord class which wraps the XTM122 table.
	/// </summary>
	[Serializable]
	public partial class XTM122 : ActiveRecord<XTM122>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public XTM122()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public XTM122(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public XTM122(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public XTM122(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("XTM122", TableType.Table, DataService.GetInstance("ErpNowthwin"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"FYERP";
				//columns
				
				TableSchema.TableColumn colvarXtwpjb = new TableSchema.TableColumn(schema);
				colvarXtwpjb.ColumnName = "XTWPJB";
				colvarXtwpjb.DataType = DbType.Decimal;
				colvarXtwpjb.MaxLength = 0;
				colvarXtwpjb.AutoIncrement = false;
				colvarXtwpjb.IsNullable = false;
				colvarXtwpjb.IsPrimaryKey = true;
				colvarXtwpjb.IsForeignKey = false;
				colvarXtwpjb.IsReadOnly = false;
				colvarXtwpjb.DefaultSetting = @"";
				colvarXtwpjb.ForeignKeyTableName = "";
				schema.Columns.Add(colvarXtwpjb);
				
				TableSchema.TableColumn colvarXtjblx = new TableSchema.TableColumn(schema);
				colvarXtjblx.ColumnName = "XTJBLX";
				colvarXtjblx.DataType = DbType.String;
				colvarXtjblx.MaxLength = 20;
				colvarXtjblx.AutoIncrement = false;
				colvarXtjblx.IsNullable = false;
				colvarXtjblx.IsPrimaryKey = true;
				colvarXtjblx.IsForeignKey = false;
				colvarXtjblx.IsReadOnly = false;
				colvarXtjblx.DefaultSetting = @"";
				colvarXtjblx.ForeignKeyTableName = "";
				schema.Columns.Add(colvarXtjblx);
				
				TableSchema.TableColumn colvarXtlxmc = new TableSchema.TableColumn(schema);
				colvarXtlxmc.ColumnName = "XTLXMC";
				colvarXtlxmc.DataType = DbType.String;
				colvarXtlxmc.MaxLength = 60;
				colvarXtlxmc.AutoIncrement = false;
				colvarXtlxmc.IsNullable = true;
				colvarXtlxmc.IsPrimaryKey = false;
				colvarXtlxmc.IsForeignKey = false;
				colvarXtlxmc.IsReadOnly = false;
				colvarXtlxmc.DefaultSetting = @"";
				colvarXtlxmc.ForeignKeyTableName = "";
				schema.Columns.Add(colvarXtlxmc);
				
				TableSchema.TableColumn colvarXtxhlx = new TableSchema.TableColumn(schema);
				colvarXtxhlx.ColumnName = "XTXHLX";
				colvarXtxhlx.DataType = DbType.String;
				colvarXtxhlx.MaxLength = 2;
				colvarXtxhlx.AutoIncrement = false;
				colvarXtxhlx.IsNullable = true;
				colvarXtxhlx.IsPrimaryKey = false;
				colvarXtxhlx.IsForeignKey = false;
				colvarXtxhlx.IsReadOnly = false;
				colvarXtxhlx.DefaultSetting = @"";
				colvarXtxhlx.ForeignKeyTableName = "";
				schema.Columns.Add(colvarXtxhlx);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["ErpNowthwin"].AddSchema("XTM122",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("Xtwpjb")]
		[Bindable(true)]
		public decimal Xtwpjb 
		{
			get { return GetColumnValue<decimal>(Columns.Xtwpjb); }
			set { SetColumnValue(Columns.Xtwpjb, value); }
		}
		  
		[XmlAttribute("Xtjblx")]
		[Bindable(true)]
		public string Xtjblx 
		{
			get { return GetColumnValue<string>(Columns.Xtjblx); }
			set { SetColumnValue(Columns.Xtjblx, value); }
		}
		  
		[XmlAttribute("Xtlxmc")]
		[Bindable(true)]
		public string Xtlxmc 
		{
			get { return GetColumnValue<string>(Columns.Xtlxmc); }
			set { SetColumnValue(Columns.Xtlxmc, value); }
		}
		  
		[XmlAttribute("Xtxhlx")]
		[Bindable(true)]
		public string Xtxhlx 
		{
			get { return GetColumnValue<string>(Columns.Xtxhlx); }
			set { SetColumnValue(Columns.Xtxhlx, value); }
		}
		
		#endregion
		
		
			
		
		//no foreign key tables defined (0)
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(decimal varXtwpjb,string varXtjblx,string varXtlxmc,string varXtxhlx)
		{
			XTM122 item = new XTM122();
			
			item.Xtwpjb = varXtwpjb;
			
			item.Xtjblx = varXtjblx;
			
			item.Xtlxmc = varXtlxmc;
			
			item.Xtxhlx = varXtxhlx;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(decimal varXtwpjb,string varXtjblx,string varXtlxmc,string varXtxhlx)
		{
			XTM122 item = new XTM122();
			
				item.Xtwpjb = varXtwpjb;
			
				item.Xtjblx = varXtjblx;
			
				item.Xtlxmc = varXtlxmc;
			
				item.Xtxhlx = varXtxhlx;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn XtwpjbColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn XtjblxColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        public static TableSchema.TableColumn XtlxmcColumn
        {
            get { return Schema.Columns[2]; }
        }
        
        
        
        public static TableSchema.TableColumn XtxhlxColumn
        {
            get { return Schema.Columns[3]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string Xtwpjb = @"XTWPJB";
			 public static string Xtjblx = @"XTJBLX";
			 public static string Xtlxmc = @"XTLXMC";
			 public static string Xtxhlx = @"XTXHLX";
						
		}
		#endregion
		
		#region Update PK Collections
		
        #endregion
    
        #region Deep Save
		
        #endregion
	}
}
