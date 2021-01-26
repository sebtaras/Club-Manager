using ClubManager.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClubManager.BaseLib
{
    public interface IPlayerView
    {
        bool ShowViewModaless(IMainController inMainController, Player player);
        void HideVerificationLabel();
        void DisplayTransactionList(List<Transaction> transactions);
        void DisplayTrainingList(List<Training> trainings);
    }
}
