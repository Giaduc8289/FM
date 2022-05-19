using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.IO;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;

namespace GD.FM.APP.LIB
{
    class ExportExcel
    {

        public static string ExportToExcel12(string reportName, DataSet dsKetqua, string tableName, string excelName, string exportFileName, string pathTemplateExcel)
        {
            System.Globalization.CultureInfo oldCulture =
               System.Threading.Thread.CurrentThread.CurrentCulture;
            System.Globalization.CultureInfo newCulture = new
               System.Globalization.CultureInfo("en-US");

            System.Threading.Thread.CurrentThread.CurrentCulture = newCulture;

            Microsoft.Office.Interop.Excel.Application oX1 = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Application oX2 = new Microsoft.Office.Interop.Excel.Application();
            Workbook oWB = null, oWBTemplate = null;
            Worksheet oWS = null, oWSTem1 = null, oWSTem2 = null;
            Range rng, rowActive;
            int stt = 0, j = 0, i = 0;
            string _ExportToExcel12 = "";
            if (!System.IO.File.Exists(excelName))
            {
                MessageBox.Show("Tệp ListReport không tồn tại", "Thông báo");
                return _ExportToExcel12;
            }
            oWB = oX1.Workbooks.Open(excelName);
            oWS = (Worksheet)oWB.Worksheets[1];
            //---Tong so dong chua du lieu trong file excel template
            int totalRowTem = 0;
            totalRowTem = oWS.UsedRange.Row - 1 + oWS.UsedRange.Rows.Count;
            string nameTemplateFile = "", sQuery = "";
            for (i = 2; i < totalRowTem; i++)
            {
                if (((Range)oWS.Cells[i,1]).Value.ToString().ToUpper() == reportName.ToUpper())
                {
                    try
                    {
                        nameTemplateFile = ((Range)oWS.Cells[i, 2]).Value.ToString();
                        sQuery = ((Range)oWS.Cells[i, 3]).Value.ToString();
                    }
                    catch { }
                }
            }
            oWB.Close();
            oX1.Quit();

            #region Dua du lieu vao file Template
            try
            {
                if (string.IsNullOrEmpty(nameTemplateFile))
                {
                    MessageBox.Show("Không có mẫu Excel ứng với báo cáo: " + reportName, "Thông báo");
                }
                else
                {
                    //---Doc file template Excel---
                    if (pathTemplateExcel.Substring(pathTemplateExcel.Length - 1) != "\\")
                        pathTemplateExcel = pathTemplateExcel.Trim() + "\\";
                    if (!File.Exists(pathTemplateExcel + nameTemplateFile))
                    {
                        MessageBox.Show("Tệp " + pathTemplateExcel + nameTemplateFile + " không tồn tại", "Thông báo");
                        return _ExportToExcel12;
                    }
                    oWBTemplate = oX2.Workbooks.Open(pathTemplateExcel + nameTemplateFile);
                    oWSTem1 = (Worksheet)oWBTemplate.Worksheets[1];
                    oWSTem2 = (Worksheet)oWBTemplate.Worksheets[2];

                    //---Tong so truong trong sheet2
                    int numField = 0, start = 0, Before_Start = 0;
                    string cString = "";
                    int[] col = new int[50], GroupField = new int[10];
                    string[] GF_OldValue = new string[10];
                    bool[] GF_In = new bool[10];
                    int colSTT = 0, GF_Count = 0;
                    string GF_String = "";
                    string[] _Columns;
                    _Columns = sQuery.Split(';');

                    numField = oWSTem2.UsedRange.Row - 1 + oWSTem2.UsedRange.Rows.Count;
                    //---Vi tri bat dau chen
                    try
                    {
                        int.TryParse(((Range)oWSTem2.Cells[1, 2]).Value.ToString(), out start);
                    }
                    catch { }
                    try
                    {
                        int.TryParse(((Range)oWSTem2.Cells[2, 2]).Value.ToString(), out colSTT);
                    }
                    catch { }

                    Before_Start = start - 1;
                    //---Dong Format la start-1 dung de xac dinh vi tri chen file trong cot nao
                    for (i = 1; i < numField; i++)
                    {
                        try
                        {
                            int.TryParse(((Range)oWSTem2.Cells[i, 1]).Value.ToString(), out col[i]);
                        }
                        catch { }
                    }
                    //---lay cac truong duoc nhom dua vao mang GroupField
                    GF_Count = 0;
                    i = 1;
                    while (true)
                    {
                        string _cotgroup = "";
                        try
                        {
                            _cotgroup = ((Range)oWSTem2.Cells[i, 3]).Value.ToString();
                        }
                        catch { }
                        if (string.IsNullOrEmpty(_cotgroup) || i > 9) break;

                        int _GroupFieldi = 0;
                        int.TryParse(((Range)oWSTem2.Cells[i, 3]).Value.ToString(), out _GroupFieldi);
                        GroupField[GF_Count] = _GroupFieldi;
                        GF_String += GroupField[GF_Count] + ";";
                        GF_Count++;
                        i++;
                    }

                    #region Insert du lieu tu database vao excel
                    stt = 0;
                    j = 1;
                    string GT = "";
                    while(j<numField)
                    {
                        if(col[j]==0) 
                        {
                            numField = j;
                            break;
                        }
                        j++;
                    }

                    if (start > 0)
                    {
                        foreach (DataRow dr in dsKetqua.Tables[tableName].Rows)
                        {
                            rowActive = (Range)oWSTem1.Cells[start, 1];
                            rowActive.EntireRow.Insert(XlInsertShiftDirection.xlShiftDown);
                            stt++;
                            if (colSTT > 0)
                                oWSTem1.Cells[start, colSTT] = stt;
                            for (i = 0; i < GF_Count - 1; i++)
                            {
                                GT = dr[GroupField[i]].ToString();
                                if (GF_In[i] || GT != GF_OldValue[i])
                                {
                                    GF_OldValue[i] = GT;
                                    if (col[GroupField[i] + 1] > 0)
                                    {
                                        oWSTem1.Cells[start, col[GroupField[i] + 1]] = GT;
                                    }
                                    GF_In[i] = false;
                                    if (i < GF_Count - 1) GF_In[i + 1] = true;
                                }
                            }
                            for (j = 1; j < numField; j++)
                            {
                                try
                                {
                                    if (col[j] > 0 && GF_String.IndexOf((j - 1).ToString() + ";") == -1)
                                    {
                                        oWSTem1.Cells[start, col[j]] = dr[_Columns[j - 1]].ToString();
                                    }
                                }
                                catch { }
                            }
                            start++;
                        }
                        if (start > Before_Start + 1)//---Co phat sinh dong moi thi xoa dong format
                        {
                            rowActive = (Range)oWSTem1.Cells[Before_Start, 1];
                            rowActive.EntireRow.Delete(XlDeleteShiftDirection.xlShiftUp);
                        }
                    }
                    #endregion

                    #region Replate cac tham 
                    oWSTem1.Application.DisplayAlerts = false;
                    rng = oWSTem1.Range["A1", "Z1000"];
                    string pattern = "";
                    for (i = 0; i < dsKetqua.Tables.Count; i++)
                    {
                        if (dsKetqua.Tables[i].Rows.Count > 0)
                        {
                            DataRow drThamso = dsKetqua.Tables[i].Rows[0];
                            if (drThamso != null)
                            {
                                for (j = 0; j < dsKetqua.Tables[i].Columns.Count; j++)
                                {
                                    if (dsKetqua.Tables[i].Columns[j].ColumnName.ToUpper().StartsWith("PARA"))
                                        pattern = "##p" + dsKetqua.Tables[i].Columns[j].ColumnName.Substring(4) + "#";
                                    else
                                        pattern = "##p" + dsKetqua.Tables[i].Columns[j].ColumnName + "#";
                                    
                                    rng.Replace(pattern, drThamso[j].ToString());
                                }
                            }
                        }
                    }

                    System.Data.DataTable dtHeader = (System.Data.DataTable)dsKetqua.Tables[2];
                    bool tam_ung = false;
                    if(dtHeader.Rows[0]["Tamung"] != DBNull.Value)
                        tam_ung = Convert.ToBoolean(dtHeader.Rows[0]["Tamung"]);
                    bool tien_mat = false;
                    if (dtHeader.Rows[0]["Taikhoanno"] != DBNull.Value)
                    {
                        string tkn = dtHeader.Rows[0]["Taikhoanno"].ToString().Substring(0, 3);
                        string tkc = dtHeader.Rows[0]["Taikhoanco"].ToString().Substring(0, 3);
                        if (tkn == "111" || tkc == "111") tien_mat = true;
                    }

                    FillPicCheckbox(oWSTem1, rng, tam_ung, tien_mat);
                    oWSTem1.Application.DisplayAlerts = true;
                    #endregion

                    oWSTem1.Activate();
                    oWSTem2.Visible = XlSheetVisibility.xlSheetVeryHidden;
                    _ExportToExcel12 = exportFileName + "_" + DateTime.Now.Year + DateTime.Now.Month + DateTime.Now.Day + "_" + DateTime.Now.Hour + DateTime.Now.Minute + DateTime.Now.Second;
                    oWBTemplate.SaveAs(_ExportToExcel12);
                    oWBTemplate.Close();
                    oX2.Quit();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra khi kết xuất dữ liệu", "Thông báo");
                //MessageBox.Show(ex.ToString());
                //oX2.Quit();
                Marshal.ReleaseComObject(oWS);
                Marshal.ReleaseComObject(oWSTem1);
                Marshal.ReleaseComObject(oWSTem2);
                Marshal.ReleaseComObject(oWB);
                Marshal.ReleaseComObject(oWBTemplate);
                Marshal.ReleaseComObject(oX1);
                Marshal.ReleaseComObject(oX2);
            }
            #endregion

            Marshal.ReleaseComObject(oWS);
            Marshal.ReleaseComObject(oWSTem1);
            Marshal.ReleaseComObject(oWSTem2);
            Marshal.ReleaseComObject(oWB);
            Marshal.ReleaseComObject(oWBTemplate);
            Marshal.ReleaseComObject(oX1);
            Marshal.ReleaseComObject(oX2);
            oX1 = null;
            oX2 = null;

            System.Threading.Thread.CurrentThread.CurrentCulture = oldCulture;
            return _ExportToExcel12;
        }

        private static void FillPicCheckbox(Worksheet oWS, Range rng, bool tam_ung, bool tien_mat)
        {
            string check_img = AppDomain.CurrentDomain.BaseDirectory + "img\\icon\\chon16.png";
            string uncheck_img = AppDomain.CurrentDomain.BaseDirectory + "img\\icon\\khongchon16.png";
            if (!File.Exists(check_img))
            {
                DirectoryInfo dir = new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory);
                check_img = dir.Parent.Parent.FullName + "\\img\\icon\\chon16.png";
                uncheck_img = dir.Parent.Parent.FullName + "\\img\\icon\\khongchon16.png";
            }

            object mis = Type.Missing;
            XlSearchDirection search_next = XlSearchDirection.xlNext;

            // thuc chi
            Range picRange = rng.Find("[picThucchi]", mis, mis, mis, mis, search_next, true, mis, mis);
            if (picRange != null)
                InsertPicture(oWS, picRange, (!tam_ung) ? check_img : uncheck_img);

            // tam ung
            picRange = rng.Find("[picTamung]", mis, mis, mis, mis, search_next, true, mis, mis);
            if (picRange != null)
                InsertPicture(oWS, picRange, (tam_ung) ? check_img : uncheck_img);

            // chuyen khoan
            picRange = rng.Find("[picChuyenkhoan]", mis, mis, mis, mis, search_next, true, mis, mis);
            if (picRange != null)
                InsertPicture(oWS, picRange, (!tien_mat) ? check_img : uncheck_img);

            // tien mat
            picRange = rng.Find("[picTienmat]", mis, mis, mis, mis, search_next, true, mis, mis);
            if (picRange != null)
                InsertPicture(oWS, picRange, (tien_mat) ? check_img : uncheck_img);
        }


