﻿using ClubManager.BaseLib;
using ClubManager.DAL_File;
using ClubManager.Models;
using ClubManager.Models.Repositories;
using System;

namespace ClubManager.Contrllers
{
    public class AuthController : IAuthController
    {
        public string LogInUser(string email, string password, IPlayerRepository playerRepository, ITrainerRepository trainerRepository, IAdminRepository adminRepository)
        {
            foreach(Player p in playerRepository.GetAll())
            {
                if (p.Email == email && p.Password == password)
                    return "player";
            }
            foreach(Trainer t in trainerRepository.GetAll())
            {
                if (t.Email == email && t.Password == password)
                    return "trainer";
            }
            foreach(Admin a in adminRepository.GetAll())
            {
                if (a.Email == email && a.Password == password)
                    return "admin";
            }
            return "";
        }

        public bool VerifyLoginInput(string email, string password)
        {
            if (!ValidationFunctions.IsValidEmail(email) || password.Length < 6)
                return false;
            return true;
        }

        public bool VerifyRegisterInput(string email, string password, string firstName, string lastName, string role, string age, IPlayerRepository playerRepository, ITrainerRepository trainerRepository)
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

            switch (role)
            {
                case "Player":
                    {
                        if (RegisterPlayer(email, password, firstName, lastName, age, playerRepository, trainerRepository))
                            return true;
                        return false;
                    }
                case "Trainer":
                    {
                        if (RegisterTrainer(email, password, firstName, lastName, trainerRepository, playerRepository))
                            return true;
                        return false;
                    }
                case "": return false;
            }
            return false;
        }

        public bool VerifyUpdateUserInput(string email, string passwordCurrent, string passwordNew)
        {
            if (!ValidationFunctions.IsValidEmail(email))
                return false;
            if (!ValidationFunctions.IsValidPassword(passwordCurrent))
                return false;
            if (!ValidationFunctions.IsValidPassword(passwordNew))
                return false;
            return true;
        }

        public bool RegisterTrainer(string email, string password, string firstName, string lastName, ITrainerRepository trainerRepository, IPlayerRepository playerRepository)
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

        public bool RegisterPlayer(string email, string password, string firstName, string lastName, string age, IPlayerRepository playerRepository, ITrainerRepository trainerRepository)
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
