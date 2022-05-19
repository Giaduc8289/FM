using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace ExtensiveCombo
{
    public partial class WeekDays4Combo : UserControl, IEXTCombo
    {
        public WeekDays4Combo()
        {
            InitializeComponent();
        }

        private CloseComboHandler CloseEXTCombo;

        #region IEXTCombo Members

        public void SetUserInterface()
        {
            this.BorderStyle = BorderStyle.None;
            this.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
        }

        public CloseComboHandler CloseComboDelegate
        {
            get { return CloseEXTCombo; }
            set { CloseEXTCombo = value; }
        }

        public string DisplayText
        {
            get
            {
                string sRetVal = string.Empty;
                if (chkMonday.Checked == true)
                    sRetVal = sRetVal + "MO" + "-";
                if (chkTuesday.Checked == true)
                    sRetVal = sRetVal + "TU" + "-";
                if (chkWednesday.Checked == true)
                    sRetVal = sRetVal + "WE" + "-";
                if (chkThursday.Checked == true)
                    sRetVal = sRetVal + "TH" + "-";
                if (chkFriday.Checked == true)
                    sRetVal = sRetVal + "FR" + "-";
                if (chkSaturday.Checked == true)
                    sRetVal = sRetVal + "SA" + "-";
                if (chkSunday.Checked == true)
                    sRetVal = sRetVal + "SU" + "-";

                if (sRetVal.Length > 1)
                    sRetVal = sRetVal.Substring(0, sRetVal.Length - 1);

                return sRetVal;
            }
        }
        #endregion

        private void cmdClose_Click(object sender, EventArgs e)
        {
            CloseEXTCombo();
        }
    }
}
