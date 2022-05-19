// Decompiled with JetBrains decompiler
// Type: TBNet.RegExTextBox
// Assembly: TBNet.Forms.Control, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DE87E719-51C4-42D8-A566-BE783BA316FC
// Assembly location: D:\temp\KTX\GD.FM\DLL\TBNet.Forms.Control.dll

using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace GD.FM.LIB
{
  public class RegExTextBox : TextBox
  {
    private int m_BorderWidth = 1;
    private int m_FixedSingleLineWidth = 1;
    private Color m_BorderColor = Color.Red;
    private Color m_FixedSingleLineColor = Color.CadetBlue;
    private bool doRedraw = false;
    private bool hideCaret = false;
    private bool first = true;
    private bool doPaint = false;
    private IContainer components = (IContainer) null;
    private const uint ECM_FIRST = 5376U;
    private const uint EM_SETCUEBANNER = 5377U;
    private const uint WM_SETFONT = 48U;
    private string mRegularExpression;
    private string _bannerText;
    private Font _bannerFont;

    public string Regular_Expression
    {
      get
      {
        return this.mRegularExpression;
      }
      set
      {
        this.mRegularExpression = value;
      }
    }

    public Color FixedSingleLineColor
    {
      get
      {
        return this.m_FixedSingleLineColor;
      }
      set
      {
        this.m_FixedSingleLineColor = value;
        this.Redraw();
      }
    }

    [Category("Appearance")]
    [Description("The banner text associated with the control.")]
    public string BannerText
    {
      get
      {
        return this._bannerText;
      }
      set
      {
        this._bannerText = value;
        if (!this.IsSupported)
          return;
        RegExTextBox.SendMessage(this.Handle, 5377U, IntPtr.Zero, value);
      }
    }

    [Description("The banner font used to display the banner text in the control.")]
    [Category("Appearance")]
    public Font BannerFont
    {
      get
      {
        if (this._bannerFont == null && this.Parent != null)
          return this.Parent.Font;
        else
          return this._bannerFont;
      }
      set
      {
        this._bannerFont = value;
      }
    }

    private bool IsSupported
    {
      get
      {
        Version version = Environment.OSVersion.Version;
        return version.Major == 5 && version.Minor == 1 || version.Major > 5;
      }
    }

    public RegExTextBox()
    {
      this.InitializeComponent();
    }

    [DllImport("User32.dll")]
    public static extern IntPtr GetWindowDC(IntPtr hWnd);

    [DllImport("User32.dll")]
    public static extern int ReleaseDC(IntPtr hWnd, IntPtr hDC);

    [DllImport("user32")]
    private static extern bool HideCaret(IntPtr hWnd);

    private void PaintBorderRect(IntPtr hWnd, int width, Color color, object borderLineColor)
    {
      if (width == 0)
        return;
      IntPtr windowDc = RegExTextBox.GetWindowDC(hWnd);
      using (Graphics graphics = Graphics.FromHdc(windowDc))
      {
        using (Pen pen = new Pen(color, (float) width))
        {
          pen.Alignment = PenAlignment.Inset;
          int num1 = width == 1 ? 1 : 0;
          graphics.DrawRectangle(pen, new Rectangle(0, 0, this.Width - num1, this.Height - num1));
          if (borderLineColor != null && width >= this.m_FixedSingleLineWidth && this.m_FixedSingleLineWidth > 0)
          {
            pen.Color = (Color) borderLineColor;
            pen.Width = (float) this.m_FixedSingleLineWidth;
            int num2 = width - this.m_FixedSingleLineWidth;
            int num3 = this.m_FixedSingleLineWidth == 1 ? 1 : 0;
            graphics.DrawRectangle(pen, new Rectangle(num2, num2, this.Width - num2 - num2 - num3, this.Height - num2 - num2 - num3));
          }
        }
      }
      RegExTextBox.ReleaseDC(hWnd, windowDc);
    }

    protected override void OnPaint(PaintEventArgs pe)
    {
      base.OnPaint(pe);
    }

    protected override bool ProcessCmdKey(ref Message m, Keys k)
    {
      if (m.Msg == 256 && k == Keys.Return)
      {
        SendKeys.Send("\t");
        return true;
      }
      else if (k == Keys.Prior || k == Keys.Up)
      {
        SendKeys.Send("+{TAB}");
        return true;
      }
      else
      {
        if (k != Keys.Next && k != Keys.Down)
          return base.ProcessCmdKey(ref m, k);
        SendKeys.Send("{TAB}");
        return true;
      }
    }

    public bool ValidateControl()
    {
      string text;
      Regex regex;
      try
      {
        text = this.Text;
        regex = new Regex(this.Regular_Expression);
      }
      catch
      {
        return false;
      }
      return regex.IsMatch(text);
    }

    [DllImport("user32.dll", CharSet = CharSet.Unicode)]
    private static extern IntPtr SendMessage(IntPtr hWnd, uint msg, IntPtr wParam, string lParam);

    private void Redraw()
    {
      if (this.RecreatingHandle)
        return;
      this.doRedraw = true;
    }

    protected override void OnLostFocus(EventArgs e)
    {
      base.OnLostFocus(e);
      if (this.Text.Length == 0 && this.IsSupported)
        RegExTextBox.SendMessage(this.Handle, 48U, this._bannerFont.ToHfont(), (string) null);
      this.PaintBorderRect(this.Handle, this.m_BorderWidth, Color.LightSteelBlue, this.BorderStyle == BorderStyle.FixedSingle ? (object) this.FixedSingleLineColor : (object) null);
    }

    protected override void OnGotFocus(EventArgs e)
    {
      base.OnGotFocus(e);
      if (this.IsSupported)
        RegExTextBox.SendMessage(this.Handle, 48U, this.Font.ToHfont(), (string) null);
      this.PaintBorderRect(this.Handle, this.m_BorderWidth, Color.Red, this.BorderStyle == BorderStyle.FixedSingle ? (object) this.FixedSingleLineColor : (object) null);
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.SuspendLayout();
      this.ResumeLayout(false);
    }
  }
}
