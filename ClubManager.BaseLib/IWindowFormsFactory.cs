using ClubManager.DAL_File;
using ClubManager.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClubManager.BaseLib
{
    public interface IWindowFormsFactory
    {
        ILogInView LoginView();
        IRegisterView RegisterView();
        IPlayerView PlayerView();
        ITrainerView TrainerView();
        IAdminView AdminView();
        IVerifyUserView VerifyUserView();
        IAdminPlayerOptionsView AdminPlayerOptionsView(Player inPlayer, IWindowFormsFactory windowFormsFactory, IAdminController inAdminController);
        IAdminTrainerOptionsView AdminTrainerOptionsView();
        IAdminShowTeamView AdminTeamView();
        IAdminCreateTransactionsView CreateTransactionsView();
        IAdminTransactionOptionsView AdminTransactionOptions();
        ISettingsPlayerView PlayerSettingsView(Player player);
        ISettingsAdminView AdminSettingsView(Admin admin);
        ISettingsTrainerView TrainerSettingsView(Trainer trainer);
        ITrainerCreateTrainingView CreateTrainingView();
        ITrainerDeleteTrainingView DeleteTrainingView(string teamName, string trainingTime);
    }
}
