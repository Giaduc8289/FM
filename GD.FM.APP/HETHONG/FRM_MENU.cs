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
using System.Reflection;

namespace GD.FM.APP.HETHONG
{
    public partial class FRM_MENU : FRM_DMPARENT
    {
        private MenuManager _MenuManager = new MenuManager();
        private MenuEntity _MenuEntity = new MenuEntity();
        private MenuroleEntity _MenuroleEntity = new MenuroleEntity();
        private DataTable DT_MENU = new DataTable();
        private BindingSource BS_MENU = new BindingSource();
        private DataRow r_Insert = null, _RowViewSelect = null;
        private GD.FM.CONTROL.JGridEX GRID_MENU = new GD.FM.CONTROL.JGridEX();
        private string FUNCTION = "LOAD", MAHIEU_PK = "";

        private LIB.GlobalFuns.CombolistNum[] loaiMenu = new LIB.GlobalFuns.CombolistNum[] {
                                                        new LIB.GlobalFuns.CombolistNum(1, "Chức năng"),
                                                        new LIB.GlobalFuns.CombolistNum(2, "Ngăn cách"),
                                                    };

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
                        //Type menuManagerType = Type.GetType("GD.FM.BLL.MenuManager");
                        //////GD.FM.BLL.MenuManager
                        //////GD.FM.DAL.EntityClasses.MenuEntity
                        ////var instance = Activator.CreateInstance(menuManagerType);
                        //ConstructorInfo menuManagerConstructor = menuManagerType.GetConstructor(Type.EmptyTypes);
                        //object menuManagerClassObject = menuManagerConstructor.Invoke(new object[] { });
                        //MethodInfo menuManagerMethod = menuManagerType.GetMethod("SelectAllRDT");
                        //object menuManagerValue = menuManagerMethod.Invoke(menuManagerClassObject, null);

                        //MenuEntity _MenuEntity = new MenuEntity();
                        //Type tp = typeof(MenuEntity);

                        //object obj = CommonEntityBase.("MenuEntity");
                        //string str = EntityType.MenuEntity.ToString();
                        //var abc = EntityType;
                        //CommonEntityBase dm
                        //var enumerable = typeof(GD.FM.DAL.EntityClasses.CommonEntityBase).GetProperty("MenuEntity").GetValue(ctx, null);

                        //Type menuEntityType = Type.GetType("MenuEntity&");
                        //var instance = Activator.CreateInstance(menuEntityType);
                        //ConstructorInfo menuEntityConstructor = menuEntityType.GetConstructor(Type.EmptyTypes);
                        //object menuEntityClassObject = menuEntityConstructor.Invoke(new object[] { });


                        _MenuroleEntity = MenuroleManager.Return_Current_Menurole("FRM_MENU");
                        DT_MENU = LIB.SESSION_START.DT_MENU;
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

