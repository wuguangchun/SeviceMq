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
	/// Strongly-typed collection for the SCT55 class.
	/// </summary>
    [Serializable]
	public partial class SCT55Collection : ActiveList<SCT55, SCT55Collection>
	{	   
		public SCT55Collection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>SCT55Collection</returns>
		public SCT55Collection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                SCT55 o = this[i];
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
	/// This is an ActiveRecord class which wraps the SCT55 table.
	/// </summary>
	[Serializable]
	public partial class SCT55 : ActiveRecord<SCT55>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public SCT55()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public SCT55(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public SCT55(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public SCT55(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("SCT55", TableType.Table, DataService.GetInstance("Nowthwin"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarScggdh = new TableSchema.TableColumn(schema);
				colvarScggdh.ColumnName = "SCGGDH";
				colvarScggdh.DataType = DbType.AnsiString;
				colvarScggdh.MaxLength = 12;
				colvarScggdh.AutoIncrement = false;
				colvarScggdh.IsNullable = false;
				colvarScggdh.IsPrimaryKey = true;
				colvarScggdh.IsForeignKey = false;
				colvarScggdh.IsReadOnly = false;
				colvarScggdh.DefaultSetting = @"";
				colvarScggdh.ForeignKeyTableName = "";
				schema.Columns.Add(colvarScggdh);
				
				TableSchema.TableColumn colvarScggxh = new TableSchema.TableColumn(schema);
				colvarScggxh.ColumnName = "SCGGXH";
				colvarScggxh.DataType = DbType.Int32;
				colvarScggxh.MaxLength = 0;
				colvarScggxh.AutoIncrement = false;
				colvarScggxh.IsNullable = false;
				colvarScggxh.IsPrimaryKey = true;
				colvarScggxh.IsForeignKey = false;
				colvarScggxh.IsReadOnly = false;
				colvarScggxh.DefaultSetting = @"";
				colvarScggxh.ForeignKeyTableName = "";
				schema.Columns.Add(colvarScggxh);
				
				TableSchema.TableColumn colvarSCDM04 = new TableSchema.TableColumn(schema);
				colvarSCDM04.ColumnName = "SCDM04";
				colvarSCDM04.DataType = DbType.AnsiString;
				colvarSCDM04.MaxLength = 20;
				colvarSCDM04.AutoIncrement = false;
				colvarSCDM04.IsNullable = true;
				colvarSCDM04.IsPrimaryKey = false;
				colvarSCDM04.IsForeignKey = false;
				colvarSCDM04.IsReadOnly = false;
				colvarSCDM04.DefaultSetting = @"";
				colvarSCDM04.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSCDM04);
				
				TableSchema.TableColumn colvarSCDM05 = new TableSchema.TableColumn(schema);
				colvarSCDM05.ColumnName = "SCDM05";
				colvarSCDM05.DataType = DbType.AnsiString;
				colvarSCDM05.MaxLength = 20;
				colvarSCDM05.AutoIncrement = false;
				colvarSCDM05.IsNullable = true;
				colvarSCDM05.IsPrimaryKey = false;
				colvarSCDM05.IsForeignKey = false;
				colvarSCDM05.IsReadOnly = false;
				colvarSCDM05.DefaultSetting = @"";
				colvarSCDM05.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSCDM05);
				
				TableSchema.TableColumn colvarSCDM06 = new TableSchema.TableColumn(schema);
				colvarSCDM06.ColumnName = "SCDM06";
				colvarSCDM06.DataType = DbType.AnsiString;
				colvarSCDM06.MaxLength = 20;
				colvarSCDM06.AutoIncrement = false;
				colvarSCDM06.IsNullable = true;
				colvarSCDM06.IsPrimaryKey = false;
				colvarSCDM06.IsForeignKey = false;
				colvarSCDM06.IsReadOnly = false;
				colvarSCDM06.DefaultSetting = @"";
				colvarSCDM06.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSCDM06);
				
				TableSchema.TableColumn colvarSCDM07 = new TableSchema.TableColumn(schema);
				colvarSCDM07.ColumnName = "SCDM07";
				colvarSCDM07.DataType = DbType.AnsiString;
				colvarSCDM07.MaxLength = 20;
				colvarSCDM07.AutoIncrement = false;
				colvarSCDM07.IsNullable = true;
				colvarSCDM07.IsPrimaryKey = false;
				colvarSCDM07.IsForeignKey = false;
				colvarSCDM07.IsReadOnly = false;
				colvarSCDM07.DefaultSetting = @"";
				colvarSCDM07.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSCDM07);
				
				TableSchema.TableColumn colvarSCDM08 = new TableSchema.TableColumn(schema);
				colvarSCDM08.ColumnName = "SCDM08";
				colvarSCDM08.DataType = DbType.AnsiString;
				colvarSCDM08.MaxLength = 20;
				colvarSCDM08.AutoIncrement = false;
				colvarSCDM08.IsNullable = true;
				colvarSCDM08.IsPrimaryKey = false;
				colvarSCDM08.IsForeignKey = false;
				colvarSCDM08.IsReadOnly = false;
				colvarSCDM08.DefaultSetting = @"";
				colvarSCDM08.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSCDM08);
				
				TableSchema.TableColumn colvarSCDM99 = new TableSchema.TableColumn(schema);
				colvarSCDM99.ColumnName = "SCDM99";
				colvarSCDM99.DataType = DbType.AnsiString;
				colvarSCDM99.MaxLength = 20;
				colvarSCDM99.AutoIncrement = false;
				colvarSCDM99.IsNullable = true;
				colvarSCDM99.IsPrimaryKey = false;
				colvarSCDM99.IsForeignKey = false;
				colvarSCDM99.IsReadOnly = false;
				colvarSCDM99.DefaultSetting = @"";
				colvarSCDM99.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSCDM99);
				
				TableSchema.TableColumn colvarXtmldm = new TableSchema.TableColumn(schema);
				colvarXtmldm.ColumnName = "XTMLDM";
				colvarXtmldm.DataType = DbType.AnsiString;
				colvarXtmldm.MaxLength = 20;
				colvarXtmldm.AutoIncrement = false;
				colvarXtmldm.IsNullable = true;
				colvarXtmldm.IsPrimaryKey = false;
				colvarXtmldm.IsForeignKey = false;
				colvarXtmldm.IsReadOnly = false;
				colvarXtmldm.DefaultSetting = @"";
				colvarXtmldm.ForeignKeyTableName = "";
				schema.Columns.Add(colvarXtmldm);
				
				TableSchema.TableColumn colvarXtyhdm = new TableSchema.TableColumn(schema);
				colvarXtyhdm.ColumnName = "XTYHDM";
				colvarXtyhdm.DataType = DbType.AnsiString;
				colvarXtyhdm.MaxLength = 100;
				colvarXtyhdm.AutoIncrement = false;
				colvarXtyhdm.IsNullable = true;
				colvarXtyhdm.IsPrimaryKey = false;
				colvarXtyhdm.IsForeignKey = false;
				colvarXtyhdm.IsReadOnly = false;
				colvarXtyhdm.DefaultSetting = @"";
				colvarXtyhdm.ForeignKeyTableName = "";
				schema.Columns.Add(colvarXtyhdm);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["Nowthwin"].AddSchema("SCT55",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("Scggdh")]
		[Bindable(true)]
		public string Scggdh 
		{
			get { return GetColumnValue<string>(Columns.Scggdh); }
			set { SetColumnValue(Columns.Scggdh, value); }
		}
		  
		[XmlAttribute("Scggxh")]
		[Bindable(true)]
		public int Scggxh 
		{
			get { return GetColumnValue<int>(Columns.Scggxh); }
			set { SetColumnValue(Columns.Scggxh, value); }
		}
		  
		[XmlAttribute("SCDM04")]
		[Bindable(true)]
		public string SCDM04 
		{
			get { return GetColumnValue<string>(Columns.SCDM04); }
			set { SetColumnValue(Columns.SCDM04, value); }
		}
		  
		[XmlAttribute("SCDM05")]
		[Bindable(true)]
		public string SCDM05 
		{
			get { return GetColumnValue<string>(Columns.SCDM05); }
			set { SetColumnValue(Columns.SCDM05, value); }
		}
		  
		[XmlAttribute("SCDM06")]
		[Bindable(true)]
		public string SCDM06 
		{
			get { return GetColumnValue<string>(Columns.SCDM06); }
			set { SetColumnValue(Columns.SCDM06, value); }
		}
		  
		[XmlAttribute("SCDM07")]
		[Bindable(true)]
		public string SCDM07 
		{
			get { return GetColumnValue<string>(Columns.SCDM07); }
			set { SetColumnValue(Columns.SCDM07, value); }
		}
		  
		[XmlAttribute("SCDM08")]
		[Bindable(true)]
		public string SCDM08 
		{
			get { return GetColumnValue<string>(Columns.SCDM08); }
			set { SetColumnValue(Columns.SCDM08, value); }
		}
		  
		[XmlAttribute("SCDM99")]
		[Bindable(true)]
		public string SCDM99 
		{
			get { return GetColumnValue<string>(Columns.SCDM99); }
			set { SetColumnValue(Columns.SCDM99, value); }
		}
		  
		[XmlAttribute("Xtmldm")]
		[Bindable(true)]
		public string Xtmldm 
		{
			get { return GetColumnValue<string>(Columns.Xtmldm); }
			set { SetColumnValue(Columns.Xtmldm, value); }
		}
		  
		[XmlAttribute("Xtyhdm")]
		[Bindable(true)]
		public string Xtyhdm 
		{
			get { return GetColumnValue<string>(Columns.Xtyhdm); }
			set { SetColumnValue(Columns.Xtyhdm, value); }
		}
		
		#endregion
		
		
			
		
		//no foreign key tables defined (0)
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(string varScggdh,int varScggxh,string varSCDM04,string varSCDM05,string varSCDM06,string varSCDM07,string varSCDM08,string varSCDM99,string varXtmldm,string varXtyhdm)
		{
			SCT55 item = new SCT55();
			
			item.Scggdh = varScggdh;
			
			item.Scggxh = varScggxh;
			
			item.SCDM04 = varSCDM04;
			
			item.SCDM05 = varSCDM05;
			
			item.SCDM06 = varSCDM06;
			
			item.SCDM07 = varSCDM07;
			
			item.SCDM08 = varSCDM08;
			
			item.SCDM99 = varSCDM99;
			
			item.Xtmldm = varXtmldm;
			
			item.Xtyhdm = varXtyhdm;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(string varScggdh,int varScggxh,string varSCDM04,string varSCDM05,string varSCDM06,string varSCDM07,string varSCDM08,string varSCDM99,string varXtmldm,string varXtyhdm)
		{
			SCT55 item = new SCT55();
			
				item.Scggdh = varScggdh;
			
				item.Scggxh = varScggxh;
			
				item.SCDM04 = varSCDM04;
			
				item.SCDM05 = varSCDM05;
			
				item.SCDM06 = varSCDM06;
			
				item.SCDM07 = varSCDM07;
			
				item.SCDM08 = varSCDM08;
			
				item.SCDM99 = varSCDM99;
			
				item.Xtmldm = varXtmldm;
			
				item.Xtyhdm = varXtyhdm;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn ScggdhColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn ScggxhColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        public static TableSchema.TableColumn SCDM04Column
        {
            get { return Schema.Columns[2]; }
        }
        
        
        
        public static TableSchema.TableColumn SCDM05Column
        {
            get { return Schema.Columns[3]; }
        }
        
        
        
        public static TableSchema.TableColumn SCDM06Column
        {
            get { return Schema.Columns[4]; }
        }
        
        
        
        public static TableSchema.TableColumn SCDM07Column
        {
            get { return Schema.Columns[5]; }
        }
        
        
        
        public static TableSchema.TableColumn SCDM08Column
        {
            get { return Schema.Columns[6]; }
        }
        
        
        
        public static TableSchema.TableColumn SCDM99Column
        {
            get { return Schema.Columns[7]; }
        }
        
        
        
        public static TableSchema.TableColumn XtmldmColumn
        {
            get { return Schema.Columns[8]; }
        }
        
        
        
        public static TableSchema.TableColumn XtyhdmColumn
        {
            get { return Schema.Columns[9]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string Scggdh = @"SCGGDH";
			 public static string Scggxh = @"SCGGXH";
			 public static string SCDM04 = @"SCDM04";
			 public static string SCDM05 = @"SCDM05";
			 public static string SCDM06 = @"SCDM06";
			 public static string SCDM07 = @"SCDM07";
			 public static string SCDM08 = @"SCDM08";
			 public static string SCDM99 = @"SCDM99";
			 public static string Xtmldm = @"XTMLDM";
			 public static string Xtyhdm = @"XTYHDM";
						
		}
		#endregion
		
		#region Update PK Collections
		
        #endregion
    
        #region Deep Save
		
        #endregion
	}
}
