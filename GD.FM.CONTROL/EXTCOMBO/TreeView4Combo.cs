using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Windows.Forms;

namespace ExtensiveCombo
{
    [Serializable]
    public partial class TreeView4Combo : TreeView , IEXTCombo
    {
        public TreeView4Combo()
        {
            InitializeComponent();
        }

        private CloseComboHandler CloseEXTCombo;

        protected override void OnDoubleClick(EventArgs e)
        {
            CloseEXTCombo();
            base.OnDoubleClick(e);
        }

        #region IEXTCombo Members

        public void SetUserInterface()
        {
            this.BorderStyle = BorderStyle.None;
            this.HideSelection = false;
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
                if (this.SelectedNode == null)
                    return string.Empty;
                else
                    return this.SelectedNode.Text; 
            }
        }

        #endregion
    }
}
