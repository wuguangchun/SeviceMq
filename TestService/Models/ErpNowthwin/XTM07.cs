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
	/// Strongly-typed collection for the XTM07 class.
	/// </summary>
    [Serializable]
	public partial class XTM07Collection : ActiveList<XTM07, XTM07Collection>
	{	   
		public XTM07Collection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>XTM07Collection</returns>
		public XTM07Collection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                XTM07 o = this[i];
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
	/// This is an ActiveRecord class which wraps the XTM07 table.
	/// </summary>
	[Serializable]
	public partial class XTM07 : ActiveRecord<XTM07>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public XTM07()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public XTM07(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public XTM07(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public XTM07(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("XTM07", TableType.Table, DataService.GetInstance("ErpNowthwin"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"FYERP";
				//columns
				
				TableSchema.TableColumn colvarBmscsj = new TableSchema.TableColumn(schema);
				colvarBmscsj.ColumnName = "BMSCSJ";
				colvarBmscsj.DataType = DbType.DateTime;
				colvarBmscsj.MaxLength = 0;
				colvarBmscsj.AutoIncrement = false;
				colvarBmscsj.IsNullable = true;
				colvarBmscsj.IsPrimaryKey = false;
				colvarBmscsj.IsForeignKey = false;
				colvarBmscsj.IsReadOnly = false;
				colvarBmscsj.DefaultSetting = @"";
				colvarBmscsj.ForeignKeyTableName = "";
				schema.Columns.Add(colvarBmscsj);
				
				TableSchema.TableColumn colvarXtzgdm = new TableSchema.TableColumn(schema);
				colvarXtzgdm.ColumnName = "XTZGDM";
				colvarXtzgdm.DataType = DbType.String;
				colvarXtzgdm.MaxLength = 8;
				colvarXtzgdm.AutoIncrement = false;
				colvarXtzgdm.IsNullable = false;
				colvarXtzgdm.IsPrimaryKey = true;
				colvarXtzgdm.IsForeignKey = false;
				colvarXtzgdm.IsReadOnly = false;
				colvarXtzgdm.DefaultSetting = @"";
				colvarXtzgdm.ForeignKeyTableName = "";
				schema.Columns.Add(colvarXtzgdm);
				
				TableSchema.TableColumn colvarXtzgxm = new TableSchema.TableColumn(schema);
				colvarXtzgxm.ColumnName = "XTZGXM";
				colvarXtzgxm.DataType = DbType.String;
				colvarXtzgxm.MaxLength = 20;
				colvarXtzgxm.AutoIncrement = false;
				colvarXtzgxm.IsNullable = true;
				colvarXtzgxm.IsPrimaryKey = false;
				colvarXtzgxm.IsForeignKey = false;
				colvarXtzgxm.IsReadOnly = false;
				colvarXtzgxm.DefaultSetting = @"";
				colvarXtzgxm.ForeignKeyTableName = "";
				schema.Columns.Add(colvarXtzgxm);
				
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
				
				TableSchema.TableColumn colvarXtzgzz = new TableSchema.TableColumn(schema);
				colvarXtzgzz.ColumnName = "XTZGZZ";
				colvarXtzgzz.DataType = DbType.String;
				colvarXtzgzz.MaxLength = 1;
				colvarXtzgzz.AutoIncrement = false;
				colvarXtzgzz.IsNullable = true;
				colvarXtzgzz.IsPrimaryKey = false;
				colvarXtzgzz.IsForeignKey = false;
				colvarXtzgzz.IsReadOnly = false;
				colvarXtzgzz.DefaultSetting = @"";
				colvarXtzgzz.ForeignKeyTableName = "";
				schema.Columns.Add(colvarXtzgzz);
				
				TableSchema.TableColumn colvarXtzgdz = new TableSchema.TableColumn(schema);
				colvarXtzgdz.ColumnName = "XTZGDZ";
				colvarXtzgdz.DataType = DbType.String;
				colvarXtzgdz.MaxLength = 100;
				colvarXtzgdz.AutoIncrement = false;
				colvarXtzgdz.IsNullable = true;
				colvarXtzgdz.IsPrimaryKey = false;
				colvarXtzgdz.IsForeignKey = false;
				colvarXtzgdz.IsReadOnly = false;
				colvarXtzgdz.DefaultSetting = @"";
				colvarXtzgdz.ForeignKeyTableName = "";
				schema.Columns.Add(colvarXtzgdz);
				
				TableSchema.TableColumn colvarXtyzbm = new TableSchema.TableColumn(schema);
				colvarXtyzbm.ColumnName = "XTYZBM";
				colvarXtyzbm.DataType = DbType.String;
				colvarXtyzbm.MaxLength = 20;
				colvarXtyzbm.AutoIncrement = false;
				colvarXtyzbm.IsNullable = true;
				colvarXtyzbm.IsPrimaryKey = false;
				colvarXtyzbm.IsForeignKey = false;
				colvarXtyzbm.IsReadOnly = false;
				colvarXtyzbm.DefaultSetting = @"";
				colvarXtyzbm.ForeignKeyTableName = "";
				schema.Columns.Add(colvarXtyzbm);
				
				TableSchema.TableColumn colvarXtdhhm = new TableSchema.TableColumn(schema);
				colvarXtdhhm.ColumnName = "XTDHHM";
				colvarXtdhhm.DataType = DbType.String;
				colvarXtdhhm.MaxLength = 20;
				colvarXtdhhm.AutoIncrement = false;
				colvarXtdhhm.IsNullable = true;
				colvarXtdhhm.IsPrimaryKey = false;
				colvarXtdhhm.IsForeignKey = false;
				colvarXtdhhm.IsReadOnly = false;
				colvarXtdhhm.DefaultSetting = @"";
				colvarXtdhhm.ForeignKeyTableName = "";
				schema.Columns.Add(colvarXtdhhm);
				
				TableSchema.TableColumn colvarXtczhm = new TableSchema.TableColumn(schema);
				colvarXtczhm.ColumnName = "XTCZHM";
				colvarXtczhm.DataType = DbType.String;
				colvarXtczhm.MaxLength = 20;
				colvarXtczhm.AutoIncrement = false;
				colvarXtczhm.IsNullable = true;
				colvarXtczhm.IsPrimaryKey = false;
				colvarXtczhm.IsForeignKey = false;
				colvarXtczhm.IsReadOnly = false;
				colvarXtczhm.DefaultSetting = @"";
				colvarXtczhm.ForeignKeyTableName = "";
				schema.Columns.Add(colvarXtczhm);
				
				TableSchema.TableColumn colvarXtbpjh = new TableSchema.TableColumn(schema);
				colvarXtbpjh.ColumnName = "XTBPJH";
				colvarXtbpjh.DataType = DbType.String;
				colvarXtbpjh.MaxLength = 20;
				colvarXtbpjh.AutoIncrement = false;
				colvarXtbpjh.IsNullable = true;
				colvarXtbpjh.IsPrimaryKey = false;
				colvarXtbpjh.IsForeignKey = false;
				colvarXtbpjh.IsReadOnly = false;
				colvarXtbpjh.DefaultSetting = @"";
				colvarXtbpjh.ForeignKeyTableName = "";
				schema.Columns.Add(colvarXtbpjh);
				
				TableSchema.TableColumn colvarXtsjhm = new TableSchema.TableColumn(schema);
				colvarXtsjhm.ColumnName = "XTSJHM";
				colvarXtsjhm.DataType = DbType.String;
				colvarXtsjhm.MaxLength = 20;
				colvarXtsjhm.AutoIncrement = false;
				colvarXtsjhm.IsNullable = true;
				colvarXtsjhm.IsPrimaryKey = false;
				colvarXtsjhm.IsForeignKey = false;
				colvarXtsjhm.IsReadOnly = false;
				colvarXtsjhm.DefaultSetting = @"";
				colvarXtsjhm.ForeignKeyTableName = "";
				schema.Columns.Add(colvarXtsjhm);
				
				TableSchema.TableColumn colvarXtemdz = new TableSchema.TableColumn(schema);
				colvarXtemdz.ColumnName = "XTEMDZ";
				colvarXtemdz.DataType = DbType.String;
				colvarXtemdz.MaxLength = 100;
				colvarXtemdz.AutoIncrement = false;
				colvarXtemdz.IsNullable = true;
				colvarXtemdz.IsPrimaryKey = false;
				colvarXtemdz.IsForeignKey = false;
				colvarXtemdz.IsReadOnly = false;
				colvarXtemdz.DefaultSetting = @"";
				colvarXtemdz.ForeignKeyTableName = "";
				schema.Columns.Add(colvarXtemdz);
				
				TableSchema.TableColumn colvarXtlzbz = new TableSchema.TableColumn(schema);
				colvarXtlzbz.ColumnName = "XTLZBZ";
				colvarXtlzbz.DataType = DbType.String;
				colvarXtlzbz.MaxLength = 1;
				colvarXtlzbz.AutoIncrement = false;
				colvarXtlzbz.IsNullable = true;
				colvarXtlzbz.IsPrimaryKey = false;
				colvarXtlzbz.IsForeignKey = false;
				colvarXtlzbz.IsReadOnly = false;
				colvarXtlzbz.DefaultSetting = @"";
				colvarXtlzbz.ForeignKeyTableName = "";
				schema.Columns.Add(colvarXtlzbz);
				
				TableSchema.TableColumn colvarXtywsm = new TableSchema.TableColumn(schema);
				colvarXtywsm.ColumnName = "XTYWSM";
				colvarXtywsm.DataType = DbType.String;
				colvarXtywsm.MaxLength = 255;
				colvarXtywsm.AutoIncrement = false;
				colvarXtywsm.IsNullable = true;
				colvarXtywsm.IsPrimaryKey = false;
				colvarXtywsm.IsForeignKey = false;
				colvarXtywsm.IsReadOnly = false;
				colvarXtywsm.DefaultSetting = @"";
				colvarXtywsm.ForeignKeyTableName = "";
				schema.Columns.Add(colvarXtywsm);
				
				TableSchema.TableColumn colvarXsndde = new TableSchema.TableColumn(schema);
				colvarXsndde.ColumnName = "XSNDDE";
				colvarXsndde.DataType = DbType.Decimal;
				colvarXsndde.MaxLength = 0;
				colvarXsndde.AutoIncrement = false;
				colvarXsndde.IsNullable = true;
				colvarXsndde.IsPrimaryKey = false;
				colvarXsndde.IsForeignKey = false;
				colvarXsndde.IsReadOnly = false;
				colvarXsndde.DefaultSetting = @"";
				colvarXsndde.ForeignKeyTableName = "";
				schema.Columns.Add(colvarXsndde);
				
				TableSchema.TableColumn colvarXtzgxb = new TableSchema.TableColumn(schema);
				colvarXtzgxb.ColumnName = "XTZGXB";
				colvarXtzgxb.DataType = DbType.String;
				colvarXtzgxb.MaxLength = 1;
				colvarXtzgxb.AutoIncrement = false;
				colvarXtzgxb.IsNullable = true;
				colvarXtzgxb.IsPrimaryKey = false;
				colvarXtzgxb.IsForeignKey = false;
				colvarXtzgxb.IsReadOnly = false;
				colvarXtzgxb.DefaultSetting = @"";
				colvarXtzgxb.ForeignKeyTableName = "";
				schema.Columns.Add(colvarXtzgxb);
				
				TableSchema.TableColumn colvarXtzgmz = new TableSchema.TableColumn(schema);
				colvarXtzgmz.ColumnName = "XTZGMZ";
				colvarXtzgmz.DataType = DbType.String;
				colvarXtzgmz.MaxLength = 10;
				colvarXtzgmz.AutoIncrement = false;
				colvarXtzgmz.IsNullable = true;
				colvarXtzgmz.IsPrimaryKey = false;
				colvarXtzgmz.IsForeignKey = false;
				colvarXtzgmz.IsReadOnly = false;
				colvarXtzgmz.DefaultSetting = @"";
				colvarXtzgmz.ForeignKeyTableName = "";
				schema.Columns.Add(colvarXtzgmz);
				
				TableSchema.TableColumn colvarXtzzmm = new TableSchema.TableColumn(schema);
				colvarXtzzmm.ColumnName = "XTZZMM";
				colvarXtzzmm.DataType = DbType.String;
				colvarXtzzmm.MaxLength = 10;
				colvarXtzzmm.AutoIncrement = false;
				colvarXtzzmm.IsNullable = true;
				colvarXtzzmm.IsPrimaryKey = false;
				colvarXtzzmm.IsForeignKey = false;
				colvarXtzzmm.IsReadOnly = false;
				colvarXtzzmm.DefaultSetting = @"";
				colvarXtzzmm.ForeignKeyTableName = "";
				schema.Columns.Add(colvarXtzzmm);
				
				TableSchema.TableColumn colvarXthyzk = new TableSchema.TableColumn(schema);
				colvarXthyzk.ColumnName = "XTHYZK";
				colvarXthyzk.DataType = DbType.String;
				colvarXthyzk.MaxLength = 1;
				colvarXthyzk.AutoIncrement = false;
				colvarXthyzk.IsNullable = true;
				colvarXthyzk.IsPrimaryKey = false;
				colvarXthyzk.IsForeignKey = false;
				colvarXthyzk.IsReadOnly = false;
				colvarXthyzk.DefaultSetting = @"";
				colvarXthyzk.ForeignKeyTableName = "";
				schema.Columns.Add(colvarXthyzk);
				
				TableSchema.TableColumn colvarXtcsdq = new TableSchema.TableColumn(schema);
				colvarXtcsdq.ColumnName = "XTCSDQ";
				colvarXtcsdq.DataType = DbType.String;
				colvarXtcsdq.MaxLength = 160;
				colvarXtcsdq.AutoIncrement = false;
				colvarXtcsdq.IsNullable = true;
				colvarXtcsdq.IsPrimaryKey = false;
				colvarXtcsdq.IsForeignKey = false;
				colvarXtcsdq.IsReadOnly = false;
				colvarXtcsdq.DefaultSetting = @"";
				colvarXtcsdq.ForeignKeyTableName = "";
				schema.Columns.Add(colvarXtcsdq);
				
				TableSchema.TableColumn colvarXtcsny = new TableSchema.TableColumn(schema);
				colvarXtcsny.ColumnName = "XTCSNY";
				colvarXtcsny.DataType = DbType.DateTime;
				colvarXtcsny.MaxLength = 0;
				colvarXtcsny.AutoIncrement = false;
				colvarXtcsny.IsNullable = true;
				colvarXtcsny.IsPrimaryKey = false;
				colvarXtcsny.IsForeignKey = false;
				colvarXtcsny.IsReadOnly = false;
				colvarXtcsny.DefaultSetting = @"";
				colvarXtcsny.ForeignKeyTableName = "";
				schema.Columns.Add(colvarXtcsny);
				
				TableSchema.TableColumn colvarXtsfzh = new TableSchema.TableColumn(schema);
				colvarXtsfzh.ColumnName = "XTSFZH";
				colvarXtsfzh.DataType = DbType.String;
				colvarXtsfzh.MaxLength = 20;
				colvarXtsfzh.AutoIncrement = false;
				colvarXtsfzh.IsNullable = true;
				colvarXtsfzh.IsPrimaryKey = false;
				colvarXtsfzh.IsForeignKey = false;
				colvarXtsfzh.IsReadOnly = false;
				colvarXtsfzh.DefaultSetting = @"";
				colvarXtsfzh.ForeignKeyTableName = "";
				schema.Columns.Add(colvarXtsfzh);
				
				TableSchema.TableColumn colvarRsgwzl = new TableSchema.TableColumn(schema);
				colvarRsgwzl.ColumnName = "RSGWZL";
				colvarRsgwzl.DataType = DbType.String;
				colvarRsgwzl.MaxLength = 4;
				colvarRsgwzl.AutoIncrement = false;
				colvarRsgwzl.IsNullable = true;
				colvarRsgwzl.IsPrimaryKey = false;
				colvarRsgwzl.IsForeignKey = false;
				colvarRsgwzl.IsReadOnly = false;
				colvarRsgwzl.DefaultSetting = @"";
				colvarRsgwzl.ForeignKeyTableName = "";
				schema.Columns.Add(colvarRsgwzl);
				
				TableSchema.TableColumn colvarXtgzsj = new TableSchema.TableColumn(schema);
				colvarXtgzsj.ColumnName = "XTGZSJ";
				colvarXtgzsj.DataType = DbType.DateTime;
				colvarXtgzsj.MaxLength = 0;
				colvarXtgzsj.AutoIncrement = false;
				colvarXtgzsj.IsNullable = true;
				colvarXtgzsj.IsPrimaryKey = false;
				colvarXtgzsj.IsForeignKey = false;
				colvarXtgzsj.IsReadOnly = false;
				colvarXtgzsj.DefaultSetting = @"";
				colvarXtgzsj.ForeignKeyTableName = "";
				schema.Columns.Add(colvarXtgzsj);
				
				TableSchema.TableColumn colvarXtrcsj = new TableSchema.TableColumn(schema);
				colvarXtrcsj.ColumnName = "XTRCSJ";
				colvarXtrcsj.DataType = DbType.DateTime;
				colvarXtrcsj.MaxLength = 0;
				colvarXtrcsj.AutoIncrement = false;
				colvarXtrcsj.IsNullable = true;
				colvarXtrcsj.IsPrimaryKey = false;
				colvarXtrcsj.IsForeignKey = false;
				colvarXtrcsj.IsReadOnly = false;
				colvarXtrcsj.DefaultSetting = @"";
				colvarXtrcsj.ForeignKeyTableName = "";
				schema.Columns.Add(colvarXtrcsj);
				
				TableSchema.TableColumn colvarGzgzlb = new TableSchema.TableColumn(schema);
				colvarGzgzlb.ColumnName = "GZGZLB";
				colvarGzgzlb.DataType = DbType.String;
				colvarGzgzlb.MaxLength = 4;
				colvarGzgzlb.AutoIncrement = false;
				colvarGzgzlb.IsNullable = true;
				colvarGzgzlb.IsPrimaryKey = false;
				colvarGzgzlb.IsForeignKey = false;
				colvarGzgzlb.IsReadOnly = false;
				colvarGzgzlb.DefaultSetting = @"";
				colvarGzgzlb.ForeignKeyTableName = "";
				schema.Columns.Add(colvarGzgzlb);
				
				TableSchema.TableColumn colvarRsdabh = new TableSchema.TableColumn(schema);
				colvarRsdabh.ColumnName = "RSDABH";
				colvarRsdabh.DataType = DbType.String;
				colvarRsdabh.MaxLength = 20;
				colvarRsdabh.AutoIncrement = false;
				colvarRsdabh.IsNullable = true;
				colvarRsdabh.IsPrimaryKey = false;
				colvarRsdabh.IsForeignKey = false;
				colvarRsdabh.IsReadOnly = false;
				colvarRsdabh.DefaultSetting = @"";
				colvarRsdabh.ForeignKeyTableName = "";
				schema.Columns.Add(colvarRsdabh);
				
				TableSchema.TableColumn colvarRszrsj = new TableSchema.TableColumn(schema);
				colvarRszrsj.ColumnName = "RSZRSJ";
				colvarRszrsj.DataType = DbType.DateTime;
				colvarRszrsj.MaxLength = 0;
				colvarRszrsj.AutoIncrement = false;
				colvarRszrsj.IsNullable = true;
				colvarRszrsj.IsPrimaryKey = false;
				colvarRszrsj.IsForeignKey = false;
				colvarRszrsj.IsReadOnly = false;
				colvarRszrsj.DefaultSetting = @"";
				colvarRszrsj.ForeignKeyTableName = "";
				schema.Columns.Add(colvarRszrsj);
				
				TableSchema.TableColumn colvarRsdalc = new TableSchema.TableColumn(schema);
				colvarRsdalc.ColumnName = "RSDALC";
				colvarRsdalc.DataType = DbType.String;
				colvarRsdalc.MaxLength = 160;
				colvarRsdalc.AutoIncrement = false;
				colvarRsdalc.IsNullable = true;
				colvarRsdalc.IsPrimaryKey = false;
				colvarRsdalc.IsForeignKey = false;
				colvarRsdalc.IsReadOnly = false;
				colvarRsdalc.DefaultSetting = @"";
				colvarRsdalc.ForeignKeyTableName = "";
				schema.Columns.Add(colvarRsdalc);
				
				TableSchema.TableColumn colvarRszcsj = new TableSchema.TableColumn(schema);
				colvarRszcsj.ColumnName = "RSZCSJ";
				colvarRszcsj.DataType = DbType.DateTime;
				colvarRszcsj.MaxLength = 0;
				colvarRszcsj.AutoIncrement = false;
				colvarRszcsj.IsNullable = true;
				colvarRszcsj.IsPrimaryKey = false;
				colvarRszcsj.IsForeignKey = false;
				colvarRszcsj.IsReadOnly = false;
				colvarRszcsj.DefaultSetting = @"";
				colvarRszcsj.ForeignKeyTableName = "";
				schema.Columns.Add(colvarRszcsj);
				
				TableSchema.TableColumn colvarRsdaqc = new TableSchema.TableColumn(schema);
				colvarRsdaqc.ColumnName = "RSDAQC";
				colvarRsdaqc.DataType = DbType.String;
				colvarRsdaqc.MaxLength = 160;
				colvarRsdaqc.AutoIncrement = false;
				colvarRsdaqc.IsNullable = true;
				colvarRsdaqc.IsPrimaryKey = false;
				colvarRsdaqc.IsForeignKey = false;
				colvarRsdaqc.IsReadOnly = false;
				colvarRsdaqc.DefaultSetting = @"";
				colvarRsdaqc.ForeignKeyTableName = "";
				schema.Columns.Add(colvarRsdaqc);
				
				TableSchema.TableColumn colvarRsdabz = new TableSchema.TableColumn(schema);
				colvarRsdabz.ColumnName = "RSDABZ";
				colvarRsdabz.DataType = DbType.String;
				colvarRsdabz.MaxLength = 255;
				colvarRsdabz.AutoIncrement = false;
				colvarRsdabz.IsNullable = true;
				colvarRsdabz.IsPrimaryKey = false;
				colvarRsdabz.IsForeignKey = false;
				colvarRsdabz.IsReadOnly = false;
				colvarRsdabz.DefaultSetting = @"";
				colvarRsdabz.ForeignKeyTableName = "";
				schema.Columns.Add(colvarRsdabz);
				
				TableSchema.TableColumn colvarRszplj = new TableSchema.TableColumn(schema);
				colvarRszplj.ColumnName = "RSZPLJ";
				colvarRszplj.DataType = DbType.String;
				colvarRszplj.MaxLength = 200;
				colvarRszplj.AutoIncrement = false;
				colvarRszplj.IsNullable = true;
				colvarRszplj.IsPrimaryKey = false;
				colvarRszplj.IsForeignKey = false;
				colvarRszplj.IsReadOnly = false;
				colvarRszplj.DefaultSetting = @"";
				colvarRszplj.ForeignKeyTableName = "";
				schema.Columns.Add(colvarRszplj);
				
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
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["ErpNowthwin"].AddSchema("XTM07",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("Bmscsj")]
		[Bindable(true)]
		public DateTime? Bmscsj 
		{
			get { return GetColumnValue<DateTime?>(Columns.Bmscsj); }
			set { SetColumnValue(Columns.Bmscsj, value); }
		}
		  
		[XmlAttribute("Xtzgdm")]
		[Bindable(true)]
		public string Xtzgdm 
		{
			get { return GetColumnValue<string>(Columns.Xtzgdm); }
			set { SetColumnValue(Columns.Xtzgdm, value); }
		}
		  
		[XmlAttribute("Xtzgxm")]
		[Bindable(true)]
		public string Xtzgxm 
		{
			get { return GetColumnValue<string>(Columns.Xtzgxm); }
			set { SetColumnValue(Columns.Xtzgxm, value); }
		}
		  
		[XmlAttribute("Xtbmdm")]
		[Bindable(true)]
		public string Xtbmdm 
		{
			get { return GetColumnValue<string>(Columns.Xtbmdm); }
			set { SetColumnValue(Columns.Xtbmdm, value); }
		}
		  
		[XmlAttribute("Xtzgzz")]
		[Bindable(true)]
		public string Xtzgzz 
		{
			get { return GetColumnValue<string>(Columns.Xtzgzz); }
			set { SetColumnValue(Columns.Xtzgzz, value); }
		}
		  
		[XmlAttribute("Xtzgdz")]
		[Bindable(true)]
		public string Xtzgdz 
		{
			get { return GetColumnValue<string>(Columns.Xtzgdz); }
			set { SetColumnValue(Columns.Xtzgdz, value); }
		}
		  
		[XmlAttribute("Xtyzbm")]
		[Bindable(true)]
		public string Xtyzbm 
		{
			get { return GetColumnValue<string>(Columns.Xtyzbm); }
			set { SetColumnValue(Columns.Xtyzbm, value); }
		}
		  
		[XmlAttribute("Xtdhhm")]
		[Bindable(true)]
		public string Xtdhhm 
		{
			get { return GetColumnValue<string>(Columns.Xtdhhm); }
			set { SetColumnValue(Columns.Xtdhhm, value); }
		}
		  
		[XmlAttribute("Xtczhm")]
		[Bindable(true)]
		public string Xtczhm 
		{
			get { return GetColumnValue<string>(Columns.Xtczhm); }
			set { SetColumnValue(Columns.Xtczhm, value); }
		}
		  
		[XmlAttribute("Xtbpjh")]
		[Bindable(true)]
		public string Xtbpjh 
		{
			get { return GetColumnValue<string>(Columns.Xtbpjh); }
			set { SetColumnValue(Columns.Xtbpjh, value); }
		}
		  
		[XmlAttribute("Xtsjhm")]
		[Bindable(true)]
		public string Xtsjhm 
		{
			get { return GetColumnValue<string>(Columns.Xtsjhm); }
			set { SetColumnValue(Columns.Xtsjhm, value); }
		}
		  
		[XmlAttribute("Xtemdz")]
		[Bindable(true)]
		public string Xtemdz 
		{
			get { return GetColumnValue<string>(Columns.Xtemdz); }
			set { SetColumnValue(Columns.Xtemdz, value); }
		}
		  
		[XmlAttribute("Xtlzbz")]
		[Bindable(true)]
		public string Xtlzbz 
		{
			get { return GetColumnValue<string>(Columns.Xtlzbz); }
			set { SetColumnValue(Columns.Xtlzbz, value); }
		}
		  
		[XmlAttribute("Xtywsm")]
		[Bindable(true)]
		public string Xtywsm 
		{
			get { return GetColumnValue<string>(Columns.Xtywsm); }
			set { SetColumnValue(Columns.Xtywsm, value); }
		}
		  
		[XmlAttribute("Xsndde")]
		[Bindable(true)]
		public decimal? Xsndde 
		{
			get { return GetColumnValue<decimal?>(Columns.Xsndde); }
			set { SetColumnValue(Columns.Xsndde, value); }
		}
		  
		[XmlAttribute("Xtzgxb")]
		[Bindable(true)]
		public string Xtzgxb 
		{
			get { return GetColumnValue<string>(Columns.Xtzgxb); }
			set { SetColumnValue(Columns.Xtzgxb, value); }
		}
		  
		[XmlAttribute("Xtzgmz")]
		[Bindable(true)]
		public string Xtzgmz 
		{
			get { return GetColumnValue<string>(Columns.Xtzgmz); }
			set { SetColumnValue(Columns.Xtzgmz, value); }
		}
		  
		[XmlAttribute("Xtzzmm")]
		[Bindable(true)]
		public string Xtzzmm 
		{
			get { return GetColumnValue<string>(Columns.Xtzzmm); }
			set { SetColumnValue(Columns.Xtzzmm, value); }
		}
		  
		[XmlAttribute("Xthyzk")]
		[Bindable(true)]
		public string Xthyzk 
		{
			get { return GetColumnValue<string>(Columns.Xthyzk); }
			set { SetColumnValue(Columns.Xthyzk, value); }
		}
		  
		[XmlAttribute("Xtcsdq")]
		[Bindable(true)]
		public string Xtcsdq 
		{
			get { return GetColumnValue<string>(Columns.Xtcsdq); }
			set { SetColumnValue(Columns.Xtcsdq, value); }
		}
		  
		[XmlAttribute("Xtcsny")]
		[Bindable(true)]
		public DateTime? Xtcsny 
		{
			get { return GetColumnValue<DateTime?>(Columns.Xtcsny); }
			set { SetColumnValue(Columns.Xtcsny, value); }
		}
		  
		[XmlAttribute("Xtsfzh")]
		[Bindable(true)]
		public string Xtsfzh 
		{
			get { return GetColumnValue<string>(Columns.Xtsfzh); }
			set { SetColumnValue(Columns.Xtsfzh, value); }
		}
		  
		[XmlAttribute("Rsgwzl")]
		[Bindable(true)]
		public string Rsgwzl 
		{
			get { return GetColumnValue<string>(Columns.Rsgwzl); }
			set { SetColumnValue(Columns.Rsgwzl, value); }
		}
		  
		[XmlAttribute("Xtgzsj")]
		[Bindable(true)]
		public DateTime? Xtgzsj 
		{
			get { return GetColumnValue<DateTime?>(Columns.Xtgzsj); }
			set { SetColumnValue(Columns.Xtgzsj, value); }
		}
		  
		[XmlAttribute("Xtrcsj")]
		[Bindable(true)]
		public DateTime? Xtrcsj 
		{
			get { return GetColumnValue<DateTime?>(Columns.Xtrcsj); }
			set { SetColumnValue(Columns.Xtrcsj, value); }
		}
		  
		[XmlAttribute("Gzgzlb")]
		[Bindable(true)]
		public string Gzgzlb 
		{
			get { return GetColumnValue<string>(Columns.Gzgzlb); }
			set { SetColumnValue(Columns.Gzgzlb, value); }
		}
		  
		[XmlAttribute("Rsdabh")]
		[Bindable(true)]
		public string Rsdabh 
		{
			get { return GetColumnValue<string>(Columns.Rsdabh); }
			set { SetColumnValue(Columns.Rsdabh, value); }
		}
		  
		[XmlAttribute("Rszrsj")]
		[Bindable(true)]
		public DateTime? Rszrsj 
		{
			get { return GetColumnValue<DateTime?>(Columns.Rszrsj); }
			set { SetColumnValue(Columns.Rszrsj, value); }
		}
		  
		[XmlAttribute("Rsdalc")]
		[Bindable(true)]
		public string Rsdalc 
		{
			get { return GetColumnValue<string>(Columns.Rsdalc); }
			set { SetColumnValue(Columns.Rsdalc, value); }
		}
		  
		[XmlAttribute("Rszcsj")]
		[Bindable(true)]
		public DateTime? Rszcsj 
		{
			get { return GetColumnValue<DateTime?>(Columns.Rszcsj); }
			set { SetColumnValue(Columns.Rszcsj, value); }
		}
		  
		[XmlAttribute("Rsdaqc")]
		[Bindable(true)]
		public string Rsdaqc 
		{
			get { return GetColumnValue<string>(Columns.Rsdaqc); }
			set { SetColumnValue(Columns.Rsdaqc, value); }
		}
		  
		[XmlAttribute("Rsdabz")]
		[Bindable(true)]
		public string Rsdabz 
		{
			get { return GetColumnValue<string>(Columns.Rsdabz); }
			set { SetColumnValue(Columns.Rsdabz, value); }
		}
		  
		[XmlAttribute("Rszplj")]
		[Bindable(true)]
		public string Rszplj 
		{
			get { return GetColumnValue<string>(Columns.Rszplj); }
			set { SetColumnValue(Columns.Rszplj, value); }
		}
		  
		[XmlAttribute("Xtwldm")]
		[Bindable(true)]
		public string Xtwldm 
		{
			get { return GetColumnValue<string>(Columns.Xtwldm); }
			set { SetColumnValue(Columns.Xtwldm, value); }
		}
		
		#endregion
		
		
			
		
		//no foreign key tables defined (0)
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(DateTime? varBmscsj,string varXtzgdm,string varXtzgxm,string varXtbmdm,string varXtzgzz,string varXtzgdz,string varXtyzbm,string varXtdhhm,string varXtczhm,string varXtbpjh,string varXtsjhm,string varXtemdz,string varXtlzbz,string varXtywsm,decimal? varXsndde,string varXtzgxb,string varXtzgmz,string varXtzzmm,string varXthyzk,string varXtcsdq,DateTime? varXtcsny,string varXtsfzh,string varRsgwzl,DateTime? varXtgzsj,DateTime? varXtrcsj,string varGzgzlb,string varRsdabh,DateTime? varRszrsj,string varRsdalc,DateTime? varRszcsj,string varRsdaqc,string varRsdabz,string varRszplj,string varXtwldm)
		{
			XTM07 item = new XTM07();
			
			item.Bmscsj = varBmscsj;
			
			item.Xtzgdm = varXtzgdm;
			
			item.Xtzgxm = varXtzgxm;
			
			item.Xtbmdm = varXtbmdm;
			
			item.Xtzgzz = varXtzgzz;
			
			item.Xtzgdz = varXtzgdz;
			
			item.Xtyzbm = varXtyzbm;
			
			item.Xtdhhm = varXtdhhm;
			
			item.Xtczhm = varXtczhm;
			
			item.Xtbpjh = varXtbpjh;
			
			item.Xtsjhm = varXtsjhm;
			
			item.Xtemdz = varXtemdz;
			
			item.Xtlzbz = varXtlzbz;
			
			item.Xtywsm = varXtywsm;
			
			item.Xsndde = varXsndde;
			
			item.Xtzgxb = varXtzgxb;
			
			item.Xtzgmz = varXtzgmz;
			
			item.Xtzzmm = varXtzzmm;
			
			item.Xthyzk = varXthyzk;
			
			item.Xtcsdq = varXtcsdq;
			
			item.Xtcsny = varXtcsny;
			
			item.Xtsfzh = varXtsfzh;
			
			item.Rsgwzl = varRsgwzl;
			
			item.Xtgzsj = varXtgzsj;
			
			item.Xtrcsj = varXtrcsj;
			
			item.Gzgzlb = varGzgzlb;
			
			item.Rsdabh = varRsdabh;
			
			item.Rszrsj = varRszrsj;
			
			item.Rsdalc = varRsdalc;
			
			item.Rszcsj = varRszcsj;
			
			item.Rsdaqc = varRsdaqc;
			
			item.Rsdabz = varRsdabz;
			
			item.Rszplj = varRszplj;
			
			item.Xtwldm = varXtwldm;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(DateTime? varBmscsj,string varXtzgdm,string varXtzgxm,string varXtbmdm,string varXtzgzz,string varXtzgdz,string varXtyzbm,string varXtdhhm,string varXtczhm,string varXtbpjh,string varXtsjhm,string varXtemdz,string varXtlzbz,string varXtywsm,decimal? varXsndde,string varXtzgxb,string varXtzgmz,string varXtzzmm,string varXthyzk,string varXtcsdq,DateTime? varXtcsny,string varXtsfzh,string varRsgwzl,DateTime? varXtgzsj,DateTime? varXtrcsj,string varGzgzlb,string varRsdabh,DateTime? varRszrsj,string varRsdalc,DateTime? varRszcsj,string varRsdaqc,string varRsdabz,string varRszplj,string varXtwldm)
		{
			XTM07 item = new XTM07();
			
				item.Bmscsj = varBmscsj;
			
				item.Xtzgdm = varXtzgdm;
			
				item.Xtzgxm = varXtzgxm;
			
				item.Xtbmdm = varXtbmdm;
			
				item.Xtzgzz = varXtzgzz;
			
				item.Xtzgdz = varXtzgdz;
			
				item.Xtyzbm = varXtyzbm;
			
				item.Xtdhhm = varXtdhhm;
			
				item.Xtczhm = varXtczhm;
			
				item.Xtbpjh = varXtbpjh;
			
				item.Xtsjhm = varXtsjhm;
			
				item.Xtemdz = varXtemdz;
			
				item.Xtlzbz = varXtlzbz;
			
				item.Xtywsm = varXtywsm;
			
				item.Xsndde = varXsndde;
			
				item.Xtzgxb = varXtzgxb;
			
				item.Xtzgmz = varXtzgmz;
			
				item.Xtzzmm = varXtzzmm;
			
				item.Xthyzk = varXthyzk;
			
				item.Xtcsdq = varXtcsdq;
			
				item.Xtcsny = varXtcsny;
			
				item.Xtsfzh = varXtsfzh;
			
				item.Rsgwzl = varRsgwzl;
			
				item.Xtgzsj = varXtgzsj;
			
				item.Xtrcsj = varXtrcsj;
			
				item.Gzgzlb = varGzgzlb;
			
				item.Rsdabh = varRsdabh;
			
				item.Rszrsj = varRszrsj;
			
				item.Rsdalc = varRsdalc;
			
				item.Rszcsj = varRszcsj;
			
				item.Rsdaqc = varRsdaqc;
			
				item.Rsdabz = varRsdabz;
			
				item.Rszplj = varRszplj;
			
				item.Xtwldm = varXtwldm;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn BmscsjColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn XtzgdmColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        public static TableSchema.TableColumn XtzgxmColumn
        {
            get { return Schema.Columns[2]; }
        }
        
        
        
        public static TableSchema.TableColumn XtbmdmColumn
        {
            get { return Schema.Columns[3]; }
        }
        
        
        
        public static TableSchema.TableColumn XtzgzzColumn
        {
            get { return Schema.Columns[4]; }
        }
        
        
        
        public static TableSchema.TableColumn XtzgdzColumn
        {
            get { return Schema.Columns[5]; }
        }
        
        
        
        public static TableSchema.TableColumn XtyzbmColumn
        {
            get { return Schema.Columns[6]; }
        }
        
        
        
        public static TableSchema.TableColumn XtdhhmColumn
        {
            get { return Schema.Columns[7]; }
        }
        
        
        
        public static TableSchema.TableColumn XtczhmColumn
        {
            get { return Schema.Columns[8]; }
        }
        
        
        
        public static TableSchema.TableColumn XtbpjhColumn
        {
            get { return Schema.Columns[9]; }
        }
        
        
        
        public static TableSchema.TableColumn XtsjhmColumn
        {
            get { return Schema.Columns[10]; }
        }
        
        
        
        public static TableSchema.TableColumn XtemdzColumn
        {
            get { return Schema.Columns[11]; }
        }
        
        
        
        public static TableSchema.TableColumn XtlzbzColumn
        {
            get { return Schema.Columns[12]; }
        }
        
        
        
        public static TableSchema.TableColumn XtywsmColumn
        {
            get { return Schema.Columns[13]; }
        }
        
        
        
        public static TableSchema.TableColumn XsnddeColumn
        {
            get { return Schema.Columns[14]; }
        }
        
        
        
        public static TableSchema.TableColumn XtzgxbColumn
        {
            get { return Schema.Columns[15]; }
        }
        
        
        
        public static TableSchema.TableColumn XtzgmzColumn
        {
            get { return Schema.Columns[16]; }
        }
        
        
        
        public static TableSchema.TableColumn XtzzmmColumn
        {
            get { return Schema.Columns[17]; }
        }
        
        
        
        public static TableSchema.TableColumn XthyzkColumn
        {
            get { return Schema.Columns[18]; }
        }
        
        
        
        public static TableSchema.TableColumn XtcsdqColumn
        {
            get { return Schema.Columns[19]; }
        }
        
        
        
        public static TableSchema.TableColumn XtcsnyColumn
        {
            get { return Schema.Columns[20]; }
        }
        
        
        
        public static TableSchema.TableColumn XtsfzhColumn
        {
            get { return Schema.Columns[21]; }
        }
        
        
        
        public static TableSchema.TableColumn RsgwzlColumn
        {
            get { return Schema.Columns[22]; }
        }
        
        
        
        public static TableSchema.TableColumn XtgzsjColumn
        {
            get { return Schema.Columns[23]; }
        }
        
        
        
        public static TableSchema.TableColumn XtrcsjColumn
        {
            get { return Schema.Columns[24]; }
        }
        
        
        
        public static TableSchema.TableColumn GzgzlbColumn
        {
            get { return Schema.Columns[25]; }
        }
        
        
        
        public static TableSchema.TableColumn RsdabhColumn
        {
            get { return Schema.Columns[26]; }
        }
        
        
        
        public static TableSchema.TableColumn RszrsjColumn
        {
            get { return Schema.Columns[27]; }
        }
        
        
        
        public static TableSchema.TableColumn RsdalcColumn
        {
            get { return Schema.Columns[28]; }
        }
        
        
        
        public static TableSchema.TableColumn RszcsjColumn
        {
            get { return Schema.Columns[29]; }
        }
        
        
        
        public static TableSchema.TableColumn RsdaqcColumn
        {
            get { return Schema.Columns[30]; }
        }
        
        
        
        public static TableSchema.TableColumn RsdabzColumn
        {
            get { return Schema.Columns[31]; }
        }
        
        
        
        public static TableSchema.TableColumn RszpljColumn
        {
            get { return Schema.Columns[32]; }
        }
        
        
        
        public static TableSchema.TableColumn XtwldmColumn
        {
            get { return Schema.Columns[33]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string Bmscsj = @"BMSCSJ";
			 public static string Xtzgdm = @"XTZGDM";
			 public static string Xtzgxm = @"XTZGXM";
			 public static string Xtbmdm = @"XTBMDM";
			 public static string Xtzgzz = @"XTZGZZ";
			 public static string Xtzgdz = @"XTZGDZ";
			 public static string Xtyzbm = @"XTYZBM";
			 public static string Xtdhhm = @"XTDHHM";
			 public static string Xtczhm = @"XTCZHM";
			 public static string Xtbpjh = @"XTBPJH";
			 public static string Xtsjhm = @"XTSJHM";
			 public static string Xtemdz = @"XTEMDZ";
			 public static string Xtlzbz = @"XTLZBZ";
			 public static string Xtywsm = @"XTYWSM";
			 public static string Xsndde = @"XSNDDE";
			 public static string Xtzgxb = @"XTZGXB";
			 public static string Xtzgmz = @"XTZGMZ";
			 public static string Xtzzmm = @"XTZZMM";
			 public static string Xthyzk = @"XTHYZK";
			 public static string Xtcsdq = @"XTCSDQ";
			 public static string Xtcsny = @"XTCSNY";
			 public static string Xtsfzh = @"XTSFZH";
			 public static string Rsgwzl = @"RSGWZL";
			 public static string Xtgzsj = @"XTGZSJ";
			 public static string Xtrcsj = @"XTRCSJ";
			 public static string Gzgzlb = @"GZGZLB";
			 public static string Rsdabh = @"RSDABH";
			 public static string Rszrsj = @"RSZRSJ";
			 public static string Rsdalc = @"RSDALC";
			 public static string Rszcsj = @"RSZCSJ";
			 public static string Rsdaqc = @"RSDAQC";
			 public static string Rsdabz = @"RSDABZ";
			 public static string Rszplj = @"RSZPLJ";
			 public static string Xtwldm = @"XTWLDM";
						
		}
		#endregion
		
		#region Update PK Collections
		
        #endregion
    
        #region Deep Save
		
        #endregion
	}
}
