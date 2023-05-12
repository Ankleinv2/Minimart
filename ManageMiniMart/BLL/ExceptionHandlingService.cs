using ManageMiniMart.Custom;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManageMiniMart.BLL
{
    public class ExceptionHandlingService
    {
        public static void Initialize()
        {
            Application.ThreadException += new System.Threading.ThreadExceptionEventHandler(Application_ThreadException);
        }
        private static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            // Handle the exception here
            MyMessageBox myMessageBox = new MyMessageBox();
            myMessageBox.show($"{e.Exception.Message}", "Error");
        }
    }
}
