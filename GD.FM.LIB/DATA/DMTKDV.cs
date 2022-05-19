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
using System.Data.OracleClient;
using System.IO;
using System.Windows.Forms;
namespace TBNET.ERP.DATA
{
    public class DMTKDV
    {
        public static string ConnectionString = System.Configuration.ConfigurationSettings.AppSettings.Get(
                                  DAL.DatabaseSpecific.DataAccessAdapter.ConnectionStringKeyName);
        public static DataTable DT_TINHCHATTK(string ID, string Name)
        {
            DataTable dt =new DataTable();
            dt.Columns.Add(ID, typeof(string));
            dt.Columns.Add(Name, typeof(string));
            DataRow R_NO = dt.NewRow(); R_NO[ID] = "1"; R_NO[Name] = "Dư Nợ"; dt.Rows.Add(R_NO);
            DataRow R_CO = dt.NewRow(); R_CO[ID] = "2"; R_CO[Name] = "Dư Có"; dt.Rows.Add(R_CO);
            DataRow R_LUONGTINH = dt.NewRow(); R_LUONGTINH[ID] = "3"; R_LUONGTINH[Name] = "Lưỡng tính"; dt.Rows.Add(R_LUONGTINH);
            DataRow R_KO_SODU = dt.NewRow(); R_KO_SODU[ID] = "4"; R_KO_SODU[Name] = "Không có số dư"; dt.Rows.Add(R_KO_SODU);
            return dt;
        }
        public static DataTable DT_DMTK_CTSC_BY_STRTK(string str_tk)
        {
            DataTable dt = new DataTable(); dt = TBNET.ERP.DATA.SESSION_START.DT_DMTKDV_CT.Clone();
            if (string.IsNullOrEmpty(str_tk)) return dt;
            if (str_tk.EndsWith(";")) str_tk = str_tk.Remove(str_tk.Length - 1, 1); 
            string[] matk = str_tk.Split(';');
            string str_where = "";
            foreach (string str_ in matk)
            {
                if (!string.IsNullOrEmpty(str_.Trim()) && str_.Trim().Length>0)
                {
                    str_where += DmtkdvFields.Matk.Name + " LIKE '" + str_ + "%' OR ";
                }
            }
            if (!string.IsNullOrEmpty(str_where))
            {
                str_where = str_where.Remove(str_where.Length - 3, 3);
            }
            try { dt = TBNET.ERP.DATA.SESSION_START.DT_DMTKDV_CT.Select(str_where).CopyToDataTable(); }
            catch { dt.Clear(); }
            return dt;
        }
        public static string[] Name_Table_DMVUVIEC = {"DMVUVIECDV","Vụ việc"};
        public static string[] Name_Table_SOCTKT = { "SOCTKT", "Số CTừ" };
        public static string[] Name_Table_DMKHACHHANG = {"DMKHACHHANG","Khách hàng"};
        public static string[] Name_Table_DMNHACUNGCAP = { "DMNHACUNGCAP", "Nhà CC" };
        public static string[] Name_Table_DMNHANVIEN = { "DMNHANVIEN", "Nhân viên" };
        public static string[] Name_Table_DMDTPN = { "DMDTPN", "Đối tượng PN" };
        public static string[] Name_Table_DMKMCPDV = {"DMKMCPDV","Chi phí"};
        public static string[] Name_Table_DMTYGIA = {"DMTYGIA","Tỷ giá"};
        public static string[] Name_Table_DMVAT = {"DMVAT","Vat"};
        public static string[] Name_Table_DMPHANXUONG = {"DMPHANXUONG","Phân xưởng"};
        public static string[] Name_Table_CTRINHKHUYENMAI = { "CTRINHKHUYENMAI", "C.trình K.mại" };
        
        public static string[] Name_Table_DMHOPDONGBANDV = { "DMHOPDONGBANDV", "HĐ bán" };
        public static string[] Name_Table_DMHOPDONGMUADV = { "DMHOPDONGMUADV", "HĐ mua" };
        public static string[] Name_Table_DMKHODV = { "DMKHODV", "DM kho" };
        public static string[] Name_Table_DMVTHHDV = { "DMVTHHDV", "Vật tư" };
        public static string[] Name_Table_DMPHONGBAN = { "DMPHONGBAN", "Phòng ban" };
        public static string[] Name_Table_DMDONVI = { "DMDONVI", "DANH MỤC ĐƠN VỊ" };
        public static string[] Name_Table_DMLOAITKNGANHANG = { "DMLOAITKNGANHANG", "DM TK Ngân Hàng" };
        public static string[] Name_Table_DMNGANHANG = { "DMNGANHANG", "Ngân hàng" };

