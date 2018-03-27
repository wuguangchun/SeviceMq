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
    /// Strongly-typed collection for the VPlanSDetail class.
    /// </summary>
    [Serializable]
    public partial class VPlanSDetailCollection : ReadOnlyList<VPlanSDetail, VPlanSDetailCollection>
    {        
        public VPlanSDetailCollection() {}
    }
    /// <summary>
    /// This is  Read-only wrapper class for the V_PlanS_Detail view.
    /// </summary>
    [Serializable]
    public partial class VPlanSDetail : ReadOnlyRecord<VPlanSDetail>, IReadOnlyRecord
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
                TableSchema.Table schema = new TableSchema.Table("V_PlanS_Detail", TableType.View, DataService.GetInstance("Nowthwin"));
                schema.Columns = new TableSchema.TableColumnCollection();
                schema.SchemaName = @"dbo";
                //columns
                
                TableSchema.TableColumn colvarPlansid = new TableSchema.TableColumn(schema);
                colvarPlansid.ColumnName = "PLANSID";
                colvarPlansid.DataType = DbType.Int32;
                colvarPlansid.MaxLength = 0;
                colvarPlansid.AutoIncrement = false;
                colvarPlansid.IsNullable = false;
                colvarPlansid.IsPrimaryKey = false;
                colvarPlansid.IsForeignKey = false;
                colvarPlansid.IsReadOnly = false;
                
                schema.Columns.Add(colvarPlansid);
                
                TableSchema.TableColumn colvarPlanmid = new TableSchema.TableColumn(schema);
                colvarPlanmid.ColumnName = "PLANMID";
                colvarPlanmid.DataType = DbType.Int32;
                colvarPlanmid.MaxLength = 0;
                colvarPlanmid.AutoIncrement = false;
                colvarPlanmid.IsNullable = true;
                colvarPlanmid.IsPrimaryKey = false;
                colvarPlanmid.IsForeignKey = false;
                colvarPlanmid.IsReadOnly = false;
                
                schema.Columns.Add(colvarPlanmid);
                
                TableSchema.TableColumn colvarKhdh = new TableSchema.TableColumn(schema);
                colvarKhdh.ColumnName = "KHDH";
                colvarKhdh.DataType = DbType.AnsiString;
                colvarKhdh.MaxLength = 30;
                colvarKhdh.AutoIncrement = false;
                colvarKhdh.IsNullable = false;
                colvarKhdh.IsPrimaryKey = false;
                colvarKhdh.IsForeignKey = false;
                colvarKhdh.IsReadOnly = false;
                
                schema.Columns.Add(colvarKhdh);
                
                TableSchema.TableColumn colvarGyfl = new TableSchema.TableColumn(schema);
                colvarGyfl.ColumnName = "GYFL";
                colvarGyfl.DataType = DbType.AnsiString;
                colvarGyfl.MaxLength = 30;
                colvarGyfl.AutoIncrement = false;
                colvarGyfl.IsNullable = true;
                colvarGyfl.IsPrimaryKey = false;
                colvarGyfl.IsForeignKey = false;
                colvarGyfl.IsReadOnly = false;
                
                schema.Columns.Add(colvarGyfl);
                
                TableSchema.TableColumn colvarSldl = new TableSchema.TableColumn(schema);
                colvarSldl.ColumnName = "SLDL";
                colvarSldl.DataType = DbType.AnsiString;
                colvarSldl.MaxLength = 50;
                colvarSldl.AutoIncrement = false;
                colvarSldl.IsNullable = true;
                colvarSldl.IsPrimaryKey = false;
                colvarSldl.IsForeignKey = false;
                colvarSldl.IsReadOnly = false;
                
                schema.Columns.Add(colvarSldl);
                
                TableSchema.TableColumn colvarPbxh = new TableSchema.TableColumn(schema);
                colvarPbxh.ColumnName = "PBXH";
                colvarPbxh.DataType = DbType.Int32;
                colvarPbxh.MaxLength = 0;
                colvarPbxh.AutoIncrement = false;
                colvarPbxh.IsNullable = true;
                colvarPbxh.IsPrimaryKey = false;
                colvarPbxh.IsForeignKey = false;
                colvarPbxh.IsReadOnly = false;
                
                schema.Columns.Add(colvarPbxh);
                
                TableSchema.TableColumn colvarWlxh = new TableSchema.TableColumn(schema);
                colvarWlxh.ColumnName = "WLXH";
                colvarWlxh.DataType = DbType.Int32;
                colvarWlxh.MaxLength = 0;
                colvarWlxh.AutoIncrement = false;
                colvarWlxh.IsNullable = true;
                colvarWlxh.IsPrimaryKey = false;
                colvarWlxh.IsForeignKey = false;
                colvarWlxh.IsReadOnly = false;
                
                schema.Columns.Add(colvarWlxh);
                
                TableSchema.TableColumn colvarWlbm = new TableSchema.TableColumn(schema);
                colvarWlbm.ColumnName = "WLBM";
                colvarWlbm.DataType = DbType.AnsiString;
                colvarWlbm.MaxLength = 50;
                colvarWlbm.AutoIncrement = false;
                colvarWlbm.IsNullable = false;
                colvarWlbm.IsPrimaryKey = false;
                colvarWlbm.IsForeignKey = false;
                colvarWlbm.IsReadOnly = false;
                
                schema.Columns.Add(colvarWlbm);
                
                TableSchema.TableColumn colvarWlfk = new TableSchema.TableColumn(schema);
                colvarWlfk.ColumnName = "WLFK";
                colvarWlfk.DataType = DbType.Decimal;
                colvarWlfk.MaxLength = 0;
                colvarWlfk.AutoIncrement = false;
                colvarWlfk.IsNullable = false;
                colvarWlfk.IsPrimaryKey = false;
                colvarWlfk.IsForeignKey = false;
                colvarWlfk.IsReadOnly = false;
                
                schema.Columns.Add(colvarWlfk);
                
                TableSchema.TableColumn colvarWlhy = new TableSchema.TableColumn(schema);
                colvarWlhy.ColumnName = "WLHY";
                colvarWlhy.DataType = DbType.Decimal;
                colvarWlhy.MaxLength = 0;
                colvarWlhy.AutoIncrement = false;
                colvarWlhy.IsNullable = false;
                colvarWlhy.IsPrimaryKey = false;
                colvarWlhy.IsForeignKey = false;
                colvarWlhy.IsReadOnly = false;
                
                schema.Columns.Add(colvarWlhy);
                
                TableSchema.TableColumn colvarTgsx = new TableSchema.TableColumn(schema);
                colvarTgsx.ColumnName = "TGSX";
                colvarTgsx.DataType = DbType.AnsiString;
                colvarTgsx.MaxLength = 30;
                colvarTgsx.AutoIncrement = false;
                colvarTgsx.IsNullable = false;
                colvarTgsx.IsPrimaryKey = false;
                colvarTgsx.IsForeignKey = false;
                colvarTgsx.IsReadOnly = false;
                
                schema.Columns.Add(colvarTgsx);
                
                TableSchema.TableColumn colvarTgkd = new TableSchema.TableColumn(schema);
                colvarTgkd.ColumnName = "TGKD";
                colvarTgkd.DataType = DbType.Decimal;
                colvarTgkd.MaxLength = 0;
                colvarTgkd.AutoIncrement = false;
                colvarTgkd.IsNullable = true;
                colvarTgkd.IsPrimaryKey = false;
                colvarTgkd.IsForeignKey = false;
                colvarTgkd.IsReadOnly = false;
                
                schema.Columns.Add(colvarTgkd);
                
                TableSchema.TableColumn colvarWlbw = new TableSchema.TableColumn(schema);
                colvarWlbw.ColumnName = "WLBW";
                colvarWlbw.DataType = DbType.AnsiString;
                colvarWlbw.MaxLength = 200;
                colvarWlbw.AutoIncrement = false;
                colvarWlbw.IsNullable = false;
                colvarWlbw.IsPrimaryKey = false;
                colvarWlbw.IsForeignKey = false;
                colvarWlbw.IsReadOnly = false;
                
                schema.Columns.Add(colvarWlbw);
                
                TableSchema.TableColumn colvarIsAPS = new TableSchema.TableColumn(schema);
                colvarIsAPS.ColumnName = "IsAPS";
                colvarIsAPS.DataType = DbType.Boolean;
                colvarIsAPS.MaxLength = 0;
                colvarIsAPS.AutoIncrement = false;
                colvarIsAPS.IsNullable = true;
                colvarIsAPS.IsPrimaryKey = false;
                colvarIsAPS.IsForeignKey = false;
                colvarIsAPS.IsReadOnly = false;
                
                schema.Columns.Add(colvarIsAPS);
                
                TableSchema.TableColumn colvarSczsbh = new TableSchema.TableColumn(schema);
                colvarSczsbh.ColumnName = "SCZSBH";
                colvarSczsbh.DataType = DbType.AnsiString;
                colvarSczsbh.MaxLength = 20;
                colvarSczsbh.AutoIncrement = false;
                colvarSczsbh.IsNullable = true;
                colvarSczsbh.IsPrimaryKey = false;
                colvarSczsbh.IsForeignKey = false;
                colvarSczsbh.IsReadOnly = false;
                
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
                
                schema.Columns.Add(colvarScxdrq);
                
                TableSchema.TableColumn colvarStatus = new TableSchema.TableColumn(schema);
                colvarStatus.ColumnName = "STATUS";
                colvarStatus.DataType = DbType.AnsiString;
                colvarStatus.MaxLength = 2;
                colvarStatus.AutoIncrement = false;
                colvarStatus.IsNullable = true;
                colvarStatus.IsPrimaryKey = false;
                colvarStatus.IsForeignKey = false;
                colvarStatus.IsReadOnly = false;
                
                schema.Columns.Add(colvarStatus);
                
                
                BaseSchema = schema;
                //add this schema to the provider
                //so we can query it later
                DataService.Providers["Nowthwin"].AddSchema("V_PlanS_Detail",schema);
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
	    public VPlanSDetail()
	    {
            SetSQLProps();
            SetDefaults();
            MarkNew();
        }
        public VPlanSDetail(bool useDatabaseDefaults)
	    {
		    SetSQLProps();
		    if(useDatabaseDefaults)
		    {
				ForceDefaults();
			}
			MarkNew();
	    }
	    
	    public VPlanSDetail(object keyID)
	    {
		    SetSQLProps();
		    LoadByKey(keyID);
	    }
    	 
	    public VPlanSDetail(string columnName, object columnValue)
        {
            SetSQLProps();
            LoadByParam(columnName,columnValue);
        }
        
	    #endregion
	    
	    #region Props
	    
          
        [XmlAttribute("Plansid")]
        [Bindable(true)]
        public int Plansid 
	    {
		    get
		    {
			    return GetColumnValue<int>("PLANSID");
		    }
            set 
		    {
			    SetColumnValue("PLANSID", value);
            }
        }
	      
        [XmlAttribute("Planmid")]
        [Bindable(true)]
        public int? Planmid 
	    {
		    get
		    {
			    return GetColumnValue<int?>("PLANMID");
		    }
            set 
		    {
			    SetColumnValue("PLANMID", value);
            }
        }
	      
        [XmlAttribute("Khdh")]
        [Bindable(true)]
        public string Khdh 
	    {
		    get
		    {
			    return GetColumnValue<string>("KHDH");
		    }
            set 
		    {
			    SetColumnValue("KHDH", value);
            }
        }
	      
        [XmlAttribute("Gyfl")]
        [Bindable(true)]
        public string Gyfl 
	    {
		    get
		    {
			    return GetColumnValue<string>("GYFL");
		    }
            set 
		    {
			    SetColumnValue("GYFL", value);
            }
        }
	      
        [XmlAttribute("Sldl")]
        [Bindable(true)]
        public string Sldl 
	    {
		    get
		    {
			    return GetColumnValue<string>("SLDL");
		    }
            set 
		    {
			    SetColumnValue("SLDL", value);
            }
        }
	      
        [XmlAttribute("Pbxh")]
        [Bindable(true)]
        public int? Pbxh 
	    {
		    get
		    {
			    return GetColumnValue<int?>("PBXH");
		    }
            set 
		    {
			    SetColumnValue("PBXH", value);
            }
        }
	      
        [XmlAttribute("Wlxh")]
        [Bindable(true)]
        public int? Wlxh 
	    {
		    get
		    {
			    return GetColumnValue<int?>("WLXH");
		    }
            set 
		    {
			    SetColumnValue("WLXH", value);
            }
        }
	      
        [XmlAttribute("Wlbm")]
        [Bindable(true)]
        public string Wlbm 
	    {
		    get
		    {
			    return GetColumnValue<string>("WLBM");
		    }
            set 
		    {
			    SetColumnValue("WLBM", value);
            }
        }
	      
        [XmlAttribute("Wlfk")]
        [Bindable(true)]
        public decimal Wlfk 
	    {
		    get
		    {
			    return GetColumnValue<decimal>("WLFK");
		    }
            set 
		    {
			    SetColumnValue("WLFK", value);
            }
        }
	      
        [XmlAttribute("Wlhy")]
        [Bindable(true)]
        public decimal Wlhy 
	    {
		    get
		    {
			    return GetColumnValue<decimal>("WLHY");
		    }
            set 
		    {
			    SetColumnValue("WLHY", value);
            }
        }
	      
        [XmlAttribute("Tgsx")]
        [Bindable(true)]
        public string Tgsx 
	    {
		    get
		    {
			    return GetColumnValue<string>("TGSX");
		    }
            set 
		    {
			    SetColumnValue("TGSX", value);
            }
        }
	      
        [XmlAttribute("Tgkd")]
        [Bindable(true)]
        public decimal? Tgkd 
	    {
		    get
		    {
			    return GetColumnValue<decimal?>("TGKD");
		    }
            set 
		    {
			    SetColumnValue("TGKD", value);
            }
        }
	      
        [XmlAttribute("Wlbw")]
        [Bindable(true)]
        public string Wlbw 
	    {
		    get
		    {
			    return GetColumnValue<string>("WLBW");
		    }
            set 
		    {
			    SetColumnValue("WLBW", value);
            }
        }
	      
        [XmlAttribute("IsAPS")]
        [Bindable(true)]
        public bool? IsAPS 
	    {
		    get
		    {
			    return GetColumnValue<bool?>("IsAPS");
		    }
            set 
		    {
			    SetColumnValue("IsAPS", value);
            }
        }
	      
        [XmlAttribute("Sczsbh")]
        [Bindable(true)]
        public string Sczsbh 
	    {
		    get
		    {
			    return GetColumnValue<string>("SCZSBH");
		    }
            set 
		    {
			    SetColumnValue("SCZSBH", value);
            }
        }
	      
        [XmlAttribute("Scgcmc")]
        [Bindable(true)]
        public string Scgcmc 
	    {
		    get
		    {
			    return GetColumnValue<string>("SCGCMC");
		    }
            set 
		    {
			    SetColumnValue("SCGCMC", value);
            }
        }
	      
        [XmlAttribute("Scxdrq")]
        [Bindable(true)]
        public DateTime? Scxdrq 
	    {
		    get
		    {
			    return GetColumnValue<DateTime?>("SCXDRQ");
		    }
            set 
		    {
			    SetColumnValue("SCXDRQ", value);
            }
        }
	      
        [XmlAttribute("Status")]
        [Bindable(true)]
        public string Status 
	    {
		    get
		    {
			    return GetColumnValue<string>("STATUS");
		    }
            set 
		    {
			    SetColumnValue("STATUS", value);
            }
        }
	    
	    #endregion
    
	    #region Columns Struct
	    public struct Columns
	    {
		    
		    
            public static string Plansid = @"PLANSID";
            
            public static string Planmid = @"PLANMID";
            
            public static string Khdh = @"KHDH";
            
            public static string Gyfl = @"GYFL";
            
            public static string Sldl = @"SLDL";
            
            public static string Pbxh = @"PBXH";
            
            public static string Wlxh = @"WLXH";
            
            public static string Wlbm = @"WLBM";
            
            public static string Wlfk = @"WLFK";
            
            public static string Wlhy = @"WLHY";
            
            public static string Tgsx = @"TGSX";
            
            public static string Tgkd = @"TGKD";
            
            public static string Wlbw = @"WLBW";
            
            public static string IsAPS = @"IsAPS";
            
            public static string Sczsbh = @"SCZSBH";
            
            public static string Scgcmc = @"SCGCMC";
            
            public static string Scxdrq = @"SCXDRQ";
            
            public static string Status = @"STATUS";
            
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
