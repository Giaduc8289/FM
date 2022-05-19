using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using EnterpriseDT.Net.Ftp;
using System.IO;
using DotNetRemoting;
using System.Xml;
using TBNET.ERP.DAL.HelperClasses;
using TBNET.ERP.BLL;

namespace TBNET.ERP.DATA
{
    public class ServerExportImportWeb
    {
        private static DataRowCollection _ROWS = null;
        public static void OUTBOX_Message_WEBSITE(string Path,string MAKHO,string KHOKM)
        {
            OUTBOX_Nguoisudung(Path);
            OUTBOX_Dmtuyenduong(Path);
            OUTBOX_Dmkhachhang(Path);
            OUTBOX_Nganhhang(Path);
            OUTBOX_Nhomhang(Path);
            //OUTBOX_Nganhhangnhomhang(Path);
            OUTBOX_Mathangkhohang(Path, MAKHO);
            OUTBOX_Dmkhachhang(Path);
            OUTBOX_Ctrinkmai(Path);
            OUTBOX_Ctrinhkmaichitiet(Path);
            OUTBOX_Mathangbohang(Path);
            OUTBOX_DmNhanvienkhachhang(Path);
            OUTBOX_MATHANGKHO_KM(Path, KHOKM);
        }
        private static void OUTBOX_MATHANGKHO_KM(string Path, string makhokm) 
        {
            DataTable dt = new DmvthhdvManager().SelectByMadonviRDT(TBNET.ERP.DATA.DMDONVI._Current.Madonvi);
            if (dt == null || dt.Rows.Count == 0) return;
            if (!dt.Columns.Contains("SLTON"))
            {
                dt.Columns.Add("SLTON", typeof(int));
            }
            if (!dt.Columns.Contains("QC"))
            {
                dt.Columns.Add("QC", typeof(int));
            }
            DataTable DT2 = dt.Clone();
            foreach (DataRow _r in dt.Rows)
            {
                DataRow ROW_TON = null, ROW_DONVITINH = null;
                int soluong_ton = 0, GIAVONHANGBAN = 0, qc = 0;
                string mavtu = _r[DmvthhdvFields.Mavtu.Name].ToString();
                try
                {
                    ROW_TON = TBNET.ERP.LIB.CONNECTIONCOMMAND.STORE_SLTON(_r[VattugdctFields.Mavtu.Name].ToString(), makhokm, TBNET.ERP.DATA.DATE.NGAYHACHTOAN);
                    if (ROW_TON != null)
                    {
                        int.TryParse(ROW_TON["TONCUOIKYSL"].ToString(), out soluong_ton);
                        int.TryParse(ROW_TON["GIAVONHANGBAN"].ToString(), out GIAVONHANGBAN);
                    }
                }
                catch { }
                if (soluong_ton > 0)
                {
                    try
                    {
                        ROW_DONVITINH = TBNET.ERP.LIB.DATATABLE_STATIC_PARAM.CheckParambyFilename(_r[DmvthhdvFields.Madvtinh.Name].ToString(), DmdonvitinhdvFields.Madvtinh.Name, TBNET.ERP.DATA.SESSION_START.DMDONVITINHDV);
                    }
                    catch { }
                    try
                    {
                        if (ROW_DONVITINH != null)
                        {
                            int.TryParse(ROW_DONVITINH[DmdonvitinhdvFields.Donviquydoi.Name].ToString(), out qc);
                        }
                    }
                    catch { }
                    _r["SLTON"] = soluong_ton;
                    _r["QC"] = qc;
                    DT2.ImportRow(_r);
                }
                //else { dt.Rows.Remove(_r); }
            }
            string path_file = Path + "OUTBOX_Mathangkhohang_KM.xml";
            DT2.TableName = "OUTBOX_Mathangkhohang_KM";
            Gendata(DT2, path_file);
        }

