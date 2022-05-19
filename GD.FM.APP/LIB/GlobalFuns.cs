using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GD.FM.APP.LIB
{
    class GlobalFuns
    {
        
        #region Difine Combolist struct
        public struct CombolistNum
        {
            private int luMa;
            private string luTen;

            public CombolistNum(int pMa, string pTen)
            {
                luMa = pMa;
                luTen = pTen;
            }

            public int Ma
            {
                get
                {
                    return luMa;
                }
            }

            public string Ten
            {
                get
                {
                    return luTen;
                }
            }

            //public string MaTen
            //{
            //    get
            //    {
            //        return luMa.ToString() + " " + luTen;
            //    }
            //}
        }

        public struct CombolistStr
        {
            private string ma;
            private string ten;
            public CombolistStr(string v_Ma, string v_Ten)
            {
                ma = v_Ma;
                ten = v_Ten;
            }
            public string Ma
            {
                get
                {
                    return ma;
                }
                set
                {
                    ma = value;
                }
            }
            public string Ten
            {
                get
                {
                    return ten;
                }
                set
                {
                    ten = value;
                }
            }
            public static string getTen(string v_MA, CombolistStr[] cmlist)
            {
                foreach (CombolistStr c in cmlist)
                {
                    if (c.Ma.Equals(v_MA))
                    {
                        return c.Ten;
                    }
                }
                return string.Empty;
            }
            public static string getMa(string v_TEN, CombolistStr[] cmlist)
            {
                foreach (CombolistStr c in cmlist)
                {
                    if (c.Ten.Equals(v_TEN))
                    {
                        return c.Ma;
                    }
                }
                return string.Empty;
            }

        }

        public struct CombolistObj
        {
            public const string MaFiled = "MA";
            public const string TenFiled = "TEN";
            private object ma;
            private object ten;
            public CombolistObj(object v_Ma, object v_Ten)
            {
                ma = v_Ma;
                ten = v_Ten;
            }
            public object Ma
            {
                get
                {
                    return ma;
                }
                set
                {
                    ma = value;
                }
            }
            public object Ten
            {
                get
                {
                    return ten;
                }
                set
                {
                    ten = value;
                }
            }
            public static object getTen(object v_MA, CombolistObj[] cmlist)
            {
                foreach (CombolistObj c in cmlist)
                {
                    if (c.Ma.Equals(v_MA))
                    {
                        return c.Ten;
                    }
                }
                return DBNull.Value;
            }
            public static object getMa(object v_TEN, CombolistObj[] cmlist)
            {
                foreach (CombolistObj c in cmlist)
                {
                    if (c.Ten.Equals(v_TEN))
                    {
                        return c.Ma;
                    }
                }
                return DBNull.Value;
            }
        }
        #endregion

    }
}
