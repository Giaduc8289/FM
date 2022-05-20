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
    public partial class FRM_DMCANG : FRM_DMPARENT
    {
        private DanhmuccangManager _DanhmuccangManager = new DanhmuccangManager();
        private DanhmuccangEntity _DanhmuccangEntity = new DanhmuccangEntity();
        private MenuroleEntity _MenuroleEntity = new MenuroleEntity();
        private DataTable DT_DMCANG = new DataTable();
        private BindingSource BS_DMCANG = new BindingSource();
        private DataRow r_Insert = null, _RowViewSelect = null;
        private GD.FM.CONTROL.JGridEX GRID_DMCANG = new GD.FM.CONTROL.JGridEX();
        private string FUNCTION = "LOAD", MAHIEU_PK = "";

        private DataTable DT_DMQUOCGIA = new DataTable();

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
                        _MenuroleEntity = MenuroleManager.Return_Current_Menurole("FRM_DMCANG");
                        DT_DMCANG = LIB.SESSION_START.DT_DMCANG;

                        DT_DMQUOCGIA = LIB.SESSION_START.DT_DMQUOCGIA;
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

        public FRM_DMCANG()
        {
            InitializeComponent();
            DanhmuccangManager _DanhmuccangManager = new DanhmuccangManager();
            DataTable dt111 = _DanhmuccangManager.Clone();
           // GD.FM.LIB.GRID_COMM.Create_GRID_CONIG(dt111, LIB.PATH.FM_PATH + @"\XMLCONFIG\FRM_DMCANG.xml");
            GD.FM.LIB.FORM_PROCESS_UTIL.enableControls(false, uiPanel1Container, null);
            GD.FM.CONTROL.BUTTON.Loadimage(LIB.PATH.FM_PATH, btn_LUULAI, btn_LUULAI.Name + ".xml");
            GD.FM.CONTROL.BUTTON.Loadimage(LIB.PATH.FM_PATH, btn_SUA, btn_SUA.Name + ".xml");
            GD.FM.CONTROL.BUTTON.Loadimage(LIB.PATH.FM_PATH, btn_THEMMOI, btn_THEMMOI.Name + ".xml");
            GD.FM.CONTROL.BUTTON.Loadimage(LIB.PATH.FM_PATH, btn_XOA, btn_XOA.Name + ".xml");
            GD.FM.CONTROL.BUTTON.Loadimage(LIB.PATH.FM_PATH, btn_KHOIPHUC, btn_KHOIPHUC.Name + ".xml");
            GD.FM.CONTROL.BUTTON.Loadimage(LIB.PATH.FM_PATH, btn_Thoat, btn_Thoat.Name + ".xml");
            GD.FM.LIB.GRID_COMM.LOAD_GRID_UIPanel(LIB.PATH.FM_PATH + @"\XMLCONFIG\FRM_DMCANG.xml", GRID_DMCANG, uiPanel0Container);
            FORM_PROCESS();
            DataView Source_View = new DataView(DT_DMCANG);
            BS_DMCANG = new BindingSource();
            BS_DMCANG.DataSource = Source_View;
            GRID_DMCANG.DataSource = BS_DMCANG;
            BS_DMCANG.CurrentChanged += new EventHandler(BS_DMCANG_CurrentChanged);
            BS_DMCANG_CurrentChanged((new object()), (new EventArgs()));
            GD.FM.BLL.MenuroleManager.set_Enable_controls(GD.FM.LIB.BUTTONACTION.BUTTONACTION_LOAD, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            Application.ThreadException += new System.Threading.ThreadExceptionEventHandler(Application_ThreadException);
            btn_THEMMOI.Focus();
        }

        void BS_DMCANG_CurrentChanged(object sender, EventArgs e)
        {
            try
            {
                GD.FM.LIB.FORM_PROCESS_UTIL.clearControls(uiPanel1Container, GD.FM.LIB.FORM_PROCESS_UTIL.getAllControl(uiPanel1Container));
                if (BS_DMCANG.Current != null)
                {
                    DataRowView _Rowview = (DataRowView)this.BS_DMCANG.Current;
                    if (_Rowview != null)
                        MAHIEU_PK = _Rowview.Row[DanhmuccangFields.Mahieu.Name].ToString();
                    txt_MAHIEU.Text = _Rowview.Row[DanhmuccangFields.Mahieu.Name].ToString();
                    txt_TENHIEU.Text = _Rowview.Row[DanhmuccangFields.Tenhieu.Name].ToString();
                    txt_TENRUTGON.Text = _Rowview.Row[DanhmuccangFields.Tenrutgon.Name].ToString();
                    txt_MAQUOCGIA.Text = _Rowview.Row[DanhmuccangFields.Maquocgia.Name].ToString();

                    txt_MAQUOCGIA_Validating(new object(), new CancelEventArgs());
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "BS_DMCANG_CurrentChanged"); }
        }

        private string Save_Data(string _str_DMCHUONG_PK)
        {
            DanhmuccangEntity _DanhmuccangEntity = new DanhmuccangEntity();
            _DanhmuccangEntity.Mahieu = txt_MAHIEU.Text.Trim();
            _DanhmuccangEntity.Tenhieu = txt_TENHIEU.Text.Trim();
            _DanhmuccangEntity.Tenrutgon = txt_TENRUTGON.Text.Trim();
            _DanhmuccangEntity.Maquocgia = txt_MAQUOCGIA.Text.Trim();
            _DanhmuccangEntity.Tenquocgia = txt_TENQUOCGIA.Text.Trim();
            if (string.IsNullOrEmpty(_str_DMCHUONG_PK))
            {
                _DanhmuccangEntity.Ngaytao = DateTime.Now;
                _DanhmuccangEntity.Nguoitao = LIB.SESSION_START.TS_USER_LOGIN;
                _str_DMCHUONG_PK = _DanhmuccangManager.InsertV2(_DanhmuccangEntity, r_Insert, DT_DMCANG, BS_DMCANG);
                 GD.FM.BLL.MenuroleManager.set_Enable_controls(_DanhmuccangManager.Convert(_DanhmuccangEntity), GD.FM.LIB.BUTTONACTION.BUTTONACTION_INSERT, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
                BS_DMCANG.ResetCurrentItem();
            }
            else
            {
                _DanhmuccangEntity.Ngaysua = DateTime.Now;
                _DanhmuccangEntity.Nguoisua = LIB.SESSION_START.TS_USER_LOGIN;
                _DanhmuccangManager.Update(_DanhmuccangEntity);
                GRID_DMCANG.CurrentRow.Cells[DanhmuccangFields.Mahieu.Name].Value = _DanhmuccangEntity.Mahieu;
                GRID_DMCANG.CurrentRow.Cells[DanhmuccangFields.Tenhieu.Name].Value = _DanhmuccangEntity.Tenhieu;
                GRID_DMCANG.CurrentRow.Cells[DanhmuccangFields.Tenrutgon.Name].Value = _DanhmuccangEntity.Tenrutgon;
                GRID_DMCANG.CurrentRow.Cells[DanhmuccangFields.Maquocgia.Name].Value = _DanhmuccangEntity.Maquocgia;
                GRID_DMCANG.CurrentRow.Cells[DanhmuccangFields.Tenquocgia.Name].Value = _DanhmuccangEntity.Tenquocgia;
                GD.FM.BLL.MenuroleManager.set_Enable_controls(_DanhmuccangManager.Convert(_DanhmuccangEntity), GD.FM.LIB.BUTTONACTION.BUTTONACTION_UPDATE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            }
            return _str_DMCHUONG_PK;
        }

        #region Button
        private void btn_THEMMOI_Click(object sender, EventArgs e)
        {
            GD.FM.LIB.FORM_PROCESS_UTIL.enableControls(true, uiPanel1Container, new List<Control>(new Control[] { }));
            txt_TENQUOCGIA.Text = string.Empty;
            DanhmuccangManager _DanhmuccangManager = new DanhmuccangManager();
            DanhmuccangEntity _DanhmuccangEntity = new DanhmuccangEntity();
            r_Insert = DT_DMCANG.NewRow();
            DT_DMCANG.Rows.Add(r_Insert);
            BS_DMCANG.Position = DT_DMCANG.Rows.Count;
            MAHIEU_PK = "";
            txt_MAHIEU.Focus();
            TEXTBOX_Only_Control(false, null);
            GD.FM.LIB.FORM_PROCESS_UTIL.enableControls(true, uiPanel1Container, new List<Control>(new Control[] { txt_TENQUOCGIA}));
            GD.FM.BLL.MenuroleManager.set_Enable_controls(GD.FM.LIB.BUTTONACTION.BUTTONACTION_THEMMOI, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            GRID_DMCANG.Enabled = false;
        }
        private void btn_SUA_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(MAHIEU_PK)) { return; }
            else
            {
                GD.FM.BLL.MenuroleManager.set_Enable_controls(GD.FM.LIB.BUTTONACTION.BUTTONACTION_SUA, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
                GD.FM.LIB.FORM_PROCESS_UTIL.enableControls(true, uiPanel1Container, new List<Control>(new Control[] { txt_MAHIEU, txt_TENQUOCGIA }));
                txt_TENHIEU.Focus();
            }
            GRID_DMCANG.Enabled = false;
        }
        private void btn_KHOIPHUC_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(MAHIEU_PK) && r_Insert != null)
            {
                DT_DMCANG.Rows.Remove(r_Insert);
            }
            BS_DMCANG_CurrentChanged(new object(), new EventArgs());
            GD.FM.BLL.MenuroleManager.set_Enable_controls(GD.FM.LIB.BUTTONACTION.BUTTONACTION_CANCEL, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            FORM_PROCESS_UTIL.enableControls(false, uiPanel1Container, new List<Control>(new Control[] { }));
            GRID_DMCANG.Enabled = true;
        }
        private void btn_XOA_Click(object sender, EventArgs e)
        {
            GD.FM.LIB.FORM_PROCESS_UTIL.enableControls(false, uiPanel1Container, null);
            if (string.IsNullOrEmpty(MAHIEU_PK)) return;
            DanhmuccangManager _DanhmuccangManager = new DanhmuccangManager();
            DanhmuccangEntity _DanhmuccangEntity = new DanhmuccangEntity();
            _DanhmuccangEntity = _DanhmuccangManager.SelectOne(MAHIEU_PK);
            if (_DanhmuccangEntity != null && MessageBox.Show("Xóa cảng: " + MAHIEU_PK + " - " + txt_TENHIEU.Text, "Xóa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) ==
                   System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                    _DanhmuccangManager.Delete(MAHIEU_PK);
                    GRID_DMCANG.CurrentRow.Delete();
                    BS_DMCANG_CurrentChanged(new object(), new EventArgs());
                    //GD.FM.LIB.TrayPopup.PoupStringMessage(GD.FM.APP.Properties.Resources.MessageTitle, GD.FM.APP.Properties.Resources.MessageContent_T);
                    GD.FM.LIB.TrayPopup.PoupStringMessage("Thông báo", "Đã xóa thành công!");
                    GD.FM.BLL.MenuroleManager.set_Enable_controls(_DanhmuccangManager.Convert(_DanhmuccangEntity), GD.FM.LIB.BUTTONACTION.BUTTONACTION_DELETE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
                }
                catch
                {
                    MessageBox.Show("Không thể xóa cảng " + MAHIEU_PK + "!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            GRID_DMCANG.Enabled = true;
        }
        private void btn_LUULAI_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(MAHIEU_PK) && _DanhmuccangManager.SelectOne(txt_MAHIEU.Text.Trim()) != null)
            {
                MessageBox.Show("Mã cảng bị trùng! \nNhập lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_MAHIEU.Focus();
                return;
            }
            else if (txt_MAHIEU.Text == "")
            {
                MessageBox.Show("Yêu cầu nhập mã cảng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_MAHIEU.Focus();
                return;
            }
            else if (txt_TENHIEU.Text == "")
            {
                MessageBox.Show("Yêu cầu nhập cảng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_TENHIEU.Focus();
                return;
            }
            else
            {
                GD.FM.LIB.FORM_PROCESS_UTIL.enableControls(false, uiPanel1Container, null);
                MAHIEU_PK = Save_Data(MAHIEU_PK);
                GD.FM.LIB.TrayPopup.PoupStringMessage("Thông báo", "Lưu lại thành công");
                GRID_DMCANG.Enabled = true;
                btn_THEMMOI.Focus();
            }
        }
        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion

        #region Validate
        private void txt_MAQUOCGIA_Validating(object sender, CancelEventArgs e)
        {
            _RowViewSelect = null;
            if (string.IsNullOrEmpty(txt_MAQUOCGIA.Text.Trim()) || DT_DMQUOCGIA == null || DT_DMQUOCGIA.Rows.Count == 0) return;
            string Str_MASIEUTHI = txt_MAQUOCGIA.Text.Trim().ToUpper();
            _RowViewSelect = checkmaPhongban(Str_MASIEUTHI, DT_DMQUOCGIA);
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
            }
            else
                txt_TENQUOCGIA.Text = _RowViewSelect[DanhmucquocgiaFields.Tenhieu.Name].ToString();
        }
        private DataRow checkmaPhongban(string masieuthi, DataTable dt)
        {
            try
            {
                return dt.Select(DanhmucquocgiaFields.Mahieu.Name + "=" + "'" + masieuthi + "'").CopyToDataTable().Rows[0];
            }
            catch { return null; }
        }
        #endregion

        #region Shortcut Key
        private void txt_MAQUOCGIA_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.F4)
            {
                FRM_DMQUOCGIA frm_Dm = new FRM_DMQUOCGIA();
                frm_Dm.Text = "Danh mục Quốc gia";
                frm_Dm.ShowDialog();
                DT_DMQUOCGIA = new DanhmucquocgiaManager().SelectAllRDT();
            }
        }
        #endregion

        private void FRM_DMCANG_FormClosing(object sender, FormClosingEventArgs e)
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
