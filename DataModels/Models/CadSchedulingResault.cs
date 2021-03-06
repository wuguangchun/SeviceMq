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
    /// Strongly-typed collection for the CadSchedulingResault class.
    /// </summary>
    [Serializable]
    public partial class CadSchedulingResaultCollection : ReadOnlyList<CadSchedulingResault, CadSchedulingResaultCollection>
    {        
        public CadSchedulingResaultCollection() {}
    }
    /// <summary>
    /// This is  Read-only wrapper class for the CadSchedulingResault view.
    /// </summary>
    [Serializable]
    public partial class CadSchedulingResault : ReadOnlyRecord<CadSchedulingResault>, IReadOnlyRecord
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
                TableSchema.Table schema = new TableSchema.Table("CadSchedulingResault", TableType.View, DataService.GetInstance("Nowthwin"));
                schema.Columns = new TableSchema.TableColumnCollection();
                schema.SchemaName = @"dbo";
                //columns
                
                TableSchema.TableColumn colvarCustomerID = new TableSchema.TableColumn(schema);
                colvarCustomerID.ColumnName = "CustomerID";
                colvarCustomerID.DataType = DbType.String;
                colvarCustomerID.MaxLength = 100;
                colvarCustomerID.AutoIncrement = false;
                colvarCustomerID.IsNullable = false;
                colvarCustomerID.IsPrimaryKey = false;
                colvarCustomerID.IsForeignKey = false;
                colvarCustomerID.IsReadOnly = false;
                
                schema.Columns.Add(colvarCustomerID);
                
                TableSchema.TableColumn colvarJobCode = new TableSchema.TableColumn(schema);
                colvarJobCode.ColumnName = "jobCode";
                colvarJobCode.DataType = DbType.String;
                colvarJobCode.MaxLength = 50;
                colvarJobCode.AutoIncrement = false;
                colvarJobCode.IsNullable = true;
                colvarJobCode.IsPrimaryKey = false;
                colvarJobCode.IsForeignKey = false;
                colvarJobCode.IsReadOnly = false;
                
                schema.Columns.Add(colvarJobCode);
                
                TableSchema.TableColumn colvarProject = new TableSchema.TableColumn(schema);
                colvarProject.ColumnName = "Project";
                colvarProject.DataType = DbType.String;
                colvarProject.MaxLength = 20;
                colvarProject.AutoIncrement = false;
                colvarProject.IsNullable = true;
                colvarProject.IsPrimaryKey = false;
                colvarProject.IsForeignKey = false;
                colvarProject.IsReadOnly = false;
                
                schema.Columns.Add(colvarProject);
                
                TableSchema.TableColumn colvarNote = new TableSchema.TableColumn(schema);
                colvarNote.ColumnName = "Note";
                colvarNote.DataType = DbType.String;
                colvarNote.MaxLength = 200;
                colvarNote.AutoIncrement = false;
                colvarNote.IsNullable = true;
                colvarNote.IsPrimaryKey = false;
                colvarNote.IsForeignKey = false;
                colvarNote.IsReadOnly = false;
                
                schema.Columns.Add(colvarNote);
                
                TableSchema.TableColumn colvarResources = new TableSchema.TableColumn(schema);
                colvarResources.ColumnName = "Resources";
                colvarResources.DataType = DbType.String;
                colvarResources.MaxLength = 1000;
                colvarResources.AutoIncrement = false;
                colvarResources.IsNullable = false;
                colvarResources.IsPrimaryKey = false;
                colvarResources.IsForeignKey = false;
                colvarResources.IsReadOnly = false;
                
                schema.Columns.Add(colvarResources);
                
                TableSchema.TableColumn colvarBeginTime = new TableSchema.TableColumn(schema);
                colvarBeginTime.ColumnName = "BeginTime";
                colvarBeginTime.DataType = DbType.DateTime;
                colvarBeginTime.MaxLength = 0;
                colvarBeginTime.AutoIncrement = false;
                colvarBeginTime.IsNullable = false;
                colvarBeginTime.IsPrimaryKey = false;
                colvarBeginTime.IsForeignKey = false;
                colvarBeginTime.IsReadOnly = false;
                
                schema.Columns.Add(colvarBeginTime);
                
                TableSchema.TableColumn colvarEndTime = new TableSchema.TableColumn(schema);
                colvarEndTime.ColumnName = "EndTime";
                colvarEndTime.DataType = DbType.DateTime;
                colvarEndTime.MaxLength = 0;
                colvarEndTime.AutoIncrement = false;
                colvarEndTime.IsNullable = false;
                colvarEndTime.IsPrimaryKey = false;
                colvarEndTime.IsForeignKey = false;
                colvarEndTime.IsReadOnly = false;
                
                schema.Columns.Add(colvarEndTime);
                
                TableSchema.TableColumn colvarMakeTime = new TableSchema.TableColumn(schema);
                colvarMakeTime.ColumnName = "MakeTime";
                colvarMakeTime.DataType = DbType.String;
                colvarMakeTime.MaxLength = 50;
                colvarMakeTime.AutoIncrement = false;
                colvarMakeTime.IsNullable = false;
                colvarMakeTime.IsPrimaryKey = false;
                colvarMakeTime.IsForeignKey = false;
                colvarMakeTime.IsReadOnly = false;
                
                schema.Columns.Add(colvarMakeTime);
                
                TableSchema.TableColumn colvarCreateTime = new TableSchema.TableColumn(schema);
                colvarCreateTime.ColumnName = "CreateTime";
                colvarCreateTime.DataType = DbType.DateTime;
                colvarCreateTime.MaxLength = 0;
                colvarCreateTime.AutoIncrement = false;
                colvarCreateTime.IsNullable = true;
                colvarCreateTime.IsPrimaryKey = false;
                colvarCreateTime.IsForeignKey = false;
                colvarCreateTime.IsReadOnly = false;
                
                schema.Columns.Add(colvarCreateTime);
                
                TableSchema.TableColumn colvarMtmOrTz = new TableSchema.TableColumn(schema);
                colvarMtmOrTz.ColumnName = "MtmOrTz";
                colvarMtmOrTz.DataType = DbType.Int32;
                colvarMtmOrTz.MaxLength = 0;
                colvarMtmOrTz.AutoIncrement = false;
                colvarMtmOrTz.IsNullable = false;
                colvarMtmOrTz.IsPrimaryKey = false;
                colvarMtmOrTz.IsForeignKey = false;
                colvarMtmOrTz.IsReadOnly = false;
                
                schema.Columns.Add(colvarMtmOrTz);
                
                TableSchema.TableColumn colvarGrabTime = new TableSchema.TableColumn(schema);
                colvarGrabTime.ColumnName = "GrabTime";
                colvarGrabTime.DataType = DbType.DateTime;
                colvarGrabTime.MaxLength = 0;
                colvarGrabTime.AutoIncrement = false;
                colvarGrabTime.IsNullable = false;
                colvarGrabTime.IsPrimaryKey = false;
                colvarGrabTime.IsForeignKey = false;
                colvarGrabTime.IsReadOnly = false;
                
                schema.Columns.Add(colvarGrabTime);
                
                TableSchema.TableColumn colvarState = new TableSchema.TableColumn(schema);
                colvarState.ColumnName = "State";
                colvarState.DataType = DbType.Int32;
                colvarState.MaxLength = 0;
                colvarState.AutoIncrement = false;
                colvarState.IsNullable = false;
                colvarState.IsPrimaryKey = false;
                colvarState.IsForeignKey = false;
                colvarState.IsReadOnly = false;
                
                schema.Columns.Add(colvarState);
                
                TableSchema.TableColumn colvarResourcesName = new TableSchema.TableColumn(schema);
                colvarResourcesName.ColumnName = "resourcesName";
                colvarResourcesName.DataType = DbType.AnsiString;
                colvarResourcesName.MaxLength = 50;
                colvarResourcesName.AutoIncrement = false;
                colvarResourcesName.IsNullable = true;
                colvarResourcesName.IsPrimaryKey = false;
                colvarResourcesName.IsForeignKey = false;
                colvarResourcesName.IsReadOnly = false;
                
                schema.Columns.Add(colvarResourcesName);
                
                
                BaseSchema = schema;
                //add this schema to the provider
                //so we can query it later
                DataService.Providers["Nowthwin"].AddSchema("CadSchedulingResault",schema);
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
	    public CadSchedulingResault()
	    {
            SetSQLProps();
            SetDefaults();
            MarkNew();
        }
        public CadSchedulingResault(bool useDatabaseDefaults)
	    {
		    SetSQLProps();
		    if(useDatabaseDefaults)
		    {
				ForceDefaults();
			}
			MarkNew();
	    }
	    
	    public CadSchedulingResault(object keyID)
	    {
		    SetSQLProps();
		    LoadByKey(keyID);
	    }
    	 
	    public CadSchedulingResault(string columnName, object columnValue)
        {
            SetSQLProps();
            LoadByParam(columnName,columnValue);
        }
        
	    #endregion
	    
	    #region Props
	    
          
        [XmlAttribute("CustomerID")]
        [Bindable(true)]
        public string CustomerID 
	    {
		    get
		    {
			    return GetColumnValue<string>("CustomerID");
		    }
            set 
		    {
			    SetColumnValue("CustomerID", value);
            }
        }
	      
        [XmlAttribute("JobCode")]
        [Bindable(true)]
        public string JobCode 
	    {
		    get
		    {
			    return GetColumnValue<string>("jobCode");
		    }
            set 
		    {
			    SetColumnValue("jobCode", value);
            }
        }
	      
        [XmlAttribute("Project")]
        [Bindable(true)]
        public string Project 
	    {
		    get
		    {
			    return GetColumnValue<string>("Project");
		    }
            set 
		    {
			    SetColumnValue("Project", value);
            }
        }
	      
        [XmlAttribute("Note")]
        [Bindable(true)]
        public string Note 
	    {
		    get
		    {
			    return GetColumnValue<string>("Note");
		    }
            set 
		    {
			    SetColumnValue("Note", value);
            }
        }
	      
        [XmlAttribute("Resources")]
        [Bindable(true)]
        public string Resources 
	    {
		    get
		    {
			    return GetColumnValue<string>("Resources");
		    }
            set 
		    {
			    SetColumnValue("Resources", value);
            }
        }
	      
        [XmlAttribute("BeginTime")]
        [Bindable(true)]
        public DateTime BeginTime 
	    {
		    get
		    {
			    return GetColumnValue<DateTime>("BeginTime");
		    }
            set 
		    {
			    SetColumnValue("BeginTime", value);
            }
        }
	      
        [XmlAttribute("EndTime")]
        [Bindable(true)]
        public DateTime EndTime 
	    {
		    get
		    {
			    return GetColumnValue<DateTime>("EndTime");
		    }
            set 
		    {
			    SetColumnValue("EndTime", value);
            }
        }
	      
        [XmlAttribute("MakeTime")]
        [Bindable(true)]
        public string MakeTime 
	    {
		    get
		    {
			    return GetColumnValue<string>("MakeTime");
		    }
            set 
		    {
			    SetColumnValue("MakeTime", value);
            }
        }
	      
        [XmlAttribute("CreateTime")]
        [Bindable(true)]
        public DateTime? CreateTime 
	    {
		    get
		    {
			    return GetColumnValue<DateTime?>("CreateTime");
		    }
            set 
		    {
			    SetColumnValue("CreateTime", value);
            }
        }
	      
        [XmlAttribute("MtmOrTz")]
        [Bindable(true)]
        public int MtmOrTz 
	    {
		    get
		    {
			    return GetColumnValue<int>("MtmOrTz");
		    }
            set 
		    {
			    SetColumnValue("MtmOrTz", value);
            }
        }
	      
        [XmlAttribute("GrabTime")]
        [Bindable(true)]
        public DateTime GrabTime 
	    {
		    get
		    {
			    return GetColumnValue<DateTime>("GrabTime");
		    }
            set 
		    {
			    SetColumnValue("GrabTime", value);
            }
        }
	      
        [XmlAttribute("State")]
        [Bindable(true)]
        public int State 
	    {
		    get
		    {
			    return GetColumnValue<int>("State");
		    }
            set 
		    {
			    SetColumnValue("State", value);
            }
        }
	      
        [XmlAttribute("ResourcesName")]
        [Bindable(true)]
        public string ResourcesName 
	    {
		    get
		    {
			    return GetColumnValue<string>("resourcesName");
		    }
            set 
		    {
			    SetColumnValue("resourcesName", value);
            }
        }
	    
	    #endregion
    
	    #region Columns Struct
	    public struct Columns
	    {
		    
		    
            public static string CustomerID = @"CustomerID";
            
            public static string JobCode = @"jobCode";
            
            public static string Project = @"Project";
            
            public static string Note = @"Note";
            
            public static string Resources = @"Resources";
            
            public static string BeginTime = @"BeginTime";
            
            public static string EndTime = @"EndTime";
            
            public static string MakeTime = @"MakeTime";
            
            public static string CreateTime = @"CreateTime";
            
            public static string MtmOrTz = @"MtmOrTz";
            
            public static string GrabTime = @"GrabTime";
            
            public static string State = @"State";
            
            public static string ResourcesName = @"resourcesName";
            
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
