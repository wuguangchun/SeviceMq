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
	/// Strongly-typed collection for the XST16 class.
	/// </summary>
    [Serializable]
	public partial class XST16Collection : ActiveList<XST16, XST16Collection>
	{	   
		public XST16Collection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>XST16Collection</returns>
		public XST16Collection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                XST16 o = this[i];
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
	/// This is an ActiveRecord class which wraps the XST16 table.
	/// </summary>
	[Serializable]
	public partial class XST16 : ActiveRecord<XST16>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public XST16()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public XST16(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public XST16(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public XST16(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("XST16", TableType.Table, DataService.GetInstance("ErpNowthwin"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"FYERP";
				//columns
				
				TableSchema.TableColumn colvarXsdpxh = new TableSchema.TableColumn(schema);
				colvarXsdpxh.ColumnName = "XSDPXH";
				colvarXsdpxh.DataType = DbType.Decimal;
				colvarXsdpxh.MaxLength = 0;
				colvarXsdpxh.AutoIncrement = false;
				colvarXsdpxh.IsNullable = false;
				colvarXsdpxh.IsPrimaryKey = true;
				colvarXsdpxh.IsForeignKey = false;
				colvarXsdpxh.IsReadOnly = false;
				colvarXsdpxh.DefaultSetting = @"";
				colvarXsdpxh.ForeignKeyTableName = "";
				schema.Columns.Add(colvarXsdpxh);
				
				TableSchema.TableColumn colvarXscphm = new TableSchema.TableColumn(schema);
				colvarXscphm.ColumnName = "XSCPHM";
				colvarXscphm.DataType = DbType.String;
				colvarXscphm.MaxLength = 10;
				colvarXscphm.AutoIncrement = false;
				colvarXscphm.IsNullable = false;
				colvarXscphm.IsPrimaryKey = true;
				colvarXscphm.IsForeignKey = false;
				colvarXscphm.IsReadOnly = false;
				colvarXscphm.DefaultSetting = @"";
				colvarXscphm.ForeignKeyTableName = "";
				schema.Columns.Add(colvarXscphm);
				
				TableSchema.TableColumn colvarXsdjlx = new TableSchema.TableColumn(schema);
				colvarXsdjlx.ColumnName = "XSDJLX";
				colvarXsdjlx.DataType = DbType.String;
				colvarXsdjlx.MaxLength = 1;
				colvarXsdjlx.AutoIncrement = false;
				colvarXsdjlx.IsNullable = false;
				colvarXsdjlx.IsPrimaryKey = true;
				colvarXsdjlx.IsForeignKey = false;
				colvarXsdjlx.IsReadOnly = false;
				colvarXsdjlx.DefaultSetting = @"";
				colvarXsdjlx.ForeignKeyTableName = "";
				schema.Columns.Add(colvarXsdjlx);
				
				TableSchema.TableColumn colvarXsphdh = new TableSchema.TableColumn(schema);
				colvarXsphdh.ColumnName = "XSPHDH";
				colvarXsphdh.DataType = DbType.String;
				colvarXsphdh.MaxLength = 12;
				colvarXsphdh.AutoIncrement = false;
				colvarXsphdh.IsNullable = false;
				colvarXsphdh.IsPrimaryKey = true;
				colvarXsphdh.IsForeignKey = false;
				colvarXsphdh.IsReadOnly = false;
				colvarXsphdh.DefaultSetting = @"";
				colvarXsphdh.ForeignKeyTableName = "";
				schema.Columns.Add(colvarXsphdh);
				
				TableSchema.TableColumn colvarXsjqbz = new TableSchema.TableColumn(schema);
				colvarXsjqbz.ColumnName = "XSJQBZ";
				colvarXsjqbz.DataType = DbType.String;
				colvarXsjqbz.MaxLength = 1;
				colvarXsjqbz.AutoIncrement = false;
				colvarXsjqbz.IsNullable = true;
				colvarXsjqbz.IsPrimaryKey = false;
				colvarXsjqbz.IsForeignKey = false;
				colvarXsjqbz.IsReadOnly = false;
				colvarXsjqbz.DefaultSetting = @"";
				colvarXsjqbz.ForeignKeyTableName = "";
				schema.Columns.Add(colvarXsjqbz);
				
				TableSchema.TableColumn colvarXsjsry = new TableSchema.TableColumn(schema);
				colvarXsjsry.ColumnName = "XSJSRY";
				colvarXsjsry.DataType = DbType.String;
				colvarXsjsry.MaxLength = 20;
				colvarXsjsry.AutoIncrement = false;
				colvarXsjsry.IsNullable = true;
				colvarXsjsry.IsPrimaryKey = false;
				colvarXsjsry.IsForeignKey = false;
				colvarXsjsry.IsReadOnly = false;
				colvarXsjsry.DefaultSetting = @"";
				colvarXsjsry.ForeignKeyTableName = "";
				schema.Columns.Add(colvarXsjsry);
				
				TableSchema.TableColumn colvarXsqrbz = new TableSchema.TableColumn(schema);
				colvarXsqrbz.ColumnName = "XSQRBZ";
				colvarXsqrbz.DataType = DbType.String;
				colvarXsqrbz.MaxLength = 1;
				colvarXsqrbz.AutoIncrement = false;
				colvarXsqrbz.IsNullable = false;
				colvarXsqrbz.IsPrimaryKey = false;
				colvarXsqrbz.IsForeignKey = false;
				colvarXsqrbz.IsReadOnly = false;
				colvarXsqrbz.DefaultSetting = @"";
				colvarXsqrbz.ForeignKeyTableName = "";
				schema.Columns.Add(colvarXsqrbz);
				
				TableSchema.TableColumn colvarXslxdm = new TableSchema.TableColumn(schema);
				colvarXslxdm.ColumnName = "XSLXDM";
				colvarXslxdm.DataType = DbType.String;
				colvarXslxdm.MaxLength = 8;
				colvarXslxdm.AutoIncrement = false;
				colvarXslxdm.IsNullable = true;
				colvarXslxdm.IsPrimaryKey = false;
				colvarXslxdm.IsForeignKey = false;
				colvarXslxdm.IsReadOnly = false;
				colvarXslxdm.DefaultSetting = @"";
				colvarXslxdm.ForeignKeyTableName = "";
				schema.Columns.Add(colvarXslxdm);
				
				TableSchema.TableColumn colvarXspcry = new TableSchema.TableColumn(schema);
				colvarXspcry.ColumnName = "XSPCRY";
				colvarXspcry.DataType = DbType.String;
				colvarXspcry.MaxLength = 8;
				colvarXspcry.AutoIncrement = false;
				colvarXspcry.IsNullable = true;
				colvarXspcry.IsPrimaryKey = false;
				colvarXspcry.IsForeignKey = false;
				colvarXspcry.IsReadOnly = false;
				colvarXspcry.DefaultSetting = @"";
				colvarXspcry.ForeignKeyTableName = "";
				schema.Columns.Add(colvarXspcry);
				
				TableSchema.TableColumn colvarXspcrq = new TableSchema.TableColumn(schema);
				colvarXspcrq.ColumnName = "XSPCRQ";
				colvarXspcrq.DataType = DbType.DateTime;
				colvarXspcrq.MaxLength = 0;
				colvarXspcrq.AutoIncrement = false;
				colvarXspcrq.IsNullable = true;
				colvarXspcrq.IsPrimaryKey = false;
				colvarXspcrq.IsForeignKey = false;
				colvarXspcrq.IsReadOnly = false;
				colvarXspcrq.DefaultSetting = @"";
				colvarXspcrq.ForeignKeyTableName = "";
				schema.Columns.Add(colvarXspcrq);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["ErpNowthwin"].AddSchema("XST16",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("Xsdpxh")]
		[Bindable(true)]
		public decimal Xsdpxh 
		{
			get { return GetColumnValue<decimal>(Columns.Xsdpxh); }
			set { SetColumnValue(Columns.Xsdpxh, value); }
		}
		  
		[XmlAttribute("Xscphm")]
		[Bindable(true)]
		public string Xscphm 
		{
			get { return GetColumnValue<string>(Columns.Xscphm); }
			set { SetColumnValue(Columns.Xscphm, value); }
		}
		  
		[XmlAttribute("Xsdjlx")]
		[Bindable(true)]
		public string Xsdjlx 
		{
			get { return GetColumnValue<string>(Columns.Xsdjlx); }
			set { SetColumnValue(Columns.Xsdjlx, value); }
		}
		  
		[XmlAttribute("Xsphdh")]
		[Bindable(true)]
		public string Xsphdh 
		{
			get { return GetColumnValue<string>(Columns.Xsphdh); }
			set { SetColumnValue(Columns.Xsphdh, value); }
		}
		  
		[XmlAttribute("Xsjqbz")]
		[Bindable(true)]
		public string Xsjqbz 
		{
			get { return GetColumnValue<string>(Columns.Xsjqbz); }
			set { SetColumnValue(Columns.Xsjqbz, value); }
		}
		  
		[XmlAttribute("Xsjsry")]
		[Bindable(true)]
		public string Xsjsry 
		{
			get { return GetColumnValue<string>(Columns.Xsjsry); }
			set { SetColumnValue(Columns.Xsjsry, value); }
		}
		  
		[XmlAttribute("Xsqrbz")]
		[Bindable(true)]
		public string Xsqrbz 
		{
			get { return GetColumnValue<string>(Columns.Xsqrbz); }
			set { SetColumnValue(Columns.Xsqrbz, value); }
		}
		  
		[XmlAttribute("Xslxdm")]
		[Bindable(true)]
		public string Xslxdm 
		{
			get { return GetColumnValue<string>(Columns.Xslxdm); }
			set { SetColumnValue(Columns.Xslxdm, value); }
		}
		  
		[XmlAttribute("Xspcry")]
		[Bindable(true)]
		public string Xspcry 
		{
			get { return GetColumnValue<string>(Columns.Xspcry); }
			set { SetColumnValue(Columns.Xspcry, value); }
		}
		  
		[XmlAttribute("Xspcrq")]
		[Bindable(true)]
		public DateTime? Xspcrq 
		{
			get { return GetColumnValue<DateTime?>(Columns.Xspcrq); }
			set { SetColumnValue(Columns.Xspcrq, value); }
		}
		
		#endregion
		
		
			
		
		//no foreign key tables defined (0)
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(decimal varXsdpxh,string varXscphm,string varXsdjlx,string varXsphdh,string varXsjqbz,string varXsjsry,string varXsqrbz,string varXslxdm,string varXspcry,DateTime? varXspcrq)
		{
			XST16 item = new XST16();
			
			item.Xsdpxh = varXsdpxh;
			
			item.Xscphm = varXscphm;
			
			item.Xsdjlx = varXsdjlx;
			
			item.Xsphdh = varXsphdh;
			
			item.Xsjqbz = varXsjqbz;
			
			item.Xsjsry = varXsjsry;
			
			item.Xsqrbz = varXsqrbz;
			
			item.Xslxdm = varXslxdm;
			
			item.Xspcry = varXspcry;
			
			item.Xspcrq = varXspcrq;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(decimal varXsdpxh,string varXscphm,string varXsdjlx,string varXsphdh,string varXsjqbz,string varXsjsry,string varXsqrbz,string varXslxdm,string varXspcry,DateTime? varXspcrq)
		{
			XST16 item = new XST16();
			
				item.Xsdpxh = varXsdpxh;
			
				item.Xscphm = varXscphm;
			
				item.Xsdjlx = varXsdjlx;
			
				item.Xsphdh = varXsphdh;
			
				item.Xsjqbz = varXsjqbz;
			
				item.Xsjsry = varXsjsry;
			
				item.Xsqrbz = varXsqrbz;
			
				item.Xslxdm = varXslxdm;
			
				item.Xspcry = varXspcry;
			
				item.Xspcrq = varXspcrq;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn XsdpxhColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn XscphmColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        public static TableSchema.TableColumn XsdjlxColumn
        {
            get { return Schema.Columns[2]; }
        }
        
        
        
        public static TableSchema.TableColumn XsphdhColumn
        {
            get { return Schema.Columns[3]; }
        }
        
        
        
        public static TableSchema.TableColumn XsjqbzColumn
        {
            get { return Schema.Columns[4]; }
        }
        
        
        
        public static TableSchema.TableColumn XsjsryColumn
        {
            get { return Schema.Columns[5]; }
        }
        
        
        
        public static TableSchema.TableColumn XsqrbzColumn
        {
            get { return Schema.Columns[6]; }
        }
        
        
        
        public static TableSchema.TableColumn XslxdmColumn
        {
            get { return Schema.Columns[7]; }
        }
        
        
        
        public static TableSchema.TableColumn XspcryColumn
        {
            get { return Schema.Columns[8]; }
        }
        
        
        
        public static TableSchema.TableColumn XspcrqColumn
        {
            get { return Schema.Columns[9]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string Xsdpxh = @"XSDPXH";
			 public static string Xscphm = @"XSCPHM";
			 public static string Xsdjlx = @"XSDJLX";
			 public static string Xsphdh = @"XSPHDH";
			 public static string Xsjqbz = @"XSJQBZ";
			 public static string Xsjsry = @"XSJSRY";
			 public static string Xsqrbz = @"XSQRBZ";
			 public static string Xslxdm = @"XSLXDM";
			 public static string Xspcry = @"XSPCRY";
			 public static string Xspcrq = @"XSPCRQ";
						
		}
		#endregion
		
		#region Update PK Collections
		
        #endregion
    
        #region Deep Save
		
        #endregion
	}
}
