using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace GD.FM.LIB
{
    public class TextFiles
    {
         public static void CreateFile(string filename, string conten)
        {
            if (System.IO.File.Exists(filename))
            {
                System.IO.File.Delete(filename);
            }
            TextWriter tw = new StreamWriter(filename, true);
            try
            {                
                tw.WriteLine(conten);
                tw.Close();
            }
            catch (Exception ex)
            {               
            }
            finally
            {
                tw.Close();
            }
        }
         public static string ReadFile(string filename)
         {
             if (!System.IO.File.Exists(filename)) {
                  
                 return ""; 
             }
             StreamReader srd = new StreamReader(filename);
             try
             {
                 String a = srd.ReadToEnd();
                 srd.Close();
                 return a;
             }
             catch (Exception ex)
             {
                 return ex.Message;
             }
             finally
             {
                 srd.Close();
             }
         }
    }
}
