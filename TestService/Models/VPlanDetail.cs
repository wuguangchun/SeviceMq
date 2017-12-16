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
namespace APSData{
    /// <summary>
    /// Strongly-typed collection for the VPlanDetail class.
    /// </summary>
    [Serializable]
    public partial class VPlanDetailCollection : ReadOnlyList<VPlanDetail, VPlanDetailCollection>
    {        
        public VPlanDetailCollection() {}
    }
    /// <summary>
    /// This is  Read-only wrapper class for the V_Plan_Detail view.
    /// </summary>
    [Serializable]
    public partial class VPlanDetail : ReadOnlyRecord<VPlanDetail>, IReadOnlyRecord
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
                TableSchema.Table schema = new TableSchema.Table("V_Plan_Detail", TableType.View, DataService.GetInstance("Nowthwin"));
                schema.Columns = new TableSchema.TableColumnCollection();
                schema.SchemaName = @"dbo";
                //columns
                
                TableSchema.TableColumn colvarSczsbh = new TableSchema.TableColumn(schema);
                colvarSczsbh.ColumnName = "SCZSBH";
                colvarSczsbh.DataType = DbType.AnsiString;
                colvarSczsbh.MaxLength = 12;
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
                
                TableSchema.TableColumn colvarSccjjq = new TableSchema.TableColumn(schema);
                colvarSccjjq.ColumnName = "SCCJJQ";
                colvarSccjjq.DataType = DbType.DateTime;
                colvarSccjjq.MaxLength = 0;
                colvarSccjjq.AutoIncrement = false;
                colvarSccjjq.IsNullable = true;
                colvarSccjjq.IsPrimaryKey = false;
                colvarSccjjq.IsForeignKey = false;
                colvarSccjjq.IsReadOnly = false;
                
                schema.Columns.Add(colvarSccjjq);
                
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
                
                TableSchema.TableColumn colvarSchtbh = new TableSchema.TableColumn(schema);
                colvarSchtbh.ColumnName = "SCHTBH";
                colvarSchtbh.DataType = DbType.AnsiString;
                colvarSchtbh.MaxLength = 12;
                colvarSchtbh.AutoIncrement = false;
                colvarSchtbh.IsNullable = true;
                colvarSchtbh.IsPrimaryKey = false;
                colvarSchtbh.IsForeignKey = false;
                colvarSchtbh.IsReadOnly = false;
                
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
                
                schema.Columns.Add(colvarSczsdl);
                
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
                colvarWlbm.IsNullable = true;
                colvarWlbm.IsPrimaryKey = false;
                colvarWlbm.IsForeignKey = false;
                colvarWlbm.IsReadOnly = false;
                
                schema.Columns.Add(colvarWlbm);
                
                TableSchema.TableColumn colvarWlhy = new TableSchema.TableColumn(schema);
                colvarWlhy.ColumnName = "WLHY";
                colvarWlhy.DataType = DbType.Decimal;
                colvarWlhy.MaxLength = 0;
                colvarWlhy.AutoIncrement = false;
                colvarWlhy.IsNullable = true;
                colvarWlhy.IsPrimaryKey = false;
                colvarWlhy.IsForeignKey = false;
                colvarWlhy.IsReadOnly = false;
                
                schema.Columns.Add(colvarWlhy);
                
                TableSchema.TableColumn colvarTgsx = new TableSchema.TableColumn(schema);
                colvarTgsx.ColumnName = "TGSX";
                colvarTgsx.DataType = DbType.AnsiString;
                colvarTgsx.MaxLength = 30;
                colvarTgsx.AutoIncrement = false;
                colvarTgsx.IsNullable = true;
                colvarTgsx.IsPrimaryKey = false;
                colvarTgsx.IsForeignKey = false;
                colvarTgsx.IsReadOnly = false;
                
                schema.Columns.Add(colvarTgsx);
                
                TableSchema.TableColumn colvarWlbw = new TableSchema.TableColumn(schema);
                colvarWlbw.ColumnName = "WLBW";
                colvarWlbw.DataType = DbType.AnsiString;
                colvarWlbw.MaxLength = 255;
                colvarWlbw.AutoIncrement = false;
                colvarWlbw.IsNullable = true;
                colvarWlbw.IsPrimaryKey = false;
                colvarWlbw.IsForeignKey = false;
                colvarWlbw.IsReadOnly = false;
                
                schema.Columns.Add(colvarWlbw);
                
