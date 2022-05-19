using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Windows.Forms;

namespace ExtensiveCombo
{
    [Serializable]
    public partial class GridView4Combo : DataGridView, IEXTCombo
    {
        public GridView4Combo()
        {
            InitializeComponent();
        }

        public GridView4Combo(IContainer container)
        {
            container.Add(this);
            InitializeComponent();
        }

        private CloseComboHandler CloseEXTCombo;
        protected override void OnDoubleClick(EventArgs e)
        {
            CloseEXTCombo();
            base.OnDoubleClick(e);
        }

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
                if (this.CurrentRow == null)
                    return string.Empty;
                else
                    return this.CurrentRow.Cells[0].Value.ToString() + " | " + this.CurrentRow.Cells[1].Value.ToString();
            }
        }

    }
}
