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
namespace Model{
    /// <summary>
    /// Strongly-typed collection for the VOrderDatapoolXfNew class.
    /// </summary>
    [Serializable]
    public partial class VOrderDatapoolXfNewCollection : ReadOnlyList<VOrderDatapoolXfNew, VOrderDatapoolXfNewCollection>
    {        
        public VOrderDatapoolXfNewCollection() {}
    }
    /// <summary>
    /// This is  Read-only wrapper class for the V_OrderDatapoolXf_new view.
    /// </summary>
    [Serializable]
    public partial class VOrderDatapoolXfNew : ReadOnlyRecord<VOrderDatapoolXfNew>, IReadOnlyRecord
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
                TableSchema.Table schema = new TableSchema.Table("V_OrderDatapoolXf_new", TableType.View, DataService.GetInstance("Nowthwin"));
                schema.Columns = new TableSchema.TableColumnCollection();
                schema.SchemaName = @"dbo";
                //columns
                
                TableSchema.TableColumn colvarJqts = new TableSchema.TableColumn(schema);
                colvarJqts.ColumnName = "JQTS";
                colvarJqts.DataType = DbType.String;
                colvarJqts.MaxLength = 20;
                colvarJqts.AutoIncrement = false;
                colvarJqts.IsNullable = true;
                colvarJqts.IsPrimaryKey = false;
                colvarJqts.IsForeignKey = false;
                colvarJqts.IsReadOnly = false;
                
                schema.Columns.Add(colvarJqts);
                
                TableSchema.TableColumn colvarMxid = new TableSchema.TableColumn(schema);
                colvarMxid.ColumnName = "mxid";
                colvarMxid.DataType = DbType.Int32;
                colvarMxid.MaxLength = 0;
                colvarMxid.AutoIncrement = false;
                colvarMxid.IsNullable = false;
                colvarMxid.IsPrimaryKey = false;
                colvarMxid.IsForeignKey = false;
                colvarMxid.IsReadOnly = false;
                
                schema.Columns.Add(colvarMxid);
                
                TableSchema.TableColumn colvarOrderid = new TableSchema.TableColumn(schema);
                colvarOrderid.ColumnName = "orderid";
                colvarOrderid.DataType = DbType.Int32;
                colvarOrderid.MaxLength = 0;
                colvarOrderid.AutoIncrement = false;
                colvarOrderid.IsNullable = true;
                colvarOrderid.IsPrimaryKey = false;
                colvarOrderid.IsForeignKey = false;
                colvarOrderid.IsReadOnly = false;
                
                schema.Columns.Add(colvarOrderid);
                
                TableSchema.TableColumn colvarKhdh = new TableSchema.TableColumn(schema);
                colvarKhdh.ColumnName = "khdh";
                colvarKhdh.DataType = DbType.String;
                colvarKhdh.MaxLength = 250;
                colvarKhdh.AutoIncrement = false;
                colvarKhdh.IsNullable = true;
                colvarKhdh.IsPrimaryKey = false;
                colvarKhdh.IsForeignKey = false;
                colvarKhdh.IsReadOnly = false;
                
                schema.Columns.Add(colvarKhdh);
                
                TableSchema.TableColumn colvarKsh = new TableSchema.TableColumn(schema);
                colvarKsh.ColumnName = "ksh";
                colvarKsh.DataType = DbType.String;
                colvarKsh.MaxLength = 250;
                colvarKsh.AutoIncrement = false;
                colvarKsh.IsNullable = true;
                colvarKsh.IsPrimaryKey = false;
                colvarKsh.IsForeignKey = false;
                colvarKsh.IsReadOnly = false;
                
                schema.Columns.Add(colvarKsh);
                
