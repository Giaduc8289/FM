using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
using GD.FM.APP.DANHMUC;

namespace GD.FM.APP.BANHANG
{
    public partial class FRM_THUCHIENHOPDONGBAN : FRM_DMPARENT
    {
        private ThuchienhopdongbanhangManager _ThuchienhopdongbanhangManager = new ThuchienhopdongbanhangManager();
        private ThuchienhopdongbanhangEntity _ThuchienhopdongbanhangEntity = new ThuchienhopdongbanhangEntity();
        private MenuroleEntity _MenuroleEntity = new MenuroleEntity();
        private DataTable DT_THHOPDONGBAN = new DataTable();
        private BindingSource BS_THHOPDONGBAN = new BindingSource();
        private DataRow r_Insert = null, _RowViewSelect = null;
        private GD.FM.CONTROL.JGridEX GRID_THHOPDONGBAN = new GD.FM.CONTROL.JGridEX();
        private string FUNCTION = "LOAD", MAHIEU_PK = "";

        private DataTable DT_HOPDONGBAN = new DataTable(), DT_HOPDONGBAN_D = new DataTable();

        private void TEXTBOX_Only_Control(bool _isbool, GD.FM.CONTROL.TEXTBOX _Textbox)
        {
            GD.FM.LIB.FORM_PROCESS_UTIL.enableControls(!_isbool, uiPanel1Container, new List<Control>(new Control[] { _Textbox }));
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
                    if (FUNCTION == "LOAD")
                    {
                        _MenuroleEntity = MenuroleManager.Return_Current_Menurole("FRM_THUCHIENHOPDONGBAN");
                        DT_THHOPDONGBAN = LIB.SESSION_START.DT_THHOPDONGBAN;

                        DT_HOPDONGBAN = LIB.Procedures.Danhsachhopdongbanhang(LIB.SESSION_START.TS_NGAYDAUNAM, LIB.SESSION_START.TS_NGAYCUOINAM, string.Empty, string.Empty, string.Empty, string.Empty);
                        DT_HOPDONGBAN_D = LIB.Procedures.Danhsachhopdongbanhangchitiet(LIB.SESSION_START.TS_NGAYDAUNAM, LIB.SESSION_START.TS_NGAYCUOINAM, string.Empty, string.Empty, string.Empty, string.Empty);
                    }
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

        private static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            //  ErrorTrapper.ErrorHandler.HandleError(e.Exception);
        }

