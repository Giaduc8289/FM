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
    public partial class FRM_DMPTTHANHTOAN : FRM_DMPARENT
    {
        private PhuongthucthanhtoanManager _PhuongthucthanhtoanManager = new PhuongthucthanhtoanManager();
        private PhuongthucthanhtoanEntity _PhuongthucthanhtoanEntity = new PhuongthucthanhtoanEntity();
        private MenuroleEntity _MenuroleEntity = new MenuroleEntity();
        private DataTable DT_DMPTTHANHTOAN = new DataTable();
        private BindingSource BS_DMPTTHANHTOAN = new BindingSource();
        private DataRow r_Insert = null;
        private GD.FM.CONTROL.JGridEX GRID_DMPTTHANHTOAN = new GD.FM.CONTROL.JGridEX();
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
                        _MenuroleEntity = MenuroleManager.Return_Current_Menurole("FRM_DMPTTHANHTOAN");
                        DT_DMPTTHANHTOAN = LIB.SESSION_START.DT_DMPTTHANHTOAN;
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

        public FRM_DMPTTHANHTOAN()
        {
            InitializeComponent();
            PhuongthucthanhtoanManager _PhuongthucthanhtoanManager = new PhuongthucthanhtoanManager();
            DataTable dt111 = _PhuongthucthanhtoanManager.Clone();
           // GD.FM.LIB.GRID_COMM.Create_GRID_CONIG(dt111, LIB.PATH.FM_PATH + @"\XMLCONFIG\FRM_DMPTTHANHTOAN.xml");
            GD.FM.LIB.FORM_PROCESS_UTIL.enableControls(false, uiPanel1Container, null);
            GD.FM.CONTROL.BUTTON.Loadimage(LIB.PATH.FM_PATH, btn_LUULAI, btn_LUULAI.Name + ".xml");
            GD.FM.CONTROL.BUTTON.Loadimage(LIB.PATH.FM_PATH, btn_SUA, btn_SUA.Name + ".xml");
            GD.FM.CONTROL.BUTTON.Loadimage(LIB.PATH.FM_PATH, btn_THEMMOI, btn_THEMMOI.Name + ".xml");
            GD.FM.CONTROL.BUTTON.Loadimage(LIB.PATH.FM_PATH, btn_XOA, btn_XOA.Name + ".xml");
            GD.FM.CONTROL.BUTTON.Loadimage(LIB.PATH.FM_PATH, btn_KHOIPHUC, btn_KHOIPHUC.Name + ".xml");
            GD.FM.CONTROL.BUTTON.Loadimage(LIB.PATH.FM_PATH, btn_Thoat, btn_Thoat.Name + ".xml");
            GD.FM.LIB.GRID_COMM.LOAD_GRID_UIPanel(LIB.PATH.FM_PATH + @"\XMLCONFIG\FRM_DMPTTHANHTOAN.xml", GRID_DMPTTHANHTOAN, uiPanel0Container);
            FORM_PROCESS();
            DataView Source_View = new DataView(DT_DMPTTHANHTOAN);
            BS_DMPTTHANHTOAN = new BindingSource();
            BS_DMPTTHANHTOAN.DataSource = Source_View;
            GRID_DMPTTHANHTOAN.DataSource = BS_DMPTTHANHTOAN;
            BS_DMPTTHANHTOAN.CurrentChanged += new EventHandler(BS_DMPTTHANHTOAN_CurrentChanged);
            BS_DMPTTHANHTOAN_CurrentChanged((new object()), (new EventArgs()));
            GD.FM.BLL.MenuroleManager.set_Enable_controls(GD.FM.LIB.BUTTONACTION.BUTTONACTION_LOAD, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            Application.ThreadException += new System.Threading.ThreadExceptionEventHandler(Application_ThreadException);
            btn_THEMMOI.Focus();
        }

        void BS_DMPTTHANHTOAN_CurrentChanged(object sender, EventArgs e)
        {
            try
            {
                GD.FM.LIB.FORM_PROCESS_UTIL.clearControls(uiPanel1Container, GD.FM.LIB.FORM_PROCESS_UTIL.getAllControl(uiPanel1Container));
                if (BS_DMPTTHANHTOAN.Current != null)
                {
                    DataRowView _Rowview = (DataRowView)this.BS_DMPTTHANHTOAN.Current;
                    if (_Rowview != null)
                        MAHIEU_PK = _Rowview.Row[PhuongthucthanhtoanFields.Mahieu.Name].ToString();
                    txt_MAHIEU.Text = _Rowview.Row[PhuongthucthanhtoanFields.Mahieu.Name].ToString();
                    txt_TENHIEU.Text = _Rowview.Row[PhuongthucthanhtoanFields.Tenhieu.Name].ToString();
                    txt_TENRUTGON.Text = _Rowview.Row[PhuongthucthanhtoanFields.Tenrutgon.Name].ToString();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "BS_DMPTTHANHTOAN_CurrentChanged"); }
        }

        private string Save_Data(string _str_DMCHUONG_PK)
        {
            PhuongthucthanhtoanEntity _PhuongthucthanhtoanEntity = new PhuongthucthanhtoanEntity();
            _PhuongthucthanhtoanEntity.Mahieu = txt_MAHIEU.Text.Trim();
            _PhuongthucthanhtoanEntity.Tenhieu = txt_TENHIEU.Text.Trim();
            _PhuongthucthanhtoanEntity.Tenrutgon = txt_TENRUTGON.Text.Trim();
            if (string.IsNullOrEmpty(_str_DMCHUONG_PK))
            {
                _PhuongthucthanhtoanEntity.Ngaytao = DateTime.Now;
                _PhuongthucthanhtoanEntity.Nguoitao = LIB.SESSION_START.TS_USER_LOGIN;
                _str_DMCHUONG_PK = _PhuongthucthanhtoanManager.InsertV2(_PhuongthucthanhtoanEntity, r_Insert, DT_DMPTTHANHTOAN, BS_DMPTTHANHTOAN);
                 GD.FM.BLL.MenuroleManager.set_Enable_controls(_PhuongthucthanhtoanManager.Convert(_PhuongthucthanhtoanEntity), GD.FM.LIB.BUTTONACTION.BUTTONACTION_INSERT, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
                BS_DMPTTHANHTOAN.ResetCurrentItem();
            }
            else
            {
                _PhuongthucthanhtoanEntity.Ngaysua = DateTime.Now;
                _PhuongthucthanhtoanEntity.Nguoisua = LIB.SESSION_START.TS_USER_LOGIN;
                _PhuongthucthanhtoanManager.Update(_PhuongthucthanhtoanEntity);
                GRID_DMPTTHANHTOAN.CurrentRow.Cells[PhuongthucthanhtoanFields.Mahieu.Name].Value = _PhuongthucthanhtoanEntity.Mahieu;
                GRID_DMPTTHANHTOAN.CurrentRow.Cells[PhuongthucthanhtoanFields.Tenhieu.Name].Value = _PhuongthucthanhtoanEntity.Tenhieu;
                GRID_DMPTTHANHTOAN.CurrentRow.Cells[PhuongthucthanhtoanFields.Tenrutgon.Name].Value = _PhuongthucthanhtoanEntity.Tenrutgon;
                GD.FM.BLL.MenuroleManager.set_Enable_controls(_PhuongthucthanhtoanManager.Convert(_PhuongthucthanhtoanEntity), GD.FM.LIB.BUTTONACTION.BUTTONACTION_UPDATE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            }
            return _str_DMCHUONG_PK;
        }

        #region Button
        private void btn_THEMMOI_Click(object sender, EventArgs e)
        {
            GD.FM.LIB.FORM_PROCESS_UTIL.enableControls(true, uiPanel1Container, new List<Control>(new Control[] { }));
            PhuongthucthanhtoanManager _PhuongthucthanhtoanManager = new PhuongthucthanhtoanManager();
            PhuongthucthanhtoanEntity _PhuongthucthanhtoanEntity = new PhuongthucthanhtoanEntity();
            r_Insert = DT_DMPTTHANHTOAN.NewRow();
            DT_DMPTTHANHTOAN.Rows.Add(r_Insert);
            BS_DMPTTHANHTOAN.Position = DT_DMPTTHANHTOAN.Rows.Count;
            MAHIEU_PK = "";
            txt_MAHIEU.Focus();
            TEXTBOX_Only_Control(false, null);
            GD.FM.LIB.FORM_PROCESS_UTIL.enableControls(true, uiPanel1Container, new List<Control>(new Control[] { }));
            GD.FM.BLL.MenuroleManager.set_Enable_controls(GD.FM.LIB.BUTTONACTION.BUTTONACTION_THEMMOI, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            GRID_DMPTTHANHTOAN.Enabled = false;
        }
        private void btn_SUA_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(MAHIEU_PK)) { return; }
            else
            {
                GD.FM.BLL.MenuroleManager.set_Enable_controls(GD.FM.LIB.BUTTONACTION.BUTTONACTION_SUA, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
                GD.FM.LIB.FORM_PROCESS_UTIL.enableControls(true, uiPanel1Container, new List<Control>(new Control[] { txt_MAHIEU }));
                txt_TENHIEU.Focus();
            }
            GRID_DMPTTHANHTOAN.Enabled = false;
        }
        private void btn_KHOIPHUC_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(MAHIEU_PK) && r_Insert != null)
            {
                DT_DMPTTHANHTOAN.Rows.Remove(r_Insert);
            }
            BS_DMPTTHANHTOAN_CurrentChanged(new object(), new EventArgs());
            GD.FM.BLL.MenuroleManager.set_Enable_controls(GD.FM.LIB.BUTTONACTION.BUTTONACTION_CANCEL, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            FORM_PROCESS_UTIL.enableControls(false, uiPanel1Container, new List<Control>(new Control[] { }));
            GRID_DMPTTHANHTOAN.Enabled = true;
        }
        private void btn_XOA_Click(object sender, EventArgs e)
        {
            GD.FM.LIB.FORM_PROCESS_UTIL.enableControls(false, uiPanel1Container, null);
            if (string.IsNullOrEmpty(MAHIEU_PK)) return;
            PhuongthucthanhtoanManager _PhuongthucthanhtoanManager = new PhuongthucthanhtoanManager();
            PhuongthucthanhtoanEntity _PhuongthucthanhtoanEntity = new PhuongthucthanhtoanEntity();
            _PhuongthucthanhtoanEntity = _PhuongthucthanhtoanManager.SelectOne(MAHIEU_PK);
            if (_PhuongthucthanhtoanEntity != null && MessageBox.Show("Xóa phương thức: " + MAHIEU_PK + " - " + txt_TENHIEU.Text, "Xóa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) ==
                   System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                    _PhuongthucthanhtoanManager.Delete(MAHIEU_PK);
                    GRID_DMPTTHANHTOAN.CurrentRow.Delete();
                    BS_DMPTTHANHTOAN_CurrentChanged(new object(), new EventArgs());
                    //GD.FM.LIB.TrayPopup.PoupStringMessage(GD.FM.APP.Properties.Resources.MessageTitle, GD.FM.APP.Properties.Resources.MessageContent_T);
                    GD.FM.LIB.TrayPopup.PoupStringMessage("Thông báo", "Đã xóa thành công!");
                    GD.FM.BLL.MenuroleManager.set_Enable_controls(_PhuongthucthanhtoanManager.Convert(_PhuongthucthanhtoanEntity), GD.FM.LIB.BUTTONACTION.BUTTONACTION_DELETE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
                }
                catch
                {
                    MessageBox.Show("Không thể xóa phương thức " + MAHIEU_PK + "!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            GRID_DMPTTHANHTOAN.Enabled = true;
        }
        private void btn_LUULAI_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(MAHIEU_PK) && _PhuongthucthanhtoanManager.SelectOne(txt_MAHIEU.Text.Trim()) != null)
            {
                MessageBox.Show("Mã phương thức bị trùng! \nNhập lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_MAHIEU.Focus();
                return;
            }
            else if (txt_MAHIEU.Text == "")
            {
                MessageBox.Show("Yêu cầu nhập mã phương thức!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_MAHIEU.Focus();
                return;
            }
            else if (txt_TENHIEU.Text == "")
            {
                MessageBox.Show("Yêu cầu nhập phương thức!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_TENHIEU.Focus();
                return;
            }
            else
            {
                GD.FM.LIB.FORM_PROCESS_UTIL.enableControls(false, uiPanel1Container, null);
                MAHIEU_PK = Save_Data(MAHIEU_PK);
                GD.FM.LIB.TrayPopup.PoupStringMessage("Thông báo", "Lưu lại thành công");
                GRID_DMPTTHANHTOAN.Enabled = true;
                btn_THEMMOI.Focus();
            }
        }
        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion

        private void FRM_DMPTTHANHTOAN_FormClosing(object sender, FormClosingEventArgs e)
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
