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
        private IAdminView _form;
        private IPlayerRepository _playerRepository;
        private ITrainerRepository _trainerRepository;
        private ITeamRepository _teamRepository;
        private ITransactionRepository _transactionRepository;

        private decimal MEMBERSHIP_FEE = (decimal)200.00;

        
        public void Homepage(IAdminView form, IMainController inController, Admin admin, IPlayerRepository playerRepository, ITrainerRepository trainerRepository, ITeamRepository teamRepository, ITransactionRepository transactionRepository)
        {
            _form = form;
            _playerRepository = playerRepository;
            _trainerRepository = trainerRepository;
            _teamRepository = teamRepository;
            _transactionRepository = transactionRepository;
            form.ShowViewModaless(inController, admin, playerRepository.GetAll(), trainerRepository.GetAll(), teamRepository.GetAll(), transactionRepository.GetAll());
        }

        public void VerifyPlayer(IVerifyUserView inForm, Player player, IPlayerRepository playerRepository, ITrainerRepository trainerRepository, ITeamRepository teamRepository)
        {
            inForm.SetPlayerValues(player);
            var result = inForm.ShowViewModal();
            if (result == DialogResult.OK)
            {
                playerRepository.Verify(player);
                _form.DisplayPlayerList(playerRepository.GetAll(), teamRepository.GetAll());
            }
            else if (result == DialogResult.No)
            {
                playerRepository.Delete(player);
            }
            _form.DisplayRegisterRequests(playerRepository.GetAll(), trainerRepository.GetAll());
        }

        public void VerifyTrainer(IVerifyUserView inForm, Trainer trainer, IPlayerRepository playerRepository, ITrainerRepository trainerRepository, ITeamRepository teamRepository)
        {
            inForm.SetTrainerValues(trainer);
            var result = inForm.ShowViewModal();
            if (result == DialogResult.OK)
            {
                trainerRepository.Verify(trainer);
                _form.DisplayTrainerList(trainerRepository.GetAll(), teamRepository.GetAll());
            }
            else if (result == DialogResult.No)
            {
                trainerRepository.Delete(trainer);
            }
            _form.DisplayRegisterRequests(playerRepository.GetAll(), trainerRepository.GetAll());
        }

        public void ShowPlayerOptions(IAdminView parentForm, IAdminPlayerOptionsView form, Player player, IPlayerRepository playerRepository, ITeamRepository teamRepository, ITransactionRepository transactionRepository)
        {
            form.DisplayTransactionList(transactionRepository.GetAll());
            form.SetPlayerValues(player, teamRepository.GetAll());
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
            parentForm.DisplayPlayerList(playerRepository.GetAll(), teamRepository.GetAll());
            parentForm.DisplayTeamList(teamRepository.GetAll());
        }

        public void ShowTrainerOptions(IAdminView parentForm, IAdminTrainerOptionsView form, Trainer trainer, ITrainerRepository trainerRepository, ITeamRepository teamRepository)
        {
            form.SetTrainerValues(trainer, teamRepository.GetAll());
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
            parentForm.DisplayTrainerList(trainerRepository.GetAll(), teamRepository.GetAll());
            parentForm.DisplayTeamList(teamRepository.GetAll());
        }

        public void ShowTeam(IAdminShowTeamView form)
        {
            form.ShowViewModal();
        }

        public void CreateTransactionsView(IAdminCreateTransactionsView form, IPlayerRepository playerRepository, ITransactionRepository transactionRepository)
        {
            var result = form.ShowViewModal();
            if(result == DialogResult.OK)
            {
                int year = int.Parse(form.Year);
                int month = int.Parse(form.Month);

                foreach (Player p in playerRepository.GetAll())
                {
                    if (!p.Verified) continue;

                    bool addNew = true;
                    foreach(int id in p.TransactionIds)
                    {
                        Transaction t = transactionRepository.GetTransactionById(id);
                        if (t.Month == month && t.Year == year)
                        {
                            addNew = false;
                            continue;
                        }
                    }
                    if (addNew)
                    {
                        Transaction newTransaction = new Transaction(transactionRepository.GetNextId(), MEMBERSHIP_FEE, p.Id, year, month);
                        transactionRepository.Add(newTransaction);
                        p.TransactionIds.Add(transactionRepository.GetNextId() - 1);
                    }
                }
            }
        }

        public void AdminTransactionOptions(IAdminPlayerOptionsView parentForm, IAdminTransactionOptionsView form, Player p, int transactionId)
        {
            form.SetValues(p, _transactionRepository.GetTransactionById(transactionId));
            var result = form.ShowViewModal();
            if(result == DialogResult.OK)
            {
                _transactionRepository.ChangeTransactionStatus(_transactionRepository.GetTransactionById(transactionId));
            }
            else if(result == DialogResult.Abort)
            {
                _playerRepository.DeleteTransaction(p, _transactionRepository.GetTransactionById(transactionId));
                _transactionRepository.Delete(_transactionRepository.GetTransactionById(transactionId));
            }
            parentForm.DisplayTransactionList(_transactionRepository.GetAll());
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
