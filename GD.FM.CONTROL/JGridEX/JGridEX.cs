using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Janus.Windows.GridEX;

namespace GD.FM.CONTROL
{
    public partial class JGridEX : GridEX
    {
        public JGridEX()
        {
            InitializeComponent();
            this.DefaultFilterRowComparison = FilterConditionOperator.Contains;
            this.FilterRowUpdateMode = FilterRowUpdateMode.WhenValueChanges;
            //this.AllowAddNew = InheritableBoolean.True;
            //this.NewRowPosition = NewRowPosition.BottomRow;
            this.CellSelectionMode = CellSelectionMode.SingleCell;
            this.VisualStyle = VisualStyle.Office2007;
        }
        public void COMBO_MULTICOLUMN(JGridEX Grid, string columnName, string columnDisplay, string _value_member, string _display_member, DataTable DT)
        {
            try
            {
                if (Grid.DropDowns.Contains(columnName) == false)
                {
                    Grid.DropDowns.Add(columnName);
                    GridEXDropDown dropDown = Grid.DropDowns[columnName];
                    dropDown.Columns.Add(_value_member);
                    dropDown.Columns.Add(columnDisplay);
                    dropDown.SelectedFormatStyle.ForeColor = Grid.SelectedFormatStyle.ForeColor;
                    dropDown.SelectedFormatStyle.BackColor = Grid.SelectedFormatStyle.BackColor;
                    dropDown.SetDataBinding(DT, "");
                    dropDown.ValueMember = _value_member;
                    dropDown.DisplayMember = _display_member;
                    Grid.RootTable.Columns[columnName].EditType = EditType.MultiColumnCombo;
                    Grid.RootTable.Columns[columnName].DropDown = dropDown;
                    Grid.RootTable.Columns[columnName].AutoComplete = true;
                    Grid.RootTable.Columns[columnName].AllowSort = true;
                    dropDown.DynamicFiltering = true;
                    dropDown.AutomaticSort = true;
                    Grid.AutomaticSort = false;
                }
                else Grid.DropDowns[columnName].SetDataBinding(DT, "");
            }
            catch { }
        }
        public void addDatetimepicker(JGridEX Grid, string columnName)
        {
            try
            {
                Grid.DropDowns.Add(columnName);
                GridEXDropDown dropDown = Grid.DropDowns[columnName];
                dropDown.SelectedFormatStyle.ForeColor = Grid.SelectedFormatStyle.ForeColor;
                dropDown.SelectedFormatStyle.BackColor = Grid.SelectedFormatStyle.BackColor;
                Grid.RootTable.Columns[columnName].EditType = EditType.CalendarCombo;
                Grid.RootTable.Columns[columnName].DropDown = dropDown;
            }
            catch { }
        }
        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            base.OnKeyPress(e);
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (this.AllowEdit == InheritableBoolean.True)
            {
                #region ENTER
                if (keyData == Keys.Enter)
                {
                    #region Add row
                    //if (this.CurrentColumn == this.RootTable.Columns[this.RootTable.Columns.Count - 1])
                    //{
                    //    BindingSource bs = (BindingSource)this.DataSource; 
                    //    if (bs != null)
                    //    {
                    //        DataTable dt = new DataTable();
                    //        try
                    //        {
                    //            DataView dtView = (DataView)bs.DataSource;
                    //            dt = dtView.ToTable();
                    //            bs.DataSource = new BindingSource(dt, null);
                    //        }
                    //        catch
                    //        {
                    //            try
                    //            {
                    //                dt = (DataTable)bs.DataSource;
                    //                bs.DataSource = new BindingSource(dt, null);
                    //            }
                    //            catch
                    //            {
                    //                bs = (BindingSource)bs.DataSource;
                    //                try
                    //                {
                    //                    DataView dtView = (DataView)bs.DataSource;
                    //                    dt = dtView.ToTable();
                    //                    bs.DataSource = new BindingSource(dt, null);
                    //                }
                    //                catch
                    //                {
                    //                    try
                    //                    {
                    //                        dt = (DataTable)bs.DataSource;
                    //                        bs.DataSource = new BindingSource(dt, null);
                    //                    }
                    //                    catch
                    //                    {
                    //                        try
                    //                        {
                    //                            DataRowView drview = (DataRowView)bs.Current;
                    //                            dt = drview.DataView.ToTable();
                    //                            bs.DataSource = new BindingSource(dt, null);
                    //                        }
                    //                        catch { }
                    //                    }
                    //                }
                    //            }
                    //        }
                    //        if (this.AllowAddNew == InheritableBoolean.True)
                    //        {
                    //            DataRow _row = dt.NewRow();
                    //            dt.Rows.Add(_row);
                    //            bs.Position = dt.Rows.Count;
                    //            this.Focus();
                    //            this.Col = 0;
                    //        }
                    //    }
                    //    else
                    //    {
                    //        if (this.AllowAddNew == InheritableBoolean.True)
                    //        {
                    //            this.BoundMode = BoundMode.Unbound;
                    //            this.AddItem(this.RowCount);
                    //            this.Focus();
                    //            this.Col = 0;
                    //        }
                    //    }
                    //}
                    //else
                    //{
                    //    if (this.RowCount == 1 || this.Row == this.RowCount - 1)
                    //    {
                    //        SendKeys.Send("{TAB}");
                    //    }
                    //    //return true;
                    //}
                    #endregion
                    SendKeys.Send("{TAB}"); return true;
                    //SendKeys.Send("\t");
                }
                #endregion
                #region F8 and CONTROL+N
                else if (keyData == Keys.F8 || keyData == (Keys)new KeysConverter().ConvertFromString("Ctrl+N"))
                {
                    BindingSource bs = (BindingSource)this.DataSource;
                    if (bs != null)
                    {
                        DataTable dt = new DataTable();
                        try
                        {
                            dt = (DataTable)bs.DataSource;
                            bs.DataSource = dt;// new BindingSource(dt, null);

                        }
                        catch
                        {
                            try
                            {
                                DataView dtView = (DataView)bs.DataSource;
                                dt = dtView.ToTable();
                                bs.DataSource = dt;// new BindingSource(dt, null);
                            }
                            catch
                            {
                                bs = (BindingSource)bs.DataSource;
                                try
                                {
                                    DataView dtView = (DataView)bs.DataSource;
                                    dt = dtView.ToTable();
                                    bs.DataSource = dt;// new BindingSource(dt, null);
                                }
                                catch
                                {
                                    try
                                    {
                                        dt = (DataTable)bs.DataSource;
                                        bs.DataSource = dt;// new BindingSource(dt, null);
                                    }
                                    catch
                                    {
                                        try
                                        {
                                            DataRowView drview = (DataRowView)bs.Current;
                                            dt = drview.DataView.ToTable();
                                            bs.DataSource = dt;// new BindingSource(dt, null);
                                        }
                                        catch { }
                                    }
                                }
                            }
                        }
                        try
                        {
                            DataRow _row = dt.NewRow();
                            if (this.CurrentRow != null)
                            {
                                dt.Rows.InsertAt(_row, this.CurrentRow.Position + 1);
                                bs.Position = this.CurrentRow.Position + 1;// -1;//dt.Rows.Count;
                            }
                            else
                            {
                                dt.Rows.InsertAt(_row, dt.Rows.Count);
                                bs.Position = dt.Rows.Count;// -1;
                            }
                            this.Focus();
                            this.Col = 0;
                        }
                        catch { }
                    }
                    else
                    {
                        this.BoundMode = BoundMode.Unbound;
                        this.AddItem(this.RowCount);
                        this.Focus();
                        this.Col = 0;
                    }
                }
                #endregion
                #region F7 and CONTROL+X
                else if (keyData == Keys.F7 || keyData == (Keys)new KeysConverter().ConvertFromString("Ctrl+X"))
                {
                    BindingSource bs = (BindingSource)this.DataSource;
                    BindingSource bs_temp = new BindingSource();
                    if (bs != null)
                    {
                        DataTable dt = new DataTable();
                        try
                        {
                            dt = (DataTable)bs.DataSource;
                            bs.DataSource = dt;// new BindingSource(dt, null);
                        }
                        catch
                        {
                            try
                            {
                                DataView dtView = (DataView)bs.DataSource;
                                dt = dtView.ToTable();
                                bs.DataSource = dt;// new BindingSource(dt, null);
                            }
                            catch
                            {
                                bs_temp = (BindingSource)bs.DataSource;
                                try
                                {
                                    DataView dtView = (DataView)bs_temp.DataSource;
                                    dt = dtView.ToTable();
                                    bs_temp.DataSource = dt;// new BindingSource(dt, null);
                                }
                                catch
                                {
                                    try
                                    {
                                        dt = (DataTable)bs.DataSource;
                                        bs.DataSource = dt;// new BindingSource(dt, null);
                                    }
                                    catch
                                    {
                                        try
                                        {
                                            DataRowView drview = (DataRowView)bs.Current;
                                            dt = drview.DataView.ToTable();
                                            bs.DataSource = dt;// new BindingSource(dt, null);
                                        }
                                        catch { }
                                    }
                                }
                            }
                        }
                        if (bs.Position >= 0)
                        {
                            dt.Rows.RemoveAt(bs.Position);
                            this.Focus();
                            this.Col = 0;
                        }
                    }
                    else
                    { this.CurrentRow.Delete(); this.Focus(); this.Col = 0; }
                }
                #endregion
                #region KEY DOWN
                else if (keyData.ToString() == "Down" && this.Row == this.RowCount - 1)
                {
                    try
                    {
                        BindingSource bs = (BindingSource)this.DataSource;

                        if (bs != null)
                        {
                            DataTable dt = new DataTable();
                            try
                            {
                                dt = (DataTable)bs.DataSource;
                                bs.DataSource = dt;// new BindingSource(dt, null);

                            }
                            catch
                            {
                                try
                                {
                                    DataView dtView = (DataView)bs.DataSource;
                                    dt = dtView.ToTable();
                                    bs.DataSource = dt;// new BindingSource(dt, null);
                                }
                                catch
                                {
                                    bs = (BindingSource)bs.DataSource;
                                    try
                                    {
                                        DataView dtView = (DataView)bs.DataSource;
                                        dt = dtView.ToTable();
                                        bs.DataSource = dt;// new BindingSource(dt, null);
                                    }
                                    catch
                                    {
                                        try
                                        {
                                            dt = (DataTable)bs.DataSource;
                                            bs.DataSource = dt;// new BindingSource(dt, null);
                                        }
                                        catch
                                        {
                                            try
                                            {
                                                DataRowView drview = (DataRowView)bs.Current;
                                                dt = drview.DataView.ToTable();
                                                bs.DataSource = dt;// new BindingSource(dt, null);
                                            }
                                            catch { }
                                        }
                                    }
                                }
                            }
                            try
                            {
                                DataRow _row = dt.NewRow();
                                if (this.CurrentRow != null)
                                {
                                    dt.Rows.InsertAt(_row, this.CurrentRow.Position + 1);
                                    bs.Position = this.CurrentRow.Position + 1;// -1;//dt.Rows.Count;
                                }
                                else
                                {
                                    dt.Rows.InsertAt(_row, dt.Rows.Count);
                                    bs.Position = dt.Rows.Count;// -1;
                                }
                                this.Focus();
                                //this.Col = 0;
                            }
                            catch { }
                        }
                        else
                        {
                            this.BoundMode = BoundMode.Unbound;
                            this.AddItem(this.RowCount);
                            this.Focus();
                            this.Col = 0;
                        }
                    }
                    catch
                    {
                      
                    }
                }
                #endregion
                #region CONTROL + ENTER // them moi dong giong dong ben tren
                else if (keyData == (Keys)new KeysConverter().ConvertFromString("Ctrl+Enter"))
                {
                    BindingSource bs = (BindingSource)this.DataSource;
                    if (bs != null)
                    {
                        DataTable dt = new DataTable();
                        try
                        {
                            dt = (DataTable)bs.DataSource;
                            bs.DataSource = dt;

                        }
                        catch
                        {
                            try
                            {
                                DataView dtView = (DataView)bs.DataSource;
                                dt = dtView.ToTable();
                                bs.DataSource = dt;
                            }
                            catch
                            {
                                bs = (BindingSource)bs.DataSource;
                                try
                                {
                                    DataView dtView = (DataView)bs.DataSource;
                                    dt = dtView.ToTable();
                                    bs.DataSource = dt;
                                }
                                catch
                                {
                                    try
                                    {
                                        dt = (DataTable)bs.DataSource;
                                        bs.DataSource = dt;
                                    }
                                    catch
                                    {
                                        try
                                        {
                                            DataRowView drview = (DataRowView)bs.Current;
                                            dt = drview.DataView.ToTable();
                                            bs.DataSource = dt;
                                        }
                                        catch { }
                                    }
                                }
                            }
                        }
                        try
                        {
                            DataRow _row = dt.NewRow();
                            if (this.CurrentRow != null)
                            {
                                DataRowView _r = (DataRowView)this.CurrentRow.DataRow;
                                for (int i = 0; i < dt.Columns.Count; i++)
                                {
                                    _row[i] = _r[i];
                                }
                                dt.Rows.InsertAt(_row, this.CurrentRow.Position + 1);
                                bs.Position = this.CurrentRow.Position + 1;
                            }
                            else
                            {
                                dt.Rows.InsertAt(_row, dt.Rows.Count);
                                bs.Position = dt.Rows.Count;
                            }
                            this.Focus();
                            this.Col = 0;
                        }
                        catch { }
                    }
                    else
                    {
                        this.BoundMode = BoundMode.Unbound;
                        this.AddItem(this.RowCount);
                        this.Focus();
                        this.Col = 0;
                    }
                }
                #endregion
                else if (keyData == (Keys)new KeysConverter().ConvertFromString("Ctrl+C"))
                {
                    string s = this.CurrentRow.Cells[this.Col].Value.ToString();
                    if (!string.IsNullOrEmpty(s))
                        Clipboard.SetText(s);
                }
                else if (keyData == (Keys)new KeysConverter().ConvertFromString("Ctrl+V") && this.AllowEdit == InheritableBoolean.True)
                {
                    this.CurrentRow.Cells[this.Col].Value = Clipboard.GetText();
                }
                else
                {
                    if (keyData == Keys.Enter) { SendKeys.Send("{TAB}"); return true; }
                }
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        public void CallProKey(Keys key)
        {
            Message m = new Message();
            ProcessCmdKey(ref m, key);
        }
    }
}
