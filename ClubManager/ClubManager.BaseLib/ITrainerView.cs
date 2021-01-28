using ClubManager.DAL_File;
using ClubManager.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClubManager.BaseLib
{
    public interface ITrainerView
    {
        bool ShowViewModaless(IMainController inMainController, Trainer trainer, TeamRepository teamRepository, TrainingRepository trainingRepository, PlayerRepository inPlayerRepository);
    }
}
