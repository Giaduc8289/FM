using System;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using System.Collections;

/// <summary>
/// Summary description for Databaseconnect 
/// </summary>


public class Databaseconnect 
{
    static string Connect = System.Configuration.ConfigurationSettings.AppSettings["Main.ConnectionString"].ToString();

    public static SqlConnection GetConnection()
    {
        return new SqlConnection(Connect);
    }
    
    public DataSet QueryToDataSet(string strSQL)
    {
        DataSet dtbTmp = new DataSet();

        try
        {
            // Mở kết nối
            SqlDataAdapter da = new SqlDataAdapter(strSQL, Databaseconnect .GetConnection());
            DataSet ds = new DataSet();// Tạo DataSet
            da.Fill(ds, "GetData");// Đổ dữ liệu DataSet
            dtbTmp = ds;// Tạo DataSet từ dataSet

        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);// Bắt lỗi
        }

        return dtbTmp;
    }

    public DataSet myDataSet(string strQuerry)
    {

        SqlDataAdapter da = new SqlDataAdapter();
        DataSet dt = new DataSet();

        try
        {

            SqlCommand cmd = new SqlCommand(strQuerry, Databaseconnect .GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            da.SelectCommand = cmd;
            da.Fill(dt);

        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);// Bắt lỗi
        }

        return dt;
    }

    public DataSet myDataSet(string store, params object[] paramater)
    {
        DataSet myDataSet = new DataSet();
        myDataSet.Clear();
        SqlDataAdapter myAdapter = new SqlDataAdapter();
        SqlCommand myCon = new SqlCommand(store, Databaseconnect.GetConnection());
        myCon = addParamater(store, paramater);
        myCon.CommandType = CommandType.StoredProcedure;
        myCon.CommandTimeout = 0;
        myAdapter.SelectCommand = myCon;
        myAdapter.Fill(myDataSet);
        return myDataSet;
    }

    public DataTable myTable(string strQuerry)
    {

        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();

        try
        {

            SqlCommand cmd = new SqlCommand(strQuerry, Databaseconnect.GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            da.SelectCommand = cmd;
            da.Fill(dt);

        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);// Bắt lỗi
        }

        return dt;
    }

    public DataTable myTable(string store, params object[] paramater)
    {
        DataTable myTable = new DataTable();
        SqlDataAdapter myAdapter = new SqlDataAdapter();
        SqlCommand myCon = new SqlCommand(store, Databaseconnect.GetConnection());
        myCon = addParamater(store, paramater);
        myCon.CommandType = CommandType.StoredProcedure;
        myCon.CommandTimeout = 0;
        myAdapter.SelectCommand = myCon;
        myAdapter.Fill(myTable);
        return myTable;
    }

    public static SqlCommand addParamater(string strQuery, params Object[] paramater)
    {
        SqlCommand myComm = new SqlCommand(strQuery, Databaseconnect .GetConnection());
        for (int i = 0; i < paramater.Length; i += 2)
        {
            myComm.Parameters.Add(paramater[i].ToString(), paramater[i + 1]);
        }
        return myComm;
    }

    public static bool RunQuery(string strQuery, params Object[] paramater)
    {

        SqlCommand myCon = addParamater(strQuery, paramater);
        myCon.Connection.Open();
        myCon.CommandType = CommandType.StoredProcedure;
        try
        {
            myCon.ExecuteNonQuery();
            myCon.Connection.Close();
            return true;
        }
        catch (SqlException ex)
        {
            throw ex;
            return false;
        }
    }

    public static DataSet Fill(DataSet table, String sql, params Object[] parameters)
    {
        SqlCommand command = Databaseconnect.CreateCommand(sql, parameters);
        command.Connection.Open();
        new SqlDataAdapter(command).Fill(table);
        command.Connection.Close();
        return table;
    }

    public static DataSet GetData(String sql, params Object[] parameters)
    {
        return Databaseconnect .Fill(new DataSet(), sql, parameters);
    }

    public static int ExecuteNonQuery(String sql, params Object[] parameters)
    {

        SqlCommand command = Databaseconnect .CreateCommand(sql, parameters);
        command.Connection.Open();
        int rows = command.ExecuteNonQuery();
        command.Connection.Close();
        return rows;

    }

    public static object ExecuteScalar(String sql, params Object[] parameters)
    {

        SqlCommand command = Databaseconnect .CreateCommand(sql, parameters);
        command.Connection.Open();
        object value = command.ExecuteScalar();
        command.Connection.Close();

        return value;
    }

    private static SqlCommand CreateCommand(String sql, params Object[] parameters)
    {

        SqlCommand command = new SqlCommand(sql, Databaseconnect .GetConnection());
        for (int i = 0; i < parameters.Length; i += 2)
        {
            command.Parameters.AddWithValue(parameters[i].ToString(), parameters[i + 1]);
        }

        return command;
    }

    // bo sung
    #region ExecuteSQL
    public static void ExecuteSQL(string SQL)
    {
        SqlConnection Conn = new SqlConnection(Connect);
        Conn.Open();
        SqlCommand Cmd = new SqlCommand(SQL, Conn);
        Cmd.CommandTimeout = 0;
        Cmd.ExecuteNonQuery();
        Cmd.Dispose();
        Conn.Close();
    }
    #endregion //ExecuteSQL

    public static DataTable getDataTable(string SQL)
    {

        SqlConnection Conn = new SqlConnection(Connect);
        Conn.Open();
        SqlDataAdapter Ad = new SqlDataAdapter(SQL, Conn);
        DataSet Ds = new DataSet();
        try
        {
            Ad.Fill(Ds);
            return Ds.Tables[0];
        }
        finally
        {
            Ad.Dispose();
            Conn.Close();
        }
    }
   
}