                TableSchema.TableColumn colvarFzfl = new TableSchema.TableColumn(schema);
                colvarFzfl.ColumnName = "fzfl";
                colvarFzfl.DataType = DbType.String;
                colvarFzfl.MaxLength = 250;
                colvarFzfl.AutoIncrement = false;
                colvarFzfl.IsNullable = true;
                colvarFzfl.IsPrimaryKey = false;
                colvarFzfl.IsForeignKey = false;
                colvarFzfl.IsReadOnly = false;
                
                schema.Columns.Add(colvarFzfl);
                
                TableSchema.TableColumn colvarMlbm = new TableSchema.TableColumn(schema);
                colvarMlbm.ColumnName = "mlbm";
                colvarMlbm.DataType = DbType.String;
                colvarMlbm.MaxLength = 250;
                colvarMlbm.AutoIncrement = false;
                colvarMlbm.IsNullable = true;
                colvarMlbm.IsPrimaryKey = false;
                colvarMlbm.IsForeignKey = false;
                colvarMlbm.IsReadOnly = false;
                
                schema.Columns.Add(colvarMlbm);
                
                TableSchema.TableColumn colvarDdsl = new TableSchema.TableColumn(schema);
                colvarDdsl.ColumnName = "ddsl";
                colvarDdsl.DataType = DbType.Int32;
                colvarDdsl.MaxLength = 0;
                colvarDdsl.AutoIncrement = false;
                colvarDdsl.IsNullable = true;
                colvarDdsl.IsPrimaryKey = false;
                colvarDdsl.IsForeignKey = false;
                colvarDdsl.IsReadOnly = false;
                
                schema.Columns.Add(colvarDdsl);
                
                TableSchema.TableColumn colvarHxjg = new TableSchema.TableColumn(schema);
                colvarHxjg.ColumnName = "hxjg";
                colvarHxjg.DataType = DbType.String;
                colvarHxjg.MaxLength = 250;
                colvarHxjg.AutoIncrement = false;
                colvarHxjg.IsNullable = true;
                colvarHxjg.IsPrimaryKey = false;
                colvarHxjg.IsForeignKey = false;
                colvarHxjg.IsReadOnly = false;
                
                schema.Columns.Add(colvarHxjg);
                
                TableSchema.TableColumn colvarKsjg = new TableSchema.TableColumn(schema);
                colvarKsjg.ColumnName = "ksjg";
                colvarKsjg.DataType = DbType.String;
                colvarKsjg.MaxLength = 250;
                colvarKsjg.AutoIncrement = false;
                colvarKsjg.IsNullable = true;
                colvarKsjg.IsPrimaryKey = false;
                colvarKsjg.IsForeignKey = false;
                colvarKsjg.IsReadOnly = false;
                
                schema.Columns.Add(colvarKsjg);
                
                TableSchema.TableColumn colvarGylx = new TableSchema.TableColumn(schema);
                colvarGylx.ColumnName = "gylx";
                colvarGylx.DataType = DbType.String;
                colvarGylx.MaxLength = 250;
                colvarGylx.AutoIncrement = false;
                colvarGylx.IsNullable = true;
                colvarGylx.IsPrimaryKey = false;
                colvarGylx.IsForeignKey = false;
                colvarGylx.IsReadOnly = false;
                
                schema.Columns.Add(colvarGylx);
                
                TableSchema.TableColumn colvarSfbcpsy = new TableSchema.TableColumn(schema);
                colvarSfbcpsy.ColumnName = "sfbcpsy";
                colvarSfbcpsy.DataType = DbType.String;
                colvarSfbcpsy.MaxLength = 250;
                colvarSfbcpsy.AutoIncrement = false;
                colvarSfbcpsy.IsNullable = true;
                colvarSfbcpsy.IsPrimaryKey = false;
                colvarSfbcpsy.IsForeignKey = false;
                colvarSfbcpsy.IsReadOnly = false;
                
                schema.Columns.Add(colvarSfbcpsy);
                
