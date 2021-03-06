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
	/// Strongly-typed collection for the TOrderKeyProcess class.
	/// </summary>
    [Serializable]
	public partial class TOrderKeyProcessCollection : ActiveList<TOrderKeyProcess, TOrderKeyProcessCollection>
	{	   
		public TOrderKeyProcessCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>TOrderKeyProcessCollection</returns>
		public TOrderKeyProcessCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                TOrderKeyProcess o = this[i];
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
	/// This is an ActiveRecord class which wraps the T_OrderKeyProcess table.
	/// </summary>
	[Serializable]
	public partial class TOrderKeyProcess : ActiveRecord<TOrderKeyProcess>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public TOrderKeyProcess()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public TOrderKeyProcess(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public TOrderKeyProcess(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public TOrderKeyProcess(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("T_OrderKeyProcess", TableType.Table, DataService.GetInstance("Nowthwin"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarMxid = new TableSchema.TableColumn(schema);
				colvarMxid.ColumnName = "mxid";
				colvarMxid.DataType = DbType.Int32;
				colvarMxid.MaxLength = 0;
				colvarMxid.AutoIncrement = false;
				colvarMxid.IsNullable = false;
				colvarMxid.IsPrimaryKey = true;
				colvarMxid.IsForeignKey = false;
				colvarMxid.IsReadOnly = false;
				colvarMxid.DefaultSetting = @"";
				colvarMxid.ForeignKeyTableName = "";
				schema.Columns.Add(colvarMxid);
				
				TableSchema.TableColumn colvarProcessNum = new TableSchema.TableColumn(schema);
				colvarProcessNum.ColumnName = "ProcessNum";
				colvarProcessNum.DataType = DbType.String;
				colvarProcessNum.MaxLength = 10;
				colvarProcessNum.AutoIncrement = false;
				colvarProcessNum.IsNullable = false;
				colvarProcessNum.IsPrimaryKey = true;
				colvarProcessNum.IsForeignKey = false;
				colvarProcessNum.IsReadOnly = false;
				colvarProcessNum.DefaultSetting = @"";
				colvarProcessNum.ForeignKeyTableName = "";
				schema.Columns.Add(colvarProcessNum);
				
				TableSchema.TableColumn colvarHours = new TableSchema.TableColumn(schema);
				colvarHours.ColumnName = "Hours";
				colvarHours.DataType = DbType.Int32;
				colvarHours.MaxLength = 0;
				colvarHours.AutoIncrement = false;
				colvarHours.IsNullable = true;
				colvarHours.IsPrimaryKey = false;
				colvarHours.IsForeignKey = false;
				colvarHours.IsReadOnly = false;
				colvarHours.DefaultSetting = @"";
				colvarHours.ForeignKeyTableName = "";
				schema.Columns.Add(colvarHours);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["Nowthwin"].AddSchema("T_OrderKeyProcess",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("Mxid")]
		[Bindable(true)]
		public int Mxid 
		{
			get { return GetColumnValue<int>(Columns.Mxid); }
			set { SetColumnValue(Columns.Mxid, value); }
		}
		  
		[XmlAttribute("ProcessNum")]
		[Bindable(true)]
		public string ProcessNum 
		{
			get { return GetColumnValue<string>(Columns.ProcessNum); }
			set { SetColumnValue(Columns.ProcessNum, value); }
		}
		  
		[XmlAttribute("Hours")]
		[Bindable(true)]
		public int? Hours 
		{
			get { return GetColumnValue<int?>(Columns.Hours); }
			set { SetColumnValue(Columns.Hours, value); }
		}
		
		#endregion
		
		
			
		
		//no foreign key tables defined (0)
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(int varMxid,string varProcessNum,int? varHours)
		{
			TOrderKeyProcess item = new TOrderKeyProcess();
			
			item.Mxid = varMxid;
			
			item.ProcessNum = varProcessNum;
			
			item.Hours = varHours;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varMxid,string varProcessNum,int? varHours)
		{
			TOrderKeyProcess item = new TOrderKeyProcess();
			
				item.Mxid = varMxid;
			
				item.ProcessNum = varProcessNum;
			
				item.Hours = varHours;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn MxidColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn ProcessNumColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        public static TableSchema.TableColumn HoursColumn
        {
            get { return Schema.Columns[2]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string Mxid = @"mxid";
			 public static string ProcessNum = @"ProcessNum";
			 public static string Hours = @"Hours";
						
		}
		#endregion
		
		#region Update PK Collections
		
        #endregion
    
        #region Deep Save
		
        #endregion
	}
}
