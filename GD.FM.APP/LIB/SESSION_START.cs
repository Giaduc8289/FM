using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GD.FM.BLL;
using GD.FM.DAL;
using GD.FM.DAL.EntityClasses;
using GD.FM.DAL.FactoryClasses;
using GD.FM.DAL.HelperClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;
using System.Data;
namespace GD.FM.APP.LIB
{
    class SESSION_START
    {
        public static string TS_USER_LOGIN;

        private static string _ConnectionStringKeyName = "";
        public static string ConnectionStringKeyName
        {
            get
            {
                _ConnectionStringKeyName = System.Configuration.ConfigurationManager.AppSettings.Get(DAL.DatabaseSpecific.DataAccessAdapter.ConnectionStringKeyName);
                return _ConnectionStringKeyName;
            }
            set { _ConnectionStringKeyName = value; }
        }

        #region USER
        private static DataTable _DT_USER = null;
        public static DataTable DM_USER
        {
            get
            {
                _DT_USER = new UsersManager().SelectAllRDT();
                return _DT_USER;
            }
            set { _DT_USER = value; }
        }
        #endregion
        #region MENU
        private static DataTable _DT_MENU = null;
        public static DataTable DT_MENU
        {
            get
            {
                _DT_MENU = new MenuManager().SelectAllRDT();
                return _DT_MENU;
            }
            set { _DT_MENU = value; }
        }
        #endregion
        #region DTROLES
        private static DataTable _DT_ROLES = null;
        public static DataTable DT_ROLES
        {
            get
            {
                _DT_ROLES = new RolesManager().SelectAllRDT();
                return _DT_ROLES;
            }
            set { _DT_ROLES = value; }
        }
        #endregion
        #region DTROLE
        // quản lý nhóm quyền
        private static DataTable _DT_ROLE = null;
        public static DataTable DT_ROLE
        {
            get
            {
                _DT_ROLE = new RolesManager().SelectAllRDT();
                return _DT_ROLE;
            }
            set { _DT_ROLE = value; }
        }
        #endregion

        #region NGAYLAMVIEC
        private static DateTime _TS_NGAYLAMVIEC = DateTime.Now;
        public static DateTime TS_NGAYLAMVIEC
        {
            get
            {
                return _TS_NGAYLAMVIEC;
            }
            set { _TS_NGAYLAMVIEC = value; }
        }
        #endregion
        #region NGAYDAUTHANG
        private static DateTime _TS_NGAYDAUTHANG = DateTime.Now; 
        public static DateTime TS_NGAYDAUTHANG
        {
            get
            {
                return _TS_NGAYDAUTHANG;
            }
            set { _TS_NGAYDAUTHANG = value; }
        }
        #endregion
        #region NGAYCUOITHANG
        private static DateTime _TS_NGAYCUOITHANG = DateTime.Now;
        public static DateTime TS_NGAYCUOITHANG
        {
            get
            {
                return _TS_NGAYCUOITHANG;
            }
            set { _TS_NGAYCUOITHANG = value; }
        }
        #endregion
        #region NGAYDAUQUY
        private static DateTime _TS_NGAYDAUQUY = DateTime.Now;
        public static DateTime TS_NGAYDAUQUY
        {
            get
            {
                return _TS_NGAYDAUQUY;
            }
            set { _TS_NGAYDAUQUY = value; }
        }
        #endregion
        #region NGAYCUOIQUY
        private static DateTime _TS_NGAYCUOIQUY = DateTime.Now;
        public static DateTime TS_NGAYCUOIQUY
        {
            get
            {
                return _TS_NGAYCUOIQUY;
            }
            set { _TS_NGAYCUOIQUY = value; }
        }
        #endregion
        #region NGAYDAUNAM
        private static DateTime _TS_NGAYDAUNAM = DateTime.Now;
        public static DateTime TS_NGAYDAUNAM
        {
            get
            {
                return _TS_NGAYDAUNAM;
            }
            set { _TS_NGAYDAUNAM = value; }
        }
        #endregion
        #region NGAYCUOINAM
        private static DateTime _TS_NGAYCUOINAM = DateTime.Now;
        public static DateTime TS_NGAYCUOINAM
        {
            get
            {
                return _TS_NGAYCUOINAM;
            }
            set { _TS_NGAYCUOINAM = value; }
        }
        #endregion

        #region NHANVIEN
        private static DataTable _DT_NHANVIEN = null;
        public static DataTable DT_NHANVIEN
        {
            get
            {
                _DT_NHANVIEN = new NhanvienManager().SelectAllRDT();
                return _DT_NHANVIEN;
            }
            set { _DT_NHANVIEN = value; }
        }
        #endregion

