using ClubManager.DAL_File;
using ClubManager.Models;
using ClubManager.Models.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClubManager.BaseLib
{
    public interface IAdminController
    {
        void Homepage(IAdminView form, IMainController inController, Admin admin, IPlayerRepository playerRepository, ITrainerRepository trainerRepository, ITeamRepository teamRepository, ITransactionRepository transactionRepository);
        void VerifyPlayer(IVerifyUserView form, Player player, IPlayerRepository playerRepository, ITrainerRepository trainerRepository, ITeamRepository teamRepository);
        void VerifyTrainer(IVerifyUserView form, Trainer trainer, IPlayerRepository playerRepository, ITrainerRepository trainerRepository, ITeamRepository teamRepository);
        void ShowPlayerOptions(IAdminView parentForm, IAdminPlayerOptionsView form, Player player, IPlayerRepository playerRepository, ITeamRepository teamRepository, ITransactionRepository transactionRepository);
        void ShowTrainerOptions(IAdminView parentForm, IAdminTrainerOptionsView form, Trainer trainer, ITrainerRepository trainerRepository, ITeamRepository teamRepository);
        void ShowTeam(IAdminShowTeamView form);
        void CreateTransactionsView(IAdminCreateTransactionsView form, IPlayerRepository playerRepository, ITransactionRepository transactionRepository);
        void AdminTransactionOptions(IAdminPlayerOptionsView parentForm, IAdminTransactionOptionsView from, Player p, int transactionId);
        bool ShowAdminSettings(ISettingsAdminView form, Admin admin, IAdminRepository adminRepository, IAuthController authController);
    }
}
