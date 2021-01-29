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
        IAdminPlayerOptionsView AdminPlayerOptionsView(Player p, IWindowFormsFactory windowFormsFactory, IAdminController adminController, PlayerRepository playerRepository, TeamRepository teamRepository, TransactionRepository transactionRepository);
        IAdminTrainerOptionsView AdminTrainerOptionsView();
        IAdminShowTeamView AdminTeamView();
        IAdminCreateTransactionsView CreateTransactionsView();
        IAdminTransactionOptionsView AdminTransactionOptions(Player p, Transaction t);
        ISettingsPlayerView PlayerSettingsView(Player player);
        ISettingsAdminView AdminSettingsView(Admin admin);
        ISettingsTrainerView TrainerSettingsView(Trainer trainer);
        ITrainerCreateTrainingView CreateTrainingView(Trainer t, TrainingRepository trainingRepository, TeamRepository teamRepository);
        ITrainerDeleteTrainingView DeleteTrainingView(string teamName, string trainingTime);
    }
}
