using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace GD.FM.APP.LIB
{
    class PATH
    {
        public static string KDTM_PATH
        {

            get
            {
                try
                {
                    //return System.Deployment.Application.ApplicationDeployment.CurrentDeployment.DataDirectory.ToString();
                    DirectoryInfo _DirectoryInfo = new DirectoryInfo(Application.StartupPath);
                    // doan nay dung de debug code
                    return _DirectoryInfo.Parent.Parent.FullName.ToString();
                    // doan nay dung de tao bo cai dat 
                    //return _DirectoryInfo.FullName.ToString();
                }
                catch
                {
                    DirectoryInfo _DirectoryInfo = new DirectoryInfo(Application.StartupPath);
                    return _DirectoryInfo.FullName.ToString();
                }

            } 

        }
    }
}
