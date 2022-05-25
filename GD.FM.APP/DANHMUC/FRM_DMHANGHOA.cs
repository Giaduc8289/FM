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

namespace GD.FM.APP.DANHMUC
{
    public partial class FRM_DMHANGHOA : FRM_DMPARENT
    {
        private DanhmuchanghoaManager _DanhmuchanghoaManager = new DanhmuchanghoaManager();
        private DanhmuchanghoaEntity _DanhmuchanghoaEntity = new DanhmuchanghoaEntity();
        private MenuroleEntity _MenuroleEntity = new MenuroleEntity();
        private DataTable DT_DMHANGHOA = new DataTable();
        private BindingSource BS_DMHANGHOA = new BindingSource();
        private DataRow r_Insert = null;
        private GD.FM.CONTROL.JGridEX GRID_DMHANGHOA = new GD.FM.CONTROL.JGridEX();
        private string FUNCTION = "LOAD", MAHIEU_PK = "";
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
                        _MenuroleEntity = MenuroleManager.Return_Current_Menurole("FRM_DMHANGHOA");
                        DT_DMHANGHOA = LIB.SESSION_START.DT_DMHANGHOA;
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

        public FRM_DMHANGHOA()
        {
            InitializeComponent();
            DanhmuchanghoaManager _DanhmuchanghoaManager = new DanhmuchanghoaManager();
            DataTable dt111 = _DanhmuchanghoaManager.Clone();
            //GD.FM.LIB.GRID_COMM.Create_GRID_CONIG(dt111, LIB.PATH.FM_PATH + @"\XMLCONFIG\FRM_DMHANGHOA.xml");
            GD.FM.LIB.FORM_PROCESS_UTIL.enableControls(false, uiPanel1Container, null);
            GD.FM.CONTROL.BUTTON.Loadimage(LIB.PATH.FM_PATH, btn_LUULAI, btn_LUULAI.Name + ".xml");
            GD.FM.CONTROL.BUTTON.Loadimage(LIB.PATH.FM_PATH, btn_SUA, btn_SUA.Name + ".xml");
            GD.FM.CONTROL.BUTTON.Loadimage(LIB.PATH.FM_PATH, btn_THEMMOI, btn_THEMMOI.Name + ".xml");
            GD.FM.CONTROL.BUTTON.Loadimage(LIB.PATH.FM_PATH, btn_XOA, btn_XOA.Name + ".xml");
            GD.FM.CONTROL.BUTTON.Loadimage(LIB.PATH.FM_PATH, btn_KHOIPHUC, btn_KHOIPHUC.Name + ".xml");
            GD.FM.CONTROL.BUTTON.Loadimage(LIB.PATH.FM_PATH, btn_Thoat, btn_Thoat.Name + ".xml");
            GD.FM.LIB.GRID_COMM.LOAD_GRID_UIPanel(LIB.PATH.FM_PATH + @"\XMLCONFIG\FRM_DMHANGHOA.xml", GRID_DMHANGHOA, uiPanel0Container);
            FORM_PROCESS();
            DataView Source_View = new DataView(DT_DMHANGHOA);
            BS_DMHANGHOA = new BindingSource();
            BS_DMHANGHOA.DataSource = Source_View;
            GRID_DMHANGHOA.DataSource = BS_DMHANGHOA;
            BS_DMHANGHOA.CurrentChanged += new EventHandler(BS_DMHANGHOA_CurrentChanged);
            BS_DMHANGHOA_CurrentChanged((new object()), (new EventArgs()));
            GD.FM.BLL.MenuroleManager.set_Enable_controls(GD.FM.LIB.BUTTONACTION.BUTTONACTION_LOAD, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            Application.ThreadException += new System.Threading.ThreadExceptionEventHandler(Application_ThreadException);
            btn_THEMMOI.Focus();
        }

        void BS_DMHANGHOA_CurrentChanged(object sender, EventArgs e)
        {
            try
            {
                GD.FM.LIB.FORM_PROCESS_UTIL.clearControls(uiPanel1Container, GD.FM.LIB.FORM_PROCESS_UTIL.getAllControl(uiPanel1Container));
                if (BS_DMHANGHOA.Current != null)
                {
                    DataRowView _Rowview = (DataRowView)this.BS_DMHANGHOA.Current;
                    if (_Rowview != null)
                        MAHIEU_PK = _Rowview.Row[DanhmuchanghoaFields.Mahieu.Name].ToString();
                    txt_MAHIEU.Text = _Rowview.Row[DanhmuchanghoaFields.Mahieu.Name].ToString();
                    txt_MAKHACH.Text = _Rowview.Row[DanhmuchanghoaFields.Makhach.Name].ToString();
                    txt_TENKHACH.Text = _Rowview.Row[DanhmuchanghoaFields.Tenkhach.Name].ToString();
                    txt_CACO3KH.Text = _Rowview.Row[DanhmuchanghoaFields.Caco3kh.Name].ToString();
                    TXT_TIO2KH.Text = _Rowview.Row[DanhmuchanghoaFields.Tio2kh.Name].ToString();
                    txt_MIKH.Text = _Rowview.Row[DanhmuchanghoaFields.Mikh.Name].ToString();
                    txt_CACO3FM.Text = _Rowview.Row[DanhmuchanghoaFields.Caco3fm.Name].ToString();
                    txt_TIO2FM.Text = _Rowview.Row[DanhmuchanghoaFields.Tio2fm.Name].ToString();
                    txt_MIFM.Text = _Rowview.Row[DanhmuchanghoaFields.Mifm.Name].ToString();

                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "BS_DMHANGHOA_CurrentChanged"); }
        }

        private string Save_Data(string _str_DMCHUONG_PK)
        {
            DanhmuchanghoaEntity _DanhmuchanghoaEntity = new DanhmuchanghoaEntity();
            _DanhmuchanghoaEntity.Mahieu = txt_MAHIEU.Text.Trim();
            _DanhmuchanghoaEntity.Makhach = txt_MAKHACH.Text.Trim();
            _DanhmuchanghoaEntity.Tenkhach = txt_TENKHACH.Text.Trim();
            try { _DanhmuchanghoaEntity.Caco3kh = Convert.ToDecimal(txt_CACO3KH.Text.Trim()); }
            catch { }
            try { _DanhmuchanghoaEntity.Tio2kh = Convert.ToDecimal(TXT_TIO2KH.Text.Trim()); }
            catch { }
            _DanhmuchanghoaEntity.Mikh = txt_MIKH.Text.Trim();
            try { _DanhmuchanghoaEntity.Caco3fm = Convert.ToDecimal(txt_CACO3FM.Text.Trim()); }
            catch { }
            try { _DanhmuchanghoaEntity.Tio2fm = Convert.ToDecimal(txt_TIO2FM.Text.Trim()); }
            catch { }
            _DanhmuchanghoaEntity.Mifm = txt_MIFM.Text.Trim();

            if (string.IsNullOrEmpty(_str_DMCHUONG_PK))
            {
                _DanhmuchanghoaEntity.Ngaytao = DateTime.Now;
                _DanhmuchanghoaEntity.Nguoitao = LIB.SESSION_START.TS_USER_LOGIN;
                _str_DMCHUONG_PK = _DanhmuchanghoaManager.InsertV2(_DanhmuchanghoaEntity, r_Insert, DT_DMHANGHOA, BS_DMHANGHOA);
                 GD.FM.BLL.MenuroleManager.set_Enable_controls(_DanhmuchanghoaManager.Convert(_DanhmuchanghoaEntity), GD.FM.LIB.BUTTONACTION.BUTTONACTION_INSERT, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
                BS_DMHANGHOA.ResetCurrentItem();
            }
            else
            {
                _DanhmuchanghoaEntity.Ngaysua = DateTime.Now;
                _DanhmuchanghoaEntity.Nguoisua = LIB.SESSION_START.TS_USER_LOGIN;
                _DanhmuchanghoaManager.Update(_DanhmuchanghoaEntity);
                GRID_DMHANGHOA.CurrentRow.Cells[DanhmuchanghoaFields.Mahieu.Name].Value = _DanhmuchanghoaEntity.Mahieu;
                GRID_DMHANGHOA.CurrentRow.Cells[DanhmuchanghoaFields.Makhach.Name].Value = _DanhmuchanghoaEntity.Makhach;
                GRID_DMHANGHOA.CurrentRow.Cells[DanhmuchanghoaFields.Tenkhach.Name].Value = _DanhmuchanghoaEntity.Tenkhach;
                GRID_DMHANGHOA.CurrentRow.Cells[DanhmuchanghoaFields.Caco3kh.Name].Value = _DanhmuchanghoaEntity.Caco3kh;
                GRID_DMHANGHOA.CurrentRow.Cells[DanhmuchanghoaFields.Tio2kh.Name].Value = _DanhmuchanghoaEntity.Tio2kh;
                GRID_DMHANGHOA.CurrentRow.Cells[DanhmuchanghoaFields.Mikh.Name].Value = _DanhmuchanghoaEntity.Mikh;
                GRID_DMHANGHOA.CurrentRow.Cells[DanhmuchanghoaFields.Caco3fm.Name].Value = _DanhmuchanghoaEntity.Caco3fm;
                GRID_DMHANGHOA.CurrentRow.Cells[DanhmuchanghoaFields.Tio2fm.Name].Value = _DanhmuchanghoaEntity.Tio2fm;
                GRID_DMHANGHOA.CurrentRow.Cells[DanhmuchanghoaFields.Mifm.Name].Value = _DanhmuchanghoaEntity.Mifm;
                GD.FM.BLL.MenuroleManager.set_Enable_controls(_DanhmuchanghoaManager.Convert(_DanhmuchanghoaEntity), GD.FM.LIB.BUTTONACTION.BUTTONACTION_UPDATE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            }
            return _str_DMCHUONG_PK;
        }

        #region Button
        private void btn_THEMMOI_Click(object sender, EventArgs e)
        {
            GD.FM.LIB.FORM_PROCESS_UTIL.enableControls(true, uiPanel1Container, new List<Control>(new Control[] { }));
            DanhmuchanghoaManager _DanhmuchanghoaManager = new DanhmuchanghoaManager();
            DanhmuchanghoaEntity _DanhmuchanghoaEntity = new DanhmuchanghoaEntity();
            r_Insert = DT_DMHANGHOA.NewRow();
            DT_DMHANGHOA.Rows.Add(r_Insert);
            BS_DMHANGHOA.Position = DT_DMHANGHOA.Rows.Count;
            MAHIEU_PK = "";
            txt_MAHIEU.Focus();
            TEXTBOX_Only_Control(false, null);
            GD.FM.LIB.FORM_PROCESS_UTIL.enableControls(true, uiPanel1Container, new List<Control>(new Control[] { }));
            GD.FM.BLL.MenuroleManager.set_Enable_controls(GD.FM.LIB.BUTTONACTION.BUTTONACTION_THEMMOI, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            GRID_DMHANGHOA.Enabled = false;
        }
        private void btn_SUA_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(MAHIEU_PK)) { return; }
            else
            {
                GD.FM.BLL.MenuroleManager.set_Enable_controls(GD.FM.LIB.BUTTONACTION.BUTTONACTION_SUA, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
                GD.FM.LIB.FORM_PROCESS_UTIL.enableControls(true, uiPanel1Container, new List<Control>(new Control[] { txt_MAHIEU }));
                txt_MAKHACH.Focus();
            }
            GRID_DMHANGHOA.Enabled = false;
        }
        private void btn_KHOIPHUC_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(MAHIEU_PK) && r_Insert != null)
            {
                DT_DMHANGHOA.Rows.Remove(r_Insert);
            }
            BS_DMHANGHOA_CurrentChanged(new object(), new EventArgs());
            GD.FM.BLL.MenuroleManager.set_Enable_controls(GD.FM.LIB.BUTTONACTION.BUTTONACTION_CANCEL, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            FORM_PROCESS_UTIL.enableControls(false, uiPanel1Container, new List<Control>(new Control[] { }));
            GRID_DMHANGHOA.Enabled = true;
        }
        private void btn_XOA_Click(object sender, EventArgs e)
        {
            GD.FM.LIB.FORM_PROCESS_UTIL.enableControls(false, uiPanel1Container, null);
            if (string.IsNullOrEmpty(MAHIEU_PK)) return;
            DanhmuchanghoaManager _DanhmuchanghoaManager = new DanhmuchanghoaManager();
            DanhmuchanghoaEntity _DanhmuchanghoaEntity = new DanhmuchanghoaEntity();
            _DanhmuchanghoaEntity = _DanhmuchanghoaManager.SelectOne(MAHIEU_PK);
            if (_DanhmuchanghoaEntity != null && MessageBox.Show("Xóa hàng hóa: " + MAHIEU_PK + " - " + txt_MAKHACH.Text, "Xóa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) ==
                   System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                    _DanhmuchanghoaManager.Delete(MAHIEU_PK);
                    GRID_DMHANGHOA.CurrentRow.Delete();
                    BS_DMHANGHOA_CurrentChanged(new object(), new EventArgs());
                    GD.FM.LIB.TrayPopup.PoupStringMessage("Thông báo", "Đã xóa thành công!");
                    GD.FM.BLL.MenuroleManager.set_Enable_controls(_DanhmuchanghoaManager.Convert(_DanhmuchanghoaEntity), GD.FM.LIB.BUTTONACTION.BUTTONACTION_DELETE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
                }
                catch
                {
                    MessageBox.Show("Không thể xóa hàng hóa " + MAHIEU_PK + "!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            GRID_DMHANGHOA.Enabled = true;
        }
        private void btn_LUULAI_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(MAHIEU_PK) && _DanhmuchanghoaManager.SelectOne(txt_MAHIEU.Text.Trim()) != null)
            {
                MessageBox.Show("Mã hàng hóa bị trùng! \nNhập lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_MAHIEU.Focus();
                return;
            }
            else if (txt_MAHIEU.Text == "")
            {
                MessageBox.Show("Yêu cầu nhập mã hàng hóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_MAHIEU.Focus();
                return;
            }
            else if (txt_MAKHACH.Text == "")
            {
                MessageBox.Show("Yêu cầu nhập tên hàng hóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_MAKHACH.Focus();
                return;
            }
            else
            {
                GD.FM.LIB.FORM_PROCESS_UTIL.enableControls(false, uiPanel1Container, null);
                MAHIEU_PK = Save_Data(MAHIEU_PK);
                GD.FM.LIB.TrayPopup.PoupStringMessage("Thông báo", "Lưu lại thành công");
                GRID_DMHANGHOA.Enabled = true;
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
                GRID_DMHANGHOA.ColumnAutoResize = true;
            else
                GRID_DMHANGHOA.ColumnAutoResize = false;
        }

        private void FRM_DMHANGHOA_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textbox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FRM_DMHANGHOA_FormClosing(object sender, FormClosingEventArgs e)
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
