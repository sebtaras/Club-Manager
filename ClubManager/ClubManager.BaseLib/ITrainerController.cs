using ClubManager.DAL_File;
using ClubManager.Models;
using ClubManager.Models.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClubManager.BaseLib
{
    public interface ITrainerController
    {
        void Homepage(ITrainerView form, IMainController inController, Trainer inTrainer, TrainerRepository trainerRepository, TrainingRepository trainingRepository, TeamRepository teamRepository, PlayerRepository playerRepository);
        bool ShowCreateTraining(ITrainerCreateTrainingView form, Trainer trainer, TrainingRepository trainingRepository, TeamRepository teamRepository);
        bool DeleteTraining(ITrainerDeleteTrainingView form, TrainingRepository trainingRepository, TeamRepository teamRepository, int trainingId);
        bool ShowTrainerSettings(ISettingsTrainerView form, Trainer trainer, ITrainerRepository trainerRepository, IAuthController authController);
    }
}
