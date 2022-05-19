using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Data;
using System.Windows.Forms;
using GD.FM.BLL;
using GD.FM.DAL.HelperClasses;

namespace GD.FM.APP.LIB
{
    public class ParameterReport
    {
         public static void ShowMessage_Error( string messge)
        {
            MessageBox.Show(messge, "Phần mềm KDTM 2020", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
