using ClubManager.DAL_File;
using ClubManager.Models;
using ClubManager.Models.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClubManager.BaseLib
{
    public interface IAdminView
    {
        bool ShowViewModaless(IMainController inController, PlayerRepository playerRepository, TrainerRepository trainerRepository, TeamRepository teamRepository, TransactionRepository transactionRepository);
        void DisplayRegisterRequests(PlayerRepository inPlayerRepository, TrainerRepository inTrainerRepository);
        void DisplayTrainerList(TrainerRepository trainerRepository, TeamRepository teamRepository);
        void DisplayPlayerList(PlayerRepository playerRepository, TeamRepository teamRepository);
        void DisplayTeamList(TeamRepository teamRepository);
    }
}
