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
namespace OracleDataDomain{
    /// <summary>
    /// Strongly-typed collection for the VYsjhDh class.
    /// </summary>
    [Serializable]
    public partial class VYsjhDhCollection : ReadOnlyList<VYsjhDh, VYsjhDhCollection>
    {        
        public VYsjhDhCollection() {}
    }
    /// <summary>
    /// This is  Read-only wrapper class for the V_YSJH_DH view.
    /// </summary>
    [Serializable]
    public partial class VYsjhDh : ReadOnlyRecord<VYsjhDh>, IReadOnlyRecord
    {
    
	    #region Default Settings
	    protected static void SetSQLProps() 
	    {
		    GetTableSchema();
	    }
	    #endregion
        #region Schema Accessor
	    public static TableSchema.Table Schema
        {
            get
            {
                if (BaseSchema == null)
                {
                    SetSQLProps();
                }
                return BaseSchema;
            }
        }
    	
        private static void GetTableSchema() 
        {
            if(!IsSchemaInitialized)
            {
                //Schema declaration
                TableSchema.Table schema = new TableSchema.Table("V_YSJH_DH", TableType.View, DataService.GetInstance("ErpNowthwin"));
                schema.Columns = new TableSchema.TableColumnCollection();
                schema.SchemaName = @"FYERP";
                //columns
                
                TableSchema.TableColumn colvar来源系统订单ID = new TableSchema.TableColumn(schema);
                colvar来源系统订单ID.ColumnName = "来源系统订单ID";
                colvar来源系统订单ID.DataType = DbType.String;
                colvar来源系统订单ID.MaxLength = 62;
                colvar来源系统订单ID.AutoIncrement = false;
                colvar来源系统订单ID.IsNullable = true;
                colvar来源系统订单ID.IsPrimaryKey = false;
                colvar来源系统订单ID.IsForeignKey = false;
                colvar来源系统订单ID.IsReadOnly = false;
                
                schema.Columns.Add(colvar来源系统订单ID);
                
                TableSchema.TableColumn colvar来源系统标识 = new TableSchema.TableColumn(schema);
                colvar来源系统标识.ColumnName = "来源系统标识";
                colvar来源系统标识.DataType = DbType.String;
                colvar来源系统标识.MaxLength = 4;
                colvar来源系统标识.AutoIncrement = false;
                colvar来源系统标识.IsNullable = true;
                colvar来源系统标识.IsPrimaryKey = false;
                colvar来源系统标识.IsForeignKey = false;
                colvar来源系统标识.IsReadOnly = false;
                
                schema.Columns.Add(colvar来源系统标识);
                
                TableSchema.TableColumn colvar销售订单号 = new TableSchema.TableColumn(schema);
                colvar销售订单号.ColumnName = "销售订单号";
                colvar销售订单号.DataType = DbType.String;
                colvar销售订单号.MaxLength = 12;
                colvar销售订单号.AutoIncrement = false;
                colvar销售订单号.IsNullable = false;
                colvar销售订单号.IsPrimaryKey = false;
                colvar销售订单号.IsForeignKey = false;
                colvar销售订单号.IsReadOnly = false;
                
                schema.Columns.Add(colvar销售订单号);
                
                TableSchema.TableColumn colvar计划单号 = new TableSchema.TableColumn(schema);
                colvar计划单号.ColumnName = "计划单号";
                colvar计划单号.DataType = DbType.String;
                colvar计划单号.MaxLength = 12;
                colvar计划单号.AutoIncrement = false;
                colvar计划单号.IsNullable = false;
                colvar计划单号.IsPrimaryKey = false;
                colvar计划单号.IsForeignKey = false;
                colvar计划单号.IsReadOnly = false;
                
                schema.Columns.Add(colvar计划单号);
                
                TableSchema.TableColumn colvar产品类型 = new TableSchema.TableColumn(schema);
                colvar产品类型.ColumnName = "产品类型";
                colvar产品类型.DataType = DbType.String;
                colvar产品类型.MaxLength = 20;
                colvar产品类型.AutoIncrement = false;
                colvar产品类型.IsNullable = false;
                colvar产品类型.IsPrimaryKey = false;
                colvar产品类型.IsForeignKey = false;
                colvar产品类型.IsReadOnly = false;
                
                schema.Columns.Add(colvar产品类型);
                
                TableSchema.TableColumn colvar下单时间 = new TableSchema.TableColumn(schema);
                colvar下单时间.ColumnName = "下单时间";
                colvar下单时间.DataType = DbType.DateTime;
                colvar下单时间.MaxLength = 0;
                colvar下单时间.AutoIncrement = false;
                colvar下单时间.IsNullable = true;
                colvar下单时间.IsPrimaryKey = false;
                colvar下单时间.IsForeignKey = false;
                colvar下单时间.IsReadOnly = false;
                
                schema.Columns.Add(colvar下单时间);
                
                TableSchema.TableColumn colvar计划下达日期 = new TableSchema.TableColumn(schema);
                colvar计划下达日期.ColumnName = "计划下达日期";
                colvar计划下达日期.DataType = DbType.DateTime;
                colvar计划下达日期.MaxLength = 0;
                colvar计划下达日期.AutoIncrement = false;
                colvar计划下达日期.IsNullable = true;
                colvar计划下达日期.IsPrimaryKey = false;
                colvar计划下达日期.IsForeignKey = false;
                colvar计划下达日期.IsReadOnly = false;
                
                schema.Columns.Add(colvar计划下达日期);
                
                TableSchema.TableColumn colvar裁剪交期 = new TableSchema.TableColumn(schema);
                colvar裁剪交期.ColumnName = "裁剪交期";
                colvar裁剪交期.DataType = DbType.DateTime;
                colvar裁剪交期.MaxLength = 0;
                colvar裁剪交期.AutoIncrement = false;
                colvar裁剪交期.IsNullable = true;
                colvar裁剪交期.IsPrimaryKey = false;
                colvar裁剪交期.IsForeignKey = false;
                colvar裁剪交期.IsReadOnly = false;
                
                schema.Columns.Add(colvar裁剪交期);
                
                TableSchema.TableColumn colvar缝制交期 = new TableSchema.TableColumn(schema);
                colvar缝制交期.ColumnName = "缝制交期";
                colvar缝制交期.DataType = DbType.DateTime;
                colvar缝制交期.MaxLength = 0;
                colvar缝制交期.AutoIncrement = false;
                colvar缝制交期.IsNullable = true;
                colvar缝制交期.IsPrimaryKey = false;
                colvar缝制交期.IsForeignKey = false;
                colvar缝制交期.IsReadOnly = false;
                
                schema.Columns.Add(colvar缝制交期);
                
                TableSchema.TableColumn colvar整烫交期 = new TableSchema.TableColumn(schema);
                colvar整烫交期.ColumnName = "整烫交期";
                colvar整烫交期.DataType = DbType.DateTime;
                colvar整烫交期.MaxLength = 0;
                colvar整烫交期.AutoIncrement = false;
                colvar整烫交期.IsNullable = true;
                colvar整烫交期.IsPrimaryKey = false;
                colvar整烫交期.IsForeignKey = false;
                colvar整烫交期.IsReadOnly = false;
                
                schema.Columns.Add(colvar整烫交期);
                
                TableSchema.TableColumn colvar包装交期 = new TableSchema.TableColumn(schema);
                colvar包装交期.ColumnName = "包装交期";
                colvar包装交期.DataType = DbType.DateTime;
                colvar包装交期.MaxLength = 0;
                colvar包装交期.AutoIncrement = false;
                colvar包装交期.IsNullable = true;
                colvar包装交期.IsPrimaryKey = false;
                colvar包装交期.IsForeignKey = false;
                colvar包装交期.IsReadOnly = false;
                
                schema.Columns.Add(colvar包装交期);
                
                TableSchema.TableColumn colvar交货日期 = new TableSchema.TableColumn(schema);
                colvar交货日期.ColumnName = "交货日期";
                colvar交货日期.DataType = DbType.DateTime;
                colvar交货日期.MaxLength = 0;
                colvar交货日期.AutoIncrement = false;
                colvar交货日期.IsNullable = true;
                colvar交货日期.IsPrimaryKey = false;
                colvar交货日期.IsForeignKey = false;
                colvar交货日期.IsReadOnly = false;
                
                schema.Columns.Add(colvar交货日期);
                
                TableSchema.TableColumn colvar面料 = new TableSchema.TableColumn(schema);
                colvar面料.ColumnName = "面料";
                colvar面料.DataType = DbType.String;
                colvar面料.MaxLength = 20;
                colvar面料.AutoIncrement = false;
                colvar面料.IsNullable = false;
                colvar面料.IsPrimaryKey = false;
                colvar面料.IsForeignKey = false;
                colvar面料.IsReadOnly = false;
                
                schema.Columns.Add(colvar面料);
                
                TableSchema.TableColumn colvar规格单号 = new TableSchema.TableColumn(schema);
                colvar规格单号.ColumnName = "规格单号";
                colvar规格单号.DataType = DbType.String;
                colvar规格单号.MaxLength = 12;
                colvar规格单号.AutoIncrement = false;
                colvar规格单号.IsNullable = false;
                colvar规格单号.IsPrimaryKey = false;
                colvar规格单号.IsForeignKey = false;
                colvar规格单号.IsReadOnly = false;
                
                schema.Columns.Add(colvar规格单号);
                
                TableSchema.TableColumn colvar状态 = new TableSchema.TableColumn(schema);
                colvar状态.ColumnName = "状态";
                colvar状态.DataType = DbType.String;
                colvar状态.MaxLength = 4;
                colvar状态.AutoIncrement = false;
                colvar状态.IsNullable = true;
                colvar状态.IsPrimaryKey = false;
                colvar状态.IsForeignKey = false;
                colvar状态.IsReadOnly = false;
                
                schema.Columns.Add(colvar状态);
                
                TableSchema.TableColumn colvar计划编号 = new TableSchema.TableColumn(schema);
                colvar计划编号.ColumnName = "计划编号";
                colvar计划编号.DataType = DbType.String;
                colvar计划编号.MaxLength = 12;
                colvar计划编号.AutoIncrement = false;
                colvar计划编号.IsNullable = false;
                colvar计划编号.IsPrimaryKey = false;
                colvar计划编号.IsForeignKey = false;
                colvar计划编号.IsReadOnly = false;
                
                schema.Columns.Add(colvar计划编号);
                
                TableSchema.TableColumn colvar订单序号 = new TableSchema.TableColumn(schema);
                colvar订单序号.ColumnName = "订单序号";
                colvar订单序号.DataType = DbType.Decimal;
                colvar订单序号.MaxLength = 0;
                colvar订单序号.AutoIncrement = false;
                colvar订单序号.IsNullable = false;
                colvar订单序号.IsPrimaryKey = false;
                colvar订单序号.IsForeignKey = false;
                colvar订单序号.IsReadOnly = false;
                
                schema.Columns.Add(colvar订单序号);
                
                TableSchema.TableColumn colvar规格单序号 = new TableSchema.TableColumn(schema);
                colvar规格单序号.ColumnName = "规格单序号";
                colvar规格单序号.DataType = DbType.String;
                colvar规格单序号.MaxLength = 12;
                colvar规格单序号.AutoIncrement = false;
                colvar规格单序号.IsNullable = false;
                colvar规格单序号.IsPrimaryKey = false;
                colvar规格单序号.IsForeignKey = false;
                colvar规格单序号.IsReadOnly = false;
                
                schema.Columns.Add(colvar规格单序号);
                
                
                BaseSchema = schema;
                //add this schema to the provider
                //so we can query it later
                DataService.Providers["ErpNowthwin"].AddSchema("V_YSJH_DH",schema);
            }
        }
        #endregion
        
