using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
namespace GD.FM.LIB
{
    public class STATIC_PARAM
    {
        public static string MART_SYNC_ERP = "0";
        public static int Maxgiaban = 150;
        public static decimal Trangthai_Sudung = 1;
        public static decimal Trangthai_KoSudung = 0;
        public static string TK_DU_NO = "1";
        public static string TK_DU_CO = "2";
        public static string TK_LUONG_TINH = "3";
        public static string TK_KO_DU = "4";
        //public static string TK_CHI_TIET = "1";
        public static string PP_KO_TINH_CHENH_LECH = "0";
        public static string PP_TRUNG_BINH_THANG = "1";
        public static string PP_TRUNG_BINH_DD = "2";
        public static string PP_TRUNG_BINH_NHAP_TRUOC_XUAT_TRUOC = "3";
        public static string PP_DICH_DANH = "4";
        public static string PP_TY_GIA_GD = "5";        

        public static string TK_SO_CAI = "0";
        public static string TK_CHI_TIET = "1";
        public static string TK_CHI_TIET_SO_CAI = "2";

        public static string THUQUYTHU_TEN = "THUQUYTHU";
        public static string THUQUYTHU_Diengiai = "Thủ quỹ thu";
        public static string THUQUYTHU_VALUE = "";

        public static string THUQUYCHI_TEN = "THUQUYCHI";
        public static string THUQUYCHI_Diengiai = "Thủ quỹ chi";
        public static string THUQUYCHI_VALUE = "";

        public static string THAMSO_KY_HACH_TOAN_Tenma = "THANGHACHTOAN";
        public static string THAMSO_KY_HACH_TOAN_Diengiai = "Tháng hạch toán";


        public static string THAMSO_KY_TU_THAPPHAN_Tenma = "KYTUTHAPPHAN";
        public static string THAMSO_KY_TU_THAPPHAN_Diengiai = "Ký tự thập phân (,||.)";
        public static string THAMSO_KY_TU_THAPPHAN_VALUE = ",";

        public static string THAMSO_KY_TU_PHANCACH_Tenma = "KYTUPHANCACH";
        public static string THAMSO_KY_TU_PHANCACH_Diengiai = "Ký tự phân cách (,||( ))";
        public static string THAMSO_KY_TU_PHANCACH_VALUE = ".";

        public static string THAMSO_SO_AM_TREN_BAO_CAO_Tenma = "SOAMTRENBAOCAO";
        public static string THAMSO_SO_AM_TREN_BAO_CAO_Diengiai = "Số âm trên báo cáo (-,(),(-))";
        public static string THAMSO_SO_AM_TREN_BAO_CAO_VALUE = "-";

