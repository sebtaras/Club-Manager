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
        private decimal MEMBERSHIP_FEE = (decimal)200.00;
        internal void Homepage(IAdminView form, IMainController inController, PlayerRepository playerRepository, TrainerRepository trainerRepository, TeamRepository teamRepository, TransactionRepository transactionRepository)
        {
            this.form = form;
            form.ShowViewModaless(inController, playerRepository, trainerRepository, teamRepository, transactionRepository);
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

        internal void RefreshPlayerList(PlayerRepository playerRepository, TeamRepository teamRepository)
        {
            form.DisplayPlayerList(playerRepository, teamRepository);
        }

        internal void RefreshTrainerList(TrainerRepository trainerRepository, TeamRepository teamRepository)
        {
            form.DisplayTrainerList(trainerRepository,teamRepository);
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

        internal void ShowTeam(IAdminShowTeamView form)
        {
            form.ShowViewModal();
        }

        internal void CreateTransactionsView(IAdminCreateTransactionsView form, PlayerRepository playerRepository, TransactionRepository transactionRepository)
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
    }
}