        #region Query Accessor
	    public static Query CreateQuery()
	    {
		    return new Query(Schema);
	    }
	    #endregion
	    
	    #region .ctors
	    public VYsjhDh()
	    {
            SetSQLProps();
            SetDefaults();
            MarkNew();
        }
        public VYsjhDh(bool useDatabaseDefaults)
	    {
		    SetSQLProps();
		    if(useDatabaseDefaults)
		    {
				ForceDefaults();
			}
			MarkNew();
	    }
	    
	    public VYsjhDh(object keyID)
	    {
		    SetSQLProps();
		    LoadByKey(keyID);
	    }
    	 
	    public VYsjhDh(string columnName, object columnValue)
        {
            SetSQLProps();
            LoadByParam(columnName,columnValue);
        }
        
	    #endregion
	    
	    #region Props
	    
          
        [XmlAttribute("来源系统订单ID")]
        [Bindable(true)]
        public string 来源系统订单ID 
	    {
		    get
		    {
			    return GetColumnValue<string>("来源系统订单ID");
		    }
            set 
		    {
			    SetColumnValue("来源系统订单ID", value);
            }
        }
	      
        [XmlAttribute("来源系统标识")]
        [Bindable(true)]
        public string 来源系统标识 
	    {
		    get
		    {
			    return GetColumnValue<string>("来源系统标识");
		    }
            set 
		    {
			    SetColumnValue("来源系统标识", value);
            }
        }
	      
