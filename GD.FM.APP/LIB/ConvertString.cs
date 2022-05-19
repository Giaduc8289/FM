using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GD.FM.APP.LIB
{
    class ConvertString
    {
        public static string StringtoDB(string strNguon)
        {
            return strNguon == string.Empty ? null : strNguon;
        }
        public static Decimal NumbertoDB(string strNguon)
        {
            return string.IsNullOrEmpty(strNguon) ? 0 : Convert.ToDecimal(strNguon);
        }
        public static Boolean BooltoDB(string strNguon)
        {
            bool result = false;
            try
            {
                result = Convert.ToBoolean(strNguon);
            }
            catch{}
            return result;
        }
        public static string TCVNtoUnicode(byte[] byteSource)
        {
            // _BKED = "¸¹µ¶· »¼½¾Æ¨ ÊË©ÇÈÉ èéê«ìíîãäåæëçßáâ¬ÏÐÑÌÎeÒÓÔÕÖª úûüýþ ïóôñò õö÷øù­ ×ØÜÝÞ ¡¢£¤¥§®¦ "
            // _ASCII = "aaaaa aaaaaa aaaaaa oooooooooooooooooeeeeeeeeeeee yyyyy uuuuu uuuuuu iiiii AAEOODdU"
            string strTCVN = "¸¹µ¶· »¼½¾Æ¨ ÊË©ÇÈÉ èéê«ìíîãäåæëçßáâ¬ÏÐÑÌÎeÒÓÔÕÖª úûüýþ ïóôñò õö÷øù­ ×ØÜÝÞ ¡¢£¤¥§®¦";
            string strUnicode = "áạàảã ằẳẵắặă ấậâầẩẫ ốộờôỡớợóọồổởỗòỏõơẽéẹèẻeềểễếệê ỳỷỹýỵ ùúụủũ ừửữứựư ìỉĩíị ĂÂÊÔƠĐđƯ";
            string strReturn="";
            char[] arrCharTCVN = strTCVN.ToCharArray();
            char[] arrCharUnicode = strUnicode.ToCharArray();
            foreach (byte _byte in byteSource)
            {
                bool ktra = false;
                for(int i=0;i<arrCharTCVN.Length;i++)
                {
                    if (Convert.ToByte(arrCharTCVN[i]) == _byte && _byte != 32)
                    {
                        strReturn += arrCharUnicode[i];
                        ktra = true;
                    }
                }
                if (!ktra)
                {
                    byte[] arrByte=new byte[1];
                    arrByte[0]=_byte;
                    strReturn += Encoding.ASCII.GetString(arrByte);
                }
            }
            return strReturn;
        }

    }
}
