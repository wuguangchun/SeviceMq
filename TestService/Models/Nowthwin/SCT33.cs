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
	/// Strongly-typed collection for the SCT33 class.
	/// </summary>
    [Serializable]
	public partial class SCT33Collection : ActiveList<SCT33, SCT33Collection>
	{	   
		public SCT33Collection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>SCT33Collection</returns>
		public SCT33Collection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                SCT33 o = this[i];
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
	/// This is an ActiveRecord class which wraps the SCT33 table.
	/// </summary>
	[Serializable]
	public partial class SCT33 : ActiveRecord<SCT33>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public SCT33()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public SCT33(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public SCT33(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public SCT33(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("SCT33", TableType.Table, DataService.GetInstance("Nowthwin"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarSchtbh = new TableSchema.TableColumn(schema);
				colvarSchtbh.ColumnName = "SCHTBH";
				colvarSchtbh.DataType = DbType.AnsiString;
				colvarSchtbh.MaxLength = 12;
				colvarSchtbh.AutoIncrement = false;
				colvarSchtbh.IsNullable = false;
				colvarSchtbh.IsPrimaryKey = true;
				colvarSchtbh.IsForeignKey = false;
				colvarSchtbh.IsReadOnly = false;
				colvarSchtbh.DefaultSetting = @"";
				colvarSchtbh.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSchtbh);
				
				TableSchema.TableColumn colvarSchtxh = new TableSchema.TableColumn(schema);
				colvarSchtxh.ColumnName = "SCHTXH";
				colvarSchtxh.DataType = DbType.Int32;
				colvarSchtxh.MaxLength = 0;
				colvarSchtxh.AutoIncrement = false;
				colvarSchtxh.IsNullable = false;
				colvarSchtxh.IsPrimaryKey = true;
				colvarSchtxh.IsForeignKey = false;
				colvarSchtxh.IsReadOnly = false;
				colvarSchtxh.DefaultSetting = @"";
				colvarSchtxh.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSchtxh);
				
				TableSchema.TableColumn colvarScggdh = new TableSchema.TableColumn(schema);
				colvarScggdh.ColumnName = "SCGGDH";
				colvarScggdh.DataType = DbType.AnsiString;
				colvarScggdh.MaxLength = 12;
				colvarScggdh.AutoIncrement = false;
				colvarScggdh.IsNullable = false;
				colvarScggdh.IsPrimaryKey = false;
				colvarScggdh.IsForeignKey = false;
				colvarScggdh.IsReadOnly = false;
				colvarScggdh.DefaultSetting = @"";
				colvarScggdh.ForeignKeyTableName = "";
				schema.Columns.Add(colvarScggdh);
				
				TableSchema.TableColumn colvarScggxh = new TableSchema.TableColumn(schema);
				colvarScggxh.ColumnName = "SCGGXH";
				colvarScggxh.DataType = DbType.Int32;
				colvarScggxh.MaxLength = 0;
				colvarScggxh.AutoIncrement = false;
				colvarScggxh.IsNullable = false;
				colvarScggxh.IsPrimaryKey = false;
				colvarScggxh.IsForeignKey = false;
				colvarScggxh.IsReadOnly = false;
				colvarScggxh.DefaultSetting = @"";
				colvarScggxh.ForeignKeyTableName = "";
				schema.Columns.Add(colvarScggxh);
				
				TableSchema.TableColumn colvarXtwpks = new TableSchema.TableColumn(schema);
				colvarXtwpks.ColumnName = "XTWPKS";
				colvarXtwpks.DataType = DbType.AnsiString;
				colvarXtwpks.MaxLength = 20;
				colvarXtwpks.AutoIncrement = false;
				colvarXtwpks.IsNullable = false;
				colvarXtwpks.IsPrimaryKey = false;
				colvarXtwpks.IsForeignKey = false;
				colvarXtwpks.IsReadOnly = false;
				colvarXtwpks.DefaultSetting = @"";
				colvarXtwpks.ForeignKeyTableName = "";
				schema.Columns.Add(colvarXtwpks);
				
				TableSchema.TableColumn colvarXtwpys = new TableSchema.TableColumn(schema);
				colvarXtwpys.ColumnName = "XTWPYS";
				colvarXtwpys.DataType = DbType.AnsiString;
				colvarXtwpys.MaxLength = 20;
				colvarXtwpys.AutoIncrement = false;
				colvarXtwpys.IsNullable = false;
				colvarXtwpys.IsPrimaryKey = false;
				colvarXtwpys.IsForeignKey = false;
				colvarXtwpys.IsReadOnly = false;
				colvarXtwpys.DefaultSetting = @"";
				colvarXtwpys.ForeignKeyTableName = "";
				schema.Columns.Add(colvarXtwpys);
				
				TableSchema.TableColumn colvarXtxmdm = new TableSchema.TableColumn(schema);
				colvarXtxmdm.ColumnName = "XTXMDM";
				colvarXtxmdm.DataType = DbType.AnsiString;
				colvarXtxmdm.MaxLength = 10;
				colvarXtxmdm.AutoIncrement = false;
				colvarXtxmdm.IsNullable = false;
				colvarXtxmdm.IsPrimaryKey = false;
				colvarXtxmdm.IsForeignKey = false;
				colvarXtxmdm.IsReadOnly = false;
				colvarXtxmdm.DefaultSetting = @"";
				colvarXtxmdm.ForeignKeyTableName = "";
				schema.Columns.Add(colvarXtxmdm);
				
				TableSchema.TableColumn colvarSchtsl = new TableSchema.TableColumn(schema);
				colvarSchtsl.ColumnName = "SCHTSL";
				colvarSchtsl.DataType = DbType.Int32;
				colvarSchtsl.MaxLength = 0;
				colvarSchtsl.AutoIncrement = false;
				colvarSchtsl.IsNullable = true;
				colvarSchtsl.IsPrimaryKey = false;
				colvarSchtsl.IsForeignKey = false;
				colvarSchtsl.IsReadOnly = false;
				colvarSchtsl.DefaultSetting = @"";
				colvarSchtsl.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSchtsl);
				
				TableSchema.TableColumn colvarScshbz = new TableSchema.TableColumn(schema);
				colvarScshbz.ColumnName = "SCSHBZ";
				colvarScshbz.DataType = DbType.AnsiString;
				colvarScshbz.MaxLength = 1;
				colvarScshbz.AutoIncrement = false;
				colvarScshbz.IsNullable = true;
				colvarScshbz.IsPrimaryKey = false;
				colvarScshbz.IsForeignKey = false;
				colvarScshbz.IsReadOnly = false;
				colvarScshbz.DefaultSetting = @"";
				colvarScshbz.ForeignKeyTableName = "";
				schema.Columns.Add(colvarScshbz);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["Nowthwin"].AddSchema("SCT33",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("Schtbh")]
		[Bindable(true)]
		public string Schtbh 
		{
			get { return GetColumnValue<string>(Columns.Schtbh); }
			set { SetColumnValue(Columns.Schtbh, value); }
		}
		  
		[XmlAttribute("Schtxh")]
		[Bindable(true)]
		public int Schtxh 
		{
			get { return GetColumnValue<int>(Columns.Schtxh); }
			set { SetColumnValue(Columns.Schtxh, value); }
		}
		  
		[XmlAttribute("Scggdh")]
		[Bindable(true)]
		public string Scggdh 
		{
			get { return GetColumnValue<string>(Columns.Scggdh); }
			set { SetColumnValue(Columns.Scggdh, value); }
		}
		  
		[XmlAttribute("Scggxh")]
		[Bindable(true)]
		public int Scggxh 
		{
			get { return GetColumnValue<int>(Columns.Scggxh); }
			set { SetColumnValue(Columns.Scggxh, value); }
		}
		  
		[XmlAttribute("Xtwpks")]
		[Bindable(true)]
		public string Xtwpks 
		{
			get { return GetColumnValue<string>(Columns.Xtwpks); }
			set { SetColumnValue(Columns.Xtwpks, value); }
		}
		  
		[XmlAttribute("Xtwpys")]
		[Bindable(true)]
		public string Xtwpys 
		{
			get { return GetColumnValue<string>(Columns.Xtwpys); }
			set { SetColumnValue(Columns.Xtwpys, value); }
		}
		  
		[XmlAttribute("Xtxmdm")]
		[Bindable(true)]
		public string Xtxmdm 
		{
			get { return GetColumnValue<string>(Columns.Xtxmdm); }
			set { SetColumnValue(Columns.Xtxmdm, value); }
		}
		  
		[XmlAttribute("Schtsl")]
		[Bindable(true)]
		public int? Schtsl 
		{
			get { return GetColumnValue<int?>(Columns.Schtsl); }
			set { SetColumnValue(Columns.Schtsl, value); }
		}
		  
		[XmlAttribute("Scshbz")]
		[Bindable(true)]
		public string Scshbz 
		{
			get { return GetColumnValue<string>(Columns.Scshbz); }
			set { SetColumnValue(Columns.Scshbz, value); }
		}
		
		#endregion
		
		
			
		
		//no foreign key tables defined (0)
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(string varSchtbh,int varSchtxh,string varScggdh,int varScggxh,string varXtwpks,string varXtwpys,string varXtxmdm,int? varSchtsl,string varScshbz)
		{
			SCT33 item = new SCT33();
			
			item.Schtbh = varSchtbh;
			
			item.Schtxh = varSchtxh;
			
			item.Scggdh = varScggdh;
			
			item.Scggxh = varScggxh;
			
			item.Xtwpks = varXtwpks;
			
			item.Xtwpys = varXtwpys;
			
			item.Xtxmdm = varXtxmdm;
			
			item.Schtsl = varSchtsl;
			
			item.Scshbz = varScshbz;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(string varSchtbh,int varSchtxh,string varScggdh,int varScggxh,string varXtwpks,string varXtwpys,string varXtxmdm,int? varSchtsl,string varScshbz)
		{
			SCT33 item = new SCT33();
			
				item.Schtbh = varSchtbh;
			
				item.Schtxh = varSchtxh;
			
				item.Scggdh = varScggdh;
			
				item.Scggxh = varScggxh;
			
				item.Xtwpks = varXtwpks;
			
				item.Xtwpys = varXtwpys;
			
				item.Xtxmdm = varXtxmdm;
			
				item.Schtsl = varSchtsl;
			
				item.Scshbz = varScshbz;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn SchtbhColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn SchtxhColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        public static TableSchema.TableColumn ScggdhColumn
        {
            get { return Schema.Columns[2]; }
        }
        
        
        
        public static TableSchema.TableColumn ScggxhColumn
        {
            get { return Schema.Columns[3]; }
        }
        
        
        
        public static TableSchema.TableColumn XtwpksColumn
        {
            get { return Schema.Columns[4]; }
        }
        
        
        
        public static TableSchema.TableColumn XtwpysColumn
        {
            get { return Schema.Columns[5]; }
        }
        
        
        
        public static TableSchema.TableColumn XtxmdmColumn
        {
            get { return Schema.Columns[6]; }
        }
        
        
        
        public static TableSchema.TableColumn SchtslColumn
        {
            get { return Schema.Columns[7]; }
        }
        
        
        
        public static TableSchema.TableColumn ScshbzColumn
        {
            get { return Schema.Columns[8]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string Schtbh = @"SCHTBH";
			 public static string Schtxh = @"SCHTXH";
			 public static string Scggdh = @"SCGGDH";
			 public static string Scggxh = @"SCGGXH";
			 public static string Xtwpks = @"XTWPKS";
			 public static string Xtwpys = @"XTWPYS";
			 public static string Xtxmdm = @"XTXMDM";
			 public static string Schtsl = @"SCHTSL";
			 public static string Scshbz = @"SCSHBZ";
						
		}
		#endregion
		
		#region Update PK Collections
		
        #endregion
    
        #region Deep Save
		
        #endregion
	}
}
