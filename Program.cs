using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace text_anal
{
    
    static class Program
    {
        public static string getText(string path)
        {
            StreamReader sr = new StreamReader(path);
            string ans = sr.ReadToEnd();
            return ans;
        }
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
