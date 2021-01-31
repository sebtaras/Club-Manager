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
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using ClubManager.Models;
using System.Reflection;
using NHibernate.Tool.hbm2ddl;
using ClubManager.DAL_File.Mappers;

namespace ClubManager
{
    public class Program
    {

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            /* var config = new Configuration();

             IDictionary<string, string> props = new Dictionary<string, string>();
             props.Add("connection.connection_string", "Data Source=DESKTOP-ES2R24K\\SQLEXPRESS;Initial Catalog=ClubManager;Integrated Security=True");
             props.Add("dialect", "NHibernate.Dialect.MsSql2012Dialect");
             props.Add("connection.provider", "NHibernate.Connection.DriverConnectionProvider");
             props.Add("", "");
             config.
             config.AddAssembly(typeof(Person).Assembly);
             config.AddAssembly(typeof(Admin).Assembly);
             config.AddAssembly(typeof(Trainer).Assembly);
             config.AddAssembly(typeof(Player).Assembly);
             config.AddAssembly(typeof(Team).Assembly);
             config.AddAssembly(typeof(Transaction).Assembly);
             config.AddAssembly(typeof(Training).Assembly);

             var sessions = config.BuildSessionFactory();
             ISession sess = sessions.OpenSession();

             var schemaExport = new SchemaExport(config);
             schemaExport.Create(false, true);*/

            ISessionFactory _sessionFactory = NhibernateService.OpenSessionFactory();
            
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