        /// <summary>
        /// sample row = "1", "2", "99"
        /// sample col = "A", "B", "Z"
        /// picturePath = "D:\\check.jpg"
        /// return true neu them picture thanh cong
        /// </summary>
        /// <param name="oWS"></param>
        /// <param name="row"></param>
        /// <param name="col"></param>
        /// <param name="picturePath"></param>
        /// <returns></returns>
        public static bool InsertPicture(Worksheet oWS, Range picRange, string picturePath)
        {
            try
            {
                picRange.Value2 = "";
                Pictures pics = (Pictures)oWS.Pictures(System.Reflection.Missing.Value);
                Picture my_pic = pics.Insert(picturePath, System.Reflection.Missing.Value);
                my_pic.Top = (double)picRange.Top;
                my_pic.Left = (double)picRange.Left;
                my_pic.Width = 12.0d;
                my_pic.Height = 12.0d;
                return true;
            }
            catch (Exception ex)
            {
                string sErr = ex.Message;
            }

            return false;
        }
    }

    //#region Export Excel
    //public static void ExportExcel(string pPathDb, string pTemplate, string pRptName, string pFileExcel, short SoTs,
    //    string Ts1=null, string Ts2=null, string Ts3=null, string Ts4=null, string Ts5=null, string Ts6=null, string Ts7=null, string Ts8=null, string Ts9=null, string Ts10=null,
    //    string Ts11=null, string Ts12=null, string Ts13=null, string Ts14=null, string Ts15=null, string Ts16=null, string Ts17=null, string Ts18=null, string Ts19=null, string Ts20=null)
    //{
    //    string _FileName = "";
    //    ToExcel.clsExcel _Excel = new clsExcel();

    //    pPathDb = pPathDb.Substring(0, pPathDb.Length - 1);
    //    string ListReport = pTemplate + "ListReport.xls";
    //    pTemplate = pTemplate.Substring(0, pTemplate.Length - 1);

    //    _Excel.ExportToExcel(ref pRptName, ref pPathDb, ref ListReport,
    //        ref pFileExcel, ref pTemplate, ref SoTs, ref Ts1, ref Ts2, ref Ts3, ref Ts4, ref Ts5, ref Ts6, ref Ts7, ref Ts8, ref Ts9, ref Ts10,
    //        ref Ts11, ref Ts12, ref Ts13, ref Ts14, ref Ts15, ref Ts16, ref Ts17, ref Ts18, ref Ts19, ref Ts20);

    //    if(string.IsNullOrEmpty(_FileName))
    //        System.Windows.Forms.MessageBox.Show("Không kết xuất được dữ liệu ra tệp Excel!", "Chú ý", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Warning);
    //    else
    //        System.Windows.Forms.MessageBox.Show("Kết xuất thành công tệp " + _FileName, "Thông báo", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
    //}
    //#endregion


}