                TableSchema.TableColumn colvarXh = new TableSchema.TableColumn(schema);
                colvarXh.ColumnName = "xh";
                colvarXh.DataType = DbType.String;
                colvarXh.MaxLength = 250;
                colvarXh.AutoIncrement = false;
                colvarXh.IsNullable = true;
                colvarXh.IsPrimaryKey = false;
                colvarXh.IsForeignKey = false;
                colvarXh.IsReadOnly = false;
                
                schema.Columns.Add(colvarXh);
                
                TableSchema.TableColumn colvarXhsy = new TableSchema.TableColumn(schema);
                colvarXhsy.ColumnName = "xhsy";
                colvarXhsy.DataType = DbType.String;
                colvarXhsy.MaxLength = 250;
                colvarXhsy.AutoIncrement = false;
                colvarXhsy.IsNullable = true;
                colvarXhsy.IsPrimaryKey = false;
                colvarXhsy.IsForeignKey = false;
                colvarXhsy.IsReadOnly = false;
                
                schema.Columns.Add(colvarXhsy);
                
                TableSchema.TableColumn colvarXhnz = new TableSchema.TableColumn(schema);
                colvarXhnz.ColumnName = "xhnz";
                colvarXhnz.DataType = DbType.String;
                colvarXhnz.MaxLength = 250;
                colvarXhnz.AutoIncrement = false;
                colvarXhnz.IsNullable = true;
                colvarXhnz.IsPrimaryKey = false;
                colvarXhnz.IsForeignKey = false;
                colvarXhnz.IsReadOnly = false;
                
                schema.Columns.Add(colvarXhnz);
                
                TableSchema.TableColumn colvarXhwz = new TableSchema.TableColumn(schema);
                colvarXhwz.ColumnName = "xhwz";
                colvarXhwz.DataType = DbType.String;
                colvarXhwz.MaxLength = 250;
                colvarXhwz.AutoIncrement = false;
                colvarXhwz.IsNullable = true;
                colvarXhwz.IsPrimaryKey = false;
                colvarXhwz.IsForeignKey = false;
                colvarXhwz.IsReadOnly = false;
                
                schema.Columns.Add(colvarXhwz);
                
                TableSchema.TableColumn colvarMlsx = new TableSchema.TableColumn(schema);
                colvarMlsx.ColumnName = "mlsx";
                colvarMlsx.DataType = DbType.String;
                colvarMlsx.MaxLength = 250;
                colvarMlsx.AutoIncrement = false;
                colvarMlsx.IsNullable = true;
                colvarMlsx.IsPrimaryKey = false;
                colvarMlsx.IsForeignKey = false;
                colvarMlsx.IsReadOnly = false;
                
                schema.Columns.Add(colvarMlsx);
                
                TableSchema.TableColumn colvarFlagDelete = new TableSchema.TableColumn(schema);
                colvarFlagDelete.ColumnName = "flagDelete";
                colvarFlagDelete.DataType = DbType.Int32;
                colvarFlagDelete.MaxLength = 0;
                colvarFlagDelete.AutoIncrement = false;
                colvarFlagDelete.IsNullable = true;
                colvarFlagDelete.IsPrimaryKey = false;
                colvarFlagDelete.IsForeignKey = false;
                colvarFlagDelete.IsReadOnly = false;
                
                schema.Columns.Add(colvarFlagDelete);
                
                TableSchema.TableColumn colvarNum = new TableSchema.TableColumn(schema);
                colvarNum.ColumnName = "num";
                colvarNum.DataType = DbType.Int32;
                colvarNum.MaxLength = 0;
                colvarNum.AutoIncrement = false;
                colvarNum.IsNullable = true;
                colvarNum.IsPrimaryKey = false;
                colvarNum.IsForeignKey = false;
                colvarNum.IsReadOnly = false;
                
                schema.Columns.Add(colvarNum);
                
