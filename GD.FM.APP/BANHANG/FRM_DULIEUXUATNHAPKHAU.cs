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

using ExcelDataReader;
using System.IO;

namespace GD.FM.APP.BANHANG
{
    public partial class FRM_DULIEUXUATNHAPKHAU : FRM_DMPARENT
    {
        private DulieuxnkManager _DulieuxnkManager = new DulieuxnkManager();
        private DulieuxnkEntity _DulieuxnkEntity = new DulieuxnkEntity();
        private MenuroleEntity _MenuroleEntity = new MenuroleEntity();
        private DataTable DT_DULIEUXNK_H = new DataTable(), DT_DULIEUXNK_D = new DataTable(), DT_DULIEUXNK_D_FILL = new DataTable(), DT_DULIEUXNK_COPY = new DataTable();
        private BindingSource BS_DULIEUXNK_H = new BindingSource(), BS_DULIEUXNK_D = new BindingSource();
        private DataRow r_Insert = null, _RowViewSelect = null, _RowDanhmuchanghoa = null;
        private GD.FM.CONTROL.JGridEX GRID_DULIEUXNK_H = new GD.FM.CONTROL.JGridEX();
        private GD.FM.CONTROL.JGridEX GRID_DULIEUXNK_D = new GD.FM.CONTROL.JGridEX();
        private string FUNCTION = "LOAD", MAHIEU_PK = "", MACHITIET = "", NAM = "", THANG = "";

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
                        _MenuroleEntity = MenuroleManager.Return_Current_Menurole("FRM_DULIEUXUATNHAPKHAU");
                        DateTime Ngaydauthang = LIB.SESSION_START.TS_NGAYDAUTHANG;
                        DateTime Ngaycuoithang = LIB.SESSION_START.TS_NGAYCUOITHANG;
                        DateTime MAHIEU_PK = LIB.SESSION_START.TS_NGAYLAMVIEC;
                        DT_DULIEUXNK_H = LIB.Procedures.Danhsachdulieuxnk(LIB.SESSION_START.TS_NGAYDAUNAM, LIB.SESSION_START.TS_NGAYCUOINAM);
                        //DT_DULIEUXNK_D = LIB.Procedures.Danhsachdulieuxnkchitiet(LIB.SESSION_START.TS_NGAYDAUNAM, LIB.SESSION_START.TS_NGAYCUOINAM);
                        DT_DULIEUXNK_D_FILL = new DulieuxnkManager().Clone();// DT_DULIEUXNK_D.Clone();
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

