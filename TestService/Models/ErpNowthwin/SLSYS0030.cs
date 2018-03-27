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
namespace OracleDataDomain
{
	/// <summary>
	/// Strongly-typed collection for the SLSYS0030 class.
	/// </summary>
    [Serializable]
	public partial class SLSYS0030Collection : ActiveList<SLSYS0030, SLSYS0030Collection>
	{	   
		public SLSYS0030Collection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>SLSYS0030Collection</returns>
		public SLSYS0030Collection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                SLSYS0030 o = this[i];
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
	/// This is an ActiveRecord class which wraps the SLSYS0030 table.
	/// </summary>
	[Serializable]
	public partial class SLSYS0030 : ActiveRecord<SLSYS0030>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public SLSYS0030()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public SLSYS0030(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public SLSYS0030(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public SLSYS0030(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("SLSYS0030", TableType.Table, DataService.GetInstance("ErpNowthwin"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"FYERP";
				//columns
				
				TableSchema.TableColumn colvarId = new TableSchema.TableColumn(schema);
				colvarId.ColumnName = "ID";
				colvarId.DataType = DbType.String;
				colvarId.MaxLength = 50;
				colvarId.AutoIncrement = false;
				colvarId.IsNullable = false;
				colvarId.IsPrimaryKey = true;
				colvarId.IsForeignKey = false;
				colvarId.IsReadOnly = false;
				colvarId.DefaultSetting = @"";
				colvarId.ForeignKeyTableName = "";
				schema.Columns.Add(colvarId);
				
				TableSchema.TableColumn colvarMenuSeqNo = new TableSchema.TableColumn(schema);
				colvarMenuSeqNo.ColumnName = "MENU_SEQ_NO";
				colvarMenuSeqNo.DataType = DbType.String;
				colvarMenuSeqNo.MaxLength = 20;
				colvarMenuSeqNo.AutoIncrement = false;
				colvarMenuSeqNo.IsNullable = true;
				colvarMenuSeqNo.IsPrimaryKey = false;
				colvarMenuSeqNo.IsForeignKey = false;
				colvarMenuSeqNo.IsReadOnly = false;
				colvarMenuSeqNo.DefaultSetting = @"";
				colvarMenuSeqNo.ForeignKeyTableName = "";
				schema.Columns.Add(colvarMenuSeqNo);
				
				TableSchema.TableColumn colvarMenuKey = new TableSchema.TableColumn(schema);
				colvarMenuKey.ColumnName = "MENU_KEY";
				colvarMenuKey.DataType = DbType.String;
				colvarMenuKey.MaxLength = 20;
				colvarMenuKey.AutoIncrement = false;
				colvarMenuKey.IsNullable = true;
				colvarMenuKey.IsPrimaryKey = false;
				colvarMenuKey.IsForeignKey = false;
				colvarMenuKey.IsReadOnly = false;
				colvarMenuKey.DefaultSetting = @"";
				colvarMenuKey.ForeignKeyTableName = "";
				schema.Columns.Add(colvarMenuKey);
				
				TableSchema.TableColumn colvarPart = new TableSchema.TableColumn(schema);
				colvarPart.ColumnName = "PART";
				colvarPart.DataType = DbType.String;
				colvarPart.MaxLength = 20;
				colvarPart.AutoIncrement = false;
				colvarPart.IsNullable = true;
				colvarPart.IsPrimaryKey = false;
				colvarPart.IsForeignKey = false;
				colvarPart.IsReadOnly = false;
				colvarPart.DefaultSetting = @"";
				colvarPart.ForeignKeyTableName = "";
				schema.Columns.Add(colvarPart);
				
				TableSchema.TableColumn colvarTitle = new TableSchema.TableColumn(schema);
				colvarTitle.ColumnName = "TITLE";
				colvarTitle.DataType = DbType.String;
				colvarTitle.MaxLength = 20;
				colvarTitle.AutoIncrement = false;
				colvarTitle.IsNullable = true;
				colvarTitle.IsPrimaryKey = false;
				colvarTitle.IsForeignKey = false;
				colvarTitle.IsReadOnly = false;
				colvarTitle.DefaultSetting = @"";
				colvarTitle.ForeignKeyTableName = "";
				schema.Columns.Add(colvarTitle);
				
				TableSchema.TableColumn colvarDll = new TableSchema.TableColumn(schema);
				colvarDll.ColumnName = "DLL";
				colvarDll.DataType = DbType.String;
				colvarDll.MaxLength = 20;
				colvarDll.AutoIncrement = false;
				colvarDll.IsNullable = true;
				colvarDll.IsPrimaryKey = false;
				colvarDll.IsForeignKey = false;
				colvarDll.IsReadOnly = false;
				colvarDll.DefaultSetting = @"";
				colvarDll.ForeignKeyTableName = "";
				schema.Columns.Add(colvarDll);
				
				TableSchema.TableColumn colvarScreenId = new TableSchema.TableColumn(schema);
				colvarScreenId.ColumnName = "SCREEN_ID";
				colvarScreenId.DataType = DbType.String;
				colvarScreenId.MaxLength = 20;
				colvarScreenId.AutoIncrement = false;
				colvarScreenId.IsNullable = true;
				colvarScreenId.IsPrimaryKey = false;
				colvarScreenId.IsForeignKey = false;
				colvarScreenId.IsReadOnly = false;
				colvarScreenId.DefaultSetting = @"";
				colvarScreenId.ForeignKeyTableName = "";
				schema.Columns.Add(colvarScreenId);
				
				TableSchema.TableColumn colvarUseGubun = new TableSchema.TableColumn(schema);
				colvarUseGubun.ColumnName = "USE_GUBUN";
				colvarUseGubun.DataType = DbType.String;
				colvarUseGubun.MaxLength = 1;
				colvarUseGubun.AutoIncrement = false;
				colvarUseGubun.IsNullable = true;
				colvarUseGubun.IsPrimaryKey = false;
				colvarUseGubun.IsForeignKey = false;
				colvarUseGubun.IsReadOnly = false;
				colvarUseGubun.DefaultSetting = @"";
				colvarUseGubun.ForeignKeyTableName = "";
				schema.Columns.Add(colvarUseGubun);
				
				TableSchema.TableColumn colvarSeqNo = new TableSchema.TableColumn(schema);
				colvarSeqNo.ColumnName = "SEQ_NO";
				colvarSeqNo.DataType = DbType.String;
				colvarSeqNo.MaxLength = 20;
				colvarSeqNo.AutoIncrement = false;
				colvarSeqNo.IsNullable = true;
				colvarSeqNo.IsPrimaryKey = false;
				colvarSeqNo.IsForeignKey = false;
				colvarSeqNo.IsReadOnly = false;
				colvarSeqNo.DefaultSetting = @"";
				colvarSeqNo.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSeqNo);
				
				TableSchema.TableColumn colvarMakefg = new TableSchema.TableColumn(schema);
				colvarMakefg.ColumnName = "MAKEFG";
				colvarMakefg.DataType = DbType.String;
				colvarMakefg.MaxLength = 20;
				colvarMakefg.AutoIncrement = false;
				colvarMakefg.IsNullable = true;
				colvarMakefg.IsPrimaryKey = false;
				colvarMakefg.IsForeignKey = false;
				colvarMakefg.IsReadOnly = false;
				colvarMakefg.DefaultSetting = @"";
				colvarMakefg.ForeignKeyTableName = "";
				schema.Columns.Add(colvarMakefg);
				
				TableSchema.TableColumn colvarWinTitle = new TableSchema.TableColumn(schema);
				colvarWinTitle.ColumnName = "WIN_TITLE";
				colvarWinTitle.DataType = DbType.String;
				colvarWinTitle.MaxLength = 20;
				colvarWinTitle.AutoIncrement = false;
				colvarWinTitle.IsNullable = true;
				colvarWinTitle.IsPrimaryKey = false;
				colvarWinTitle.IsForeignKey = false;
				colvarWinTitle.IsReadOnly = false;
				colvarWinTitle.DefaultSetting = @"";
				colvarWinTitle.ForeignKeyTableName = "";
				schema.Columns.Add(colvarWinTitle);
				
				TableSchema.TableColumn colvarComments = new TableSchema.TableColumn(schema);
				colvarComments.ColumnName = "COMMENTS";
				colvarComments.DataType = DbType.String;
				colvarComments.MaxLength = 20;
				colvarComments.AutoIncrement = false;
				colvarComments.IsNullable = true;
				colvarComments.IsPrimaryKey = false;
				colvarComments.IsForeignKey = false;
				colvarComments.IsReadOnly = false;
				colvarComments.DefaultSetting = @"";
				colvarComments.ForeignKeyTableName = "";
				schema.Columns.Add(colvarComments);
				
				TableSchema.TableColumn colvarTopfg = new TableSchema.TableColumn(schema);
				colvarTopfg.ColumnName = "TOPFG";
				colvarTopfg.DataType = DbType.String;
				colvarTopfg.MaxLength = 20;
				colvarTopfg.AutoIncrement = false;
				colvarTopfg.IsNullable = true;
				colvarTopfg.IsPrimaryKey = false;
				colvarTopfg.IsForeignKey = false;
				colvarTopfg.IsReadOnly = false;
				colvarTopfg.DefaultSetting = @"";
				colvarTopfg.ForeignKeyTableName = "";
				schema.Columns.Add(colvarTopfg);
				
				TableSchema.TableColumn colvarSubfg = new TableSchema.TableColumn(schema);
				colvarSubfg.ColumnName = "SUBFG";
				colvarSubfg.DataType = DbType.String;
				colvarSubfg.MaxLength = 20;
				colvarSubfg.AutoIncrement = false;
				colvarSubfg.IsNullable = true;
				colvarSubfg.IsPrimaryKey = false;
				colvarSubfg.IsForeignKey = false;
				colvarSubfg.IsReadOnly = false;
				colvarSubfg.DefaultSetting = @"";
				colvarSubfg.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSubfg);
				
				TableSchema.TableColumn colvarCreationDate = new TableSchema.TableColumn(schema);
				colvarCreationDate.ColumnName = "CREATION_DATE";
				colvarCreationDate.DataType = DbType.DateTime;
				colvarCreationDate.MaxLength = 0;
				colvarCreationDate.AutoIncrement = false;
				colvarCreationDate.IsNullable = true;
				colvarCreationDate.IsPrimaryKey = false;
				colvarCreationDate.IsForeignKey = false;
				colvarCreationDate.IsReadOnly = false;
				colvarCreationDate.DefaultSetting = @"";
				colvarCreationDate.ForeignKeyTableName = "";
				schema.Columns.Add(colvarCreationDate);
				
				TableSchema.TableColumn colvarCreationUserId = new TableSchema.TableColumn(schema);
				colvarCreationUserId.ColumnName = "CREATION_USER_ID";
				colvarCreationUserId.DataType = DbType.String;
				colvarCreationUserId.MaxLength = 20;
				colvarCreationUserId.AutoIncrement = false;
				colvarCreationUserId.IsNullable = true;
				colvarCreationUserId.IsPrimaryKey = false;
				colvarCreationUserId.IsForeignKey = false;
				colvarCreationUserId.IsReadOnly = false;
				colvarCreationUserId.DefaultSetting = @"";
				colvarCreationUserId.ForeignKeyTableName = "";
				schema.Columns.Add(colvarCreationUserId);
				
				TableSchema.TableColumn colvarUpdateDate = new TableSchema.TableColumn(schema);
				colvarUpdateDate.ColumnName = "UPDATE_DATE";
				colvarUpdateDate.DataType = DbType.DateTime;
				colvarUpdateDate.MaxLength = 0;
				colvarUpdateDate.AutoIncrement = false;
				colvarUpdateDate.IsNullable = true;
				colvarUpdateDate.IsPrimaryKey = false;
				colvarUpdateDate.IsForeignKey = false;
				colvarUpdateDate.IsReadOnly = false;
				colvarUpdateDate.DefaultSetting = @"";
				colvarUpdateDate.ForeignKeyTableName = "";
				schema.Columns.Add(colvarUpdateDate);
				
				TableSchema.TableColumn colvarUpdateUserId = new TableSchema.TableColumn(schema);
				colvarUpdateUserId.ColumnName = "UPDATE_USER_ID";
				colvarUpdateUserId.DataType = DbType.String;
				colvarUpdateUserId.MaxLength = 20;
				colvarUpdateUserId.AutoIncrement = false;
				colvarUpdateUserId.IsNullable = true;
				colvarUpdateUserId.IsPrimaryKey = false;
				colvarUpdateUserId.IsForeignKey = false;
				colvarUpdateUserId.IsReadOnly = false;
				colvarUpdateUserId.DefaultSetting = @"";
				colvarUpdateUserId.ForeignKeyTableName = "";
				schema.Columns.Add(colvarUpdateUserId);
				
				TableSchema.TableColumn colvarS30System = new TableSchema.TableColumn(schema);
				colvarS30System.ColumnName = "S30_SYSTEM";
				colvarS30System.DataType = DbType.String;
				colvarS30System.MaxLength = 20;
				colvarS30System.AutoIncrement = false;
				colvarS30System.IsNullable = true;
				colvarS30System.IsPrimaryKey = false;
				colvarS30System.IsForeignKey = false;
				colvarS30System.IsReadOnly = false;
				colvarS30System.DefaultSetting = @"";
				colvarS30System.ForeignKeyTableName = "";
				schema.Columns.Add(colvarS30System);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["ErpNowthwin"].AddSchema("SLSYS0030",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("Id")]
		[Bindable(true)]
		public string Id 
		{
			get { return GetColumnValue<string>(Columns.Id); }
			set { SetColumnValue(Columns.Id, value); }
		}
		  
		[XmlAttribute("MenuSeqNo")]
		[Bindable(true)]
		public string MenuSeqNo 
		{
			get { return GetColumnValue<string>(Columns.MenuSeqNo); }
			set { SetColumnValue(Columns.MenuSeqNo, value); }
		}
		  
		[XmlAttribute("MenuKey")]
		[Bindable(true)]
		public string MenuKey 
		{
			get { return GetColumnValue<string>(Columns.MenuKey); }
			set { SetColumnValue(Columns.MenuKey, value); }
		}
		  
		[XmlAttribute("Part")]
		[Bindable(true)]
		public string Part 
		{
			get { return GetColumnValue<string>(Columns.Part); }
			set { SetColumnValue(Columns.Part, value); }
		}
		  
		[XmlAttribute("Title")]
		[Bindable(true)]
		public string Title 
		{
			get { return GetColumnValue<string>(Columns.Title); }
			set { SetColumnValue(Columns.Title, value); }
		}
		  
		[XmlAttribute("Dll")]
		[Bindable(true)]
		public string Dll 
		{
			get { return GetColumnValue<string>(Columns.Dll); }
			set { SetColumnValue(Columns.Dll, value); }
		}
		  
		[XmlAttribute("ScreenId")]
		[Bindable(true)]
		public string ScreenId 
		{
			get { return GetColumnValue<string>(Columns.ScreenId); }
			set { SetColumnValue(Columns.ScreenId, value); }
		}
		  
		[XmlAttribute("UseGubun")]
		[Bindable(true)]
		public string UseGubun 
		{
			get { return GetColumnValue<string>(Columns.UseGubun); }
			set { SetColumnValue(Columns.UseGubun, value); }
		}
		  
		[XmlAttribute("SeqNo")]
		[Bindable(true)]
		public string SeqNo 
		{
			get { return GetColumnValue<string>(Columns.SeqNo); }
			set { SetColumnValue(Columns.SeqNo, value); }
		}
		  
		[XmlAttribute("Makefg")]
		[Bindable(true)]
		public string Makefg 
		{
			get { return GetColumnValue<string>(Columns.Makefg); }
			set { SetColumnValue(Columns.Makefg, value); }
		}
		  
		[XmlAttribute("WinTitle")]
		[Bindable(true)]
		public string WinTitle 
		{
			get { return GetColumnValue<string>(Columns.WinTitle); }
			set { SetColumnValue(Columns.WinTitle, value); }
		}
		  
		[XmlAttribute("Comments")]
		[Bindable(true)]
		public string Comments 
		{
			get { return GetColumnValue<string>(Columns.Comments); }
			set { SetColumnValue(Columns.Comments, value); }
		}
		  
		[XmlAttribute("Topfg")]
		[Bindable(true)]
		public string Topfg 
		{
			get { return GetColumnValue<string>(Columns.Topfg); }
			set { SetColumnValue(Columns.Topfg, value); }
		}
		  
		[XmlAttribute("Subfg")]
		[Bindable(true)]
		public string Subfg 
		{
			get { return GetColumnValue<string>(Columns.Subfg); }
			set { SetColumnValue(Columns.Subfg, value); }
		}
		  
		[XmlAttribute("CreationDate")]
		[Bindable(true)]
		public DateTime? CreationDate 
		{
			get { return GetColumnValue<DateTime?>(Columns.CreationDate); }
			set { SetColumnValue(Columns.CreationDate, value); }
		}
		  
		[XmlAttribute("CreationUserId")]
		[Bindable(true)]
		public string CreationUserId 
		{
			get { return GetColumnValue<string>(Columns.CreationUserId); }
			set { SetColumnValue(Columns.CreationUserId, value); }
		}
		  
		[XmlAttribute("UpdateDate")]
		[Bindable(true)]
		public DateTime? UpdateDate 
		{
			get { return GetColumnValue<DateTime?>(Columns.UpdateDate); }
			set { SetColumnValue(Columns.UpdateDate, value); }
		}
		  
		[XmlAttribute("UpdateUserId")]
		[Bindable(true)]
		public string UpdateUserId 
		{
			get { return GetColumnValue<string>(Columns.UpdateUserId); }
			set { SetColumnValue(Columns.UpdateUserId, value); }
		}
		  
		[XmlAttribute("S30System")]
		[Bindable(true)]
		public string S30System 
		{
			get { return GetColumnValue<string>(Columns.S30System); }
			set { SetColumnValue(Columns.S30System, value); }
		}
		
		#endregion
		
		
			
		
		//no foreign key tables defined (0)
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(string varId,string varMenuSeqNo,string varMenuKey,string varPart,string varTitle,string varDll,string varScreenId,string varUseGubun,string varSeqNo,string varMakefg,string varWinTitle,string varComments,string varTopfg,string varSubfg,DateTime? varCreationDate,string varCreationUserId,DateTime? varUpdateDate,string varUpdateUserId,string varS30System)
		{
			SLSYS0030 item = new SLSYS0030();
			
			item.Id = varId;
			
			item.MenuSeqNo = varMenuSeqNo;
			
			item.MenuKey = varMenuKey;
			
			item.Part = varPart;
			
			item.Title = varTitle;
			
			item.Dll = varDll;
			
			item.ScreenId = varScreenId;
			
			item.UseGubun = varUseGubun;
			
			item.SeqNo = varSeqNo;
			
			item.Makefg = varMakefg;
			
			item.WinTitle = varWinTitle;
			
			item.Comments = varComments;
			
			item.Topfg = varTopfg;
			
			item.Subfg = varSubfg;
			
			item.CreationDate = varCreationDate;
			
			item.CreationUserId = varCreationUserId;
			
			item.UpdateDate = varUpdateDate;
			
			item.UpdateUserId = varUpdateUserId;
			
			item.S30System = varS30System;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(string varId,string varMenuSeqNo,string varMenuKey,string varPart,string varTitle,string varDll,string varScreenId,string varUseGubun,string varSeqNo,string varMakefg,string varWinTitle,string varComments,string varTopfg,string varSubfg,DateTime? varCreationDate,string varCreationUserId,DateTime? varUpdateDate,string varUpdateUserId,string varS30System)
		{
			SLSYS0030 item = new SLSYS0030();
			
				item.Id = varId;
			
				item.MenuSeqNo = varMenuSeqNo;
			
				item.MenuKey = varMenuKey;
			
				item.Part = varPart;
			
				item.Title = varTitle;
			
				item.Dll = varDll;
			
				item.ScreenId = varScreenId;
			
				item.UseGubun = varUseGubun;
			
				item.SeqNo = varSeqNo;
			
				item.Makefg = varMakefg;
			
				item.WinTitle = varWinTitle;
			
				item.Comments = varComments;
			
				item.Topfg = varTopfg;
			
				item.Subfg = varSubfg;
			
				item.CreationDate = varCreationDate;
			
				item.CreationUserId = varCreationUserId;
			
				item.UpdateDate = varUpdateDate;
			
				item.UpdateUserId = varUpdateUserId;
			
				item.S30System = varS30System;
			
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
        
        
        
        public static TableSchema.TableColumn MenuSeqNoColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        public static TableSchema.TableColumn MenuKeyColumn
        {
            get { return Schema.Columns[2]; }
        }
        
        
        
        public static TableSchema.TableColumn PartColumn
        {
            get { return Schema.Columns[3]; }
        }
        
        
        
        public static TableSchema.TableColumn TitleColumn
        {
            get { return Schema.Columns[4]; }
        }
        
        
        
        public static TableSchema.TableColumn DllColumn
        {
            get { return Schema.Columns[5]; }
        }
        
        
        
        public static TableSchema.TableColumn ScreenIdColumn
        {
            get { return Schema.Columns[6]; }
        }
        
        
        
        public static TableSchema.TableColumn UseGubunColumn
        {
            get { return Schema.Columns[7]; }
        }
        
        
        
        public static TableSchema.TableColumn SeqNoColumn
        {
            get { return Schema.Columns[8]; }
        }
        
        
        
        public static TableSchema.TableColumn MakefgColumn
        {
            get { return Schema.Columns[9]; }
        }
        
        
        
        public static TableSchema.TableColumn WinTitleColumn
        {
            get { return Schema.Columns[10]; }
        }
        
        
        
        public static TableSchema.TableColumn CommentsColumn
        {
            get { return Schema.Columns[11]; }
        }
        
        
        
        public static TableSchema.TableColumn TopfgColumn
        {
            get { return Schema.Columns[12]; }
        }
        
        
        
        public static TableSchema.TableColumn SubfgColumn
        {
            get { return Schema.Columns[13]; }
        }
        
        
        
        public static TableSchema.TableColumn CreationDateColumn
        {
            get { return Schema.Columns[14]; }
        }
        
        
        
        public static TableSchema.TableColumn CreationUserIdColumn
        {
            get { return Schema.Columns[15]; }
        }
        
        
        
        public static TableSchema.TableColumn UpdateDateColumn
        {
            get { return Schema.Columns[16]; }
        }
        
        
        
        public static TableSchema.TableColumn UpdateUserIdColumn
        {
            get { return Schema.Columns[17]; }
        }
        
        
        
        public static TableSchema.TableColumn S30SystemColumn
        {
            get { return Schema.Columns[18]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string Id = @"ID";
			 public static string MenuSeqNo = @"MENU_SEQ_NO";
			 public static string MenuKey = @"MENU_KEY";
			 public static string Part = @"PART";
			 public static string Title = @"TITLE";
			 public static string Dll = @"DLL";
			 public static string ScreenId = @"SCREEN_ID";
			 public static string UseGubun = @"USE_GUBUN";
			 public static string SeqNo = @"SEQ_NO";
			 public static string Makefg = @"MAKEFG";
			 public static string WinTitle = @"WIN_TITLE";
			 public static string Comments = @"COMMENTS";
			 public static string Topfg = @"TOPFG";
			 public static string Subfg = @"SUBFG";
			 public static string CreationDate = @"CREATION_DATE";
			 public static string CreationUserId = @"CREATION_USER_ID";
			 public static string UpdateDate = @"UPDATE_DATE";
			 public static string UpdateUserId = @"UPDATE_USER_ID";
			 public static string S30System = @"S30_SYSTEM";
						
		}
		#endregion
		
		#region Update PK Collections
		
        #endregion
    
        #region Deep Save
		
        #endregion
	}
}
