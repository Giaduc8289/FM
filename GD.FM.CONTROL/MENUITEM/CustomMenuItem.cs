using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace GD.FM.CONTROL.MENUITEM
{
    public partial class CustomMenuItem : ToolStripMenuItem
    {
        public CustomMenuItem()
            :base()
        {
            //InitializeComponent();
        }

        public CustomMenuItem(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        public CustomMenuItem(string _string, Image _Image, EventHandler _EventHandler)
            :base(_string, _Image, _EventHandler)
        {
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Rectangle r = this.Bounds;
            g.FillRectangle(Brushes.Blue, r);
            g.DrawString(this.Text, this.Font, Brushes.Red, r);
        }

        public virtual string Name { get; set; }

        public virtual bool Enabled { get; set; }

        public virtual string Tag { get; set; }

        public virtual Image Image { get; set; }

        //public virtual Image Items { get; }

        ////
        //// Summary:
        ////     Gets the border color to use with a System.Windows.Forms.ToolStripMenuItem.
        ////
        //// Returns:
        ////     A System.Drawing.Color that is the border color to use with a System.Windows.Forms.ToolStripMenuItem.
        //public virtual Color MenuItemBorder { get; }
        ////
        //// Summary:
        ////     Gets the starting color of the gradient used when a top-level System.Windows.Forms.ToolStripMenuItem
        ////     is pressed.
        ////
        //// Returns:
        ////     A System.Drawing.Color that is the starting color of the gradient used when
        ////     a top-level System.Windows.Forms.ToolStripMenuItem is pressed.
        //public virtual Color MenuItemPressedGradientBegin { get; }
        ////
        //// Summary:
        ////     Gets the end color of the gradient used when a top-level System.Windows.Forms.ToolStripMenuItem
        ////     is pressed.
        ////
        //// Returns:
        ////     A System.Drawing.Color that is the end color of the gradient used when a
        ////     top-level System.Windows.Forms.ToolStripMenuItem is pressed.
        //public virtual Color MenuItemPressedGradientEnd { get; }
        ////
        //// Summary:
        ////     Gets the middle color of the gradient used when a top-level System.Windows.Forms.ToolStripMenuItem
        ////     is pressed.
        ////
        //// Returns:
        ////     A System.Drawing.Color that is the middle color of the gradient used when
        ////     a top-level System.Windows.Forms.ToolStripMenuItem is pressed.
        //public virtual Color MenuItemPressedGradientMiddle { get; }
        ////
        //// Summary:
        ////     Gets the solid color to use when a System.Windows.Forms.ToolStripMenuItem
        ////     other than the top-level System.Windows.Forms.ToolStripMenuItem is selected.
        ////
        //// Returns:
        ////     A System.Drawing.Color that is the solid color to use when a System.Windows.Forms.ToolStripMenuItem
        ////     other than the top-level System.Windows.Forms.ToolStripMenuItem is selected.
        //public virtual Color MenuItemSelected { get; }
        ////
        //// Summary:
        ////     Gets the starting color of the gradient used when the System.Windows.Forms.ToolStripMenuItem
        ////     is selected.
        ////
        //// Returns:
        ////     A System.Drawing.Color that is the starting color of the gradient used when
        ////     the System.Windows.Forms.ToolStripMenuItem is selected.
        //public virtual Color MenuItemSelectedGradientBegin { get; }
        ////
        //// Summary:
        ////     Gets the end color of the gradient used when the System.Windows.Forms.ToolStripMenuItem
        ////     is selected.
        ////
        //// Returns:
        ////     A System.Drawing.Color that is the end color of the gradient used when the
        ////     System.Windows.Forms.ToolStripMenuItem is selected.
        //public virtual Color MenuItemSelectedGradientEnd { get; }


        //class CustomProfessionalColors : ProfessionalColorTable
        //{
        //    public override Color MenuItemSelectedGradientBegin
        //    { get { return Color.White; } }
        //    public override Color MenuItemSelectedGradientEnd
        //    { get { return Color.Yellow; } }
        //}

    }
}