                TableSchema.TableColumn colvarFlagStatus = new TableSchema.TableColumn(schema);
                colvarFlagStatus.ColumnName = "flagStatus";
                colvarFlagStatus.DataType = DbType.Int32;
                colvarFlagStatus.MaxLength = 0;
                colvarFlagStatus.AutoIncrement = false;
                colvarFlagStatus.IsNullable = true;
                colvarFlagStatus.IsPrimaryKey = false;
                colvarFlagStatus.IsForeignKey = false;
                colvarFlagStatus.IsReadOnly = false;
                
                schema.Columns.Add(colvarFlagStatus);
                
                TableSchema.TableColumn colvarJhrq = new TableSchema.TableColumn(schema);
                colvarJhrq.ColumnName = "jhrq";
                colvarJhrq.DataType = DbType.DateTime;
                colvarJhrq.MaxLength = 0;
                colvarJhrq.AutoIncrement = false;
                colvarJhrq.IsNullable = true;
                colvarJhrq.IsPrimaryKey = false;
                colvarJhrq.IsForeignKey = false;
                colvarJhrq.IsReadOnly = false;
                
                schema.Columns.Add(colvarJhrq);
                
                TableSchema.TableColumn colvarTrantime = new TableSchema.TableColumn(schema);
                colvarTrantime.ColumnName = "trantime";
                colvarTrantime.DataType = DbType.DateTime;
                colvarTrantime.MaxLength = 0;
                colvarTrantime.AutoIncrement = false;
                colvarTrantime.IsNullable = true;
                colvarTrantime.IsPrimaryKey = false;
                colvarTrantime.IsForeignKey = false;
                colvarTrantime.IsReadOnly = false;
                
                schema.Columns.Add(colvarTrantime);
                
                TableSchema.TableColumn colvarSldl = new TableSchema.TableColumn(schema);
                colvarSldl.ColumnName = "sldl";
                colvarSldl.DataType = DbType.String;
                colvarSldl.MaxLength = 50;
                colvarSldl.AutoIncrement = false;
                colvarSldl.IsNullable = true;
                colvarSldl.IsPrimaryKey = false;
                colvarSldl.IsForeignKey = false;
                colvarSldl.IsReadOnly = false;
                
                schema.Columns.Add(colvarSldl);
                
                TableSchema.TableColumn colvarScjhbz = new TableSchema.TableColumn(schema);
                colvarScjhbz.ColumnName = "SCJHBZ";
                colvarScjhbz.DataType = DbType.String;
                colvarScjhbz.MaxLength = 100;
                colvarScjhbz.AutoIncrement = false;
                colvarScjhbz.IsNullable = true;
                colvarScjhbz.IsPrimaryKey = false;
                colvarScjhbz.IsForeignKey = false;
                colvarScjhbz.IsReadOnly = false;
                
                schema.Columns.Add(colvarScjhbz);
                
                
                BaseSchema = schema;
                //add this schema to the provider
                //so we can query it later
                DataService.Providers["Nowthwin"].AddSchema("V_OrderDatapoolXf_new",schema);
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
	    public VOrderDatapoolXfNew()
	    {
            SetSQLProps();
            SetDefaults();
            MarkNew();
        }
        public VOrderDatapoolXfNew(bool useDatabaseDefaults)
	    {
		    SetSQLProps();
		    if(useDatabaseDefaults)
		    {
				ForceDefaults();
			}
			MarkNew();
	    }
	    
	    public VOrderDatapoolXfNew(object keyID)
	    {
		    SetSQLProps();
		    LoadByKey(keyID);
	    }
    	 
	    public VOrderDatapoolXfNew(string columnName, object columnValue)
        {
            SetSQLProps();
            LoadByParam(columnName,columnValue);
        }
        
	    #endregion
	    
	    #region Props
	    
          
        [XmlAttribute("Jqts")]
        [Bindable(true)]
        public string Jqts 
	    {
		    get
		    {
			    return GetColumnValue<string>("JQTS");
		    }
            set 
		    {
			    SetColumnValue("JQTS", value);
            }
        }
	      
