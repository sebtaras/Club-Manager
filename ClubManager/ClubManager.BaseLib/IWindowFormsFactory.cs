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
        IVerifyUserView VerifyUserView(Player p, Trainer t);
        IAdminPlayerOptionsView AdminPlayerOptionsView(Player p, TeamRepository teamRepository, TransactionRepository transactionRepository);
        IAdminTrainerOptionsView AdminTrainerOptionsView(Trainer t, TeamRepository teamRepository);
        IAdminShowTeamView AdminTeamView(Team t, PlayerRepository playerRepository, TrainerRepository trainerRepository);
        IAdminCreateTransactionsView CreateTransactionsView();
    }
}
