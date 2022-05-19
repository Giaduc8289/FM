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
    public partial class FRM_DMNGANHANG : FRM_DMPARENT
    {
        private DanhmucnganhangManager _DanhmucnganhangManager = new DanhmucnganhangManager();
        private DanhmucnganhangEntity _DanhmucnganhangEntity = new DanhmucnganhangEntity();
        private MenuroleEntity _MenuroleEntity = new MenuroleEntity();
        private DataTable DT_DMNGANHANG = new DataTable();
        private BindingSource BS_DMNGANHANG = new BindingSource();
        private DataRow r_Insert = null;
        private GD.FM.CONTROL.JGridEX GRID_DMNGANHANG = new GD.FM.CONTROL.JGridEX();
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
                Image _image = Image.FromFile(LIB.PATH.KDTM_PATH + @"\IMG\waiting.xml");
                _PictureBox.Image = _image;
                _PictureBox.Width = _image.Width;
                _PictureBox.Height = _image.Height;
                worker.DoWork += delegate
                {
                    if (FUNCTION == "LOAD")
                    {
                        _MenuroleEntity = MenuroleManager.Return_Current_Menurole("FRM_DMNGANHANG");
                        DT_DMNGANHANG = LIB.SESSION_START.DT_DMNGANHANG;
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

        public FRM_DMNGANHANG()
        {
            InitializeComponent();
            DanhmucnganhangManager _DanhmucnganhangManager = new DanhmucnganhangManager();
            DataTable dt111 = _DanhmucnganhangManager.Clone();
           // GD.FM.LIB.GRID_COMM.Create_GRID_CONIG(dt111, LIB.PATH.KDTM_PATH + @"\XMLCONFIG\FRM_DMNGANHANG.xml");
            GD.FM.LIB.FORM_PROCESS_UTIL.enableControls(false, uiPanel1Container, null);
            GD.FM.CONTROL.BUTTON.Loadimage(LIB.PATH.KDTM_PATH, btn_LUULAI, btn_LUULAI.Name + ".xml");
            GD.FM.CONTROL.BUTTON.Loadimage(LIB.PATH.KDTM_PATH, btn_SUA, btn_SUA.Name + ".xml");
            GD.FM.CONTROL.BUTTON.Loadimage(LIB.PATH.KDTM_PATH, btn_THEMMOI, btn_THEMMOI.Name + ".xml");
            GD.FM.CONTROL.BUTTON.Loadimage(LIB.PATH.KDTM_PATH, btn_XOA, btn_XOA.Name + ".xml");
            GD.FM.CONTROL.BUTTON.Loadimage(LIB.PATH.KDTM_PATH, btn_KHOIPHUC, btn_KHOIPHUC.Name + ".xml");
            GD.FM.CONTROL.BUTTON.Loadimage(LIB.PATH.KDTM_PATH, btn_Thoat, btn_Thoat.Name + ".xml");
            GD.FM.LIB.GRID_COMM.LOAD_GRID_UIPanel(LIB.PATH.KDTM_PATH + @"\XMLCONFIG\FRM_DMNGANHANG.xml", GRID_DMNGANHANG, uiPanel0Container);
            FORM_PROCESS();
            DataView Source_View = new DataView(DT_DMNGANHANG);
            BS_DMNGANHANG = new BindingSource();
            BS_DMNGANHANG.DataSource = Source_View;
            GRID_DMNGANHANG.DataSource = BS_DMNGANHANG;
            BS_DMNGANHANG.CurrentChanged += new EventHandler(BS_DMNGANHANG_CurrentChanged);
            BS_DMNGANHANG_CurrentChanged((new object()), (new EventArgs()));
            GD.FM.BLL.MenuroleManager.set_Enable_controls(GD.FM.LIB.BUTTONACTION.BUTTONACTION_LOAD, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            Application.ThreadException += new System.Threading.ThreadExceptionEventHandler(Application_ThreadException);
            btn_THEMMOI.Focus();
        }

        void BS_DMNGANHANG_CurrentChanged(object sender, EventArgs e)
        {
            try
            {
                GD.FM.LIB.FORM_PROCESS_UTIL.clearControls(uiPanel1Container, GD.FM.LIB.FORM_PROCESS_UTIL.getAllControl(uiPanel1Container));
                if (BS_DMNGANHANG.Current != null)
                {
                    DataRowView _Rowview = (DataRowView)this.BS_DMNGANHANG.Current;
                    if (_Rowview != null)
                        MAHIEU_PK = _Rowview.Row[DanhmucnganhangFields.Mahieu.Name].ToString();
                    txt_MAHIEU.Text = _Rowview.Row[DanhmucnganhangFields.Mahieu.Name].ToString();
                    txt_AccountHolder.Text = _Rowview.Row[DanhmucnganhangFields.AccountHolder.Name].ToString();
                    txt_Bank.Text = _Rowview.Row[DanhmucnganhangFields.Bank.Name].ToString();
                    txt_Address.Text = _Rowview.Row[DanhmucnganhangFields.Address.Name].ToString();
                    txt_Accountnumber.Text = _Rowview.Row[DanhmucnganhangFields.Accountnumber.Name].ToString();
                    txt_Swift.Text = _Rowview.Row[DanhmucnganhangFields.Swift.Name].ToString();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "BS_DMNGANHANG_CurrentChanged"); }
        }

        private string Save_Data(string _str_DMCHUONG_PK)
        {
            DanhmucnganhangEntity _DanhmucnganhangEntity = new DanhmucnganhangEntity();
            _DanhmucnganhangEntity.Mahieu = txt_MAHIEU.Text.Trim();
            _DanhmucnganhangEntity.AccountHolder = txt_AccountHolder.Text.Trim();
            _DanhmucnganhangEntity.Bank = txt_Bank.Text.Trim();
            _DanhmucnganhangEntity.Address = txt_Address.Text.Trim();
            _DanhmucnganhangEntity.Accountnumber = txt_Accountnumber.Text.Trim();
            _DanhmucnganhangEntity.Swift = txt_Swift.Text.Trim();
            if (string.IsNullOrEmpty(_str_DMCHUONG_PK))
            {
                _DanhmucnganhangEntity.Ngaytao = DateTime.Now;
                _DanhmucnganhangEntity.Nguoitao = LIB.SESSION_START.TS_USER_LOGIN;
                _str_DMCHUONG_PK = _DanhmucnganhangManager.InsertV2(_DanhmucnganhangEntity, r_Insert, DT_DMNGANHANG, BS_DMNGANHANG);
                 GD.FM.BLL.MenuroleManager.set_Enable_controls(_DanhmucnganhangManager.Convert(_DanhmucnganhangEntity), GD.FM.LIB.BUTTONACTION.BUTTONACTION_INSERT, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
                BS_DMNGANHANG.ResetCurrentItem();
            }
            else
            {
                _DanhmucnganhangEntity.Ngaysua = DateTime.Now;
                _DanhmucnganhangEntity.Nguoisua = LIB.SESSION_START.TS_USER_LOGIN;
                _DanhmucnganhangManager.Update(_DanhmucnganhangEntity);
                GRID_DMNGANHANG.CurrentRow.Cells[DanhmucnganhangFields.Mahieu.Name].Value = _DanhmucnganhangEntity.Mahieu;
                GRID_DMNGANHANG.CurrentRow.Cells[DanhmucnganhangFields.AccountHolder.Name].Value = _DanhmucnganhangEntity.AccountHolder;
                GRID_DMNGANHANG.CurrentRow.Cells[DanhmucnganhangFields.Bank.Name].Value = _DanhmucnganhangEntity.Bank;
                GRID_DMNGANHANG.CurrentRow.Cells[DanhmucnganhangFields.Address.Name].Value = _DanhmucnganhangEntity.Address;
                GRID_DMNGANHANG.CurrentRow.Cells[DanhmucnganhangFields.Accountnumber.Name].Value = _DanhmucnganhangEntity.Accountnumber;
                GRID_DMNGANHANG.CurrentRow.Cells[DanhmucnganhangFields.Swift.Name].Value = _DanhmucnganhangEntity.Swift;
                GD.FM.BLL.MenuroleManager.set_Enable_controls(_DanhmucnganhangManager.Convert(_DanhmucnganhangEntity), GD.FM.LIB.BUTTONACTION.BUTTONACTION_UPDATE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            }
            return _str_DMCHUONG_PK;
        }

        #region Button
        private void btn_THEMMOI_Click(object sender, EventArgs e)
        {
            GD.FM.LIB.FORM_PROCESS_UTIL.enableControls(true, uiPanel1Container, new List<Control>(new Control[] { }));
            DanhmucnganhangManager _DanhmucnganhangManager = new DanhmucnganhangManager();
            DanhmucnganhangEntity _DanhmucnganhangEntity = new DanhmucnganhangEntity();
            r_Insert = DT_DMNGANHANG.NewRow();
            DT_DMNGANHANG.Rows.Add(r_Insert);
            BS_DMNGANHANG.Position = DT_DMNGANHANG.Rows.Count;
            MAHIEU_PK = "";
            txt_MAHIEU.Focus();
            TEXTBOX_Only_Control(false, null);
            GD.FM.LIB.FORM_PROCESS_UTIL.enableControls(true, uiPanel1Container, new List<Control>(new Control[] { }));
            GD.FM.BLL.MenuroleManager.set_Enable_controls(GD.FM.LIB.BUTTONACTION.BUTTONACTION_THEMMOI, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            GRID_DMNGANHANG.Enabled = false;
        }
        private void btn_SUA_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(MAHIEU_PK)) { return; }
            else
            {
                GD.FM.BLL.MenuroleManager.set_Enable_controls(GD.FM.LIB.BUTTONACTION.BUTTONACTION_SUA, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
                GD.FM.LIB.FORM_PROCESS_UTIL.enableControls(true, uiPanel1Container, new List<Control>(new Control[] { txt_MAHIEU }));
                txt_AccountHolder.Focus();
            }
            GRID_DMNGANHANG.Enabled = false;
        }
        private void btn_KHOIPHUC_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(MAHIEU_PK) && r_Insert != null)
            {
                DT_DMNGANHANG.Rows.Remove(r_Insert);
            }
            BS_DMNGANHANG_CurrentChanged(new object(), new EventArgs());
            GD.FM.BLL.MenuroleManager.set_Enable_controls(GD.FM.LIB.BUTTONACTION.BUTTONACTION_CANCEL, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            FORM_PROCESS_UTIL.enableControls(false, uiPanel1Container, new List<Control>(new Control[] { }));
            GRID_DMNGANHANG.Enabled = true;
        }
        private void btn_XOA_Click(object sender, EventArgs e)
        {
            GD.FM.LIB.FORM_PROCESS_UTIL.enableControls(false, uiPanel1Container, null);
            if (string.IsNullOrEmpty(MAHIEU_PK)) return;
            DanhmucnganhangManager _DanhmucnganhangManager = new DanhmucnganhangManager();
            DanhmucnganhangEntity _DanhmucnganhangEntity = new DanhmucnganhangEntity();
            _DanhmucnganhangEntity = _DanhmucnganhangManager.SelectOne(MAHIEU_PK);
            if (_DanhmucnganhangEntity != null && MessageBox.Show("Xóa tài khoản: " + MAHIEU_PK + " - " + txt_AccountHolder.Text, "Xóa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) ==
                   System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                    _DanhmucnganhangManager.Delete(MAHIEU_PK);
                    GRID_DMNGANHANG.CurrentRow.Delete();
                    BS_DMNGANHANG_CurrentChanged(new object(), new EventArgs());
                    //GD.FM.LIB.TrayPopup.PoupStringMessage(GD.FM.APP.Properties.Resources.MessageTitle, GD.FM.APP.Properties.Resources.MessageContent_T);
                    GD.FM.LIB.TrayPopup.PoupStringMessage("Thông báo", "Đã xóa thành công!");
                    GD.FM.BLL.MenuroleManager.set_Enable_controls(_DanhmucnganhangManager.Convert(_DanhmucnganhangEntity), GD.FM.LIB.BUTTONACTION.BUTTONACTION_DELETE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
                }
                catch
                {
                    MessageBox.Show("Không thể xóa tài khoản " + MAHIEU_PK + "!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            GRID_DMNGANHANG.Enabled = true;
        }
        private void btn_LUULAI_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(MAHIEU_PK) && _DanhmucnganhangManager.SelectOne(txt_MAHIEU.Text.Trim()) != null)
            {
                MessageBox.Show("Mã tài khoản bị trùng! \nNhập lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_MAHIEU.Focus();
                return;
            }
            else if (txt_MAHIEU.Text == "")
            {
                MessageBox.Show("Yêu cầu nhập mã tài khoản!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_MAHIEU.Focus();
                return;
            }
            else if (txt_AccountHolder.Text == "")
            {
                MessageBox.Show("Yêu cầu nhập chủ tài khoản!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_AccountHolder.Focus();
                return;
            }
            else
            {
                GD.FM.LIB.FORM_PROCESS_UTIL.enableControls(false, uiPanel1Container, null);
                MAHIEU_PK = Save_Data(MAHIEU_PK);
                GD.FM.LIB.TrayPopup.PoupStringMessage("Thông báo", "Lưu lại thành công");
                GRID_DMNGANHANG.Enabled = true;
                btn_THEMMOI.Focus();
            }
        }
        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion

        private void FRM_DMNGANHANG_FormClosing(object sender, FormClosingEventArgs e)
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