        public static string THAMSO_SO_GIA_TRI_THAP_PHAN_Tenma = "GIATRITHAPPHAN";
        public static string THAMSO_SO_GIA_TRI_THAP_PHAN_Diengiai = "số sau ký thự thập phân";
        public static int THAMSO_GIA_TRI_THAP_PHAN_VALUE = 0;
        public static string MANGOAITEDEFAULT = "VND";
        public static string MANHOMKHACHANG = "";
        public static string MANHOMPHANXUONG = "";
        public static string PHANHE_KTTMNH = "KTTMNH";
        public static string PHANHE_KTVTHH = "KTVTHH";
        public static string PHANHE_KTSX = "KTSX";
        public static string PHANHE_KTTSAN = "KTTSAN";
        public static string PHANHE_KTNSU = "KTNSU";
        public static string PHANHE_CHUNGTUINKT = "CHUNGTUINKT";
        public static string FormatNumber_Grid //= "#,##0.00";
        {
            get
            {
                string value = "";
                if (GD.FM.LIB.STATIC_PARAM.THAMSO_KY_TU_PHANCACH_VALUE.Equals(".")) { value = "#,###,###,###"; }
                else
                {
                    value = "#" + GD.FM.LIB.STATIC_PARAM.THAMSO_KY_TU_PHANCACH_VALUE + "###" + GD.FM.LIB.STATIC_PARAM.THAMSO_KY_TU_PHANCACH_VALUE;
                    value = value + "###" + GD.FM.LIB.STATIC_PARAM.THAMSO_KY_TU_PHANCACH_VALUE + "###";// +GD.FM.LIB.STATIC_PARAM.THAMSO_KY_TU_PHANCACH_VALUE;
                    //value = value + "###" + GD.FM.LIB.STATIC_PARAM.THAMSO_KY_TU_PHANCACH_VALUE + "###";
                }
                string str_THAP_PHAN_VALUE = "";
                for (int i = 0; i < GD.FM.LIB.STATIC_PARAM.THAMSO_GIA_TRI_THAP_PHAN_VALUE; i++)
                {
                    str_THAP_PHAN_VALUE = str_THAP_PHAN_VALUE + "0";
                }
                value = value + "." + str_THAP_PHAN_VALUE; //GD.FM.LIB.STATIC_PARAM.THAMSO_KY_TU_THAPPHAN_VALUE
                return value;
            }
            set
            {
                FormatNumber_Report = value;
            }
        }
        public static string FormatNumber_Report // = "### ### ### ### ###.00";
        {
            get
            {
                string value = "";
                //if (GD.FM.LIB.STATIC_PARAM.THAMSO_KY_TU_PHANCACH_VALUE.Equals(".")) { value = "#,###,###,###"; }
                //else
                //{
                //    value = "#" + GD.FM.LIB.STATIC_PARAM.THAMSO_KY_TU_PHANCACH_VALUE + "###" + GD.FM.LIB.STATIC_PARAM.THAMSO_KY_TU_PHANCACH_VALUE;
                //    value = value + "###" + GD.FM.LIB.STATIC_PARAM.THAMSO_KY_TU_PHANCACH_VALUE + "###";// +GD.FM.LIB.STATIC_PARAM.THAMSO_KY_TU_PHANCACH_VALUE;
                //    //value = value + "###" + GD.FM.LIB.STATIC_PARAM.THAMSO_KY_TU_PHANCACH_VALUE + "###";
                //}
                //string str_THAP_PHAN_VALUE = "";
                //for (int i = 0; i < GD.FM.LIB.STATIC_PARAM.THAMSO_GIA_TRI_THAP_PHAN_VALUE; i++)
                //{
                //    str_THAP_PHAN_VALUE = str_THAP_PHAN_VALUE + "0";
                //}
                //value = value + "." + str_THAP_PHAN_VALUE; //GD.FM.LIB.STATIC_PARAM.THAMSO_KY_TU_THAPPHAN_VALUE

                //HIEPMT SUA NGAY 14/03/2011
                value = "#,###,###,###";
                //string str_THAP_PHAN_VALUE = "";
                //for (int i = 0; i < GD.FM.LIB.STATIC_PARAM.THAMSO_GIA_TRI_THAP_PHAN_VALUE; i++)
                //{
                //    str_THAP_PHAN_VALUE = str_THAP_PHAN_VALUE + "0";
                //}
                //if (!string.IsNullOrEmpty(str_THAP_PHAN_VALUE))
                //{
                //    value = value + "." + str_THAP_PHAN_VALUE;
                //}
                return value;
            }
            set
            {
                FormatNumber_Report = value;
            }
        }
        //public static string CHEDOKETOAN_TEN = "CHEDOKETOAN";
        //public static string CHEDOKETOAN_Diengiai = "Các mẫu biểu báo cáo dựa trên các Quyết Định";
        //public static string CHEDOKETOAN_VALUE = "15";

        public static string THANGBATDAUTAICHINH_TEN = "THANGBATDAUTAICHINH";
        public static string THANGBATDAUTAICHINH_Diengiai = "Tháng bắt đầu tài chính";
        public static string THANGBATDAUTAICHINH_VALUE = "1";

        public static string THEODOIKHACHHANG_TEN = "THEODOICONGNO";
        public static string THEODOIKHACHHANG_Diengiai = "Theo dõi công nợ theo chi tiết hóa đơn";
        public static int THEODOIKHACHHANG_VALUE = 0;

        public static string NGAYBATDAUHACHTOAN_TEN = "NGAYBATDAUHACHTOAN";
        public static string NGAYBATDAUHACHTOAN_Diengiai = "Ngày bắt đầu hạch toán";
        public static string NGAYBATDAUHACHTOAN_VALUE = "01/01/2010";

        public static string DONGTIENHACHTOAN_TEN = "DONGTIENHACHTOAN";
        public static string DONGTIENHACHTOAN_Diengiai = "Đồng tiền hạch toán";
        public static string DONGTIENHACHTOAN_VALUE = "VND";

        public static string LINHVUCHOATDONG_TEN = "LINHVUCHOATDONG";
        public static string LINHVUCHOATDONG_Diengiai = "Lĩnh vực hoạt động";
        public static string LINHVUCHOATDONG_VALUE = "";

        public static string LAPHOADON_TEN = "LAPHOADON";
        public static string LAPHOADON_Diengiai = "Hóa đơn gồm phiếu xuất";
        public static string LAPHOADON_VALUE = "HD_KIEM_PHIEUXUAT";

        //public static string GIAVON_TEN = "GIAVON";
        //public static string GIAVON_Diengiai = "Tính giá vốn tất cả các kho";
        //public static string GIAVON_VALUE = "0";

