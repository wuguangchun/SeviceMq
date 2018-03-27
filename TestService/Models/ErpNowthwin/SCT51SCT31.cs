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
    /// Strongly-typed collection for the SCT51SCT31 class.
    /// </summary>
    [Serializable]
    public partial class SCT51SCT31Collection : ReadOnlyList<SCT51SCT31, SCT51SCT31Collection>
    {        
        public SCT51SCT31Collection() {}
    }
    /// <summary>
    /// This is  Read-only wrapper class for the SCT51_SCT31 view.
    /// </summary>
    [Serializable]
    public partial class SCT51SCT31 : ReadOnlyRecord<SCT51SCT31>, IReadOnlyRecord
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
                TableSchema.Table schema = new TableSchema.Table("SCT51_SCT31", TableType.View, DataService.GetInstance("ErpNowthwin"));
                schema.Columns = new TableSchema.TableColumnCollection();
                schema.SchemaName = @"FYERP";
                //columns
                
                TableSchema.TableColumn colvarScggdh = new TableSchema.TableColumn(schema);
                colvarScggdh.ColumnName = "SCGGDH";
                colvarScggdh.DataType = DbType.String;
                colvarScggdh.MaxLength = 12;
                colvarScggdh.AutoIncrement = false;
                colvarScggdh.IsNullable = false;
                colvarScggdh.IsPrimaryKey = false;
                colvarScggdh.IsForeignKey = false;
                colvarScggdh.IsReadOnly = false;
                
                schema.Columns.Add(colvarScggdh);
                
                TableSchema.TableColumn colvarSchtbh = new TableSchema.TableColumn(schema);
                colvarSchtbh.ColumnName = "SCHTBH";
                colvarSchtbh.DataType = DbType.String;
                colvarSchtbh.MaxLength = 12;
                colvarSchtbh.AutoIncrement = false;
                colvarSchtbh.IsNullable = true;
                colvarSchtbh.IsPrimaryKey = false;
                colvarSchtbh.IsForeignKey = false;
                colvarSchtbh.IsReadOnly = false;
                
                schema.Columns.Add(colvarSchtbh);
                
                TableSchema.TableColumn colvarXtwldm = new TableSchema.TableColumn(schema);
                colvarXtwldm.ColumnName = "XTWLDM";
                colvarXtwldm.DataType = DbType.String;
                colvarXtwldm.MaxLength = 8;
                colvarXtwldm.AutoIncrement = false;
                colvarXtwldm.IsNullable = true;
                colvarXtwldm.IsPrimaryKey = false;
                colvarXtwldm.IsForeignKey = false;
                colvarXtwldm.IsReadOnly = false;
                
                schema.Columns.Add(colvarXtwldm);
                
                TableSchema.TableColumn colvarSckhxm = new TableSchema.TableColumn(schema);
                colvarSckhxm.ColumnName = "SCKHXM";
                colvarSckhxm.DataType = DbType.String;
                colvarSckhxm.MaxLength = 100;
                colvarSckhxm.AutoIncrement = false;
                colvarSckhxm.IsNullable = true;
                colvarSckhxm.IsPrimaryKey = false;
                colvarSckhxm.IsForeignKey = false;
                colvarSckhxm.IsReadOnly = false;
                
                schema.Columns.Add(colvarSckhxm);
                
                TableSchema.TableColumn colvarSckhdz = new TableSchema.TableColumn(schema);
                colvarSckhdz.ColumnName = "SCKHDZ";
                colvarSckhdz.DataType = DbType.String;
                colvarSckhdz.MaxLength = 60;
                colvarSckhdz.AutoIncrement = false;
                colvarSckhdz.IsNullable = true;
                colvarSckhdz.IsPrimaryKey = false;
                colvarSckhdz.IsForeignKey = false;
                colvarSckhdz.IsReadOnly = false;
                
                schema.Columns.Add(colvarSckhdz);
                
                TableSchema.TableColumn colvarScyzbm = new TableSchema.TableColumn(schema);
                colvarScyzbm.ColumnName = "SCYZBM";
                colvarScyzbm.DataType = DbType.String;
                colvarScyzbm.MaxLength = 8;
                colvarScyzbm.AutoIncrement = false;
                colvarScyzbm.IsNullable = true;
                colvarScyzbm.IsPrimaryKey = false;
                colvarScyzbm.IsForeignKey = false;
                colvarScyzbm.IsReadOnly = false;
                
                schema.Columns.Add(colvarScyzbm);
                
                TableSchema.TableColumn colvarScgddh = new TableSchema.TableColumn(schema);
                colvarScgddh.ColumnName = "SCGDDH";
                colvarScgddh.DataType = DbType.String;
                colvarScgddh.MaxLength = 20;
                colvarScgddh.AutoIncrement = false;
                colvarScgddh.IsNullable = true;
                colvarScgddh.IsPrimaryKey = false;
                colvarScgddh.IsForeignKey = false;
                colvarScgddh.IsReadOnly = false;
                
                schema.Columns.Add(colvarScgddh);
                
                TableSchema.TableColumn colvarScyddh = new TableSchema.TableColumn(schema);
                colvarScyddh.ColumnName = "SCYDDH";
                colvarScyddh.DataType = DbType.String;
                colvarScyddh.MaxLength = 20;
                colvarScyddh.AutoIncrement = false;
                colvarScyddh.IsNullable = true;
                colvarScyddh.IsPrimaryKey = false;
                colvarScyddh.IsForeignKey = false;
                colvarScyddh.IsReadOnly = false;
                
                schema.Columns.Add(colvarScyddh);
                
                TableSchema.TableColumn colvarSchybh = new TableSchema.TableColumn(schema);
                colvarSchybh.ColumnName = "SCHYBH";
                colvarSchybh.DataType = DbType.String;
                colvarSchybh.MaxLength = 12;
                colvarSchybh.AutoIncrement = false;
                colvarSchybh.IsNullable = true;
                colvarSchybh.IsPrimaryKey = false;
                colvarSchybh.IsForeignKey = false;
                colvarSchybh.IsReadOnly = false;
                
                schema.Columns.Add(colvarSchybh);
                
                TableSchema.TableColumn colvarScjgry = new TableSchema.TableColumn(schema);
                colvarScjgry.ColumnName = "SCJGRY";
                colvarScjgry.DataType = DbType.String;
                colvarScjgry.MaxLength = 10;
                colvarScjgry.AutoIncrement = false;
                colvarScjgry.IsNullable = true;
                colvarScjgry.IsPrimaryKey = false;
                colvarScjgry.IsForeignKey = false;
                colvarScjgry.IsReadOnly = false;
                
                schema.Columns.Add(colvarScjgry);
                
                TableSchema.TableColumn colvarXtbmdm = new TableSchema.TableColumn(schema);
                colvarXtbmdm.ColumnName = "XTBMDM";
                colvarXtbmdm.DataType = DbType.String;
                colvarXtbmdm.MaxLength = 8;
                colvarXtbmdm.AutoIncrement = false;
                colvarXtbmdm.IsNullable = true;
                colvarXtbmdm.IsPrimaryKey = false;
                colvarXtbmdm.IsForeignKey = false;
                colvarXtbmdm.IsReadOnly = false;
                
                schema.Columns.Add(colvarXtbmdm);
                
                TableSchema.TableColumn colvarScywry = new TableSchema.TableColumn(schema);
                colvarScywry.ColumnName = "SCYWRY";
                colvarScywry.DataType = DbType.String;
                colvarScywry.MaxLength = 8;
                colvarScywry.AutoIncrement = false;
                colvarScywry.IsNullable = true;
                colvarScywry.IsPrimaryKey = false;
                colvarScywry.IsForeignKey = false;
                colvarScywry.IsReadOnly = false;
                
                schema.Columns.Add(colvarScywry);
                
                TableSchema.TableColumn colvarSclrrq = new TableSchema.TableColumn(schema);
                colvarSclrrq.ColumnName = "SCLRRQ";
                colvarSclrrq.DataType = DbType.DateTime;
                colvarSclrrq.MaxLength = 0;
                colvarSclrrq.AutoIncrement = false;
                colvarSclrrq.IsNullable = true;
                colvarSclrrq.IsPrimaryKey = false;
                colvarSclrrq.IsForeignKey = false;
                colvarSclrrq.IsReadOnly = false;
                
                schema.Columns.Add(colvarSclrrq);
                
                TableSchema.TableColumn colvarSclrry = new TableSchema.TableColumn(schema);
                colvarSclrry.ColumnName = "SCLRRY";
                colvarSclrry.DataType = DbType.String;
                colvarSclrry.MaxLength = 8;
                colvarSclrry.AutoIncrement = false;
                colvarSclrry.IsNullable = true;
                colvarSclrry.IsPrimaryKey = false;
                colvarSclrry.IsForeignKey = false;
                colvarSclrry.IsReadOnly = false;
                
                schema.Columns.Add(colvarSclrry);
                
                TableSchema.TableColumn colvarScshrq = new TableSchema.TableColumn(schema);
                colvarScshrq.ColumnName = "SCSHRQ";
                colvarScshrq.DataType = DbType.DateTime;
                colvarScshrq.MaxLength = 0;
                colvarScshrq.AutoIncrement = false;
                colvarScshrq.IsNullable = true;
                colvarScshrq.IsPrimaryKey = false;
                colvarScshrq.IsForeignKey = false;
                colvarScshrq.IsReadOnly = false;
                
                schema.Columns.Add(colvarScshrq);
                
                TableSchema.TableColumn colvarScshry = new TableSchema.TableColumn(schema);
                colvarScshry.ColumnName = "SCSHRY";
                colvarScshry.DataType = DbType.String;
                colvarScshry.MaxLength = 8;
                colvarScshry.AutoIncrement = false;
                colvarScshry.IsNullable = true;
                colvarScshry.IsPrimaryKey = false;
                colvarScshry.IsForeignKey = false;
                colvarScshry.IsReadOnly = false;
                
                schema.Columns.Add(colvarScshry);
                
                TableSchema.TableColumn colvarScdjzt = new TableSchema.TableColumn(schema);
                colvarScdjzt.ColumnName = "SCDJZT";
                colvarScdjzt.DataType = DbType.String;
                colvarScdjzt.MaxLength = 1;
                colvarScdjzt.AutoIncrement = false;
                colvarScdjzt.IsNullable = true;
                colvarScdjzt.IsPrimaryKey = false;
                colvarScdjzt.IsForeignKey = false;
                colvarScdjzt.IsReadOnly = false;
                
                schema.Columns.Add(colvarScdjzt);
                
                TableSchema.TableColumn colvarSclybz = new TableSchema.TableColumn(schema);
                colvarSclybz.ColumnName = "SCLYBZ";
                colvarSclybz.DataType = DbType.String;
                colvarSclybz.MaxLength = 1;
                colvarSclybz.AutoIncrement = false;
                colvarSclybz.IsNullable = true;
                colvarSclybz.IsPrimaryKey = false;
                colvarSclybz.IsForeignKey = false;
                colvarSclybz.IsReadOnly = false;
                
                schema.Columns.Add(colvarSclybz);
                
                TableSchema.TableColumn colvarScggbz = new TableSchema.TableColumn(schema);
                colvarScggbz.ColumnName = "SCGGBZ";
                colvarScggbz.DataType = DbType.String;
                colvarScggbz.MaxLength = 1000;
                colvarScggbz.AutoIncrement = false;
                colvarScggbz.IsNullable = true;
                colvarScggbz.IsPrimaryKey = false;
                colvarScggbz.IsForeignKey = false;
                colvarScggbz.IsReadOnly = false;
                
                schema.Columns.Add(colvarScggbz);
                
                TableSchema.TableColumn colvarScqdrq = new TableSchema.TableColumn(schema);
                colvarScqdrq.ColumnName = "SCQDRQ";
                colvarScqdrq.DataType = DbType.DateTime;
                colvarScqdrq.MaxLength = 0;
                colvarScqdrq.AutoIncrement = false;
                colvarScqdrq.IsNullable = true;
                colvarScqdrq.IsPrimaryKey = false;
                colvarScqdrq.IsForeignKey = false;
                colvarScqdrq.IsReadOnly = false;
                
                schema.Columns.Add(colvarScqdrq);
                
                TableSchema.TableColumn colvarScjhrq = new TableSchema.TableColumn(schema);
                colvarScjhrq.ColumnName = "SCJHRQ";
                colvarScjhrq.DataType = DbType.DateTime;
                colvarScjhrq.MaxLength = 0;
                colvarScjhrq.AutoIncrement = false;
                colvarScjhrq.IsNullable = true;
                colvarScjhrq.IsPrimaryKey = false;
                colvarScjhrq.IsForeignKey = false;
                colvarScjhrq.IsReadOnly = false;
                
                schema.Columns.Add(colvarScjhrq);
                
                TableSchema.TableColumn colvarScglbz = new TableSchema.TableColumn(schema);
                colvarScglbz.ColumnName = "SCGLBZ";
                colvarScglbz.DataType = DbType.String;
                colvarScglbz.MaxLength = 1;
                colvarScglbz.AutoIncrement = false;
                colvarScglbz.IsNullable = true;
                colvarScglbz.IsPrimaryKey = false;
                colvarScglbz.IsForeignKey = false;
                colvarScglbz.IsReadOnly = false;
                
                schema.Columns.Add(colvarScglbz);
                
                TableSchema.TableColumn colvarScssrq = new TableSchema.TableColumn(schema);
                colvarScssrq.ColumnName = "SCSSRQ";
                colvarScssrq.DataType = DbType.DateTime;
                colvarScssrq.MaxLength = 0;
                colvarScssrq.AutoIncrement = false;
                colvarScssrq.IsNullable = true;
                colvarScssrq.IsPrimaryKey = false;
                colvarScssrq.IsForeignKey = false;
                colvarScssrq.IsReadOnly = false;
                
                schema.Columns.Add(colvarScssrq);
                
                TableSchema.TableColumn colvarScshyj = new TableSchema.TableColumn(schema);
                colvarScshyj.ColumnName = "SCSHYJ";
                colvarScshyj.DataType = DbType.String;
                colvarScshyj.MaxLength = 255;
                colvarScshyj.AutoIncrement = false;
                colvarScshyj.IsNullable = true;
                colvarScshyj.IsPrimaryKey = false;
                colvarScshyj.IsForeignKey = false;
                colvarScshyj.IsReadOnly = false;
                
                schema.Columns.Add(colvarScshyj);
                
                TableSchema.TableColumn colvarScyspd = new TableSchema.TableColumn(schema);
                colvarScyspd.ColumnName = "SCYSPD";
                colvarScyspd.DataType = DbType.String;
                colvarScyspd.MaxLength = 12;
                colvarScyspd.AutoIncrement = false;
                colvarScyspd.IsNullable = true;
                colvarScyspd.IsPrimaryKey = false;
                colvarScyspd.IsForeignKey = false;
                colvarScyspd.IsReadOnly = false;
                
                schema.Columns.Add(colvarScyspd);
                
                TableSchema.TableColumn colvarScggxh = new TableSchema.TableColumn(schema);
                colvarScggxh.ColumnName = "SCGGXH";
                colvarScggxh.DataType = DbType.Decimal;
                colvarScggxh.MaxLength = 0;
                colvarScggxh.AutoIncrement = false;
                colvarScggxh.IsNullable = false;
                colvarScggxh.IsPrimaryKey = false;
                colvarScggxh.IsForeignKey = false;
                colvarScggxh.IsReadOnly = false;
                
                schema.Columns.Add(colvarScggxh);
                
                TableSchema.TableColumn colvarXtwpks = new TableSchema.TableColumn(schema);
                colvarXtwpks.ColumnName = "XTWPKS";
                colvarXtwpks.DataType = DbType.String;
                colvarXtwpks.MaxLength = 20;
                colvarXtwpks.AutoIncrement = false;
                colvarXtwpks.IsNullable = true;
                colvarXtwpks.IsPrimaryKey = false;
                colvarXtwpks.IsForeignKey = false;
                colvarXtwpks.IsReadOnly = false;
                
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
                
                schema.Columns.Add(colvarXtwpys);
                
                TableSchema.TableColumn colvarXtxmdm = new TableSchema.TableColumn(schema);
                colvarXtxmdm.ColumnName = "XTXMDM";
                colvarXtxmdm.DataType = DbType.String;
                colvarXtxmdm.MaxLength = 10;
                colvarXtxmdm.AutoIncrement = false;
                colvarXtxmdm.IsNullable = true;
                colvarXtxmdm.IsPrimaryKey = false;
                colvarXtxmdm.IsForeignKey = false;
                colvarXtxmdm.IsReadOnly = false;
                
                schema.Columns.Add(colvarXtxmdm);
                
                TableSchema.TableColumn colvarSchtsl = new TableSchema.TableColumn(schema);
                colvarSchtsl.ColumnName = "SCHTSL";
                colvarSchtsl.DataType = DbType.String;
                colvarSchtsl.MaxLength = 44;
                colvarSchtsl.AutoIncrement = false;
                colvarSchtsl.IsNullable = true;
                colvarSchtsl.IsPrimaryKey = false;
                colvarSchtsl.IsForeignKey = false;
                colvarSchtsl.IsReadOnly = false;
                
                schema.Columns.Add(colvarSchtsl);
                
                TableSchema.TableColumn colvarScjhdd = new TableSchema.TableColumn(schema);
                colvarScjhdd.ColumnName = "SCJHDD";
                colvarScjhdd.DataType = DbType.String;
                colvarScjhdd.MaxLength = 4000;
                colvarScjhdd.AutoIncrement = false;
                colvarScjhdd.IsNullable = true;
                colvarScjhdd.IsPrimaryKey = false;
                colvarScjhdd.IsForeignKey = false;
                colvarScjhdd.IsReadOnly = false;
                
                schema.Columns.Add(colvarScjhdd);
                
                TableSchema.TableColumn colvarWPSXLB19 = new TableSchema.TableColumn(schema);
                colvarWPSXLB19.ColumnName = "WPSXLB19";
                colvarWPSXLB19.DataType = DbType.String;
                colvarWPSXLB19.MaxLength = 20;
                colvarWPSXLB19.AutoIncrement = false;
                colvarWPSXLB19.IsNullable = true;
                colvarWPSXLB19.IsPrimaryKey = false;
                colvarWPSXLB19.IsForeignKey = false;
                colvarWPSXLB19.IsReadOnly = false;
                
                schema.Columns.Add(colvarWPSXLB19);
                
                
                BaseSchema = schema;
                //add this schema to the provider
                //so we can query it later
                DataService.Providers["ErpNowthwin"].AddSchema("SCT51_SCT31",schema);
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
	    public SCT51SCT31()
	    {
            SetSQLProps();
            SetDefaults();
            MarkNew();
        }
        public SCT51SCT31(bool useDatabaseDefaults)
	    {
		    SetSQLProps();
		    if(useDatabaseDefaults)
		    {
				ForceDefaults();
			}
			MarkNew();
	    }
	    
	    public SCT51SCT31(object keyID)
	    {
		    SetSQLProps();
		    LoadByKey(keyID);
	    }
    	 
	    public SCT51SCT31(string columnName, object columnValue)
        {
            SetSQLProps();
            LoadByParam(columnName,columnValue);
        }
        
	    #endregion
	    
	    #region Props
	    
          
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
	      
        [XmlAttribute("Xtwldm")]
        [Bindable(true)]
        public string Xtwldm 
	    {
		    get
		    {
			    return GetColumnValue<string>("XTWLDM");
		    }
            set 
		    {
			    SetColumnValue("XTWLDM", value);
            }
        }
	      
        [XmlAttribute("Sckhxm")]
        [Bindable(true)]
        public string Sckhxm 
	    {
		    get
		    {
			    return GetColumnValue<string>("SCKHXM");
		    }
            set 
		    {
			    SetColumnValue("SCKHXM", value);
            }
        }
	      
        [XmlAttribute("Sckhdz")]
        [Bindable(true)]
        public string Sckhdz 
	    {
		    get
		    {
			    return GetColumnValue<string>("SCKHDZ");
		    }
            set 
		    {
			    SetColumnValue("SCKHDZ", value);
            }
        }
	      
        [XmlAttribute("Scyzbm")]
        [Bindable(true)]
        public string Scyzbm 
	    {
		    get
		    {
			    return GetColumnValue<string>("SCYZBM");
		    }
            set 
		    {
			    SetColumnValue("SCYZBM", value);
            }
        }
	      
        [XmlAttribute("Scgddh")]
        [Bindable(true)]
        public string Scgddh 
	    {
		    get
		    {
			    return GetColumnValue<string>("SCGDDH");
		    }
            set 
		    {
			    SetColumnValue("SCGDDH", value);
            }
        }
	      
        [XmlAttribute("Scyddh")]
        [Bindable(true)]
        public string Scyddh 
	    {
		    get
		    {
			    return GetColumnValue<string>("SCYDDH");
		    }
            set 
		    {
			    SetColumnValue("SCYDDH", value);
            }
        }
	      
        [XmlAttribute("Schybh")]
        [Bindable(true)]
        public string Schybh 
	    {
		    get
		    {
			    return GetColumnValue<string>("SCHYBH");
		    }
            set 
		    {
			    SetColumnValue("SCHYBH", value);
            }
        }
	      
        [XmlAttribute("Scjgry")]
        [Bindable(true)]
        public string Scjgry 
	    {
		    get
		    {
			    return GetColumnValue<string>("SCJGRY");
		    }
            set 
		    {
			    SetColumnValue("SCJGRY", value);
            }
        }
	      
        [XmlAttribute("Xtbmdm")]
        [Bindable(true)]
        public string Xtbmdm 
	    {
		    get
		    {
			    return GetColumnValue<string>("XTBMDM");
		    }
            set 
		    {
			    SetColumnValue("XTBMDM", value);
            }
        }
	      
        [XmlAttribute("Scywry")]
        [Bindable(true)]
        public string Scywry 
	    {
		    get
		    {
			    return GetColumnValue<string>("SCYWRY");
		    }
            set 
		    {
			    SetColumnValue("SCYWRY", value);
            }
        }
	      
        [XmlAttribute("Sclrrq")]
        [Bindable(true)]
        public DateTime? Sclrrq 
	    {
		    get
		    {
			    return GetColumnValue<DateTime?>("SCLRRQ");
		    }
            set 
		    {
			    SetColumnValue("SCLRRQ", value);
            }
        }
	      
        [XmlAttribute("Sclrry")]
        [Bindable(true)]
        public string Sclrry 
	    {
		    get
		    {
			    return GetColumnValue<string>("SCLRRY");
		    }
            set 
		    {
			    SetColumnValue("SCLRRY", value);
            }
        }
	      
        [XmlAttribute("Scshrq")]
        [Bindable(true)]
        public DateTime? Scshrq 
	    {
		    get
		    {
			    return GetColumnValue<DateTime?>("SCSHRQ");
		    }
            set 
		    {
			    SetColumnValue("SCSHRQ", value);
            }
        }
	      
        [XmlAttribute("Scshry")]
        [Bindable(true)]
        public string Scshry 
	    {
		    get
		    {
			    return GetColumnValue<string>("SCSHRY");
		    }
            set 
		    {
			    SetColumnValue("SCSHRY", value);
            }
        }
	      
        [XmlAttribute("Scdjzt")]
        [Bindable(true)]
        public string Scdjzt 
	    {
		    get
		    {
			    return GetColumnValue<string>("SCDJZT");
		    }
            set 
		    {
			    SetColumnValue("SCDJZT", value);
            }
        }
	      
        [XmlAttribute("Sclybz")]
        [Bindable(true)]
        public string Sclybz 
	    {
		    get
		    {
			    return GetColumnValue<string>("SCLYBZ");
		    }
            set 
		    {
			    SetColumnValue("SCLYBZ", value);
            }
        }
	      
        [XmlAttribute("Scggbz")]
        [Bindable(true)]
        public string Scggbz 
	    {
		    get
		    {
			    return GetColumnValue<string>("SCGGBZ");
		    }
            set 
		    {
			    SetColumnValue("SCGGBZ", value);
            }
        }
	      
        [XmlAttribute("Scqdrq")]
        [Bindable(true)]
        public DateTime? Scqdrq 
	    {
		    get
		    {
			    return GetColumnValue<DateTime?>("SCQDRQ");
		    }
            set 
		    {
			    SetColumnValue("SCQDRQ", value);
            }
        }
	      
        [XmlAttribute("Scjhrq")]
        [Bindable(true)]
        public DateTime? Scjhrq 
	    {
		    get
		    {
			    return GetColumnValue<DateTime?>("SCJHRQ");
		    }
            set 
		    {
			    SetColumnValue("SCJHRQ", value);
            }
        }
	      
        [XmlAttribute("Scglbz")]
        [Bindable(true)]
        public string Scglbz 
	    {
		    get
		    {
			    return GetColumnValue<string>("SCGLBZ");
		    }
            set 
		    {
			    SetColumnValue("SCGLBZ", value);
            }
        }
	      
        [XmlAttribute("Scssrq")]
        [Bindable(true)]
        public DateTime? Scssrq 
	    {
		    get
		    {
			    return GetColumnValue<DateTime?>("SCSSRQ");
		    }
            set 
		    {
			    SetColumnValue("SCSSRQ", value);
            }
        }
	      
        [XmlAttribute("Scshyj")]
        [Bindable(true)]
        public string Scshyj 
	    {
		    get
		    {
			    return GetColumnValue<string>("SCSHYJ");
		    }
            set 
		    {
			    SetColumnValue("SCSHYJ", value);
            }
        }
	      
        [XmlAttribute("Scyspd")]
        [Bindable(true)]
        public string Scyspd 
	    {
		    get
		    {
			    return GetColumnValue<string>("SCYSPD");
		    }
            set 
		    {
			    SetColumnValue("SCYSPD", value);
            }
        }
	      
        [XmlAttribute("Scggxh")]
        [Bindable(true)]
        public decimal Scggxh 
	    {
		    get
		    {
			    return GetColumnValue<decimal>("SCGGXH");
		    }
            set 
		    {
			    SetColumnValue("SCGGXH", value);
            }
        }
	      
        [XmlAttribute("Xtwpks")]
        [Bindable(true)]
        public string Xtwpks 
	    {
		    get
		    {
			    return GetColumnValue<string>("XTWPKS");
		    }
            set 
		    {
			    SetColumnValue("XTWPKS", value);
            }
        }
	      
        [XmlAttribute("Xtwpys")]
        [Bindable(true)]
        public string Xtwpys 
	    {
		    get
		    {
			    return GetColumnValue<string>("XTWPYS");
		    }
            set 
		    {
			    SetColumnValue("XTWPYS", value);
            }
        }
	      
        [XmlAttribute("Xtxmdm")]
        [Bindable(true)]
        public string Xtxmdm 
	    {
		    get
		    {
			    return GetColumnValue<string>("XTXMDM");
		    }
            set 
		    {
			    SetColumnValue("XTXMDM", value);
            }
        }
	      
        [XmlAttribute("Schtsl")]
        [Bindable(true)]
        public string Schtsl 
	    {
		    get
		    {
			    return GetColumnValue<string>("SCHTSL");
		    }
            set 
		    {
			    SetColumnValue("SCHTSL", value);
            }
        }
	      
        [XmlAttribute("Scjhdd")]
        [Bindable(true)]
        public string Scjhdd 
	    {
		    get
		    {
			    return GetColumnValue<string>("SCJHDD");
		    }
            set 
		    {
			    SetColumnValue("SCJHDD", value);
            }
        }
	      
        [XmlAttribute("WPSXLB19")]
        [Bindable(true)]
        public string WPSXLB19 
	    {
		    get
		    {
			    return GetColumnValue<string>("WPSXLB19");
		    }
            set 
		    {
			    SetColumnValue("WPSXLB19", value);
            }
        }
	    
	    #endregion
    
	    #region Columns Struct
	    public struct Columns
	    {
		    
		    
            public static string Scggdh = @"SCGGDH";
            
            public static string Schtbh = @"SCHTBH";
            
            public static string Xtwldm = @"XTWLDM";
            
            public static string Sckhxm = @"SCKHXM";
            
            public static string Sckhdz = @"SCKHDZ";
            
            public static string Scyzbm = @"SCYZBM";
            
            public static string Scgddh = @"SCGDDH";
            
            public static string Scyddh = @"SCYDDH";
            
            public static string Schybh = @"SCHYBH";
            
            public static string Scjgry = @"SCJGRY";
            
            public static string Xtbmdm = @"XTBMDM";
            
            public static string Scywry = @"SCYWRY";
            
            public static string Sclrrq = @"SCLRRQ";
            
            public static string Sclrry = @"SCLRRY";
            
            public static string Scshrq = @"SCSHRQ";
            
            public static string Scshry = @"SCSHRY";
            
            public static string Scdjzt = @"SCDJZT";
            
            public static string Sclybz = @"SCLYBZ";
            
            public static string Scggbz = @"SCGGBZ";
            
            public static string Scqdrq = @"SCQDRQ";
            
            public static string Scjhrq = @"SCJHRQ";
            
            public static string Scglbz = @"SCGLBZ";
            
            public static string Scssrq = @"SCSSRQ";
            
            public static string Scshyj = @"SCSHYJ";
            
            public static string Scyspd = @"SCYSPD";
            
            public static string Scggxh = @"SCGGXH";
            
            public static string Xtwpks = @"XTWPKS";
            
            public static string Xtwpys = @"XTWPYS";
            
            public static string Xtxmdm = @"XTXMDM";
            
            public static string Schtsl = @"SCHTSL";
            
            public static string Scjhdd = @"SCJHDD";
            
            public static string WPSXLB19 = @"WPSXLB19";
            
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