        [XmlAttribute("销售订单号")]
        [Bindable(true)]
        public string 销售订单号 
	    {
		    get
		    {
			    return GetColumnValue<string>("销售订单号");
		    }
            set 
		    {
			    SetColumnValue("销售订单号", value);
            }
        }
	      
        [XmlAttribute("计划单号")]
        [Bindable(true)]
        public string 计划单号 
	    {
		    get
		    {
			    return GetColumnValue<string>("计划单号");
		    }
            set 
		    {
			    SetColumnValue("计划单号", value);
            }
        }
	      
        [XmlAttribute("产品类型")]
        [Bindable(true)]
        public string 产品类型 
	    {
		    get
		    {
			    return GetColumnValue<string>("产品类型");
		    }
            set 
		    {
			    SetColumnValue("产品类型", value);
            }
        }
	      
        [XmlAttribute("下单时间")]
        [Bindable(true)]
        public DateTime? 下单时间 
	    {
		    get
		    {
			    return GetColumnValue<DateTime?>("下单时间");
		    }
            set 
		    {
			    SetColumnValue("下单时间", value);
            }
        }
	      
        [XmlAttribute("计划下达日期")]
        [Bindable(true)]
        public DateTime? 计划下达日期 
	    {
		    get
		    {
			    return GetColumnValue<DateTime?>("计划下达日期");
		    }
            set 
		    {
			    SetColumnValue("计划下达日期", value);
            }
        }
	      
