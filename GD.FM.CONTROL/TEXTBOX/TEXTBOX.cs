using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Runtime.InteropServices;
using Janus.Windows.GridEX;         


namespace GD.FM.CONTROL
{

    public partial class TEXTBOX : TextBox
    {
        private string TENDM = "";
        public openFormHandle openForm;
        public closeFormHandle closeForm;
        private bool _isShowForm;
        private static TEXTBOX _tx;
        private static GridEX _grid;
        private static string _colvalue;
        private static System.Data.DataTable _dt;
        private bool controlKey = false;
        private bool _AutoComplete;
        private int      _LinkedColumnIndex;
        private TextBox  _LinkedTextBox;
        //private Collection<string> _ColumnNames = new Collection<string>();
        //private Collection<int> _ColumnWidths = new Collection<int>();
#region "Declarations"

        private string mRegularExpression;
        private bool IsDateTime;
#endregion

        void TEXTBOX_Disposed(object sender, EventArgs e)
        {
            if (_grid != null)
            {
                this.IsShowForm = false;
                _grid.RowDoubleClick -= new RowActionEventHandler(_grid_RowDoubleClick);
                _grid.KeyDown -= new KeyEventHandler(_grid_KeyDown);
            }
        }
#region "Properties"
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
        public string Regular_Expression
        {
            get
            {
                return mRegularExpression;
            }
            set
            {
                mRegularExpression = value;
            }
        }
        public bool Is_DateTime
        {
            get
            {
                return IsDateTime;
            }
            set
            {
                IsDateTime = value;
            }
        }
#endregion
        public void Get_GRID_PK(GridEX grid, string colValue, System.Data.DataTable dt)
        {//su dung trong form them moi': new GD.FM.CONTROL.COMBO().Get_GRID_PK(GRID_BOPHANDV, DmbophandvFields.Mabophan.Name, DmbophandvFields.Tenbophan.Name,DT_BOPHANDV);            
            if (_tx != null && _tx.IsShowForm)
            {
                _grid = grid;
                _colvalue = colValue;
                _dt = dt;
                _grid.RowDoubleClick +=new RowActionEventHandler(_grid_RowDoubleClick);
                _grid.KeyDown +=new KeyEventHandler(_grid_KeyDown);
            }
        }
        void _grid_RowDoubleClick(object sender, RowActionEventArgs e)
        {
            _tx.Text = e.Row.Cells[_colvalue].Value.ToString();
            this.closeForm(this, TENDM);
        }
        void _grid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Space)
            {
                _tx.Text = _grid.CurrentRow.Cells[_colvalue].Value.ToString();
                this.closeForm(this, TENDM);
            }
        }
      
#region "Constructor"

        public TEXTBOX()
        {
            InitializeComponent();
            ContextMenu = new ContextMenu();
            this.Disposed +=new EventHandler(TEXTBOX_Disposed);
        }
        [DllImport("User32.dll")]
        public extern static IntPtr GetWindowDC(IntPtr hWnd);

        [DllImport("User32.dll")]
        public extern static int ReleaseDC(IntPtr hWnd, IntPtr hDC);

        [DllImport("user32")]
        private static extern bool HideCaret(IntPtr hWnd);
        #region Declarations
        private int m_BorderWidth = 1;
        private int m_FixedSingleLineWidth = 1;
        private Color m_BorderColor = Color.Red;
        private Color m_FixedSingleLineColor = Color.CadetBlue;

        private bool doRedraw = false;
        private bool hideCaret = false;
        private bool first = true;
        private bool doPaint = false;

        #endregion Declarations
        private void PaintBorderRect(IntPtr hWnd, int width, Color color, object borderLineColor)
        {
            if (width == 0) return;                             // Without this test there may be artifacts

            IntPtr hDC = GetWindowDC(hWnd);
            using (Graphics g = Graphics.FromHdc(hDC))
            {
                using (Pen p = new Pen(color, width))
                {
                    p.Alignment = System.Drawing.Drawing2D.PenAlignment.Inset;
                    // 2634 -- Start
                    // There is a bug when drawing a line of width 1 so we have to special case it and adjust
                    // the height and width down 1 to circumvent it:
                    int adjustment = (width == 1 ? 1 : 0);
                    g.DrawRectangle(p, new Rectangle(0, 0, Width - adjustment, Height - adjustment));
                    // 2634 -- End

                    // Draw the border line if a color is specified and there is room:
                    if (borderLineColor != null && width >= m_FixedSingleLineWidth && m_FixedSingleLineWidth > 0)   // 2635
                    {
                        p.Color = (Color)borderLineColor;
                        p.Width = m_FixedSingleLineWidth;
                        int offset = width - m_FixedSingleLineWidth;    // Overlay the inner border edge with the border line
                        // 2634 -- Start
                        // There is a bug when drawing a line of width 1 so we have to special case it and adjust
                        // the height and width down 1 to circumvent it:
                        adjustment = (m_FixedSingleLineWidth == 1 ? 1 : 0);
                        g.DrawRectangle(p, new Rectangle(offset, offset, Width - offset - offset - adjustment,
                                                         Height - offset - offset - adjustment));
                        // 2634 -- End
                    }
                }
            }
            ReleaseDC(hWnd, hDC);
        }
