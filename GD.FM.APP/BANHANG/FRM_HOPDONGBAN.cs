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
using System.Data.SqlClient;

namespace GD.FM.APP.BANHANG
{
    public partial class FRM_HOPDONGBAN : FRM_DMPARENT
    {
        private HopdongbanhangManager _HopdongbanhangManager = new HopdongbanhangManager();
        private HopdongbanhangEntity _HopdongbanhangEntity = new HopdongbanhangEntity();
        private HopdongbanhangchitietManager _HopdongbanhangchitietManager = new HopdongbanhangchitietManager();
        private HopdongbanhangchitietEntity _HopdongbanhangchitietEntity = new HopdongbanhangchitietEntity();
        private MenuroleEntity _MenuroleEntity = new MenuroleEntity();
        private DataTable DT_HOPDONGBAN = new DataTable(), DT_HOPDONGBAN_D = new DataTable(), DT_HOPDONGBAN_D_FILL = new DataTable();
        private BindingSource BS_HOPDONGBAN = new BindingSource(), BS_HOPDONGBAN_D = new BindingSource();
        private DataRow r_Insert = null, _RowViewSelect = null, _RowDanhmuchanghoa = null;
        private GD.FM.CONTROL.JGridEX GRID_HOPDONGBAN = new GD.FM.CONTROL.JGridEX();
        private GD.FM.CONTROL.JGridEX GRID_HOPDONGBAN_D = new GD.FM.CONTROL.JGridEX();
        private string FUNCTION = "LOAD", MAHIEU_PK = "", MACHITIET = "";
        private string MAKHACHHANG = "", MAHANG = "", MACANGDEN = "";

        private DataTable DT_DMKHACH = new DataTable(), DT_DMHANG = new DataTable(), DT_DMCANG = new DataTable();
        public DataTable DT_HANGCHON = new DataTable();

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
                        _MenuroleEntity = MenuroleManager.Return_Current_Menurole("FRM_HOPDONGBAN");
                        DT_HOPDONGBAN = LIB.Procedures.Danhsachhopdongbanhang(LIB.SESSION_START.TS_NGAYDAUNAM, LIB.SESSION_START.TS_NGAYCUOINAM, MAHIEU_PK, MAKHACHHANG, MAHANG, MACANGDEN);
                        DT_HOPDONGBAN_D = LIB.Procedures.Danhsachhopdongbanhangchitiet(LIB.SESSION_START.TS_NGAYDAUNAM, LIB.SESSION_START.TS_NGAYCUOINAM, MAHIEU_PK, MAKHACHHANG, MAHANG, MACANGDEN);
                        DT_HOPDONGBAN_D_FILL = DT_HOPDONGBAN_D.Clone();

                        DT_DMKHACH = LIB.SESSION_START.DT_DMKHACH;
                        DT_DMHANG = LIB.SESSION_START.DT_DMHANGHOA;
                        DT_DMCANG = LIB.SESSION_START.DT_DMCANG;
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

