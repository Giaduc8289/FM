using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GD.FM.LIB
{
    public class COMBO_COMM
    {
        public static void SOURCE(GD.FM.CONTROL.COMBO combo, GD.FM.CONTROL.TEXTBOX linktextbox, DataTable dt, string Columvalue, string Columkey)
        {
            if (dt != null)
            {
                DataView dtview = dt.DefaultView;
                dtview.Sort = Columkey + " ASC";
                dt = dtview.ToTable();
                DataTable dtempcate = new DataTable("dtempcate");
                dtempcate.Columns.Add("key", typeof(String));
                dtempcate.Columns.Add("value", typeof(String));
                dtempcate.Rows.Add(new String[] { ""/*GD.FM.DATA.DMDONVI.MADONVI_TH*/, "Lựa chọn" });
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    string value = dt.Rows[i][Columvalue].ToString().Trim();
                    string key = dt.Rows[i][Columkey].ToString().Trim();
                    dtempcate.Rows.Add(new String[] { key, value });
                }
                combo.DataSource = dtempcate;
                combo.DisplayMember = "key";
                combo.ValueMember = "key";
                combo.LinkedTextBox = linktextbox;
                combo.LinkedColumnIndex = 1;
                combo.ColumnWidths = "100,200";
                combo.SelectedIndex = 0; linktextbox.Text = dtempcate.Rows[0]["value"].ToString();
            }
        }

        public static void SOURCE(bool sudungRow0, GD.FM.CONTROL.COMBO combo, GD.FM.CONTROL.TEXTBOX linktextbox, DataTable dt, string Columvalue, string Columkey)
        {
            if (dt == null || dt.Rows.Count == 0)
            {
                DataTable dtempcate = new DataTable("dtempcate");
                dtempcate.Columns.Add("key", typeof(String));
                dtempcate.Columns.Add("value", typeof(String));
                dtempcate.Rows.Add(new String[] { ""/*GD.FM.DATA.DMDONVI.MADONVI_TH*/, "Lựa chọn" });
                combo.DataSource = dtempcate;
                combo.DisplayMember = "key";
                combo.ValueMember = "key";
                combo.LinkedTextBox = linktextbox;
                combo.LinkedColumnIndex = 1;
                combo.ColumnWidths = "50,200";
                combo.SelectedIndex = 0; linktextbox.Text = dtempcate.Rows[0]["value"].ToString();
                return;
            }
            SOURCE(combo, linktextbox, dt, Columvalue, Columkey);
            if (!sudungRow0)
            {
                ((DataTable)combo.DataSource).Rows.RemoveAt(0);
            }
            //combo.SelectedIndex = 1;
        }

        public static void SOURCE(bool sudungRow0, bool Row0_isEmpty, GD.FM.CONTROL.COMBO combo, GD.FM.CONTROL.TEXTBOX linktextbox, DataTable dt, string Columvalue, string Columkey)
        {
            SOURCE(combo, linktextbox, dt, Columvalue, Columkey);
            if (sudungRow0)
            {
                if (Row0_isEmpty)
                {
                    if (combo.DataSource != null)
                    {
                        ((DataTable)combo.DataSource).Rows[0][0] = "";
                        ((DataTable)combo.DataSource).Rows[0][1] = "";
                    }
                }                
            }
            else
            {
                ((DataTable)combo.DataSource).Rows.RemoveAt(0);
            }
        }
    }
}