#endregion


#region "Methods"

        protected override void OnPaint(PaintEventArgs pe)
        {
            // TODO: Add custom paint code here

            // Calling the base class OnPaint
            base.OnPaint(pe);
        }
        // This method intercepts the Enter Key signal before the containing Form does
        protected override bool ProcessCmdKey(ref System.Windows.Forms.Message m, System.Windows.Forms.Keys k)
        {
            if (_isShowForm)
            {
                if (_isShowForm && k == System.Windows.Forms.Keys.F9)
                {
                    _tx = this;
                    this.openForm(this, TENDM);
                    return true;
                }
            }
            // detect the pushing of Enter Key
            if (m.Msg == 256 && k == System.Windows.Forms.Keys.Enter)
            {                
                // Execute an alternative action: here we tabulate in order to focus on the next control in the formular
                System.Windows.Forms.SendKeys.Send("\t");
                //SelectNextControl((Control)this, true, true, true, false);                
                // return true to stop any further interpretation of this key action
                return true;
            }
            if (k == System.Windows.Forms.Keys.PageUp || k == System.Windows.Forms.Keys.Up)
            {
                // Execute an alternative action: here we tabulate in order to focus on the next control in the formular
                System.Windows.Forms.SendKeys.Send("+{TAB}");
                // return true to stop any further interpretation of this key action

                return true;
            }
            if (k == System.Windows.Forms.Keys.PageDown || k == System.Windows.Forms.Keys.Down)
            {
                // Execute an alternative action: here we tabulate in order to focus on the next control in the formular
                System.Windows.Forms.SendKeys.Send("{TAB}");
                // return true to stop any further interpretation of this key action

                return true;
            }
            if (k == (Keys)new KeysConverter().ConvertFromString("Ctrl+A"))
            {
                this.SelectAll();
            }
            // if not pushing Enter Key, then process the signal as usual
            return base.ProcessCmdKey(ref m, k);
        }
        public bool ValidateControl()
        {
            string TextToValidate;
            Regex expression;

            try
            {
                TextToValidate = this.Text;
                expression = new Regex(Regular_Expression);
            }
            catch
            {
                return false;
            }

            // test text with expression
            if (expression.IsMatch(TextToValidate))
            {
                return true;
            }
            else
            {
                // no match
                return false;
            }
        }

#endregion

