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
        private PlayerRepository _playerRepository;
        private TrainerRepository _trainerRepository;
        private AdminRepository _adminRepository;
        private ITrainingRepository _trainingRepository;
        private ITeamRepository _teamRepository;
        
        public MainController(IWindowFormsFactory formsFactory, 
            PlayerRepository playerRepository, 
            TrainerRepository trainerRepository, 
            AdminRepository adminRepository, 
            ITrainingRepository trainingRepository,
            ITeamRepository teamRepository)
        {
            _formsFactory = formsFactory;
            _playerRepository = playerRepository;
            _trainerRepository = trainerRepository;
            _adminRepository = adminRepository;
            _trainingRepository = trainingRepository;
            _teamRepository = teamRepository;
        }

        public void LoadDefaultModel()
        {
            _adminRepository.Add(new Admin(1, "admin", "admin", "admin@mail", "password"));
            Trainer trainerPionir = new Trainer(1, "gospon", "trener", "gt@mail", "password", true);
            _trainerRepository.Add(trainerPionir);

            Player player_bd = new Player(1, "bob", "dasilva", "bd@mail", "password", 15, true);
            Player player_mp = new Player(1, "marko", "perkovic", "mp@mail", "password", 15, true);
            Player player_mz = new Player(1, "mali", "zugec", "mz@mail", "password", 6, false);
            _playerRepository.Add(player_bd);
            _playerRepository.Add(player_mp);
            _playerRepository.Add(player_mz);

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
                            playerController.Homepage(form, this);
                            break;
                        }
                    case "trainer":
                        {
                            var form = _formsFactory.TrainerView();
                            var trainerController = new TrainerController();
                            trainerController.Homepage(form, this);
                            break;
                        }
                    case "admin":
                        {
                            var form = _formsFactory.AdminView();
                            var adminController = new AdminController();
                            adminController.Homepage(form, this);
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

        
    }
}
