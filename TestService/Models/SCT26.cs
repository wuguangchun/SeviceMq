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
namespace APSData
{
	/// <summary>
	/// Strongly-typed collection for the SCT26 class.
	/// </summary>
    [Serializable]
	public partial class SCT26Collection : ActiveList<SCT26, SCT26Collection>
	{	   
		public SCT26Collection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>SCT26Collection</returns>
		public SCT26Collection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                SCT26 o = this[i];
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
	/// This is an ActiveRecord class which wraps the SCT26 table.
	/// </summary>
	[Serializable]
	public partial class SCT26 : ActiveRecord<SCT26>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public SCT26()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public SCT26(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public SCT26(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public SCT26(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("SCT26", TableType.Table, DataService.GetInstance("Nowthwin"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarSczsbh = new TableSchema.TableColumn(schema);
				colvarSczsbh.ColumnName = "SCZSBH";
				colvarSczsbh.DataType = DbType.AnsiString;
				colvarSczsbh.MaxLength = 12;
				colvarSczsbh.AutoIncrement = false;
				colvarSczsbh.IsNullable = false;
				colvarSczsbh.IsPrimaryKey = true;
				colvarSczsbh.IsForeignKey = false;
				colvarSczsbh.IsReadOnly = false;
				colvarSczsbh.DefaultSetting = @"";
				colvarSczsbh.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSczsbh);
				
				TableSchema.TableColumn colvarScgcdm = new TableSchema.TableColumn(schema);
				colvarScgcdm.ColumnName = "SCGCDM";
				colvarScgcdm.DataType = DbType.AnsiString;
				colvarScgcdm.MaxLength = 8;
				colvarScgcdm.AutoIncrement = false;
				colvarScgcdm.IsNullable = true;
				colvarScgcdm.IsPrimaryKey = false;
				colvarScgcdm.IsForeignKey = false;
				colvarScgcdm.IsReadOnly = false;
				colvarScgcdm.DefaultSetting = @"";
				colvarScgcdm.ForeignKeyTableName = "";
				schema.Columns.Add(colvarScgcdm);
				
				TableSchema.TableColumn colvarScxdrq = new TableSchema.TableColumn(schema);
				colvarScxdrq.ColumnName = "SCXDRQ";
				colvarScxdrq.DataType = DbType.DateTime;
				colvarScxdrq.MaxLength = 0;
				colvarScxdrq.AutoIncrement = false;
				colvarScxdrq.IsNullable = true;
				colvarScxdrq.IsPrimaryKey = false;
				colvarScxdrq.IsForeignKey = false;
				colvarScxdrq.IsReadOnly = false;
				colvarScxdrq.DefaultSetting = @"";
				colvarScxdrq.ForeignKeyTableName = "";
				schema.Columns.Add(colvarScxdrq);
				
				TableSchema.TableColumn colvarSccjjq = new TableSchema.TableColumn(schema);
				colvarSccjjq.ColumnName = "SCCJJQ";
				colvarSccjjq.DataType = DbType.DateTime;
				colvarSccjjq.MaxLength = 0;
				colvarSccjjq.AutoIncrement = false;
				colvarSccjjq.IsNullable = true;
				colvarSccjjq.IsPrimaryKey = false;
				colvarSccjjq.IsForeignKey = false;
				colvarSccjjq.IsReadOnly = false;
				colvarSccjjq.DefaultSetting = @"";
				colvarSccjjq.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSccjjq);
				
				TableSchema.TableColumn colvarScfzjq = new TableSchema.TableColumn(schema);
				colvarScfzjq.ColumnName = "SCFZJQ";
				colvarScfzjq.DataType = DbType.DateTime;
				colvarScfzjq.MaxLength = 0;
				colvarScfzjq.AutoIncrement = false;
				colvarScfzjq.IsNullable = true;
				colvarScfzjq.IsPrimaryKey = false;
				colvarScfzjq.IsForeignKey = false;
				colvarScfzjq.IsReadOnly = false;
				colvarScfzjq.DefaultSetting = @"";
				colvarScfzjq.ForeignKeyTableName = "";
				schema.Columns.Add(colvarScfzjq);
				
				TableSchema.TableColumn colvarScjhrq = new TableSchema.TableColumn(schema);
				colvarScjhrq.ColumnName = "SCJHRQ";
				colvarScjhrq.DataType = DbType.DateTime;
				colvarScjhrq.MaxLength = 0;
				colvarScjhrq.AutoIncrement = false;
				colvarScjhrq.IsNullable = true;
				colvarScjhrq.IsPrimaryKey = false;
				colvarScjhrq.IsForeignKey = false;
				colvarScjhrq.IsReadOnly = false;
				colvarScjhrq.DefaultSetting = @"";
				colvarScjhrq.ForeignKeyTableName = "";
				schema.Columns.Add(colvarScjhrq);
				
				TableSchema.TableColumn colvarScjhry = new TableSchema.TableColumn(schema);
				colvarScjhry.ColumnName = "SCJHRY";
				colvarScjhry.DataType = DbType.AnsiString;
				colvarScjhry.MaxLength = 8;
				colvarScjhry.AutoIncrement = false;
				colvarScjhry.IsNullable = true;
				colvarScjhry.IsPrimaryKey = false;
				colvarScjhry.IsForeignKey = false;
				colvarScjhry.IsReadOnly = false;
				colvarScjhry.DefaultSetting = @"";
				colvarScjhry.ForeignKeyTableName = "";
				schema.Columns.Add(colvarScjhry);
				
				TableSchema.TableColumn colvarSczsbz = new TableSchema.TableColumn(schema);
				colvarSczsbz.ColumnName = "SCZSBZ";
				colvarSczsbz.DataType = DbType.AnsiString;
				colvarSczsbz.MaxLength = 255;
				colvarSczsbz.AutoIncrement = false;
				colvarSczsbz.IsNullable = true;
				colvarSczsbz.IsPrimaryKey = false;
				colvarSczsbz.IsForeignKey = false;
				colvarSczsbz.IsReadOnly = false;
				colvarSczsbz.DefaultSetting = @"";
				colvarSczsbz.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSczsbz);
				
				TableSchema.TableColumn colvarSczszt = new TableSchema.TableColumn(schema);
				colvarSczszt.ColumnName = "SCZSZT";
				colvarSczszt.DataType = DbType.AnsiString;
				colvarSczszt.MaxLength = 1;
				colvarSczszt.AutoIncrement = false;
				colvarSczszt.IsNullable = true;
				colvarSczszt.IsPrimaryKey = false;
				colvarSczszt.IsForeignKey = false;
				colvarSczszt.IsReadOnly = false;
				colvarSczszt.DefaultSetting = @"";
				colvarSczszt.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSczszt);
				
				TableSchema.TableColumn colvarScjqsm = new TableSchema.TableColumn(schema);
				colvarScjqsm.ColumnName = "SCJQSM";
				colvarScjqsm.DataType = DbType.AnsiString;
				colvarScjqsm.MaxLength = 100;
				colvarScjqsm.AutoIncrement = false;
				colvarScjqsm.IsNullable = true;
				colvarScjqsm.IsPrimaryKey = false;
				colvarScjqsm.IsForeignKey = false;
				colvarScjqsm.IsReadOnly = false;
				colvarScjqsm.DefaultSetting = @"";
				colvarScjqsm.ForeignKeyTableName = "";
				schema.Columns.Add(colvarScjqsm);
				
				TableSchema.TableColumn colvarScjqrq = new TableSchema.TableColumn(schema);
				colvarScjqrq.ColumnName = "SCJQRQ";
				colvarScjqrq.DataType = DbType.DateTime;
				colvarScjqrq.MaxLength = 0;
				colvarScjqrq.AutoIncrement = false;
				colvarScjqrq.IsNullable = true;
				colvarScjqrq.IsPrimaryKey = false;
				colvarScjqrq.IsForeignKey = false;
				colvarScjqrq.IsReadOnly = false;
				colvarScjqrq.DefaultSetting = @"";
				colvarScjqrq.ForeignKeyTableName = "";
				schema.Columns.Add(colvarScjqrq);
				
				TableSchema.TableColumn colvarSclrrq = new TableSchema.TableColumn(schema);
				colvarSclrrq.ColumnName = "SCLRRQ";
				colvarSclrrq.DataType = DbType.DateTime;
				colvarSclrrq.MaxLength = 0;
				colvarSclrrq.AutoIncrement = false;
				colvarSclrrq.IsNullable = true;
				colvarSclrrq.IsPrimaryKey = false;
				colvarSclrrq.IsForeignKey = false;
				colvarSclrrq.IsReadOnly = false;
				colvarSclrrq.DefaultSetting = @"";
				colvarSclrrq.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSclrrq);
				
