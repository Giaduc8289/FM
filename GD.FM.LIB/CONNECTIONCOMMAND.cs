using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OracleClient;
using System.Windows.Forms;

namespace TBNET.ERP.LIB
{
    public class CONNECTIONCOMMAND
    {
        public static string ACTION_D = "D";
        public static string ACTION_I_U = "U";
        public static string ACTION_I_V = "V";
        public static string ACTION_TRALUONG = "TRALUONG";
        public static string ConnectionString = System.Configuration.ConfigurationSettings.AppSettings.Get(
                                    DAL.DatabaseSpecific.DataAccessAdapter.ConnectionStringKeyName);
        public static void EXEC_QUERY(string file, char endquery)
        {
            try
            {
                 string sqlQuery = TBNET.ERP.LIB.TextFiles.ReadFile(file);
                OracleConnection conn = new OracleConnection(ConnectionString);
                string[] eachSqlQuery = sqlQuery.Split(endquery);
                foreach (string exe_query in eachSqlQuery)
                {
                    if (!string.IsNullOrEmpty(exe_query) && exe_query.Length > 10)
                    {
                        OracleCommand cmd = new OracleCommand(TBNet.Project.BL.UnicodeConversion.TCVNtoUnicode(exe_query), conn);
                        cmd.CommandType = CommandType.Text;
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();
                    }
                }
            }
            catch { MessageBox.Show("Lỗi khi chạy câu lệnh SQL! " + file); }
            // moi lan chi chay duoc mot cau lenh. Quy tac la ko co' dau' ; o~ cuoi cau lenh
            // vi du create 1 table thi` bo~ dau' ; di
            // neu tao nhieu` table 1 luc thi` cat chuoi~ = dau ; va` moi lan lap thi tao 1 bang            
        }
        public static DataSet EXECUTE_BY_SQL(Dictionary<string, string> dictSqlSelect)
        {
            OracleConnection conn = new OracleConnection(ConnectionString);
            OracleCommand cmd = new OracleCommand();
            DataSet dsSourceTemp = new DataSet();
            cmd.Connection = conn;
            OracleParameter[] arrParam = new OracleParameter[dictSqlSelect.Count];
            #region KHOI TAO arrParam
            int i = 0;
            foreach (string key in dictSqlSelect.Keys)
            {
                arrParam[i] = new OracleParameter("Ret" + i, OracleType.Cursor);
                arrParam[i].Direction = ParameterDirection.Output;
                i++;
            }
            cmd.Parameters.AddRange(arrParam);
            cmd.CommandType = CommandType.Text;
            #endregion
            #region READ FILE.SQL 
            string sqlSelect = "Begin ";
            i = 0;
            foreach (string key in dictSqlSelect.Keys)
            {
                //Neu ko thay dau ; o cuoi cau select thi them vao de ko bi loi
                if (!dictSqlSelect[key].Trim().EndsWith(";")) dictSqlSelect[key] = dictSqlSelect[key] + ";";
                sqlSelect += "OPEN :Ret" + i + " FOR " + dictSqlSelect[key] + " ";  //chu y SqlSelect phai ket thuc bang dau ";"
                i++;
            }
            sqlSelect += "end; ";
            #endregion
            cmd.CommandText = sqlSelect;
            OracleDataAdapter adapter = new OracleDataAdapter(cmd);
            try
            {
                adapter.Fill(dsSourceTemp);
                //Load table name
                if (dictSqlSelect.Count == dsSourceTemp.Tables.Count)
                {
                    i = 0;
                    foreach (string key in dictSqlSelect.Keys)
                    {
                        dsSourceTemp.Tables[i].TableName = key;
                        i++;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi khi lên báo cáo!\n"+ex.Message, "Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            return dsSourceTemp;
        }
        private static DataTable EXECUTE_STORE_PROCEDURE_RDT(string STORE_PROCEDURE_NAME, string TABLENAME, params DictionaryEntry[] ParamName)
        {
            return EXECUTE_STORE_PROCEDURE(STORE_PROCEDURE_NAME, TABLENAME, ParamName).Tables[0];
        }
        private static DataSet EXECUTE_STORE_PROCEDURE(string STORE_PROCEDURE_NAME, string TABLENAME, params DictionaryEntry[] ParamName)
        {
            OracleConnection conn = new OracleConnection(ConnectionString);
            OracleCommand cmd = new OracleCommand(STORE_PROCEDURE_NAME, conn);
            foreach (DictionaryEntry paramV in ParamName)
            {
                cmd.Parameters.AddWithValue(paramV.Key.ToString(), paramV.Value);
            }
            cmd.CommandType = CommandType.StoredProcedure;
            conn.Open();
            OracleDataAdapter adapter = new OracleDataAdapter(cmd);
            DataSet resultDS = new DataSet();
            try
            {
                adapter.Fill(resultDS, TABLENAME);
            }
            finally
            {
                conn.Close();
            }
            return resultDS;
        }
        public static string STORE_CTUGOC_QUYCTKT(string ACTION, string P_MACTKTPK)
        {
            string P_out = "0";            
            OracleConnection conn = new OracleConnection(ConnectionString);
            OracleCommand cmd = new OracleCommand("CTUGOC_QUYCTKT", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("P_ACTION", OracleType.VarChar).Value = ACTION;
            cmd.Parameters.Add("P_MACTKTPK", OracleType.VarChar).Value = P_MACTKTPK;
            cmd.Parameters.Add("P_MADONVI", OracleType.VarChar).Value = TBNET.ERP.DATA.DMDONVI._Current.Madonvi;
            OracleParameter P1 = new OracleParameter("P_RETURN_NUMBER", P_out);
            P1.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(P1);
            conn.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            finally
            {
                conn.Close();
            }
            return P1.Value.ToString();
        }
        public static string STORE_UPDATE_TONVTU(string ACTION, string P_MAVATTUGDPK)
        {
            string P_out = "0";
            OracleConnection conn = new OracleConnection(ConnectionString);
            OracleCommand cmd = new OracleCommand("UPDATE_TON_VTU", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("P_FUNC", OracleType.VarChar).Value = ACTION;
            cmd.Parameters.Add("P_MAGD", OracleType.VarChar).Value = P_MAVATTUGDPK;
            cmd.Parameters.Add("P_MADONVI", OracleType.VarChar).Value = TBNET.ERP.DATA.DMDONVI._Current.Madonvi;
            OracleParameter P1 = new OracleParameter("P_RETURN_NUMBER", P_out);
            P1.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(P1);
            conn.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            finally
            {
                conn.Close();
            }
            return P1.Value.ToString();
        }
        public static void STORE_TINHLUONG(string ACTION, string TUNGAY, string DENNGAY, string MABANGLUONG,string THANG, string NAM)
        {
            OracleConnection conn = new OracleConnection(ConnectionString);
            OracleCommand cmd = new OracleCommand("PROC_TINHLUONG", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("P_MADONVI", OracleType.VarChar).Value = TBNET.ERP.DATA.DMDONVI._Current.Madonvi;
            cmd.Parameters.Add("P_TUNGAY", OracleType.VarChar).Value = TUNGAY;
            cmd.Parameters.Add("P_DENNGAY", OracleType.VarChar).Value = DENNGAY;
            cmd.Parameters.Add("P_MABANGLUONG", OracleType.VarChar).Value = MABANGLUONG;
            cmd.Parameters.Add("P_THANG", OracleType.VarChar).Value = THANG;
            cmd.Parameters.Add("P_NAM", OracleType.VarChar).Value = NAM;
            cmd.Parameters.Add("P_ACTION", OracleType.VarChar).Value = ACTION;
            conn.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch { }
            finally
            {
                conn.Close();
            }
        }
        public static void STORE_UPDATE_DMVTHHDVCT(string ACTION,string MAKHO,string MAVTU,string SOLUONG,string GIAVON)
        {
            OracleConnection conn = new OracleConnection(ConnectionString);
            OracleCommand cmd = new OracleCommand("UPDATE_DMVTHHDVCT", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("P_MADONVI", OracleType.VarChar).Value = TBNET.ERP.DATA.DMDONVI._Current.Madonvi;
            cmd.Parameters.Add("P_MAKHO", OracleType.VarChar).Value = MAKHO;
            cmd.Parameters.Add("P_ACTION", OracleType.VarChar).Value = ACTION;
            cmd.Parameters.Add("P_MAVTU", OracleType.VarChar).Value = MAVTU;
            cmd.Parameters.Add("P_SOLUONG", OracleType.VarChar).Value = SOLUONG;
            cmd.Parameters.Add("P_GIAVON", OracleType.VarChar).Value = GIAVON;
            cmd.Parameters.Add("P_MAKY", OracleType.VarChar).Value = TBNET.ERP.DATA.DATE.NGAYHACHTOAN.Month.ToString();
            conn.Open();
            try
            {
                int i = cmd.ExecuteNonQuery();
            }
            finally
            {
                conn.Close();
            }
        }
        public static void STORE_GIAVONTUCTHI(string MADV,string MKHO,string MVTU,string NAM,string MAKY,decimal SOLUONG,decimal THANHTIEN)
        {                   
            OracleConnection conn = new OracleConnection(ConnectionString);
            OracleCommand cmd = new OracleCommand("GIAVONTUCTHOI", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("MADV", OracleType.VarChar).Value = MADV;
            cmd.Parameters.Add("MKHO", OracleType.VarChar).Value = MKHO;
            cmd.Parameters.Add("MVTU", OracleType.VarChar).Value = MVTU;
            cmd.Parameters.Add("NAM", OracleType.VarChar).Value = NAM;
            cmd.Parameters.Add("MKY", OracleType.VarChar).Value = MAKY;
            cmd.Parameters.Add("SOLUONG", OracleType.Number).Value = SOLUONG;
            cmd.Parameters.Add("TTIEN", OracleType.Number).Value = THANHTIEN; 
            conn.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            finally
            {
                conn.Close();
            }            
        }
        public static void STORE_UPDATE_TRANGTHAICT(string DONVI, string TAIKHOAN, string NAM)
        {                   
            OracleConnection conn = new OracleConnection(ConnectionString);
            OracleCommand cmd = new OracleCommand("UPDATE_TRANGTHAICT", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("DONVI", OracleType.VarChar).Value = DONVI;
            cmd.Parameters.Add("NAM", OracleType.VarChar).Value = NAM;
            cmd.Parameters.Add("TAIKHOAN", OracleType.VarChar).Value = TAIKHOAN;
            conn.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            finally
            {
                conn.Close();
            }
        }
        public static void STORE_UPDATE_TAIKHOAN(string DONVI, string TAIKHOAN, string NAM, string TAIKHOANCHA)
        {
            OracleConnection conn = new OracleConnection(ConnectionString);
            OracleCommand cmd = new OracleCommand("UPDATE_TAIKHOAN", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("DONVI", OracleType.VarChar).Value = DONVI;
            cmd.Parameters.Add("NAM", OracleType.VarChar).Value = NAM;
            cmd.Parameters.Add("TAIKHOAN", OracleType.VarChar).Value = TAIKHOAN;
            cmd.Parameters.Add("TAIKHOANCHA", OracleType.VarChar).Value = TAIKHOANCHA;
            conn.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            finally
            {
                conn.Close();
            }
        }
        public static void STORE_UPDATE_TAIKHOAN_CTUGOC(string DONVI, string TAIKHOAN, string NAM, string TAIKHOANCHA)
        {
            OracleConnection conn = new OracleConnection(ConnectionString);
            OracleCommand cmd = new OracleCommand("UPDATE_TAIKHOAN_CTUGOC", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("DONVI", OracleType.VarChar).Value = DONVI;
            cmd.Parameters.Add("NAM", OracleType.VarChar).Value = NAM;
            cmd.Parameters.Add("TAIKHOAN", OracleType.VarChar).Value = TAIKHOAN;
            cmd.Parameters.Add("TAIKHOANCHA", OracleType.VarChar).Value = TAIKHOANCHA;
            conn.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            finally
            {
                conn.Close();
            }
        }
        public static void STORE_INPUT_NHANVIEN(string DONVI, string NAM, string STRTHANG, string PBAN, decimal SONGAY, DateTime NGAY)
        {
            OracleConnection conn = new OracleConnection(ConnectionString);
            OracleCommand cmd = new OracleCommand("INPUT_NHANVIEN", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("DONVI", OracleType.VarChar).Value = DONVI;
            cmd.Parameters.Add("NAM", OracleType.VarChar).Value = NAM;
            cmd.Parameters.Add("STRTHANG", OracleType.VarChar).Value = STRTHANG;
            cmd.Parameters.Add("PBAN", OracleType.VarChar).Value = PBAN;
            cmd.Parameters.Add("SONGAY", OracleType.Number).Value = SONGAY;
            cmd.Parameters.Add("NGAY", OracleType.DateTime).Value = NGAY;
            conn.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            finally
            {
                conn.Close();
            }
        }
        public static void STORE_UPDATE_QUYCTKTCT_CTUGOC(string MATK, string MATK_OLD)
        {
            OracleConnection conn = new OracleConnection(ConnectionString);
            OracleCommand cmd = new OracleCommand("UPDATE_QUYCTKTCT_CTUGOC", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("P_MADONVI", OracleType.VarChar).Value = TBNET.ERP.DATA.DMDONVI._Current.Madonvi;
            cmd.Parameters.Add("P_MATK", OracleType.VarChar).Value = MATK;
            cmd.Parameters.Add("P_MATK_OLD", OracleType.VarChar).Value = MATK_OLD;
            conn.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch { }
            finally
            {
                conn.Close();
            }
        }        
        public static DataTable STORE_CTRINHKM(string NGAYHACHTOAN,string MALOAIGD)
        {
            OracleConnection conn = new OracleConnection(ConnectionString);
            OracleCommand cmd = new OracleCommand("CHUONGTRINHKM_ACTIVATE", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("MADONVI", OracleType.VarChar).Value = TBNET.ERP.DATA.DMDONVI._Current.Madonvi;
            cmd.Parameters.Add("NGAYHACHTOAN", OracleType.VarChar).Value = NGAYHACHTOAN;
            cmd.Parameters.Add("LOAIGIAODICH", OracleType.VarChar).Value = MALOAIGD;
            OracleParameter P1 = new OracleParameter("c",OracleType.Cursor);
            P1.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(P1);
            conn.Open();
            OracleDataAdapter adapter = new OracleDataAdapter(cmd);
            DataSet resultDS = new DataSet();
            try
            {
                adapter.Fill(resultDS);
            }
            catch { conn.Close(); return null; }
            finally
            {
                conn.Close();
            }
            return resultDS.Tables[0];
        }
        public static DataTable FILL_VATTUGD(string FROMDATE, string TODATE, string TRANGTHAI, string MANHOMPTNX)
        {
            OracleConnection conn = new OracleConnection(ConnectionString);
            OracleCommand cmd = new OracleCommand("FILL_VATTUGD", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("MADONVI", OracleType.VarChar).Value = TBNET.ERP.DATA.DMDONVI._Current.Madonvi;
            cmd.Parameters.Add("TUNGAY", OracleType.VarChar).Value = FROMDATE;
            cmd.Parameters.Add("DENNGAY", OracleType.VarChar).Value = TODATE;
            cmd.Parameters.Add("TRANGTHAI", OracleType.Number).Value = decimal.Parse(TRANGTHAI);
            cmd.Parameters.Add("MANHOMPTNX", OracleType.VarChar).Value = MANHOMPTNX;
            OracleParameter P1 = new OracleParameter("c", OracleType.Cursor);
            P1.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(P1);
            conn.Open();
            OracleDataAdapter adapter = new OracleDataAdapter(cmd);
            DataSet resultDS = new DataSet();
            try
            {
                adapter.Fill(resultDS);
            }
            catch { conn.Close(); return null; }
            finally
            {
                conn.Close();
            }
            return resultDS.Tables[0];
        }
        public static DataTable FILL_QUY(string FROMDATE, string TODATE, string MANHOMPTNX)
        {
            OracleConnection conn = new OracleConnection(ConnectionString);
            OracleCommand cmd = new OracleCommand("FILL_QUY", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("MADONVI", OracleType.VarChar).Value = TBNET.ERP.DATA.DMDONVI._Current.Madonvi;
            cmd.Parameters.Add("TUNGAY", OracleType.VarChar).Value = FROMDATE.ToString();
            cmd.Parameters.Add("DENNGAY", OracleType.VarChar).Value = TODATE.ToString();
            cmd.Parameters.Add("MANHOMPTNX", OracleType.VarChar).Value = MANHOMPTNX.ToString();
            OracleParameter P1 = new OracleParameter("c", OracleType.Cursor);
            P1.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(P1);
            conn.Open();
            OracleDataAdapter adapter = new OracleDataAdapter(cmd);
            DataSet resultDS = new DataSet();
            try
            {
                adapter.Fill(resultDS);
            }
            catch { conn.Close(); return null; }
            finally
            {
                conn.Close();
            }
            return resultDS.Tables[0];
        }
        public static DataTable FILL_VTGDCT(string FROMDATE, string TODATE, string MANHOMPTNX)
        {
            OracleConnection conn = new OracleConnection(ConnectionString);
            OracleCommand cmd = new OracleCommand("FILL_VTGDCT", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("MADONVI", OracleType.VarChar).Value = TBNET.ERP.DATA.DMDONVI._Current.Madonvi;
            cmd.Parameters.Add("TUNGAY", OracleType.VarChar).Value = FROMDATE.ToString();
            cmd.Parameters.Add("DENNGAY", OracleType.VarChar).Value = TODATE.ToString();
            cmd.Parameters.Add("MANHOMPTNX", OracleType.VarChar).Value = MANHOMPTNX.ToString();
            OracleParameter P1 = new OracleParameter("c", OracleType.Cursor);
            P1.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(P1);
            conn.Open();
            OracleDataAdapter adapter = new OracleDataAdapter(cmd);
            DataSet resultDS = new DataSet();
            try
            {
                adapter.Fill(resultDS);
            }
            catch { conn.Close(); return null; }
            finally
            {
                conn.Close();
            }
            return resultDS.Tables[0];
        }
        public static DataTable FILL_VTGD(string FROMDATE, string TODATE, string MANHOMPTNX)
        {
            OracleConnection conn = new OracleConnection(ConnectionString);
            OracleCommand cmd = new OracleCommand("FILL_VTGD", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("MADONVI", OracleType.VarChar).Value = TBNET.ERP.DATA.DMDONVI._Current.Madonvi;
            cmd.Parameters.Add("TUNGAY", OracleType.VarChar).Value = FROMDATE.ToString();
            cmd.Parameters.Add("DENNGAY", OracleType.VarChar).Value = TODATE.ToString();
            cmd.Parameters.Add("MANHOMPTNX", OracleType.VarChar).Value = MANHOMPTNX.ToString();
            OracleParameter P1 = new OracleParameter("c", OracleType.Cursor);
            P1.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(P1);
            conn.Open();
            OracleDataAdapter adapter = new OracleDataAdapter(cmd);
            DataSet resultDS = new DataSet();
            try
            {
                adapter.Fill(resultDS);
            }
            catch { conn.Close(); return null; }
            finally
            {
                conn.Close();
            }
            return resultDS.Tables[0];
        }
        public static String XNT_CHECK (string XNT_DB)
        {
            OracleConnection conn = new OracleConnection(ConnectionString);
            OracleCommand cmd = new OracleCommand("XNT_CHECK", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("P_MADONVI", OracleType.VarChar).Value = TBNET.ERP.DATA.DMDONVI._Current.Madonvi;
            cmd.Parameters.Add("DB_XNT_NAME", OracleType.VarChar).Value = "TBNETERP";
            cmd.Parameters.Add("P_TABLE_NAME", OracleType.VarChar).Value = XNT_DB;
            conn.Open();
            Int32 P_out = 1;
            OracleParameter P1 = new OracleParameter("P_N_COUNT", P_out);
            P1.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(P1);
            try
            {
                 cmd.ExecuteNonQuery();
            }
            catch { conn.Close(); return "0"; }
            finally
            {
                conn.Close();
            }
            return P1.Value.ToString();
        }
        public static void XNT_DELETE_MADONVI(string XNT_DB)
        {
            OracleConnection conn = new OracleConnection(ConnectionString);
            OracleCommand cmd = new OracleCommand("XNT_DELETE_MADONVI", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("P_MADONVI", OracleType.VarChar).Value = TBNET.ERP.DATA.DMDONVI._Current.Madonvi;
            cmd.Parameters.Add("DB_XNT_NAME", OracleType.VarChar).Value = "TBNETERP";
            cmd.Parameters.Add("P_TABLE_NAME", OracleType.VarChar).Value = XNT_DB;
            conn.Open();            
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch { conn.Close(); }
            finally
            {
                conn.Close();
            }
        }
        public static DataTable FILL_QUYCT(string FROMDATE, string TODATE, string MANHOMPTNX)
        {
            OracleConnection conn = new OracleConnection(ConnectionString);
            OracleCommand cmd = new OracleCommand("FILL_QUYCT", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("MADONVI", OracleType.VarChar).Value = TBNET.ERP.DATA.DMDONVI._Current.Madonvi;
            cmd.Parameters.Add("TUNGAY", OracleType.VarChar).Value = FROMDATE.ToString();
            cmd.Parameters.Add("DENNGAY", OracleType.VarChar).Value = TODATE.ToString();
            cmd.Parameters.Add("MANHOMPTNX", OracleType.VarChar).Value = MANHOMPTNX.ToString();
            OracleParameter P1 = new OracleParameter("c", OracleType.Cursor);
            P1.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(P1);
            conn.Open();
            OracleDataAdapter adapter = new OracleDataAdapter(cmd);
            DataSet resultDS = new DataSet();
            try
            {
                adapter.Fill(resultDS);
            }
            catch { conn.Close(); return null; }
            finally
            {
                conn.Close();
            }
            return resultDS.Tables[0];
        }
        public static DataTable FILL_VATTUGDTHANHPHAMCT(string FROMDATE, string TODATE, string MANHOMPTNX)
        {
            OracleConnection conn = new OracleConnection(ConnectionString);
            OracleCommand cmd = new OracleCommand("FILL_VATTUGDTHANHPHAMCT", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("MADONVI", OracleType.VarChar).Value = TBNET.ERP.DATA.DMDONVI._Current.Madonvi;
            cmd.Parameters.Add("TUNGAY", OracleType.VarChar).Value = FROMDATE;
            cmd.Parameters.Add("DENNGAY", OracleType.VarChar).Value = TODATE;
            cmd.Parameters.Add("MANHOMPTNX", OracleType.VarChar).Value = MANHOMPTNX;
            OracleParameter P1 = new OracleParameter("c", OracleType.Cursor);
            P1.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(P1);
            conn.Open();
            OracleDataAdapter adapter = new OracleDataAdapter(cmd);
            DataSet resultDS = new DataSet();
            try
            {
                adapter.Fill(resultDS);
            }
            catch { conn.Close(); return null; }
            finally
            {
                conn.Close();
            }
            return resultDS.Tables[0];
        }
        public static DataTable FILL_THUE(string FROMDATE, string TODATE, string MANHOMPTNX)
        {
            OracleConnection conn = new OracleConnection(ConnectionString);
            OracleCommand cmd = new OracleCommand("FILL_CTKTGTGTDVAO", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("MADONVI", OracleType.VarChar).Value = TBNET.ERP.DATA.DMDONVI._Current.Madonvi;
            cmd.Parameters.Add("TUNGAY", OracleType.VarChar).Value = FROMDATE.ToString();
            cmd.Parameters.Add("DENNGAY", OracleType.VarChar).Value = TODATE.ToString();
            cmd.Parameters.Add("MANHOMPTNX", OracleType.VarChar).Value = MANHOMPTNX.ToString();
            OracleParameter P1 = new OracleParameter("c", OracleType.Cursor);
            P1.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(P1);
            conn.Open();
            OracleDataAdapter adapter = new OracleDataAdapter(cmd);
            DataSet resultDS = new DataSet();
            try
            {
                adapter.Fill(resultDS);
            }
            catch { conn.Close(); return null; }
            finally
            {
                conn.Close();
            }
            return resultDS.Tables[0];
        }
        public static DataTable STORE_SELECT_VATTUGD(string MANHOMPTNX, string TUNGAY, string DENNGAY, string COLUMN_NAME, string COLUMN_VALUE)
        {
            OracleConnection conn = new OracleConnection(ConnectionString);
            OracleCommand cmd = new OracleCommand("P_SELECT_VATTUGD", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("P_MADONVI", OracleType.VarChar).Value = TBNET.ERP.DATA.DMDONVI._Current.Madonvi;
            cmd.Parameters.Add("P_MANHOMPTNX", OracleType.VarChar).Value = MANHOMPTNX;
            cmd.Parameters.Add("P_TUNGAY", OracleType.VarChar).Value = TUNGAY;
            cmd.Parameters.Add("P_DENNGAY", OracleType.VarChar).Value = DENNGAY;
            cmd.Parameters.Add("P_COLUMN", OracleType.VarChar).Value = COLUMN_NAME;
            cmd.Parameters.Add("P_COLUMN_VALUE", OracleType.VarChar).Value = COLUMN_VALUE;
            OracleParameter P1 = new OracleParameter("c", OracleType.Cursor);
            P1.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(P1);
            conn.Open();
            OracleDataAdapter adapter = new OracleDataAdapter(cmd);
            DataSet resultDS = new DataSet();
            try
            {
                adapter.Fill(resultDS);
            }
            catch { conn.Close(); return null; }
            finally
            {
                conn.Close();
            }
            return resultDS.Tables[0];
        }
        public static DataTable STORE_TONGHOP_BANLE(string TUNGAY, string DENNGAY,string MANHOMPTNX)
        {
            OracleConnection conn = new OracleConnection(ConnectionString);
            OracleCommand cmd = new OracleCommand("P_TONGHOP_BANLE", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("P_MADONVI", OracleType.VarChar).Value = TBNET.ERP.DATA.DMDONVI._Current.Madonvi;
            cmd.Parameters.Add("P_TUNGAY", OracleType.VarChar).Value = TUNGAY;
            cmd.Parameters.Add("P_DENNGAY", OracleType.VarChar).Value = DENNGAY;
            cmd.Parameters.Add("P_MANHOMPTNX", OracleType.VarChar).Value = MANHOMPTNX;
            OracleParameter P1 = new OracleParameter("c", OracleType.Cursor);
            P1.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(P1);
            conn.Open();
            OracleDataAdapter adapter = new OracleDataAdapter(cmd);
            DataSet resultDS = new DataSet();
            try
            {
                adapter.Fill(resultDS);
            }
            catch { conn.Close(); return null; }
            finally
            {
                conn.Close();
            }
            return resultDS.Tables[0];
        }
        public static string STORE_TINHGIAVON_KHO(string P_TUNGAY,string P_DENNGAY,string P_DENNGAY_KYTRUOC,string P_MAKY,string NAM,string P_MAKHO)
        {
            string P_out = "0";
            OracleConnection conn = new OracleConnection(ConnectionString);
            OracleCommand cmd = new OracleCommand("EXECE_GIAVON_KHO", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("P_MADONVI", OracleType.VarChar).Value = TBNET.ERP.DATA.DMDONVI._Current.Madonvi;
            cmd.Parameters.Add("P_TUNGAY", OracleType.VarChar).Value = P_TUNGAY;
            cmd.Parameters.Add("P_DENNGAY", OracleType.VarChar).Value = P_DENNGAY;
            cmd.Parameters.Add("P_DENNGAY_KYTRUOC", OracleType.VarChar).Value = P_DENNGAY_KYTRUOC;
            cmd.Parameters.Add("P_MAKHO", OracleType.VarChar).Value = P_MAKHO;
            cmd.Parameters.Add("P_MAKY", OracleType.VarChar).Value = P_MAKY;
            cmd.Parameters.Add("NAM", OracleType.VarChar).Value = NAM;
            OracleParameter P1 = new OracleParameter("P_RETURN", P_out);
            P1.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(P1);
            conn.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch { }
            finally
            {
                conn.Close();
            }
            return P1.Value.ToString();
        }
        public static DataTable KIEM_KE(string tablename, string MAKHO, string MADONVI)
        {
            OracleConnection conn = new OracleConnection(ConnectionString);
            OracleCommand cmd = new OracleCommand("KIEM_KE", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("MADONVI", OracleType.VarChar).Value = TBNET.ERP.DATA.DMDONVI._Current.Madonvi;
            cmd.Parameters.Add("TABLENAME_XNT", OracleType.VarChar).Value = tablename;
            cmd.Parameters.Add("MAKHO", OracleType.VarChar).Value = MAKHO; 
            OracleParameter P1 = new OracleParameter("c", OracleType.Cursor);
            P1.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(P1);
            conn.Open();
            OracleDataAdapter adapter = new OracleDataAdapter(cmd);
            DataSet resultDS = new DataSet();
            try
            {
                adapter.Fill(resultDS);
            }
            catch { conn.Close(); return null; }
            finally
            {
                conn.Close();
            }
            return resultDS.Tables[0];
        }
        public static void STORE_TINHGIATHANH_NO_MDV(DateTime tungay, DateTime denngay, DateTime denngaykytruoc, string maky)
        {
            OracleConnection conn = new OracleConnection(ConnectionString);
            OracleCommand cmd = new OracleCommand("EXECE_GIATHANH_NOMDV", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("tungay", OracleType.DateTime).Value = tungay;
            cmd.Parameters.Add("denngay", OracleType.DateTime).Value = denngay;
            cmd.Parameters.Add("denngaykytruoc", OracleType.DateTime).Value = denngaykytruoc;
            cmd.Parameters.Add("maky", OracleType.VarChar).Value = maky;
            cmd.Parameters.Add("mdv", OracleType.VarChar).Value = TBNET.ERP.DATA.DMDONVI._Current.Madonvi;
            conn.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            finally
            {
                conn.Close();
            }
        }

        public static void STORE_NXT(string P_MAVATTUGDPK, string NHOMPTNHAPXUAT,DateTime TODAY,DateTime B_TODAY)
        {
            string COL_SL = "", COL_GT = "", STORED_NAME = "";
            OracleConnection conn = new OracleConnection(ConnectionString);
            if (NHOMPTNHAPXUAT.Equals(TBNET.ERP.DATA.SESSION_START.N_MUA))
            { STORED_NAME = "XNT_VATTUGD_VATTUGDCT_TANG"; COL_SL = "NHAPMUASL"; COL_GT = "NHAPMUAGT"; }
            else if (NHOMPTNHAPXUAT.Equals(TBNET.ERP.DATA.SESSION_START.N_KHAU))
            { STORED_NAME = "XNT_VATTUGD_VATTUGDCT_TANG"; COL_SL = "NKHAUSL"; COL_GT = "NKHAUGT"; }
            else if (NHOMPTNHAPXUAT.Equals(TBNET.ERP.DATA.SESSION_START.N_KHAC))
            { STORED_NAME = "XNT_VATTUGD_VATTUGDCT_TANG"; COL_SL = "NKHACSL"; COL_GT = "NKHACGT"; }
            else if (NHOMPTNHAPXUAT.Equals(TBNET.ERP.DATA.SESSION_START.N_TRALAI))
            { STORED_NAME = "XNT_VATTUGD_VATTUGDCT_TANG"; COL_SL = "NTRALAISL"; COL_GT = "NTRALAIGT"; }
            else if (NHOMPTNHAPXUAT.Equals(TBNET.ERP.DATA.SESSION_START.N_NLDDANG))
            { STORED_NAME = "XNT_VATTUGD_VATTUGDCT_TANG"; COL_SL = "NDODANGSL"; COL_GT = "NDODANGGT"; }
            else if (NHOMPTNHAPXUAT.Equals(TBNET.ERP.DATA.SESSION_START.X_BAN))
            { STORED_NAME = "XNT_VATTUGD_VATTUGDCT_GIAM"; COL_SL = "XBANSL"; COL_GT = "XBANGT"; }
            else if (NHOMPTNHAPXUAT.Equals(TBNET.ERP.DATA.SESSION_START.X_DICHDANH))
            { STORED_NAME = "XNT_VATTUGD_VATTUGDCT_GIAM"; COL_SL = "XDICHDANHSL"; COL_GT = "XDICHDANHGT"; }
            else if (NHOMPTNHAPXUAT.Equals(TBNET.ERP.DATA.SESSION_START.X_KHAC))
            { STORED_NAME = "XNT_VATTUGD_VATTUGDCT_GIAM"; COL_SL = "XKHACSL"; COL_GT = "XKHACGT"; }
            else if (NHOMPTNHAPXUAT.Equals(TBNET.ERP.DATA.SESSION_START.X_SANXUAT))
            { STORED_NAME = "XNT_VATTUGD_VATTUGDCT_GIAM"; COL_SL = "XSXSL"; COL_GT = "XSXGT"; }
            //else if (NHOMPTNHAPXUAT.Equals(TBNET.ERP.DATA.SESSION_START.X_SUDUNG))
            //{ STORED_NAME = "XNT_VATTUGD_VATTUGDCT_GIAM"; COL_SL = "XBANSL"; COL_GT = "XBANGT"; }
            else if (NHOMPTNHAPXUAT.Equals(TBNET.ERP.DATA.SESSION_START.X_TRALAI))
            { STORED_NAME = "XNT_VATTUGD_VATTUGDCT_GIAM"; COL_SL = "XTRALAISL"; COL_GT = "XTRALAIGT"; }
            else if (NHOMPTNHAPXUAT.Equals(TBNET.ERP.DATA.SESSION_START.X_DIEUCHINH))
            { STORED_NAME = "XNT_VATTUGD_VATTUGDCT_GIAM"; COL_SL = "XDIEUCHINHSL"; COL_GT = "XDIEUCHINHGT"; }

            else if (NHOMPTNHAPXUAT.Equals(TBNET.ERP.DATA.SESSION_START.X_CHUYENKHO))
            { STORED_NAME = "XNT_DIEUCHUYEN"; COL_SL = "XCHUYENKHOSL"; COL_GT = "XCHUYENKHOGT"; }
            else if (NHOMPTNHAPXUAT.Equals(TBNET.ERP.DATA.SESSION_START.N_CHUYENKHO))
            { STORED_NAME = "XNT_DIEUCHUYEN"; COL_SL = "NCHUYENKHOSL"; COL_GT = "NCHUYENKHOGT"; }

            else if (NHOMPTNHAPXUAT.Equals(TBNET.ERP.DATA.SESSION_START.N_THANHPHAM))
            { STORED_NAME = "XNT_THANHPHAM"; COL_SL = "NTHANHPHAMSL"; COL_GT = "NTHANHPHAMGT"; }
            else if (NHOMPTNHAPXUAT.Equals(TBNET.ERP.DATA.SESSION_START.X_TAICHE))
            { STORED_NAME = "XNT_TAICHE"; COL_SL = "XTAICHESL"; COL_GT = "XTAICHEGT"; }
            OracleCommand cmd = new OracleCommand(STORED_NAME, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("DB_NAME", OracleType.VarChar).Value = "TBNETERP";
            cmd.Parameters.Add("DB_NAME_XNT", OracleType.VarChar).Value = "TBNETERP";
            cmd.Parameters.Add("TB_NAME_XNT", OracleType.VarChar).Value = "XNT_" + TODAY.ToString("ddMMyyyy");
            cmd.Parameters.Add("P_MAVATTUGDPK", OracleType.VarChar).Value = P_MAVATTUGDPK;
            cmd.Parameters.Add("P_MANHOMPTNX", OracleType.VarChar).Value = NHOMPTNHAPXUAT;
            cmd.Parameters.Add("COL_SL", OracleType.VarChar).Value = COL_SL;
            cmd.Parameters.Add("COL_GT", OracleType.VarChar).Value = COL_GT;
            cmd.Parameters.Add("TODAY", OracleType.DateTime).Value = TODAY;
            cmd.Parameters.Add("B_TODAY", OracleType.DateTime).Value = B_TODAY;
            cmd.Parameters.Add("P_MADONVI", OracleType.VarChar).Value = TBNET.ERP.DATA.DMDONVI._Current.Madonvi;
            conn.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch { }
            finally
            {
                conn.Close();
            }
        }

        public static DataRow STORE_SLTON(string MAVTU, string MAKHO, DateTime TODAY)
        {
            OracleConnection conn = new OracleConnection(ConnectionString);
            OracleCommand cmd = new OracleCommand("SLTON", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("P_MAVTU", OracleType.VarChar).Value = MAVTU;
            cmd.Parameters.Add("P_MAKHO", OracleType.VarChar).Value = MAKHO;
            cmd.Parameters.Add("P_TBNAME", OracleType.DateTime).Value = TODAY;
            cmd.Parameters.Add("P_MDV", OracleType.VarChar).Value = TBNET.ERP.DATA.DMDONVI._Current.Madonvi;
            OracleParameter P1 = new OracleParameter("P_RETURN", OracleType.Cursor);
            P1.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(P1);
            conn.Open();
            OracleDataAdapter adapter = new OracleDataAdapter(cmd);
            DataSet resultDS = new DataSet();
            try
            {
                adapter.Fill(resultDS);
            }
            catch { conn.Close(); return null; }
            finally
            {
                conn.Close();
            }
            DataRow dr = null;
            try
            {
                dr = resultDS.Tables[0].Rows[0];
            }
            catch { }
            return dr;
        }

        public static void STORE_KHOASO_NXT(string NHOMPTNHAPXUAT, DateTime TODAY, DateTime B_TODAY)
        {
            string COL_SL = "", COL_GT = "", STORED_NAME = "";
            OracleConnection conn = new OracleConnection(ConnectionString);
            if (NHOMPTNHAPXUAT.Equals(TBNET.ERP.DATA.SESSION_START.N_MUA))
            { STORED_NAME = "XNT_KHOASO_TANG"; COL_SL = "NHAPMUASL"; COL_GT = "NHAPMUAGT"; }
            else if (NHOMPTNHAPXUAT.Equals(TBNET.ERP.DATA.SESSION_START.N_KHAU))
            { STORED_NAME = "XNT_KHOASO_TANG"; COL_SL = "NKHAUSL"; COL_GT = "NKHAUGT"; }
            else if (NHOMPTNHAPXUAT.Equals(TBNET.ERP.DATA.SESSION_START.N_KHAC))
            { STORED_NAME = "XNT_KHOASO_TANG"; COL_SL = "NKHACSL"; COL_GT = "NKHACGT"; }
            else if (NHOMPTNHAPXUAT.Equals(TBNET.ERP.DATA.SESSION_START.N_TRALAI))
            { STORED_NAME = "XNT_KHOASO_TANG"; COL_SL = "NTRALAISL"; COL_GT = "NTRALAIGT"; }
            else if (NHOMPTNHAPXUAT.Equals(TBNET.ERP.DATA.SESSION_START.N_NLDDANG))
            { STORED_NAME = "XNT_KHOASO_TANG"; COL_SL = "NDODANGSL"; COL_GT = "NDODANGGT"; }
            else if (NHOMPTNHAPXUAT.Equals(TBNET.ERP.DATA.SESSION_START.X_BAN))
            { STORED_NAME = "XNT_KHOASO_GIAM"; COL_SL = "XBANSL"; COL_GT = "XBANGT"; }
            else if (NHOMPTNHAPXUAT.Equals(TBNET.ERP.DATA.SESSION_START.X_DICHDANH))
            { STORED_NAME = "XNT_KHOASO_GIAM"; COL_SL = "XDICHDANHSL"; COL_GT = "XDICHDANHGT"; }
            else if (NHOMPTNHAPXUAT.Equals(TBNET.ERP.DATA.SESSION_START.X_KHAC))
            { STORED_NAME = "XNT_KHOASO_GIAM"; COL_SL = "XKHACSL"; COL_GT = "XKHACGT"; }
            else if (NHOMPTNHAPXUAT.Equals(TBNET.ERP.DATA.SESSION_START.X_SANXUAT))
            { STORED_NAME = "XNT_KHOASO_GIAM"; COL_SL = "XSXSL"; COL_GT = "XSXGT"; }
            //else if (NHOMPTNHAPXUAT.Equals(TBNET.ERP.DATA.SESSION_START.X_SUDUNG))
            //{ STORED_NAME = "XNT_VATTUGD_VATTUGDCT_GIAM"; COL_SL = "XBANSL"; COL_GT = "XBANGT"; }
            else if (NHOMPTNHAPXUAT.Equals(TBNET.ERP.DATA.SESSION_START.X_TRALAI))
            { STORED_NAME = "XNT_KHOASO_GIAM"; COL_SL = "XTRALAISL"; COL_GT = "XTRALAIGT"; }
            else if (NHOMPTNHAPXUAT.Equals(TBNET.ERP.DATA.SESSION_START.X_DIEUCHINH))
            { STORED_NAME = "XNT_KHOASO_GIAM"; COL_SL = "XDIEUCHINHSL"; COL_GT = "XDIEUCHINHGT"; }

            else if (NHOMPTNHAPXUAT.Equals(TBNET.ERP.DATA.SESSION_START.X_CHUYENKHO))
            { STORED_NAME = "XNT_KHOASO_DIEUCHUYEN"; COL_SL = "XCHUYENKHOSL"; COL_GT = "XCHUYENKHOGT"; }
            else if (NHOMPTNHAPXUAT.Equals(TBNET.ERP.DATA.SESSION_START.N_CHUYENKHO))
            { STORED_NAME = "XNT_KHOASO_DIEUCHUYEN"; COL_SL = "NCHUYENKHOSL"; COL_GT = "NCHUYENKHOGT"; }

            else if (NHOMPTNHAPXUAT.Equals(TBNET.ERP.DATA.SESSION_START.N_THANHPHAM))
            { STORED_NAME = "XNT_KHOASO_THANHPHAM"; COL_SL = "NTHANHPHAMSL"; COL_GT = "NTHANHPHAMGT"; }
            else if (NHOMPTNHAPXUAT.Equals(TBNET.ERP.DATA.SESSION_START.X_TAICHE))
            { STORED_NAME = "XNT_KHOASO_TAICHE"; COL_SL = "XTAICHESL"; COL_GT = "XTAICHEGT"; }
            OracleCommand cmd = new OracleCommand(STORED_NAME, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("DB_NAME", OracleType.VarChar).Value = "TBNETERP";
            cmd.Parameters.Add("DB_NAME_XNT", OracleType.VarChar).Value = "TBNETERP";
            cmd.Parameters.Add("TB_NAME_XNT", OracleType.VarChar).Value = "XNT_" + TODAY.ToString("ddMMyyyy");
            cmd.Parameters.Add("P_MANHOMPTNX", OracleType.VarChar).Value = NHOMPTNHAPXUAT;
            cmd.Parameters.Add("COL_SL", OracleType.VarChar).Value = COL_SL;
            cmd.Parameters.Add("COL_GT", OracleType.VarChar).Value = COL_GT;
            cmd.Parameters.Add("TODAY", OracleType.DateTime).Value = TODAY;
            cmd.Parameters.Add("B_TODAY", OracleType.DateTime).Value = B_TODAY;
            cmd.Parameters.Add("P_MADONVI", OracleType.VarChar).Value = TBNET.ERP.DATA.DMDONVI._Current.Madonvi;
            conn.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch { }
            finally
            {
                conn.Close();
            }
            //XNT_UPDATE_GIAVON(TODAY, TODAY, TODAY);
        }

        public static DataTable FILL_QUY_FORM(string FROMDATE, string TODATE, string MADMLOAICT,string TRANGTHAI)
        {
            OracleConnection conn = new OracleConnection(ConnectionString);
            OracleCommand cmd = new OracleCommand("FILL_QUY_FORM", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("MADONVI", OracleType.VarChar).Value = TBNET.ERP.DATA.DMDONVI._Current.Madonvi;
            cmd.Parameters.Add("TUNGAY", OracleType.VarChar).Value = FROMDATE;
            cmd.Parameters.Add("DENNGAY", OracleType.VarChar).Value = TODATE;
            cmd.Parameters.Add("P_MALOAICT", OracleType.VarChar).Value = MADMLOAICT;
            cmd.Parameters.Add("P_TRANGTHAI", OracleType.VarChar).Value = TRANGTHAI;
            OracleParameter P1 = new OracleParameter("c", OracleType.Cursor);
            P1.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(P1);
            conn.Open();
            OracleDataAdapter adapter = new OracleDataAdapter(cmd);
            DataSet resultDS = new DataSet();
            try
            {
                adapter.Fill(resultDS);
            }
            catch { conn.Close(); return null; }
            finally
            {
                conn.Close();
            }
            return resultDS.Tables[0];
        }

        public static void XNT_UPDATE_GIAVON(DateTime TODAY, DateTime P_TUNGAY, DateTime P_DENNGAY)
        {
            OracleConnection conn = new OracleConnection(ConnectionString);
            OracleCommand cmd = new OracleCommand("XNT_UPDATE_GIAVON", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("TB_NAME", OracleType.VarChar).Value = TODAY.ToString("ddMMyyyy");
            cmd.Parameters.Add("P_MADONVI", OracleType.VarChar).Value = TBNET.ERP.DATA.DMDONVI._Current.Madonvi;
            cmd.Parameters.Add("P_TUNGAY", OracleType.DateTime).Value = P_TUNGAY;
            cmd.Parameters.Add("P_DENNGAY", OracleType.DateTime).Value = P_DENNGAY;
            conn.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch { }
            finally
            {
                conn.Close();
            }
        }

        public static void UPDATE_SOHD(string SOHD , string NGAYHD, string KYHIEUHD,string MAPK, string MADONVI)
        {
            OracleConnection conn = new OracleConnection(ConnectionString);
            string sql = "update vattugdct set " + TBNET.ERP.DAL.HelperClasses.VattugdctFields.Sohoadon.Name + "='" + SOHD + "'," + TBNET.ERP.DAL.HelperClasses.VattugdctFields.Kyhieuhoadon.Name + "='" + KYHIEUHD + "'," + TBNET.ERP.DAL.HelperClasses.VattugdctFields.Ngayhoadon.Name + "=to_date('" + NGAYHD + "','DD/MM/YYYY') where " + TBNET.ERP.DAL.HelperClasses.VattugdctFields.Mavattugdpk.Name + "='" + MAPK + "' and " + TBNET.ERP.DAL.HelperClasses.VattugdctFields.Madonvi.Name + "='" + MADONVI + "'";
            OracleCommand cmd = new OracleCommand(sql, conn);            
            conn.Open();
            try
            {
                cmd.ExecuteNonQuery();                
            }
            catch { }
            finally
            {
                conn.Close();
            }
        }

        public static DataSet LICH_THU_CHI(bool chi,string P_TUNGAY, string P_DENNGAY, string P_MAKHACHHANG,string P_MANV)
        {
            string P_MANHOMPTNX = "";
            OracleConnection conn = new OracleConnection(ConnectionString);
            OracleCommand cmd = null;
            if (chi)
            {
                P_MANHOMPTNX = " (MANHOMPTNX ='" + TBNET.ERP.DATA.SESSION_START.N_MUA + "' OR MANHOMPTNX ='" + TBNET.ERP.DATA.SESSION_START.X_TRALAI + "')";
                cmd = new OracleCommand("LICH_CHI", conn);
            }
            else { cmd = new OracleCommand("LICH_CHI", conn); P_MANHOMPTNX = " (MANHOMPTNX ='" + TBNET.ERP.DATA.SESSION_START.X_BAN + "' OR MANHOMPTNX ='" + TBNET.ERP.DATA.SESSION_START.N_TRALAI + "')"; }
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("P_MAKHACH", OracleType.VarChar).Value = P_MAKHACHHANG;
            cmd.Parameters.Add("P_MADONVI", OracleType.VarChar).Value = TBNET.ERP.DATA.DMDONVI._Current.Madonvi;
            cmd.Parameters.Add("P_TUNGAY", OracleType.VarChar).Value = P_TUNGAY;
            cmd.Parameters.Add("P_DENNGAY", OracleType.VarChar).Value = P_DENNGAY;
            cmd.Parameters.Add("P_MANHOMPTNX", OracleType.VarChar).Value = P_MANHOMPTNX;
            if (string.IsNullOrEmpty(P_MAKHACHHANG) && string.IsNullOrEmpty(P_MANV))
            {
                cmd.Parameters.Add("P_MAKHACHHANG", OracleType.VarChar).Value = "1=1";
            }
            else if (string.IsNullOrEmpty(P_MAKHACHHANG) && !string.IsNullOrEmpty(P_MANV))
            { cmd.Parameters.Add("P_MAKHACHHANG", OracleType.VarChar).Value = " VATTUGD.MANV ='" + P_MANV + "' "; }
            else if (string.IsNullOrEmpty(P_MANV) && !string.IsNullOrEmpty(P_MAKHACHHANG))
            { cmd.Parameters.Add("P_MAKHACHHANG", OracleType.VarChar).Value = " VATTUGD.MAKHACHANG ='" + P_MAKHACHHANG + "' "; }
            else if (!string.IsNullOrEmpty(P_MAKHACHHANG) && !string.IsNullOrEmpty(P_MANV))
            { cmd.Parameters.Add("P_MAKHACHHANG", OracleType.VarChar).Value = " VATTUGD.MAKHACHANG ='" + P_MAKHACHHANG + "' AND VATTUGD.MANV ='" + P_MANV + "' "; }
            OracleParameter P1 = new OracleParameter("c", OracleType.Cursor);
            P1.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(P1);
            conn.Open();
            OracleDataAdapter adapter = new OracleDataAdapter(cmd);
            DataSet resultDS = new DataSet();
            try
            {
                adapter.Fill(resultDS);
            }
            catch { return null; }
            finally
            {
                conn.Close();
            }
            return resultDS;
        }
        public static DataSet LICH_THUCHIQUY_CANTRUCN(bool chi, string P_TUNGAY, string P_DENNGAY, string P_MAKHACHHANG, string P_MANV)
        {
            OracleConnection conn = new OracleConnection(ConnectionString);
            OracleCommand cmd = null;
            cmd = new OracleCommand("LICH_THUCHIQUY_CANTRUCN", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            if (chi)
            {
                cmd.Parameters.Add("CHI", OracleType.Number).Value = 1;
            }
            else
            {
                cmd.Parameters.Add("CHI", OracleType.Number).Value = 0;
            }
            cmd.Parameters.Add("P_MADONVI", OracleType.VarChar).Value = TBNET.ERP.DATA.DMDONVI._Current.Madonvi;
            cmd.Parameters.Add("P_TUNGAY", OracleType.VarChar).Value = P_TUNGAY;
            cmd.Parameters.Add("P_DENNGAY", OracleType.VarChar).Value = P_DENNGAY;
            if (string.IsNullOrEmpty(P_MAKHACHHANG) && string.IsNullOrEmpty(P_MANV))
            {
                cmd.Parameters.Add("P_MAKHACHHANG", OracleType.VarChar).Value = "1=1";
            }
            else if (string.IsNullOrEmpty(P_MAKHACHHANG) && !string.IsNullOrEmpty(P_MANV))
            { cmd.Parameters.Add("P_MAKHACHHANG", OracleType.VarChar).Value = " CT.MANV ='" + P_MANV + "' "; }
            else if (string.IsNullOrEmpty(P_MANV) && !string.IsNullOrEmpty(P_MAKHACHHANG))
            { cmd.Parameters.Add("P_MAKHACHHANG", OracleType.VarChar).Value = " CT.MAKHACHHANG ='" + P_MAKHACHHANG + "' "; }
            else if (!string.IsNullOrEmpty(P_MAKHACHHANG) && !string.IsNullOrEmpty(P_MANV))
            { cmd.Parameters.Add("P_MAKHACHHANG", OracleType.VarChar).Value = " CT.MAKHACHHANG ='" + P_MAKHACHHANG + "' AND CT.MANV ='" + P_MANV + "' "; }
            else { cmd.Parameters.Add("P_MAKHACHHANG", OracleType.VarChar).Value = "1=1"; }
            OracleParameter P1 = new OracleParameter("c", OracleType.Cursor);
            P1.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(P1);
            conn.Open();
            OracleDataAdapter adapter = new OracleDataAdapter(cmd);
            DataSet resultDS = new DataSet();
            try
            {
                adapter.Fill(resultDS);
            }
            catch { return null; }
            finally
            {
                conn.Close();
            }
            return resultDS;
        }

        public static DataSet LICH_THU_QUY(bool chi,string P_TUNGAY,string P_DENNGAY, string P_MAKHACHHANG)
        {
            OracleConnection conn = new OracleConnection(ConnectionString);
            OracleCommand cmd = new OracleCommand("LICH_THU_QUY", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            if (chi)
            {
                cmd.Parameters.Add("CHI", OracleType.Number).Value = 1;
            }
            else
            {
                cmd.Parameters.Add("CHI", OracleType.Number).Value = 0;
            }
            cmd.Parameters.Add("P_MADONVI", OracleType.VarChar).Value = TBNET.ERP.DATA.DMDONVI._Current.Madonvi;
            cmd.Parameters.Add("P_DENNGAY", OracleType.VarChar).Value = P_DENNGAY;
            cmd.Parameters.Add("P_TUNGAY", OracleType.VarChar).Value = P_TUNGAY;
            cmd.Parameters.Add("P_MAKHACHHANG", OracleType.VarChar).Value = P_MAKHACHHANG;
            OracleParameter P1 = new OracleParameter("c", OracleType.Cursor);
            P1.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(P1);
            conn.Open();
            OracleDataAdapter adapter = new OracleDataAdapter(cmd);
            DataSet resultDS = new DataSet();
            try
            {
                adapter.Fill(resultDS);
            }
            catch { conn.Close(); return null; }
            finally
            {
                conn.Close();
            }
            return resultDS;
        }

        public static DataSet LICH_THUCHI_CANTRUCN(bool chi, string P_TUNGAY, string P_DENNGAY, string P_MAKHACHHANG, string P_MANV)
        {            
            OracleConnection conn = new OracleConnection(ConnectionString);
            OracleCommand cmd = null;
            cmd = new OracleCommand("LICH_THUCHI_CANTRUCN", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            if (chi)
            {
                cmd.Parameters.Add("CHI", OracleType.Number).Value = 1;
            }
            else
            {
                cmd.Parameters.Add("CHI", OracleType.Number).Value = 0;
            }
            cmd.Parameters.Add("P_MADONVI", OracleType.VarChar).Value = TBNET.ERP.DATA.DMDONVI._Current.Madonvi;
            cmd.Parameters.Add("P_TUNGAY", OracleType.VarChar).Value = P_TUNGAY;
            cmd.Parameters.Add("P_DENNGAY", OracleType.VarChar).Value = P_DENNGAY;
            if (string.IsNullOrEmpty(P_MAKHACHHANG) && string.IsNullOrEmpty(P_MANV))
            {
                cmd.Parameters.Add("P_MAKHACHHANG", OracleType.VarChar).Value = "1=1";
            }
            else if (string.IsNullOrEmpty(P_MAKHACHHANG) && !string.IsNullOrEmpty(P_MANV))
            { cmd.Parameters.Add("P_MAKHACHHANG", OracleType.VarChar).Value = " CT.MANV ='" + P_MANV + "' "; }
            else if (string.IsNullOrEmpty(P_MANV) && !string.IsNullOrEmpty(P_MAKHACHHANG))
            { cmd.Parameters.Add("P_MAKHACHHANG", OracleType.VarChar).Value = " CT.MAKHACHHANG ='" + P_MAKHACHHANG + "' "; }
            else if (!string.IsNullOrEmpty(P_MAKHACHHANG) && !string.IsNullOrEmpty(P_MANV))
            { cmd.Parameters.Add("P_MAKHACHHANG", OracleType.VarChar).Value = " CT.MAKHACHHANG ='" + P_MAKHACHHANG + "' AND CT.MANV ='" + P_MANV + "' "; }
            else { cmd.Parameters.Add("P_MAKHACHHANG", OracleType.VarChar).Value = "1=1"; }
            OracleParameter P1 = new OracleParameter("c", OracleType.Cursor);
            P1.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(P1);
            conn.Open();
            OracleDataAdapter adapter = new OracleDataAdapter(cmd);
            DataSet resultDS = new DataSet();
            try
            {
                adapter.Fill(resultDS);
            }
            catch { return null; }
            finally
            {
                conn.Close();
            }
            return resultDS;
        }

        public static DataSet LICH_THUCHI_SODUDK(bool chi, string P_TUNGAY, string P_MAKHACHHANG, string P_MANV)
        {
            OracleConnection conn = new OracleConnection(ConnectionString);
            OracleCommand cmd = null;
            cmd = new OracleCommand("LICH_THUCHI_SODUDK", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            if (chi)
            {
                cmd.Parameters.Add("CHI", OracleType.Number).Value = 1;
            }
            else
            {
                cmd.Parameters.Add("CHI", OracleType.Number).Value = 0;
            }
            cmd.Parameters.Add("P_MADONVI", OracleType.VarChar).Value = TBNET.ERP.DATA.DMDONVI._Current.Madonvi;
            cmd.Parameters.Add("P_TUNGAY", OracleType.VarChar).Value = P_TUNGAY;
            cmd.Parameters.Add("P_MAKHACHHANG", OracleType.VarChar).Value = P_MAKHACHHANG;
            cmd.Parameters.Add("P_MANV", OracleType.VarChar).Value = P_MANV;
            OracleParameter P1 = new OracleParameter("c", OracleType.Cursor);
            P1.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(P1);
            conn.Open();
            OracleDataAdapter adapter = new OracleDataAdapter(cmd);
            DataSet resultDS = new DataSet();
            try
            {
                adapter.Fill(resultDS);
            }
            catch { return null; }
            finally
            {
                conn.Close();
            }
            return resultDS;
        }

        public static DataSet PRO_GOPHDBANHANG(string P_MADONVI, string P_MAVATTUGDPK)
        {
            OracleConnection conn = new OracleConnection(ConnectionString);
            OracleCommand cmd = new OracleCommand("PRO_GOPHDBANHANG", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("P_MADONVI", OracleType.VarChar).Value = TBNET.ERP.DATA.DMDONVI._Current.Madonvi;
            cmd.Parameters.Add("P_MAVATTUGDPK", OracleType.VarChar).Value = P_MAVATTUGDPK;
            OracleParameter P1 = new OracleParameter("c", OracleType.Cursor);
            P1.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(P1);
            conn.Open();
            OracleDataAdapter adapter = new OracleDataAdapter(cmd);
            DataSet resultDS = new DataSet();
            try
            {
                adapter.Fill(resultDS);
            }
            catch { conn.Close(); return null; }
            finally
            {
                conn.Close();
            }
            return resultDS;
        }

        public static DataSet PRO_GOPPHIEUXK(string madonvi, string mavatugdpk)
        {
            OracleConnection conn = new OracleConnection(ConnectionString);
            OracleCommand cmd = new OracleCommand("PRO_GOPPHIEUXK", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("P_MADONVI", OracleType.VarChar).Value = TBNET.ERP.DATA.DMDONVI._Current.Madonvi;
            cmd.Parameters.Add("P_MAVATTUGDPK", OracleType.VarChar).Value = mavatugdpk;
            OracleParameter P1 = new OracleParameter("c", OracleType.Cursor);
            P1.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(P1);
            conn.Open();
            OracleDataAdapter adapter = new OracleDataAdapter(cmd);
            DataSet resultDS = new DataSet();
            try
            {
                adapter.Fill(resultDS);
            }
            catch { conn.Close(); return null; }
            finally
            {
                conn.Close();
            }
            return resultDS;
        }
        public static DataSet PRO_PHIEUBHVAT(string madonvi, string mavatugdpk)
        {
            OracleConnection conn = new OracleConnection(ConnectionString);
            OracleCommand cmd = new OracleCommand("PRO_PHIEUBHVAT", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("P_MADONVI", OracleType.VarChar).Value = TBNET.ERP.DATA.DMDONVI._Current.Madonvi;
            cmd.Parameters.Add("P_MAVATTUGDPK", OracleType.VarChar).Value = mavatugdpk;
            OracleParameter P1 = new OracleParameter("c", OracleType.Cursor);
            P1.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(P1);
            conn.Open();
            OracleDataAdapter adapter = new OracleDataAdapter(cmd);
            DataSet resultDS = new DataSet();
            try
            {
                adapter.Fill(resultDS);
            }
            catch { conn.Close(); return null; }
            finally
            {
                conn.Close();
            }
            return resultDS;
        }
        public static decimal CONGNO_KH_NV(bool khachhang, DateTime P_DENNGAY, string P_MAKHACHHANG)
        {
            OracleConnection conn = new OracleConnection(ConnectionString);
            OracleCommand cmd = null;
            if (khachhang)
            {
                cmd = new OracleCommand("CONGNO_KHACHHANG", conn);
            }
            else { cmd = new OracleCommand("CONGNO_NV", conn); }
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("P_MADONVI", OracleType.VarChar).Value = TBNET.ERP.DATA.DMDONVI._Current.Madonvi;
            cmd.Parameters.Add("P_NAM", OracleType.VarChar).Value = P_DENNGAY.Year.ToString();
            cmd.Parameters.Add("P_DENNGAY", OracleType.VarChar).Value = P_DENNGAY.ToString("dd/MM/yyyy");
            cmd.Parameters.Add("P_MAKHACHHANG", OracleType.VarChar).Value = P_MAKHACHHANG;
            OracleParameter P1 = new OracleParameter("c", OracleType.Cursor);
            P1.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(P1);
            conn.Open();
            OracleDataAdapter adapter = new OracleDataAdapter(cmd);
            DataSet resultDS = new DataSet();
            try
            {
                adapter.Fill(resultDS);
            }
            catch { return 0; }
            finally
            {
                conn.Close();
            }
            // DAU KY
            conn = new OracleConnection(ConnectionString);
            cmd = null;
            if (khachhang)
            {
                cmd = new OracleCommand("CONGNO_KHACHHANG_DAUKY", conn);
            }
            else { cmd = new OracleCommand("CONGNO_NV_DAUKY", conn); }
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("P_MADONVI", OracleType.VarChar).Value = TBNET.ERP.DATA.DMDONVI._Current.Madonvi;
            cmd.Parameters.Add("P_NAM", OracleType.VarChar).Value = P_DENNGAY.Year.ToString();
            cmd.Parameters.Add("P_DENNGAY", OracleType.VarChar).Value = P_DENNGAY.ToString("dd/MM/yyyy");
            cmd.Parameters.Add("P_MAKHACHHANG", OracleType.VarChar).Value = P_MAKHACHHANG;
            OracleParameter P2 = new OracleParameter("c", OracleType.Cursor);
            P2.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(P2);
            conn.Open();
            adapter = new OracleDataAdapter(cmd);
            DataSet resultDS2 = new DataSet();
            try
            {
                adapter.Fill(resultDS2);
            }
            catch { return 0; }
            finally
            {
                conn.Close();
            }
            decimal DAUKY_NO = 0, DAUKY_CO = 0, PS_NO = 0, PS_CO = 0, CUOIKY = 0;
            decimal.TryParse(resultDS2.Tables[0].Compute("Sum(SODUNODK)", "").ToString(), out DAUKY_NO);
            decimal.TryParse(resultDS2.Tables[0].Compute("Sum(SODUCODK)", "").ToString(), out DAUKY_CO);
            decimal.TryParse(resultDS.Tables[0].Compute("Sum(PHATSINHNO)", "").ToString(), out PS_NO);
            decimal.TryParse(resultDS.Tables[0].Compute("Sum(PHATSINHCO)", "").ToString(), out PS_CO);
            if (DAUKY_NO > 0) 
            {
                CUOIKY = DAUKY_NO + PS_NO - PS_CO;
            }
            else if (DAUKY_CO > 0)
            {
                CUOIKY = DAUKY_CO + PS_CO - PS_NO;
            }
            else { CUOIKY = PS_NO - PS_CO; }
            return CUOIKY;
        }

        public static void XOABANG(string TABLE_NAME)
        {
            OracleConnection conn = new OracleConnection(ConnectionString);
            OracleCommand cmd = null;
            cmd = new OracleCommand("XOA_BANG", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("P_TABLENAME", OracleType.VarChar).Value = TABLE_NAME;
            conn.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch { }
            finally
            {
                conn.Close();
            }
        }

        public static void BAOCAO_NGAY(DateTime NGAY, string NAM)
        {            
            OracleConnection conn = new OracleConnection(ConnectionString);
            OracleCommand cmd = null;
            cmd = new OracleCommand("BCC_EXE", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("P_MADONVI", OracleType.VarChar).Value = TBNET.ERP.DATA.DMDONVI._Current.Madonvi;
            cmd.Parameters.Add("P_DATE", OracleType.VarChar).Value = NGAY.ToString("dd/MM/yyyy");
            cmd.Parameters.Add("P_NAM", OracleType.VarChar).Value = NAM;
            cmd.Parameters.Add("P_BCPK", OracleType.VarChar).Value = NGAY.ToString("ddMMyyyy");            
            conn.Open();
            OracleDataAdapter adapter = new OracleDataAdapter(cmd);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch { }
            finally
            {
                conn.Close();
            }
        }

        public static string CHECK_DANHMUC(string P_TABLE_NAME, string P_PK, string P_COLUMNNAME)
        {
            OracleConnection conn = new OracleConnection(ConnectionString);
            OracleCommand cmd = new OracleCommand("SELECT_DATA_DANHMUC_ALL_TABLE", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("P_MADONVI", OracleType.VarChar).Value = TBNET.ERP.DATA.DMDONVI._Current.Madonvi;
            cmd.Parameters.Add("P_TABLE_NAME", OracleType.VarChar).Value = P_TABLE_NAME;
            cmd.Parameters.Add("P_COLUMNNAME", OracleType.VarChar).Value = P_COLUMNNAME;
            cmd.Parameters.Add("P_PK", OracleType.VarChar).Value = P_PK;
            conn.Open();
            Int32 P_out = 0;
            OracleParameter P1 = new OracleParameter("N_COUNT", P_out);
            P1.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(P1);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch { conn.Close(); return "0"; }
            finally
            {
                conn.Close();
            }
            return P1.Value.ToString();
        }

        public static DataTable GET_VATTUGDCT_MAPK(string MAPK, string P_KHOHANG)
        {
            OracleConnection conn = new OracleConnection(ConnectionString);
            OracleCommand cmd = new OracleCommand("GET_VATTUGDCT_MAPK", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("P_MADONVI", OracleType.VarChar).Value = TBNET.ERP.DATA.DMDONVI._Current.Madonvi;
            cmd.Parameters.Add("P_VATTUGDPK", OracleType.VarChar).Value = MAPK;
            cmd.Parameters.Add("P_KHOHANG", OracleType.VarChar).Value = P_KHOHANG;
            cmd.Parameters.Add("P_FORMAT", OracleType.VarChar).Value = TBNET.ERP.LIB.STATIC_PARAM.FormatNumber_Grid.Replace("#", "9");
            OracleParameter P1 = new OracleParameter("c", OracleType.Cursor);
            P1.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(P1);
            conn.Open();
            OracleDataAdapter adapter = new OracleDataAdapter(cmd);
            DataSet resultDS = new DataSet();
            try
            {
                adapter.Fill(resultDS);
            }
            catch { conn.Close(); return null; }
            finally
            {
                conn.Close();
            }
            return resultDS.Tables[0];
        }

        public static void TAO_XNT_NGAYMOI(DateTime TODAY, DateTime BTODAY)
        {
            OracleConnection conn = new OracleConnection(ConnectionString);
            OracleCommand cmd = null;
            cmd = new OracleCommand("XNT_CALL_CREATE_TABLE", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("P_MADONVI", OracleType.VarChar).Value = TBNET.ERP.DATA.DMDONVI._Current.Madonvi;
            cmd.Parameters.Add("TODAY", OracleType.DateTime).Value = TODAY;
            cmd.Parameters.Add("B_TODAY", OracleType.DateTime).Value = BTODAY;
            conn.Open();
            OracleDataAdapter adapter = new OracleDataAdapter(cmd);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch { }
            finally
            {
                conn.Close();
            }
        }
    }
}
