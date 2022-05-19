 using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using TBNET.ERP.BLL;
using TBNET.ERP.DAL;
using TBNET.ERP.DAL.EntityClasses;
using TBNET.ERP.DAL.FactoryClasses;
using TBNET.ERP.DAL.HelperClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace TBNET.ERP.DATA
{
    public class SESSION_START
    {
        public static string NHOMPC = "NHOMPC";
        public static string NHOMDS = "NHOMDS";
        public static string MANHOMLOAIPHUCAP = "MANHOMLOAIPHUCAP";
        public static string TENNHOMLOAITHUNHAP = "TENNHOMLOAITHUNHAP";
        public static string MADONVI = "MADONVI";

        public static string MALOAIPHANBO = "MALOAIPHANBO";
        public static string TENLOAIPHANBO = "TENLOAIPHANBO";
        public static string MALOAIPHANBO_CHIPHI = "CHIPHI";
        public static string TENLOAIPHANBO_CHIPHI = "Chi phí";
        public static string MALOAIPHANBO_CHIPHIKHAC = "CHIPHIKHAC";
        public static string TENLOAIPHANBO_CHIPHIKHAC = "Chi phí khác";
        public static string MALOAIPHANBO_LEPHI = "LEPHI";
        public static string TENLOAIPHANBO_LEPHI = "Lệ phí";

        public static string NHOMKH_KH = "KH_";
        public static string NHOMKH_NCC = "NCC_";
        public static string NHOMKH_NV = "NV_";

        public static string MANHOMPTNX = "MANHOMPTNX";
        public static string TENNHOMPTNX = "TENNHOMPTNX";
        public static string NHAPXUAT = "NHAPXUAT";
        public static string DKTIENHANG = "DKTIENHANG";
        public static string TRANGTHAI = "TRANGTHAI";
        public static string ISSUDUNG = "ISSUDUNG";

        #region DM LOAI KHUYEN MAI
        public static decimal MA_MUA1_1 = 1;
        public static string TEN_MUA1_1 = "Mua 1 mã hàng tặng 1 mã hàng";

        public static decimal MA_MUA1_n = 2;
        public static string TEN_MUA1_n = "Mua 1 mã hàng tặng nhiều mã hàng";

        public static decimal MA_MUA1_1_n = 3;
        public static string TEN_MUA1_1_n = "Mua 1 mã hàng tặng 1 trong nhiều mã hàng";

        public static decimal MA_MUA2_1 = 4;
        public static string TEN_MUA2_1 = "Mua 1 bó hàng tặng 1 mã hàng";

        public static decimal MA_BH_MUA1_n = 5;
        public static string TEN_BH_MUA1_n = "Mua 1 bó hàng tặng nhiều mã hàng";

        public static decimal MA_BH_MUA1_1_n = 6;
        public static string TEN_BH_MUA1_1_n = "Mua 1 bó hàng tặng 1 trong nhiều mã hàng";

        public static decimal MA_MUAHANG_TANGTIEN = 7;
        public static string TEN_MUAHANG_TANGTIEN = "Mua hàng tặng tiền";

        private static DataTable _DM_LOAIKM = new DataTable();
        public static DataTable DM_LOAIKM
        {
            get 
            {
                if (_DM_LOAIKM != null && _DM_LOAIKM.Rows.Count > 0) { return _DM_LOAIKM; }
                _DM_LOAIKM = new DataTable();
                _DM_LOAIKM.Columns.Add("ID", typeof(decimal));
                _DM_LOAIKM.Columns.Add("NAME", typeof(string));

                DataRow _1hang_tang_1hang = _DM_LOAIKM.NewRow();
                _1hang_tang_1hang["ID"] = MA_MUA1_1;
                _1hang_tang_1hang["NAME"] = TEN_MUA1_1;
                _DM_LOAIKM.Rows.Add(_1hang_tang_1hang);

                DataRow _1tang_n = _DM_LOAIKM.NewRow();
                _1tang_n["ID"] = MA_MUA1_n;
                _1tang_n["NAME"] = TEN_MUA1_n;
                _DM_LOAIKM.Rows.Add(_1tang_n);

                DataRow _1tang1_n = _DM_LOAIKM.NewRow();
                _1tang1_n["ID"] = MA_MUA1_1_n;
                _1tang1_n["NAME"] = TEN_MUA1_1_n;
                _DM_LOAIKM.Rows.Add(_1tang1_n);

                DataRow _2tang1 = _DM_LOAIKM.NewRow();
                _2tang1["ID"] = MA_MUA2_1;
                _2tang1["NAME"] = TEN_MUA2_1;
                _DM_LOAIKM.Rows.Add(_2tang1);

                DataRow _BH1tangn = _DM_LOAIKM.NewRow();
                _BH1tangn["ID"] = MA_BH_MUA1_n;
                _BH1tangn["NAME"] = TEN_BH_MUA1_n;
                _DM_LOAIKM.Rows.Add(_BH1tangn);

                DataRow _BH1tang1_n = _DM_LOAIKM.NewRow();
                _BH1tang1_n["ID"] = MA_BH_MUA1_1_n;
                _BH1tang1_n["NAME"] = TEN_BH_MUA1_1_n;
                _DM_LOAIKM.Rows.Add(_BH1tang1_n);

                DataRow _Mua_hang_ttien = _DM_LOAIKM.NewRow();
                _Mua_hang_ttien["ID"] = MA_MUAHANG_TANGTIEN;
                _Mua_hang_ttien["NAME"] = TEN_MUAHANG_TANGTIEN; ;
                _DM_LOAIKM.Rows.Add(_Mua_hang_ttien);

                return _DM_LOAIKM;
            }
            set { _DM_LOAIKM = value; }
        }
        #endregion

        //#region LOAI THUE -- DAC BIET -- NHAP KHAU -- VAT
        //public static string COL_TENLOAIVAT = "TÊN LOẠI VAT";
        //public static string COL_MALOAIVAT = "MÃ LOẠI VAT";
        //public static string TENLOAIVAT_NK = "Thuế nhập khẩu";
        //public static string TENLOAIVAT_DB = "Thuế đặc biệt";
        //public static string TENLOAIVAT_VAT = "VAT";
        //public static int MALOAIVAT_NK = 4;
        //public static int MALOAIVAT_DB = 3;
        //public static int MALOAIVAT_VAT = 2;
        //private static DataTable _DT_LOAIVAT = new DataTable();
        //public static DataTable DT_LOAIVAT
        //{
        //    get 
        //    {
        //        _DT_LOAIVAT = new DataTable();
        //        try
        //        {
        //            if (_DT_LOAIVAT.Columns.Contains(COL_TENLOAIVAT) == false) _DT_LOAIVAT.Columns.Add(COL_TENLOAIVAT, typeof(string));
        //        }
        //        catch { }
        //        try
        //        {
        //            if (_DT_LOAIVAT.Columns.Contains(COL_MALOAIVAT) == false) _DT_LOAIVAT.Columns.Add(COL_MALOAIVAT, typeof(int));
        //        }
        //        catch { }
        //        DataRow row = _DT_LOAIVAT.NewRow();
        //        row[COL_TENLOAIVAT] = TENLOAIVAT_VAT;
        //        row[COL_MALOAIVAT] = MALOAIVAT_VAT;
        //        _DT_LOAIVAT.Rows.Add(row);
        //        DataRow row1 = _DT_LOAIVAT.NewRow();
        //        row1[COL_TENLOAIVAT] = TENLOAIVAT_DB;
        //        row1[COL_MALOAIVAT] = MALOAIVAT_DB;
        //        _DT_LOAIVAT.Rows.Add(row1);
        //        DataRow row2 = _DT_LOAIVAT.NewRow();
        //        row2[COL_TENLOAIVAT] = TENLOAIVAT_NK;
        //        row2[COL_MALOAIVAT] = MALOAIVAT_NK;
        //        _DT_LOAIVAT.Rows.Add(row2);
        //        return _DT_LOAIVAT;
        //    }
        //    set { _DT_LOAIVAT = value; }
        //}
        //#endregion

        #region Dinh nghia cac loai ket chuyen
        public static string MAKETCHUYEN_KD = "KINHDOAN";
        public static string TENKETCHUYEN_KD = "Kết chuyển xác định kết quả kinh doanh";
        public static string MAKETCHUYEN_SX = "SANXUAT";
        public static string TENKETCHUYEN_SX = "Kết chuyển chi phí sản xuất";
        #endregion
        #region Dinh nghia cac nhom ptnx
        public static string N_MUA = "N_MUA", TEN_NMUA = "Nhập mua";
        public static string N_KHAU = "N_KHAU", TEN_N_KHAU = "Nhập khẩu";
        public static string N_KHAC = "N_KHAC",TEN_NKHAC="Nhập khác";
        public static string X_BAN = "X_BAN",TEN_XBAN="Xuất bán";
        public static string X_CHUYENKHO = "X_CHUYENKHO",TEN_XCHUYENKHO="Xuất chuyển kho";
        public static string N_CHUYENKHO = "N_CHUYENKHO", TEN_NCHUYENKHO = "Nhập chuyển kho";
        public static string X_SUDUNG = "X_SUDUNG",TEN_XSUDUNG="Xuất sử dụng";
        public static string X_DIEUCHINH = "X_DIEUCHINH",TEN_XDIEUCHINH="Xuất điều chỉnh";
        public static string X_KHAC = "X_KHAC",TEN_XKHAC="Xuất khác";
        public static string X_SANXUAT = "X_SANXUAT", TEN_XSANXUAT = "Xuất sản xuất";
        public static string N_THANHPHAM = "N_THANHPHAM", TEN_NHAPTHANHPHAM = "Nhập thành phẩm";
        public static string N_NLDDANG = "N_NLDDANG", TEN_NNLDDANG = "Nhập nguyên liệu dở dang";
        public static string X_TAICHE = "X_TAICHE", TEN_X_TAICHE = "Xuất tái chế";
        public static string N_TRALAI = "N_TRALAI", TEN_N_TRALAI = "Nhập hàng trả lại";
        public static string X_TRALAI = "X_TRALAI", TEN_X_TRALAI = "Xuất hàng trả lại";
        public static string X_DICHDANH = "X_DICHDANH", TEN_X_DICHDANH = "Xuất đích danh";
        public static int trangthai = 10;
        public static int sudung = 1;
        #endregion

        private static DataTable _DT_NHOMTHUNHAP = new DataTable();
        public static DataTable DMNHOMTHUNHAP
        {
            get
            {
                _DT_NHOMTHUNHAP = new DataTable();
                try
                {
                    if (_DT_NHOMTHUNHAP.Columns.Contains(MANHOMLOAIPHUCAP) == false) _DT_NHOMTHUNHAP.Columns.Add(MANHOMLOAIPHUCAP, typeof(string));
                }
                catch { if (_DT_NHOMTHUNHAP.Columns.Contains("MANHOMLOAIPHUCAP") == false) _DT_NHOMTHUNHAP.Columns.Add("MANHOMLOAIPHUCAP", typeof(string)); }
                try
                {
                    if (_DT_NHOMTHUNHAP.Columns.Contains(TENNHOMLOAITHUNHAP) == false) _DT_NHOMTHUNHAP.Columns.Add(TENNHOMLOAITHUNHAP, typeof(string));
                }
                catch { if (_DT_NHOMTHUNHAP.Columns.Contains("TENNHOMLOAITHUNHAP") == false) _DT_NHOMTHUNHAP.Columns.Add("TENNHOMLOAITHUNHAP", typeof(string)); }
                try
                {
                    if (_DT_NHOMTHUNHAP.Columns.Contains(MADONVI) == false) _DT_NHOMTHUNHAP.Columns.Add(MADONVI, typeof(string));
                }
                catch { if (_DT_NHOMTHUNHAP.Columns.Contains("MADONVI") == false) _DT_NHOMTHUNHAP.Columns.Add("MADONVI", typeof(string)); }
                try
                {
                    if (_DT_NHOMTHUNHAP.Columns.Contains(TRANGTHAI) == false) _DT_NHOMTHUNHAP.Columns.Add(TRANGTHAI, typeof(string));
                }
                catch { if (_DT_NHOMTHUNHAP.Columns.Contains("TRANGTHAI") == false) _DT_NHOMTHUNHAP.Columns.Add("TRANGTHAI", typeof(string)); }
                DataRow r = _DT_NHOMTHUNHAP.NewRow();
                r[MANHOMLOAIPHUCAP] = NHOMDS;
                r[TENNHOMLOAITHUNHAP] = "Nhóm Doanh Số";
                r[MADONVI] = TBNET.ERP.DATA.DMDONVI._Current.Madonvi;
                r[TRANGTHAI] = "1";
                _DT_NHOMTHUNHAP.Rows.Add(r);

                DataRow r1 = _DT_NHOMTHUNHAP.NewRow();
                r1[MANHOMLOAIPHUCAP] = NHOMPC;
                r1[TENNHOMLOAITHUNHAP] = "Nhóm Phụ cấp";
                r1[MADONVI] = TBNET.ERP.DATA.DMDONVI._Current.Madonvi;
                r1[TRANGTHAI] = "1";
                _DT_NHOMTHUNHAP.Rows.Add(r1); 
                return _DT_NHOMTHUNHAP;
            }
            set
            {
                _DT_NHOMTHUNHAP = value;
            }
        }

        #region DANH MUC NHOMPTNX
        private static DataTable _DT_NHOMPTNX = new DataTable();
        public static DataTable DMNHOMPTNX
        {
            get
            {
                _DT_NHOMPTNX = new DataTable();
                try
                {
                    if (_DT_NHOMPTNX.Columns.Contains(MANHOMPTNX) == false) _DT_NHOMPTNX.Columns.Add(MANHOMPTNX, typeof(string));
                }
                catch { if (_DT_NHOMPTNX.Columns.Contains("MANHOMPTNX") == false) _DT_NHOMPTNX.Columns.Add("MANHOMPTNX", typeof(string)); }
                try
                {
                    if (_DT_NHOMPTNX.Columns.Contains(TENNHOMPTNX) == false) _DT_NHOMPTNX.Columns.Add(TENNHOMPTNX, typeof(string));
                }
                catch { if (_DT_NHOMPTNX.Columns.Contains("TENNHOMPTNX") == false) _DT_NHOMPTNX.Columns.Add("TENNHOMPTNX", typeof(string)); }
                try
                {
                    if (_DT_NHOMPTNX.Columns.Contains(NHAPXUAT) == false) _DT_NHOMPTNX.Columns.Add(NHAPXUAT, typeof(string));
                }
                catch { if (_DT_NHOMPTNX.Columns.Contains("NHAPXUAT") == false) _DT_NHOMPTNX.Columns.Add("NHAPXUAT", typeof(string)); }
                try
                {
                    if (_DT_NHOMPTNX.Columns.Contains(DKTIENHANG) == false) _DT_NHOMPTNX.Columns.Add(DKTIENHANG, typeof(string));
                }
                catch { if (_DT_NHOMPTNX.Columns.Contains("DKTIENHANG") == false) _DT_NHOMPTNX.Columns.Add("DKTIENHANG", typeof(string)); }
                try { if (_DT_NHOMPTNX.Columns.Contains(TRANGTHAI) == false) _DT_NHOMPTNX.Columns.Add(TRANGTHAI, typeof(int)); }
                catch { if (_DT_NHOMPTNX.Columns.Contains("TRANGTHAI") == false) _DT_NHOMPTNX.Columns.Add("TRANGTHAI", typeof(int)); }
                try
                {
                    if (_DT_NHOMPTNX.Columns.Contains(ISSUDUNG) == false) _DT_NHOMPTNX.Columns.Add(ISSUDUNG, typeof(int));
                }
                catch { if (_DT_NHOMPTNX.Columns.Contains("ISSUDUNG") == false) _DT_NHOMPTNX.Columns.Add("ISSUDUNG", typeof(int)); }
                loadNHOMPTNX(N_MUA, TEN_NMUA, "N", "", 10, 1);
                loadNHOMPTNX(N_KHAC, TEN_NKHAC, "N", "", 10, 1);
                loadNHOMPTNX(X_BAN, TEN_XBAN, "X", "", 10, 1);
                loadNHOMPTNX(X_CHUYENKHO, TEN_XCHUYENKHO, "X", "", 10, 1);
                loadNHOMPTNX(N_CHUYENKHO, TEN_NCHUYENKHO, "N", "", 10, 1);
                loadNHOMPTNX(X_SUDUNG, TEN_XSUDUNG, "X", "", 10, 1);
                loadNHOMPTNX(X_DIEUCHINH, TEN_XDIEUCHINH, "X", "", 10, 1);
                loadNHOMPTNX(X_KHAC, TEN_XKHAC, "X", "", 10, 1);
                loadNHOMPTNX(X_SANXUAT, TEN_XSANXUAT, "X", "", 10, 1);
                loadNHOMPTNX(N_THANHPHAM, TEN_NHAPTHANHPHAM, "N", "", 10, 1);
                loadNHOMPTNX(N_NLDDANG, TEN_NNLDDANG, "N", "", 10, 1);
                loadNHOMPTNX(X_TAICHE, TEN_X_TAICHE, "X", "", 10, 1);
                loadNHOMPTNX(N_TRALAI, TEN_N_TRALAI, "N", "", 10, 1);
                loadNHOMPTNX(X_TRALAI, TEN_X_TRALAI, "X", "", 10, 1);
                loadNHOMPTNX(X_DICHDANH, TEN_X_DICHDANH, "X", "", 10, 1);
                loadNHOMPTNX(N_KHAU, TEN_N_KHAU, "N", "", 10, 1);
                return _DT_NHOMPTNX;
            }
            set
            {
                _DT_NHOMPTNX = value;
            }
        }
        #endregion
        #region TABLE loai ket chuyen
        private static DataTable _DT_LOAIKETCHUYEN = new DataTable();
        public static DataTable LOAIKETCHUYEN
        {
            get 
            {
                string maloai="MALOAI",tenloai="TENLOAI";
                _DT_LOAIKETCHUYEN = new DataTable();
                if (_DT_LOAIKETCHUYEN.Columns.Contains(maloai) == false) _DT_LOAIKETCHUYEN.Columns.Add(maloai, typeof(string));
                if (_DT_LOAIKETCHUYEN.Columns.Contains(tenloai) == false) _DT_LOAIKETCHUYEN.Columns.Add(tenloai, typeof(string));
                DataRow row1 = _DT_LOAIKETCHUYEN.NewRow();
                row1[maloai] = MAKETCHUYEN_KD;
                row1[tenloai] = TENKETCHUYEN_KD;
                _DT_LOAIKETCHUYEN.Rows.Add(row1);

                DataRow row2 = _DT_LOAIKETCHUYEN.NewRow();
                row2[maloai] = MAKETCHUYEN_SX;
                row2[tenloai] = TENKETCHUYEN_SX;
                _DT_LOAIKETCHUYEN.Rows.Add(row2);
                return _DT_LOAIKETCHUYEN;
            }
            set 
            {
                _DT_LOAIKETCHUYEN = value;
            }
        }
        #endregion
        private static void loadNHOMPTNX(string manhomptnx, string tennhomptnx, string nhapxuat, string dktienhang, int trangthai, int sudung)
        {
            DataRow row = _DT_NHOMPTNX.NewRow();
            row[MANHOMPTNX] = manhomptnx;
            row[TENNHOMPTNX] = tennhomptnx;
            row[NHAPXUAT] = nhapxuat;
            row[DKTIENHANG] = "";
            row[TRANGTHAI] = trangthai;
            row[ISSUDUNG] = sudung;
            _DT_NHOMPTNX.Rows.Add(row);
        }

        #region DMTUYENDUONG
        private static DataTable _DMTUYENDUONG = null;
        public static DataTable DMTUYENDUONG
        {
            get
            {
                if (TBNET.ERP.DATA.DMDONVI.DV_TH)
                { _DMTUYENDUONG = new DmtuyenduongManager().SelectAllRDT(); }
                else
                {
                    _DMTUYENDUONG = new DmtuyenduongManager().SelectByMadonviRDT(TBNET.ERP.DATA.DMDONVI._Current.Madonvi);
                }
                return _DMTUYENDUONG;
            }
            set { _DMTUYENDUONG = value; }
        }
        #endregion
        
        #region DMNGOAITE
        private static DataTable _DT_NGOAITE = null;
        public static DataTable DT_NGOAITE
        {
            get 
            {
                _DT_NGOAITE = new DmngoaiteManager().SelectByIssudungRDT(1);
                return _DT_NGOAITE;
            }
            set { _DT_NGOAITE = value; }
        }
        #endregion

        #region DM_NOIKHAM
        private static DataTable _DT_NOIKHAM = null;
        public static DataTable DT_NOIKHAM
        {
            get
            {
                if (_DT_NOIKHAM == null || _DT_NOIKHAM.Rows.Count == 0)
                {
                    if (TBNET.ERP.DATA.DMDONVI.DV_TH)
                    { _DT_NOIKHAM = new DmnoikhamManager().SelectAllRDT(); }
                    else
                    { _DT_NOIKHAM = new DmnoikhamManager().SelectByMadonviRDT(TBNET.ERP.DATA.DMDONVI._Current.Madonvi); }
                    return _DT_NOIKHAM;
                }
                return _DT_NOIKHAM;
            }
            set { _DT_NOIKHAM = value; }
        }
        #endregion

        #region DM_BOHANG
        private static DataTable _DM_BOHANG = null;
        public static DataTable DM_BOHANG
        {
            get
            {
                if (_DM_BOHANG == null || _DM_BOHANG.Rows.Count == 0)
                {
                    if (TBNET.ERP.DATA.DMDONVI.DV_TH)
                    { _DM_BOHANG = new DmbohangManager().SelectAllRDT(); }
                    else
                    { _DM_BOHANG = new DmbohangManager().SelectByMadonviRDT(TBNET.ERP.DATA.DMDONVI._Current.Madonvi); }
                    return _DM_BOHANG;
                }
                return _DM_BOHANG;
            }
            set { _DM_BOHANG = value; }
        }
        #endregion
        #region DM_VATTUGDTPCT
        private static DataTable _DM_VATTUGDTPCT = null;
        public static DataTable DM_VATTUGDTPCT
        {
            get
            {
                if (_DM_VATTUGDTPCT == null || _DM_VATTUGDTPCT.Rows.Count == 0)
                {
                    if (TBNET.ERP.DATA.DMDONVI.DV_TH)
                    { _DM_VATTUGDTPCT = new VattugdthanhphamctManager().SelectAllRDT(); }
                    else
                    { _DM_VATTUGDTPCT = new VattugdthanhphamctManager().SelectByMadonviRDT(TBNET.ERP.DATA.DMDONVI._Current.Madonvi); }
                    return _DM_BOHANG;
                }
                return _DM_VATTUGDTPCT;
            }
            set { _DM_VATTUGDTPCT = value; }
        }
        #endregion

        #region DM_BOHANGCT
        private static DataTable _DM_BOHANGCT = null;
        public static DataTable DM_BOHANGCT
        {
            get
            {
                if (_DM_BOHANGCT == null || _DM_BOHANGCT.Rows.Count == 0)
                {
                    if (TBNET.ERP.DATA.DMDONVI.DV_TH)
                    { _DM_BOHANGCT = new DmbohangctManagerBase().SelectAllRDT(); }
                    else
                    { _DM_BOHANGCT = new DmbohangctManagerBase().SelectByMadonviRDT(TBNET.ERP.DATA.DMDONVI._Current.Madonvi); }
                    return _DM_BOHANGCT;
                }
                return _DM_BOHANGCT;
            }
            set { _DM_BOHANGCT = value; }
        }
        #endregion

        #region DM_CTRINHKM
        private static DataTable _DM_CTRINHKM = null;
        public static DataTable DM_CTRINHKM
        {
            get
            {
                if (TBNET.ERP.DATA.DMDONVI.DV_TH)
                { _DM_CTRINHKM = new CtrinhkmaiManager().SelectAllRDT(); }
                else
                { _DM_CTRINHKM = new CtrinhkmaiManager().SelectByMadonviRDT(TBNET.ERP.DATA.DMDONVI._Current.Madonvi); }
                return _DM_CTRINHKM;
            }
            set { _DM_CTRINHKM = value; }
        }
        #endregion

        #region DM_CTRINHKMCT
        private static DataTable _DM_CTRINHKMCT = null;
        public static DataTable DM_CTRINHKMCT
        {
            get
            {
                if (TBNET.ERP.DATA.DMDONVI.DV_TH)
                { _DM_CTRINHKMCT = new CtrinhkmaictManager().SelectAllRDT(); }
                else
                { _DM_CTRINHKMCT = new CtrinhkmaictManager().SelectByMadonviRDT(TBNET.ERP.DATA.DMDONVI._Current.Madonvi); }
                return _DM_CTRINHKMCT;
            }
            set { _DM_CTRINHKMCT = value; }
        }
        #endregion

        #region Quanlytienluongthechap
        private static DataTable DM_QLTIENLUONGTHECHAP = null;
        public static DataTable DT_QLTIENLUONGTHECHAP
        {
            get
            {
                if (TBNET.ERP.DATA.DMDONVI.DV_TH)
                { DM_QLTIENLUONGTHECHAP = new DmqltienluongthechapManager().SelectAllRDT(); }
                else
                { DM_QLTIENLUONGTHECHAP = new DmqltienluongthechapManager().SelectByMadonviRDT(TBNET.ERP.DATA.DMDONVI._Current.Madonvi); }
                return DM_QLTIENLUONGTHECHAP;
            }
            set { DM_QLTIENLUONGTHECHAP = value; }
        }
        #endregion

        #region Quanlytienthechap
        private static DataTable DM_QLTIENTHECHAP = null;
        public static DataTable DT_QLTIENTHECHAP
        {
            get
            {
                if (TBNET.ERP.DATA.DMDONVI.DV_TH)
                { DM_QLTIENTHECHAP = new DmqltienthechapManager().SelectAllRDT(); }
                else
                {DM_QLTIENTHECHAP = new DmqltienthechapManager().SelectByMadonviRDT(TBNET.ERP.DATA.DMDONVI._Current.Madonvi);}
                return DM_QLTIENTHECHAP;
            }
            set { DM_QLTIENTHECHAP = value; }
        }
        #endregion

        #region Luongdoanhso
        private static DataTable DM_LUONGDOANHSO = null;
        public static DataTable DT_LUONGDOANHSO
        {
            get
            {
                if (TBNET.ERP.DATA.DMDONVI.DV_TH)
                { DM_LUONGDOANHSO = new DmluongdoanhsoManager().SelectAllRDT(); }
                else
                {DM_LUONGDOANHSO = new DmluongdoanhsoManager().SelectByMadonviRDT(TBNET.ERP.DATA.DMDONVI._Current.Madonvi);}
                return DM_LUONGDOANHSO;
            }
            set { DM_LUONGDOANHSO = value; }
        }

        #endregion


        #region DM_PHUCAP
        private static DataTable _DT_PHUCAP = null;
        public static DataTable DT_PHUCAP
        {
            get
            {
                if (TBNET.ERP.DATA.DMDONVI.DV_TH)
                { _DT_PHUCAP = new DmphucapManager().SelectAllRDT(); }
                else
                { _DT_PHUCAP = new DmphucapManager().SelectByMadonviRDT(TBNET.ERP.DATA.DMDONVI._Current.Madonvi); }
                return _DT_PHUCAP;
            }
            set { _DT_PHUCAP = value; }
        }
        #endregion

        #region DT_NHOMPHUCAP
        private static DataTable _DT_NHOMPHUCAP = null;
        public static DataTable DT_NHOMPHUCAP
        {
            get
            {
                if (TBNET.ERP.DATA.DMDONVI.DV_TH)
                { _DT_NHOMPHUCAP = new DmnhomphucapManager().SelectAllRDT(); }
                else
                { _DT_NHOMPHUCAP = new DmnhomphucapManager().SelectByMadonviRDT(TBNET.ERP.DATA.DMDONVI._Current.Madonvi); }
                return _DT_NHOMPHUCAP;
            }
            set { _DT_NHOMPHUCAP = value; }
        }
        #endregion
        #region NHANVIEN
        private static DataTable _HR_NHANVIEN = new DataTable();
        public static DataTable HR_NHANVIEN
        {
            get 
            {
                _HR_NHANVIEN = new DataTable();
                if (TBNET.ERP.DATA.DMDONVI.DV_TH)
                { _HR_NHANVIEN = new HrnhanvienManager().SelectAllRDT(); }
                else
                { _HR_NHANVIEN = new HrnhanvienManager().SelectByMadonviRDT(TBNET.ERP.DATA.DMDONVI._Current.Madonvi); }
                return _HR_NHANVIEN;
            }
            set { _HR_NHANVIEN = value; }
        }
#endregion

        #region NGACHLUONG
        private static DataTable _DMNGACHLUONG = null;
        public static DataTable DT_NGACHLUONG
        {
            get
            {
                if (_DMNGACHLUONG == null || _DMNGACHLUONG.Rows.Count == 0)
                {
                    if (TBNET.ERP.DATA.DMDONVI.DV_TH)
                    { _DMNGACHLUONG = (new DmngachlnnManager()).SelectAllRDT(); }
                    else
                    {_DMNGACHLUONG = (new DmngachlnnManager().SelectByMadonviRDT(TBNET.ERP.DATA.DMDONVI._Current.Madonvi));}
                    return _DMNGACHLUONG;
                }
                else { return _DMNGACHLUONG; }
            }
            set { _DMNGACHLUONG = value; }
        }

        #endregion       

        #region DmCaLamViec
        private static DataTable _DM_CALAMVIEC = null;
        public static DataTable DT_CALAMVIEC
        {
            get
            {
                if (_DM_CALAMVIEC == null || _DM_CALAMVIEC.Rows.Count == 0)
                {
                    try
                    {
                        if (TBNET.ERP.DATA.DMDONVI.DV_TH)
                        { _DM_CALAMVIEC = (new DmcalvManager()).SelectAllRDT(); }
                        else
                        { _DM_CALAMVIEC = (new DmcalvManager()).SelectByMadonviRDT(TBNET.ERP.DATA.DMDONVI._Current.Madonvi); }
                        DataView view = _DM_CALAMVIEC.DefaultView;
                        view.Sort = DmcalvFields.Tenca.Name + " ASC";
                        _DM_CALAMVIEC = view.ToTable();
                        return _DM_CALAMVIEC;
                    }
                    catch { }
                    return _DM_CALAMVIEC;
                }
                else
                {
                    return _DM_CALAMVIEC;
                }
            }
            set
            {
                _DM_CALAMVIEC = value;
            }
        }

        #endregion

        #region DT_BACLUONGNN

        private static DataTable DM_BACLUONG = null;
        public static DataTable DT_BACLUONGNN
        {
            get
            {
                if (DM_BACLUONG == null || DM_BACLUONG.Rows.Count == 0)
                {
                    if (TBNET.ERP.DATA.DMDONVI.DV_TH)
                    { DM_BACLUONG = (new DmbaclnnManager()).SelectAllRDT(); }
                    else
                    { DM_BACLUONG = (new DmbaclnnManager().SelectByMadonviRDT(TBNET.ERP.DATA.DMDONVI._Current.Madonvi)); }
                    return DM_BACLUONG;
                }
                else { return DM_BACLUONG; }
            }
            set { DM_BACLUONG = value; }
        }
        #endregion

        #region DT_BACLUONGNN

        private static DataTable DM_CTKTGTGTDVAO = null;
        public static DataTable DT_CTKTGTGTDVAO
        {
            get
            {
                if (DM_CTKTGTGTDVAO == null || DM_CTKTGTGTDVAO.Rows.Count == 0)
                {
                    if (TBNET.ERP.DATA.DMDONVI.DV_TH)
                    { DM_CTKTGTGTDVAO = (new CtktgtgtdvaoManager()).SelectAllRDT(); }
                    else
                    { DM_CTKTGTGTDVAO = (new CtktgtgtdvaoManager().SelectByMadonviRDT(TBNET.ERP.DATA.DMDONVI._Current.Madonvi)); }
                    return DM_CTKTGTGTDVAO;
                }
                else { return DM_CTKTGTGTDVAO; }
            }
            set { DM_CTKTGTGTDVAO = value; }
        }
        #endregion
        #region DMBTKC
        private static DataTable _DT_DMBTKC = new DataTable();
        public static DataTable DT_BTKC
        {            
            get
            {
                _DT_DMBTKC = new DataTable();
                if (TBNET.ERP.DATA.DMDONVI.DV_TH)
                { _DT_DMBTKC = new DmbtkcManager().SelectAllRDT(); }
                else
                { _DT_DMBTKC = new DmbtkcManager().SelectByMadonviRDT(TBNET.ERP.DATA.DMDONVI._Current.Madonvi); }
                return _DT_DMBTKC;
            }
            set
            {
                _DT_DMBTKC = value;
            }
        }
        #endregion

        #region VATTUGD
        private static DataTable _DT_VATTUGD = null;
        public static DataTable DT_VATTUGD
        {
            get 
            {
                if (_DT_VATTUGD == null || _DT_VATTUGD.Rows.Count <= 0)
                {
                    if (TBNET.ERP.DATA.DMDONVI.DV_TH)
                    { _DT_VATTUGD = new VattugdManager().SelectAllRDT(); }
                    else
                    {
                        _DT_VATTUGD = new VattugdManager().SelectByMadonviRDT(TBNET.ERP.DATA.DMDONVI._Current.Madonvi);
                    }
                }
                return _DT_VATTUGD;
            }
            set { _DT_VATTUGD = value; }
        }
        #endregion

        #region QUYCTKT
        private static DataTable _DT_QUYCTKT = null;
        public static DataTable DT_QUYCTKT
        {
            get
            {
                if (_DT_QUYCTKT == null || _DT_QUYCTKT.Rows.Count == 0)
                {
                    if (TBNET.ERP.DATA.DMDONVI.DV_TH)
                    {
                        _DT_QUYCTKT = new QuyctktManager().SelectAllRDT();
                    }
                    else { _DT_QUYCTKT = new QuyctktManager().SelectByMadonviRDT(TBNET.ERP.DATA.DMDONVI._Current.Madonvi); }
                }
                return _DT_QUYCTKT;
            }
            set { _DT_QUYCTKT = value; }
        }
        #endregion

        #region DMBOPHAN
        private static DataTable _DT_BOPHANDV = null;
        public static DataTable DT_BOPHANDV
        {
            get 
            {
                if (_DT_BOPHANDV == null || _DT_BOPHANDV.Rows.Count < 0)
                {
                    if (TBNET.ERP.DATA.DMDONVI.DV_TH)
                    { _DT_BOPHANDV = new DmbophandvManager().SelectAllRDT(); }
                    else
                    { _DT_BOPHANDV = new DmbophandvManager().SelectByMadonviRDT(TBNET.ERP.DATA.DMDONVI._Current.Madonvi); }
                }
                return _DT_BOPHANDV;
            }
            set { _DT_BOPHANDV = value; }
        }
        #endregion

        #region DMLOAITK
        private static DataTable _DT_DMLOAITK = null;
        public static DataTable DT_LOAITK
        {
            get 
            {
                if (_DT_DMLOAITK == null || _DT_DMLOAITK.Rows.Count < 0)
                {
                    _DT_DMLOAITK = new DmloaitkManager().SelectAllRDT();
                }
                return _DT_DMLOAITK;
            }

            set { _DT_DMLOAITK = value; }
        
        }
        #endregion

        #region DMNHOMKHODV
        private static DataTable _DT_DMNHOMKHODV;
        public static DataTable DT_DMNHOMKHODV
        {
            get 
            {
                if (_DT_DMNHOMKHODV == null || _DT_DMNHOMKHODV.Rows.Count < 0)
                {
                    if (TBNET.ERP.DATA.DMDONVI.DV_TH)
                    { _DT_DMNHOMKHODV = new DmnhomkhoManager().SelectAllRDT(); }
                    else
                    { _DT_DMNHOMKHODV = new DmnhomkhoManager().SelectByMadonviRDT(TBNET.ERP.DATA.DMDONVI._Current.Madonvi); }
                }
                return _DT_DMNHOMKHODV;
            }
            set { _DT_DMNHOMKHODV = value; }
        }

        #endregion
        #region DMQUAYHANG
        private static DataTable _DT_QUAYHANG;
        public static DataTable DT_QUAYHANG
        {
            get
            {
                if (_DT_QUAYHANG == null || _DT_QUAYHANG.Rows.Count < 0)
                {
                    if (TBNET.ERP.DATA.DMDONVI.DV_TH)
                    { _DT_QUAYHANG = new DmquayhangdvManager().SelectAllRDT(); }
                    else
                    { _DT_QUAYHANG = new DmquayhangdvManager().SelectByMadonviRDT(TBNET.ERP.DATA.DMDONVI._Current.Madonvi); }
                }
                return _DT_QUAYHANG;
            }
            set { _DT_QUAYHANG = value; }
        }

        #endregion
        #region DMVUVIEC
        private static DataTable _DMVUVIEC;
        public static DataTable DMVUVIEC
        {
            get 
            {
                if (_DMVUVIEC == null || _DMVUVIEC.Rows.Count < 0)
                {
                    if (TBNET.ERP.DATA.DMDONVI.DV_TH)
                    { _DMVUVIEC = new DmvuviecdvManager().SelectAllRDT(); }
                    else
                    { _DMVUVIEC = new DmvuviecdvManager().SelectByMadonviRDT(TBNET.ERP.DATA.DMDONVI._Current.Madonvi); }
                }
                return _DMVUVIEC;
            }
            set { _DMVUVIEC = value; }
        }
        #endregion

        #region DmLoaiHopdong
        private static DataTable _Dm_LOAIHOPDONG=null;
        public static DataTable DT_LOAIHOPDONG
        {
            get
            {
                if (_Dm_LOAIHOPDONG == null || _Dm_LOAIHOPDONG.Rows.Count == 0)
                {
                    if (TBNET.ERP.DATA.DMDONVI.DV_TH)
                    { _Dm_LOAIHOPDONG = (new DmloaihopdongManager()).SelectAllRDT(); }
                    else
                    {_Dm_LOAIHOPDONG = (new DmloaihopdongManager().SelectByMadonviRDT(TBNET.ERP.DATA.DMDONVI._Current.Madonvi));}
                    return _Dm_LOAIHOPDONG;
                }
                else { return _Dm_LOAIHOPDONG; }
            }
            set { _Dm_LOAIHOPDONG = value; }
        }
           
        #endregion

        #region DT_DMNHOMDTPN
        private static DataTable _DT_DMNHOMDTPN = null;
        public static DataTable DT_DMNHOMDTPN
        {
            get
            {
                if (_DT_DMNHOMDTPN == null || _DT_DMNHOMDTPN.Rows.Count == 0)
                {
                    if (TBNET.ERP.DATA.DMDONVI.DV_TH)
                    { _DT_DMNHOMDTPN = (new DmloaihopdongManager()).SelectAllRDT(); }
                    else
                    { _DT_DMNHOMDTPN = (new DmloaihopdongManager().SelectByMadonviRDT(TBNET.ERP.DATA.DMDONVI._Current.Madonvi)); }
                    return _DT_DMNHOMDTPN;
                }
                else { return _DT_DMNHOMDTPN; }
            }
            set { _DT_DMNHOMDTPN = value; }
        }

        #endregion

        #region DMNHOMTH
        private static DataTable DMNHOMTH;
        public static DataTable DM_NHOMTH
        {
            get
            { if (DMNHOMTH == null || DMNHOMTH.Rows.Count < 0) { DMNHOMTH = new DmnhomdtthManager().SelectAllRDT(); } return DMNHOMTH; }
            set { DMNHOMTH = value; }
        }
        #endregion

        #region DMNHOMVVIEC
        private static DataTable _DMNHOMVUVIEC;
        public static DataTable DMNHOMVUVIEC
        {
            get             
            {
                if (_DMNHOMVUVIEC == null || _DMNHOMVUVIEC.Rows.Count < 0)
                {
                    if (TBNET.ERP.DATA.DMDONVI.DV_TH)
                    { _DMNHOMVUVIEC = new DmnhomvuviecdvManager().SelectAllRDT(); }
                    else
                    { _DMNHOMVUVIEC = new DmnhomvuviecdvManager().SelectByMadonviRDT(TBNET.ERP.DATA.DMDONVI._Current.Madonvi); }
                    }
                return _DMNHOMVUVIEC;
            }
            set { _DMNHOMVUVIEC = value; }
        }


        #endregion

        #region DmKYKETOAN
        private static DataTable DMKYKETOAN;
        public static DataTable DM_KYKETOAN
        {
            get
            {
                if (DMKYKETOAN == null || DMKYKETOAN.Rows.Count < 0)
                { DMKYKETOAN = new DmkyketoanManager().SelectAllRDT(); }
                return DMKYKETOAN;
            }
            set { DMKYKETOAN = value; }
        }
        #endregion

        #region QUYCTKTCT
        private static DataTable _DT_QUYCTKTCT = null;
        public static DataTable DT_QUYCTKTCT
        {
            get
            {
                if (_DT_QUYCTKTCT == null || _DT_QUYCTKTCT.Rows.Count == 0)
                {
                    if (TBNET.ERP.DATA.DMDONVI.DV_TH)
                    { _DT_QUYCTKTCT = new QuyctktctManager().SelectAllRDT(); }
                    else
                    {
                        _DT_QUYCTKTCT = new QuyctktctManager().SelectByMadonviRDT(TBNET.ERP.DATA.DMDONVI._Current.Madonvi);
                    }
                }
                return _DT_QUYCTKTCT;
            }
            set { _DT_QUYCTKTCT = value; }
        }
        #endregion

        #region CTKTGTGT
        private static DataTable _CTKTGTGTDAUVAO = null;
        public static DataTable CTKTGTGTDAUVAO
        {
            get
            {
                if (_CTKTGTGTDAUVAO == null || _CTKTGTGTDAUVAO.Rows.Count == 0)
                {
                    if (TBNET.ERP.DATA.DMDONVI.DV_TH)
                    { CTKTGTGTDAUVAO = new CtktgtgtdvaoManager().SelectAllRDT(); }
                    else
                    { _CTKTGTGTDAUVAO = new CtktgtgtdvaoManager().SelectByMadonviRDT(TBNET.ERP.DATA.DMDONVI._Current.Madonvi); }
                }
                return _CTKTGTGTDAUVAO;
            }
            set { _CTKTGTGTDAUVAO = value; }
        }
        #endregion

        #region VATTUGDCT
        private static DataTable _DT_VATTUGDCT = null;
        public static DataTable DT_VATTUGDCT
        {
            get
            {
                if (_DT_VATTUGDCT == null || _DT_VATTUGDCT.Rows.Count == 0)
                {
                    if (TBNET.ERP.DATA.DMDONVI.DV_TH)
                    { _DT_VATTUGDCT = new VattugdctManager().SelectAllRDT(); }
                    else
                    {
                        _DT_VATTUGDCT = new VattugdctManager().SelectByMadonviRDT(TBNET.ERP.DATA.DMDONVI._Current.Madonvi);
                    }
                }
                return _DT_VATTUGDCT;
            }
            set { _DT_VATTUGDCT = value; }
        }
        #endregion

        #region DMCTUDV
        private static DataTable _DT_DMCTUDV = null;
        public static DataTable DT_DMCTUDV
        {
            get
            {
                if (_DT_DMCTUDV == null || _DT_DMCTUDV.Rows.Count == 0)
                {
                    if (TBNET.ERP.DATA.DMDONVI.DV_TH)
                    { _DT_DMCTUDV = new DmctudvManager().SelectAllRDT(); }
                    else
                    { _DT_DMCTUDV = (new DmctudvManager()).SelectByMadonviRDT(TBNET.ERP.DATA.DMDONVI._Current.Madonvi); }
                    if ((new RolesManager()).SelectOne(TBNET.ERP.DATA.USERS._Current.Rolesid, TBNET.ERP.DATA.DMDONVI._Current.Madonvi).Rolesname.ToUpper() != RolesManager.ROLE_ADMINISTRATOR)
                    {
                        try
                        {
                            _DT_DMCTUDV = _DT_DMCTUDV.Select(DmctudvFields.Rolesid.Name + " LIKE '%;" + TBNET.ERP.DATA.USERS._Current.Rolesid + ";%'").CopyToDataTable();
                        }
                        catch { return null; }
                    }
                    return _DT_DMCTUDV;
                }
                else
                {
                    return _DT_DMCTUDV;
                }
            }
            set
            {
                _DT_DMCTUDV = value;
            }
        }
        private static string _DMCTUDV_SQL_WHERE_OR = "";
        public static string DMCTUDV_SQL_WHERE_OR
        {
            get
            {
            if(string.IsNullOrEmpty(_DMCTUDV_SQL_WHERE_OR))
            {
                for (int i = 0; i < DT_DMCTUDV.Rows.Count; i++)
                {
                    DataRow r = DT_DMCTUDV.Rows[i];
                    if (i == DT_DMCTUDV.Rows.Count - 1)
                    {
                        _DMCTUDV_SQL_WHERE_OR = _DMCTUDV_SQL_WHERE_OR + QuyctktFields.Madmloaict.Name + " LIKE '" + r[DmctudvFields.Mactu.Name].ToString() + "%'";
                    }
                    else
                    {
                        _DMCTUDV_SQL_WHERE_OR = _DMCTUDV_SQL_WHERE_OR + QuyctktFields.Madmloaict.Name + " LIKE '" + r[DmctudvFields.Mactu.Name].ToString() + "%' OR ";
                    }
                }
            }
            return _DMCTUDV_SQL_WHERE_OR;
            }
        }
        #endregion

        #region DMTKDV
        private static DataTable _DT_DMTK = null;        
        public static DataTable DT_DMTK
        {
            get
            {
                return _DT_DMTK;
            }
            set
            {
                _DT_DMTK = value;
            }
        }
        private static DataTable _DT_DMTKDV = null;
        public static DataTable DT_DMTKDV
        {
            get
            {
                if (_DT_DMTKDV == null || _DT_DMTKDV.Rows.Count == 0)
                {
                    //RolesEntity _RolesEntity = (new RolesManager()).SelectOne(TBNET.ERP.DATA.USERS._Current.Rolesid, TBNET.ERP.DATA.DMDONVI._Current.Madonvi);
                    //if (_RolesEntity != null)
                    //{
                        if (TBNET.ERP.DATA.USERS._RolesEntity.Rolesname.ToUpper().Equals(RolesManager.ROLE_ADMINISTRATOR))
                        {
                            if (TBNET.ERP.DATA.DMDONVI.DV_TH)
                            { _DT_DMTKDV = (new DmtkdvManagerBase()).SelectAllRDT(); }
                            else
                            { _DT_DMTKDV = (new DmtkdvManagerBase()).SelectByMadonviRDT(TBNET.ERP.DATA.DMDONVI._Current.Madonvi); }
                            DataView view = _DT_DMTKDV.DefaultView;
                            view.Sort = DmtkdvFields.Matk.Name + " ASC";
                            _DT_DMTKDV = view.ToTable();
                            return _DT_DMTKDV;
                        }
                        else
                        {
                            try
                            {
                                //_DT_DMTKDV = TBNET.ERP.DAL.DatabaseSpecific.RetrievalProcedures.DmtkdvSelectLikeRolesid(TBNET.ERP.DATA.DMDONVI._Current.Madonvi, ";" + TBNET.ERP.DATA.USERS._Current.Rolesid + ";").Tables[0];                                
                                _DT_DMTKDV = (new DmtkdvManagerBase()).SelectByMadonviRDT(TBNET.ERP.DATA.DMDONVI._Current.Madonvi).Select(DmtkdvFields.Rolesid.Name + " like '%" + TBNET.ERP.DATA.USERS._Current.Rolesid + "%'").CopyToDataTable();
                                DataView view = _DT_DMTKDV.DefaultView;
                                view.Sort = DmtkdvFields.Matk.Name + " ASC";
                                _DT_DMTKDV = view.ToTable();
                                return _DT_DMTKDV;
                            }
                            catch { return null; }
                        }
                    //}
                    //else 
                    //{
                    //    return null;
                    //}
                }
                else
                {
                    return _DT_DMTKDV;
                }
            }
            set
            {
                _DT_DMTKDV = value;
            }
        }
        private static DataTable _DT_DMTKDV_CT = null;
        public static DataTable DT_DMTKDV_CT
        {
            get
            {
                if (_DT_DMTKDV_CT == null || _DT_DMTKDV_CT.Rows.Count <= 0)
                {
                    try
                    {
                       _DT_DMTKDV_CT = DT_DMTKDV.Select(DmtkdvFields.Tkchitiet.Name + " = " + TBNET.ERP.LIB.STATIC_PARAM.TK_CHI_TIET + " or " + DmtkdvFields.Tkchitiet.Name + " =" + TBNET.ERP.LIB.STATIC_PARAM.TK_CHI_TIET_SO_CAI).CopyToDataTable();
                    }
                    catch { _DT_DMTKDV_CT = DT_DMTKDV; }                    
                    return _DT_DMTKDV_CT;
                }
                else
                { return _DT_DMTKDV_CT; }
            }
            set
            {
                _DT_DMTKDV_CT = value;
            }
        }        
        private static DataTable _DT_DMTKDV_SC = null;
        public static DataTable DT_DMTKDV_SC
        {
            get
            {
                if (_DT_DMTKDV_SC == null || _DT_DMTKDV_SC.Rows.Count <= 0)
                {
                    try
                    {
                        _DT_DMTKDV_SC = DT_DMTKDV.Select(DmtkdvFields.Tkchitiet.Name + " = " + TBNET.ERP.LIB.STATIC_PARAM.TK_SO_CAI + " or " + DmtkdvFields.Tkchitiet.Name + " =" + TBNET.ERP.LIB.STATIC_PARAM.TK_CHI_TIET_SO_CAI).CopyToDataTable();
                    }
                    catch { _DT_DMTKDV_SC = DT_DMTKDV; }
                    return _DT_DMTKDV_SC;
                }
                else { return _DT_DMTKDV_SC; }
            }
            set
            {
                _DT_DMTKDV_SC = value;
            }
        }
        #endregion

        #region DMQHNGUOITHAN
        private static DataTable _DMQHNGUOITHAN = null;
        public static DataTable DT_QHNGUOITHAN
        {
            get
            {
                if (_DMQHNGUOITHAN == null || _DMQHNGUOITHAN.Rows.Count == 0)
                {
                    if (TBNET.ERP.DATA.DMDONVI.DV_TH)
                    { _DMQHNGUOITHAN = new DmqhnguoithanManager().SelectAllRDT(); }
                    else
                    { _DMQHNGUOITHAN = (new DmqhnguoithanManager().SelectByMadonviRDT(TBNET.ERP.DATA.DMDONVI._Current.Madonvi)); }
                    return _DMQHNGUOITHAN;
                }
                else { return _DMQHNGUOITHAN; }
            }
            set { _DMQHNGUOITHAN = value; }
        }
            
        #endregion

        #region HRNGUOITHAN
        private static DataTable _HRNGUOITHAN = null;
        public static DataTable HR_NGUOITHAN
        {
            get
            {
                if (_HRNGUOITHAN == null || _HRNGUOITHAN.Rows.Count == 0)
                {
                    if (TBNET.ERP.DATA.DMDONVI.DV_TH)
                    { _HRNGUOITHAN = new HrkpcdManager().SelectAllRDT(); }
                    else
                    { _HRNGUOITHAN = (new HrkpcdManager().SelectByMadonviRDT(TBNET.ERP.DATA.DMDONVI._Current.Madonvi)); }
                    return _HRNGUOITHAN;
                }
                else { return _HRNGUOITHAN; }
            }
            set { _HRNGUOITHAN = value; }
        }

        #endregion

        #region DMCHUYENNGANH
        private static DataTable _DMCHYENNGANH =null;
        public static DataTable DT_CHUYENNGANH
        {
            get             
            {
                if (_DMCHYENNGANH == null || _DMCHYENNGANH.Rows.Count == 0)
                {
                    if (TBNET.ERP.DATA.DMDONVI.DV_TH)
                    { _DMCHYENNGANH = new DmchuyennganhManager().SelectAllRDT(); }
                    else
                    { _DMCHYENNGANH = (new DmchuyennganhManager().SelectByMadonviRDT(TBNET.ERP.DATA.DMDONVI._Current.Madonvi)); }
                    return _DMCHYENNGANH;
                }
                else { return _DMCHYENNGANH; }
            }
            set { _DMCHYENNGANH = value; }
        }

        #endregion

        #region DmXEPLOAI
        private static DataTable _DMXEPLOAI= null;
        public static DataTable DT_XEPLOAI
        {
            get
            {
                if (_DMXEPLOAI == null || _DMXEPLOAI.Rows.Count == 0)
                {
                    if (TBNET.ERP.DATA.DMDONVI.DV_TH)
                    { _DMXEPLOAI = new DmxeploaibangManager().SelectAllRDT(); }
                    else
                    { _DMXEPLOAI = (new DmxeploaibangManager().SelectByMadonviRDT(TBNET.ERP.DATA.DMDONVI._Current.Madonvi)); }
                    return _DMXEPLOAI;
                }
                else { return _DMXEPLOAI; }
            }
            set { _DMXEPLOAI = value; }
        }
        #endregion

        #region DMTTNHANVIEN
        private static DataTable _DMTTNHANVIEN = null;
        public static DataTable DT_TTNHANVIEN
        {
            get
            {
                if (_DMTTNHANVIEN == null || _DMTTNHANVIEN.Rows.Count == 0)
                {
                    if (TBNET.ERP.DATA.DMDONVI.DV_TH)
                    { _DMTTNHANVIEN = new DmttnhanvienManager().SelectAllRDT(); }
                    else
                    { _DMTTNHANVIEN = (new DmttnhanvienManager().SelectByMadonviRDT(TBNET.ERP.DATA.DMDONVI._Current.Madonvi)); }
                    return _DMTTNHANVIEN;
                }
                else { return _DMTTNHANVIEN; }
            }
            set { _DMTTNHANVIEN = value; }
        }
        #endregion

        #region DMTRUONGTN
        private static DataTable _DMTRUONGTN = null;
        public static DataTable DT_TRUONGTN
        {
            get
            {
                if (_DMTRUONGTN == null || _DMTRUONGTN.Rows.Count == 0)
                {
                    if (TBNET.ERP.DATA.DMDONVI.DV_TH)
                    { _DMTRUONGTN = new DmtruongtnManager().SelectAllRDT(); }
                    else
                    { _DMTRUONGTN = (new DmtruongtnManager().SelectByMadonviRDT(TBNET.ERP.DATA.DMDONVI._Current.Madonvi)); }
                    return _DMTRUONGTN;
                }
                else { return _DMTRUONGTN; }
            }
            set { _DMTRUONGTN = value; }
        }
        #endregion

        #region DMDTCHIUTHUE
        private static DataTable _DMDTCHIUTHUE = null;
        public static DataTable DT_DTCHIUTHUE
        {
            get
            {
                if (_DMDTCHIUTHUE == null || _DMDTCHIUTHUE.Rows.Count == 0)
                {
                    if (TBNET.ERP.DATA.DMDONVI.DV_TH)
                    { _DMDTCHIUTHUE = new DmdtchiuthueManager().SelectAllRDT(); }
                        else{
                    _DMDTCHIUTHUE = (new DmdtchiuthueManager().SelectByMadonviRDT(TBNET.ERP.DATA.DMDONVI._Current.Madonvi));}
                    return _DMDTCHIUTHUE;
                }
                else { return _DMDTCHIUTHUE; }
            }
            set { _DMDTCHIUTHUE = value; }
        }
        #endregion

        #region _DT_DMGIADV
        private static DataTable _DT_DMGIADV = null;
        public static DataTable DT_DMGIADV
        {
            get
            {
                if (_DT_DMGIADV == null || _DT_DMGIADV.Rows.Count == 0)
                {
                    if (TBNET.ERP.DATA.DMDONVI.DV_TH)
                    { _DT_DMGIADV = new DmdtchiuthuectManager().SelectAllRDT(); }
                    else
                    { _DT_DMGIADV = (new DmdtchiuthuectManager().SelectByMadonviRDT(TBNET.ERP.DATA.DMDONVI._Current.Madonvi)); }
                    return _DT_DMGIADV;
                }
                else { return _DT_DMGIADV; }
            }
            set { _DT_DMGIADV = value; }
        }
        #endregion
        #region DMDTCHIUTHUECT
        private static DataTable _DMDTCHIUTHUECT = null;
        public static DataTable DT_DTCHIUTHUECT
        {
            get
            {
                if (_DMDTCHIUTHUECT == null || _DMDTCHIUTHUECT.Rows.Count == 0)
                {
                    if (TBNET.ERP.DATA.DMDONVI.DV_TH)
                    { _DMDTCHIUTHUECT = new DmdtchiuthuectManager().SelectAllRDT(); }
                    else
                    { _DMDTCHIUTHUECT = (new DmdtchiuthuectManager().SelectByMadonviRDT(TBNET.ERP.DATA.DMDONVI._Current.Madonvi)); }
                    return _DMDTCHIUTHUECT;
                }
                else { return _DMDTCHIUTHUECT; }
            }
            set { _DMDTCHIUTHUECT = value; }
        }
        #endregion

        #region DMNHOMLOAITHUNHAP
        private static DataTable _DMNHOMLOAITHUNHAP = null;
        public static DataTable DT_NHOMLOAITHUNHAP
        {
            get
            {
                if (_DMNHOMLOAITHUNHAP == null || _DMNHOMLOAITHUNHAP.Rows.Count == 0)
                {
                    if (TBNET.ERP.DATA.DMDONVI.DV_TH)
                    { _DMNHOMLOAITHUNHAP = new DmnhomloaithunhapManager().SelectAllRDT(); }
                    else
                    { _DMNHOMLOAITHUNHAP = (new DmnhomloaithunhapManager().SelectByMadonviRDT(TBNET.ERP.DATA.DMDONVI._Current.Madonvi)); }
                    return _DMNHOMLOAITHUNHAP;
                }
                else { return _DMNHOMLOAITHUNHAP; }
            }
            set { _DMNHOMLOAITHUNHAP = value; }
        }
        #endregion

        #region DMNGAYNGHI
        private static DataTable _DMNGAYNGHI = null;
        public static DataTable DT_DMNGAYNGHI
        {
            get
            {
                if (_DMNGAYNGHI == null || _DMNGAYNGHI.Rows.Count == 0)
                {
                    if (TBNET.ERP.DATA.DMDONVI.DV_TH)
                    { _DMNGAYNGHI = new DmngaynghiManager().SelectAllRDT(); }
                    else
                    { _DMNGAYNGHI = (new DmngaynghiManager().SelectByMadonviRDT(TBNET.ERP.DATA.DMDONVI._Current.Madonvi)); }
                    return _DMNGAYNGHI;
                }
                else { return _DMNGAYNGHI; }
            }
            set { _DMNGAYNGHI = value; }
        }
        #endregion

        #region DMNHOMNGAYNGHI
        private static DataTable _DMNHOMNGAYNGHI = null;
        public static DataTable DT_DMNHOMNGAYNGHI
        {
            get
            {
                if (_DMNHOMNGAYNGHI == null || _DMNHOMNGAYNGHI.Rows.Count == 0)
                {
                    if (TBNET.ERP.DATA.DMDONVI.DV_TH)
                    { _DMNHOMNGAYNGHI = new DmnhomngaynghiManager().SelectAllRDT(); }
                    else
                    { _DMNHOMNGAYNGHI = (new DmnhomngaynghiManager().SelectByMadonviRDT(TBNET.ERP.DATA.DMDONVI._Current.Madonvi)); }
                    return _DMNHOMNGAYNGHI;
                }
                else { return _DMNHOMNGAYNGHI; }
            }
            set { _DMNHOMNGAYNGHI = value; }
        }
        #endregion

        #region DMNHOMVITRI
        private static DataTable _DMNHOMVITRI = null;
        public static DataTable DT_DMNHOMVITRI
        {
            get
            {
                if (_DMNHOMVITRI == null || _DMNHOMVITRI.Rows.Count == 0)
                {
                    if (TBNET.ERP.DATA.DMDONVI.DV_TH)
                    { _DMNHOMVITRI = new DmnhomvitriManager().SelectAllRDT(); }
                    else
                    { _DMNHOMVITRI = (new DmnhomvitriManager().SelectByMadonviRDT(TBNET.ERP.DATA.DMDONVI._Current.Madonvi)); }
                    return _DMNHOMVITRI;
                }
                else { return _DMNHOMVITRI; }
            }
            set { _DMNHOMVITRI = value; }
        }
        #endregion

        #region DMKHOANKHAC
        private static DataTable _DMKHOANKHAC = null;
        public static DataTable DT_DMKHOANKHAC
        {
            get
            {
                if (_DMKHOANKHAC == null || _DMKHOANKHAC.Rows.Count == 0)
                {
                    if (TBNET.ERP.DATA.DMDONVI.DV_TH)
                    { _DMKHOANKHAC = new DmkhoankhacManager().SelectAllRDT(); }
                    else
                    { _DMKHOANKHAC = (new DmkhoankhacManager().SelectByMadonviRDT(TBNET.ERP.DATA.DMDONVI._Current.Madonvi)); }
                    return _DMKHOANKHAC;
                }
                else { return _DMKHOANKHAC; }
            }
            set { _DMKHOANKHAC = value; }
        }
        #endregion

        #region DMTTHONNHAN
        private static DataTable _DMTTHONNHAN = null;
        public static DataTable DT_TTHONNHAN
        {
            get
            {
                if (_DMTTHONNHAN == null || _DMTTHONNHAN.Rows.Count == 0)
                {
                    if (TBNET.ERP.DATA.DMDONVI.DV_TH)
                    { _DMTTHONNHAN = new DmtthonnhanManager().SelectAllRDT(); }
                    else
                    { _DMTTHONNHAN = (new DmtthonnhanManager().SelectByMadonviRDT(TBNET.ERP.DATA.DMDONVI._Current.Madonvi)); }
                    return _DMTTHONNHAN;
                }
                else { return _DMTTHONNHAN; }
            }
            set { _DMTTHONNHAN = value; }
        }

        #endregion

        #region DMNOICAPCMT
        private static DataTable _DMNOICAPCMT=null;
        public static DataTable DT_NOICAPCMT
        {
            get
            {
                if (_DMNOICAPCMT == null || _DMNOICAPCMT.Rows.Count == 0)
                {
                    if (TBNET.ERP.DATA.DMDONVI.DV_TH)
                    { _DMNOICAPCMT = new DmnoicapcmtManager().SelectAllRDT(); }
                    else
                    {
                        _DMNOICAPCMT = (new DmnoicapcmtManager().SelectByMadonviRDT(TBNET.ERP.DATA.DMDONVI._Current.Madonvi));
                    }
                    return _DMNOICAPCMT;
                }
                else { return _DMNOICAPCMT; }
            }
            set { _DMNOICAPCMT = value; }
        }

        #endregion

        #region DMNHOMNV
        private static DataTable _DMNHOMNV = null;
        public static DataTable DT_NHOMNV
        {
            get
            {
                if (_DMNHOMNV == null || _DMNHOMNV.Rows.Count == 0)
                {
                    if (TBNET.ERP.DATA.DMDONVI.DV_TH)
                    {_DMNHOMNV = new DmnhomnvManager().SelectAllRDT(); }
                    else
                   { _DMNHOMNV = (new DmnhomnvManager().SelectByMadonviRDT(TBNET.ERP.DATA.DMDONVI._Current.Madonvi));}
                    return _DMNHOMNV;
                }
                else { return _DMNHOMNV; }
            }
            set { _DMNHOMNV = value; }
        }

        #endregion

        #region DMTHAYDOI
        private static DataTable _DMTHAYDOI = null;
        public static DataTable DT_THAYDOI
        {
            get
            {
                if (_DMTHAYDOI == null || _DMTHAYDOI.Rows.Count == 0)
                {
                    if (TBNET.ERP.DATA.DMDONVI.DV_TH)
                    { _DMTHAYDOI = new DmthaydoiManager().SelectAllRDT(); }
                    else
                    { _DMTHAYDOI = (new DmthaydoiManager().SelectByMadonviRDT(TBNET.ERP.DATA.DMDONVI._Current.Madonvi)); }
                    return _DMTHAYDOI;
                }
                else { return _DMTHAYDOI; }
            }
            set { _DMTHAYDOI = value; }
        }
        #endregion 

        #region DMLYDOTHAYDOI
        private static DataTable _DMLYDOTHAYDOI = null;
        public static DataTable  DT_LYDOTHAYDOI
        {
        get
        {
            if (_DMLYDOTHAYDOI == null || _DMLYDOTHAYDOI.Rows.Count == 0)
            {
                if (TBNET.ERP.DATA.DMDONVI.DV_TH)
                { _DMLYDOTHAYDOI = new DmlydothaydoiManager().SelectAllRDT(); }
                else
                { _DMLYDOTHAYDOI = (new DmlydothaydoiManager().SelectByMadonviRDT(TBNET.ERP.DATA.DMDONVI._Current.Madonvi)); }
                return _DMLYDOTHAYDOI;
            }
            else { return _DMLYDOTHAYDOI; }
        }
            set { _DMLYDOTHAYDOI = value; }
       }

        #endregion

        #region DT_BAOCAODV
        private static DataTable _DT_BAOCAODV = null;
        public static DataTable DT_BAOCAODV
        {
            get 
            {
                try
                {
                    if (_DT_BAOCAODV == null || _DT_BAOCAODV.Rows.Count == 0)
                    {
                        _DT_BAOCAODV = new BaocaodvManager().SelectByMadonviRDT(TBNET.ERP.DATA.DMDONVI._Current.Madonvi); 
                        if (TBNET.ERP.DATA.USERS._RolesEntity.Rolesname.ToUpper().Equals(RolesManager.ROLE_ADMINISTRATOR)==false)
                        {
                            _DT_BAOCAODV = _DT_BAOCAODV.Select(BaocaodvFields.Rolesid.Name + " LIKE '%;" + TBNET.ERP.DATA.USERS._Current.Rolesid + ";%'").CopyToDataTable();
                        }
                        _DT_BAOCAODV = _DT_BAOCAODV.Select(BaocaodvFields.Sudung.Name + "='1'").CopyToDataTable();
                    }
                }
                catch { }
                return _DT_BAOCAODV;
            }
            set { _DT_BAOCAODV = value; }
        }
        #endregion

        #region DMNGANHANG
        private static DataTable _DM_NGANHANG = null;
        public static DataTable DM_NGANHANG
        {
            get
            {
                try
                {
                    if (_DM_NGANHANG == null || _DM_NGANHANG.Rows.Count == 0)
                    {
                        _DM_NGANHANG = new DmnganhangManager().SelectAllRDT();
                    }
                }
                catch { }
                return _DM_NGANHANG;
            }
            set { _DM_NGANHANG = value; }
        }
        #endregion

        #region DT_NHOMBAOCAO
        private static DataTable _DT_NHOMBAOCAO = null;
        public static DataTable DT_NHOMBAOCAO
        {
            get
            {
                if (_DT_NHOMBAOCAO == null || _DT_NHOMBAOCAO.Rows.Count == 0)_DT_NHOMBAOCAO = (new NhombaocaoManager()).SelectBySudungRDT(1);   
                return _DT_NHOMBAOCAO;
            }
            set 
            {
                _DT_NHOMBAOCAO = value; 
            }
        }
        #endregion

        #region DT_MENU
        private static DataTable _DT_MENU = null;
        public static DataTable DT_MENU
        {
            get
            {
                if (_DT_MENU == null || _DT_MENU.Rows.Count == 0)
                {
                    if (TBNET.ERP.DATA.DMDONVI._Current.Madonvicha.Equals("0000"))
                    {
                        _DT_MENU = (new MenuManager()).Select_By_Loaimenu_Madonvi_RDT(1,TBNET.ERP.DATA.DMDONVI._Current.Madonvi);
                    }
                    else
                    {
                        _DT_MENU = (new MenuManager()).Select_By_Loaimenu_Madonvi_RDT(2,TBNET.ERP.DATA.DMDONVI._Current.Madonvi);
                    }
                    return _DT_MENU;
                }
                else
                {
                    return _DT_MENU;
                }
            }
            set
            {
                _DT_MENU = value;
            }
        }
        #endregion

        #region DMCONGTHUCGTCT
        private static DataTable _DMCTGT = null;
        public static DataTable DMCONGTHUCGT
        {
            get
            {
                if (_DMCTGT == null || _DMCTGT.Rows.Count == 0)
                {
                    if (TBNET.ERP.DATA.DMDONVI.DV_TH)
                    { _DMCTGT = (new DmcongthucgtManager()).SelectAllRDT(); }
                    else
                    { _DMCTGT = (new DmcongthucgtManager()).SelectByMadonviRDT(TBNET.ERP.DATA.DMDONVI._Current.Madonvi); }
                    return _DMCTGT;
                }
                else
                {
                    return _DMCTGT;
                }
            }
            set
            {
                _DMCTGT = value;
            }
        }
        #endregion

        #region DMCONGTHUCGTCT
        private static DataTable _DMCTGTCT = null;
        public static DataTable DT_DMCONGTHUCGTCT
        {
            get
            {
                if (_DMCTGTCT == null || _DMCTGTCT.Rows.Count == 0)
                {
                    if (TBNET.ERP.DATA.DMDONVI.DV_TH)
                    { _DMCTGTCT = (new DmcongthucgtctManager()).SelectAllRDT(); }
                    else
                    { _DMCTGTCT = (new DmcongthucgtctManager()).SelectByMadonviRDT(TBNET.ERP.DATA.DMDONVI._Current.Madonvi); }
                    return _DMCTGTCT;
                }
                else
                {
                    return _DMCTGTCT;
                }
            }
            set
            {
                _DMCTGTCT = value;
            }
        }
        #endregion

        #region _DM_NHOMKMCP
        private static DataTable _DM_NHOMKMCP = null;
        public static DataTable DM_NHOMKMCP
        {
            get
            {
                if (_DM_NHOMKMCP == null || _DM_NHOMKMCP.Rows.Count == 0)
                {
                    _DM_NHOMKMCP = (new DmnhomkmcpManager()).SelectAllRDT();
                    return _DM_NHOMKMCP;
                }
                else
                {
                    return _DM_NHOMKMCP;
                }
            }
            set
            {
                _DM_NHOMKMCP = value;
            }
        }
        #endregion
       
        #region DM_LUONGVAPHUCAP_CT
        private static DataTable _DM_LUONGPHUCAP_CT = null;
        public static DataTable DT_LUONGPHUCAP_CT
        {
            get
            {
                if (_DM_LUONGPHUCAP_CT == null || _DM_LUONGPHUCAP_CT.Rows.Count == 0)
                {
                    try
                    {
                        if (TBNET.ERP.DATA.DMDONVI.DV_TH)
                        { _DM_LUONGPHUCAP_CT = (new DmluongvaphucapctManager()).SelectAllRDT(); }
                        else
                        { _DM_LUONGPHUCAP_CT = (new DmluongvaphucapctManager()).SelectByMadonviRDT(TBNET.ERP.DATA.DMDONVI._Current.Madonvi); }
                        DataView view = _DM_LUONGPHUCAP_CT.DefaultView;
                        view.Sort = DmluongvaphucapctFields.Tenloaithunhap.Name + " ASC";
                        _DM_LUONGPHUCAP_CT = view.ToTable();
                        return _DM_LUONGPHUCAP_CT;
                    }
                    catch { }
                    return _DM_LUONGPHUCAP_CT;
                }
                else
                {
                    return _DM_LUONGPHUCAP_CT;
                }
            }
            set
            {
                _DM_LUONGPHUCAP_CT = value;
            }
        }

        #endregion

        #region DM_LOAITHUNHAP
        private static DataTable _DM_LOAITHUNHAP = null;
        public static DataTable DT_DMLOAITHUNHAP
        {
            get
            {
                if (_DM_LOAITHUNHAP == null || _DM_LOAITHUNHAP.Rows.Count == 0)
                {
                    try
                    {
                        if (TBNET.ERP.DATA.DMDONVI.DV_TH)
                        { _DM_LOAITHUNHAP = (new DmloaithunhapManager()).SelectAllRDT(); }
                        else
                        { _DM_LOAITHUNHAP = (new DmloaithunhapManager()).SelectByMadonviRDT(TBNET.ERP.DATA.DMDONVI._Current.Madonvi); }
                        DataView view = _DM_LOAITHUNHAP.DefaultView;
                        view.Sort = DmloaithunhapFields.Tenloaithunhap.Name + " ASC";
                        _DM_LOAITHUNHAP = view.ToTable();
                        return _DM_LOAITHUNHAP;
                    }
                    catch { }
                    return _DM_LOAITHUNHAP;
                }
                else
                {
                    return _DM_LOAITHUNHAP;
                }
            }
            set
            {
                _DM_LOAITHUNHAP = value;
            }
        }       

        #endregion

        #region DM_DANGKYOT_CT
        private static DataTable DM_DANGKYOT_CT = null;
        public static DataTable DT_DANGKYOT_CT
        {
            get
            {
                if (DM_DANGKYOT_CT == null || DM_DANGKYOT_CT.Rows.Count == 0)
                {
                    try
                    {
                        if (TBNET.ERP.DATA.DMDONVI.DV_TH)
                        {
                            DM_DANGKYOT_CT = (new ChitietngaylamthemManager()).SelectAllRDT();
                        }
                        else
                        { DM_DANGKYOT_CT = (new ChitietngaylamthemManager()).SelectByMadonviRDT(TBNET.ERP.DATA.DMDONVI._Current.Madonvi); }
                        DataView view = DM_DANGKYOT_CT.DefaultView;
                        view.Sort = ChitietngaylamthemFields.Manhanvien.Name + " ASC";
                        DM_DANGKYOT_CT = view.ToTable();
                        return DM_DANGKYOT_CT;
                    }
                    catch { }
                    return DM_DANGKYOT_CT;
                }
                else
                {
                    return DM_DANGKYOT_CT;
                }
            }
            set
            {
                DM_DANGKYOT_CT = value;
            }
        }


        #endregion


        #region DM_DANGKYOT
        private static DataTable DM_DANGKYOT = null;
        public static DataTable DT_DANGKYOT
        {
            get
            {
                if (DM_DANGKYOT == null || DM_DANGKYOT.Rows.Count == 0)
                {
                    try
                    {
                        if (TBNET.ERP.DATA.DMDONVI.DV_TH)
                        { DM_DANGKYOT = (new DmdangkyotManager()).SelectAllRDT(); }
                        else
                        { DM_DANGKYOT = (new DmdangkyotManager()).SelectByMadonviRDT(TBNET.ERP.DATA.DMDONVI._Current.Madonvi); }
                        DataView view = DM_DANGKYOT.DefaultView;
                        view.Sort = DmdangkyotFields.Manhanvien.Name + " ASC";
                        DM_DANGKYOT = view.ToTable();
                        return DM_DANGKYOT;
                    }
                    catch { }
                    return DM_DANGKYOT;
                }
                else
                {
                    return DM_DANGKYOT;
                }
            }
            set
            {
                DM_DANGKYOT = value;
            }
        }


        #endregion

        #region BANGLUONG_CT
        private static DataTable _DM_BANGLUONG_CT = null;
        public static DataTable DT_BANGLUONG_CT
        {
            get
            {
                if (_DM_BANGLUONG_CT == null || _DM_BANGLUONG_CT.Rows.Count == 0)
                {
                    try
                    {
                        if (TBNET.ERP.DATA.DMDONVI.DV_TH)
                        { _DM_BANGLUONG_CT = (new BangluongManager()).SelectAllRDT(); }
                        else
                        { _DM_BANGLUONG_CT = (new BangluongManager()).SelectByMadonviRDT(TBNET.ERP.DATA.DMDONVI._Current.Madonvi); }
                        DataView view = _DM_BANGLUONG_CT.DefaultView;
                        view.Sort = BangluongFields.Manhanvien.Name + " ASC";
                        _DM_BANGLUONG_CT = view.ToTable();
                        return _DM_BANGLUONG_CT;
                    }
                    catch { }
                    return _DM_BANGLUONG_CT;
                }
                else
                {
                    return _DM_BANGLUONG_CT;
                }
            }
            set
            {
                _DM_BANGLUONG_CT = value;
            }
        }
        #endregion

        #region CHAMCONG

        private static DataTable _DM_CHAMCONG_CT = null;
        public static DataTable DT_CHAMCONG_CT
        {
            get
            {
                if (_DM_CHAMCONG_CT == null || _DM_CHAMCONG_CT.Rows.Count == 0)
                {
                    try
                    {
                        if (TBNET.ERP.DATA.DMDONVI.DV_TH)
                        { _DM_CHAMCONG_CT = (new ChamcongManager()).SelectAllRDT(); }
                        else
                        {_DM_CHAMCONG_CT = (new ChamcongManager()).SelectByMadonviRDT(TBNET.ERP.DATA.DMDONVI._Current.Madonvi);}
                        DataView view = _DM_CHAMCONG_CT.DefaultView;
                        view.Sort = ChamcongFields.Manhanvien.Name + " ASC";
                        _DM_CHAMCONG_CT = view.ToTable();
                        return _DM_CHAMCONG_CT;
                    }
                    catch { }
                    return _DM_CHAMCONG_CT;
                }
                else
                {
                    return _DM_CHAMCONG_CT;
                }
            }
            set
            {
                _DM_CHAMCONG = value;
            }
        }
        #endregion

        #region CHAMCONG

        private static DataTable _DM_CHAMCONG = null;
        public static DataTable DT_CHAMCONG
        {
            get
            {
                if (_DM_CHAMCONG == null || _DM_CHAMCONG.Rows.Count == 0)
                {
                    if (TBNET.ERP.DATA.DMDONVI.DV_TH)
                    { _DM_CHAMCONG = (new DmchamcongManager()).SelectAllRDT(); }
                    else
                    { _DM_CHAMCONG = (new DmchamcongManager()).SelectByMadonviRDT(TBNET.ERP.DATA.DMDONVI._Current.Madonvi); }
                    return _DM_CHAMCONG;
                }
                else { return _DM_CHAMCONG; }
            }
            set{ _DM_CHAMCONG = value;}
        }
        #endregion

        #region Ganlichlamviec
        private static  DataTable _DM_GANLICHLAMVIEC = null;
        public static DataTable DT_GANLICHLAMVIEC
        {
            get
            {
                if (_DM_GANLICHLAMVIEC == null || _DM_GANLICHLAMVIEC.Rows.Count == 0)
                {
                    try
                    {
                        if (TBNET.ERP.DATA.DMDONVI.DV_TH)
                        { _DM_GANLICHLAMVIEC = (new DmganlichlvManager()).SelectAllRDT(); }
                        else
                        { _DM_GANLICHLAMVIEC = (new DmganlichlvManager()).SelectByMadonviRDT(TBNET.ERP.DATA.DMDONVI._Current.Madonvi); }
                        DataView view = _DM_GANLICHLAMVIEC.DefaultView;
                       // view.Sort = DmganlichlvFields.t.Name + " ASC";
                        _DM_GANLICHLAMVIEC = view.ToTable();
                        return _DM_GANLICHLAMVIEC;
                    }
                    catch { }
                    return _DM_GANLICHLAMVIEC;
                }
                else
                {
                    return _DM_GANLICHLAMVIEC;
                }
            }
            set
            {
                _DM_GANLICHLAMVIEC = value;
            }
        }

        #endregion

        #region DMVTHHDV
        private static DataTable _DM_DMVTHHDV = null;
        public static DataTable DT_DMVTHHDV
        {
            get
            {
                if (_DM_DMVTHHDV == null || _DM_DMVTHHDV.Rows.Count == 0)
                {
                    try
                    {
                        if (TBNET.ERP.DATA.DMDONVI.DV_TH)
                        {
                            _DM_DMVTHHDV = (new DmvthhdvManager()).SelectAllRDT();
                        }
                        else { _DM_DMVTHHDV = (new DmvthhdvManager()).SelectBy_Madonvi_Issudung_RDT(TBNET.ERP.DATA.DMDONVI._Current.Madonvi,1); }
                        DataView view = _DM_DMVTHHDV.DefaultView;
                        view.Sort = DmvthhdvFields.Tenvtu.Name + " ASC";
                        _DM_DMVTHHDV = view.ToTable();
                        return _DM_DMVTHHDV;
                    }
                    catch { }
                    return _DM_DMVTHHDV;
                }
                else
                {
                    return _DM_DMVTHHDV;
                }
            }
            set
            {
                _DM_DMVTHHDV = value;
            }
        }
        #endregion

        #region DMVTHHDV
        private static DataTable _DM_DMVTHHDV_ALL = null;
        public static DataTable DM_DMVTHHDV_ALL
        {
            get
            {
                if (_DM_DMVTHHDV_ALL == null || _DM_DMVTHHDV_ALL.Rows.Count == 0)
                {
                    try
                    {
                        if (TBNET.ERP.DATA.DMDONVI.DV_TH)
                        {
                            _DM_DMVTHHDV_ALL = (new DmvthhdvManager()).SelectAllRDT();
                        }
                        else { _DM_DMVTHHDV_ALL = (new DmvthhdvManager()).SelectByMadonviRDT(TBNET.ERP.DATA.DMDONVI._Current.Madonvi); }
                        DataView view = _DM_DMVTHHDV_ALL.DefaultView;
                        view.Sort = DmvthhdvFields.Tenvtu.Name + " ASC";
                        _DM_DMVTHHDV_ALL = view.ToTable();
                        return _DM_DMVTHHDV_ALL;
                    }
                    catch { }
                    return _DM_DMVTHHDV_ALL;
                }
                else
                {
                    return _DM_DMVTHHDV_ALL;
                }
            }
            set
            {
                _DM_DMVTHHDV_ALL = value;
            }
        }
        #endregion

        #region DMVTHHDV_CT
        private static DataTable _DM_DMVTHHDV_CT = null;
        public static DataTable DT_DMVTHHDV_CT
        {
            get
            {
                if (_DM_DMVTHHDV_CT == null || _DM_DMVTHHDV_CT.Rows.Count == 0)
                {
                    if (TBNET.ERP.DATA.DMDONVI.DV_TH)
                    { _DM_DMVTHHDV_CT = (new DmvthhdvctManagerBase()).SelectAllRDT(); }
                    else
                    { _DM_DMVTHHDV_CT = (new DmvthhdvctManagerBase()).SelectByMadonviRDT(TBNET.ERP.DATA.DMDONVI._Current.Madonvi); }
                    return _DM_DMVTHHDV_CT;
                }
                else
                {
                    return _DM_DMVTHHDV_CT;
                }
            }
            set
            {
                _DM_DMVTHHDV_CT = value;
            }
        }
        #endregion
        #region TONVTHHDV
        private static DataTable _TONVTHHDV = null;
        public static DataTable TONVTHHDV
        {
            get
            {
                if (_TONVTHHDV == null || _TONVTHHDV.Rows.Count == 0)
                {
                    if (TBNET.ERP.DATA.DMDONVI.DV_TH)
                    { _TONVTHHDV = (new TonvthhdvManager()).SelectAllRDT(); }
                    else
                    { _TONVTHHDV = (new TonvthhdvManager()).SelectByMadonviRDT(TBNET.ERP.DATA.DMDONVI._Current.Madonvi); }
                    return _TONVTHHDV;
                }
                else
                {
                    return _TONVTHHDV;
                }
            }
            set
            {
                _TONVTHHDV = value;
            }
        }
        #endregion

        #region DMNHOMKHACHHANG
        private static DataTable _DMNHOMKHACHHANG = null;
        public static DataTable DMNHOMKHACHHANG
        {
            get
            {
                if (_DMNHOMKHACHHANG == null || _DMNHOMKHACHHANG.Rows.Count == 0)
                {
                    if (TBNET.ERP.DATA.DMDONVI.DV_TH)
                    { _DMNHOMKHACHHANG = (new DmnhomkhachhangManager()).SelectAllRDT(); }
                    else
                    { _DMNHOMKHACHHANG = (new DmnhomkhachhangManager()).SelectByMadonviRDT(TBNET.ERP.DATA.DMDONVI._Current.Madonvi); }
                    return _DMNHOMKHACHHANG;
                }
                else
                {
                    return _DMNHOMKHACHHANG;
                }
            }
            set
            {
                _DMNHOMKHACHHANG = value;
            }
        }
        #endregion

        #region _DMKHACHHANG_ALL_issudung
        private static DataTable _DMKHACHHANG_ALL_issudung = null;
        public static DataTable DMKHACHHANG_ALL_issudung
        {
            get
            {
                if (_DMKHACHHANG_ALL_issudung == null || _DMKHACHHANG_ALL_issudung.Rows.Count == 0)
                {
                    if (TBNET.ERP.DATA.DMDONVI.DV_TH)
                    { _DMKHACHHANG_ALL_issudung = (new DmkhachhangManager()).SelectAllRDT(); }
                    else
                    { _DMKHACHHANG_ALL_issudung = (new DmkhachhangManager()).SelectByMadonviRDT(TBNET.ERP.DATA.DMDONVI._Current.Madonvi); }
                    return _DMKHACHHANG_ALL_issudung;
                }
                else
                {
                    return _DMKHACHHANG_ALL_issudung;
                }                
            }
            set
            {
                _DMKHACHHANG_ALL_issudung = value;
            }
        }

        private static DataTable _DMKHACHHANG_issudung = null;
        public static DataTable DMKHACHHANG_issudung
        {
            get
            {
                if (_DMKHACHHANG_issudung == null || _DMKHACHHANG_issudung.Rows.Count == 0)
                {
                    try
                    {
                        _DMKHACHHANG_issudung = DMKHACHHANG_ALL_issudung.Select(DmkhachhangFields.Manhomkhachang.Name + " LIKE '%" + NHOMKH_KH + "%'").CopyToDataTable();
                    }
                    catch { _DMKHACHHANG_issudung = DMKHACHHANG_ALL_issudung.Clone(); }
                    return _DMKHACHHANG_issudung;
                }
                else
                {
                    return _DMKHACHHANG_issudung;
                }
            }
            set
            {
                _DMKHACHHANG_issudung = value;
            }
        }

        private static DataTable _DMNHACUNGCAP_issudung = null;
        public static DataTable DMNHACUNGCAP_issudung
        {
            get
            {
                if (_DMNHACUNGCAP_issudung == null || _DMNHACUNGCAP_issudung.Rows.Count == 0)
                {
                    try
                    {
                        _DMNHACUNGCAP_issudung = DMKHACHHANG_ALL_issudung.Select(DmkhachhangFields.Manhomkhachang.Name + " LIKE '%" + NHOMKH_NCC + "%'").CopyToDataTable();
                    }
                    catch { _DMNHACUNGCAP_issudung = DMKHACHHANG_ALL_issudung.Clone(); }
                    return _DMNHACUNGCAP_issudung;
                }
                else
                {
                    return _DMNHACUNGCAP_issudung;
                }
            }
            set
            {
                _DMNHACUNGCAP_issudung = value;
            }
        }

        private static DataTable _DMNHANVIEN_issudung = null;
        public static DataTable DMNHANVIEN_issudung
        {
            get
            {
                if (_DMNHANVIEN_issudung == null || _DMNHANVIEN_issudung.Rows.Count == 0)
                {
                    try
                    {
                        _DMNHANVIEN_issudung = DMKHACHHANG_ALL_issudung.Select(DmkhachhangFields.Manhomkhachang.Name + " LIKE '%" + NHOMKH_NV + "%'").CopyToDataTable();
                        return _DMNHANVIEN_issudung;
                    }
                    catch { return DMKHACHHANG_ALL_issudung.Clone(); }
                }
                else
                {
                    return _DMNHANVIEN_issudung;
                }
            }
            set
            {
                _DMNHANVIEN_issudung = value;
            }
        }
        #endregion

        #region DMKHACHHANG _ALL
        private static DataTable _DMKHACHHANG_ALL = null;
        public static DataTable DMKHACHHANG_ALL
        {
            get
            {
                if (_DMKHACHHANG_ALL == null || _DMKHACHHANG_ALL.Rows.Count == 0)
                {
                    if (TBNET.ERP.DATA.DMDONVI.DV_TH)
                    { _DMKHACHHANG_ALL = (new DmkhachhangManager()).SelectAllRDT(); }
                    else
                    { _DMKHACHHANG_ALL = (new DmkhachhangManager()).SelectBy_Madonvi_Issudung_RDT(TBNET.ERP.DATA.DMDONVI._Current.Madonvi, 1); }
                    return _DMKHACHHANG_ALL;
                }
                else
                {
                    return _DMKHACHHANG_ALL;
                }
            }
            set
            {
                _DMKHACHHANG_ALL = value;
            }
        }
       
        private static DataTable _DMKHACHHANG = null;
        public static DataTable DMKHACHHANG
        {
            get
            {
                if (_DMKHACHHANG == null || _DMKHACHHANG.Rows.Count == 0)
                {
                    try
                    {
                        _DMKHACHHANG = DMKHACHHANG_ALL.Select(DmkhachhangFields.Manhomkhachang.Name + " LIKE '%" + NHOMKH_KH + "%'").CopyToDataTable();
                    }
                    catch { _DMKHACHHANG = DMKHACHHANG_ALL.Clone(); }
                    return _DMKHACHHANG;
                }
                else
                {
                    return _DMKHACHHANG;
                }
            }
            set
            {
                _DMKHACHHANG = value;
            }
        }


        private static DataTable _DMNHACUNGCAP = null;
        public static DataTable DMNHACUNGCAP
        {
            get
            {
                if (_DMNHACUNGCAP == null || _DMNHACUNGCAP.Rows.Count == 0)
                {
                    try
                    {
                        _DMNHACUNGCAP = DMKHACHHANG_ALL.Select(DmkhachhangFields.Manhomkhachang.Name + " LIKE '%" + NHOMKH_NCC + "%'").CopyToDataTable();
                    }
                    catch { _DMNHACUNGCAP = DMKHACHHANG_ALL.Clone(); }
                    return _DMNHACUNGCAP;
                }
                else
                {
                    return _DMNHACUNGCAP;
                }
            }
            set
            {
                _DMNHACUNGCAP = value;
            }
        }

        private static DataTable _DMNHANVIEN = null;
        public static DataTable DMNHANVIEN
        {
            get
            {
                if (_DMNHANVIEN == null || _DMNHANVIEN.Rows.Count == 0)
                {
                    try
                    {
                        _DMNHANVIEN = DMKHACHHANG_ALL.Select(DmkhachhangFields.Manhomkhachang.Name + " LIKE '%" + NHOMKH_NV+ "%'").CopyToDataTable();
                        return _DMNHANVIEN;
                    }
                    catch { return DMKHACHHANG_ALL.Clone(); }
                }
                else
                {
                    return _DMNHANVIEN;
                }
            }
            set
            {
                _DMNHANVIEN = value;
            }
        }

        #endregion

        #region NHANVIENKHACHHANG
        private static DataTable _NHANVIENKHACHHANG = null;
        public static DataTable NHANVIENKHACHHANG
        { 
         get
            {
                if (_NHANVIENKHACHHANG == null || _NHANVIENKHACHHANG.Rows.Count == 0)
                {
                    if (TBNET.ERP.DATA.DMDONVI.DV_TH)
                    { _NHANVIENKHACHHANG = (new NhanvienkhachhangManeger()).SelectAllRDT(); }
                    else
                    { _NHANVIENKHACHHANG = (new NhanvienkhachhangManeger()).SelectByMadonviRDT(TBNET.ERP.DATA.DMDONVI._Current.Madonvi); }
                    return _NHANVIENKHACHHANG;
                }
                else
                {
                    return _NHANVIENKHACHHANG;
                }
            }
            set
            {
                _NHANVIENKHACHHANG = value;
            }
        }

        #endregion

        #region DT_LOAIVTU
        private static DataTable _DT_LOAIVTU = null;
        public static DataTable DT_LOAIVTU
        {
            get
            {
                if (_DT_LOAIVTU == null || _DT_LOAIVTU.Rows.Count == 0)
                {
                    if (TBNET.ERP.DATA.DMDONVI.DV_TH)
                    { _DT_LOAIVTU = (new DmloaivtudvManager()).SelectAllRDT(); }
                    else
                    { _DT_LOAIVTU = (new DmloaivtudvManager()).SelectByMadonviRDT(TBNET.ERP.DATA.DMDONVI._Current.Madonvi); }
                    return _DT_LOAIVTU;
                }
                else
                {
                    return _DT_LOAIVTU;
                }
            }
            set
            {
                _DT_LOAIVTU = value;
            }
        }
        #endregion        

        #region DT_NHOMVTU
        private static DataTable _DT_NHOMVTU = null;
        public static DataTable DT_NHOMVTU
        {
            get
            {
                if (_DT_NHOMVTU == null || _DT_NHOMVTU.Rows.Count == 0)
                {
                    if (TBNET.ERP.DATA.DMDONVI.DV_TH)
                    { _DT_NHOMVTU = (new DmnhomvtudvManager()).SelectAllRDT(); }
                    else
                    { _DT_NHOMVTU = (new DmnhomvtudvManager()).SelectByMadonviRDT(TBNET.ERP.DATA.DMDONVI._Current.Madonvi); }
                    return _DT_NHOMVTU;
                }
                else
                {
                    return _DT_NHOMVTU;
                }
            }
            set
            {
                _DT_NHOMVTU = value;
            }
        }
        #endregion

        #region DMKEHANG
        private static DataTable _DMKEHANG_ALL = null;
        public static DataTable DMKEHANG_ALL
        {
            get
            {
                if (_DMKEHANG_ALL == null || _DMKEHANG_ALL.Rows.Count == 0)
                {
                    if (TBNET.ERP.DATA.DMDONVI.DV_TH)
                    { _DMKEHANG_ALL = (new DmkehangdvManager()).SelectAllRDT(); }
                    else
                    { _DMKEHANG_ALL = (new DmkehangdvManager()).SelectByMadonviRDT(TBNET.ERP.DATA.DMDONVI._Current.Madonvi); }
                    return _DMKEHANG_ALL;
                }
                else
                {
                    return _DMKEHANG_ALL;
                }
            }
            set
            {
                _DMKEHANG_ALL = value;
            }
        }
        #endregion

        #region DMDONVITINHDV
        private static DataTable _DMDONVITINHDV = null;
        public static DataTable DMDONVITINHDV
        {
            get
            {
                if (_DMDONVITINHDV == null || _DMDONVITINHDV.Rows.Count == 0)
                {
                    if (TBNET.ERP.DATA.DMDONVI.DV_TH)
                    { _DMDONVITINHDV = (new DmdonvitinhdvManager()).SelectAllRDT(); }
                    else
                    { _DMDONVITINHDV = (new DmdonvitinhdvManager()).SelectByMadonviRDT(TBNET.ERP.DATA.DMDONVI._Current.Madonvi); }
                    return _DMDONVITINHDV;
                }
                else
                {
                    return _DMDONVITINHDV;
                }
            }
            set
            {
                _DMDONVITINHDV = value;
            }
        }
        #endregion

        #region THONGTINHETHONG

        private static DataTable _THONGTINHETHONG = null;
        public static DataTable THONGTINHETHONG
        {
            get
            {
                if (_THONGTINHETHONG == null || _THONGTINHETHONG.Rows.Count == 0)
                {
                    if (TBNET.ERP.DATA.DMDONVI.DV_TH)
                    { _THONGTINHETHONG = (new ThongtinhethongManager()).SelectAllRDT(); }
                    else
                    { _THONGTINHETHONG = (new ThongtinhethongManager()).SelectByMadonviRDT(TBNET.ERP.DATA.DMDONVI._Current.Madonvi); }
                    return _THONGTINHETHONG;
                }
                else
                {
                    return _THONGTINHETHONG;
                }
            }
            set
            {
                _THONGTINHETHONG = value;
            }
        }

        #endregion

        #region FROMNAME CONTROL MENU

        private static DataTable _MENUFROMNEMCONTRO = null;
        public static DataTable MENUFROMNEMCONTRO
        {
            get
            {
                if (_MENUFROMNEMCONTRO == null || _MENUFROMNEMCONTRO.Rows.Count == 0)
                {
                    _MENUFROMNEMCONTRO = TBNet.Project.IO.ReadXMLTOW(TBNET.ERP.LIB.PATH.ERP_PATH + @"\XMLCONFIG\MENUFROMNEMCONTRO.xml");
                    return _MENUFROMNEMCONTRO;
                }
                else
                {
                    return _MENUFROMNEMCONTRO;
                }
            }
            set
            {
                _MENUFROMNEMCONTRO = value;
            }
        }
        #endregion
        #region TABLE NAME
        private static DataTable _TABLENAME = null;
        public static DataTable TABLECTDOITUONG
        {
            get
            {
                if (_TABLENAME == null || _TABLENAME.Rows.Count == 0)
                {
                    _TABLENAME = TBNet.Project.IO.ReadXMLTOW(TBNET.ERP.LIB.PATH.ERP_PATH + @"\XMLCONFIG\TABLECTDOITUONG.xml");
                    return _TABLENAME;
                }
                else
                {
                    return _TABLENAME;
                }
            }
            set
            {
                _TABLENAME = value;
            }
        }
        #endregion

        #region CTDOITUONG
        private static DataTable _CTDOITUONG = null;
        public static DataTable CTDOITUONG
        {
            get
            {
                if (_CTDOITUONG == null || _CTDOITUONG.Rows.Count == 0)
                {
                    _CTDOITUONG = TBNet.Project.IO.ReadXMLTOW(TBNET.ERP.LIB.PATH.ERP_PATH + @"\XMLCONFIG\TABLECTDOITUONG.xml");
                
                    return _CTDOITUONG;
                }
                else
                {
                    return _CTDOITUONG;
                }
            }
            set
            {
                _CTDOITUONG = value;
            }
        }

        #endregion

        #region DMDTPN
        private static DataTable _DMDTPN = null;
        public static DataTable DMDTPN
        {
            get
            {
                if (_DMDTPN == null || _DMDTPN.Rows.Count == 0)
                {
                    if (TBNET.ERP.DATA.DMDONVI.DV_TH)
                    { _DMDTPN = (new DmdtpnManager()).SelectAllRDT(); }
                    else
                    { _DMDTPN = (new DmdtpnManager()).SelectByMadonviRDT(TBNET.ERP.DATA.DMDONVI._Current.Madonvi); }
                    return _DMDTPN;
                }
                else
                {
                    return _DMDTPN;
                }
            }
            set
            {
                _DMDTPN = value;
            }
        }
        #endregion

        #region DMVITRI
        private static DataTable _DMVITRI = null;
        public static DataTable DMVITRI
        {
            get             
            {
                if (_DMVITRI == null || _DMVITRI.Rows.Count == 0)
                {
                    if (TBNET.ERP.DATA.DMDONVI.DV_TH)
                    {_DMVITRI=(new DmvitriManager().SelectAllRDT());}
                    else
                    {_DMVITRI=(new DmvitriManager().SelectByMadonviRDT(TBNET.ERP.DATA.DMDONVI._Current.Madonvi));}
                        return _DMVITRI;
                }
                else{return _DMVITRI;}
            }
            set { _DMVITRI=value;}
        }

        #endregion

        #region Danh muc nhom vi tri

        private static DataTable DM_NHOMVITRI = null;
        public static DataTable DT_NHOMVITRI
        {
            get
            {
                if (DM_NHOMVITRI == null || DM_NHOMVITRI.Rows.Count == 0)
                {
                    if (TBNET.ERP.DATA.DMDONVI.DV_TH)
                    {DM_NHOMVITRI = (new DmnhomvitriManager()).SelectAllRDT();}
                    else
                    {DM_NHOMVITRI = (new DmnhomvitriManager().SelectByMadonviRDT(TBNET.ERP.DATA.DMDONVI._Current.Madonvi));}
                    return DM_NHOMVITRI;
                }
                else { return DM_NHOMVITRI; }
            }
            set { DM_NHOMVITRI = value; }
        }

        #endregion

        #region Lich lam viec

        private static DataTable _DM_LICHLAMVIEC = null;
        public static DataTable DT_LICHALMVIEC
        {
            get
            {
                if (_DM_LICHLAMVIEC == null || _DM_LICHLAMVIEC.Rows.Count == 0)
                {
                    if (TBNET.ERP.DATA.DMDONVI.DV_TH)
                    { _DM_LICHLAMVIEC = new DmlichlvManager().SelectAllRDT(); }
                    else
                    { _DM_LICHLAMVIEC = (new DmlichlvManager().SelectByMadonviRDT(TBNET.ERP.DATA.DMDONVI._Current.Madonvi)); }
                    return _DM_LICHLAMVIEC;
                }
                else { return _DM_LICHLAMVIEC; }
            }
            set { _DM_LICHLAMVIEC = value; }
        }
        #endregion

        #region Danh muc bao hiem

        private static DataTable DMBAOHIEM = null;
        public static DataTable DT_BAOHIEM
        {
            get
            {
                if (DMBAOHIEM == null || DMBAOHIEM.Rows.Count == 0)
                {
                    if (TBNET.ERP.DATA.DMDONVI.DV_TH)
                    { DMBAOHIEM = (new DmbaohiemManager()).SelectAllRDT(); }
                    else
                    { DMBAOHIEM = (new DmbaohiemManager().SelectByMadonviRDT(TBNET.ERP.DATA.DMDONVI._Current.Madonvi)); }
                    return DMBAOHIEM;
                }
                else { return DMBAOHIEM; }
            }
            set { DMBAOHIEM = value; }
        }
        #endregion

        #region HR_BHXH
        private static DataTable _HR_BHXH = null;
        public static DataTable DM_BHXH
        {
            get
            {
                if (_HR_BHXH == null || _HR_BHXH.Rows.Count == 0)
                {
                    if (TBNET.ERP.DATA.DMDONVI.DV_TH)
                    { _HR_BHXH = (new HrbhxhManager()).SelectAllRDT(); }
                    else
                    { _HR_BHXH = (new HrbhxhManager().SelectByMadonviRDT(TBNET.ERP.DATA.DMDONVI._Current.Madonvi)); }
                    return _HR_BHXH;
                }
                else { return _HR_BHXH; }
            }
            set { _HR_BHXH = value; }
        }
        #endregion

        #region Hr_BHYT 

        private static DataTable HR_BHYT = null;
        public static DataTable _DM_BHYT
        {
            get
            {
                if (HR_BHYT == null || HR_BHYT.Rows.Count == 0)
                {
                    if (TBNET.ERP.DATA.DMDONVI.DV_TH)
                    { HR_BHYT = (new HrbhytManager()).SelectAllRDT(); }
                    else
                    { HR_BHYT = (new HrbhytManager().SelectByMadonviRDT(TBNET.ERP.DATA.DMDONVI._Current.Madonvi)); }
                    return HR_BHYT;
                }
                else { return HR_BHYT; }
            }
            set { HR_BHYT = value; }
        }

        #endregion

        #region hr_BHTN
        private static DataTable HR_BHTN = null;
        public static DataTable _DM_BHTN
        {
            get
            {
                if (HR_BHTN == null || HR_BHTN.Rows.Count == 0)
                {
                    if (TBNET.ERP.DATA.DMDONVI.DV_TH)
                    { HR_BHTN = (new HrbhtnManager()).SelectAllRDT(); }
                    else
                    { HR_BHTN = (new HrbhtnManager().SelectByMadonviRDT(TBNET.ERP.DATA.DMDONVI._Current.Madonvi)); }
                    return HR_BHTN;
                }
                else { return HR_BHTN; }
            }
            set { HR_BHTN = value; }
        }

        #endregion
        
        #region DMQUOCGIA
        private static DataTable _DMQUOCGIA = null;
        public static DataTable DT_QUOCGIA
        {
            get
            {
                if (_DMQUOCGIA == null || _DMQUOCGIA.Rows.Count == 0)
                {
                    if (TBNET.ERP.DATA.DMDONVI.DV_TH)
                    { _DMQUOCGIA = (new DmquocgiaManager()).SelectAllRDT(); }
                    { _DMQUOCGIA = (new DmquocgiaManager().SelectByMadonviRDT(TBNET.ERP.DATA.DMDONVI._Current.Madonvi)); }
                    return _DMQUOCGIA;
                }
                else { return _DMQUOCGIA; }
            }
            set { _DMQUOCGIA = value; }
        }

        #endregion

        #region DMTINHTHANH
        private static DataTable _DMTINHTHANH = null;
        public static DataTable DT_TINHTHANH
        {
            get
            {
                if (_DMTINHTHANH == null || _DMTINHTHANH.Rows.Count == 0)
                {
                    if (TBNET.ERP.DATA.DMDONVI.DV_TH)
                    { _DMTINHTHANH = (new DmtinhthanhManager()).SelectAllRDT(); }
                    else
                    { _DMTINHTHANH = (new DmtinhthanhManager().SelectByMadonviRDT(TBNET.ERP.DATA.DMDONVI._Current.Madonvi)); }
                    return _DMTINHTHANH;
                }
                else { return _DMTINHTHANH; }
            }
            set { _DMTINHTHANH = value; }
        }
        #endregion

        #region DMKMCPDV
        private static DataTable _DMKMCPDV = null;
        public static DataTable DMKMCPDV
        {
            get
            {
                if (_DMKMCPDV == null || _DMKMCPDV.Rows.Count == 0)
                {
                    if (TBNET.ERP.DATA.DMDONVI.DV_TH)
                    { _DMKMCPDV = (new DmkmcpdvManager()).SelectAllRDT(); }
                    else
                    { _DMKMCPDV = (new DmkmcpdvManager()).SelectByMadonviRDT(TBNET.ERP.DATA.DMDONVI._Current.Madonvi); }
                    return _DMKMCPDV;
                }
                else
                {
                    return _DMKMCPDV;
                }
            }
            set
            {
                _DMKMCPDV = value;
            }
        }
        #endregion

        #region DMTYGIA
        private static DataTable _DMTYGIA = null;
        public static DataTable DMTYGIA
        {
            get
            {
                if (_DMTYGIA == null || _DMTYGIA.Rows.Count == 0)
                {
                    if (TBNET.ERP.DATA.DMDONVI.DV_TH)
                    { _DMTYGIA = (new DmtygiaManager()).SelectAllRDT(); }
                    else
                    { _DMTYGIA = (new DmtygiaManager()).SelectByMadonviRDT(TBNET.ERP.DATA.DMDONVI._Current.Madonvi); }
                    return _DMTYGIA;
                }
                else
                {
                    return _DMTYGIA;
                }
            }
            set
            {
                _DMTYGIA = value;
            }
        }
        #endregion

        #region DMVAT
        private static DataTable _DMVAT = null;
        public static DataTable DMVAT
        {
            get
            {
                if (_DMVAT == null || _DMVAT.Rows.Count == 0)
                {
                    if (TBNET.ERP.DATA.DMDONVI.DV_TH)
                    { _DMVAT = (new DmvatManager()).SelectAllRDT(); }
                    else
                    { _DMVAT = (new DmvatManager()).SelectByMadonviRDT(TBNET.ERP.DATA.DMDONVI._Current.Madonvi); }
                    return _DMVAT;
                }
                else
                {
                    return _DMVAT;
                }
            }
            set
            {
                _DMVAT = value;
            }
        }
        #endregion

        #region DMPTNXDV
        private static DataTable _DMPTNXDV = null;
        public static DataTable DMPTNXDV
        {
            get
            {
                if (_DMPTNXDV == null || _DMPTNXDV.Rows.Count == 0)
                {
                    if (TBNET.ERP.DATA.DMDONVI.DV_TH)
                    { _DMPTNXDV = (new DmptnxdvManager()).SelectAllRDT(); }
                    else
                    { _DMPTNXDV = (new DmptnxdvManager()).SelectByMadonviRDT(TBNET.ERP.DATA.DMDONVI._Current.Madonvi); }
                    return _DMPTNXDV;
                }
                else
                {
                    return _DMPTNXDV;
                }
            }
            set
            {
                _DMPTNXDV = value;
            }
        }
        #endregion       

        #region DMHOPDONGMUADV
        private static DataTable _DMHOPDONGMUADVT = null;
        public static DataTable DMHOPDONGMUADV
        {
            get
            {
                if (_DMHOPDONGMUADVT == null || _DMHOPDONGMUADVT.Rows.Count == 0)
                {
                    if (TBNET.ERP.DATA.DMDONVI.DV_TH)
                    { _DMHOPDONGMUADVT = (new DmhopdongmuadvManager()).SelectAllRDT(); }
                    else
                    { _DMHOPDONGMUADVT = (new DmhopdongmuadvManager()).SelectByMadonviRDT(TBNET.ERP.DATA.DMDONVI._Current.Madonvi); }
                    return _DMHOPDONGMUADVT;
                }
                else
                {
                    return _DMHOPDONGMUADVT;
                }
            }
            set
            {
                _DMHOPDONGMUADVT = value;
            }
        }
        #endregion

        #region DMHOPDONG
        private static DataTable _DMHOPDONG = null;
        public static DataTable DMHOPDONG
        {
            get
            {
                if (_DMHOPDONG == null || _DMHOPDONG.Rows.Count == 0)
                {
                    if (TBNET.ERP.DATA.DMDONVI.DV_TH)
                    { _DMHOPDONG = (new DmhopdongManager()).SelectAllRDT(); }
                    else
                    { _DMHOPDONG = (new DmhopdongManager()).SelectByMadonviRDT(TBNET.ERP.DATA.DMDONVI._Current.Madonvi); }
                    return _DMHOPDONG;
                }
                else
                {
                    return _DMHOPDONG;
                }
            }
            set
            {
                _DMHOPDONG = value;
            }
        }
        #endregion


        #region DMHOPDONGBANDV
        private static DataTable _DMHOPDONGBANDV = null;
        public static DataTable DMHOPDONGBANDV
        {
            get
            {
                if (_DMHOPDONGBANDV == null || _DMHOPDONGBANDV.Rows.Count == 0)
                {
                    if (TBNET.ERP.DATA.DMDONVI.DV_TH)
                    { _DMHOPDONGBANDV = (new DmhopdongbandvManager()).SelectAllRDT(); }
                    else
                    { _DMHOPDONGBANDV = (new DmhopdongbandvManager()).SelectByMadonviRDT(TBNET.ERP.DATA.DMDONVI._Current.Madonvi); }
                    return _DMHOPDONGBANDV;
                }
                else
                {
                    return _DMHOPDONGBANDV;
                }
            }
            set
            {
                _DMHOPDONGBANDV = value;
            }
        }
        #endregion

        #region DMKHODV
        private static DataTable _DMKHODV = null;
        public static DataTable DMKHODV
        {
            get
            {
                if (_DMKHODV == null || _DMKHODV.Rows.Count == 0)
                {
                    if (TBNET.ERP.DATA.DMDONVI.DV_TH)
                    { _DMKHODV = (new DmkhodvManager()).SelectAllRDT(); }
                    else
                    { _DMKHODV = (new DmkhodvManager()).SelectByMadonviRDT(TBNET.ERP.DATA.DMDONVI._Current.Madonvi); }
                    return _DMKHODV;
                }
                else
                {
                    return _DMKHODV;
                }
            }
            set
            {
                _DMKHODV = value;
            }
        }
        #endregion

        #region DMPHONGBAN
        private static DataTable _DMPHONGBAN = null;
        public static DataTable DMPHONGBAN
        {
            get
            {
                if (_DMPHONGBAN == null || _DMPHONGBAN.Rows.Count == 0)
                {
                    if (TBNET.ERP.DATA.DMDONVI.DV_TH)
                    { _DMPHONGBAN = (new DmphongbanManager()).SelectAllRDT(); }
                    else
                    { _DMPHONGBAN = (new DmphongbanManager()).SelectByMadonviRDT(TBNET.ERP.DATA.DMDONVI._Current.Madonvi); }
                    return _DMPHONGBAN;
                }
                else
                {
                    return _DMPHONGBAN;
                }
            }
            set
            {
                _DMPHONGBAN = value;
            }
        }
        #endregion

        #region DMNHOMVTUDV
        private static DataTable _DMNHOMVTUDV = null;
        public static DataTable DMNHOMVTUDV
        {
            get 
            {
                if (_DMNHOMVTUDV == null || _DMNHOMVTUDV.Rows.Count <=0)
                {
                    if (TBNET.ERP.DATA.DMDONVI.DV_TH)
                    { _DMNHOMVTUDV = new DmnhomvtudvManager().SelectAllRDT(); }
                    else
                    { _DMNHOMVTUDV = new DmnhomvtudvManager().SelectByMadonviRDT(TBNET.ERP.DATA.DMDONVI._Current.Madonvi); }
                }
                return _DMNHOMVTUDV;
            }
            set 
            {
                _DMNHOMVTUDV = value;
            }
        }
        #endregion       

        #region USERS
        private static DataTable _USERS = null;
        public static DataTable USERS
        {
            get
            {
                if (_USERS == null || _USERS.Rows.Count <= 0)
                {
                    if (TBNET.ERP.DATA.DMDONVI.DV_TH)
                    { _USERS = new UsersManager().SelectAllRDT(); }
                    else
                    { _USERS = new UsersManager().SelectByMadonviRDT(TBNET.ERP.DATA.DMDONVI._Current.Madonvi); }
                }
                return _USERS;
            }
            set 
            {
                _USERS = value;
            }
        }
        #endregion

        #region TABLECONFIG
        private static DataTable _TABLECONFIG = null;
        public static DataTable TABLECONFIG
        {
            get
            {
                if (_TABLECONFIG == null || _TABLECONFIG.Rows.Count <= 0)
                {
                    if (TBNET.ERP.DATA.DMDONVI.DV_TH)
                    { _TABLECONFIG = (new TableconfigManager()).SelectAllRDT(); }
                    else
                    { _TABLECONFIG = (new TableconfigManager()).SelectByMadonviRDT(TBNET.ERP.DATA.DMDONVI._Current.Madonvi); }
                }
                return _TABLECONFIG;
            }
            set
            {
                _TABLECONFIG = value;
            }
        }
        #endregion

        #region ROLES
        private static DataTable _ROLES = null;
        public static DataTable ROLES
        {
            get
            {
                if (_ROLES == null || _ROLES.Rows.Count <= 0)
                {
                    if (TBNET.ERP.DATA.DMDONVI.DV_TH)
                    { _ROLES = (new RolesManager()).SelectAllRDT(); }
                    else
                    { _ROLES = (new RolesManager()).SelectByMadonviRDT(TBNET.ERP.DATA.DMDONVI._Current.Madonvi); }
                }
                return _ROLES;
            }
            set 
            {
                _ROLES = value;
            }
        }
        #endregion

        #region DMDONVI
        private static DataTable _DMDONVI = null;
        public static DataTable DMDONVI
        {
            get
            {
                if (_DMDONVI == null || _DMDONVI.Rows.Count <= 0)
                {
                    _DMDONVI = new DmdonviManager().SelectAllRDT();
                }
                return _DMDONVI;
            }
            set
            {
                _DMDONVI = value;
            }
        }
        #endregion
        
        #region DMLOAITKNGANHANG
        private static DataTable _DMLOAITKNGANHANG = null;
        public static DataTable DMLOAITKNGANHANG
        {
            get
            {
                if (_DMLOAITKNGANHANG == null || _DMLOAITKNGANHANG.Rows.Count == 0)
                {
                    if (TBNET.ERP.DATA.DMDONVI.DV_TH)
                    { _DMLOAITKNGANHANG = (new DmloaitknganhangManager()).SelectAllRDT(); }
                    else
                    { _DMLOAITKNGANHANG = (new DmloaitknganhangManager()).SelectByMadonviRDT(TBNET.ERP.DATA.DMDONVI._Current.Madonvi); }
                    return _DMLOAITKNGANHANG;
                }
                else
                {
                    return _DMLOAITKNGANHANG;
                }
            }
            set
            {
                _DMLOAITKNGANHANG = value;
            }
        }
        #endregion
        
        #region LOAIPHANBO
        private static DataTable _DT_LOAIPHANBO = null;
        public static DataTable DT_LOAIPHANBO
        {                        
            get
            {
                _DT_LOAIPHANBO = new DataTable();
                if (_DT_LOAIPHANBO.Columns.Contains("MALOAIPHANBO") == false) _DT_LOAIPHANBO.Columns.Add("MALOAIPHANBO",typeof(string));
                if (_DT_LOAIPHANBO.Columns.Contains("TENLOAIPHANBO") == false) _DT_LOAIPHANBO.Columns.Add("TENLOAIPHANBO", typeof(string));
                DataRow rowChiphi = _DT_LOAIPHANBO.NewRow();
                rowChiphi["MALOAIPHANBO"] = MALOAIPHANBO_CHIPHI;
                rowChiphi["TENLOAIPHANBO"] = TENLOAIPHANBO_CHIPHI;
                _DT_LOAIPHANBO.Rows.Add(rowChiphi);

                DataRow rowChiphikhac = _DT_LOAIPHANBO.NewRow();
                rowChiphikhac["MALOAIPHANBO"] = MALOAIPHANBO_CHIPHIKHAC;
                rowChiphikhac["TENLOAIPHANBO"] = TENLOAIPHANBO_CHIPHIKHAC;
                _DT_LOAIPHANBO.Rows.Add(rowChiphikhac);

                DataRow rowLephi = _DT_LOAIPHANBO.NewRow();
                rowLephi["MALOAIPHANBO"] = MALOAIPHANBO_LEPHI;
                rowLephi["TENLOAIPHANBO"] = TENLOAIPHANBO_LEPHI;
                _DT_LOAIPHANBO.Rows.Add(rowLephi);

                return _DT_LOAIPHANBO;
            }
            set 
            {
                _DT_LOAIPHANBO = value;
            }

        }
        #endregion

        #region DM_CHITIET_FRM
        private static DataTable _DT_FRMCHITIET = null;
        public static DataTable DT_FRMCHITIET
        {
            get 
            {
                if (_DT_FRMCHITIET == null)
                    _DT_FRMCHITIET = TBNET.ERP.LIB.PROCESS_DATA.ReadXMLtoDataTable(TBNET.ERP.LIB.PATH.ERP_PATH + "\\XMLCONFIG\\HIENTHI.xml");
                    //_DT_FRMCHITIET = TBNET.ERP.LIB.PROCESS_DATA.ReadXMLtoDataTable(TBNET.ERP.LIB.PATH.ERP_PATH + "\\XMLCONFIG\\HIENTHI.xml");
                    return _DT_FRMCHITIET;
                
            }
            set { _DT_FRMCHITIET = value; }
        }

        #endregion

        #region CTRINHKHUYENMAI
        private static DataTable _CTRINHKHUYENMAI = null;
        public static DataTable CTRINHKHUYENMAI
        {
            get
            {
                if (_CTRINHKHUYENMAI == null || _CTRINHKHUYENMAI.Rows.Count == 0)
                {
                    if (TBNET.ERP.DATA.DMDONVI.DV_TH)
                    { _CTRINHKHUYENMAI = (new CtrinhkmaictManager()).SelectAllRDT(); }
                    else
                    { _CTRINHKHUYENMAI = (new CtrinhkmaictManager()).SelectByMadonviRDT(TBNET.ERP.DATA.DMDONVI._Current.Madonvi); }
                    return _CTRINHKHUYENMAI;
                }
                else
                {
                    return _CTRINHKHUYENMAI;
                }
            }
            set
            {
                _CTRINHKHUYENMAI = value;
            }
        }
        #endregion
        public static DataTable SELECT_TABLENAME(string TABLENAME)
        {
            DataTable DT_RETURN = null;
            if (TABLENAME.ToUpper() == "DMTKDV") DT_RETURN = DT_DMTKDV;
            else if (TABLENAME.ToUpper() == "DMKHACHHANG") DT_RETURN = DMKHACHHANG;
            else if (TABLENAME.ToUpper() == "DMNHACUNGCAP") DT_RETURN = DMNHACUNGCAP;
            else if (TABLENAME.ToUpper() == "DMNHANVIEN") DT_RETURN = DMNHANVIEN;
            else if (TABLENAME.ToUpper() == "DMDTPN") DT_RETURN = DMDTPN;
            else if (TABLENAME.ToUpper() == "DMKMCPDV") DT_RETURN = DMKMCPDV;
            else if (TABLENAME.ToUpper() == "DMTYGIA") DT_RETURN = DMTYGIA;
            else if (TABLENAME.ToUpper() == "DMVAT") DT_RETURN = DMVAT;
            else if (TABLENAME.ToUpper() == "DMHOPDONGMUADV") DT_RETURN = DMHOPDONGMUADV;
            else if (TABLENAME.ToUpper() == "DMHOPDONGBANDV") DT_RETURN = DMHOPDONGBANDV;
            else if (TABLENAME.ToUpper() == "DMKHODV") DT_RETURN = DMKHODV;
            else if (TABLENAME.ToUpper() == "DMVTHHDV") DT_RETURN = DT_DMVTHHDV;
            else if (TABLENAME.ToUpper() == "DMPHONGBAN") DT_RETURN = DMPHONGBAN;
            else if (TABLENAME.ToUpper() == "DMLOAITKNGANHANG") DT_RETURN = DMLOAITKNGANHANG;
            else if (TABLENAME.ToUpper() == "DMNHOMVTUDV") DT_RETURN = DMNHOMVTUDV;
            else if (TABLENAME.ToUpper() == "USERS") DT_RETURN = USERS;
            else if (TABLENAME.ToUpper() == "DMDONVI") DT_RETURN = DMDONVI;
            else if (TABLENAME.ToUpper() == "DMLOAIVTUDV") DT_RETURN = DT_LOAIVTU;
            else if (TABLENAME.ToUpper() == "DMNGANHANG") DT_RETURN = DM_NGANHANG;
            else if (TABLENAME.ToUpper() == "HRNHANVIEN") DT_RETURN = HR_NHANVIEN;
            else if (TABLENAME.ToUpper() == "DMNHOMPTNX") DT_RETURN = DMNHOMPTNX;
            else if (TABLENAME.ToUpper() == "DMVUVIECDV") DT_RETURN = DMVUVIEC;
            else if (TABLENAME.ToUpper() == "DMNHOMKHACHHANG") DT_RETURN = DMNHOMKHACHHANG;
            else if (TABLENAME.ToUpper() == "CTRINHKHUYENMAI") DT_RETURN = CTRINHKHUYENMAI;
            return DT_RETURN;
        }

        public static DataTable GET_CONTRACT_TABLENAME(string TABLENAME)
        {
            DataTable dt_contract_table = new DataTable();
            try
            {
                dt_contract_table = CTDOITUONG.Select("KEY = '" + TABLENAME + "'").CopyToDataTable();
            }
            catch { }
            return dt_contract_table;
        }                
    }
}
