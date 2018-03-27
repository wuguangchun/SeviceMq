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
	/// Strongly-typed collection for the XST41 class.
	/// </summary>
    [Serializable]
	public partial class XST41Collection : ActiveList<XST41, XST41Collection>
	{	   
		public XST41Collection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>XST41Collection</returns>
		public XST41Collection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                XST41 o = this[i];
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
	/// This is an ActiveRecord class which wraps the XST41 table.
	/// </summary>
	[Serializable]
	public partial class XST41 : ActiveRecord<XST41>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public XST41()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public XST41(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public XST41(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public XST41(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("XST41", TableType.Table, DataService.GetInstance("ErpNowthwin"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"FYERP";
				//columns
				
				TableSchema.TableColumn colvarXtwldm = new TableSchema.TableColumn(schema);
				colvarXtwldm.ColumnName = "XTWLDM";
				colvarXtwldm.DataType = DbType.String;
				colvarXtwldm.MaxLength = 8;
				colvarXtwldm.AutoIncrement = false;
				colvarXtwldm.IsNullable = false;
				colvarXtwldm.IsPrimaryKey = true;
				colvarXtwldm.IsForeignKey = false;
				colvarXtwldm.IsReadOnly = false;
				colvarXtwldm.DefaultSetting = @"";
				colvarXtwldm.ForeignKeyTableName = "";
				schema.Columns.Add(colvarXtwldm);
				
				TableSchema.TableColumn colvarXskjnd = new TableSchema.TableColumn(schema);
				colvarXskjnd.ColumnName = "XSKJND";
				colvarXskjnd.DataType = DbType.Decimal;
				colvarXskjnd.MaxLength = 0;
				colvarXskjnd.AutoIncrement = false;
				colvarXskjnd.IsNullable = false;
				colvarXskjnd.IsPrimaryKey = true;
				colvarXskjnd.IsForeignKey = false;
				colvarXskjnd.IsReadOnly = false;
				colvarXskjnd.DefaultSetting = @"";
				colvarXskjnd.ForeignKeyTableName = "";
				schema.Columns.Add(colvarXskjnd);
				
				TableSchema.TableColumn colvarXskjyf = new TableSchema.TableColumn(schema);
				colvarXskjyf.ColumnName = "XSKJYF";
				colvarXskjyf.DataType = DbType.Decimal;
				colvarXskjyf.MaxLength = 0;
				colvarXskjyf.AutoIncrement = false;
				colvarXskjyf.IsNullable = false;
				colvarXskjyf.IsPrimaryKey = true;
				colvarXskjyf.IsForeignKey = false;
				colvarXskjyf.IsReadOnly = false;
				colvarXskjyf.DefaultSetting = @"";
				colvarXskjyf.ForeignKeyTableName = "";
				schema.Columns.Add(colvarXskjyf);
				
				TableSchema.TableColumn colvarXsrwje = new TableSchema.TableColumn(schema);
				colvarXsrwje.ColumnName = "XSRWJE";
				colvarXsrwje.DataType = DbType.Decimal;
				colvarXsrwje.MaxLength = 0;
				colvarXsrwje.AutoIncrement = false;
				colvarXsrwje.IsNullable = true;
				colvarXsrwje.IsPrimaryKey = false;
				colvarXsrwje.IsForeignKey = false;
				colvarXsrwje.IsReadOnly = false;
				colvarXsrwje.DefaultSetting = @"";
				colvarXsrwje.ForeignKeyTableName = "";
				schema.Columns.Add(colvarXsrwje);
				
				TableSchema.TableColumn colvarXsshbz = new TableSchema.TableColumn(schema);
				colvarXsshbz.ColumnName = "XSSHBZ";
				colvarXsshbz.DataType = DbType.String;
				colvarXsshbz.MaxLength = 2;
				colvarXsshbz.AutoIncrement = false;
				colvarXsshbz.IsNullable = true;
				colvarXsshbz.IsPrimaryKey = false;
				colvarXsshbz.IsForeignKey = false;
				colvarXsshbz.IsReadOnly = false;
				colvarXsshbz.DefaultSetting = @"";
				colvarXsshbz.ForeignKeyTableName = "";
				schema.Columns.Add(colvarXsshbz);
				
				TableSchema.TableColumn colvarXshkje = new TableSchema.TableColumn(schema);
				colvarXshkje.ColumnName = "XSHKJE";
				colvarXshkje.DataType = DbType.Decimal;
				colvarXshkje.MaxLength = 0;
				colvarXshkje.AutoIncrement = false;
				colvarXshkje.IsNullable = true;
				colvarXshkje.IsPrimaryKey = false;
				colvarXshkje.IsForeignKey = false;
				colvarXshkje.IsReadOnly = false;
				colvarXshkje.DefaultSetting = @"";
				colvarXshkje.ForeignKeyTableName = "";
				schema.Columns.Add(colvarXshkje);
				
				TableSchema.TableColumn colvarXtjqhm = new TableSchema.TableColumn(schema);
				colvarXtjqhm.ColumnName = "XTJQHM";
				colvarXtjqhm.DataType = DbType.String;
				colvarXtjqhm.MaxLength = 6;
				colvarXtjqhm.AutoIncrement = false;
				colvarXtjqhm.IsNullable = true;
				colvarXtjqhm.IsPrimaryKey = false;
				colvarXtjqhm.IsForeignKey = false;
				colvarXtjqhm.IsReadOnly = false;
				colvarXtjqhm.DefaultSetting = @"";
				colvarXtjqhm.ForeignKeyTableName = "";
				schema.Columns.Add(colvarXtjqhm);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["ErpNowthwin"].AddSchema("XST41",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("Xtwldm")]
		[Bindable(true)]
		public string Xtwldm 
		{
			get { return GetColumnValue<string>(Columns.Xtwldm); }
			set { SetColumnValue(Columns.Xtwldm, value); }
		}
		  
		[XmlAttribute("Xskjnd")]
		[Bindable(true)]
		public decimal Xskjnd 
		{
			get { return GetColumnValue<decimal>(Columns.Xskjnd); }
			set { SetColumnValue(Columns.Xskjnd, value); }
		}
		  
		[XmlAttribute("Xskjyf")]
		[Bindable(true)]
		public decimal Xskjyf 
		{
			get { return GetColumnValue<decimal>(Columns.Xskjyf); }
			set { SetColumnValue(Columns.Xskjyf, value); }
		}
		  
		[XmlAttribute("Xsrwje")]
		[Bindable(true)]
		public decimal? Xsrwje 
		{
			get { return GetColumnValue<decimal?>(Columns.Xsrwje); }
			set { SetColumnValue(Columns.Xsrwje, value); }
		}
		  
		[XmlAttribute("Xsshbz")]
		[Bindable(true)]
		public string Xsshbz 
		{
			get { return GetColumnValue<string>(Columns.Xsshbz); }
			set { SetColumnValue(Columns.Xsshbz, value); }
		}
		  
		[XmlAttribute("Xshkje")]
		[Bindable(true)]
		public decimal? Xshkje 
		{
			get { return GetColumnValue<decimal?>(Columns.Xshkje); }
			set { SetColumnValue(Columns.Xshkje, value); }
		}
		  
		[XmlAttribute("Xtjqhm")]
		[Bindable(true)]
		public string Xtjqhm 
		{
			get { return GetColumnValue<string>(Columns.Xtjqhm); }
			set { SetColumnValue(Columns.Xtjqhm, value); }
		}
		
		#endregion
		
		
			
		
		//no foreign key tables defined (0)
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(string varXtwldm,decimal varXskjnd,decimal varXskjyf,decimal? varXsrwje,string varXsshbz,decimal? varXshkje,string varXtjqhm)
		{
			XST41 item = new XST41();
			
			item.Xtwldm = varXtwldm;
			
			item.Xskjnd = varXskjnd;
			
			item.Xskjyf = varXskjyf;
			
			item.Xsrwje = varXsrwje;
			
			item.Xsshbz = varXsshbz;
			
			item.Xshkje = varXshkje;
			
			item.Xtjqhm = varXtjqhm;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(string varXtwldm,decimal varXskjnd,decimal varXskjyf,decimal? varXsrwje,string varXsshbz,decimal? varXshkje,string varXtjqhm)
		{
			XST41 item = new XST41();
			
				item.Xtwldm = varXtwldm;
			
				item.Xskjnd = varXskjnd;
			
				item.Xskjyf = varXskjyf;
			
				item.Xsrwje = varXsrwje;
			
				item.Xsshbz = varXsshbz;
			
				item.Xshkje = varXshkje;
			
				item.Xtjqhm = varXtjqhm;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn XtwldmColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn XskjndColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        public static TableSchema.TableColumn XskjyfColumn
        {
            get { return Schema.Columns[2]; }
        }
        
        
        
        public static TableSchema.TableColumn XsrwjeColumn
        {
            get { return Schema.Columns[3]; }
        }
        
        
        
        public static TableSchema.TableColumn XsshbzColumn
        {
            get { return Schema.Columns[4]; }
        }
        
        
        
        public static TableSchema.TableColumn XshkjeColumn
        {
            get { return Schema.Columns[5]; }
        }
        
        
        
        public static TableSchema.TableColumn XtjqhmColumn
        {
            get { return Schema.Columns[6]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string Xtwldm = @"XTWLDM";
			 public static string Xskjnd = @"XSKJND";
			 public static string Xskjyf = @"XSKJYF";
			 public static string Xsrwje = @"XSRWJE";
			 public static string Xsshbz = @"XSSHBZ";
			 public static string Xshkje = @"XSHKJE";
			 public static string Xtjqhm = @"XTJQHM";
						
		}
		#endregion
		
		#region Update PK Collections
		
        #endregion
    
        #region Deep Save
		
        #endregion
	}
}
