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
	/// Strongly-typed collection for the TAnalysisMTMXFJh class.
	/// </summary>
    [Serializable]
	public partial class TAnalysisMTMXFJhCollection : ActiveList<TAnalysisMTMXFJh, TAnalysisMTMXFJhCollection>
	{	   
		public TAnalysisMTMXFJhCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>TAnalysisMTMXFJhCollection</returns>
		public TAnalysisMTMXFJhCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                TAnalysisMTMXFJh o = this[i];
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
	/// This is an ActiveRecord class which wraps the T_Analysis_MTMXFJh table.
	/// </summary>
	[Serializable]
	public partial class TAnalysisMTMXFJh : ActiveRecord<TAnalysisMTMXFJh>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public TAnalysisMTMXFJh()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public TAnalysisMTMXFJh(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public TAnalysisMTMXFJh(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public TAnalysisMTMXFJh(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("T_Analysis_MTMXFJh", TableType.Table, DataService.GetInstance("Nowthwin"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarId = new TableSchema.TableColumn(schema);
				colvarId.ColumnName = "ID";
				colvarId.DataType = DbType.Int64;
				colvarId.MaxLength = 0;
				colvarId.AutoIncrement = false;
				colvarId.IsNullable = false;
				colvarId.IsPrimaryKey = true;
				colvarId.IsForeignKey = false;
				colvarId.IsReadOnly = false;
				colvarId.DefaultSetting = @"";
				colvarId.ForeignKeyTableName = "";
				schema.Columns.Add(colvarId);
				
				TableSchema.TableColumn colvarXtwpks = new TableSchema.TableColumn(schema);
				colvarXtwpks.ColumnName = "XTWPKS";
				colvarXtwpks.DataType = DbType.String;
				colvarXtwpks.MaxLength = 20;
				colvarXtwpks.AutoIncrement = false;
				colvarXtwpks.IsNullable = true;
				colvarXtwpks.IsPrimaryKey = false;
				colvarXtwpks.IsForeignKey = false;
				colvarXtwpks.IsReadOnly = false;
				colvarXtwpks.DefaultSetting = @"";
				colvarXtwpks.ForeignKeyTableName = "";
				schema.Columns.Add(colvarXtwpks);
				
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
				
				TableSchema.TableColumn colvarXtwplj = new TableSchema.TableColumn(schema);
				colvarXtwplj.ColumnName = "XTWPLJ";
				colvarXtwplj.DataType = DbType.String;
				colvarXtwplj.MaxLength = 50;
				colvarXtwplj.AutoIncrement = false;
				colvarXtwplj.IsNullable = true;
				colvarXtwplj.IsPrimaryKey = false;
				colvarXtwplj.IsForeignKey = false;
				colvarXtwplj.IsReadOnly = false;
				colvarXtwplj.DefaultSetting = @"";
				colvarXtwplj.ForeignKeyTableName = "";
				schema.Columns.Add(colvarXtwplj);
				
				TableSchema.TableColumn colvarSchtsl = new TableSchema.TableColumn(schema);
				colvarSchtsl.ColumnName = "SCHTSL";
				colvarSchtsl.DataType = DbType.String;
				colvarSchtsl.MaxLength = 384;
				colvarSchtsl.AutoIncrement = false;
				colvarSchtsl.IsNullable = true;
				colvarSchtsl.IsPrimaryKey = false;
				colvarSchtsl.IsForeignKey = false;
				colvarSchtsl.IsReadOnly = false;
				colvarSchtsl.DefaultSetting = @"";
				colvarSchtsl.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSchtsl);
				
				TableSchema.TableColumn colvarScggdh = new TableSchema.TableColumn(schema);
				colvarScggdh.ColumnName = "SCGGDH";
				colvarScggdh.DataType = DbType.String;
				colvarScggdh.MaxLength = 12;
				colvarScggdh.AutoIncrement = false;
				colvarScggdh.IsNullable = false;
				colvarScggdh.IsPrimaryKey = false;
				colvarScggdh.IsForeignKey = false;
				colvarScggdh.IsReadOnly = false;
				colvarScggdh.DefaultSetting = @"";
				colvarScggdh.ForeignKeyTableName = "";
				schema.Columns.Add(colvarScggdh);
				
				TableSchema.TableColumn colvarScyspd = new TableSchema.TableColumn(schema);
				colvarScyspd.ColumnName = "SCYSPD";
				colvarScyspd.DataType = DbType.String;
				colvarScyspd.MaxLength = 12;
				colvarScyspd.AutoIncrement = false;
				colvarScyspd.IsNullable = true;
				colvarScyspd.IsPrimaryKey = false;
				colvarScyspd.IsForeignKey = false;
				colvarScyspd.IsReadOnly = false;
				colvarScyspd.DefaultSetting = @"";
				colvarScyspd.ForeignKeyTableName = "";
				schema.Columns.Add(colvarScyspd);
				
				TableSchema.TableColumn colvarXtwldm = new TableSchema.TableColumn(schema);
				colvarXtwldm.ColumnName = "XTWLDM";
				colvarXtwldm.DataType = DbType.String;
				colvarXtwldm.MaxLength = 8;
				colvarXtwldm.AutoIncrement = false;
				colvarXtwldm.IsNullable = true;
				colvarXtwldm.IsPrimaryKey = false;
				colvarXtwldm.IsForeignKey = false;
				colvarXtwldm.IsReadOnly = false;
				colvarXtwldm.DefaultSetting = @"";
				colvarXtwldm.ForeignKeyTableName = "";
				schema.Columns.Add(colvarXtwldm);
				
				TableSchema.TableColumn colvarScgydm = new TableSchema.TableColumn(schema);
				colvarScgydm.ColumnName = "SCGYDM";
				colvarScgydm.DataType = DbType.String;
				colvarScgydm.MaxLength = 4;
				colvarScgydm.AutoIncrement = false;
				colvarScgydm.IsNullable = true;
				colvarScgydm.IsPrimaryKey = false;
				colvarScgydm.IsForeignKey = false;
				colvarScgydm.IsReadOnly = false;
				colvarScgydm.DefaultSetting = @"";
				colvarScgydm.ForeignKeyTableName = "";
				schema.Columns.Add(colvarScgydm);
				
				TableSchema.TableColumn colvarScjhbz = new TableSchema.TableColumn(schema);
				colvarScjhbz.ColumnName = "SCJHBZ";
				colvarScjhbz.DataType = DbType.String;
				colvarScjhbz.MaxLength = 255;
				colvarScjhbz.AutoIncrement = false;
				colvarScjhbz.IsNullable = true;
				colvarScjhbz.IsPrimaryKey = false;
				colvarScjhbz.IsForeignKey = false;
				colvarScjhbz.IsReadOnly = false;
				colvarScjhbz.DefaultSetting = @"";
				colvarScjhbz.ForeignKeyTableName = "";
				schema.Columns.Add(colvarScjhbz);
				
				TableSchema.TableColumn colvarXtwpmc = new TableSchema.TableColumn(schema);
				colvarXtwpmc.ColumnName = "XTWPMC";
				colvarXtwpmc.DataType = DbType.String;
				colvarXtwpmc.MaxLength = 100;
				colvarXtwpmc.AutoIncrement = false;
				colvarXtwpmc.IsNullable = true;
				colvarXtwpmc.IsPrimaryKey = false;
				colvarXtwpmc.IsForeignKey = false;
				colvarXtwpmc.IsReadOnly = false;
				colvarXtwpmc.DefaultSetting = @"";
				colvarXtwpmc.ForeignKeyTableName = "";
				schema.Columns.Add(colvarXtwpmc);
				
				TableSchema.TableColumn colvarScjhdd = new TableSchema.TableColumn(schema);
				colvarScjhdd.ColumnName = "SCJHDD";
				colvarScjhdd.DataType = DbType.String;
				colvarScjhdd.MaxLength = 4000;
				colvarScjhdd.AutoIncrement = false;
				colvarScjhdd.IsNullable = true;
				colvarScjhdd.IsPrimaryKey = false;
				colvarScjhdd.IsForeignKey = false;
				colvarScjhdd.IsReadOnly = false;
				colvarScjhdd.DefaultSetting = @"";
				colvarScjhdd.ForeignKeyTableName = "";
				schema.Columns.Add(colvarScjhdd);
				
				TableSchema.TableColumn colvarClothtype = new TableSchema.TableColumn(schema);
				colvarClothtype.ColumnName = "CLOTHTYPE";
				colvarClothtype.DataType = DbType.Int32;
				colvarClothtype.MaxLength = 0;
				colvarClothtype.AutoIncrement = false;
				colvarClothtype.IsNullable = false;
				colvarClothtype.IsPrimaryKey = false;
				colvarClothtype.IsForeignKey = false;
				colvarClothtype.IsReadOnly = false;
				colvarClothtype.DefaultSetting = @"";
				colvarClothtype.ForeignKeyTableName = "";
				schema.Columns.Add(colvarClothtype);
				
				TableSchema.TableColumn colvarJiaji = new TableSchema.TableColumn(schema);
				colvarJiaji.ColumnName = "JIAJI";
				colvarJiaji.DataType = DbType.Int32;
				colvarJiaji.MaxLength = 0;
				colvarJiaji.AutoIncrement = false;
				colvarJiaji.IsNullable = false;
				colvarJiaji.IsPrimaryKey = false;
				colvarJiaji.IsForeignKey = false;
				colvarJiaji.IsReadOnly = false;
				colvarJiaji.DefaultSetting = @"";
				colvarJiaji.ForeignKeyTableName = "";
				schema.Columns.Add(colvarJiaji);
				
				TableSchema.TableColumn colvarFangge = new TableSchema.TableColumn(schema);
				colvarFangge.ColumnName = "FANGGE";
				colvarFangge.DataType = DbType.Int32;
				colvarFangge.MaxLength = 0;
				colvarFangge.AutoIncrement = false;
				colvarFangge.IsNullable = false;
				colvarFangge.IsPrimaryKey = false;
				colvarFangge.IsForeignKey = false;
				colvarFangge.IsReadOnly = false;
				colvarFangge.DefaultSetting = @"";
				colvarFangge.ForeignKeyTableName = "";
				schema.Columns.Add(colvarFangge);
				
				TableSchema.TableColumn colvarWoman = new TableSchema.TableColumn(schema);
				colvarWoman.ColumnName = "WOMAN";
				colvarWoman.DataType = DbType.Int32;
				colvarWoman.MaxLength = 0;
				colvarWoman.AutoIncrement = false;
				colvarWoman.IsNullable = false;
				colvarWoman.IsPrimaryKey = false;
				colvarWoman.IsForeignKey = false;
				colvarWoman.IsReadOnly = false;
				colvarWoman.DefaultSetting = @"";
				colvarWoman.ForeignKeyTableName = "";
				schema.Columns.Add(colvarWoman);
				
				TableSchema.TableColumn colvarShiyi = new TableSchema.TableColumn(schema);
				colvarShiyi.ColumnName = "SHIYI";
				colvarShiyi.DataType = DbType.Int32;
				colvarShiyi.MaxLength = 0;
				colvarShiyi.AutoIncrement = false;
				colvarShiyi.IsNullable = false;
				colvarShiyi.IsPrimaryKey = false;
				colvarShiyi.IsForeignKey = false;
				colvarShiyi.IsReadOnly = false;
				colvarShiyi.DefaultSetting = @"";
				colvarShiyi.ForeignKeyTableName = "";
				schema.Columns.Add(colvarShiyi);
				
				TableSchema.TableColumn colvarPeijian = new TableSchema.TableColumn(schema);
				colvarPeijian.ColumnName = "PEIJIAN";
				colvarPeijian.DataType = DbType.Int32;
				colvarPeijian.MaxLength = 0;
				colvarPeijian.AutoIncrement = false;
				colvarPeijian.IsNullable = false;
				colvarPeijian.IsPrimaryKey = false;
				colvarPeijian.IsForeignKey = false;
				colvarPeijian.IsReadOnly = false;
				colvarPeijian.DefaultSetting = @"";
				colvarPeijian.ForeignKeyTableName = "";
				schema.Columns.Add(colvarPeijian);
				
				TableSchema.TableColumn colvarShougong = new TableSchema.TableColumn(schema);
				colvarShougong.ColumnName = "SHOUGONG";
				colvarShougong.DataType = DbType.Int32;
				colvarShougong.MaxLength = 0;
				colvarShougong.AutoIncrement = false;
				colvarShougong.IsNullable = false;
				colvarShougong.IsPrimaryKey = false;
				colvarShougong.IsForeignKey = false;
				colvarShougong.IsReadOnly = false;
				colvarShougong.DefaultSetting = @"";
				colvarShougong.ForeignKeyTableName = "";
				schema.Columns.Add(colvarShougong);
				
				TableSchema.TableColumn colvarHuizhipi = new TableSchema.TableColumn(schema);
				colvarHuizhipi.ColumnName = "HUIZHIPI";
				colvarHuizhipi.DataType = DbType.Int32;
				colvarHuizhipi.MaxLength = 0;
				colvarHuizhipi.AutoIncrement = false;
				colvarHuizhipi.IsNullable = false;
				colvarHuizhipi.IsPrimaryKey = false;
				colvarHuizhipi.IsForeignKey = false;
				colvarHuizhipi.IsReadOnly = false;
				colvarHuizhipi.DefaultSetting = @"";
				colvarHuizhipi.ForeignKeyTableName = "";
				schema.Columns.Add(colvarHuizhipi);
				
				TableSchema.TableColumn colvarNabotou = new TableSchema.TableColumn(schema);
				colvarNabotou.ColumnName = "NABOTOU";
				colvarNabotou.DataType = DbType.Int32;
				colvarNabotou.MaxLength = 0;
				colvarNabotou.AutoIncrement = false;
				colvarNabotou.IsNullable = false;
				colvarNabotou.IsPrimaryKey = false;
				colvarNabotou.IsForeignKey = false;
				colvarNabotou.IsReadOnly = false;
				colvarNabotou.DefaultSetting = @"";
				colvarNabotou.ForeignKeyTableName = "";
				schema.Columns.Add(colvarNabotou);
				
				TableSchema.TableColumn colvarCeshi = new TableSchema.TableColumn(schema);
				colvarCeshi.ColumnName = "CESHI";
				colvarCeshi.DataType = DbType.Int32;
				colvarCeshi.MaxLength = 0;
				colvarCeshi.AutoIncrement = false;
				colvarCeshi.IsNullable = false;
				colvarCeshi.IsPrimaryKey = false;
				colvarCeshi.IsForeignKey = false;
				colvarCeshi.IsReadOnly = false;
				colvarCeshi.DefaultSetting = @"";
				colvarCeshi.ForeignKeyTableName = "";
				schema.Columns.Add(colvarCeshi);
				
				TableSchema.TableColumn colvarTmw = new TableSchema.TableColumn(schema);
				colvarTmw.ColumnName = "TMW";
				colvarTmw.DataType = DbType.Int32;
				colvarTmw.MaxLength = 0;
				colvarTmw.AutoIncrement = false;
				colvarTmw.IsNullable = false;
				colvarTmw.IsPrimaryKey = false;
				colvarTmw.IsForeignKey = false;
				colvarTmw.IsReadOnly = false;
				colvarTmw.DefaultSetting = @"";
				colvarTmw.ForeignKeyTableName = "";
				schema.Columns.Add(colvarTmw);
				
				TableSchema.TableColumn colvarGuowai = new TableSchema.TableColumn(schema);
				colvarGuowai.ColumnName = "GUOWAI";
				colvarGuowai.DataType = DbType.Int32;
				colvarGuowai.MaxLength = 0;
				colvarGuowai.AutoIncrement = false;
				colvarGuowai.IsNullable = true;
				colvarGuowai.IsPrimaryKey = false;
				colvarGuowai.IsForeignKey = false;
				colvarGuowai.IsReadOnly = false;
				colvarGuowai.DefaultSetting = @"";
				colvarGuowai.ForeignKeyTableName = "";
				schema.Columns.Add(colvarGuowai);
				
				TableSchema.TableColumn colvarBanzu = new TableSchema.TableColumn(schema);
				colvarBanzu.ColumnName = "BANZU";
				colvarBanzu.DataType = DbType.Int32;
				colvarBanzu.MaxLength = 0;
				colvarBanzu.AutoIncrement = false;
				colvarBanzu.IsNullable = true;
				colvarBanzu.IsPrimaryKey = false;
				colvarBanzu.IsForeignKey = false;
				colvarBanzu.IsReadOnly = false;
				colvarBanzu.DefaultSetting = @"";
				colvarBanzu.ForeignKeyTableName = "";
				schema.Columns.Add(colvarBanzu);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["Nowthwin"].AddSchema("T_Analysis_MTMXFJh",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("Id")]
		[Bindable(true)]
		public long Id 
		{
			get { return GetColumnValue<long>(Columns.Id); }
			set { SetColumnValue(Columns.Id, value); }
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
		  
		[XmlAttribute("Scjhrq")]
		[Bindable(true)]
		public DateTime? Scjhrq 
		{
			get { return GetColumnValue<DateTime?>(Columns.Scjhrq); }
			set { SetColumnValue(Columns.Scjhrq, value); }
		}
		  
		[XmlAttribute("Xtwplj")]
		[Bindable(true)]
		public string Xtwplj 
		{
			get { return GetColumnValue<string>(Columns.Xtwplj); }
			set { SetColumnValue(Columns.Xtwplj, value); }
		}
		  
		[XmlAttribute("Schtsl")]
		[Bindable(true)]
		public string Schtsl 
		{
			get { return GetColumnValue<string>(Columns.Schtsl); }
			set { SetColumnValue(Columns.Schtsl, value); }
		}
		  
		[XmlAttribute("Scggdh")]
		[Bindable(true)]
		public string Scggdh 
		{
			get { return GetColumnValue<string>(Columns.Scggdh); }
			set { SetColumnValue(Columns.Scggdh, value); }
		}
		  
		[XmlAttribute("Scyspd")]
		[Bindable(true)]
		public string Scyspd 
		{
			get { return GetColumnValue<string>(Columns.Scyspd); }
			set { SetColumnValue(Columns.Scyspd, value); }
		}
		  
		[XmlAttribute("Xtwldm")]
		[Bindable(true)]
		public string Xtwldm 
		{
			get { return GetColumnValue<string>(Columns.Xtwldm); }
			set { SetColumnValue(Columns.Xtwldm, value); }
		}
		  
		[XmlAttribute("Scgydm")]
		[Bindable(true)]
		public string Scgydm 
		{
			get { return GetColumnValue<string>(Columns.Scgydm); }
			set { SetColumnValue(Columns.Scgydm, value); }
		}
		  
		[XmlAttribute("Scjhbz")]
		[Bindable(true)]
		public string Scjhbz 
		{
			get { return GetColumnValue<string>(Columns.Scjhbz); }
			set { SetColumnValue(Columns.Scjhbz, value); }
		}
		  
		[XmlAttribute("Xtwpmc")]
		[Bindable(true)]
		public string Xtwpmc 
		{
			get { return GetColumnValue<string>(Columns.Xtwpmc); }
			set { SetColumnValue(Columns.Xtwpmc, value); }
		}
		  
		[XmlAttribute("Scjhdd")]
		[Bindable(true)]
		public string Scjhdd 
		{
			get { return GetColumnValue<string>(Columns.Scjhdd); }
			set { SetColumnValue(Columns.Scjhdd, value); }
		}
		  
		[XmlAttribute("Clothtype")]
		[Bindable(true)]
		public int Clothtype 
		{
			get { return GetColumnValue<int>(Columns.Clothtype); }
			set { SetColumnValue(Columns.Clothtype, value); }
		}
		  
		[XmlAttribute("Jiaji")]
		[Bindable(true)]
		public int Jiaji 
		{
			get { return GetColumnValue<int>(Columns.Jiaji); }
			set { SetColumnValue(Columns.Jiaji, value); }
		}
		  
		[XmlAttribute("Fangge")]
		[Bindable(true)]
		public int Fangge 
		{
			get { return GetColumnValue<int>(Columns.Fangge); }
			set { SetColumnValue(Columns.Fangge, value); }
		}
		  
		[XmlAttribute("Woman")]
		[Bindable(true)]
		public int Woman 
		{
			get { return GetColumnValue<int>(Columns.Woman); }
			set { SetColumnValue(Columns.Woman, value); }
		}
		  
		[XmlAttribute("Shiyi")]
		[Bindable(true)]
		public int Shiyi 
		{
			get { return GetColumnValue<int>(Columns.Shiyi); }
			set { SetColumnValue(Columns.Shiyi, value); }
		}
		  
		[XmlAttribute("Peijian")]
		[Bindable(true)]
		public int Peijian 
		{
			get { return GetColumnValue<int>(Columns.Peijian); }
			set { SetColumnValue(Columns.Peijian, value); }
		}
		  
		[XmlAttribute("Shougong")]
		[Bindable(true)]
		public int Shougong 
		{
			get { return GetColumnValue<int>(Columns.Shougong); }
			set { SetColumnValue(Columns.Shougong, value); }
		}
		  
		[XmlAttribute("Huizhipi")]
		[Bindable(true)]
		public int Huizhipi 
		{
			get { return GetColumnValue<int>(Columns.Huizhipi); }
			set { SetColumnValue(Columns.Huizhipi, value); }
		}
		  
		[XmlAttribute("Nabotou")]
		[Bindable(true)]
		public int Nabotou 
		{
			get { return GetColumnValue<int>(Columns.Nabotou); }
			set { SetColumnValue(Columns.Nabotou, value); }
		}
		  
		[XmlAttribute("Ceshi")]
		[Bindable(true)]
		public int Ceshi 
		{
			get { return GetColumnValue<int>(Columns.Ceshi); }
			set { SetColumnValue(Columns.Ceshi, value); }
		}
		  
		[XmlAttribute("Tmw")]
		[Bindable(true)]
		public int Tmw 
		{
			get { return GetColumnValue<int>(Columns.Tmw); }
			set { SetColumnValue(Columns.Tmw, value); }
		}
		  
		[XmlAttribute("Guowai")]
		[Bindable(true)]
		public int? Guowai 
		{
			get { return GetColumnValue<int?>(Columns.Guowai); }
			set { SetColumnValue(Columns.Guowai, value); }
		}
		  
		[XmlAttribute("Banzu")]
		[Bindable(true)]
		public int? Banzu 
		{
			get { return GetColumnValue<int?>(Columns.Banzu); }
			set { SetColumnValue(Columns.Banzu, value); }
		}
		
		#endregion
		
		
			
		
		//no foreign key tables defined (0)
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(long varId,string varXtwpks,string varXtwpys,DateTime? varScjhrq,string varXtwplj,string varSchtsl,string varScggdh,string varScyspd,string varXtwldm,string varScgydm,string varScjhbz,string varXtwpmc,string varScjhdd,int varClothtype,int varJiaji,int varFangge,int varWoman,int varShiyi,int varPeijian,int varShougong,int varHuizhipi,int varNabotou,int varCeshi,int varTmw,int? varGuowai,int? varBanzu)
		{
			TAnalysisMTMXFJh item = new TAnalysisMTMXFJh();
			
			item.Id = varId;
			
			item.Xtwpks = varXtwpks;
			
			item.Xtwpys = varXtwpys;
			
			item.Scjhrq = varScjhrq;
			
			item.Xtwplj = varXtwplj;
			
			item.Schtsl = varSchtsl;
			
			item.Scggdh = varScggdh;
			
			item.Scyspd = varScyspd;
			
			item.Xtwldm = varXtwldm;
			
			item.Scgydm = varScgydm;
			
			item.Scjhbz = varScjhbz;
			
			item.Xtwpmc = varXtwpmc;
			
			item.Scjhdd = varScjhdd;
			
			item.Clothtype = varClothtype;
			
			item.Jiaji = varJiaji;
			
			item.Fangge = varFangge;
			
			item.Woman = varWoman;
			
			item.Shiyi = varShiyi;
			
			item.Peijian = varPeijian;
			
			item.Shougong = varShougong;
			
			item.Huizhipi = varHuizhipi;
			
			item.Nabotou = varNabotou;
			
			item.Ceshi = varCeshi;
			
			item.Tmw = varTmw;
			
			item.Guowai = varGuowai;
			
			item.Banzu = varBanzu;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(long varId,string varXtwpks,string varXtwpys,DateTime? varScjhrq,string varXtwplj,string varSchtsl,string varScggdh,string varScyspd,string varXtwldm,string varScgydm,string varScjhbz,string varXtwpmc,string varScjhdd,int varClothtype,int varJiaji,int varFangge,int varWoman,int varShiyi,int varPeijian,int varShougong,int varHuizhipi,int varNabotou,int varCeshi,int varTmw,int? varGuowai,int? varBanzu)
		{
			TAnalysisMTMXFJh item = new TAnalysisMTMXFJh();
			
				item.Id = varId;
			
				item.Xtwpks = varXtwpks;
			
				item.Xtwpys = varXtwpys;
			
				item.Scjhrq = varScjhrq;
			
				item.Xtwplj = varXtwplj;
			
				item.Schtsl = varSchtsl;
			
				item.Scggdh = varScggdh;
			
				item.Scyspd = varScyspd;
			
				item.Xtwldm = varXtwldm;
			
				item.Scgydm = varScgydm;
			
				item.Scjhbz = varScjhbz;
			
				item.Xtwpmc = varXtwpmc;
			
				item.Scjhdd = varScjhdd;
			
				item.Clothtype = varClothtype;
			
				item.Jiaji = varJiaji;
			
				item.Fangge = varFangge;
			
				item.Woman = varWoman;
			
				item.Shiyi = varShiyi;
			
				item.Peijian = varPeijian;
			
				item.Shougong = varShougong;
			
				item.Huizhipi = varHuizhipi;
			
				item.Nabotou = varNabotou;
			
				item.Ceshi = varCeshi;
			
				item.Tmw = varTmw;
			
				item.Guowai = varGuowai;
			
				item.Banzu = varBanzu;
			
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
        
        
        
        public static TableSchema.TableColumn XtwpksColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        public static TableSchema.TableColumn XtwpysColumn
        {
            get { return Schema.Columns[2]; }
        }
        
        
        
        public static TableSchema.TableColumn ScjhrqColumn
        {
            get { return Schema.Columns[3]; }
        }
        
        
        
        public static TableSchema.TableColumn XtwpljColumn
        {
            get { return Schema.Columns[4]; }
        }
        
        
        
        public static TableSchema.TableColumn SchtslColumn
        {
            get { return Schema.Columns[5]; }
        }
        
        
        
        public static TableSchema.TableColumn ScggdhColumn
        {
            get { return Schema.Columns[6]; }
        }
        
        
        
        public static TableSchema.TableColumn ScyspdColumn
        {
            get { return Schema.Columns[7]; }
        }
        
        
        
        public static TableSchema.TableColumn XtwldmColumn
        {
            get { return Schema.Columns[8]; }
        }
        
        
        
        public static TableSchema.TableColumn ScgydmColumn
        {
            get { return Schema.Columns[9]; }
        }
        
        
        
        public static TableSchema.TableColumn ScjhbzColumn
        {
            get { return Schema.Columns[10]; }
        }
        
        
        
        public static TableSchema.TableColumn XtwpmcColumn
        {
            get { return Schema.Columns[11]; }
        }
        
        
        
        public static TableSchema.TableColumn ScjhddColumn
        {
            get { return Schema.Columns[12]; }
        }
        
        
        
        public static TableSchema.TableColumn ClothtypeColumn
        {
            get { return Schema.Columns[13]; }
        }
        
        
        
        public static TableSchema.TableColumn JiajiColumn
        {
            get { return Schema.Columns[14]; }
        }
        
        
        
        public static TableSchema.TableColumn FanggeColumn
        {
            get { return Schema.Columns[15]; }
        }
        
        
        
        public static TableSchema.TableColumn WomanColumn
        {
            get { return Schema.Columns[16]; }
        }
        
        
        
        public static TableSchema.TableColumn ShiyiColumn
        {
            get { return Schema.Columns[17]; }
        }
        
        
        
        public static TableSchema.TableColumn PeijianColumn
        {
            get { return Schema.Columns[18]; }
        }
        
        
        
        public static TableSchema.TableColumn ShougongColumn
        {
            get { return Schema.Columns[19]; }
        }
        
        
        
        public static TableSchema.TableColumn HuizhipiColumn
        {
            get { return Schema.Columns[20]; }
        }
        
        
        
        public static TableSchema.TableColumn NabotouColumn
        {
            get { return Schema.Columns[21]; }
        }
        
        
        
        public static TableSchema.TableColumn CeshiColumn
        {
            get { return Schema.Columns[22]; }
        }
        
        
        
        public static TableSchema.TableColumn TmwColumn
        {
            get { return Schema.Columns[23]; }
        }
        
        
        
        public static TableSchema.TableColumn GuowaiColumn
        {
            get { return Schema.Columns[24]; }
        }
        
        
        
        public static TableSchema.TableColumn BanzuColumn
        {
            get { return Schema.Columns[25]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string Id = @"ID";
			 public static string Xtwpks = @"XTWPKS";
			 public static string Xtwpys = @"XTWPYS";
			 public static string Scjhrq = @"SCJHRQ";
			 public static string Xtwplj = @"XTWPLJ";
			 public static string Schtsl = @"SCHTSL";
			 public static string Scggdh = @"SCGGDH";
			 public static string Scyspd = @"SCYSPD";
			 public static string Xtwldm = @"XTWLDM";
			 public static string Scgydm = @"SCGYDM";
			 public static string Scjhbz = @"SCJHBZ";
			 public static string Xtwpmc = @"XTWPMC";
			 public static string Scjhdd = @"SCJHDD";
			 public static string Clothtype = @"CLOTHTYPE";
			 public static string Jiaji = @"JIAJI";
			 public static string Fangge = @"FANGGE";
			 public static string Woman = @"WOMAN";
			 public static string Shiyi = @"SHIYI";
			 public static string Peijian = @"PEIJIAN";
			 public static string Shougong = @"SHOUGONG";
			 public static string Huizhipi = @"HUIZHIPI";
			 public static string Nabotou = @"NABOTOU";
			 public static string Ceshi = @"CESHI";
			 public static string Tmw = @"TMW";
			 public static string Guowai = @"GUOWAI";
			 public static string Banzu = @"BANZU";
						
		}
		#endregion
		
		#region Update PK Collections
		
        #endregion
    
        #region Deep Save
		
        #endregion
	}
}
