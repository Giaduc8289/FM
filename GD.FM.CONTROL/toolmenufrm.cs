using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Janus.Windows.GridEX;

namespace GD.FM.CONTROL
{
    public partial class toolmenufrm : UserControl
    {
        private static string xmlfileconfig;
        private DataTable dtsource;
        private GridEX DGVConfig;
        private GD.FM.CONTROL.FORM _frmconfig;
        public static string XMLFILE
        {
            get { return xmlfileconfig; }
            set { xmlfileconfig = value; }
        }
        public DataTable DT_SOURCE
        {
            get { return dtsource; }
            set { dtsource = value; }
        }
        public GridEX GRID 
        {
            get { return DGVConfig; }
            set { DGVConfig = value; }
        }
        public GD.FM.CONTROL.FORM FRM_CONFIG 
        {
            get { return _frmconfig; }
            set { _frmconfig = value; }
        }
        public toolmenufrm(string xmlfile, DataTable dtconfig, GridEX _DataGridView,GD.FM.CONTROL.FORM _Form)
        {
            InitializeComponent();

            GD.FM.CONTROL.BUTTON.Loadimage(btnTimKiem, btnTimKiem.Name + ".xml");
            GD.FM.CONTROL.BUTTON.Loadimage(btnIn, btnIn.Name + ".xml");
            GD.FM.CONTROL.BUTTON.Loadimage(btnThoat, btnThoat.Name + ".xml");
            btnsetupview.Visible = true;
            XMLFILE = xmlfile;
            DT_SOURCE = dtconfig;
            GRID = _DataGridView;
            FRM_CONFIG = _Form;
        }
        public toolmenufrm(string xmlfile, DataTable dtconfig, DataGridView _DataGridView, GD.FM.CONTROL.FORM _Form)
        {
            InitializeComponent();

            GD.FM.CONTROL.BUTTON.Loadimage(btnTimKiem, btnTimKiem.Name + ".xml");
            GD.FM.CONTROL.BUTTON.Loadimage(btnIn, btnIn.Name + ".xml");
            GD.FM.CONTROL.BUTTON.Loadimage(btnThoat, btnThoat.Name + ".xml");
            btnsetupview.Visible = true;
            XMLFILE = xmlfile;
            DT_SOURCE = dtconfig;
            //GRID = _DataGridView;
            FRM_CONFIG = _Form;
        }
        public static void Setup_GridView()
        {
            GD.FM.CONTROL.setup setupview = new GD.FM.CONTROL.setup(XMLFILE);
            setupview.ShowDialog();
        }
        private void KhoiTaoGridView()
        {
            DialogResult result;
            result = MessageBox.Show("Bạn có chắc chắn muốm tạo lại các cột hiện thị cho dự liệu ở dưới không", "Cài đặt hiển thị cột dữ liệu", MessageBoxButtons.YesNoCancel);
            if (result.Equals(DialogResult.Yes))
            {
                // TBNet.Mart.TBNetCommon.cratexml(this.DT_SOURCE, this.XMLFILE);                
            }
        }
        public void btnsetupview_Click(object sender, EventArgs e)
        {
            Setup_GridView();
        }
        private void btnresetview_Click(object sender, EventArgs e)
        {
            KhoiTaoGridView();
        }
        //private void btntimkiem_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        TBNet.Mart.FindHelp.FindSearch(txtKeySearch.Text.Trim(), ref DT_SOURCE, dtpTuNgay.Value, dtpDenNgay.Value);
        //    }
        //    catch { }
        //}
        //private void btnin_Click(object sender, EventArgs e)
        //{
        //    PrintDGV.Print_DataGridView(this.GRID);
        //}
        private void btnthoat_Click(object sender, EventArgs e)
        {
            FRM_CONFIG.Dispose();
        }

        //private void txtKeySearch_Validating(object sender, CancelEventArgs e)
        //{
        //    if (txtKeySearch.Text.Trim().Length > 0)
        //    {
        //        try
        //        {
        //            TBNet.Mart.FindHelp.FindSearch(txtKeySearch.Text.Trim(), ref DT_SOURCE, dtpTuNgay.Value, dtpDenNgay.Value);
        //        }
        //        catch { }
        //    }
        //}

        //private void toolmenufrm_Load(object sender, EventArgs e)
        //{
        //    txtKeySearch.Focus();
        //}

    }
}