        #region DT_DMPTTHANHTOAN
        private static DataTable _DT_DMPTTHANHTOAN = null;
        public static DataTable DT_DMPTTHANHTOAN
        {
            get
            {
                _DT_DMPTTHANHTOAN = new PhuongthucthanhtoanManager().SelectAllRDT();
                return _DT_DMPTTHANHTOAN;
            }
            set { _DT_DMPTTHANHTOAN = value; }
        }
        #endregion
        #region DT_DMFORMCO
        private static DataTable _DT_DMFORMCO = null;
        public static DataTable DT_DMFORMCO
        {
            get
            {
                _DT_DMFORMCO = new FormcoManager().SelectAllRDT();
                return _DT_DMFORMCO;
            }
            set { _DT_DMFORMCO = value; }
        }
        #endregion
        #region DT_DMQUOCGIA
        private static DataTable _DT_DMQUOCGIA = null;
        public static DataTable DT_DMQUOCGIA
        {
            get
            {
                _DT_DMQUOCGIA = new DanhmucquocgiaManager().SelectAllRDT();
                return _DT_DMQUOCGIA;
            }
            set { _DT_DMQUOCGIA = value; }
        }
        #endregion
        #region DT_DMPTVANCHUYEN
        private static DataTable _DT_DMPTVANCHUYEN = null;
        public static DataTable DT_DMPTVANCHUYEN
        {
            get
            {
                _DT_DMPTVANCHUYEN = new PhuongthucvanchuyenManager().SelectAllRDT();
                return _DT_DMPTVANCHUYEN;
            }
            set { _DT_DMPTVANCHUYEN = value; }
        }
        #endregion
        #region DT_DMNGANHANG
        private static DataTable _DT_DMNGANHANG = null;
        public static DataTable DT_DMNGANHANG
        {
            get
            {
                _DT_DMNGANHANG = new DanhmucnganhangManager().SelectAllRDT();
                return _DT_DMNGANHANG;
            }
            set { _DT_DMNGANHANG = value; }
        }
        #endregion
        #region DT_DMCANG
        private static DataTable _DT_DMCANG = null;
        public static DataTable DT_DMCANG
        {
            get
            {
                _DT_DMCANG = new DanhmuccangManager().SelectAllRDT();
                return _DT_DMCANG;
            }
            set { _DT_DMCANG = value; }
        }
        #endregion

        #region DMCACBUOCLOGISTIC
        private static DataTable _DT_DMCACBUOCLOGISTIC = null;
        public static DataTable DT_DMCACBUOCLOGISTIC
        {
            get
            {
                _DT_DMCACBUOCLOGISTIC = new CacbuoclogisticManager().SelectAllRDT();
                return _DT_DMCACBUOCLOGISTIC;
            }
            set { _DT_DMCACBUOCLOGISTIC = value; }
        }
        #endregion

        #region DMDONVITINH
        private static DataTable _DT_DMDONVITINH = null;
        public static DataTable DT_DMDONVITINH
        {
            get
            {
                _DT_DMDONVITINH = new DonvitinhManager().SelectAllRDT();
                return _DT_DMDONVITINH;
            }
            set { _DT_DMDONVITINH = value; }
        }
        #endregion
        #region DMKHACH
        private static DataTable _DT_DMKHACH = null;
        public static DataTable DT_DMKHACH
        {
            get
            {
                _DT_DMKHACH = new DanhmuckhachManager().SelectAllRDT();
                return _DT_DMKHACH;
            }
            set { _DT_DMKHACH = value; }
        }
        #endregion
        #region DMTYGIA
        private static DataTable _DT_DMTYGIA = null;
        public static DataTable DT_DMTYGIA
        {
            get
            {
                _DT_DMTYGIA = new TygiaManager().SelectAllRDT();
                return _DT_DMTYGIA;
            }
            set { _DT_DMTYGIA = value; }
        }
        #endregion

        #region DMCHUCVU
        private static DataTable _DT_DMCHUCVU = null;
        public static DataTable DT_DMCHUCVU
        {
            get
            {
                _DT_DMUNGDUNG = new DanhmucchucvuManager().SelectAllRDT();
                return _DT_DMCHUCVU;
            }
            set { _DT_DMCHUCVU = value; }
        }
        #endregion

        #region DMPHONGBAN
        private static DataTable _DT_DMPHONGBAN = null;
        public static DataTable DT_DMPHONGBAN
        {
            get
            {
                _DT_DMUNGDUNG = new DanhmucchucvuManager().SelectAllRDT();
                return _DT_DMPHONGBAN;
            }
            set { _DT_DMPHONGBAN = value; }
        }
        #endregion

        #region DMUNGDUNG
        private static DataTable _DT_DMUNGDUNG = null;
        public static DataTable DT_DMUNGDUNG
        {
            get
            {
                _DT_DMUNGDUNG = new DanhmucungdungManager().SelectAllRDT();
                return _DT_DMUNGDUNG;
            }
            set { _DT_DMUNGDUNG = value; }
        }
        #endregion

        #region DMHANGHOA
        private static DataTable _DT_DMHANGHOA = null;
        public static DataTable DT_DMHANGHOA
        {
            get
            {
                _DT_DMHANGHOA = new DanhmuchanghoaManager().SelectAllRDT();
                return _DT_DMHANGHOA;
            }
            set { _DT_DMHANGHOA = value; }
        }
        #endregion

    }
}
