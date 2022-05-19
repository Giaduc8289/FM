using System;
using System.Collections;
using System.Collections.Specialized;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace GD.FM.LIB
{
  public class SimpleStoredProcedure
  {
    private string myConnectionString;
    private SqlConnection Connection;
    private SqlCommand comm;
    private SqlParameter samparam;

    public SimpleStoredProcedure(string ConnectionString)
    {
      this.myConnectionString = ConnectionString;
      this.Connection = new SqlConnection(this.myConnectionString);
      this.comm = new SqlCommand();
      this.samparam = new SqlParameter();
    }

    public DataSet ExecuteSPReader(string StoredProcedure, string tableName, params DictionaryEntry[] ParamName)
    {
      this.comm = new SqlCommand(StoredProcedure);
      this.comm.CommandType = CommandType.StoredProcedure;
      foreach (DictionaryEntry dictionaryEntry in ParamName)
        this.comm.Parameters.AddWithValue(dictionaryEntry.Key.ToString(), dictionaryEntry.Value);
      SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
      sqlDataAdapter.SelectCommand = this.comm;
      sqlDataAdapter.SelectCommand.Connection = this.Connection;
      this.Connection.Open();
      DataSet dataSet = new DataSet();
      try
      {
        sqlDataAdapter.Fill(dataSet, tableName);
      }
      finally
      {
        this.Connection.Close();
      }
      return dataSet;
    }

    public DataSet ExecuteSPReader(int TimeOut, string StoredProcedure, string tableName, params DictionaryEntry[] ParamName)
    {
      this.comm = new SqlCommand(StoredProcedure);
      this.comm.CommandType = CommandType.StoredProcedure;
      this.comm.CommandTimeout = TimeOut;
      foreach (DictionaryEntry dictionaryEntry in ParamName)
        this.comm.Parameters.AddWithValue(dictionaryEntry.Key.ToString(), dictionaryEntry.Value);
      SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
      sqlDataAdapter.SelectCommand = this.comm;
      sqlDataAdapter.SelectCommand.Connection = this.Connection;
      this.Connection.Open();
      DataSet dataSet = new DataSet();
      try
      {
        sqlDataAdapter.Fill(dataSet, tableName);
      }
      finally
      {
        this.Connection.Close();
      }
      return dataSet;
    }

    public object ExecuteScalarSP(string StoredProcedure, params DictionaryEntry[] ParamName)
    {
      this.comm = new SqlCommand(StoredProcedure);
      this.comm.CommandType = CommandType.StoredProcedure;
      this.comm.Parameters.Add("RETURN_VALUE", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
      foreach (DictionaryEntry dictionaryEntry in ParamName)
        this.comm.Parameters.AddWithValue(dictionaryEntry.Key.ToString(), dictionaryEntry.Value);
      this.Connection.Open();
      SqlDataReader sqlDataReader = (SqlDataReader) null;
      try
      {
        this.comm.Connection = this.Connection;
        sqlDataReader = this.comm.ExecuteReader();
      }
      finally
      {
        this.Connection.Close();
      }
      return this.comm.Parameters["RETURN_VALUE"].Value;
    }

    //public static DataTable TOP_mathanggiaodichquay(string strParam_masieuthi, string strParam_manganh)
    //{
    //  SimpleStoredProcedure simpleStoredProcedure = new SimpleStoredProcedure(ConfigurationManager.AppSettings.Get(DataAccessAdapter.ConnectionStringKeyName));
    //  ListDictionary listDictionary = new ListDictionary();
    //  listDictionary.Add((object) new SqlParameter("@strParam_masieuthi", SqlDbType.NVarChar, 4000), (object) strParam_masieuthi);
    //  listDictionary.Add((object) new SqlParameter("@strParam_manganh", SqlDbType.NVarChar, 20), (object) strParam_manganh);
    //  DictionaryEntry[] dictionaryEntryArray = new DictionaryEntry[listDictionary.Count];
    //  listDictionary.CopyTo((Array) dictionaryEntryArray, 0);
    //  return simpleStoredProcedure.ExecuteSPReader("TOP_mathanggiaodichquay", "TOP_mathanggiaodichquay", dictionaryEntryArray).Tables[0];
    //}

    //public static DataTable TOP_mathanggiaodichquay_NGANH(string strParam_masieuthi, string strParam_manganh)
    //{
    //  SimpleStoredProcedure simpleStoredProcedure = new SimpleStoredProcedure(ConfigurationManager.AppSettings.Get(DataAccessAdapter.ConnectionStringKeyName));
    //  ListDictionary listDictionary = new ListDictionary();
    //  listDictionary.Add((object) new SqlParameter("@strParam_masieuthi", SqlDbType.NVarChar, 4000), (object) strParam_masieuthi);
    //  listDictionary.Add((object) new SqlParameter("@strParam_manganh", SqlDbType.NVarChar, 20), (object) strParam_manganh);
    //  DictionaryEntry[] dictionaryEntryArray = new DictionaryEntry[listDictionary.Count];
    //  listDictionary.CopyTo((Array) dictionaryEntryArray, 0);
    //  return simpleStoredProcedure.ExecuteSPReader("TOP_mathanggiaodichquay_NGANH", "TOP_mathanggiaodichquay_NGANH", dictionaryEntryArray).Tables[0];
    //}

    //public static DataTable XNT_XUAT_BAN_LE_update_xnt_mathangkhohang(string TABLE_NAME, string Magdquaypk, string Manganhhang, string Col_SL, string Col_GT, int Loaigiaodich, string DB_NAME, string DB_NAME_XNT)
    //{
    //  SimpleStoredProcedure simpleStoredProcedure = new SimpleStoredProcedure(ConfigurationManager.AppSettings.Get(DataAccessAdapter.ConnectionStringKeyName));
    //  ListDictionary listDictionary = new ListDictionary();
    //  listDictionary.Add((object) new SqlParameter("@TABLE_NAME", SqlDbType.NVarChar, 100), (object) TABLE_NAME);
    //  listDictionary.Add((object) new SqlParameter("@Magdquaypk", SqlDbType.NVarChar, 50), (object) Magdquaypk);
    //  listDictionary.Add((object) new SqlParameter("@Manganhhang", SqlDbType.NVarChar, 20), (object) Manganhhang);
    //  listDictionary.Add((object) new SqlParameter("@Col_SL", SqlDbType.NVarChar, 50), (object) Col_SL);
    //  listDictionary.Add((object) new SqlParameter("@Col_GT", SqlDbType.NVarChar, 50), (object) Col_GT);
    //  listDictionary.Add((object) new SqlParameter("@Loaigiaodich", SqlDbType.Int, 0), (object) Loaigiaodich);
    //  listDictionary.Add((object) new SqlParameter("@DB_NAME", SqlDbType.NVarChar, 50), (object) DB_NAME);
    //  listDictionary.Add((object) new SqlParameter("@DB_NAME_XNT", SqlDbType.NVarChar, 50), (object) DB_NAME_XNT);
    //  DictionaryEntry[] dictionaryEntryArray = new DictionaryEntry[listDictionary.Count];
    //  listDictionary.CopyTo((Array) dictionaryEntryArray, 0);
    //  return simpleStoredProcedure.ExecuteSPReader("XNT_XUAT_BAN_LE_update_xnt_mathangkhohang", "XNT_XUAT_BAN_LE_update_xnt_mathangkhohang", dictionaryEntryArray).Tables[0];
    //}

    //public static DataTable XNT_XUAT_BAN_LE_AM_update_xnt_mathangkhohang(string TABLE_NAME, string Magdquaypk, string Manganhhang, string Col_SL, string Col_GT, int Loaigiaodich, string DB_NAME, string DB_NAME_XNT)
    //{
    //  SimpleStoredProcedure simpleStoredProcedure = new SimpleStoredProcedure(ConfigurationManager.AppSettings.Get(DataAccessAdapter.ConnectionStringKeyName));
    //  ListDictionary listDictionary = new ListDictionary();
    //  listDictionary.Add((object) new SqlParameter("@TABLE_NAME", SqlDbType.NVarChar, 100), (object) TABLE_NAME);
    //  listDictionary.Add((object) new SqlParameter("@Magdquaypk", SqlDbType.NVarChar, 50), (object) Magdquaypk);
    //  listDictionary.Add((object) new SqlParameter("@Manganhhang", SqlDbType.NVarChar, 20), (object) Manganhhang);
    //  listDictionary.Add((object) new SqlParameter("@Col_SL", SqlDbType.NVarChar, 50), (object) Col_SL);
    //  listDictionary.Add((object) new SqlParameter("@Col_GT", SqlDbType.NVarChar, 50), (object) Col_GT);
    //  listDictionary.Add((object) new SqlParameter("@Loaigiaodich", SqlDbType.Int, 0), (object) Loaigiaodich);
    //  listDictionary.Add((object) new SqlParameter("@DB_NAME", SqlDbType.NVarChar, 50), (object) DB_NAME);
    //  listDictionary.Add((object) new SqlParameter("@DB_NAME_XNT", SqlDbType.NVarChar, 50), (object) DB_NAME_XNT);
    //  DictionaryEntry[] dictionaryEntryArray = new DictionaryEntry[listDictionary.Count];
    //  listDictionary.CopyTo((Array) dictionaryEntryArray, 0);
    //  return simpleStoredProcedure.ExecuteSPReader("XNT_XUAT_BAN_LE_AM_update_xnt_mathangkhohang", "XNT_XUAT_BAN_LE_AM_update_xnt_mathangkhohang", dictionaryEntryArray).Tables[0];
    //}

    //public static DataTable XNT_NHAP_BAN_LE_update_xnt_mathangkhohang(string TABLE_NAME, string Magdquaypk, string Manganhhang, string Col_SL, string Col_GT, int Loaigiaodich, string DB_NAME, string DB_NAME_XNT)
    //{
    //  SimpleStoredProcedure simpleStoredProcedure = new SimpleStoredProcedure(ConfigurationManager.AppSettings.Get(DataAccessAdapter.ConnectionStringKeyName));
    //  ListDictionary listDictionary = new ListDictionary();
    //  listDictionary.Add((object) new SqlParameter("@TABLE_NAME", SqlDbType.NVarChar, 100), (object) TABLE_NAME);
    //  listDictionary.Add((object) new SqlParameter("@Magdquaypk", SqlDbType.NVarChar, 50), (object) Magdquaypk);
    //  listDictionary.Add((object) new SqlParameter("@Manganhhang", SqlDbType.NVarChar, 20), (object) Manganhhang);
    //  listDictionary.Add((object) new SqlParameter("@Col_SL", SqlDbType.NVarChar, 50), (object) Col_SL);
    //  listDictionary.Add((object) new SqlParameter("@Col_GT", SqlDbType.NVarChar, 50), (object) Col_GT);
    //  listDictionary.Add((object) new SqlParameter("@Loaigiaodich", SqlDbType.Int, 0), (object) Loaigiaodich);
    //  listDictionary.Add((object) new SqlParameter("@DB_NAME", SqlDbType.NVarChar, 50), (object) DB_NAME);
    //  listDictionary.Add((object) new SqlParameter("@DB_NAME_XNT", SqlDbType.NVarChar, 50), (object) DB_NAME_XNT);
    //  DictionaryEntry[] dictionaryEntryArray = new DictionaryEntry[listDictionary.Count];
    //  listDictionary.CopyTo((Array) dictionaryEntryArray, 0);
    //  return simpleStoredProcedure.ExecuteSPReader("XNT_NHAP_BAN_LE_update_xnt_mathangkhohang", "XNT_NHAP_BAN_LE_update_xnt_mathangkhohang", dictionaryEntryArray).Tables[0];
    //}
  }
}
