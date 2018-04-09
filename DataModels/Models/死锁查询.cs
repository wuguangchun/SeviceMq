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
    /// Strongly-typed collection for the 死锁查询 class.
    /// </summary>
    [Serializable]
    public partial class 死锁查询Collection : ReadOnlyList<死锁查询, 死锁查询Collection>
    {        
        public 死锁查询Collection() {}
    }
    /// <summary>
    /// This is  Read-only wrapper class for the 死锁查询 view.
    /// </summary>
    [Serializable]
    public partial class 死锁查询 : ReadOnlyRecord<死锁查询>, IReadOnlyRecord
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
                TableSchema.Table schema = new TableSchema.Table("死锁查询", TableType.View, DataService.GetInstance("Nowthwin"));
                schema.Columns = new TableSchema.TableColumnCollection();
                schema.SchemaName = @"dbo";
                //columns
                
                TableSchema.TableColumn colvarSpid = new TableSchema.TableColumn(schema);
                colvarSpid.ColumnName = "spid";
                colvarSpid.DataType = DbType.Int32;
                colvarSpid.MaxLength = 0;
                colvarSpid.AutoIncrement = false;
                colvarSpid.IsNullable = false;
                colvarSpid.IsPrimaryKey = false;
                colvarSpid.IsForeignKey = false;
                colvarSpid.IsReadOnly = false;
                
                schema.Columns.Add(colvarSpid);
                
                TableSchema.TableColumn colvarTableName = new TableSchema.TableColumn(schema);
                colvarTableName.ColumnName = "tableName";
                colvarTableName.DataType = DbType.String;
                colvarTableName.MaxLength = 128;
                colvarTableName.AutoIncrement = false;
                colvarTableName.IsNullable = true;
                colvarTableName.IsPrimaryKey = false;
                colvarTableName.IsForeignKey = false;
                colvarTableName.IsReadOnly = false;
                
                schema.Columns.Add(colvarTableName);
                
                TableSchema.TableColumn colvarResourceType = new TableSchema.TableColumn(schema);
                colvarResourceType.ColumnName = "resource_type";
                colvarResourceType.DataType = DbType.String;
                colvarResourceType.MaxLength = 60;
                colvarResourceType.AutoIncrement = false;
                colvarResourceType.IsNullable = false;
                colvarResourceType.IsPrimaryKey = false;
                colvarResourceType.IsForeignKey = false;
                colvarResourceType.IsReadOnly = false;
                
                schema.Columns.Add(colvarResourceType);
                
                TableSchema.TableColumn colvarResourceSubtype = new TableSchema.TableColumn(schema);
                colvarResourceSubtype.ColumnName = "resource_subtype";
                colvarResourceSubtype.DataType = DbType.String;
                colvarResourceSubtype.MaxLength = 60;
                colvarResourceSubtype.AutoIncrement = false;
                colvarResourceSubtype.IsNullable = false;
                colvarResourceSubtype.IsPrimaryKey = false;
                colvarResourceSubtype.IsForeignKey = false;
                colvarResourceSubtype.IsReadOnly = false;
                
                schema.Columns.Add(colvarResourceSubtype);
                
                TableSchema.TableColumn colvarResourceDatabaseId = new TableSchema.TableColumn(schema);
                colvarResourceDatabaseId.ColumnName = "resource_database_id";
                colvarResourceDatabaseId.DataType = DbType.Int32;
                colvarResourceDatabaseId.MaxLength = 0;
                colvarResourceDatabaseId.AutoIncrement = false;
                colvarResourceDatabaseId.IsNullable = false;
                colvarResourceDatabaseId.IsPrimaryKey = false;
                colvarResourceDatabaseId.IsForeignKey = false;
                colvarResourceDatabaseId.IsReadOnly = false;
                
                schema.Columns.Add(colvarResourceDatabaseId);
                
                TableSchema.TableColumn colvarResourceDescription = new TableSchema.TableColumn(schema);
                colvarResourceDescription.ColumnName = "resource_description";
                colvarResourceDescription.DataType = DbType.String;
                colvarResourceDescription.MaxLength = 256;
                colvarResourceDescription.AutoIncrement = false;
                colvarResourceDescription.IsNullable = false;
                colvarResourceDescription.IsPrimaryKey = false;
                colvarResourceDescription.IsForeignKey = false;
                colvarResourceDescription.IsReadOnly = false;
                
                schema.Columns.Add(colvarResourceDescription);
                
                TableSchema.TableColumn colvarResourceAssociatedEntityId = new TableSchema.TableColumn(schema);
                colvarResourceAssociatedEntityId.ColumnName = "resource_associated_entity_id";
                colvarResourceAssociatedEntityId.DataType = DbType.Int64;
                colvarResourceAssociatedEntityId.MaxLength = 0;
                colvarResourceAssociatedEntityId.AutoIncrement = false;
                colvarResourceAssociatedEntityId.IsNullable = true;
                colvarResourceAssociatedEntityId.IsPrimaryKey = false;
                colvarResourceAssociatedEntityId.IsForeignKey = false;
                colvarResourceAssociatedEntityId.IsReadOnly = false;
                
                schema.Columns.Add(colvarResourceAssociatedEntityId);
                
                TableSchema.TableColumn colvarResourceLockPartition = new TableSchema.TableColumn(schema);
                colvarResourceLockPartition.ColumnName = "resource_lock_partition";
                colvarResourceLockPartition.DataType = DbType.Int32;
                colvarResourceLockPartition.MaxLength = 0;
                colvarResourceLockPartition.AutoIncrement = false;
                colvarResourceLockPartition.IsNullable = true;
                colvarResourceLockPartition.IsPrimaryKey = false;
                colvarResourceLockPartition.IsForeignKey = false;
                colvarResourceLockPartition.IsReadOnly = false;
                
                schema.Columns.Add(colvarResourceLockPartition);
                
                TableSchema.TableColumn colvarRequestMode = new TableSchema.TableColumn(schema);
                colvarRequestMode.ColumnName = "request_mode";
                colvarRequestMode.DataType = DbType.String;
                colvarRequestMode.MaxLength = 60;
                colvarRequestMode.AutoIncrement = false;
                colvarRequestMode.IsNullable = false;
                colvarRequestMode.IsPrimaryKey = false;
                colvarRequestMode.IsForeignKey = false;
                colvarRequestMode.IsReadOnly = false;
                
                schema.Columns.Add(colvarRequestMode);
                
                TableSchema.TableColumn colvarRequestType = new TableSchema.TableColumn(schema);
                colvarRequestType.ColumnName = "request_type";
                colvarRequestType.DataType = DbType.String;
                colvarRequestType.MaxLength = 60;
                colvarRequestType.AutoIncrement = false;
                colvarRequestType.IsNullable = false;
                colvarRequestType.IsPrimaryKey = false;
                colvarRequestType.IsForeignKey = false;
                colvarRequestType.IsReadOnly = false;
                
                schema.Columns.Add(colvarRequestType);
                
                TableSchema.TableColumn colvarRequestStatus = new TableSchema.TableColumn(schema);
                colvarRequestStatus.ColumnName = "request_status";
                colvarRequestStatus.DataType = DbType.String;
                colvarRequestStatus.MaxLength = 60;
                colvarRequestStatus.AutoIncrement = false;
                colvarRequestStatus.IsNullable = false;
                colvarRequestStatus.IsPrimaryKey = false;
                colvarRequestStatus.IsForeignKey = false;
                colvarRequestStatus.IsReadOnly = false;
                
                schema.Columns.Add(colvarRequestStatus);
                
                TableSchema.TableColumn colvarRequestReferenceCount = new TableSchema.TableColumn(schema);
                colvarRequestReferenceCount.ColumnName = "request_reference_count";
                colvarRequestReferenceCount.DataType = DbType.Int16;
                colvarRequestReferenceCount.MaxLength = 0;
                colvarRequestReferenceCount.AutoIncrement = false;
                colvarRequestReferenceCount.IsNullable = false;
                colvarRequestReferenceCount.IsPrimaryKey = false;
                colvarRequestReferenceCount.IsForeignKey = false;
                colvarRequestReferenceCount.IsReadOnly = false;
                
                schema.Columns.Add(colvarRequestReferenceCount);
                
                TableSchema.TableColumn colvarRequestLifetime = new TableSchema.TableColumn(schema);
                colvarRequestLifetime.ColumnName = "request_lifetime";
                colvarRequestLifetime.DataType = DbType.Int32;
                colvarRequestLifetime.MaxLength = 0;
                colvarRequestLifetime.AutoIncrement = false;
                colvarRequestLifetime.IsNullable = false;
                colvarRequestLifetime.IsPrimaryKey = false;
                colvarRequestLifetime.IsForeignKey = false;
                colvarRequestLifetime.IsReadOnly = false;
                
                schema.Columns.Add(colvarRequestLifetime);
                
                TableSchema.TableColumn colvarRequestSessionId = new TableSchema.TableColumn(schema);
                colvarRequestSessionId.ColumnName = "request_session_id";
                colvarRequestSessionId.DataType = DbType.Int32;
                colvarRequestSessionId.MaxLength = 0;
                colvarRequestSessionId.AutoIncrement = false;
                colvarRequestSessionId.IsNullable = false;
                colvarRequestSessionId.IsPrimaryKey = false;
                colvarRequestSessionId.IsForeignKey = false;
                colvarRequestSessionId.IsReadOnly = false;
                
                schema.Columns.Add(colvarRequestSessionId);
                
                TableSchema.TableColumn colvarRequestExecContextId = new TableSchema.TableColumn(schema);
                colvarRequestExecContextId.ColumnName = "request_exec_context_id";
                colvarRequestExecContextId.DataType = DbType.Int32;
                colvarRequestExecContextId.MaxLength = 0;
                colvarRequestExecContextId.AutoIncrement = false;
                colvarRequestExecContextId.IsNullable = false;
                colvarRequestExecContextId.IsPrimaryKey = false;
                colvarRequestExecContextId.IsForeignKey = false;
                colvarRequestExecContextId.IsReadOnly = false;
                
                schema.Columns.Add(colvarRequestExecContextId);
                
                TableSchema.TableColumn colvarRequestRequestId = new TableSchema.TableColumn(schema);
                colvarRequestRequestId.ColumnName = "request_request_id";
                colvarRequestRequestId.DataType = DbType.Int32;
                colvarRequestRequestId.MaxLength = 0;
                colvarRequestRequestId.AutoIncrement = false;
                colvarRequestRequestId.IsNullable = false;
                colvarRequestRequestId.IsPrimaryKey = false;
                colvarRequestRequestId.IsForeignKey = false;
                colvarRequestRequestId.IsReadOnly = false;
                
                schema.Columns.Add(colvarRequestRequestId);
                
                TableSchema.TableColumn colvarRequestOwnerType = new TableSchema.TableColumn(schema);
                colvarRequestOwnerType.ColumnName = "request_owner_type";
                colvarRequestOwnerType.DataType = DbType.String;
                colvarRequestOwnerType.MaxLength = 60;
                colvarRequestOwnerType.AutoIncrement = false;
                colvarRequestOwnerType.IsNullable = false;
                colvarRequestOwnerType.IsPrimaryKey = false;
                colvarRequestOwnerType.IsForeignKey = false;
                colvarRequestOwnerType.IsReadOnly = false;
                
                schema.Columns.Add(colvarRequestOwnerType);
                
                TableSchema.TableColumn colvarRequestOwnerId = new TableSchema.TableColumn(schema);
                colvarRequestOwnerId.ColumnName = "request_owner_id";
                colvarRequestOwnerId.DataType = DbType.Int64;
                colvarRequestOwnerId.MaxLength = 0;
                colvarRequestOwnerId.AutoIncrement = false;
                colvarRequestOwnerId.IsNullable = true;
                colvarRequestOwnerId.IsPrimaryKey = false;
                colvarRequestOwnerId.IsForeignKey = false;
                colvarRequestOwnerId.IsReadOnly = false;
                
                schema.Columns.Add(colvarRequestOwnerId);
                
                TableSchema.TableColumn colvarRequestOwnerGuid = new TableSchema.TableColumn(schema);
                colvarRequestOwnerGuid.ColumnName = "request_owner_guid";
                colvarRequestOwnerGuid.DataType = DbType.Guid;
                colvarRequestOwnerGuid.MaxLength = 0;
                colvarRequestOwnerGuid.AutoIncrement = false;
                colvarRequestOwnerGuid.IsNullable = true;
                colvarRequestOwnerGuid.IsPrimaryKey = false;
                colvarRequestOwnerGuid.IsForeignKey = false;
                colvarRequestOwnerGuid.IsReadOnly = false;
                
                schema.Columns.Add(colvarRequestOwnerGuid);
                
                TableSchema.TableColumn colvarRequestOwnerLockspaceId = new TableSchema.TableColumn(schema);
                colvarRequestOwnerLockspaceId.ColumnName = "request_owner_lockspace_id";
                colvarRequestOwnerLockspaceId.DataType = DbType.String;
                colvarRequestOwnerLockspaceId.MaxLength = 32;
                colvarRequestOwnerLockspaceId.AutoIncrement = false;
                colvarRequestOwnerLockspaceId.IsNullable = false;
                colvarRequestOwnerLockspaceId.IsPrimaryKey = false;
                colvarRequestOwnerLockspaceId.IsForeignKey = false;
                colvarRequestOwnerLockspaceId.IsReadOnly = false;
                
                schema.Columns.Add(colvarRequestOwnerLockspaceId);
                
                TableSchema.TableColumn colvarLockOwnerAddress = new TableSchema.TableColumn(schema);
                colvarLockOwnerAddress.ColumnName = "lock_owner_address";
                colvarLockOwnerAddress.DataType = DbType.Binary;
                colvarLockOwnerAddress.MaxLength = 8;
                colvarLockOwnerAddress.AutoIncrement = false;
                colvarLockOwnerAddress.IsNullable = false;
                colvarLockOwnerAddress.IsPrimaryKey = false;
                colvarLockOwnerAddress.IsForeignKey = false;
                colvarLockOwnerAddress.IsReadOnly = false;
                
                schema.Columns.Add(colvarLockOwnerAddress);
                
                
                BaseSchema = schema;
                //add this schema to the provider
                //so we can query it later
                DataService.Providers["Nowthwin"].AddSchema("死锁查询",schema);
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
	    public 死锁查询()
	    {
            SetSQLProps();
            SetDefaults();
            MarkNew();
        }
        public 死锁查询(bool useDatabaseDefaults)
	    {
		    SetSQLProps();
		    if(useDatabaseDefaults)
		    {
				ForceDefaults();
			}
			MarkNew();
	    }
	    
	    public 死锁查询(object keyID)
	    {
		    SetSQLProps();
		    LoadByKey(keyID);
	    }
    	 
	    public 死锁查询(string columnName, object columnValue)
        {
            SetSQLProps();
            LoadByParam(columnName,columnValue);
        }
        
	    #endregion
	    
	    #region Props
	    
          
        [XmlAttribute("Spid")]
        [Bindable(true)]
        public int Spid 
	    {
		    get
		    {
			    return GetColumnValue<int>("spid");
		    }
            set 
		    {
			    SetColumnValue("spid", value);
            }
        }
	      
        [XmlAttribute("TableName")]
        [Bindable(true)]
        public string TableName 
	    {
		    get
		    {
			    return GetColumnValue<string>("tableName");
		    }
            set 
		    {
			    SetColumnValue("tableName", value);
            }
        }
	      
        [XmlAttribute("ResourceType")]
        [Bindable(true)]
        public string ResourceType 
	    {
		    get
		    {
			    return GetColumnValue<string>("resource_type");
		    }
            set 
		    {
			    SetColumnValue("resource_type", value);
            }
        }
	      
        [XmlAttribute("ResourceSubtype")]
        [Bindable(true)]
        public string ResourceSubtype 
	    {
		    get
		    {
			    return GetColumnValue<string>("resource_subtype");
		    }
            set 
		    {
			    SetColumnValue("resource_subtype", value);
            }
        }
	      
        [XmlAttribute("ResourceDatabaseId")]
        [Bindable(true)]
        public int ResourceDatabaseId 
	    {
		    get
		    {
			    return GetColumnValue<int>("resource_database_id");
		    }
            set 
		    {
			    SetColumnValue("resource_database_id", value);
            }
        }
	      
        [XmlAttribute("ResourceDescription")]
        [Bindable(true)]
        public string ResourceDescription 
	    {
		    get
		    {
			    return GetColumnValue<string>("resource_description");
		    }
            set 
		    {
			    SetColumnValue("resource_description", value);
            }
        }
	      
        [XmlAttribute("ResourceAssociatedEntityId")]
        [Bindable(true)]
        public long? ResourceAssociatedEntityId 
	    {
		    get
		    {
			    return GetColumnValue<long?>("resource_associated_entity_id");
		    }
            set 
		    {
			    SetColumnValue("resource_associated_entity_id", value);
            }
        }
	      
        [XmlAttribute("ResourceLockPartition")]
        [Bindable(true)]
        public int? ResourceLockPartition 
	    {
		    get
		    {
			    return GetColumnValue<int?>("resource_lock_partition");
		    }
            set 
		    {
			    SetColumnValue("resource_lock_partition", value);
            }
        }
	      
        [XmlAttribute("RequestMode")]
        [Bindable(true)]
        public string RequestMode 
	    {
		    get
		    {
			    return GetColumnValue<string>("request_mode");
		    }
            set 
		    {
			    SetColumnValue("request_mode", value);
            }
        }
	      
        [XmlAttribute("RequestType")]
        [Bindable(true)]
        public string RequestType 
	    {
		    get
		    {
			    return GetColumnValue<string>("request_type");
		    }
            set 
		    {
			    SetColumnValue("request_type", value);
            }
        }
	      
        [XmlAttribute("RequestStatus")]
        [Bindable(true)]
        public string RequestStatus 
	    {
		    get
		    {
			    return GetColumnValue<string>("request_status");
		    }
            set 
		    {
			    SetColumnValue("request_status", value);
            }
        }
	      
        [XmlAttribute("RequestReferenceCount")]
        [Bindable(true)]
        public short RequestReferenceCount 
	    {
		    get
		    {
			    return GetColumnValue<short>("request_reference_count");
		    }
            set 
		    {
			    SetColumnValue("request_reference_count", value);
            }
        }
	      
        [XmlAttribute("RequestLifetime")]
        [Bindable(true)]
        public int RequestLifetime 
	    {
		    get
		    {
			    return GetColumnValue<int>("request_lifetime");
		    }
            set 
		    {
			    SetColumnValue("request_lifetime", value);
            }
        }
	      
        [XmlAttribute("RequestSessionId")]
        [Bindable(true)]
        public int RequestSessionId 
	    {
		    get
		    {
			    return GetColumnValue<int>("request_session_id");
		    }
            set 
		    {
			    SetColumnValue("request_session_id", value);
            }
        }
	      
        [XmlAttribute("RequestExecContextId")]
        [Bindable(true)]
        public int RequestExecContextId 
	    {
		    get
		    {
			    return GetColumnValue<int>("request_exec_context_id");
		    }
            set 
		    {
			    SetColumnValue("request_exec_context_id", value);
            }
        }
	      
        [XmlAttribute("RequestRequestId")]
        [Bindable(true)]
        public int RequestRequestId 
	    {
		    get
		    {
			    return GetColumnValue<int>("request_request_id");
		    }
            set 
		    {
			    SetColumnValue("request_request_id", value);
            }
        }
	      
        [XmlAttribute("RequestOwnerType")]
        [Bindable(true)]
        public string RequestOwnerType 
	    {
		    get
		    {
			    return GetColumnValue<string>("request_owner_type");
		    }
            set 
		    {
			    SetColumnValue("request_owner_type", value);
            }
        }
	      
        [XmlAttribute("RequestOwnerId")]
        [Bindable(true)]
        public long? RequestOwnerId 
	    {
		    get
		    {
			    return GetColumnValue<long?>("request_owner_id");
		    }
            set 
		    {
			    SetColumnValue("request_owner_id", value);
            }
        }
	      
        [XmlAttribute("RequestOwnerGuid")]
        [Bindable(true)]
        public Guid? RequestOwnerGuid 
	    {
		    get
		    {
			    return GetColumnValue<Guid?>("request_owner_guid");
		    }
            set 
		    {
			    SetColumnValue("request_owner_guid", value);
            }
        }
	      
        [XmlAttribute("RequestOwnerLockspaceId")]
        [Bindable(true)]
        public string RequestOwnerLockspaceId 
	    {
		    get
		    {
			    return GetColumnValue<string>("request_owner_lockspace_id");
		    }
            set 
		    {
			    SetColumnValue("request_owner_lockspace_id", value);
            }
        }
	      
        [XmlAttribute("LockOwnerAddress")]
        [Bindable(true)]
        public byte[] LockOwnerAddress 
	    {
		    get
		    {
			    return GetColumnValue<byte[]>("lock_owner_address");
		    }
            set 
		    {
			    SetColumnValue("lock_owner_address", value);
            }
        }
	    
	    #endregion
    
	    #region Columns Struct
	    public struct Columns
	    {
		    
		    
            public static string Spid = @"spid";
            
            public static string TableName = @"tableName";
            
            public static string ResourceType = @"resource_type";
            
            public static string ResourceSubtype = @"resource_subtype";
            
            public static string ResourceDatabaseId = @"resource_database_id";
            
            public static string ResourceDescription = @"resource_description";
            
            public static string ResourceAssociatedEntityId = @"resource_associated_entity_id";
            
            public static string ResourceLockPartition = @"resource_lock_partition";
            
            public static string RequestMode = @"request_mode";
            
            public static string RequestType = @"request_type";
            
            public static string RequestStatus = @"request_status";
            
            public static string RequestReferenceCount = @"request_reference_count";
            
            public static string RequestLifetime = @"request_lifetime";
            
            public static string RequestSessionId = @"request_session_id";
            
            public static string RequestExecContextId = @"request_exec_context_id";
            
            public static string RequestRequestId = @"request_request_id";
            
            public static string RequestOwnerType = @"request_owner_type";
            
            public static string RequestOwnerId = @"request_owner_id";
            
            public static string RequestOwnerGuid = @"request_owner_guid";
            
            public static string RequestOwnerLockspaceId = @"request_owner_lockspace_id";
            
            public static string LockOwnerAddress = @"lock_owner_address";
            
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
