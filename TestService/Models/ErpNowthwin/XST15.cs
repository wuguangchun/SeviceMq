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
	/// Strongly-typed collection for the XST15 class.
	/// </summary>
    [Serializable]
	public partial class XST15Collection : ActiveList<XST15, XST15Collection>
	{	   
		public XST15Collection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>XST15Collection</returns>
		public XST15Collection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                XST15 o = this[i];
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
	/// This is an ActiveRecord class which wraps the XST15 table.
	/// </summary>
	[Serializable]
	public partial class XST15 : ActiveRecord<XST15>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public XST15()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public XST15(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public XST15(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public XST15(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("XST15", TableType.Table, DataService.GetInstance("ErpNowthwin"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"FYERP";
				//columns
				
				TableSchema.TableColumn colvarXsjhfh = new TableSchema.TableColumn(schema);
				colvarXsjhfh.ColumnName = "XSJHFH";
				colvarXsjhfh.DataType = DbType.DateTime;
				colvarXsjhfh.MaxLength = 0;
				colvarXsjhfh.AutoIncrement = false;
				colvarXsjhfh.IsNullable = true;
				colvarXsjhfh.IsPrimaryKey = false;
				colvarXsjhfh.IsForeignKey = false;
				colvarXsjhfh.IsReadOnly = false;
				colvarXsjhfh.DefaultSetting = @"";
				colvarXsjhfh.ForeignKeyTableName = "";
				schema.Columns.Add(colvarXsjhfh);
				
				TableSchema.TableColumn colvarXsjhdh = new TableSchema.TableColumn(schema);
				colvarXsjhdh.ColumnName = "XSJHDH";
				colvarXsjhdh.DataType = DbType.DateTime;
				colvarXsjhdh.MaxLength = 0;
				colvarXsjhdh.AutoIncrement = false;
				colvarXsjhdh.IsNullable = true;
				colvarXsjhdh.IsPrimaryKey = false;
				colvarXsjhdh.IsForeignKey = false;
				colvarXsjhdh.IsReadOnly = false;
				colvarXsjhdh.DefaultSetting = @"";
				colvarXsjhdh.ForeignKeyTableName = "";
				schema.Columns.Add(colvarXsjhdh);
				
				TableSchema.TableColumn colvarXsykfy = new TableSchema.TableColumn(schema);
				colvarXsykfy.ColumnName = "XSYKFY";
				colvarXsykfy.DataType = DbType.Decimal;
				colvarXsykfy.MaxLength = 0;
				colvarXsykfy.AutoIncrement = false;
				colvarXsykfy.IsNullable = true;
				colvarXsykfy.IsPrimaryKey = false;
				colvarXsykfy.IsForeignKey = false;
				colvarXsykfy.IsReadOnly = false;
				colvarXsykfy.DefaultSetting = @"";
				colvarXsykfy.ForeignKeyTableName = "";
				schema.Columns.Add(colvarXsykfy);
				
				TableSchema.TableColumn colvarXsyfhl = new TableSchema.TableColumn(schema);
				colvarXsyfhl.ColumnName = "XSYFHL";
				colvarXsyfhl.DataType = DbType.Decimal;
				colvarXsyfhl.MaxLength = 0;
				colvarXsyfhl.AutoIncrement = false;
				colvarXsyfhl.IsNullable = true;
				colvarXsyfhl.IsPrimaryKey = false;
				colvarXsyfhl.IsForeignKey = false;
				colvarXsyfhl.IsReadOnly = false;
				colvarXsyfhl.DefaultSetting = @"";
				colvarXsyfhl.ForeignKeyTableName = "";
				schema.Columns.Add(colvarXsyfhl);
				
				TableSchema.TableColumn colvarXstjbz = new TableSchema.TableColumn(schema);
				colvarXstjbz.ColumnName = "XSTJBZ";
				colvarXstjbz.DataType = DbType.String;
				colvarXstjbz.MaxLength = 1;
				colvarXstjbz.AutoIncrement = false;
				colvarXstjbz.IsNullable = true;
				colvarXstjbz.IsPrimaryKey = false;
				colvarXstjbz.IsForeignKey = false;
				colvarXstjbz.IsReadOnly = false;
				colvarXstjbz.DefaultSetting = @"";
				colvarXstjbz.ForeignKeyTableName = "";
				schema.Columns.Add(colvarXstjbz);
				
				TableSchema.TableColumn colvarXsthbz = new TableSchema.TableColumn(schema);
				colvarXsthbz.ColumnName = "XSTHBZ";
				colvarXsthbz.DataType = DbType.String;
				colvarXsthbz.MaxLength = 1;
				colvarXsthbz.AutoIncrement = false;
				colvarXsthbz.IsNullable = true;
				colvarXsthbz.IsPrimaryKey = false;
				colvarXsthbz.IsForeignKey = false;
				colvarXsthbz.IsReadOnly = false;
				colvarXsthbz.DefaultSetting = @"";
				colvarXsthbz.ForeignKeyTableName = "";
				schema.Columns.Add(colvarXsthbz);
				
				TableSchema.TableColumn colvarKcshck = new TableSchema.TableColumn(schema);
				colvarKcshck.ColumnName = "KCSHCK";
				colvarKcshck.DataType = DbType.String;
				colvarKcshck.MaxLength = 8;
				colvarKcshck.AutoIncrement = false;
				colvarKcshck.IsNullable = true;
				colvarKcshck.IsPrimaryKey = false;
				colvarKcshck.IsForeignKey = false;
				colvarKcshck.IsReadOnly = false;
				colvarKcshck.DefaultSetting = @"";
				colvarKcshck.ForeignKeyTableName = "";
				schema.Columns.Add(colvarKcshck);
				
				TableSchema.TableColumn colvarXsphzk = new TableSchema.TableColumn(schema);
				colvarXsphzk.ColumnName = "XSPHZK";
				colvarXsphzk.DataType = DbType.Decimal;
				colvarXsphzk.MaxLength = 0;
				colvarXsphzk.AutoIncrement = false;
				colvarXsphzk.IsNullable = true;
				colvarXsphzk.IsPrimaryKey = false;
				colvarXsphzk.IsForeignKey = false;
				colvarXsphzk.IsReadOnly = false;
				colvarXsphzk.DefaultSetting = @"";
				colvarXsphzk.ForeignKeyTableName = "";
				schema.Columns.Add(colvarXsphzk);
				
				TableSchema.TableColumn colvarScggdh = new TableSchema.TableColumn(schema);
				colvarScggdh.ColumnName = "SCGGDH";
				colvarScggdh.DataType = DbType.String;
				colvarScggdh.MaxLength = 12;
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
				colvarScggxh.DataType = DbType.Decimal;
				colvarScggxh.MaxLength = 0;
				colvarScggxh.AutoIncrement = false;
				colvarScggxh.IsNullable = true;
				colvarScggxh.IsPrimaryKey = false;
				colvarScggxh.IsForeignKey = false;
				colvarScggxh.IsReadOnly = false;
				colvarScggxh.DefaultSetting = @"";
				colvarScggxh.ForeignKeyTableName = "";
				schema.Columns.Add(colvarScggxh);
				
				TableSchema.TableColumn colvarXsphdh = new TableSchema.TableColumn(schema);
				colvarXsphdh.ColumnName = "XSPHDH";
				colvarXsphdh.DataType = DbType.String;
				colvarXsphdh.MaxLength = 12;
				colvarXsphdh.AutoIncrement = false;
				colvarXsphdh.IsNullable = false;
				colvarXsphdh.IsPrimaryKey = true;
				colvarXsphdh.IsForeignKey = false;
				colvarXsphdh.IsReadOnly = false;
				colvarXsphdh.DefaultSetting = @"";
				colvarXsphdh.ForeignKeyTableName = "";
				schema.Columns.Add(colvarXsphdh);
				
				TableSchema.TableColumn colvarXsphhh = new TableSchema.TableColumn(schema);
				colvarXsphhh.ColumnName = "XSPHHH";
				colvarXsphhh.DataType = DbType.Decimal;
				colvarXsphhh.MaxLength = 0;
				colvarXsphhh.AutoIncrement = false;
				colvarXsphhh.IsNullable = false;
				colvarXsphhh.IsPrimaryKey = true;
				colvarXsphhh.IsForeignKey = false;
				colvarXsphhh.IsReadOnly = false;
				colvarXsphhh.DefaultSetting = @"";
				colvarXsphhh.ForeignKeyTableName = "";
				schema.Columns.Add(colvarXsphhh);
				
				TableSchema.TableColumn colvarXsyhdh = new TableSchema.TableColumn(schema);
				colvarXsyhdh.ColumnName = "XSYHDH";
				colvarXsyhdh.DataType = DbType.String;
				colvarXsyhdh.MaxLength = 12;
				colvarXsyhdh.AutoIncrement = false;
				colvarXsyhdh.IsNullable = true;
				colvarXsyhdh.IsPrimaryKey = false;
				colvarXsyhdh.IsForeignKey = false;
				colvarXsyhdh.IsReadOnly = false;
				colvarXsyhdh.DefaultSetting = @"";
				colvarXsyhdh.ForeignKeyTableName = "";
				schema.Columns.Add(colvarXsyhdh);
				
				TableSchema.TableColumn colvarXsydhh = new TableSchema.TableColumn(schema);
				colvarXsydhh.ColumnName = "XSYDHH";
				colvarXsydhh.DataType = DbType.Decimal;
				colvarXsydhh.MaxLength = 0;
				colvarXsydhh.AutoIncrement = false;
				colvarXsydhh.IsNullable = true;
				colvarXsydhh.IsPrimaryKey = false;
				colvarXsydhh.IsForeignKey = false;
				colvarXsydhh.IsReadOnly = false;
				colvarXsydhh.DefaultSetting = @"";
				colvarXsydhh.ForeignKeyTableName = "";
				schema.Columns.Add(colvarXsydhh);
				
				TableSchema.TableColumn colvarXtysfs = new TableSchema.TableColumn(schema);
				colvarXtysfs.ColumnName = "XTYSFS";
				colvarXtysfs.DataType = DbType.String;
				colvarXtysfs.MaxLength = 4;
				colvarXtysfs.AutoIncrement = false;
				colvarXtysfs.IsNullable = true;
				colvarXtysfs.IsPrimaryKey = false;
				colvarXtysfs.IsForeignKey = false;
				colvarXtysfs.IsReadOnly = false;
				colvarXtysfs.DefaultSetting = @"";
				colvarXtysfs.ForeignKeyTableName = "";
				schema.Columns.Add(colvarXtysfs);
				
				TableSchema.TableColumn colvarKcckdm = new TableSchema.TableColumn(schema);
				colvarKcckdm.ColumnName = "KCCKDM";
				colvarKcckdm.DataType = DbType.String;
				colvarKcckdm.MaxLength = 8;
				colvarKcckdm.AutoIncrement = false;
				colvarKcckdm.IsNullable = true;
				colvarKcckdm.IsPrimaryKey = false;
				colvarKcckdm.IsForeignKey = false;
				colvarKcckdm.IsReadOnly = false;
				colvarKcckdm.DefaultSetting = @"";
				colvarKcckdm.ForeignKeyTableName = "";
				schema.Columns.Add(colvarKcckdm);
				
				TableSchema.TableColumn colvarXtbmdm = new TableSchema.TableColumn(schema);
				colvarXtbmdm.ColumnName = "XTBMDM";
				colvarXtbmdm.DataType = DbType.String;
				colvarXtbmdm.MaxLength = 8;
				colvarXtbmdm.AutoIncrement = false;
				colvarXtbmdm.IsNullable = true;
				colvarXtbmdm.IsPrimaryKey = false;
				colvarXtbmdm.IsForeignKey = false;
				colvarXtbmdm.IsReadOnly = false;
				colvarXtbmdm.DefaultSetting = @"";
				colvarXtbmdm.ForeignKeyTableName = "";
				schema.Columns.Add(colvarXtbmdm);
				
				TableSchema.TableColumn colvarXtwpdm = new TableSchema.TableColumn(schema);
				colvarXtwpdm.ColumnName = "XTWPDM";
				colvarXtwpdm.DataType = DbType.String;
				colvarXtwpdm.MaxLength = 20;
				colvarXtwpdm.AutoIncrement = false;
				colvarXtwpdm.IsNullable = true;
				colvarXtwpdm.IsPrimaryKey = false;
				colvarXtwpdm.IsForeignKey = false;
				colvarXtwpdm.IsReadOnly = false;
				colvarXtwpdm.DefaultSetting = @"";
				colvarXtwpdm.ForeignKeyTableName = "";
				schema.Columns.Add(colvarXtwpdm);
				
				TableSchema.TableColumn colvarXtjldw = new TableSchema.TableColumn(schema);
				colvarXtjldw.ColumnName = "XTJLDW";
				colvarXtjldw.DataType = DbType.String;
				colvarXtjldw.MaxLength = 6;
				colvarXtjldw.AutoIncrement = false;
				colvarXtjldw.IsNullable = true;
				colvarXtjldw.IsPrimaryKey = false;
				colvarXtjldw.IsForeignKey = false;
				colvarXtjldw.IsReadOnly = false;
				colvarXtjldw.DefaultSetting = @"";
				colvarXtjldw.ForeignKeyTableName = "";
				schema.Columns.Add(colvarXtjldw);
				
				TableSchema.TableColumn colvarXsphsl = new TableSchema.TableColumn(schema);
				colvarXsphsl.ColumnName = "XSPHSL";
				colvarXsphsl.DataType = DbType.Decimal;
				colvarXsphsl.MaxLength = 0;
				colvarXsphsl.AutoIncrement = false;
				colvarXsphsl.IsNullable = true;
				colvarXsphsl.IsPrimaryKey = false;
				colvarXsphsl.IsForeignKey = false;
				colvarXsphsl.IsReadOnly = false;
				colvarXsphsl.DefaultSetting = @"";
				colvarXsphsl.ForeignKeyTableName = "";
				schema.Columns.Add(colvarXsphsl);
				
				TableSchema.TableColumn colvarXsphdj = new TableSchema.TableColumn(schema);
				colvarXsphdj.ColumnName = "XSPHDJ";
				colvarXsphdj.DataType = DbType.Decimal;
				colvarXsphdj.MaxLength = 0;
				colvarXsphdj.AutoIncrement = false;
				colvarXsphdj.IsNullable = true;
				colvarXsphdj.IsPrimaryKey = false;
				colvarXsphdj.IsForeignKey = false;
				colvarXsphdj.IsReadOnly = false;
				colvarXsphdj.DefaultSetting = @"";
				colvarXsphdj.ForeignKeyTableName = "";
				schema.Columns.Add(colvarXsphdj);
				
				TableSchema.TableColumn colvarXsphje = new TableSchema.TableColumn(schema);
				colvarXsphje.ColumnName = "XSPHJE";
				colvarXsphje.DataType = DbType.Decimal;
				colvarXsphje.MaxLength = 0;
				colvarXsphje.AutoIncrement = false;
				colvarXsphje.IsNullable = true;
				colvarXsphje.IsPrimaryKey = false;
				colvarXsphje.IsForeignKey = false;
				colvarXsphje.IsReadOnly = false;
				colvarXsphje.DefaultSetting = @"";
				colvarXsphje.ForeignKeyTableName = "";
				schema.Columns.Add(colvarXsphje);
				
				TableSchema.TableColumn colvarXsphry = new TableSchema.TableColumn(schema);
				colvarXsphry.ColumnName = "XSPHRY";
				colvarXsphry.DataType = DbType.String;
				colvarXsphry.MaxLength = 8;
				colvarXsphry.AutoIncrement = false;
				colvarXsphry.IsNullable = true;
				colvarXsphry.IsPrimaryKey = false;
				colvarXsphry.IsForeignKey = false;
				colvarXsphry.IsReadOnly = false;
				colvarXsphry.DefaultSetting = @"";
				colvarXsphry.ForeignKeyTableName = "";
				schema.Columns.Add(colvarXsphry);
				
				TableSchema.TableColumn colvarXsphrq = new TableSchema.TableColumn(schema);
				colvarXsphrq.ColumnName = "XSPHRQ";
				colvarXsphrq.DataType = DbType.DateTime;
				colvarXsphrq.MaxLength = 0;
				colvarXsphrq.AutoIncrement = false;
				colvarXsphrq.IsNullable = true;
				colvarXsphrq.IsPrimaryKey = false;
				colvarXsphrq.IsForeignKey = false;
				colvarXsphrq.IsReadOnly = false;
				colvarXsphrq.DefaultSetting = @"";
				colvarXsphrq.ForeignKeyTableName = "";
				schema.Columns.Add(colvarXsphrq);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["ErpNowthwin"].AddSchema("XST15",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("Xsjhfh")]
		[Bindable(true)]
		public DateTime? Xsjhfh 
		{
			get { return GetColumnValue<DateTime?>(Columns.Xsjhfh); }
			set { SetColumnValue(Columns.Xsjhfh, value); }
		}
		  
		[XmlAttribute("Xsjhdh")]
		[Bindable(true)]
		public DateTime? Xsjhdh 
		{
			get { return GetColumnValue<DateTime?>(Columns.Xsjhdh); }
			set { SetColumnValue(Columns.Xsjhdh, value); }
		}
		  
		[XmlAttribute("Xsykfy")]
		[Bindable(true)]
		public decimal? Xsykfy 
		{
			get { return GetColumnValue<decimal?>(Columns.Xsykfy); }
			set { SetColumnValue(Columns.Xsykfy, value); }
		}
		  
		[XmlAttribute("Xsyfhl")]
		[Bindable(true)]
		public decimal? Xsyfhl 
		{
			get { return GetColumnValue<decimal?>(Columns.Xsyfhl); }
			set { SetColumnValue(Columns.Xsyfhl, value); }
		}
		  
		[XmlAttribute("Xstjbz")]
		[Bindable(true)]
		public string Xstjbz 
		{
			get { return GetColumnValue<string>(Columns.Xstjbz); }
			set { SetColumnValue(Columns.Xstjbz, value); }
		}
		  
		[XmlAttribute("Xsthbz")]
		[Bindable(true)]
		public string Xsthbz 
		{
			get { return GetColumnValue<string>(Columns.Xsthbz); }
			set { SetColumnValue(Columns.Xsthbz, value); }
		}
		  
		[XmlAttribute("Kcshck")]
		[Bindable(true)]
		public string Kcshck 
		{
			get { return GetColumnValue<string>(Columns.Kcshck); }
			set { SetColumnValue(Columns.Kcshck, value); }
		}
		  
		[XmlAttribute("Xsphzk")]
		[Bindable(true)]
		public decimal? Xsphzk 
		{
			get { return GetColumnValue<decimal?>(Columns.Xsphzk); }
			set { SetColumnValue(Columns.Xsphzk, value); }
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
		public decimal? Scggxh 
		{
			get { return GetColumnValue<decimal?>(Columns.Scggxh); }
			set { SetColumnValue(Columns.Scggxh, value); }
		}
		  
		[XmlAttribute("Xsphdh")]
		[Bindable(true)]
		public string Xsphdh 
		{
			get { return GetColumnValue<string>(Columns.Xsphdh); }
			set { SetColumnValue(Columns.Xsphdh, value); }
		}
		  
		[XmlAttribute("Xsphhh")]
		[Bindable(true)]
		public decimal Xsphhh 
		{
			get { return GetColumnValue<decimal>(Columns.Xsphhh); }
			set { SetColumnValue(Columns.Xsphhh, value); }
		}
		  
		[XmlAttribute("Xsyhdh")]
		[Bindable(true)]
		public string Xsyhdh 
		{
			get { return GetColumnValue<string>(Columns.Xsyhdh); }
			set { SetColumnValue(Columns.Xsyhdh, value); }
		}
		  
		[XmlAttribute("Xsydhh")]
		[Bindable(true)]
		public decimal? Xsydhh 
		{
			get { return GetColumnValue<decimal?>(Columns.Xsydhh); }
			set { SetColumnValue(Columns.Xsydhh, value); }
		}
		  
		[XmlAttribute("Xtysfs")]
		[Bindable(true)]
		public string Xtysfs 
		{
			get { return GetColumnValue<string>(Columns.Xtysfs); }
			set { SetColumnValue(Columns.Xtysfs, value); }
		}
		  
		[XmlAttribute("Kcckdm")]
		[Bindable(true)]
		public string Kcckdm 
		{
			get { return GetColumnValue<string>(Columns.Kcckdm); }
			set { SetColumnValue(Columns.Kcckdm, value); }
		}
		  
		[XmlAttribute("Xtbmdm")]
		[Bindable(true)]
		public string Xtbmdm 
		{
			get { return GetColumnValue<string>(Columns.Xtbmdm); }
			set { SetColumnValue(Columns.Xtbmdm, value); }
		}
		  
		[XmlAttribute("Xtwpdm")]
		[Bindable(true)]
		public string Xtwpdm 
		{
			get { return GetColumnValue<string>(Columns.Xtwpdm); }
			set { SetColumnValue(Columns.Xtwpdm, value); }
		}
		  
		[XmlAttribute("Xtjldw")]
		[Bindable(true)]
		public string Xtjldw 
		{
			get { return GetColumnValue<string>(Columns.Xtjldw); }
			set { SetColumnValue(Columns.Xtjldw, value); }
		}
		  
		[XmlAttribute("Xsphsl")]
		[Bindable(true)]
		public decimal? Xsphsl 
		{
			get { return GetColumnValue<decimal?>(Columns.Xsphsl); }
			set { SetColumnValue(Columns.Xsphsl, value); }
		}
		  
		[XmlAttribute("Xsphdj")]
		[Bindable(true)]
		public decimal? Xsphdj 
		{
			get { return GetColumnValue<decimal?>(Columns.Xsphdj); }
			set { SetColumnValue(Columns.Xsphdj, value); }
		}
		  
		[XmlAttribute("Xsphje")]
		[Bindable(true)]
		public decimal? Xsphje 
		{
			get { return GetColumnValue<decimal?>(Columns.Xsphje); }
			set { SetColumnValue(Columns.Xsphje, value); }
		}
		  
		[XmlAttribute("Xsphry")]
		[Bindable(true)]
		public string Xsphry 
		{
			get { return GetColumnValue<string>(Columns.Xsphry); }
			set { SetColumnValue(Columns.Xsphry, value); }
		}
		  
		[XmlAttribute("Xsphrq")]
		[Bindable(true)]
		public DateTime? Xsphrq 
		{
			get { return GetColumnValue<DateTime?>(Columns.Xsphrq); }
			set { SetColumnValue(Columns.Xsphrq, value); }
		}
		
		#endregion
		
		
			
		
		//no foreign key tables defined (0)
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(DateTime? varXsjhfh,DateTime? varXsjhdh,decimal? varXsykfy,decimal? varXsyfhl,string varXstjbz,string varXsthbz,string varKcshck,decimal? varXsphzk,string varScggdh,decimal? varScggxh,string varXsphdh,decimal varXsphhh,string varXsyhdh,decimal? varXsydhh,string varXtysfs,string varKcckdm,string varXtbmdm,string varXtwpdm,string varXtjldw,decimal? varXsphsl,decimal? varXsphdj,decimal? varXsphje,string varXsphry,DateTime? varXsphrq)
		{
			XST15 item = new XST15();
			
			item.Xsjhfh = varXsjhfh;
			
			item.Xsjhdh = varXsjhdh;
			
			item.Xsykfy = varXsykfy;
			
			item.Xsyfhl = varXsyfhl;
			
			item.Xstjbz = varXstjbz;
			
			item.Xsthbz = varXsthbz;
			
			item.Kcshck = varKcshck;
			
			item.Xsphzk = varXsphzk;
			
			item.Scggdh = varScggdh;
			
			item.Scggxh = varScggxh;
			
			item.Xsphdh = varXsphdh;
			
			item.Xsphhh = varXsphhh;
			
			item.Xsyhdh = varXsyhdh;
			
			item.Xsydhh = varXsydhh;
			
			item.Xtysfs = varXtysfs;
			
			item.Kcckdm = varKcckdm;
			
			item.Xtbmdm = varXtbmdm;
			
			item.Xtwpdm = varXtwpdm;
			
			item.Xtjldw = varXtjldw;
			
			item.Xsphsl = varXsphsl;
			
			item.Xsphdj = varXsphdj;
			
			item.Xsphje = varXsphje;
			
			item.Xsphry = varXsphry;
			
			item.Xsphrq = varXsphrq;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(DateTime? varXsjhfh,DateTime? varXsjhdh,decimal? varXsykfy,decimal? varXsyfhl,string varXstjbz,string varXsthbz,string varKcshck,decimal? varXsphzk,string varScggdh,decimal? varScggxh,string varXsphdh,decimal varXsphhh,string varXsyhdh,decimal? varXsydhh,string varXtysfs,string varKcckdm,string varXtbmdm,string varXtwpdm,string varXtjldw,decimal? varXsphsl,decimal? varXsphdj,decimal? varXsphje,string varXsphry,DateTime? varXsphrq)
		{
			XST15 item = new XST15();
			
				item.Xsjhfh = varXsjhfh;
			
				item.Xsjhdh = varXsjhdh;
			
				item.Xsykfy = varXsykfy;
			
				item.Xsyfhl = varXsyfhl;
			
				item.Xstjbz = varXstjbz;
			
				item.Xsthbz = varXsthbz;
			
				item.Kcshck = varKcshck;
			
				item.Xsphzk = varXsphzk;
			
				item.Scggdh = varScggdh;
			
				item.Scggxh = varScggxh;
			
				item.Xsphdh = varXsphdh;
			
				item.Xsphhh = varXsphhh;
			
				item.Xsyhdh = varXsyhdh;
			
				item.Xsydhh = varXsydhh;
			
				item.Xtysfs = varXtysfs;
			
				item.Kcckdm = varKcckdm;
			
				item.Xtbmdm = varXtbmdm;
			
				item.Xtwpdm = varXtwpdm;
			
				item.Xtjldw = varXtjldw;
			
				item.Xsphsl = varXsphsl;
			
				item.Xsphdj = varXsphdj;
			
				item.Xsphje = varXsphje;
			
				item.Xsphry = varXsphry;
			
				item.Xsphrq = varXsphrq;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn XsjhfhColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn XsjhdhColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        public static TableSchema.TableColumn XsykfyColumn
        {
            get { return Schema.Columns[2]; }
        }
        
        
        
        public static TableSchema.TableColumn XsyfhlColumn
        {
            get { return Schema.Columns[3]; }
        }
        
        
        
        public static TableSchema.TableColumn XstjbzColumn
        {
            get { return Schema.Columns[4]; }
        }
        
        
        
        public static TableSchema.TableColumn XsthbzColumn
        {
            get { return Schema.Columns[5]; }
        }
        
        
        
        public static TableSchema.TableColumn KcshckColumn
        {
            get { return Schema.Columns[6]; }
        }
        
        
        
        public static TableSchema.TableColumn XsphzkColumn
        {
            get { return Schema.Columns[7]; }
        }
        
        
        
        public static TableSchema.TableColumn ScggdhColumn
        {
            get { return Schema.Columns[8]; }
        }
        
        
        
        public static TableSchema.TableColumn ScggxhColumn
        {
            get { return Schema.Columns[9]; }
        }
        
        
        
        public static TableSchema.TableColumn XsphdhColumn
        {
            get { return Schema.Columns[10]; }
        }
        
        
        
        public static TableSchema.TableColumn XsphhhColumn
        {
            get { return Schema.Columns[11]; }
        }
        
        
        
        public static TableSchema.TableColumn XsyhdhColumn
        {
            get { return Schema.Columns[12]; }
        }
        
        
        
        public static TableSchema.TableColumn XsydhhColumn
        {
            get { return Schema.Columns[13]; }
        }
        
        
        
        public static TableSchema.TableColumn XtysfsColumn
        {
            get { return Schema.Columns[14]; }
        }
        
        
        
        public static TableSchema.TableColumn KcckdmColumn
        {
            get { return Schema.Columns[15]; }
        }
        
        
        
        public static TableSchema.TableColumn XtbmdmColumn
        {
            get { return Schema.Columns[16]; }
        }
        
        
        
        public static TableSchema.TableColumn XtwpdmColumn
        {
            get { return Schema.Columns[17]; }
        }
        
        
        
        public static TableSchema.TableColumn XtjldwColumn
        {
            get { return Schema.Columns[18]; }
        }
        
        
        
        public static TableSchema.TableColumn XsphslColumn
        {
            get { return Schema.Columns[19]; }
        }
        
        
        
        public static TableSchema.TableColumn XsphdjColumn
        {
            get { return Schema.Columns[20]; }
        }
        
        
        
        public static TableSchema.TableColumn XsphjeColumn
        {
            get { return Schema.Columns[21]; }
        }
        
        
        
        public static TableSchema.TableColumn XsphryColumn
        {
            get { return Schema.Columns[22]; }
        }
        
        
        
        public static TableSchema.TableColumn XsphrqColumn
        {
            get { return Schema.Columns[23]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string Xsjhfh = @"XSJHFH";
			 public static string Xsjhdh = @"XSJHDH";
			 public static string Xsykfy = @"XSYKFY";
			 public static string Xsyfhl = @"XSYFHL";
			 public static string Xstjbz = @"XSTJBZ";
			 public static string Xsthbz = @"XSTHBZ";
			 public static string Kcshck = @"KCSHCK";
			 public static string Xsphzk = @"XSPHZK";
			 public static string Scggdh = @"SCGGDH";
			 public static string Scggxh = @"SCGGXH";
			 public static string Xsphdh = @"XSPHDH";
			 public static string Xsphhh = @"XSPHHH";
			 public static string Xsyhdh = @"XSYHDH";
			 public static string Xsydhh = @"XSYDHH";
			 public static string Xtysfs = @"XTYSFS";
			 public static string Kcckdm = @"KCCKDM";
			 public static string Xtbmdm = @"XTBMDM";
			 public static string Xtwpdm = @"XTWPDM";
			 public static string Xtjldw = @"XTJLDW";
			 public static string Xsphsl = @"XSPHSL";
			 public static string Xsphdj = @"XSPHDJ";
			 public static string Xsphje = @"XSPHJE";
			 public static string Xsphry = @"XSPHRY";
			 public static string Xsphrq = @"XSPHRQ";
						
		}
		#endregion
		
		#region Update PK Collections
		
        #endregion
    
        #region Deep Save
		
        #endregion
	}
}
