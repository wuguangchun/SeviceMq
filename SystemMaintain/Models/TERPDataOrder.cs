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
	/// Strongly-typed collection for the TERPDataOrder class.
	/// </summary>
    [Serializable]
	public partial class TERPDataOrderCollection : ActiveList<TERPDataOrder, TERPDataOrderCollection>
	{	   
		public TERPDataOrderCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>TERPDataOrderCollection</returns>
		public TERPDataOrderCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                TERPDataOrder o = this[i];
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
	/// This is an ActiveRecord class which wraps the T_ERPData_Order table.
	/// </summary>
	[Serializable]
	public partial class TERPDataOrder : ActiveRecord<TERPDataOrder>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public TERPDataOrder()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public TERPDataOrder(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public TERPDataOrder(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public TERPDataOrder(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("T_ERPData_Order", TableType.Table, DataService.GetInstance("Nowthwin"));
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
				
				TableSchema.TableColumn colvarSchtbh = new TableSchema.TableColumn(schema);
				colvarSchtbh.ColumnName = "SCHTBH";
				colvarSchtbh.DataType = DbType.String;
				colvarSchtbh.MaxLength = 20;
				colvarSchtbh.AutoIncrement = false;
				colvarSchtbh.IsNullable = true;
				colvarSchtbh.IsPrimaryKey = false;
				colvarSchtbh.IsForeignKey = false;
				colvarSchtbh.IsReadOnly = false;
				colvarSchtbh.DefaultSetting = @"";
				colvarSchtbh.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSchtbh);
				
				TableSchema.TableColumn colvarScggdh = new TableSchema.TableColumn(schema);
				colvarScggdh.ColumnName = "SCGGDH";
				colvarScggdh.DataType = DbType.String;
				colvarScggdh.MaxLength = 50;
				colvarScggdh.AutoIncrement = false;
				colvarScggdh.IsNullable = true;
				colvarScggdh.IsPrimaryKey = false;
				colvarScggdh.IsForeignKey = false;
				colvarScggdh.IsReadOnly = false;
				colvarScggdh.DefaultSetting = @"";
				colvarScggdh.ForeignKeyTableName = "";
				schema.Columns.Add(colvarScggdh);
				
				TableSchema.TableColumn colvarScggxh = new TableSchema.TableColumn(schema);
				colvarScggxh.ColumnName = "SCGGXH";
				colvarScggxh.DataType = DbType.String;
				colvarScggxh.MaxLength = 50;
				colvarScggxh.AutoIncrement = false;
				colvarScggxh.IsNullable = true;
				colvarScggxh.IsPrimaryKey = false;
				colvarScggxh.IsForeignKey = false;
				colvarScggxh.IsReadOnly = false;
				colvarScggxh.DefaultSetting = @"";
				colvarScggxh.ForeignKeyTableName = "";
				schema.Columns.Add(colvarScggxh);
				
				TableSchema.TableColumn colvarDtxtwpmc = new TableSchema.TableColumn(schema);
				colvarDtxtwpmc.ColumnName = "DTXTWPMC";
				colvarDtxtwpmc.DataType = DbType.String;
				colvarDtxtwpmc.MaxLength = 20;
				colvarDtxtwpmc.AutoIncrement = false;
				colvarDtxtwpmc.IsNullable = true;
				colvarDtxtwpmc.IsPrimaryKey = false;
				colvarDtxtwpmc.IsForeignKey = false;
				colvarDtxtwpmc.IsReadOnly = false;
				colvarDtxtwpmc.DefaultSetting = @"";
				colvarDtxtwpmc.ForeignKeyTableName = "";
				schema.Columns.Add(colvarDtxtwpmc);
				
				TableSchema.TableColumn colvarWPSXLB19 = new TableSchema.TableColumn(schema);
				colvarWPSXLB19.ColumnName = "WPSXLB19";
				colvarWPSXLB19.DataType = DbType.String;
				colvarWPSXLB19.MaxLength = 20;
				colvarWPSXLB19.AutoIncrement = false;
				colvarWPSXLB19.IsNullable = true;
				colvarWPSXLB19.IsPrimaryKey = false;
				colvarWPSXLB19.IsForeignKey = false;
				colvarWPSXLB19.IsReadOnly = false;
				colvarWPSXLB19.DefaultSetting = @"";
				colvarWPSXLB19.ForeignKeyTableName = "";
				schema.Columns.Add(colvarWPSXLB19);
				
				TableSchema.TableColumn colvarXtwpys = new TableSchema.TableColumn(schema);
				colvarXtwpys.ColumnName = "XTWPYS";
				colvarXtwpys.DataType = DbType.String;
				colvarXtwpys.MaxLength = 20;
				colvarXtwpys.AutoIncrement = false;
				colvarXtwpys.IsNullable = true;
				colvarXtwpys.IsPrimaryKey = false;
				colvarXtwpys.IsForeignKey = false;
				colvarXtwpys.IsReadOnly = false;
				colvarXtwpys.DefaultSetting = @"";
				colvarXtwpys.ForeignKeyTableName = "";
				schema.Columns.Add(colvarXtwpys);
				
				TableSchema.TableColumn colvarScqdrq = new TableSchema.TableColumn(schema);
				colvarScqdrq.ColumnName = "SCQDRQ";
				colvarScqdrq.DataType = DbType.DateTime;
				colvarScqdrq.MaxLength = 0;
				colvarScqdrq.AutoIncrement = false;
				colvarScqdrq.IsNullable = true;
				colvarScqdrq.IsPrimaryKey = false;
				colvarScqdrq.IsForeignKey = false;
				colvarScqdrq.IsReadOnly = false;
				colvarScqdrq.DefaultSetting = @"";
				colvarScqdrq.ForeignKeyTableName = "";
				schema.Columns.Add(colvarScqdrq);
				
				TableSchema.TableColumn colvarScjhrq = new TableSchema.TableColumn(schema);
				colvarScjhrq.ColumnName = "SCJHRQ";
				colvarScjhrq.DataType = DbType.DateTime;
				colvarScjhrq.MaxLength = 0;
				colvarScjhrq.AutoIncrement = false;
				colvarScjhrq.IsNullable = true;
				colvarScjhrq.IsPrimaryKey = false;
				colvarScjhrq.IsForeignKey = false;
				colvarScjhrq.IsReadOnly = false;
				colvarScjhrq.DefaultSetting = @"";
				colvarScjhrq.ForeignKeyTableName = "";
				schema.Columns.Add(colvarScjhrq);
				
				TableSchema.TableColumn colvarXttxhm = new TableSchema.TableColumn(schema);
				colvarXttxhm.ColumnName = "XTTXHM";
				colvarXttxhm.DataType = DbType.String;
				colvarXttxhm.MaxLength = 20;
				colvarXttxhm.AutoIncrement = false;
				colvarXttxhm.IsNullable = true;
				colvarXttxhm.IsPrimaryKey = false;
				colvarXttxhm.IsForeignKey = false;
				colvarXttxhm.IsReadOnly = false;
				colvarXttxhm.DefaultSetting = @"";
				colvarXttxhm.ForeignKeyTableName = "";
				schema.Columns.Add(colvarXttxhm);
				
				TableSchema.TableColumn colvarSchtsl = new TableSchema.TableColumn(schema);
				colvarSchtsl.ColumnName = "SCHTSL";
				colvarSchtsl.DataType = DbType.String;
				colvarSchtsl.MaxLength = 20;
				colvarSchtsl.AutoIncrement = false;
				colvarSchtsl.IsNullable = true;
				colvarSchtsl.IsPrimaryKey = false;
				colvarSchtsl.IsForeignKey = false;
				colvarSchtsl.IsReadOnly = false;
				colvarSchtsl.DefaultSetting = @"";
				colvarSchtsl.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSchtsl);
				
				TableSchema.TableColumn colvarScggbz = new TableSchema.TableColumn(schema);
				colvarScggbz.ColumnName = "SCGGBZ";
				colvarScggbz.DataType = DbType.String;
				colvarScggbz.MaxLength = 50;
				colvarScggbz.AutoIncrement = false;
				colvarScggbz.IsNullable = true;
				colvarScggbz.IsPrimaryKey = false;
				colvarScggbz.IsForeignKey = false;
				colvarScggbz.IsReadOnly = false;
				colvarScggbz.DefaultSetting = @"";
				colvarScggbz.ForeignKeyTableName = "";
				schema.Columns.Add(colvarScggbz);
				
				TableSchema.TableColumn colvarSckhxm = new TableSchema.TableColumn(schema);
				colvarSckhxm.ColumnName = "SCKHXM";
				colvarSckhxm.DataType = DbType.String;
				colvarSckhxm.MaxLength = 50;
				colvarSckhxm.AutoIncrement = false;
				colvarSckhxm.IsNullable = true;
				colvarSckhxm.IsPrimaryKey = false;
				colvarSckhxm.IsForeignKey = false;
				colvarSckhxm.IsReadOnly = false;
				colvarSckhxm.DefaultSetting = @"";
				colvarSckhxm.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSckhxm);
				
				TableSchema.TableColumn colvarSjbh = new TableSchema.TableColumn(schema);
				colvarSjbh.ColumnName = "SJBH";
				colvarSjbh.DataType = DbType.String;
				colvarSjbh.MaxLength = 50;
				colvarSjbh.AutoIncrement = false;
				colvarSjbh.IsNullable = true;
				colvarSjbh.IsPrimaryKey = false;
				colvarSjbh.IsForeignKey = false;
				colvarSjbh.IsReadOnly = false;
				colvarSjbh.DefaultSetting = @"";
				colvarSjbh.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSjbh);
				
				TableSchema.TableColumn colvarXtxmdm = new TableSchema.TableColumn(schema);
				colvarXtxmdm.ColumnName = "XTXMDM";
				colvarXtxmdm.DataType = DbType.String;
				colvarXtxmdm.MaxLength = 20;
				colvarXtxmdm.AutoIncrement = false;
				colvarXtxmdm.IsNullable = true;
				colvarXtxmdm.IsPrimaryKey = false;
				colvarXtxmdm.IsForeignKey = false;
				colvarXtxmdm.IsReadOnly = false;
				colvarXtxmdm.DefaultSetting = @"";
				colvarXtxmdm.ForeignKeyTableName = "";
				schema.Columns.Add(colvarXtxmdm);
				
				TableSchema.TableColumn colvarScytdm = new TableSchema.TableColumn(schema);
				colvarScytdm.ColumnName = "SCYTDM";
				colvarScytdm.DataType = DbType.String;
				colvarScytdm.MaxLength = 500;
				colvarScytdm.AutoIncrement = false;
				colvarScytdm.IsNullable = true;
				colvarScytdm.IsPrimaryKey = false;
				colvarScytdm.IsForeignKey = false;
				colvarScytdm.IsReadOnly = false;
				colvarScytdm.DefaultSetting = @"";
				colvarScytdm.ForeignKeyTableName = "";
				schema.Columns.Add(colvarScytdm);
				
				TableSchema.TableColumn colvarScytmc = new TableSchema.TableColumn(schema);
				colvarScytmc.ColumnName = "SCYTMC";
				colvarScytmc.DataType = DbType.String;
				colvarScytmc.MaxLength = 500;
				colvarScytmc.AutoIncrement = false;
				colvarScytmc.IsNullable = true;
				colvarScytmc.IsPrimaryKey = false;
				colvarScytmc.IsForeignKey = false;
				colvarScytmc.IsReadOnly = false;
				colvarScytmc.DefaultSetting = @"";
				colvarScytmc.ForeignKeyTableName = "";
				schema.Columns.Add(colvarScytmc);
				
				TableSchema.TableColumn colvarFlnm = new TableSchema.TableColumn(schema);
				colvarFlnm.ColumnName = "FLNM";
				colvarFlnm.DataType = DbType.String;
				colvarFlnm.MaxLength = 500;
				colvarFlnm.AutoIncrement = false;
				colvarFlnm.IsNullable = true;
				colvarFlnm.IsPrimaryKey = false;
				colvarFlnm.IsForeignKey = false;
				colvarFlnm.IsReadOnly = false;
				colvarFlnm.DefaultSetting = @"";
				colvarFlnm.ForeignKeyTableName = "";
				schema.Columns.Add(colvarFlnm);
				
				TableSchema.TableColumn colvarXtwpmc = new TableSchema.TableColumn(schema);
				colvarXtwpmc.ColumnName = "XTWPMC";
				colvarXtwpmc.DataType = DbType.String;
				colvarXtwpmc.MaxLength = 500;
				colvarXtwpmc.AutoIncrement = false;
				colvarXtwpmc.IsNullable = true;
				colvarXtwpmc.IsPrimaryKey = false;
				colvarXtwpmc.IsForeignKey = false;
				colvarXtwpmc.IsReadOnly = false;
				colvarXtwpmc.DefaultSetting = @"";
				colvarXtwpmc.ForeignKeyTableName = "";
				schema.Columns.Add(colvarXtwpmc);
				
				TableSchema.TableColumn colvarXtwpxh = new TableSchema.TableColumn(schema);
				colvarXtwpxh.ColumnName = "XTWPXH";
				colvarXtwpxh.DataType = DbType.String;
				colvarXtwpxh.MaxLength = 500;
				colvarXtwpxh.AutoIncrement = false;
				colvarXtwpxh.IsNullable = true;
				colvarXtwpxh.IsPrimaryKey = false;
				colvarXtwpxh.IsForeignKey = false;
				colvarXtwpxh.IsReadOnly = false;
				colvarXtwpxh.DefaultSetting = @"";
				colvarXtwpxh.ForeignKeyTableName = "";
				schema.Columns.Add(colvarXtwpxh);
				
				TableSchema.TableColumn colvarErptype = new TableSchema.TableColumn(schema);
				colvarErptype.ColumnName = "ERPTYPE";
				colvarErptype.DataType = DbType.String;
				colvarErptype.MaxLength = 50;
				colvarErptype.AutoIncrement = false;
				colvarErptype.IsNullable = true;
				colvarErptype.IsPrimaryKey = false;
				colvarErptype.IsForeignKey = false;
				colvarErptype.IsReadOnly = false;
				colvarErptype.DefaultSetting = @"";
				colvarErptype.ForeignKeyTableName = "";
				schema.Columns.Add(colvarErptype);
				
				TableSchema.TableColumn colvarScjhdd = new TableSchema.TableColumn(schema);
				colvarScjhdd.ColumnName = "scjhdd";
				colvarScjhdd.DataType = DbType.String;
				colvarScjhdd.MaxLength = 50;
				colvarScjhdd.AutoIncrement = false;
				colvarScjhdd.IsNullable = true;
				colvarScjhdd.IsPrimaryKey = false;
				colvarScjhdd.IsForeignKey = false;
				colvarScjhdd.IsReadOnly = false;
				colvarScjhdd.DefaultSetting = @"";
				colvarScjhdd.ForeignKeyTableName = "";
				schema.Columns.Add(colvarScjhdd);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["Nowthwin"].AddSchema("T_ERPData_Order",schema);
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
		  
		[XmlAttribute("Schtbh")]
		[Bindable(true)]
		public string Schtbh 
		{
			get { return GetColumnValue<string>(Columns.Schtbh); }
			set { SetColumnValue(Columns.Schtbh, value); }
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
		public string Scggxh 
		{
			get { return GetColumnValue<string>(Columns.Scggxh); }
			set { SetColumnValue(Columns.Scggxh, value); }
		}
		  
		[XmlAttribute("Dtxtwpmc")]
		[Bindable(true)]
		public string Dtxtwpmc 
		{
			get { return GetColumnValue<string>(Columns.Dtxtwpmc); }
			set { SetColumnValue(Columns.Dtxtwpmc, value); }
		}
		  
		[XmlAttribute("WPSXLB19")]
		[Bindable(true)]
		public string WPSXLB19 
		{
			get { return GetColumnValue<string>(Columns.WPSXLB19); }
			set { SetColumnValue(Columns.WPSXLB19, value); }
		}
		  
		[XmlAttribute("Xtwpys")]
		[Bindable(true)]
		public string Xtwpys 
		{
			get { return GetColumnValue<string>(Columns.Xtwpys); }
			set { SetColumnValue(Columns.Xtwpys, value); }
		}
		  
		[XmlAttribute("Scqdrq")]
		[Bindable(true)]
		public DateTime? Scqdrq 
		{
			get { return GetColumnValue<DateTime?>(Columns.Scqdrq); }
			set { SetColumnValue(Columns.Scqdrq, value); }
		}
		  
		[XmlAttribute("Scjhrq")]
		[Bindable(true)]
		public DateTime? Scjhrq 
		{
			get { return GetColumnValue<DateTime?>(Columns.Scjhrq); }
			set { SetColumnValue(Columns.Scjhrq, value); }
		}
		  
		[XmlAttribute("Xttxhm")]
		[Bindable(true)]
		public string Xttxhm 
		{
			get { return GetColumnValue<string>(Columns.Xttxhm); }
			set { SetColumnValue(Columns.Xttxhm, value); }
		}
		  
		[XmlAttribute("Schtsl")]
		[Bindable(true)]
		public string Schtsl 
		{
			get { return GetColumnValue<string>(Columns.Schtsl); }
			set { SetColumnValue(Columns.Schtsl, value); }
		}
		  
		[XmlAttribute("Scggbz")]
		[Bindable(true)]
		public string Scggbz 
		{
			get { return GetColumnValue<string>(Columns.Scggbz); }
			set { SetColumnValue(Columns.Scggbz, value); }
		}
		  
		[XmlAttribute("Sckhxm")]
		[Bindable(true)]
		public string Sckhxm 
		{
			get { return GetColumnValue<string>(Columns.Sckhxm); }
			set { SetColumnValue(Columns.Sckhxm, value); }
		}
		  
		[XmlAttribute("Sjbh")]
		[Bindable(true)]
		public string Sjbh 
		{
			get { return GetColumnValue<string>(Columns.Sjbh); }
			set { SetColumnValue(Columns.Sjbh, value); }
		}
		  
		[XmlAttribute("Xtxmdm")]
		[Bindable(true)]
		public string Xtxmdm 
		{
			get { return GetColumnValue<string>(Columns.Xtxmdm); }
			set { SetColumnValue(Columns.Xtxmdm, value); }
		}
		  
		[XmlAttribute("Scytdm")]
		[Bindable(true)]
		public string Scytdm 
		{
			get { return GetColumnValue<string>(Columns.Scytdm); }
			set { SetColumnValue(Columns.Scytdm, value); }
		}
		  
		[XmlAttribute("Scytmc")]
		[Bindable(true)]
		public string Scytmc 
		{
			get { return GetColumnValue<string>(Columns.Scytmc); }
			set { SetColumnValue(Columns.Scytmc, value); }
		}
		  
		[XmlAttribute("Flnm")]
		[Bindable(true)]
		public string Flnm 
		{
			get { return GetColumnValue<string>(Columns.Flnm); }
			set { SetColumnValue(Columns.Flnm, value); }
		}
		  
		[XmlAttribute("Xtwpmc")]
		[Bindable(true)]
		public string Xtwpmc 
		{
			get { return GetColumnValue<string>(Columns.Xtwpmc); }
			set { SetColumnValue(Columns.Xtwpmc, value); }
		}
		  
		[XmlAttribute("Xtwpxh")]
		[Bindable(true)]
		public string Xtwpxh 
		{
			get { return GetColumnValue<string>(Columns.Xtwpxh); }
			set { SetColumnValue(Columns.Xtwpxh, value); }
		}
		  
		[XmlAttribute("Erptype")]
		[Bindable(true)]
		public string Erptype 
		{
			get { return GetColumnValue<string>(Columns.Erptype); }
			set { SetColumnValue(Columns.Erptype, value); }
		}
		  
		[XmlAttribute("Scjhdd")]
		[Bindable(true)]
		public string Scjhdd 
		{
			get { return GetColumnValue<string>(Columns.Scjhdd); }
			set { SetColumnValue(Columns.Scjhdd, value); }
		}
		
		#endregion
		
		
			
		
		//no foreign key tables defined (0)
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(string varSchtbh,string varScggdh,string varScggxh,string varDtxtwpmc,string varWPSXLB19,string varXtwpys,DateTime? varScqdrq,DateTime? varScjhrq,string varXttxhm,string varSchtsl,string varScggbz,string varSckhxm,string varSjbh,string varXtxmdm,string varScytdm,string varScytmc,string varFlnm,string varXtwpmc,string varXtwpxh,string varErptype,string varScjhdd)
		{
			TERPDataOrder item = new TERPDataOrder();
			
			item.Schtbh = varSchtbh;
			
			item.Scggdh = varScggdh;
			
			item.Scggxh = varScggxh;
			
			item.Dtxtwpmc = varDtxtwpmc;
			
			item.WPSXLB19 = varWPSXLB19;
			
			item.Xtwpys = varXtwpys;
			
			item.Scqdrq = varScqdrq;
			
			item.Scjhrq = varScjhrq;
			
			item.Xttxhm = varXttxhm;
			
			item.Schtsl = varSchtsl;
			
			item.Scggbz = varScggbz;
			
			item.Sckhxm = varSckhxm;
			
			item.Sjbh = varSjbh;
			
			item.Xtxmdm = varXtxmdm;
			
			item.Scytdm = varScytdm;
			
			item.Scytmc = varScytmc;
			
			item.Flnm = varFlnm;
			
			item.Xtwpmc = varXtwpmc;
			
			item.Xtwpxh = varXtwpxh;
			
			item.Erptype = varErptype;
			
			item.Scjhdd = varScjhdd;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varId,string varSchtbh,string varScggdh,string varScggxh,string varDtxtwpmc,string varWPSXLB19,string varXtwpys,DateTime? varScqdrq,DateTime? varScjhrq,string varXttxhm,string varSchtsl,string varScggbz,string varSckhxm,string varSjbh,string varXtxmdm,string varScytdm,string varScytmc,string varFlnm,string varXtwpmc,string varXtwpxh,string varErptype,string varScjhdd)
		{
			TERPDataOrder item = new TERPDataOrder();
			
				item.Id = varId;
			
				item.Schtbh = varSchtbh;
			
				item.Scggdh = varScggdh;
			
				item.Scggxh = varScggxh;
			
				item.Dtxtwpmc = varDtxtwpmc;
			
				item.WPSXLB19 = varWPSXLB19;
			
				item.Xtwpys = varXtwpys;
			
				item.Scqdrq = varScqdrq;
			
				item.Scjhrq = varScjhrq;
			
				item.Xttxhm = varXttxhm;
			
				item.Schtsl = varSchtsl;
			
				item.Scggbz = varScggbz;
			
				item.Sckhxm = varSckhxm;
			
				item.Sjbh = varSjbh;
			
				item.Xtxmdm = varXtxmdm;
			
				item.Scytdm = varScytdm;
			
				item.Scytmc = varScytmc;
			
				item.Flnm = varFlnm;
			
				item.Xtwpmc = varXtwpmc;
			
				item.Xtwpxh = varXtwpxh;
			
				item.Erptype = varErptype;
			
				item.Scjhdd = varScjhdd;
			
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
        
        
        
        public static TableSchema.TableColumn SchtbhColumn
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
        
        
        
        public static TableSchema.TableColumn DtxtwpmcColumn
        {
            get { return Schema.Columns[4]; }
        }
        
        
        
        public static TableSchema.TableColumn WPSXLB19Column
        {
            get { return Schema.Columns[5]; }
        }
        
        
        
        public static TableSchema.TableColumn XtwpysColumn
        {
            get { return Schema.Columns[6]; }
        }
        
        
        
        public static TableSchema.TableColumn ScqdrqColumn
        {
            get { return Schema.Columns[7]; }
        }
        
        
        
        public static TableSchema.TableColumn ScjhrqColumn
        {
            get { return Schema.Columns[8]; }
        }
        
        
        
        public static TableSchema.TableColumn XttxhmColumn
        {
            get { return Schema.Columns[9]; }
        }
        
        
        
        public static TableSchema.TableColumn SchtslColumn
        {
            get { return Schema.Columns[10]; }
        }
        
        
        
        public static TableSchema.TableColumn ScggbzColumn
        {
            get { return Schema.Columns[11]; }
        }
        
        
        
        public static TableSchema.TableColumn SckhxmColumn
        {
            get { return Schema.Columns[12]; }
        }
        
        
        
        public static TableSchema.TableColumn SjbhColumn
        {
            get { return Schema.Columns[13]; }
        }
        
        
        
        public static TableSchema.TableColumn XtxmdmColumn
        {
            get { return Schema.Columns[14]; }
        }
        
        
        
        public static TableSchema.TableColumn ScytdmColumn
        {
            get { return Schema.Columns[15]; }
        }
        
        
        
        public static TableSchema.TableColumn ScytmcColumn
        {
            get { return Schema.Columns[16]; }
        }
        
        
        
        public static TableSchema.TableColumn FlnmColumn
        {
            get { return Schema.Columns[17]; }
        }
        
        
        
        public static TableSchema.TableColumn XtwpmcColumn
        {
            get { return Schema.Columns[18]; }
        }
        
        
        
        public static TableSchema.TableColumn XtwpxhColumn
        {
            get { return Schema.Columns[19]; }
        }
        
        
        
        public static TableSchema.TableColumn ErptypeColumn
        {
            get { return Schema.Columns[20]; }
        }
        
        
        
        public static TableSchema.TableColumn ScjhddColumn
        {
            get { return Schema.Columns[21]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string Id = @"id";
			 public static string Schtbh = @"SCHTBH";
			 public static string Scggdh = @"SCGGDH";
			 public static string Scggxh = @"SCGGXH";
			 public static string Dtxtwpmc = @"DTXTWPMC";
			 public static string WPSXLB19 = @"WPSXLB19";
			 public static string Xtwpys = @"XTWPYS";
			 public static string Scqdrq = @"SCQDRQ";
			 public static string Scjhrq = @"SCJHRQ";
			 public static string Xttxhm = @"XTTXHM";
			 public static string Schtsl = @"SCHTSL";
			 public static string Scggbz = @"SCGGBZ";
			 public static string Sckhxm = @"SCKHXM";
			 public static string Sjbh = @"SJBH";
			 public static string Xtxmdm = @"XTXMDM";
			 public static string Scytdm = @"SCYTDM";
			 public static string Scytmc = @"SCYTMC";
			 public static string Flnm = @"FLNM";
			 public static string Xtwpmc = @"XTWPMC";
			 public static string Xtwpxh = @"XTWPXH";
			 public static string Erptype = @"ERPTYPE";
			 public static string Scjhdd = @"scjhdd";
						
		}
		#endregion
		
		#region Update PK Collections
		
        #endregion
    
        #region Deep Save
		
        #endregion
	}
}