        [XmlAttribute("Mxid")]
        [Bindable(true)]
        public int Mxid 
	    {
		    get
		    {
			    return GetColumnValue<int>("mxid");
		    }
            set 
		    {
			    SetColumnValue("mxid", value);
            }
        }
	      
        [XmlAttribute("Orderid")]
        [Bindable(true)]
        public int? Orderid 
	    {
		    get
		    {
			    return GetColumnValue<int?>("orderid");
		    }
            set 
		    {
			    SetColumnValue("orderid", value);
            }
        }
	      
        [XmlAttribute("Khdh")]
        [Bindable(true)]
        public string Khdh 
	    {
		    get
		    {
			    return GetColumnValue<string>("khdh");
		    }
            set 
		    {
			    SetColumnValue("khdh", value);
            }
        }
	      
        [XmlAttribute("Ksh")]
        [Bindable(true)]
        public string Ksh 
	    {
		    get
		    {
			    return GetColumnValue<string>("ksh");
		    }
            set 
		    {
			    SetColumnValue("ksh", value);
            }
        }
	      
        [XmlAttribute("Fzfl")]
        [Bindable(true)]
        public string Fzfl 
	    {
		    get
		    {
			    return GetColumnValue<string>("fzfl");
		    }
            set 
		    {
			    SetColumnValue("fzfl", value);
            }
        }
	      
        [XmlAttribute("Mlbm")]
        [Bindable(true)]
        public string Mlbm 
	    {
		    get
		    {
			    return GetColumnValue<string>("mlbm");
		    }
            set 
		    {
			    SetColumnValue("mlbm", value);
            }
        }
	      
        [XmlAttribute("Ddsl")]
        [Bindable(true)]
        public int? Ddsl 
	    {
		    get
		    {
			    return GetColumnValue<int?>("ddsl");
		    }
            set 
		    {
			    SetColumnValue("ddsl", value);
            }
        }
	      
        [XmlAttribute("Hxjg")]
        [Bindable(true)]
        public string Hxjg 
	    {
		    get
		    {
			    return GetColumnValue<string>("hxjg");
		    }
            set 
		    {
			    SetColumnValue("hxjg", value);
            }
        }
	      
        [XmlAttribute("Ksjg")]
        [Bindable(true)]
        public string Ksjg 
	    {
		    get
		    {
			    return GetColumnValue<string>("ksjg");
		    }
            set 
		    {
			    SetColumnValue("ksjg", value);
            }
        }
	      
        [XmlAttribute("Gylx")]
        [Bindable(true)]
        public string Gylx 
	    {
		    get
		    {
			    return GetColumnValue<string>("gylx");
		    }
            set 
		    {
			    SetColumnValue("gylx", value);
            }
        }
	      
        [XmlAttribute("Sfbcpsy")]
        [Bindable(true)]
        public string Sfbcpsy 
	    {
		    get
		    {
			    return GetColumnValue<string>("sfbcpsy");
		    }
            set 
		    {
			    SetColumnValue("sfbcpsy", value);
            }
        }
	      
        [XmlAttribute("Xh")]
        [Bindable(true)]
        public string Xh 
	    {
		    get
		    {
			    return GetColumnValue<string>("xh");
		    }
            set 
		    {
			    SetColumnValue("xh", value);
            }
        }
	      
        [XmlAttribute("Xhsy")]
        [Bindable(true)]
        public string Xhsy 
	    {
		    get
		    {
			    return GetColumnValue<string>("xhsy");
		    }
            set 
		    {
			    SetColumnValue("xhsy", value);
            }
        }
	      
        [XmlAttribute("Xhnz")]
        [Bindable(true)]
        public string Xhnz 
	    {
		    get
		    {
			    return GetColumnValue<string>("xhnz");
		    }
            set 
		    {
			    SetColumnValue("xhnz", value);
            }
        }
	      
