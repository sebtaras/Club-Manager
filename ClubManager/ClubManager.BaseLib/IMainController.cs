
using ClubManager.DAL_File;
using ClubManager.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClubManager.BaseLib
{
    public interface IMainController
    {
        bool LogInUser(string email, string password);
        void LogOut();
        void SwitchToLogin(IRegisterView form);
        void SwitchToRegister(ILogInView form);
        void ShowAgeInput(IRegisterView form);
        void HideAgeInput(IRegisterView form);
        bool RegisterUser(string email, string password, string firstName, string lastName, string role, string age);
        void ShowVerifyUserForm(Player p, Trainer t);
        void ShowPlayerInfo(Player p);
        void ShowTrainerInfo(Trainer t);
        void ShowTeamInfo(Team t);
        void CreateTransactionsView(PlayerRepository playerRepository, TransactionRepository transactionRepository);
        bool ShowPlayerSettings(Player player, PlayerRepository playerRepository);
        bool ShowTrainerSettings(Trainer trainer, TrainerRepository trainerRepository);
        bool CreateTrainingView(Trainer trainer);
    }
}
