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
    public partial class FRM_DMNHANVIEN : FRM_DMPARENT
    {
        private NhanvienManager _NhanvienManager = new NhanvienManager();
        private NhanvienEntity _NhanvienEntity = new NhanvienEntity();
        private MenuroleEntity _MenuroleEntity = new MenuroleEntity();
        private DataTable DT_NHANVIEN = new DataTable();
        private BindingSource BS_DMNHANVIEN = new BindingSource();
        private DataRow r_Insert = null;
        private GD.FM.CONTROL.JGridEX GRID_DMNHANVIEN = new GD.FM.CONTROL.JGridEX();
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
                        _MenuroleEntity = MenuroleManager.Return_Current_Menurole("FRM_DMNHANVIEN");
                        DT_NHANVIEN = LIB.SESSION_START.DT_NHANVIEN;
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

        public FRM_DMNHANVIEN()
        {
            InitializeComponent();
            NhanvienManager _NhanvienManager = new NhanvienManager();
            DataTable dt111 = _NhanvienManager.Clone();
            //GD.FM.LIB.GRID_COMM.Create_GRID_CONIG(dt111, LIB.PATH.KDTM_PATH + @"\XMLCONFIG\FRM_DMNHANVIEN.xml");
            GD.FM.LIB.FORM_PROCESS_UTIL.enableControls(false, uiPanel1Container, null);
            GD.FM.CONTROL.BUTTON.Loadimage(LIB.PATH.KDTM_PATH, btn_LUULAI, btn_LUULAI.Name + ".xml");
            GD.FM.CONTROL.BUTTON.Loadimage(LIB.PATH.KDTM_PATH, btn_SUA, btn_SUA.Name + ".xml");
            GD.FM.CONTROL.BUTTON.Loadimage(LIB.PATH.KDTM_PATH, btn_THEMMOI, btn_THEMMOI.Name + ".xml");
            GD.FM.CONTROL.BUTTON.Loadimage(LIB.PATH.KDTM_PATH, btn_XOA, btn_XOA.Name + ".xml");
            GD.FM.CONTROL.BUTTON.Loadimage(LIB.PATH.KDTM_PATH, btn_KHOIPHUC, btn_KHOIPHUC.Name + ".xml");
            GD.FM.CONTROL.BUTTON.Loadimage(LIB.PATH.KDTM_PATH, btn_Thoat, btn_Thoat.Name + ".xml");
            GD.FM.LIB.GRID_COMM.LOAD_GRID_UIPanel(LIB.PATH.KDTM_PATH + @"\XMLCONFIG\FRM_DMNHANVIEN.xml", GRID_DMNHANVIEN, uiPanel0Container);
            FORM_PROCESS();
            DataView Source_View = new DataView(DT_NHANVIEN);
            BS_DMNHANVIEN = new BindingSource();
            BS_DMNHANVIEN.DataSource = Source_View;
            GRID_DMNHANVIEN.DataSource = BS_DMNHANVIEN;
            BS_DMNHANVIEN.CurrentChanged += new EventHandler(BS_DMNHANVIEN_CurrentChanged);
            BS_DMNHANVIEN_CurrentChanged((new object()), (new EventArgs()));
            GD.FM.BLL.MenuroleManager.set_Enable_controls(GD.FM.LIB.BUTTONACTION.BUTTONACTION_LOAD, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            Application.ThreadException += new System.Threading.ThreadExceptionEventHandler(Application_ThreadException);
            btn_THEMMOI.Focus();
        }

        void BS_DMNHANVIEN_CurrentChanged(object sender, EventArgs e)
        {
            try
            {
                GD.FM.LIB.FORM_PROCESS_UTIL.clearControls(uiPanel1Container, GD.FM.LIB.FORM_PROCESS_UTIL.getAllControl(uiPanel1Container));
                if (BS_DMNHANVIEN.Current != null)
                {
                    DataRowView _Rowview = (DataRowView)this.BS_DMNHANVIEN.Current;
                    if (_Rowview != null)
                        MAHIEU_PK = _Rowview.Row[NhanvienFields.Manhanvien.Name].ToString();
                    txt_MAHIEU.Text = _Rowview.Row[NhanvienFields.Manhanvien.Name].ToString();
                    txt_TENHIEU.Text = _Rowview.Row[NhanvienFields.Hoten.Name].ToString();
                    txt_DIACHI.Text = _Rowview.Row[NhanvienFields.Diachi.Name].ToString();
                    txt_SODIENTHOAI.Text = _Rowview.Row[NhanvienFields.Sodienthoai.Name].ToString();
                    txt_CHUCVU.Text = _Rowview.Row[NhanvienFields.Tenchucvu.Name].ToString();
                    dtp_NGAYSINH.Text = _Rowview.Row[NhanvienFields.Ngaysinh.Name].ToString();
                    txt_EMAIL.Text = _Rowview.Row[NhanvienFields.Email.Name].ToString();
                    try
                    {
                        rd_MALE.Checked = Convert.ToBoolean(_Rowview.Row[NhanvienFields.Gioitinh.Name].ToString());
                    }
                    catch { }
                    try
                    {
                        if (Convert.ToBoolean(_Rowview.Row[NhanvienFields.Gioitinh.Name]) == false)
                        {
                            rd_FEMALE.Checked = true;
                        }
                    }
                    catch { }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "BS_DMNHANVIEN_CurrentChanged"); }
        }

        private string Save_Data(string _str_DMCHUONG_PK)
        {
            NhanvienEntity _NhanvienEntity = new NhanvienEntity();
            _NhanvienEntity.Manhanvien = txt_MAHIEU.Text.Trim();
            _NhanvienEntity.Hoten = txt_TENHIEU.Text.Trim();
            _NhanvienEntity.Diachi = txt_DIACHI.Text.Trim();
            _NhanvienEntity.Sodienthoai = txt_SODIENTHOAI.Text.Trim();
            _NhanvienEntity.Tenchucvu = txt_CHUCVU.Text.Trim();
            _NhanvienEntity.Ngaysinh = Convert.ToDateTime(dtp_NGAYSINH.Text);
            _NhanvienEntity.Email = txt_EMAIL.Text.Trim();
            if (rd_MALE.Checked)
                _NhanvienEntity.Gioitinh = true;
            if (rd_FEMALE.Checked)
                _NhanvienEntity.Gioitinh = false;
            if (string.IsNullOrEmpty(_str_DMCHUONG_PK))
            { 
                _str_DMCHUONG_PK = _NhanvienManager.InsertV2(_NhanvienEntity, r_Insert, DT_NHANVIEN, BS_DMNHANVIEN);
                 GD.FM.BLL.MenuroleManager.set_Enable_controls(_NhanvienManager.Convert(_NhanvienEntity), GD.FM.LIB.BUTTONACTION.BUTTONACTION_INSERT, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
                BS_DMNHANVIEN.ResetCurrentItem();
            }
            else
            {
                _NhanvienManager.Update(_NhanvienEntity);
                GRID_DMNHANVIEN.CurrentRow.Cells[NhanvienFields.Manhanvien.Name].Value = _NhanvienEntity.Manhanvien;
                GRID_DMNHANVIEN.CurrentRow.Cells[NhanvienFields.Hoten.Name].Value = _NhanvienEntity.Hoten;
                GRID_DMNHANVIEN.CurrentRow.Cells[NhanvienFields.Diachi.Name].Value = _NhanvienEntity.Diachi;
                GRID_DMNHANVIEN.CurrentRow.Cells[NhanvienFields.Sodienthoai.Name].Value = _NhanvienEntity.Sodienthoai;
                GRID_DMNHANVIEN.CurrentRow.Cells[NhanvienFields.Tenchucvu.Name].Value = _NhanvienEntity.Tenchucvu;
                GRID_DMNHANVIEN.CurrentRow.Cells[NhanvienFields.Ngaysinh.Name].Value = _NhanvienEntity.Ngaysinh;
                GRID_DMNHANVIEN.CurrentRow.Cells[NhanvienFields.Email.Name].Value = _NhanvienEntity.Email;
                GRID_DMNHANVIEN.CurrentRow.Cells[NhanvienFields.Gioitinh.Name].Value = _NhanvienEntity.Gioitinh;

                GD.FM.BLL.MenuroleManager.set_Enable_controls(_NhanvienManager.Convert(_NhanvienEntity), GD.FM.LIB.BUTTONACTION.BUTTONACTION_UPDATE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            }
            return _str_DMCHUONG_PK;
        }

        #region Button
        private void btn_THEMMOI_Click(object sender, EventArgs e)
        {
            GD.FM.LIB.FORM_PROCESS_UTIL.enableControls(true, uiPanel1Container, new List<Control>(new Control[] { }));
            NhanvienManager _NhanvienManager = new NhanvienManager();
            NhanvienEntity _NhanvienEntity = new NhanvienEntity();
            r_Insert = DT_NHANVIEN.NewRow();
            DT_NHANVIEN.Rows.Add(r_Insert);
            BS_DMNHANVIEN.Position = DT_NHANVIEN.Rows.Count;
            MAHIEU_PK = "";
            txt_MAHIEU.Focus();
            TEXTBOX_Only_Control(false, null);
            GD.FM.LIB.FORM_PROCESS_UTIL.enableControls(true, uiPanel1Container, new List<Control>(new Control[] { }));
            GD.FM.BLL.MenuroleManager.set_Enable_controls(GD.FM.LIB.BUTTONACTION.BUTTONACTION_THEMMOI, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            GRID_DMNHANVIEN.Enabled = false;
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
            GRID_DMNHANVIEN.Enabled = false;
        }
        private void btn_KHOIPHUC_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(MAHIEU_PK) && r_Insert != null)
            {
                DT_NHANVIEN.Rows.Remove(r_Insert);
            }
            BS_DMNHANVIEN_CurrentChanged(new object(), new EventArgs());
            GD.FM.BLL.MenuroleManager.set_Enable_controls(GD.FM.LIB.BUTTONACTION.BUTTONACTION_CANCEL, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            FORM_PROCESS_UTIL.enableControls(false, uiPanel1Container, new List<Control>(new Control[] { }));
            GRID_DMNHANVIEN.Enabled = true;
        }
        private void btn_XOA_Click(object sender, EventArgs e)
        {
            GD.FM.LIB.FORM_PROCESS_UTIL.enableControls(false, uiPanel1Container, null);
            if (string.IsNullOrEmpty(MAHIEU_PK)) return;
            NhanvienManager _NhanvienManager = new NhanvienManager();
            NhanvienEntity _NhanvienEntity = new NhanvienEntity();
            _NhanvienEntity = _NhanvienManager.SelectOne(MAHIEU_PK);
            if (_NhanvienEntity != null && MessageBox.Show("Xóa Nhân viên: " + MAHIEU_PK + " - " + txt_TENHIEU.Text, "Xóa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) ==
                   System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                    _NhanvienManager.Delete(MAHIEU_PK);
                    GRID_DMNHANVIEN.CurrentRow.Delete();
                    BS_DMNHANVIEN_CurrentChanged(new object(), new EventArgs());
                    GD.FM.LIB.TrayPopup.PoupStringMessage("Thông báo", "Đã xóa thành công!");
                    GD.FM.BLL.MenuroleManager.set_Enable_controls(_NhanvienManager.Convert(_NhanvienEntity), GD.FM.LIB.BUTTONACTION.BUTTONACTION_DELETE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
                }
                catch
                {
                    MessageBox.Show("Không thể xóa Nhân viên " + MAHIEU_PK + "!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            GRID_DMNHANVIEN.Enabled = true;
        }
        private void btn_LUULAI_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(MAHIEU_PK) && _NhanvienManager.SelectOne(txt_MAHIEU.Text.Trim()) != null)
            {
                MessageBox.Show("Mã Nhân viên bị trùng! \nNhập lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_MAHIEU.Focus();
                return;
            }
            else if (txt_MAHIEU.Text == "")
            {
                MessageBox.Show("Yêu cầu nhập mã Nhân viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_MAHIEU.Focus();
                return;
            }
            else if (txt_TENHIEU.Text == "")
            {
                MessageBox.Show("Yêu cầu nhập tên Nhân viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_TENHIEU.Focus();
                return;
            }
            else
            {
                GD.FM.LIB.FORM_PROCESS_UTIL.enableControls(false, uiPanel1Container, null);
                MAHIEU_PK = Save_Data(MAHIEU_PK);
                GD.FM.LIB.TrayPopup.PoupStringMessage("Thông báo", "Lưu lại thành công");
                GRID_DMNHANVIEN.Enabled = true;
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
                GRID_DMNHANVIEN.ColumnAutoResize = true;
            else
                GRID_DMNHANVIEN.ColumnAutoResize = false;
        }

        private void FRM_DMKHACH_FormClosing(object sender, FormClosingEventArgs e)
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
