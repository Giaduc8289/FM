using System;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.IO;

namespace GD.FM.CONTROL
{
  public class IO
  {
    public static string ReadNewsletterTemplate(string path)
    {
      StreamReader streamReader = File.OpenText(path);
      string str = streamReader.ReadToEnd();
      streamReader.Close();
      return str;
    }

    public static DataTable ReadExcelToDataTable(string excelFile, string sheetName)
    {
      string cmdText = "select * from [" + sheetName + "$]";
      OleDbConnection connection = new OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0;data source=" + excelFile + ";Extended Properties=Excel 8.0;");
      connection.Open();
      OleDbCommand oleDbCommand = new OleDbCommand(cmdText, connection);
      OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter();
      oleDbDataAdapter.SelectCommand = oleDbCommand;
      DataTable dataTable = new DataTable();
      oleDbDataAdapter.FillSchema(dataTable, SchemaType.Source);
      ((DbDataAdapter) oleDbDataAdapter).Fill(dataTable);
      oleDbDataAdapter.Dispose();
      connection.Close();
      connection.Dispose();
      return dataTable;
    }

    public static DataView ReadXML(string strpathfilename)
    {
      DataSet dataSet = new DataSet();
      FileStream fileStream = new FileStream(strpathfilename, FileMode.Open, FileAccess.Read);
      StreamReader streamReader = new StreamReader(strpathfilename);
      try
      {
        int num = (int) dataSet.ReadXml((Stream) fileStream);
        DataView defaultView = dataSet.Tables[0].DefaultView;
      }
      catch (Exception ex)
      {
        streamReader.Dispose();
        fileStream.Dispose();
        streamReader.Close();
        fileStream.Close();
      }
      finally
      {
        streamReader.Dispose();
        fileStream.Dispose();
        streamReader.Close();
        fileStream.Close();
      }
      return dataSet.Tables[0].DefaultView;
    }

    public static DataSet ReadXML2(string strpathfilename)
    {
      DataSet dataSet = new DataSet();
      FileStream fileStream = new FileStream(strpathfilename, FileMode.Open, FileAccess.Read);
      StreamReader streamReader = new StreamReader(strpathfilename);
      try
      {
        int num = (int) dataSet.ReadXml((Stream) fileStream);
        DataView defaultView = dataSet.Tables[0].DefaultView;
      }
      catch (Exception ex)
      {
        streamReader.Dispose();
        fileStream.Dispose();
        streamReader.Close();
        fileStream.Close();
      }
      finally
      {
        streamReader.Dispose();
        fileStream.Dispose();
        streamReader.Close();
        fileStream.Close();
      }
      return dataSet;
    }

    public static void GenXML(string path, DataSet ds)
    {
      FileInfo fileInfo = new FileInfo(path);
      if (fileInfo.Exists)
        fileInfo.Delete();
      ds.WriteXml(path, XmlWriteMode.WriteSchema);
    }

    public static DataTable ReadXMLTOW(string strpathfilename)
    {
      DataSet dataSet = new DataSet();
      FileStream fileStream = new FileStream(strpathfilename, FileMode.Open, FileAccess.Read);
      StreamReader streamReader = new StreamReader(strpathfilename);
      try
      {
        int num = (int) dataSet.ReadXml((Stream) fileStream);
        DataView defaultView = dataSet.Tables[0].DefaultView;
      }
      catch (Exception ex)
      {
        streamReader.Dispose();
        fileStream.Dispose();
        streamReader.Close();
        fileStream.Close();
      }
      finally
      {
        streamReader.Dispose();
        fileStream.Dispose();
        streamReader.Close();
        fileStream.Close();
      }
      return dataSet.Tables[0];
    }

    public static void CopyFile(string SourceFile, string DestinationFile)
    {
      File.Copy(SourceFile, DestinationFile, true);
    }

    public static void CopyFile(string SourceFile, string DestinationFile, bool OverWrite)
    {
      File.Copy(SourceFile, DestinationFile, OverWrite);
    }
  }
}
