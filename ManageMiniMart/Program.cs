using ManageMiniMart.BLL;
using ManageMiniMart.View;
using Register_Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManageMiniMart
{
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ExceptionHandlingService.Initialize();
            Application.Run(new FormLogin());
        }
    }
}
