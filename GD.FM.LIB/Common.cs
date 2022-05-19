using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace TBNET.ERP.LIB
{
    public class Common
    {
        public Common()
        { 
            
        }
        public static DataRow CheckData(string strMaPK, DataTable _DT, string FieldName)
        {
            DataTable _Temp = new DataTable();
            try
            {
                _Temp = _DT.Select(FieldName + "='" + strMaPK + "'").CopyToDataTable();
            }
            catch { }
            if (_Temp.Rows.Count > 0)
            {
                return _Temp.Rows[0];
            }
            return null;
        }
        public static DataTable Return_table(string[] _string, string Col_Table_Name, string Col_Value, string Col_Value_Name)
        {
            DataTable DT_RETURN = new DataTable();
            DT_RETURN.Columns.Add(Col_Table_Name, typeof(string));
            DT_RETURN.Columns.Add(Col_Value, typeof(string));
            DT_RETURN.Columns.Add(Col_Value_Name, typeof(string));
            for (int i = 0; i < _string.Length; i++)
            {
                if (!string.IsNullOrEmpty(_string[i]))
                {
                    DataRow R_DT = DT_RETURN.NewRow();
                    R_DT[Col_Table_Name] = _string[i].ToString();
                    DT_RETURN.Rows.Add(R_DT);
                }
            }
            return DT_RETURN;
        }
    }
}
