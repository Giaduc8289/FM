using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Runtime.InteropServices;


namespace GD.FM.CONTROL
{
    public partial class MonCalendar : MonthCalendar
    {
        public MonCalendar()
        {
            InitializeComponent();
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (msg.Msg == 256 && keyData == System.Windows.Forms.Keys.Escape)
            {
                this.Hide();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
