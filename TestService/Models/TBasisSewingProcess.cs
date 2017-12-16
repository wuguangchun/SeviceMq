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
namespace APSData
{
	/// <summary>
	/// Strongly-typed collection for the TBasisSewingProcess class.
	/// </summary>
    [Serializable]
	public partial class TBasisSewingProcessCollection : ActiveList<TBasisSewingProcess, TBasisSewingProcessCollection>
	{	   
		public TBasisSewingProcessCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>TBasisSewingProcessCollection</returns>
		public TBasisSewingProcessCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                TBasisSewingProcess o = this[i];
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
	/// This is an ActiveRecord class which wraps the T_Basis_SewingProcess table.
	/// </summary>
	[Serializable]
	public partial class TBasisSewingProcess : ActiveRecord<TBasisSewingProcess>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public TBasisSewingProcess()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public TBasisSewingProcess(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public TBasisSewingProcess(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public TBasisSewingProcess(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("T_Basis_SewingProcess", TableType.Table, DataService.GetInstance("Nowthwin"));
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
				
				TableSchema.TableColumn colvarCodeType = new TableSchema.TableColumn(schema);
				colvarCodeType.ColumnName = "CodeType";
				colvarCodeType.DataType = DbType.String;
				colvarCodeType.MaxLength = 50;
				colvarCodeType.AutoIncrement = false;
				colvarCodeType.IsNullable = true;
				colvarCodeType.IsPrimaryKey = false;
				colvarCodeType.IsForeignKey = false;
				colvarCodeType.IsReadOnly = false;
				colvarCodeType.DefaultSetting = @"";
				colvarCodeType.ForeignKeyTableName = "";
				schema.Columns.Add(colvarCodeType);
				
				TableSchema.TableColumn colvarShortX = new TableSchema.TableColumn(schema);
				colvarShortX.ColumnName = "Short";
				colvarShortX.DataType = DbType.Int32;
				colvarShortX.MaxLength = 0;
				colvarShortX.AutoIncrement = false;
				colvarShortX.IsNullable = true;
				colvarShortX.IsPrimaryKey = false;
				colvarShortX.IsForeignKey = false;
				colvarShortX.IsReadOnly = false;
				colvarShortX.DefaultSetting = @"";
				colvarShortX.ForeignKeyTableName = "";
				schema.Columns.Add(colvarShortX);
				
				TableSchema.TableColumn colvarProcedure = new TableSchema.TableColumn(schema);
				colvarProcedure.ColumnName = "Procedure";
				colvarProcedure.DataType = DbType.String;
				colvarProcedure.MaxLength = 50;
				colvarProcedure.AutoIncrement = false;
				colvarProcedure.IsNullable = true;
				colvarProcedure.IsPrimaryKey = false;
				colvarProcedure.IsForeignKey = false;
				colvarProcedure.IsReadOnly = false;
				colvarProcedure.DefaultSetting = @"";
				colvarProcedure.ForeignKeyTableName = "";
				schema.Columns.Add(colvarProcedure);
				
				TableSchema.TableColumn colvarIsCrux = new TableSchema.TableColumn(schema);
				colvarIsCrux.ColumnName = "IsCrux";
				colvarIsCrux.DataType = DbType.Int32;
				colvarIsCrux.MaxLength = 0;
				colvarIsCrux.AutoIncrement = false;
				colvarIsCrux.IsNullable = true;
				colvarIsCrux.IsPrimaryKey = false;
				colvarIsCrux.IsForeignKey = false;
				colvarIsCrux.IsReadOnly = false;
				colvarIsCrux.DefaultSetting = @"";
				colvarIsCrux.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIsCrux);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["Nowthwin"].AddSchema("T_Basis_SewingProcess",schema);
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
		  
		[XmlAttribute("CodeType")]
		[Bindable(true)]
		public string CodeType 
		{
			get { return GetColumnValue<string>(Columns.CodeType); }
			set { SetColumnValue(Columns.CodeType, value); }
		}
		  
		[XmlAttribute("ShortX")]
		[Bindable(true)]
		public int? ShortX 
		{
			get { return GetColumnValue<int?>(Columns.ShortX); }
			set { SetColumnValue(Columns.ShortX, value); }
		}
		  
		[XmlAttribute("Procedure")]
		[Bindable(true)]
		public string Procedure 
		{
			get { return GetColumnValue<string>(Columns.Procedure); }
			set { SetColumnValue(Columns.Procedure, value); }
		}
		  
		[XmlAttribute("IsCrux")]
		[Bindable(true)]
		public int? IsCrux 
		{
			get { return GetColumnValue<int?>(Columns.IsCrux); }
			set { SetColumnValue(Columns.IsCrux, value); }
		}
		
		#endregion
		
		
			
		
		//no foreign key tables defined (0)
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(string varCodeType,int? varShortX,string varProcedure,int? varIsCrux)
		{
			TBasisSewingProcess item = new TBasisSewingProcess();
			
			item.CodeType = varCodeType;
			
			item.ShortX = varShortX;
			
			item.Procedure = varProcedure;
			
			item.IsCrux = varIsCrux;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varId,string varCodeType,int? varShortX,string varProcedure,int? varIsCrux)
		{
			TBasisSewingProcess item = new TBasisSewingProcess();
			
				item.Id = varId;
			
				item.CodeType = varCodeType;
			
				item.ShortX = varShortX;
			
				item.Procedure = varProcedure;
			
				item.IsCrux = varIsCrux;
			
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
        
        
        
        public static TableSchema.TableColumn CodeTypeColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        public static TableSchema.TableColumn ShortXColumn
        {
            get { return Schema.Columns[2]; }
        }
        
        
        
        public static TableSchema.TableColumn ProcedureColumn
        {
            get { return Schema.Columns[3]; }
        }
        
        
        
        public static TableSchema.TableColumn IsCruxColumn
        {
            get { return Schema.Columns[4]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string Id = @"ID";
			 public static string CodeType = @"CodeType";
			 public static string ShortX = @"Short";
			 public static string Procedure = @"Procedure";
			 public static string IsCrux = @"IsCrux";
						
		}
		#endregion
		
		#region Update PK Collections
		
        #endregion
    
        #region Deep Save
		
        #endregion
	}
}