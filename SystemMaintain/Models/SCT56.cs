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
	/// Strongly-typed collection for the SCT56 class.
	/// </summary>
    [Serializable]
	public partial class SCT56Collection : ActiveList<SCT56, SCT56Collection>
	{	   
		public SCT56Collection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>SCT56Collection</returns>
		public SCT56Collection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                SCT56 o = this[i];
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
	/// This is an ActiveRecord class which wraps the SCT56 table.
	/// </summary>
	[Serializable]
	public partial class SCT56 : ActiveRecord<SCT56>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public SCT56()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public SCT56(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public SCT56(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public SCT56(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("SCT56", TableType.Table, DataService.GetInstance("Nowthwin"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarSchtbh = new TableSchema.TableColumn(schema);
				colvarSchtbh.ColumnName = "SCHTBH";
				colvarSchtbh.DataType = DbType.AnsiString;
				colvarSchtbh.MaxLength = 12;
				colvarSchtbh.AutoIncrement = false;
				colvarSchtbh.IsNullable = false;
				colvarSchtbh.IsPrimaryKey = true;
				colvarSchtbh.IsForeignKey = false;
				colvarSchtbh.IsReadOnly = false;
				colvarSchtbh.DefaultSetting = @"";
				colvarSchtbh.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSchtbh);
				
				TableSchema.TableColumn colvarSchtzt = new TableSchema.TableColumn(schema);
				colvarSchtzt.ColumnName = "SCHTZT";
				colvarSchtzt.DataType = DbType.AnsiString;
				colvarSchtzt.MaxLength = 1;
				colvarSchtzt.AutoIncrement = false;
				colvarSchtzt.IsNullable = true;
				colvarSchtzt.IsPrimaryKey = false;
				colvarSchtzt.IsForeignKey = false;
				colvarSchtzt.IsReadOnly = false;
				colvarSchtzt.DefaultSetting = @"";
				colvarSchtzt.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSchtzt);
				
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
				DataService.Providers["Nowthwin"].AddSchema("SCT56",schema);
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
		  
		[XmlAttribute("Schtzt")]
		[Bindable(true)]
		public string Schtzt 
		{
			get { return GetColumnValue<string>(Columns.Schtzt); }
			set { SetColumnValue(Columns.Schtzt, value); }
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
		public static void Insert(string varSchtbh,string varSchtzt,string varXtyhdm)
		{
			SCT56 item = new SCT56();
			
			item.Schtbh = varSchtbh;
			
			item.Schtzt = varSchtzt;
			
			item.Xtyhdm = varXtyhdm;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(string varSchtbh,string varSchtzt,string varXtyhdm)
		{
			SCT56 item = new SCT56();
			
				item.Schtbh = varSchtbh;
			
				item.Schtzt = varSchtzt;
			
				item.Xtyhdm = varXtyhdm;
			
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
        
        
        
        public static TableSchema.TableColumn SchtztColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        public static TableSchema.TableColumn XtyhdmColumn
        {
            get { return Schema.Columns[2]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string Schtbh = @"SCHTBH";
			 public static string Schtzt = @"SCHTZT";
			 public static string Xtyhdm = @"XTYHDM";
						
		}
		#endregion
		
		#region Update PK Collections
		
        #endregion
    
        #region Deep Save
		
        #endregion
	}
}