                TableSchema.TableColumn colvarCutternum = new TableSchema.TableColumn(schema);
                colvarCutternum.ColumnName = "CUTTERNUM";
                colvarCutternum.DataType = DbType.Int32;
                colvarCutternum.MaxLength = 0;
                colvarCutternum.AutoIncrement = false;
                colvarCutternum.IsNullable = true;
                colvarCutternum.IsPrimaryKey = false;
                colvarCutternum.IsForeignKey = false;
                colvarCutternum.IsReadOnly = false;
                
                schema.Columns.Add(colvarCutternum);
                
                TableSchema.TableColumn colvarCutdate = new TableSchema.TableColumn(schema);
                colvarCutdate.ColumnName = "CUTDATE";
                colvarCutdate.DataType = DbType.AnsiString;
                colvarCutdate.MaxLength = 10;
                colvarCutdate.AutoIncrement = false;
                colvarCutdate.IsNullable = true;
                colvarCutdate.IsPrimaryKey = false;
                colvarCutdate.IsForeignKey = false;
                colvarCutdate.IsReadOnly = false;
                
                schema.Columns.Add(colvarCutdate);
                
                TableSchema.TableColumn colvarCuttime = new TableSchema.TableColumn(schema);
                colvarCuttime.ColumnName = "CUTTIME";
                colvarCuttime.DataType = DbType.AnsiString;
                colvarCuttime.MaxLength = 11;
                colvarCuttime.AutoIncrement = false;
                colvarCuttime.IsNullable = true;
                colvarCuttime.IsPrimaryKey = false;
                colvarCuttime.IsForeignKey = false;
                colvarCuttime.IsReadOnly = false;
                
                schema.Columns.Add(colvarCuttime);
                
                TableSchema.TableColumn colvarFilestatus = new TableSchema.TableColumn(schema);
                colvarFilestatus.ColumnName = "FILESTATUS";
                colvarFilestatus.DataType = DbType.AnsiString;
                colvarFilestatus.MaxLength = 4;
                colvarFilestatus.AutoIncrement = false;
                colvarFilestatus.IsNullable = true;
                colvarFilestatus.IsPrimaryKey = false;
                colvarFilestatus.IsForeignKey = false;
                colvarFilestatus.IsReadOnly = false;
                
                schema.Columns.Add(colvarFilestatus);
                
                TableSchema.TableColumn colvarMatstatus = new TableSchema.TableColumn(schema);
                colvarMatstatus.ColumnName = "MATSTATUS";
                colvarMatstatus.DataType = DbType.AnsiString;
                colvarMatstatus.MaxLength = 4;
                colvarMatstatus.AutoIncrement = false;
                colvarMatstatus.IsNullable = true;
                colvarMatstatus.IsPrimaryKey = false;
                colvarMatstatus.IsForeignKey = false;
                colvarMatstatus.IsReadOnly = false;
                
                schema.Columns.Add(colvarMatstatus);
                
                TableSchema.TableColumn colvarMatlength = new TableSchema.TableColumn(schema);
                colvarMatlength.ColumnName = "MATLENGTH";
                colvarMatlength.DataType = DbType.AnsiString;
                colvarMatlength.MaxLength = 10;
                colvarMatlength.AutoIncrement = false;
                colvarMatlength.IsNullable = true;
                colvarMatlength.IsPrimaryKey = false;
                colvarMatlength.IsForeignKey = false;
                colvarMatlength.IsReadOnly = false;
                
                schema.Columns.Add(colvarMatlength);
                
                TableSchema.TableColumn colvarCutstatus = new TableSchema.TableColumn(schema);
                colvarCutstatus.ColumnName = "CUTSTATUS";
                colvarCutstatus.DataType = DbType.AnsiString;
                colvarCutstatus.MaxLength = 4;
                colvarCutstatus.AutoIncrement = false;
                colvarCutstatus.IsNullable = true;
                colvarCutstatus.IsPrimaryKey = false;
                colvarCutstatus.IsForeignKey = false;
                colvarCutstatus.IsReadOnly = false;
                
                schema.Columns.Add(colvarCutstatus);
                
                TableSchema.TableColumn colvarStatusdate = new TableSchema.TableColumn(schema);
                colvarStatusdate.ColumnName = "STATUSDATE";
                colvarStatusdate.DataType = DbType.DateTime;
                colvarStatusdate.MaxLength = 0;
                colvarStatusdate.AutoIncrement = false;
                colvarStatusdate.IsNullable = true;
                colvarStatusdate.IsPrimaryKey = false;
                colvarStatusdate.IsForeignKey = false;
                colvarStatusdate.IsReadOnly = false;
                
