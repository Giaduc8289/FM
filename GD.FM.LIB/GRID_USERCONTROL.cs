using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Janus.Windows.GridEX;
using System.Drawing;
using System.Data;
using GD.FM.CONTROL;
using System.Windows.Forms;

namespace GD.FM.LIB
{
    /*Cac dieu kien can` khi su dung:
     * doan nay` cho vao` method khi chay form.      
        DataTable dt = new DmbohangManager().SelectAllRDT();
        GD.FM.LIB.GRID_USERCONTROL.Main_COMBO(dt, "Mabo", gridEX1, combo1, DmbohangFields.Tenbo.Name, DmbohangFields.Mabo.Name,true);
        GD.FM.LIB.GRID_USERCONTROL.Main_txtDATETIME("Ngaytao", txt_DATETIME, gridEX1,false);
     * 
        void BS_BOHANG_CurrentChanged(object sender, EventArgs e)
        {
            try
            {
                if (BS_BOHANG.Current != null)
                {
                    DataRowView _Rowview = (DataRowView)BS_BOHANG.Current;                    
                    //combo1.SelectedValue = _Rowview.Row[DmbohangFields.Mabo.Name].ToString();//co cung duoc
                    txt_DATETIME.SetDateTime(Convert.ToDateTime(_Rowview.Row[DmbohangFields.Ngaytao.Name].ToString()));
                }
            }
            catch (Exception)
            {                
            }
        }
     */
    public class GRID_USERCONTROL
    {
        #region DECLARE
        private static GridEX Control_Grid = new GridEX();        
        private static GD.FM.CONTROL.TEXTBOXDATE Control_txt_DATETIME = new GD.FM.CONTROL.TEXTBOXDATE();
        private static GD.FM.CONTROL.COMBO Control_combo1 = new GD.FM.CONTROL.COMBO();
        private static Rectangle rect = new Rectangle();
        public static DataTable _dt_combo = new DataTable();
        private static GridEXRow row_old = null;
        private static string _colName_Cobo, _valueCobo, _keyCobo, _colName_Datetime;
        private static bool _filterMode;
        #endregion
        #region METHOD
        public static void Main_COMBO(DataTable dt_cobo, string colName_Cobo, GridEX gridEX1, COMBO combo1, string value_combo, string key_combo,bool filterMode)
        {
            Control_Grid = gridEX1;
            Control_combo1 = combo1;
            _dt_combo = dt_cobo;
            _colName_Cobo = colName_Cobo;
            _valueCobo = value_combo;
            _keyCobo = key_combo;
            _filterMode = filterMode;
            if (_filterMode) { Control_Grid.FilterMode = FilterMode.Automatic; }
            else { Control_Grid.FilterMode = FilterMode.None; }
            Control_Grid.CurrentCellChanged+=new EventHandler(Control_Grid_CurrentCellChanged);
            Control_Grid_CurrentCellChanged(new object(), new EventArgs());
        }
        public static void Main_txtDATETIME(string colName_Datetime, TEXTBOXDATE txt_DATETIME, GridEX gridEX1, bool filterMode)
        {
            Control_Grid = gridEX1;
            Control_txt_DATETIME = txt_DATETIME;
            _colName_Datetime = colName_Datetime;            
            _filterMode = filterMode;
            if (_filterMode) { Control_Grid.FilterMode = FilterMode.Automatic; }
            else { Control_Grid.FilterMode = FilterMode.None; }
            Control_Grid.CurrentCellChanged += new EventHandler(Control_Grid_CurrentCellChanged1);
        }
        public static void addComboBox(DataTable dt_cobo, string colName_Cobo, GridEX gridEX1, COMBO combo1, string value_combo, string key_combo)
        {
            Control_Grid = gridEX1;
            Control_combo1 = combo1;
            Control_Grid.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.True;
            Control_Grid.AllowColumnDrag = false;
            Control_Grid.EnterKeyBehavior = EnterKeyBehavior.NextCell;                        
            Control_Grid.AutomaticSort = false;
            Control_Grid.NewRowEnterKeyBehavior = NewRowEnterKeyBehavior.None;            
            Control_Grid.SizingColumn += new SizingColumnEventHandler(gridEX1_SizingColumn);
            Control_Grid.Scroll += new EventHandler(gridEX1_Scroll);            
            GridEXRow row = Control_Grid.GetRow(Control_Grid.Row);
            Control_combo1.AutoComplete = true;
            if (Control_Grid.CurrentColumn == Control_Grid.RootTable.Columns[colName_Cobo])
            {
                if (row != null && row.Position < 0)
                {
                    Control_Grid.Controls.Remove(Control_combo1);
                    Control_Grid.RootTable.Columns[colName_Cobo].EditType = EditType.TextBox;
                }
                else
                {                    
                    row_old = row;                    
                    TEXTBOX txt_cobo = new TEXTBOX();
                    Control_Grid.RootTable.Columns[colName_Cobo].EditType = EditType.NoEdit;
                    rect = Control_Grid.GetCellBounds(Control_Grid.Row, Control_Grid.RootTable.Columns[colName_Cobo].Position);
                    Control_Grid.Controls.Add(Control_combo1);
                    Control_combo1.Location = new Point(rect.X, rect.Y);
                    Control_combo1.Size = new Size(Control_Grid.RootTable.Columns[colName_Cobo].Width, 21);
                    gridEX1.RootTable.Columns[colName_Cobo].EditType = EditType.NoEdit;
                    rect = gridEX1.GetCellBounds(gridEX1.Row, gridEX1.RootTable.Columns[colName_Cobo].Position);
                    gridEX1.Controls.Add(combo1);
                    combo1.Location = new Point(rect.X, rect.Y);
                    combo1.Size = new Size(gridEX1.RootTable.Columns[colName_Cobo].Width, 21);
                    txt_cobo.Visible = false;
                    Control_combo1.Visible = true;
                    Control_combo1.Enabled = true;
                    GD.FM.LIB.COMBO_COMM.SOURCE(Control_combo1, txt_cobo, dt_cobo, value_combo, key_combo);
                    if (row.Cells[colName_Cobo].Value != null)
                    {
                        Control_combo1.SelectedValue = row.Cells[colName_Cobo].Value.ToString();
                    }
                    Control_combo1.Focus();
                }
            }
            else
            {
                #region
                if (Control_Grid.CurrentColumn != null && row != null && row.Position >= 0)
                {
                    bool flag = false;
                    Control_combo1.AutoComplete = true;
                    for (int i = 0; i < dt_cobo.Rows.Count; i++)
                    {
                        if (dt_cobo.Rows[i][key_combo].ToString().Equals(Control_combo1.Text))
                        {                            
                            row_old.BeginEdit();
                            row_old.Cells[colName_Cobo].Value = Control_combo1.Text.Trim();
                            row_old = Control_Grid.GetRow(Control_Grid.Row);
                            try { Control_combo1.SelectedIndex = 0; }
                            catch { }
                            flag = true;
                            break;                                
                        }
                        if (flag) { break; }
                    }
                    Control_Grid.Controls.Remove(Control_combo1);
                    Control_Grid.Focus();
                }
                #endregion
            }
        }
        public static void addTxtDateTime(string colName_Datetime, TEXTBOXDATE txt_DATETIME, GridEX gridEX1)
        {
            Control_Grid = gridEX1;
            Control_txt_DATETIME = txt_DATETIME;
            Control_Grid.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.True;
            Control_Grid.AllowColumnDrag = false;
            Control_Grid.EnterKeyBehavior = EnterKeyBehavior.NextCell;            
            Control_Grid.AutomaticSort = false;
            Control_Grid.NewRowEnterKeyBehavior = NewRowEnterKeyBehavior.None;
            Control_Grid.Scroll += new EventHandler(gridEX1_Scroll1);
            Control_Grid.SizingColumn += new SizingColumnEventHandler(gridEX1_SizingColumn1);
            GridEXRow row = Control_Grid.GetRow(Control_Grid.Row);
            if (Control_Grid.CurrentColumn == Control_Grid.RootTable.Columns[colName_Datetime])
            {
                if (row != null && row.Position < 0)
                {
                    Control_Grid.Controls.Remove(Control_txt_DATETIME);
                    Control_Grid.RootTable.Columns[colName_Datetime].EditType = EditType.CalendarCombo;
                }
                else
                {                    
                    Control_Grid.RootTable.Columns[colName_Datetime].EditType = EditType.NoEdit;
                    rect = Control_Grid.GetCellBounds(Control_Grid.Row, Control_Grid.RootTable.Columns[colName_Datetime].Position);
                    Control_Grid.Controls.Add(Control_txt_DATETIME);                    
                    Control_txt_DATETIME.Location = new Point(rect.X + Control_Grid.Location.X, rect.Y + Control_Grid.Location.Y);
                    Control_txt_DATETIME.Size = new Size(Control_Grid.RootTable.Columns[colName_Datetime].Width, 21);
                    Control_txt_DATETIME.Visible = true;
                    Control_txt_DATETIME.Enabled = true;
                    if (row.Cells[colName_Datetime].Value != null)
                    {
                        Control_txt_DATETIME.SetDateTime(DateTime.Parse(row.Cells[colName_Datetime].Value.ToString()));
                    }
                    Control_txt_DATETIME.Focus();
                }
            }
            else
            {
                #region
                if (!string.IsNullOrEmpty(Control_txt_DATETIME.Text) && row != null && row.Position >= 0)
                {
                    if (row != null && row.Selected)
                    {
                        try
                        {
                            foreach (GridEXCell cell in row.Cells)
                            {
                                if (cell.Column.Key == colName_Datetime)
                                {
                                    cell.Value = Control_txt_DATETIME.Text.Trim();
                                    break;
                                }
                            }
                        }
                        catch (FormatException)
                        {
                            MessageBox.Show("Ngày tháng không đúng !\n Bạn hãy nhập lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            Control_Grid.CurrentColumn = Control_Grid.RootTable.Columns[colName_Datetime];
                            Control_Grid.RootTable.Columns[colName_Datetime].EditType = EditType.NoEdit;
                            rect = Control_Grid.GetCellBounds(Control_Grid.Row, Control_Grid.RootTable.Columns[colName_Datetime].Position);
                            Control_Grid.Controls.Add(Control_txt_DATETIME);
                            Control_txt_DATETIME.Location = new Point(rect.X + Control_Grid.Location.X, rect.Y + Control_Grid.Location.Y);
                            Control_txt_DATETIME.Size = new Size(Control_Grid.RootTable.Columns[colName_Datetime].Width, 21);
                            Control_txt_DATETIME.Visible = true;
                            Control_txt_DATETIME.Enabled = true;
                        }
                    }
                }
                Control_Grid.Focus();
                Control_Grid.Controls.Remove(Control_txt_DATETIME);
                #endregion
            }
        }
        #endregion
        #region EVENT
        static void gridEX1_SizingColumn1(object sender, SizingColumnEventArgs e)
        {
            Control_Grid.Controls.Remove(Control_txt_DATETIME);
        }
        static void gridEX1_SizingColumn(object sender, SizingColumnEventArgs e)
        {
            Control_Grid.Controls.Remove(Control_combo1);
        }
        static void gridEX1_Scroll1(object sender, EventArgs e)
        {
            Control_Grid.Controls.Remove(Control_txt_DATETIME);
        }
        static void gridEX1_Scroll(object sender, EventArgs e)
        {
            Control_Grid.Controls.Remove(Control_combo1);
        }
        static void Control_Grid_CurrentCellChanged1(object sender, EventArgs e)
        {
            addTxtDateTime(_colName_Datetime, Control_txt_DATETIME, Control_Grid);
        }
        static void Control_Grid_CurrentCellChanged(object sender, EventArgs e)
        {
            addComboBox(_dt_combo, _colName_Cobo, Control_Grid, Control_combo1, _valueCobo, _keyCobo);
        }
        #endregion
    }
}
