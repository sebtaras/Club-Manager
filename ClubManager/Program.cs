using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClubManager.DAL_File;
using ClubManager.PresentationLayer;
using ClubManager.BaseLib;
using ClubManager.Contrllers;
using NHibernate.Cfg;
using NHibernate;
using ClubManager.Models;

namespace ClubManager
{
    public class Program
    {
        
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        [Obsolete]
        static void Main()
        {
            IWindowFormsFactory formsFactory = new WindowFormsFactory();
            PlayerRepository playerRepository = new PlayerRepository();
            TrainerRepository trainerRepository = new TrainerRepository();
            AdminRepository adminRepository = new AdminRepository();
            TrainingRepository trainingRepository = new TrainingRepository();
            TeamRepository teamRepository = new TeamRepository();
            TransactionRepository transactionRepository = new TransactionRepository();

            MainController mainController = new MainController(
                formsFactory, 
                playerRepository, 
                trainerRepository, 
                adminRepository, 
                trainingRepository,
                teamRepository,
                transactionRepository,
                new AdminController(),
                new PlayerController(),
                new TrainerController(),
                new AuthController());
            mainController.LoadDefaultModel();

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormLogIn(mainController));
        }
    }
}
