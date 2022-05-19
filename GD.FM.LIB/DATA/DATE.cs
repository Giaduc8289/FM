using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
namespace GD.FM.DATA
{
    public class DATE
    {
        private static DateTime dt = DateTime.Now;
        public static DateTime NGAYHACHTOAN
        {
            get
            {
                return dt;
            }
            set 
            {
                dt = value;
            }
        }
        public static CultureInfo CultureInfo = new CultureInfo("en-GB");
        public static int Getlastday(int Thang, int Nam)
        {
            int songay;
            switch (Thang)
            {
                case 4:
                    songay = 30;
                    break;
                case 6:
                    songay = 30;
                    break;
                case 9:
                    songay = 30;
                    break;
                case 11:
                    songay = 30;
                    break;
                case 2:
                    if (((Nam % 4 == 0) && (Nam % 100 != 0)) || (Nam % 400 == 0)) songay = 29;
                    else songay = 28;
                    break;
                default:
                    songay = 31;
                    break;

            }
            return songay;
        }
    }
}
