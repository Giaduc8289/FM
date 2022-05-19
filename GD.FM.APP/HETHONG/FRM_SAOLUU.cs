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
using SD.LLBLGen.Pro.ORMSupportClasses;
using GD.FM.LIB;
using Janus.Data;
using Janus.Windows.GridEX;
using Janus.Windows.Common;
using GD.FM.CONTROL;
using GD.FM.APP.DANHMUC;

namespace GD.FM.APP.HETHONG 
{
    public partial class FRM_SAOLUU : FRM_DMPARENT
    {
        String path = "";

        public FRM_SAOLUU()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnChapnhan_Click(object sender, EventArgs e)
        {
            Cursor curr = this.Cursor;
            try
            {
                this.Cursor = Cursors.WaitCursor;
                GD.FM.APP.LIB.Procedures.Saoluudulieu(txt_THUMUC.Text);
                GD.FM.LIB.TrayPopup.PoupStringMessage("Thông báo", "Đã sao lưu thành công CSDL!"); 
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Sao lưu không thành công. Thực hiện lại!", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                MessageBox.Show(ex.Message);
            }
            this.Cursor = curr;
        }

        private void btnChonduongdan_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlgSave = new SaveFileDialog();
            dlgSave.FileName = Properties.Settings.Default.ApplicationName 
                + "_" + DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString().PadLeft(2, '0') + DateTime.Now.Day.ToString().PadLeft(2, '0')
                + "_" + DateTime.Now.Hour.ToString().PadLeft(2, '0') + DateTime.Now.Minute.ToString().PadLeft(2, '0');
            dlgSave.Filter = "Data files (*.bak)|*.bak|All files (*.*)|*.*";
            if (dlgSave.ShowDialog() == DialogResult.OK)
            {
                txt_THUMUC.Text = dlgSave.FileName;
            }
        }

    }
}
