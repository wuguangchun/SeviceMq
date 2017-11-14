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
	/// Strongly-typed collection for the HljtTaskList class.
	/// </summary>
    [Serializable]
	public partial class HljtTaskListCollection : ActiveList<HljtTaskList, HljtTaskListCollection>
	{	   
		public HljtTaskListCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>HljtTaskListCollection</returns>
		public HljtTaskListCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                HljtTaskList o = this[i];
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
	/// This is an ActiveRecord class which wraps the HLJT_TaskList table.
	/// </summary>
	[Serializable]
	public partial class HljtTaskList : ActiveRecord<HljtTaskList>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public HljtTaskList()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public HljtTaskList(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public HljtTaskList(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public HljtTaskList(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("HLJT_TaskList", TableType.Table, DataService.GetInstance("Nowthwin"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarModelType = new TableSchema.TableColumn(schema);
				colvarModelType.ColumnName = "ModelType";
				colvarModelType.DataType = DbType.AnsiString;
				colvarModelType.MaxLength = 50;
				colvarModelType.AutoIncrement = false;
				colvarModelType.IsNullable = false;
				colvarModelType.IsPrimaryKey = true;
				colvarModelType.IsForeignKey = false;
				colvarModelType.IsReadOnly = false;
				colvarModelType.DefaultSetting = @"";
				colvarModelType.ForeignKeyTableName = "";
				schema.Columns.Add(colvarModelType);
				
				TableSchema.TableColumn colvarFlag = new TableSchema.TableColumn(schema);
				colvarFlag.ColumnName = "Flag";
				colvarFlag.DataType = DbType.AnsiString;
				colvarFlag.MaxLength = 50;
				colvarFlag.AutoIncrement = false;
				colvarFlag.IsNullable = true;
				colvarFlag.IsPrimaryKey = false;
				colvarFlag.IsForeignKey = false;
				colvarFlag.IsReadOnly = false;
				
						colvarFlag.DefaultSetting = @"('N')";
				colvarFlag.ForeignKeyTableName = "";
				schema.Columns.Add(colvarFlag);
				
				TableSchema.TableColumn colvarUpdateSource = new TableSchema.TableColumn(schema);
				colvarUpdateSource.ColumnName = "UpdateSource";
				colvarUpdateSource.DataType = DbType.AnsiString;
				colvarUpdateSource.MaxLength = 50;
				colvarUpdateSource.AutoIncrement = false;
				colvarUpdateSource.IsNullable = true;
				colvarUpdateSource.IsPrimaryKey = false;
				colvarUpdateSource.IsForeignKey = false;
				colvarUpdateSource.IsReadOnly = false;
				colvarUpdateSource.DefaultSetting = @"";
				colvarUpdateSource.ForeignKeyTableName = "";
				schema.Columns.Add(colvarUpdateSource);
				
				TableSchema.TableColumn colvarUpdateTime = new TableSchema.TableColumn(schema);
				colvarUpdateTime.ColumnName = "UpdateTime";
				colvarUpdateTime.DataType = DbType.DateTime;
				colvarUpdateTime.MaxLength = 0;
				colvarUpdateTime.AutoIncrement = false;
				colvarUpdateTime.IsNullable = true;
				colvarUpdateTime.IsPrimaryKey = false;
				colvarUpdateTime.IsForeignKey = false;
				colvarUpdateTime.IsReadOnly = false;
				colvarUpdateTime.DefaultSetting = @"";
				colvarUpdateTime.ForeignKeyTableName = "";
				schema.Columns.Add(colvarUpdateTime);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["Nowthwin"].AddSchema("HLJT_TaskList",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("ModelType")]
		[Bindable(true)]
		public string ModelType 
		{
			get { return GetColumnValue<string>(Columns.ModelType); }
			set { SetColumnValue(Columns.ModelType, value); }
		}
		  
		[XmlAttribute("Flag")]
		[Bindable(true)]
		public string Flag 
		{
			get { return GetColumnValue<string>(Columns.Flag); }
			set { SetColumnValue(Columns.Flag, value); }
		}
		  
		[XmlAttribute("UpdateSource")]
		[Bindable(true)]
		public string UpdateSource 
		{
			get { return GetColumnValue<string>(Columns.UpdateSource); }
			set { SetColumnValue(Columns.UpdateSource, value); }
		}
		  
		[XmlAttribute("UpdateTime")]
		[Bindable(true)]
		public DateTime? UpdateTime 
		{
			get { return GetColumnValue<DateTime?>(Columns.UpdateTime); }
			set { SetColumnValue(Columns.UpdateTime, value); }
		}
		
		#endregion
		
		
			
		
		//no foreign key tables defined (0)
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(string varModelType,string varFlag,string varUpdateSource,DateTime? varUpdateTime)
		{
			HljtTaskList item = new HljtTaskList();
			
			item.ModelType = varModelType;
			
			item.Flag = varFlag;
			
			item.UpdateSource = varUpdateSource;
			
			item.UpdateTime = varUpdateTime;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(string varModelType,string varFlag,string varUpdateSource,DateTime? varUpdateTime)
		{
			HljtTaskList item = new HljtTaskList();
			
				item.ModelType = varModelType;
			
				item.Flag = varFlag;
			
				item.UpdateSource = varUpdateSource;
			
				item.UpdateTime = varUpdateTime;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn ModelTypeColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn FlagColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        public static TableSchema.TableColumn UpdateSourceColumn
        {
            get { return Schema.Columns[2]; }
        }
        
        
        
        public static TableSchema.TableColumn UpdateTimeColumn
        {
            get { return Schema.Columns[3]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string ModelType = @"ModelType";
			 public static string Flag = @"Flag";
			 public static string UpdateSource = @"UpdateSource";
			 public static string UpdateTime = @"UpdateTime";
						
		}
		#endregion
		
		#region Update PK Collections
		
        #endregion
    
        #region Deep Save
		
        #endregion
	}
}
