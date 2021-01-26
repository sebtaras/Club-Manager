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
        IAdminView form;
        internal void Homepage(IAdminView form, IMainController inController, PlayerRepository playerRepository, TrainerRepository trainerRepository, TeamRepository teamRepository)
        {
            this.form = form;
            form.ShowViewModaless(inController, playerRepository, trainerRepository, teamRepository);
        }

        internal void VerifyPlayer(IVerifyUserView form, Player player, PlayerRepository playerRepository)
        {
            if (form.ShowViewModal() == true)
            {
                playerRepository.Verify(player);
            }
        }

        internal void VerifyTrainer(IVerifyUserView form, Trainer trainer, TrainerRepository trainerRepository)
        {
            if (form.ShowViewModal() == true)
            {
                trainerRepository.Verify(trainer);   
            }
        }

        internal void RefreshRegisterRequestsList(PlayerRepository playerRepository, TrainerRepository trainerRepository)
        {
            form.DisplayRegisterRequests(playerRepository, trainerRepository);
        }
    }
}
