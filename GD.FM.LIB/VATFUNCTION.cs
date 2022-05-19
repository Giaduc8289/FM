using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
namespace GD.FM.LIB
{
    public class VATFUNCTION
    {

        public static decimal TINHBIEUTHUC(string congThuc, Dictionary<string, decimal> giaTriBien)
        {
            if (string.IsNullOrEmpty(congThuc)) return 0;
            ArrayList listCongThuc = new ArrayList();
            int i = 0;
            int n = congThuc.Length;
            string s = "";
            bool bTinh = false;
            //int k = 0;
            while (i < n)
            {
                if (congThuc[i] == '+' || congThuc[i] == '-' || congThuc[i] == '*'
                    || congThuc[i] == '/' || congThuc[i] == '(' || congThuc[i] == ')')
                {
                    bool flag = true;
                    if (s.Length > 0)
                    {
                        if (giaTriBien.ContainsKey(s))
                        {
                            listCongThuc.Add(giaTriBien[s]);
                        }
                        else
                        {
                            try
                            {
                                listCongThuc.Add(Convert.ToDecimal(s));
                            }
                            catch { flag = false; }
                        }
                        //k++;
                        s = "";
                    }
                    if (flag) { listCongThuc.Add(congThuc[i].ToString()); }
                }
                else
                {
                    s += congThuc[i];
                }
                i++;
            }//while

            if (s.Length > 0)
            {
                if (giaTriBien.ContainsKey(s))
                {
                    listCongThuc.Add(giaTriBien[s]);
                }
                else
                {
                    listCongThuc.Add(Convert.ToDecimal(s));
                }

            }

            Stack<string> stack = new Stack<string>();
            ArrayList listKQ = new ArrayList();

            for (int j = 0; j < listCongThuc.Count; j++)
            {
                if (listCongThuc[j].ToString() == ")")
                {
                    //string strDongNgoac = stack.Pop();
                    while (stack.Pop() != "(")
                    { }
                    continue;
                }

                if (listCongThuc[j].ToString() == "+" || listCongThuc[j].ToString() == "-"
                    || listCongThuc[j].ToString() == "*" || listCongThuc[j].ToString() == "/"
                    || listCongThuc[j].ToString() == "(")
                {
                    stack.Push(listCongThuc[j].ToString());
                    bTinh = false;
                }
                else
                {
                    listKQ.Add(listCongThuc[j]);
                    bTinh = true;
                }

                if (stack.Count == 0) continue;

                string toanTu = stack.Pop();

                if (bTinh && listKQ.Count > 1 && (toanTu == "+" || toanTu == "-" || toanTu == "*" || toanTu == "/"))
                {
                    decimal toanHangA = Convert.ToDecimal(listKQ[listKQ.Count - 2]);
                    decimal toanHangB = Convert.ToDecimal(listKQ[listKQ.Count - 1]);
                    listKQ.Remove(listKQ[listKQ.Count - 2]);
                    listKQ.Remove(listKQ[listKQ.Count - 1]);
                    switch (toanTu)
                    {
                        case "+":
                            listKQ.Add(toanHangA + toanHangB);
                            break;
                        case "-":
                            listKQ.Add(toanHangA - toanHangB);
                            break;
                        case "*":
                            listKQ.Add(toanHangA * toanHangB);
                            break;
                        case "/":
                            listKQ.Add(toanHangA / toanHangB);
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    stack.Push(toanTu);
                }
            }//for
            while (listKQ.Count > 1)
            {
                if (listKQ.Count > 1 && stack.Count > 0)
                {
                    string toanTu = stack.Pop();
                    decimal toanHangA = Convert.ToDecimal(listKQ[listKQ.Count - 2]);
                    decimal toanHangB = Convert.ToDecimal(listKQ[listKQ.Count - 1]);
                    listKQ.Remove(listKQ[listKQ.Count - 2]);
                    listKQ.Remove(listKQ[listKQ.Count - 1]);
                    switch (toanTu)
                    {
                        case "+":
                            listKQ.Add(toanHangA + toanHangB);
                            break;
                        case "-":
                            listKQ.Add(toanHangA - toanHangB);
                            break;
                        case "*":
                            listKQ.Add(toanHangA * toanHangB);
                            break;
                        case "/":
                            listKQ.Add(toanHangA / toanHangB);
                            break;
                        default:
                            break;
                    }
                }
            }
            if (listKQ.Count == 0) return 0;
            return Convert.ToDecimal(listKQ[0]);
        }//TinhBieuThuc
     
        /// <summary>
        /// 
        /// </summary>
        /// <param name="m_datetime"></param>
        /// <returns></returns>
        public static bool CheckValidDatetime_ddmmyyyy ( string m_datetime ){
            bool valid = false;
            if (string.IsNullOrEmpty(m_datetime)) return valid; 
            
            char[] arrchars = { '/', '-' };                
            string[] arrdate = m_datetime.Trim().Split(arrchars);
            int day, month, year;
            if (arrdate.Length != 3) return valid; 
            int.TryParse(arrdate[0], out day);
            int.TryParse(arrdate[1], out month);
            int.TryParse(arrdate[2], out year);
            valid = ( (day > 0 && day <= 31) && (  month >0 && month <=12 ) && ( year >= 1900 & year <= 2090) )? true : false;
            return valid;                                                      
        }

        public static string SplitDatetime_ddmmyyy(string m_datetime, string m_displaydefault)
        {
            string m_result = m_displaydefault;
            if (string.IsNullOrEmpty(m_datetime)) return m_result;
            if (CheckValidDatetime_ddmmyyyy(m_datetime)) {
                char[] arrchars = { '/', '-' };
                string[] arr = m_datetime.Trim().Split(arrchars); 
                m_result = string.Format("Ngày  {0} tháng  {1} năm  {2}", arr[0], arr[1], arr[2]);
            }

            return m_result; 
        } 
    }
}
