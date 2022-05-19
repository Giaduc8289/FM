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
    public partial class ListviewJanus : GD.FM.CONTROL.FORM 
    {
        private GD.FM.CONTROL.JGridEX GRID_LIST = new GD.FM.CONTROL.JGridEX();
        private DataTable dtSource, dttheme = new DataTable(), dtColumns=new DataTable();
        private BindingSource BindingListView=new BindingSource();
        public DataRowView _RowViewSelect; 

        public ListviewJanus(string filenamexml, DataTable _dtSource, string Fieldname_Search_MA, string Paramsearch)
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
            dttheme = CustomViewGrid.BuildviewgridJanus(filenamexml, GRID_LIST, panel1);
            for (int i = 0; i < dttheme.Rows.Count; i++)
            {
                DataRow r_1 = dtColumns.NewRow();
                r_1["ID"] = dttheme.Rows[i]["name"].ToString();
                r_1["NAME"] = dttheme.Rows[i]["headerText"].ToString();
                dtColumns.Rows.Add(r_1);
            }
            //GRID_LIST.RootTable.Columns[dttheme.Rows.Count - 1].AutoSizeMode = Janus.Windows.GridEX.ColumnAutoSizeMode.Default;// = DataGridViewAutoSizeColumnMode.Fill;
            GRID_LIST.DoubleClick +=new EventHandler(GRID_LIST_DoubleClick);
            GRID_LIST.KeyDown +=new KeyEventHandler(GRID_LIST_KeyDown);
            GRID_LIST.KeyUp +=new KeyEventHandler(GRID_LIST_KeyUp);
            GRID_LIST.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            GRID_LIST.GroupByBoxVisible = false;
            txtKeySearch.Text = Paramsearch; 
            txtKeySearch_TextChanged((new object()), (new EventArgs()));
        }
        public ListviewJanus(string caption, string filenamexml, DataTable _dtSource, string Fieldname_Search_MA, string Paramsearch)
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
            dttheme = CustomViewGrid.BuildviewgridJanus(filenamexml, GRID_LIST, panel1);
            for (int i = 0; i < dttheme.Rows.Count; i++)
            {
                DataRow r_1 = dtColumns.NewRow();
                r_1["ID"] = dttheme.Rows[i]["name"].ToString();
                r_1["NAME"] = dttheme.Rows[i]["headerText"].ToString();
                dtColumns.Rows.Add(r_1);
            }
            //GRID_LIST.RootTable.Columns[dttheme.Rows.Count - 1].AutoSizeMode = Janus.Windows.GridEX.ColumnAutoSizeMode.Default;// = DataGridViewAutoSizeColumnMode.Fill;
            GRID_LIST.DoubleClick += new EventHandler(GRID_LIST_DoubleClick);
            GRID_LIST.KeyDown += new KeyEventHandler(GRID_LIST_KeyDown);
            GRID_LIST.KeyUp += new KeyEventHandler(GRID_LIST_KeyUp);
            GRID_LIST.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            GRID_LIST.GroupByBoxVisible = false;
            txtKeySearch.Text = Paramsearch;
            txtKeySearch_TextChanged((new object()), (new EventArgs()));
        }

        private void GRID_LIST_DoubleClick(object sender, EventArgs e)
        {
            _RowViewSelect = (DataRowView)this.BindingListView.Current;
            this.Hide();
        }
        private void GRID_LIST_KeyDown(object sender, KeyEventArgs e)
        {            
           if (e.KeyData == Keys.Enter)
            {
                _RowViewSelect = (DataRowView)this.BindingListView.Current;
                this.Hide();
            }
        }
        private void GRID_LIST_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (_RowViewSelect != null)
                {
                    _RowViewSelect = (DataRowView)this.BindingListView.Current;
                    this.Hide();
                }
            }
        }           
        private void btnchon_Click(object sender, EventArgs e)
        {
            _RowViewSelect = (DataRowView)this.BindingListView.Current;
            this.Hide();
        }

        private void Listview_Load(object sender, EventArgs e)
        {
            txtKeySearch.Focus();
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
    }
}
