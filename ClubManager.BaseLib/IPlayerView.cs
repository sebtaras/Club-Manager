using ClubManager.DAL_File;
using ClubManager.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClubManager.BaseLib
{
    public interface IPlayerView
    {
        bool ShowViewModaless(
            IMainController inController, 
            Player inPlayer, 
            IList<Transaction> inListTransactions, 
            IList<Training> inListTrainings, 
            List<Team> inListTeams, 
            List<Trainer> inListTrainers);
        void HideVerificationLabel();
        void DisplayTransactionList(IList<Transaction> inListTransactions);
        void DisplayTrainingList(IList<Training> trainings, List<Team> teams, List<Trainer> trainers);
    }
}
