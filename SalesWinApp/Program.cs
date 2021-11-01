using BusinessObject.Models;
using SalesWinApp.Admin.ProductManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesWinApp
{
    static class Program
    {
        public static object Configuration { get; internal set; }

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]

        static void Main()
        {
            Member admin = LoadJson.GetAdminAccount();
            Member loginUser = null;
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new frmProductManagement());
            /*
            frmLogin fLogin = new frmLogin(admin);
            Application.Run(fLogin);
            loginUser = fLogin.loginUser;
            if (loginUser != null)
            {
                if(loginUser == admin)
                {
                    Application.Run(new frmMain(loginUser));
                }
            }
            */
        }
    }
}
