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
	/// Strongly-typed collection for the TOrderMESArtInfo class.
	/// </summary>
    [Serializable]
	public partial class TOrderMESArtInfoCollection : ActiveList<TOrderMESArtInfo, TOrderMESArtInfoCollection>
	{	   
		public TOrderMESArtInfoCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>TOrderMESArtInfoCollection</returns>
		public TOrderMESArtInfoCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                TOrderMESArtInfo o = this[i];
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
	/// This is an ActiveRecord class which wraps the T_OrderMESArtInfo table.
	/// </summary>
	[Serializable]
	public partial class TOrderMESArtInfo : ActiveRecord<TOrderMESArtInfo>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public TOrderMESArtInfo()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public TOrderMESArtInfo(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public TOrderMESArtInfo(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public TOrderMESArtInfo(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("T_OrderMESArtInfo", TableType.Table, DataService.GetInstance("Nowthwin"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarMxId = new TableSchema.TableColumn(schema);
				colvarMxId.ColumnName = "MxId";
				colvarMxId.DataType = DbType.Int32;
				colvarMxId.MaxLength = 0;
				colvarMxId.AutoIncrement = false;
				colvarMxId.IsNullable = false;
				colvarMxId.IsPrimaryKey = true;
				colvarMxId.IsForeignKey = false;
				colvarMxId.IsReadOnly = false;
				colvarMxId.DefaultSetting = @"";
				colvarMxId.ForeignKeyTableName = "";
				schema.Columns.Add(colvarMxId);
				
				TableSchema.TableColumn colvarCode = new TableSchema.TableColumn(schema);
				colvarCode.ColumnName = "Code";
				colvarCode.DataType = DbType.String;
				colvarCode.MaxLength = 32;
				colvarCode.AutoIncrement = false;
				colvarCode.IsNullable = false;
				colvarCode.IsPrimaryKey = true;
				colvarCode.IsForeignKey = false;
				colvarCode.IsReadOnly = false;
				colvarCode.DefaultSetting = @"";
				colvarCode.ForeignKeyTableName = "";
				schema.Columns.Add(colvarCode);
				
				TableSchema.TableColumn colvarHour = new TableSchema.TableColumn(schema);
				colvarHour.ColumnName = "Hour";
				colvarHour.DataType = DbType.Int32;
				colvarHour.MaxLength = 0;
				colvarHour.AutoIncrement = false;
				colvarHour.IsNullable = true;
				colvarHour.IsPrimaryKey = false;
				colvarHour.IsForeignKey = false;
				colvarHour.IsReadOnly = false;
				colvarHour.DefaultSetting = @"";
				colvarHour.ForeignKeyTableName = "";
				schema.Columns.Add(colvarHour);
				
				TableSchema.TableColumn colvarOrderArtslist = new TableSchema.TableColumn(schema);
				colvarOrderArtslist.ColumnName = "OrderArtslist";
				colvarOrderArtslist.DataType = DbType.String;
				colvarOrderArtslist.MaxLength = 1024;
				colvarOrderArtslist.AutoIncrement = false;
				colvarOrderArtslist.IsNullable = true;
				colvarOrderArtslist.IsPrimaryKey = false;
				colvarOrderArtslist.IsForeignKey = false;
				colvarOrderArtslist.IsReadOnly = false;
				colvarOrderArtslist.DefaultSetting = @"";
				colvarOrderArtslist.ForeignKeyTableName = "";
				schema.Columns.Add(colvarOrderArtslist);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["Nowthwin"].AddSchema("T_OrderMESArtInfo",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("MxId")]
		[Bindable(true)]
		public int MxId 
		{
			get { return GetColumnValue<int>(Columns.MxId); }
			set { SetColumnValue(Columns.MxId, value); }
		}
		  
		[XmlAttribute("Code")]
		[Bindable(true)]
		public string Code 
		{
			get { return GetColumnValue<string>(Columns.Code); }
			set { SetColumnValue(Columns.Code, value); }
		}
		  
		[XmlAttribute("Hour")]
		[Bindable(true)]
		public int? Hour 
		{
			get { return GetColumnValue<int?>(Columns.Hour); }
			set { SetColumnValue(Columns.Hour, value); }
		}
		  
		[XmlAttribute("OrderArtslist")]
		[Bindable(true)]
		public string OrderArtslist 
		{
			get { return GetColumnValue<string>(Columns.OrderArtslist); }
			set { SetColumnValue(Columns.OrderArtslist, value); }
		}
		
		#endregion
		
		
			
		
		//no foreign key tables defined (0)
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(int varMxId,string varCode,int? varHour,string varOrderArtslist)
		{
			TOrderMESArtInfo item = new TOrderMESArtInfo();
			
			item.MxId = varMxId;
			
			item.Code = varCode;
			
			item.Hour = varHour;
			
			item.OrderArtslist = varOrderArtslist;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varMxId,string varCode,int? varHour,string varOrderArtslist)
		{
			TOrderMESArtInfo item = new TOrderMESArtInfo();
			
				item.MxId = varMxId;
			
				item.Code = varCode;
			
				item.Hour = varHour;
			
				item.OrderArtslist = varOrderArtslist;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn MxIdColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn CodeColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        public static TableSchema.TableColumn HourColumn
        {
            get { return Schema.Columns[2]; }
        }
        
        
        
        public static TableSchema.TableColumn OrderArtslistColumn
        {
            get { return Schema.Columns[3]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string MxId = @"MxId";
			 public static string Code = @"Code";
			 public static string Hour = @"Hour";
			 public static string OrderArtslist = @"OrderArtslist";
						
		}
		#endregion
		
		#region Update PK Collections
		
        #endregion
    
        #region Deep Save
		
        #endregion
	}
}
