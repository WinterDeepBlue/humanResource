using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI.WebControls;

namespace humanResource.APPCODE.DAL
{/// <summary>
 /// Summary description for DB
 /// </summary>
    public class CoreX
    {
        public CoreX()
        {                           
            //
            // TODO: Add constructor logic here
            //
        }

    SqlConnection connectionString = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=G:\VSCODE\HRM\HRM\App_Data\employee.mdf;Integrated Security=True");
   
    
    #region Control Specific

    public DropDownList FillAndReturnDropDownList(DropDownList dropDownListName,string sqlSelect)
    {
        DataTable dt = FillAndReturnDataTable(sqlSelect);

        dropDownListName.Items.Add("--Select--");
        dropDownListName.Items.Clear();

        for (int i = 0; i < dt.Rows.Count; i++)
        {
            dropDownListName.Items.Add(dt.Rows[i].ItemArray[0].ToString());
        }
        
        return dropDownListName;
    }

    public DropDownList FillAndReturnDropDownList(DropDownList dropDownListName, DataTable dataTableName)
    {
        
        dropDownListName.Items.Add("--Select--");
        dropDownListName.Items.Clear();

        for (int i = 0; i < dataTableName.Rows.Count; i++)
        {
            dropDownListName.Items.Add(dataTableName.Rows[i].ItemArray[0].ToString());
        }

        return dropDownListName;
    }

    public GridView FillAndReturnGridView(GridView gridViewName,DataTable dataTableName)
    {
        if (dataTableName.Rows.Count != 0)
        {
            gridViewName.DataSource = dataTableName;
            gridViewName.DataBind();
        }
        return gridViewName;

    }

    #endregion
    
    #region SQL Specific
    public int InsertUpdateOrDelete(string sqlQuery, NameValuePairList nameValuePairObject)
    { 
      SqlCommand cmdObject = new SqlCommand(sqlQuery,GetConnection());
       
      foreach (NameValuePair objList in nameValuePairObject)
      {
          cmdObject.Parameters.AddWithValue(objList.GetName, objList.getValue);
      }

      int status = 0;

      try
      {
          status = cmdObject.ExecuteNonQuery();
          CloseConnection();
          return status;
      }
      catch (Exception exp)
      {
          return status;
      }

    }
    #region update************************************************************************
    public int updateQ(string sqlQuery, NameValuePairList nameValuePairObject)
        {
            SqlCommand cmdObject = new SqlCommand(sqlQuery, GetConnection());

            foreach (NameValuePair objList in nameValuePairObject)
            {
                if (!objList.getValue.Equals(0))
                    cmdObject.Parameters.AddWithValue(objList.GetName, objList.getValue);
            }

            int status = 0;

            try
            {
                status = cmdObject.ExecuteNonQuery();
                CloseConnection();
                return status;
            }
            catch (Exception exp)
            {
                return status;
            }

        }
    #endregion
    
    
    public DataSet AddTableToDataSet(DataTable dtName)
    {
        DataSet ds = new DataSet();
        ds.Tables.Add(dtName);
        return ds;
    }
    
    public DataTable FillAndReturnDataTable(string selectQuery)
    {

        SqlDataAdapter adp = new SqlDataAdapter(selectQuery, GetConnection());
        DataTable dt = new DataTable();
        adp.Fill(dt);
        CloseConnection();
        return dt;

    }
    
    public DataSet FillAndReturnDataSet(string selectQuery)
    {
        SqlDataAdapter adp = new SqlDataAdapter(selectQuery, GetConnection());
        DataSet ds = new DataSet();
        adp.Fill(ds);
        CloseConnection();

        return ds;
    }

    public DataSet FillAndReturnDataSet(string storedProcedureName,NameValuePairList nameValuePairObject)
    {
        SqlCommand commandObject = new SqlCommand(storedProcedureName,GetConnection());

        commandObject.CommandType = CommandType.StoredProcedure;
        
        foreach (NameValuePair objList in nameValuePairObject)
        {
            commandObject.Parameters.Add(createSqlParameter(objList.GetName, objList.getValue));
        }

        SqlDataReader readerObject = commandObject.ExecuteReader();

        DataSet ds = ConvertDataReaderToDataSet(readerObject);

        return ds;

       
    
    }
    #endregion

    #region Connection Oriented Functions
    public SqlConnection GetConnection()
    {
        connectionString.Open();
        return connectionString;

    }
    public void CloseConnection()
    {

        connectionString.Close();
    }
    #endregion

    #region DataReader to DataSet

    public DataSet ConvertDataReaderToDataSet(SqlDataReader reader)
    {
        DataSet dataSet = new DataSet();
        do
        {
            // Create new data table

            DataTable schemaTable = reader.GetSchemaTable();
            DataTable dataTable = new DataTable();

            if (schemaTable != null)
            {
                // A query returning records was executed

                for (int i = 0; i < schemaTable.Rows.Count; i++)
                {
                    DataRow dataRow = schemaTable.Rows[i];
                    // Create a column name that is unique in the data table
                    string columnName = (string)dataRow["ColumnName"]; //+ "<C" + i + "/>";
                    // Add the column definition to the data table
                    DataColumn column = new DataColumn(columnName, (Type)dataRow["DataType"]);
                    dataTable.Columns.Add(column);
                }

                dataSet.Tables.Add(dataTable);

                // Fill the data table we just created

                while (reader.Read())
                {
                    DataRow dataRow = dataTable.NewRow();

                    for (int i = 0; i < reader.FieldCount; i++)
                        dataRow[i] = reader.GetValue(i);

                    dataTable.Rows.Add(dataRow);
                }
            }
            else
            {
                // No records were returned

                DataColumn column = new DataColumn("RowsAffected");
                dataTable.Columns.Add(column);
                dataSet.Tables.Add(dataTable);
                DataRow dataRow = dataTable.NewRow();
                dataRow[0] = reader.RecordsAffected;
                dataTable.Rows.Add(dataRow);
            }
        }
        while (reader.NextResult());
        return dataSet;
    }

    #endregion

    private SqlParameter createSqlParameter(string name, object value)
    {
        SqlParameter objSqlParameter = new SqlParameter(name, value);
        return objSqlParameter;
    }
}


  #region Name Value Pair and List...
public class NameValuePairList : List<NameValuePair>
{

}

public class NameValuePair
{
    object _value;

    public NameValuePair(string iName, object iValue)
    {
        GetName = iName;
        _value = iValue;
    }

    public string GetName { get; set; }

    public object getValue
    {
        get { return _value; }
        set { _value = value; }
    }
}
#endregion
}