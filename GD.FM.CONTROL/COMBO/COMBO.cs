using System;
using System.Windows.Forms;
using System.Collections;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using Janus.Windows.GridEX;
using System.Data;
namespace GD.FM.CONTROL
{
    /*De~ dung` combobox show form can` :
     *Property : IsShowForm = true;
     *Property : FormNametoShow = ten form can` show.
     * doan code trong method khoi tao cua form chua' combo
        combo2.openForm = new GD.FM.CONTROL.openFormHandle(openFormDM);
        public void openFormDM(object sender, string strFormname)
        {            
            FRM_DM_PARENT.OpenFormByName(strFormname, "", this.ParentForm);
        }
     combo2 la` combo dung` de nhan' F9
     Cau lenh trong form duoc show. 
     combo1.closeForm = new GD.FM.CONTROL.closeFormHandle(CloseFormByName);
     neu 1 form vua` goi vua show thi combo2 = combo1
    */
    public delegate void openFormHandle(object sender, string frmName);
    public delegate void closeFormHandle(object sender, string frmName);    
    public class COMBO : ComboBox
    {
        #region Declare
        private string TENDM="";
        public openFormHandle openForm;
        public closeFormHandle closeForm;
        private bool _isShowForm;
        private static COMBO _cb;
        private static GridEX _grid;
        private static string _colkey;
        private static string _colvalue;
        private static System.Data.DataTable _dt;
        private bool controlKey = false;
        private bool     _AutoComplete;
        private bool     _AutoDropdown = true;
        private Color    _BackColorEven = Color.White;
        private Color    _BackColorOdd = Color.White;
        private string   _ColumnNameString = "";
        private int      _ColumnWidthDefault = 150;
        private string   _ColumnWidthString = "";
        private int      _LinkedColumnIndex;
        private TextBox  _LinkedTextBox;
        private int      _TotalWidth = 0;
        private int      _ValueMemberColumnIndex = 0;

        private Collection<string> _ColumnNames  = new Collection<string>();
        private Collection<int>    _ColumnWidths = new Collection<int>();
        #endregion
        public COMBO()
        {
            DrawMode = DrawMode.OwnerDrawVariable;
            this.AutoCompleteMode = AutoCompleteMode.None;            
            ContextMenu = new ContextMenu();
            this.Disposed += new EventHandler(COMBO_Disposed);
        }

        void COMBO_Disposed(object sender, EventArgs e)
        {
            if (_grid != null)
            {
                this.IsShowForm = false; 
                _grid.RowDoubleClick -= new RowActionEventHandler(_grid_RowDoubleClick);
                _grid.KeyDown -= new KeyEventHandler(_grid_KeyDown);
            }
        }
        #region PROPERTISE
        public string FormNametoShow
        {
            get { return TENDM; }
            set { TENDM = value; }
        }
        public bool IsShowForm
        {
            get
            {
                return _isShowForm;
            }
            set
            {
                _isShowForm = value;
            }
        }
        public event System.EventHandler OpenSearchForm;

        public bool AutoComplete
        {
            get
            {
                return _AutoComplete;
            }
            set
            {
                _AutoComplete = value;
            }
        }

        public bool AutoDropdown
        {
            get
            {
                return _AutoDropdown;
            }
            set
            {
                _AutoDropdown = value;
            }
        }

        public Color BackColorEven
        {
            get
            {
                return _BackColorEven;
            }
            set
            {
                _BackColorEven = value;
            }
        }

        public Color BackColorOdd
        {
            get
            {
                return _BackColorOdd;
            }
            set
            {
                _BackColorOdd = value;
            }
        }

        public Collection<string> ColumnNameCollection
        {
            get
            {
                return _ColumnNames;
            }
        }

