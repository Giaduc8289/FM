using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
namespace GD.FM.LIB
{
    public class DATATABLE_STATIC_PARAM
    {
        public static DataRow CheckParambyFilename(string mapram, string Filename, DataTable dt)
        {
            try
            {
                return dt.Select(Filename + "='" + mapram + "'").CopyToDataTable().Rows[0];
            }
            catch { return null; }
        }
        public static string GET_VALUE_COLUMN_EQUAL(string columnKey,string paramValue,DataTable DT,string returnColumn)
        {
            string reStr = "";
            try
            {
                reStr = DT.Select(columnKey + "='" + paramValue + "'")[0][returnColumn].ToString();
            }
            catch { }
            return reStr;
        }
        public static string GET_VALUE_COLUMN_LIKE(string columnKey, string paramValue, DataTable DT, string returnColumn)
        {
            string reStr = "";
            try
            {
                reStr = DT.Select(columnKey + " LIKE '" + paramValue + "%'")[0][returnColumn].ToString();
            }
            catch { }
            return reStr;
        }
        public static DataTable DT_TINHCHATTK(string ID, string Name)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add(ID, typeof(string));
            dt.Columns.Add(Name, typeof(string));
            DataRow R_NO = dt.NewRow(); R_NO[ID] = STATIC_PARAM.TK_DU_NO; R_NO[Name] = "Dư Nợ"; dt.Rows.Add(R_NO);
            DataRow R_CO = dt.NewRow(); R_CO[ID] = STATIC_PARAM.TK_DU_CO; R_CO[Name] = "Dư Có"; dt.Rows.Add(R_CO);
            DataRow R_LUONGTINH = dt.NewRow(); R_LUONGTINH[ID] = STATIC_PARAM.TK_LUONG_TINH; R_LUONGTINH[Name] = "Lưỡng tính"; dt.Rows.Add(R_LUONGTINH);
            DataRow R_KO_SODU = dt.NewRow(); R_KO_SODU[ID] = STATIC_PARAM.TK_KO_DU; R_KO_SODU[Name] = "Không có số dư"; dt.Rows.Add(R_KO_SODU);
            return dt;
        }
        public static DataTable DT_TKSOCAI(string ID, string Name)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add(ID, typeof(string));
            dt.Columns.Add(Name, typeof(string));
            DataRow R_CT = dt.NewRow(); R_CT[ID] = STATIC_PARAM.TK_CHI_TIET; R_CT[Name] = "Chi tiết"; dt.Rows.Add(R_CT);
            DataRow R_SC = dt.NewRow(); R_SC[ID] = STATIC_PARAM.TK_SO_CAI; R_SC[Name] = "Sổ cái"; dt.Rows.Add(R_SC);
            DataRow R_SC_CT = dt.NewRow(); R_SC_CT[ID] = STATIC_PARAM.TK_CHI_TIET_SO_CAI; R_SC_CT[Name] = "Sổ cái và chi tiết"; dt.Rows.Add(R_SC_CT);
            return dt;
        }
        public static DataTable DT_PPTINHTYGIAGS(string ID, string Name)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add(ID, typeof(string));
            dt.Columns.Add(Name, typeof(string));
            DataRow R_0 = dt.NewRow(); R_0[ID] = STATIC_PARAM.PP_KO_TINH_CHENH_LECH; R_0[Name] = "Không tính chênh lệch"; dt.Rows.Add(R_0);
            DataRow R_1 = dt.NewRow(); R_1[ID] = STATIC_PARAM.PP_TRUNG_BINH_THANG; R_1[Name] = "Trung bình tháng"; dt.Rows.Add(R_1);
            DataRow R_2 = dt.NewRow(); R_2[ID] = STATIC_PARAM.PP_TRUNG_BINH_DD; R_2[Name] = "Trung bình di động"; dt.Rows.Add(R_2);
            DataRow R_3 = dt.NewRow(); R_3[ID] = STATIC_PARAM.PP_TRUNG_BINH_NHAP_TRUOC_XUAT_TRUOC; R_3[Name] = "Nhập trước xuất trước"; dt.Rows.Add(R_3);
            DataRow R_4 = dt.NewRow(); R_4[ID] = STATIC_PARAM.PP_DICH_DANH; R_4[Name] = "Đích danh"; dt.Rows.Add(R_4);
            DataRow R_5 = dt.NewRow(); R_5[ID] = STATIC_PARAM.PP_TY_GIA_GD; R_5[Name] = "Tỷ giá giao dịch"; dt.Rows.Add(R_5);
            return dt;
        }
    }
}
