using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using System.Collections;

namespace GD.FM.APP.BAOCAO
{
    public partial class FRM_REPORTVIEWER : GD.FM.APP.DANHMUC.FRM_DMPARENT
    {
        protected Hashtable _params = null;

        public FRM_REPORTVIEWER(DataSet ds, string path, string dtName, string Tieude, bool Ketxuat = true)
        {
            InitializeComponent();
            ReportDataSource rpdt = new ReportDataSource();
            rpdt.Name = dtName;// ds.Tables[0].TableName;
            rpdt.Value = ds.Tables[0];
            reportViewer1.LocalReport.DataSources.Add(rpdt);

            for (int i = 1; i < ds.Tables.Count; i++)
            {
                ReportDataSource rpdt1 = new ReportDataSource();
                rpdt1.Name = ds.Tables[i].TableName;
                rpdt1.Value = ds.Tables[i];
                reportViewer1.LocalReport.DataSources.Add(rpdt1);
            }

            reportViewer1.LocalReport.ReportPath = path;

            //List<ReportParameter> paraList = new List<ReportParameter>();
            //paraList.Add(new ReportParameter("Tinh", "Thái Bình"));
            //paraList.Add(new ReportParameter("Thua", "Biến thừa"));
            //reportViewer1.LocalReport.SetParameters(paraList);

            this.reportViewer1.ShowExportButton = Ketxuat;

            this.Text = Tieude;
            //this.reportViewer1.RefreshReport();
            this.reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            this.reportViewer1.ZoomMode = ZoomMode.Percent;
            this.reportViewer1.ZoomPercent = 100;
            //this.reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            this.reportViewer1.RefreshReport();
        }

        public FRM_REPORTVIEWER(bool Matrix, DataSet ds, string path, string dtName, string Tieude, bool Ketxuat = true)
        {
            InitializeComponent();
            ReportDataSource rpdt = new ReportDataSource();
            rpdt.Name = dtName;// ds.Tables[0].TableName;
            rpdt.Value = ds.Tables[0];
            reportViewer1.LocalReport.DataSources.Add(rpdt);

            for (int i = 1; i < ds.Tables.Count; i++)
            {
                ReportDataSource rpdt1 = new ReportDataSource();
                rpdt1.Name = ds.Tables[i].TableName;
                rpdt1.Value = ds.Tables[i];
                reportViewer1.LocalReport.DataSources.Add(rpdt1);
            }

            reportViewer1.LocalReport.ReportPath = path;

            //List<ReportParameter> paraList = new List<ReportParameter>();
            //paraList.Add(new ReportParameter("Tinh", "Thái Bình"));
            //paraList.Add(new ReportParameter("Thua", "Biến thừa"));
            //reportViewer1.LocalReport.SetParameters(paraList);

            this.reportViewer1.ShowExportButton = Ketxuat;

            this.Text = Tieude;
            //this.reportViewer1.RefreshReport();
            //this.reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            this.reportViewer1.ZoomMode = ZoomMode.Percent;
            this.reportViewer1.ZoomPercent = 100;
            if(Matrix)
                this.reportViewer1.SetDisplayMode(DisplayMode.Normal);
            else
                this.reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);

            this.reportViewer1.RefreshReport();
        }

        public FRM_REPORTVIEWER(DataSet ds, string path, string Tieude, bool Ketxuat = false)
        {
            InitializeComponent();

            for (int i = 0; i < ds.Tables.Count; i++)
            {
                ReportDataSource rpdt = new ReportDataSource();
                rpdt.Name = ds.Tables[i].TableName;
                rpdt.Value = ds.Tables[i];
                reportViewer1.LocalReport.DataSources.Add(rpdt);
            }

            reportViewer1.LocalReport.ReportPath = path;
            this.reportViewer1.ShowExportButton = Ketxuat;

            this.Text = Tieude;
            this.reportViewer1.ZoomMode = ZoomMode.Percent;
            this.reportViewer1.ZoomPercent = 100;
            this.reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            this.reportViewer1.RefreshReport();
        }

        //public FRM_REPORTVIEWER(DataTable dt, List<ReportParameter> paraList, string path, string dtName)
        //{
        //    InitializeComponent();
        //    ReportDataSource rpdt = new ReportDataSource();
        //    rpdt.Name = dtName;
        //    rpdt.Value = dt;
        //    reportViewer1.LocalReport.DataSources.Add(rpdt);

        //    reportViewer1.LocalReport.ReportPath = path;

        //    reportViewer1.LocalReport.SetParameters(paraList);

        //    this.reportViewer1.RefreshReport();
        //    this.reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
        //    this.reportViewer1.ZoomMode = ZoomMode.Percent;
        //    this.reportViewer1.ZoomPercent = 100;
        //}


        public FRM_REPORTVIEWER(DataTable dt, string path, string Tieude, bool Ketxuat = false)
        {

            InitializeComponent();

            ReportDataSource rpdt = new ReportDataSource("DataSet1", dt);
            reportViewer1.LocalReport.DataSources.Add(rpdt);
            reportViewer1.LocalReport.ReportPath = path;
            reportViewer1.RefreshReport();

            this.reportViewer1.ShowExportButton = Ketxuat;
            this.Text = Tieude;

        }

        public FRM_REPORTVIEWER(DataTable dt, string path, ReportParameterCollection p, string Tieude, bool Ketxuat = false)
        {

            InitializeComponent();

            ReportDataSource rpdt = new ReportDataSource("DataSet1", dt);
            reportViewer1.LocalReport.DataSources.Add(rpdt);
            reportViewer1.LocalReport.ReportPath = path;
            reportViewer1.RefreshReport();
            reportViewer1.LocalReport.SetParameters(p);

            this.reportViewer1.ShowExportButton = Ketxuat;
            this.Text = Tieude;

        }


        public void FillParams(Hashtable h_param)
        {
            try
            {
                ReportParameterCollection pp = new ReportParameterCollection();
                IDictionaryEnumerator ide = h_param.GetEnumerator();
                while (ide.MoveNext())
                {
                    string p_name = ide.Key.ToString();
                    pp.Add(new ReportParameter(p_name, ide.Value.ToString()));
                }
                reportViewer1.LocalReport.SetParameters(pp);
            }
            catch (Exception ex)
            {
                string s_err = ex.Message;
            }
        }


    }
}
