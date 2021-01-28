using ClubManager.BaseLib;
using ClubManager.DAL_File;
using ClubManager.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace ClubManager.Contrllers
{
    public class PlayerController : IPlayerController
    {
        public void Homepage(IPlayerView form, IMainController inController, Player player, TransactionRepository transactionRepository, TrainingRepository trainingRepository, PlayerRepository playerRepository)
        {
            form.ShowViewModaless(inController, player, transactionRepository, trainingRepository, playerRepository);
        }

        public bool ShowPlayerSettings(IPlayerSettingsView form, Player player, PlayerRepository playerRepository)
        {
            var result = form.ShowViewModal();
            if (result == DialogResult.OK)
            {
                if (VerifyPlayerInput(form.Email, form.PasswordCurrent, form.PasswordNew, playerRepository))
                    return playerRepository.UpdatePlayerValues(player, form.Email, form.PasswordCurrent, form.PasswordNew);
                else
                    return false;
            }
            return true;
        }

        private bool VerifyPlayerInput(string email, string passwordCurrent, string passwordNew, PlayerRepository playerRepository)
        {
            if (!ValidationFunctions.IsValidEmail(email))
                return false;
            if (!ValidationFunctions.IsValidPassword(passwordCurrent))
                return false;
            if (!ValidationFunctions.IsValidPassword(passwordNew))
                return false;
            return true;
        }
    }
}
