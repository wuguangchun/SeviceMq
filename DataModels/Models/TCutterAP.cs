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
	/// Strongly-typed collection for the TCutterAP class.
	/// </summary>
    [Serializable]
	public partial class TCutterAPCollection : ActiveList<TCutterAP, TCutterAPCollection>
	{	   
		public TCutterAPCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>TCutterAPCollection</returns>
		public TCutterAPCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                TCutterAP o = this[i];
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
	/// This is an ActiveRecord class which wraps the T_CutterAPS table.
	/// </summary>
	[Serializable]
	public partial class TCutterAP : ActiveRecord<TCutterAP>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public TCutterAP()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public TCutterAP(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public TCutterAP(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public TCutterAP(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("T_CutterAPS", TableType.Table, DataService.GetInstance("Nowthwin"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarApsid = new TableSchema.TableColumn(schema);
				colvarApsid.ColumnName = "APSID";
				colvarApsid.DataType = DbType.Int32;
				colvarApsid.MaxLength = 0;
				colvarApsid.AutoIncrement = true;
				colvarApsid.IsNullable = false;
				colvarApsid.IsPrimaryKey = true;
				colvarApsid.IsForeignKey = false;
				colvarApsid.IsReadOnly = false;
				colvarApsid.DefaultSetting = @"";
				colvarApsid.ForeignKeyTableName = "";
				schema.Columns.Add(colvarApsid);
				
				TableSchema.TableColumn colvarScggdh = new TableSchema.TableColumn(schema);
				colvarScggdh.ColumnName = "SCGGDH";
				colvarScggdh.DataType = DbType.AnsiString;
				colvarScggdh.MaxLength = 20;
				colvarScggdh.AutoIncrement = false;
				colvarScggdh.IsNullable = false;
				colvarScggdh.IsPrimaryKey = false;
				colvarScggdh.IsForeignKey = false;
				colvarScggdh.IsReadOnly = false;
				colvarScggdh.DefaultSetting = @"";
				colvarScggdh.ForeignKeyTableName = "";
				schema.Columns.Add(colvarScggdh);
				
				TableSchema.TableColumn colvarPlansid = new TableSchema.TableColumn(schema);
				colvarPlansid.ColumnName = "PLANSID";
				colvarPlansid.DataType = DbType.Int32;
				colvarPlansid.MaxLength = 0;
				colvarPlansid.AutoIncrement = false;
				colvarPlansid.IsNullable = false;
				colvarPlansid.IsPrimaryKey = false;
				colvarPlansid.IsForeignKey = false;
				colvarPlansid.IsReadOnly = false;
				colvarPlansid.DefaultSetting = @"";
				colvarPlansid.ForeignKeyTableName = "";
				schema.Columns.Add(colvarPlansid);
				
				TableSchema.TableColumn colvarSczsbh = new TableSchema.TableColumn(schema);
				colvarSczsbh.ColumnName = "SCZSBH";
				colvarSczsbh.DataType = DbType.AnsiString;
				colvarSczsbh.MaxLength = 20;
				colvarSczsbh.AutoIncrement = false;
				colvarSczsbh.IsNullable = false;
				colvarSczsbh.IsPrimaryKey = false;
				colvarSczsbh.IsForeignKey = false;
				colvarSczsbh.IsReadOnly = false;
				colvarSczsbh.DefaultSetting = @"";
				colvarSczsbh.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSczsbh);
				
				TableSchema.TableColumn colvarFilename = new TableSchema.TableColumn(schema);
				colvarFilename.ColumnName = "FILENAME";
				colvarFilename.DataType = DbType.AnsiString;
				colvarFilename.MaxLength = 20;
				colvarFilename.AutoIncrement = false;
				colvarFilename.IsNullable = false;
				colvarFilename.IsPrimaryKey = false;
				colvarFilename.IsForeignKey = false;
				colvarFilename.IsReadOnly = false;
				
						colvarFilename.DefaultSetting = @"('')";
				colvarFilename.ForeignKeyTableName = "";
				schema.Columns.Add(colvarFilename);
				
				TableSchema.TableColumn colvarCutternum = new TableSchema.TableColumn(schema);
				colvarCutternum.ColumnName = "CUTTERNUM";
				colvarCutternum.DataType = DbType.Int32;
				colvarCutternum.MaxLength = 0;
				colvarCutternum.AutoIncrement = false;
				colvarCutternum.IsNullable = false;
				colvarCutternum.IsPrimaryKey = false;
				colvarCutternum.IsForeignKey = false;
				colvarCutternum.IsReadOnly = false;
				colvarCutternum.DefaultSetting = @"";
				colvarCutternum.ForeignKeyTableName = "";
				schema.Columns.Add(colvarCutternum);
				
				TableSchema.TableColumn colvarCutcount = new TableSchema.TableColumn(schema);
				colvarCutcount.ColumnName = "CUTCOUNT";
				colvarCutcount.DataType = DbType.Int32;
				colvarCutcount.MaxLength = 0;
				colvarCutcount.AutoIncrement = false;
				colvarCutcount.IsNullable = false;
				colvarCutcount.IsPrimaryKey = false;
				colvarCutcount.IsForeignKey = false;
				colvarCutcount.IsReadOnly = false;
				colvarCutcount.DefaultSetting = @"";
				colvarCutcount.ForeignKeyTableName = "";
				schema.Columns.Add(colvarCutcount);
				
				TableSchema.TableColumn colvarCutdate = new TableSchema.TableColumn(schema);
				colvarCutdate.ColumnName = "CUTDATE";
				colvarCutdate.DataType = DbType.AnsiString;
				colvarCutdate.MaxLength = 10;
				colvarCutdate.AutoIncrement = false;
				colvarCutdate.IsNullable = false;
				colvarCutdate.IsPrimaryKey = false;
				colvarCutdate.IsForeignKey = false;
				colvarCutdate.IsReadOnly = false;
				colvarCutdate.DefaultSetting = @"";
				colvarCutdate.ForeignKeyTableName = "";
				schema.Columns.Add(colvarCutdate);
				
				TableSchema.TableColumn colvarCuttime = new TableSchema.TableColumn(schema);
				colvarCuttime.ColumnName = "CUTTIME";
				colvarCuttime.DataType = DbType.AnsiString;
				colvarCuttime.MaxLength = 11;
				colvarCuttime.AutoIncrement = false;
				colvarCuttime.IsNullable = false;
				colvarCuttime.IsPrimaryKey = false;
				colvarCuttime.IsForeignKey = false;
				colvarCuttime.IsReadOnly = false;
				colvarCuttime.DefaultSetting = @"";
				colvarCuttime.ForeignKeyTableName = "";
				schema.Columns.Add(colvarCuttime);
				
				TableSchema.TableColumn colvarOpdate = new TableSchema.TableColumn(schema);
				colvarOpdate.ColumnName = "OPDATE";
				colvarOpdate.DataType = DbType.DateTime;
				colvarOpdate.MaxLength = 0;
				colvarOpdate.AutoIncrement = false;
				colvarOpdate.IsNullable = true;
				colvarOpdate.IsPrimaryKey = false;
				colvarOpdate.IsForeignKey = false;
				colvarOpdate.IsReadOnly = false;
				colvarOpdate.DefaultSetting = @"";
				colvarOpdate.ForeignKeyTableName = "";
				schema.Columns.Add(colvarOpdate);
				
				TableSchema.TableColumn colvarBarcode = new TableSchema.TableColumn(schema);
				colvarBarcode.ColumnName = "BARCODE";
				colvarBarcode.DataType = DbType.AnsiString;
				colvarBarcode.MaxLength = 50;
				colvarBarcode.AutoIncrement = false;
				colvarBarcode.IsNullable = false;
				colvarBarcode.IsPrimaryKey = false;
				colvarBarcode.IsForeignKey = false;
				colvarBarcode.IsReadOnly = false;
				
						colvarBarcode.DefaultSetting = @"(getdate())";
				colvarBarcode.ForeignKeyTableName = "";
				schema.Columns.Add(colvarBarcode);
				
				TableSchema.TableColumn colvarFilestatus = new TableSchema.TableColumn(schema);
				colvarFilestatus.ColumnName = "FILESTATUS";
				colvarFilestatus.DataType = DbType.AnsiString;
				colvarFilestatus.MaxLength = 4;
				colvarFilestatus.AutoIncrement = false;
				colvarFilestatus.IsNullable = false;
				colvarFilestatus.IsPrimaryKey = false;
				colvarFilestatus.IsForeignKey = false;
				colvarFilestatus.IsReadOnly = false;
				
						colvarFilestatus.DefaultSetting = @"((0))";
				colvarFilestatus.ForeignKeyTableName = "";
				schema.Columns.Add(colvarFilestatus);
				
				TableSchema.TableColumn colvarMatstatus = new TableSchema.TableColumn(schema);
				colvarMatstatus.ColumnName = "MATSTATUS";
				colvarMatstatus.DataType = DbType.AnsiString;
				colvarMatstatus.MaxLength = 4;
				colvarMatstatus.AutoIncrement = false;
				colvarMatstatus.IsNullable = false;
				colvarMatstatus.IsPrimaryKey = false;
				colvarMatstatus.IsForeignKey = false;
				colvarMatstatus.IsReadOnly = false;
				
						colvarMatstatus.DefaultSetting = @"((0))";
				colvarMatstatus.ForeignKeyTableName = "";
				schema.Columns.Add(colvarMatstatus);
				
				TableSchema.TableColumn colvarMatlength = new TableSchema.TableColumn(schema);
				colvarMatlength.ColumnName = "MATLENGTH";
				colvarMatlength.DataType = DbType.AnsiString;
				colvarMatlength.MaxLength = 10;
				colvarMatlength.AutoIncrement = false;
				colvarMatlength.IsNullable = false;
				colvarMatlength.IsPrimaryKey = false;
				colvarMatlength.IsForeignKey = false;
				colvarMatlength.IsReadOnly = false;
				
						colvarMatlength.DefaultSetting = @"('')";
				colvarMatlength.ForeignKeyTableName = "";
				schema.Columns.Add(colvarMatlength);
				
				TableSchema.TableColumn colvarCutstatus = new TableSchema.TableColumn(schema);
				colvarCutstatus.ColumnName = "CUTSTATUS";
				colvarCutstatus.DataType = DbType.AnsiString;
				colvarCutstatus.MaxLength = 4;
				colvarCutstatus.AutoIncrement = false;
				colvarCutstatus.IsNullable = false;
				colvarCutstatus.IsPrimaryKey = false;
				colvarCutstatus.IsForeignKey = false;
				colvarCutstatus.IsReadOnly = false;
				
						colvarCutstatus.DefaultSetting = @"((0))";
				colvarCutstatus.ForeignKeyTableName = "";
				schema.Columns.Add(colvarCutstatus);
				
				TableSchema.TableColumn colvarStatusdate = new TableSchema.TableColumn(schema);
				colvarStatusdate.ColumnName = "STATUSDATE";
				colvarStatusdate.DataType = DbType.DateTime;
				colvarStatusdate.MaxLength = 0;
				colvarStatusdate.AutoIncrement = false;
				colvarStatusdate.IsNullable = false;
				colvarStatusdate.IsPrimaryKey = false;
				colvarStatusdate.IsForeignKey = false;
				colvarStatusdate.IsReadOnly = false;
				
						colvarStatusdate.DefaultSetting = @"(getdate())";
				colvarStatusdate.ForeignKeyTableName = "";
				schema.Columns.Add(colvarStatusdate);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["Nowthwin"].AddSchema("T_CutterAPS",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("Apsid")]
		[Bindable(true)]
		public int Apsid 
		{
			get { return GetColumnValue<int>(Columns.Apsid); }
			set { SetColumnValue(Columns.Apsid, value); }
		}
		  
		[XmlAttribute("Scggdh")]
		[Bindable(true)]
		public string Scggdh 
		{
			get { return GetColumnValue<string>(Columns.Scggdh); }
			set { SetColumnValue(Columns.Scggdh, value); }
		}
		  
		[XmlAttribute("Plansid")]
		[Bindable(true)]
		public int Plansid 
		{
			get { return GetColumnValue<int>(Columns.Plansid); }
			set { SetColumnValue(Columns.Plansid, value); }
		}
		  
		[XmlAttribute("Sczsbh")]
		[Bindable(true)]
		public string Sczsbh 
		{
			get { return GetColumnValue<string>(Columns.Sczsbh); }
			set { SetColumnValue(Columns.Sczsbh, value); }
		}
		  
		[XmlAttribute("Filename")]
		[Bindable(true)]
		public string Filename 
		{
			get { return GetColumnValue<string>(Columns.Filename); }
			set { SetColumnValue(Columns.Filename, value); }
		}
		  
		[XmlAttribute("Cutternum")]
		[Bindable(true)]
		public int Cutternum 
		{
			get { return GetColumnValue<int>(Columns.Cutternum); }
			set { SetColumnValue(Columns.Cutternum, value); }
		}
		  
		[XmlAttribute("Cutcount")]
		[Bindable(true)]
		public int Cutcount 
		{
			get { return GetColumnValue<int>(Columns.Cutcount); }
			set { SetColumnValue(Columns.Cutcount, value); }
		}
		  
		[XmlAttribute("Cutdate")]
		[Bindable(true)]
		public string Cutdate 
		{
			get { return GetColumnValue<string>(Columns.Cutdate); }
			set { SetColumnValue(Columns.Cutdate, value); }
		}
		  
		[XmlAttribute("Cuttime")]
		[Bindable(true)]
		public string Cuttime 
		{
			get { return GetColumnValue<string>(Columns.Cuttime); }
			set { SetColumnValue(Columns.Cuttime, value); }
		}
		  
		[XmlAttribute("Opdate")]
		[Bindable(true)]
		public DateTime? Opdate 
		{
			get { return GetColumnValue<DateTime?>(Columns.Opdate); }
			set { SetColumnValue(Columns.Opdate, value); }
		}
		  
		[XmlAttribute("Barcode")]
		[Bindable(true)]
		public string Barcode 
		{
			get { return GetColumnValue<string>(Columns.Barcode); }
			set { SetColumnValue(Columns.Barcode, value); }
		}
		  
		[XmlAttribute("Filestatus")]
		[Bindable(true)]
		public string Filestatus 
		{
			get { return GetColumnValue<string>(Columns.Filestatus); }
			set { SetColumnValue(Columns.Filestatus, value); }
		}
		  
		[XmlAttribute("Matstatus")]
		[Bindable(true)]
		public string Matstatus 
		{
			get { return GetColumnValue<string>(Columns.Matstatus); }
			set { SetColumnValue(Columns.Matstatus, value); }
		}
		  
		[XmlAttribute("Matlength")]
		[Bindable(true)]
		public string Matlength 
		{
			get { return GetColumnValue<string>(Columns.Matlength); }
			set { SetColumnValue(Columns.Matlength, value); }
		}
		  
		[XmlAttribute("Cutstatus")]
		[Bindable(true)]
		public string Cutstatus 
		{
			get { return GetColumnValue<string>(Columns.Cutstatus); }
			set { SetColumnValue(Columns.Cutstatus, value); }
		}
		  
		[XmlAttribute("Statusdate")]
		[Bindable(true)]
		public DateTime Statusdate 
		{
			get { return GetColumnValue<DateTime>(Columns.Statusdate); }
			set { SetColumnValue(Columns.Statusdate, value); }
		}
		
		#endregion
		
		
			
		
		//no foreign key tables defined (0)
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(string varScggdh,int varPlansid,string varSczsbh,string varFilename,int varCutternum,int varCutcount,string varCutdate,string varCuttime,DateTime? varOpdate,string varBarcode,string varFilestatus,string varMatstatus,string varMatlength,string varCutstatus,DateTime varStatusdate)
		{
			TCutterAP item = new TCutterAP();
			
			item.Scggdh = varScggdh;
			
			item.Plansid = varPlansid;
			
			item.Sczsbh = varSczsbh;
			
			item.Filename = varFilename;
			
			item.Cutternum = varCutternum;
			
			item.Cutcount = varCutcount;
			
			item.Cutdate = varCutdate;
			
			item.Cuttime = varCuttime;
			
			item.Opdate = varOpdate;
			
			item.Barcode = varBarcode;
			
			item.Filestatus = varFilestatus;
			
			item.Matstatus = varMatstatus;
			
			item.Matlength = varMatlength;
			
			item.Cutstatus = varCutstatus;
			
			item.Statusdate = varStatusdate;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varApsid,string varScggdh,int varPlansid,string varSczsbh,string varFilename,int varCutternum,int varCutcount,string varCutdate,string varCuttime,DateTime? varOpdate,string varBarcode,string varFilestatus,string varMatstatus,string varMatlength,string varCutstatus,DateTime varStatusdate)
		{
			TCutterAP item = new TCutterAP();
			
				item.Apsid = varApsid;
			
				item.Scggdh = varScggdh;
			
				item.Plansid = varPlansid;
			
				item.Sczsbh = varSczsbh;
			
				item.Filename = varFilename;
			
				item.Cutternum = varCutternum;
			
				item.Cutcount = varCutcount;
			
				item.Cutdate = varCutdate;
			
				item.Cuttime = varCuttime;
			
				item.Opdate = varOpdate;
			
				item.Barcode = varBarcode;
			
				item.Filestatus = varFilestatus;
			
				item.Matstatus = varMatstatus;
			
				item.Matlength = varMatlength;
			
				item.Cutstatus = varCutstatus;
			
				item.Statusdate = varStatusdate;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn ApsidColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn ScggdhColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        public static TableSchema.TableColumn PlansidColumn
        {
            get { return Schema.Columns[2]; }
        }
        
        
        
        public static TableSchema.TableColumn SczsbhColumn
        {
            get { return Schema.Columns[3]; }
        }
        
        
        
        public static TableSchema.TableColumn FilenameColumn
        {
            get { return Schema.Columns[4]; }
        }
        
        
        
        public static TableSchema.TableColumn CutternumColumn
        {
            get { return Schema.Columns[5]; }
        }
        
        
        
        public static TableSchema.TableColumn CutcountColumn
        {
            get { return Schema.Columns[6]; }
        }
        
        
        
        public static TableSchema.TableColumn CutdateColumn
        {
            get { return Schema.Columns[7]; }
        }
        
        
        
        public static TableSchema.TableColumn CuttimeColumn
        {
            get { return Schema.Columns[8]; }
        }
        
        
        
        public static TableSchema.TableColumn OpdateColumn
        {
            get { return Schema.Columns[9]; }
        }
        
        
        
        public static TableSchema.TableColumn BarcodeColumn
        {
            get { return Schema.Columns[10]; }
        }
        
        
        
        public static TableSchema.TableColumn FilestatusColumn
        {
            get { return Schema.Columns[11]; }
        }
        
        
        
        public static TableSchema.TableColumn MatstatusColumn
        {
            get { return Schema.Columns[12]; }
        }
        
        
        
        public static TableSchema.TableColumn MatlengthColumn
        {
            get { return Schema.Columns[13]; }
        }
        
        
        
        public static TableSchema.TableColumn CutstatusColumn
        {
            get { return Schema.Columns[14]; }
        }
        
        
        
        public static TableSchema.TableColumn StatusdateColumn
        {
            get { return Schema.Columns[15]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string Apsid = @"APSID";
			 public static string Scggdh = @"SCGGDH";
			 public static string Plansid = @"PLANSID";
			 public static string Sczsbh = @"SCZSBH";
			 public static string Filename = @"FILENAME";
			 public static string Cutternum = @"CUTTERNUM";
			 public static string Cutcount = @"CUTCOUNT";
			 public static string Cutdate = @"CUTDATE";
			 public static string Cuttime = @"CUTTIME";
			 public static string Opdate = @"OPDATE";
			 public static string Barcode = @"BARCODE";
			 public static string Filestatus = @"FILESTATUS";
			 public static string Matstatus = @"MATSTATUS";
			 public static string Matlength = @"MATLENGTH";
			 public static string Cutstatus = @"CUTSTATUS";
			 public static string Statusdate = @"STATUSDATE";
						
		}
		#endregion
		
		#region Update PK Collections
		
        #endregion
    
        #region Deep Save
		
        #endregion
	}
}
