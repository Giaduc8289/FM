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
    public partial class FRM_DMPTVANCHUYEN : FRM_DMPARENT
    {
        private PhuongthucvanchuyenManager _PhuongthucvanchuyenManager = new PhuongthucvanchuyenManager();
        private PhuongthucvanchuyenEntity _PhuongthucvanchuyenEntity = new PhuongthucvanchuyenEntity();
        private MenuroleEntity _MenuroleEntity = new MenuroleEntity();
        private DataTable DT_DMPTVANCHUYEN = new DataTable();
        private BindingSource BS_DMPTVANCHUYEN = new BindingSource();
        private DataRow r_Insert = null;
        private GD.FM.CONTROL.JGridEX GRID_DMPTVANCHUYEN = new GD.FM.CONTROL.JGridEX();
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
                        _MenuroleEntity = MenuroleManager.Return_Current_Menurole("FRM_DMPTVANCHUYEN");
                        DT_DMPTVANCHUYEN = LIB.SESSION_START.DT_DMPTVANCHUYEN;
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

        public FRM_DMPTVANCHUYEN()
        {
            InitializeComponent();
            PhuongthucvanchuyenManager _PhuongthucvanchuyenManager = new PhuongthucvanchuyenManager();
            DataTable dt111 = _PhuongthucvanchuyenManager.Clone();
           // GD.FM.LIB.GRID_COMM.Create_GRID_CONIG(dt111, LIB.PATH.FM_PATH + @"\XMLCONFIG\FRM_DMPTVANCHUYEN.xml");
            GD.FM.LIB.FORM_PROCESS_UTIL.enableControls(false, uiPanel1Container, null);
            GD.FM.CONTROL.BUTTON.Loadimage(LIB.PATH.FM_PATH, btn_LUULAI, btn_LUULAI.Name + ".xml");
            GD.FM.CONTROL.BUTTON.Loadimage(LIB.PATH.FM_PATH, btn_SUA, btn_SUA.Name + ".xml");
            GD.FM.CONTROL.BUTTON.Loadimage(LIB.PATH.FM_PATH, btn_THEMMOI, btn_THEMMOI.Name + ".xml");
            GD.FM.CONTROL.BUTTON.Loadimage(LIB.PATH.FM_PATH, btn_XOA, btn_XOA.Name + ".xml");
            GD.FM.CONTROL.BUTTON.Loadimage(LIB.PATH.FM_PATH, btn_KHOIPHUC, btn_KHOIPHUC.Name + ".xml");
            GD.FM.CONTROL.BUTTON.Loadimage(LIB.PATH.FM_PATH, btn_Thoat, btn_Thoat.Name + ".xml");
            GD.FM.LIB.GRID_COMM.LOAD_GRID_UIPanel(LIB.PATH.FM_PATH + @"\XMLCONFIG\FRM_DMPTVANCHUYEN.xml", GRID_DMPTVANCHUYEN, uiPanel0Container);
            FORM_PROCESS();
            DataView Source_View = new DataView(DT_DMPTVANCHUYEN);
            BS_DMPTVANCHUYEN = new BindingSource();
            BS_DMPTVANCHUYEN.DataSource = Source_View;
            GRID_DMPTVANCHUYEN.DataSource = BS_DMPTVANCHUYEN;
            BS_DMPTVANCHUYEN.CurrentChanged += new EventHandler(BS_DMPTVANCHUYEN_CurrentChanged);
            BS_DMPTVANCHUYEN_CurrentChanged((new object()), (new EventArgs()));
            GD.FM.BLL.MenuroleManager.set_Enable_controls(GD.FM.LIB.BUTTONACTION.BUTTONACTION_LOAD, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            Application.ThreadException += new System.Threading.ThreadExceptionEventHandler(Application_ThreadException);
            btn_THEMMOI.Focus();
        }

        void BS_DMPTVANCHUYEN_CurrentChanged(object sender, EventArgs e)
        {
            try
            {
                GD.FM.LIB.FORM_PROCESS_UTIL.clearControls(uiPanel1Container, GD.FM.LIB.FORM_PROCESS_UTIL.getAllControl(uiPanel1Container));
                if (BS_DMPTVANCHUYEN.Current != null)
                {
                    DataRowView _Rowview = (DataRowView)this.BS_DMPTVANCHUYEN.Current;
                    if (_Rowview != null)
                        MAHIEU_PK = _Rowview.Row[PhuongthucvanchuyenFields.Mahieu.Name].ToString();
                    txt_MAHIEU.Text = _Rowview.Row[PhuongthucvanchuyenFields.Mahieu.Name].ToString();
                    txt_TENHIEU.Text = _Rowview.Row[PhuongthucvanchuyenFields.Tenhieu.Name].ToString();
                    txt_TENRUTGON.Text = _Rowview.Row[PhuongthucvanchuyenFields.Tenrutgon.Name].ToString();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "BS_DMPTVANCHUYEN_CurrentChanged"); }
        }

        private string Save_Data(string _str_DMCHUONG_PK)
        {
            PhuongthucvanchuyenEntity _PhuongthucvanchuyenEntity = new PhuongthucvanchuyenEntity();
            _PhuongthucvanchuyenEntity.Mahieu = txt_MAHIEU.Text.Trim();
            _PhuongthucvanchuyenEntity.Tenhieu = txt_TENHIEU.Text.Trim();
            _PhuongthucvanchuyenEntity.Tenrutgon = txt_TENRUTGON.Text.Trim();
            if (string.IsNullOrEmpty(_str_DMCHUONG_PK))
            {
                _PhuongthucvanchuyenEntity.Ngaytao = DateTime.Now;
                _PhuongthucvanchuyenEntity.Nguoitao = LIB.SESSION_START.TS_USER_LOGIN;
                _str_DMCHUONG_PK = _PhuongthucvanchuyenManager.InsertV2(_PhuongthucvanchuyenEntity, r_Insert, DT_DMPTVANCHUYEN, BS_DMPTVANCHUYEN);
                 GD.FM.BLL.MenuroleManager.set_Enable_controls(_PhuongthucvanchuyenManager.Convert(_PhuongthucvanchuyenEntity), GD.FM.LIB.BUTTONACTION.BUTTONACTION_INSERT, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
                BS_DMPTVANCHUYEN.ResetCurrentItem();
            }
            else
            {
                _PhuongthucvanchuyenEntity.Ngaysua = DateTime.Now;
                _PhuongthucvanchuyenEntity.Nguoisua = LIB.SESSION_START.TS_USER_LOGIN;
                _PhuongthucvanchuyenManager.Update(_PhuongthucvanchuyenEntity);
                GRID_DMPTVANCHUYEN.CurrentRow.Cells[PhuongthucvanchuyenFields.Mahieu.Name].Value = _PhuongthucvanchuyenEntity.Mahieu;
                GRID_DMPTVANCHUYEN.CurrentRow.Cells[PhuongthucvanchuyenFields.Tenhieu.Name].Value = _PhuongthucvanchuyenEntity.Tenhieu;
                GRID_DMPTVANCHUYEN.CurrentRow.Cells[PhuongthucvanchuyenFields.Tenrutgon.Name].Value = _PhuongthucvanchuyenEntity.Tenrutgon;
                GD.FM.BLL.MenuroleManager.set_Enable_controls(_PhuongthucvanchuyenManager.Convert(_PhuongthucvanchuyenEntity), GD.FM.LIB.BUTTONACTION.BUTTONACTION_UPDATE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            }
            return _str_DMCHUONG_PK;
        }

        #region Button
        private void btn_THEMMOI_Click(object sender, EventArgs e)
        {
            GD.FM.LIB.FORM_PROCESS_UTIL.enableControls(true, uiPanel1Container, new List<Control>(new Control[] { }));
            PhuongthucvanchuyenManager _PhuongthucvanchuyenManager = new PhuongthucvanchuyenManager();
            PhuongthucvanchuyenEntity _PhuongthucvanchuyenEntity = new PhuongthucvanchuyenEntity();
            r_Insert = DT_DMPTVANCHUYEN.NewRow();
            DT_DMPTVANCHUYEN.Rows.Add(r_Insert);
            BS_DMPTVANCHUYEN.Position = DT_DMPTVANCHUYEN.Rows.Count;
            MAHIEU_PK = "";
            txt_MAHIEU.Focus();
            TEXTBOX_Only_Control(false, null);
            GD.FM.LIB.FORM_PROCESS_UTIL.enableControls(true, uiPanel1Container, new List<Control>(new Control[] { }));
            GD.FM.BLL.MenuroleManager.set_Enable_controls(GD.FM.LIB.BUTTONACTION.BUTTONACTION_THEMMOI, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            GRID_DMPTVANCHUYEN.Enabled = false;
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
            GRID_DMPTVANCHUYEN.Enabled = false;
        }
        private void btn_KHOIPHUC_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(MAHIEU_PK) && r_Insert != null)
            {
                DT_DMPTVANCHUYEN.Rows.Remove(r_Insert);
            }
            BS_DMPTVANCHUYEN_CurrentChanged(new object(), new EventArgs());
            GD.FM.BLL.MenuroleManager.set_Enable_controls(GD.FM.LIB.BUTTONACTION.BUTTONACTION_CANCEL, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            FORM_PROCESS_UTIL.enableControls(false, uiPanel1Container, new List<Control>(new Control[] { }));
            GRID_DMPTVANCHUYEN.Enabled = true;
        }
        private void btn_XOA_Click(object sender, EventArgs e)
        {
            GD.FM.LIB.FORM_PROCESS_UTIL.enableControls(false, uiPanel1Container, null);
            if (string.IsNullOrEmpty(MAHIEU_PK)) return;
            PhuongthucvanchuyenManager _PhuongthucvanchuyenManager = new PhuongthucvanchuyenManager();
            PhuongthucvanchuyenEntity _PhuongthucvanchuyenEntity = new PhuongthucvanchuyenEntity();
            _PhuongthucvanchuyenEntity = _PhuongthucvanchuyenManager.SelectOne(MAHIEU_PK);
            if (_PhuongthucvanchuyenEntity != null && MessageBox.Show("Xóa phương thức: " + MAHIEU_PK + " - " + txt_TENHIEU.Text, "Xóa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) ==
                   System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                    _PhuongthucvanchuyenManager.Delete(MAHIEU_PK);
                    GRID_DMPTVANCHUYEN.CurrentRow.Delete();
                    BS_DMPTVANCHUYEN_CurrentChanged(new object(), new EventArgs());
                    //GD.FM.LIB.TrayPopup.PoupStringMessage(GD.FM.APP.Properties.Resources.MessageTitle, GD.FM.APP.Properties.Resources.MessageContent_T);
                    GD.FM.LIB.TrayPopup.PoupStringMessage("Thông báo", "Đã xóa thành công!");
                    GD.FM.BLL.MenuroleManager.set_Enable_controls(_PhuongthucvanchuyenManager.Convert(_PhuongthucvanchuyenEntity), GD.FM.LIB.BUTTONACTION.BUTTONACTION_DELETE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
                }
                catch
                {
                    MessageBox.Show("Không thể xóa phương thức " + MAHIEU_PK + "!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            GRID_DMPTVANCHUYEN.Enabled = true;
        }
        private void btn_LUULAI_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(MAHIEU_PK) && _PhuongthucvanchuyenManager.SelectOne(txt_MAHIEU.Text.Trim()) != null)
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
                GRID_DMPTVANCHUYEN.Enabled = true;
                btn_THEMMOI.Focus();
            }
        }
        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion

        private void FRM_DMPTVANCHUYEN_FormClosing(object sender, FormClosingEventArgs e)
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
