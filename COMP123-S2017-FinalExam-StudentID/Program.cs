using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Name:Kirandeeep Kaur
 * Date:17/August/2017
 * StudentID:300915966
 * Description:This is main program to run a splash form
 * Version:0.1 
 */

namespace COMP123_S2017_FinalExam_StudentID
{
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SplashForm());
        }
    }
}
