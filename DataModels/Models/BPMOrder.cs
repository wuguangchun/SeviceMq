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
	/// Strongly-typed collection for the BPMOrder class.
	/// </summary>
    [Serializable]
	public partial class BPMOrderCollection : ActiveList<BPMOrder, BPMOrderCollection>
	{	   
		public BPMOrderCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>BPMOrderCollection</returns>
		public BPMOrderCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                BPMOrder o = this[i];
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
	/// This is an ActiveRecord class which wraps the BPMOrders table.
	/// </summary>
	[Serializable]
	public partial class BPMOrder : ActiveRecord<BPMOrder>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public BPMOrder()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public BPMOrder(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public BPMOrder(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public BPMOrder(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("BPMOrders", TableType.Table, DataService.GetInstance("Nowthwin"));
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
				
				TableSchema.TableColumn colvarPlanmid = new TableSchema.TableColumn(schema);
				colvarPlanmid.ColumnName = "PLANMID";
				colvarPlanmid.DataType = DbType.AnsiString;
				colvarPlanmid.MaxLength = 50;
				colvarPlanmid.AutoIncrement = false;
				colvarPlanmid.IsNullable = false;
				colvarPlanmid.IsPrimaryKey = false;
				colvarPlanmid.IsForeignKey = false;
				colvarPlanmid.IsReadOnly = false;
				colvarPlanmid.DefaultSetting = @"";
				colvarPlanmid.ForeignKeyTableName = "";
				schema.Columns.Add(colvarPlanmid);
				
				TableSchema.TableColumn colvarKhddbh = new TableSchema.TableColumn(schema);
				colvarKhddbh.ColumnName = "KHDDBH";
				colvarKhddbh.DataType = DbType.AnsiString;
				colvarKhddbh.MaxLength = 50;
				colvarKhddbh.AutoIncrement = false;
				colvarKhddbh.IsNullable = true;
				colvarKhddbh.IsPrimaryKey = false;
				colvarKhddbh.IsForeignKey = false;
				colvarKhddbh.IsReadOnly = false;
				colvarKhddbh.DefaultSetting = @"";
				colvarKhddbh.ForeignKeyTableName = "";
				schema.Columns.Add(colvarKhddbh);
				
				TableSchema.TableColumn colvarScggdh = new TableSchema.TableColumn(schema);
				colvarScggdh.ColumnName = "SCGGDH";
				colvarScggdh.DataType = DbType.AnsiString;
				colvarScggdh.MaxLength = 50;
				colvarScggdh.AutoIncrement = false;
				colvarScggdh.IsNullable = true;
				colvarScggdh.IsPrimaryKey = false;
				colvarScggdh.IsForeignKey = false;
				colvarScggdh.IsReadOnly = false;
				colvarScggdh.DefaultSetting = @"";
				colvarScggdh.ForeignKeyTableName = "";
				schema.Columns.Add(colvarScggdh);
				
				TableSchema.TableColumn colvarScgcmc = new TableSchema.TableColumn(schema);
				colvarScgcmc.ColumnName = "SCGCMC";
				colvarScgcmc.DataType = DbType.AnsiString;
				colvarScgcmc.MaxLength = 50;
				colvarScgcmc.AutoIncrement = false;
				colvarScgcmc.IsNullable = true;
				colvarScgcmc.IsPrimaryKey = false;
				colvarScgcmc.IsForeignKey = false;
				colvarScgcmc.IsReadOnly = false;
				colvarScgcmc.DefaultSetting = @"";
				colvarScgcmc.ForeignKeyTableName = "";
				schema.Columns.Add(colvarScgcmc);
				
				TableSchema.TableColumn colvarPcsj = new TableSchema.TableColumn(schema);
				colvarPcsj.ColumnName = "PCSJ";
				colvarPcsj.DataType = DbType.DateTime;
				colvarPcsj.MaxLength = 0;
				colvarPcsj.AutoIncrement = false;
				colvarPcsj.IsNullable = true;
				colvarPcsj.IsPrimaryKey = false;
				colvarPcsj.IsForeignKey = false;
				colvarPcsj.IsReadOnly = false;
				colvarPcsj.DefaultSetting = @"";
				colvarPcsj.ForeignKeyTableName = "";
				schema.Columns.Add(colvarPcsj);
				
				TableSchema.TableColumn colvarStatus = new TableSchema.TableColumn(schema);
				colvarStatus.ColumnName = "STATUS";
				colvarStatus.DataType = DbType.Int32;
				colvarStatus.MaxLength = 0;
				colvarStatus.AutoIncrement = false;
				colvarStatus.IsNullable = true;
				colvarStatus.IsPrimaryKey = false;
				colvarStatus.IsForeignKey = false;
				colvarStatus.IsReadOnly = false;
				colvarStatus.DefaultSetting = @"";
				colvarStatus.ForeignKeyTableName = "";
				schema.Columns.Add(colvarStatus);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["Nowthwin"].AddSchema("BPMOrders",schema);
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
		  
		[XmlAttribute("Planmid")]
		[Bindable(true)]
		public string Planmid 
		{
			get { return GetColumnValue<string>(Columns.Planmid); }
			set { SetColumnValue(Columns.Planmid, value); }
		}
		  
		[XmlAttribute("Khddbh")]
		[Bindable(true)]
		public string Khddbh 
		{
			get { return GetColumnValue<string>(Columns.Khddbh); }
			set { SetColumnValue(Columns.Khddbh, value); }
		}
		  
		[XmlAttribute("Scggdh")]
		[Bindable(true)]
		public string Scggdh 
		{
			get { return GetColumnValue<string>(Columns.Scggdh); }
			set { SetColumnValue(Columns.Scggdh, value); }
		}
		  
		[XmlAttribute("Scgcmc")]
		[Bindable(true)]
		public string Scgcmc 
		{
			get { return GetColumnValue<string>(Columns.Scgcmc); }
			set { SetColumnValue(Columns.Scgcmc, value); }
		}
		  
		[XmlAttribute("Pcsj")]
		[Bindable(true)]
		public DateTime? Pcsj 
		{
			get { return GetColumnValue<DateTime?>(Columns.Pcsj); }
			set { SetColumnValue(Columns.Pcsj, value); }
		}
		  
		[XmlAttribute("Status")]
		[Bindable(true)]
		public int? Status 
		{
			get { return GetColumnValue<int?>(Columns.Status); }
			set { SetColumnValue(Columns.Status, value); }
		}
		
		#endregion
		
		
			
		
		//no foreign key tables defined (0)
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(string varPlanmid,string varKhddbh,string varScggdh,string varScgcmc,DateTime? varPcsj,int? varStatus)
		{
			BPMOrder item = new BPMOrder();
			
			item.Planmid = varPlanmid;
			
			item.Khddbh = varKhddbh;
			
			item.Scggdh = varScggdh;
			
			item.Scgcmc = varScgcmc;
			
			item.Pcsj = varPcsj;
			
			item.Status = varStatus;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varId,string varPlanmid,string varKhddbh,string varScggdh,string varScgcmc,DateTime? varPcsj,int? varStatus)
		{
			BPMOrder item = new BPMOrder();
			
				item.Id = varId;
			
				item.Planmid = varPlanmid;
			
				item.Khddbh = varKhddbh;
			
				item.Scggdh = varScggdh;
			
				item.Scgcmc = varScgcmc;
			
				item.Pcsj = varPcsj;
			
				item.Status = varStatus;
			
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
        
        
        
        public static TableSchema.TableColumn PlanmidColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        public static TableSchema.TableColumn KhddbhColumn
        {
            get { return Schema.Columns[2]; }
        }
        
        
        
        public static TableSchema.TableColumn ScggdhColumn
        {
            get { return Schema.Columns[3]; }
        }
        
        
        
        public static TableSchema.TableColumn ScgcmcColumn
        {
            get { return Schema.Columns[4]; }
        }
        
        
        
        public static TableSchema.TableColumn PcsjColumn
        {
            get { return Schema.Columns[5]; }
        }
        
        
        
        public static TableSchema.TableColumn StatusColumn
        {
            get { return Schema.Columns[6]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string Id = @"ID";
			 public static string Planmid = @"PLANMID";
			 public static string Khddbh = @"KHDDBH";
			 public static string Scggdh = @"SCGGDH";
			 public static string Scgcmc = @"SCGCMC";
			 public static string Pcsj = @"PCSJ";
			 public static string Status = @"STATUS";
						
		}
		#endregion
		
		#region Update PK Collections
		
        #endregion
    
        #region Deep Save
		
        #endregion
	}
}