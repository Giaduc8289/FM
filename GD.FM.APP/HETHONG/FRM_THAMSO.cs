using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using GD.FM.BLL;
using GD.FM.DAL;
using GD.FM.DAL.EntityClasses;
using GD.FM.DAL.FactoryClasses;
using GD.FM.DAL.HelperClasses;
using Janus.Windows.GridEX;

namespace GD.FM.APP.HETHONG
{
    public partial class FRM_THAMSO : GD.FM.APP.DANHMUC.FRM_DMPARENT
    {
        public FRM_THAMSO()
        {
            InitializeComponent();
        }

        private void FormatGridStyle(DataGridView dgv)
        {
            dgv.Columns["Mahieu"].Visible = false;
            dgv.Columns["Ghichu"].Width = 250;
            dgv.Columns["Ghichu"].ReadOnly = true;
            dgv.Columns["Giatri"].Width = 250;
            dgv.Columns["Thaydoi"].Visible = false;
            dgv.Columns["Ghichu"].HeaderText = "Ghi chú";
            dgv.Columns["Giatri"].HeaderText = "Giá trị";
            dgv.AllowUserToAddRows = false;

            DataTable dt = (DataTable)dgv.DataSource;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                bool Thaydoi = Convert.ToBoolean(dt.Rows[i]["Thaydoi"]);
                if (!Thaydoi)
                {
                    dgv.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
                    dgv.Rows[i].ReadOnly = true;
                }
            }
        }

        private void AddValue(ref DataTable dtView, DataTable dt, int _index)
        {
            DataRow row = dtView.NewRow();
            dtView.Rows.Add(row);
            row["Mahieu"] = dt.Rows[_index]["Mahieu"].ToString();
            row["Ghichu"] = dt.Rows[_index]["Ghichu"].ToString();
            row["Giatri"] = dt.Rows[_index]["Giatri"].ToString();
            row["Thaydoi"] = dt.Rows[_index]["Thaydoi"];
        }

        private void CreateTab(ref DataTable dtView, ref TabPage m_tab, DataTable dt, int _index)
        {
            m_tab = new TabPage();
            m_tab.Text = dt.Rows[_index]["Ghichu"].ToString().ToUpperInvariant();
            tabControl1.TabPages.Add(m_tab);
            m_tab.Paint += new PaintEventHandler(m_tab_Paint);

            dtView = new DataTable();
            dtView.Columns.Add(new DataColumn("Mahieu", typeof(string)));
            dtView.Columns.Add(new DataColumn("Ghichu", typeof(string)));
            dtView.Columns.Add(new DataColumn("Giatri", typeof(string)));
            dtView.Columns.Add(new DataColumn("Thaydoi", typeof(bool)));

            DataGridView dgv = new DataGridView();
            dgv.Dock = DockStyle.Fill;
            dgv.Width = m_tab.Width - 10;
            dgv.Height = m_tab.Height - 10;
            m_tab.Controls.Add(dgv);
            dgv.DataSource = dtView;

            //GD.FM.CONTROL.JGridEX GRID_THAMSO = new GD.FM.CONTROL.JGridEX();
            //GD.FM.LIB.GRID_COMM.LOAD_GRID_SYS_TabPage(LIB.PATH.KTXPT_PATH + @"\XMLCONFIG\FRM_THAMSO.xml", GRID_THAMSO, m_tab, true);
            //GRID_THAMSO.DataSource = dtView;

            DataRow row = dtView.NewRow();
            dtView.Rows.Add(row);
            row["Mahieu"] = dt.Rows[_index]["Mahieu"].ToString();
            row["Ghichu"] = dt.Rows[_index]["Ghichu"].ToString();
            row["Giatri"] = dt.Rows[_index]["Giatri"].ToString();
            row["Thaydoi"] = dt.Rows[_index]["Thaydoi"];
        }

        void m_tab_Paint(object sender, PaintEventArgs e)
        {
            //throw new NotImplementedException();

            // khi bam chuyen tab, su kien pain datagrid-view duoc goi. Phai ve lai datagridview
            DataGridView dgv = (DataGridView)((TabPage)sender).Controls[0];
            FormatGridStyle(dgv);

            //GD.FM.CONTROL.JGridEX GRID_THAMSO = (GD.FM.CONTROL.JGridEX)((TabPage)sender).Controls[0];
            //GRID_THAMSO.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.True;
            //GRID_THAMSO.RootTable.Columns[ThamsoFields.Ghichu.Name].EditType = EditType.NoEdit;

            //for (int i = 0; i < GRID_THAMSO.RowCount; i++)
            //{
            //    if (!(bool)GRID_THAMSO.GetRow(i).Cells[ThamsoFields.Thaydoi.Name].Value)
            //    {
            //        Janus.Windows.GridEX.GridEXFormatStyle style = new GridEXFormatStyle();
            //        //style.ForeColor = Color.Black;
            //        style.BackColor = Color.Yellow;// Color.CornflowerBlue;
            //        GRID_THAMSO.GetRow(i).RowStyle = style;
            //        GRID_THAMSO.GetRow(i)
            //    }
            //}

        }

        private void LoadTabs()
        {
            string strSQL = @"SELECT Mahieu, Ghichu, Giatri, Thaydoi
                                    FROM Thamso Where An = '0' ORDER BY Stt";
            DataTable dt = DataFactory.SelectTable(strSQL);

            TabPage m_tab = null;
            DataTable dtView = null;
            bool _create_new_tab = false;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (i == 0) _create_new_tab = true;
                string ghi_chu = dt.Rows[i]["Ghichu"].ToString();
                if (ghi_chu == ghi_chu.ToUpper()) _create_new_tab = true;

                if (_create_new_tab)
                    CreateTab(ref dtView, ref m_tab, dt, i);
                else
                    AddValue(ref dtView, dt, i);

                _create_new_tab = false;
            }
        }

        private void FRM_THAMSO_Load(object sender, EventArgs e)
        {
            try
            {
                LoadTabs();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string strSQL = "update Thamso set Giatri=@Giatri where Mahieu=@Mahieu";
                for (int i = 0; i < tabControl1.TabPages.Count; i++)
                {
                    DataGridView dgv = (DataGridView)((TabPage)tabControl1.TabPages[i]).Controls[0];
                    DataTable dt = (DataTable)dgv.DataSource;
                    for (int j = 0; j < dt.Rows.Count; j++)
                    {
                        ArrayList p = new ArrayList();
                        p.Add(new SqlParameter("@Mahieu", dt.Rows[j]["Mahieu"].ToString()));
                        p.Add(new SqlParameter("@Giatri", dt.Rows[j]["Giatri"].ToString()));

                        bool Thaydoi = Convert.ToBoolean(dt.Rows[j]["Thaydoi"]);
                        if (Thaydoi)
                            DataFactory.Execute(strSQL, p);
                    }
                }
                MessageBox.Show("Thành công!","Thông báo");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
