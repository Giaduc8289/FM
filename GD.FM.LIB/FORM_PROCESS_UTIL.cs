using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace GD.FM.LIB
{
    public class FORM_PROCESS_UTIL
    {
        private static List<Control> listCtrl = new List<Control>();
        /// <summary>
        /// Ham de enable cac textbox, ComboBox, checkbox, radio, DateTimePicker
        /// </summary>
        /// <param name="isEnable">trang thai enable hay !readonly</param>
        /// <param name="control">container hay form chua cac control</param>
        /// <param name="listControlsNotIsEnable">danh sach cac control set trang thai nguoc lai voi isEnable</param>
        public static void enableControls(bool isEnable, Control control, List<Control> listControlsNotIsEnable)
        {
            if (control.Controls.Count > 0)
            {
                for (int i = 0; i < control.Controls.Count; i++)
                {
                    enableControls(isEnable, control.Controls[i], listControlsNotIsEnable);
                }                
            }
            else
            {
                if (listControlsNotIsEnable != null && listControlsNotIsEnable.Contains(control))
                {
                    isEnable = !isEnable;
                }

                if (control.GetType() == typeof(TextBox) || control.GetType().BaseType == typeof(TextBox))
                {
                    ((TextBox)control).ReadOnly = !isEnable;
                }
                else if (control.GetType() == typeof(MaskedTextBox) || control.GetType().BaseType == typeof(MaskedTextBox))
                {
                    ((MaskedTextBox)control).ReadOnly = !isEnable;
                }
                else if (control.GetType() == typeof(DateTimePicker) || control.GetType().BaseType == typeof(DateTimePicker))
                {
                    ((DateTimePicker)control).Enabled = isEnable;
                }
                else if (control.GetType() == typeof(ComboBox) || control.GetType().BaseType == typeof(ComboBox)
                        || control.GetType() == typeof(CheckBox) || control.GetType().BaseType == typeof(CheckBox)
                        || control.GetType() == typeof(RadioButton) || control.GetType().BaseType == typeof(RadioButton))
                {
                    string str = control.Name;
                    control.Enabled = isEnable;
                }                
            }
        }
        //lay' tat ca control trong 1 container
        public static List<Control> getAllControl(Control ctrl)
        {            
            if (ctrl.Controls.Count > 0)
            {
                for (int i = 0; i < ctrl.Controls.Count; i++)
                {
                    getAllControl(ctrl.Controls[i]);
                }
            }
            else
            {
                if (ctrl.GetType() == typeof(TextBox) || ctrl.GetType().BaseType == typeof(TextBox))
                {
                    listCtrl.Add((TextBox)ctrl);
                }
                else if (ctrl.GetType() == typeof(MaskedTextBox) || ctrl.GetType().BaseType == typeof(MaskedTextBox))
                {
                    listCtrl.Add((MaskedTextBox)ctrl);
                }
                else if (ctrl.GetType() == typeof(DateTimePicker) || ctrl.GetType().BaseType == typeof(DateTimePicker))
                {
                    listCtrl.Add((DateTimePicker)ctrl);
                }
                else if (ctrl.GetType() == typeof(ComboBox)
                    || ctrl.GetType().BaseType == typeof(ComboBox))
                {
                    listCtrl.Add((ComboBox)ctrl);
                }
                else if (ctrl.GetType() == typeof(CheckBox)
                        || ctrl.GetType().BaseType == typeof(CheckBox))
                {
                    listCtrl.Add((CheckBox)ctrl);
                }
            }
            return listCtrl;
        }

        //Ham xoa rong noi dung control
        public static void clearControls(Control control, List<Control> listControlsNotClear)
        {
            if (control.Controls.Count > 0)
            {
                for (int i = 0; i < control.Controls.Count; i++)
                {
                    clearControls(control.Controls[i], listControlsNotClear);
                }
            }
            else
            {
                if (listControlsNotClear == null || listControlsNotClear.Contains(control))
                {
                    if (control.GetType() == typeof(TextBox) || control.GetType().BaseType == typeof(TextBox))
                    {
                        ((TextBox)control).Text = "";
                    }
                    else if (control.GetType() == typeof(MaskedTextBox) || control.GetType().BaseType == typeof(MaskedTextBox))
                    {
                        ((MaskedTextBox)control).Text = "";
                    }
                    else if (control.GetType() == typeof(DateTimePicker) || control.GetType().BaseType == typeof(DateTimePicker))
                    {
                        ((DateTimePicker)control).Value = GD.FM.DATA.DATE.NGAYHACHTOAN;
                    }
                    else if (control.GetType() == typeof(ComboBox) 
                        || control.GetType().BaseType == typeof(ComboBox))
                    {
                        if (((ComboBox)control).Items.Count > 0)
                        {
                            ((ComboBox)control).SelectedIndex = 0;
                        }                        
                    }
                    else if (control.GetType() == typeof(CheckBox)
                            || control.GetType().BaseType == typeof(CheckBox))
                    {
                        ((CheckBox)control).Checked = false;
                    }
                }                
            }
        }

        #region --->>> Ham dich so tien sang dang chu
        //Co 2 loi: - ko doc duoc dang 0,326 (0 phay) |- doc sai so dang 34,640 (co so 0 cuoi phan thap phan)
        private static int m_blSDungNgonNhuMB = -1;        
        private static string m_tenvnd = "đồng";

        public static string convertSotienThanhChu(decimal number)
        {
            return ReplaceNgonNguBN(DIchso(number));
        }

        /// <summary>
        /// Chuyển số thành chữ
        /// </summary>
        private static string dichso(string number)
        {
            decimal num = 0M;
            try
            {
                num = Convert.ToDecimal(number);
                return ReplaceNgonNguBN(DIchso(num));
            }
            catch
            {
                return "Không đúng định dạng số";
            }
        }

        private static string ReplaceNgonNguBN(string sotienchu)
        {
            switch (m_blSDungNgonNhuMB)
            {
                //mien bac, 
                case 1:
                    sotienchu = sotienchu.Replace("ngàn", "nghìn").Replace("lẻ", "linh");
                    break;
                //mien nam ,mac dinh la mien nam nen khong can phai thay the
                case 2:
                    break;
                default://mien bac, mac dinh la mien nam nen  phai thay the
                    sotienchu = sotienchu.Replace("ngàn", "nghìn").Replace("lẻ", "linh");
                    break;
            }
            return sotienchu;
        }

        private static double Round1(double value)
        {
            string tblhung = "";
            string source = Convert.ToString(value).Trim();
            int count = source.IndexOf(",", 0);
            if (count > 0)
            {
                tblhung = source.Substring(0, count);
            }
            else
            {
                tblhung = Convert.ToString(value);
            }
            return Convert.ToDouble(tblhung);
        }

        //tao ham lay so ben phai.
        private static double right(double value1, int numb)
        {
            string value2 = Convert.ToString(value1);
            if (value2.Length < numb)
            {
                return Convert.ToDouble(value2);
            }
            return Convert.ToDouble(value2.Substring(value2.Length - numb));
        }

        private static object IIF(bool x1, object x2, object x3)
        {
            if (x1 == true)
            {
                return x2;
            }
            else
            {
                return x3;
            }
        }

        private static string DIchso(decimal num)
        {
            bool blAm = false;
            if (num < 0)
            {
                blAm = true;
                num = -num;
            }

            //Cho nay de thiet lap ngon ngu mien Bac hoac Nam ( 1:Bac, 2:Nam )
            if (m_blSDungNgonNhuMB == -1)
                m_blSDungNgonNhuMB = 1;
            string strSourceValue;

            string strUnitOfCalculate;
            // strSourceValue = num.ToString();
            strSourceValue = num.ToString();
            //dinh nghia mo so de luu phan thap phan
            string strNumBerTp = "";
            // cắt bỏ phần thập phân
            string dauphantachTP = System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator;
            if (strSourceValue.Contains(dauphantachTP))
            {
                //bo cac so 0 thua o ben phai phan thap phan
                strNumBerTp = strSourceValue.Substring(strSourceValue.IndexOf(dauphantachTP) + 1).TrimEnd(new char[] { '0' });
                strSourceValue = strSourceValue.Substring(0, strSourceValue.IndexOf(dauphantachTP));
            }

            strUnitOfCalculate = m_tenvnd;// Thay đổi đơn vị tính ở đây (mặc định là "đồng")
            String strResult = "";// Chuỗi lưu kết quả phân tích

            String ThreeDigit = "";

            // ' Mảng lưu các đơn vị (const) tương ứng của 1 chữ số
            String[] UnitArray1 = new string[] { "", "mươi ", "trăm " };
            int idUnit1;// ' idUnit1 = 1: hàng đơn vị  2: hàng chục  3: hàng trăm
            // ' Mảng lưu các hằng đơn vị (const) tương ứng của cụm 3 chữ số
            String[] UnitArray2 = new string[] { "", "ngàn ", "triệu ", "tỉ ", "ngàn ", "triệu ", "tỉ ", "triệu ", "tỉ ", "tỉ " };
            //' Mảng lưu các chữ số đơn lẻ đã được phân tích trong một cụm 3 chữ số

            String[] OneWordArray = new string[3];
            //  ' Stack lưu các cụm 3 chữ số đã được phân tích
            String[] ThreeWordStack = new string[12];

            // ' Số lượng các phần tử có nghĩa trong ThreeWordStack

            int nTop = 0;
            nTop = 0;
            //' Bắt đầu xử lý =============================================================

            // 'Convert chuỗi strSourceValue về dạng đầy đủ XXX XXX XXX XXX
            int lenght;
            lenght = strSourceValue.Length % 3;
            if (lenght == 1)
                strSourceValue = "00" + strSourceValue;
            else if (lenght == 2)//'lenght = 2
                strSourceValue = "0" + strSourceValue;
            //   ' Bắt đầu xử lý chính việc chuyển đổi ==================================        

            while (strSourceValue.Length > 0)
            {
                ThreeDigit = strSourceValue.Substring(strSourceValue.Length - 3);//' Lấy ra 3 chữ số cuối
                idUnit1 = 0;//' Bắt đầu là hàng đơn vị trong một cụm 3 chữ số

                String SingleWord = "";

                for (int i = 2; i >= 0; i--)
                {
                    switch (ThreeDigit[i])
                    {
                        case '1':
                            if (ThreeDigit[1] != '0' && i != 0 && ThreeDigit[1] != '1')
                                SingleWord = "mốt " + UnitArray1[idUnit1];
                            else
                                SingleWord = "một " + UnitArray1[idUnit1];
                            // ' Con số đang xét là hàng chục

                            if (idUnit1 == 1)
                                SingleWord = "mười ";
                            break;
                        case '2':
                            SingleWord = "hai " + UnitArray1[idUnit1];
                            break;
                        case '3':
                            SingleWord = "ba " + UnitArray1[idUnit1];
                            break;
                        case '4':
                            SingleWord = "bốn " + UnitArray1[idUnit1];
                            break;
                        case '5':
                            SingleWord = "năm " + UnitArray1[idUnit1];
                            break;
                        case '6':
                            SingleWord = "sáu " + UnitArray1[idUnit1];
                            break;
                        case '7':
                            SingleWord = "bảy " + UnitArray1[idUnit1];
                            break;
                        case '8':
                            SingleWord = "tám " + UnitArray1[idUnit1];
                            break;
                        case '9':
                            SingleWord = "chín " + UnitArray1[idUnit1];
                            break;
                    }

                    if (i == 0 && ThreeDigit[i] == '0' && Int32.Parse(ThreeDigit) > 0)
                    {
                        SingleWord = "không trăm ";
                    }
                    else if (i == 1 && ThreeDigit[i] == '0' && Int32.Parse(ThreeDigit) > 0 && ThreeDigit[2] != '0')
                    {
                        SingleWord = "lẻ ";
                    }
                    idUnit1 = idUnit1 + 1;
                    //' Thêm chữ số vừa mới phân tích vào mảng
                    OneWordArray[i] = SingleWord;
                    SingleWord = "";
                }
                // Next ' Kết thúc phân tích một cụm 3 chữ số của chuỗi strSourceValue
                //' Thêm cụm 3 chữ số vừa mới phân tích vào mảng
                ThreeWordStack[nTop] = OneWordArray[0] + OneWordArray[1] + OneWordArray[2];
                nTop++;
                //' Loại bỏ 3 chữ số cuối vừa mới phân tích
                strSourceValue = strSourceValue.Substring(0, strSourceValue.Length - 3);
            }

            nTop = nTop - 1;
            int k = nTop;
            for (int i = nTop; i >= 0; i--)
            {
                //30 /3
                if (ThreeWordStack[i] != null)
                {
                    if (ThreeWordStack[i] == "")
                    {
                        if (i >= 1 && i + 1 < ThreeWordStack.Length)
                            if (ThreeWordStack[i + 1] != "" && UnitArray2[i + 1] != "")
                                strResult = strResult + UnitArray2[i];
                    }
                    else
                    {
                        strResult = strResult + ThreeWordStack[i] + UnitArray2[i];
                    }
                }
            }//het for

            // Next
            strResult = strResult.Replace("mươi năm", "mươi lăm");
            //30 /3
            strResult = strResult.Replace("triệu ngàn", "triệu");
            strResult = strResult.Replace("tỉ triệu", "tỉ");
            //3/4
            strResult = strResult.Replace("mười năm", "mười lăm");
            //cat bo truong hop không trăm lẻ ở đầu khi số tiền nhỏ hơn 10
            if (strResult.StartsWith("không trăm lẻ"))
                strResult = strResult.Substring(13);
            else if (strResult.StartsWith("không trăm linh"))
                strResult = strResult.Substring(15);
            if (strResult == "")
            {
                strResult = "Không";
            }
            //cắt bỏ trường hợp không trăm
            if (strResult.StartsWith("không trăm"))
                strResult = strResult.Substring(10);
            if (blAm)
                strResult = "âm " + strResult.Trim();
            string chudau = strResult.Trim().Substring(0, 1);
            string cuoi = strResult.Trim().Substring(1, strResult.Trim().Length - 1);
            chudau = chudau.Trim().ToUpper();
            strResult = chudau + cuoi;

            //doc phan thap phan
            string strReadTP = "";
            try
            {
                //bo cac so 0 thua o ben phai phan thap phan
                Int32 sotp = Int32.Parse(strNumBerTp);
                if (sotp > 0)
                {
                    strReadTP = dichso(strNumBerTp);
                }
            }
            catch { }

            if (strResult.Trim() == "Không")
            {
                if (strReadTP == "")
                {
                    return "";
                }
                else
                {
                    strResult = "Không ";
                }
            }
            else
            {
                strResult = strResult + " " + strUnitOfCalculate; // +"./.";
            }

            if (strReadTP != "")
            {
                strResult = strResult.Replace(strUnitOfCalculate, ""); // + "./."
                strReadTP = strReadTP.Trim().Substring(0, 1).ToLower() + strReadTP.Trim().Substring(1);
                strResult = strResult + "phẩy " + strReadTP;
            }
            return strResult;
        }
        #endregion
    }
}
