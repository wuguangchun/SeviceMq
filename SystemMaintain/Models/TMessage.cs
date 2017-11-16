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
	/// Strongly-typed collection for the TMessage class.
	/// </summary>
    [Serializable]
	public partial class TMessageCollection : ActiveList<TMessage, TMessageCollection>
	{	   
		public TMessageCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>TMessageCollection</returns>
		public TMessageCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                TMessage o = this[i];
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
	/// This is an ActiveRecord class which wraps the T_Message table.
	/// </summary>
	[Serializable]
	public partial class TMessage : ActiveRecord<TMessage>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public TMessage()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public TMessage(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public TMessage(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public TMessage(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("T_Message", TableType.Table, DataService.GetInstance("Nowthwin"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarRunlevel = new TableSchema.TableColumn(schema);
				colvarRunlevel.ColumnName = "Runlevel";
				colvarRunlevel.DataType = DbType.String;
				colvarRunlevel.MaxLength = 250;
				colvarRunlevel.AutoIncrement = false;
				colvarRunlevel.IsNullable = true;
				colvarRunlevel.IsPrimaryKey = false;
				colvarRunlevel.IsForeignKey = false;
				colvarRunlevel.IsReadOnly = false;
				colvarRunlevel.DefaultSetting = @"";
				colvarRunlevel.ForeignKeyTableName = "";
				schema.Columns.Add(colvarRunlevel);
				
				TableSchema.TableColumn colvarMetype = new TableSchema.TableColumn(schema);
				colvarMetype.ColumnName = "Metype";
				colvarMetype.DataType = DbType.String;
				colvarMetype.MaxLength = 250;
				colvarMetype.AutoIncrement = false;
				colvarMetype.IsNullable = true;
				colvarMetype.IsPrimaryKey = false;
				colvarMetype.IsForeignKey = false;
				colvarMetype.IsReadOnly = false;
				colvarMetype.DefaultSetting = @"";
				colvarMetype.ForeignKeyTableName = "";
				schema.Columns.Add(colvarMetype);
				
				TableSchema.TableColumn colvarMecontent = new TableSchema.TableColumn(schema);
				colvarMecontent.ColumnName = "Mecontent";
				colvarMecontent.DataType = DbType.String;
				colvarMecontent.MaxLength = -1;
				colvarMecontent.AutoIncrement = false;
				colvarMecontent.IsNullable = true;
				colvarMecontent.IsPrimaryKey = false;
				colvarMecontent.IsForeignKey = false;
				colvarMecontent.IsReadOnly = false;
				colvarMecontent.DefaultSetting = @"";
				colvarMecontent.ForeignKeyTableName = "";
				schema.Columns.Add(colvarMecontent);
				
				TableSchema.TableColumn colvarMetime = new TableSchema.TableColumn(schema);
				colvarMetime.ColumnName = "Metime";
				colvarMetime.DataType = DbType.DateTime;
				colvarMetime.MaxLength = 0;
				colvarMetime.AutoIncrement = false;
				colvarMetime.IsNullable = true;
				colvarMetime.IsPrimaryKey = false;
				colvarMetime.IsForeignKey = false;
				colvarMetime.IsReadOnly = false;
				colvarMetime.DefaultSetting = @"";
				colvarMetime.ForeignKeyTableName = "";
				schema.Columns.Add(colvarMetime);
				
				TableSchema.TableColumn colvarId = new TableSchema.TableColumn(schema);
				colvarId.ColumnName = "Id";
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
				
				TableSchema.TableColumn colvarModeltype = new TableSchema.TableColumn(schema);
				colvarModeltype.ColumnName = "modeltype";
				colvarModeltype.DataType = DbType.String;
				colvarModeltype.MaxLength = 50;
				colvarModeltype.AutoIncrement = false;
				colvarModeltype.IsNullable = true;
				colvarModeltype.IsPrimaryKey = false;
				colvarModeltype.IsForeignKey = false;
				colvarModeltype.IsReadOnly = false;
				colvarModeltype.DefaultSetting = @"";
				colvarModeltype.ForeignKeyTableName = "";
				schema.Columns.Add(colvarModeltype);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["Nowthwin"].AddSchema("T_Message",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("Runlevel")]
		[Bindable(true)]
		public string Runlevel 
		{
			get { return GetColumnValue<string>(Columns.Runlevel); }
			set { SetColumnValue(Columns.Runlevel, value); }
		}
		  
		[XmlAttribute("Metype")]
		[Bindable(true)]
		public string Metype 
		{
			get { return GetColumnValue<string>(Columns.Metype); }
			set { SetColumnValue(Columns.Metype, value); }
		}
		  
		[XmlAttribute("Mecontent")]
		[Bindable(true)]
		public string Mecontent 
		{
			get { return GetColumnValue<string>(Columns.Mecontent); }
			set { SetColumnValue(Columns.Mecontent, value); }
		}
		  
		[XmlAttribute("Metime")]
		[Bindable(true)]
		public DateTime? Metime 
		{
			get { return GetColumnValue<DateTime?>(Columns.Metime); }
			set { SetColumnValue(Columns.Metime, value); }
		}
		  
		[XmlAttribute("Id")]
		[Bindable(true)]
		public int Id 
		{
			get { return GetColumnValue<int>(Columns.Id); }
			set { SetColumnValue(Columns.Id, value); }
		}
		  
		[XmlAttribute("Modeltype")]
		[Bindable(true)]
		public string Modeltype 
		{
			get { return GetColumnValue<string>(Columns.Modeltype); }
			set { SetColumnValue(Columns.Modeltype, value); }
		}
		
		#endregion
		
		
			
		
		//no foreign key tables defined (0)
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(string varRunlevel,string varMetype,string varMecontent,DateTime? varMetime,string varModeltype)
		{
			TMessage item = new TMessage();
			
			item.Runlevel = varRunlevel;
			
			item.Metype = varMetype;
			
			item.Mecontent = varMecontent;
			
			item.Metime = varMetime;
			
			item.Modeltype = varModeltype;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(string varRunlevel,string varMetype,string varMecontent,DateTime? varMetime,int varId,string varModeltype)
		{
			TMessage item = new TMessage();
			
				item.Runlevel = varRunlevel;
			
				item.Metype = varMetype;
			
				item.Mecontent = varMecontent;
			
				item.Metime = varMetime;
			
				item.Id = varId;
			
				item.Modeltype = varModeltype;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn RunlevelColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn MetypeColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        public static TableSchema.TableColumn MecontentColumn
        {
            get { return Schema.Columns[2]; }
        }
        
        
        
        public static TableSchema.TableColumn MetimeColumn
        {
            get { return Schema.Columns[3]; }
        }
        
        
        
        public static TableSchema.TableColumn IdColumn
        {
            get { return Schema.Columns[4]; }
        }
        
        
        
        public static TableSchema.TableColumn ModeltypeColumn
        {
            get { return Schema.Columns[5]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string Runlevel = @"Runlevel";
			 public static string Metype = @"Metype";
			 public static string Mecontent = @"Mecontent";
			 public static string Metime = @"Metime";
			 public static string Id = @"Id";
			 public static string Modeltype = @"modeltype";
						
		}
		#endregion
		
		#region Update PK Collections
		
        #endregion
    
        #region Deep Save
		
        #endregion
	}
}