                schema.Columns.Add(colvarStatusdate);
                
                TableSchema.TableColumn colvarCuttername = new TableSchema.TableColumn(schema);
                colvarCuttername.ColumnName = "CUTTERNAME";
                colvarCuttername.DataType = DbType.AnsiString;
                colvarCuttername.MaxLength = 30;
                colvarCuttername.AutoIncrement = false;
                colvarCuttername.IsNullable = true;
                colvarCuttername.IsPrimaryKey = false;
                colvarCuttername.IsForeignKey = false;
                colvarCuttername.IsReadOnly = false;
                
                schema.Columns.Add(colvarCuttername);
                
                TableSchema.TableColumn colvarIsaps = new TableSchema.TableColumn(schema);
                colvarIsaps.ColumnName = "ISAPS";
                colvarIsaps.DataType = DbType.Boolean;
                colvarIsaps.MaxLength = 0;
                colvarIsaps.AutoIncrement = false;
                colvarIsaps.IsNullable = true;
                colvarIsaps.IsPrimaryKey = false;
                colvarIsaps.IsForeignKey = false;
                colvarIsaps.IsReadOnly = false;
                
                schema.Columns.Add(colvarIsaps);
                
                TableSchema.TableColumn colvarTs = new TableSchema.TableColumn(schema);
                colvarTs.ColumnName = "TS";
                colvarTs.DataType = DbType.AnsiString;
                colvarTs.MaxLength = 50;
                colvarTs.AutoIncrement = false;
                colvarTs.IsNullable = true;
                colvarTs.IsPrimaryKey = false;
                colvarTs.IsForeignKey = false;
                colvarTs.IsReadOnly = false;
                
                schema.Columns.Add(colvarTs);
                
                
                BaseSchema = schema;
                //add this schema to the provider
                //so we can query it later
                DataService.Providers["Nowthwin"].AddSchema("V_Plan_Detail",schema);
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
	    public VPlanDetail()
	    {
            SetSQLProps();
            SetDefaults();
            MarkNew();
        }
        public VPlanDetail(bool useDatabaseDefaults)
	    {
		    SetSQLProps();
		    if(useDatabaseDefaults)
		    {
				ForceDefaults();
			}
			MarkNew();
	    }
	    
	    public VPlanDetail(object keyID)
	    {
		    SetSQLProps();
		    LoadByKey(keyID);
	    }
    	 
	    public VPlanDetail(string columnName, object columnValue)
        {
            SetSQLProps();
            LoadByParam(columnName,columnValue);
        }
        
	    #endregion
	    
	    #region Props
	    
          
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
	      
