using ClubManager.BaseLib;
using ClubManager.DAL_File;
using ClubManager.Models;
using ClubManager.Models.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClubManager.Controllers
{
    public class MainController
    {
        private IWindowFormsFactory _formsFactory;
        private PlayerRepository _playerRepository;
        private TrainerRepository _trainerRepository;
        private AdminRepository _adminRepository;
        
        public MainController(IWindowFormsFactory formsFactory, PlayerRepository playerRepository, TrainerRepository trainerRepository, AdminRepository adminRepository)
        {
            _formsFactory = formsFactory;
            _playerRepository = playerRepository;
            _trainerRepository = trainerRepository;
            _adminRepository = adminRepository;
        }

        public void LoadDefaultModel()
        {
            _adminRepository.Add(new Admin(1, "admin", "admin", "admin@mail", "password"));
            _trainerRepository.Add(new Trainer(1, "gospon", "trener", "gt@mail", "password", true));
            _playerRepository.Add(new Player(1, "bob", "dasilva", "bd@mail", "password", 15, true));
            _playerRepository.Add(new Player(1, "marko", "perkovic", "mp@mail", "password", 15, true));
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
                        playerController.Homepage(form);
                        break; 
                    }
                    case "trainer": _formsFactory.TrainerView(); break;
                    case "admin": _formsFactory.AdminView(); break;
                    case "": loginSuccess = false; break;
                }
                return loginSuccess;       
            }
            return false;
        }
    }
}
