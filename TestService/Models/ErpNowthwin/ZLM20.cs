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
	/// Strongly-typed collection for the ZLM20 class.
	/// </summary>
    [Serializable]
	public partial class ZLM20Collection : ActiveList<ZLM20, ZLM20Collection>
	{	   
		public ZLM20Collection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>ZLM20Collection</returns>
		public ZLM20Collection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                ZLM20 o = this[i];
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
	/// This is an ActiveRecord class which wraps the ZLM20 table.
	/// </summary>
	[Serializable]
	public partial class ZLM20 : ActiveRecord<ZLM20>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public ZLM20()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public ZLM20(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public ZLM20(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public ZLM20(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("ZLM20", TableType.Table, DataService.GetInstance("ErpNowthwin"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"FYERP";
				//columns
				
				TableSchema.TableColumn colvarZlzjdm = new TableSchema.TableColumn(schema);
				colvarZlzjdm.ColumnName = "ZLZJDM";
				colvarZlzjdm.DataType = DbType.String;
				colvarZlzjdm.MaxLength = 12;
				colvarZlzjdm.AutoIncrement = false;
				colvarZlzjdm.IsNullable = false;
				colvarZlzjdm.IsPrimaryKey = true;
				colvarZlzjdm.IsForeignKey = false;
				colvarZlzjdm.IsReadOnly = false;
				colvarZlzjdm.DefaultSetting = @"";
				colvarZlzjdm.ForeignKeyTableName = "";
				schema.Columns.Add(colvarZlzjdm);
				
				TableSchema.TableColumn colvarZlzjmc = new TableSchema.TableColumn(schema);
				colvarZlzjmc.ColumnName = "ZLZJMC";
				colvarZlzjmc.DataType = DbType.String;
				colvarZlzjmc.MaxLength = 100;
				colvarZlzjmc.AutoIncrement = false;
				colvarZlzjmc.IsNullable = false;
				colvarZlzjmc.IsPrimaryKey = false;
				colvarZlzjmc.IsForeignKey = false;
				colvarZlzjmc.IsReadOnly = false;
				colvarZlzjmc.DefaultSetting = @"";
				colvarZlzjmc.ForeignKeyTableName = "";
				schema.Columns.Add(colvarZlzjmc);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["ErpNowthwin"].AddSchema("ZLM20",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("Zlzjdm")]
		[Bindable(true)]
		public string Zlzjdm 
		{
			get { return GetColumnValue<string>(Columns.Zlzjdm); }
			set { SetColumnValue(Columns.Zlzjdm, value); }
		}
		  
		[XmlAttribute("Zlzjmc")]
		[Bindable(true)]
		public string Zlzjmc 
		{
			get { return GetColumnValue<string>(Columns.Zlzjmc); }
			set { SetColumnValue(Columns.Zlzjmc, value); }
		}
		
		#endregion
		
		
			
		
		//no foreign key tables defined (0)
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(string varZlzjdm,string varZlzjmc)
		{
			ZLM20 item = new ZLM20();
			
			item.Zlzjdm = varZlzjdm;
			
			item.Zlzjmc = varZlzjmc;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(string varZlzjdm,string varZlzjmc)
		{
			ZLM20 item = new ZLM20();
			
				item.Zlzjdm = varZlzjdm;
			
				item.Zlzjmc = varZlzjmc;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn ZlzjdmColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn ZlzjmcColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string Zlzjdm = @"ZLZJDM";
			 public static string Zlzjmc = @"ZLZJMC";
						
		}
		#endregion
		
		#region Update PK Collections
		
        #endregion
    
        #region Deep Save
		
        #endregion
	}
}
