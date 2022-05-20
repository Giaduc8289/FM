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
    public partial class FRM_LOGIN : FRM_DMPARENT
    {
        private string _catalogNameToUse = System.Configuration.ConfigurationManager.AppSettings.Get("CatalogNameToUse");
        private DataTable DT_USER = new DataTable();
        private string FUNCTION = "LOAD";
        public bool islogin = false;
        private UsersManager _UsersManager = new UsersManager();
        public string CKEY = "gtid_soft";
        public string username;
        public string password;
        public FRM_LOGIN()
        {
            InitializeComponent();
            GD.FM.CONTROL.BUTTON.Loadimage(LIB.PATH.FM_PATH, btn_Thoat, btn_Thoat.Name + ".xml");
            GD.FM.CONTROL.BUTTON.Loadimage(btnOK, btnOK.Name + ".xml");
            FORM_PROCESS();
            //numNamLamViec.Value = int.Parse(_catalogNameToUse.Substring(_catalogNameToUse.Length - 4));//DateTime.Now.Year.ToString();
            txt_NGAYLAMVIEC.Text = DateTime.Now.ToString("dd/MM/yyyy");
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
            string user = txt_USERNAME.Text, pass = MaHoa.Encrypt(txt_PASS.Text, CKEY, true), datapass = "";
            //thiet dat cho file config
            //string str = LIB.SESSION_START.ConnectionStringKeyName;
            //int i = str.IndexOf(Properties.Settings.Default.ApplicationName);
            //string strcu = str.Substring(i, Properties.Settings.Default.ApplicationName.Length + 4);
            //str = str.Replace(strcu, Properties.Settings.Default.ApplicationName + numNamLamViec.Value.ToString());
            //System.Configuration.ConfigurationManager.AppSettings.Set("Main.ConnectionString", str);
            //System.Configuration.ConfigurationManager.AppSettings.Set("CatalogNameToUse", Properties.Settings.Default.ApplicationName + numNamLamViec.Value.ToString());

            //UpdateKey("Main.ConnectionString", str);
            //UpdateKey("CatalogNameToUse", Properties.Settings.Default.ApplicationName + numNamLamViec.Value.ToString());

            try
            {
                DT_USER = LIB.SESSION_START.DM_USER;
                try
                {
                    datapass = DT_USER.Select(UsersFields.Username.Name + "='" + user + "'").CopyToDataTable().Rows[0][UsersFields.Password.Name].ToString();
                    if (pass == datapass)
                    {
                        EntityCollection _Collection = _UsersManager.SelectBy_Username_Passwords(user, datapass);
                        GD.FM.APP.LIB.USERS._Current = (UsersEntity)_Collection[0];
                        GD.FM.APP.LIB.USERS._RolesEntity = (new RolesManager()).SelectOne(GD.FM.APP.LIB.USERS._Current.Rolesid);
                        GD.FM.APP.LIB.USERS._Rolesid = GD.FM.APP.LIB.USERS._Current.Rolesid;
                        GD.FM.APP.LIB.SESSION_START.TS_USER_LOGIN = user;

                        //  GD.FM.APP.LIB.USERS._RoleEntity = (new RolesManager()).SelectOne(GD.FM.APP.LIB.USERS._Current.Rolesid);
                        islogin = true;
                        LIB.SESSION_START.TS_NGAYLAMVIEC = Convert.ToDateTime(txt_NGAYLAMVIEC.Text);//Convert.ToDateTime(_Rowview.Row[DanhmucdoituongthanhtoanFields.Ngaycap.Name]).ToString("dd/MM/yyyy");
                        LIB.SESSION_START.TS_NGAYDAUTHANG = LIB.SESSION_START.TS_NGAYLAMVIEC.AddDays(1 - LIB.SESSION_START.TS_NGAYLAMVIEC.Day);
                        LIB.SESSION_START.TS_NGAYCUOITHANG = LIB.SESSION_START.TS_NGAYLAMVIEC.AddMonths(1).AddDays(-LIB.SESSION_START.TS_NGAYLAMVIEC.AddMonths(1).Day);
                        LIB.SESSION_START.TS_NGAYDAUQUY = LIB.SESSION_START.TS_NGAYLAMVIEC.AddMonths(-(LIB.SESSION_START.TS_NGAYLAMVIEC.Month - 1) % 3).AddDays(1 - LIB.SESSION_START.TS_NGAYLAMVIEC.Day);
                        LIB.SESSION_START.TS_NGAYCUOIQUY = LIB.SESSION_START.TS_NGAYLAMVIEC.AddMonths(3 - (LIB.SESSION_START.TS_NGAYLAMVIEC.Month - 1) % 3).AddDays(-LIB.SESSION_START.TS_NGAYLAMVIEC.AddMonths(3 - (LIB.SESSION_START.TS_NGAYLAMVIEC.Month - 1) % 3).Day);
                        LIB.SESSION_START.TS_NGAYDAUNAM = LIB.SESSION_START.TS_NGAYLAMVIEC.AddDays(1 - LIB.SESSION_START.TS_NGAYLAMVIEC.DayOfYear);
                        LIB.SESSION_START.TS_NGAYCUOINAM = LIB.SESSION_START.TS_NGAYLAMVIEC.AddYears(1).AddDays(-LIB.SESSION_START.TS_NGAYLAMVIEC.AddYears(1).DayOfYear);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Mật khẩu không đúng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        islogin = false;
                    }
                }
                catch {
                    MessageBox.Show("Đăng nhập không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    islogin = false;
                }

            }
            catch(Exception ex)
            {
                //MessageBox.Show(ex.Message);
                //MessageBox.Show(str);
                MessageBox.Show("CSDL không tồn tại, kiểm tra lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                islogin = false;
            }
        }

        public static void UpdateKey(string strKey, string newValue)
        {
            // MessageBox.Show(AppDomain.CurrentDomain.BaseDirectory + "BTC.exe.config");
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(AppDomain.CurrentDomain.BaseDirectory + "GD.FM.APP.exe.config");
            if (!KeyExists(strKey))
            {
                throw new ArgumentNullException("Key", "<" + strKey + "> does not exist in the configuration. Update failed.");
            }
            XmlNode appSettingsNode = xmlDoc.SelectSingleNode("configuration/appSettings");
            // Attempt to locate the requested setting.
            foreach (XmlNode childNode in appSettingsNode)
            {
                if (childNode.Attributes["key"].Value == strKey)
                {
                    childNode.Attributes["value"].Value = newValue;
                }
            }
            xmlDoc.Save(AppDomain.CurrentDomain.BaseDirectory + "GD.FM.APP.exe.config");
            xmlDoc.Save(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);
        }

        public static bool KeyExists(string strKey)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(AppDomain.CurrentDomain.BaseDirectory + "GD.FM.APP.exe.config");
            XmlNode appSettingsNode = xmlDoc.SelectSingleNode("configuration/appSettings");
            // Attempt to locate the requested setting.
            foreach (XmlNode childNode in appSettingsNode)
            {
                if (childNode.Attributes["key"].Value == strKey)
                {
                    return true;
                }
            }
            return false;
        }

    }
}
