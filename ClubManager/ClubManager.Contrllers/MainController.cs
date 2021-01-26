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
        private AdminController _adminController;
        
        public MainController(IWindowFormsFactory formsFactory, 
            PlayerRepository playerRepository, 
            TrainerRepository trainerRepository, 
            AdminRepository adminRepository, 
            TrainingRepository trainingRepository,
            TeamRepository teamRepository)
        {
            _formsFactory = formsFactory;
            _playerRepository = playerRepository;
            _trainerRepository = trainerRepository;
            _adminRepository = adminRepository;
            _trainingRepository = trainingRepository;
            _teamRepository = teamRepository;
            _adminController = new AdminController();
        }

        public void LoadDefaultModel()
        {
            _adminRepository.Add(new Admin(1, "admin", "admin", "admin@mail", "password"));

            Trainer trainerPionir = new Trainer(1, "gospon", "trener", "gt@mail", "password", false);
            _trainerRepository.Add(trainerPionir);

            Player player_bd = new Player(1, "bob", "dasilva", "bd@mail", "password", 15, true);
            Player player_mp = new Player(1, "marko", "perkovic", "mp@mail", "password", 15, true);
            Player player_mz = new Player(1, "mali", "zugec", "mz@mail", "password", 6, false);
            _playerRepository.Add(player_bd);
            _playerRepository.Add(player_mp);
            _playerRepository.Add(player_mz);

            DateTime time = DateTime.Now;
            Transaction bd_t1 = new Transaction(1, (decimal)200.00, time);
            Transaction bd_t2 = new Transaction(2, (decimal)200.00, time.AddDays(31));
            player_bd.transactions.Add(bd_t1);
            player_bd.transactions.Add(bd_t2);

            List<Player> playersPionir = new List<Player>() { player_bd, player_mp };
            Team teamPioniri = new Team(1, "Pioniri", 13, 15, trainerPionir, playersPionir);
            _teamRepository.Add(teamPioniri);

            
            
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
                            var playerController = new PlayerController();
                            playerController.Homepage(form, this, _playerRepository.GetPlayerByEmail(email));
                            break;
                        }
                    case "trainer":
                        {
                            var form = _formsFactory.TrainerView();
                            var trainerController = new TrainerController();
                            trainerController.Homepage(form, this, _trainerRepository.GetTrainerByEmail(email));
                            break;
                        }
                    case "admin":
                        {
                            var form = _formsFactory.AdminView();
                            //var adminController = new AdminController();
                            _adminController.Homepage(form, this, _playerRepository, _trainerRepository, _teamRepository);
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
            //var adminController = new AdminController();
            var form = _formsFactory.VerifyUserView(p, t);
            if (p != null) _adminController.VerifyPlayer(form, p, _playerRepository);
            else _adminController.VerifyTrainer(form, t, _trainerRepository);

            _adminController.RefreshRegisterRequestsList(_playerRepository, _trainerRepository);
        }
    }
}