				TableSchema.TableColumn colvarSclrry = new TableSchema.TableColumn(schema);
				colvarSclrry.ColumnName = "SCLRRY";
				colvarSclrry.DataType = DbType.AnsiString;
				colvarSclrry.MaxLength = 10;
				colvarSclrry.AutoIncrement = false;
				colvarSclrry.IsNullable = true;
				colvarSclrry.IsPrimaryKey = false;
				colvarSclrry.IsForeignKey = false;
				colvarSclrry.IsReadOnly = false;
				colvarSclrry.DefaultSetting = @"";
				colvarSclrry.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSclrry);
				
				TableSchema.TableColumn colvarScshrq = new TableSchema.TableColumn(schema);
				colvarScshrq.ColumnName = "SCSHRQ";
				colvarScshrq.DataType = DbType.DateTime;
				colvarScshrq.MaxLength = 0;
				colvarScshrq.AutoIncrement = false;
				colvarScshrq.IsNullable = true;
				colvarScshrq.IsPrimaryKey = false;
				colvarScshrq.IsForeignKey = false;
				colvarScshrq.IsReadOnly = false;
				colvarScshrq.DefaultSetting = @"";
				colvarScshrq.ForeignKeyTableName = "";
				schema.Columns.Add(colvarScshrq);
				
