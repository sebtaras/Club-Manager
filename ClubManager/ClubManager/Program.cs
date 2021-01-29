using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using ClubManager.DAL_File;
using ClubManager.PresentationLayer;
using ClubManager.BaseLib;
using ClubManager.Contrllers;

namespace ClubManager
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            IWindowFormsFactory _formsFactory = new WindowFormsFactory();

            PlayerRepository playerRepository = new PlayerRepository();
            TrainerRepository trainerRepository = new TrainerRepository();
            AdminRepository adminRepository = new AdminRepository();
            TrainingRepository trainingRepository = new TrainingRepository();
            TeamRepository teamRepository = new TeamRepository();
            TransactionRepository transactionRepository = new TransactionRepository();

            MainController mainController = new MainController(
                _formsFactory, 
                playerRepository, 
                trainerRepository, 
                adminRepository, 
                trainingRepository,
                teamRepository,
                transactionRepository);
            mainController.LoadDefaultModel();

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormLogIn(mainController));
        }
    }
}