        [XmlAttribute("裁剪交期")]
        [Bindable(true)]
        public DateTime? 裁剪交期 
	    {
		    get
		    {
			    return GetColumnValue<DateTime?>("裁剪交期");
		    }
            set 
		    {
			    SetColumnValue("裁剪交期", value);
            }
        }
	      
        [XmlAttribute("缝制交期")]
        [Bindable(true)]
        public DateTime? 缝制交期 
	    {
		    get
		    {
			    return GetColumnValue<DateTime?>("缝制交期");
		    }
            set 
		    {
			    SetColumnValue("缝制交期", value);
            }
        }
	      
        [XmlAttribute("整烫交期")]
        [Bindable(true)]
        public DateTime? 整烫交期 
	    {
		    get
		    {
			    return GetColumnValue<DateTime?>("整烫交期");
		    }
            set 
		    {
			    SetColumnValue("整烫交期", value);
            }
        }
	      
        [XmlAttribute("包装交期")]
        [Bindable(true)]
        public DateTime? 包装交期 
	    {
		    get
		    {
			    return GetColumnValue<DateTime?>("包装交期");
		    }
            set 
		    {
			    SetColumnValue("包装交期", value);
            }
        }
	      
        [XmlAttribute("交货日期")]
        [Bindable(true)]
        public DateTime? 交货日期 
	    {
		    get
		    {
			    return GetColumnValue<DateTime?>("交货日期");
		    }
            set 
		    {
			    SetColumnValue("交货日期", value);
            }
        }
	      
