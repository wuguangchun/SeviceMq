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
	/// Strongly-typed collection for the XST36 class.
	/// </summary>
    [Serializable]
	public partial class XST36Collection : ActiveList<XST36, XST36Collection>
	{	   
		public XST36Collection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>XST36Collection</returns>
		public XST36Collection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                XST36 o = this[i];
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
	/// This is an ActiveRecord class which wraps the XST36 table.
	/// </summary>
	[Serializable]
	public partial class XST36 : ActiveRecord<XST36>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public XST36()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public XST36(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public XST36(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public XST36(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("XST36", TableType.Table, DataService.GetInstance("ErpNowthwin"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"FYERP";
				//columns
				
				TableSchema.TableColumn colvarKcczxh = new TableSchema.TableColumn(schema);
				colvarKcczxh.ColumnName = "KCCZXH";
				colvarKcczxh.DataType = DbType.Decimal;
				colvarKcczxh.MaxLength = 0;
				colvarKcczxh.AutoIncrement = false;
				colvarKcczxh.IsNullable = false;
				colvarKcczxh.IsPrimaryKey = true;
				colvarKcczxh.IsForeignKey = false;
				colvarKcczxh.IsReadOnly = false;
				colvarKcczxh.DefaultSetting = @"";
				colvarKcczxh.ForeignKeyTableName = "";
				schema.Columns.Add(colvarKcczxh);
				
				TableSchema.TableColumn colvarKckjyf = new TableSchema.TableColumn(schema);
				colvarKckjyf.ColumnName = "KCKJYF";
				colvarKckjyf.DataType = DbType.Decimal;
				colvarKckjyf.MaxLength = 0;
				colvarKckjyf.AutoIncrement = false;
				colvarKckjyf.IsNullable = false;
				colvarKckjyf.IsPrimaryKey = true;
				colvarKckjyf.IsForeignKey = false;
				colvarKckjyf.IsReadOnly = false;
				colvarKckjyf.DefaultSetting = @"";
				colvarKckjyf.ForeignKeyTableName = "";
				schema.Columns.Add(colvarKckjyf);
				
				TableSchema.TableColumn colvarKckjnd = new TableSchema.TableColumn(schema);
				colvarKckjnd.ColumnName = "KCKJND";
				colvarKckjnd.DataType = DbType.Decimal;
				colvarKckjnd.MaxLength = 0;
				colvarKckjnd.AutoIncrement = false;
				colvarKckjnd.IsNullable = false;
				colvarKckjnd.IsPrimaryKey = true;
				colvarKckjnd.IsForeignKey = false;
				colvarKckjnd.IsReadOnly = false;
				colvarKckjnd.DefaultSetting = @"";
				colvarKckjnd.ForeignKeyTableName = "";
				schema.Columns.Add(colvarKckjnd);
				
				TableSchema.TableColumn colvarKcczhh = new TableSchema.TableColumn(schema);
				colvarKcczhh.ColumnName = "KCCZHH";
				colvarKcczhh.DataType = DbType.Decimal;
				colvarKcczhh.MaxLength = 0;
				colvarKcczhh.AutoIncrement = false;
				colvarKcczhh.IsNullable = false;
				colvarKcczhh.IsPrimaryKey = true;
				colvarKcczhh.IsForeignKey = false;
				colvarKcczhh.IsReadOnly = false;
				colvarKcczhh.DefaultSetting = @"";
				colvarKcczhh.ForeignKeyTableName = "";
				schema.Columns.Add(colvarKcczhh);
				
				TableSchema.TableColumn colvarKcckdh = new TableSchema.TableColumn(schema);
				colvarKcckdh.ColumnName = "KCCKDH";
				colvarKcckdh.DataType = DbType.String;
				colvarKcckdh.MaxLength = 12;
				colvarKcckdh.AutoIncrement = false;
				colvarKcckdh.IsNullable = true;
				colvarKcckdh.IsPrimaryKey = false;
				colvarKcckdh.IsForeignKey = false;
				colvarKcckdh.IsReadOnly = false;
				colvarKcckdh.DefaultSetting = @"";
				colvarKcckdh.ForeignKeyTableName = "";
				schema.Columns.Add(colvarKcckdh);
				
				TableSchema.TableColumn colvarKcckdm = new TableSchema.TableColumn(schema);
				colvarKcckdm.ColumnName = "KCCKDM";
				colvarKcckdm.DataType = DbType.String;
				colvarKcckdm.MaxLength = 8;
				colvarKcckdm.AutoIncrement = false;
				colvarKcckdm.IsNullable = true;
				colvarKcckdm.IsPrimaryKey = false;
				colvarKcckdm.IsForeignKey = false;
				colvarKcckdm.IsReadOnly = false;
				colvarKcckdm.DefaultSetting = @"";
				colvarKcckdm.ForeignKeyTableName = "";
				schema.Columns.Add(colvarKcckdm);
				
				TableSchema.TableColumn colvarXtbmdm = new TableSchema.TableColumn(schema);
				colvarXtbmdm.ColumnName = "XTBMDM";
				colvarXtbmdm.DataType = DbType.String;
				colvarXtbmdm.MaxLength = 8;
				colvarXtbmdm.AutoIncrement = false;
				colvarXtbmdm.IsNullable = true;
				colvarXtbmdm.IsPrimaryKey = false;
				colvarXtbmdm.IsForeignKey = false;
				colvarXtbmdm.IsReadOnly = false;
				colvarXtbmdm.DefaultSetting = @"";
				colvarXtbmdm.ForeignKeyTableName = "";
				schema.Columns.Add(colvarXtbmdm);
				
				TableSchema.TableColumn colvarXtwpdm = new TableSchema.TableColumn(schema);
				colvarXtwpdm.ColumnName = "XTWPDM";
				colvarXtwpdm.DataType = DbType.String;
				colvarXtwpdm.MaxLength = 20;
				colvarXtwpdm.AutoIncrement = false;
				colvarXtwpdm.IsNullable = true;
				colvarXtwpdm.IsPrimaryKey = false;
				colvarXtwpdm.IsForeignKey = false;
				colvarXtwpdm.IsReadOnly = false;
				colvarXtwpdm.DefaultSetting = @"";
				colvarXtwpdm.ForeignKeyTableName = "";
				schema.Columns.Add(colvarXtwpdm);
				
				TableSchema.TableColumn colvarXsphsl = new TableSchema.TableColumn(schema);
				colvarXsphsl.ColumnName = "XSPHSL";
				colvarXsphsl.DataType = DbType.Decimal;
				colvarXsphsl.MaxLength = 0;
				colvarXsphsl.AutoIncrement = false;
				colvarXsphsl.IsNullable = true;
				colvarXsphsl.IsPrimaryKey = false;
				colvarXsphsl.IsForeignKey = false;
				colvarXsphsl.IsReadOnly = false;
				colvarXsphsl.DefaultSetting = @"";
				colvarXsphsl.ForeignKeyTableName = "";
				schema.Columns.Add(colvarXsphsl);
				
				TableSchema.TableColumn colvarXtjldw = new TableSchema.TableColumn(schema);
				colvarXtjldw.ColumnName = "XTJLDW";
				colvarXtjldw.DataType = DbType.String;
				colvarXtjldw.MaxLength = 6;
				colvarXtjldw.AutoIncrement = false;
				colvarXtjldw.IsNullable = true;
				colvarXtjldw.IsPrimaryKey = false;
				colvarXtjldw.IsForeignKey = false;
				colvarXtjldw.IsReadOnly = false;
				colvarXtjldw.DefaultSetting = @"";
				colvarXtjldw.ForeignKeyTableName = "";
				schema.Columns.Add(colvarXtjldw);
				
				TableSchema.TableColumn colvarXsfhrq = new TableSchema.TableColumn(schema);
				colvarXsfhrq.ColumnName = "XSFHRQ";
				colvarXsfhrq.DataType = DbType.DateTime;
				colvarXsfhrq.MaxLength = 0;
				colvarXsfhrq.AutoIncrement = false;
				colvarXsfhrq.IsNullable = true;
				colvarXsfhrq.IsPrimaryKey = false;
				colvarXsfhrq.IsForeignKey = false;
				colvarXsfhrq.IsReadOnly = false;
				colvarXsfhrq.DefaultSetting = @"";
				colvarXsfhrq.ForeignKeyTableName = "";
				schema.Columns.Add(colvarXsfhrq);
				
				TableSchema.TableColumn colvarKcshck = new TableSchema.TableColumn(schema);
				colvarKcshck.ColumnName = "KCSHCK";
				colvarKcshck.DataType = DbType.String;
				colvarKcshck.MaxLength = 8;
				colvarKcshck.AutoIncrement = false;
				colvarKcshck.IsNullable = true;
				colvarKcshck.IsPrimaryKey = false;
				colvarKcshck.IsForeignKey = false;
				colvarKcshck.IsReadOnly = false;
				colvarKcshck.DefaultSetting = @"";
				colvarKcshck.ForeignKeyTableName = "";
				schema.Columns.Add(colvarKcshck);
				
				TableSchema.TableColumn colvarXsphhh = new TableSchema.TableColumn(schema);
				colvarXsphhh.ColumnName = "XSPHHH";
				colvarXsphhh.DataType = DbType.Decimal;
				colvarXsphhh.MaxLength = 0;
				colvarXsphhh.AutoIncrement = false;
				colvarXsphhh.IsNullable = true;
				colvarXsphhh.IsPrimaryKey = false;
				colvarXsphhh.IsForeignKey = false;
				colvarXsphhh.IsReadOnly = false;
				colvarXsphhh.DefaultSetting = @"";
				colvarXsphhh.ForeignKeyTableName = "";
				schema.Columns.Add(colvarXsphhh);
				
				TableSchema.TableColumn colvarXsfhdj = new TableSchema.TableColumn(schema);
				colvarXsfhdj.ColumnName = "XSFHDJ";
				colvarXsfhdj.DataType = DbType.Decimal;
				colvarXsfhdj.MaxLength = 0;
				colvarXsfhdj.AutoIncrement = false;
				colvarXsfhdj.IsNullable = true;
				colvarXsfhdj.IsPrimaryKey = false;
				colvarXsfhdj.IsForeignKey = false;
				colvarXsfhdj.IsReadOnly = false;
				colvarXsfhdj.DefaultSetting = @"";
				colvarXsfhdj.ForeignKeyTableName = "";
				schema.Columns.Add(colvarXsfhdj);
				
				TableSchema.TableColumn colvarXsfhje = new TableSchema.TableColumn(schema);
				colvarXsfhje.ColumnName = "XSFHJE";
				colvarXsfhje.DataType = DbType.Decimal;
				colvarXsfhje.MaxLength = 0;
				colvarXsfhje.AutoIncrement = false;
				colvarXsfhje.IsNullable = true;
				colvarXsfhje.IsPrimaryKey = false;
				colvarXsfhje.IsForeignKey = false;
				colvarXsfhje.IsReadOnly = false;
				colvarXsfhje.DefaultSetting = @"";
				colvarXsfhje.ForeignKeyTableName = "";
				schema.Columns.Add(colvarXsfhje);
				
				TableSchema.TableColumn colvarXsyhdh = new TableSchema.TableColumn(schema);
				colvarXsyhdh.ColumnName = "XSYHDH";
				colvarXsyhdh.DataType = DbType.String;
				colvarXsyhdh.MaxLength = 12;
				colvarXsyhdh.AutoIncrement = false;
				colvarXsyhdh.IsNullable = true;
				colvarXsyhdh.IsPrimaryKey = false;
				colvarXsyhdh.IsForeignKey = false;
				colvarXsyhdh.IsReadOnly = false;
				colvarXsyhdh.DefaultSetting = @"";
				colvarXsyhdh.ForeignKeyTableName = "";
				schema.Columns.Add(colvarXsyhdh);
				
				TableSchema.TableColumn colvarXsfhzk = new TableSchema.TableColumn(schema);
				colvarXsfhzk.ColumnName = "XSFHZK";
				colvarXsfhzk.DataType = DbType.Decimal;
				colvarXsfhzk.MaxLength = 0;
				colvarXsfhzk.AutoIncrement = false;
				colvarXsfhzk.IsNullable = true;
				colvarXsfhzk.IsPrimaryKey = false;
				colvarXsfhzk.IsForeignKey = false;
				colvarXsfhzk.IsReadOnly = false;
				colvarXsfhzk.DefaultSetting = @"";
				colvarXsfhzk.ForeignKeyTableName = "";
				schema.Columns.Add(colvarXsfhzk);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["ErpNowthwin"].AddSchema("XST36",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("Kcczxh")]
		[Bindable(true)]
		public decimal Kcczxh 
		{
			get { return GetColumnValue<decimal>(Columns.Kcczxh); }
			set { SetColumnValue(Columns.Kcczxh, value); }
		}
		  
		[XmlAttribute("Kckjyf")]
		[Bindable(true)]
		public decimal Kckjyf 
		{
			get { return GetColumnValue<decimal>(Columns.Kckjyf); }
			set { SetColumnValue(Columns.Kckjyf, value); }
		}
		  
		[XmlAttribute("Kckjnd")]
		[Bindable(true)]
		public decimal Kckjnd 
		{
			get { return GetColumnValue<decimal>(Columns.Kckjnd); }
			set { SetColumnValue(Columns.Kckjnd, value); }
		}
		  
		[XmlAttribute("Kcczhh")]
		[Bindable(true)]
		public decimal Kcczhh 
		{
			get { return GetColumnValue<decimal>(Columns.Kcczhh); }
			set { SetColumnValue(Columns.Kcczhh, value); }
		}
		  
		[XmlAttribute("Kcckdh")]
		[Bindable(true)]
		public string Kcckdh 
		{
			get { return GetColumnValue<string>(Columns.Kcckdh); }
			set { SetColumnValue(Columns.Kcckdh, value); }
		}
		  
		[XmlAttribute("Kcckdm")]
		[Bindable(true)]
		public string Kcckdm 
		{
			get { return GetColumnValue<string>(Columns.Kcckdm); }
			set { SetColumnValue(Columns.Kcckdm, value); }
		}
		  
		[XmlAttribute("Xtbmdm")]
		[Bindable(true)]
		public string Xtbmdm 
		{
			get { return GetColumnValue<string>(Columns.Xtbmdm); }
			set { SetColumnValue(Columns.Xtbmdm, value); }
		}
		  
		[XmlAttribute("Xtwpdm")]
		[Bindable(true)]
		public string Xtwpdm 
		{
			get { return GetColumnValue<string>(Columns.Xtwpdm); }
			set { SetColumnValue(Columns.Xtwpdm, value); }
		}
		  
		[XmlAttribute("Xsphsl")]
		[Bindable(true)]
		public decimal? Xsphsl 
		{
			get { return GetColumnValue<decimal?>(Columns.Xsphsl); }
			set { SetColumnValue(Columns.Xsphsl, value); }
		}
		  
		[XmlAttribute("Xtjldw")]
		[Bindable(true)]
		public string Xtjldw 
		{
			get { return GetColumnValue<string>(Columns.Xtjldw); }
			set { SetColumnValue(Columns.Xtjldw, value); }
		}
		  
		[XmlAttribute("Xsfhrq")]
		[Bindable(true)]
		public DateTime? Xsfhrq 
		{
			get { return GetColumnValue<DateTime?>(Columns.Xsfhrq); }
			set { SetColumnValue(Columns.Xsfhrq, value); }
		}
		  
		[XmlAttribute("Kcshck")]
		[Bindable(true)]
		public string Kcshck 
		{
			get { return GetColumnValue<string>(Columns.Kcshck); }
			set { SetColumnValue(Columns.Kcshck, value); }
		}
		  
		[XmlAttribute("Xsphhh")]
		[Bindable(true)]
		public decimal? Xsphhh 
		{
			get { return GetColumnValue<decimal?>(Columns.Xsphhh); }
			set { SetColumnValue(Columns.Xsphhh, value); }
		}
		  
		[XmlAttribute("Xsfhdj")]
		[Bindable(true)]
		public decimal? Xsfhdj 
		{
			get { return GetColumnValue<decimal?>(Columns.Xsfhdj); }
			set { SetColumnValue(Columns.Xsfhdj, value); }
		}
		  
		[XmlAttribute("Xsfhje")]
		[Bindable(true)]
		public decimal? Xsfhje 
		{
			get { return GetColumnValue<decimal?>(Columns.Xsfhje); }
			set { SetColumnValue(Columns.Xsfhje, value); }
		}
		  
		[XmlAttribute("Xsyhdh")]
		[Bindable(true)]
		public string Xsyhdh 
		{
			get { return GetColumnValue<string>(Columns.Xsyhdh); }
			set { SetColumnValue(Columns.Xsyhdh, value); }
		}
		  
		[XmlAttribute("Xsfhzk")]
		[Bindable(true)]
		public decimal? Xsfhzk 
		{
			get { return GetColumnValue<decimal?>(Columns.Xsfhzk); }
			set { SetColumnValue(Columns.Xsfhzk, value); }
		}
		
		#endregion
		
		
			
		
		//no foreign key tables defined (0)
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(decimal varKcczxh,decimal varKckjyf,decimal varKckjnd,decimal varKcczhh,string varKcckdh,string varKcckdm,string varXtbmdm,string varXtwpdm,decimal? varXsphsl,string varXtjldw,DateTime? varXsfhrq,string varKcshck,decimal? varXsphhh,decimal? varXsfhdj,decimal? varXsfhje,string varXsyhdh,decimal? varXsfhzk)
		{
			XST36 item = new XST36();
			
			item.Kcczxh = varKcczxh;
			
			item.Kckjyf = varKckjyf;
			
			item.Kckjnd = varKckjnd;
			
			item.Kcczhh = varKcczhh;
			
			item.Kcckdh = varKcckdh;
			
			item.Kcckdm = varKcckdm;
			
			item.Xtbmdm = varXtbmdm;
			
			item.Xtwpdm = varXtwpdm;
			
			item.Xsphsl = varXsphsl;
			
			item.Xtjldw = varXtjldw;
			
			item.Xsfhrq = varXsfhrq;
			
			item.Kcshck = varKcshck;
			
			item.Xsphhh = varXsphhh;
			
			item.Xsfhdj = varXsfhdj;
			
			item.Xsfhje = varXsfhje;
			
			item.Xsyhdh = varXsyhdh;
			
			item.Xsfhzk = varXsfhzk;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(decimal varKcczxh,decimal varKckjyf,decimal varKckjnd,decimal varKcczhh,string varKcckdh,string varKcckdm,string varXtbmdm,string varXtwpdm,decimal? varXsphsl,string varXtjldw,DateTime? varXsfhrq,string varKcshck,decimal? varXsphhh,decimal? varXsfhdj,decimal? varXsfhje,string varXsyhdh,decimal? varXsfhzk)
		{
			XST36 item = new XST36();
			
				item.Kcczxh = varKcczxh;
			
				item.Kckjyf = varKckjyf;
			
				item.Kckjnd = varKckjnd;
			
				item.Kcczhh = varKcczhh;
			
				item.Kcckdh = varKcckdh;
			
				item.Kcckdm = varKcckdm;
			
				item.Xtbmdm = varXtbmdm;
			
				item.Xtwpdm = varXtwpdm;
			
				item.Xsphsl = varXsphsl;
			
				item.Xtjldw = varXtjldw;
			
				item.Xsfhrq = varXsfhrq;
			
				item.Kcshck = varKcshck;
			
				item.Xsphhh = varXsphhh;
			
				item.Xsfhdj = varXsfhdj;
			
				item.Xsfhje = varXsfhje;
			
				item.Xsyhdh = varXsyhdh;
			
				item.Xsfhzk = varXsfhzk;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn KcczxhColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn KckjyfColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        public static TableSchema.TableColumn KckjndColumn
        {
            get { return Schema.Columns[2]; }
        }
        
        
        
        public static TableSchema.TableColumn KcczhhColumn
        {
            get { return Schema.Columns[3]; }
        }
        
        
        
        public static TableSchema.TableColumn KcckdhColumn
        {
            get { return Schema.Columns[4]; }
        }
        
        
        
        public static TableSchema.TableColumn KcckdmColumn
        {
            get { return Schema.Columns[5]; }
        }
        
        
        
        public static TableSchema.TableColumn XtbmdmColumn
        {
            get { return Schema.Columns[6]; }
        }
        
        
        
        public static TableSchema.TableColumn XtwpdmColumn
        {
            get { return Schema.Columns[7]; }
        }
        
        
        
        public static TableSchema.TableColumn XsphslColumn
        {
            get { return Schema.Columns[8]; }
        }
        
        
        
        public static TableSchema.TableColumn XtjldwColumn
        {
            get { return Schema.Columns[9]; }
        }
        
        
        
        public static TableSchema.TableColumn XsfhrqColumn
        {
            get { return Schema.Columns[10]; }
        }
        
        
        
        public static TableSchema.TableColumn KcshckColumn
        {
            get { return Schema.Columns[11]; }
        }
        
        
        
        public static TableSchema.TableColumn XsphhhColumn
        {
            get { return Schema.Columns[12]; }
        }
        
        
        
        public static TableSchema.TableColumn XsfhdjColumn
        {
            get { return Schema.Columns[13]; }
        }
        
        
        
        public static TableSchema.TableColumn XsfhjeColumn
        {
            get { return Schema.Columns[14]; }
        }
        
        
        
        public static TableSchema.TableColumn XsyhdhColumn
        {
            get { return Schema.Columns[15]; }
        }
        
        
        
        public static TableSchema.TableColumn XsfhzkColumn
        {
            get { return Schema.Columns[16]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string Kcczxh = @"KCCZXH";
			 public static string Kckjyf = @"KCKJYF";
			 public static string Kckjnd = @"KCKJND";
			 public static string Kcczhh = @"KCCZHH";
			 public static string Kcckdh = @"KCCKDH";
			 public static string Kcckdm = @"KCCKDM";
			 public static string Xtbmdm = @"XTBMDM";
			 public static string Xtwpdm = @"XTWPDM";
			 public static string Xsphsl = @"XSPHSL";
			 public static string Xtjldw = @"XTJLDW";
			 public static string Xsfhrq = @"XSFHRQ";
			 public static string Kcshck = @"KCSHCK";
			 public static string Xsphhh = @"XSPHHH";
			 public static string Xsfhdj = @"XSFHDJ";
			 public static string Xsfhje = @"XSFHJE";
			 public static string Xsyhdh = @"XSYHDH";
			 public static string Xsfhzk = @"XSFHZK";
						
		}
		#endregion
		
		#region Update PK Collections
		
        #endregion
    
        #region Deep Save
		
        #endregion
	}
}
