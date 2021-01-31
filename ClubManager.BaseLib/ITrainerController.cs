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
        void Homepage(ITrainerView form, IMainController inController, Trainer inTrainer, ITrainerRepository trainerRepository, ITrainingRepository trainingRepository, ITeamRepository teamRepository, IPlayerRepository playerRepository);
        bool ShowCreateTraining(ITrainerCreateTrainingView form, Trainer trainer, ITrainingRepository trainingRepository, ITeamRepository teamRepository);
        bool DeleteTraining(ITrainerDeleteTrainingView form, ITrainingRepository trainingRepository, ITeamRepository teamRepository, Training training);
        bool ShowTrainerSettings(ISettingsTrainerView form, Trainer trainer, ITrainerRepository trainerRepository, IAuthController authController);
    }
}
