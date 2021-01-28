using ClubManager.DAL_File;
using ClubManager.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClubManager.BaseLib
{
    public interface ITrainerController
    {
        void Homepage(ITrainerView form, IMainController inController, Trainer inTrainer, TrainerRepository trainerRepository, TrainingRepository trainingRepository, TeamRepository teamRepository, PlayerRepository playerRepository);
        bool ShowCreateTraining(ITrainerCreateTrainingView form, Trainer trainer, TrainingRepository trainingRepository, TeamRepository teamRepository);
    }
}
