using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using KTXPT.BLL;
using KTXPT.DAL;
using KTXPT.DAL.EntityClasses;
using KTXPT.DAL.FactoryClasses;
using KTXPT.DAL.HelperClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;
namespace KTXPT.DATA
{
    public class TABLECOMM
    {
        public static string HTTH_TM_id = "TM";
        public static string HTTH_CK_id = "CK";
        public static string HTTH_TM_ten = "Tiền mặt";
        public static string HTTH_CK_ten = "Chuyển khoản";
        public static DataTable DT_HT_THANHTOAN(string ID, string Name)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add(ID, typeof(string));
            dt.Columns.Add(Name, typeof(string));
            DataRow R_TM = dt.NewRow(); R_TM[ID] = HTTH_TM_id; R_TM[Name] = HTTH_TM_ten; dt.Rows.Add(R_TM);
            DataRow R_CK = dt.NewRow(); R_CK[ID] = HTTH_CK_id; R_CK[Name] = HTTH_CK_ten; dt.Rows.Add(R_CK);
            return dt;
        }
        public static DataTable DT_TRANGTHAISUDUNG(string ID, string Name)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add(ID, typeof(string));
            dt.Columns.Add(Name, typeof(string));
            DataRow R_KHONGSUDUNG = dt.NewRow(); R_KHONGSUDUNG[ID] = "0"; R_KHONGSUDUNG[Name] = "Ngừng sử dụng"; dt.Rows.Add(R_KHONGSUDUNG);
            DataRow R_SUDUNG = dt.NewRow(); R_SUDUNG[ID] = "1"; R_SUDUNG[Name] = "Sử dụng"; dt.Rows.Add(R_SUDUNG);
            return dt;
        }
        public static DataTable DT_NGAYLAMVIEC(string ID, string Name)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add(ID, typeof(string));
            dt.Columns.Add(Name, typeof(string));
            DataRow R_KHONGSUDUNG = dt.NewRow(); R_KHONGSUDUNG[ID] = "0"; R_KHONGSUDUNG[Name] = "HOT"; dt.Rows.Add(R_KHONGSUDUNG);
            DataRow R_SUDUNG = dt.NewRow(); R_SUDUNG[ID] = "1"; R_SUDUNG[Name] = "WOT"; dt.Rows.Add(R_SUDUNG);
            DataRow R_TYLE = dt.NewRow(); R_TYLE[ID] = "2"; R_TYLE[Name] = "NOT"; dt.Rows.Add(R_TYLE);
            return dt;
        }
        public static DataTable DT_KIEUTINH(string ID, string Name)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add(ID, typeof(string));
            dt.Columns.Add(Name, typeof(string));
            DataRow R_KHONGSUDUNG = dt.NewRow(); R_KHONGSUDUNG[ID] = "0"; R_KHONGSUDUNG[Name] = "Tính theo tiền mặt"; dt.Rows.Add(R_KHONGSUDUNG);
            DataRow R_SUDUNG = dt.NewRow(); R_SUDUNG[ID] = "1"; R_SUDUNG[Name] = "Tính theo hệ số"; dt.Rows.Add(R_SUDUNG);
            DataRow R_TYLE = dt.NewRow(); R_TYLE[ID] = "2"; R_TYLE[Name] = "Tính theo tỷ lệ %"; dt.Rows.Add(R_TYLE);
            return dt;
        }
        public static DataTable DT_NGAYNGHI(string ID, string Name)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add(ID, typeof(string));
            dt.Columns.Add(Name, typeof(string));
            DataRow R_KHONGSUDUNG = dt.NewRow(); R_KHONGSUDUNG[ID] = "0"; R_KHONGSUDUNG[Name] = "Nghỉ"; dt.Rows.Add(R_KHONGSUDUNG);
            DataRow R_SUDUNG = dt.NewRow(); R_SUDUNG[ID] = "1"; R_SUDUNG[Name] = "Đi Làm"; dt.Rows.Add(R_SUDUNG);
            return dt;
        }
        public static DataTable DT_NGAYNGHIKHAC(string ID, string Name)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add(ID, typeof(string));
            dt.Columns.Add(Name, typeof(string));
            DataRow R_KHONGSUDUNG = dt.NewRow(); R_KHONGSUDUNG[ID] = "0"; R_KHONGSUDUNG[Name] = "Không sử dụng"; dt.Rows.Add(R_KHONGSUDUNG);
            DataRow R_SUDUNG = dt.NewRow(); R_SUDUNG[ID] = "1"; R_SUDUNG[Name] = "Sử dụng"; dt.Rows.Add(R_SUDUNG);
            return dt;
        }
        public static DataTable DT_GIAMTRU(string ID, string Name)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add(ID, typeof(string));
            dt.Columns.Add(Name, typeof(string));
            DataRow R_KHONGSUDUNG = dt.NewRow(); R_KHONGSUDUNG[ID] = "0"; R_KHONGSUDUNG[Name] = "Không giảm trừ"; dt.Rows.Add(R_KHONGSUDUNG);
            DataRow R_SUDUNG = dt.NewRow(); R_SUDUNG[ID] = "1"; R_SUDUNG[Name] = "Giảm trừ"; dt.Rows.Add(R_SUDUNG);
            return dt;
        }
        public static DataTable DT_NUANGAY(string ID, string Name)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add(ID, typeof(string));
            dt.Columns.Add(Name, typeof(string));
            DataRow R_KHONGSUDUNG = dt.NewRow(); R_KHONGSUDUNG[ID] = "0"; R_KHONGSUDUNG[Name] = "Nghỉ cả ngày"; dt.Rows.Add(R_KHONGSUDUNG);
            DataRow R_SUDUNG = dt.NewRow(); R_SUDUNG[ID] = "1"; R_SUDUNG[Name] = "Nghỉ nửa ngày"; dt.Rows.Add(R_SUDUNG);
            return dt;
        }
        public static DataTable DT_TRALUONG(string ID, string Name)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add(ID, typeof(string));
            dt.Columns.Add(Name, typeof(string));
            DataRow R_KHONGSUDUNG = dt.NewRow(); R_KHONGSUDUNG[ID] = "0"; R_KHONGSUDUNG[Name] = "NGhỉ không lương"; dt.Rows.Add(R_KHONGSUDUNG);
            DataRow R_SUDUNG = dt.NewRow(); R_SUDUNG[ID] = "1"; R_SUDUNG[Name] = "NGhỉ hưởng lương"; dt.Rows.Add(R_SUDUNG);
            return dt;
        }
        public static DataTable DT_THUNHAP(string ID, string Name)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add(ID, typeof(string));
            dt.Columns.Add(Name, typeof(string));
            DataRow R_KHONGSUDUNG = dt.NewRow(); R_KHONGSUDUNG[ID] = "0"; R_KHONGSUDUNG[Name] = "Khấu trừ"; dt.Rows.Add(R_KHONGSUDUNG);
            DataRow R_SUDUNG = dt.NewRow(); R_SUDUNG[ID] = "1"; R_SUDUNG[Name] = "Thu nhập"; dt.Rows.Add(R_SUDUNG);
            return dt;
        }
        public static DataTable DT_TRUOCTHUE(string ID, string Name)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add(ID, typeof(string));
            dt.Columns.Add(Name, typeof(string));
            DataRow R_KHONGSUDUNG = dt.NewRow(); R_KHONGSUDUNG[ID] = "0"; R_KHONGSUDUNG[Name] = "Sau Thuế"; dt.Rows.Add(R_KHONGSUDUNG);
            DataRow R_SUDUNG = dt.NewRow(); R_SUDUNG[ID] = "1"; R_SUDUNG[Name] = "Trước Thuế"; dt.Rows.Add(R_SUDUNG);
            return dt;
        }
        public static DataTable DT_HINHTHUCTRA(string ID, string Name)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add(ID, typeof(string));
            dt.Columns.Add(Name, typeof(string));
            DataRow R_KHONGSUDUNG = dt.NewRow(); R_KHONGSUDUNG[ID] = "0"; R_KHONGSUDUNG[Name] = "Theo tiền mặt"; dt.Rows.Add(R_KHONGSUDUNG);
            DataRow R_SUDUNG = dt.NewRow(); R_SUDUNG[ID] = "1"; R_SUDUNG[Name] = "Theo lương CB"; dt.Rows.Add(R_SUDUNG);
            return dt;
        }
        public static DataTable DT_NGHITHU7(string ID, string Name)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add(ID, typeof(string));
            dt.Columns.Add(Name, typeof(string));
            DataRow R_KHONGSUDUNG = dt.NewRow(); R_KHONGSUDUNG[ID] = "0"; R_KHONGSUDUNG[Name] = "Thứ 7 không là ngày nghỉ"; dt.Rows.Add(R_KHONGSUDUNG);
            DataRow R_SUDUNG = dt.NewRow(); R_SUDUNG[ID] = "1"; R_SUDUNG[Name] = "Thứ 7 là ngày nghỉ"; dt.Rows.Add(R_SUDUNG);
            return dt;
        }
        public static DataTable DT_NGHICHUNHAT(string ID, string Name)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add(ID, typeof(string));
            dt.Columns.Add(Name, typeof(string));
            DataRow R_KHONGSUDUNG = dt.NewRow(); R_KHONGSUDUNG[ID] = "0"; R_KHONGSUDUNG[Name] = "Chủ nhật không là ngày nghỉ"; dt.Rows.Add(R_KHONGSUDUNG);
            DataRow R_SUDUNG = dt.NewRow(); R_SUDUNG[ID] = "1"; R_SUDUNG[Name] = "Chủ nhật là ngày nghỉ"; dt.Rows.Add(R_SUDUNG);
            return dt;
        }
        public static DataTable DT_TRANGTHAIHL(string ID, string Name)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add(ID, typeof(string));
            dt.Columns.Add(Name, typeof(string));
            DataRow R_KHONGSUDUNG = dt.NewRow(); R_KHONGSUDUNG[ID] = "0"; R_KHONGSUDUNG[Name] = "không có hiệu lực"; dt.Rows.Add(R_KHONGSUDUNG);
            DataRow R_SUDUNG = dt.NewRow(); R_SUDUNG[ID] = "1"; R_SUDUNG[Name] = "Có hiệu lực"; dt.Rows.Add(R_SUDUNG);
            return dt;
        }
        public static DataTable DT_LIST_MONTH(string ID, string Name)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add(ID, typeof(string));
            dt.Columns.Add(Name, typeof(string));
            dt.Rows.Add(new string[] { "1", "Tháng 1" });
            dt.Rows.Add(new string[] { "2", "Tháng 2" });
            dt.Rows.Add(new string[] { "3", "Tháng 3" });
            dt.Rows.Add(new string[] { "4", "Tháng 4" });
            dt.Rows.Add(new string[] { "5", "Tháng 5" });
            dt.Rows.Add(new string[] { "6", "Tháng 6" });
            dt.Rows.Add(new string[] { "7", "Tháng 7" });
            dt.Rows.Add(new string[] { "8", "Tháng 8" });
            dt.Rows.Add(new string[] { "9", "Tháng 9" });
            dt.Rows.Add(new string[] { "10", "Tháng 10" });
            dt.Rows.Add(new string[] { "11", "Tháng 11" });
            dt.Rows.Add(new string[] { "12", "Tháng 12" });
            return dt;
        }
        public static DataTable DT_LIST_QUY(string ID, string Name)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add(ID, typeof(string));
            dt.Columns.Add(Name, typeof(string));
            dt.Rows.Add(new string[] { "1", "Quý 1" });
            dt.Rows.Add(new string[] { "2", "Quý 2" });
            dt.Rows.Add(new string[] { "3", "Quý 3" });
            dt.Rows.Add(new string[] { "4", "Quý 4" });
            return dt;
        }
    }
}
