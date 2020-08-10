using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Windows.Forms;

namespace Cinema.WinUI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            IList<string> userPrincipal = new List<string>() { "Guest" };

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            FormLogin mainForm = new FormLogin(userPrincipal);

            // Set form to be main window in order to Exit the application.
            mainForm.IsMainWindow = true;
            mainForm.Show();

            if (mainForm.Created)
                Application.Run();

            //Application.Run(new Form1(userPrincipal));
        }
    }
}
