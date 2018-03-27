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
	/// Strongly-typed collection for the SCT36 class.
	/// </summary>
    [Serializable]
	public partial class SCT36Collection : ActiveList<SCT36, SCT36Collection>
	{	   
		public SCT36Collection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>SCT36Collection</returns>
		public SCT36Collection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                SCT36 o = this[i];
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
	/// This is an ActiveRecord class which wraps the SCT36 table.
	/// </summary>
	[Serializable]
	public partial class SCT36 : ActiveRecord<SCT36>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public SCT36()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public SCT36(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public SCT36(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public SCT36(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("SCT36", TableType.Table, DataService.GetInstance("ErpNowthwin"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"FYERP";
				//columns
				
				TableSchema.TableColumn colvarSchtbh = new TableSchema.TableColumn(schema);
				colvarSchtbh.ColumnName = "SCHTBH";
				colvarSchtbh.DataType = DbType.String;
				colvarSchtbh.MaxLength = 12;
				colvarSchtbh.AutoIncrement = false;
				colvarSchtbh.IsNullable = false;
				colvarSchtbh.IsPrimaryKey = true;
				colvarSchtbh.IsForeignKey = false;
				colvarSchtbh.IsReadOnly = false;
				colvarSchtbh.DefaultSetting = @"";
				colvarSchtbh.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSchtbh);
				
				TableSchema.TableColumn colvarXttxhm = new TableSchema.TableColumn(schema);
				colvarXttxhm.ColumnName = "XTTXHM";
				colvarXttxhm.DataType = DbType.String;
				colvarXttxhm.MaxLength = 20;
				colvarXttxhm.AutoIncrement = false;
				colvarXttxhm.IsNullable = false;
				colvarXttxhm.IsPrimaryKey = true;
				colvarXttxhm.IsForeignKey = false;
				colvarXttxhm.IsReadOnly = false;
				colvarXttxhm.DefaultSetting = @"";
				colvarXttxhm.ForeignKeyTableName = "";
				schema.Columns.Add(colvarXttxhm);
				
				TableSchema.TableColumn colvarScxqrq = new TableSchema.TableColumn(schema);
				colvarScxqrq.ColumnName = "SCXQRQ";
				colvarScxqrq.DataType = DbType.DateTime;
				colvarScxqrq.MaxLength = 0;
				colvarScxqrq.AutoIncrement = false;
				colvarScxqrq.IsNullable = false;
				colvarScxqrq.IsPrimaryKey = true;
				colvarScxqrq.IsForeignKey = false;
				colvarScxqrq.IsReadOnly = false;
				colvarScxqrq.DefaultSetting = @"";
				colvarScxqrq.ForeignKeyTableName = "";
				schema.Columns.Add(colvarScxqrq);
				
				TableSchema.TableColumn colvarScclsl = new TableSchema.TableColumn(schema);
				colvarScclsl.ColumnName = "SCCLSL";
				colvarScclsl.DataType = DbType.Decimal;
				colvarScclsl.MaxLength = 0;
				colvarScclsl.AutoIncrement = false;
				colvarScclsl.IsNullable = true;
				colvarScclsl.IsPrimaryKey = false;
				colvarScclsl.IsForeignKey = false;
				colvarScclsl.IsReadOnly = false;
				colvarScclsl.DefaultSetting = @"";
				colvarScclsl.ForeignKeyTableName = "";
				schema.Columns.Add(colvarScclsl);
				
				TableSchema.TableColumn colvarScxqbz = new TableSchema.TableColumn(schema);
				colvarScxqbz.ColumnName = "SCXQBZ";
				colvarScxqbz.DataType = DbType.String;
				colvarScxqbz.MaxLength = 255;
				colvarScxqbz.AutoIncrement = false;
				colvarScxqbz.IsNullable = true;
				colvarScxqbz.IsPrimaryKey = false;
				colvarScxqbz.IsForeignKey = false;
				colvarScxqbz.IsReadOnly = false;
				colvarScxqbz.DefaultSetting = @"";
				colvarScxqbz.ForeignKeyTableName = "";
				schema.Columns.Add(colvarScxqbz);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["ErpNowthwin"].AddSchema("SCT36",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("Schtbh")]
		[Bindable(true)]
		public string Schtbh 
		{
			get { return GetColumnValue<string>(Columns.Schtbh); }
			set { SetColumnValue(Columns.Schtbh, value); }
		}
		  
		[XmlAttribute("Xttxhm")]
		[Bindable(true)]
		public string Xttxhm 
		{
			get { return GetColumnValue<string>(Columns.Xttxhm); }
			set { SetColumnValue(Columns.Xttxhm, value); }
		}
		  
		[XmlAttribute("Scxqrq")]
		[Bindable(true)]
		public DateTime Scxqrq 
		{
			get { return GetColumnValue<DateTime>(Columns.Scxqrq); }
			set { SetColumnValue(Columns.Scxqrq, value); }
		}
		  
		[XmlAttribute("Scclsl")]
		[Bindable(true)]
		public decimal? Scclsl 
		{
			get { return GetColumnValue<decimal?>(Columns.Scclsl); }
			set { SetColumnValue(Columns.Scclsl, value); }
		}
		  
		[XmlAttribute("Scxqbz")]
		[Bindable(true)]
		public string Scxqbz 
		{
			get { return GetColumnValue<string>(Columns.Scxqbz); }
			set { SetColumnValue(Columns.Scxqbz, value); }
		}
		
		#endregion
		
		
			
		
		//no foreign key tables defined (0)
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(string varSchtbh,string varXttxhm,DateTime varScxqrq,decimal? varScclsl,string varScxqbz)
		{
			SCT36 item = new SCT36();
			
			item.Schtbh = varSchtbh;
			
			item.Xttxhm = varXttxhm;
			
			item.Scxqrq = varScxqrq;
			
			item.Scclsl = varScclsl;
			
			item.Scxqbz = varScxqbz;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(string varSchtbh,string varXttxhm,DateTime varScxqrq,decimal? varScclsl,string varScxqbz)
		{
			SCT36 item = new SCT36();
			
				item.Schtbh = varSchtbh;
			
				item.Xttxhm = varXttxhm;
			
				item.Scxqrq = varScxqrq;
			
				item.Scclsl = varScclsl;
			
				item.Scxqbz = varScxqbz;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn SchtbhColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn XttxhmColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        public static TableSchema.TableColumn ScxqrqColumn
        {
            get { return Schema.Columns[2]; }
        }
        
        
        
        public static TableSchema.TableColumn ScclslColumn
        {
            get { return Schema.Columns[3]; }
        }
        
        
        
        public static TableSchema.TableColumn ScxqbzColumn
        {
            get { return Schema.Columns[4]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string Schtbh = @"SCHTBH";
			 public static string Xttxhm = @"XTTXHM";
			 public static string Scxqrq = @"SCXQRQ";
			 public static string Scclsl = @"SCCLSL";
			 public static string Scxqbz = @"SCXQBZ";
						
		}
		#endregion
		
		#region Update PK Collections
		
        #endregion
    
        #region Deep Save
		
        #endregion
	}
}
