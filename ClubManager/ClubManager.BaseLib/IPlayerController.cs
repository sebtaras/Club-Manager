using ClubManager.DAL_File;
using ClubManager.Models;
using ClubManager.Models.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClubManager.BaseLib
{
    public interface IPlayerController
    {
        void Homepage(IPlayerView form, IMainController inController, Player player, TransactionRepository transactionRepository, TrainerRepository trainerRepository, TrainingRepository trainingRepository, TeamRepository teamRepository);
        bool ShowPlayerSettings(ISettingsPlayerView form, Player player, IPlayerRepository playerRepository, IAuthController authController);
    }
}
