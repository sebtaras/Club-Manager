using ClubManager.DAL_File;
using ClubManager.Models.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClubManager.BaseLib
{
    public interface IAuthController
    {
        string LogInUser(string email, string password, IPlayerRepository playerRepository, ITrainerRepository trainerRepository, IAdminRepository adminRepository);
        bool RegisterPlayer(string email, string password, string firstName, string lastName, string age, IPlayerRepository playerRepository, ITrainerRepository trainerRepository);
        bool RegisterTrainer(string email, string password, string firstName, string lastName, ITrainerRepository trainerRepository, IPlayerRepository playerRepository);
        bool VerifyUpdateUserInput(string email, string passwordCurrent, string passwordNew);
        bool VerifyRegisterInput(string email, string password, string firstName, string lastName, string role, string age, IPlayerRepository playerRepository, ITrainerRepository trainerRepository);
        bool VerifyLoginInput(string email, string password);
    }
}
