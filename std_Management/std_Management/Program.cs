using std_Management.Models;
using Student_Management;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace std_Management
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
<<<<<<< HEAD
            User user = new User();
            user.UserId = "TE0002";
            Application.Run(new ClassUpdateMark_Form(user));
=======
            Application.Run(new Login_Form());
>>>>>>> 56ceee8fefebd7656717ca2dedc3392d819e26db
        }
    }
}
