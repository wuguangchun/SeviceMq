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
	/// Strongly-typed collection for the XSM01 class.
	/// </summary>
    [Serializable]
	public partial class XSM01Collection : ActiveList<XSM01, XSM01Collection>
	{	   
		public XSM01Collection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>XSM01Collection</returns>
		public XSM01Collection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                XSM01 o = this[i];
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
	/// This is an ActiveRecord class which wraps the XSM01 table.
	/// </summary>
	[Serializable]
	public partial class XSM01 : ActiveRecord<XSM01>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public XSM01()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public XSM01(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public XSM01(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public XSM01(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("XSM01", TableType.Table, DataService.GetInstance("ErpNowthwin"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"FYERP";
				//columns
				
				TableSchema.TableColumn colvarXskhzb = new TableSchema.TableColumn(schema);
				colvarXskhzb.ColumnName = "XSKHZB";
				colvarXskhzb.DataType = DbType.String;
				colvarXskhzb.MaxLength = 4;
				colvarXskhzb.AutoIncrement = false;
				colvarXskhzb.IsNullable = false;
				colvarXskhzb.IsPrimaryKey = true;
				colvarXskhzb.IsForeignKey = false;
				colvarXskhzb.IsReadOnly = false;
				colvarXskhzb.DefaultSetting = @"";
				colvarXskhzb.ForeignKeyTableName = "";
				schema.Columns.Add(colvarXskhzb);
				
				TableSchema.TableColumn colvarXszbmc = new TableSchema.TableColumn(schema);
				colvarXszbmc.ColumnName = "XSZBMC";
				colvarXszbmc.DataType = DbType.String;
				colvarXszbmc.MaxLength = 40;
				colvarXszbmc.AutoIncrement = false;
				colvarXszbmc.IsNullable = true;
				colvarXszbmc.IsPrimaryKey = false;
				colvarXszbmc.IsForeignKey = false;
				colvarXszbmc.IsReadOnly = false;
				colvarXszbmc.DefaultSetting = @"";
				colvarXszbmc.ForeignKeyTableName = "";
				schema.Columns.Add(colvarXszbmc);
				
				TableSchema.TableColumn colvarXszblx = new TableSchema.TableColumn(schema);
				colvarXszblx.ColumnName = "XSZBLX";
				colvarXszblx.DataType = DbType.String;
				colvarXszblx.MaxLength = 4;
				colvarXszblx.AutoIncrement = false;
				colvarXszblx.IsNullable = true;
				colvarXszblx.IsPrimaryKey = false;
				colvarXszblx.IsForeignKey = false;
				colvarXszblx.IsReadOnly = false;
				colvarXszblx.DefaultSetting = @"";
				colvarXszblx.ForeignKeyTableName = "";
				schema.Columns.Add(colvarXszblx);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["ErpNowthwin"].AddSchema("XSM01",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("Xskhzb")]
		[Bindable(true)]
		public string Xskhzb 
		{
			get { return GetColumnValue<string>(Columns.Xskhzb); }
			set { SetColumnValue(Columns.Xskhzb, value); }
		}
		  
		[XmlAttribute("Xszbmc")]
		[Bindable(true)]
		public string Xszbmc 
		{
			get { return GetColumnValue<string>(Columns.Xszbmc); }
			set { SetColumnValue(Columns.Xszbmc, value); }
		}
		  
		[XmlAttribute("Xszblx")]
		[Bindable(true)]
		public string Xszblx 
		{
			get { return GetColumnValue<string>(Columns.Xszblx); }
			set { SetColumnValue(Columns.Xszblx, value); }
		}
		
		#endregion
		
		
			
		
		//no foreign key tables defined (0)
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(string varXskhzb,string varXszbmc,string varXszblx)
		{
			XSM01 item = new XSM01();
			
			item.Xskhzb = varXskhzb;
			
			item.Xszbmc = varXszbmc;
			
			item.Xszblx = varXszblx;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(string varXskhzb,string varXszbmc,string varXszblx)
		{
			XSM01 item = new XSM01();
			
				item.Xskhzb = varXskhzb;
			
				item.Xszbmc = varXszbmc;
			
				item.Xszblx = varXszblx;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn XskhzbColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn XszbmcColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        public static TableSchema.TableColumn XszblxColumn
        {
            get { return Schema.Columns[2]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string Xskhzb = @"XSKHZB";
			 public static string Xszbmc = @"XSZBMC";
			 public static string Xszblx = @"XSZBLX";
						
		}
		#endregion
		
		#region Update PK Collections
		
        #endregion
    
        #region Deep Save
		
        #endregion
	}
}
