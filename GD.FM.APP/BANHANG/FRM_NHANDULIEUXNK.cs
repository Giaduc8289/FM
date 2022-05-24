using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Data.SqlClient;
using System.Collections;
using System.Collections.Specialized;
using Microsoft.Reporting.WinForms;
using GD.FM.APP.BANHANG;
using GD.FM.LIB;
using GD.FM.APP.DANHMUC;

namespace GD.FM.APP.BANHANG
{
    public partial class FRM_NHANDULIEUXNK : FRM_DMPARENT
    {
        public string _PathFile = "";
        public DialogResult _DialogResult = DialogResult.No;

        public FRM_NHANDULIEUXNK()
        {
            InitializeComponent();
            //txt_NGAYNHAP.Text = LIB.SESSION_START.TS_NGAYLAMVIEC.ToString("dd/MM/yyyy");
        }

        private void btn_CHON_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlgOpen = new OpenFileDialog();
            dlgOpen.Filter = "Excel files (*.xls;*.xlsx)|*.xls;*.xlsx|All files (*.*)|*.*";
            if (dlgOpen.ShowDialog() == DialogResult.OK)
            {
                txt_PATH.Text = dlgOpen.FileName;
            }
        }

        private void btn_CHAPNHAN_Click(object sender, EventArgs e)
        {
            //_Thoigian = txt_NGAYNHAP.Text;
            _PathFile = txt_PATH.Text;
            _DialogResult = DialogResult.Yes;
            this.Dispose();
        }

        private void btn_THOAT_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

    }
}
