using ClubManager.BaseLib;
using ClubManager.DAL_File;
using ClubManager.Models;
using ClubManager.Models.Repositories;
using System;

namespace ClubManager.Controllers
{
    public class AuthController
    {
        public string LogInUser(string email, string password, PlayerRepository playerRepository, TrainerRepository trainerRepository, AdminRepository adminRepository)
        {
            foreach(Player p in playerRepository._listPlayers)
            {
                if (p.Email == email && p.Password == password)
                    return "player";
            }
            foreach(Trainer t in trainerRepository._listTrainers)
            {
                if (t.Email == email && t.Password == password)
                    return "trainer";
            }
            foreach(Admin a in adminRepository._listAdmins)
            {
                if (a.Email == email && a.Password == password)
                    return "admin";
            }
            return "";
        }

        internal bool VerifyLoginInput(string email, string password)
        {
            if (!ValidationFunctions.IsValidEmail(email) || password.Length < 6)
                return false;
            return true;
        }
    }
}