        public FRM_DULIEUXUATNHAPKHAU()
        {
            InitializeComponent();
            DulieuxnkManager _DulieuxnkManager = new DulieuxnkManager();
            DataTable dt111 = _DulieuxnkManager.Clone();
            //GD.FM.LIB.GRID_COMM.Create_GRID_CONIG(dt111, LIB.PATH.FM_PATH + @"\XMLCONFIG\FRM_DULIEUXUATNHAPKHAUCHITIET.xml");
            GD.FM.LIB.FORM_PROCESS_UTIL.enableControls(false, uiPanel1Container, null);
            GD.FM.CONTROL.BUTTON.Loadimage(LIB.PATH.FM_PATH, btn_LUULAI, btn_LUULAI.Name + ".xml");
            GD.FM.CONTROL.BUTTON.Loadimage(LIB.PATH.FM_PATH, btn_SUA, btn_SUA.Name + ".xml");
            GD.FM.CONTROL.BUTTON.Loadimage(LIB.PATH.FM_PATH, btn_THEMMOI, btn_THEMMOI.Name + ".xml");
            GD.FM.CONTROL.BUTTON.Loadimage(LIB.PATH.FM_PATH, btn_XOA, btn_XOA.Name + ".xml");
            GD.FM.CONTROL.BUTTON.Loadimage(LIB.PATH.FM_PATH, btn_NHANDULIEU, "btnchuyendulieu.xml");
            GD.FM.CONTROL.BUTTON.Loadimage(LIB.PATH.FM_PATH, btn_KHOIPHUC, btn_KHOIPHUC.Name + ".xml");
            GD.FM.CONTROL.BUTTON.Loadimage(LIB.PATH.FM_PATH, btn_Thoat, btn_Thoat.Name + ".xml");
            GD.FM.LIB.GRID_COMM.LOAD_GRID_UIPanel(LIB.PATH.FM_PATH + @"\XMLCONFIG\FRM_DULIEUXUATNHAPKHAU.xml", GRID_DULIEUXNK_H, uiPanel0Container);
            GD.FM.LIB.GRID_COMM.LOAD_GRID_UIPanel(LIB.PATH.FM_PATH + @"\XMLCONFIG\FRM_DULIEUXUATNHAPKHAUCHITIET.xml", GRID_DULIEUXNK_D, pne_CHITIET);
            //GRID_DULIEUXNK_H.RootTable.SortKeys.Add(DulieuxnkFields.Ngaykiemke.Name, Janus.Windows.GridEX.SortOrder.Ascending);
            //GRID_DULIEUXNK_D.FilterMode = FilterMode.None;
            //GRID_DULIEUXNK_D.RootTable.Columns["Chon"].ColumnType = ColumnType.CheckBox;
            //GRID_DULIEUXNK_D.RootTable.Columns["Chon"].EditType = EditType.NoEdit;
            //GRID_DULIEUXNK_D.RootTable.Columns["Chon"].CheckBoxTrueValue = true;
            //GRID_DULIEUXNK_D.RootTable.Columns["Chon"].CheckBoxFalseValue = false;
            //GRID_DULIEUXNK_D.RootTable.Columns["Chon"].Width = 20;
            //GRID_DULIEUXNK_D.RootTable.Columns["Chon"].Position = 0;
            //GRID_DULIEUXNK_D.RootTable.Columns["Chon"].ActAsSelector = true;
            //GRID_DULIEUXNK_D.GroupByBoxVisible = false; FORM_PROCESS();
            //GRID_DULIEUXNK_D.CellEdited += GRID_DULIEUXNK_D_CellEdited;
            //GRID_DULIEUXNK_D.RecordsDeleted += GRID_DULIEUXNK_D_RecordsDeleted;
            //GRID_DULIEUXNK_D.RecordUpdated += GRID_DULIEUXNK_D_RecordUpdated;
            //GRID_DULIEUXNK_D.DeletingRecord += GRID_DULIEUXNK_D_DeletingRecord;
            //GRID_DULIEUXNK_D.RootTable.Columns[DulieuxnkFields.Mauin.Name].EditType = EditType.NoEdit;
            ////GRID_DULIEUXNK_D.RootTable.Columns[DulieuxnkFields.Mahang.Name].EditType = EditType.NoEdit;
            //GRID_DULIEUXNK_D.RootTable.Columns[DulieuxnkFields.Makhach.Name].EditType = EditType.NoEdit;
            //GRID_DULIEUXNK_D.RootTable.Columns[DulieuxnkFields.Tenkhach.Name].EditType = EditType.NoEdit;
            DataView Source_View = new DataView(DT_DULIEUXNK_H);
            BS_DULIEUXNK_H = new BindingSource();
            BS_DULIEUXNK_H.DataSource = Source_View;
            GRID_DULIEUXNK_H.DataSource = BS_DULIEUXNK_H;
            BS_DULIEUXNK_H.CurrentChanged += new EventHandler(BS_DULIEUXNK_H_CurrentChanged);
            BS_DULIEUXNK_H_CurrentChanged((new object()), (new EventArgs()));
            GD.FM.BLL.MenuroleManager.set_Enable_controls(GD.FM.LIB.BUTTONACTION.BUTTONACTION_LOAD, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            Application.ThreadException += new System.Threading.ThreadExceptionEventHandler(Application_ThreadException);
            btn_THEMMOI.Focus();
            ContextMenuStrip.Enabled = false;
        }

        #region Xử lý Grid Detail
        private void GRID_DULIEUXNK_D_RecordUpdated(object sender, EventArgs e)
        {
        }

        private void GRID_DULIEUXNK_D_RecordsDeleted(object sender, EventArgs e)
        {
        }
        private void GRID_DULIEUXNK_D_CellEdited(object sender, ColumnActionEventArgs e)
        {
            ////binding mã hàng search theo mẫu in
            //if (e.Column.DataMember == DulieuxnkFields.Mahang.Name)
            //{
            //    _RowViewSelect = null;
            //    string mahang = GRID_DULIEUXNK_D.CurrentRow.Cells[DulieuxnkFields.Mahang.Name].Value.ToString();
            //    if (string.IsNullOrEmpty(mahang.Trim()) || DT_DMHANGHOA == null || DT_DMHANGHOA.Rows.Count == 0) return;
            //    string Str_MASIEUTHI = mahang.Trim().ToUpper();
            //    _RowViewSelect = checkMahang(Str_MASIEUTHI, DT_DMHANGHOA);
            //    if (_RowViewSelect == null)
            //    {
            //        ListviewJanus _frm_SingerRows_Select =
            //            new ListviewJanus(LIB.PATH.FM_PATH + @"\XMLCONFIG\FRM_DMHANGHOA.xml",
            //                DT_DMHANGHOA, DanhmuchanghoaFields.Mahieu.Name, Str_MASIEUTHI);
            //        _frm_SingerRows_Select.ShowDialog();
            //        if (_frm_SingerRows_Select._RowViewSelect == null) return;
            //        _RowViewSelect = _frm_SingerRows_Select._RowViewSelect.Row;
            //        GRID_DULIEUXNK_D.CurrentRow.Cells[DulieuxnkFields.Mahang.Name].Value = _RowViewSelect[DanhmuchanghoaFields.Mahieu.Name].ToString();
            //        GRID_DULIEUXNK_D.CurrentRow.Cells[DulieuxnkFields.Mauin.Name].Value = _RowViewSelect[DanhmuchanghoaFields.Mauin.Name].ToString();
            //        GRID_DULIEUXNK_D.CurrentRow.Cells[DulieuxnkFields.Makhach.Name].Value = _RowViewSelect[DanhmuchanghoaFields.Makhach.Name].ToString();
            //        GRID_DULIEUXNK_D.CurrentRow.Cells[DulieuxnkFields.Tenkhach.Name].Value = _RowViewSelect[DanhmuchanghoaFields.Tenkhach.Name].ToString();
            //        GRID_DULIEUXNK_D.CurrentRow.Cells[DulieuxnkFields.Mabenkho.Name].Value = _RowViewSelect[DanhmuchanghoaFields.Makho.Name].ToString();
            //    }
            //    else
            //    {
            //        GRID_DULIEUXNK_D.CurrentRow.Cells[DulieuxnkFields.Mauin.Name].Value = _RowViewSelect[DanhmuchanghoaFields.Mauin.Name].ToString();
            //        GRID_DULIEUXNK_D.CurrentRow.Cells[DulieuxnkFields.Makhach.Name].Value = _RowViewSelect[DanhmuchanghoaFields.Makhach.Name].ToString();
            //        GRID_DULIEUXNK_D.CurrentRow.Cells[DulieuxnkFields.Tenkhach.Name].Value = _RowViewSelect[DanhmuchanghoaFields.Tenkhach.Name].ToString();
            //        GRID_DULIEUXNK_D.CurrentRow.Cells[DulieuxnkFields.Mabenkho.Name].Value = _RowViewSelect[DanhmuchanghoaFields.Makho.Name].ToString();
            //    }

            //}
        }
        private void GRID_DULIEUXNK_D_DeletingRecord(object sender, RowActionCancelEventArgs e)
        {
            btn_XOADONG_Click(new object(), new EventArgs());
        }
        #endregion

        void BS_DULIEUXNK_H_CurrentChanged(object sender, EventArgs e)
        {
            try
            {
                GRID_DULIEUXNK_H.UpdateData();
                if (BS_DULIEUXNK_H.Current != null)
                {
                    DataRowView _Rowview = (DataRowView)this.BS_DULIEUXNK_H.Current;
                    if (_Rowview != null)
                        MAHIEU_PK = _Rowview.Row[DulieuxnkFields.Nam.Name].ToString();
                    NAM = _Rowview.Row[DulieuxnkFields.Nam.Name].ToString();
                    THANG = _Rowview.Row[DulieuxnkFields.Thang.Name].ToString();

                    SHOWGRID(MAHIEU_PK);
                }
                else
                {
                    SHOWGRID("");
                    GD.FM.LIB.FORM_PROCESS_UTIL.clearControls(uiPanel1Container, GD.FM.LIB.FORM_PROCESS_UTIL.getAllControl(uiPanel1Container));
                }
            }
            catch { }
        }

        void BS_DULIEUXNK_D_CurrentChanged(object sender, EventArgs e)
        {
            try
            {
                if (BS_DULIEUXNK_D.Current != null)
                {
                    DataRowView _Rowview = (DataRowView)this.BS_DULIEUXNK_D.Current;
                    if (_Rowview != null)
                        MACHITIET = _Rowview.Row[DulieuxnkFields.Id.Name].ToString();
                }
                else
                {
                    GD.FM.LIB.FORM_PROCESS_UTIL.clearControls(uiPanel1Container, GD.FM.LIB.FORM_PROCESS_UTIL.getAllControl(uiPanel1Container));
                }
            }
            catch
            {
                MessageBox.Show("Dữ liệu nhập vào chưa đúng, xin mời nhập lại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void SHOWGRID(string MAHIEU_PK)
        {
            if (string.IsNullOrEmpty(MAHIEU_PK))
            {
                DT_DULIEUXNK_D = DT_DULIEUXNK_D.Clone();
                BS_DULIEUXNK_D = new BindingSource(DT_DULIEUXNK_D, null);
                GRID_DULIEUXNK_D.DataSource = BS_DULIEUXNK_D;
            }
            else
            {
                DT_DULIEUXNK_D = new DulieuxnkManager().SelectBy_Nam_Thang(NAM, THANG);

                DataView Source_View = new DataView(DT_DULIEUXNK_D);
                BS_DULIEUXNK_D = new BindingSource();
                BS_DULIEUXNK_D.DataSource = Source_View;
                GRID_DULIEUXNK_D.DataSource = BS_DULIEUXNK_D;
            }
            BS_DULIEUXNK_D.CurrentChanged += new EventHandler(BS_DULIEUXNK_D_CurrentChanged);
            BS_DULIEUXNK_D_CurrentChanged((new object()), (new EventArgs()));
        }

        #region Button
        private void btn_THEMMOI_Click(object sender, EventArgs e)
        {
            GD.FM.LIB.FORM_PROCESS_UTIL.enableControls(true, uiPanel1Container, new List<Control>(new Control[] { }));
            DulieuxnkManager _DulieuxnkManager = new DulieuxnkManager();
            DulieuxnkEntity _DulieuxnkEntity = new DulieuxnkEntity();
            r_Insert = DT_DULIEUXNK_H.NewRow();
            DT_DULIEUXNK_H.Rows.Add(r_Insert);
            BS_DULIEUXNK_H.Position = DT_DULIEUXNK_H.Rows.Count;
            GRID_DULIEUXNK_D.Enabled = true;
            GRID_DULIEUXNK_D.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.True;
            GRID_DULIEUXNK_D.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.True;
            GRID_DULIEUXNK_D.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.True;
            GRID_DULIEUXNK_D.NewRowPosition = Janus.Windows.GridEX.NewRowPosition.BottomRow;
            MAHIEU_PK = "";
            TEXTBOX_Only_Control(false, null);
            GD.FM.LIB.FORM_PROCESS_UTIL.enableControls(true, uiPanel1Container, new List<Control>(new Control[] { }));
            GD.FM.BLL.MenuroleManager.set_Enable_controls(GD.FM.LIB.BUTTONACTION.BUTTONACTION_THEMMOI, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            GRID_DULIEUXNK_H.Enabled = false;
            ContextMenuStrip.Enabled = true;

        }

        private void btn_SUA_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(MAHIEU_PK)) { return; }
            else
            {
                GD.FM.BLL.MenuroleManager.set_Enable_controls(GD.FM.LIB.BUTTONACTION.BUTTONACTION_SUA, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
                GD.FM.LIB.FORM_PROCESS_UTIL.enableControls(true, uiPanel1Container, new List<Control>(new Control[] {  }));
            }
            GRID_DULIEUXNK_D.NewRowPosition = Janus.Windows.GridEX.NewRowPosition.BottomRow;
            GRID_DULIEUXNK_D.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.True;
            GRID_DULIEUXNK_D.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.True;
            GRID_DULIEUXNK_D.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.True;
            GRID_DULIEUXNK_D.Enabled = true;
            GRID_DULIEUXNK_H.Enabled = false;
            ContextMenuStrip.Enabled = true;
        }

        private void btn_XOA_Click(object sender, EventArgs e)
        {
            GD.FM.LIB.FORM_PROCESS_UTIL.enableControls(false, uiPanel1Container, null);
            if (string.IsNullOrEmpty(MAHIEU_PK)) return;
            DulieuxnkManager _DulieuxnkManager = new DulieuxnkManager();
            DulieuxnkEntity _DulieuxnkEntity = new DulieuxnkEntity();
            //_DulieuxnkEntity = _DulieuxnkManager.SelectOne(MAHIEU_PK);
            if (_DulieuxnkEntity != null && MessageBox.Show("Xóa tháng " + THANG +"/" + NAM , "Xóa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) ==
                   System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                    GridEXRow[] listGrid = GRID_DULIEUXNK_D.GetDataRows();
                    foreach (GridEXRow _grid in listGrid)
                    {
                        DataRowView _view = (DataRowView)_grid.DataRow;
                        if (_view == null) continue;
                        if (!string.IsNullOrEmpty(_view[DulieuxnkFields.Id.Name].ToString()))
                        {
                            try { _DulieuxnkManager.Delete(Convert.ToInt64(_view[DulieuxnkFields.Id.Name].ToString())); }
                            catch { }
                        }
                    }
                    try { GRID_DULIEUXNK_H.CurrentRow.Delete(); }
                    catch { }
                    BS_DULIEUXNK_H_CurrentChanged(new object(), new EventArgs());
                    GD.FM.LIB.TrayPopup.PoupStringMessage("Thông báo", "Đã xóa thành công!");
                    GD.FM.BLL.MenuroleManager.set_Enable_controls(_DulieuxnkManager.Convert(_DulieuxnkEntity), GD.FM.LIB.BUTTONACTION.BUTTONACTION_DELETE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
                }
                catch
                {
                    MessageBox.Show("Không thể xóa tháng " + THANG + "/" + NAM + "!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            GRID_DULIEUXNK_D.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.False;
            GRID_DULIEUXNK_D.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            GRID_DULIEUXNK_D.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.False;
            GRID_DULIEUXNK_H.Enabled = true;
            ContextMenuStrip.Enabled = false;
        }

        private void btn_KHOIPHUC_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(MAHIEU_PK) && r_Insert != null)
            {
                DT_DULIEUXNK_H.Rows.Remove(r_Insert);
            }
            BS_DULIEUXNK_H_CurrentChanged(new object(), new EventArgs());
            GD.FM.BLL.MenuroleManager.set_Enable_controls(GD.FM.LIB.BUTTONACTION.BUTTONACTION_CANCEL, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            FORM_PROCESS_UTIL.enableControls(false, uiPanel1Container, new List<Control>(new Control[] { }));
            GRID_DULIEUXNK_D.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.False;
            GRID_DULIEUXNK_D.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            GRID_DULIEUXNK_D.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.False;
            GRID_DULIEUXNK_H.Enabled = true;
            ContextMenuStrip.Enabled = false;
        }

        private void btn_LUULAI_Click(object sender, EventArgs e)
        {
            {
                GD.FM.LIB.FORM_PROCESS_UTIL.enableControls(false, uiPanel1Container, null);
                MAHIEU_PK = Save_Data(MAHIEU_PK);
                GD.FM.LIB.TrayPopup.PoupStringMessage("Thông báo", "Lưu lại thành công");
                GRID_DULIEUXNK_H.Enabled = true;
                //BS_DULIEUXNK_H.MoveLast();
                btn_THEMMOI.Focus();
                GRID_DULIEUXNK_D.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.False;
                GRID_DULIEUXNK_D.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
                GRID_DULIEUXNK_D.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.False;
                ContextMenuStrip.Enabled = false;
            }
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_LAMMOI_Click(object sender, EventArgs e)
        {
            //DT_DMKHACH = LIB.SESSION_START.DT_DMKHACH;
            //DT_DMHANGHOA = LIB.SESSION_START.DT_DMHANGHOA;
        }

        private void btn_TIMKIEM_Click(object sender, EventArgs e)
        {
        }

        private void btn_THEMDONG_Click(object sender, EventArgs e)
        {
            //DataRow r_Detail = DT_DULIEUXNK_D.NewRow();
            //r_Detail[DulieuxnkFields.Ngaykiemke.Name] = Convert.ToDateTime(txt_NGAY.Text.Trim());
            //r_Detail[DulieuxnkFields.Makhach.Name] = txt_MAKHACH.Text.Trim();
            //r_Detail[DulieuxnkFields.Tenkhach.Name] = txt_TENKHACH.Text.Trim();
            //r_Detail[DulieuxnkFields.Mahang.Name] = txt_MATHANG.Text.Trim();
            //r_Detail[DulieuxnkFields.Mauin.Name] = txt_MAUIN.Text.Trim();
            //try { r_Detail[DulieuxnkFields.Soluong.Name] = LIB.ConvertString.NumbertoDB(txt_SOLUONG.Text.Trim()); }
            //catch { }
            //try { r_Detail[DulieuxnkFields.Khoiluong.Name] = LIB.ConvertString.NumbertoDB(txt_KHOILUONG.Text.Trim()); }
            //catch { }
            //DT_DULIEUXNK_D.Rows.Add(r_Detail);
            //BS_DULIEUXNK_D.Position = DT_DULIEUXNK_D.Rows.Count;

            //DataView Source_View = new DataView(DT_DULIEUXNK_D);
            //BS_DULIEUXNK_D = new BindingSource();
            //BS_DULIEUXNK_D.DataSource = Source_View;
            //GRID_DULIEUXNK_D.DataSource = BS_DULIEUXNK_D;
            //txt_MATHANG.Focus();
        }

        private void btn_XOADONG_Click(object sender, EventArgs e)
        {
            DataRowView _view = (DataRowView)GRID_DULIEUXNK_D.CurrentRow.DataRow;
            string _MAHIEU_PK = _view[DulieuxnkFields.Id.Name].ToString();
            string _MAHANG = _view[DulieuxnkFields.Sotokhai.Name].ToString();
            if (string.IsNullOrEmpty(_MAHIEU_PK) && MessageBox.Show("Xóa dòng: " + _MAHANG, "Xóa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) ==
                   System.Windows.Forms.DialogResult.Yes)
            {
                GRID_DULIEUXNK_D.CurrentRow.Delete();
            }
            else
            {
                DulieuxnkManager _DulieuxnkManager = new DulieuxnkManager();
                DulieuxnkEntity _DulieuxnkEntity = new DulieuxnkEntity();
                try { _DulieuxnkEntity = _DulieuxnkManager.SelectOne(Convert.ToInt64(_MAHIEU_PK)); }
                catch { }
                if (_DulieuxnkEntity != null && MessageBox.Show("Xóa dòng: " + _MAHANG, "Xóa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) ==
                       System.Windows.Forms.DialogResult.Yes)
                {
                    try
                    {
                        _DulieuxnkManager.Delete(Convert.ToInt64(_MAHIEU_PK));
                        DataRow[] drArr = DT_DULIEUXNK_D.Select(DulieuxnkFields.Id.Name + "='" + _MAHIEU_PK + "'");
                        DT_DULIEUXNK_D.Rows.Remove(drArr[0]);
                    }
                    catch
                    {
                        MessageBox.Show("Không thể xóa dòng " + _MAHANG + "!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    BS_DULIEUXNK_D.ResetCurrentItem();
                    GRID_DULIEUXNK_D.DataSource = BS_DULIEUXNK_D;
                }
            }
            
            GRID_DULIEUXNK_D.Enabled = true;
        }

        private void btn_NHANDULIEU_Click(object sender, EventArgs e)
        {
            try
            {
                FRM_NHANDULIEUXNK frm = new FRM_NHANDULIEUXNK();
                frm.ShowDialog();
                if (frm._DialogResult == DialogResult.No) return;
                string PathFile = frm._PathFile;

                if(!string.IsNullOrEmpty(PathFile))
                {
                    ////------Kiểm tra xem đã có dữ liệu Ngaykiemke chưa, nếu có có ghi đè dữ liệu lên không
                    ////------Nếu có ghi đè dữ liệu: Xóa dữ liệu Ngaykiemke và Insert dữ liệu từ file Excel
                    //if (new DulieuxnkManager().SelectByNgaykiemkeRDT(Ngaykiemke).Rows.Count > 0)
                    //{
                    //    DialogResult dlgResult = MessageBox.Show("Đã có dữ liệu kiểm kê ngày " + Ngaykiemke.ToString("dd/MM/yyyy") + "! Bạn có muốn nhận lại không?", "Thông báo"
                    //        , MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                    //    if (dlgResult == DialogResult.Yes)
                    //    {
                            Cursor _cur = Cursor.Current;
                            Cursor.Current = Cursors.WaitCursor;
                            //new DulieuxnkManager().DeleteByNgaykiemke(Ngaykiemke);
                            Nhandulieu(PathFile);
                            Cursor.Current = _cur;
                            GD.FM.LIB.TrayPopup.PoupStringMessage("Thông báo", "Nhận dữ liệu kiểm kê thành công");
                        //}
                        //else if(dlgResult == DialogResult.No)
                        //{
                        //    Cursor _cur = Cursor.Current;
                        //    Cursor.Current = Cursors.WaitCursor;
                        //    Nhandulieu(PathFile, Ngaykiemke);
                        //    Cursor.Current = _cur;
                        //    GD.FM.LIB.TrayPopup.PoupStringMessage("Thông báo", "Nhận dữ liệu kiểm kê thành công");
                        //}
                    }
                    //else
                    //{
                    //    Cursor _cur = Cursor.Current;
                    //    Cursor.Current = Cursors.WaitCursor;
                    //    Nhandulieu(PathFile, Ngaykiemke);
                    //    Cursor.Current = _cur;
                    //    GD.FM.LIB.TrayPopup.PoupStringMessage("Thông báo", "Nhận dữ liệu kiểm kê thành công");
                    //}
                //}

                //DateTime Ngaydauthang = LIB.SESSION_START.TS_NGAYDAUTHANG;
                //DateTime Ngaycuoithang = LIB.SESSION_START.TS_NGAYCUOITHANG;
                DT_DULIEUXNK_H = LIB.Procedures.Danhsachdulieuxnk(LIB.SESSION_START.TS_NGAYDAUNAM, LIB.SESSION_START.TS_NGAYCUOINAM);
                DataView Source_View_H = new DataView(DT_DULIEUXNK_H);
                BS_DULIEUXNK_H = new BindingSource();
                BS_DULIEUXNK_H.DataSource = Source_View_H;
                GRID_DULIEUXNK_H.DataSource = BS_DULIEUXNK_H;
                BS_DULIEUXNK_H.CurrentChanged += new EventHandler(BS_DULIEUXNK_H_CurrentChanged);
                BS_DULIEUXNK_H_CurrentChanged((new object()), (new EventArgs()));
            }
            catch { }
        }
        private void Nhandulieu(string PathFile)
        {
            try
            {
                //---------Insert dữ liệu từ file Excel
                DataSet dsDulieuxnk = new DataSet();
                using (var stream = File.Open(PathFile, FileMode.Open, FileAccess.Read))
                {
                    IExcelDataReader reader;
                    reader = ExcelReaderFactory.CreateOpenXmlReader(stream);
                    dsDulieuxnk = reader.AsDataSet(new ExcelDataSetConfiguration()
                    {
                        ConfigureDataTable = (_) => new ExcelDataTableConfiguration()
                        {
                            UseHeaderRow = true
                        }
                    });
                    reader.Close();
                }

                EntityCollection _DulieuxnkEntityCol = new EntityCollection();
                foreach (DataRow dr in dsDulieuxnk.Tables[0].Rows)
                {
                    if (string.IsNullOrEmpty(dr[9].ToString()))
                        continue;

                    DulieuxnkEntity _DulieuxnkEntity = new DulieuxnkEntity();
                    try { _DulieuxnkEntity.Nam = Convert.ToInt32(dr[0].ToString()); }
                    catch { }
                    try { _DulieuxnkEntity.Thang = Convert.ToInt32(dr[1].ToString()); }
                    catch { }
                    try { _DulieuxnkEntity.Ngaythongquan = Convert.ToDateTime(dr[2].ToString()); }
                    catch { }
                    _DulieuxnkEntity.Masothuexuat = dr[3].ToString();
                    _DulieuxnkEntity.Tencongtyxuat = dr[4].ToString();
                    _DulieuxnkEntity.Diachicongtyxuat = dr[5].ToString();
                    _DulieuxnkEntity.Dienthoaicongtyxuat = dr[6].ToString();
                    _DulieuxnkEntity.Tencongtynhap = dr[7].ToString();
                    _DulieuxnkEntity.Diachicongtynhap = dr[8].ToString();
                    _DulieuxnkEntity.Hscode = dr[9].ToString();
                    _DulieuxnkEntity.Motahanghoa = dr[10].ToString();
                    try { _DulieuxnkEntity.Thuexuat = Convert.ToDecimal(dr[11].ToString()); }
                    catch { }
                    _DulieuxnkEntity.Xuatxu = dr[12].ToString();
                    _DulieuxnkEntity.Madonvi = dr[13].ToString();
                    try { _DulieuxnkEntity.Sotan = Convert.ToDecimal(dr[14].ToString()); }
                    catch { }
                    try { _DulieuxnkEntity.Giausd = Convert.ToDecimal(dr[15].ToString()); }
                    catch { }
                    try { _DulieuxnkEntity.Soluong = Convert.ToDecimal(dr[16].ToString()); }
                    catch { }
                    try { _DulieuxnkEntity.Dongianguyente = Convert.ToDecimal(dr[17].ToString()); }
                    catch { }
                    try { _DulieuxnkEntity.Dongiausd = Convert.ToDecimal(dr[18].ToString()); }
                    catch { }
                    try { _DulieuxnkEntity.Trigiausd = Convert.ToDecimal(dr[19].ToString()); }
                    catch { }
                    try { _DulieuxnkEntity.Tygiavnd = Convert.ToDecimal(dr[20].ToString()); }
                    catch { }
                    _DulieuxnkEntity.Madongtien = dr[21].ToString();
                    _DulieuxnkEntity.Dieukiengia = dr[22].ToString();
                    _DulieuxnkEntity.Phuongthucthanhtoan = dr[23].ToString();
                    _DulieuxnkEntity.Chicuchaiquan = dr[24].ToString();
                    _DulieuxnkEntity.Loaihinhxuatkhau = dr[25].ToString();
                    _DulieuxnkEntity.Tennuocxuatkhau = dr[26].ToString();
                    _DulieuxnkEntity.Tennuocnhapkhau = dr[27].ToString();
                    _DulieuxnkEntity.Diadiemxephang = dr[28].ToString();
                    _DulieuxnkEntity.Diadiemnhanhangcuoicung = dr[29].ToString();
                    _DulieuxnkEntity.Sotokhai = dr[30].ToString();

                    _DulieuxnkEntityCol.Add(_DulieuxnkEntity);
                }

                if (_DulieuxnkEntityCol.Count > 0)
                {
                    foreach (DulieuxnkEntity _nkhtEntity in _DulieuxnkEntityCol)
                    {
                        _DulieuxnkManager.Insert(_nkhtEntity);
                    }
                }
            }
            catch { }
        }
        #endregion

        private string Save_Data(string _str_DMCHUONG_PK)
        {
            EntityCollection _DulieuxnkEntityCol = new EntityCollection();
            GridEXRow[] listGrid = GRID_DULIEUXNK_D.GetDataRows();
            foreach (GridEXRow _grid in listGrid)
            {
                DataRowView _view = (DataRowView)_grid.DataRow;
                if (_view == null) continue;
                DulieuxnkEntity _DulieuxnkEntity = new DulieuxnkEntity();
                try { _DulieuxnkEntity.Nam = Convert.ToInt32(_view[DulieuxnkFields.Nam.Name].ToString()); }
                catch { }
                try { _DulieuxnkEntity.Thang = Convert.ToInt32(_view[DulieuxnkFields.Thang.Name].ToString()); }
                catch { }
                try { _DulieuxnkEntity.Ngaythongquan = Convert.ToDateTime(_view[DulieuxnkFields.Ngaythongquan.Name].ToString()); }
                catch { }
                _DulieuxnkEntity.Masothuexuat = _view[DulieuxnkFields.Masothuexuat.Name].ToString();
                _DulieuxnkEntity.Tencongtyxuat = _view[DulieuxnkFields.Tencongtyxuat.Name].ToString();
                _DulieuxnkEntity.Diachicongtyxuat = _view[DulieuxnkFields.Diachicongtyxuat.Name].ToString();
                _DulieuxnkEntity.Dienthoaicongtyxuat = _view[DulieuxnkFields.Dienthoaicongtyxuat.Name].ToString();

                try { _DulieuxnkEntity.Soluong = Convert.ToInt32(_view[DulieuxnkFields.Soluong.Name].ToString()); }
                catch { }

                try { _DulieuxnkEntity.Id = Convert.ToInt64(_view[DulieuxnkFields.Id.Name].ToString()); }
                catch { }

                _DulieuxnkEntity.IsNew = _view.Row.RowState == DataRowState.Added ? true : false;
                if (_DulieuxnkEntity.IsNew && _DulieuxnkManager.SelectOne(_DulieuxnkEntity.Id) != null)
                    _DulieuxnkEntity.IsNew = false;

                _DulieuxnkEntityCol.Add(_DulieuxnkEntity);
            }

            if (_DulieuxnkEntityCol.Count > 0)
            {
                foreach (DulieuxnkEntity _nkhtEntity in _DulieuxnkEntityCol)
                {
                    if (_nkhtEntity.IsNew)
                    {
                        //_nkhtEntity.Ngaytao = DateTime.Now;
                        //_nkhtEntity.Nguoitao = LIB.SESSION_START.TS_USER_LOGIN;
                        _DulieuxnkManager.Insert(_nkhtEntity);
                    }
                    else
                    {
                        //_nkhtEntity.Ngaysua = DateTime.Now;
                        //_nkhtEntity.Nguoisua = LIB.SESSION_START.TS_USER_LOGIN;
                        _DulieuxnkManager.Update(_nkhtEntity);
                    }
                }

                if (string.IsNullOrEmpty(_str_DMCHUONG_PK))
                {
                    _str_DMCHUONG_PK = THANG + "/" + NAM;
                    GD.FM.BLL.MenuroleManager.set_Enable_controls(_DulieuxnkManager.Convert(_DulieuxnkEntity), GD.FM.LIB.BUTTONACTION.BUTTONACTION_INSERT, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
                    ContextMenuStrip.Enabled = false;
                    BS_DULIEUXNK_H.ResetCurrentItem();
                    BS_DULIEUXNK_H_CurrentChanged(new object(), new EventArgs());
                }
                else
                {
                    GRID_DULIEUXNK_H.CurrentRow.Cells[DulieuxnkFields.Nam.Name].Value = NAM; //_DulieuxnkEntity.Makho;
                    GRID_DULIEUXNK_H.CurrentRow.Cells[DulieuxnkFields.Thang.Name].Value = THANG; //_DulieuxnkEntity.Tenkho;
                    GD.FM.BLL.MenuroleManager.set_Enable_controls(_DulieuxnkManager.Convert(_DulieuxnkEntity), GD.FM.LIB.BUTTONACTION.BUTTONACTION_UPDATE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
                    BS_DULIEUXNK_H.ResetCurrentItem();
                    BS_DULIEUXNK_H_CurrentChanged(new object(), new EventArgs());
                }
            }
            else
                btn_KHOIPHUC_Click(new object(), new EventArgs());
            return _str_DMCHUONG_PK;
        }

        #region Shortcut Key
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            //if (keyData == (Keys.Add))
            //{
            //    btn_THEMDONG.PerformClick();
            //    return true;
            //}
            //if (keyData == (Keys.Subtract))
            //{
            //    btn_XOADONG.PerformClick();
            //    return true;
            //}
            //if (keyData == (Keys.F5))
            //{
            //    btn_LAMMOI.PerformClick();
            //    return true;
            //}
            return base.ProcessCmdKey(ref msg, keyData);
        }
        #endregion

        #region Mouse Hover
        private void btn_LUULAI_MouseHover(object sender, EventArgs e)
        {
            toolTip.Show("Phím tắt: CTRL + S hoặc ALT + L ", btn_LUULAI);
        }
        private void btn_XOA_MouseHover(object sender, EventArgs e)
        {
            toolTip.Show("Phím tắt: ALT + X ", btn_XOA);
        }
        private void btn_KHOIPHUC_MouseHover(object sender, EventArgs e)
        {
            toolTip.Show("Phím tắt: ALT + K ", btn_KHOIPHUC);
        }
        private void btn_NHANDULIEU_MouseHover(object sender, EventArgs e)
        {
            toolTip.Show("Phím tắt: ALT + D ", btn_NHANDULIEU);
        }
        private void btn_SUA_MouseHover(object sender, EventArgs e)
        {
            toolTip.Show("Phím tắt: ALT + S ", btn_SUA);
        }
        private void btn_THEMMOI_MouseHover(object sender, EventArgs e)
        {
            toolTip.Show("Phím tắt: ALT + M ", btn_THEMMOI);
        }
        private void btn_Thoat_MouseHover(object sender, EventArgs e)
        {
            toolTip.Show("Phím tắt: ALT + T ", btn_Thoat);
        }
        #endregion
        
        #region ToolStripMenu
        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DT_DULIEUXNK_COPY.Clear();
            DT_DULIEUXNK_COPY.Columns.Clear();
            //DT_DULIEUXNK_COPY.Columns.Add(DulieuxnkFields.Ngaykiemke.Name);
            //DT_DULIEUXNK_COPY.Columns.Add(DulieuxnkFields.Mahang.Name);
            //DT_DULIEUXNK_COPY.Columns.Add(DulieuxnkFields.Makhach.Name);
            //DT_DULIEUXNK_COPY.Columns.Add(DulieuxnkFields.Tenkhach.Name);
            //DT_DULIEUXNK_COPY.Columns.Add(DulieuxnkFields.Tenhang.Name);
            //DT_DULIEUXNK_COPY.Columns.Add(DulieuxnkFields.Mauin.Name);
            //DT_DULIEUXNK_COPY.Columns.Add(DulieuxnkFields.Soluong.Name);
            //DT_DULIEUXNK_COPY.Columns.Add(DulieuxnkFields.Khoiluong.Name);

            GridEXRow[] listGrid = GRID_DULIEUXNK_D.GetDataRows();
            foreach (GridEXRow _grid in listGrid)
            {
                if (Convert.ToBoolean(_grid.Cells["Chon"].Value))
                {
                    DT_DULIEUXNK_COPY.Rows.Add(_grid.Cells[1].Value, _grid.Cells[2].Value, _grid.Cells[3].Value, _grid.Cells[4].Value,
                        _grid.Cells[5].Value, _grid.Cells[6].Value, _grid.Cells[7].Value, _grid.Cells[8].Value, _grid.Cells[9].Value
                       );
                }
            }
        }
        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Copy
            DT_DULIEUXNK_COPY.Clear();
            DT_DULIEUXNK_COPY.Columns.Clear();
            //DT_DULIEUXNK_COPY.Columns.Add(DulieuxnkFields.Ngaykiemke.Name);
            //DT_DULIEUXNK_COPY.Columns.Add(DulieuxnkFields.Mahang.Name);
            //DT_DULIEUXNK_COPY.Columns.Add(DulieuxnkFields.Makhach.Name);
            //DT_DULIEUXNK_COPY.Columns.Add(DulieuxnkFields.Tenkhach.Name);
            //DT_DULIEUXNK_COPY.Columns.Add(DulieuxnkFields.Tenhang.Name);
            //DT_DULIEUXNK_COPY.Columns.Add(DulieuxnkFields.Mauin.Name);
            //DT_DULIEUXNK_COPY.Columns.Add(DulieuxnkFields.Soluong.Name);
            //DT_DULIEUXNK_COPY.Columns.Add(DulieuxnkFields.Khoiluong.Name);

            GridEXRow[] listGrid = GRID_DULIEUXNK_D.GetDataRows();
            foreach (GridEXRow _grid in listGrid)
            {
                if (Convert.ToBoolean(_grid.Cells["Chon"].Value))
                {
                    DT_DULIEUXNK_COPY.Rows.Add(_grid.Cells[1].Value, _grid.Cells[2].Value, _grid.Cells[3].Value, _grid.Cells[4].Value,
                        _grid.Cells[5].Value, _grid.Cells[6].Value, _grid.Cells[7].Value, _grid.Cells[8].Value, _grid.Cells[9].Value
                       );
                    // Delete row selected
                    DataRowView _view = (DataRowView)_grid.DataRow;
                    string _MAHIEU_PK = _view[DulieuxnkFields.Id.Name].ToString();
                    if (string.IsNullOrEmpty(_MAHIEU_PK))
                    {
                        _view.Delete();
                    }
                    else
                    {
                        _DulieuxnkManager.Delete(Convert.ToInt64(_MAHIEU_PK));
                        DataRow[] drArr = DT_DULIEUXNK_D.Select(DulieuxnkFields.Id.Name + "='" + _MAHIEU_PK + "'");
                        DT_DULIEUXNK_D.Rows.Remove(drArr[0]);
                    }
                }
            }
        }
        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= DT_DULIEUXNK_COPY.Rows.Count - 1; i++)
            {
                DataRow r_Detail = DT_DULIEUXNK_D.NewRow();
                //try { r_Detail[DulieuxnkFields.Ngaykiemke.Name] = Convert.ToDateTime(DT_DULIEUXNK_COPY.Rows[i]["Ngaykiemke"].ToString().Trim()); }
                //catch { }
                //r_Detail[DulieuxnkFields.Mahang.Name] = DT_DULIEUXNK_COPY.Rows[i]["Mahang"].ToString();
                //r_Detail[DulieuxnkFields.Makhach.Name] = DT_DULIEUXNK_COPY.Rows[i]["Makhach"].ToString();
                //r_Detail[DulieuxnkFields.Tenkhach.Name] = DT_DULIEUXNK_COPY.Rows[i]["Tenkhach"].ToString();
                //r_Detail[DulieuxnkFields.Tenhang.Name] = DT_DULIEUXNK_COPY.Rows[i]["Tenhang"].ToString();
                //r_Detail[DulieuxnkFields.Mauin.Name] = DT_DULIEUXNK_COPY.Rows[i]["Mauin"].ToString();
                //try { r_Detail[DulieuxnkFields.Soluong.Name] = Convert.ToDecimal(DT_DULIEUXNK_COPY.Rows[i]["Soluong"].ToString()); }
                //catch { }
                //try { r_Detail[DulieuxnkFields.Khoiluong.Name] = Convert.ToDecimal(DT_DULIEUXNK_COPY.Rows[i]["Khoiluong"].ToString()); }
                //catch { }
                DT_DULIEUXNK_D.Rows.Add(r_Detail);
            }

            BS_DULIEUXNK_D.Position = DT_DULIEUXNK_D.Rows.Count;

            DataView Source_View = new DataView(DT_DULIEUXNK_D);
            BS_DULIEUXNK_D = new BindingSource();
            BS_DULIEUXNK_D.DataSource = Source_View;
            GRID_DULIEUXNK_D.DataSource = BS_DULIEUXNK_D;
            BS_DULIEUXNK_D.Position = DT_DULIEUXNK_D.Rows.Count;
        }
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận xóa các dòng đã chọn ? ", "Xóa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) ==
                   System.Windows.Forms.DialogResult.Yes)
            {
                GridEXRow[] listGrid = GRID_DULIEUXNK_D.GetDataRows();
             
                foreach (GridEXRow _grid in listGrid)
                {
                    if (Convert.ToBoolean(_grid.Cells["Chon"].Value))
                    {
                        // Delete row selected
                        DataRowView _view = (DataRowView)_grid.DataRow;
                        string _MAHIEU_PK = _view[DulieuxnkFields.Id.Name].ToString();
                        if (string.IsNullOrEmpty(_MAHIEU_PK))
                        {
                            _view.Delete();
                        }
                        else
                        {
                            _DulieuxnkManager.Delete(Convert.ToInt64(_MAHIEU_PK));
                            DataRow[] drArr = DT_DULIEUXNK_D.Select(DulieuxnkFields.Id.Name + "='" + _MAHIEU_PK + "'");
                            DT_DULIEUXNK_D.Rows.Remove(drArr[0]);
                        }
                    }
                }
            }
            else
            {
                BS_DULIEUXNK_D.ResetCurrentItem();
                GRID_DULIEUXNK_D.DataSource = BS_DULIEUXNK_D;
            }
        }
        #endregion

        private void FRM_DULIEUXUATNHAPKHAU_FormClosing(object sender, FormClosingEventArgs e)
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
