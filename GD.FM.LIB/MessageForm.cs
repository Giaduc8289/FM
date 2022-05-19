// Decompiled with JetBrains decompiler
// Type: TBNet.TrayPopup.MessageForm
// Assembly: TBNet.TrayPopup, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 81C79E04-460C-4603-B2F9-D14305D3A26E
// Assembly location: D:\temp\KTX\GD.FM\DLL\TBNet.TrayPopup.dll

using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace GD.FM.LIB
{
  public class MessageForm : Form
  {
    public Icon icon = SystemIcons.Information;
    private IContainer components;
    public string text;
    public Font font;
    public Color color;
    public string title;
    public Timer timer1;
    public TrayPopupBase ParentControl;

    public MessageForm()
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
      this.components = (IContainer) new Container();
      this.timer1 = new Timer(this.components);
      this.timer1.Enabled = true;
      this.timer1.Tick += new EventHandler(this.timer1_Tick);
      this.AutoScaleBaseSize = new Size(5, 13);
      this.ClientSize = new Size(292, 273);
      this.ControlBox = false;
      this.FormBorderStyle = FormBorderStyle.None;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "messageForm";
      this.ShowInTaskbar = false;
      this.SizeGripStyle = SizeGripStyle.Hide;
      this.StartPosition = FormStartPosition.Manual;
      this.Text = "messageForm";
      this.TopMost = true;
      this.Click += new EventHandler(this.messageForm_Click);
      this.Paint += new PaintEventHandler(this.messageForm_Paint);
    }

    private void messageForm_Paint(object sender, PaintEventArgs e)
    {
      int x = 5;
      int num = 10;
      LinearGradientBrush linearGradientBrush1 = new LinearGradientBrush(new Rectangle(0, 0, this.Width, this.Height), this.ParentControl.TopColor, this.ParentControl.BottomColor, LinearGradientMode.ForwardDiagonal);
      LinearGradientBrush linearGradientBrush2 = new LinearGradientBrush(new Rectangle(0, 0, this.Width, this.Height), this.ParentControl.TopColor, this.ParentControl.BottomColor, LinearGradientMode.BackwardDiagonal);
      Graphics graphics = Graphics.FromHwnd(this.Handle);
      graphics.FillRectangle((Brush) linearGradientBrush1, 0, 0, this.Width, this.Height);
      SizeF sizeF = graphics.MeasureString(this.title, this.font);
      graphics.DrawIcon(this.icon, x, (int) sizeF.Height + this.Height / 2 - this.icon.Height);
      graphics.FillRectangle((Brush) linearGradientBrush2, 2f, 2f, (float) (this.Width - 2), sizeF.Height);
      Font font = new Font(this.font, FontStyle.Bold);
      graphics.DrawString(this.title, font, (Brush) new SolidBrush(this.color), (float) x, 2f, StringFormat.GenericDefault);
      graphics.DrawString(this.text, this.font, (Brush) new SolidBrush(this.color), new RectangleF((float) (this.icon.Width + x * 2), sizeF.Height + (float) num, (float) (this.Width - (this.icon.Width + x * 2)), (float) this.Height - (sizeF.Height + (float) num)), StringFormat.GenericDefault);
    }

    private void timer1_Tick(object sender, EventArgs e)
    {
      this.Close();
    }

    private void messageForm_Click(object sender, EventArgs e)
    {
      this.ParentControl.OnClick(sender, e);
    }
  }
}
