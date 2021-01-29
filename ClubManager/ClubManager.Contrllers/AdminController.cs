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
    public class AdminController : IAdminController
    {
        IAdminView form;
        private decimal MEMBERSHIP_FEE = (decimal)200.00;
        public void Homepage(IAdminView form, IMainController inController, Admin admin, PlayerRepository playerRepository, TrainerRepository trainerRepository, TeamRepository teamRepository, TransactionRepository transactionRepository)
        {
            this.form = form;
            form.ShowViewModaless(inController, admin, playerRepository, trainerRepository, teamRepository, transactionRepository);
        }

        public void VerifyPlayer(IVerifyUserView form, Player player, PlayerRepository playerRepository)
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

        public void VerifyTrainer(IVerifyUserView form, Trainer trainer, TrainerRepository trainerRepository)
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

        public void RefreshRegisterRequestsList(PlayerRepository playerRepository, TrainerRepository trainerRepository)
        {
            form.DisplayRegisterRequests(playerRepository, trainerRepository);
        }

        public void RefreshPlayerList(PlayerRepository playerRepository, TeamRepository teamRepository)
        {
            form.DisplayPlayerList(playerRepository, teamRepository);
        }

        public void RefreshTrainerList(TrainerRepository trainerRepository, TeamRepository teamRepository)
        {
            form.DisplayTrainerList(trainerRepository,teamRepository);
        }
        public void RefreshTeamList(TeamRepository teamRepository)
        {
            form.DisplayTeamList(teamRepository);
        }

        public void ShowPlayerOptions(IAdminPlayerOptionsView form, Player player, PlayerRepository playerRepository, TeamRepository teamRepository)
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

        public void ShowTrainerOptions(IAdminTrainerOptionsView form, Trainer trainer, TrainerRepository trainerRepository, TeamRepository teamRepository)
        {
            var result = form.ShowViewModal();
            if (result == DialogResult.Yes)
            {
                string teamAddName = form.NameAddTeam();
                teamRepository.AddTrainerToTeam(trainer, teamAddName, trainerRepository);
            }
            else if (result == DialogResult.No)
            {
                string teamRemoveName = form.NameRemoveTeam();
                teamRepository.RemoveTrainerFromTeam(trainer, teamRemoveName, trainerRepository);
            }
            else if (result == DialogResult.Abort)
            {
                teamRepository.DeleteTrainer(trainer, trainerRepository);
            }
        }

        public void ShowTeam(IAdminShowTeamView form)
        {
            form.ShowViewModal();
        }

        public void CreateTransactionsView(IAdminCreateTransactionsView form, PlayerRepository playerRepository, TransactionRepository transactionRepository)
        {
            var result = form.ShowViewModal();
            if(result == DialogResult.OK)
            {
                int year = int.Parse(form.Year);
                int month = int.Parse(form.Month);
                
                foreach (Player p in playerRepository._listPlayers)
                {
                    if (!p.Verified) continue;

                    bool addNew = true;
                    foreach(int id in p._transactionIds)
                    {
                        Transaction t = transactionRepository.GetTransactionById(id);
                        if (t._month == month && t._year == year)
                        {
                            addNew = false;
                            continue;
                        }
                    }
                    if (addNew)
                    {
                        Transaction newTransaction = new Transaction(transactionRepository.next_ID, MEMBERSHIP_FEE, p.Id, year, month);
                        transactionRepository.Add(newTransaction);
                        p._transactionIds.Add(transactionRepository.next_ID - 1);
                    }
                }
            }

        }

        public void AdminTransactionOptions(IAdminTransactionOptionsView inForm, Player p, Transaction t, PlayerRepository playerRepository, TransactionRepository transactionRepository)
        {
            var result = inForm.ShowViewModal();
            if(result == DialogResult.OK)
            {
                transactionRepository.ChangeTransactionStatus(t, playerRepository);
            }
            else if(result == DialogResult.Abort)
            {
                transactionRepository.Delete(t);
                playerRepository.DeleteTransaction(p, t);
            }
        }

        public bool ShowAdminSettings(ISettingsAdminView form, Admin admin, IAdminRepository adminRepository, IAuthController authController)
        {
            var result = form.ShowViewModal();
            if (result == DialogResult.OK)
            {
                if (authController.VerifyUpdateUserInput(form.Email, form.PasswordCurrent, form.PasswordNew))
                    return adminRepository.UpdateAdminValues(admin, form.Email, form.PasswordCurrent, form.PasswordNew);
                else
                    return false;
            }
            return true;
        }
    }
}
