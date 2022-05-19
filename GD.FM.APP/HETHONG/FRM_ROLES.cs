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

namespace GD.FM.APP.HETHONG
{
    public partial class FRM_ROLES : FRM_DMPARENT
    {
        private RolesManager _RolesManager = new RolesManager();
        private RolesEntity _RolesEntity = new RolesEntity();
        private MenuroleEntity _MenuroleEntity = new MenuroleEntity();
        private DataTable DT_ROLES = new DataTable();
        private BindingSource BS_ROLES = new BindingSource();
        private DataRow r_Insert = null;
        private GD.FM.CONTROL.JGridEX GRID_ROLES = new GD.FM.CONTROL.JGridEX();
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
                        _MenuroleEntity = MenuroleManager.Return_Current_Menurole("FRM_ROLES");
                        DT_ROLES = LIB.SESSION_START.DT_ROLE;
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
        public FRM_ROLES()
        {
            InitializeComponent();
            RolesManager _RolesManager = new RolesManager();
            DataTable dt111 = _RolesManager.Clone();
            //GD.FM.LIB.GRID_COMM.Create_GRID_CONIG(dt111, LIB.PATH.KDTM_PATH + @"\XMLCONFIG\FRM_ROLES.xml");
            // GD.FM.LIB.COMBO_COMM.SOURCE(false, cbb_NHOMQUYEN, txt_TENNHOMQUYEN, DT_ROLES, RolesFields.Rolesid.Name, RolesFields.Rolesname.Name);
            GD.FM.LIB.FORM_PROCESS_UTIL.enableControls(false, uiPanel1Container, null);
            GD.FM.CONTROL.BUTTON.Loadimage(LIB.PATH.KDTM_PATH, btn_LUULAI, btn_LUULAI.Name + ".xml");
            GD.FM.CONTROL.BUTTON.Loadimage(LIB.PATH.KDTM_PATH, btn_SUA, btn_SUA.Name + ".xml");
            GD.FM.CONTROL.BUTTON.Loadimage(LIB.PATH.KDTM_PATH, btn_THEMMOI, btn_THEMMOI.Name + ".xml");
            GD.FM.CONTROL.BUTTON.Loadimage(LIB.PATH.KDTM_PATH, btn_XOA, btn_XOA.Name + ".xml");
            GD.FM.CONTROL.BUTTON.Loadimage(LIB.PATH.KDTM_PATH, btn_KHOIPHUC, btn_KHOIPHUC.Name + ".xml"); 
            GD.FM.CONTROL.BUTTON.Loadimage(LIB.PATH.KDTM_PATH, btn_Thoat, btn_Thoat.Name + ".xml");
            GD.FM.LIB.GRID_COMM.LOAD_GRID_UIPanel(LIB.PATH.KDTM_PATH + @"\XMLCONFIG\FRM_ROLES.xml", GRID_ROLES, uiPanel0Container);
            FORM_PROCESS();
            DataView Source_View = new DataView(DT_ROLES);
            BS_ROLES = new BindingSource();
            BS_ROLES.DataSource = Source_View;
            GRID_ROLES.DataSource = BS_ROLES;
            //GRID_FORMAT();
            //GRID_ROLES.ColumnAutoResize = true;
            BS_ROLES.CurrentChanged += new EventHandler(BS_ROLES_CurrentChanged);
            BS_ROLES_CurrentChanged((new object()), (new EventArgs()));
            GD.FM.BLL.MenuroleManager.set_Enable_controls(GD.FM.LIB.BUTTONACTION.BUTTONACTION_LOAD, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            Application.ThreadException += new System.Threading.ThreadExceptionEventHandler(Application_ThreadException);
            btn_THEMMOI.Focus();
        }
        void BS_ROLES_CurrentChanged(object sender, EventArgs e)
        {
            try
            {
                if (BS_ROLES.Current != null)
                {
                    DataRowView _Rowview = (DataRowView)this.BS_ROLES.Current;
                    if (_Rowview != null)
                        MAHIEU_PK = _Rowview.Row[RolesFields.Rolesid.Name].ToString();
                    txt_MAHIEU.Text = _Rowview.Row[RolesFields.Rolesid.Name].ToString();
                    txt_TENHIEU.Text = _Rowview.Row[RolesFields.Rolesname.Name].ToString();
                    txt_TENRUTGON.Text = _Rowview.Row[RolesFields.Description.Name].ToString();
                }
                else { GD.FM.LIB.FORM_PROCESS_UTIL.clearControls(uiPanel1Container, GD.FM.LIB.FORM_PROCESS_UTIL.getAllControl(uiPanel1Container)); }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "BS_ROLES_CurrentChanged"); }
        }
        private void btn_THEMMOI_Click(object sender, EventArgs e)
        {
            //txt_username.ReadOnly = txt_password.ReadOnly = txt_fullname.ReadOnly = txt_phone.ReadOnly = txt_address.ReadOnly = true;
            GD.FM.LIB.FORM_PROCESS_UTIL.enableControls(true, uiPanel1Container, new List<Control>(new Control[] { }));
            RolesManager _RolesManager = new RolesManager();
            RolesEntity _RolesEntity = new RolesEntity();
            r_Insert = DT_ROLES.NewRow();
            DT_ROLES.Rows.Add(r_Insert);
            BS_ROLES.Position = DT_ROLES.Rows.Count;
            MAHIEU_PK = "";
            txt_MAHIEU.Focus();
            TEXTBOX_Only_Control(false, null);
            // txt_MAHIEU.Text = DmcapmaManager.GET_MA_INT(DmcapmaManager.LOAI_MA_HIEU, false, GD.FM.DATA);
            GD.FM.LIB.FORM_PROCESS_UTIL.enableControls(true, uiPanel1Container, new List<Control>(new Control[] { }));
            GD.FM.BLL.MenuroleManager.set_Enable_controls(GD.FM.LIB.BUTTONACTION.BUTTONACTION_THEMMOI, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            GRID_ROLES.Enabled = false;
        }
        private string Save_Data(string _str_ROLES_PK)
        {
            RolesEntity _RolesEntity = new RolesEntity();

            _RolesEntity.Rolesid = txt_MAHIEU.Text.Trim();
            _RolesEntity.Rolesname = txt_TENHIEU.Text.Trim();
            _RolesEntity.Description = txt_TENRUTGON.Text.Trim();

            if (string.IsNullOrEmpty(_str_ROLES_PK))
            {
                _str_ROLES_PK = _RolesManager.InsertV2(_RolesEntity, r_Insert, DT_ROLES, BS_ROLES);
                GD.FM.BLL.MenuroleManager.set_Enable_controls(_RolesManager.Convert(_RolesEntity), GD.FM.LIB.BUTTONACTION.BUTTONACTION_INSERT, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
                BS_ROLES.ResetCurrentItem();
            }
            else
            {
                _RolesManager.Update(_RolesEntity);
                GRID_ROLES.CurrentRow.Cells[RolesFields.Rolesid.Name].Value = _RolesEntity.Rolesid;
                GRID_ROLES.CurrentRow.Cells[RolesFields.Rolesname.Name].Value = _RolesEntity.Rolesname;
                GRID_ROLES.CurrentRow.Cells[RolesFields.Description.Name].Value = _RolesEntity.Description;
                GD.FM.BLL.MenuroleManager.set_Enable_controls(_RolesManager.Convert(_RolesEntity), GD.FM.LIB.BUTTONACTION.BUTTONACTION_UPDATE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            }
            return _str_ROLES_PK;
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
            GRID_ROLES.Enabled = false;
        }
        private void btn_KHOIPHUC_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(MAHIEU_PK) && r_Insert != null)
            {
                DT_ROLES.Rows.Remove(r_Insert);
            }
            BS_ROLES_CurrentChanged(new object(), new EventArgs());
            GD.FM.BLL.MenuroleManager.set_Enable_controls(GD.FM.LIB.BUTTONACTION.BUTTONACTION_CANCEL, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            FORM_PROCESS_UTIL.enableControls(false, uiPanel1Container, new List<Control>(new Control[] { }));
            GRID_ROLES.Enabled = true;
        }
        private void btn_XOA_Click(object sender, EventArgs e)
        {
            GD.FM.LIB.FORM_PROCESS_UTIL.enableControls(false, uiPanel1Container, null);
            if (string.IsNullOrEmpty(MAHIEU_PK)) return;
            RolesManager _RolesManager = new RolesManager();
            RolesEntity _RolesEntity = new RolesEntity();
            _RolesEntity = _RolesManager.SelectOne(MAHIEU_PK);
            if (_RolesEntity != null && MessageBox.Show("Xóa tài khoản: " + MAHIEU_PK + " - " + txt_TENHIEU.Text, "Xóa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) ==
                   System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                    _RolesManager.Delete(MAHIEU_PK);
                    GRID_ROLES.CurrentRow.Delete();
                    BS_ROLES_CurrentChanged(new object(), new EventArgs());
                    //GD.FM.LIB.TrayPopup.PoupStringMessage(GD.FM.APP.Properties.Resources.MessageTitle, GD.FM.APP.Properties.Resources.MessageContent_T);
                    GD.FM.LIB.TrayPopup.PoupStringMessage("Thông báo", "Đã xóa thành công!");
                    GD.FM.BLL.MenuroleManager.set_Enable_controls(_RolesManager.Convert(_RolesEntity), GD.FM.LIB.BUTTONACTION.BUTTONACTION_DELETE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
                }
                catch
                {
                    MessageBox.Show("Không thể xóa tài khoản " + MAHIEU_PK + "!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            GRID_ROLES.Enabled = true;
        }
        private void btn_LUULAI_Click(object sender, EventArgs e)
        {
            if (txt_MAHIEU.Text == "")
            {
                MessageBox.Show("Yêu cầu nhập mã người dùng !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_MAHIEU.Focus();
                return;
            }
            else if (txt_TENHIEU.Text == "")
            {
                MessageBox.Show("Yêu cầu nhập tên quyền !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_TENHIEU.Focus();
                return;
            }

            if (string.IsNullOrEmpty(MAHIEU_PK) && _RolesManager.SelectOne(txt_MAHIEU.Text.Trim()) != null)
            {
                MessageBox.Show("Mã người dùng bị trùng! \nNhập lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_MAHIEU.Focus();
                return;
            }
            // if (GD.FM.BLL.MenuroleManager.Validating_TextBox(txt_MAQUOCGIA, txt_TENQUOCGIA, txt_TRANGTHAI) == false) return;
            // error1.Clear();
            else if (txt_MAHIEU.Text == "")
            {
                MessageBox.Show("Yêu cầu nhập mã người dùng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_MAHIEU.Focus();
                return;
            }
            else if (txt_TENHIEU.Text == "")
            {
                MessageBox.Show("Yêu cầu nhập tên quyền!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_TENHIEU.Focus();
                return;
            }
            else
            {
                GD.FM.LIB.FORM_PROCESS_UTIL.enableControls(false, uiPanel1Container, null);
                MAHIEU_PK = Save_Data(MAHIEU_PK);
                GD.FM.LIB.TrayPopup.PoupStringMessage("Thông báo", "Lưu lại thành công");
                GRID_ROLES.Enabled = true;
                btn_THEMMOI.Focus();
            }
        }
        //private void FRM_ROLES_FormClosing(object sender, FormClosingEventArgs e)
        //{
        //    if (btn_LUULAI.Enabled)
        //    {
        //        DialogResult Dlog = MessageBox.Show("Dữ liệu đã được thay đổi! Bạn có muốn lưu lại không?", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
        //        if (Dlog == DialogResult.Yes)
        //        {
        //            btn_LUULAI_Click(new object(), new EventArgs());
        //            return;
        //        }
        //        if (Dlog == DialogResult.Cancel)
        //        {
        //            e.Cancel = true;
        //            return;
        //        }
        //    }
        //}

        private void FRM_ROLES_Resize(object sender, EventArgs e)
        {
        }

        private void FRM_ROLES_SizeChanged(object sender, EventArgs e)
        {
            //if (this.Width==1000&&this.Height==500)
            //{
            //    uiPanel0.Width = 400;
            //}
            //else
            //uiPanel0.Width = 600;

        }

        private void txt_MAHIEU_KeyPress(object sender, KeyPressEventArgs e)
        {
            //e.Handled = false;
            //if (txt_MAHIEU.Text.Length < 20&&(int)e.KeyChar <= 57 && (int)e.KeyChar >= 48 | (int)e.KeyChar == 8 | (int)e.KeyChar == 13)
            //{
            //    e.Handled = false;
            //}
            //else if(txt_MAHIEU.Text.Length >= 20&&(int)e.KeyChar!=8){
            //    //GD.FM.LIB.TrayPopup.PoupStringMessage("Thông báo", "Mã hiệu không được lớn hơn 20 ký tự!");
            //    //MessageBox.Show("Chỉ nhập số!!!", "Error", MessageBoxButtons.OK);
            //    e.Handled = true;
            //}
            //else if (txt_MAHIEU.Text.Length >= 20 && (int)e.KeyChar == 8)
            //{
            //    e.Handled = false; ;
            //}
            //else
            //{
            //    //GD.FM.LIB.TrayPopup.PoupStringMessage("Thông báo", "Chỉ được nhập số!");
            //    //MessageBox.Show("Chỉ nhập số!!!", "Error", MessageBoxButtons.OK);
            //    e.Handled = true;
            //}
        }



        private void uiPanel0_Resize(object sender, EventArgs e)
        {
            //GRID_ROLES.ColumnAutoResize = false;
            if (uiPanel0.Width > 820)
                GRID_ROLES.ColumnAutoResize = true;
            else
                GRID_ROLES.ColumnAutoResize = false;
        }

        private void txt_TENRUTGON_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = false;
            if (txt_TENRUTGON.Text.Length >= 20 && (int)e.KeyChar != 8)
            {
                e.Handled = true;
                //MessageBox.Show("Tên rút gọn không được lớn hơn 20 ký tự!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                GD.FM.LIB.TrayPopup.PoupStringMessage("Thông báo", "Tên rút gọn không được lớn hơn 20 ký tự!");
            }
            else
                e.Handled = false;
        }
        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FRM_ROLES_FormClosing(object sender, FormClosingEventArgs e)
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

        private void FRM_ROLES_Load(object sender, EventArgs e)
        {

        }
    }
}