        [XmlAttribute("Xhwz")]
        [Bindable(true)]
        public string Xhwz 
	    {
		    get
		    {
			    return GetColumnValue<string>("xhwz");
		    }
            set 
		    {
			    SetColumnValue("xhwz", value);
            }
        }
	      
        [XmlAttribute("Mlsx")]
        [Bindable(true)]
        public string Mlsx 
	    {
		    get
		    {
			    return GetColumnValue<string>("mlsx");
		    }
            set 
		    {
			    SetColumnValue("mlsx", value);
            }
        }
	      
        [XmlAttribute("FlagDelete")]
        [Bindable(true)]
        public int? FlagDelete 
	    {
		    get
		    {
			    return GetColumnValue<int?>("flagDelete");
		    }
            set 
		    {
			    SetColumnValue("flagDelete", value);
            }
        }
	      
        [XmlAttribute("Num")]
        [Bindable(true)]
        public int? Num 
	    {
		    get
		    {
			    return GetColumnValue<int?>("num");
		    }
            set 
		    {
			    SetColumnValue("num", value);
            }
        }
	      
        [XmlAttribute("FlagStatus")]
        [Bindable(true)]
        public int? FlagStatus 
	    {
		    get
		    {
			    return GetColumnValue<int?>("flagStatus");
		    }
            set 
		    {
			    SetColumnValue("flagStatus", value);
            }
        }
	      
        [XmlAttribute("Jhrq")]
        [Bindable(true)]
        public DateTime? Jhrq 
	    {
		    get
		    {
			    return GetColumnValue<DateTime?>("jhrq");
		    }
            set 
		    {
			    SetColumnValue("jhrq", value);
            }
        }
	      
        [XmlAttribute("Trantime")]
        [Bindable(true)]
        public DateTime? Trantime 
	    {
		    get
		    {
			    return GetColumnValue<DateTime?>("trantime");
		    }
            set 
		    {
			    SetColumnValue("trantime", value);
            }
        }
	      
        [XmlAttribute("Sldl")]
        [Bindable(true)]
        public string Sldl 
	    {
		    get
		    {
			    return GetColumnValue<string>("sldl");
		    }
            set 
		    {
			    SetColumnValue("sldl", value);
            }
        }
	      
        [XmlAttribute("Scjhbz")]
        [Bindable(true)]
        public string Scjhbz 
	    {
		    get
		    {
			    return GetColumnValue<string>("SCJHBZ");
		    }
            set 
		    {
			    SetColumnValue("SCJHBZ", value);
            }
        }
	    
	    #endregion
    
	    #region Columns Struct
	    public struct Columns
	    {
		    
		    
            public static string Jqts = @"JQTS";
            
            public static string Mxid = @"mxid";
            
            public static string Orderid = @"orderid";
            
            public static string Khdh = @"khdh";
            
            public static string Ksh = @"ksh";
            
            public static string Fzfl = @"fzfl";
            
            public static string Mlbm = @"mlbm";
            
            public static string Ddsl = @"ddsl";
            
            public static string Hxjg = @"hxjg";
            
            public static string Ksjg = @"ksjg";
            
            public static string Gylx = @"gylx";
            
            public static string Sfbcpsy = @"sfbcpsy";
            
            public static string Xh = @"xh";
            
            public static string Xhsy = @"xhsy";
            
            public static string Xhnz = @"xhnz";
            
            public static string Xhwz = @"xhwz";
            
            public static string Mlsx = @"mlsx";
            
            public static string FlagDelete = @"flagDelete";
            
            public static string Num = @"num";
            
            public static string FlagStatus = @"flagStatus";
            
            public static string Jhrq = @"jhrq";
            
            public static string Trantime = @"trantime";
            
            public static string Sldl = @"sldl";
            
            public static string Scjhbz = @"SCJHBZ";
            
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