        public string ColumnNames
        {
            get
            {
                return _ColumnNameString;
            }

            set
            {
                // If the column string is blank, leave it blank.
                // The default width will be used for all columns.
                if (! Convert.ToBoolean(value.Trim().Length))
                {
                    _ColumnNameString = "";
                }
                else if (value != null)
                {
                    char[] delimiterChars = { ',', ';', ':' };
                    string[] columnNames = value.Split(delimiterChars);

                    if (!DesignMode)
                    {
                        _ColumnNames.Clear();
                    }

                    // After splitting the string into an array, iterate
                    // through the strings and check that they're all valid.
                    foreach (string s in columnNames)
                    {
                        // Does it have length?
                        if (Convert.ToBoolean(s.Trim().Length))
                        {
                            if (!DesignMode)
                            {
                                _ColumnNames.Add(s.Trim());
                            }
                        }
                        else // The value is blank
                        {
                            throw new NotSupportedException("Column names can not be blank.");
                        }
                    }
                    _ColumnNameString = value;
                }
            }
        }

        public Collection<int> ColumnWidthCollection
        {
            get
            {
                return _ColumnWidths;
            }
        }

        public int ColumnWidthDefault
        {
            get
            {
                return _ColumnWidthDefault;
            }
            set
            {
                _ColumnWidthDefault = value;
            }
        }

        public string ColumnWidths
        {
            get
            {
                return _ColumnWidthString;
            }

            set
            {
                // If the column string is blank, leave it blank.
                // The default width will be used for all columns.
                if (! Convert.ToBoolean(value.Trim().Length))
                {
                    _ColumnWidthString = "";
                }
                else if (value != null)
                {
                    char[] delimiterChars = { ',', ';', ':' };
                    string[] columnWidths = value.Split(delimiterChars);
                    string invalidValue = "";
                    int invalidIndex = -1;
                    int idx = 1;
                    int intValue;

                    // After splitting the string into an array, iterate
                    // through the strings and check that they're all integers
                    // or blanks
                    foreach (string s in columnWidths)
                    {
                        // If it has length, test if it's an integer
                        if (Convert.ToBoolean(s.Trim().Length))
                        {
                            // It's not an integer. Flag the offending value.
                            if (!int.TryParse(s, out intValue))
                            {
                                invalidIndex = idx;
                                invalidValue = s;
                            }
                            else // The value was okay. Increment the item index.
                            {
                                idx++;
                            }
                        }
                        else // The value is a space. Use the default width.
                        {
                            idx++;
                        }
                    }

                    // If an invalid value was found, raise an exception.
                    if (invalidIndex > -1)
                    {
                        string errMsg;

                        errMsg = "Invalid column width '" + invalidValue + "' located at column " + invalidIndex.ToString();
                        throw new ArgumentOutOfRangeException(errMsg);
                    }
                    else // The string is fine
                    {
                        _ColumnWidthString = value;

                        // Only set the values of the collections at runtime.
                        // Setting them at design time doesn't accomplish 
                        // anything and causes errors since the collections 
                        // don't exist at design time.
                        if (!DesignMode)
                        {
                            _ColumnWidths.Clear();
                            foreach (string s in columnWidths)
                            {
                                // Initialize a column width to an integer
                                if (Convert.ToBoolean(s.Trim().Length))
                                {
                                    _ColumnWidths.Add(Convert.ToInt32(s));
                                }
                                else // Initialize the column to the default
                                {
                                    _ColumnWidths.Add(_ColumnWidthDefault);
                                }
                            }

                            // If the column is bound to data, set the column widths
                            // for any columns that aren't explicitly set by the 
                            // string value entered by the programmer
                            if (DataManager != null)
                            {
                                InitializeColumns();
                            }
                        }
                    }
                }
            }
        }

        public new DrawMode DrawMode 
        { 
            get
            {
                return base.DrawMode;
            } 
            set
            {
                if (value != DrawMode.OwnerDrawVariable)
                {
                    throw new NotSupportedException("Needs to be DrawMode.OwnerDrawVariable");
                }
                base.DrawMode = value;
            }
        }

