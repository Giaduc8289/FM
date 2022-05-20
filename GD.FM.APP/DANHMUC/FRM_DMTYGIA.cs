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
    public partial class FRM_DMTYGIA : FRM_DMPARENT
    {
        private TygiaManager _TygiaManager = new TygiaManager();
        private TygiaEntity _TygiaEntity = new TygiaEntity();
        private MenuroleEntity _MenuroleEntity = new MenuroleEntity();
        private DataTable DT_DMTYGIA = new DataTable();
        private BindingSource BS_DMTYGIA = new BindingSource();
        private DataRow r_Insert = null;
        private GD.FM.CONTROL.JGridEX GRID_DMTYGIA = new GD.FM.CONTROL.JGridEX();
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
                        _MenuroleEntity = MenuroleManager.Return_Current_Menurole("FRM_DMTYGIA");
                        DT_DMTYGIA = LIB.SESSION_START.DT_DMTYGIA;
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

        public FRM_DMTYGIA()
        {
            InitializeComponent();
            TygiaManager _TygiaManager = new TygiaManager();
            DataTable dt111 = _TygiaManager.Clone();
            //GD.FM.LIB.GRID_COMM.Create_GRID_CONIG(dt111, LIB.PATH.FM_PATH + @"\XMLCONFIG\FRM_DMTYGIA.xml");
            GD.FM.LIB.FORM_PROCESS_UTIL.enableControls(false, uiPanel1Container, null);
            GD.FM.CONTROL.BUTTON.Loadimage(LIB.PATH.FM_PATH, btn_LUULAI, btn_LUULAI.Name + ".xml");
            GD.FM.CONTROL.BUTTON.Loadimage(LIB.PATH.FM_PATH, btn_SUA, btn_SUA.Name + ".xml");
            GD.FM.CONTROL.BUTTON.Loadimage(LIB.PATH.FM_PATH, btn_THEMMOI, btn_THEMMOI.Name + ".xml");
            GD.FM.CONTROL.BUTTON.Loadimage(LIB.PATH.FM_PATH, btn_XOA, btn_XOA.Name + ".xml");
            GD.FM.CONTROL.BUTTON.Loadimage(LIB.PATH.FM_PATH, btn_KHOIPHUC, btn_KHOIPHUC.Name + ".xml");
            GD.FM.CONTROL.BUTTON.Loadimage(LIB.PATH.FM_PATH, btn_Thoat, btn_Thoat.Name + ".xml");
            GD.FM.LIB.GRID_COMM.LOAD_GRID_UIPanel(LIB.PATH.FM_PATH + @"\XMLCONFIG\FRM_DMTYGIA.xml", GRID_DMTYGIA, uiPanel0Container);
            FORM_PROCESS();
            DataView Source_View = new DataView(DT_DMTYGIA);
            BS_DMTYGIA = new BindingSource();
            BS_DMTYGIA.DataSource = Source_View;
            GRID_DMTYGIA.DataSource = BS_DMTYGIA;
            BS_DMTYGIA.CurrentChanged += new EventHandler(BS_DMTYGIA_CurrentChanged);
            BS_DMTYGIA_CurrentChanged((new object()), (new EventArgs()));
            GD.FM.BLL.MenuroleManager.set_Enable_controls(GD.FM.LIB.BUTTONACTION.BUTTONACTION_LOAD, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            Application.ThreadException += new System.Threading.ThreadExceptionEventHandler(Application_ThreadException);
            btn_THEMMOI.Focus();
        }

        void BS_DMTYGIA_CurrentChanged(object sender, EventArgs e)
        {
            try
            {
                GD.FM.LIB.FORM_PROCESS_UTIL.clearControls(uiPanel1Container, GD.FM.LIB.FORM_PROCESS_UTIL.getAllControl(uiPanel1Container));
                if (BS_DMTYGIA.Current != null)
                {
                    DataRowView _Rowview = (DataRowView)this.BS_DMTYGIA.Current;
                    if (_Rowview != null)
                        MAHIEU_PK = _Rowview.Row[TygiaFields.Thang.Name].ToString();
                    txt_THANG.Text = _Rowview.Row[TygiaFields.Thang.Name].ToString();
                    txt_TYGIA.Text = _Rowview.Row[TygiaFields.Tygia.Name].ToString();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "BS_DMTYGIA_CurrentChanged"); }
        }

        #region Button
        private void btn_THEMMOI_Click(object sender, EventArgs e)
        {
            GD.FM.LIB.FORM_PROCESS_UTIL.enableControls(true, uiPanel1Container, new List<Control>(new Control[] { }));
            TygiaManager _TygiaManager = new TygiaManager();
            TygiaEntity _TygiaEntity = new TygiaEntity();
            r_Insert = DT_DMTYGIA.NewRow();
            DT_DMTYGIA.Rows.Add(r_Insert);
            BS_DMTYGIA.Position = DT_DMTYGIA.Rows.Count;
            MAHIEU_PK = "";
            txt_THANG.Focus();
            TEXTBOX_Only_Control(false, null);
            GD.FM.LIB.FORM_PROCESS_UTIL.enableControls(true, uiPanel1Container, new List<Control>(new Control[] { }));
            GD.FM.BLL.MenuroleManager.set_Enable_controls(GD.FM.LIB.BUTTONACTION.BUTTONACTION_THEMMOI, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            GRID_DMTYGIA.Enabled = false;
        }
        private void btn_SUA_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(MAHIEU_PK)) { return; }
            else
            {
                GD.FM.BLL.MenuroleManager.set_Enable_controls(GD.FM.LIB.BUTTONACTION.BUTTONACTION_SUA, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
                GD.FM.LIB.FORM_PROCESS_UTIL.enableControls(true, uiPanel1Container, new List<Control>(new Control[] { txt_THANG }));
                txt_TYGIA.Focus();
            }
            GRID_DMTYGIA.Enabled = false;
        }
        private void btn_KHOIPHUC_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(MAHIEU_PK) && r_Insert != null)
            {
                DT_DMTYGIA.Rows.Remove(r_Insert);
            }
            BS_DMTYGIA_CurrentChanged(new object(), new EventArgs());
            GD.FM.BLL.MenuroleManager.set_Enable_controls(GD.FM.LIB.BUTTONACTION.BUTTONACTION_CANCEL, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            FORM_PROCESS_UTIL.enableControls(false, uiPanel1Container, new List<Control>(new Control[] { }));
            GRID_DMTYGIA.Enabled = true;
        }
        private void btn_XOA_Click(object sender, EventArgs e)
        {
            GD.FM.LIB.FORM_PROCESS_UTIL.enableControls(false, uiPanel1Container, null);
            if (string.IsNullOrEmpty(MAHIEU_PK)) return;
            TygiaManager _TygiaManager = new TygiaManager();
            TygiaEntity _TygiaEntity = new TygiaEntity();
            _TygiaEntity = _TygiaManager.SelectOne(MAHIEU_PK);
            if (_TygiaEntity != null && MessageBox.Show("Xóa tỷ giá tháng: " + MAHIEU_PK + " - " + txt_TYGIA.Text, "Xóa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) ==
                   System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                    _TygiaManager.Delete(MAHIEU_PK);
                    GRID_DMTYGIA.CurrentRow.Delete();
                    BS_DMTYGIA_CurrentChanged(new object(), new EventArgs());
                    //GD.FM.LIB.TrayPopup.PoupStringMessage(GD.FM.APP.Properties.Resources.MessageTitle, GD.FM.APP.Properties.Resources.MessageContent_T);
                    GD.FM.LIB.TrayPopup.PoupStringMessage("Thông báo", "Đã xóa thành công!");
                    GD.FM.BLL.MenuroleManager.set_Enable_controls(_TygiaManager.Convert(_TygiaEntity), GD.FM.LIB.BUTTONACTION.BUTTONACTION_DELETE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
                }
                catch
                {
                    MessageBox.Show("Không thể xóa tỷ giá tháng " + MAHIEU_PK + "!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            GRID_DMTYGIA.Enabled = true;
        }
        private void btn_LUULAI_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(MAHIEU_PK) && _TygiaManager.SelectOne(txt_THANG.Text.Trim()) != null)
            {
                MessageBox.Show("Tháng bị trùng! \nNhập lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_THANG.Focus();
                return;
            }
            else if (txt_THANG.Text == "")
            {
                MessageBox.Show("Yêu cầu nhập tháng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_THANG.Focus();
                return;
            }
            else if (txt_TYGIA.Text == "")
            {
                MessageBox.Show("Yêu cầu nhập tỷ giá!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_TYGIA.Focus();
                return;
            }
            else
            {
                GD.FM.LIB.FORM_PROCESS_UTIL.enableControls(false, uiPanel1Container, null);
                MAHIEU_PK = Save_Data(MAHIEU_PK);
                GD.FM.LIB.TrayPopup.PoupStringMessage("Thông báo", "Lưu lại thành công");
                GRID_DMTYGIA.Enabled = true;
                btn_THEMMOI.Focus();
            }
        }
        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion

        private string Save_Data(string _str_DMCHUONG_PK)
        {
            TygiaEntity _TygiaEntity = new TygiaEntity();
            _TygiaEntity.Thang = txt_THANG.Text.Trim();
            try { _TygiaEntity.Tygia = Convert.ToDecimal(txt_TYGIA.Text.Trim()); }
            catch { }
            if (string.IsNullOrEmpty(_str_DMCHUONG_PK))
            {
                _TygiaEntity.Ngaytao = DateTime.Now;
                _TygiaEntity.Nguoitao = LIB.SESSION_START.TS_USER_LOGIN;
                _str_DMCHUONG_PK = _TygiaManager.InsertV2(_TygiaEntity, r_Insert, DT_DMTYGIA, BS_DMTYGIA);
                 GD.FM.BLL.MenuroleManager.set_Enable_controls(_TygiaManager.Convert(_TygiaEntity), GD.FM.LIB.BUTTONACTION.BUTTONACTION_INSERT, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
                BS_DMTYGIA.ResetCurrentItem();
            }
            else
            {
                _TygiaEntity.Ngaysua = DateTime.Now;
                _TygiaEntity.Nguoisua = LIB.SESSION_START.TS_USER_LOGIN;
                _TygiaManager.Update(_TygiaEntity);
                GRID_DMTYGIA.CurrentRow.Cells[TygiaFields.Thang.Name].Value = _TygiaEntity.Thang;
                GRID_DMTYGIA.CurrentRow.Cells[TygiaFields.Tygia.Name].Value = _TygiaEntity.Tygia;
                GD.FM.BLL.MenuroleManager.set_Enable_controls(_TygiaManager.Convert(_TygiaEntity), GD.FM.LIB.BUTTONACTION.BUTTONACTION_UPDATE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            }
            return _str_DMCHUONG_PK;
        }

        private void FRM_DMTYGIA_FormClosing(object sender, FormClosingEventArgs e)
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
