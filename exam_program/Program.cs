using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exam_program
{
    internal static class Program
    {
        public static List<string> count = new List<string>();
        public static int score = 0;
        public static int[] list = new int[5];
        public static int flag = 0;

        public static string name = "";
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
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
