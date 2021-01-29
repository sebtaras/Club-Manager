using ClubManager.DAL_File;
using ClubManager.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClubManager.BaseLib
{
    public interface IPlayerView
    {
        //bool ShowViewModaless(IMainController inController, Player inPlayer, TransactionRepository transactionRepository, TrainingRepository trainingRepository, PlayerRepository playerRepository);
        bool ShowViewModaless(
            IMainController inController, 
            Player inPlayer, 
            List<Transaction> inListTransactions, 
            List<Training> inListTrainings, 
            List<Team> inListTeams, 
            List<Trainer> inListTrainers);
        void HideVerificationLabel();
        void DisplayTransactionList(List<Transaction> inListTransactions);
        void DisplayTrainingList(List<Training> trainings, List<Team> teams, List<Trainer> trainers);
    }
}
