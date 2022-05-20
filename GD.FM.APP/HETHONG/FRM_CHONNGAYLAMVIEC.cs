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
using GD.FM.APP.DANHMUC;
using System.Xml;
using GD.FM.APP.LIB;

namespace GD.FM.APP.HETHONG
{
    public partial class FRM_CHONNGAYLAMVIEC : FRM_DMPARENT
    {
        public FRM_CHONNGAYLAMVIEC()
        {
            InitializeComponent();
            GD.FM.CONTROL.BUTTON.Loadimage(LIB.PATH.FM_PATH, btn_Thoat, btn_Thoat.Name + ".xml");
            GD.FM.CONTROL.BUTTON.Loadimage(btnOK, btnOK.Name + ".xml");
            FORM_PROCESS();
            //numNamLamViec.Value = int.Parse(_catalogNameToUse.Substring(_catalogNameToUse.Length - 4));//DateTime.Now.Year.ToString();
            txt_NGAYLAMVIEC.Text = LIB.SESSION_START.TS_NGAYLAMVIEC.ToString("dd/MM/yyyy");
            lblVersion.Text = string.Format("{0}", SysInfo.CopyRightsDetail);
            lblNameSoftware.Text = SysInfo.ProductTitle;
        }
        private void FORM_PROCESS()
        {
            using (System.Windows.Forms.Form f = new System.Windows.Forms.Form())
            using (PictureBox _PictureBox = new PictureBox())
            using (BackgroundWorker worker = new BackgroundWorker())
            {
                Image _image = Image.FromFile(LIB.PATH.FM_PATH + @"\IMG\waiting.xml");
                _PictureBox.Image = _image;
                _PictureBox.Width = _image.Width;
                _PictureBox.Height = _image.Height;
                worker.DoWork += delegate
                {
                    //if (FUNCTION == "LOAD")
                    //{
                    //    DT_USER = LIB.SESSION_START.DM_USER;
                    //}
                };
                worker.RunWorkerCompleted += delegate
                {
                    f.Dispose();   // exit the modal dialog
                };
                f.Load += delegate
                {
                    worker.RunWorkerAsync();
                };
                Point a = new Point(10, 10);
                _PictureBox.Location = a;
                f.Controls.Add(_PictureBox);
                f.Text = "Chờ xử lý";
                f.ShowIcon = false;
                f.FormBorderStyle = FormBorderStyle.None;
                f.ShowInTaskbar = false;
                f.ControlBox = false;
                //f.BackColor = Color.Blue;
                f.MaximumSize = new System.Drawing.Size(_PictureBox.Width + 20, _PictureBox.Height + 20);
                f.MinimumSize = new System.Drawing.Size(_PictureBox.Width + 20, _PictureBox.Height + 20);
                f.StartPosition = FormStartPosition.CenterParent;
                f.ShowDialog();
            };
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                LIB.SESSION_START.TS_NGAYLAMVIEC = Convert.ToDateTime(txt_NGAYLAMVIEC.Text);
                LIB.SESSION_START.TS_NGAYDAUTHANG = LIB.SESSION_START.TS_NGAYLAMVIEC.AddDays(1 - LIB.SESSION_START.TS_NGAYLAMVIEC.Day);
                LIB.SESSION_START.TS_NGAYCUOITHANG = LIB.SESSION_START.TS_NGAYLAMVIEC.AddMonths(1).AddDays(-LIB.SESSION_START.TS_NGAYLAMVIEC.AddMonths(1).Day);
                LIB.SESSION_START.TS_NGAYDAUQUY = LIB.SESSION_START.TS_NGAYLAMVIEC.AddMonths(-(LIB.SESSION_START.TS_NGAYLAMVIEC.Month-1) % 3).AddDays(1 - LIB.SESSION_START.TS_NGAYLAMVIEC.Day);
                LIB.SESSION_START.TS_NGAYCUOIQUY = LIB.SESSION_START.TS_NGAYLAMVIEC.AddMonths(3 - (LIB.SESSION_START.TS_NGAYLAMVIEC.Month-1) % 3).AddDays(-LIB.SESSION_START.TS_NGAYLAMVIEC.AddMonths(3 - (LIB.SESSION_START.TS_NGAYLAMVIEC.Month - 1) % 3).Day);
                LIB.SESSION_START.TS_NGAYDAUNAM = LIB.SESSION_START.TS_NGAYLAMVIEC.AddDays(1 - LIB.SESSION_START.TS_NGAYLAMVIEC.DayOfYear);
                LIB.SESSION_START.TS_NGAYCUOINAM = LIB.SESSION_START.TS_NGAYLAMVIEC.AddYears(1).AddDays(-LIB.SESSION_START.TS_NGAYLAMVIEC.AddYears(1).DayOfYear);
                ((Janus.Windows.UI.StatusBar.UIStatusBar)(((FRM_MAIN)(this.MdiParent)).Controls["uiStatusBar2"])).Panels[0].Text = "Ngày làm việc: " + LIB.SESSION_START.TS_NGAYLAMVIEC.ToString("dd/MM/yyyy");
                this.Close();
            }
            catch { }
        }

    }
}
