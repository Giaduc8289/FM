using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Security.Principal;
using System.IO;
using System.Security.AccessControl;
using GD.FM.APP.DANHMUC;

namespace GD.FM.APP
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            if (args != null && args.Length > 0 && args[0] == "Install")
            {
                string path = LIB.PATH.KDTM_PATH;
                SetPermissions(path);

                //try
                //{
                //    new HETHONG.FRM_MAIN().UpdateDB();
                //}
                //catch {}

                System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("vi-VN");
                System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("vi-VN");
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                GD.FM.APP.HETHONG.FRM_LOGIN _FRM_LOGIN = new GD.FM.APP.HETHONG.FRM_LOGIN();
                _FRM_LOGIN.ShowDialog();
                if (_FRM_LOGIN.islogin == true) Application.Run(new GD.FM.APP.HETHONG.FRM_MAIN());
            }
            else
            {
                System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("vi-VN");
                System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("vi-VN");
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                GD.FM.APP.HETHONG.FRM_LOGIN _FRM_LOGIN = new GD.FM.APP.HETHONG.FRM_LOGIN();
                _FRM_LOGIN.ShowDialog();
                /*FRM_THONGTIN _FRM_LOGIN = new FRM_THONGTIN();
                _FRM_LOGIN.ShowDialog();*/
                if (_FRM_LOGIN.islogin == true) Application.Run(new GD.FM.APP.HETHONG.FRM_MAIN());
            }
        }


        public static void SetPermissions(string path)
        {
            try
            {
                // Create security idenifier for all users (WorldSid)
                SecurityIdentifier sid = new SecurityIdentifier(WellKnownSidType.WorldSid, null);
                DirectoryInfo di = new DirectoryInfo(path);
                DirectorySecurity ds = di.GetAccessControl();
                // add a new file access rule w/ write/modify for all users to the directory security object

                ds.AddAccessRule(new FileSystemAccessRule(sid,
                                                      FileSystemRights.Write | FileSystemRights.Modify,
                                                      InheritanceFlags.ObjectInherit | InheritanceFlags.ContainerInherit,   // all sub-dirs to inherit
                                                      PropagationFlags.None,
                                                      AccessControlType.Allow));                                            // Turn write and modify on
                // Apply the directory security to the directory
                di.SetAccessControl(ds);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