        //public static void OUTBOX_Message_GGBAN_STTHANHVIEN_WEBSITE(string Path, string magiaodich, string makhachang)
        //{
        //    GiaodichbanbuonEntity _GiaodichbanbuonEntity = (new GiaodichbanbuonManager()).SelectOne(magiaodich + "." + TBNet.Mart.SessionConfig.Madonvi);
        //    if (_GiaodichbanbuonEntity.Loaigiaodich == DanhmucchungManager.XB_ST_THANHVIEN_TAM)
        //    {
        //        TBNet.Mart.TrayPopup.PoupStringMessage(TBNet.Mart.Properties.Resources.MessageTitle, "Giao dịch này chưa lưu thực nên không đẩy được nên server.");
        //        return;
        //    }
        //    DataTable dt = (new MathanggiaodichbanbuonManager()).SelectByMagdbanbuonpkRDT(magiaodich + "." + TBNet.Mart.SessionConfig.Madonvi);
        //    string path_file = Path + makhachang + "_" + magiaodich + ".xml";
        //    dt.TableName = "CTMATHANGGIAODICHBANBUONSTTHANHVIEN";
        //    Gendata(dt, path_file);

        //}
        public static DataSet AddTable(DataTable dt)
        {
            DataSet ds = new DataSet();
            ds.Clear();
            if (ds.Tables.Contains(dt.TableName))
            {
                ds.Tables.Remove(dt.TableName);
            }
            ds.Tables.Add(dt.Copy());
            return ds;
        }
        public static void Gendata(DataTable dt, string xmlfile)
        {
            TBNet.Project.IO.GenXML(xmlfile, AddTable(dt));
        }
        private static void OUTBOX_Mathangkhohang(string Path,string makho)
        {
            DataTable dt = new DmvthhdvManager().SelectByMadonviRDT(TBNET.ERP.DATA.DMDONVI._Current.Madonvi);
            if (dt == null || dt.Rows.Count == 0) return;
            if (!dt.Columns.Contains("SLTON")) 
            {
                dt.Columns.Add("SLTON", typeof(int));
            }
            if (!dt.Columns.Contains("QC"))
            {
                dt.Columns.Add("QC", typeof(int));
            }
            foreach (DataRow _r in dt.Rows)
            {
                DataRow ROW_TON = null, ROW_DONVITINH = null;
                int soluong_ton = 0, GIAVONHANGBAN = 0, qc = 0;
                string mavtu = _r[DmvthhdvFields.Mavtu.Name].ToString();
                try
                {
                    ROW_TON = TBNET.ERP.LIB.CONNECTIONCOMMAND.STORE_SLTON(_r[VattugdctFields.Mavtu.Name].ToString(), makho, TBNET.ERP.DATA.DATE.NGAYHACHTOAN);
                }
                catch { }
                try 
                {
                    ROW_DONVITINH = TBNET.ERP.LIB.DATATABLE_STATIC_PARAM.CheckParambyFilename(_r[DmvthhdvFields.Madvtinh.Name].ToString(), DmdonvitinhdvFields.Madvtinh.Name, TBNET.ERP.DATA.SESSION_START.DMDONVITINHDV);
                }
                catch { }
                try
                {
                    if (ROW_TON != null)
                    {
                        int.TryParse(ROW_TON["TONCUOIKYSL"].ToString(), out soluong_ton);
                        int.TryParse(ROW_TON["GIAVONHANGBAN"].ToString(), out GIAVONHANGBAN);
                    }
                    if (ROW_DONVITINH != null)
                    {
                        int.TryParse(ROW_DONVITINH[DmdonvitinhdvFields.Donviquydoi.Name].ToString(), out qc);
                    }
                }
                catch { }
                _r["SLTON"] = soluong_ton;
                _r["QC"] = qc;
            }
            string path_file = Path + "OUTBOX_Mathangkhohang.xml";
            dt.TableName = "OUTBOX_Mathangkhohang";
            Gendata(dt, path_file);            
        }
        private static void OUTBOX_Nganhhang(string Path)
        {
            DataTable dt = new DmloaivtudvManager().SelectByMadonviRDT(TBNET.ERP.DATA.DMDONVI._Current.Madonvi);
            if (dt == null || dt.Rows.Count == 0) return;
            string path_file = Path + "OUTBOX_Nganhhang.xml";
            dt.TableName = "OUTBOX_Nganhhang";
            Gendata(dt, path_file);
        }
        private static void OUTBOX_Nhomhang(string Path)
        {
            DataTable dt = new DmnhomvtudvManager().SelectByMadonviRDT(TBNET.ERP.DATA.DMDONVI._Current.Madonvi);
            if (dt == null || dt.Rows.Count == 0) return;
            string path_file = Path + "OUTBOX_Nhomhang.xml";
            dt.TableName = "OUTBOX_Nhomhang";
            Gendata(dt, path_file);
        }
        //private static void OUTBOX_Nganhhangnhomhang(string Path)
        //{
        //    NganhhangnhomhangManager _NganhhangnhomhangManager = new NganhhangnhomhangManager();
        //    DataTable dt = _NganhhangnhomhangManager.SelectAllRDT();
        //    if (dt == null || dt.Rows.Count == 0) return;
        //    string path_file = Path + "OUTBOX_Nganhhangnhomhang.xml";
        //    dt.TableName = "OUTBOX_Nganhhangnhomhang";
        //    Gendata(dt, path_file);
        //}
        private static void OUTBOX_Dmtuyenduong(string Path)
        {
            DmtuyenduongManager _DmtuyenduongManager = new DmtuyenduongManager();
            DataTable dt = _DmtuyenduongManager.SelectByMadonviRDT(TBNET.ERP.DATA.DMDONVI._Current.Madonvi);
            if (dt == null || dt.Rows.Count == 0) return;
            string path_file = Path + "OUTBOX_Dmtuyenduong.xml";
            dt.TableName = "OUTBOX_Dmtuyenduong";
            Gendata(dt, path_file);
        }
        private static void OUTBOX_DmNhanvienkhachhang(string Path)
        {
            NhanvienkhachhangManeger _NhanvienkhachhangManeger = new NhanvienkhachhangManeger();            
            DataTable dt = _NhanvienkhachhangManeger.SelectByMadonviRDT(TBNET.ERP.DATA.DMDONVI._Current.Madonvi);
            if (dt == null || dt.Rows.Count == 0) return;
            string path_file = Path + "OUTBOX_Dmnhanvienkhachhang.xml";
            dt.TableName = "OUTBOX_Dmnhanvienkhachhang";
            Gendata(dt, path_file);
        }
        private static void OUTBOX_Dmkhachhang(string Path)
        {
            DataTable dt = TBNET.ERP.DATA.SESSION_START.DMKHACHHANG_issudung;
            if (dt == null || dt.Rows.Count == 0) return;
            string path_file = Path + "OUTBOX_Dmkhachhang.xml";
            dt.TableName = "OUTBOX_Dmkhachhang";
            Gendata(dt, path_file);
        }
        private static void OUTBOX_Nguoisudung(string Path)
        {
            DataTable dt = TBNET.ERP.DATA.SESSION_START.DMNHANVIEN_issudung;
            if (dt == null || dt.Rows.Count == 0) return;
            string path_file = Path + "OUTBOX_Nguoisudung.xml";
            dt.TableName = "OUTBOX_Nguoisudung";
            Gendata(dt, path_file);
        }
        private static void OUTBOX_Mathangbohang(string Path)
        {
            DmbohangManager _MathangbohangManager = new DmbohangManager();
            DataTable dt = _MathangbohangManager.SelectByMadonviRDT(TBNET.ERP.DATA.DMDONVI._Current.Madonvi);
            if (dt == null || dt.Rows.Count == 0) return;
            string path_file = Path + "OUTBOX_Mathangbohang.xml";
            dt.TableName = "OUTBOX_Mathangbohang";
            Gendata(dt, path_file);
        }
        private static void OUTBOX_Ctrinkmai(string Path)
        {
            CtrinhkmaiManager _CtrinkmaiManager = new CtrinhkmaiManager();
            DataTable dt = _CtrinkmaiManager.SelectAllRDT();
            if (dt == null || dt.Rows.Count == 0) return;
            string path_file = Path + "OUTBOX_Ctrinkmai.xml";
            dt.TableName = "OUTBOX_Ctrinkmai";
            Gendata(dt, path_file);
        }
        private static void OUTBOX_Ctrinhkmaichitiet(string Path)
        {
            CtrinhkmaictManager _CtrinhkmaichitietManager = new CtrinhkmaictManager();
            DataTable dt = _CtrinhkmaichitietManager.SelectAllRDT();
            if (dt == null || dt.Rows.Count == 0) return;
            string path_file = Path + "OUTBOX_Ctrinhkmaichitiet.xml";
            dt.TableName = "OUTBOX_Ctrinhkmaichitiet";
            Gendata(dt, path_file);
        }
    }
}
