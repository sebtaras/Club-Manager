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
    public class PlayerController : IPlayerController
    {
        public void Homepage(IPlayerView form, IMainController inController, Player player, ITransactionRepository transactionRepository, ITrainerRepository trainerRepository, ITrainingRepository trainingRepository, ITeamRepository teamRepository)
        {
            ITransactionRepository transRep = transactionRepository;
            ITrainingRepository trainRep = trainingRepository;
            ITeamRepository teamRep = teamRepository;
            ITrainerRepository trainerRep = trainerRepository;
            form.ShowViewModaless(inController, player, transRep.GetAll(), trainRep.GetAll(), teamRep.GetAll(), trainerRep.GetAll());
        }

        public bool ShowPlayerSettings(ISettingsPlayerView form, Player player, IPlayerRepository playerRepository, IAuthController authController)
        {
            var result = form.ShowViewModal();
            if (result == DialogResult.OK)
            {
                if (authController.VerifyUpdateUserInput(form.Email, form.PasswordCurrent, form.PasswordNew))
                    return playerRepository.UpdatePlayerValues(player.Id, form.Email, form.PasswordCurrent, form.PasswordNew);
                else
                    return false;
            }
            return true;
        }
    }
}
