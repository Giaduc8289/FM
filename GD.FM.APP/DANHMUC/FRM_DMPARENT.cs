using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GD.FM.APP.DANHMUC
{
    public partial class FRM_DMPARENT : GD.FM.CONTROL.FORM
    {
        private static Form _fmain = null;

        public FRM_DMPARENT()
        {
            InitializeComponent();
        }

        public static void OpenFormByName(string strFormName, string strParam, Form fmain)
        {
            //try
            //{
            //    _fmain = fmain;
            //    //foreach (GD.FM.CONTROL.FORM frm in fmain.MdiChildren)
            //    //{
            //    //    if (frm.Name == strFormName) { frm.Activate(); return; }
            //    //}                
            //    if (!string.IsNullOrEmpty(strParam))
                //{
                //    if (strFormName.Equals("FRM_DMNHANVIEN"))
                //    {
                //        GD.FM.DANHMUC.FRM_DMNHANVIEN frm_nhanvien = new FRM_DMNHANVIEN(strParam);
                //        frm_nhanvien.StartPosition = FormStartPosition.CenterScreen;
                //        frm_nhanvien.ShowDialog();
                //    }
                //    else if (strFormName.Equals("FRM_DMKHACHHANG"))
                //    {
                //        GD.FM.DANHMUC.FRM_DMKHACHHANG frm_khachhang = new FRM_DMKHACHHANG(strParam);
                //        frm_khachhang.StartPosition = FormStartPosition.CenterScreen;
                //        frm_khachhang.ShowDialog();
                //    }
                //    else if (strFormName.Equals("FRM_DMNHACUNGCAP"))
                //    {
                //        GD.FM.DANHMUC.FRM_DMNHACUNGCAP frm_nhacungcap = new FRM_DMNHACUNGCAP(strParam);
                //        frm_nhacungcap.StartPosition = FormStartPosition.CenterScreen;
                //        frm_nhacungcap.ShowDialog();
                //    }
                //    else if (strFormName.Equals("FRM_HRNHANVIEN"))
                //    {
                //        GD.FM.DANHMUC.FRM_HRNHANVIEN frm_hrnhanvien = new FRM_HRNHANVIEN(strParam);
                //        frm_hrnhanvien.StartPosition = FormStartPosition.CenterScreen;
                //        frm_hrnhanvien.ShowDialog();
                //    }
                //    else if (strFormName.Equals("FRM_DMLICHLV"))
                //    {
                //        GD.FM.DANHMUC.FRM_DMLICHLV frm_khachhang = new FRM_DMLICHLV(strParam);
                //        frm_khachhang.StartPosition = FormStartPosition.CenterScreen;
                //        frm_khachhang.ShowDialog();
                //    }
                //    else
                //    {
                //        Form frmCheck = (Form)System.Type.GetType("GD.FM.DANHMUC." + strFormName).GetConstructor(System.Type.EmptyTypes).Invoke(null);
                //        frmCheck.StartPosition = FormStartPosition.CenterScreen;
                //        frmCheck.ShowDialog();
                //    }
                //}
                //else
                //{
                //    if (strFormName == "FRM_DMLICHLV")
                //    { new FRM_DMLICHLV("").ShowDialog(); }
                //    Form frmCheck = (Form)System.Type.GetType("GD.FM.DANHMUC." + strFormName).GetConstructor(System.Type.EmptyTypes).Invoke(null);
                //    frmCheck.StartPosition = FormStartPosition.CenterScreen;
                //    frmCheck.ShowDialog();
                //}
            //}
            //catch (Exception)
            //{ }
        }

        public void CloseFormByName(object sender, string strFormname)
        {
            try
            {
                this.Close();
            }
            catch (Exception)
            { }
        }
    }
}
