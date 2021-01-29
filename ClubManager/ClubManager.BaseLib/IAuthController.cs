using ClubManager.DAL_File;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClubManager.BaseLib
{
    public interface IAuthController
    {
        string LogInUser(string email, string password, PlayerRepository playerRepository, TrainerRepository trainerRepository, AdminRepository adminRepository);
        bool RegisterPlayer(string email, string password, string firstName, string lastName, string age, PlayerRepository playerRepository, TrainerRepository trainerRepository);
        bool RegisterTrainer(string email, string password, string firstName, string lastName, TrainerRepository trainerRepository, PlayerRepository playerRepository);
        bool VerifyUpdateUserInput(string email, string passwordCurrent, string passwordNew);
        bool VerifyRegisterInput(string email, string password, string firstName, string lastName, string role, string age, PlayerRepository playerRepository, TrainerRepository trainerRepository);
        bool VerifyLoginInput(string email, string password);
    }
}
