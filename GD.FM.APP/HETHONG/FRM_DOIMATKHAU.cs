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
using Microsoft.ReportingServices.ReportProcessing.ReportObjectModel;

namespace GD.FM.APP.HETHONG
{
    public partial class FRM_DOIMATKHAU : FRM_DMPARENT
    {
        private DataTable DT_USER = new DataTable();
        private UsersManager _UsersManager = new UsersManager();
        private BindingSource BS_USER = new BindingSource();
        public string CKEY = "gtid_soft";
        public string username;
        public string password;
        public string newpassword;
        private string USERID_PK = "";
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


        public FRM_DOIMATKHAU()
        {
            InitializeComponent();
            txt_username.Text = LIB.SESSION_START.TS_USER_LOGIN;
            GD.FM.CONTROL.BUTTON.Loadimage(LIB.PATH.FM_PATH, btn_LUULAI, btn_LUULAI.Name + ".xml");
            GD.FM.CONTROL.BUTTON.Loadimage(LIB.PATH.FM_PATH, btn_Thoat, btn_Thoat.Name + ".xml");
            FORM_PROCESS();
          
        }
        private void btn_LUULAI_Click(object sender, EventArgs e)
        {
            
            if (txt_password.Text == "")
            {
                MessageBox.Show("Yêu cầu nhập mật khẩu cũ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_password.Focus();
                return;
            }
            if (txt_newpassword.Text == "")
            {
                MessageBox.Show("Yêu cầu nhập mật khẩu mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_newpassword.Focus();
                return;
            }
            if (!txt_newpassword.Text.Equals(txt_repassword.Text))
            {
                MessageBox.Show("Mật khẩu mới không trùng khớp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_repassword.Focus();
                return;
            }
            USERID_PK = Save_Data(USERID_PK);
            

        }
        private string Save_Data(string _str_USER_PK)
        {
            string datapass;
            DT_USER = LIB.SESSION_START.DM_USER;
            username = txt_username.Text.ToLower();
            password = MaHoa.Encrypt(txt_password.Text, CKEY, true);
            newpassword = MaHoa.Encrypt(txt_newpassword.Text, CKEY, true);

            UsersEntity _UsersEntity = new UsersEntity();
            try
            {
                _UsersEntity = (UsersEntity)(new UsersManager().SelectByUsername(username)[0]);
                datapass = _UsersEntity.Password;
                if (password == datapass)
                {
                    _UsersEntity.Password = newpassword;
                    _UsersManager.Update(_UsersEntity);
                    GD.FM.LIB.TrayPopup.PoupStringMessage("Thông báo", "Lưu lại thành công");
                    btn_Thoat_Click(new object(), new EventArgs());

                }
                else
                {
                    MessageBox.Show("Vui lòng nhập đúng mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
            catch
            {
                MessageBox.Show("Đổi mật khẩu thất bại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return _str_USER_PK;
        }
        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
