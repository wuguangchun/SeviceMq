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
	/// Strongly-typed collection for the TBom class.
	/// </summary>
    [Serializable]
	public partial class TBomCollection : ActiveList<TBom, TBomCollection>
	{	   
		public TBomCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>TBomCollection</returns>
		public TBomCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                TBom o = this[i];
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
	/// This is an ActiveRecord class which wraps the T_BOM table.
	/// </summary>
	[Serializable]
	public partial class TBom : ActiveRecord<TBom>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public TBom()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public TBom(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public TBom(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public TBom(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("T_BOM", TableType.Table, DataService.GetInstance("Nowthwin"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarId = new TableSchema.TableColumn(schema);
				colvarId.ColumnName = "id";
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
				
				TableSchema.TableColumn colvarItems = new TableSchema.TableColumn(schema);
				colvarItems.ColumnName = "Items";
				colvarItems.DataType = DbType.String;
				colvarItems.MaxLength = 250;
				colvarItems.AutoIncrement = false;
				colvarItems.IsNullable = true;
				colvarItems.IsPrimaryKey = false;
				colvarItems.IsForeignKey = false;
				colvarItems.IsReadOnly = false;
				colvarItems.DefaultSetting = @"";
				colvarItems.ForeignKeyTableName = "";
				schema.Columns.Add(colvarItems);
				
				TableSchema.TableColumn colvarPronumber = new TableSchema.TableColumn(schema);
				colvarPronumber.ColumnName = "Pronumber";
				colvarPronumber.DataType = DbType.String;
				colvarPronumber.MaxLength = 250;
				colvarPronumber.AutoIncrement = false;
				colvarPronumber.IsNullable = true;
				colvarPronumber.IsPrimaryKey = false;
				colvarPronumber.IsForeignKey = false;
				colvarPronumber.IsReadOnly = false;
				colvarPronumber.DefaultSetting = @"";
				colvarPronumber.ForeignKeyTableName = "";
				schema.Columns.Add(colvarPronumber);
				
				TableSchema.TableColumn colvarProcode = new TableSchema.TableColumn(schema);
				colvarProcode.ColumnName = "Procode";
				colvarProcode.DataType = DbType.String;
				colvarProcode.MaxLength = 250;
				colvarProcode.AutoIncrement = false;
				colvarProcode.IsNullable = true;
				colvarProcode.IsPrimaryKey = false;
				colvarProcode.IsForeignKey = false;
				colvarProcode.IsReadOnly = false;
				colvarProcode.DefaultSetting = @"";
				colvarProcode.ForeignKeyTableName = "";
				schema.Columns.Add(colvarProcode);
				
				TableSchema.TableColumn colvarInstrutype = new TableSchema.TableColumn(schema);
				colvarInstrutype.ColumnName = "Instrutype";
				colvarInstrutype.DataType = DbType.String;
				colvarInstrutype.MaxLength = 250;
				colvarInstrutype.AutoIncrement = false;
				colvarInstrutype.IsNullable = true;
				colvarInstrutype.IsPrimaryKey = false;
				colvarInstrutype.IsForeignKey = false;
				colvarInstrutype.IsReadOnly = false;
				colvarInstrutype.DefaultSetting = @"";
				colvarInstrutype.ForeignKeyTableName = "";
				schema.Columns.Add(colvarInstrutype);
				
				TableSchema.TableColumn colvarInstrucode = new TableSchema.TableColumn(schema);
				colvarInstrucode.ColumnName = "Instrucode";
				colvarInstrucode.DataType = DbType.String;
				colvarInstrucode.MaxLength = 250;
				colvarInstrucode.AutoIncrement = false;
				colvarInstrucode.IsNullable = true;
				colvarInstrucode.IsPrimaryKey = false;
				colvarInstrucode.IsForeignKey = false;
				colvarInstrucode.IsReadOnly = false;
				colvarInstrucode.DefaultSetting = @"";
				colvarInstrucode.ForeignKeyTableName = "";
				schema.Columns.Add(colvarInstrucode);
				
				TableSchema.TableColumn colvarResource = new TableSchema.TableColumn(schema);
				colvarResource.ColumnName = "Resource";
				colvarResource.DataType = DbType.String;
				colvarResource.MaxLength = 250;
				colvarResource.AutoIncrement = false;
				colvarResource.IsNullable = true;
				colvarResource.IsPrimaryKey = false;
				colvarResource.IsForeignKey = false;
				colvarResource.IsReadOnly = false;
				colvarResource.DefaultSetting = @"";
				colvarResource.ForeignKeyTableName = "";
				schema.Columns.Add(colvarResource);
				
				TableSchema.TableColumn colvarAbility = new TableSchema.TableColumn(schema);
				colvarAbility.ColumnName = "Ability";
				colvarAbility.DataType = DbType.String;
				colvarAbility.MaxLength = 250;
				colvarAbility.AutoIncrement = false;
				colvarAbility.IsNullable = true;
				colvarAbility.IsPrimaryKey = false;
				colvarAbility.IsForeignKey = false;
				colvarAbility.IsReadOnly = false;
				colvarAbility.DefaultSetting = @"";
				colvarAbility.ForeignKeyTableName = "";
				schema.Columns.Add(colvarAbility);
				
				TableSchema.TableColumn colvarPriority = new TableSchema.TableColumn(schema);
				colvarPriority.ColumnName = "Priority";
				colvarPriority.DataType = DbType.String;
				colvarPriority.MaxLength = 250;
				colvarPriority.AutoIncrement = false;
				colvarPriority.IsNullable = true;
				colvarPriority.IsPrimaryKey = false;
				colvarPriority.IsForeignKey = false;
				colvarPriority.IsReadOnly = false;
				colvarPriority.DefaultSetting = @"";
				colvarPriority.ForeignKeyTableName = "";
				schema.Columns.Add(colvarPriority);
				
				TableSchema.TableColumn colvarModeltype = new TableSchema.TableColumn(schema);
				colvarModeltype.ColumnName = "Modeltype";
				colvarModeltype.DataType = DbType.String;
				colvarModeltype.MaxLength = 250;
				colvarModeltype.AutoIncrement = false;
				colvarModeltype.IsNullable = true;
				colvarModeltype.IsPrimaryKey = false;
				colvarModeltype.IsForeignKey = false;
				colvarModeltype.IsReadOnly = false;
				colvarModeltype.DefaultSetting = @"";
				colvarModeltype.ForeignKeyTableName = "";
				schema.Columns.Add(colvarModeltype);
				
				TableSchema.TableColumn colvarPlaincapacity = new TableSchema.TableColumn(schema);
				colvarPlaincapacity.ColumnName = "Plaincapacity";
				colvarPlaincapacity.DataType = DbType.String;
				colvarPlaincapacity.MaxLength = 250;
				colvarPlaincapacity.AutoIncrement = false;
				colvarPlaincapacity.IsNullable = true;
				colvarPlaincapacity.IsPrimaryKey = false;
				colvarPlaincapacity.IsForeignKey = false;
				colvarPlaincapacity.IsReadOnly = false;
				colvarPlaincapacity.DefaultSetting = @"";
				colvarPlaincapacity.ForeignKeyTableName = "";
				schema.Columns.Add(colvarPlaincapacity);
				
				TableSchema.TableColumn colvarEffective = new TableSchema.TableColumn(schema);
				colvarEffective.ColumnName = "effective";
				colvarEffective.DataType = DbType.String;
				colvarEffective.MaxLength = 250;
				colvarEffective.AutoIncrement = false;
				colvarEffective.IsNullable = true;
				colvarEffective.IsPrimaryKey = false;
				colvarEffective.IsForeignKey = false;
				colvarEffective.IsReadOnly = false;
				colvarEffective.DefaultSetting = @"";
				colvarEffective.ForeignKeyTableName = "";
				schema.Columns.Add(colvarEffective);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["Nowthwin"].AddSchema("T_BOM",schema);
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
		  
		[XmlAttribute("Items")]
		[Bindable(true)]
		public string Items 
		{
			get { return GetColumnValue<string>(Columns.Items); }
			set { SetColumnValue(Columns.Items, value); }
		}
		  
		[XmlAttribute("Pronumber")]
		[Bindable(true)]
		public string Pronumber 
		{
			get { return GetColumnValue<string>(Columns.Pronumber); }
			set { SetColumnValue(Columns.Pronumber, value); }
		}
		  
		[XmlAttribute("Procode")]
		[Bindable(true)]
		public string Procode 
		{
			get { return GetColumnValue<string>(Columns.Procode); }
			set { SetColumnValue(Columns.Procode, value); }
		}
		  
		[XmlAttribute("Instrutype")]
		[Bindable(true)]
		public string Instrutype 
		{
			get { return GetColumnValue<string>(Columns.Instrutype); }
			set { SetColumnValue(Columns.Instrutype, value); }
		}
		  
		[XmlAttribute("Instrucode")]
		[Bindable(true)]
		public string Instrucode 
		{
			get { return GetColumnValue<string>(Columns.Instrucode); }
			set { SetColumnValue(Columns.Instrucode, value); }
		}
		  
		[XmlAttribute("Resource")]
		[Bindable(true)]
		public string Resource 
		{
			get { return GetColumnValue<string>(Columns.Resource); }
			set { SetColumnValue(Columns.Resource, value); }
		}
		  
		[XmlAttribute("Ability")]
		[Bindable(true)]
		public string Ability 
		{
			get { return GetColumnValue<string>(Columns.Ability); }
			set { SetColumnValue(Columns.Ability, value); }
		}
		  
		[XmlAttribute("Priority")]
		[Bindable(true)]
		public string Priority 
		{
			get { return GetColumnValue<string>(Columns.Priority); }
			set { SetColumnValue(Columns.Priority, value); }
		}
		  
		[XmlAttribute("Modeltype")]
		[Bindable(true)]
		public string Modeltype 
		{
			get { return GetColumnValue<string>(Columns.Modeltype); }
			set { SetColumnValue(Columns.Modeltype, value); }
		}
		  
		[XmlAttribute("Plaincapacity")]
		[Bindable(true)]
		public string Plaincapacity 
		{
			get { return GetColumnValue<string>(Columns.Plaincapacity); }
			set { SetColumnValue(Columns.Plaincapacity, value); }
		}
		  
		[XmlAttribute("Effective")]
		[Bindable(true)]
		public string Effective 
		{
			get { return GetColumnValue<string>(Columns.Effective); }
			set { SetColumnValue(Columns.Effective, value); }
		}
		
		#endregion
		
		
			
		
		//no foreign key tables defined (0)
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(string varItems,string varPronumber,string varProcode,string varInstrutype,string varInstrucode,string varResource,string varAbility,string varPriority,string varModeltype,string varPlaincapacity,string varEffective)
		{
			TBom item = new TBom();
			
			item.Items = varItems;
			
			item.Pronumber = varPronumber;
			
			item.Procode = varProcode;
			
			item.Instrutype = varInstrutype;
			
			item.Instrucode = varInstrucode;
			
			item.Resource = varResource;
			
			item.Ability = varAbility;
			
			item.Priority = varPriority;
			
			item.Modeltype = varModeltype;
			
			item.Plaincapacity = varPlaincapacity;
			
			item.Effective = varEffective;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varId,string varItems,string varPronumber,string varProcode,string varInstrutype,string varInstrucode,string varResource,string varAbility,string varPriority,string varModeltype,string varPlaincapacity,string varEffective)
		{
			TBom item = new TBom();
			
				item.Id = varId;
			
				item.Items = varItems;
			
				item.Pronumber = varPronumber;
			
				item.Procode = varProcode;
			
				item.Instrutype = varInstrutype;
			
				item.Instrucode = varInstrucode;
			
				item.Resource = varResource;
			
				item.Ability = varAbility;
			
				item.Priority = varPriority;
			
				item.Modeltype = varModeltype;
			
				item.Plaincapacity = varPlaincapacity;
			
				item.Effective = varEffective;
			
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
        
        
        
        public static TableSchema.TableColumn ItemsColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        public static TableSchema.TableColumn PronumberColumn
        {
            get { return Schema.Columns[2]; }
        }
        
        
        
        public static TableSchema.TableColumn ProcodeColumn
        {
            get { return Schema.Columns[3]; }
        }
        
        
        
        public static TableSchema.TableColumn InstrutypeColumn
        {
            get { return Schema.Columns[4]; }
        }
        
        
        
        public static TableSchema.TableColumn InstrucodeColumn
        {
            get { return Schema.Columns[5]; }
        }
        
        
        
        public static TableSchema.TableColumn ResourceColumn
        {
            get { return Schema.Columns[6]; }
        }
        
        
        
        public static TableSchema.TableColumn AbilityColumn
        {
            get { return Schema.Columns[7]; }
        }
        
        
        
        public static TableSchema.TableColumn PriorityColumn
        {
            get { return Schema.Columns[8]; }
        }
        
        
        
        public static TableSchema.TableColumn ModeltypeColumn
        {
            get { return Schema.Columns[9]; }
        }
        
        
        
        public static TableSchema.TableColumn PlaincapacityColumn
        {
            get { return Schema.Columns[10]; }
        }
        
        
        
        public static TableSchema.TableColumn EffectiveColumn
        {
            get { return Schema.Columns[11]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string Id = @"id";
			 public static string Items = @"Items";
			 public static string Pronumber = @"Pronumber";
			 public static string Procode = @"Procode";
			 public static string Instrutype = @"Instrutype";
			 public static string Instrucode = @"Instrucode";
			 public static string Resource = @"Resource";
			 public static string Ability = @"Ability";
			 public static string Priority = @"Priority";
			 public static string Modeltype = @"Modeltype";
			 public static string Plaincapacity = @"Plaincapacity";
			 public static string Effective = @"effective";
						
		}
		#endregion
		
		#region Update PK Collections
		
        #endregion
    
        #region Deep Save
		
        #endregion
	}
}
