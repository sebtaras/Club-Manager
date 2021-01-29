using ClubManager.BaseLib;
using ClubManager.Contrllers;
using ClubManager.DAL_File;
using ClubManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubManager.PresentationLayer
{
    public class WindowFormsFactory : IWindowFormsFactory
    {
        public ILogInView LoginView()
        {
            return new formLogIn();
        }

        public IRegisterView RegisterView()
        {
            return new formRegister();
        }

        public IAdminView AdminView()
        {
            return new formUIAdmin();
        }

        public IPlayerView PlayerView()
        {
            return new formUIPlayer();
        }

        public ITrainerView TrainerView()
        {
            return new formUITrainer();
        }

        public IVerifyUserView VerifyUserView(Player p, Trainer t)
        {
            return new formVerifyUser(p, t);
        }

        public IAdminPlayerOptionsView AdminPlayerOptionsView(Player p, IWindowFormsFactory windowFormsFactory, IAdminController adminController, PlayerRepository playerRepository, TeamRepository teamRepository, TransactionRepository transactionRepository)
        {
            return new formAdminPlayerOptions(p, windowFormsFactory, adminController, playerRepository, teamRepository, transactionRepository);
        }

        public IAdminTrainerOptionsView AdminTrainerOptionsView(Trainer t, TeamRepository teamRepository)
        {
            return new formAdminTrainerOptions(t, teamRepository);
        }
        
        public IAdminShowTeamView AdminTeamView(Team team, PlayerRepository playerRepository, TrainerRepository trainerRepository)
        {
            return new formAdminShowTeam(team, playerRepository, trainerRepository);
        }

        public IAdminCreateTransactionsView CreateTransactionsView()
        {
            return new formAdminCreateTransactions();
        }

        public IAdminTransactionOptionsView AdminTransactionOptions(Player p, Transaction t)
        {
            return new formAdminTransactionOptions(p, t);
        }

        public ISettingsPlayerView PlayerSettingsView(Player player)
        {
            return new formSettingsPlayer(player);
        }

        public ISettingsAdminView AdminSettingsView(Admin admin)
        {
            return new formSettingsAdmin(admin);
        }

        public ISettingsTrainerView TrainerSettingsView(Trainer trainer)
        {
            return new formSettingsTrainer(trainer);
        }

        public ITrainerCreateTrainingView CreateTrainingView(Trainer t, TrainingRepository trainingRepository, TeamRepository teamRepository)
        {
            return new formTrainerCreateTraining(t, trainingRepository, teamRepository);
        }

        public ITrainerDeleteTrainingView DeleteTrainingView(string teamName, string trainingTime)
        {
            return new formTrainerDeleteTraining(teamName, trainingTime);
        }


    }
}
