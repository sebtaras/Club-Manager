using ClubManager.BaseLib;
using ClubManager.DAL_File;
using ClubManager.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClubManager.Contrllers;
namespace ClubManager.PresentationLayer
{
    public partial class formAdminPlayerOptions : Form, IAdminPlayerOptionsView
    {
        private Player player;
        private IAdminController adminController;
        private IWindowFormsFactory windowFormsFactory;
        private TeamRepository teamRepository;
        private PlayerRepository playerRepository;
        private TransactionRepository transactionRepository;
          
        public formAdminPlayerOptions(Player inPlayer, IWindowFormsFactory inWindowFormsFactory, IAdminController inAdminController, PlayerRepository inPlayerRepository, TeamRepository inTeamRepository, TransactionRepository inTransactionRepository)
        {
            InitializeComponent();
            player = inPlayer;
            windowFormsFactory = inWindowFormsFactory;
            adminController = inAdminController;
            teamRepository = inTeamRepository;
            playerRepository = inPlayerRepository;
            transactionRepository = inTransactionRepository;
            SetPlayerValues(inPlayer, teamRepository, transactionRepository);
        }

        public DialogResult ShowViewModal()
        {
            return this.ShowDialog();
        }

        public void SetPlayerValues(Player player, TeamRepository teamRepository, TransactionRepository transactionRepository)
        {
            FullName.Text = "Full name: " + player.FirstName + " " + player.LastName;
            Age.Text = "Age: " + player.Age.ToString();
            if (player.teamId != -1)
                CurrentTeam.Text = "Team: " + teamRepository.GetTeamById(player.teamId)._name;
            else
                CurrentTeam.Visible = false;

            UpdateTransactionList();
        }

        private void AdminTransactionOptions(object sender, EventArgs e)
        {
            if (TransactionList.SelectedItems[0] != null)
            {
                string id = TransactionList.SelectedItems[0].SubItems[0].Text;
                Transaction transaction = transactionRepository.GetTransactionById(int.Parse(id));
                var form = windowFormsFactory.AdminTransactionOptions(player, transaction);
                adminController.AdminTransactionOptions(form, player, transaction,  playerRepository, transactionRepository);
                UpdateTransactionList();
            }
        }

        private void UpdateTransactionList()
        {
            TransactionList.Items.Clear();
            foreach (Transaction t in transactionRepository._listTransactions)
            {
                if (t._playerId == player.Id)
                {
                    TransactionList.Items.Add(new ListViewItem(new string[] { t.Id.ToString(), t._year.ToString(), t._month.ToString(), t._amount.ToString(), t._paid.ToString() }));
                }
            }
        }
    }
}
