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
	/// Strongly-typed collection for the WmsSyncPlanmDelete class.
	/// </summary>
    [Serializable]
	public partial class WmsSyncPlanmDeleteCollection : ActiveList<WmsSyncPlanmDelete, WmsSyncPlanmDeleteCollection>
	{	   
		public WmsSyncPlanmDeleteCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>WmsSyncPlanmDeleteCollection</returns>
		public WmsSyncPlanmDeleteCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                WmsSyncPlanmDelete o = this[i];
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
	/// This is an ActiveRecord class which wraps the WMS_SYNC_planm_delete table.
	/// </summary>
	[Serializable]
	public partial class WmsSyncPlanmDelete : ActiveRecord<WmsSyncPlanmDelete>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public WmsSyncPlanmDelete()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public WmsSyncPlanmDelete(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public WmsSyncPlanmDelete(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public WmsSyncPlanmDelete(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("WMS_SYNC_planm_delete", TableType.Table, DataService.GetInstance("Nowthwin"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarPlanmid = new TableSchema.TableColumn(schema);
				colvarPlanmid.ColumnName = "PLANMID";
				colvarPlanmid.DataType = DbType.Int32;
				colvarPlanmid.MaxLength = 0;
				colvarPlanmid.AutoIncrement = false;
				colvarPlanmid.IsNullable = true;
				colvarPlanmid.IsPrimaryKey = false;
				colvarPlanmid.IsForeignKey = false;
				colvarPlanmid.IsReadOnly = false;
				colvarPlanmid.DefaultSetting = @"";
				colvarPlanmid.ForeignKeyTableName = "";
				schema.Columns.Add(colvarPlanmid);
				
				TableSchema.TableColumn colvarSczsbh = new TableSchema.TableColumn(schema);
				colvarSczsbh.ColumnName = "SCZSBH";
				colvarSczsbh.DataType = DbType.AnsiString;
				colvarSczsbh.MaxLength = 12;
				colvarSczsbh.AutoIncrement = false;
				colvarSczsbh.IsNullable = true;
				colvarSczsbh.IsPrimaryKey = false;
				colvarSczsbh.IsForeignKey = false;
				colvarSczsbh.IsReadOnly = false;
				colvarSczsbh.DefaultSetting = @"";
				colvarSczsbh.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSczsbh);
				
				TableSchema.TableColumn colvarScgcmc = new TableSchema.TableColumn(schema);
				colvarScgcmc.ColumnName = "SCGCMC";
				colvarScgcmc.DataType = DbType.AnsiString;
				colvarScgcmc.MaxLength = 60;
				colvarScgcmc.AutoIncrement = false;
				colvarScgcmc.IsNullable = true;
				colvarScgcmc.IsPrimaryKey = false;
				colvarScgcmc.IsForeignKey = false;
				colvarScgcmc.IsReadOnly = false;
				colvarScgcmc.DefaultSetting = @"";
				colvarScgcmc.ForeignKeyTableName = "";
				schema.Columns.Add(colvarScgcmc);
				
				TableSchema.TableColumn colvarScxdrq = new TableSchema.TableColumn(schema);
				colvarScxdrq.ColumnName = "SCXDRQ";
				colvarScxdrq.DataType = DbType.DateTime;
				colvarScxdrq.MaxLength = 0;
				colvarScxdrq.AutoIncrement = false;
				colvarScxdrq.IsNullable = true;
				colvarScxdrq.IsPrimaryKey = false;
				colvarScxdrq.IsForeignKey = false;
				colvarScxdrq.IsReadOnly = false;
				colvarScxdrq.DefaultSetting = @"";
				colvarScxdrq.ForeignKeyTableName = "";
				schema.Columns.Add(colvarScxdrq);
				
				TableSchema.TableColumn colvarSccjjq = new TableSchema.TableColumn(schema);
				colvarSccjjq.ColumnName = "SCCJJQ";
				colvarSccjjq.DataType = DbType.DateTime;
				colvarSccjjq.MaxLength = 0;
				colvarSccjjq.AutoIncrement = false;
				colvarSccjjq.IsNullable = true;
				colvarSccjjq.IsPrimaryKey = false;
				colvarSccjjq.IsForeignKey = false;
				colvarSccjjq.IsReadOnly = false;
				colvarSccjjq.DefaultSetting = @"";
				colvarSccjjq.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSccjjq);
				
				TableSchema.TableColumn colvarScjhry = new TableSchema.TableColumn(schema);
				colvarScjhry.ColumnName = "SCJHRY";
				colvarScjhry.DataType = DbType.AnsiString;
				colvarScjhry.MaxLength = 8;
				colvarScjhry.AutoIncrement = false;
				colvarScjhry.IsNullable = true;
				colvarScjhry.IsPrimaryKey = false;
				colvarScjhry.IsForeignKey = false;
				colvarScjhry.IsReadOnly = false;
				colvarScjhry.DefaultSetting = @"";
				colvarScjhry.ForeignKeyTableName = "";
				schema.Columns.Add(colvarScjhry);
				
				TableSchema.TableColumn colvarSczsbz = new TableSchema.TableColumn(schema);
				colvarSczsbz.ColumnName = "SCZSBZ";
				colvarSczsbz.DataType = DbType.AnsiString;
				colvarSczsbz.MaxLength = 200;
				colvarSczsbz.AutoIncrement = false;
				colvarSczsbz.IsNullable = true;
				colvarSczsbz.IsPrimaryKey = false;
				colvarSczsbz.IsForeignKey = false;
				colvarSczsbz.IsReadOnly = false;
				colvarSczsbz.DefaultSetting = @"";
				colvarSczsbz.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSczsbz);
				
				TableSchema.TableColumn colvarSchtbh = new TableSchema.TableColumn(schema);
				colvarSchtbh.ColumnName = "SCHTBH";
				colvarSchtbh.DataType = DbType.AnsiString;
				colvarSchtbh.MaxLength = 12;
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
				colvarScggdh.DataType = DbType.AnsiString;
				colvarScggdh.MaxLength = 12;
				colvarScggdh.AutoIncrement = false;
				colvarScggdh.IsNullable = true;
				colvarScggdh.IsPrimaryKey = false;
				colvarScggdh.IsForeignKey = false;
				colvarScggdh.IsReadOnly = false;
				colvarScggdh.DefaultSetting = @"";
				colvarScggdh.ForeignKeyTableName = "";
				schema.Columns.Add(colvarScggdh);
				
				TableSchema.TableColumn colvarKhddbh = new TableSchema.TableColumn(schema);
				colvarKhddbh.ColumnName = "KHDDBH";
				colvarKhddbh.DataType = DbType.AnsiString;
				colvarKhddbh.MaxLength = 30;
				colvarKhddbh.AutoIncrement = false;
				colvarKhddbh.IsNullable = true;
				colvarKhddbh.IsPrimaryKey = false;
				colvarKhddbh.IsForeignKey = false;
				colvarKhddbh.IsReadOnly = false;
				colvarKhddbh.DefaultSetting = @"";
				colvarKhddbh.ForeignKeyTableName = "";
				schema.Columns.Add(colvarKhddbh);
				
				TableSchema.TableColumn colvarSczsdl = new TableSchema.TableColumn(schema);
				colvarSczsdl.ColumnName = "SCZSDL";
				colvarSczsdl.DataType = DbType.AnsiString;
				colvarSczsdl.MaxLength = 200;
				colvarSczsdl.AutoIncrement = false;
				colvarSczsdl.IsNullable = true;
				colvarSczsdl.IsPrimaryKey = false;
				colvarSczsdl.IsForeignKey = false;
				colvarSczsdl.IsReadOnly = false;
				colvarSczsdl.DefaultSetting = @"";
				colvarSczsdl.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSczsdl);
				
				TableSchema.TableColumn colvarSczssl = new TableSchema.TableColumn(schema);
				colvarSczssl.ColumnName = "SCZSSL";
				colvarSczssl.DataType = DbType.Int32;
				colvarSczssl.MaxLength = 0;
				colvarSczssl.AutoIncrement = false;
				colvarSczssl.IsNullable = true;
				colvarSczssl.IsPrimaryKey = false;
				colvarSczssl.IsForeignKey = false;
				colvarSczssl.IsReadOnly = false;
				colvarSczssl.DefaultSetting = @"";
				colvarSczssl.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSczssl);
				
				TableSchema.TableColumn colvarSczszt = new TableSchema.TableColumn(schema);
				colvarSczszt.ColumnName = "SCZSZT";
				colvarSczszt.DataType = DbType.AnsiString;
				colvarSczszt.MaxLength = 1;
				colvarSczszt.AutoIncrement = false;
				colvarSczszt.IsNullable = true;
				colvarSczszt.IsPrimaryKey = false;
				colvarSczszt.IsForeignKey = false;
				colvarSczszt.IsReadOnly = false;
				colvarSczszt.DefaultSetting = @"";
				colvarSczszt.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSczszt);
				
				TableSchema.TableColumn colvarScnlzy = new TableSchema.TableColumn(schema);
				colvarScnlzy.ColumnName = "SCNLZY";
				colvarScnlzy.DataType = DbType.Decimal;
				colvarScnlzy.MaxLength = 0;
				colvarScnlzy.AutoIncrement = false;
				colvarScnlzy.IsNullable = true;
				colvarScnlzy.IsPrimaryKey = false;
				colvarScnlzy.IsForeignKey = false;
				colvarScnlzy.IsReadOnly = false;
				colvarScnlzy.DefaultSetting = @"";
				colvarScnlzy.ForeignKeyTableName = "";
				schema.Columns.Add(colvarScnlzy);
				
				TableSchema.TableColumn colvarStatus = new TableSchema.TableColumn(schema);
				colvarStatus.ColumnName = "STATUS";
				colvarStatus.DataType = DbType.AnsiString;
				colvarStatus.MaxLength = 2;
				colvarStatus.AutoIncrement = false;
				colvarStatus.IsNullable = true;
				colvarStatus.IsPrimaryKey = false;
				colvarStatus.IsForeignKey = false;
				colvarStatus.IsReadOnly = false;
				colvarStatus.DefaultSetting = @"";
				colvarStatus.ForeignKeyTableName = "";
				schema.Columns.Add(colvarStatus);
				
				TableSchema.TableColumn colvarDeleted = new TableSchema.TableColumn(schema);
				colvarDeleted.ColumnName = "DELETED";
				colvarDeleted.DataType = DbType.Boolean;
				colvarDeleted.MaxLength = 0;
				colvarDeleted.AutoIncrement = false;
				colvarDeleted.IsNullable = true;
				colvarDeleted.IsPrimaryKey = false;
				colvarDeleted.IsForeignKey = false;
				colvarDeleted.IsReadOnly = false;
				colvarDeleted.DefaultSetting = @"";
				colvarDeleted.ForeignKeyTableName = "";
				schema.Columns.Add(colvarDeleted);
				
				TableSchema.TableColumn colvarWlbm = new TableSchema.TableColumn(schema);
				colvarWlbm.ColumnName = "WLBM";
				colvarWlbm.DataType = DbType.AnsiString;
				colvarWlbm.MaxLength = 50;
				colvarWlbm.AutoIncrement = false;
				colvarWlbm.IsNullable = true;
				colvarWlbm.IsPrimaryKey = false;
				colvarWlbm.IsForeignKey = false;
				colvarWlbm.IsReadOnly = false;
				colvarWlbm.DefaultSetting = @"";
				colvarWlbm.ForeignKeyTableName = "";
				schema.Columns.Add(colvarWlbm);
				
				TableSchema.TableColumn colvarWlbmbz = new TableSchema.TableColumn(schema);
				colvarWlbmbz.ColumnName = "WLBMBZ";
				colvarWlbmbz.DataType = DbType.AnsiString;
				colvarWlbmbz.MaxLength = 2;
				colvarWlbmbz.AutoIncrement = false;
				colvarWlbmbz.IsNullable = true;
				colvarWlbmbz.IsPrimaryKey = false;
				colvarWlbmbz.IsForeignKey = false;
				colvarWlbmbz.IsReadOnly = false;
				colvarWlbmbz.DefaultSetting = @"";
				colvarWlbmbz.ForeignKeyTableName = "";
				schema.Columns.Add(colvarWlbmbz);
				
				TableSchema.TableColumn colvarWlbmdh = new TableSchema.TableColumn(schema);
				colvarWlbmdh.ColumnName = "WLBMDH";
				colvarWlbmdh.DataType = DbType.AnsiString;
				colvarWlbmdh.MaxLength = 20;
				colvarWlbmdh.AutoIncrement = false;
				colvarWlbmdh.IsNullable = true;
				colvarWlbmdh.IsPrimaryKey = false;
				colvarWlbmdh.IsForeignKey = false;
				colvarWlbmdh.IsReadOnly = false;
				colvarWlbmdh.DefaultSetting = @"";
				colvarWlbmdh.ForeignKeyTableName = "";
				schema.Columns.Add(colvarWlbmdh);
				
				TableSchema.TableColumn colvarPlanType = new TableSchema.TableColumn(schema);
				colvarPlanType.ColumnName = "PlanType";
				colvarPlanType.DataType = DbType.AnsiString;
				colvarPlanType.MaxLength = 8;
				colvarPlanType.AutoIncrement = false;
				colvarPlanType.IsNullable = true;
				colvarPlanType.IsPrimaryKey = false;
				colvarPlanType.IsForeignKey = false;
				colvarPlanType.IsReadOnly = false;
				colvarPlanType.DefaultSetting = @"";
				colvarPlanType.ForeignKeyTableName = "";
				schema.Columns.Add(colvarPlanType);
				
				TableSchema.TableColumn colvarSctcrq = new TableSchema.TableColumn(schema);
				colvarSctcrq.ColumnName = "SCTCRQ";
				colvarSctcrq.DataType = DbType.DateTime;
				colvarSctcrq.MaxLength = 0;
				colvarSctcrq.AutoIncrement = false;
				colvarSctcrq.IsNullable = true;
				colvarSctcrq.IsPrimaryKey = false;
				colvarSctcrq.IsForeignKey = false;
				colvarSctcrq.IsReadOnly = false;
				colvarSctcrq.DefaultSetting = @"";
				colvarSctcrq.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSctcrq);
				
				TableSchema.TableColumn colvarScfzxh = new TableSchema.TableColumn(schema);
				colvarScfzxh.ColumnName = "SCFZXH";
				colvarScfzxh.DataType = DbType.AnsiString;
				colvarScfzxh.MaxLength = 22;
				colvarScfzxh.AutoIncrement = false;
				colvarScfzxh.IsNullable = true;
				colvarScfzxh.IsPrimaryKey = false;
				colvarScfzxh.IsForeignKey = false;
				colvarScfzxh.IsReadOnly = false;
				colvarScfzxh.DefaultSetting = @"";
				colvarScfzxh.ForeignKeyTableName = "";
				schema.Columns.Add(colvarScfzxh);
				
				TableSchema.TableColumn colvarSckhxm = new TableSchema.TableColumn(schema);
				colvarSckhxm.ColumnName = "SCKHXM";
				colvarSckhxm.DataType = DbType.AnsiString;
				colvarSckhxm.MaxLength = 100;
				colvarSckhxm.AutoIncrement = false;
				colvarSckhxm.IsNullable = true;
				colvarSckhxm.IsPrimaryKey = false;
				colvarSckhxm.IsForeignKey = false;
				colvarSckhxm.IsReadOnly = false;
				colvarSckhxm.DefaultSetting = @"";
				colvarSckhxm.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSckhxm);
				
				TableSchema.TableColumn colvarScfzjq = new TableSchema.TableColumn(schema);
				colvarScfzjq.ColumnName = "SCFZJQ";
				colvarScfzjq.DataType = DbType.DateTime;
				colvarScfzjq.MaxLength = 0;
				colvarScfzjq.AutoIncrement = false;
				colvarScfzjq.IsNullable = true;
				colvarScfzjq.IsPrimaryKey = false;
				colvarScfzjq.IsForeignKey = false;
				colvarScfzjq.IsReadOnly = false;
				colvarScfzjq.DefaultSetting = @"";
				colvarScfzjq.ForeignKeyTableName = "";
				schema.Columns.Add(colvarScfzjq);
				
				TableSchema.TableColumn colvarScztjq = new TableSchema.TableColumn(schema);
				colvarScztjq.ColumnName = "SCZTJQ";
				colvarScztjq.DataType = DbType.DateTime;
				colvarScztjq.MaxLength = 0;
				colvarScztjq.AutoIncrement = false;
				colvarScztjq.IsNullable = true;
				colvarScztjq.IsPrimaryKey = false;
				colvarScztjq.IsForeignKey = false;
				colvarScztjq.IsReadOnly = false;
				colvarScztjq.DefaultSetting = @"";
				colvarScztjq.ForeignKeyTableName = "";
				schema.Columns.Add(colvarScztjq);
				
				TableSchema.TableColumn colvarScbzjq = new TableSchema.TableColumn(schema);
				colvarScbzjq.ColumnName = "SCBZJQ";
				colvarScbzjq.DataType = DbType.DateTime;
				colvarScbzjq.MaxLength = 0;
				colvarScbzjq.AutoIncrement = false;
				colvarScbzjq.IsNullable = true;
				colvarScbzjq.IsPrimaryKey = false;
				colvarScbzjq.IsForeignKey = false;
				colvarScbzjq.IsReadOnly = false;
				colvarScbzjq.DefaultSetting = @"";
				colvarScbzjq.ForeignKeyTableName = "";
				schema.Columns.Add(colvarScbzjq);
				
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
				
				TableSchema.TableColumn colvarDdjhrq = new TableSchema.TableColumn(schema);
				colvarDdjhrq.ColumnName = "DDJHRQ";
				colvarDdjhrq.DataType = DbType.DateTime;
				colvarDdjhrq.MaxLength = 0;
				colvarDdjhrq.AutoIncrement = false;
				colvarDdjhrq.IsNullable = true;
				colvarDdjhrq.IsPrimaryKey = false;
				colvarDdjhrq.IsForeignKey = false;
				colvarDdjhrq.IsReadOnly = false;
				colvarDdjhrq.DefaultSetting = @"";
				colvarDdjhrq.ForeignKeyTableName = "";
				schema.Columns.Add(colvarDdjhrq);
				
				TableSchema.TableColumn colvarStatusOld = new TableSchema.TableColumn(schema);
				colvarStatusOld.ColumnName = "STATUS_OLD";
				colvarStatusOld.DataType = DbType.AnsiString;
				colvarStatusOld.MaxLength = 2;
				colvarStatusOld.AutoIncrement = false;
				colvarStatusOld.IsNullable = true;
				colvarStatusOld.IsPrimaryKey = false;
				colvarStatusOld.IsForeignKey = false;
				colvarStatusOld.IsReadOnly = false;
				colvarStatusOld.DefaultSetting = @"";
				colvarStatusOld.ForeignKeyTableName = "";
				schema.Columns.Add(colvarStatusOld);
				
				TableSchema.TableColumn colvarDdhtbh = new TableSchema.TableColumn(schema);
				colvarDdhtbh.ColumnName = "DDHTBH";
				colvarDdhtbh.DataType = DbType.AnsiString;
				colvarDdhtbh.MaxLength = 30;
				colvarDdhtbh.AutoIncrement = false;
				colvarDdhtbh.IsNullable = true;
				colvarDdhtbh.IsPrimaryKey = false;
				colvarDdhtbh.IsForeignKey = false;
				colvarDdhtbh.IsReadOnly = false;
				colvarDdhtbh.DefaultSetting = @"";
				colvarDdhtbh.ForeignKeyTableName = "";
				schema.Columns.Add(colvarDdhtbh);
				
				TableSchema.TableColumn colvarSyncd = new TableSchema.TableColumn(schema);
				colvarSyncd.ColumnName = "SYNCD";
				colvarSyncd.DataType = DbType.AnsiStringFixedLength;
				colvarSyncd.MaxLength = 1;
				colvarSyncd.AutoIncrement = false;
				colvarSyncd.IsNullable = true;
				colvarSyncd.IsPrimaryKey = false;
				colvarSyncd.IsForeignKey = false;
				colvarSyncd.IsReadOnly = false;
				colvarSyncd.DefaultSetting = @"";
				colvarSyncd.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSyncd);
				
				TableSchema.TableColumn colvarStime = new TableSchema.TableColumn(schema);
				colvarStime.ColumnName = "stime";
				colvarStime.DataType = DbType.DateTime;
				colvarStime.MaxLength = 0;
				colvarStime.AutoIncrement = false;
				colvarStime.IsNullable = true;
				colvarStime.IsPrimaryKey = false;
				colvarStime.IsForeignKey = false;
				colvarStime.IsReadOnly = false;
				colvarStime.DefaultSetting = @"";
				colvarStime.ForeignKeyTableName = "";
				schema.Columns.Add(colvarStime);
				
				TableSchema.TableColumn colvarPid = new TableSchema.TableColumn(schema);
				colvarPid.ColumnName = "pid";
				colvarPid.DataType = DbType.Int32;
				colvarPid.MaxLength = 0;
				colvarPid.AutoIncrement = true;
				colvarPid.IsNullable = false;
				colvarPid.IsPrimaryKey = true;
				colvarPid.IsForeignKey = false;
				colvarPid.IsReadOnly = false;
				colvarPid.DefaultSetting = @"";
				colvarPid.ForeignKeyTableName = "";
				schema.Columns.Add(colvarPid);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["Nowthwin"].AddSchema("WMS_SYNC_planm_delete",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("Planmid")]
		[Bindable(true)]
		public int? Planmid 
		{
			get { return GetColumnValue<int?>(Columns.Planmid); }
			set { SetColumnValue(Columns.Planmid, value); }
		}
		  
		[XmlAttribute("Sczsbh")]
		[Bindable(true)]
		public string Sczsbh 
		{
			get { return GetColumnValue<string>(Columns.Sczsbh); }
			set { SetColumnValue(Columns.Sczsbh, value); }
		}
		  
		[XmlAttribute("Scgcmc")]
		[Bindable(true)]
		public string Scgcmc 
		{
			get { return GetColumnValue<string>(Columns.Scgcmc); }
			set { SetColumnValue(Columns.Scgcmc, value); }
		}
		  
		[XmlAttribute("Scxdrq")]
		[Bindable(true)]
		public DateTime? Scxdrq 
		{
			get { return GetColumnValue<DateTime?>(Columns.Scxdrq); }
			set { SetColumnValue(Columns.Scxdrq, value); }
		}
		  
		[XmlAttribute("Sccjjq")]
		[Bindable(true)]
		public DateTime? Sccjjq 
		{
			get { return GetColumnValue<DateTime?>(Columns.Sccjjq); }
			set { SetColumnValue(Columns.Sccjjq, value); }
		}
		  
		[XmlAttribute("Scjhry")]
		[Bindable(true)]
		public string Scjhry 
		{
			get { return GetColumnValue<string>(Columns.Scjhry); }
			set { SetColumnValue(Columns.Scjhry, value); }
		}
		  
		[XmlAttribute("Sczsbz")]
		[Bindable(true)]
		public string Sczsbz 
		{
			get { return GetColumnValue<string>(Columns.Sczsbz); }
			set { SetColumnValue(Columns.Sczsbz, value); }
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
		  
		[XmlAttribute("Khddbh")]
		[Bindable(true)]
		public string Khddbh 
		{
			get { return GetColumnValue<string>(Columns.Khddbh); }
			set { SetColumnValue(Columns.Khddbh, value); }
		}
		  
		[XmlAttribute("Sczsdl")]
		[Bindable(true)]
		public string Sczsdl 
		{
			get { return GetColumnValue<string>(Columns.Sczsdl); }
			set { SetColumnValue(Columns.Sczsdl, value); }
		}
		  
		[XmlAttribute("Sczssl")]
		[Bindable(true)]
		public int? Sczssl 
		{
			get { return GetColumnValue<int?>(Columns.Sczssl); }
			set { SetColumnValue(Columns.Sczssl, value); }
		}
		  
		[XmlAttribute("Sczszt")]
		[Bindable(true)]
		public string Sczszt 
		{
			get { return GetColumnValue<string>(Columns.Sczszt); }
			set { SetColumnValue(Columns.Sczszt, value); }
		}
		  
		[XmlAttribute("Scnlzy")]
		[Bindable(true)]
		public decimal? Scnlzy 
		{
			get { return GetColumnValue<decimal?>(Columns.Scnlzy); }
			set { SetColumnValue(Columns.Scnlzy, value); }
		}
		  
		[XmlAttribute("Status")]
		[Bindable(true)]
		public string Status 
		{
			get { return GetColumnValue<string>(Columns.Status); }
			set { SetColumnValue(Columns.Status, value); }
		}
		  
		[XmlAttribute("Deleted")]
		[Bindable(true)]
		public bool? Deleted 
		{
			get { return GetColumnValue<bool?>(Columns.Deleted); }
			set { SetColumnValue(Columns.Deleted, value); }
		}
		  
		[XmlAttribute("Wlbm")]
		[Bindable(true)]
		public string Wlbm 
		{
			get { return GetColumnValue<string>(Columns.Wlbm); }
			set { SetColumnValue(Columns.Wlbm, value); }
		}
		  
		[XmlAttribute("Wlbmbz")]
		[Bindable(true)]
		public string Wlbmbz 
		{
			get { return GetColumnValue<string>(Columns.Wlbmbz); }
			set { SetColumnValue(Columns.Wlbmbz, value); }
		}
		  
		[XmlAttribute("Wlbmdh")]
		[Bindable(true)]
		public string Wlbmdh 
		{
			get { return GetColumnValue<string>(Columns.Wlbmdh); }
			set { SetColumnValue(Columns.Wlbmdh, value); }
		}
		  
		[XmlAttribute("PlanType")]
		[Bindable(true)]
		public string PlanType 
		{
			get { return GetColumnValue<string>(Columns.PlanType); }
			set { SetColumnValue(Columns.PlanType, value); }
		}
		  
		[XmlAttribute("Sctcrq")]
		[Bindable(true)]
		public DateTime? Sctcrq 
		{
			get { return GetColumnValue<DateTime?>(Columns.Sctcrq); }
			set { SetColumnValue(Columns.Sctcrq, value); }
		}
		  
		[XmlAttribute("Scfzxh")]
		[Bindable(true)]
		public string Scfzxh 
		{
			get { return GetColumnValue<string>(Columns.Scfzxh); }
			set { SetColumnValue(Columns.Scfzxh, value); }
		}
		  
		[XmlAttribute("Sckhxm")]
		[Bindable(true)]
		public string Sckhxm 
		{
			get { return GetColumnValue<string>(Columns.Sckhxm); }
			set { SetColumnValue(Columns.Sckhxm, value); }
		}
		  
		[XmlAttribute("Scfzjq")]
		[Bindable(true)]
		public DateTime? Scfzjq 
		{
			get { return GetColumnValue<DateTime?>(Columns.Scfzjq); }
			set { SetColumnValue(Columns.Scfzjq, value); }
		}
		  
		[XmlAttribute("Scztjq")]
		[Bindable(true)]
		public DateTime? Scztjq 
		{
			get { return GetColumnValue<DateTime?>(Columns.Scztjq); }
			set { SetColumnValue(Columns.Scztjq, value); }
		}
		  
		[XmlAttribute("Scbzjq")]
		[Bindable(true)]
		public DateTime? Scbzjq 
		{
			get { return GetColumnValue<DateTime?>(Columns.Scbzjq); }
			set { SetColumnValue(Columns.Scbzjq, value); }
		}
		  
		[XmlAttribute("Scjhrq")]
		[Bindable(true)]
		public DateTime? Scjhrq 
		{
			get { return GetColumnValue<DateTime?>(Columns.Scjhrq); }
			set { SetColumnValue(Columns.Scjhrq, value); }
		}
		  
		[XmlAttribute("Ddjhrq")]
		[Bindable(true)]
		public DateTime? Ddjhrq 
		{
			get { return GetColumnValue<DateTime?>(Columns.Ddjhrq); }
			set { SetColumnValue(Columns.Ddjhrq, value); }
		}
		  
		[XmlAttribute("StatusOld")]
		[Bindable(true)]
		public string StatusOld 
		{
			get { return GetColumnValue<string>(Columns.StatusOld); }
			set { SetColumnValue(Columns.StatusOld, value); }
		}
		  
		[XmlAttribute("Ddhtbh")]
		[Bindable(true)]
		public string Ddhtbh 
		{
			get { return GetColumnValue<string>(Columns.Ddhtbh); }
			set { SetColumnValue(Columns.Ddhtbh, value); }
		}
		  
		[XmlAttribute("Syncd")]
		[Bindable(true)]
		public string Syncd 
		{
			get { return GetColumnValue<string>(Columns.Syncd); }
			set { SetColumnValue(Columns.Syncd, value); }
		}
		  
		[XmlAttribute("Stime")]
		[Bindable(true)]
		public DateTime? Stime 
		{
			get { return GetColumnValue<DateTime?>(Columns.Stime); }
			set { SetColumnValue(Columns.Stime, value); }
		}
		  
		[XmlAttribute("Pid")]
		[Bindable(true)]
		public int Pid 
		{
			get { return GetColumnValue<int>(Columns.Pid); }
			set { SetColumnValue(Columns.Pid, value); }
		}
		
		#endregion
		
		
			
		
		//no foreign key tables defined (0)
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(int? varPlanmid,string varSczsbh,string varScgcmc,DateTime? varScxdrq,DateTime? varSccjjq,string varScjhry,string varSczsbz,string varSchtbh,string varScggdh,string varKhddbh,string varSczsdl,int? varSczssl,string varSczszt,decimal? varScnlzy,string varStatus,bool? varDeleted,string varWlbm,string varWlbmbz,string varWlbmdh,string varPlanType,DateTime? varSctcrq,string varScfzxh,string varSckhxm,DateTime? varScfzjq,DateTime? varScztjq,DateTime? varScbzjq,DateTime? varScjhrq,DateTime? varDdjhrq,string varStatusOld,string varDdhtbh,string varSyncd,DateTime? varStime)
		{
			WmsSyncPlanmDelete item = new WmsSyncPlanmDelete();
			
			item.Planmid = varPlanmid;
			
			item.Sczsbh = varSczsbh;
			
			item.Scgcmc = varScgcmc;
			
			item.Scxdrq = varScxdrq;
			
			item.Sccjjq = varSccjjq;
			
			item.Scjhry = varScjhry;
			
			item.Sczsbz = varSczsbz;
			
			item.Schtbh = varSchtbh;
			
			item.Scggdh = varScggdh;
			
			item.Khddbh = varKhddbh;
			
			item.Sczsdl = varSczsdl;
			
			item.Sczssl = varSczssl;
			
			item.Sczszt = varSczszt;
			
			item.Scnlzy = varScnlzy;
			
			item.Status = varStatus;
			
			item.Deleted = varDeleted;
			
			item.Wlbm = varWlbm;
			
			item.Wlbmbz = varWlbmbz;
			
			item.Wlbmdh = varWlbmdh;
			
			item.PlanType = varPlanType;
			
			item.Sctcrq = varSctcrq;
			
			item.Scfzxh = varScfzxh;
			
			item.Sckhxm = varSckhxm;
			
			item.Scfzjq = varScfzjq;
			
			item.Scztjq = varScztjq;
			
			item.Scbzjq = varScbzjq;
			
			item.Scjhrq = varScjhrq;
			
			item.Ddjhrq = varDdjhrq;
			
			item.StatusOld = varStatusOld;
			
			item.Ddhtbh = varDdhtbh;
			
			item.Syncd = varSyncd;
			
			item.Stime = varStime;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int? varPlanmid,string varSczsbh,string varScgcmc,DateTime? varScxdrq,DateTime? varSccjjq,string varScjhry,string varSczsbz,string varSchtbh,string varScggdh,string varKhddbh,string varSczsdl,int? varSczssl,string varSczszt,decimal? varScnlzy,string varStatus,bool? varDeleted,string varWlbm,string varWlbmbz,string varWlbmdh,string varPlanType,DateTime? varSctcrq,string varScfzxh,string varSckhxm,DateTime? varScfzjq,DateTime? varScztjq,DateTime? varScbzjq,DateTime? varScjhrq,DateTime? varDdjhrq,string varStatusOld,string varDdhtbh,string varSyncd,DateTime? varStime,int varPid)
		{
			WmsSyncPlanmDelete item = new WmsSyncPlanmDelete();
			
				item.Planmid = varPlanmid;
			
				item.Sczsbh = varSczsbh;
			
				item.Scgcmc = varScgcmc;
			
				item.Scxdrq = varScxdrq;
			
				item.Sccjjq = varSccjjq;
			
				item.Scjhry = varScjhry;
			
				item.Sczsbz = varSczsbz;
			
				item.Schtbh = varSchtbh;
			
				item.Scggdh = varScggdh;
			
				item.Khddbh = varKhddbh;
			
				item.Sczsdl = varSczsdl;
			
				item.Sczssl = varSczssl;
			
				item.Sczszt = varSczszt;
			
				item.Scnlzy = varScnlzy;
			
				item.Status = varStatus;
			
				item.Deleted = varDeleted;
			
				item.Wlbm = varWlbm;
			
				item.Wlbmbz = varWlbmbz;
			
				item.Wlbmdh = varWlbmdh;
			
				item.PlanType = varPlanType;
			
				item.Sctcrq = varSctcrq;
			
				item.Scfzxh = varScfzxh;
			
				item.Sckhxm = varSckhxm;
			
				item.Scfzjq = varScfzjq;
			
				item.Scztjq = varScztjq;
			
				item.Scbzjq = varScbzjq;
			
				item.Scjhrq = varScjhrq;
			
				item.Ddjhrq = varDdjhrq;
			
				item.StatusOld = varStatusOld;
			
				item.Ddhtbh = varDdhtbh;
			
				item.Syncd = varSyncd;
			
				item.Stime = varStime;
			
				item.Pid = varPid;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn PlanmidColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn SczsbhColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        public static TableSchema.TableColumn ScgcmcColumn
        {
            get { return Schema.Columns[2]; }
        }
        
        
        
        public static TableSchema.TableColumn ScxdrqColumn
        {
            get { return Schema.Columns[3]; }
        }
        
        
        
        public static TableSchema.TableColumn SccjjqColumn
        {
            get { return Schema.Columns[4]; }
        }
        
        
        
        public static TableSchema.TableColumn ScjhryColumn
        {
            get { return Schema.Columns[5]; }
        }
        
        
        
        public static TableSchema.TableColumn SczsbzColumn
        {
            get { return Schema.Columns[6]; }
        }
        
        
        
        public static TableSchema.TableColumn SchtbhColumn
        {
            get { return Schema.Columns[7]; }
        }
        
        
        
        public static TableSchema.TableColumn ScggdhColumn
        {
            get { return Schema.Columns[8]; }
        }
        
        
        
        public static TableSchema.TableColumn KhddbhColumn
        {
            get { return Schema.Columns[9]; }
        }
        
        
        
        public static TableSchema.TableColumn SczsdlColumn
        {
            get { return Schema.Columns[10]; }
        }
        
        
        
        public static TableSchema.TableColumn SczsslColumn
        {
            get { return Schema.Columns[11]; }
        }
        
        
        
        public static TableSchema.TableColumn SczsztColumn
        {
            get { return Schema.Columns[12]; }
        }
        
        
        
        public static TableSchema.TableColumn ScnlzyColumn
        {
            get { return Schema.Columns[13]; }
        }
        
        
        
        public static TableSchema.TableColumn StatusColumn
        {
            get { return Schema.Columns[14]; }
        }
        
        
        
        public static TableSchema.TableColumn DeletedColumn
        {
            get { return Schema.Columns[15]; }
        }
        
        
        
        public static TableSchema.TableColumn WlbmColumn
        {
            get { return Schema.Columns[16]; }
        }
        
        
        
        public static TableSchema.TableColumn WlbmbzColumn
        {
            get { return Schema.Columns[17]; }
        }
        
        
        
        public static TableSchema.TableColumn WlbmdhColumn
        {
            get { return Schema.Columns[18]; }
        }
        
        
        
        public static TableSchema.TableColumn PlanTypeColumn
        {
            get { return Schema.Columns[19]; }
        }
        
        
        
        public static TableSchema.TableColumn SctcrqColumn
        {
            get { return Schema.Columns[20]; }
        }
        
        
        
        public static TableSchema.TableColumn ScfzxhColumn
        {
            get { return Schema.Columns[21]; }
        }
        
        
        
        public static TableSchema.TableColumn SckhxmColumn
        {
            get { return Schema.Columns[22]; }
        }
        
        
        
        public static TableSchema.TableColumn ScfzjqColumn
        {
            get { return Schema.Columns[23]; }
        }
        
        
        
        public static TableSchema.TableColumn ScztjqColumn
        {
            get { return Schema.Columns[24]; }
        }
        
        
        
        public static TableSchema.TableColumn ScbzjqColumn
        {
            get { return Schema.Columns[25]; }
        }
        
        
        
        public static TableSchema.TableColumn ScjhrqColumn
        {
            get { return Schema.Columns[26]; }
        }
        
        
        
        public static TableSchema.TableColumn DdjhrqColumn
        {
            get { return Schema.Columns[27]; }
        }
        
        
        
        public static TableSchema.TableColumn StatusOldColumn
        {
            get { return Schema.Columns[28]; }
        }
        
        
        
        public static TableSchema.TableColumn DdhtbhColumn
        {
            get { return Schema.Columns[29]; }
        }
        
        
        
        public static TableSchema.TableColumn SyncdColumn
        {
            get { return Schema.Columns[30]; }
        }
        
        
        
        public static TableSchema.TableColumn StimeColumn
        {
            get { return Schema.Columns[31]; }
        }
        
        
        
        public static TableSchema.TableColumn PidColumn
        {
            get { return Schema.Columns[32]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string Planmid = @"PLANMID";
			 public static string Sczsbh = @"SCZSBH";
			 public static string Scgcmc = @"SCGCMC";
			 public static string Scxdrq = @"SCXDRQ";
			 public static string Sccjjq = @"SCCJJQ";
			 public static string Scjhry = @"SCJHRY";
			 public static string Sczsbz = @"SCZSBZ";
			 public static string Schtbh = @"SCHTBH";
			 public static string Scggdh = @"SCGGDH";
			 public static string Khddbh = @"KHDDBH";
			 public static string Sczsdl = @"SCZSDL";
			 public static string Sczssl = @"SCZSSL";
			 public static string Sczszt = @"SCZSZT";
			 public static string Scnlzy = @"SCNLZY";
			 public static string Status = @"STATUS";
			 public static string Deleted = @"DELETED";
			 public static string Wlbm = @"WLBM";
			 public static string Wlbmbz = @"WLBMBZ";
			 public static string Wlbmdh = @"WLBMDH";
			 public static string PlanType = @"PlanType";
			 public static string Sctcrq = @"SCTCRQ";
			 public static string Scfzxh = @"SCFZXH";
			 public static string Sckhxm = @"SCKHXM";
			 public static string Scfzjq = @"SCFZJQ";
			 public static string Scztjq = @"SCZTJQ";
			 public static string Scbzjq = @"SCBZJQ";
			 public static string Scjhrq = @"SCJHRQ";
			 public static string Ddjhrq = @"DDJHRQ";
			 public static string StatusOld = @"STATUS_OLD";
			 public static string Ddhtbh = @"DDHTBH";
			 public static string Syncd = @"SYNCD";
			 public static string Stime = @"stime";
			 public static string Pid = @"pid";
						
		}
		#endregion
		
		#region Update PK Collections
		
        #endregion
    
        #region Deep Save
		
        #endregion
	}
}
