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
        void Homepage(IAdminView form, IMainController inController, Admin admin, PlayerRepository playerRepository, TrainerRepository trainerRepository, TeamRepository teamRepository, TransactionRepository transactionRepository);
        void VerifyPlayer(IVerifyUserView form, Player player, PlayerRepository playerRepository);
        void VerifyTrainer(IVerifyUserView form, Trainer trainer, TrainerRepository trainerRepository);
        void RefreshRegisterRequestsList(PlayerRepository playerRepository, TrainerRepository trainerRepository);
        void RefreshPlayerList(PlayerRepository playerRepository, TeamRepository teamRepository);
        void RefreshTrainerList(TrainerRepository trainerRepository, TeamRepository teamRepository);
        void RefreshTeamList(TeamRepository teamRepository);
        void ShowPlayerOptions(IAdminPlayerOptionsView form, Player player, PlayerRepository playerRepository, TeamRepository teamRepository);
        void ShowTrainerOptions(IAdminTrainerOptionsView form, Trainer trainer, TrainerRepository trainerRepository, TeamRepository teamRepository);
        void ShowTeam(IAdminShowTeamView form);
        void CreateTransactionsView(IAdminCreateTransactionsView form, PlayerRepository playerRepository, TransactionRepository transactionRepository);
        void AdminTransactionOptions(IAdminTransactionOptionsView from, Player p, Transaction t, PlayerRepository playerRepository, TransactionRepository transactionRepository);
        bool ShowAdminSettings(ISettingsAdminView form, Admin admin, IAdminRepository adminRepository, IAuthController authController);
    }
}
