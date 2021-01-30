
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
        void ShowVerifyPlayerForm(int playerId);
        void ShowVerifyTrainerForm(int trainerId);
        void ShowPlayerInfo(IAdminView form, int playerId);
        void ShowTrainerInfo(IAdminView form, int trainerId);
        void ShowTeamInfo(IAdminView form, int teamId);
        void CreateTransactionsView();
        bool ShowPlayerSettings(int playerId);
        bool ShowTrainerSettings(int trainerId);
        bool ShowAdminSettings(int adminId);
        void CreateTrainingView(ITrainerView form, Trainer trainer);
        void DeleteTraining(ITrainerView form, int trainingId, string teamName, string trainingTime);
    }
}
