using ClubManager.BaseLib;
using ClubManager.DAL_File;
using ClubManager.Models;
using ClubManager.Models.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClubManager.Contrllers
{
    class AdminController
    {
        internal void Homepage(IAdminView form, IMainController inController, PlayerRepository playerRepository, TrainerRepository trainerRepository, TeamRepository teamRepository)
        {
            form.ShowViewModaless(inController, playerRepository, trainerRepository, teamRepository);
        }
    }
}
