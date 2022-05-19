using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Drawing;

namespace GD.FM.LIB

{
    public class TrayPopup
    {        
        public static void PoupStringMessage(string strtitle, string strconten)
        {
            TrayPopupBase _TrayPopup = new TrayPopupBase();
            _TrayPopup.Width = 300;
            _TrayPopup.Height = 100;
            _TrayPopup.opacity = 75;
            _TrayPopup.TimeToLive = 3;
            _TrayPopup.ShowWindow(strconten,strtitle);

        }
        public static void PoupStringMessage(string strtitle, string strconten,string type)
        {
            if (type.Equals("H"))
            {
                PoupStringMessage(strtitle, strconten);
            }
            if (type.Equals("E"))
            {
                PoupStringMessage(strtitle, strconten);
            }
        }
    }
    
}
