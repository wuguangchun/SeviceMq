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
	/// Strongly-typed collection for the TBasisPlanTime class.
	/// </summary>
    [Serializable]
	public partial class TBasisPlanTimeCollection : ActiveList<TBasisPlanTime, TBasisPlanTimeCollection>
	{	   
		public TBasisPlanTimeCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>TBasisPlanTimeCollection</returns>
		public TBasisPlanTimeCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                TBasisPlanTime o = this[i];
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
	/// This is an ActiveRecord class which wraps the T_Basis_PlanTime table.
	/// </summary>
	[Serializable]
	public partial class TBasisPlanTime : ActiveRecord<TBasisPlanTime>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public TBasisPlanTime()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public TBasisPlanTime(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public TBasisPlanTime(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public TBasisPlanTime(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("T_Basis_PlanTime", TableType.Table, DataService.GetInstance("Nowthwin"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarId = new TableSchema.TableColumn(schema);
				colvarId.ColumnName = "ID";
				colvarId.DataType = DbType.Int32;
				colvarId.MaxLength = 0;
				colvarId.AutoIncrement = true;
				colvarId.IsNullable = false;
				colvarId.IsPrimaryKey = true;
				colvarId.IsForeignKey = false;
				colvarId.IsReadOnly = false;
				colvarId.DefaultSetting = @"";
				colvarId.ForeignKeyTableName = "";
				schema.Columns.Add(colvarId);
				
				TableSchema.TableColumn colvarSctcrq = new TableSchema.TableColumn(schema);
				colvarSctcrq.ColumnName = "Sctcrq";
				colvarSctcrq.DataType = DbType.DateTime;
				colvarSctcrq.MaxLength = 0;
				colvarSctcrq.AutoIncrement = false;
				colvarSctcrq.IsNullable = true;
				colvarSctcrq.IsPrimaryKey = false;
				colvarSctcrq.IsForeignKey = false;
				colvarSctcrq.IsReadOnly = false;
				colvarSctcrq.DefaultSetting = @"";
				colvarSctcrq.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSctcrq);
				
				TableSchema.TableColumn colvarState = new TableSchema.TableColumn(schema);
				colvarState.ColumnName = "state";
				colvarState.DataType = DbType.AnsiStringFixedLength;
				colvarState.MaxLength = 1;
				colvarState.AutoIncrement = false;
				colvarState.IsNullable = true;
				colvarState.IsPrimaryKey = false;
				colvarState.IsForeignKey = false;
				colvarState.IsReadOnly = false;
				
						colvarState.DefaultSetting = @"((0))";
				colvarState.ForeignKeyTableName = "";
				schema.Columns.Add(colvarState);
				
				TableSchema.TableColumn colvarCrateTime = new TableSchema.TableColumn(schema);
				colvarCrateTime.ColumnName = "CrateTime";
				colvarCrateTime.DataType = DbType.DateTime;
				colvarCrateTime.MaxLength = 0;
				colvarCrateTime.AutoIncrement = false;
				colvarCrateTime.IsNullable = true;
				colvarCrateTime.IsPrimaryKey = false;
				colvarCrateTime.IsForeignKey = false;
				colvarCrateTime.IsReadOnly = false;
				
						colvarCrateTime.DefaultSetting = @"(getdate())";
				colvarCrateTime.ForeignKeyTableName = "";
				schema.Columns.Add(colvarCrateTime);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["Nowthwin"].AddSchema("T_Basis_PlanTime",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("Id")]
		[Bindable(true)]
		public int Id 
		{
			get { return GetColumnValue<int>(Columns.Id); }
			set { SetColumnValue(Columns.Id, value); }
		}
		  
		[XmlAttribute("Sctcrq")]
		[Bindable(true)]
		public DateTime? Sctcrq 
		{
			get { return GetColumnValue<DateTime?>(Columns.Sctcrq); }
			set { SetColumnValue(Columns.Sctcrq, value); }
		}
		  
		[XmlAttribute("State")]
		[Bindable(true)]
		public string State 
		{
			get { return GetColumnValue<string>(Columns.State); }
			set { SetColumnValue(Columns.State, value); }
		}
		  
		[XmlAttribute("CrateTime")]
		[Bindable(true)]
		public DateTime? CrateTime 
		{
			get { return GetColumnValue<DateTime?>(Columns.CrateTime); }
			set { SetColumnValue(Columns.CrateTime, value); }
		}
		
		#endregion
		
		
			
		
		//no foreign key tables defined (0)
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(DateTime? varSctcrq,string varState,DateTime? varCrateTime)
		{
			TBasisPlanTime item = new TBasisPlanTime();
			
			item.Sctcrq = varSctcrq;
			
			item.State = varState;
			
			item.CrateTime = varCrateTime;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varId,DateTime? varSctcrq,string varState,DateTime? varCrateTime)
		{
			TBasisPlanTime item = new TBasisPlanTime();
			
				item.Id = varId;
			
				item.Sctcrq = varSctcrq;
			
				item.State = varState;
			
				item.CrateTime = varCrateTime;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn IdColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn SctcrqColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        public static TableSchema.TableColumn StateColumn
        {
            get { return Schema.Columns[2]; }
        }
        
        
        
        public static TableSchema.TableColumn CrateTimeColumn
        {
            get { return Schema.Columns[3]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string Id = @"ID";
			 public static string Sctcrq = @"Sctcrq";
			 public static string State = @"state";
			 public static string CrateTime = @"CrateTime";
						
		}
		#endregion
		
		#region Update PK Collections
		
        #endregion
    
        #region Deep Save
		
        #endregion
	}
}