using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.ComponentModel;
using System.IO;
using System.Drawing;
using System.Xml;
using System.Diagnostics;
namespace GD.FM.CONTROL
{
    public class FORM : System.Windows.Forms.Form
    {
        public FORM()
		{

        }
        private void InitializeComponent()
        {
            
            this.SuspendLayout();
            // 
            // Form
            //             
            this.ClientSize = new System.Drawing.Size(294, 276);
            this.Name = "Form";
            this.ResumeLayout(false);
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                this.Close();                
            }
            if (keyData == Keys.F1)
            {
                SendKeys.Send("%{t}");
            }
            if (keyData == Keys.F2)
            {
                SendKeys.Send("%{s}");
            }
            if (keyData == Keys.F3)
            {
                SendKeys.Send("%{x}");
            }
            if (keyData == Keys.F4)
            {
                SendKeys.Send("%{k}");
            }
            if (keyData == Keys.F5)
            {
                SendKeys.Send("%{l}");
            }
            if (keyData == Keys.F6)
            {
                SendKeys.Send("%{u}");
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
