/// ETML
/// Author      : Dmytro Remeniuk
/// Date        : 03.06.2024
/// Description :
using System;
using System.Windows.Forms;
using P_Sante.Views;
using P_Sante.Controllers;
using P_Sante.Models;

namespace P_Sante
{
    /// <summary>
    /// Main program
    /// </summary>
    internal static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //views' instances
            Login aLogin = new Login();
            Register aRegister = new Register();
            Interests aInterests = new Interests();

            //model's instance
            Model aModel = new Model();

            //controller's instance
            Controller aController = new Controller(aLogin, aRegister, aInterests, aModel);

            Application.Run(aLogin);
        }
    }
}
