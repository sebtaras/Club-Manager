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
        bool ShowViewModaless(IMainController inController, Admin inAdmin, List<Player> players, List<Trainer> trainers, List<Team> teams, List<Transaction> transactions);
        void DisplayRegisterRequests(List<Player> players, List<Trainer> trainers);
        void DisplayTrainerList(List<Trainer> trainers, List<Team> teams);
        void DisplayPlayerList(List<Player> players, List<Team> teams);
        void DisplayTeamList(List<Team> teams);
    }
}
