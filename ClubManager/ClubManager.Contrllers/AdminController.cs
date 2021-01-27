using ClubManager.BaseLib;
using ClubManager.DAL_File;
using ClubManager.Models;
using ClubManager.Models.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

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
            var result = form.ShowViewModal();
            if (result == DialogResult.OK)
            {
                playerRepository.Verify(player);
            }
            else if (result == DialogResult.No)
            {
                playerRepository.Delete(player);
            }
        }

        internal void VerifyTrainer(IVerifyUserView form, Trainer trainer, TrainerRepository trainerRepository)
        {
            var result = form.ShowViewModal();
            if (result == DialogResult.OK)
            {
                trainerRepository.Verify(trainer);
            }
            else if (result == DialogResult.No)
            {
                trainerRepository.Delete(trainer);
            }
        }

        internal void RefreshRegisterRequestsList(PlayerRepository playerRepository, TrainerRepository trainerRepository)
        {
            form.DisplayRegisterRequests(playerRepository, trainerRepository);
        }

        internal void RefreshPlayerList(PlayerRepository playerRepository)
        {
            form.DisplayPlayerList(playerRepository);
        }

        internal void RefreshTrainerList(TrainerRepository trainerRepository)
        {
            form.DisplayTrainerList(trainerRepository);
        }
        internal void RefreshTeamList(TeamRepository teamRepository)
        {
            form.DisplayTeamList(teamRepository);
        }

        internal void ShowPlayerOptions(IAdminPlayerOptionsView form, Player player, PlayerRepository playerRepository, TeamRepository teamRepository)
        {
            var result = form.ShowViewModal();
            if (result == DialogResult.Yes)
            {
                teamRepository.AddPlayerToTeam(player, playerRepository);
            }
            else if (result == DialogResult.No)
            {
                teamRepository.RemovePlayerFromTeam(player, playerRepository);
            }
            else if (result == DialogResult.Abort)
            {
                teamRepository.DeletePlayer(player, playerRepository);
            }
        }

        internal void ShowTrainerOptions(IAdminTrainerOptionsView form, Trainer trainer, TrainerRepository trainerRepository, TeamRepository teamRepository)
        {
            var result = form.ShowViewModal();
            if (result == DialogResult.Yes)
            {
                teamRepository.AddTrainerToTeam(trainer, trainerRepository);
            }
            else if (result == DialogResult.No)
            {
                teamRepository.RemoveTrainerFromTeam(trainer, trainerRepository);
            }
            else if (result == DialogResult.Abort)
            {
                teamRepository.DeleteTrainer(trainer, trainerRepository);
            }
        }
    }
}