        public new ComboBoxStyle DropDownStyle
        { 
            get
            {
                return base.DropDownStyle;
            } 
            set
            {
                if (value != ComboBoxStyle.DropDown)
                {
                    throw new NotSupportedException("ComboBoxStyle.DropDown is the only supported style");
                }
                base.DropDownStyle = value;
            } 
        }

        public int LinkedColumnIndex
        {
            get 
            { 
                return _LinkedColumnIndex; 
            }
            set 
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("A column index can not be negative");
                }
                _LinkedColumnIndex = value; 
            }
        }

        public TextBox LinkedTextBox
        {
            get 
            { 
                return _LinkedTextBox; 
            }
            set 
            { 
                _LinkedTextBox = value;

                if (_LinkedTextBox != null)
                {
                    // Set any default properties of the Linked Textbox here
                    _LinkedTextBox.ReadOnly = true;
                    _LinkedTextBox.TabStop = false;
                }
            }
        }

        public int TotalWidth
        {
            get
            {
                return _TotalWidth;
            }
        }
        #endregion 
        protected override void OnDataSourceChanged(EventArgs e)
        {
            base.OnDataSourceChanged(e);

            InitializeColumns();
        }
        protected override void OnLostFocus(EventArgs e)
        {
            try
            {
                if (_AutoComplete)
                {
                    string matchText = this.Text;
                    int match = this.FindString(matchText);
                    if (match == -1)
                    {
                        this.SelectedIndex = 0;
                        DroppedDown = false;
                    }
                    else
                    {
                        this.SelectedIndex = match;
                    }
                }
            }
            catch { }
            base.OnLostFocus(e);
        }

        protected override void OnDrawItem(DrawItemEventArgs e)
        {
            base.OnDrawItem(e);

            if (DesignMode)
                return;

            e.DrawBackground();

            Rectangle boundsRect = e.Bounds;
            int lastRight = 0;

            Color brushForeColor;
            if ((e.State & DrawItemState.Selected) == 0)
            {   
                // Item is not selected. Use BackColorOdd & BackColorEven
                Color backColor;
                backColor = Convert.ToBoolean(e.Index % 2) ? _BackColorOdd : _BackColorEven;
                using (SolidBrush brushBackColor = new SolidBrush(backColor))
                {
                    e.Graphics.FillRectangle(brushBackColor, e.Bounds);
                }
                brushForeColor = Color.Black;
            }
            else
            {
                // Item is selected. Use ForeColor = White
                brushForeColor = Color.White;
            }

            using (Pen linePen = new Pen(SystemColors.GrayText))
            {
                using (SolidBrush brush = new SolidBrush(brushForeColor))
                {
                    if (! Convert.ToBoolean(_ColumnNames.Count))
                    {
                        e.Graphics.DrawString(Convert.ToString(Items[e.Index]), Font, brush, boundsRect);
                    }
                    else
                    {
                        for (int colIndex = 0; colIndex < _ColumnNames.Count; colIndex++)
                        {
                            if (Convert.ToBoolean(_ColumnWidths[colIndex]))
                            {
                                string item = Convert.ToString(FilterItemOnProperty(Items[e.Index], _ColumnNames[colIndex]));

                                boundsRect.X = lastRight;
                                boundsRect.Width = (int)_ColumnWidths[colIndex]; 
                                lastRight = boundsRect.Right;
                                e.Graphics.DrawString(item, Font, brush, boundsRect);

                                if (colIndex < _ColumnNames.Count - 1)
                                {
                                    e.Graphics.DrawLine(linePen, boundsRect.Right, boundsRect.Top, boundsRect.Right, boundsRect.Bottom);
                                }
                            }
                        }

                    }
                }
            }

            e.DrawFocusRectangle();
        }

        #region Combo_ShowForm_AddNew        
        public void Get_GRID_PK(GridEX grid,string colKey,string colValue,System.Data.DataTable dt)
        {//su dung trong form them moi': new GD.FM.CONTROL.COMBO().Get_GRID_PK(GRID_BOPHANDV, DmbophandvFields.Mabophan.Name, DmbophandvFields.Tenbophan.Name,DT_BOPHANDV);            
            if (_cb != null && _cb.IsShowForm)
            {
                _grid = grid;
                _colkey = colKey;
                _colvalue = colValue;
                _dt = dt;
                _grid.RowDoubleClick += new RowActionEventHandler(_grid_RowDoubleClick);
                _grid.KeyDown += new KeyEventHandler(_grid_KeyDown);
            }
        }

        void _grid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Space)
            {
                TEXTBOX txt = new TEXTBOX();
                SOURCE(_cb, (TEXTBOX)_cb.LinkedTextBox, _dt, _colvalue, _colkey);
                _cb.SelectedValue = _grid.CurrentRow.Cells[_colkey].Value.ToString();
                this.closeForm(this, TENDM);
            }
        }
        void _grid_RowDoubleClick(object sender, RowActionEventArgs e)
        {            
            TEXTBOX txt = new TEXTBOX();
            SOURCE(_cb,(TEXTBOX)_cb.LinkedTextBox, _dt, _colvalue, _colkey);
            _cb.SelectedValue = e.Row.Cells[_colkey].Value.ToString();
            this.closeForm(this, TENDM);
        }
        public static void SOURCE(GD.FM.CONTROL.COMBO combo, GD.FM.CONTROL.TEXTBOX linktextbox, DataTable dt, string Columvalue, string Columkey)
        {
            DataView dtview = dt.DefaultView;
            dtview.Sort = Columkey + " ASC";
            dt = dtview.ToTable();
            DataTable dtempcate = new DataTable("dtempcate");
            dtempcate.Columns.Add("key", typeof(String));
            dtempcate.Columns.Add("value", typeof(String));
            dtempcate.Rows.Add(new String[] { "0000", "Lựa chọn" });
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string value = dt.Rows[i][Columvalue].ToString();
                string key = dt.Rows[i][Columkey].ToString();
                dtempcate.Rows.Add(new String[] { key, value });
            }
            combo.DataSource = dtempcate;
            combo.DisplayMember = "key";
            combo.ValueMember = "key";
            combo.LinkedTextBox = linktextbox;
            combo.LinkedColumnIndex = 1;
            combo.ColumnWidths = "50,200";
            combo.SelectedIndex = 0; linktextbox.Text = dtempcate.Rows[0]["value"].ToString();
        }
        #endregion
        
        protected override void OnDropDown(EventArgs e)
        {
            base.OnDropDown(e);

            if (_TotalWidth > 0)
            {
                this.DropDownWidth = _TotalWidth; 
            }
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);
            if (_AutoComplete)
            {
                if ((e.KeyCode == Keys.Delete) || (e.KeyCode == Keys.Escape))
                {
                    SelectedIndex = 0;
                    Text = "";
                    if (_LinkedTextBox != null)
                    {
                        _LinkedTextBox.Text = "";
                    }
                }
                else if (e.KeyCode == Keys.F9)
                {
                    if (OpenSearchForm != null)
                    {
                        OpenSearchForm(this, System.EventArgs.Empty);
                    }
                }
            }            
        }

        protected override void OnKeyPress(System.Windows.Forms.KeyPressEventArgs e)
        {
            base.OnKeyPress(e);
            if (_AutoComplete)
            {
                string matchText = this.Text;
                int match = this.FindString(matchText);
                if (e.KeyChar == (int)Keys.Escape)
                {
                    this.SelectedIndex = 0;                    
                    controlKey = true;
                }
                else if (Char.IsControl(e.KeyChar))
                {
                    controlKey = true;
                }
                else
                {
                    controlKey = false;
                }                
                if (match == -1)
                {
                    match = FindString(matchText);
                }
                else
                {
                    DroppedDown = true;
                }
            }
        }

        protected override void OnTextChanged(System.EventArgs e)
        {
            base.OnTextChanged(e);
            if (this.Text != "" && !controlKey)
            {
                if (_AutoComplete)
                {
                    string matchText = this.Text;
                    int match = this.FindString(matchText);
                    if (match != -1)
                    {
                        // anh huong den su kien SelectedIndexChanged.
                        //this.SelectedIndex = match;
                        Select(matchText.Length, this.Text.Length);
                    }
                }
            }
        }
        protected override void OnSelectedValueChanged(EventArgs e)
        {
            base.OnSelectedValueChanged(e);
            if (_LinkedTextBox != null)
            {
                if (_LinkedColumnIndex < _ColumnNames.Count)
                {
                    _LinkedTextBox.Text = Convert.ToString(FilterItemOnProperty(SelectedItem, _ColumnNames[_LinkedColumnIndex]));
                }
            }
        }
        protected override bool ProcessCmdKey(ref System.Windows.Forms.Message m, System.Windows.Forms.Keys k)
        {
            if (_isShowForm)
            {
                if (_isShowForm && k == System.Windows.Forms.Keys.F9)
                {
                    _cb = this;
                    this.openForm(this, TENDM);
                    return true;
                }
            }
            if (m.Msg == 256 && k == System.Windows.Forms.Keys.Enter)
            {
                System.Windows.Forms.SendKeys.Send("\t");
                if (_AutoComplete)
                {
                    string matchText = this.Text;
                    int match = this.FindString(matchText);
                    if (match == -1)
                    {
                        this.SelectedIndex = 0;
                        DroppedDown = false;
                    }
                    else
                    {
                        this.SelectedIndex = match;                        
                    }
                }
                return true;
            }
            if (_AutoComplete)
            {
                if (m.Msg == 256 && k == System.Windows.Forms.Keys.Escape)
                {
                    DroppedDown = false;
                    return true;
                }
                if (k == System.Windows.Forms.Keys.Left && this.SelectionStart == 0)
                {                    
                    SendKeys.Send("+{TAB}");
                    return true;
                }
                if (k == System.Windows.Forms.Keys.Right && this.SelectionStart == this.Text.Length)
                {
                    SendKeys.Send("{TAB}");
                    return true;
                }                
            }
            return base.ProcessCmdKey(ref m, k);
        }
        protected override void OnValueMemberChanged(EventArgs e)
        {
            base.OnValueMemberChanged(e);
            InitializeValueMemberColumn();
        }

        private void InitializeColumns()
        {
            if (!Convert.ToBoolean(_ColumnNameString.Length))
            {
                PropertyDescriptorCollection propertyDescriptorCollection = DataManager.GetItemProperties();
                _TotalWidth = 0;
                _ColumnNames.Clear();

                for (int colIndex = 0; colIndex < propertyDescriptorCollection.Count; colIndex++)
                {
                    _ColumnNames.Add(propertyDescriptorCollection[colIndex].Name);
                    if (colIndex >= _ColumnWidths.Count)
                    {
                        _ColumnWidths.Add(_ColumnWidthDefault);
                    }
                    _TotalWidth += _ColumnWidths[colIndex];
                }
            }
            else
            {
                _TotalWidth = 0;
                for (int colIndex = 0; colIndex < _ColumnNames.Count; colIndex++)
                {
                    if (colIndex >= _ColumnWidths.Count)
                    {
                        _ColumnWidths.Add(_ColumnWidthDefault);
                    }
                    _TotalWidth += _ColumnWidths[colIndex];
                }
            }
            if (_LinkedColumnIndex >= _ColumnNames.Count)
            {
                _LinkedColumnIndex = 0;
            }
        }

        private void InitializeValueMemberColumn()
        {            
            int colIndex = 0;
            foreach (String columnName in _ColumnNames)
            {
                if (String.Compare(columnName, ValueMember, true, CultureInfo.CurrentUICulture) == 0)
                {
                    _ValueMemberColumnIndex = colIndex;
                    break;
                }
                colIndex++;
            }
        }
        }
}
