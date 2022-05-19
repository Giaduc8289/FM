using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GD.FM.CONTROL.DATETIMEPICKER
{
    public partial class DATETIMEPICKER : DateTimePicker
    {
        public DATETIMEPICKER()
        {
            InitializeComponent();
            this.CustomFormat = "dd/MM/yyyy";
            this.Format = DateTimePickerFormat.Custom;
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (msg.Msg == 256 && keyData == System.Windows.Forms.Keys.Enter)
            {
                // Execute an alternative action: here we tabulate in order to focus on the next control in the formular
                System.Windows.Forms.SendKeys.Send("\t");
                // return true to stop any further interpretation of this key action
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
       // protected override 
    }
}