        public FRM_THUCHIENHOPDONGBAN()
        {
            InitializeComponent();
            ThuchienhopdongbanhangManager _ThuchienhopdongbanhangManager = new ThuchienhopdongbanhangManager();
            DataTable dt111 = _ThuchienhopdongbanhangManager.Clone();
            //GD.FM.LIB.GRID_COMM.Create_GRID_CONIG(dt111, LIB.PATH.FM_PATH + @"\XMLCONFIG\FRM_THUCHIENHOPDONGBAN.xml");
            GD.FM.LIB.FORM_PROCESS_UTIL.enableControls(false, uiPanel1Container, null);
            GD.FM.CONTROL.BUTTON.Loadimage(LIB.PATH.FM_PATH, btn_LUULAI, btn_LUULAI.Name + ".xml");
            GD.FM.CONTROL.BUTTON.Loadimage(LIB.PATH.FM_PATH, btn_SUA, btn_SUA.Name + ".xml");
            GD.FM.CONTROL.BUTTON.Loadimage(LIB.PATH.FM_PATH, btn_THEMMOI, btn_THEMMOI.Name + ".xml");
            GD.FM.CONTROL.BUTTON.Loadimage(LIB.PATH.FM_PATH, btn_XOA, btn_XOA.Name + ".xml");
            GD.FM.CONTROL.BUTTON.Loadimage(LIB.PATH.FM_PATH, btn_KHOIPHUC, btn_KHOIPHUC.Name + ".xml");
            GD.FM.CONTROL.BUTTON.Loadimage(LIB.PATH.FM_PATH, btn_Thoat, btn_Thoat.Name + ".xml");
            GD.FM.LIB.GRID_COMM.LOAD_GRID_UIPanel(LIB.PATH.FM_PATH + @"\XMLCONFIG\FRM_THUCHIENHOPDONGBAN.xml", GRID_THHOPDONGBAN, uiPanel0Container);
            FORM_PROCESS();
            DataView Source_View = new DataView(DT_THHOPDONGBAN);
            BS_THHOPDONGBAN = new BindingSource();
            BS_THHOPDONGBAN.DataSource = Source_View;
            GRID_THHOPDONGBAN.DataSource = BS_THHOPDONGBAN;
            BS_THHOPDONGBAN.CurrentChanged += new EventHandler(BS_THHOPDONGBAN_CurrentChanged);
            BS_THHOPDONGBAN_CurrentChanged((new object()), (new EventArgs()));
            GD.FM.BLL.MenuroleManager.set_Enable_controls(GD.FM.LIB.BUTTONACTION.BUTTONACTION_LOAD, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            Application.ThreadException += new System.Threading.ThreadExceptionEventHandler(Application_ThreadException);
            btn_THEMMOI.Focus();
        }

        void BS_THHOPDONGBAN_CurrentChanged(object sender, EventArgs e)
        {
            try
            {
                GD.FM.LIB.FORM_PROCESS_UTIL.clearControls(uiPanel1Container, GD.FM.LIB.FORM_PROCESS_UTIL.getAllControl(uiPanel1Container));
                if (BS_THHOPDONGBAN.Current != null)
                {
                    DataRowView _Rowview = (DataRowView)this.BS_THHOPDONGBAN.Current;
                    if (_Rowview != null)
                        MAHIEU_PK = _Rowview.Row[ThuchienhopdongbanhangFields.Id.Name].ToString();
                    txt_SOHOPDONG.Text = _Rowview.Row[ThuchienhopdongbanhangFields.Sohopdong.Name].ToString();
                    txt_MAHANGPHIAKHACH.Text = _Rowview.Row[ThuchienhopdongbanhangFields.Mahangphiakhach.Name].ToString();
                    txt_SOLUONGGIAO.Text = _Rowview.Row[ThuchienhopdongbanhangFields.Soluonggiao.Name].ToString();
                    txt_NGAYGIAO.Text = _Rowview.Row[ThuchienhopdongbanhangFields.Ngaygiao.Name].ToString();
                    txt_THANHTOANVND.Text = _Rowview.Row[ThuchienhopdongbanhangFields.Thanhtoanvnd.Name].ToString();
                    txt_THANHTOANUSD.Text = _Rowview.Row[ThuchienhopdongbanhangFields.Thanhtoanusd.Name].ToString();
                    txt_SOHOPDONG_Validating(new object(), new CancelEventArgs());
                    txt_MAHANGPHIAKHACH_Validating(new object(), new CancelEventArgs());
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "BS_THHOPDONGBAN_CurrentChanged"); }
        }

        private string Save_Data(string _str_DMCHUONG_PK)
        {
            ThuchienhopdongbanhangEntity _ThuchienhopdongbanhangEntity = new ThuchienhopdongbanhangEntity();
           
            _ThuchienhopdongbanhangEntity.Sohopdong = txt_SOHOPDONG.Text.Trim();
            _ThuchienhopdongbanhangEntity.Mahangphiakhach = txt_MAHANGPHIAKHACH.Text.Trim();
            try { _ThuchienhopdongbanhangEntity.Ngayhopdong = Convert.ToDateTime(txt_NGAYHOPDONG.Text.Trim()); }
            catch { }
            try { _ThuchienhopdongbanhangEntity.Ngaygiao = Convert.ToDateTime(txt_NGAYGIAO.Text.Trim()); }
            catch { }
            try { _ThuchienhopdongbanhangEntity.Soluonggiao = Convert.ToDecimal(txt_SOLUONGGIAO.Text.Trim()); }
            catch { }
            try { _ThuchienhopdongbanhangEntity.Thanhtienusd = Convert.ToDecimal(txt_THANHTIENUSD.Text.Trim()); }
            catch { }
            try { _ThuchienhopdongbanhangEntity.Thanhtienvnd = Convert.ToDecimal(txt_THANHTIENVND.Text.Trim()); }
            catch { }
            try { _ThuchienhopdongbanhangEntity.Thanhtoanusd = Convert.ToDecimal(txt_THANHTOANUSD.Text.Trim()); }
            catch { }
            try { _ThuchienhopdongbanhangEntity.Thanhtoanvnd = Convert.ToDecimal(txt_THANHTOANVND.Text.Trim()); }
            catch { }

            if (string.IsNullOrEmpty(_str_DMCHUONG_PK))
            {
                _ThuchienhopdongbanhangEntity.Ngaytao = DateTime.Now;
                _ThuchienhopdongbanhangEntity.Nguoitao = LIB.SESSION_START.TS_USER_LOGIN;
                _str_DMCHUONG_PK = _ThuchienhopdongbanhangManager.InsertV2(_ThuchienhopdongbanhangEntity, r_Insert, DT_THHOPDONGBAN, BS_THHOPDONGBAN);
                 GD.FM.BLL.MenuroleManager.set_Enable_controls(_ThuchienhopdongbanhangManager.Convert(_ThuchienhopdongbanhangEntity), GD.FM.LIB.BUTTONACTION.BUTTONACTION_INSERT, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
                BS_THHOPDONGBAN.ResetCurrentItem();
            }
            else    
            {
                _ThuchienhopdongbanhangEntity.Ngaysua = DateTime.Now;
                _ThuchienhopdongbanhangEntity.Nguoisua = LIB.SESSION_START.TS_USER_LOGIN;
                _ThuchienhopdongbanhangManager.Update(_ThuchienhopdongbanhangEntity);
                GRID_THHOPDONGBAN.CurrentRow.Cells[ThuchienhopdongbanhangFields.Ngayhopdong.Name].Value = _ThuchienhopdongbanhangEntity.Ngayhopdong;
                GRID_THHOPDONGBAN.CurrentRow.Cells[ThuchienhopdongbanhangFields.Sohopdong.Name].Value = _ThuchienhopdongbanhangEntity.Sohopdong;
                GRID_THHOPDONGBAN.CurrentRow.Cells[ThuchienhopdongbanhangFields.Ngaygiao.Name].Value = _ThuchienhopdongbanhangEntity.Ngaygiao;
                GRID_THHOPDONGBAN.CurrentRow.Cells[ThuchienhopdongbanhangFields.Mahangphiakhach.Name].Value = _ThuchienhopdongbanhangEntity.Mahangphiakhach;
                GRID_THHOPDONGBAN.CurrentRow.Cells[ThuchienhopdongbanhangFields.Soluonggiao.Name].Value = _ThuchienhopdongbanhangEntity.Soluonggiao;
                GD.FM.BLL.MenuroleManager.set_Enable_controls(_ThuchienhopdongbanhangManager.Convert(_ThuchienhopdongbanhangEntity), GD.FM.LIB.BUTTONACTION.BUTTONACTION_UPDATE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            }
            return _str_DMCHUONG_PK;
        }

        #region Button
        private void btn_THEMMOI_Click(object sender, EventArgs e)
        {
            GD.FM.LIB.FORM_PROCESS_UTIL.enableControls(true, uiPanel1Container, new List<Control>(new Control[] { }));
            ThuchienhopdongbanhangManager _ThuchienhopdongbanhangManager = new ThuchienhopdongbanhangManager();
            ThuchienhopdongbanhangEntity _ThuchienhopdongbanhangEntity = new ThuchienhopdongbanhangEntity();
            r_Insert = DT_THHOPDONGBAN.NewRow();
            DT_THHOPDONGBAN.Rows.Add(r_Insert);
            BS_THHOPDONGBAN.Position = DT_THHOPDONGBAN.Rows.Count;
            MAHIEU_PK = "";
            txt_SOHOPDONG.Focus();
            TEXTBOX_Only_Control(false, null);
            GD.FM.LIB.FORM_PROCESS_UTIL.enableControls(true, uiPanel1Container, new List<Control>(new Control[] { }));
            GD.FM.BLL.MenuroleManager.set_Enable_controls(GD.FM.LIB.BUTTONACTION.BUTTONACTION_THEMMOI, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            GRID_THHOPDONGBAN.Enabled = false;
        }
        private void btn_SUA_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(MAHIEU_PK)) { return; }
            else
            {
                GD.FM.BLL.MenuroleManager.set_Enable_controls(GD.FM.LIB.BUTTONACTION.BUTTONACTION_SUA, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
                GD.FM.LIB.FORM_PROCESS_UTIL.enableControls(true, uiPanel1Container, new List<Control>(new Control[] { txt_SOHOPDONG }));
                txt_MAHANGPHIAKHACH.Focus();
            }
            GRID_THHOPDONGBAN.Enabled = false;
        }
        private void btn_KHOIPHUC_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(MAHIEU_PK) && r_Insert != null)
            {
                DT_THHOPDONGBAN.Rows.Remove(r_Insert);
            }
            BS_THHOPDONGBAN_CurrentChanged(new object(), new EventArgs());
            GD.FM.BLL.MenuroleManager.set_Enable_controls(GD.FM.LIB.BUTTONACTION.BUTTONACTION_CANCEL, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            FORM_PROCESS_UTIL.enableControls(false, uiPanel1Container, new List<Control>(new Control[] { }));
            GRID_THHOPDONGBAN.Enabled = true;
        }
        private void btn_XOA_Click(object sender, EventArgs e)
        {
            GD.FM.LIB.FORM_PROCESS_UTIL.enableControls(false, uiPanel1Container, null);
            if (string.IsNullOrEmpty(MAHIEU_PK)) return;
            ThuchienhopdongbanhangManager _ThuchienhopdongbanhangManager = new ThuchienhopdongbanhangManager();
            ThuchienhopdongbanhangEntity _ThuchienhopdongbanhangEntity = new ThuchienhopdongbanhangEntity();
            _ThuchienhopdongbanhangEntity = _ThuchienhopdongbanhangManager.SelectOne(Convert.ToInt64(MAHIEU_PK));
            if (_ThuchienhopdongbanhangEntity != null && MessageBox.Show("Xóa đơn vị tính: " + MAHIEU_PK + " - " + txt_MAHANGPHIAKHACH.Text, "Xóa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) ==
                   System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                    _ThuchienhopdongbanhangManager.Delete(Convert.ToInt64(MAHIEU_PK));
                    GRID_THHOPDONGBAN.CurrentRow.Delete();
                    BS_THHOPDONGBAN_CurrentChanged(new object(), new EventArgs());
                    GD.FM.LIB.TrayPopup.PoupStringMessage("Thông báo", "Đã xóa thành công!");
                    GD.FM.BLL.MenuroleManager.set_Enable_controls(_ThuchienhopdongbanhangManager.Convert(_ThuchienhopdongbanhangEntity), GD.FM.LIB.BUTTONACTION.BUTTONACTION_DELETE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
                }
                catch
                {
                    MessageBox.Show("Không thể xóa đơn vị tính " + MAHIEU_PK + "!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            GRID_THHOPDONGBAN.Enabled = true;
        }
        private void btn_LUULAI_Click(object sender, EventArgs e)
        {
            if (txt_SOHOPDONG.Text == "")
            {
                MessageBox.Show("Yêu cầu nhập mã đơn vị tính!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_SOHOPDONG.Focus();
                return;
            }
            else if (txt_MAHANGPHIAKHACH.Text == "")
            {
                MessageBox.Show("Yêu cầu nhập tên đơn vị tính!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_MAHANGPHIAKHACH.Focus();
                return;
            }
            else
            {
                GD.FM.LIB.FORM_PROCESS_UTIL.enableControls(false, uiPanel1Container, null);
                MAHIEU_PK = Save_Data(MAHIEU_PK);
                GD.FM.LIB.TrayPopup.PoupStringMessage("Thông báo", "Lưu lại thành công");
                GRID_THHOPDONGBAN.Enabled = true;
                btn_THEMMOI.Focus();
            }
        }
        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion

        private void uiPanel0_Resize(object sender, EventArgs e)
        {
            if (uiPanel0.Width > 820)
                GRID_THHOPDONGBAN.ColumnAutoResize = true;
            else
                GRID_THHOPDONGBAN.ColumnAutoResize = false;
        }

        #region Validate
        private void txt_SOHOPDONG_Validating(object sender, CancelEventArgs e)
        {
            _RowViewSelect = null;
            if (string.IsNullOrEmpty(txt_SOHOPDONG.Text.Trim()) || DT_HOPDONGBAN == null || DT_HOPDONGBAN.Rows.Count == 0) return;
            string Str_MASIEUTHI = txt_SOHOPDONG.Text.Trim().ToUpper();
            _RowViewSelect = checkSohopdong(Str_MASIEUTHI, DT_HOPDONGBAN);
            if (_RowViewSelect == null)
            {
                ListviewJanus _frm_SingerRows_Select =
                    new ListviewJanus(LIB.PATH.FM_PATH + @"\XMLCONFIG\FRM_HOPDONGBAN_H.xml",
                        DT_HOPDONGBAN, HopdongbanhangFields.Sohopdong.Name, Str_MASIEUTHI);
                _frm_SingerRows_Select.ShowDialog();
                if (_frm_SingerRows_Select._RowViewSelect == null) return;
                _RowViewSelect = _frm_SingerRows_Select._RowViewSelect.Row;
                txt_SOHOPDONG.Text = _RowViewSelect[HopdongbanhangFields.Sohopdong.Name].ToString();
                txt_NGAYHOPDONG.Text = _RowViewSelect[HopdongbanhangFields.Ngayhopdong.Name].ToString();
                txt_MAKHACH.Text = _RowViewSelect[HopdongbanhangFields.Makhach.Name].ToString();
                txt_TENKHACH.Text = _RowViewSelect[HopdongbanhangFields.Tenkhach.Name].ToString();

                DT_HOPDONGBAN_D = new HopdongbanhangchitietManager().SelectBySohopdongRDT(txt_SOHOPDONG.Text);
            }
            else
            {
                txt_NGAYHOPDONG.Text = _RowViewSelect[HopdongbanhangFields.Ngayhopdong.Name].ToString();
                txt_MAKHACH.Text = _RowViewSelect[HopdongbanhangFields.Makhach.Name].ToString();
                txt_TENKHACH.Text = _RowViewSelect[HopdongbanhangFields.Tenkhach.Name].ToString();

                DT_HOPDONGBAN_D = new HopdongbanhangchitietManager().SelectBySohopdongRDT(txt_SOHOPDONG.Text);
            }
        }
        private DataRow checkSohopdong(string masieuthi, DataTable dt)
        {
            try
            {
                return dt.Select(HopdongbanhangFields.Sohopdong.Name + "=" + "'" + masieuthi + "'").CopyToDataTable().Rows[0];
            }
            catch { return null; }
        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void txt_SOHOPDONG_TextChanged(object sender, EventArgs e)
        {

        }

        private void uiPanel1Container_Click(object sender, EventArgs e)
        {

        }

        private void txt_MAHANGPHIAKHACH_Validating(object sender, CancelEventArgs e)
        {
            _RowViewSelect = null;
            if (string.IsNullOrEmpty(txt_MAHANGPHIAKHACH.Text.Trim()) || DT_HOPDONGBAN_D == null || DT_HOPDONGBAN_D.Rows.Count == 0) return;
            string Str_MASIEUTHI = txt_MAHANGPHIAKHACH.Text.Trim().ToUpper();
            _RowViewSelect = checkMahangphiakhach(Str_MASIEUTHI, DT_HOPDONGBAN_D);
            if (_RowViewSelect == null)
            {
                ListviewJanus _frm_SingerRows_Select =
                    new ListviewJanus(LIB.PATH.FM_PATH + @"\XMLCONFIG\FRM_HOPDONGBAN_D.xml",
                        DT_HOPDONGBAN_D, HopdongbanhangchitietFields.Mahangphiakhach.Name, Str_MASIEUTHI);
                _frm_SingerRows_Select.ShowDialog();
                if (_frm_SingerRows_Select._RowViewSelect == null) return;
                _RowViewSelect = _frm_SingerRows_Select._RowViewSelect.Row;
                txt_MAHANGPHIAKHACH.Text = _RowViewSelect[HopdongbanhangchitietFields.Mahangphiakhach.Name].ToString();
                txt_CODEFILLER.Text = _RowViewSelect[HopdongbanhangchitietFields.Codefiller.Name].ToString();
                txt_DONGIAVND.Text = _RowViewSelect[HopdongbanhangchitietFields.Dongiavnd.Name].ToString();
                txt_DONGIAUSD.Text = _RowViewSelect[HopdongbanhangchitietFields.Dongiausd.Name].ToString();
                txt_SOLUONGDAT.Text = _RowViewSelect[HopdongbanhangchitietFields.Soluong.Name].ToString();
            }
            else
            {
                txt_CODEFILLER.Text = _RowViewSelect[HopdongbanhangchitietFields.Codefiller.Name].ToString();
                txt_DONGIAVND.Text = _RowViewSelect[HopdongbanhangchitietFields.Dongiavnd.Name].ToString();
                txt_DONGIAUSD.Text = _RowViewSelect[HopdongbanhangchitietFields.Dongiausd.Name].ToString();
                txt_SOLUONGDAT.Text = _RowViewSelect[HopdongbanhangchitietFields.Soluong.Name].ToString();
            }
        }
        private DataRow checkMahangphiakhach(string masieuthi, DataTable dt)
        {
            try
            {
                return dt.Select(HopdongbanhangchitietFields.Mahangphiakhach.Name + "=" + "'" + masieuthi + "'").CopyToDataTable().Rows[0];
            }
            catch { return null; }
        }
        #endregion

        private void FRM_THUCHIENHOPDONGBAN_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (btn_LUULAI.Enabled)
            {
                DialogResult Dlog = MessageBox.Show("Dữ liệu đã được thay đổi! Bạn có muốn lưu lại không?", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (Dlog == DialogResult.Yes)
                {
                    btn_LUULAI_Click(new object(), new EventArgs());
                    return;
                }
                if (Dlog == DialogResult.Cancel)
                {
                    e.Cancel = true;
                    return;
                }
            }
        }
    }
}