				TableSchema.TableColumn colvarScshry = new TableSchema.TableColumn(schema);
				colvarScshry.ColumnName = "SCSHRY";
				colvarScshry.DataType = DbType.AnsiString;
				colvarScshry.MaxLength = 10;
				colvarScshry.AutoIncrement = false;
				colvarScshry.IsNullable = true;
				colvarScshry.IsPrimaryKey = false;
				colvarScshry.IsForeignKey = false;
				colvarScshry.IsReadOnly = false;
				colvarScshry.DefaultSetting = @"";
				colvarScshry.ForeignKeyTableName = "";
				schema.Columns.Add(colvarScshry);
				
				TableSchema.TableColumn colvarScztjq = new TableSchema.TableColumn(schema);
				colvarScztjq.ColumnName = "SCZTJQ";
				colvarScztjq.DataType = DbType.DateTime;
				colvarScztjq.MaxLength = 0;
				colvarScztjq.AutoIncrement = false;
				colvarScztjq.IsNullable = true;
				colvarScztjq.IsPrimaryKey = false;
				colvarScztjq.IsForeignKey = false;
				colvarScztjq.IsReadOnly = false;
				colvarScztjq.DefaultSetting = @"";
				colvarScztjq.ForeignKeyTableName = "";
				schema.Columns.Add(colvarScztjq);
				
				TableSchema.TableColumn colvarScbzjq = new TableSchema.TableColumn(schema);
				colvarScbzjq.ColumnName = "SCBZJQ";
				colvarScbzjq.DataType = DbType.DateTime;
				colvarScbzjq.MaxLength = 0;
				colvarScbzjq.AutoIncrement = false;
				colvarScbzjq.IsNullable = true;
				colvarScbzjq.IsPrimaryKey = false;
				colvarScbzjq.IsForeignKey = false;
				colvarScbzjq.IsReadOnly = false;
				colvarScbzjq.DefaultSetting = @"";
				colvarScbzjq.ForeignKeyTableName = "";
				schema.Columns.Add(colvarScbzjq);
				
