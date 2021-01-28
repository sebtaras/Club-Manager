﻿using ClubManager.DAL_File;
using ClubManager.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClubManager.BaseLib
{
    public interface IPlayerView
    {
        bool ShowViewModaless(IMainController inController, Player inPlayer, TransactionRepository transactionRepository, TrainingRepository trainingRepository, PlayerRepository playerRepository);
        void HideVerificationLabel();
        void DisplayTransactionList(TransactionRepository transactionRepository);
        void DisplayTrainingList(TrainingRepository trainingRepository);
    }
}
