using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Data;
using System.IO;

namespace GD.FM.LIB
{
    public class PROCESS_DATA
    {
        public static void GenXMLfromDataTable(string path, DataTable dtable)
        {
            try
            {
                FileInfo info = new FileInfo(path);
                if (info.Exists)
                {
                    info.Delete();
                }
                DataSet DS=new DataSet();
                DS.Tables.Add(dtable.Copy());
                IO.GenXML(path, DS);
                //dtable.WriteXml(path, XmlWriteMode.WriteSchema);
            }
            catch (Exception)
            {
            }
        }

        public static void GenXMLfromDataSet(string path, DataSet ds)
        {
            try
            {
                FileInfo info = new FileInfo(path);
                if (info.Exists)
                {
                    info.Delete();
                }
                ds.WriteXml(path, XmlWriteMode.WriteSchema);
            }
            catch (Exception)
            {
                throw;
            }           
        }

        //---------------------
        public static DataTable ReadXMLtoDataTable(string strpathfilename)
        {            
            DataTable set = new DataTable();
            try
            {
                if (System.IO.File.Exists(strpathfilename)) set = IO.ReadXMLTOW(strpathfilename);                
            }
            catch { }
            return set;
        }

        public static string RunTheMethod(Func<string> MethodName)
        {
            string Str_return = "";
            using (System.Windows.Forms.Form f = new System.Windows.Forms.Form())
            using (System.Windows.Forms.PictureBox _PictureBox = new System.Windows.Forms.PictureBox())
            using (System.ComponentModel.BackgroundWorker worker = new System.ComponentModel.BackgroundWorker())
            {
                System.Drawing.Image _image = System.Drawing.Image.FromFile(GD.FM.LIB.PATH.ERP_PATH + @"\IMG\waiting.xml");
                _PictureBox.Image = _image;
                _PictureBox.Width = _image.Width;
                _PictureBox.Height = _image.Height;
                worker.DoWork += delegate
                {
                    Str_return = MethodName();
                };
                worker.RunWorkerCompleted += delegate
                {
                    f.Dispose();   // exit the modal dialog
                };
                f.Load += delegate
                {
                    worker.RunWorkerAsync();
                };
                System.Drawing.Point a = new System.Drawing.Point(10, 10);
                _PictureBox.Location = a;
                f.Controls.Add(_PictureBox);
                f.Text = "Chờ xử lý";
                f.ShowIcon = false;
                f.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                f.ShowInTaskbar = false;
                f.ControlBox = false;
                f.BackColor = System.Drawing.Color.Blue;
                f.MaximumSize = new System.Drawing.Size(_PictureBox.Width + 20, _PictureBox.Height + 20);
                f.MinimumSize = new System.Drawing.Size(_PictureBox.Width + 20, _PictureBox.Height + 20);
                f.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
                f.ShowDialog();
            };
            return Str_return;
        }
    }
}
