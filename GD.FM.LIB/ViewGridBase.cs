using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace GD.FM.LIB
{
  public class ViewGridBase
  {
    public static DataTable BuildViewGridAndCheckBox(int Status, DataRow[] dtsource, string xmlfile, DataGridView _DataGridView, Panel _Panel)
    {
      _DataGridView.Columns.Clear();
      DataTable dataTable = IO.ReadXMLTOW(xmlfile);
      DataGridViewCheckBoxColumn viewCheckBoxColumn = new DataGridViewCheckBoxColumn();
      viewCheckBoxColumn.Name = "Chọn";
      viewCheckBoxColumn.Width = 40;
      _DataGridView.Columns.Add((DataGridViewColumn) viewCheckBoxColumn);
      for (int index = 0; index < dataTable.Rows.Count; ++index)
      {
        DataGridViewTextBoxColumn viewTextBoxColumn = new DataGridViewTextBoxColumn();
        viewTextBoxColumn.Name = dataTable.Rows[index]["name"].ToString();
        viewTextBoxColumn.DataPropertyName = dataTable.Rows[index]["name"].ToString();
        viewTextBoxColumn.HeaderText = dataTable.Rows[index]["headerText"].ToString();
        if (dataTable.Rows[index]["value"].ToString().Trim().Equals("0") || dataTable.Rows[index]["value"].ToString().Trim().Equals("2"))
          viewTextBoxColumn.Visible = false;
        viewTextBoxColumn.Width = int.Parse(dataTable.Rows[index]["Width"].ToString());
        _DataGridView.Columns.Add((DataGridViewColumn) viewTextBoxColumn);
        _DataGridView.AutoSize = true;
        _DataGridView.Dock = DockStyle.Fill;
        _DataGridView.AllowUserToAddRows = false;
        _DataGridView.ReadOnly = true;
        _DataGridView.Location = new Point(22, 42);
        _DataGridView.Size = new Size(905, 368);
        _DataGridView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
      }
      _DataGridView.RowCount = dtsource.Length;
      for (int index1 = 0; index1 < dtsource.Length; ++index1)
      {
        for (int index2 = 0; index2 < dataTable.Rows.Count; ++index2)
        {
          if (Status == 1)
            _DataGridView.Rows[index1].Cells["Chọn"].Value = (object) true;
          if (Status == 2)
            _DataGridView.Rows[index1].Cells["Chọn"].Value = (object) false;
          string index3 = dataTable.Rows[index2]["name"].ToString();
          _DataGridView.Rows[index1].Cells[index3].Value = dtsource[index1][index3];
        }
      }
      _Panel.AutoScroll = true;
      _Panel.Controls.Add((Control) _DataGridView);
      return dataTable;
    }

    public static DataTable BuildViewGridAndCheckBox(int Status, DataTable dtsource, string xmlfile, DataGridView _DataGridView, Panel _Panel)
    {
      _DataGridView.Columns.Clear();
      DataTable dataTable = IO.ReadXMLTOW(xmlfile);
      DataGridViewCheckBoxColumn viewCheckBoxColumn = new DataGridViewCheckBoxColumn();
      viewCheckBoxColumn.Name = "Chọn";
      viewCheckBoxColumn.Width = 40;
      _DataGridView.Columns.Add((DataGridViewColumn) viewCheckBoxColumn);
      for (int index = 0; index < dataTable.Rows.Count; ++index)
      {
        DataGridViewTextBoxColumn viewTextBoxColumn = new DataGridViewTextBoxColumn();
        viewTextBoxColumn.Name = dataTable.Rows[index]["name"].ToString();
        viewTextBoxColumn.DataPropertyName = dataTable.Rows[index]["name"].ToString();
        viewTextBoxColumn.HeaderText = dataTable.Rows[index]["headerText"].ToString();
        if (dataTable.Rows[index]["value"].ToString().Trim().Equals("0") || dataTable.Rows[index]["value"].ToString().Trim().Equals("2"))
          viewTextBoxColumn.Visible = false;
        viewTextBoxColumn.Width = int.Parse(dataTable.Rows[index]["Width"].ToString());
        _DataGridView.Columns.Add((DataGridViewColumn) viewTextBoxColumn);
        _DataGridView.AutoSize = true;
        _DataGridView.Dock = DockStyle.Fill;
        _DataGridView.AllowUserToAddRows = false;
        _DataGridView.ReadOnly = true;
        _DataGridView.Location = new Point(22, 42);
        _DataGridView.Size = new Size(905, 368);
        _DataGridView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
      }
      _DataGridView.RowCount = dtsource.Rows.Count;
      for (int index1 = 0; index1 < dtsource.Rows.Count; ++index1)
      {
        for (int index2 = 0; index2 < dataTable.Rows.Count; ++index2)
        {
          if (Status == 1)
            _DataGridView.Rows[index1].Cells["Chọn"].Value = (object) true;
          if (Status == 2)
            _DataGridView.Rows[index1].Cells["Chọn"].Value = (object) false;
          string index3 = dataTable.Rows[index2]["name"].ToString();
          _DataGridView.Rows[index1].Cells[index3].Value = dtsource.Rows[index1][index3];
        }
      }
      _Panel.AutoScroll = true;
      _Panel.Controls.Add((Control) _DataGridView);
      return dataTable;
    }

    public static DataTable Buildviewgrid(string xmlfile, DataGridView _DataGridView, Panel _Panel)
    {
      _DataGridView.Columns.Clear();
      DataTable dataTable = IO.ReadXMLTOW(xmlfile);
      dataTable.Clone();
      try
      {
        dataTable = DataTableExtensions.CopyToDataTable<DataRow>((IEnumerable<DataRow>) dataTable.Select("value='1'"));
      }
      catch
      {
      }
      for (int index = 0; index < dataTable.Rows.Count; ++index)
      {
        DataGridViewTextBoxColumn viewTextBoxColumn = new DataGridViewTextBoxColumn();
        viewTextBoxColumn.Name = dataTable.Rows[index]["name"].ToString();
        viewTextBoxColumn.HeaderText = dataTable.Rows[index]["headerText"].ToString();
        viewTextBoxColumn.DataPropertyName = dataTable.Rows[index]["name"].ToString();
        if (dataTable.Rows[index]["value"].ToString().Trim().Equals("0") || dataTable.Rows[index]["value"].ToString().Trim().Equals("2"))
          viewTextBoxColumn.Visible = false;
        viewTextBoxColumn.Width = int.Parse(dataTable.Rows[index]["Width"].ToString());
        _DataGridView.Columns.Add((DataGridViewColumn) viewTextBoxColumn);
        _DataGridView.AutoSize = true;
        _DataGridView.Dock = DockStyle.Fill;
        _DataGridView.AllowUserToAddRows = false;
        _DataGridView.ReadOnly = true;
        _DataGridView.Location = new Point(22, 42);
        _DataGridView.Size = new Size(905, 368);
        _DataGridView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
      }
      string str = string.Empty;
      for (int index1 = 0; index1 < _DataGridView.Columns.Count; ++index1)
      {
        for (int index2 = 0; index2 < dataTable.Rows.Count; ++index2)
        {
          if (_DataGridView.Columns[index1].Name == dataTable.Rows[index2]["name"].ToString())
          {
            try
            {
              _DataGridView.Columns[index1].DisplayIndex = int.Parse(dataTable.Rows[index2]["Thutu"].ToString());
              break;
            }
            catch
            {
            }
          }
        }
      }
      _DataGridView.Refresh();
      _Panel.AutoScroll = true;
      _Panel.Controls.Add((Control) _DataGridView);
      return dataTable;
    }

    public static DataTable Buildviewgrid(string xmlfile, DataGridView _DataGridView, TabPage _TabPage)
    {
      _DataGridView.Columns.Clear();
      DataTable dataTable = IO.ReadXMLTOW(xmlfile);
      try
      {
        dataTable = DataTableExtensions.CopyToDataTable<DataRow>((IEnumerable<DataRow>) dataTable.Select("1=1", "Thutu ASC"));
      }
      catch
      {
      }
      for (int index = 0; index < dataTable.Rows.Count; ++index)
      {
        DataGridViewTextBoxColumn viewTextBoxColumn = new DataGridViewTextBoxColumn();
        viewTextBoxColumn.Name = dataTable.Rows[index]["name"].ToString();
        viewTextBoxColumn.DataPropertyName = dataTable.Rows[index]["name"].ToString();
        viewTextBoxColumn.HeaderText = dataTable.Rows[index]["headerText"].ToString();
        if (dataTable.Rows[index]["value"].ToString().Trim().Equals("0") || dataTable.Rows[index]["value"].ToString().Trim().Equals("2"))
          viewTextBoxColumn.Visible = false;
        viewTextBoxColumn.Width = int.Parse(dataTable.Rows[index]["Width"].ToString());
        _DataGridView.Columns.Add((DataGridViewColumn) viewTextBoxColumn);
        _DataGridView.AutoSize = true;
        _DataGridView.Dock = DockStyle.Fill;
        _DataGridView.AllowUserToAddRows = false;
        _DataGridView.ReadOnly = true;
        _DataGridView.Location = new Point(22, 42);
        _DataGridView.Size = new Size(905, 368);
        _DataGridView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
      }
      _DataGridView.Height = _TabPage.Height;
      _DataGridView.Width = _TabPage.Width;
      _TabPage.AutoScroll = true;
      _TabPage.Controls.Add((Control) _DataGridView);
      return dataTable;
    }

    public static DataTable BuildViewGridAndCheckBox(DataTable dtsource, DataTable dtchecktrue, string Makeychon, string xmlfile, DataGridView _DataGridView, Panel _Panel)
    {
      _DataGridView.Columns.Clear();
      DataTable dataTable = IO.ReadXMLTOW(xmlfile);
      try
      {
        dataTable = DataTableExtensions.CopyToDataTable<DataRow>((IEnumerable<DataRow>) dataTable.Select("1=1", "Thutu ASC"));
      }
      catch
      {
      }
      DataGridViewCheckBoxColumn viewCheckBoxColumn = new DataGridViewCheckBoxColumn();
      viewCheckBoxColumn.Name = "Chọn";
      viewCheckBoxColumn.Width = 40;
      _DataGridView.Columns.Add((DataGridViewColumn) viewCheckBoxColumn);
      for (int index = 0; index < dataTable.Rows.Count; ++index)
      {
        DataGridViewTextBoxColumn viewTextBoxColumn = new DataGridViewTextBoxColumn();
        viewTextBoxColumn.Name = dataTable.Rows[index]["name"].ToString();
        viewTextBoxColumn.DataPropertyName = dataTable.Rows[index]["name"].ToString();
        viewTextBoxColumn.HeaderText = dataTable.Rows[index]["headerText"].ToString();
        if (dataTable.Rows[index]["value"].ToString().Trim().Equals("0") || dataTable.Rows[index]["value"].ToString().Trim().Equals("2"))
          viewTextBoxColumn.Visible = false;
        viewTextBoxColumn.Width = int.Parse(dataTable.Rows[index]["Width"].ToString());
        _DataGridView.Columns.Add((DataGridViewColumn) viewTextBoxColumn);
        _DataGridView.AutoSize = true;
        _DataGridView.Dock = DockStyle.Fill;
        _DataGridView.AllowUserToAddRows = false;
        _DataGridView.ReadOnly = true;
        _DataGridView.Location = new Point(22, 42);
        _DataGridView.Size = new Size(905, 368);
        _DataGridView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
      }
      _DataGridView.RowCount = dtsource.Rows.Count;
      for (int index1 = 0; index1 < dtsource.Rows.Count; ++index1)
      {
        for (int index2 = 0; index2 < dataTable.Rows.Count; ++index2)
        {
          string index3 = dataTable.Rows[index2]["name"].ToString();
          _DataGridView.Rows[index1].Cells[index3].Value = dtsource.Rows[index1][index3];
        }
        if (Makeychon != string.Empty)
        {
          string str1 = dtsource.Rows[index1][Makeychon].ToString();
          for (int index2 = 0; index2 < dtchecktrue.Rows.Count; ++index2)
          {
            string str2 = dtchecktrue.Rows[index2][Makeychon].ToString();
            if (str1 == str2)
              _DataGridView.Rows[index1].Cells["Chọn"].Value = (object) true;
          }
        }
      }
      _Panel.AutoScroll = true;
      _Panel.Controls.Add((Control) _DataGridView);
      return dataTable;
    }

    public static DataTable Buildviewgrid_C(string xmlfile, DataGridView _DataGridView, Panel _Panel)
    {
      _DataGridView.Columns.Clear();
      DataTable dataTable = IO.ReadXMLTOW(xmlfile);
      dataTable.Clone();
      try
      {
        dataTable = DataTableExtensions.CopyToDataTable<DataRow>((IEnumerable<DataRow>) dataTable.Select("1=1", "Thutu ASC"));
      }
      catch
      {
      }
      DataGridViewCheckBoxColumn viewCheckBoxColumn = new DataGridViewCheckBoxColumn();
      viewCheckBoxColumn.Name = "C";
      viewCheckBoxColumn.HeaderText = "Chọn";
      viewCheckBoxColumn.Width = 40;
      _DataGridView.Columns.Add((DataGridViewColumn) viewCheckBoxColumn);
      for (int index = 0; index < dataTable.Rows.Count; ++index)
      {
        DataGridViewTextBoxColumn viewTextBoxColumn = new DataGridViewTextBoxColumn();
        viewTextBoxColumn.Name = dataTable.Rows[index]["name"].ToString();
        viewTextBoxColumn.HeaderText = dataTable.Rows[index]["headerText"].ToString();
        viewTextBoxColumn.DataPropertyName = dataTable.Rows[index]["name"].ToString();
        if (dataTable.Rows[index]["value"].ToString().Trim().Equals("0") || dataTable.Rows[index]["value"].ToString().Trim().Equals("2"))
          viewTextBoxColumn.Visible = false;
        viewTextBoxColumn.Width = int.Parse(dataTable.Rows[index]["Width"].ToString());
        _DataGridView.Columns.Add((DataGridViewColumn) viewTextBoxColumn);
        _DataGridView.AutoSize = true;
        _DataGridView.Dock = DockStyle.Fill;
        _DataGridView.AllowUserToAddRows = false;
        _DataGridView.ReadOnly = true;
        _DataGridView.Location = new Point(22, 42);
        _DataGridView.Size = new Size(905, 368);
        _DataGridView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
      }
      string str = string.Empty;
      for (int index1 = 0; index1 < _DataGridView.Columns.Count; ++index1)
      {
        for (int index2 = 0; index2 < dataTable.Rows.Count; ++index2)
        {
          if (_DataGridView.Columns[index1].Name == dataTable.Rows[index2]["name"].ToString())
          {
            try
            {
              _DataGridView.Columns[index1].DisplayIndex = int.Parse(dataTable.Rows[index2]["Thutu"].ToString());
              break;
            }
            catch
            {
            }
          }
        }
      }
      _DataGridView.Refresh();
      _Panel.AutoScroll = true;
      _Panel.Controls.Add((Control) _DataGridView);
      return dataTable;
    }

    public static void BinMultiCombo(MultiColumnComboBox combo, TextBox linktextbox, DataTable dt, string Columvalue, string Columkey)
    {
      DataTable dataTable = new DataTable("dtempcate");
      dataTable.Columns.Add("key", typeof (string));
      dataTable.Columns.Add("value", typeof (string));
      dataTable.Rows.Add((object[]) new string[2]
      {
        "0",
        "Lựa chọn"
      });
      for (int index = 0; index < dt.Rows.Count; ++index)
      {
        string str1 = dt.Rows[index][Columvalue].ToString();
        string str2 = dt.Rows[index][Columkey].ToString();
        dataTable.Rows.Add((object[]) new string[2]
        {
          str2,
          str1
        });
      }
      combo.DataSource = (object) dataTable;
      combo.DisplayMember = "key";
      combo.ValueMember = "key";
      combo.LinkedTextBox = linktextbox;
      combo.LinkedColumnIndex = 1;
      combo.ColumnWidths = "50,200";
      combo.SelectedIndex = 0;
      linktextbox.Text = dataTable.Rows[0]["value"].ToString();
    }

    public static void BinMultiCombo(MultiColumnComboBox combo, DataTable dt, string Columvalue, string Columkey)
    {
      DataTable dataTable = new DataTable("dtempcate");
      dataTable.Columns.Add("key", typeof (string));
      dataTable.Columns.Add("value", typeof (string));
      dataTable.Rows.Add((object[]) new string[2]
      {
        "0",
        "Lựa chọn"
      });
      for (int index = 0; index < dt.Rows.Count; ++index)
      {
        string str1 = dt.Rows[index][Columvalue].ToString();
        string str2 = dt.Rows[index][Columkey].ToString();
        dataTable.Rows.Add((object[]) new string[2]
        {
          str2,
          str1
        });
      }
      combo.DataSource = (object) dataTable;
      combo.DisplayMember = "key";
      combo.ValueMember = "key";
      combo.LinkedColumnIndex = 1;
      combo.ColumnWidths = "50,200";
      combo.SelectedIndex = 0;
    }

    public static void BinMultiCombo(MultiColumnComboBox combo, TextBox linktextbox, DataRow[] _DataRow, string Columvalue, string Columkey)
    {
      DataTable dataTable = new DataTable("dtempcate");
      dataTable.Columns.Add("key", typeof (string));
      dataTable.Columns.Add("value", typeof (string));
      dataTable.Rows.Add((object[]) new string[2]
      {
        "0",
        "Lựa chọn"
      });
      for (int index = 0; index < _DataRow.Length; ++index)
      {
        string str1 = _DataRow[index][Columvalue].ToString();
        string str2 = _DataRow[index][Columkey].ToString();
        dataTable.Rows.Add((object[]) new string[2]
        {
          str2,
          str1
        });
      }
      combo.DataSource = (object) dataTable;
      combo.DisplayMember = "key";
      combo.ValueMember = "key";
      combo.LinkedTextBox = linktextbox;
      combo.LinkedColumnIndex = 1;
      combo.ColumnWidths = "50,200";
      combo.SelectedIndex = 0;
      linktextbox.Text = dataTable.Rows[0]["value"].ToString();
    }
  }
}
