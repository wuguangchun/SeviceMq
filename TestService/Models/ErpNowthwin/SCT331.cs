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
	/// Strongly-typed collection for the SCT331 class.
	/// </summary>
    [Serializable]
	public partial class SCT331Collection : ActiveList<SCT331, SCT331Collection>
	{	   
		public SCT331Collection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>SCT331Collection</returns>
		public SCT331Collection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                SCT331 o = this[i];
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
	/// This is an ActiveRecord class which wraps the SCT331 table.
	/// </summary>
	[Serializable]
	public partial class SCT331 : ActiveRecord<SCT331>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public SCT331()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public SCT331(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public SCT331(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public SCT331(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("SCT331", TableType.Table, DataService.GetInstance("ErpNowthwin"));
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
				
				TableSchema.TableColumn colvarXtwpks = new TableSchema.TableColumn(schema);
				colvarXtwpks.ColumnName = "XTWPKS";
				colvarXtwpks.DataType = DbType.String;
				colvarXtwpks.MaxLength = 20;
				colvarXtwpks.AutoIncrement = false;
				colvarXtwpks.IsNullable = false;
				colvarXtwpks.IsPrimaryKey = true;
				colvarXtwpks.IsForeignKey = false;
				colvarXtwpks.IsReadOnly = false;
				colvarXtwpks.DefaultSetting = @"";
				colvarXtwpks.ForeignKeyTableName = "";
				schema.Columns.Add(colvarXtwpks);
				
				TableSchema.TableColumn colvarXtwpys = new TableSchema.TableColumn(schema);
				colvarXtwpys.ColumnName = "XTWPYS";
				colvarXtwpys.DataType = DbType.String;
				colvarXtwpys.MaxLength = 20;
				colvarXtwpys.AutoIncrement = false;
				colvarXtwpys.IsNullable = false;
				colvarXtwpys.IsPrimaryKey = true;
				colvarXtwpys.IsForeignKey = false;
				colvarXtwpys.IsReadOnly = false;
				colvarXtwpys.DefaultSetting = @"";
				colvarXtwpys.ForeignKeyTableName = "";
				schema.Columns.Add(colvarXtwpys);
				
				TableSchema.TableColumn colvarXtxmdm = new TableSchema.TableColumn(schema);
				colvarXtxmdm.ColumnName = "XTXMDM";
				colvarXtxmdm.DataType = DbType.String;
				colvarXtxmdm.MaxLength = 10;
				colvarXtxmdm.AutoIncrement = false;
				colvarXtxmdm.IsNullable = false;
				colvarXtxmdm.IsPrimaryKey = true;
				colvarXtxmdm.IsForeignKey = false;
				colvarXtxmdm.IsReadOnly = false;
				colvarXtxmdm.DefaultSetting = @"";
				colvarXtxmdm.ForeignKeyTableName = "";
				schema.Columns.Add(colvarXtxmdm);
				
				TableSchema.TableColumn colvarScptsl = new TableSchema.TableColumn(schema);
				colvarScptsl.ColumnName = "SCPTSL";
				colvarScptsl.DataType = DbType.Decimal;
				colvarScptsl.MaxLength = 0;
				colvarScptsl.AutoIncrement = false;
				colvarScptsl.IsNullable = true;
				colvarScptsl.IsPrimaryKey = false;
				colvarScptsl.IsForeignKey = false;
				colvarScptsl.IsReadOnly = false;
				colvarScptsl.DefaultSetting = @"";
				colvarScptsl.ForeignKeyTableName = "";
				schema.Columns.Add(colvarScptsl);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["ErpNowthwin"].AddSchema("SCT331",schema);
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
		  
		[XmlAttribute("Xtwpks")]
		[Bindable(true)]
		public string Xtwpks 
		{
			get { return GetColumnValue<string>(Columns.Xtwpks); }
			set { SetColumnValue(Columns.Xtwpks, value); }
		}
		  
		[XmlAttribute("Xtwpys")]
		[Bindable(true)]
		public string Xtwpys 
		{
			get { return GetColumnValue<string>(Columns.Xtwpys); }
			set { SetColumnValue(Columns.Xtwpys, value); }
		}
		  
		[XmlAttribute("Xtxmdm")]
		[Bindable(true)]
		public string Xtxmdm 
		{
			get { return GetColumnValue<string>(Columns.Xtxmdm); }
			set { SetColumnValue(Columns.Xtxmdm, value); }
		}
		  
		[XmlAttribute("Scptsl")]
		[Bindable(true)]
		public decimal? Scptsl 
		{
			get { return GetColumnValue<decimal?>(Columns.Scptsl); }
			set { SetColumnValue(Columns.Scptsl, value); }
		}
		
		#endregion
		
		
			
		
		//no foreign key tables defined (0)
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(string varSchtbh,string varXtwpks,string varXtwpys,string varXtxmdm,decimal? varScptsl)
		{
			SCT331 item = new SCT331();
			
			item.Schtbh = varSchtbh;
			
			item.Xtwpks = varXtwpks;
			
			item.Xtwpys = varXtwpys;
			
			item.Xtxmdm = varXtxmdm;
			
			item.Scptsl = varScptsl;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(string varSchtbh,string varXtwpks,string varXtwpys,string varXtxmdm,decimal? varScptsl)
		{
			SCT331 item = new SCT331();
			
				item.Schtbh = varSchtbh;
			
				item.Xtwpks = varXtwpks;
			
				item.Xtwpys = varXtwpys;
			
				item.Xtxmdm = varXtxmdm;
			
				item.Scptsl = varScptsl;
			
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
        
        
        
        public static TableSchema.TableColumn XtwpksColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        public static TableSchema.TableColumn XtwpysColumn
        {
            get { return Schema.Columns[2]; }
        }
        
        
        
        public static TableSchema.TableColumn XtxmdmColumn
        {
            get { return Schema.Columns[3]; }
        }
        
        
        
        public static TableSchema.TableColumn ScptslColumn
        {
            get { return Schema.Columns[4]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string Schtbh = @"SCHTBH";
			 public static string Xtwpks = @"XTWPKS";
			 public static string Xtwpys = @"XTWPYS";
			 public static string Xtxmdm = @"XTXMDM";
			 public static string Scptsl = @"SCPTSL";
						
		}
		#endregion
		
		#region Update PK Collections
		
        #endregion
    
        #region Deep Save
		
        #endregion
	}
}
