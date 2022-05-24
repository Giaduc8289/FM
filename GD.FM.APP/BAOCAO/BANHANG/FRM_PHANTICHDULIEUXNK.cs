using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using GD.FM.BLL;
using GD.FM.DAL;
using GD.FM.DAL.EntityClasses;
using GD.FM.DAL.FactoryClasses;
using GD.FM.DAL.HelperClasses;
using System.Data.SqlClient;
using System.Collections;
using System.Collections.Specialized;
using Microsoft.Reporting.WinForms;
using GD.FM.APP.DANHMUC;
using GD.FM.LIB;

namespace GD.FM.APP.BAOCAO
{
    public partial class FRM_PHANTICHDULIEUXNK : FRM_DMPARENT
    {
        private DataTable DT_DMQUOCGIA = new DataTable(), DT_DMCANG = new DataTable();
        private DataRow _RowViewSelect = null;

        public FRM_PHANTICHDULIEUXNK()
        {
            InitializeComponent();
            GD.FM.CONTROL.BUTTON.Loadimage(LIB.PATH.FM_PATH, btn_IN, btn_IN.Name + ".xml");
            GD.FM.CONTROL.BUTTON.Loadimage(LIB.PATH.FM_PATH, btn_THOAT, btn_THOAT.Name + ".xml");
            txt_TUNGAY.Text = LIB.SESSION_START.TS_NGAYDAUTHANG.ToString("dd/MM/yyyy");
            txt_DENNGAY.Text = LIB.SESSION_START.TS_NGAYCUOITHANG.ToString("dd/MM/yyyy");
            DT_DMQUOCGIA = LIB.SESSION_START.DT_DMQUOCGIA;
            DT_DMCANG = LIB.SESSION_START.DT_DMCANG;
        }

