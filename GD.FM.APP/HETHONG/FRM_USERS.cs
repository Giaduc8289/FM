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
using GD.FM.APP.DANHMUC;

namespace GD.FM.APP.HETHONG
{
    public partial class FRM_USERS : FRM_DMPARENT
    {

        public string CKEY = "gtid_soft";
        public string username;
        public string password;
        private string maNhom;
        private UsersManager _UsersManager = new UsersManager();
        private UsersEntity _UsersEntity = new UsersEntity();
        private MenuroleEntity _MenuroleEntity = new MenuroleEntity();
        private DataTable DT_USER = new DataTable();
        private DataTable DT_ROLES = new DataTable();
        private BindingSource BS_USER = new BindingSource();
        private DataRow r_Insert = null;
        private GD.FM.CONTROL.JGridEX GRID_USERS = new GD.FM.CONTROL.JGridEX();
        private string FUNCTION = "LOAD", USERID_PK = "";

        private static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
           // ErrorTrapper.ErrorHandler.HandleError(e.Exception);
        }
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
                        DT_USER = LIB.SESSION_START.DM_USER;
                        cbb_NHOMQUYEN.DataSource = LIB.SESSION_START.DT_ROLE;
                        cbb_NHOMQUYEN.ValueMember = "Rolesid";
                        cbb_NHOMQUYEN.DisplayMember = "Rolesname";
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

        
        public FRM_USERS()
        {
            InitializeComponent();
            UsersManager _UsersManager = new UsersManager();
            DataTable dt111 = _UsersManager.Clone();

            //GD.FM.LIB.GRID_COMM.Create_GRID_CONIG(dt111, LIB.PATH.KDTM_PATH + @"\XMLCONFIG\FRM_USERS.xml");
            //GD.FM.LIB.COMBO_COMM.SOURCE(false, cbb_NHOMQUYEN, txt_TENNHOMQUYEN, DT_ROLES, RolesFields.Rolesid.Name, RolesFields.Rolesname.Name);
            GD.FM.LIB.FORM_PROCESS_UTIL.enableControls(false, uiPanel1Container, null);
            GD.FM.CONTROL.BUTTON.Loadimage(LIB.PATH.KDTM_PATH, btn_LUULAI, btn_LUULAI.Name + ".xml");
            GD.FM.CONTROL.BUTTON.Loadimage(LIB.PATH.KDTM_PATH, btn_SUA, btn_SUA.Name + ".xml");
            GD.FM.CONTROL.BUTTON.Loadimage(LIB.PATH.KDTM_PATH, btn_THEMMOI, btn_THEMMOI.Name + ".xml");
            GD.FM.CONTROL.BUTTON.Loadimage(LIB.PATH.KDTM_PATH, btn_XOA, btn_XOA.Name + ".xml");
            GD.FM.CONTROL.BUTTON.Loadimage(LIB.PATH.KDTM_PATH, btn_KHOIPHUC, btn_KHOIPHUC.Name + ".xml");
            GD.FM.CONTROL.BUTTON.Loadimage(LIB.PATH.KDTM_PATH, btn_Thoat, btn_Thoat.Name + ".xml");
            GD.FM.LIB.GRID_COMM.LOAD_GRID_UIPanel(LIB.PATH.KDTM_PATH + @"\XMLCONFIG\FRM_USERS.xml", GRID_USERS, uiPanel0Container);
            FORM_PROCESS();

            DataView Source_View = new DataView(DT_USER);
            BS_USER = new BindingSource();
            BS_USER.DataSource = Source_View;
            GRID_USERS.DataSource = BS_USER;
            BS_USER.CurrentChanged += new EventHandler(BS_USER_CurrentChanged);
            BS_USER_CurrentChanged((new object()), (new EventArgs()));
            GD.FM.BLL.MenuroleManager.set_Enable_controls(GD.FM.LIB.BUTTONACTION.BUTTONACTION_LOAD, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            Application.ThreadException += new System.Threading.ThreadExceptionEventHandler(Application_ThreadException);
            btn_THEMMOI.Focus();
        }
        void BS_USER_CurrentChanged(object sender, EventArgs e)
        {
            try
            {
                if (BS_USER.Current != null)
                {
                    string pass = string.Empty;
                    DataRowView _Rowview = (DataRowView)this.BS_USER.Current;
                    if (_Rowview != null)
                    txt_username.Text = _Rowview.Row[UsersFields.Username.Name].ToString();
                    try
                    {
                        pass = MaHoa.Decrypt(_Rowview.Row[UsersFields.Password.Name].ToString(), CKEY, true);
                    }
                    catch { }
                    txt_password.Text = pass;
                    txt_fullname.Text = _Rowview.Row[UsersFields.Fullname.Name].ToString();
                    txt_phone.Text = _Rowview.Row[UsersFields.Phone.Name].ToString();
                    txt_address.Text = _Rowview.Row[UsersFields.Address.Name].ToString();
                    USERID_PK = _Rowview.Row[UsersFields.Userid.Name].ToString();
                    cbb_NHOMQUYEN.SelectedValue = _Rowview.Row[UsersFields.Rolesid.Name].ToString();
                }
                else { GD.FM.LIB.FORM_PROCESS_UTIL.clearControls(uiPanel1Container, GD.FM.LIB.FORM_PROCESS_UTIL.getAllControl(uiPanel1Container)); }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "BS_USER_CurrentChanged"); }
        }
        private void Text_Validating(object sender, CancelEventArgs e)
        {
            TextBox _TextBox = (TextBox)sender;
            if (_TextBox.Text.Trim().Length == 0)
            {
                // error1.SetError(_TextBox, GD.FM.DANHMUC.Properties.Resources.TexBox_EMTY);
                _TextBox.Focus();
            }
        }
        private string Save_Data(string _str_USER_PK)
        {
            // ma hoa mat khau
            username = txt_username.Text.ToLower();
            password = MaHoa.Encrypt(txt_password.Text, CKEY, true);

            UsersEntity _UsersEntity = new UsersEntity();
            _UsersEntity.Userid = username;
            _UsersEntity.Username = username;
            _UsersEntity.Fullname = txt_fullname.Text.Trim();
            _UsersEntity.Phone = txt_phone.Text.Trim();
            _UsersEntity.Address = txt_address.Text.Trim();
            _UsersEntity.Password = password;
            _UsersEntity.Rolesid = cbb_NHOMQUYEN.SelectedValue.ToString();

            if (string.IsNullOrEmpty(_str_USER_PK))
            {
                if (txt_username.Text.Trim().Equals(DmcapmaManager.GET_MA_INT(this.Name, false)))
                {
                    _UsersEntity.Userid = DmcapmaManager.GET_MA_INT(this.Name, true);
                    _UsersEntity.Userid = txt_username.Text.Trim();
                }
                else { _UsersEntity.Userid = txt_username.Text.Trim(); }
            }
            if (string.IsNullOrEmpty(_str_USER_PK))
            {
                _str_USER_PK = _UsersManager.InsertV2(_UsersEntity, r_Insert, DT_USER, BS_USER);
                GD.FM.BLL.MenuroleManager.set_Enable_controls(_UsersManager.Convert(_UsersEntity), GD.FM.LIB.BUTTONACTION.BUTTONACTION_INSERT, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
                BS_USER.ResetCurrentItem();
            }
            else
            {
                _UsersManager.Update(_UsersEntity);
                GRID_USERS.CurrentRow.Cells[UsersFields.Username.Name].Value = _UsersEntity.Username;
                GRID_USERS.CurrentRow.Cells[UsersFields.Password.Name].Value = _UsersEntity.Password;
                GRID_USERS.CurrentRow.Cells[UsersFields.Fullname.Name].Value = _UsersEntity.Fullname;
                GRID_USERS.CurrentRow.Cells[UsersFields.Phone.Name].Value = _UsersEntity.Phone;
                GRID_USERS.CurrentRow.Cells[UsersFields.Address.Name].Value = _UsersEntity.Address;


                GD.FM.BLL.MenuroleManager.set_Enable_controls(_UsersManager.Convert(_UsersEntity), GD.FM.LIB.BUTTONACTION.BUTTONACTION_UPDATE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            }
            return _str_USER_PK;
        }       
        private void btn_THEMMOI_Click(object sender, EventArgs e)
        {

            //txt_username.ReadOnly = txt_password.ReadOnly = txt_fullname.ReadOnly = txt_phone.ReadOnly = txt_address.ReadOnly = true;
            GD.FM.LIB.FORM_PROCESS_UTIL.enableControls(true, uiPanel1Container, new List<Control>(new Control[] { }));
            //txt_username.Text = txt_password.Text = txt_fullname.Text = "";
            UsersEntity _UsersEntity = new UsersEntity();
            UsersManager _UsersManager = new UsersManager();
            r_Insert = DT_USER.NewRow();
            DT_USER.Rows.Add(r_Insert);
            BS_USER.Position = DT_USER.Rows.Count;
            USERID_PK = "";
            txt_username.Focus();
            TEXTBOX_Only_Control(false, null);
            GD.FM.LIB.FORM_PROCESS_UTIL.enableControls(true, uiPanel1Container, new List<Control>(new Control[] { }));
            GD.FM.BLL.MenuroleManager.set_Enable_controls(GD.FM.LIB.BUTTONACTION.BUTTONACTION_THEMMOI, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            GRID_USERS.Enabled = false;
            txt_username.Enabled = true;
        }

        private void btn_SUA_Click(object sender, EventArgs e)
        {
            txt_username.Enabled = false;
            if (string.IsNullOrEmpty(USERID_PK)) { return; }
            else
            {
                GD.FM.BLL.MenuroleManager.set_Enable_controls(GD.FM.LIB.BUTTONACTION.BUTTONACTION_SUA, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
                GD.FM.LIB.FORM_PROCESS_UTIL.enableControls(true, uiPanel1Container, new List<Control>(new Control[] {}));
                txt_username.Focus();
            }
            GRID_USERS.Enabled = false;
            if (txt_username.Text == "Admin")
            {
              
                cbb_NHOMQUYEN.Enabled = false;
            }
            else {
                cbb_NHOMQUYEN.Enabled = true;
            }
        }
        private void btn_LUULAI_Click(object sender, EventArgs e)
        {

            if (txt_username.Text == "")
            {
                MessageBox.Show("Yêu cầu nhập tên đăng nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_username.Focus();
                return;
            }
     
            if (cbb_NHOMQUYEN.Text == "")
            {
                MessageBox.Show("Yêu cầu chọn nhóm quyền!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbb_NHOMQUYEN.Focus();
                return;
            }
         
            if (txt_fullname.Text == "")
            {
                MessageBox.Show("Yêu cầu nhập tên đầy đủ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_fullname.Focus();
                return;
            }
            else if (txt_password.Text == "")
            {
                MessageBox.Show("Yêu cầu nhập mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_password.Focus();
                return;
            }
            if (string.IsNullOrEmpty(USERID_PK) && _UsersManager.SelectOne(txt_username.Text.Trim())!= null)
            {
                MessageBox.Show("Tên đăng nhập bị trùng! \nNhập lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_username.Focus();
                return;
            }
           // if (GD.FM.BLL.MenuroleManager.Validating_TextBox(txt_MAQUOCGIA, txt_TENQUOCGIA, txt_TRANGTHAI) == false) return;
           // error1.Clear();
            GD.FM.LIB.FORM_PROCESS_UTIL.enableControls(false, uiPanel1Container, null);
            USERID_PK = Save_Data(USERID_PK);
            GD.FM.LIB.TrayPopup.PoupStringMessage("Thông báo","Lưu lại thành công");
            GRID_USERS.Enabled = true;
            btn_THEMMOI.Focus();
        }
        private void btn_KHOIPHUC_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(USERID_PK) && r_Insert != null)
            {
                  DT_USER.Rows.Remove(r_Insert);
            }
            BS_USER_CurrentChanged(new object(), new EventArgs());
            GD.FM.BLL.MenuroleManager.set_Enable_controls(GD.FM.LIB.BUTTONACTION.BUTTONACTION_CANCEL, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            FORM_PROCESS_UTIL.enableControls(false, uiPanel1Container, new List<Control>(new Control[] { }));
            GRID_USERS.Enabled = true;
        }

        private void btn_XOA_Click(object sender, EventArgs e)
        {
            GD.FM.LIB.FORM_PROCESS_UTIL.enableControls(false, uiPanel1Container, null);
            if (string.IsNullOrEmpty(USERID_PK)) return;
            UsersEntity _UsersEntity = new UsersEntity();
            UsersManager _UsersManager = new UsersManager();

            if (txt_username.Text=="Admin")
            { 
                MessageBox.Show("Không xóa tài khoản "+ txt_username.Text);
                return;
            }
           _UsersEntity = _UsersManager.SelectOne(USERID_PK);
            if (_UsersEntity != null && MessageBox.Show("Xóa tài khoản "+ txt_username.Text, "Xóa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) ==
                   System.Windows.Forms.DialogResult.Yes)
            {
                _UsersManager.Delete(USERID_PK);
                GRID_USERS.CurrentRow.Delete();
                BS_USER_CurrentChanged(new object(), new EventArgs());
              //  GD.FM.LIB.TrayPopup.PoupStringMessage(GD.FM.APP.Properties.Resources.MessageTitle, GD.FM.APP.Properties.Resources.MessageContent_T);
                GD.FM.BLL.MenuroleManager.set_Enable_controls(_UsersManager.Convert(_UsersEntity), GD.FM.LIB.BUTTONACTION.BUTTONACTION_DELETE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            }
            GRID_USERS.Enabled = true;
        }

        private void FRM_USERS_FormClosing(object sender, FormClosingEventArgs e)
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

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FRM_USERS_Load(object sender, EventArgs e)
        {

        }

        private void uiPanel1Container_Click(object sender, EventArgs e)
        {

        }

        private void txt_username_Leave(object sender, EventArgs e)
        {
            txt_password.Text = txt_username.Text;
        }
    }
}
