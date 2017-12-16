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
    /// Strongly-typed collection for the VFzScjh class.
    /// </summary>
    [Serializable]
    public partial class VFzScjhCollection : ReadOnlyList<VFzScjh, VFzScjhCollection>
    {        
        public VFzScjhCollection() {}
    }
    /// <summary>
    /// This is  Read-only wrapper class for the V_FZ_SCJH view.
    /// </summary>
    [Serializable]
    public partial class VFzScjh : ReadOnlyRecord<VFzScjh>, IReadOnlyRecord
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
                TableSchema.Table schema = new TableSchema.Table("V_FZ_SCJH", TableType.View, DataService.GetInstance("Nowthwin"));
                schema.Columns = new TableSchema.TableColumnCollection();
                schema.SchemaName = @"dbo";
                //columns
                
                TableSchema.TableColumn colvarKhdh = new TableSchema.TableColumn(schema);
                colvarKhdh.ColumnName = "khdh";
                colvarKhdh.DataType = DbType.String;
                colvarKhdh.MaxLength = 50;
                colvarKhdh.AutoIncrement = false;
                colvarKhdh.IsNullable = true;
                colvarKhdh.IsPrimaryKey = false;
                colvarKhdh.IsForeignKey = false;
                colvarKhdh.IsReadOnly = false;
                
                schema.Columns.Add(colvarKhdh);
                
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
                
                TableSchema.TableColumn colvarRemarkCode = new TableSchema.TableColumn(schema);
                colvarRemarkCode.ColumnName = "remarkCode";
                colvarRemarkCode.DataType = DbType.String;
                colvarRemarkCode.MaxLength = 50;
                colvarRemarkCode.AutoIncrement = false;
                colvarRemarkCode.IsNullable = true;
                colvarRemarkCode.IsPrimaryKey = false;
                colvarRemarkCode.IsForeignKey = false;
                colvarRemarkCode.IsReadOnly = false;
                
                schema.Columns.Add(colvarRemarkCode);
                
                TableSchema.TableColumn colvarGylx = new TableSchema.TableColumn(schema);
                colvarGylx.ColumnName = "gylx";
                colvarGylx.DataType = DbType.String;
                colvarGylx.MaxLength = 50;
                colvarGylx.AutoIncrement = false;
                colvarGylx.IsNullable = true;
                colvarGylx.IsPrimaryKey = false;
                colvarGylx.IsForeignKey = false;
                colvarGylx.IsReadOnly = false;
                
                schema.Columns.Add(colvarGylx);
                
                TableSchema.TableColumn colvarFzfl = new TableSchema.TableColumn(schema);
                colvarFzfl.ColumnName = "fzfl";
                colvarFzfl.DataType = DbType.String;
                colvarFzfl.MaxLength = 50;
                colvarFzfl.AutoIncrement = false;
                colvarFzfl.IsNullable = true;
                colvarFzfl.IsPrimaryKey = false;
                colvarFzfl.IsForeignKey = false;
                colvarFzfl.IsReadOnly = false;
                
                schema.Columns.Add(colvarFzfl);
                
                TableSchema.TableColumn colvarKsjg = new TableSchema.TableColumn(schema);
                colvarKsjg.ColumnName = "ksjg";
                colvarKsjg.DataType = DbType.String;
                colvarKsjg.MaxLength = 50;
                colvarKsjg.AutoIncrement = false;
                colvarKsjg.IsNullable = true;
                colvarKsjg.IsPrimaryKey = false;
                colvarKsjg.IsForeignKey = false;
                colvarKsjg.IsReadOnly = false;
                
                schema.Columns.Add(colvarKsjg);
                
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
                
                TableSchema.TableColumn colvarCustomername = new TableSchema.TableColumn(schema);
                colvarCustomername.ColumnName = "customername";
                colvarCustomername.DataType = DbType.String;
                colvarCustomername.MaxLength = 100;
                colvarCustomername.AutoIncrement = false;
                colvarCustomername.IsNullable = true;
                colvarCustomername.IsPrimaryKey = false;
                colvarCustomername.IsForeignKey = false;
                colvarCustomername.IsReadOnly = false;
                
                schema.Columns.Add(colvarCustomername);
                
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
                
                TableSchema.TableColumn colvarKsh = new TableSchema.TableColumn(schema);
                colvarKsh.ColumnName = "ksh";
                colvarKsh.DataType = DbType.String;
                colvarKsh.MaxLength = 50;
                colvarKsh.AutoIncrement = false;
                colvarKsh.IsNullable = true;
                colvarKsh.IsPrimaryKey = false;
                colvarKsh.IsForeignKey = false;
                colvarKsh.IsReadOnly = false;
                
                schema.Columns.Add(colvarKsh);
                
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
                
                TableSchema.TableColumn colvarMlbm = new TableSchema.TableColumn(schema);
                colvarMlbm.ColumnName = "mlbm";
                colvarMlbm.DataType = DbType.String;
                colvarMlbm.MaxLength = 50;
                colvarMlbm.AutoIncrement = false;
                colvarMlbm.IsNullable = true;
                colvarMlbm.IsPrimaryKey = false;
                colvarMlbm.IsForeignKey = false;
                colvarMlbm.IsReadOnly = false;
                
                schema.Columns.Add(colvarMlbm);
                
                TableSchema.TableColumn colvarHxjg = new TableSchema.TableColumn(schema);
                colvarHxjg.ColumnName = "hxjg";
                colvarHxjg.DataType = DbType.String;
                colvarHxjg.MaxLength = 50;
                colvarHxjg.AutoIncrement = false;
                colvarHxjg.IsNullable = true;
                colvarHxjg.IsPrimaryKey = false;
                colvarHxjg.IsForeignKey = false;
                colvarHxjg.IsReadOnly = false;
                
                schema.Columns.Add(colvarHxjg);
                
                TableSchema.TableColumn colvarOrderType = new TableSchema.TableColumn(schema);
                colvarOrderType.ColumnName = "orderType";
                colvarOrderType.DataType = DbType.String;
                colvarOrderType.MaxLength = 20;
                colvarOrderType.AutoIncrement = false;
                colvarOrderType.IsNullable = true;
                colvarOrderType.IsPrimaryKey = false;
                colvarOrderType.IsForeignKey = false;
                colvarOrderType.IsReadOnly = false;
                
                schema.Columns.Add(colvarOrderType);
                
                TableSchema.TableColumn colvarC = new TableSchema.TableColumn(schema);
                colvarC.ColumnName = "c";
                colvarC.DataType = DbType.String;
                colvarC.MaxLength = 71;
                colvarC.AutoIncrement = false;
                colvarC.IsNullable = true;
                colvarC.IsPrimaryKey = false;
                colvarC.IsForeignKey = false;
                colvarC.IsReadOnly = false;
                
                schema.Columns.Add(colvarC);
                
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
                
                TableSchema.TableColumn colvarMtml = new TableSchema.TableColumn(schema);
                colvarMtml.ColumnName = "MTML";
                colvarMtml.DataType = DbType.String;
                colvarMtml.MaxLength = 50;
                colvarMtml.AutoIncrement = false;
                colvarMtml.IsNullable = true;
                colvarMtml.IsPrimaryKey = false;
                colvarMtml.IsForeignKey = false;
                colvarMtml.IsReadOnly = false;
                
                schema.Columns.Add(colvarMtml);
                
                TableSchema.TableColumn colvarXianh = new TableSchema.TableColumn(schema);
                colvarXianh.ColumnName = "XIANH";
                colvarXianh.DataType = DbType.String;
                colvarXianh.MaxLength = 50;
                colvarXianh.AutoIncrement = false;
                colvarXianh.IsNullable = true;
                colvarXianh.IsPrimaryKey = false;
                colvarXianh.IsForeignKey = false;
                colvarXianh.IsReadOnly = false;
                
                schema.Columns.Add(colvarXianh);
                
                TableSchema.TableColumn colvarGyxx = new TableSchema.TableColumn(schema);
                colvarGyxx.ColumnName = "gyxx";
                colvarGyxx.DataType = DbType.String;
                colvarGyxx.MaxLength = -1;
                colvarGyxx.AutoIncrement = false;
                colvarGyxx.IsNullable = true;
                colvarGyxx.IsPrimaryKey = false;
                colvarGyxx.IsForeignKey = false;
                colvarGyxx.IsReadOnly = false;
                
                schema.Columns.Add(colvarGyxx);
                
                TableSchema.TableColumn colvarSfbcpsy = new TableSchema.TableColumn(schema);
                colvarSfbcpsy.ColumnName = "sfbcpsy";
                colvarSfbcpsy.DataType = DbType.String;
                colvarSfbcpsy.MaxLength = 20;
                colvarSfbcpsy.AutoIncrement = false;
                colvarSfbcpsy.IsNullable = true;
                colvarSfbcpsy.IsPrimaryKey = false;
                colvarSfbcpsy.IsForeignKey = false;
                colvarSfbcpsy.IsReadOnly = false;
                
                schema.Columns.Add(colvarSfbcpsy);
                
                
                BaseSchema = schema;
                //add this schema to the provider
                //so we can query it later
                DataService.Providers["Nowthwin"].AddSchema("V_FZ_SCJH",schema);
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
	    public VFzScjh()
	    {
            SetSQLProps();
            SetDefaults();
            MarkNew();
        }
        public VFzScjh(bool useDatabaseDefaults)
	    {
		    SetSQLProps();
		    if(useDatabaseDefaults)
		    {
				ForceDefaults();
			}
			MarkNew();
	    }
	    
	    public VFzScjh(object keyID)
	    {
		    SetSQLProps();
		    LoadByKey(keyID);
	    }
    	 
	    public VFzScjh(string columnName, object columnValue)
        {
            SetSQLProps();
            LoadByParam(columnName,columnValue);
        }
        
	    #endregion
	    
	    #region Props
	    
          
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
	      
        [XmlAttribute("RemarkCode")]
        [Bindable(true)]
        public string RemarkCode 
	    {
		    get
		    {
			    return GetColumnValue<string>("remarkCode");
		    }
            set 
		    {
			    SetColumnValue("remarkCode", value);
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
	      
        [XmlAttribute("Customername")]
        [Bindable(true)]
        public string Customername 
	    {
		    get
		    {
			    return GetColumnValue<string>("customername");
		    }
            set 
		    {
			    SetColumnValue("customername", value);
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
	      
        [XmlAttribute("OrderType")]
        [Bindable(true)]
        public string OrderType 
	    {
		    get
		    {
			    return GetColumnValue<string>("orderType");
		    }
            set 
		    {
			    SetColumnValue("orderType", value);
            }
        }
	      
        [XmlAttribute("C")]
        [Bindable(true)]
        public string C 
	    {
		    get
		    {
			    return GetColumnValue<string>("c");
		    }
            set 
		    {
			    SetColumnValue("c", value);
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
	      
        [XmlAttribute("Mtml")]
        [Bindable(true)]
        public string Mtml 
	    {
		    get
		    {
			    return GetColumnValue<string>("MTML");
		    }
            set 
		    {
			    SetColumnValue("MTML", value);
            }
        }
	      
        [XmlAttribute("Xianh")]
        [Bindable(true)]
        public string Xianh 
	    {
		    get
		    {
			    return GetColumnValue<string>("XIANH");
		    }
            set 
		    {
			    SetColumnValue("XIANH", value);
            }
        }
	      
        [XmlAttribute("Gyxx")]
        [Bindable(true)]
        public string Gyxx 
	    {
		    get
		    {
			    return GetColumnValue<string>("gyxx");
		    }
            set 
		    {
			    SetColumnValue("gyxx", value);
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
	    
	    #endregion
    
	    #region Columns Struct
	    public struct Columns
	    {
		    
		    
            public static string Khdh = @"khdh";
            
            public static string Sldl = @"sldl";
            
            public static string RemarkCode = @"remarkCode";
            
            public static string Gylx = @"gylx";
            
            public static string Fzfl = @"fzfl";
            
            public static string Ksjg = @"ksjg";
            
            public static string Num = @"num";
            
            public static string Customername = @"customername";
            
            public static string Jhrq = @"jhrq";
            
            public static string Ksh = @"ksh";
            
            public static string Trantime = @"trantime";
            
            public static string Mlbm = @"mlbm";
            
            public static string Hxjg = @"hxjg";
            
            public static string OrderType = @"orderType";
            
            public static string C = @"c";
            
            public static string Mxid = @"mxid";
            
            public static string Mtml = @"MTML";
            
            public static string Xianh = @"XIANH";
            
            public static string Gyxx = @"gyxx";
            
            public static string Sfbcpsy = @"sfbcpsy";
            
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