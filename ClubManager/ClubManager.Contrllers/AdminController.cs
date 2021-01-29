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
            form.ShowViewModaless(inController, admin, playerRepository._listPlayers, trainerRepository._listTrainers, teamRepository._teamList, transactionRepository._listTransactions);
        }

        public void VerifyPlayer(IVerifyUserView inForm, Player player, IPlayerRepository playerRepository, ITrainerRepository trainerRepository, ITeamRepository teamRepository)
        {
            inForm.SetPlayerValues(player);
            var result = inForm.ShowViewModal();
            if (result == DialogResult.OK)
            {
                playerRepository.Verify(player);
                form.DisplayPlayerList(playerRepository.GetAll(), teamRepository.GetAll());
            }
            else if (result == DialogResult.No)
            {
                playerRepository.Delete(player);
            }
            form.DisplayRegisterRequests(playerRepository.GetAll(), trainerRepository.GetAll());
        }

        public void VerifyTrainer(IVerifyUserView inForm, Trainer trainer, IPlayerRepository playerRepository, ITrainerRepository trainerRepository, ITeamRepository teamRepository)
        {
            inForm.SetTrainerValues(trainer);
            var result = inForm.ShowViewModal();
            if (result == DialogResult.OK)
            {
                trainerRepository.Verify(trainer);
                form.DisplayTrainerList(trainerRepository.GetAll(), teamRepository.GetAll());
            }
            else if (result == DialogResult.No)
            {
                trainerRepository.Delete(trainer);
            }
            form.DisplayRegisterRequests(playerRepository.GetAll(), trainerRepository.GetAll());
        }

        public void ShowPlayerOptions(IAdminView parentForm, IAdminPlayerOptionsView form, Player player, PlayerRepository playerRepository, TeamRepository teamRepository)
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
            parentForm.DisplayPlayerList(playerRepository._listPlayers, teamRepository._teamList);
            parentForm.DisplayTeamList(teamRepository._teamList);
        }

        public void ShowTrainerOptions(IAdminView parentForm, IAdminTrainerOptionsView form, Trainer trainer, TrainerRepository trainerRepository, TeamRepository teamRepository)
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
            parentForm.DisplayTrainerList(trainerRepository._listTrainers, teamRepository._teamList);
            parentForm.DisplayTeamList(teamRepository._teamList);
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
