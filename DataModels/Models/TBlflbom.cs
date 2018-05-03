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
	/// Strongly-typed collection for the TBlflbom class.
	/// </summary>
    [Serializable]
	public partial class TBlflbomCollection : ActiveList<TBlflbom, TBlflbomCollection>
	{	   
		public TBlflbomCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>TBlflbomCollection</returns>
		public TBlflbomCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                TBlflbom o = this[i];
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
	/// This is an ActiveRecord class which wraps the T_BLFLBOM table.
	/// </summary>
	[Serializable]
	public partial class TBlflbom : ActiveRecord<TBlflbom>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public TBlflbom()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public TBlflbom(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public TBlflbom(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public TBlflbom(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("T_BLFLBOM", TableType.Table, DataService.GetInstance("Nowthwin"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarKhdh = new TableSchema.TableColumn(schema);
				colvarKhdh.ColumnName = "KHDH";
				colvarKhdh.DataType = DbType.String;
				colvarKhdh.MaxLength = 50;
				colvarKhdh.AutoIncrement = false;
				colvarKhdh.IsNullable = false;
				colvarKhdh.IsPrimaryKey = true;
				colvarKhdh.IsForeignKey = false;
				colvarKhdh.IsReadOnly = false;
				colvarKhdh.DefaultSetting = @"";
				colvarKhdh.ForeignKeyTableName = "";
				schema.Columns.Add(colvarKhdh);
				
				TableSchema.TableColumn colvarClflmc = new TableSchema.TableColumn(schema);
				colvarClflmc.ColumnName = "clflmc";
				colvarClflmc.DataType = DbType.String;
				colvarClflmc.MaxLength = 50;
				colvarClflmc.AutoIncrement = false;
				colvarClflmc.IsNullable = false;
				colvarClflmc.IsPrimaryKey = true;
				colvarClflmc.IsForeignKey = false;
				colvarClflmc.IsReadOnly = false;
				colvarClflmc.DefaultSetting = @"";
				colvarClflmc.ForeignKeyTableName = "";
				schema.Columns.Add(colvarClflmc);
				
				TableSchema.TableColumn colvarYlbm = new TableSchema.TableColumn(schema);
				colvarYlbm.ColumnName = "ylbm";
				colvarYlbm.DataType = DbType.AnsiString;
				colvarYlbm.MaxLength = 50;
				colvarYlbm.AutoIncrement = false;
				colvarYlbm.IsNullable = false;
				colvarYlbm.IsPrimaryKey = true;
				colvarYlbm.IsForeignKey = false;
				colvarYlbm.IsReadOnly = false;
				colvarYlbm.DefaultSetting = @"";
				colvarYlbm.ForeignKeyTableName = "";
				schema.Columns.Add(colvarYlbm);
				
				TableSchema.TableColumn colvarHy = new TableSchema.TableColumn(schema);
				colvarHy.ColumnName = "hy";
				colvarHy.DataType = DbType.Decimal;
				colvarHy.MaxLength = 0;
				colvarHy.AutoIncrement = false;
				colvarHy.IsNullable = false;
				colvarHy.IsPrimaryKey = false;
				colvarHy.IsForeignKey = false;
				colvarHy.IsReadOnly = false;
				colvarHy.DefaultSetting = @"";
				colvarHy.ForeignKeyTableName = "";
				schema.Columns.Add(colvarHy);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["Nowthwin"].AddSchema("T_BLFLBOM",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("Khdh")]
		[Bindable(true)]
		public string Khdh 
		{
			get { return GetColumnValue<string>(Columns.Khdh); }
			set { SetColumnValue(Columns.Khdh, value); }
		}
		  
		[XmlAttribute("Clflmc")]
		[Bindable(true)]
		public string Clflmc 
		{
			get { return GetColumnValue<string>(Columns.Clflmc); }
			set { SetColumnValue(Columns.Clflmc, value); }
		}
		  
		[XmlAttribute("Ylbm")]
		[Bindable(true)]
		public string Ylbm 
		{
			get { return GetColumnValue<string>(Columns.Ylbm); }
			set { SetColumnValue(Columns.Ylbm, value); }
		}
		  
		[XmlAttribute("Hy")]
		[Bindable(true)]
		public decimal Hy 
		{
			get { return GetColumnValue<decimal>(Columns.Hy); }
			set { SetColumnValue(Columns.Hy, value); }
		}
		
		#endregion
		
		
			
		
		//no foreign key tables defined (0)
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(string varKhdh,string varClflmc,string varYlbm,decimal varHy)
		{
			TBlflbom item = new TBlflbom();
			
			item.Khdh = varKhdh;
			
			item.Clflmc = varClflmc;
			
			item.Ylbm = varYlbm;
			
			item.Hy = varHy;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(string varKhdh,string varClflmc,string varYlbm,decimal varHy)
		{
			TBlflbom item = new TBlflbom();
			
				item.Khdh = varKhdh;
			
				item.Clflmc = varClflmc;
			
				item.Ylbm = varYlbm;
			
				item.Hy = varHy;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn KhdhColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn ClflmcColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        public static TableSchema.TableColumn YlbmColumn
        {
            get { return Schema.Columns[2]; }
        }
        
        
        
        public static TableSchema.TableColumn HyColumn
        {
            get { return Schema.Columns[3]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string Khdh = @"KHDH";
			 public static string Clflmc = @"clflmc";
			 public static string Ylbm = @"ylbm";
			 public static string Hy = @"hy";
						
		}
		#endregion
		
		#region Update PK Collections
		
        #endregion
    
        #region Deep Save
		
        #endregion
	}
}