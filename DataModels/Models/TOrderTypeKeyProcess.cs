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
	/// Strongly-typed collection for the TOrderTypeKeyProcess class.
	/// </summary>
    [Serializable]
	public partial class TOrderTypeKeyProcessCollection : ActiveList<TOrderTypeKeyProcess, TOrderTypeKeyProcessCollection>
	{	   
		public TOrderTypeKeyProcessCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>TOrderTypeKeyProcessCollection</returns>
		public TOrderTypeKeyProcessCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                TOrderTypeKeyProcess o = this[i];
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
	/// This is an ActiveRecord class which wraps the T_OrderTypeKeyProcess table.
	/// </summary>
	[Serializable]
	public partial class TOrderTypeKeyProcess : ActiveRecord<TOrderTypeKeyProcess>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public TOrderTypeKeyProcess()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public TOrderTypeKeyProcess(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public TOrderTypeKeyProcess(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public TOrderTypeKeyProcess(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("T_OrderTypeKeyProcess", TableType.Table, DataService.GetInstance("Nowthwin"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarFzfl = new TableSchema.TableColumn(schema);
				colvarFzfl.ColumnName = "Fzfl";
				colvarFzfl.DataType = DbType.String;
				colvarFzfl.MaxLength = 50;
				colvarFzfl.AutoIncrement = false;
				colvarFzfl.IsNullable = false;
				colvarFzfl.IsPrimaryKey = true;
				colvarFzfl.IsForeignKey = false;
				colvarFzfl.IsReadOnly = false;
				colvarFzfl.DefaultSetting = @"";
				colvarFzfl.ForeignKeyTableName = "";
				schema.Columns.Add(colvarFzfl);
				
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
				DataService.Providers["Nowthwin"].AddSchema("T_OrderTypeKeyProcess",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("Fzfl")]
		[Bindable(true)]
		public string Fzfl 
		{
			get { return GetColumnValue<string>(Columns.Fzfl); }
			set { SetColumnValue(Columns.Fzfl, value); }
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
		public static void Insert(string varFzfl,string varProcessNum,int? varHours)
		{
			TOrderTypeKeyProcess item = new TOrderTypeKeyProcess();
			
			item.Fzfl = varFzfl;
			
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
		public static void Update(string varFzfl,string varProcessNum,int? varHours)
		{
			TOrderTypeKeyProcess item = new TOrderTypeKeyProcess();
			
				item.Fzfl = varFzfl;
			
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
        
        
        public static TableSchema.TableColumn FzflColumn
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
			 public static string Fzfl = @"Fzfl";
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
