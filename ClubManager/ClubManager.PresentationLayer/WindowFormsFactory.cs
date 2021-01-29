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
            return new FormLogIn();
        }

        public IRegisterView RegisterView()
        {
            return new FormRegister();
        }

        public IAdminView AdminView()
        {
            return new FormUIAdmin();
        }

        public IPlayerView PlayerView()
        {
            return new FormUIPlayer();
        }

        public ITrainerView TrainerView()
        {
            return new FormUITrainer();
        }

        public IVerifyUserView VerifyUserView()
        {
            return new FormVerifyUser();
        }


        public IAdminPlayerOptionsView AdminPlayerOptionsView(Player inPlayer, IWindowFormsFactory windowFormsFactory, IAdminController inAdminController)
        {
            return new FormAdminPlayerOptions(inPlayer, windowFormsFactory, inAdminController);
        }

        public IAdminTrainerOptionsView AdminTrainerOptionsView()
        {
            return new FormAdminTrainerOptions();
        }
        
        public IAdminShowTeamView AdminTeamView()
        {
            return new FormAdminShowTeam();
        }

        public IAdminCreateTransactionsView CreateTransactionsView()
        {
            return new FormAdminCreateTransactions();
        }

        public IAdminTransactionOptionsView AdminTransactionOptions()
        {
            return new FormAdminTransactionOptions();
        }

        public ISettingsPlayerView PlayerSettingsView(Player player)
        {
            return new FormSettingsPlayer(player);
        }

        public ISettingsAdminView AdminSettingsView(Admin admin)
        {
            return new FormSettingsAdmin(admin);
        }

        public ISettingsTrainerView TrainerSettingsView(Trainer trainer)
        {
            return new FormSettingsTrainer(trainer);
        }

        public ITrainerCreateTrainingView CreateTrainingView()
        {
            return new FormTrainerCreateTraining();
        }

        public ITrainerDeleteTrainingView DeleteTrainingView(string teamName, string trainingTime)
        {
            return new FormTrainerDeleteTraining(teamName, trainingTime);
        }

    }
}
