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
        public PlayerRepository _playerRepository;
        public TrainerRepository _trainerRepository;
        private AdminRepository _adminRepository;
        private TrainingRepository _trainingRepository;
        private TeamRepository _teamRepository;
        private IAdminController _adminController;
        private IPlayerController _playerController;
        private ITrainerController _trainerController;
        private TransactionRepository _transactionRepository;
        
        public MainController(IWindowFormsFactory formsFactory, 
            PlayerRepository playerRepository, 
            TrainerRepository trainerRepository, 
            AdminRepository adminRepository, 
            TrainingRepository trainingRepository,
            TeamRepository teamRepository,
            TransactionRepository transactionRepository)
        {
            _formsFactory = formsFactory;
            _playerRepository = playerRepository;
            _trainerRepository = trainerRepository;
            _adminRepository = adminRepository;
            _trainingRepository = trainingRepository;
            _teamRepository = teamRepository;
            _transactionRepository = transactionRepository;
            _adminController = new AdminController();
            _playerController = new PlayerController();
            _trainerController = new TrainerController();
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
            player_bd._transactionIds.Add(1);
            player_bd._transactionIds.Add(2);
            _playerRepository.Add(player_bd);
            _playerRepository.Add(player_mp);
            _playerRepository.Add(player_mz);
            _playerRepository.Add(player_poreg);
            _playerRepository.Add(player_mb);
            _playerRepository.Add(player_it);


            Trainer trainer1 = new Trainer(1, "gospon", "trener", "gt@mail", "password", true);
            Trainer trainer2 = new Trainer(1, "brkonja", "bradic", "bb@mail", "password", true);
            Trainer trainer3 = new Trainer(1, "drugi", "trener", "dt@mail", "password", false);
            trainer1._teamIds.Add(1);
            _trainerRepository.Add(trainer1);
            _trainerRepository.Add(trainer2);
            _trainerRepository.Add(trainer3);

            Team zagici = new Team(1, "Zagici", 6, 7);
            Team limaci = new Team(1, "Limaci", 8, 10);
            Team mladiPioniri = new Team(1, "Mladi Pioniri", 11, 12);
            Team pioniri = new Team(1, "Pioniri", 13, 15);
            Team juniori = new Team(1, "Juniori", 16, 18);
            Team seniori = new Team(1, "Seniori", 19, 30);
            _teamRepository.Add(zagici);
            _teamRepository.Add(limaci);
            _teamRepository.Add(mladiPioniri);
            _teamRepository.Add(pioniri);
            _teamRepository.Add(juniori);
            _teamRepository.Add(seniori);

        }

        public bool RegisterUser(string email, string password, string firstName, string lastName, string role, string age)
        {
            var authController = new AuthController();
            if(authController.VerifyRegisterInput(email, password, firstName, lastName, role, age, _playerRepository, _trainerRepository))
                return true;
            return false;
        }

        public bool LogInUser(string email, string password)
        {
            var authController = new AuthController();

            if (authController.VerifyLoginInput(email, password))
            {
                bool loginSuccess = true;
                switch (authController.LogInUser(email, password, _playerRepository, _trainerRepository, _adminRepository))
                {
                    case "player":
                        {
                            var form = _formsFactory.PlayerView();
                            _playerController.Homepage(form, this, _playerRepository.GetPlayerByEmail(email), _transactionRepository, _trainingRepository, _playerRepository);
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
                            _adminController.Homepage(form, this, _playerRepository, _trainerRepository, _teamRepository, _transactionRepository);
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

        public void ShowVerifyUserForm(Player p, Trainer t)
        {
            var form = _formsFactory.VerifyUserView(p, t);
            if (p != null)
            {
                _adminController.VerifyPlayer(form, p, _playerRepository);
            }
            else
            {
                _adminController.VerifyTrainer(form, t, _trainerRepository);
            }
            _adminController.RefreshTrainerList(_trainerRepository, _teamRepository);
            _adminController.RefreshRegisterRequestsList(_playerRepository, _trainerRepository);
        }

        public void ShowPlayerInfo(Player p)
        {
            var form = _formsFactory.AdminPlayerOptionsView(p, _formsFactory, _adminController, _playerRepository, _teamRepository, _transactionRepository);
            _adminController.ShowPlayerOptions(form, p, _playerRepository ,_teamRepository);

            _adminController.RefreshPlayerList(_playerRepository, _teamRepository);
            _adminController.RefreshTeamList(_teamRepository);
        }

        public void ShowTrainerInfo(Trainer t)
        {
            var form = _formsFactory.AdminTrainerOptionsView(t, _teamRepository);
            _adminController.ShowTrainerOptions(form, t, _trainerRepository, _teamRepository);

            _adminController.RefreshTrainerList(_trainerRepository, _teamRepository);
            _adminController.RefreshTeamList(_teamRepository);
        }

        public void ShowTeamInfo(Team t)
        {
            var form = _formsFactory.AdminTeamView(t, _playerRepository, _trainerRepository);
            _adminController.ShowTeam(form);
        }

        public void CreateTransactionsView(PlayerRepository playerRepository, TransactionRepository transactionRepository)
        {
            var form = _formsFactory.CreateTransactionsView();
            _adminController.CreateTransactionsView(form, playerRepository, transactionRepository);
        }

        public bool ShowPlayerSettings(Player player, PlayerRepository playerRepository)
        {
            var form = _formsFactory.PlayerSettingsView(player, playerRepository);
            return _playerController.ShowPlayerSettings(form, player, playerRepository);
        }

        public bool CreateTrainingView(Trainer trainer)
        {
            var form = _formsFactory.CreateTrainingView(trainer, _trainingRepository, _teamRepository);
            if (_trainerController.ShowCreateTraining(form, trainer, _trainingRepository, _teamRepository))
                return true;
            return false;
        }

        public bool ShowTrainerSettings(Trainer trainer, TrainerRepository trainerRepository)
        {
            throw new NotImplementedException();
        }
    }
}