        public static string PPTINHGIAXUAT_TEN = "PPTINHGIAXUAT";
        public static string PPTINHGIAXUAT_Diengiai = "Phương pháp tính giá xuất";
        public static string PPTINHGIAXUAT_VALUE = "BQCUOIKY";

        public static string DUYETCHUNGTU_TEN = "DUYETCHUNGTU";
        public static string DUYETCHUNGTU_Diengiai = "0 - Không sử dụng chức năng duyệt chứng từ, 1- Sử dụng chức năng duyệt chứng từ";
        public static int DUYETCHUNGTU_VALUE = 0;

        public static string XUATHANGAM_TEN = "XUATAM";
        public static string XUATHANGAM_Diengiai = "0 - Không cho phép xuất hàng âm, 1- Cho phép xuất hàng âm";
        public static int XUATHANGAM_VALUE = 1;

        public static string GIOIHAN_CONGNO_TEN = "GH_CONGNO";
        public static string GIOIHAN_CONGNO_Diengiai = "0 - Không cho phép khách hàng vuợt quá hạn mức nợ, 1- Cho phép khách hàng vuợt quá hạn mức nợ";
        public static int GIOIHAN_CONGNO_VALUE = 1;

        public static string GIOIHAN_CONGNONV_TEN = "GH_CONGNO_NV";
        public static string GIOIHAN_CONGNONV_Diengiai = "0 - Không cho phép Nhân viên vuợt quá hạn mức nợ, 1- Cho phép Nhân viên vuợt quá hạn mức nợ";
        public static int GIOIHAN_CONGNONV_VALUE = 1;

        public static string THEODOI_CONGNO_NV_TEN = "THEODOI_CONGNO_NV";
        public static string THEODOI_CONGNO_NV_Diengiai = "0 - Không theo dõi công nợ Nhân viên, 1- Theo dõi công nợ Nhân viên";
        public static int THEODOI_CONGNO_NV_VALUE = 0;

        public static string GIATHANH_TEN = "TINHGIATHANH";
        public static string GIATHANH_Diengiai = "0 - Tính giá thành trên tất cả các đơn vị, 1- Tính giá thành trên từng đơn vị";
        public static string GIATHANH_VALUE = "1";

        public static string FTP_URL_HOMEMART_TEN = "FTP_URL_HOMEMART";
        public static string FTP_URL_HOMEMART_Diengiai = "Thông tin kế nối máy chủ FTP";
        public static string FTP_URL_HOMEMART_VALUE = "homemart24h.com";

        public static string FTP_SERVER_TEN = "FTP_SERVER";
        public static string FTP_SERVER_Diengiai = "Thông tin kế nối máy chủ FTP";
        public static string FTP_SERVER_VALUE = "homemart24h.com";

        public static string FTP_USER_TEN = "FTP_USER";
        public static string FTP_USER_Diengiai = "Tên đăng nhập FTP";
        public static string FTP_USER_VALUE = "tendangnhap";

        public static string FTP_PASS_TEN = "FTP_PASS";
        public static string FTP_PASS_Diengiai = "Mật khẩu kết nối FTP";
        public static string FTP_PASS_VALUE = "matkhau";

        public static string SERVICE_URL = "SERVICE_URL";
        public static string SERVICE_URL_Diengiai = "Địa chỉ webservice";
        public static string SERVICE_URL_VALUE = "http://serp.homemart24h.com/Service1.asmx";

        public static string XUATKHO_KM = "XUATKHO_KM";
        public static string XUATKHO_KM_Diengiai = "Cho phép xuất hàng kho khuyến mại. (1)-Có ;(0)-Không";
        public static int XUATKHO_KM_VALUE = 1;

        public static string TIEN_GIAM_GIA = "TIENGGIA";
        public static string TIEN_CK = "TIENCK";
        public static string TIEN_VAT_NK = "TIENVATNK";
        public static string TIEN_VAT_DB = "TIENVATDB";
        public static string TIEN_HANG = "TIENHANG";
        public static string TIEN_DKY = "TIENDAUKY";
        public static string TIEN_CHIPHI = "TIENCHIPHI";
        public static string TIEN_CHIPHIKHAC = "TIENCHIPHIKHAC";
        public static string TIEN_LEPHI = "TIENLEPHI";
        public static string TIEN_VAT = "TIENVAT";
        public static string TIEN_KM = "TIENKM";
        public static string TIEN_VATG_TRU = "TIENVATGT";

        #region TEN CAC FORM BAO CAO
        public static string FNAME_BC_VT = "FRM_MAINREPORT_VATTU";
        public static string FNAME_BC_NH = "FRM_MAINREPORT_NH";
        public static string FNAME_BC_QUY = "FRM_MAINREPORT_QUY";
        public static string FNAME_BC_MAIN = "FRM_MAINREPORT";        
        #endregion
    }
}
