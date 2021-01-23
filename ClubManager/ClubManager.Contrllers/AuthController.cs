using ClubManager.BaseLib;
using ClubManager.DAL_File;
using ClubManager.Models;
using ClubManager.Models.Repositories;
using System;

namespace ClubManager.Contrllers
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

        internal bool VerifyRegisterInput(string email, string password, string firstName, string lastName, string role, string age, PlayerRepository playerRepository, TrainerRepository trainerRepository)
        {
            if (!ValidationFunctions.IsValidEmail(email))
                return false;
            if (!ValidationFunctions.IsValidPassword(password))
                return false;
            if (!ValidationFunctions.IsValidName(new string[] { firstName, lastName }))
                return false;
            if (role == "Player" && !ValidationFunctions.IsValidAge(age))
                return false;
            if (role == "")
                return false;

            switch (role) {

                case "Player":
                    {
                        if(RegisterPlayer(email, password, firstName, lastName, age, playerRepository, trainerRepository))
                            return true;
                        return false;
                    }
                case "Trainer":
                    {
                        if(RegisterTrainer(email, password, firstName, lastName, trainerRepository, playerRepository))
                            return true;
                        return false;
                    }
                case "": return false;
            }
            return false;
            }

        private bool RegisterTrainer(string email, string password, string firstName, string lastName, TrainerRepository trainerRepository, PlayerRepository playerRepository)
        {
            Trainer newTrainer = new Trainer(1, firstName, lastName, email, password, false);
            Player checkEmailInUse = new Player(1, firstName, lastName, email, password, 20, false);
            if (!trainerRepository.CheckTrainerExists(newTrainer) && !playerRepository.CheckPlayerExists(checkEmailInUse))
            {
                trainerRepository.Add(newTrainer);
                return true;
            }
            return false;
        }

        private bool RegisterPlayer(string email, string password, string firstName, string lastName, string age, PlayerRepository playerRepository, TrainerRepository trainerRepository)
        {
            Player newPlayer = new Player(1, firstName, lastName, email, password, int.Parse(age), false);
            Trainer checkEmailInUse = new Trainer(1, firstName, lastName, email, password, false);
            if (!playerRepository.CheckPlayerExists(newPlayer) && !trainerRepository.CheckTrainerExists(checkEmailInUse))
            {
                playerRepository.Add(newPlayer);
                return true;
            }
            return false;
        }
    }
}
