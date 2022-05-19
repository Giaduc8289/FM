using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Windows.Forms;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace GD.FM.LIB
{
    public class PATH
    {
        public static string ERP_PATH
        {
            get
            {
                try
                {
                    return System.Deployment.Application.ApplicationDeployment.CurrentDeployment.DataDirectory.ToString();
                }
                catch
                {
                    DirectoryInfo _DirectoryInfo = new DirectoryInfo(Application.StartupPath);
                    return _DirectoryInfo.Parent.Parent.FullName.ToString();
                }

            }
        }
       
    }
}
