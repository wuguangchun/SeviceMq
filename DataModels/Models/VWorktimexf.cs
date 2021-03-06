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
    /// Strongly-typed collection for the VWorktimexf class.
    /// </summary>
    [Serializable]
    public partial class VWorktimexfCollection : ReadOnlyList<VWorktimexf, VWorktimexfCollection>
    {        
        public VWorktimexfCollection() {}
    }
    /// <summary>
    /// This is  Read-only wrapper class for the v_worktimexf view.
    /// </summary>
    [Serializable]
    public partial class VWorktimexf : ReadOnlyRecord<VWorktimexf>, IReadOnlyRecord
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
                TableSchema.Table schema = new TableSchema.Table("v_worktimexf", TableType.View, DataService.GetInstance("Nowthwin"));
                schema.Columns = new TableSchema.TableColumnCollection();
                schema.SchemaName = @"dbo";
                //columns
                
                TableSchema.TableColumn colvarWorkTime = new TableSchema.TableColumn(schema);
                colvarWorkTime.ColumnName = "workTime";
                colvarWorkTime.DataType = DbType.DateTime;
                colvarWorkTime.MaxLength = 0;
                colvarWorkTime.AutoIncrement = false;
                colvarWorkTime.IsNullable = true;
                colvarWorkTime.IsPrimaryKey = false;
                colvarWorkTime.IsForeignKey = false;
                colvarWorkTime.IsReadOnly = false;
                
                schema.Columns.Add(colvarWorkTime);
                
                
                BaseSchema = schema;
                //add this schema to the provider
                //so we can query it later
                DataService.Providers["Nowthwin"].AddSchema("v_worktimexf",schema);
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
	    public VWorktimexf()
	    {
            SetSQLProps();
            SetDefaults();
            MarkNew();
        }
        public VWorktimexf(bool useDatabaseDefaults)
	    {
		    SetSQLProps();
		    if(useDatabaseDefaults)
		    {
				ForceDefaults();
			}
			MarkNew();
	    }
	    
	    public VWorktimexf(object keyID)
	    {
		    SetSQLProps();
		    LoadByKey(keyID);
	    }
    	 
	    public VWorktimexf(string columnName, object columnValue)
        {
            SetSQLProps();
            LoadByParam(columnName,columnValue);
        }
        
	    #endregion
	    
	    #region Props
	    
          
        [XmlAttribute("WorkTime")]
        [Bindable(true)]
        public DateTime? WorkTime 
	    {
		    get
		    {
			    return GetColumnValue<DateTime?>("workTime");
		    }
            set 
		    {
			    SetColumnValue("workTime", value);
            }
        }
	    
	    #endregion
    
	    #region Columns Struct
	    public struct Columns
	    {
		    
		    
            public static string WorkTime = @"workTime";
            
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
