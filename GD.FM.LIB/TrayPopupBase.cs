using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace GD.FM.LIB
{
  [ToolboxBitmap(typeof (NotifyIcon))]
  public class TrayPopupBase : Component
  {
    private int fWidth = 100;
    private int fHeight = 100;
    private Font ffont = new Font(FontFamily.GenericSansSerif, 8.25f);
    private Color fcolor = Color.White;
    private Color fTopColor = Color.Blue;
    private Color fBottomColor = Color.Red;
    private Icon ficon = SystemIcons.Information;
    private int fopacity = 100;
    private int fTimeToLive = 5;
    private Container components;
    private MessageForm dlg;

    [Category("Appearance")]
    [Description("Window Width.")]
    [DefaultValue(100)]
    public int Width
    {
      get
      {
        return this.fWidth;
      }
      set
      {
        this.fWidth = value;
      }
    }

    [Category("Appearance")]
    [DefaultValue(100)]
    [Description("Window Height.")]
    public int Height
    {
      get
      {
        return this.fHeight;
      }
      set
      {
        this.fHeight = value;
      }
    }

    [Description("Text Font.")]
    [Category("Appearance")]
    public Font font
    {
      get
      {
        return this.ffont;
      }
      set
      {
        this.ffont = value;
      }
    }

    [Description("Text Color.")]
    [Category("Appearance")]
    public Color color
    {
      get
      {
        return this.fcolor;
      }
      set
      {
        this.fcolor = value;
      }
    }

    [Category("Appearance")]
    [Description("Top gradient Color.")]
    public Color TopColor
    {
      get
      {
        return this.fTopColor;
      }
      set
      {
        this.fTopColor = value;
      }
    }

    [Category("Appearance")]
    [Description("Bottom gradient Color.")]
    public Color BottomColor
    {
      get
      {
        return this.fBottomColor;
      }
      set
      {
        this.fBottomColor = value;
      }
    }

    [Description("Icon for message.")]
    [Category("Appearance")]
    public Icon icon
    {
      get
      {
        return this.ficon;
      }
      set
      {
        this.ficon = value;
      }
    }

    [Description("Window Opacity.")]
    [Category("Appearance")]
    public int opacity
    {
      get
      {
        return this.fopacity;
      }
      set
      {
        if (value > 100 || value < 0)
          this.fopacity = 100;
        else
          this.fopacity = value;
      }
    }

    [Description("Time To Live, seconds.")]
    [Category("Appearance")]
    [DefaultValue(5)]
    public int TimeToLive
    {
      get
      {
        return this.fTimeToLive;
      }
      set
      {
        this.fTimeToLive = value;
      }
    }

    public event EventHandler Click;

    public TrayPopupBase(IContainer container)
    {
      container.Add((IComponent) this);
      this.InitializeComponent();
    }

    public TrayPopupBase()
    {
      this.InitializeComponent();
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.components = new Container();
    }

    public void ShowWindow(string messageToShow, string messageTitle)
    {
      this.dlg = new MessageForm();
      this.dlg.ParentControl = this;
      this.dlg.icon = this.icon;
      this.dlg.text = messageToShow;
      this.dlg.title = messageTitle;
      this.dlg.font = this.font;
      this.dlg.color = this.color;
      this.dlg.Width = this.Width;
      this.dlg.Height = this.Height;
      this.dlg.timer1.Interval = this.TimeToLive * 1000;
      this.dlg.SetDesktopLocation(Screen.PrimaryScreen.WorkingArea.Width - this.dlg.Width, Screen.PrimaryScreen.WorkingArea.Height - this.dlg.Height);
      this.dlg.Opacity = (double) this.opacity / 100.0;
      ((Control) this.dlg).Show();
      this.dlg.Visible = true;
    }

    internal virtual void OnClick(object sender, EventArgs e)
    {
      if (this.Click == null)
        return;
      this.Click((object) this, e);
    }

    public void Hide()
    {
      this.dlg.Visible = false;
    }
  }
}
