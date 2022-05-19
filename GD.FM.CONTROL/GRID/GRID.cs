using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GD.FM.CONTROL
{
    public partial class GRID : DataGridView
    {
        public GRID()
        {
            InitializeComponent();
        }
        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            base.OnKeyPress(e);
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter)
            {
                if (this.CurrentCell == this.CurrentRow.Cells[this.Columns.Count - 1])
                {
                    BindingSource bs = (BindingSource)this.DataSource;
                    DataTable dt = (DataTable)bs.DataSource;
                    DataRow _row = dt.NewRow();
                    dt.Rows.Add(_row);
                    bs.Position = dt.Rows.Count;
                    this.CurrentRow.Cells[0].Selected = true;
                }
                else
                {
                    SendKeys.Send("{TAB}");
                }
            }
            if (keyData == Keys.F8)
            {
                BindingSource bs = (BindingSource)this.DataSource;
                DataTable dt = (DataTable)bs.DataSource;
                DataRow _row = dt.NewRow();
                dt.Rows.Add(_row);
                bs.Position = dt.Rows.Count;
                this.CurrentRow.Cells[0].Selected = true;
            }
            if (keyData == Keys.F7)
            {
                BindingSource bs = (BindingSource)this.DataSource;
                DataTable dt = (DataTable)bs.DataSource;
                dt.Rows.RemoveAt(bs.Position);
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
