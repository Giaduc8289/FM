using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GD.FM.LIB
{
    public partial class ListviewJanusC : GD.FM.CONTROL.FORM 
    {
        private GD.FM.CONTROL.JGridEX GRID_LIST = new GD.FM.CONTROL.JGridEX();
        private DataTable dtSource, dttheme = new DataTable(), dtColumns=new DataTable();
        private BindingSource BindingListView=new BindingSource();
        public DataRowView[] _RowsViewSelect;
        private string _Fieldname_Search = "";

        public ListviewJanusC(string filenamexml, DataTable _dtSource, string Fieldname_Search_MA, string Paramsearch)
        {
            InitializeComponent();
            DataSet ds = IO.ReadXML2(filenamexml);
            DataTable dttemplate = ds.Tables["tablename"];
            this.Text = dttemplate.Rows[0]["headerText"].ToString();
            this.dtSource = _dtSource.Copy();
            DataView Source_View = new DataView(dtSource);
            Source_View.Sort = Fieldname_Search_MA + " ASC";
            BindingListView.DataSource = Source_View;
            GRID_LIST.DataSource = BindingListView;
            dtColumns.Columns.Add("ID", typeof(string));
            dtColumns.Columns.Add("NAME", typeof(string));
            dttheme = CustomViewGrid.BuildviewgridJanus_C(filenamexml, GRID_LIST, panel1);
            for (int i = 0; i < dttheme.Rows.Count; i++)
            {
                DataRow r_1 = dtColumns.NewRow();
                r_1["ID"] = dttheme.Rows[i]["name"].ToString();
                r_1["NAME"] = dttheme.Rows[i]["headerText"].ToString();
                dtColumns.Rows.Add(r_1);
            }
            //GRID_LIST.RootTable.Columns[dttheme.Rows.Count - 1].AutoSizeMode = Janus.Windows.GridEX.ColumnAutoSizeMode.Default;// = DataGridViewAutoSizeColumnMode.Fill;
            GRID_LIST.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            GRID_LIST.GroupByBoxVisible = false;
            GRID_LIST.CellEdited += GRID_LIST_CellEdited;
            txtKeySearch.Text = Paramsearch; 
            txtKeySearch_TextChanged((new object()), (new EventArgs()));
            _Fieldname_Search = Fieldname_Search_MA;
        }

        public ListviewJanusC(string caption, string filenamexml, DataTable _dtSource, string Fieldname_Search_MA, string Paramsearch)
        {
            InitializeComponent();
            this.Text = caption;
            this.dtSource = _dtSource.Copy();
            DataView Source_View = new DataView(dtSource);
            Source_View.Sort = Fieldname_Search_MA + " ASC";
            BindingListView.DataSource = Source_View;
            GRID_LIST.DataSource = BindingListView;
            dtColumns.Columns.Add("ID", typeof(string));
            dtColumns.Columns.Add("NAME", typeof(string));
            dttheme = CustomViewGrid.BuildviewgridJanus_C(filenamexml, GRID_LIST, panel1);
            for (int i = 0; i < dttheme.Rows.Count; i++)
            {
                DataRow r_1 = dtColumns.NewRow();
                r_1["ID"] = dttheme.Rows[i]["name"].ToString();
                r_1["NAME"] = dttheme.Rows[i]["headerText"].ToString();
                dtColumns.Rows.Add(r_1);
            }
            //GRID_LIST.RootTable.Columns[dttheme.Rows.Count - 1].AutoSizeMode = Janus.Windows.GridEX.ColumnAutoSizeMode.Default;// = DataGridViewAutoSizeColumnMode.Fill;
            GRID_LIST.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            GRID_LIST.GroupByBoxVisible = false;
            txtKeySearch.Text = Paramsearch;
            txtKeySearch_TextChanged((new object()), (new EventArgs()));
        }

        private void btnchon_Click(object sender, EventArgs e)
        {
            Janus.Windows.GridEX.GridEXRow[] grArr = GRID_LIST.GetCheckedRows();
            _RowsViewSelect = new DataRowView[grArr.Length];
            int i = 0;
            foreach (Janus.Windows.GridEX.GridEXRow grdr in grArr)
                _RowsViewSelect[i++] = (DataRowView)grdr.DataRow;

            this.Hide();
        }

        private void Listview_Load(object sender, EventArgs e)
        {
            txtKeySearch.Focus();
            //--------Check các row đã lựa chọn
            string _Paramsearch = txtKeySearch.Text;
            Janus.Windows.GridEX.GridEXRow[] listGrid = GRID_LIST.GetDataRows();
            foreach (Janus.Windows.GridEX.GridEXRow _grid in listGrid)
            {
                DataRowView _view = (DataRowView)_grid.DataRow;
                if (_view == null) continue;
                string gtri = _view[_Fieldname_Search].ToString() + ",";
                if (_Paramsearch.Contains(gtri))
                    _grid.CheckState = Janus.Windows.GridEX.RowCheckState.Checked;
            }
        }
        private void txtKeySearch_Validating(object sender, CancelEventArgs e)
        {
            GRID_LIST.Focus();
        }
        private void txtKeySearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string strTimKiem = txtKeySearch.Text;
                string strFilter = "";
                foreach (DataRow dr in dtColumns.Rows)
                {
                    if (dr[0].ToString() == "C") continue;
                    if (dtSource.Columns[dr[0].ToString()].DataType.ToString() == "System.String")
                    {
                        strFilter += " Or " + dr[0].ToString() + " Like '%" + strTimKiem + "%' ";
                    }
                    else if (dtSource.Columns[dr[0].ToString()].DataType.ToString() == "System.Int32")
                    {
                        try
                        {
                            Convert.ToInt32(strTimKiem);
                            strFilter += " Or " + dr[0].ToString() + " = " + strTimKiem + " ";
                        }
                        catch { }
                    }
                }
                strFilter = strFilter.Substring(4);
                BindingListView.Filter = strFilter;

                if (BindingListView.Count == 0 && dtSource.Rows.Count > 0)
                    BindingListView.Filter = "";
            }
            catch { }
        }

        private void GRID_LIST_CellEdited(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {
            if (e.Column.Key == "Chon")
            {
                GRID_LIST.CurrentRow.Cells["T"].Value = DateTimeOffset.Now.ToString("MM/dd/yyyy hh:mm:ss.fff");
            }
        }

    }
}
