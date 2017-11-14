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
	/// Strongly-typed collection for the TUsersInfo class.
	/// </summary>
    [Serializable]
	public partial class TUsersInfoCollection : ActiveList<TUsersInfo, TUsersInfoCollection>
	{	   
		public TUsersInfoCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>TUsersInfoCollection</returns>
		public TUsersInfoCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                TUsersInfo o = this[i];
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
	/// This is an ActiveRecord class which wraps the T_UsersInfo table.
	/// </summary>
	[Serializable]
	public partial class TUsersInfo : ActiveRecord<TUsersInfo>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public TUsersInfo()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public TUsersInfo(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public TUsersInfo(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public TUsersInfo(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("T_UsersInfo", TableType.Table, DataService.GetInstance("Nowthwin"));
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
				
				TableSchema.TableColumn colvarUserName = new TableSchema.TableColumn(schema);
				colvarUserName.ColumnName = "userName";
				colvarUserName.DataType = DbType.String;
				colvarUserName.MaxLength = 255;
				colvarUserName.AutoIncrement = false;
				colvarUserName.IsNullable = false;
				colvarUserName.IsPrimaryKey = true;
				colvarUserName.IsForeignKey = false;
				colvarUserName.IsReadOnly = false;
				colvarUserName.DefaultSetting = @"";
				colvarUserName.ForeignKeyTableName = "";
				schema.Columns.Add(colvarUserName);
				
				TableSchema.TableColumn colvarUserPwd = new TableSchema.TableColumn(schema);
				colvarUserPwd.ColumnName = "userPwd";
				colvarUserPwd.DataType = DbType.String;
				colvarUserPwd.MaxLength = 255;
				colvarUserPwd.AutoIncrement = false;
				colvarUserPwd.IsNullable = true;
				colvarUserPwd.IsPrimaryKey = false;
				colvarUserPwd.IsForeignKey = false;
				colvarUserPwd.IsReadOnly = false;
				colvarUserPwd.DefaultSetting = @"";
				colvarUserPwd.ForeignKeyTableName = "";
				schema.Columns.Add(colvarUserPwd);
				
				TableSchema.TableColumn colvarIsLock = new TableSchema.TableColumn(schema);
				colvarIsLock.ColumnName = "IsLock";
				colvarIsLock.DataType = DbType.Int32;
				colvarIsLock.MaxLength = 0;
				colvarIsLock.AutoIncrement = false;
				colvarIsLock.IsNullable = true;
				colvarIsLock.IsPrimaryKey = false;
				colvarIsLock.IsForeignKey = false;
				colvarIsLock.IsReadOnly = false;
				colvarIsLock.DefaultSetting = @"";
				colvarIsLock.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIsLock);
				
				TableSchema.TableColumn colvarLoginLastTime = new TableSchema.TableColumn(schema);
				colvarLoginLastTime.ColumnName = "LoginLastTime";
				colvarLoginLastTime.DataType = DbType.DateTime;
				colvarLoginLastTime.MaxLength = 0;
				colvarLoginLastTime.AutoIncrement = false;
				colvarLoginLastTime.IsNullable = true;
				colvarLoginLastTime.IsPrimaryKey = false;
				colvarLoginLastTime.IsForeignKey = false;
				colvarLoginLastTime.IsReadOnly = false;
				colvarLoginLastTime.DefaultSetting = @"";
				colvarLoginLastTime.ForeignKeyTableName = "";
				schema.Columns.Add(colvarLoginLastTime);
				
				TableSchema.TableColumn colvarMenberType = new TableSchema.TableColumn(schema);
				colvarMenberType.ColumnName = "MenberType";
				colvarMenberType.DataType = DbType.String;
				colvarMenberType.MaxLength = 255;
				colvarMenberType.AutoIncrement = false;
				colvarMenberType.IsNullable = true;
				colvarMenberType.IsPrimaryKey = false;
				colvarMenberType.IsForeignKey = false;
				colvarMenberType.IsReadOnly = false;
				colvarMenberType.DefaultSetting = @"";
				colvarMenberType.ForeignKeyTableName = "";
				schema.Columns.Add(colvarMenberType);
				
				TableSchema.TableColumn colvarHavingPage = new TableSchema.TableColumn(schema);
				colvarHavingPage.ColumnName = "HavingPage";
				colvarHavingPage.DataType = DbType.String;
				colvarHavingPage.MaxLength = 255;
				colvarHavingPage.AutoIncrement = false;
				colvarHavingPage.IsNullable = true;
				colvarHavingPage.IsPrimaryKey = false;
				colvarHavingPage.IsForeignKey = false;
				colvarHavingPage.IsReadOnly = false;
				colvarHavingPage.DefaultSetting = @"";
				colvarHavingPage.ForeignKeyTableName = "";
				schema.Columns.Add(colvarHavingPage);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["Nowthwin"].AddSchema("T_UsersInfo",schema);
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
		  
		[XmlAttribute("UserName")]
		[Bindable(true)]
		public string UserName 
		{
			get { return GetColumnValue<string>(Columns.UserName); }
			set { SetColumnValue(Columns.UserName, value); }
		}
		  
		[XmlAttribute("UserPwd")]
		[Bindable(true)]
		public string UserPwd 
		{
			get { return GetColumnValue<string>(Columns.UserPwd); }
			set { SetColumnValue(Columns.UserPwd, value); }
		}
		  
		[XmlAttribute("IsLock")]
		[Bindable(true)]
		public int? IsLock 
		{
			get { return GetColumnValue<int?>(Columns.IsLock); }
			set { SetColumnValue(Columns.IsLock, value); }
		}
		  
		[XmlAttribute("LoginLastTime")]
		[Bindable(true)]
		public DateTime? LoginLastTime 
		{
			get { return GetColumnValue<DateTime?>(Columns.LoginLastTime); }
			set { SetColumnValue(Columns.LoginLastTime, value); }
		}
		  
		[XmlAttribute("MenberType")]
		[Bindable(true)]
		public string MenberType 
		{
			get { return GetColumnValue<string>(Columns.MenberType); }
			set { SetColumnValue(Columns.MenberType, value); }
		}
		  
		[XmlAttribute("HavingPage")]
		[Bindable(true)]
		public string HavingPage 
		{
			get { return GetColumnValue<string>(Columns.HavingPage); }
			set { SetColumnValue(Columns.HavingPage, value); }
		}
		
		#endregion
		
		
			
		
		//no foreign key tables defined (0)
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(string varUserName,string varUserPwd,int? varIsLock,DateTime? varLoginLastTime,string varMenberType,string varHavingPage)
		{
			TUsersInfo item = new TUsersInfo();
			
			item.UserName = varUserName;
			
			item.UserPwd = varUserPwd;
			
			item.IsLock = varIsLock;
			
			item.LoginLastTime = varLoginLastTime;
			
			item.MenberType = varMenberType;
			
			item.HavingPage = varHavingPage;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varId,string varUserName,string varUserPwd,int? varIsLock,DateTime? varLoginLastTime,string varMenberType,string varHavingPage)
		{
			TUsersInfo item = new TUsersInfo();
			
				item.Id = varId;
			
				item.UserName = varUserName;
			
				item.UserPwd = varUserPwd;
			
				item.IsLock = varIsLock;
			
				item.LoginLastTime = varLoginLastTime;
			
				item.MenberType = varMenberType;
			
				item.HavingPage = varHavingPage;
			
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
        
        
        
        public static TableSchema.TableColumn UserNameColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        public static TableSchema.TableColumn UserPwdColumn
        {
            get { return Schema.Columns[2]; }
        }
        
        
        
        public static TableSchema.TableColumn IsLockColumn
        {
            get { return Schema.Columns[3]; }
        }
        
        
        
        public static TableSchema.TableColumn LoginLastTimeColumn
        {
            get { return Schema.Columns[4]; }
        }
        
        
        
        public static TableSchema.TableColumn MenberTypeColumn
        {
            get { return Schema.Columns[5]; }
        }
        
        
        
        public static TableSchema.TableColumn HavingPageColumn
        {
            get { return Schema.Columns[6]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string Id = @"id";
			 public static string UserName = @"userName";
			 public static string UserPwd = @"userPwd";
			 public static string IsLock = @"IsLock";
			 public static string LoginLastTime = @"LoginLastTime";
			 public static string MenberType = @"MenberType";
			 public static string HavingPage = @"HavingPage";
						
		}
		#endregion
		
		#region Update PK Collections
		
        #endregion
    
        #region Deep Save
		
        #endregion
	}
}
