using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Collections.Specialized;
using GD.FM.LIB;

namespace GD.FM.APP.LIB
{
  public  class Procedures
    {
        private static Int32 timeout = 0;//1200;
        private static string ConnectionStringKeyName = LIB.SESSION_START.ConnectionStringKeyName;

        public static DataTable Danhsachmauin()
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();

            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader("Danhsachmauin", "Danhsachmauin", myArr).Tables[0];
        }
        public static DataTable Danhsachcadet(DateTime Tungay, DateTime Denngay)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.Date, 0), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.Date, 0), Denngay);

            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader("Danhsachcadet", "Danhsachcadet", myArr).Tables[0];
        }
        public static DataTable Danhsachcongnhandet(DateTime Tungay, DateTime Denngay)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.Date, 0), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.Date, 0), Denngay);

            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader("Danhsachcongnhandet", "Danhsachcongnhandet", myArr).Tables[0];
        }
        public static DataTable Danhsachmahanghoanthien(DateTime Tungay, DateTime Denngay)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.Date, 0), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.Date, 0), Denngay);

            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader("Danhsachmahanghoanthien", "Danhsachmahanghoanthien", myArr).Tables[0];
        }
        public static DataTable Danhsachthanhphansoi()
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();

            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader("Danhsachthanhphansoi", "Danhsachthanhphansoi", myArr).Tables[0];
        }
        public static DataTable Dongianguyenlieuhieuluc(DateTime Ngaytinhgia, string Manguyenlieu)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Ngaytinhgia", SqlDbType.Date, 0), Ngaytinhgia);
            parameters.Add(new SqlParameter("@Manguyenlieu", SqlDbType.NVarChar, 0), Manguyenlieu);

            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader("Dongianguyenlieuhieuluc", "Dongianguyenlieuhieuluc", myArr).Tables[0];
        }
        public static DataTable Danhsachthanhphanpe()
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();

            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader("Danhsachthanhphanpe", "Danhsachthanhphanpe", myArr).Tables[0];
        }
        public static DataTable Danhsachcongsuattheohang()
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();

            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader("Danhsachcongsuattheohang", "Danhsachcongsuattheohang", myArr).Tables[0];
        }
        public static DataTable Danhsachhieusuatsanxuat()
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();

            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader("Danhsachhieusuatsanxuat", "Danhsachhieusuatsanxuat", myArr).Tables[0];
        }
        public static DataTable Danhsachtonghopchiphichung()
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();

            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader("Danhsachtonghopchiphichung", "Danhsachtonghopchiphichung", myArr).Tables[0];
        }
        public static DataTable Danhsachsanluongtoida()
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();

            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader("Danhsachsanluongtoida", "Danhsachsanluongtoida", myArr).Tables[0];
        }
        public static DataTable Danhsachchiphichungtheohang()
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();

            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader("Danhsachchiphichungtheohang", "Danhsachchiphichungtheohang", myArr).Tables[0];
        }
        public static DataTable Danhsachchiphichungtheohangchitiet(string Thang)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Thang", SqlDbType.NVarChar, 0), Thang);

            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader("View_Chiphichungtheohang", "View_Chiphichungtheohang", myArr).Tables[0];
        }
        public static DataTable Danhsachchiphibanhangtheohang()
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();

            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader("Danhsachchiphibanhangtheohang", "Danhsachchiphibanhangtheohang", myArr).Tables[0];
        }
        public static DataTable Danhsachchiphibanhangtheohangchitiet(string Thang)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Thang", SqlDbType.NVarChar, 0), Thang);

            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader("View_Chiphibanhangtheohang", "View_Chiphibanhangtheohang", myArr).Tables[0];
        }
        public static DataTable Danhsachchiphigiacongtheohang()
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();

            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader("Danhsachchiphigiacongtheohang", "Danhsachchiphigiacongtheohang", myArr).Tables[0];
        }
        public static DataTable Danhsachchiphigiacongtheohangchitiet(string Thang)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Thang", SqlDbType.NVarChar, 0), Thang);

            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader("View_Chiphigiacongtheohang", "View_Chiphigiacongtheohang", myArr).Tables[0];
        }
        public static DataTable Danhsachnguyenvatlieutrang()
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();

            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader("Danhsachnguyenvatlieutrang", "Danhsachnguyenvatlieutrang", myArr).Tables[0];
        }
        public static DataTable Danhsachcongdoan()
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();

            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader("Danhsachcongdoan", "Danhsachcongdoan", myArr).Tables[0];
        }
        public static DataTable Tinhcongsuatmaydet(string Mamanh)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Mamanh", SqlDbType.NVarChar, 0), Mamanh);

            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader("Tinhcongsuatmaydet", "Tinhcongsuatmaydet", myArr).Tables[0];
        }
        public static DataTable Ngaysudungmaysoithang(DateTime Tungay, DateTime Denngay)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.Date, 0), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.Date, 0), Denngay);

            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader("Ngaysudungmaysoithang", "Ngaysudungmaysoithang", myArr).Tables[0];
        }
        public static DataTable Ngaysudungmaytrangthang(DateTime Tungay, DateTime Denngay)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.Date, 0), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.Date, 0), Denngay);

            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader("Ngaysudungmaytrangthang", "Ngaysudungmaytrangthang", myArr).Tables[0];
        }
        public static DataTable Ngaysudungmayinthang(DateTime Tungay, DateTime Denngay)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.Date, 0), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.Date, 0), Denngay);

            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader("Ngaysudungmayinthang", "Ngaysudungmayinthang", myArr).Tables[0];
        }
        public static DataTable Ngaysudungmayhoanthienthang(DateTime Tungay, DateTime Denngay)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.Date, 0), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.Date, 0), Denngay);

            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader("Ngaysudungmayhoanthienthang", "Ngaysudungmayhoanthienthang", myArr).Tables[0];
        }
        public static DataTable Tinhcongsuatmaysoi(string Masoi)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Masoi", SqlDbType.NVarChar, 0), Masoi);

            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader("Tinhcongsuatmaysoi", "Tinhcongsuatmaysoi", myArr).Tables[0];
        }        
        public static DataTable Congsuattungloaisoitheokehoachdet(DateTime Tungay, DateTime Denngay)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.Date, 0), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.Date, 0), Denngay);

            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader("Congsuattungloaisoitheokehoachdet", "Congsuattungloaisoitheokehoachdet", myArr).Tables[0];
        }        
        public static DataTable Congsuatmayinchotungmauin(DateTime Tungay, DateTime Denngay)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.Date, 0), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.Date, 0), Denngay);

            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader("Congsuatmayinchotungmauin", "Congsuatmayinchotungmauin", myArr).Tables[0];
        }
        public static DataSet Congsuatmayhoanthienchotungmahang(DateTime Tungay, DateTime Denngay)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.Date, 0), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.Date, 0), Denngay);

            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader("Congsuatmayhoanthienchotungmahang", "Congsuatmayhoanthienchotungmahang", myArr);
        }
        public static DataTable Danhsachsoitheokehoachdetcuakhachhang(string Makhachhang, DateTime Tungay, DateTime Denngay)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Makhachhang", SqlDbType.NVarChar, 0), Makhachhang);
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.Date, 0), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.Date, 0), Denngay);

            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader("Danhsachsoitheokehoachdetcuakhachhang", "Danhsachsoitheokehoachdetcuakhachhang", myArr).Tables[0];
        }
        public static DataTable Nhucaumanhtheodonhang(DateTime Tungay, DateTime Denngay)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.Date, 0), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.Date, 0), Denngay);

            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader("Nhucaumanhtheodonhang", "Nhucaumanhtheodonhang", myArr).Tables[0];
        }
        public static DataTable Tonghopnhucaumanhtheothang(DateTime Tungay, DateTime Denngay)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.Date, 0), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.Date, 0), Denngay);

            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader("Tonghopnhucaumanhtheothang", "Tonghopnhucaumanhtheothang", myArr).Tables[0];
        }
        public static DataTable Tonghopnhucausoitheothang(DateTime Tungay, DateTime Denngay)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.Date, 0), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.Date, 0), Denngay);

            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader("Tonghopnhucausoitheothang", "Tonghopnhucausoitheothang", myArr).Tables[0];
        }
        public static DataTable Tonghopnhucautrangtheothang(DateTime Tungay, DateTime Denngay)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.Date, 0), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.Date, 0), Denngay);

            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader("Tonghopnhucautrangtheothang", "Tonghopnhucautrangtheothang", myArr).Tables[0];
        }        
        public static DataTable Nhucautrangtheodonhangchitiet(DateTime Tungay, DateTime Denngay)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.Date, 0), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.Date, 0), Denngay);

            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader("Nhucautrangtheodonhangchitiet", "Nhucautrangtheodonhangchitiet", myArr).Tables[0];
        }
        public static DataTable Nhucauintheodondathangchitiet(DateTime Tungay, DateTime Denngay)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.Date, 0), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.Date, 0), Denngay);

            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader("Nhucauintheodondathangchitiet", "Nhucauintheodondathangchitiet", myArr).Tables[0];
        }
        public static DataTable Nhucaulapkehoachintheodondathangchitiet(DateTime Tungay, DateTime Denngay)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.Date, 0), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.Date, 0), Denngay);

            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader("Nhucaulapkehoachintheodondathangchitiet", "Nhucaulapkehoachintheodondathangchitiet", myArr).Tables[0];
        }
        public static DataTable Nhucauhoanthientheodondathangchitiet(DateTime Tungay, DateTime Denngay)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.Date, 0), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.Date, 0), Denngay);

            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader("Nhucauhoanthientheodondathangchitiet", "Nhucauhoanthientheodondathangchitiet", myArr).Tables[0];
        }
        public static DataTable Nhucauhoanthien_Danhsach(DateTime Tungay, DateTime Denngay)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.Date, 0), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.Date, 0), Denngay);

            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader("Nhucauhoanthien_Danhsach", "Nhucauhoanthien_Danhsach", myArr).Tables[0];
        }
        public static DataTable Chayhamkhongbien(string Tenham)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();

            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader(timeout, Tenham, Tenham, myArr).Tables[0];
        }
        public static void Tinhtrongluongmet()
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            _SimpleStoredProcedure.ExecuteSPReader("Tinhtrongluongmet", "Tinhtrongluongmet", myArr);
        }

        public static void Tinhluonghoanthien(int Thang, int Nam, string User, DateTime Ngaytinh)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Thang", SqlDbType.Int, 0), Thang);
            parameters.Add(new SqlParameter("@Nam", SqlDbType.Int, 0), Nam);
            parameters.Add(new SqlParameter("@User", SqlDbType.NVarChar, 0), User);
            parameters.Add(new SqlParameter("@Ngaytinh", SqlDbType.Date, 0), Ngaytinh);

            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            _SimpleStoredProcedure.ExecuteSPReader("Tinhluonghoanthien", "Tinhluonghoanthien", myArr);
        }
        public static void Xoaluonghoanthien(int Thang, int Nam)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Thang", SqlDbType.Int, 0), Thang);
            parameters.Add(new SqlParameter("@Nam", SqlDbType.Int, 0), Nam);

            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            _SimpleStoredProcedure.ExecuteSPReader("Xoaluonghoanthien", "Xoaluonghoanthien", myArr);
        }

        public static string Laygiatrithamso(string Mathamso)
        {
            GD.FM.DAL.EntityClasses.ThamsoEntity _ThamsoEntity = new GD.FM.BLL.ThamsoManagerBase().SelectOne(Mathamso);
            return _ThamsoEntity.Giatri;
        }
        public static decimal fCongsuatmayindasudung(DateTime Ngaychay, Int32 Ca, string Mamayin)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Ngaychay", SqlDbType.Date, 0), Ngaychay);
            parameters.Add(new SqlParameter("@Ca", SqlDbType.Int, 0), Ca);
            parameters.Add(new SqlParameter("@Mamayin", SqlDbType.NVarChar, 0), Mamayin);

            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);

            decimal gtri = Convert.ToDecimal(_SimpleStoredProcedure.ExecuteScalarSP("fCongsuatmayindasudung", myArr));
            return gtri;
        }
        public static bool fKiemtrakehoachhoanthien(DateTime Tungay, DateTime Denngay, string Macongdoan)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.Date, 0), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.Date, 0), Denngay);
            parameters.Add(new SqlParameter("@Macongdoan", SqlDbType.NVarChar, 0), Macongdoan);

            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);

            bool gtri = Convert.ToBoolean(_SimpleStoredProcedure.ExecuteScalarSP("fKiemtrakehoachhoanthien", myArr));
            return gtri;
        }
        public static DataTable Choncongthuctrang()
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();

            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader("Choncongthuctrang", "Choncongthuctrang", myArr).Tables[0];
        }
        public static DataTable Danhmuccongdoantruoccat()
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();

            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader("Danhmuccongdoantruoccat", "Danhmuccongdoantruoccat", myArr).Tables[0];
        }
        public static DataTable Danhmuccongdoansaucat()
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();

            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader("Danhmuccongdoansaucat", "Danhmuccongdoansaucat", myArr).Tables[0];
        }
        public static DataTable Danhsachquycachspchitiet(string Macongdoan)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Macongdoan", SqlDbType.NVarChar, 0), Macongdoan);

            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader("Danhsachquycachspchitiet", "Danhsachquycachspchitiet", myArr).Tables[0];

        }
        public static DataTable LayIddanhsachcuonmanh()
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();

            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader("LayIddanhsachcuonmanh", "LayIddanhsachcuonmanh", myArr).Tables[0];
        }
        #region Khác
        public static void Saoluudulieu(string FileName)
        {
            int vt1 = ConnectionStringKeyName.IndexOf(";Initial Catalog");
            int vt2 = ConnectionStringKeyName.IndexOf(";User ID");
            string strRep = ConnectionStringKeyName.Substring(vt1, vt2 - vt1);
            string strMasterConnect = ConnectionStringKeyName.Replace(strRep, ";Initial Catalog=master");
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(strMasterConnect);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@FileName", SqlDbType.NVarChar, 0), FileName);

            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            _SimpleStoredProcedure.ExecuteSPReader(timeout, "BackupDataKDTM", "BackupDataKDTM", myArr);//.ExecuteScalarSP("BackupDataKTXPT", myArr);
        }
        #endregion

        #region FM
        public static DataTable Inbaogiamauhang(string Mamauhang)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Mamauhang", SqlDbType.NVarChar, 0), Mamauhang);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader("Inbaogiamauhang", "Inbaogiamauhang", myArr).Tables[0];
        }
        public static DataTable Danhsachbaogiakhachnoidia(DateTime Tungay, DateTime Denngay, string Sobaogia, string Makhachhang, string Mahang)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.Date, 0), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.Date, 0), Denngay);
            parameters.Add(new SqlParameter("@Sobaogia", SqlDbType.NVarChar, 0), Sobaogia);
            parameters.Add(new SqlParameter("@Makhachhang", SqlDbType.NVarChar, 0), Makhachhang);
            parameters.Add(new SqlParameter("@Mahang", SqlDbType.NVarChar, 0), Mahang);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader("Danhsachbaogiakhachnoidia", "Danhsachbaogiakhachnoidia", myArr).Tables[0];
        }
        public static DataTable Danhsachbaogiakhachnoidiachon(string Sobaogia)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Sobaogia", SqlDbType.NVarChar, 0), Sobaogia);

            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader("Danhsachbaogiakhachnoidiachon", "Danhsachbaogiakhachnoidiachon", myArr).Tables[0];
        }
        public static DataTable Danhsachbaogiakhachnoidiachitiet(DateTime Tungay, DateTime Denngay, string Sobaogia, string Makhachhang, string Mahang)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.Date, 0), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.Date, 0), Denngay);
            parameters.Add(new SqlParameter("@Sobaogia", SqlDbType.NVarChar, 0), Sobaogia);
            parameters.Add(new SqlParameter("@Makhachhang", SqlDbType.NVarChar, 0), Makhachhang);
            parameters.Add(new SqlParameter("@Mahang", SqlDbType.NVarChar, 0), Mahang);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader("Danhsachbaogiakhachnoidiachitiet", "Danhsachbaogiakhachnoidiachitiet", myArr).Tables[0];
        }
        public static DataTable Danhsachbaogiaxuatkhau(DateTime Tungay, DateTime Denngay, string Sobaogia, string Makhachhang, string Mahang)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.Date, 0), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.Date, 0), Denngay);
            parameters.Add(new SqlParameter("@Sobaogia", SqlDbType.NVarChar, 0), Sobaogia);
            parameters.Add(new SqlParameter("@Makhachhang", SqlDbType.NVarChar, 0), Makhachhang);
            parameters.Add(new SqlParameter("@Mahang", SqlDbType.NVarChar, 0), Mahang);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader("Danhsachbaogiaxuatkhau", "Danhsachbaogiaxuatkhau", myArr).Tables[0];
        }
        public static DataTable Danhsachbaogiachonxuatkhau(string Sobaogia)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Sobaogia", SqlDbType.NVarChar, 0), Sobaogia);

            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader("Danhsachbaogiachonxuatkhau", "Danhsachbaogiachonxuatkhau", myArr).Tables[0];
        }
        public static DataTable Danhsachbaogiachitietxuatkhau(DateTime Tungay, DateTime Denngay, string Sobaogia, string Makhachhang, string Mahang)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.Date, 0), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.Date, 0), Denngay);
            parameters.Add(new SqlParameter("@Sobaogia", SqlDbType.NVarChar, 0), Sobaogia);
            parameters.Add(new SqlParameter("@Makhachhang", SqlDbType.NVarChar, 0), Makhachhang);
            parameters.Add(new SqlParameter("@Mahang", SqlDbType.NVarChar, 0), Mahang);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader("Danhsachbaogiachitietxuatkhau", "Danhsachbaogiachitietxuatkhau", myArr).Tables[0];
        }
        public static DataTable Danhsachdondathangkhachnoidia(DateTime Tungay, DateTime Denngay, string Madondathang, string Sobaogia, string SoPO, string Makhachhang, string Mahang)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.Date, 0), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.Date, 0), Denngay);
            parameters.Add(new SqlParameter("@Madondathang", SqlDbType.NVarChar, 0), Madondathang);
            parameters.Add(new SqlParameter("@Sobaogia", SqlDbType.NVarChar, 0), Sobaogia);
            parameters.Add(new SqlParameter("@SoPO", SqlDbType.NVarChar, 0), SoPO);
            parameters.Add(new SqlParameter("@Makhachhang", SqlDbType.NVarChar, 0), Makhachhang);
            parameters.Add(new SqlParameter("@Mahang", SqlDbType.NVarChar, 0), Mahang);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader("Danhsachdondathangkhachnoidia", "Danhsachdondathangkhachnoidia", myArr).Tables[0];
        }
        public static DataTable Danhsachdondathangkhachnoidiachitiet(DateTime Tungay, DateTime Denngay, string Madondathang, string Sobaogia, string SoPO, string Makhachhang, string Mahang)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.Date, 0), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.Date, 0), Denngay);
            parameters.Add(new SqlParameter("@Madondathang", SqlDbType.NVarChar, 0), Madondathang);
            parameters.Add(new SqlParameter("@Sobaogia", SqlDbType.NVarChar, 0), Sobaogia);
            parameters.Add(new SqlParameter("@SoPO", SqlDbType.NVarChar, 0), SoPO);
            parameters.Add(new SqlParameter("@Makhachhang", SqlDbType.NVarChar, 0), Makhachhang);
            parameters.Add(new SqlParameter("@Mahang", SqlDbType.NVarChar, 0), Mahang);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader("Danhsachdondathangkhachnoidiachitiet", "Danhsachdondathangkhachnoidiachitiet", myArr).Tables[0];
        }
        public static DataTable Danhsachdondathangchitietkhongton(string Makhach, string Mahang)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Makhachhang", SqlDbType.NVarChar, 0), Makhach);
            parameters.Add(new SqlParameter("@Mahang", SqlDbType.NVarChar, 0), Mahang);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader("Danhsachdondathangchitietkhongton", "Danhsachdondathangchitietkhongton", myArr).Tables[0];
        }
        public static DataTable Danhsachdondathangxuatkhau(DateTime Tungay, DateTime Denngay, string Madondathang, string Sobaogia, string SoPO, string Makhachhang, string Mahang)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.Date, 0), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.Date, 0), Denngay);
            parameters.Add(new SqlParameter("@Madondathang", SqlDbType.NVarChar, 0), Madondathang);
            parameters.Add(new SqlParameter("@Sobaogia", SqlDbType.NVarChar, 0), Sobaogia);
            parameters.Add(new SqlParameter("@SoPO", SqlDbType.NVarChar, 0), SoPO);
            parameters.Add(new SqlParameter("@Makhachhang", SqlDbType.NVarChar, 0), Makhachhang);
            parameters.Add(new SqlParameter("@Mahang", SqlDbType.NVarChar, 0), Mahang);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader("Danhsachdondathangxuatkhau", "Danhsachdondathangxuatkhau", myArr).Tables[0];
        }
        public static DataTable Danhsachdondathangchitietxuatkhau(DateTime Tungay, DateTime Denngay, string Madondathang, string Sobaogia, string SoPO, string Makhachhang, string Mahang)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.Date, 0), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.Date, 0), Denngay);
            parameters.Add(new SqlParameter("@Madondathang", SqlDbType.NVarChar, 0), Madondathang);
            parameters.Add(new SqlParameter("@Sobaogia", SqlDbType.NVarChar, 0), Sobaogia);
            parameters.Add(new SqlParameter("@SoPO", SqlDbType.NVarChar, 0), SoPO);
            parameters.Add(new SqlParameter("@Makhachhang", SqlDbType.NVarChar, 0), Makhachhang);
            parameters.Add(new SqlParameter("@Mahang", SqlDbType.NVarChar, 0), Mahang);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader("Danhsachdondathangchitietxuatkhau", "Danhsachdondathangchitietxuatkhau", myArr).Tables[0];
        }
        public static DataTable Danhsachdondathangchitietkhongtonxuatkhau(string Makhach, string Mahang)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Makhachhang", SqlDbType.NVarChar, 0), Makhach);
            parameters.Add(new SqlParameter("@Mahang", SqlDbType.NVarChar, 0), Mahang);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader("Danhsachdondathangchitietkhongtonxuatkhau", "Danhsachdondathangchitietkhongtonxuatkhau", myArr).Tables[0];
        }
        public static DataTable Hopdongmuaban(DateTime Tungay, DateTime Denngay, string Sohopdong, string Makhachhang, string Mahang)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.Date, 0), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.Date, 0), Denngay);
            parameters.Add(new SqlParameter("@Sohopdong", SqlDbType.NVarChar, 0), Sohopdong);
            parameters.Add(new SqlParameter("@Makhachhang", SqlDbType.NVarChar, 0), Makhachhang);
            parameters.Add(new SqlParameter("@Mahang", SqlDbType.NVarChar, 0), Mahang);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader("Hopdongmuaban", "Hopdongmuaban", myArr).Tables[0];
        }
        public static DataTable Hopdongmuabanchitiet(DateTime Tungay, DateTime Denngay, string Sohopdong, string Makhachhang, string Mahang)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.Date, 0), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.Date, 0), Denngay);
            parameters.Add(new SqlParameter("@Sohopdong", SqlDbType.NVarChar, 0), Sohopdong);
            parameters.Add(new SqlParameter("@Makhachhang", SqlDbType.NVarChar, 0), Makhachhang);
            parameters.Add(new SqlParameter("@Mahang", SqlDbType.NVarChar, 0), Mahang);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader("Hopdongmuabanchitiet", "Hopdongmuabanchitiet", myArr).Tables[0];
        }
        public static DataTable Danhsachphieuxuathang(DateTime Tungay, DateTime Denngay, string Sophieuxuat, string Madondathang, string SoPO, string Makhachhang, string Mahang)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.Date, 0), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.Date, 0), Denngay);
            parameters.Add(new SqlParameter("@Sophieuxuat", SqlDbType.NVarChar, 0), Sophieuxuat);
            parameters.Add(new SqlParameter("@Madondathang", SqlDbType.NVarChar, 0), Madondathang);
            parameters.Add(new SqlParameter("@SoPO", SqlDbType.NVarChar, 0), SoPO);
            parameters.Add(new SqlParameter("@Makhachhang", SqlDbType.NVarChar, 0), Makhachhang);
            parameters.Add(new SqlParameter("@Mahang", SqlDbType.NVarChar, 0), Mahang);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader("Danhsachphieuxuathang", "Danhsachphieuxuathang", myArr).Tables[0];
        }
        public static DataTable Danhsachhanggiao(DateTime Tungay, DateTime Denngay, string Sophieuxuat, string Madondathang, string SoPO, string Makhachhang, string Mahang)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.Date, 0), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.Date, 0), Denngay);
            parameters.Add(new SqlParameter("@Sophieuxuat", SqlDbType.NVarChar, 0), Sophieuxuat);
            parameters.Add(new SqlParameter("@Madondathang", SqlDbType.NVarChar, 0), Madondathang);
            parameters.Add(new SqlParameter("@SoPO", SqlDbType.NVarChar, 0), SoPO);
            parameters.Add(new SqlParameter("@Makhachhang", SqlDbType.NVarChar, 0), Makhachhang);
            parameters.Add(new SqlParameter("@Mahang", SqlDbType.NVarChar, 0), Mahang);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader("Danhsachhanggiao", "Danhsachhanggiao", myArr).Tables[0];
        }
        public static DataTable Danhsachphieuxuathangxuatkhau(DateTime Tungay, DateTime Denngay, string Sophieuxuat, string Madondathang, string SoPO, string Makhachhang, string Mahang)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.Date, 0), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.Date, 0), Denngay);
            parameters.Add(new SqlParameter("@Sophieuxuat", SqlDbType.NVarChar, 0), Sophieuxuat);
            parameters.Add(new SqlParameter("@Madondathang", SqlDbType.NVarChar, 0), Madondathang);
            parameters.Add(new SqlParameter("@SoPO", SqlDbType.NVarChar, 0), SoPO);
            parameters.Add(new SqlParameter("@Makhachhang", SqlDbType.NVarChar, 0), Makhachhang);
            parameters.Add(new SqlParameter("@Mahang", SqlDbType.NVarChar, 0), Mahang);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader("Danhsachphieuxuathangxuatkhau", "Danhsachphieuxuathangxuatkhau", myArr).Tables[0];
        }
        public static DataTable Danhsachhanggiaoxuatkhau(DateTime Tungay, DateTime Denngay, string Sophieuxuat, string Madondathang, string SoPO, string Makhachhang, string Mahang)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.Date, 0), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.Date, 0), Denngay);
            parameters.Add(new SqlParameter("@Sophieuxuat", SqlDbType.NVarChar, 0), Sophieuxuat);
            parameters.Add(new SqlParameter("@Madondathang", SqlDbType.NVarChar, 0), Madondathang);
            parameters.Add(new SqlParameter("@SoPO", SqlDbType.NVarChar, 0), SoPO);
            parameters.Add(new SqlParameter("@Makhachhang", SqlDbType.NVarChar, 0), Makhachhang);
            parameters.Add(new SqlParameter("@Mahang", SqlDbType.NVarChar, 0), Mahang);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader("Danhsachhanggiaoxuatkhau", "Danhsachhanggiaoxuatkhau", myArr).Tables[0];
        }
        public static DataTable Danhsachphieugiaohang(DateTime Tungay, DateTime Denngay, string Sophieugiao, string Madonhang, string Makhachhang, string Mahang)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.Date, 0), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.Date, 0), Denngay);
            parameters.Add(new SqlParameter("@Sophieugiao", SqlDbType.NVarChar, 0), Sophieugiao);
            parameters.Add(new SqlParameter("@Madonhang", SqlDbType.NVarChar, 0), Madonhang);
            parameters.Add(new SqlParameter("@Makhachhang", SqlDbType.NVarChar, 0), Makhachhang);
            parameters.Add(new SqlParameter("@Mahang", SqlDbType.NVarChar, 0), Mahang);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader("Danhsachphieugiaohang", "Danhsachphieugiaohang", myArr).Tables[0];
        }
        public static DataTable Danhsachphieugiaohangchitiet(DateTime Tungay, DateTime Denngay, string Sophieugiao, string Madonhang, string Makhachhang, string Mahang)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.Date, 0), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.Date, 0), Denngay);
            parameters.Add(new SqlParameter("@Sophieugiao", SqlDbType.NVarChar, 0), Sophieugiao);
            parameters.Add(new SqlParameter("@Madonhang", SqlDbType.NVarChar, 0), Madonhang);
            parameters.Add(new SqlParameter("@Makhachhang", SqlDbType.NVarChar, 0), Makhachhang);
            parameters.Add(new SqlParameter("@Mahang", SqlDbType.NVarChar, 0), Mahang);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader("Danhsachphieugiaohangchitiet", "Danhsachphieugiaohangchitiet", myArr).Tables[0];
        }
        public static DataTable Danhsachphieugiaohangxuatkhau(DateTime Tungay, DateTime Denngay, string Sophieugiao, string Madonhang, string Makhachhang, string Mahang)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.Date, 0), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.Date, 0), Denngay);
            parameters.Add(new SqlParameter("@Sophieugiao", SqlDbType.NVarChar, 0), Sophieugiao);
            parameters.Add(new SqlParameter("@Madonhang", SqlDbType.NVarChar, 0), Madonhang);
            parameters.Add(new SqlParameter("@Makhachhang", SqlDbType.NVarChar, 0), Makhachhang);
            parameters.Add(new SqlParameter("@Mahang", SqlDbType.NVarChar, 0), Mahang);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader("Danhsachphieugiaohangxuatkhau", "Danhsachphieugiaohangxuatkhau", myArr).Tables[0];
        }
        public static DataTable Danhsachphieugiaohangchitietxuatkhau(DateTime Tungay, DateTime Denngay, string Sophieugiao, string Madonhang, string Makhachhang, string Mahang)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.Date, 0), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.Date, 0), Denngay);
            parameters.Add(new SqlParameter("@Sophieugiao", SqlDbType.NVarChar, 0), Sophieugiao);
            parameters.Add(new SqlParameter("@Madonhang", SqlDbType.NVarChar, 0), Madonhang);
            parameters.Add(new SqlParameter("@Makhachhang", SqlDbType.NVarChar, 0), Makhachhang);
            parameters.Add(new SqlParameter("@Mahang", SqlDbType.NVarChar, 0), Mahang);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader("Danhsachphieugiaohangchitietxuatkhau", "Danhsachphieugiaohangchitietxuatkhau", myArr).Tables[0];
        }
        public static DataTable Danhsachphieuxuathangtralai(DateTime Tungay, DateTime Denngay, string Sophieunhap, string Makhachhang)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.Date, 0), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.Date, 0), Denngay);
            parameters.Add(new SqlParameter("@Sophieunhap", SqlDbType.NVarChar, 0), Sophieunhap);
            parameters.Add(new SqlParameter("@Makhachhang", SqlDbType.NVarChar, 0), Makhachhang);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader("Danhsachphieuxuathangtralai", "Danhsachphieuxuathangtralai", myArr).Tables[0];
        }
        public static DataTable Danhsachhangtralai(DateTime Tungay, DateTime Denngay, string Sophieunhap, string Madondathang, string Mahang)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.Date, 0), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.Date, 0), Denngay);
            parameters.Add(new SqlParameter("@Sophieunhap", SqlDbType.NVarChar, 0), Sophieunhap);
            parameters.Add(new SqlParameter("@Madondathang", SqlDbType.NVarChar, 0), Madondathang);
            parameters.Add(new SqlParameter("@Mahang", SqlDbType.NVarChar, 0), Mahang);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader("Danhsachhangtralai", "Danhsachhangtralai", myArr).Tables[0];
        }
        public static DataTable Danhsachdondathangchon()
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader("Danhsachdondathangchon", "Danhsachdondathangchon", myArr).Tables[0];
        }
        public static DataTable Danhsachnguyenlieu(string Manguyenlieu, DateTime Ngay)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Manguyenlieu", SqlDbType.NVarChar, 0), Manguyenlieu);
            parameters.Add(new SqlParameter("@Ngay", SqlDbType.Date, 0), Ngay);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader("Danhsachnguyenlieu", "Danhsachnguyenlieu", myArr).Tables[0];
        }
        public static DataTable Danhsachchimay(string Machimay)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Machimay", SqlDbType.NVarChar, 0), Machimay);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader("Danhsachchimay", "Danhsachchimay", myArr).Tables[0];
        }
        public static DataTable Danhsachdayxienluon(string Madayxienluon)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Madayxienluon", SqlDbType.NVarChar, 0), Madayxienluon);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader("Danhsachdayxienluon", "Danhsachdayxienluon", myArr).Tables[0];
        }
        public static DataTable Tinhcongsuattheohang()
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader("Tinhcongsuattheohang", "Tinhcongsuattheohang", myArr).Tables[0];
        }
        public static DataTable Themmoichiphibanhangtheohang()
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader("Themmoichiphibanhangtheohang", "Themmoichiphibanhangtheohang", myArr).Tables[0];
        }
        public static DataTable Tinhchiphichungtheohang(string Thang)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Thang", SqlDbType.Date, 0), Thang);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader("Tinhchiphichungtheohang", "Tinhchiphichungtheohang", myArr).Tables[0];
        }
        public static DataTable Tinhchiphigiacongtheohang(DateTime Ngay)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Ngay", SqlDbType.Date, 0), Ngay);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader("Tinhchiphigiacongtheohang", "Tinhchiphigiacongtheohang", myArr).Tables[0];
        }
        public static DataTable Tinhchiphigiacongsoimanh(DateTime Ngay)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Ngay", SqlDbType.Date, 0), Ngay);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader("Tinhchiphigiacongsoimanh", "Tinhchiphigiacongsoimanh", myArr).Tables[0];
        }
        public static DataTable Tinhsanluongtoida(string Thang, string Makhach, string Mahang)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Thang", SqlDbType.NVarChar, 0), Thang);
            parameters.Add(new SqlParameter("@Makhach", SqlDbType.NVarChar, 0), Makhach);
            parameters.Add(new SqlParameter("@Mahang", SqlDbType.NVarChar, 0), Mahang);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader("Tinhsanluongtoida", "Tinhsanluongtoida", myArr).Tables[0];
        }
        public static Int32 Tinhsohangchuadienduthongtin()
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);

            Int32 gtri = Convert.ToInt32(_SimpleStoredProcedure.ExecuteScalarSP("fTinhsohangchuadienduthongtin", myArr));
            return gtri;
        }
        public static DataTable Danhsachchiphinguyenlieutheohang()
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader("Danhsachchiphinguyenlieutheohang", "Danhsachchiphinguyenlieutheohang", myArr).Tables[0];
        }
        public static DataTable Tinhchiphinguyenlieutheohang(DateTime Ngaytinhgia, string Makhach, string Mahang)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Ngaytinhgia", SqlDbType.Date, 0), Ngaytinhgia);
            parameters.Add(new SqlParameter("@Makhach", SqlDbType.NVarChar, 0), Makhach);
            parameters.Add(new SqlParameter("@Mahang", SqlDbType.NVarChar, 0), Mahang);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader("Tinhchiphinguyenlieutheohang", "Tinhchiphinguyenlieutheohang", myArr).Tables[0];
        }
        public static DataTable Danhsachchiphinguyenlieusoimanh()
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader("Danhsachchiphinguyenlieusoimanh", "Danhsachchiphinguyenlieusoimanh", myArr).Tables[0];
        }
        public static DataTable Tinhchiphinguyenlieusoimanh(DateTime Ngaytinhgia)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Ngaytinhgia", SqlDbType.Date, 0), Ngaytinhgia);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader("Tinhchiphinguyenlieusoimanh", "Tinhchiphinguyenlieusoimanh", myArr).Tables[0];
        }
        public static DataTable Danhsachchiphigiacongsoimanh()
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader("Danhsachchiphigiacongsoimanh", "Danhsachchiphigiacongsoimanh", myArr).Tables[0];
        }
        public static DataTable Danhsachsanluongsoimanh()
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader("Danhsachsanluongsoimanh", "Danhsachsanluongsoimanh", myArr).Tables[0];
        }
        public static DataTable Tinhchiphichungsoimanh(string Thang)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Thang", SqlDbType.Date, 0), Thang);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader("Tinhchiphichungsoimanh", "Tinhchiphichungsoimanh", myArr).Tables[0];
        }
        public static DataTable Tinhsanluongsoimanh(string Thang)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Thang", SqlDbType.Date, 0), Thang);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader("Tinhsanluongsoimanh", "Tinhsanluongsoimanh", myArr).Tables[0];
        }
        public static DataTable Danhsachchiphichungsoimanh()
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader("Danhsachchiphichungsoimanh", "Danhsachchiphichungsoimanh", myArr).Tables[0];
        }
        public static DataTable Danhsachchiphichungsoimanhchitiet(string Thang)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Thang", SqlDbType.NVarChar, 0), Thang);

            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader("Danhsachchiphichungsoimanhchitiet", "Danhsachchiphichungsoimanhchitiet", myArr).Tables[0];
        }
        public static DataTable Danhsachchiphibanhangsoimanh()
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader("Danhsachchiphibanhangsoimanh", "Danhsachchiphibanhangsoimanh", myArr).Tables[0];
        }
        public static DataTable Themmoichiphibanhangsoimanh()
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader("Themmoichiphibanhangsoimanh", "Themmoichiphibanhangsoimanh", myArr).Tables[0];
        }
        public static DataTable Danhsachchiphibanhangsoimanhchitiet(string Thang)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Thang", SqlDbType.NVarChar, 0), Thang);

            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader("Danhsachchiphibanhangsoimanhchitiet", "Danhsachchiphibanhangsoimanhchitiet", myArr).Tables[0];
        }
        public static DataTable Danhsachgiavonhangban()
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader("Danhsachgiavonhangban", "Danhsachgiavonhangban", myArr).Tables[0];
        }
        public static DataTable Tonghopgiavonhangban(string Thang)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Thang", SqlDbType.Date, 0), Thang);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader("Tonghopgiavonhangban", "Tonghopgiavonhangban", myArr).Tables[0];
        }
        public static DataTable Danhsachgiavonsoimanh()
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader("Danhsachgiavonsoimanh", "Danhsachgiavonsoimanh", myArr).Tables[0];
        }
        public static DataTable Tonghopgiavonsoimanh(string Thang)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Thang", SqlDbType.Date, 0), Thang);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader("Tonghopgiavonsoimanh", "Tonghopgiavonsoimanh", myArr).Tables[0];
        }
        public static DataTable Danhsachkehoachbanhang()
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();

            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader("Danhsachkehoachbanhang", "Danhsachkehoachbanhang", myArr).Tables[0];
        }
        public static DataTable Danhsachkehoachbanhangchitiet(string Thang)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Thang", SqlDbType.NVarChar, 0), Thang);

            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader("Danhsachkehoachbanhangchitiet", "Danhsachkehoachbanhangchitiet", myArr).Tables[0];
        }
        public static DataTable Tinhchiphibansoi(DateTime Ngaytinhgia, string Masoi)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Ngaytinhgia", SqlDbType.Date, 0), Ngaytinhgia);
            parameters.Add(new SqlParameter("@Masoi", SqlDbType.NVarChar, 0), Masoi);

            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader("Tinhchiphibansoi", "Tinhchiphibansoi", myArr).Tables[0];
        }
        public static DataTable Tinhchiphibanmanh(DateTime Ngaytinhgia, string Mamanh)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Ngaytinhgia", SqlDbType.Date, 0), Ngaytinhgia);
            parameters.Add(new SqlParameter("@Mamanh", SqlDbType.NVarChar, 0), Mamanh);

            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader("Tinhchiphibanmanh", "Tinhchiphibanmanh", myArr).Tables[0];
        }
        public static DataTable Tinhchiphibansoimanh(DateTime Ngaytinhgia, string Mamanh, string Masoi)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Ngaytinhgia", SqlDbType.Date, 0), Ngaytinhgia);
            parameters.Add(new SqlParameter("@Mamanh", SqlDbType.NVarChar, 0), Mamanh);
            parameters.Add(new SqlParameter("@Masoi", SqlDbType.NVarChar, 0), Masoi);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader("Tinhchiphibansoimanh", "Tinhchiphibansoimanh", myArr).Tables[0];
        }
        public static DataTable Tinhchiphimauhang(DateTime Ngaytinhgia, string Mamauhang)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Ngaytinhgia", SqlDbType.Date, 0), Ngaytinhgia);
            parameters.Add(new SqlParameter("@Mamauhang", SqlDbType.NVarChar, 0), Mamauhang);

            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader("Tinhchiphimauhang", "Tinhchiphimauhang", myArr).Tables[0];
        }
        public static DataTable Danhsachhangchontronghoadon(string Makhach, DateTime Ngay)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Makhach", SqlDbType.NVarChar, 0), Makhach);
            parameters.Add(new SqlParameter("@Ngay", SqlDbType.Date, 0), Ngay);

            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader("Danhsachhangchontronghoadon", "Danhsachhangchontronghoadon", myArr).Tables[0];
        }
        public static DataTable Danhsachhangchontronghoadonxuatkhau(string Makhach, DateTime Ngay)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Makhach", SqlDbType.NVarChar, 0), Makhach);
            parameters.Add(new SqlParameter("@Ngay", SqlDbType.Date, 0), Ngay);

            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader("Danhsachhangchontronghoadonxuatkhau", "Danhsachhangchontronghoadonxuatkhau", myArr).Tables[0];
        }

        public static DataTable Danhsachhopdongbanhang(DateTime Tungay, DateTime Denngay, string Sohopdong, string Makhachhang, string Mahang, string Macangden)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.Date, 0), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.Date, 0), Denngay);
            parameters.Add(new SqlParameter("@Sohopdong", SqlDbType.NVarChar, 0), Sohopdong);
            parameters.Add(new SqlParameter("@Makhachhang", SqlDbType.NVarChar, 0), Makhachhang);
            parameters.Add(new SqlParameter("@Mahang", SqlDbType.NVarChar, 0), Mahang);
            parameters.Add(new SqlParameter("@Macangden", SqlDbType.NVarChar, 0), Macangden);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader("Danhsachhopdongbanhang", "Danhsachhopdongbanhang", myArr).Tables[0];
        }
        public static DataTable Danhsachhopdongbanhangchitiet(DateTime Tungay, DateTime Denngay, string Sohopdong, string Makhachhang, string Mahang, string Macangden)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.Date, 0), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.Date, 0), Denngay);
            parameters.Add(new SqlParameter("@Sohopdong", SqlDbType.NVarChar, 0), Sohopdong);
            parameters.Add(new SqlParameter("@Makhachhang", SqlDbType.NVarChar, 0), Makhachhang);
            parameters.Add(new SqlParameter("@Mahang", SqlDbType.NVarChar, 0), Mahang);
            parameters.Add(new SqlParameter("@Macangden", SqlDbType.NVarChar, 0), Macangden);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader("Danhsachhopdongbanhangchitiet", "Danhsachhopdongbanhangchitiet", myArr).Tables[0];
        }
        #endregion

    }
}