        public static void IMPORT_DMLOAITK(string EXCEL_SHEET_DMTK)
        {
            #region Insert DMLOAITK
                DmloaitkManager _DmloaitkManager = new DmloaitkManager();
                DataTable DT_DMLOAITK = _DmloaitkManager.SelectAllRDT();
                EntityCollection _EntityCollection = new EntityCollection();
                if (DT_DMLOAITK == null || DT_DMLOAITK.Rows.Count == 0)
                {
                    DT_DMLOAITK.Clear(); DT_DMLOAITK = TBNet.Project.IO.ReadExcelToDataTable(TBNET.ERP.LIB.PATH.ERP_PATH + @"\XMLCONFIG\TONGHOPDULIEU.xls", EXCEL_SHEET_DMTK);
                    foreach (DataRow r_tk in DT_DMLOAITK.Rows)
                    {
                        DmloaitkEntity _DmloaitkEntity = new DmloaitkEntity();
                        _DmloaitkEntity.Maloaitk = r_tk[DmloaitkFields.Maloaitk.Name].ToString().Trim();
                        _DmloaitkEntity.Tenloaitk = r_tk[DmloaitkFields.Tenloaitk.Name].ToString().Trim();
                        _DmloaitkEntity.Trangthai = 10;
                        if (string.IsNullOrEmpty(_DmloaitkEntity.Tenloaitk) == false && string.IsNullOrEmpty(_DmloaitkEntity.Maloaitk) == false)
                        { _DmloaitkManager.Insert(_DmloaitkEntity); }//_DmloaitkManager.Insert(_DmloaitkEntity); }
                    }
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Không cập nhật được DMLOAITK\nĐã có dữ liệu trong bảng DMLOAITK");
                    //TBNET.ERP.LIB.TrayPopup.PoupStringMessage("Không cập nhật được DMLOAITK", "Đã có dữ liệu trong bảng DMLOAITK");
                }
            #endregion
        }
        public static void IMPORT_DMTK(string CURRENT_DV, string EXCEL_SHEET_DMTK,string TEN_GHEP_TENTK)
        {
            #region Insert DMTK
            DmtkdvManager _DmtkManager = new DmtkdvManager();
            EntityCollection _EntityCollection = new EntityCollection();
            _DmtkManager.DeleteByMadonvi(CURRENT_DV);
            DataTable DT_TAIKHOAN = new DataTable();
            DT_TAIKHOAN = TBNet.Project.IO.ReadExcelToDataTable(TBNET.ERP.LIB.PATH.ERP_PATH + @"\XMLCONFIG\TONGHOPDULIEU.xls", EXCEL_SHEET_DMTK);
            foreach (DataRow r_tk in DT_TAIKHOAN.Rows)
            {
                try
                {
                    DmtkdvEntity _DmtkEntity = new DmtkdvEntity();
                    if (string.IsNullOrEmpty(r_tk[DmtkdvFields.Matk.Name].ToString().Trim())) { continue; }
                    _DmtkEntity.Matk = r_tk[DmtkdvFields.Matk.Name].ToString().Trim();
                    if (string.IsNullOrEmpty(r_tk[DmtkdvFields.Tinhchat.Name].ToString().Trim())) { _DmtkEntity.Tinhchat = 0; }
                    else
                    {
                        try
                        {
                            _DmtkEntity.Tinhchat = decimal.Parse(r_tk[DmtkdvFields.Tinhchat.Name].ToString());
                        }
                        catch { }
                    }

                    if (string.IsNullOrEmpty(r_tk[DmtkdvFields.Tkcongno.Name].ToString().Trim())) { _DmtkEntity.Tkcongno = 0; }
                    else
                    {
                        try
                        {
                            _DmtkEntity.Tkcongno = decimal.Parse(r_tk[DmtkdvFields.Tkcongno.Name].ToString());
                        }
                        catch { }
                    }

                    if (string.IsNullOrEmpty(r_tk[DmtkdvFields.Tkchitiet.Name].ToString().Trim())) { _DmtkEntity.Tkchitiet = 0; }
                    else
                    {
                        try { _DmtkEntity.Tkchitiet = decimal.Parse(r_tk[DmtkdvFields.Tkchitiet.Name].ToString()); }
                        catch { }
                    }

                    if (string.IsNullOrEmpty(r_tk[DmtkdvFields.Matkcha.Name].ToString().Trim())) { _DmtkEntity.Matkcha = "0000"; }
                    else { _DmtkEntity.Matkcha = r_tk[DmtkdvFields.Matkcha.Name].ToString(); }

                    if (string.IsNullOrEmpty(r_tk[DmtkdvFields.Bactk.Name].ToString().Trim())) { _DmtkEntity.Bactk = "0"; }
                    else { _DmtkEntity.Bactk = r_tk[DmtkdvFields.Bactk.Name].ToString().Trim(); }

                    if (r_tk[DmtkdvFields.Maloaitk.Name].ToString().Trim().Length < 0) { _DmtkEntity.Maloaitk = "0000"; }
                    else { _DmtkEntity.Maloaitk = r_tk[DmtkdvFields.Maloaitk.Name].ToString().Trim(); }                        
                    _DmtkEntity.Tentk = r_tk[DmtkdvFields.Tentk.Name].ToString().Trim();
                    if (!string.IsNullOrEmpty(TEN_GHEP_TENTK))
                    {
                        _DmtkEntity.Tentk = r_tk[DmtkdvFields.Tentk.Name].ToString().Trim() + "-" + TEN_GHEP_TENTK;
                    }

                    _DmtkEntity.Ghichu = r_tk[DmtkdvFields.Ghichu.Name].ToString().Trim();

                    _DmtkEntity.Mangoaite = r_tk[DmtkdvFields.Mangoaite.Name].ToString().Trim();

                    _DmtkEntity.Trangthai = 1;
                    _DmtkEntity.Trangthaisd = 1;
                    _DmtkEntity.Ppttygiagsco = _DmtkEntity.Ppttygiagsno = 0;
                    DmtkdvEntity _DmtkEntity_CHA = _DmtkManager.SelectOne(CURRENT_DV, _DmtkEntity.Matkcha);
                    if (_DmtkEntity_CHA == null) _DmtkEntity.Step = _DmtkEntity.Matkcha + ";";
                    if (_DmtkEntity_CHA != null) _DmtkEntity.Step = _DmtkEntity_CHA.Step + ";" + _DmtkEntity.Matkcha;
                    _DmtkEntity.Madonvi = CURRENT_DV;
                    _DmtkEntity.Ctdoituong = r_tk[DmtkdvFields.Ctdoituong.Name].ToString().Trim();
                    _DmtkEntity.Rolesid = r_tk[DmtkdvFields.Rolesid.Name].ToString().Trim();
                    try
                    {
                        { _EntityCollection.Add(_DmtkEntity); }// _DmtkManager.Insert(_DmtkEntity); }
                    }
                    catch { }
                }
                catch { }
            }
            _DmtkManager.InsertCollection(_EntityCollection);
            //else
            //{
            //    System.Windows.Forms.MessageBox.Show("Không cập nhật được DMTK\nĐã có dữ liệu trong bảng DMTK");
            //    //TBNET.ERP.LIB.TrayPopup.PoupStringMessage("Không cập nhật được DMTK", "Đã có dữ liệu trong bảng DMTK");
            //}
            #endregion
        }
        public static void COPY_DMTK_DMTKDV(string CURRENT_DV,string TEN_TK_UPDATE)
        { 
            #region Sao chep DMTK -> DMTKDV
            DmtkdvManager _DmtkManager = new DmtkdvManager();
            EntityCollection _EntityCollection = new EntityCollection();
            DmtkdvManager _DmtkdvManager = new DmtkdvManager();            
            DataTable dt_tkdv = _DmtkdvManager.SelectByMadonviRDT(CURRENT_DV);
            if (dt_tkdv == null || dt_tkdv.Rows.Count == 0)
            {
                DataTable DT_TAIKHOAN = _DmtkManager.SelectAllRDT();
                foreach (DataRow r_tk in DT_TAIKHOAN.Rows)
                {
                    DmtkdvEntity _DmtkdvEntity = new DmtkdvEntity();
                    _DmtkdvEntity.Matk = r_tk[DmtkFields.Matk.Name].ToString().Trim();
                    _DmtkdvEntity.Maloaitk = r_tk[DmtkFields.Maloaitk.Name].ToString().Trim();
                    if (string.IsNullOrEmpty(r_tk[DmtkFields.Matkcha.Name].ToString().Trim())) { _DmtkdvEntity.Matkcha = "0000"; }
                    else { _DmtkdvEntity.Matkcha = r_tk[DmtkFields.Matkcha.Name].ToString().Trim(); }
                    if (string.IsNullOrEmpty(r_tk[DmtkFields.Tkchitiet.Name].ToString().Trim()) == false) _DmtkdvEntity.Tkchitiet = decimal.Parse(r_tk[DmtkFields.Tkchitiet.Name].ToString());
                    _DmtkdvEntity.Step = r_tk[DmtkFields.Step.Name].ToString().Trim();
                    _DmtkdvEntity.Ghichu = r_tk[DmtkFields.Ghichu.Name].ToString().Trim();
                    if (string.IsNullOrEmpty(r_tk[DmtkFields.Tinhchat.Name].ToString()) == false) _DmtkdvEntity.Tinhchat = decimal.Parse(r_tk[DmtkFields.Tinhchat.Name].ToString());
                    if (string.IsNullOrEmpty(r_tk[DmtkFields.Trangthai.Name].ToString()) == false) _DmtkdvEntity.Trangthai = decimal.Parse(r_tk[DmtkFields.Trangthai.Name].ToString());
                    _DmtkdvEntity.Trangthaisd = 10;
                    _DmtkdvEntity.Tentk = r_tk[DmtkFields.Tentk.Name].ToString().Trim();
                    if (string.IsNullOrEmpty(TEN_TK_UPDATE)==false) _DmtkdvEntity.Tentk = r_tk[DmtkFields.Tentk.Name].ToString().Trim() + " - " + TEN_TK_UPDATE.Trim();
                    _DmtkdvEntity.Bactk = r_tk[DmtkFields.Bactk.Name].ToString().Trim();
                    _DmtkdvEntity.Ctdoituong = "";
                    _DmtkdvEntity.Mangoaite = "";
                    _DmtkdvEntity.Ppttygiagsno = 0;
                    _DmtkdvEntity.Ppttygiagsco = 0;
                    _DmtkdvEntity.Madonvi = CURRENT_DV;
                    _EntityCollection.Add(_DmtkdvEntity);
                    //_DmtkdvManager.Insert(_DmtkdvEntity);
                }
                _DmtkdvManager.InsertCollection(_EntityCollection);
            }
            else
            {
                TBNET.ERP.LIB.TrayPopup.PoupStringMessage("Không sao chép được dữ liệu tài khoản", "DMTKDV đã có dữ liệu của đơn vị");
            }
            #endregion            
        }
        public static void IMPORT_EXEC_DMTKDV_MAU(string CURRENT_DV,string Filename)
        {
            DmtkdvManager _DmtkdvManager = new DmtkdvManager();            
            DataTable dt_tkdv = _DmtkdvManager.SelectByMadonviRDT(CURRENT_DV);
            if (dt_tkdv == null || dt_tkdv.Rows.Count == 0)
            {
                char endquery='/';
                TBNET.ERP.LIB.CONNECTIONCOMMAND.EXEC_QUERY(TBNET.ERP.LIB.PATH.ERP_PATH + @"\SCRIPT\" + Filename,endquery);
            }
        }
       
    }
    
