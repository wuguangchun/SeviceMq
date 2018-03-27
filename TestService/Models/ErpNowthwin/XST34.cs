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
	/// Strongly-typed collection for the XST34 class.
	/// </summary>
    [Serializable]
	public partial class XST34Collection : ActiveList<XST34, XST34Collection>
	{	   
		public XST34Collection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>XST34Collection</returns>
		public XST34Collection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                XST34 o = this[i];
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
	/// This is an ActiveRecord class which wraps the XST34 table.
	/// </summary>
	[Serializable]
	public partial class XST34 : ActiveRecord<XST34>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public XST34()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public XST34(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public XST34(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public XST34(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("XST34", TableType.Table, DataService.GetInstance("ErpNowthwin"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"FYERP";
				//columns
				
				TableSchema.TableColumn colvarXsdhdh = new TableSchema.TableColumn(schema);
				colvarXsdhdh.ColumnName = "XSDHDH";
				colvarXsdhdh.DataType = DbType.String;
				colvarXsdhdh.MaxLength = 12;
				colvarXsdhdh.AutoIncrement = false;
				colvarXsdhdh.IsNullable = false;
				colvarXsdhdh.IsPrimaryKey = true;
				colvarXsdhdh.IsForeignKey = false;
				colvarXsdhdh.IsReadOnly = false;
				colvarXsdhdh.DefaultSetting = @"";
				colvarXsdhdh.ForeignKeyTableName = "";
				schema.Columns.Add(colvarXsdhdh);
				
				TableSchema.TableColumn colvarKcdcck = new TableSchema.TableColumn(schema);
				colvarKcdcck.ColumnName = "KCDCCK";
				colvarKcdcck.DataType = DbType.String;
				colvarKcdcck.MaxLength = 8;
				colvarKcdcck.AutoIncrement = false;
				colvarKcdcck.IsNullable = true;
				colvarKcdcck.IsPrimaryKey = false;
				colvarKcdcck.IsForeignKey = false;
				colvarKcdcck.IsReadOnly = false;
				colvarKcdcck.DefaultSetting = @"";
				colvarKcdcck.ForeignKeyTableName = "";
				schema.Columns.Add(colvarKcdcck);
				
				TableSchema.TableColumn colvarKcdrck = new TableSchema.TableColumn(schema);
				colvarKcdrck.ColumnName = "KCDRCK";
				colvarKcdrck.DataType = DbType.String;
				colvarKcdrck.MaxLength = 8;
				colvarKcdrck.AutoIncrement = false;
				colvarKcdrck.IsNullable = true;
				colvarKcdrck.IsPrimaryKey = false;
				colvarKcdrck.IsForeignKey = false;
				colvarKcdrck.IsReadOnly = false;
				colvarKcdrck.DefaultSetting = @"";
				colvarKcdrck.ForeignKeyTableName = "";
				schema.Columns.Add(colvarKcdrck);
				
				TableSchema.TableColumn colvarXsdhrq = new TableSchema.TableColumn(schema);
				colvarXsdhrq.ColumnName = "XSDHRQ";
				colvarXsdhrq.DataType = DbType.DateTime;
				colvarXsdhrq.MaxLength = 0;
				colvarXsdhrq.AutoIncrement = false;
				colvarXsdhrq.IsNullable = true;
				colvarXsdhrq.IsPrimaryKey = false;
				colvarXsdhrq.IsForeignKey = false;
				colvarXsdhrq.IsReadOnly = false;
				colvarXsdhrq.DefaultSetting = @"";
				colvarXsdhrq.ForeignKeyTableName = "";
				schema.Columns.Add(colvarXsdhrq);
				
				TableSchema.TableColumn colvarXsdhze = new TableSchema.TableColumn(schema);
				colvarXsdhze.ColumnName = "XSDHZE";
				colvarXsdhze.DataType = DbType.Decimal;
				colvarXsdhze.MaxLength = 0;
				colvarXsdhze.AutoIncrement = false;
				colvarXsdhze.IsNullable = true;
				colvarXsdhze.IsPrimaryKey = false;
				colvarXsdhze.IsForeignKey = false;
				colvarXsdhze.IsReadOnly = false;
				colvarXsdhze.DefaultSetting = @"";
				colvarXsdhze.ForeignKeyTableName = "";
				schema.Columns.Add(colvarXsdhze);
				
				TableSchema.TableColumn colvarXskjnd = new TableSchema.TableColumn(schema);
				colvarXskjnd.ColumnName = "XSKJND";
				colvarXskjnd.DataType = DbType.Decimal;
				colvarXskjnd.MaxLength = 0;
				colvarXskjnd.AutoIncrement = false;
				colvarXskjnd.IsNullable = true;
				colvarXskjnd.IsPrimaryKey = false;
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
				colvarXskjyf.IsNullable = true;
				colvarXskjyf.IsPrimaryKey = false;
				colvarXskjyf.IsForeignKey = false;
				colvarXskjyf.IsReadOnly = false;
				colvarXskjyf.DefaultSetting = @"";
				colvarXskjyf.ForeignKeyTableName = "";
				schema.Columns.Add(colvarXskjyf);
				
				TableSchema.TableColumn colvarXsdhzt = new TableSchema.TableColumn(schema);
				colvarXsdhzt.ColumnName = "XSDHZT";
				colvarXsdhzt.DataType = DbType.String;
				colvarXsdhzt.MaxLength = 1;
				colvarXsdhzt.AutoIncrement = false;
				colvarXsdhzt.IsNullable = true;
				colvarXsdhzt.IsPrimaryKey = false;
				colvarXsdhzt.IsForeignKey = false;
				colvarXsdhzt.IsReadOnly = false;
				colvarXsdhzt.DefaultSetting = @"";
				colvarXsdhzt.ForeignKeyTableName = "";
				schema.Columns.Add(colvarXsdhzt);
				
				TableSchema.TableColumn colvarXslrry = new TableSchema.TableColumn(schema);
				colvarXslrry.ColumnName = "XSLRRY";
				colvarXslrry.DataType = DbType.String;
				colvarXslrry.MaxLength = 8;
				colvarXslrry.AutoIncrement = false;
				colvarXslrry.IsNullable = true;
				colvarXslrry.IsPrimaryKey = false;
				colvarXslrry.IsForeignKey = false;
				colvarXslrry.IsReadOnly = false;
				colvarXslrry.DefaultSetting = @"";
				colvarXslrry.ForeignKeyTableName = "";
				schema.Columns.Add(colvarXslrry);
				
				TableSchema.TableColumn colvarXslrrq = new TableSchema.TableColumn(schema);
				colvarXslrrq.ColumnName = "XSLRRQ";
				colvarXslrrq.DataType = DbType.DateTime;
				colvarXslrrq.MaxLength = 0;
				colvarXslrrq.AutoIncrement = false;
				colvarXslrrq.IsNullable = true;
				colvarXslrrq.IsPrimaryKey = false;
				colvarXslrrq.IsForeignKey = false;
				colvarXslrrq.IsReadOnly = false;
				colvarXslrrq.DefaultSetting = @"";
				colvarXslrrq.ForeignKeyTableName = "";
				schema.Columns.Add(colvarXslrrq);
				
				TableSchema.TableColumn colvarXsshry = new TableSchema.TableColumn(schema);
				colvarXsshry.ColumnName = "XSSHRY";
				colvarXsshry.DataType = DbType.String;
				colvarXsshry.MaxLength = 8;
				colvarXsshry.AutoIncrement = false;
				colvarXsshry.IsNullable = true;
				colvarXsshry.IsPrimaryKey = false;
				colvarXsshry.IsForeignKey = false;
				colvarXsshry.IsReadOnly = false;
				colvarXsshry.DefaultSetting = @"";
				colvarXsshry.ForeignKeyTableName = "";
				schema.Columns.Add(colvarXsshry);
				
				TableSchema.TableColumn colvarXsshrq = new TableSchema.TableColumn(schema);
				colvarXsshrq.ColumnName = "XSSHRQ";
				colvarXsshrq.DataType = DbType.DateTime;
				colvarXsshrq.MaxLength = 0;
				colvarXsshrq.AutoIncrement = false;
				colvarXsshrq.IsNullable = true;
				colvarXsshrq.IsPrimaryKey = false;
				colvarXsshrq.IsForeignKey = false;
				colvarXsshrq.IsReadOnly = false;
				colvarXsshrq.DefaultSetting = @"";
				colvarXsshrq.ForeignKeyTableName = "";
				schema.Columns.Add(colvarXsshrq);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["ErpNowthwin"].AddSchema("XST34",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("Xsdhdh")]
		[Bindable(true)]
		public string Xsdhdh 
		{
			get { return GetColumnValue<string>(Columns.Xsdhdh); }
			set { SetColumnValue(Columns.Xsdhdh, value); }
		}
		  
		[XmlAttribute("Kcdcck")]
		[Bindable(true)]
		public string Kcdcck 
		{
			get { return GetColumnValue<string>(Columns.Kcdcck); }
			set { SetColumnValue(Columns.Kcdcck, value); }
		}
		  
		[XmlAttribute("Kcdrck")]
		[Bindable(true)]
		public string Kcdrck 
		{
			get { return GetColumnValue<string>(Columns.Kcdrck); }
			set { SetColumnValue(Columns.Kcdrck, value); }
		}
		  
		[XmlAttribute("Xsdhrq")]
		[Bindable(true)]
		public DateTime? Xsdhrq 
		{
			get { return GetColumnValue<DateTime?>(Columns.Xsdhrq); }
			set { SetColumnValue(Columns.Xsdhrq, value); }
		}
		  
		[XmlAttribute("Xsdhze")]
		[Bindable(true)]
		public decimal? Xsdhze 
		{
			get { return GetColumnValue<decimal?>(Columns.Xsdhze); }
			set { SetColumnValue(Columns.Xsdhze, value); }
		}
		  
		[XmlAttribute("Xskjnd")]
		[Bindable(true)]
		public decimal? Xskjnd 
		{
			get { return GetColumnValue<decimal?>(Columns.Xskjnd); }
			set { SetColumnValue(Columns.Xskjnd, value); }
		}
		  
		[XmlAttribute("Xskjyf")]
		[Bindable(true)]
		public decimal? Xskjyf 
		{
			get { return GetColumnValue<decimal?>(Columns.Xskjyf); }
			set { SetColumnValue(Columns.Xskjyf, value); }
		}
		  
		[XmlAttribute("Xsdhzt")]
		[Bindable(true)]
		public string Xsdhzt 
		{
			get { return GetColumnValue<string>(Columns.Xsdhzt); }
			set { SetColumnValue(Columns.Xsdhzt, value); }
		}
		  
		[XmlAttribute("Xslrry")]
		[Bindable(true)]
		public string Xslrry 
		{
			get { return GetColumnValue<string>(Columns.Xslrry); }
			set { SetColumnValue(Columns.Xslrry, value); }
		}
		  
		[XmlAttribute("Xslrrq")]
		[Bindable(true)]
		public DateTime? Xslrrq 
		{
			get { return GetColumnValue<DateTime?>(Columns.Xslrrq); }
			set { SetColumnValue(Columns.Xslrrq, value); }
		}
		  
		[XmlAttribute("Xsshry")]
		[Bindable(true)]
		public string Xsshry 
		{
			get { return GetColumnValue<string>(Columns.Xsshry); }
			set { SetColumnValue(Columns.Xsshry, value); }
		}
		  
		[XmlAttribute("Xsshrq")]
		[Bindable(true)]
		public DateTime? Xsshrq 
		{
			get { return GetColumnValue<DateTime?>(Columns.Xsshrq); }
			set { SetColumnValue(Columns.Xsshrq, value); }
		}
		
		#endregion
		
		
			
		
		//no foreign key tables defined (0)
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(string varXsdhdh,string varKcdcck,string varKcdrck,DateTime? varXsdhrq,decimal? varXsdhze,decimal? varXskjnd,decimal? varXskjyf,string varXsdhzt,string varXslrry,DateTime? varXslrrq,string varXsshry,DateTime? varXsshrq)
		{
			XST34 item = new XST34();
			
			item.Xsdhdh = varXsdhdh;
			
			item.Kcdcck = varKcdcck;
			
			item.Kcdrck = varKcdrck;
			
			item.Xsdhrq = varXsdhrq;
			
			item.Xsdhze = varXsdhze;
			
			item.Xskjnd = varXskjnd;
			
			item.Xskjyf = varXskjyf;
			
			item.Xsdhzt = varXsdhzt;
			
			item.Xslrry = varXslrry;
			
			item.Xslrrq = varXslrrq;
			
			item.Xsshry = varXsshry;
			
			item.Xsshrq = varXsshrq;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(string varXsdhdh,string varKcdcck,string varKcdrck,DateTime? varXsdhrq,decimal? varXsdhze,decimal? varXskjnd,decimal? varXskjyf,string varXsdhzt,string varXslrry,DateTime? varXslrrq,string varXsshry,DateTime? varXsshrq)
		{
			XST34 item = new XST34();
			
				item.Xsdhdh = varXsdhdh;
			
				item.Kcdcck = varKcdcck;
			
				item.Kcdrck = varKcdrck;
			
				item.Xsdhrq = varXsdhrq;
			
				item.Xsdhze = varXsdhze;
			
				item.Xskjnd = varXskjnd;
			
				item.Xskjyf = varXskjyf;
			
				item.Xsdhzt = varXsdhzt;
			
				item.Xslrry = varXslrry;
			
				item.Xslrrq = varXslrrq;
			
				item.Xsshry = varXsshry;
			
				item.Xsshrq = varXsshrq;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn XsdhdhColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn KcdcckColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        public static TableSchema.TableColumn KcdrckColumn
        {
            get { return Schema.Columns[2]; }
        }
        
        
        
        public static TableSchema.TableColumn XsdhrqColumn
        {
            get { return Schema.Columns[3]; }
        }
        
        
        
        public static TableSchema.TableColumn XsdhzeColumn
        {
            get { return Schema.Columns[4]; }
        }
        
        
        
        public static TableSchema.TableColumn XskjndColumn
        {
            get { return Schema.Columns[5]; }
        }
        
        
        
        public static TableSchema.TableColumn XskjyfColumn
        {
            get { return Schema.Columns[6]; }
        }
        
        
        
        public static TableSchema.TableColumn XsdhztColumn
        {
            get { return Schema.Columns[7]; }
        }
        
        
        
        public static TableSchema.TableColumn XslrryColumn
        {
            get { return Schema.Columns[8]; }
        }
        
        
        
        public static TableSchema.TableColumn XslrrqColumn
        {
            get { return Schema.Columns[9]; }
        }
        
        
        
        public static TableSchema.TableColumn XsshryColumn
        {
            get { return Schema.Columns[10]; }
        }
        
        
        
        public static TableSchema.TableColumn XsshrqColumn
        {
            get { return Schema.Columns[11]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string Xsdhdh = @"XSDHDH";
			 public static string Kcdcck = @"KCDCCK";
			 public static string Kcdrck = @"KCDRCK";
			 public static string Xsdhrq = @"XSDHRQ";
			 public static string Xsdhze = @"XSDHZE";
			 public static string Xskjnd = @"XSKJND";
			 public static string Xskjyf = @"XSKJYF";
			 public static string Xsdhzt = @"XSDHZT";
			 public static string Xslrry = @"XSLRRY";
			 public static string Xslrrq = @"XSLRRQ";
			 public static string Xsshry = @"XSSHRY";
			 public static string Xsshrq = @"XSSHRQ";
						
		}
		#endregion
		
		#region Update PK Collections
		
        #endregion
    
        #region Deep Save
		
        #endregion
	}
}