        private void btn_IN_Click(object sender, EventArgs e)
        {
            DateTime _Tungay = new DateTime(), _Denngay = new DateTime();
            string _Maquocgia = "", _Macang = "";
            DataSet dsKetqua = new DataSet();

            try
            {
                #region Lay thong tin cac tham so
                _Tungay = Convert.ToDateTime(txt_TUNGAY.Text);
                _Denngay = Convert.ToDateTime(txt_DENNGAY.Text);
                _Maquocgia = txt_TENQUOCGIA.Text;
                _Macang = txt_TENCANG.Text;
                #endregion

                #region Chay procedure
                DAL.DatabaseSpecific.DataAccessAdapter _DataAccessAdapter = new DAL.DatabaseSpecific.DataAccessAdapter(LIB.SESSION_START.ConnectionStringKeyName);
                SqlParameter[] parameters = new SqlParameter[4];
                parameters[0] = new SqlParameter("@Tungay", _Tungay);
                parameters[1] = new SqlParameter("@Denngay", _Denngay);
                parameters[2] = new SqlParameter("@Maquocgia", _Maquocgia);
                parameters[3] = new SqlParameter("@Macang", _Macang);
                _DataAccessAdapter.CallRetrievalStoredProcedure("Baocaophantichdulieuxnk", parameters, dsKetqua);
                _DataAccessAdapter.CloseConnection();
                dsKetqua.Tables[0].TableName = "Dulieuxnk";
                #endregion

                #region Tham so
                DataTable dtThamso = new DataTable("Thamso");
                dtThamso.Columns.Add("Thoigianbaocao");
                DataRow dr = dtThamso.NewRow();
                if (_Tungay == _Denngay)
                    dr["Thoigianbaocao"] = "Ngày " + _Tungay.ToString("dd/MM/yyyy");
                else
                    dr["Thoigianbaocao"] = "Từ ngày " + _Tungay.ToString("dd/MM/yyyy") + " Đến ngày " + _Denngay.ToString("dd/MM/yyyy");
                dtThamso.Rows.Add(dr);
                dsKetqua.Tables.Add(dtThamso);
                #endregion

                #region Hien bao cao
                new FRM_REPORTVIEWER(dsKetqua, LIB.PATH.FM_PATH + @"\RDLC\BANHANG\DULIEUXNK.rdlc", "Dulieuxnk", this.Text, true).Show();
                #endregion
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        #region Validate
        private void txt_MAQUOCGIA_Validating(object sender, CancelEventArgs e)
        {
            _RowViewSelect = null;
            txt_TENQUOCGIA.Text = string.Empty;
            if (string.IsNullOrEmpty(txt_MAQUOCGIA.Text.Trim()) || DT_DMQUOCGIA == null || DT_DMQUOCGIA.Rows.Count == 0) return;
            string Str_MASIEUTHI = txt_MAQUOCGIA.Text.Trim().ToUpper();
            _RowViewSelect = checkmaQuocgia(Str_MASIEUTHI, DT_DMQUOCGIA);
            if (_RowViewSelect == null)
            {
                ListviewJanus _frm_SingerRows_Select =
                    new ListviewJanus(LIB.PATH.FM_PATH + @"\XMLCONFIG\FRM_DMQUOCGIA.xml",
                        DT_DMQUOCGIA, DanhmucquocgiaFields.Mahieu.Name, Str_MASIEUTHI);
                _frm_SingerRows_Select.ShowDialog();
                if (_frm_SingerRows_Select._RowViewSelect == null) return;
                _RowViewSelect = _frm_SingerRows_Select._RowViewSelect.Row;
                txt_MAQUOCGIA.Text = _RowViewSelect[DanhmucquocgiaFields.Mahieu.Name].ToString();
                txt_TENQUOCGIA.Text = _RowViewSelect[DanhmucquocgiaFields.Tenhieu.Name].ToString();

                //DT_DMCANG = new DanhmucquocgiaManager().SelectByMakhachRDT(txt_MAQUOCGIA.Text.Trim());
            }
            else
            {
                txt_TENQUOCGIA.Text = _RowViewSelect[DanhmucquocgiaFields.Tenhieu.Name].ToString();
                //DT_DMCANG = new DanhmucquocgiaManager().SelectByMakhachRDT(txt_MAQUOCGIA.Text.Trim());
            }
        }
        private DataRow checkmaQuocgia(string masieuthi, DataTable dt)
        {
            try
            {
                return dt.Select(DanhmucquocgiaFields.Mahieu.Name + "=" + "'" + masieuthi + "'").CopyToDataTable().Rows[0];
            }
            catch { return null; }
        }

        private void txt_MACANG_Validating(object sender, CancelEventArgs e)
        {
            _RowViewSelect = null;
            txt_TENCANG.Text = string.Empty;
            if (string.IsNullOrEmpty(txt_MACANG.Text.Trim()) || DT_DMCANG == null || DT_DMCANG.Rows.Count == 0) return;
            string Str_MASIEUTHI = txt_MACANG.Text.Trim().ToUpper();
            _RowViewSelect = checkmaCang(Str_MASIEUTHI, DT_DMCANG);
            if (_RowViewSelect == null)
            {
                ListviewJanus _frm_SingerRows_Select =
                    new ListviewJanus(LIB.PATH.FM_PATH + @"\XMLCONFIG\FRM_DMCANG.xml",
                        DT_DMCANG, DanhmuccangFields.Mahieu.Name, Str_MASIEUTHI);
                _frm_SingerRows_Select.ShowDialog();
                if (_frm_SingerRows_Select._RowViewSelect == null) return;
                _RowViewSelect = _frm_SingerRows_Select._RowViewSelect.Row;
                txt_MACANG.Text = _RowViewSelect[DanhmuccangFields.Mahieu.Name].ToString();
                txt_TENCANG.Text = _RowViewSelect[DanhmuccangFields.Tenhieu.Name].ToString();
            }
            else
            {
                txt_TENCANG.Text = _RowViewSelect[DanhmuccangFields.Tenhieu.Name].ToString();
            }
        }
        private DataRow checkmaCang(string masieuthi, DataTable dt)
        {
            try
            {
                return dt.Select(DanhmuccangFields.Mahieu.Name + "=" + "'" + masieuthi + "'").CopyToDataTable().Rows[0];
            }
            catch { return null; }
        }
        #endregion

        private void btn_THOAT_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
