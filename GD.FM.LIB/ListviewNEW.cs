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
    public partial class ListviewNEW : GD.FM.CONTROL.FORM 
    {

        private DataGridView DataGridListView = new DataGridView();
        private DataTable dtSource, dttheme = new DataTable(), dtColumns=new DataTable();
        private BindingSource BindingListView=new BindingSource();
        public DataRowView _RowViewSelect; 
        private string Fieldname = "";
        public ListviewNEW(string filenamexml,DataTable _dtSource, string Fieldname_Search_MA,string Paramsearch)
        {
            InitializeComponent();
            DataSet ds = IO.ReadXML2(filenamexml);
            DataTable dttemplate = ds.Tables["tablename"];
            this.Text = dttemplate.Rows[0]["headerText"].ToString();

            this.dtSource = _dtSource.Copy(); 
            Fieldname = Fieldname_Search_MA;
            DataView Source_View = new DataView(dtSource);
            Source_View.Sort = Fieldname_Search_MA + " ASC";
            BindingListView.DataSource = Source_View;
            DataGridListView.DataSource = BindingListView;

            dtColumns.Columns.Add("ID", typeof(string));
            dtColumns.Columns.Add("NAME", typeof(string));
            dttheme = CustomViewGrid.Buildviewgrid_NEW(filenamexml, DataGridListView, panel1);
            for (int i = 0; i < dttheme.Rows.Count; i++)
            {
                DataRow r_1 = dtColumns.NewRow();
                r_1["ID"] = dttheme.Rows[i]["name"].ToString();
                r_1["NAME"] = dttheme.Rows[i]["headerText"].ToString();
                dtColumns.Rows.Add(r_1);
            }
            DataGridListView.Columns[dttheme.Rows.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            CustomViewGrid.BinMultiCombo(combofiled, txttenfiled, dtColumns, "NAME", "ID");
            DataGridListView.DoubleClick +=new EventHandler(DataGridListView_DoubleClick);
            DataGridListView.KeyDown +=new KeyEventHandler(DataGridListView_KeyDown);
            DataGridListView.KeyUp +=new KeyEventHandler(DataGridListView_KeyUp);
            DataGridViewRow row = DataGridListView.RowTemplate;
            //row.DefaultCellStyle.Format = "#,##0";
            txtKeySearch.Text = Paramsearch; 
            txtKeySearch_TextChanged((new object()), (new EventArgs()));
            //if (Fieldname == MathangFields.Masieuthi.Name) combofiled.SelectedValue = MathangFields.Tendaydu.Name;
            if (Fieldname == "Masieuthi") combofiled.SelectedValue = "Tendaydu";
        }
        public ListviewNEW(string caption, string filenamexml, DataTable _dtSource, string Fieldname_Search_MA, string Paramsearch)
        {
            InitializeComponent();
            this.Text = caption;
            this.dtSource = _dtSource.Copy(); Fieldname = Fieldname_Search_MA;
            DataView Source_View = new DataView(dtSource);
            Source_View.Sort = Fieldname_Search_MA + " ASC";
            BindingListView.DataSource = Source_View;
            DataGridListView.DataSource = BindingListView;

            dtColumns.Columns.Add("ID", typeof(string));
            dtColumns.Columns.Add("NAME", typeof(string));
            dttheme = CustomViewGrid.Buildviewgrid_NEW(filenamexml, DataGridListView, panel1);
            for (int i = 0; i < dttheme.Rows.Count; i++)
            {
                DataRow r_1 = dtColumns.NewRow();
                r_1["ID"] = dttheme.Rows[i]["name"].ToString();
                r_1["NAME"] = dttheme.Rows[i]["headerText"].ToString();
                dtColumns.Rows.Add(r_1);
            }
            DataGridListView.Columns[dttheme.Rows.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            CustomViewGrid.BinMultiCombo(combofiled, txttenfiled, dtColumns, "NAME", "ID");
            DataGridListView.DoubleClick += new EventHandler(DataGridListView_DoubleClick);
            DataGridListView.KeyDown += new KeyEventHandler(DataGridListView_KeyDown);
            DataGridListView.KeyUp += new KeyEventHandler(DataGridListView_KeyUp);
            DataGridViewRow row = DataGridListView.RowTemplate;
            row.DefaultCellStyle.Format = "#,##0";
            txtKeySearch.Text = Paramsearch; txtKeySearch_TextChanged((new object()), (new EventArgs()));
            //if (Fieldname == MathangFields.Masieuthi.Name) combofiled.SelectedValue = MathangFields.Tendaydu.Name;
            if (Fieldname == "Masieuthi") combofiled.SelectedValue = "Tendaydu";
        }

        private void DataGridListView_DoubleClick(object sender, EventArgs e)
        {
            _RowViewSelect = (DataRowView)this.BindingListView.Current;
            this.Hide();
            
        }
        private void DataGridListView_KeyDown(object sender, KeyEventArgs e)
        {            
           if (e.KeyData == Keys.Enter)
            {
                _RowViewSelect = (DataRowView)this.BindingListView.Current;
                this.Hide();
            }
        }
        private void DataGridListView_KeyUp(object sender, KeyEventArgs e)
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
        private void Search_Validating()
        {
            DataTable dt = dtSource.Copy();
            try
            {
                string KeySearch = txtKeySearch.Text.Trim();
                //if (Fieldname == MathangFields.Masieuthi.Name)
                //{
                //    BindingListView.Filter = MathangFields.Masieuthi.Name + " Like '%" + KeySearch + "%' or " + MathangFields.Tendaydu.Name + " Like '%" + KeySearch + "%'";
                //}
                //else
                {
                    BindingListView.Filter = Fieldname + " Like '%" + KeySearch + "%'";
                }
            }
            catch { }
        }
        private void txtKeySearch_Validating(object sender, CancelEventArgs e)
        {
            Search_Validating();
            DataGridListView.Focus();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            Search_Validating();
        }

        private void txtKeySearch_TextChanged(object sender, EventArgs e)
        {
            //Lấy ra chuỗi tìm kiếm
            try
            {
                string strTimKiem = txtKeySearch.Text;
                string str_FiledName = combofiled.SelectedValue.ToString();
                //if (str_FiledName != "0") Fieldname = str_FiledName;
                Fieldname = str_FiledName;
                if (Fieldname == "0")
                {
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
                }
                else
                {
                    if (dtSource.Columns[Fieldname].DataType.ToString() == "System.String")
                    {
                        BindingListView.Filter = Fieldname + " Like '%" + strTimKiem + "%'";
                    }
                    else 
                    {
                        BindingListView.Filter = Fieldname + " = " + strTimKiem;
                    }
                }

                if (BindingListView.Count == 0 && dtSource.Rows.Count > 0)
                    BindingListView.Filter = "";
            }
            catch { }
        }
    }
}