				TableSchema.TableColumn colvarSchtbh = new TableSchema.TableColumn(schema);
				colvarSchtbh.ColumnName = "SCHTBH";
				colvarSchtbh.DataType = DbType.AnsiString;
				colvarSchtbh.MaxLength = 12;
				colvarSchtbh.AutoIncrement = false;
				colvarSchtbh.IsNullable = true;
				colvarSchtbh.IsPrimaryKey = false;
				colvarSchtbh.IsForeignKey = false;
				colvarSchtbh.IsReadOnly = false;
				colvarSchtbh.DefaultSetting = @"";
				colvarSchtbh.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSchtbh);
				
				TableSchema.TableColumn colvarSctcrq = new TableSchema.TableColumn(schema);
				colvarSctcrq.ColumnName = "SCTCRQ";
				colvarSctcrq.DataType = DbType.DateTime;
				colvarSctcrq.MaxLength = 0;
				colvarSctcrq.AutoIncrement = false;
				colvarSctcrq.IsNullable = true;
				colvarSctcrq.IsPrimaryKey = false;
				colvarSctcrq.IsForeignKey = false;
				colvarSctcrq.IsReadOnly = false;
				colvarSctcrq.DefaultSetting = @"";
				colvarSctcrq.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSctcrq);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["Nowthwin"].AddSchema("SCT26",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("Sczsbh")]
		[Bindable(true)]
		public string Sczsbh 
		{
			get { return GetColumnValue<string>(Columns.Sczsbh); }
			set { SetColumnValue(Columns.Sczsbh, value); }
		}
		  
		[XmlAttribute("Scgcdm")]
		[Bindable(true)]
		public string Scgcdm 
		{
			get { return GetColumnValue<string>(Columns.Scgcdm); }
			set { SetColumnValue(Columns.Scgcdm, value); }
		}
		  
		[XmlAttribute("Scxdrq")]
		[Bindable(true)]
		public DateTime? Scxdrq 
		{
			get { return GetColumnValue<DateTime?>(Columns.Scxdrq); }
			set { SetColumnValue(Columns.Scxdrq, value); }
		}
		  
		[XmlAttribute("Sccjjq")]
		[Bindable(true)]
		public DateTime? Sccjjq 
		{
			get { return GetColumnValue<DateTime?>(Columns.Sccjjq); }
			set { SetColumnValue(Columns.Sccjjq, value); }
		}
		  
		[XmlAttribute("Scfzjq")]
		[Bindable(true)]
		public DateTime? Scfzjq 
		{
			get { return GetColumnValue<DateTime?>(Columns.Scfzjq); }
			set { SetColumnValue(Columns.Scfzjq, value); }
		}
		  
		[XmlAttribute("Scjhrq")]
		[Bindable(true)]
		public DateTime? Scjhrq 
		{
			get { return GetColumnValue<DateTime?>(Columns.Scjhrq); }
			set { SetColumnValue(Columns.Scjhrq, value); }
		}
		  
		[XmlAttribute("Scjhry")]
		[Bindable(true)]
		public string Scjhry 
		{
			get { return GetColumnValue<string>(Columns.Scjhry); }
			set { SetColumnValue(Columns.Scjhry, value); }
		}
		  
		[XmlAttribute("Sczsbz")]
		[Bindable(true)]
		public string Sczsbz 
		{
			get { return GetColumnValue<string>(Columns.Sczsbz); }
			set { SetColumnValue(Columns.Sczsbz, value); }
		}
		  
		[XmlAttribute("Sczszt")]
		[Bindable(true)]
		public string Sczszt 
		{
			get { return GetColumnValue<string>(Columns.Sczszt); }
			set { SetColumnValue(Columns.Sczszt, value); }
		}
		  
		[XmlAttribute("Scjqsm")]
		[Bindable(true)]
		public string Scjqsm 
		{
			get { return GetColumnValue<string>(Columns.Scjqsm); }
			set { SetColumnValue(Columns.Scjqsm, value); }
		}
		  
		[XmlAttribute("Scjqrq")]
		[Bindable(true)]
		public DateTime? Scjqrq 
		{
			get { return GetColumnValue<DateTime?>(Columns.Scjqrq); }
			set { SetColumnValue(Columns.Scjqrq, value); }
		}
		  
		[XmlAttribute("Sclrrq")]
		[Bindable(true)]
		public DateTime? Sclrrq 
		{
			get { return GetColumnValue<DateTime?>(Columns.Sclrrq); }
			set { SetColumnValue(Columns.Sclrrq, value); }
		}
		  
		[XmlAttribute("Sclrry")]
		[Bindable(true)]
		public string Sclrry 
		{
			get { return GetColumnValue<string>(Columns.Sclrry); }
			set { SetColumnValue(Columns.Sclrry, value); }
		}
		  
		[XmlAttribute("Scshrq")]
		[Bindable(true)]
		public DateTime? Scshrq 
		{
			get { return GetColumnValue<DateTime?>(Columns.Scshrq); }
			set { SetColumnValue(Columns.Scshrq, value); }
		}
		  
		[XmlAttribute("Scshry")]
		[Bindable(true)]
		public string Scshry 
		{
			get { return GetColumnValue<string>(Columns.Scshry); }
			set { SetColumnValue(Columns.Scshry, value); }
		}
		  
		[XmlAttribute("Scztjq")]
		[Bindable(true)]
		public DateTime? Scztjq 
		{
			get { return GetColumnValue<DateTime?>(Columns.Scztjq); }
			set { SetColumnValue(Columns.Scztjq, value); }
		}
		  
		[XmlAttribute("Scbzjq")]
		[Bindable(true)]
		public DateTime? Scbzjq 
		{
			get { return GetColumnValue<DateTime?>(Columns.Scbzjq); }
			set { SetColumnValue(Columns.Scbzjq, value); }
		}
		  
		[XmlAttribute("Schtbh")]
		[Bindable(true)]
		public string Schtbh 
		{
			get { return GetColumnValue<string>(Columns.Schtbh); }
			set { SetColumnValue(Columns.Schtbh, value); }
		}
		  
		[XmlAttribute("Sctcrq")]
		[Bindable(true)]
		public DateTime? Sctcrq 
		{
			get { return GetColumnValue<DateTime?>(Columns.Sctcrq); }
			set { SetColumnValue(Columns.Sctcrq, value); }
		}
		
		#endregion
		
		
			
		
		//no foreign key tables defined (0)
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(string varSczsbh,string varScgcdm,DateTime? varScxdrq,DateTime? varSccjjq,DateTime? varScfzjq,DateTime? varScjhrq,string varScjhry,string varSczsbz,string varSczszt,string varScjqsm,DateTime? varScjqrq,DateTime? varSclrrq,string varSclrry,DateTime? varScshrq,string varScshry,DateTime? varScztjq,DateTime? varScbzjq,string varSchtbh,DateTime? varSctcrq)
		{
			SCT26 item = new SCT26();
			
			item.Sczsbh = varSczsbh;
			
			item.Scgcdm = varScgcdm;
			
			item.Scxdrq = varScxdrq;
			
			item.Sccjjq = varSccjjq;
			
			item.Scfzjq = varScfzjq;
			
			item.Scjhrq = varScjhrq;
			
			item.Scjhry = varScjhry;
			
			item.Sczsbz = varSczsbz;
			
			item.Sczszt = varSczszt;
			
			item.Scjqsm = varScjqsm;
			
			item.Scjqrq = varScjqrq;
			
			item.Sclrrq = varSclrrq;
			
			item.Sclrry = varSclrry;
			
			item.Scshrq = varScshrq;
			
			item.Scshry = varScshry;
			
			item.Scztjq = varScztjq;
			
			item.Scbzjq = varScbzjq;
			
			item.Schtbh = varSchtbh;
			
			item.Sctcrq = varSctcrq;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(string varSczsbh,string varScgcdm,DateTime? varScxdrq,DateTime? varSccjjq,DateTime? varScfzjq,DateTime? varScjhrq,string varScjhry,string varSczsbz,string varSczszt,string varScjqsm,DateTime? varScjqrq,DateTime? varSclrrq,string varSclrry,DateTime? varScshrq,string varScshry,DateTime? varScztjq,DateTime? varScbzjq,string varSchtbh,DateTime? varSctcrq)
		{
			SCT26 item = new SCT26();
			
				item.Sczsbh = varSczsbh;
			
				item.Scgcdm = varScgcdm;
			
				item.Scxdrq = varScxdrq;
			
				item.Sccjjq = varSccjjq;
			
				item.Scfzjq = varScfzjq;
			
				item.Scjhrq = varScjhrq;
			
				item.Scjhry = varScjhry;
			
				item.Sczsbz = varSczsbz;
			
				item.Sczszt = varSczszt;
			
				item.Scjqsm = varScjqsm;
			
				item.Scjqrq = varScjqrq;
			
				item.Sclrrq = varSclrrq;
			
				item.Sclrry = varSclrry;
			
				item.Scshrq = varScshrq;
			
				item.Scshry = varScshry;
			
				item.Scztjq = varScztjq;
			
				item.Scbzjq = varScbzjq;
			
				item.Schtbh = varSchtbh;
			
				item.Sctcrq = varSctcrq;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn SczsbhColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn ScgcdmColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        public static TableSchema.TableColumn ScxdrqColumn
        {
            get { return Schema.Columns[2]; }
        }
        
        
        
        public static TableSchema.TableColumn SccjjqColumn
        {
            get { return Schema.Columns[3]; }
        }
        
        
        
        public static TableSchema.TableColumn ScfzjqColumn
        {
            get { return Schema.Columns[4]; }
        }
        
        
        
        public static TableSchema.TableColumn ScjhrqColumn
        {
            get { return Schema.Columns[5]; }
        }
        
        
        
        public static TableSchema.TableColumn ScjhryColumn
        {
            get { return Schema.Columns[6]; }
        }
        
        
        
        public static TableSchema.TableColumn SczsbzColumn
        {
            get { return Schema.Columns[7]; }
        }
        
        
        
        public static TableSchema.TableColumn SczsztColumn
        {
            get { return Schema.Columns[8]; }
        }
        
        
        
        public static TableSchema.TableColumn ScjqsmColumn
        {
            get { return Schema.Columns[9]; }
        }
        
        
        
        public static TableSchema.TableColumn ScjqrqColumn
        {
            get { return Schema.Columns[10]; }
        }
        
        
        
        public static TableSchema.TableColumn SclrrqColumn
        {
            get { return Schema.Columns[11]; }
        }
        
        
        
        public static TableSchema.TableColumn SclrryColumn
        {
            get { return Schema.Columns[12]; }
        }
        
        
        
        public static TableSchema.TableColumn ScshrqColumn
        {
            get { return Schema.Columns[13]; }
        }
        
        
        
        public static TableSchema.TableColumn ScshryColumn
        {
            get { return Schema.Columns[14]; }
        }
        
        
        
        public static TableSchema.TableColumn ScztjqColumn
        {
            get { return Schema.Columns[15]; }
        }
        
        
        
        public static TableSchema.TableColumn ScbzjqColumn
        {
            get { return Schema.Columns[16]; }
        }
        
        
        
        public static TableSchema.TableColumn SchtbhColumn
        {
            get { return Schema.Columns[17]; }
        }
        
        
        
        public static TableSchema.TableColumn SctcrqColumn
        {
            get { return Schema.Columns[18]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string Sczsbh = @"SCZSBH";
			 public static string Scgcdm = @"SCGCDM";
			 public static string Scxdrq = @"SCXDRQ";
			 public static string Sccjjq = @"SCCJJQ";
			 public static string Scfzjq = @"SCFZJQ";
			 public static string Scjhrq = @"SCJHRQ";
			 public static string Scjhry = @"SCJHRY";
			 public static string Sczsbz = @"SCZSBZ";
			 public static string Sczszt = @"SCZSZT";
			 public static string Scjqsm = @"SCJQSM";
			 public static string Scjqrq = @"SCJQRQ";
			 public static string Sclrrq = @"SCLRRQ";
			 public static string Sclrry = @"SCLRRY";
			 public static string Scshrq = @"SCSHRQ";
			 public static string Scshry = @"SCSHRY";
			 public static string Scztjq = @"SCZTJQ";
			 public static string Scbzjq = @"SCBZJQ";
			 public static string Schtbh = @"SCHTBH";
			 public static string Sctcrq = @"SCTCRQ";
						
		}
		#endregion
		
		#region Update PK Collections
		
        #endregion
    
        #region Deep Save
		
        #endregion
	}
}