        public FRM_HOPDONGBAN()
        {
            InitializeComponent();
            HopdongbanhangManager _HopdongbanhangManager = new HopdongbanhangManager();
            DataTable dt111 = _HopdongbanhangManager.Clone();
            //GD.FM.LIB.GRID_COMM.Create_GRID_CONIG(dt111, LIB.PATH.FM_PATH + @"\XMLCONFIG\FRM_HOPDONGBAN_H.xml");
            //dt111 = _HopdongbanhangchitietManager.Clone();
            //GD.FM.LIB.GRID_COMM.Create_GRID_CONIG(dt111, LIB.PATH.FM_PATH + @"\XMLCONFIG\FRM_HOPDONGBAN_D.xml");
            GD.FM.LIB.FORM_PROCESS_UTIL.enableControls(false, uiPanel1Container, null);
            GD.FM.CONTROL.BUTTON.Loadimage(LIB.PATH.FM_PATH, btn_LUULAI, btn_LUULAI.Name + ".xml");
            GD.FM.CONTROL.BUTTON.Loadimage(LIB.PATH.FM_PATH, btn_SUA, btn_SUA.Name + ".xml");
            GD.FM.CONTROL.BUTTON.Loadimage(LIB.PATH.FM_PATH, btn_THEMMOI, btn_THEMMOI.Name + ".xml");
            GD.FM.CONTROL.BUTTON.Loadimage(LIB.PATH.FM_PATH, btn_XOA, btn_XOA.Name + ".xml");
            GD.FM.CONTROL.BUTTON.Loadimage(LIB.PATH.FM_PATH, btn_KHOIPHUC, btn_KHOIPHUC.Name + ".xml");
            GD.FM.CONTROL.BUTTON.Loadimage(LIB.PATH.FM_PATH, btn_LAMMOI, btn_LAMMOI.Name + ".xml");
            GD.FM.CONTROL.BUTTON.Loadimage(LIB.PATH.FM_PATH, btn_TIMKIEM, btn_TIMKIEM.Name + ".xml");
            GD.FM.CONTROL.BUTTON.Loadimage(LIB.PATH.FM_PATH, btn_IN, btn_IN.Name + ".xml");
            GD.FM.CONTROL.BUTTON.Loadimage(LIB.PATH.FM_PATH, btn_Thoat, btn_Thoat.Name + ".xml");
            GD.FM.LIB.GRID_COMM.LOAD_GRID_UIPanel(LIB.PATH.FM_PATH + @"\XMLCONFIG\FRM_HOPDONGBAN_H.xml", GRID_HOPDONGBAN, uiPanel0Container);
            GD.FM.LIB.GRID_COMM.LOAD_GRID_UIPanel(LIB.PATH.FM_PATH + @"\XMLCONFIG\FRM_HOPDONGBAN_D.xml", GRID_HOPDONGBAN_D, pne_CHITIET);
            GRID_HOPDONGBAN.RootTable.SortKeys.Add(HopdongbanhangFields.Ngayhopdong.Name, Janus.Windows.GridEX.SortOrder.Descending);
            GRID_HOPDONGBAN_D.FilterMode = FilterMode.None;
            GRID_HOPDONGBAN_D.GroupByBoxVisible = false;
            //GRID_HOPDONGBAN_D.RootTable.Columns["Chungloai"].EditType = EditType.NoEdit;
            FORM_PROCESS();
            GRID_HOPDONGBAN_D.COMBO_MULTICOLUMN(GRID_HOPDONGBAN_D, HopdongbanhangchitietFields.Mahangphiakhach.Name, DanhmuchanghoaFields.Mahangphiakhach.Name, DanhmuchanghoaFields.Mahieu.Name, DanhmuchanghoaFields.Mahieu.Name, DT_DMHANG);
            GRID_HOPDONGBAN_D.CellEdited += GRID_HOPDONGBAN_D_CellEdited;
            GRID_HOPDONGBAN_D.RecordsDeleted += GRID_HOPDONGBAN_D_RecordsDeleted;
            GRID_HOPDONGBAN_D.RecordUpdated += GRID_HOPDONGBAN_D_RecordUpdated;
            GRID_HOPDONGBAN_D.DeletingRecord += GRID_HOPDONGBAN_D_DeletingRecord;
            DataView Source_View = new DataView(DT_HOPDONGBAN);
            BS_HOPDONGBAN = new BindingSource();
            BS_HOPDONGBAN.DataSource = Source_View;
            GRID_HOPDONGBAN.DataSource = BS_HOPDONGBAN;
            BS_HOPDONGBAN.CurrentChanged += new EventHandler(BS_HOPDONGBAN_CurrentChanged);
            BS_HOPDONGBAN_CurrentChanged((new object()), (new EventArgs()));
            GD.FM.BLL.MenuroleManager.set_Enable_controls(GD.FM.LIB.BUTTONACTION.BUTTONACTION_LOAD, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            btn_THEMDONG.Enabled = btn_XOADONG.Enabled = false;
            Application.ThreadException += new System.Threading.ThreadExceptionEventHandler(Application_ThreadException);
            btn_THEMMOI.Focus();
        }

        #region Xử lý Grid Detail
        private void GRID_HOPDONGBAN_D_RecordUpdated(object sender, EventArgs e)
        {
            Tinhtongthanhtien();
        }
        private void GRID_HOPDONGBAN_D_RecordsDeleted(object sender, EventArgs e)
        {
            Tinhtongthanhtien();
        }
        private void GRID_HOPDONGBAN_D_CellEdited(object sender, ColumnActionEventArgs e)
        {
            // Binding thành tiền từ số lượng và đơn giá
            if (e.Column.DataMember == HopdongbanhangchitietFields.Soluong.Name || e.Column.DataMember == HopdongbanhangchitietFields.Dongiavnd.Name
                || e.Column.DataMember == HopdongbanhangchitietFields.Dongiausd.Name)
            {

                decimal soluong = LIB.ConvertString.NumbertoDB(GRID_HOPDONGBAN_D.CurrentRow.Cells[HopdongbanhangchitietFields.Soluong.Name].Value.ToString());
                decimal dongiavnd = LIB.ConvertString.NumbertoDB(GRID_HOPDONGBAN_D.CurrentRow.Cells[HopdongbanhangchitietFields.Dongiavnd.Name].Value.ToString());
                decimal dongiausd = LIB.ConvertString.NumbertoDB(GRID_HOPDONGBAN_D.CurrentRow.Cells[HopdongbanhangchitietFields.Dongiausd.Name].Value.ToString());

                GRID_HOPDONGBAN_D.CurrentRow.Cells[HopdongbanhangchitietFields.Thanhtienvnd.Name].Value = soluong * dongiavnd;
                GRID_HOPDONGBAN_D.CurrentRow.Cells[HopdongbanhangchitietFields.Thanhtienusd.Name].Value = soluong * dongiausd;
            }
        }
        private void GRID_HOPDONGBAN_D_DeletingRecord(object sender, RowActionCancelEventArgs e)
        {
            //throw new NotImplementedException();
            btn_XOADONG_Click(new object(), new EventArgs());
        }

        private void Tinhtongthanhtien()
        {
            decimal tongvnd = 0, tongusd = 0;
            try
            {
                GRID_HOPDONGBAN_D.UpdateData();
                GridEXRow[] listGrid = GRID_HOPDONGBAN_D.GetDataRows();
                //-------Tính tổng thành tiền vnd và usd
                foreach (GridEXRow _grid in listGrid)
                {
                    DataRowView _view = (DataRowView)_grid.DataRow;
                    if (_view == null) continue;
                    decimal _cs = 0;
                    _cs = LIB.ConvertString.NumbertoDB(_view[HopdongbanhangFields.Thanhtienvnd.Name].ToString());
                    tongvnd += _cs;
                    _cs = 0;
                    _cs = LIB.ConvertString.NumbertoDB(_view[HopdongbanhangFields.Thanhtienusd.Name].ToString());
                    tongusd += _cs;
                }
                txt_THANHTIENVND.Text = tongvnd.ToString("#,0", new System.Globalization.CultureInfo("vi-VN"));
                txt_THANHTIENUSD.Text = tongusd.ToString("#,0.00", new System.Globalization.CultureInfo("vi-VN"));
            }
            catch { }
        }
        #endregion

        void BS_HOPDONGBAN_CurrentChanged(object sender, EventArgs e)
        {
            try
            {
                // GD.FM.LIB.FORM_PROCESS_UTIL.clearControls(uiPanel1Container, GD.FM.LIB.FORM_PROCESS_UTIL.getAllControl(uiPanel1Container));
                GRID_HOPDONGBAN.UpdateData();
                if (BS_HOPDONGBAN.Current != null)
                {
                    DataRowView _Rowview = (DataRowView)this.BS_HOPDONGBAN.Current;
                    if (_Rowview != null)
                        MAHIEU_PK = _Rowview.Row[HopdongbanhangFields.Sohopdong.Name].ToString();

                    txt_MADONDATHANG.Text = _Rowview.Row[HopdongbanhangFields.Sohopdong.Name].ToString();
                    txt_NGAYHOPDONG.Text = _Rowview.Row[HopdongbanhangFields.Ngayhopdong.Name].ToString();
                    txt_MAKHACH.Text = _Rowview.Row[HopdongbanhangFields.Makhach.Name].ToString();
                    txt_MACANGDEN.Text = _Rowview.Row[HopdongbanhangFields.Macangden.Name].ToString();
                    txt_THANHTIENVND.Text = _Rowview.Row[HopdongbanhangFields.Thanhtienvnd.Name].ToString();
                    txt_THANHTIENUSD.Text = _Rowview.Row[HopdongbanhangFields.Thanhtienusd.Name].ToString();

                    txt_MAKHACH_Validating(new object(), new CancelEventArgs());
                    txt_MACANGDEN_Validating(new object(), new CancelEventArgs());
                    SHOWGRID(MAHIEU_PK);
                }
                else
                    SHOWGRID("");

                Tinhtongthanhtien();
            }
            catch
            { }
        }

        void BS_HOPDONGBAN_D_CurrentChanged(object sender, EventArgs e)
        {
            try
            {
                if (BS_HOPDONGBAN_D.Current != null)
                {
                    DataRowView _Rowview = (DataRowView)this.BS_HOPDONGBAN_D.Current;
                    if (_Rowview != null)
                        MACHITIET = _Rowview.Row[HopdongbanhangchitietFields.Id.Name].ToString();
                }
            }
            catch
            { }
        }
        private void SHOWGRID(string MAHIEU_PK)
        {
            if (string.IsNullOrEmpty(MAHIEU_PK))
            {
                DT_HOPDONGBAN_D_FILL = new HopdongbanhangchitietManager().Clone();
                BS_HOPDONGBAN_D = new BindingSource(DT_HOPDONGBAN_D_FILL, null);
                GRID_HOPDONGBAN_D.DataSource = BS_HOPDONGBAN_D;
            }
            else
            {
                DT_HOPDONGBAN_D_FILL = LIB.Procedures.Danhsachhopdongbanhangchitiet(LIB.SESSION_START.TS_NGAYDAUNAM, LIB.SESSION_START.TS_NGAYCUOINAM, MAHIEU_PK, MAKHACHHANG, MAHANG, MACANGDEN);

                DataView Source_View = new DataView(DT_HOPDONGBAN_D_FILL);
                BS_HOPDONGBAN_D = new BindingSource();
                BS_HOPDONGBAN_D.DataSource = Source_View;
                GRID_HOPDONGBAN_D.DataSource = BS_HOPDONGBAN_D;
            }
            BS_HOPDONGBAN_D.CurrentChanged += new EventHandler(BS_HOPDONGBAN_D_CurrentChanged);
            BS_HOPDONGBAN_D_CurrentChanged((new object()), (new EventArgs()));
        }

        #region Xu ly dong chi tiet
        private void btn_THEMDONG_Click(object sender, EventArgs e)
        {
            DataTable DT_DMHANGHOA_C = new DataTable();
            DT_DMHANGHOA_C = new DanhmuchanghoaManager().Clone();
            DT_DMHANGHOA_C.Columns.Add("Time");
            ListviewJanusC _frm_MultiRows_Select =
                new ListviewJanusC(LIB.PATH.FM_PATH + @"\XMLCONFIG\FRM_DMHANGHOA_CHON.xml", DT_DMHANG, DanhmuchanghoaFields.Mahieu.Name, string.Empty);
            _frm_MultiRows_Select.ShowDialog();
            if (_frm_MultiRows_Select._RowsViewSelect == null) return;

            DataTable dt = new DataTable(); dt = DT_DMHANGHOA_C.Clone();
            foreach (DataRowView drv in _frm_MultiRows_Select._RowsViewSelect)
            {
                DataRow dr = dt.NewRow();
                dr.ItemArray = drv.Row.ItemArray;
                dt.Rows.Add(dr);
            }
            DataRow[] arrDr = dt.Select("", "Time");
            foreach (DataRow dr in arrDr)
            {
                DataRow r_Detail = DT_HOPDONGBAN_D_FILL.NewRow();
                r_Detail[HopdongbanhangchitietFields.Mahangphiakhach.Name] = string.IsNullOrEmpty(dr[DanhmuchanghoaFields.Mahangphiakhach.Name].ToString()) ? dr[DanhmuchanghoaFields.Mahieu.Name].ToString() : dr[DanhmuchanghoaFields.Mahangphiakhach.Name].ToString();
                r_Detail[HopdongbanhangchitietFields.Codefiller.Name] = dr[DanhmuchanghoaFields.Mahieu.Name].ToString();

                DT_HOPDONGBAN_D_FILL.Rows.Add(r_Detail);
            }

            DataView Source_View = new DataView(DT_HOPDONGBAN_D_FILL);
            BS_HOPDONGBAN_D = new BindingSource();
            BS_HOPDONGBAN_D.DataSource = Source_View;
            GRID_HOPDONGBAN_D.DataSource = BS_HOPDONGBAN_D;
            BS_HOPDONGBAN_D.Position = DT_HOPDONGBAN_D_FILL.Rows.Count;
        }
        private void btn_XOADONG_Click(object sender, EventArgs e)
        {
            DataRowView _view = (DataRowView)GRID_HOPDONGBAN_D.CurrentRow.DataRow;
            string _MAHIEU_PK = _view[HopdongbanhangchitietFields.Id.Name].ToString();
            string _SOHOPDONG = _view[HopdongbanhangchitietFields.Sohopdong.Name].ToString();
            string _MAHANG = _view[HopdongbanhangchitietFields.Mahangphiakhach.Name].ToString();
            if (new ThuchienhopdongbanhangManager().SelectBy_Sohopdong_Mahangphiakhach(_SOHOPDONG, _MAHANG).Count > 0)
            {
                MessageBox.Show("Đã thực hiện giao hàng." + '\n' + "Không thể xóa hàng " + _MAHANG + "!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(_MAHIEU_PK) && MessageBox.Show("Xóa dòng: " + _MAHANG, "Xóa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) ==
                   System.Windows.Forms.DialogResult.Yes)
            {
                GRID_HOPDONGBAN_D.CurrentRow.Delete();
            }
            else
            {
                HopdongbanhangchitietManager _HopdongbanhangchitietManager = new HopdongbanhangchitietManager();
                HopdongbanhangchitietEntity _HopdongbanhangchitietEntity = new HopdongbanhangchitietEntity();
                try { _HopdongbanhangchitietEntity = _HopdongbanhangchitietManager.SelectOne(Convert.ToInt64(_MAHIEU_PK)); }
                catch { }
                if (_HopdongbanhangchitietEntity != null && MessageBox.Show("Xóa dòng: " + _MAHANG, "Xóa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) ==
                       System.Windows.Forms.DialogResult.Yes)
                {
                    try
                    {
                        _HopdongbanhangchitietManager.Delete(Convert.ToInt64(_MAHIEU_PK));
                        DataRow[] drArr = DT_HOPDONGBAN_D_FILL.Select(HopdongbanhangchitietFields.Id.Name + "='" + _MAHIEU_PK + "'");
                        DT_HOPDONGBAN_D_FILL.Rows.Remove(drArr[0]);
                    }
                    catch
                    {
                        MessageBox.Show("Không thể xóa dòng " + _MAHANG + "!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    BS_HOPDONGBAN_D.ResetCurrentItem();
                    GRID_HOPDONGBAN_D.DataSource = BS_HOPDONGBAN_D;
                }
                GRID_HOPDONGBAN_D.Enabled = true;
            }
        }
        #endregion

        private string Save_Data(string _str_DMCHUONG_PK)
        {
            HopdongbanhangEntity _HopdongbanhangEntity = new HopdongbanhangEntity();
            _HopdongbanhangEntity.Sohopdong = txt_MADONDATHANG.Text.Trim();
            try { _HopdongbanhangEntity.Ngayhopdong = Convert.ToDateTime(txt_NGAYHOPDONG.Text.Trim()); }
            catch { }
            _HopdongbanhangEntity.Makhach = txt_MAKHACH.Text.Trim();
            _HopdongbanhangEntity.Tenkhach = txt_TENKHACH.Text.Trim();
            _HopdongbanhangEntity.Macangden = txt_MACANGDEN.Text.Trim();
            _HopdongbanhangEntity.Tencangden = txt_TENCANGDEN.Text.Trim();
            try { _HopdongbanhangEntity.Thanhtienvnd = Convert.ToDecimal(txt_THANHTIENVND.Text.Trim()); }
            catch { }
            try { _HopdongbanhangEntity.Thanhtienusd = Convert.ToDecimal(txt_THANHTIENUSD.Text.Trim()); }
            catch { }

            EntityCollection _HopdongbanhangchitietEntityCol = new EntityCollection();
            GridEXRow[] listGrid = GRID_HOPDONGBAN_D.GetDataRows();
            foreach (GridEXRow _grid in listGrid)
            {
                DataRowView _view = (DataRowView)_grid.DataRow;
                if (_view == null) continue;
                HopdongbanhangchitietEntity _HopdongbanhangchitietEntity = new HopdongbanhangchitietEntity();
                _HopdongbanhangchitietEntity.Sohopdong = _HopdongbanhangEntity.Sohopdong;
                _HopdongbanhangchitietEntity.Ngayhopdong = _HopdongbanhangEntity.Ngayhopdong;
                _HopdongbanhangchitietEntity.Makhach = _HopdongbanhangEntity.Makhach;
                _HopdongbanhangchitietEntity.Tenkhach = _HopdongbanhangEntity.Tenkhach;
                _HopdongbanhangchitietEntity.Macangden = _HopdongbanhangEntity.Macangden;
                _HopdongbanhangchitietEntity.Tencangden = _HopdongbanhangEntity.Tencangden;
                _HopdongbanhangchitietEntity.Mahangphiakhach = _view[HopdongbanhangchitietFields.Mahangphiakhach.Name].ToString();
                _HopdongbanhangchitietEntity.Codefiller = _view[HopdongbanhangchitietFields.Codefiller.Name].ToString();
                try { _HopdongbanhangchitietEntity.Soluong = Convert.ToInt32(_view[HopdongbanhangchitietFields.Soluong.Name].ToString()); }
                catch { }
                try { _HopdongbanhangchitietEntity.Dongiavnd = Convert.ToDecimal(_view[HopdongbanhangchitietFields.Dongiavnd.Name].ToString()); }
                catch { }
                try { _HopdongbanhangchitietEntity.Tygia = Convert.ToDecimal(_view[HopdongbanhangchitietFields.Tygia.Name].ToString()); }
                catch { }
                try { _HopdongbanhangchitietEntity.Dongiausd = Convert.ToDecimal(_view[HopdongbanhangchitietFields.Dongiausd.Name].ToString()); }
                catch { }
                try { _HopdongbanhangchitietEntity.Thanhtienvnd = Convert.ToDecimal(_view[HopdongbanhangchitietFields.Thanhtienvnd.Name].ToString()); }
                catch { }
                try { _HopdongbanhangchitietEntity.Thanhtienusd = Convert.ToDecimal(_view[HopdongbanhangchitietFields.Thanhtienusd.Name].ToString()); }
                catch { }
                try { _HopdongbanhangchitietEntity.Ngaygiao = Convert.ToDateTime(_view[HopdongbanhangchitietFields.Ngaygiao.Name].ToString()); }
                catch { }

                try { _HopdongbanhangchitietEntity.Id = Convert.ToInt64(_view[HopdongbanhangchitietFields.Id.Name].ToString()); }
                catch { }

                _HopdongbanhangchitietEntity.IsNew = _view.Row.RowState == DataRowState.Added ? true : false;
                if (_HopdongbanhangchitietEntity.IsNew)
                {
                    EntityCollection drDHCT = (new HopdongbanhangchitietManager()).SelectById(_HopdongbanhangchitietEntity.Id);
                    if (drDHCT.Count > 0)
                    {
                        _HopdongbanhangchitietEntity.Ngaysua = DateTime.Now;
                        _HopdongbanhangchitietEntity.Nguoisua = LIB.SESSION_START.TS_USER_LOGIN;
                        _HopdongbanhangchitietEntity.IsNew = false;
                    }
                    else
                    {
                        _HopdongbanhangchitietEntity.Ngaytao = DateTime.Now;
                        _HopdongbanhangchitietEntity.Nguoitao = LIB.SESSION_START.TS_USER_LOGIN;
                    }
                }

                if (!string.IsNullOrEmpty(_HopdongbanhangchitietEntity.Mahangphiakhach))
                    _HopdongbanhangchitietEntityCol.Add(_HopdongbanhangchitietEntity);
            }

            if (string.IsNullOrEmpty(_str_DMCHUONG_PK))
            {
                _HopdongbanhangEntity.Ngaytao = DateTime.Now;
                _HopdongbanhangEntity.Nguoitao = LIB.SESSION_START.TS_USER_LOGIN;
                _str_DMCHUONG_PK = _HopdongbanhangManager.InsertV2(_HopdongbanhangEntity, r_Insert, DT_HOPDONGBAN, BS_HOPDONGBAN);
                _HopdongbanhangchitietManager.InsertCollection(_HopdongbanhangchitietEntityCol);
                GRID_HOPDONGBAN_D.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.False;
                GRID_HOPDONGBAN_D.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
                GRID_HOPDONGBAN_D.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.False;
                GD.FM.BLL.MenuroleManager.set_Enable_controls(_HopdongbanhangManager.Convert(_HopdongbanhangEntity), GD.FM.LIB.BUTTONACTION.BUTTONACTION_INSERT, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
                btn_THEMDONG.Enabled = btn_XOADONG.Enabled = false;
                BS_HOPDONGBAN.ResetCurrentItem();
                BS_HOPDONGBAN_CurrentChanged(new object(), new EventArgs());
                //BS_HOPDONGBAN.Position = DT_HOPDONGBAN.Rows.Count - 1;
            }
            else
            {
                _HopdongbanhangEntity.Ngaysua = DateTime.Now;
                _HopdongbanhangEntity.Nguoisua = LIB.SESSION_START.TS_USER_LOGIN;
                _HopdongbanhangManager.Update(_HopdongbanhangEntity);
                foreach (HopdongbanhangchitietEntity _HopdongbanhangchitietEntity in _HopdongbanhangchitietEntityCol)
                {
                    if (_HopdongbanhangchitietEntity.IsNew)
                    {
                        DataRow _r_Insert = DT_HOPDONGBAN_D.NewRow();
                        DT_HOPDONGBAN_D.Rows.Add(_r_Insert);
                        _HopdongbanhangchitietManager.InsertV2(_HopdongbanhangchitietEntity, _r_Insert, DT_HOPDONGBAN_D, BS_HOPDONGBAN_D);
                    }
                    else _HopdongbanhangchitietManager.Update(_HopdongbanhangchitietEntity);
                }
                GRID_HOPDONGBAN.CurrentRow.Cells[HopdongbanhangFields.Sohopdong.Name].Value = _HopdongbanhangEntity.Sohopdong;
                GRID_HOPDONGBAN.CurrentRow.Cells[HopdongbanhangFields.Makhach.Name].Value = _HopdongbanhangEntity.Makhach;
                GRID_HOPDONGBAN.CurrentRow.Cells[HopdongbanhangFields.Tenkhach.Name].Value = _HopdongbanhangEntity.Tenkhach;
                GRID_HOPDONGBAN.CurrentRow.Cells[HopdongbanhangFields.Ngayhopdong.Name].Value = _HopdongbanhangEntity.Ngayhopdong;
                GRID_HOPDONGBAN.CurrentRow.Cells[HopdongbanhangFields.Macangden.Name].Value = _HopdongbanhangEntity.Macangden;
                GD.FM.BLL.MenuroleManager.set_Enable_controls(_HopdongbanhangManager.Convert(_HopdongbanhangEntity), GD.FM.LIB.BUTTONACTION.BUTTONACTION_UPDATE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
                GRID_HOPDONGBAN_D.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.False;
                GRID_HOPDONGBAN_D.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
                GRID_HOPDONGBAN_D.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.False;
                btn_THEMDONG.Enabled = btn_XOADONG.Enabled = false;
                BS_HOPDONGBAN.ResetCurrentItem();
                BS_HOPDONGBAN_CurrentChanged(new object(), new EventArgs());
            }
            return _str_DMCHUONG_PK;
        }

        #region Button
        private void btn_THEMMOI_Click(object sender, EventArgs e)
        {
            GD.FM.LIB.FORM_PROCESS_UTIL.enableControls(true, uiPanel1Container, new List<Control>(new Control[] { }));
            txt_MADONDATHANG.Text = txt_MAKHACH.Text = txt_TENKHACH.Text = txt_TENCANGDEN.Text = string.Empty;
            HopdongbanhangManager _HopdongbanhangManager = new HopdongbanhangManager();
            HopdongbanhangEntity _HopdongbanhangEntity = new HopdongbanhangEntity();
            r_Insert = DT_HOPDONGBAN.NewRow();
            DT_HOPDONGBAN.Rows.Add(r_Insert);
            BS_HOPDONGBAN.Position = DT_HOPDONGBAN.Rows.Count;
            GRID_HOPDONGBAN_D.Enabled = true;
            GRID_HOPDONGBAN_D.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.True;
            GRID_HOPDONGBAN_D.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.True;
            GRID_HOPDONGBAN_D.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.True;
            GRID_HOPDONGBAN_D.NewRowPosition = Janus.Windows.GridEX.NewRowPosition.BottomRow;
            MAHIEU_PK = "";
            txt_MADONDATHANG.Focus();
            TEXTBOX_Only_Control(false, null);
            GD.FM.LIB.FORM_PROCESS_UTIL.enableControls(true, uiPanel1Container, new List<Control>(new Control[] { txt_TENKHACH, txt_TENCANGDEN }));
            GD.FM.BLL.MenuroleManager.set_Enable_controls(GD.FM.LIB.BUTTONACTION.BUTTONACTION_THEMMOI, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            btn_THEMDONG.Enabled = btn_XOADONG.Enabled = true;
            GRID_HOPDONGBAN.Enabled = false;
            btn_TIMKIEM.Enabled = false;
            txt_NGAYHOPDONG.Text = LIB.SESSION_START.TS_NGAYLAMVIEC.ToString("dd/MM/yyyy");
        }
        private void btn_SUA_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(MAHIEU_PK)) { return; }
            else
            {
                GD.FM.BLL.MenuroleManager.set_Enable_controls(GD.FM.LIB.BUTTONACTION.BUTTONACTION_SUA, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
                btn_THEMDONG.Enabled = btn_XOADONG.Enabled = true;
                GD.FM.LIB.FORM_PROCESS_UTIL.enableControls(true, uiPanel1Container, new List<Control>(new Control[] { txt_TENKHACH, txt_TENCANGDEN }));
                //txt_TENHIEU.Focus();
            }
            GRID_HOPDONGBAN_D.NewRowPosition = Janus.Windows.GridEX.NewRowPosition.BottomRow;
            GRID_HOPDONGBAN_D.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.True;
            GRID_HOPDONGBAN_D.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.True;
            GRID_HOPDONGBAN_D.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.True;
            GRID_HOPDONGBAN_D.Enabled = true;
            GRID_HOPDONGBAN.Enabled = false;
            btn_XOADONG.Enabled = true;
            btn_TIMKIEM.Enabled = false;
        }
        private void btn_KHOIPHUC_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(MAHIEU_PK) && r_Insert != null)
            {
                DT_HOPDONGBAN.Rows.Remove(r_Insert);
            }
            BS_HOPDONGBAN_CurrentChanged(new object(), new EventArgs());
            GD.FM.BLL.MenuroleManager.set_Enable_controls(GD.FM.LIB.BUTTONACTION.BUTTONACTION_CANCEL, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            btn_THEMDONG.Enabled = btn_XOADONG.Enabled = false;
            FORM_PROCESS_UTIL.enableControls(false, uiPanel1Container, new List<Control>(new Control[] { }));
            btn_TIMKIEM.Enabled = btn_IN.Enabled = btn_LAMMOI.Enabled = true;
            GRID_HOPDONGBAN.Enabled = true;
            GRID_HOPDONGBAN_D.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.False;
            GRID_HOPDONGBAN_D.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            GRID_HOPDONGBAN_D.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.False;
        }

        private void btn_XOA_Click(object sender, EventArgs e)
        {
            GD.FM.LIB.FORM_PROCESS_UTIL.enableControls(false, uiPanel1Container, null);
            if (string.IsNullOrEmpty(MAHIEU_PK)) return;
            //if (new PhieugiaohangDManager().SelectByMadonhangRDT(MAHIEU_PK).Rows.Count > 0)
            //{
            //    MessageBox.Show("Đã sử dụng trong phiếu xuất hàng bán." + '\n' + "Không thể xóa đơn đặt hàng " + MAHIEU_PK + "!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}
            HopdongbanhangManager _HopdongbanhangManager = new HopdongbanhangManager();
            HopdongbanhangEntity _HopdongbanhangEntity = new HopdongbanhangEntity();
            _HopdongbanhangEntity = _HopdongbanhangManager.SelectOne(MAHIEU_PK);
            if (_HopdongbanhangEntity != null && MessageBox.Show("Xóa hợp đồng: " + MAHIEU_PK, "Xóa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) ==
                   System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                    _HopdongbanhangchitietManager.DeleteBySohopdong(MAHIEU_PK);
                    _HopdongbanhangManager.Delete(MAHIEU_PK);
                    GRID_HOPDONGBAN.CurrentRow.Delete();
                    BS_HOPDONGBAN_CurrentChanged(new object(), new EventArgs());
                    //GD.FM.LIB.TrayPopup.PoupStringMessage(GD.FM.APP.Properties.Resources.MessageTitle, GD.FM.APP.Properties.Resources.MessageContent_T);
                    GD.FM.LIB.TrayPopup.PoupStringMessage("Thông báo", "Đã xóa thành công!");
                    GD.FM.BLL.MenuroleManager.set_Enable_controls(_HopdongbanhangManager.Convert(_HopdongbanhangEntity), GD.FM.LIB.BUTTONACTION.BUTTONACTION_DELETE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
                    btn_THEMDONG.Enabled = btn_XOADONG.Enabled = false;
                }
                catch
                {
                    MessageBox.Show("Không thể xóa hợp đồng " + MAHIEU_PK + "!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            btn_TIMKIEM.Enabled = btn_LAMMOI.Enabled = true;
            GRID_HOPDONGBAN.Enabled = true;
            GRID_HOPDONGBAN_D.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.False;
            GRID_HOPDONGBAN_D.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            GRID_HOPDONGBAN_D.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.False;
        }

        private void btn_LAMMOI_Click(object sender, EventArgs e)
        {
            DT_DMKHACH = LIB.SESSION_START.DT_DMKHACH;
            DT_DMHANG = LIB.SESSION_START.DT_DMHANGHOA;
            DT_DMCANG = LIB.SESSION_START.DT_DMCANG;
            if (btn_SUA.Enabled == true || btn_THEMMOI.Enabled == true)
            {
                MAHIEU_PK = "";
                MAKHACHHANG = "";
                MAHANG = "";
                DT_HOPDONGBAN = LIB.Procedures.Danhsachhopdongbanhang(LIB.SESSION_START.TS_NGAYDAUNAM, LIB.SESSION_START.TS_NGAYCUOINAM, MAHIEU_PK, MAKHACHHANG, MAHANG, MACANGDEN);
                DataView Source_View = new DataView(DT_HOPDONGBAN);
                BS_HOPDONGBAN = new BindingSource();
                BS_HOPDONGBAN.DataSource = Source_View;
                GRID_HOPDONGBAN.DataSource = BS_HOPDONGBAN;
                BS_HOPDONGBAN.CurrentChanged += new EventHandler(BS_HOPDONGBAN_CurrentChanged);
                BS_HOPDONGBAN_CurrentChanged((new object()), (new EventArgs()));
            }
        }

        private void btn_IN_Click(object sender, EventArgs e)
        {
            DataSet dsKetqua = new DataSet();
            string _Sohopdong = "";

            try
            {
                #region Lay thong tin cac tham so
                _Sohopdong = txt_MADONDATHANG.Text;
                #endregion

                #region Chay procedure
                DAL.DatabaseSpecific.DataAccessAdapter _DataAccessAdapter = new DAL.DatabaseSpecific.DataAccessAdapter(LIB.SESSION_START.ConnectionStringKeyName);
                SqlParameter[] parameters = new SqlParameter[1];
                parameters[0] = new SqlParameter("@Sohopdong", _Sohopdong);

                _DataAccessAdapter.CallRetrievalStoredProcedure("Indondathang", parameters, dsKetqua);
                _DataAccessAdapter.CloseConnection();
                dsKetqua.Tables[0].TableName = "Dondathang";
                #endregion

                #region Tham so
                DataTable dtThamso = new DataTable("Thamso");
                dtThamso.Columns.Add("Khachhang");
                dtThamso.Columns.Add("Thoigianbaocao");
                DataRow dr = dtThamso.NewRow();
                dr["Khachhang"] = txt_TENKHACH.Text;
                dr["Thoigianbaocao"] = "Hà Nội, ngày " + txt_NGAYHOPDONG.Text;
                dtThamso.Rows.Add(dr);
                dsKetqua.Tables.Add(dtThamso);
                #endregion

                #region Hien bao cao
                new BAOCAO.FRM_REPORTVIEWER(dsKetqua, LIB.PATH.FM_PATH + @"\RDLC\NHUCAUSANXUAT.rdlc", "Dondathang", this.Text, true).Show();
                #endregion
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_TIMKIEM_Click(object sender, EventArgs e)
        {
            //FRM_TIMKIEM frm = new FRM_TIMKIEM();
            //frm.ShowDialog();
            //if (frm._DialogResult == DialogResult.No) return;
            //DT_DMKHACH = LIB.SESSION_START.DT_DMKHACH;
            //DT_DMHANG = LIB.SESSION_START.DT_DMHANGHOA;
            //MAKHACHHANG = frm._Makhachhang;
            //MAHANG = frm._Mahang;
            //SOBAOGIA = frm._Macangden;
            //MAHIEU_PK = frm._Sohopdong;
            //DT_HOPDONGBAN = LIB.Procedures.Danhsachdondathang(LIB.SESSION_START.TS_NGAYDAUNAM, LIB.SESSION_START.TS_NGAYCUOINAM, MAHIEU_PK, SOBAOGIA, SoPO, MAKHACHHANG, MAHANG);
            //DataView Source_View = new DataView(DT_HOPDONGBAN);
            //BS_HOPDONGBAN = new BindingSource();
            //BS_HOPDONGBAN.DataSource = Source_View;
            //GRID_HOPDONGBAN.DataSource = BS_HOPDONGBAN;
            //BS_HOPDONGBAN.CurrentChanged += new EventHandler(BS_HOPDONGBAN_CurrentChanged);
            //BS_HOPDONGBAN_CurrentChanged((new object()), (new EventArgs()));
        }
        private void btn_LUULAI_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(MAHIEU_PK) && _HopdongbanhangManager.SelectOne(txt_MADONDATHANG.Text.Trim()) != null)
            {
                MessageBox.Show("Mã hợp đồng bị trùng! \nNhập lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_MADONDATHANG.Focus();
                return;
            }
            else if (txt_MADONDATHANG.Text == "")
            {
                MessageBox.Show("Yêu cầu nhập mã!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_MADONDATHANG.Focus();
                return;
            }
            else
            {
                GD.FM.LIB.FORM_PROCESS_UTIL.enableControls(false, uiPanel1Container, null);
                MAHIEU_PK = Save_Data(MAHIEU_PK);
                GD.FM.LIB.TrayPopup.PoupStringMessage("Thông báo", "Lưu lại thành công");
                GRID_HOPDONGBAN.Enabled = true;
                btn_TIMKIEM.Enabled = btn_LAMMOI.Enabled = true;
                btn_THEMMOI.Focus();
                GRID_HOPDONGBAN_D.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.False;
                GRID_HOPDONGBAN_D.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
                GRID_HOPDONGBAN_D.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.False;
            }
        }
        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion

        #region Validate
        private void txt_MAKHACH_Validating(object sender, CancelEventArgs e)
        {
            _RowViewSelect = null;
            if (string.IsNullOrEmpty(txt_MAKHACH.Text.Trim()) || DT_DMKHACH == null || DT_DMKHACH.Rows.Count == 0) return;
            string Str_MASIEUTHI = txt_MAKHACH.Text.Trim().ToUpper();
            _RowViewSelect = checkmaKhach(Str_MASIEUTHI, DT_DMKHACH);
            if (_RowViewSelect == null)
            {
                ListviewJanus _frm_SingerRows_Select =
                    new ListviewJanus(LIB.PATH.FM_PATH + @"\XMLCONFIG\FRM_DMKHACH.xml",
                        DT_DMKHACH, DanhmuckhachFields.Mahieu.Name, Str_MASIEUTHI);
                _frm_SingerRows_Select.ShowDialog();
                if (_frm_SingerRows_Select._RowViewSelect == null) return;
                _RowViewSelect = _frm_SingerRows_Select._RowViewSelect.Row;
                txt_MAKHACH.Text = _RowViewSelect[DanhmuckhachFields.Mahieu.Name].ToString();
                txt_TENKHACH.Text = _RowViewSelect[DanhmuckhachFields.Tenhieu.Name].ToString();

                //DT_DMHANG = new DanhmuchanghoaManager().SelectByMakhachRDT(txt_MAKHACH.Text);
            }
            else
            {
                txt_TENKHACH.Text = _RowViewSelect[DanhmuckhachFields.Tenhieu.Name].ToString();
                //DT_DMHANG = new DanhmuchanghoaManager().SelectByMakhachRDT(txt_MAKHACH.Text);
            }
        }
        private DataRow checkmaKhach(string masieuthi, DataTable dt)
        {
            try
            {
                return dt.Select(DanhmuckhachFields.Mahieu.Name + "=" + "'" + masieuthi + "'").CopyToDataTable().Rows[0];
            }
            catch { return null; }
        }

        private void txt_MACANGDEN_Validating(object sender, CancelEventArgs e)
        {
            _RowViewSelect = null;
            if (string.IsNullOrEmpty(txt_MACANGDEN.Text.Trim()) || DT_DMCANG == null || DT_DMCANG.Rows.Count == 0) return;
            string Str_MASIEUTHI = txt_MACANGDEN.Text.Trim().ToUpper();
            _RowViewSelect = checkmaCang(Str_MASIEUTHI, DT_DMCANG);
            if (_RowViewSelect == null)
            {
                ListviewJanus _frm_SingerRows_Select =
                    new ListviewJanus(LIB.PATH.FM_PATH + @"\XMLCONFIG\FRM_DMCANG.xml",
                        DT_DMCANG, DanhmuccangFields.Mahieu.Name, Str_MASIEUTHI);
                _frm_SingerRows_Select.ShowDialog();
                if (_frm_SingerRows_Select._RowViewSelect == null) return;
                _RowViewSelect = _frm_SingerRows_Select._RowViewSelect.Row;
                txt_MACANGDEN.Text = _RowViewSelect[DanhmuccangFields.Mahieu.Name].ToString();
                txt_TENCANGDEN.Text = _RowViewSelect[DanhmuccangFields.Tenhieu.Name].ToString();
            }
            else
            {
                txt_TENCANGDEN.Text = _RowViewSelect[DanhmuccangFields.Tenhieu.Name].ToString();
            }
        }
        private DataRow checkmaCang(string masieuthi, DataTable dt)
        {
            try
            {
                return dt.Select(DanhmuccangFields.Mahieu.Name + "=" + "'" + masieuthi + "'").CopyToDataTable().Rows[0];
            }
            catch { return null; }
        }
        #endregion

        #region   Shortcut Key
        private void txt_MAKHACH_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.F4)
            {
                FRM_DMKHACH frm_Dm = new FRM_DMKHACH();
                frm_Dm.Text = "Danh mục khách hàng";
                frm_Dm.ShowDialog();
                DT_DMKHACH = new DanhmuckhachManager().SelectAllRDT();
            }
        }
        private void txt_MACANGDEN_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.F4)
            {
                FRM_DMCANG frm_Dm = new FRM_DMCANG();
                frm_Dm.Text = "Danh mục cảng";
                frm_Dm.ShowDialog();
                DT_DMCANG = new DanhmuccangManager().SelectAllRDT();
            }
        }

        #endregion
        private void FRM_HOPDONGBAN_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void FRM_HOPDONGBAN_FormClosing(object sender, FormClosingEventArgs e)
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