        [XmlAttribute("面料")]
        [Bindable(true)]
        public string 面料 
	    {
		    get
		    {
			    return GetColumnValue<string>("面料");
		    }
            set 
		    {
			    SetColumnValue("面料", value);
            }
        }
	      
        [XmlAttribute("规格单号")]
        [Bindable(true)]
        public string 规格单号 
	    {
		    get
		    {
			    return GetColumnValue<string>("规格单号");
		    }
            set 
		    {
			    SetColumnValue("规格单号", value);
            }
        }
	      
        [XmlAttribute("状态")]
        [Bindable(true)]
        public string 状态 
	    {
		    get
		    {
			    return GetColumnValue<string>("状态");
		    }
            set 
		    {
			    SetColumnValue("状态", value);
            }
        }
	      
        [XmlAttribute("计划编号")]
        [Bindable(true)]
        public string 计划编号 
	    {
		    get
		    {
			    return GetColumnValue<string>("计划编号");
		    }
            set 
		    {
			    SetColumnValue("计划编号", value);
            }
        }
	      
        [XmlAttribute("订单序号")]
        [Bindable(true)]
        public decimal 订单序号 
	    {
		    get
		    {
			    return GetColumnValue<decimal>("订单序号");
		    }
            set 
		    {
			    SetColumnValue("订单序号", value);
            }
        }
	      
        [XmlAttribute("规格单序号")]
        [Bindable(true)]
        public string 规格单序号 
	    {
		    get
		    {
			    return GetColumnValue<string>("规格单序号");
		    }
            set 
		    {
			    SetColumnValue("规格单序号", value);
            }
        }
	    
	    #endregion
    
	    #region Columns Struct
	    public struct Columns
	    {
		    
		    
            public static string 来源系统订单ID = @"来源系统订单ID";
            
            public static string 来源系统标识 = @"来源系统标识";
            
            public static string 销售订单号 = @"销售订单号";
            
            public static string 计划单号 = @"计划单号";
            
            public static string 产品类型 = @"产品类型";
            
            public static string 下单时间 = @"下单时间";
            
            public static string 计划下达日期 = @"计划下达日期";
            
            public static string 裁剪交期 = @"裁剪交期";
            
            public static string 缝制交期 = @"缝制交期";
            
            public static string 整烫交期 = @"整烫交期";
            
            public static string 包装交期 = @"包装交期";
            
            public static string 交货日期 = @"交货日期";
            
            public static string 面料 = @"面料";
            
            public static string 规格单号 = @"规格单号";
            
            public static string 状态 = @"状态";
            
            public static string 计划编号 = @"计划编号";
            
            public static string 订单序号 = @"订单序号";
            
            public static string 规格单序号 = @"规格单序号";
            
	    }
	    #endregion
	    
	    
	    #region IAbstractRecord Members
        public new CT GetColumnValue<CT>(string columnName) {
            return base.GetColumnValue<CT>(columnName);
        }
        public object GetColumnValue(string columnName) {
            return base.GetColumnValue<object>(columnName);
        }
        #endregion
	    
    }
}
