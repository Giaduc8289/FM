using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TBNET.ERP.LIB.DATA
{
    class GRID_COMBO_DATETIME
    {
        /*
         * Set cac thuoc tinh cho Grid
            gridEX1.Controls.Add(combo1);
            combo1.Location = new Point(3,4);
            combo1.Visible = true;
            gridEX1.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.True;
            gridEX1.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.False;
            gridEX1.EnterKeyBehavior = EnterKeyBehavior.NextCell;
         * Them su kien cho Grid khi su dung Combo_Grid method
         private void gridEX1_CurrentCellChanged(object sender, EventArgs e)
        {
            if (gridEX1.CurrentColumn == gridEX1.RootTable.Columns[1])
            {
                showCombobox(1);
                combo1.Focus();
            }
            else
            {
                combo1.Visible = false;
            }
        }        
         private void gridEX1_SizingColumn(object sender, SizingColumnEventArgs e)
         {
             combo1.Visible = false;                          
         }
         */
        //public static void Combo_Grid(int colPosition)
        //{
        //    if (gridEX1.Row >= 0)
        //    {
        //        gridEX1.RootTable.Columns[colPosition].EditType = EditType.NoEdit;
        //        gridEX1.Controls.Add(combo1);
        //        rect = gridEX1.GetCellBounds(gridEX1.Row, colPosition);
        //        combo1.Size = new Size(gridEX1.RootTable.Columns[colPosition].Width, 21);
        //        combo1.Location = new Point(rect.X + gridEX1.Location.X, rect.Y + gridEX1.Location.Y);
        //        txt.Visible = false;
        //        combo1.Visible = true;
        //        combo1.Enabled = true;
        //        TBNET.ERP.LIB.COMBO_COMM.SOURCE(combo1, txt, DT_NEW, DmbophandvFields.Tenbophan.Name, DmbophandvFields.Mabophan.Name);
        //    }
        //}
        //public static void Combo_Grid(string colName)
        //{
        //    if (gridEX1.Row >= 0)
        //    {
        //        gridEX1.RootTable.Columns[colName].EditType = EditType.NoEdit;
        //        gridEX1.Controls.Add(combo1);
        //        rect = gridEX1.GetCellBounds(gridEX1.Row, gridEX1.RootTable.Columns[colName].Position);
        //        combo1.Size = new Size(gridEX1.RootTable.Columns[colName].Width, 21);
        //        combo1.Location = new Point(rect.X + gridEX1.Location.X, rect.Y + gridEX1.Location.Y);
        //        txt.Visible = false;
        //        combo1.Visible = true;
        //        combo1.Enabled = true;
        //        TBNET.ERP.LIB.COMBO_COMM.SOURCE(combo1, txt, DT_NEW, DmbophandvFields.Tenbophan.Name, DmbophandvFields.Mabophan.Name);
        //    }
        //}
    }
}
