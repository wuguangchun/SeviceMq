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
	/// Strongly-typed collection for the TAnalysisOrderMx class.
	/// </summary>
    [Serializable]
	public partial class TAnalysisOrderMxCollection : ActiveList<TAnalysisOrderMx, TAnalysisOrderMxCollection>
	{	   
		public TAnalysisOrderMxCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>TAnalysisOrderMxCollection</returns>
		public TAnalysisOrderMxCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                TAnalysisOrderMx o = this[i];
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
	/// This is an ActiveRecord class which wraps the T_Analysis_OrderMx table.
	/// </summary>
	[Serializable]
	public partial class TAnalysisOrderMx : ActiveRecord<TAnalysisOrderMx>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public TAnalysisOrderMx()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public TAnalysisOrderMx(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public TAnalysisOrderMx(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public TAnalysisOrderMx(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("T_Analysis_OrderMx", TableType.Table, DataService.GetInstance("Nowthwin"));
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
				
				TableSchema.TableColumn colvarKhdh = new TableSchema.TableColumn(schema);
				colvarKhdh.ColumnName = "Khdh";
				colvarKhdh.DataType = DbType.String;
				colvarKhdh.MaxLength = 100;
				colvarKhdh.AutoIncrement = false;
				colvarKhdh.IsNullable = true;
				colvarKhdh.IsPrimaryKey = false;
				colvarKhdh.IsForeignKey = false;
				colvarKhdh.IsReadOnly = false;
				colvarKhdh.DefaultSetting = @"";
				colvarKhdh.ForeignKeyTableName = "";
				schema.Columns.Add(colvarKhdh);
				
				TableSchema.TableColumn colvarSpecialCode = new TableSchema.TableColumn(schema);
				colvarSpecialCode.ColumnName = "SpecialCode";
				colvarSpecialCode.DataType = DbType.String;
				colvarSpecialCode.MaxLength = -1;
				colvarSpecialCode.AutoIncrement = false;
				colvarSpecialCode.IsNullable = true;
				colvarSpecialCode.IsPrimaryKey = false;
				colvarSpecialCode.IsForeignKey = false;
				colvarSpecialCode.IsReadOnly = false;
				colvarSpecialCode.DefaultSetting = @"";
				colvarSpecialCode.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSpecialCode);
				
				TableSchema.TableColumn colvarFzfl = new TableSchema.TableColumn(schema);
				colvarFzfl.ColumnName = "Fzfl";
				colvarFzfl.DataType = DbType.String;
				colvarFzfl.MaxLength = 255;
				colvarFzfl.AutoIncrement = false;
				colvarFzfl.IsNullable = true;
				colvarFzfl.IsPrimaryKey = false;
				colvarFzfl.IsForeignKey = false;
				colvarFzfl.IsReadOnly = false;
				colvarFzfl.DefaultSetting = @"";
				colvarFzfl.ForeignKeyTableName = "";
				schema.Columns.Add(colvarFzfl);
				
				TableSchema.TableColumn colvarScjhbz = new TableSchema.TableColumn(schema);
				colvarScjhbz.ColumnName = "SCJHBZ";
				colvarScjhbz.DataType = DbType.String;
				colvarScjhbz.MaxLength = 100;
				colvarScjhbz.AutoIncrement = false;
				colvarScjhbz.IsNullable = true;
				colvarScjhbz.IsPrimaryKey = false;
				colvarScjhbz.IsForeignKey = false;
				colvarScjhbz.IsReadOnly = false;
				colvarScjhbz.DefaultSetting = @"";
				colvarScjhbz.ForeignKeyTableName = "";
				schema.Columns.Add(colvarScjhbz);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["Nowthwin"].AddSchema("T_Analysis_OrderMx",schema);
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
		  
		[XmlAttribute("Khdh")]
		[Bindable(true)]
		public string Khdh 
		{
			get { return GetColumnValue<string>(Columns.Khdh); }
			set { SetColumnValue(Columns.Khdh, value); }
		}
		  
		[XmlAttribute("SpecialCode")]
		[Bindable(true)]
		public string SpecialCode 
		{
			get { return GetColumnValue<string>(Columns.SpecialCode); }
			set { SetColumnValue(Columns.SpecialCode, value); }
		}
		  
		[XmlAttribute("Fzfl")]
		[Bindable(true)]
		public string Fzfl 
		{
			get { return GetColumnValue<string>(Columns.Fzfl); }
			set { SetColumnValue(Columns.Fzfl, value); }
		}
		  
		[XmlAttribute("Scjhbz")]
		[Bindable(true)]
		public string Scjhbz 
		{
			get { return GetColumnValue<string>(Columns.Scjhbz); }
			set { SetColumnValue(Columns.Scjhbz, value); }
		}
		
		#endregion
		
		
			
		
		//no foreign key tables defined (0)
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(string varKhdh,string varSpecialCode,string varFzfl,string varScjhbz)
		{
			TAnalysisOrderMx item = new TAnalysisOrderMx();
			
			item.Khdh = varKhdh;
			
			item.SpecialCode = varSpecialCode;
			
			item.Fzfl = varFzfl;
			
			item.Scjhbz = varScjhbz;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varId,string varKhdh,string varSpecialCode,string varFzfl,string varScjhbz)
		{
			TAnalysisOrderMx item = new TAnalysisOrderMx();
			
				item.Id = varId;
			
				item.Khdh = varKhdh;
			
				item.SpecialCode = varSpecialCode;
			
				item.Fzfl = varFzfl;
			
				item.Scjhbz = varScjhbz;
			
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
        
        
        
        public static TableSchema.TableColumn KhdhColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        public static TableSchema.TableColumn SpecialCodeColumn
        {
            get { return Schema.Columns[2]; }
        }
        
        
        
        public static TableSchema.TableColumn FzflColumn
        {
            get { return Schema.Columns[3]; }
        }
        
        
        
        public static TableSchema.TableColumn ScjhbzColumn
        {
            get { return Schema.Columns[4]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string Id = @"ID";
			 public static string Khdh = @"Khdh";
			 public static string SpecialCode = @"SpecialCode";
			 public static string Fzfl = @"Fzfl";
			 public static string Scjhbz = @"SCJHBZ";
						
		}
		#endregion
		
		#region Update PK Collections
		
        #endregion
    
        #region Deep Save
		
        #endregion
	}
}
