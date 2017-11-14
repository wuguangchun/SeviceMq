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
    /// Strongly-typed collection for the VTzjh class.
    /// </summary>
    [Serializable]
    public partial class VTzjhCollection : ReadOnlyList<VTzjh, VTzjhCollection>
    {        
        public VTzjhCollection() {}
    }
    /// <summary>
    /// This is  Read-only wrapper class for the v_tzjh view.
    /// </summary>
    [Serializable]
    public partial class VTzjh : ReadOnlyRecord<VTzjh>, IReadOnlyRecord
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
                TableSchema.Table schema = new TableSchema.Table("v_tzjh", TableType.View, DataService.GetInstance("Nowthwin"));
                schema.Columns = new TableSchema.TableColumnCollection();
                schema.SchemaName = @"dbo";
                //columns
                
                TableSchema.TableColumn colvarScgydm = new TableSchema.TableColumn(schema);
                colvarScgydm.ColumnName = "SCGYDM";
                colvarScgydm.DataType = DbType.String;
                colvarScgydm.MaxLength = 4;
                colvarScgydm.AutoIncrement = false;
                colvarScgydm.IsNullable = true;
                colvarScgydm.IsPrimaryKey = false;
                colvarScgydm.IsForeignKey = false;
                colvarScgydm.IsReadOnly = false;
                
                schema.Columns.Add(colvarScgydm);
                
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
                
                TableSchema.TableColumn colvarSchtsl = new TableSchema.TableColumn(schema);
                colvarSchtsl.ColumnName = "SCHTSL";
                colvarSchtsl.DataType = DbType.String;
                colvarSchtsl.MaxLength = 384;
                colvarSchtsl.AutoIncrement = false;
                colvarSchtsl.IsNullable = true;
                colvarSchtsl.IsPrimaryKey = false;
                colvarSchtsl.IsForeignKey = false;
                colvarSchtsl.IsReadOnly = false;
                
                schema.Columns.Add(colvarSchtsl);
                
                TableSchema.TableColumn colvarSchtxh = new TableSchema.TableColumn(schema);
                colvarSchtxh.ColumnName = "SCHTXH";
                colvarSchtxh.DataType = DbType.String;
                colvarSchtxh.MaxLength = 384;
                colvarSchtxh.AutoIncrement = false;
                colvarSchtxh.IsNullable = true;
                colvarSchtxh.IsPrimaryKey = false;
                colvarSchtxh.IsForeignKey = false;
                colvarSchtxh.IsReadOnly = false;
                
                schema.Columns.Add(colvarSchtxh);
                
                TableSchema.TableColumn colvarXtwpmc = new TableSchema.TableColumn(schema);
                colvarXtwpmc.ColumnName = "XTWPMC";
                colvarXtwpmc.DataType = DbType.String;
                colvarXtwpmc.MaxLength = 100;
                colvarXtwpmc.AutoIncrement = false;
                colvarXtwpmc.IsNullable = true;
                colvarXtwpmc.IsPrimaryKey = false;
                colvarXtwpmc.IsForeignKey = false;
                colvarXtwpmc.IsReadOnly = false;
                
                schema.Columns.Add(colvarXtwpmc);
                
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
                
                TableSchema.TableColumn colvarPtfs = new TableSchema.TableColumn(schema);
                colvarPtfs.ColumnName = "PTFS";
                colvarPtfs.DataType = DbType.String;
                colvarPtfs.MaxLength = 255;
                colvarPtfs.AutoIncrement = false;
                colvarPtfs.IsNullable = true;
                colvarPtfs.IsPrimaryKey = false;
                colvarPtfs.IsForeignKey = false;
                colvarPtfs.IsReadOnly = false;
                
                schema.Columns.Add(colvarPtfs);
                
                
                BaseSchema = schema;
                //add this schema to the provider
                //so we can query it later
                DataService.Providers["Nowthwin"].AddSchema("v_tzjh",schema);
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
	    public VTzjh()
	    {
            SetSQLProps();
            SetDefaults();
            MarkNew();
        }
        public VTzjh(bool useDatabaseDefaults)
	    {
		    SetSQLProps();
		    if(useDatabaseDefaults)
		    {
				ForceDefaults();
			}
			MarkNew();
	    }
	    
	    public VTzjh(object keyID)
	    {
		    SetSQLProps();
		    LoadByKey(keyID);
	    }
    	 
	    public VTzjh(string columnName, object columnValue)
        {
            SetSQLProps();
            LoadByParam(columnName,columnValue);
        }
        
	    #endregion
	    
	    #region Props
	    
          
        [XmlAttribute("Scgydm")]
        [Bindable(true)]
        public string Scgydm 
	    {
		    get
		    {
			    return GetColumnValue<string>("SCGYDM");
		    }
            set 
		    {
			    SetColumnValue("SCGYDM", value);
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
	      
        [XmlAttribute("Schtxh")]
        [Bindable(true)]
        public string Schtxh 
	    {
		    get
		    {
			    return GetColumnValue<string>("SCHTXH");
		    }
            set 
		    {
			    SetColumnValue("SCHTXH", value);
            }
        }
	      
        [XmlAttribute("Xtwpmc")]
        [Bindable(true)]
        public string Xtwpmc 
	    {
		    get
		    {
			    return GetColumnValue<string>("XTWPMC");
		    }
            set 
		    {
			    SetColumnValue("XTWPMC", value);
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
	      
        [XmlAttribute("Ptfs")]
        [Bindable(true)]
        public string Ptfs 
	    {
		    get
		    {
			    return GetColumnValue<string>("PTFS");
		    }
            set 
		    {
			    SetColumnValue("PTFS", value);
            }
        }
	    
	    #endregion
    
	    #region Columns Struct
	    public struct Columns
	    {
		    
		    
            public static string Scgydm = @"SCGYDM";
            
            public static string Scjhrq = @"SCJHRQ";
            
            public static string Scyspd = @"SCYSPD";
            
            public static string Schtbh = @"SCHTBH";
            
            public static string Scggdh = @"SCGGDH";
            
            public static string Scggbz = @"SCGGBZ";
            
            public static string Schtsl = @"SCHTSL";
            
            public static string Schtxh = @"SCHTXH";
            
            public static string Xtwpmc = @"XTWPMC";
            
            public static string Xtwpks = @"XTWPKS";
            
            public static string Xtwpys = @"XTWPYS";
            
            public static string Ptfs = @"PTFS";
            
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