#region bannertext

        #region NativeMethods

        private const uint ECM_FIRST = 0x1500;
        private const uint EM_SETCUEBANNER = ECM_FIRST + 1;
        private const uint WM_SETFONT = 0x30;

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        private static extern IntPtr SendMessage(IntPtr hWnd, UInt32 msg, IntPtr wParam, string lParam);
        public Color FixedSingleLineColor
        {
            get { return m_FixedSingleLineColor; }
            set
            {
                m_FixedSingleLineColor = value;
                Redraw();
            }
        }
        private void Redraw()
        {
            // Make sure there is no recursion while recreating the handle:
            if (!this.RecreatingHandle) doRedraw = true;        // doRedraw = !this.RecreatingHandle;

            #region DEBUG redrawCount++
#if DEBUG
            //redrawCount++;
            //Debug.WriteLine("****** Redraw()");
#endif
            #endregion DEBUG redrawCount++
        }
        #endregion

        private string _bannerText;
        private Font _bannerFont;

        /// <summary>
        /// The banner text associated with the control.
        /// </summary>
        [Description("The banner text associated with the control.")]
        [Category("Appearance")]
        public string BannerText
        {
            get { return _bannerText; }
            set
            {
                _bannerText = value;

                // If supported set the value as banner text.
                if (IsSupported)
                    SendMessage(this.Handle, EM_SETCUEBANNER, IntPtr.Zero, value);
            }
        }

        /// <summary>
        /// The banner font used to display the banner text in the control.
        /// </summary>
        [Description("The banner font used to display the banner text in the control.")]
        [Category("Appearance")]
        public Font BannerFont
        {
            get
            {
                if (_bannerFont == null && this.Parent != null)
                    return this.Parent.Font;

                return _bannerFont;
            }
            set { _bannerFont = value; }
        }

        #region Overridden Members

        /// <summary>
        /// Invoked each time the focus is lost.
        /// </summary>
        /// <param name="e"></param>
        protected override void OnLostFocus(EventArgs e)
        {
            base.OnLostFocus(e);
            // Notify the text box to change the font to the banner font.
            if (this.Text.Length == 0 && IsSupported)
            {
                SendMessage(this.Handle, WM_SETFONT, _bannerFont.ToHfont(), null);
            }

            PaintBorderRect(this.Handle, m_BorderWidth, Color.LightSteelBlue,
                   (this.BorderStyle == System.Windows.Forms.BorderStyle.FixedSingle) ? (object)FixedSingleLineColor : null);
        }
        //protected override void OnLeave(EventArgs e)
        //{
        //    base.OnLeave(e);

        //    // Notify the text box to change the font back.
        //    if (IsSupported)
        //        SendMessage(this.Handle, WM_SETFONT, base.Font.ToHfont(), null);
        //    PaintBorderRect(this.Handle, m_BorderWidth, Color.LightSteelBlue,
        //           (BorderStyle == BorderStyle.FixedSingle) ? (object)FixedSingleLineColor : null);
        //}
        //protected override void OnMouseHover(EventArgs e)
        //{
        //    base.OnMouseHover(e);
        //    // Notify the text box to change the font to the banner font.
        //    PaintBorderRect(this.Handle, m_BorderWidth, Color.Red,
        //           (BorderStyle == BorderStyle.FixedSingle) ? (object)FixedSingleLineColor : null);
        //}
        //protected override void OnMouseLeave(EventArgs e)
        //{
        //    base.OnMouseLeave(e);
        //    // Notify the text box to change the font to the banner font.
        //    PaintBorderRect(this.Handle, m_BorderWidth, Color.LightBlue,
        //           (BorderStyle == BorderStyle.FixedSingle) ? (object)FixedSingleLineColor : null);
        //}
        /// <summary>
        /// Invoked each time the focus is gotten.
        /// </summary>
        /// <param name="e"></param>
        protected override void OnGotFocus(EventArgs e)
        {
            base.OnGotFocus(e);
            
            // Notify the text box to change the font back.
            if (IsSupported)
                SendMessage(this.Handle, WM_SETFONT, base.Font.ToHfont(), null);
            PaintBorderRect(this.Handle, m_BorderWidth, Color.Red,
                   (this.BorderStyle== System.Windows.Forms.BorderStyle.FixedSingle) ? (object)FixedSingleLineColor : null);
        }
        #endregion

        /// <summary>
        /// Returns whether the OS supports banner texts. It is fine if the application
        /// runs on XP or higher.
        /// </summary>
        private bool IsSupported
        {
            get
            {
                Version v = Environment.OSVersion.Version;
                return ((v.Major == 5 && v.Minor == 1) || v.Major > 5);
            }
        }

#endregion endbannertext
    }
}