        [XmlAttribute("Sccjjq")]
        [Bindable(true)]
        public DateTime? Sccjjq 
	    {
		    get
		    {
			    return GetColumnValue<DateTime?>("SCCJJQ");
		    }
            set 
		    {
			    SetColumnValue("SCCJJQ", value);
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
	      
        [XmlAttribute("Schtbh")]
        [Bindable(true)]
        public string Schtbh 
	    {
		    get
		    {
			    return GetColumnValue<string>("SCHTBH");
		    }
            set 
		    {
			    SetColumnValue("SCHTBH", value);
            }
        }
	      
        [XmlAttribute("Scggdh")]
        [Bindable(true)]
        public string Scggdh 
	    {
		    get
		    {
			    return GetColumnValue<string>("SCGGDH");
		    }
            set 
		    {
			    SetColumnValue("SCGGDH", value);
            }
        }
	      
        [XmlAttribute("Khddbh")]
        [Bindable(true)]
        public string Khddbh 
	    {
		    get
		    {
			    return GetColumnValue<string>("KHDDBH");
		    }
            set 
		    {
			    SetColumnValue("KHDDBH", value);
            }
        }
	      
        [XmlAttribute("Sczsdl")]
        [Bindable(true)]
        public string Sczsdl 
	    {
		    get
		    {
			    return GetColumnValue<string>("SCZSDL");
		    }
            set 
		    {
			    SetColumnValue("SCZSDL", value);
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
	      
        [XmlAttribute("Wlhy")]
        [Bindable(true)]
        public decimal? Wlhy 
	    {
		    get
		    {
			    return GetColumnValue<decimal?>("WLHY");
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
	      
        [XmlAttribute("Cutternum")]
        [Bindable(true)]
        public int? Cutternum 
	    {
		    get
		    {
			    return GetColumnValue<int?>("CUTTERNUM");
		    }
            set 
		    {
			    SetColumnValue("CUTTERNUM", value);
            }
        }
	      
        [XmlAttribute("Cutdate")]
        [Bindable(true)]
        public string Cutdate 
	    {
		    get
		    {
			    return GetColumnValue<string>("CUTDATE");
		    }
            set 
		    {
			    SetColumnValue("CUTDATE", value);
            }
        }
	      
        [XmlAttribute("Cuttime")]
        [Bindable(true)]
        public string Cuttime 
	    {
		    get
		    {
			    return GetColumnValue<string>("CUTTIME");
		    }
            set 
		    {
			    SetColumnValue("CUTTIME", value);
            }
        }
	      
        [XmlAttribute("Filestatus")]
        [Bindable(true)]
        public string Filestatus 
	    {
		    get
		    {
			    return GetColumnValue<string>("FILESTATUS");
		    }
            set 
		    {
			    SetColumnValue("FILESTATUS", value);
            }
        }
	      
        [XmlAttribute("Matstatus")]
        [Bindable(true)]
        public string Matstatus 
	    {
		    get
		    {
			    return GetColumnValue<string>("MATSTATUS");
		    }
            set 
		    {
			    SetColumnValue("MATSTATUS", value);
            }
        }
	      
        [XmlAttribute("Matlength")]
        [Bindable(true)]
        public string Matlength 
	    {
		    get
		    {
			    return GetColumnValue<string>("MATLENGTH");
		    }
            set 
		    {
			    SetColumnValue("MATLENGTH", value);
            }
        }
	      
        [XmlAttribute("Cutstatus")]
        [Bindable(true)]
        public string Cutstatus 
	    {
		    get
		    {
			    return GetColumnValue<string>("CUTSTATUS");
		    }
            set 
		    {
			    SetColumnValue("CUTSTATUS", value);
            }
        }
	      
        [XmlAttribute("Statusdate")]
        [Bindable(true)]
        public DateTime? Statusdate 
	    {
		    get
		    {
			    return GetColumnValue<DateTime?>("STATUSDATE");
		    }
            set 
		    {
			    SetColumnValue("STATUSDATE", value);
            }
        }
	      
        [XmlAttribute("Cuttername")]
        [Bindable(true)]
        public string Cuttername 
	    {
		    get
		    {
			    return GetColumnValue<string>("CUTTERNAME");
		    }
            set 
		    {
			    SetColumnValue("CUTTERNAME", value);
            }
        }
	      
        [XmlAttribute("Isaps")]
        [Bindable(true)]
        public bool? Isaps 
	    {
		    get
		    {
			    return GetColumnValue<bool?>("ISAPS");
		    }
            set 
		    {
			    SetColumnValue("ISAPS", value);
            }
        }
	      
        [XmlAttribute("Ts")]
        [Bindable(true)]
        public string Ts 
	    {
		    get
		    {
			    return GetColumnValue<string>("TS");
		    }
            set 
		    {
			    SetColumnValue("TS", value);
            }
        }
	    
	    #endregion
    
	    #region Columns Struct
	    public struct Columns
	    {
		    
		    
            public static string Sczsbh = @"SCZSBH";
            
            public static string Scgcmc = @"SCGCMC";
            
            public static string Scxdrq = @"SCXDRQ";
            
            public static string Sccjjq = @"SCCJJQ";
            
            public static string Status = @"STATUS";
            
            public static string Schtbh = @"SCHTBH";
            
            public static string Scggdh = @"SCGGDH";
            
            public static string Khddbh = @"KHDDBH";
            
            public static string Sczsdl = @"SCZSDL";
            
            public static string Gyfl = @"GYFL";
            
            public static string Sldl = @"SLDL";
            
            public static string Wlxh = @"WLXH";
            
            public static string Wlbm = @"WLBM";
            
            public static string Wlhy = @"WLHY";
            
            public static string Tgsx = @"TGSX";
            
            public static string Wlbw = @"WLBW";
            
            public static string Cutternum = @"CUTTERNUM";
            
            public static string Cutdate = @"CUTDATE";
            
            public static string Cuttime = @"CUTTIME";
            
            public static string Filestatus = @"FILESTATUS";
            
            public static string Matstatus = @"MATSTATUS";
            
            public static string Matlength = @"MATLENGTH";
            
            public static string Cutstatus = @"CUTSTATUS";
            
            public static string Statusdate = @"STATUSDATE";
            
            public static string Cuttername = @"CUTTERNAME";
            
            public static string Isaps = @"ISAPS";
            
            public static string Ts = @"TS";
            
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