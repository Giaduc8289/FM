using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using System.Data;

namespace TBNET.ERP.LIB
{
    public class ODP_CONNECTTIONCOMMAND
    {
        public static string ConnectionString = System.Configuration.ConfigurationSettings.AppSettings.Get(
                                   DAL.DatabaseSpecific.DataAccessAdapter.ConnectionStringKeyName);
        public static string STORE_CTUGOC_QUYCTKT(string ACTION, string P_MACTKTPK)
        {
            //string P_out = "0";
            OracleConnection conn = new OracleConnection(ConnectionString);
            OracleCommand cmd = new OracleCommand("CTUGOC_QUYCTKT", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("P_ACTION", OracleDbType.Varchar2).Value = ACTION;
            cmd.Parameters.Add("P_MACTKTPK", OracleDbType.Varchar2).Value = P_MACTKTPK;
            cmd.Parameters.Add("P_MADONVI", OracleDbType.Varchar2).Value = TBNET.ERP.DATA.DMDONVI._Current.Madonvi;
            OracleParameter P1 = new OracleParameter("P_RETURN_NUMBER", OracleDbType.Varchar2, 50);
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
    }
}
