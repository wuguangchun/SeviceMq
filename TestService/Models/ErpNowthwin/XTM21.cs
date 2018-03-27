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
	/// Strongly-typed collection for the XTM21 class.
	/// </summary>
    [Serializable]
	public partial class XTM21Collection : ActiveList<XTM21, XTM21Collection>
	{	   
		public XTM21Collection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>XTM21Collection</returns>
		public XTM21Collection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                XTM21 o = this[i];
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
	/// This is an ActiveRecord class which wraps the XTM21 table.
	/// </summary>
	[Serializable]
	public partial class XTM21 : ActiveRecord<XTM21>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public XTM21()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public XTM21(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public XTM21(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public XTM21(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("XTM21", TableType.Table, DataService.GetInstance("ErpNowthwin"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"FYERP";
				//columns
				
				TableSchema.TableColumn colvarXtfydm = new TableSchema.TableColumn(schema);
				colvarXtfydm.ColumnName = "XTFYDM";
				colvarXtfydm.DataType = DbType.String;
				colvarXtfydm.MaxLength = 3;
				colvarXtfydm.AutoIncrement = false;
				colvarXtfydm.IsNullable = false;
				colvarXtfydm.IsPrimaryKey = true;
				colvarXtfydm.IsForeignKey = false;
				colvarXtfydm.IsReadOnly = false;
				colvarXtfydm.DefaultSetting = @"";
				colvarXtfydm.ForeignKeyTableName = "";
				schema.Columns.Add(colvarXtfydm);
				
				TableSchema.TableColumn colvarXtfymc = new TableSchema.TableColumn(schema);
				colvarXtfymc.ColumnName = "XTFYMC";
				colvarXtfymc.DataType = DbType.String;
				colvarXtfymc.MaxLength = 20;
				colvarXtfymc.AutoIncrement = false;
				colvarXtfymc.IsNullable = true;
				colvarXtfymc.IsPrimaryKey = false;
				colvarXtfymc.IsForeignKey = false;
				colvarXtfymc.IsReadOnly = false;
				colvarXtfymc.DefaultSetting = @"";
				colvarXtfymc.ForeignKeyTableName = "";
				schema.Columns.Add(colvarXtfymc);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["ErpNowthwin"].AddSchema("XTM21",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("Xtfydm")]
		[Bindable(true)]
		public string Xtfydm 
		{
			get { return GetColumnValue<string>(Columns.Xtfydm); }
			set { SetColumnValue(Columns.Xtfydm, value); }
		}
		  
		[XmlAttribute("Xtfymc")]
		[Bindable(true)]
		public string Xtfymc 
		{
			get { return GetColumnValue<string>(Columns.Xtfymc); }
			set { SetColumnValue(Columns.Xtfymc, value); }
		}
		
		#endregion
		
		
			
		
		//no foreign key tables defined (0)
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(string varXtfydm,string varXtfymc)
		{
			XTM21 item = new XTM21();
			
			item.Xtfydm = varXtfydm;
			
			item.Xtfymc = varXtfymc;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(string varXtfydm,string varXtfymc)
		{
			XTM21 item = new XTM21();
			
				item.Xtfydm = varXtfydm;
			
				item.Xtfymc = varXtfymc;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn XtfydmColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn XtfymcColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string Xtfydm = @"XTFYDM";
			 public static string Xtfymc = @"XTFYMC";
						
		}
		#endregion
		
		#region Update PK Collections
		
        #endregion
    
        #region Deep Save
		
        #endregion
	}
}
