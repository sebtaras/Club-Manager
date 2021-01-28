using ClubManager.DAL_File;
using ClubManager.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClubManager.BaseLib
{
    public interface IPlayerController
    {
        void Homepage(IPlayerView form, IMainController inController, Player player, TransactionRepository transactionRepository, TrainingRepository trainingRepository, PlayerRepository playerRepository);
        bool ShowPlayerSettings(IPlayerSettingsView form, Player player, PlayerRepository playerRepository);
    }
}
