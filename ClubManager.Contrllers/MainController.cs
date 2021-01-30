using ClubManager.BaseLib;
using ClubManager.DAL_File;
using ClubManager.Models;
using ClubManager.Models.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClubManager.Contrllers
{
    public class MainController : IMainController
    {
        private IWindowFormsFactory _formsFactory;
        public IPlayerRepository _playerRepository;
        public ITrainerRepository _trainerRepository;
        private IAdminRepository _adminRepository;
        private ITrainingRepository _trainingRepository;
        private ITeamRepository _teamRepository;
        private ITransactionRepository _transactionRepository;
        private IAdminController _adminController;
        private IPlayerController _playerController;
        private ITrainerController _trainerController;
        private IAuthController _authController;
        
        public MainController(IWindowFormsFactory formsFactory, 
            IPlayerRepository playerRepository, 
            ITrainerRepository trainerRepository, 
            IAdminRepository adminRepository, 
            ITrainingRepository trainingRepository,
            ITeamRepository teamRepository,
            ITransactionRepository transactionRepository,
            IAdminController adminController,
            IPlayerController playerController,
            ITrainerController trainerController,
            IAuthController authController
            )
        {
            _formsFactory = formsFactory;
            _playerRepository = playerRepository;
            _trainerRepository = trainerRepository;
            _adminRepository = adminRepository;
            _trainingRepository = trainingRepository;
            _teamRepository = teamRepository;
            _transactionRepository = transactionRepository;
            _adminController = adminController;
            _playerController = playerController;
            _trainerController = trainerController;
            _authController = authController;
        }

        public void LoadDefaultModel()
        {
            _adminRepository.Add(new Admin(1, "admin", "admin", "a@m", "aaaaaa"));

            Transaction bd_t1 = new Transaction(1, (decimal)200.00, 1, 2020, 12);
            Transaction bd_t2 = new Transaction(2, (decimal)200.00, 1, 2021, 1);
            _transactionRepository.Add(bd_t1);
            _transactionRepository.Add(bd_t2);

            Player player_bd = new Player(1, "bob", "dasilva", "bd@mail", "password", 15, true);
            Player player_mp = new Player(1, "marko", "perkovic", "mp@mail", "password", 15, true);
            Player player_mz = new Player(1, "mali", "zugec", "mz@mail", "password", 6, true);
            Player player_mb = new Player(1, "zugecov", "brat", "mb@mail", "password", 6, false);
            Player player_poreg = new Player(1, "poreg", "srbin", "poreg@mail", "password", 17, false);
            Player player_it = new Player(1, "ivan", "tarzan", "mb@mail", "password", 7, true);
            player_bd.TransactionIds.Add(1);
            player_bd.TransactionIds.Add(2);
            player_mz.TeamId = 1;
            player_it.TeamId = 1;
            _playerRepository.Add(player_bd);
            _playerRepository.Add(player_mp);
            _playerRepository.Add(player_mz);
            _playerRepository.Add(player_poreg);
            _playerRepository.Add(player_mb);
            _playerRepository.Add(player_it);


            Trainer trainer1 = new Trainer(1, "gospon", "trener", "gt@mail", "password", true);
            Trainer trainer2 = new Trainer(1, "brkonja", "bradic", "bb@mail", "password", true);
            Trainer trainer3 = new Trainer(1, "drugi", "trener", "dt@mail", "password", false);
            trainer1.TeamIds.Add(1);
            _trainerRepository.Add(trainer1);
            _trainerRepository.Add(trainer2);
            _trainerRepository.Add(trainer3);

            Team zagici = new Team(1, "Zagici", 6, 7);
            Team limaci = new Team(1, "Limaci", 8, 10);
            Team mladiPioniri = new Team(1, "Mladi Pioniri", 11, 12);
            Team pioniri = new Team(1, "Pioniri", 13, 15);
            Team juniori = new Team(1, "Juniori", 16, 18);
            Team seniori = new Team(1, "Seniori", 19, 30);
            zagici.ListTrainerIds.Add(1);
            zagici.ListPlayerIds.Add(3);
            zagici.ListPlayerIds.Add(6);
            zagici.ListTrainingIds.Add(1);
            zagici.ListTrainingIds.Add(2);
            _teamRepository.Add(zagici);
            _teamRepository.Add(limaci);
            _teamRepository.Add(mladiPioniri);
            _teamRepository.Add(pioniri);
            _teamRepository.Add(juniori);
            _teamRepository.Add(seniori);

            Training training1 = new Training(1, DateTime.Now, new TimeSpan(0, 60, 0), 1, 1);
            Training training2 = new Training(1, DateTime.Now - new TimeSpan(1, 0, 0, 0), new TimeSpan(0, 60, 0), 1, 1);
            _trainingRepository.Add(training1);
            _trainingRepository.Add(training2);

        }

        public bool RegisterUser(string email, string password, string firstName, string lastName, string role, string age)
        {
            if(_authController.VerifyRegisterInput(email, password, firstName, lastName, role, age, _playerRepository, _trainerRepository))
                return true;
            return false;
        }

        public bool LogInUser(string email, string password)
        {

            if (_authController.VerifyLoginInput(email, password))
            {
                bool loginSuccess = true;
                switch (_authController.LogInUser(email, password, _playerRepository, _trainerRepository, _adminRepository))
                {
                    case "player":
                        {
                            var form = _formsFactory.PlayerView();
                            _playerController.Homepage(form, this, _playerRepository.GetPlayerByEmail(email), _transactionRepository, _trainerRepository, _trainingRepository, _teamRepository);
                            break;
                        }
                    case "trainer":
                        {
                            var form = _formsFactory.TrainerView();
                            var trainerController = new TrainerController();
                            trainerController.Homepage(form, this, _trainerRepository.GetTrainerByEmail(email), _trainerRepository, _trainingRepository, _teamRepository, _playerRepository);
                            break;
                        }
                    case "admin":
                        {
                            var form = _formsFactory.AdminView();
                            _adminController.Homepage(form, this, _adminRepository.GetAdminByEmail(email), _playerRepository, _trainerRepository, _teamRepository, _transactionRepository);
                            break;
                        }
                    case "": loginSuccess = false; break;
                }
                return loginSuccess;       
            }
            return false;
        }

        public void LogOut()
        {
            var form = _formsFactory.LoginView();
            form.ShowViewModaless(this);
        }

        public void SwitchToLogin(IRegisterView registerForm)
        {
            registerForm.HideForm();
            var form = _formsFactory.LoginView();
            form.ShowViewModaless(this);
        }

        public void SwitchToRegister(ILogInView loginForm)
        {
            loginForm.HideForm();
            var form = _formsFactory.RegisterView();
            form.ShowViewModaless(this);
        }

        public void HideAgeInput(IRegisterView form)
        {
            form.HideAgeOption();
        }

        public void ShowAgeInput(IRegisterView form)
        {
            form.ShowAgeOption();
        }

        public void ShowVerifyPlayerForm(int playerId)
        {
            var form = _formsFactory.VerifyUserView();
            _adminController.VerifyPlayer(form, _playerRepository.GetPlayerById(playerId), _playerRepository, _trainerRepository, _teamRepository);
        }

        public void ShowVerifyTrainerForm(int trainerId)
        {
            var form = _formsFactory.VerifyUserView();
            _adminController.VerifyTrainer(form, _trainerRepository.GetTrainerById(trainerId), _playerRepository, _trainerRepository, _teamRepository);
        }

        public void ShowPlayerInfo(IAdminView inForm, int playerId)
        {
            var form = _formsFactory.AdminPlayerOptionsView(_playerRepository.GetPlayerById(playerId), _formsFactory, _adminController);
            _adminController.ShowPlayerOptions(inForm, form, _playerRepository.GetPlayerById(playerId), _playerRepository ,_teamRepository, _transactionRepository);
        }

        public void ShowTrainerInfo(IAdminView inForm, int trainerId)
        {
            var form = _formsFactory.AdminTrainerOptionsView();
            _adminController.ShowTrainerOptions(inForm, form, _trainerRepository.GetTrainerById(trainerId), _trainerRepository, _teamRepository);
        }

        public void ShowTeamInfo(IAdminView inForm, int teamId)
        {
            var form = _formsFactory.AdminTeamView();
            form.SetTeamValues(_teamRepository.GetTeamById(teamId), _playerRepository.GetAll(), _trainerRepository.GetAll());
            _adminController.ShowTeam(form);
        }

        public void CreateTransactionsView()
        {
            var form = _formsFactory.CreateTransactionsView();
            _adminController.CreateTransactionsView(form, _playerRepository, _transactionRepository);
        }

        public bool ShowPlayerSettings(int playerId)
        {
            var form = _formsFactory.PlayerSettingsView(_playerRepository.GetPlayerById(playerId));
            return _playerController.ShowPlayerSettings(form, _playerRepository.GetPlayerById(playerId), _playerRepository, _authController);
        }

        public bool ShowTrainerSettings(int trainerId)
        {
            var form = _formsFactory.TrainerSettingsView(_trainerRepository.GetTrainerById(trainerId));
            return _trainerController.ShowTrainerSettings(form, _trainerRepository.GetTrainerById(trainerId), _trainerRepository, _authController);
        }
        public bool ShowAdminSettings(int adminId)
        {
            var form = _formsFactory.AdminSettingsView(_adminRepository.GetAdminById(adminId));
            return _adminController.ShowAdminSettings(form, _adminRepository.GetAdminById(adminId), _adminRepository, _authController);
        }

        public void CreateTrainingView(ITrainerView parentForm, Trainer trainer)
        {
            var form = _formsFactory.CreateTrainingView();
            form.LoadData(trainer, _teamRepository.GetAll());
            if (_trainerController.ShowCreateTraining(form, trainer, _trainingRepository, _teamRepository))
                parentForm.DisplayTrainingList(_trainingRepository.GetAll(), _teamRepository.GetAll());
            else
                parentForm.AlertFailedCreateTraining();
        }

        public void DeleteTraining(ITrainerView trainerForm, int trainingId, string teamName, string trainingTime)
        {
            var form = _formsFactory.DeleteTrainingView(teamName, trainingTime);
            if(_trainerController.DeleteTraining(form, _trainingRepository, _teamRepository, trainingId))
                trainerForm.DisplayTrainingList(_trainingRepository.GetAll(), _teamRepository.GetAll());
        }
    }
}
