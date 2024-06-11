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
            Registration aRegister = new Registration();
            Interests aInterests = new Interests();
            MentalQuestions aMentalQuestions = new MentalQuestions();
            PhysiqueQuestions aPhysiqueQuestions = new PhysiqueQuestions();
            Profile aProfile = new Profile();
            DialogWindow aDialog = new DialogWindow();
            Contact aContact = new Contact();

            //model's instance
            Model aModel = new Model();

            //controller's instance
            Controller aController = new Controller(aLogin, aRegister, aInterests, aMentalQuestions, aPhysiqueQuestions, aProfile, aDialog, aContact, aModel);

            Application.Run(aLogin);
        }
    }
}
