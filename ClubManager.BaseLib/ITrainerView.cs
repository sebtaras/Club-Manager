using ClubManager.DAL_File;
using ClubManager.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClubManager.BaseLib
{
    public interface ITrainerView
    {
        bool ShowViewModaless(IMainController inController, Trainer inTrainer);
        void DisplayTrainingList(IList<Training> trainings, List<Team> teams);
        void DisplayPlayerList(List<Player> players, List<Team> teams);
        void AlertFailedCreateTraining();
    }
}
