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
    /// Strongly-typed collection for the VYstz class.
    /// </summary>
    [Serializable]
    public partial class VYstzCollection : ReadOnlyList<VYstz, VYstzCollection>
    {        
        public VYstzCollection() {}
    }
    /// <summary>
    /// This is  Read-only wrapper class for the V_YSTZ view.
    /// </summary>
    [Serializable]
    public partial class VYstz : ReadOnlyRecord<VYstz>, IReadOnlyRecord
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
                TableSchema.Table schema = new TableSchema.Table("V_YSTZ", TableType.View, DataService.GetInstance("ErpNowthwin"));
                schema.Columns = new TableSchema.TableColumnCollection();
                schema.SchemaName = @"FYERP";
                //columns
                
                TableSchema.TableColumn colvar单体单号 = new TableSchema.TableColumn(schema);
                colvar单体单号.ColumnName = "单体单号";
                colvar单体单号.DataType = DbType.String;
                colvar单体单号.MaxLength = 12;
                colvar单体单号.AutoIncrement = false;
                colvar单体单号.IsNullable = false;
                colvar单体单号.IsPrimaryKey = false;
                colvar单体单号.IsForeignKey = false;
                colvar单体单号.IsReadOnly = false;
                
                schema.Columns.Add(colvar单体单号);
                
                TableSchema.TableColumn colvar销售订单号 = new TableSchema.TableColumn(schema);
                colvar销售订单号.ColumnName = "销售订单号";
                colvar销售订单号.DataType = DbType.String;
                colvar销售订单号.MaxLength = 12;
                colvar销售订单号.AutoIncrement = false;
                colvar销售订单号.IsNullable = true;
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
                
                TableSchema.TableColumn colvar下单日期 = new TableSchema.TableColumn(schema);
                colvar下单日期.ColumnName = "下单日期";
                colvar下单日期.DataType = DbType.DateTime;
                colvar下单日期.MaxLength = 0;
                colvar下单日期.AutoIncrement = false;
                colvar下单日期.IsNullable = true;
                colvar下单日期.IsPrimaryKey = false;
                colvar下单日期.IsForeignKey = false;
                colvar下单日期.IsReadOnly = false;
                
                schema.Columns.Add(colvar下单日期);
                
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
                
                TableSchema.TableColumn colvar订单总额 = new TableSchema.TableColumn(schema);
                colvar订单总额.ColumnName = "订单总额";
                colvar订单总额.DataType = DbType.String;
                colvar订单总额.MaxLength = 0;
                colvar订单总额.AutoIncrement = false;
                colvar订单总额.IsNullable = true;
                colvar订单总额.IsPrimaryKey = false;
                colvar订单总额.IsForeignKey = false;
                colvar订单总额.IsReadOnly = false;
                
                schema.Columns.Add(colvar订单总额);
                
                TableSchema.TableColumn colvar来源系统客户ID = new TableSchema.TableColumn(schema);
                colvar来源系统客户ID.ColumnName = "来源系统客户ID";
                colvar来源系统客户ID.DataType = DbType.String;
                colvar来源系统客户ID.MaxLength = 8;
                colvar来源系统客户ID.AutoIncrement = false;
                colvar来源系统客户ID.IsNullable = true;
                colvar来源系统客户ID.IsPrimaryKey = false;
                colvar来源系统客户ID.IsForeignKey = false;
                colvar来源系统客户ID.IsReadOnly = false;
                
                schema.Columns.Add(colvar来源系统客户ID);
                
                TableSchema.TableColumn colvar订单行ID = new TableSchema.TableColumn(schema);
                colvar订单行ID.ColumnName = "订单行ID";
                colvar订单行ID.DataType = DbType.Decimal;
                colvar订单行ID.MaxLength = 0;
                colvar订单行ID.AutoIncrement = false;
                colvar订单行ID.IsNullable = false;
                colvar订单行ID.IsPrimaryKey = false;
                colvar订单行ID.IsForeignKey = false;
                colvar订单行ID.IsReadOnly = false;
                
                schema.Columns.Add(colvar订单行ID);
                
                TableSchema.TableColumn colvar商品数量 = new TableSchema.TableColumn(schema);
                colvar商品数量.ColumnName = "商品数量";
                colvar商品数量.DataType = DbType.Decimal;
                colvar商品数量.MaxLength = 0;
                colvar商品数量.AutoIncrement = false;
                colvar商品数量.IsNullable = true;
                colvar商品数量.IsPrimaryKey = false;
                colvar商品数量.IsForeignKey = false;
                colvar商品数量.IsReadOnly = false;
                
                schema.Columns.Add(colvar商品数量);
                
                TableSchema.TableColumn colvar订单金额 = new TableSchema.TableColumn(schema);
                colvar订单金额.ColumnName = "订单金额";
                colvar订单金额.DataType = DbType.String;
                colvar订单金额.MaxLength = 0;
                colvar订单金额.AutoIncrement = false;
                colvar订单金额.IsNullable = true;
                colvar订单金额.IsPrimaryKey = false;
                colvar订单金额.IsForeignKey = false;
                colvar订单金额.IsReadOnly = false;
                
                schema.Columns.Add(colvar订单金额);
                
                TableSchema.TableColumn colvar币种 = new TableSchema.TableColumn(schema);
                colvar币种.ColumnName = "币种";
                colvar币种.DataType = DbType.String;
                colvar币种.MaxLength = 3;
                colvar币种.AutoIncrement = false;
                colvar币种.IsNullable = true;
                colvar币种.IsPrimaryKey = false;
                colvar币种.IsForeignKey = false;
                colvar币种.IsReadOnly = false;
                
                schema.Columns.Add(colvar币种);
                
                TableSchema.TableColumn colvar面料款式 = new TableSchema.TableColumn(schema);
                colvar面料款式.ColumnName = "面料款式";
                colvar面料款式.DataType = DbType.String;
                colvar面料款式.MaxLength = 20;
                colvar面料款式.AutoIncrement = false;
                colvar面料款式.IsNullable = true;
                colvar面料款式.IsPrimaryKey = false;
                colvar面料款式.IsForeignKey = false;
                colvar面料款式.IsReadOnly = false;
                
                schema.Columns.Add(colvar面料款式);
                
                TableSchema.TableColumn colvar是否客供面料 = new TableSchema.TableColumn(schema);
                colvar是否客供面料.ColumnName = "是否客供面料";
                colvar是否客供面料.DataType = DbType.String;
                colvar是否客供面料.MaxLength = 1;
                colvar是否客供面料.AutoIncrement = false;
                colvar是否客供面料.IsNullable = true;
                colvar是否客供面料.IsPrimaryKey = false;
                colvar是否客供面料.IsForeignKey = false;
                colvar是否客供面料.IsReadOnly = false;
                
                schema.Columns.Add(colvar是否客供面料);
                
                TableSchema.TableColumn colvar款式代码 = new TableSchema.TableColumn(schema);
                colvar款式代码.ColumnName = "款式代码";
                colvar款式代码.DataType = DbType.String;
                colvar款式代码.MaxLength = 20;
                colvar款式代码.AutoIncrement = false;
                colvar款式代码.IsNullable = true;
                colvar款式代码.IsPrimaryKey = false;
                colvar款式代码.IsForeignKey = false;
                colvar款式代码.IsReadOnly = false;
                
                schema.Columns.Add(colvar款式代码);
                
                
                BaseSchema = schema;
                //add this schema to the provider
                //so we can query it later
                DataService.Providers["ErpNowthwin"].AddSchema("V_YSTZ",schema);
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
	    public VYstz()
	    {
            SetSQLProps();
            SetDefaults();
            MarkNew();
        }
        public VYstz(bool useDatabaseDefaults)
	    {
		    SetSQLProps();
		    if(useDatabaseDefaults)
		    {
				ForceDefaults();
			}
			MarkNew();
	    }
	    
	    public VYstz(object keyID)
	    {
		    SetSQLProps();
		    LoadByKey(keyID);
	    }
    	 
	    public VYstz(string columnName, object columnValue)
        {
            SetSQLProps();
            LoadByParam(columnName,columnValue);
        }
        
	    #endregion
	    
	    #region Props
	    
          
        [XmlAttribute("单体单号")]
        [Bindable(true)]
        public string 单体单号 
	    {
		    get
		    {
			    return GetColumnValue<string>("单体单号");
		    }
            set 
		    {
			    SetColumnValue("单体单号", value);
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
	      
        [XmlAttribute("下单日期")]
        [Bindable(true)]
        public DateTime? 下单日期 
	    {
		    get
		    {
			    return GetColumnValue<DateTime?>("下单日期");
		    }
            set 
		    {
			    SetColumnValue("下单日期", value);
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
	      
        [XmlAttribute("订单总额")]
        [Bindable(true)]
        public string 订单总额 
	    {
		    get
		    {
			    return GetColumnValue<string>("订单总额");
		    }
            set 
		    {
			    SetColumnValue("订单总额", value);
            }
        }
	      
        [XmlAttribute("来源系统客户ID")]
        [Bindable(true)]
        public string 来源系统客户ID 
	    {
		    get
		    {
			    return GetColumnValue<string>("来源系统客户ID");
		    }
            set 
		    {
			    SetColumnValue("来源系统客户ID", value);
            }
        }
	      
        [XmlAttribute("订单行ID")]
        [Bindable(true)]
        public decimal 订单行ID 
	    {
		    get
		    {
			    return GetColumnValue<decimal>("订单行ID");
		    }
            set 
		    {
			    SetColumnValue("订单行ID", value);
            }
        }
	      
        [XmlAttribute("商品数量")]
        [Bindable(true)]
        public decimal? 商品数量 
	    {
		    get
		    {
			    return GetColumnValue<decimal?>("商品数量");
		    }
            set 
		    {
			    SetColumnValue("商品数量", value);
            }
        }
	      
        [XmlAttribute("订单金额")]
        [Bindable(true)]
        public string 订单金额 
	    {
		    get
		    {
			    return GetColumnValue<string>("订单金额");
		    }
            set 
		    {
			    SetColumnValue("订单金额", value);
            }
        }
	      
        [XmlAttribute("币种")]
        [Bindable(true)]
        public string 币种 
	    {
		    get
		    {
			    return GetColumnValue<string>("币种");
		    }
            set 
		    {
			    SetColumnValue("币种", value);
            }
        }
	      
        [XmlAttribute("面料款式")]
        [Bindable(true)]
        public string 面料款式 
	    {
		    get
		    {
			    return GetColumnValue<string>("面料款式");
		    }
            set 
		    {
			    SetColumnValue("面料款式", value);
            }
        }
	      
        [XmlAttribute("是否客供面料")]
        [Bindable(true)]
        public string 是否客供面料 
	    {
		    get
		    {
			    return GetColumnValue<string>("是否客供面料");
		    }
            set 
		    {
			    SetColumnValue("是否客供面料", value);
            }
        }
	      
        [XmlAttribute("款式代码")]
        [Bindable(true)]
        public string 款式代码 
	    {
		    get
		    {
			    return GetColumnValue<string>("款式代码");
		    }
            set 
		    {
			    SetColumnValue("款式代码", value);
            }
        }
	    
	    #endregion
    
	    #region Columns Struct
	    public struct Columns
	    {
		    
		    
            public static string 单体单号 = @"单体单号";
            
            public static string 销售订单号 = @"销售订单号";
            
            public static string 计划单号 = @"计划单号";
            
            public static string 下单日期 = @"下单日期";
            
            public static string 交货日期 = @"交货日期";
            
            public static string 订单总额 = @"订单总额";
            
            public static string 来源系统客户ID = @"来源系统客户ID";
            
            public static string 订单行ID = @"订单行ID";
            
            public static string 商品数量 = @"商品数量";
            
            public static string 订单金额 = @"订单金额";
            
            public static string 币种 = @"币种";
            
            public static string 面料款式 = @"面料款式";
            
            public static string 是否客供面料 = @"是否客供面料";
            
            public static string 款式代码 = @"款式代码";
            
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