    public class DMTK
    {
        public static DataTable DT_TINHCHATTK(string ID, string Name)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add(ID, typeof(string));
            dt.Columns.Add(Name, typeof(string));
            DataRow R_NO = dt.NewRow(); R_NO[ID] = "1"; R_NO[Name] = "Dư Nợ"; dt.Rows.Add(R_NO);
            DataRow R_CO = dt.NewRow(); R_CO[ID] = "2"; R_CO[Name] = "Dư Có"; dt.Rows.Add(R_CO);
            DataRow R_LUONGTINH = dt.NewRow(); R_LUONGTINH[ID] = "3"; R_LUONGTINH[Name] = "Lưỡng tính"; dt.Rows.Add(R_LUONGTINH);
            DataRow R_KO_SODU = dt.NewRow(); R_KO_SODU[ID] = "4"; R_KO_SODU[Name] = "Không có số dư"; dt.Rows.Add(R_KO_SODU);
            return dt;
        }
        public static string[] Name_Table_DMVUVIEC = { "DMVUVIECDV", "Vụ việc" };
        public static string[] Name_Table_DMKMCPDV = { "DMKMCPDV", "Chi phí" };
        public static string[] Name_Table_DMKHACHHANG = { "DMKHACHHANG", "Khách hàng" };
        public static string[] Name_Table_DMDTPN = { "DMDTPN", "Đối tượng PN" };
        public static string[] Name_Table_DMTYGIA = { "DMTYGIA", "Tỷ giá" };
        public static string[] Name_Table_DMVAT = { "DMVAT", "Vat" };
        public static string[] Name_Table_DMNHACUNGCAP = { "DMNHACUNGCAP", "Nhà CC" };
        public static string[] Name_Table_DMNHANVIEN = { "DMNHANVIEN", "Nhân viên" };
        public static string[] Name_Table_DMHOPDONGBANDV = { "DMHOPDONGBANDV", "HĐ bán" };
        public static string[] Name_Table_DMHOPDONGMUADV = { "DMHOPDONGMUADV", "HĐ mua" };
        public static string[] Name_Table_DMKHODV = { "DMKHODV", "DM kho" };
        public static string[] Name_Table_DMVTHHDV = { "DMVTHHDV", "Vật tư" };
        public static string[] Name_Table_DMPHONGBAN = { "DMPHONGBAN", "Phòng ban" };
        public static string[] Name_Table_DMNGANHANG = { "DMNGANHANG", "Ngân hàng" };
        public static string[] Name_Table_CTRINHKHUYENMAI = { "CTRINHKHUYENMAI", "C.trình K.mại" };
    }
}