        public FRM_MENU()
        {
            InitializeComponent();
            MenuManager _MenuManager = new MenuManager();
            DataTable dt111 = _MenuManager.Clone();
            //GD.FM.LIB.GRID_COMM.Create_GRID_CONIG(dt111, LIB.PATH.FM_PATH + @"\XMLCONFIG\FRM_MENU.xml");
            GD.FM.LIB.FORM_PROCESS_UTIL.enableControls(false, uiPanel1Container, null);
            GD.FM.CONTROL.BUTTON.Loadimage(LIB.PATH.FM_PATH, btn_LUULAI, btn_LUULAI.Name + ".xml");
            GD.FM.CONTROL.BUTTON.Loadimage(LIB.PATH.FM_PATH, btn_SUA, btn_SUA.Name + ".xml");
            GD.FM.CONTROL.BUTTON.Loadimage(LIB.PATH.FM_PATH, btn_THEMMOI, btn_THEMMOI.Name + ".xml");
            GD.FM.CONTROL.BUTTON.Loadimage(LIB.PATH.FM_PATH, btn_XOA, btn_XOA.Name + ".xml");
            GD.FM.CONTROL.BUTTON.Loadimage(LIB.PATH.FM_PATH, btn_KHOIPHUC, btn_KHOIPHUC.Name + ".xml");
            GD.FM.CONTROL.BUTTON.Loadimage(LIB.PATH.FM_PATH, btn_Thoat, btn_Thoat.Name + ".xml");
            GD.FM.LIB.GRID_COMM.LOAD_GRID_UIPanel(LIB.PATH.FM_PATH + @"\XMLCONFIG\FRM_MENU.xml", GRID_MENU, uiPanel0Container);
            GRID_MENU.RootTable.Groups.Add(GRID_MENU.Tables[0].Columns[MenuFields.Maphanhe.Name]);
            GRID_MENU.RootTable.Groups.Add(GRID_MENU.Tables[0].Columns[MenuFields.Menuparent.Name]);
            GRID_MENU.RootTable.SortKeys.Add(MenuFields.Thutu.Name, Janus.Windows.GridEX.SortOrder.Ascending);
            FORM_PROCESS();
            DataView Source_View = new DataView(DT_MENU);
            BS_MENU = new BindingSource();
            BS_MENU.DataSource = Source_View;
            GRID_MENU.DataSource = BS_MENU;
            BS_MENU.CurrentChanged += new EventHandler(BS_MENU_CurrentChanged);
            BS_MENU_CurrentChanged((new object()), (new EventArgs()));
            GD.FM.BLL.MenuroleManager.set_Enable_controls(GD.FM.LIB.BUTTONACTION.BUTTONACTION_LOAD, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            Application.ThreadException += new System.Threading.ThreadExceptionEventHandler(Application_ThreadException);
            cbo_LOAIMENU.ValueMember = "MA";
            cbo_LOAIMENU.DisplayMember = "TEN";
            cbo_LOAIMENU.DataSource = loaiMenu;
            btn_THEMMOI.Focus();
            btn_CHONFILE.Enabled = false;
        }

        void BS_MENU_CurrentChanged(object sender, EventArgs e)
        {
            try
            {
                GD.FM.LIB.FORM_PROCESS_UTIL.clearControls(uiPanel1Container, GD.FM.LIB.FORM_PROCESS_UTIL.getAllControl(uiPanel1Container));
                if (BS_MENU.Current != null)
                {
                    DataRowView _Rowview = (DataRowView)this.BS_MENU.Current;
                    if (_Rowview != null)
                        MAHIEU_PK = _Rowview.Row[MenuFields.MenuId.Name].ToString();
                    txt_MENUID.Text = _Rowview.Row[MenuFields.MenuId.Name].ToString();
                    txt_MENUNAME.Text = _Rowview.Row[MenuFields.MenuName.Name].ToString();
                    txt_MAPHANHE.Text = _Rowview.Row[MenuFields.Maphanhe.Name].ToString();
                    txt_MENUPARENT.Text = _Rowview.Row[MenuFields.Menuparent.Name].ToString();
                    try{ cbo_LOAIMENU.SelectedValue = int.Parse(_Rowview.Row[MenuFields.LoaiMenu.Name].ToString()); }
                    catch { }
                    txt_ICON.Text = _Rowview.Row[MenuFields.Icon.Name].ToString();
                    try
                    {
                        txt_THUTU.Text = Int32.Parse(_Rowview.Row[MenuFields.Thutu.Name].ToString()).ToString("#", new System.Globalization.CultureInfo("vi-VN"));
                    }
                    catch { }
                    txt_FORMNAME.Text = _Rowview.Row[MenuFields.FormName.Name].ToString();
                    txt_PARAM.Text = _Rowview.Row[MenuFields.Param.Name].ToString();
                    try { chk_ISSUDUNG.Checked = Convert.ToBoolean(Convert.ToInt32(_Rowview.Row[MenuFields.Issudung.Name].ToString())); }
                    catch { }

                    txt_MENUPARENT_Validating(new object(), new CancelEventArgs());
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "BS_MENU_CurrentChanged"); }
        }

        private string Save_Data(string _str_DMBANSOI_PK)
        {
            MenuEntity _MenuEntity = new MenuEntity();
            _MenuEntity.MenuId = txt_MENUID.Text.Trim();
            _MenuEntity.MenuName = txt_MENUNAME.Text.Trim();
            _MenuEntity.Maphanhe = txt_MAPHANHE.Text.Trim();
            _MenuEntity.Menuparent = txt_MENUPARENT.Text.Trim();
            _MenuEntity.LoaiMenu = (int)cbo_LOAIMENU.SelectedValue;
            _MenuEntity.Icon = txt_ICON.Text.Trim();
            try { _MenuEntity.Thutu = Convert.ToInt32(txt_THUTU.Text.Trim()); }
            catch { }
            _MenuEntity.FormName = txt_FORMNAME.Text.Trim();
            _MenuEntity.Param = txt_PARAM.Text.Trim();
            _MenuEntity.Issudung = chk_ISSUDUNG.Checked ? 1 : 0;

            if (string.IsNullOrEmpty(_str_DMBANSOI_PK))
            {
                _str_DMBANSOI_PK = _MenuManager.InsertV2(_MenuEntity, r_Insert, DT_MENU, BS_MENU);
                GD.FM.BLL.MenuroleManager.set_Enable_controls(_MenuManager.Convert(_MenuEntity), GD.FM.LIB.BUTTONACTION.BUTTONACTION_INSERT, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
                BS_MENU.ResetCurrentItem();
            }
            else
            {
                _MenuManager.Update(_MenuEntity);
                GRID_MENU.CurrentRow.Cells[MenuFields.MenuId.Name].Value = _MenuEntity.MenuId;
                GRID_MENU.CurrentRow.Cells[MenuFields.MenuName.Name].Value = _MenuEntity.MenuName;
                GRID_MENU.CurrentRow.Cells[MenuFields.Maphanhe.Name].Value = _MenuEntity.Maphanhe;
                GRID_MENU.CurrentRow.Cells[MenuFields.Menuparent.Name].Value = _MenuEntity.Menuparent;
                GRID_MENU.CurrentRow.Cells[MenuFields.LoaiMenu.Name].Value = _MenuEntity.LoaiMenu;
                GRID_MENU.CurrentRow.Cells[MenuFields.Icon.Name].Value = _MenuEntity.Icon;
                GRID_MENU.CurrentRow.Cells[MenuFields.Thutu.Name].Value = _MenuEntity.Thutu;
                GRID_MENU.CurrentRow.Cells[MenuFields.FormName.Name].Value = _MenuEntity.FormName;
                GRID_MENU.CurrentRow.Cells[MenuFields.Param.Name].Value = _MenuEntity.Param;
                GRID_MENU.CurrentRow.Cells[MenuFields.Issudung.Name].Value = _MenuEntity.Issudung;
                GD.FM.BLL.MenuroleManager.set_Enable_controls(_MenuManager.Convert(_MenuEntity), GD.FM.LIB.BUTTONACTION.BUTTONACTION_UPDATE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            }
            return _str_DMBANSOI_PK;
        }

        #region Button
        private void btn_THEMMOI_Click(object sender, EventArgs e)
        {
            GD.FM.LIB.FORM_PROCESS_UTIL.enableControls(true, uiPanel1Container, new List<Control>(new Control[] { txt_MENUPARENTNAME }));
            txt_MENUPARENTNAME.Text = string.Empty;
            MenuManager _MenuManager = new MenuManager();
            MenuEntity _MenuEntity = new MenuEntity();
            r_Insert = DT_MENU.NewRow();
            DT_MENU.Rows.Add(r_Insert);
            BS_MENU.Position = DT_MENU.Rows.Count;
            MAHIEU_PK = "";
            txt_MENUID.Focus();
            TEXTBOX_Only_Control(false, null);
            GD.FM.LIB.FORM_PROCESS_UTIL.enableControls(true, uiPanel1Container, new List<Control>(new Control[] { }));
            GD.FM.BLL.MenuroleManager.set_Enable_controls(GD.FM.LIB.BUTTONACTION.BUTTONACTION_THEMMOI, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            GRID_MENU.Enabled = false;
            btn_CHONFILE.Enabled = true;
            btn_SAOCHEP.Enabled = false;
        }
        private void btn_SUA_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(MAHIEU_PK)) { return; }
            else
            {
                GD.FM.BLL.MenuroleManager.set_Enable_controls(GD.FM.LIB.BUTTONACTION.BUTTONACTION_SUA, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
                GD.FM.LIB.FORM_PROCESS_UTIL.enableControls(true, uiPanel1Container, new List<Control>(new Control[] { txt_MENUID, txt_MENUPARENTNAME }));
                txt_THUTU.Focus();
            }
            GRID_MENU.Enabled = false;
            btn_CHONFILE.Enabled = true;
            btn_SAOCHEP.Enabled = false;
        }
        private void btn_KHOIPHUC_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(MAHIEU_PK) && r_Insert != null)
            {
                DT_MENU.Rows.Remove(r_Insert);
            }
            BS_MENU_CurrentChanged(new object(), new EventArgs());
            GD.FM.BLL.MenuroleManager.set_Enable_controls(GD.FM.LIB.BUTTONACTION.BUTTONACTION_CANCEL, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            FORM_PROCESS_UTIL.enableControls(false, uiPanel1Container, new List<Control>(new Control[] { }));
            GRID_MENU.Enabled = true;
            btn_CHONFILE.Enabled = false;
            btn_SAOCHEP.Enabled = true;
        }
        private void btn_XOA_Click(object sender, EventArgs e)
        {
            GD.FM.LIB.FORM_PROCESS_UTIL.enableControls(false, uiPanel1Container, null);
            if (string.IsNullOrEmpty(MAHIEU_PK)) return;
            MenuManager _MenuManager = new MenuManager();
            MenuEntity _MenuEntity = new MenuEntity();
            _MenuEntity = _MenuManager.SelectOne(MAHIEU_PK);
            if (_MenuEntity != null && MessageBox.Show("Xóa chức năng: " + txt_MENUNAME.Text, "Xóa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) ==
                   System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                    _MenuManager.Delete(MAHIEU_PK);
                    GRID_MENU.CurrentRow.Delete();
                    BS_MENU_CurrentChanged(new object(), new EventArgs());
                    //GD.FM.LIB.TrayPopup.PoupStringMessage(GD.FM.APP.Properties.Resources.MessageTitle, GD.FM.APP.Properties.Resources.MessageContent_T);
                    GD.FM.LIB.TrayPopup.PoupStringMessage("Thông báo", "Đã xóa thành công!");
                    GD.FM.BLL.MenuroleManager.set_Enable_controls(_MenuManager.Convert(_MenuEntity), GD.FM.LIB.BUTTONACTION.BUTTONACTION_DELETE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
                }
                catch
                {
                    MessageBox.Show("Không thể xóa chức năng " + txt_MENUNAME.Text + "!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            GRID_MENU.Enabled = true;
        }
        private void btn_LUULAI_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(MAHIEU_PK) && _MenuManager.SelectOne(txt_MENUID.Text.Trim()) != null)
            {
                MessageBox.Show("Mã chức năng bị trùng! \nNhập lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_MENUID.Focus();
                return;
            }
            else if (txt_MENUID.Text == "")
            {
                MessageBox.Show("Yêu cầu nhập mã chức năng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_MENUID.Focus();
                return;
            }
            else if (txt_THUTU.Text == "")
            {
                MessageBox.Show("Yêu cầu nhập thứ tự!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_THUTU.Focus();
                return;
            }
            else
            {
                GD.FM.LIB.FORM_PROCESS_UTIL.enableControls(false, uiPanel1Container, null);
                MAHIEU_PK = Save_Data(MAHIEU_PK);
                GD.FM.LIB.TrayPopup.PoupStringMessage("Thông báo", "Lưu lại thành công");
                GRID_MENU.Enabled = true;
                btn_CHONFILE.Enabled = false;
                btn_SAOCHEP.Enabled = true;
                btn_THEMMOI.Focus();
            }
        }
        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_CHONFILE_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlgOpen = new OpenFileDialog();
            dlgOpen.Filter = "Icon files (*.ico)|*.ico|All files (*.*)|*.*";
            if (dlgOpen.ShowDialog() == DialogResult.OK)
            {
                txt_ICON.Text = dlgOpen.SafeFileName;
            }
        }

        private void btn_SAOCHEP_Click(object sender, EventArgs e)
        {
            try
            {
                FM.LIB.FORM_PROCESS_UTIL.enableControls(true, uiPanel1Container, new List<Control>(new Control[] { }));
                MenuManager _MenuManager = new MenuManager();
                MenuEntity _MenuEntity = new MenuEntity();
                r_Insert = DT_MENU.NewRow();
                DT_MENU.Rows.Add(r_Insert);
                DataRow[] drCopy = DT_MENU.Select(MenuFields.MenuId.Name + "= '" + MAHIEU_PK + "'");
                BS_MENU.Position = DT_MENU.Rows.Count;

                txt_MENUID.Text = drCopy[0][MenuFields.MenuId.Name].ToString();
                txt_MENUNAME.Text = drCopy[0][MenuFields.MenuName.Name].ToString();
                txt_MAPHANHE.Text = drCopy[0][MenuFields.Maphanhe.Name].ToString();
                txt_MENUPARENT.Text = drCopy[0][MenuFields.Menuparent.Name].ToString();
                try { cbo_LOAIMENU.SelectedValue = int.Parse(drCopy[0][MenuFields.LoaiMenu.Name].ToString()); }
                catch { }
                txt_ICON.Text = drCopy[0][MenuFields.Icon.Name].ToString();
                try
                {
                    txt_THUTU.Text = Int32.Parse(drCopy[0][MenuFields.Thutu.Name].ToString()).ToString("#", new System.Globalization.CultureInfo("vi-VN"));
                }
                catch { }
                txt_FORMNAME.Text = drCopy[0][MenuFields.FormName.Name].ToString();
                txt_PARAM.Text = drCopy[0][MenuFields.Param.Name].ToString();
                try { chk_ISSUDUNG.Checked = Convert.ToBoolean(Convert.ToInt32(drCopy[0][MenuFields.Issudung.Name].ToString())); }
                catch { }

                txt_MENUPARENT_Validating(new object(), new CancelEventArgs());

                MAHIEU_PK = "";
                txt_MENUID.Focus();
                //TEXTBOX_Only_Control(false, null);
                // txt_MAHIEU.Text = DmcapmaManager.GET_MA_INT(DmcapmaManager.LOAI_MA_HIEU, false, KTXPT.DATA);
                FM.LIB.FORM_PROCESS_UTIL.enableControls(true, uiPanel1Container, new List<Control>(new Control[] { }));
                MenuroleManager.set_Enable_controls(FM.LIB.BUTTONACTION.BUTTONACTION_THEMMOI, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
                FUNCTION = GD.FM.LIB.BUTTONACTION.BUTTONACTION_THEMMOI;
                GRID_MENU.Enabled = false;
            }
            catch { }
            btn_CHONFILE.Enabled = true;
            btn_SAOCHEP.Enabled = false;
        }
        #endregion

        #region Validate
        private void txt_MENUPARENT_Validating(object sender, CancelEventArgs e)
        {
            _RowViewSelect = null;
            if (string.IsNullOrEmpty(txt_MENUPARENT.Text.Trim()) || DT_MENU == null || DT_MENU.Rows.Count == 0) return;
            string Str_MASIEUTHI = txt_MENUPARENT.Text.Trim().ToUpper();
            _RowViewSelect = checkmaMenu(Str_MASIEUTHI, DT_MENU);
            if (_RowViewSelect == null)
            {
                ListviewJanus _frm_SingerRows_Select =
                    new ListviewJanus(LIB.PATH.FM_PATH + @"\XMLCONFIG\FRM_MENU.xml",
                        DT_MENU, MenuFields.MenuId.Name, Str_MASIEUTHI);
                _frm_SingerRows_Select.ShowDialog();
                if (_frm_SingerRows_Select._RowViewSelect == null) return;
                _RowViewSelect = _frm_SingerRows_Select._RowViewSelect.Row;
                txt_MENUPARENT.Text = _RowViewSelect[MenuFields.MenuId.Name].ToString();
                txt_MENUPARENTNAME.Text = _RowViewSelect[MenuFields.MenuName.Name].ToString();
            }
            else
                txt_MENUPARENTNAME.Text = _RowViewSelect[MenuFields.MenuName.Name].ToString();
        }
        private DataRow checkmaMenu(string masieuthi, DataTable dt)
        {
            try
            {
                return dt.Select(MenuFields.MenuId.Name + "=" + "'" + masieuthi + "'").CopyToDataTable().Rows[0];
            }
            catch { return null; }
        }
        #endregion

        private void uiPanel0_Resize(object sender, EventArgs e)
        {
            //GRID_MENU.ColumnAutoResize = false;
            if (uiPanel0.Width > 820)
                GRID_MENU.ColumnAutoResize = true;
            else
                GRID_MENU.ColumnAutoResize = false;
        }

        private void FRM_MENU_FormClosing(object sender, FormClosingEventArgs e)
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
