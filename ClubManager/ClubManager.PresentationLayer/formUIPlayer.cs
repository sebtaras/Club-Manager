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

namespace ClubManager.PresentationLayer
{
    public partial class formUIPlayer : Form, IPlayerView
    {
        public IMainController controller;
        public Player player;
        public PlayerRepository playerRepository;

        public formUIPlayer()
        {
            InitializeComponent();
        }

        public bool ShowViewModaless(IMainController inController, Player inPlayer, TransactionRepository transactionRepository, TrainingRepository trainingRepository, PlayerRepository inPlayerRepository)
        {
            controller = inController;
            playerRepository = inPlayerRepository;
            player = inPlayer;
            if (player.Verified)
            {
                HideVerificationLabel();
                DisplayTransactionList(transactionRepository);
                //DisplayTrainingList(player._trainingIds);
            }
            this.Show();
            return true;
        }

        public void HideVerificationLabel()
        {
            this.VerificationLabel.Hide();
        }

        public void DisplayTransactionList(TransactionRepository transactionRepository)
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

        public void DisplayTrainingList(TrainingRepository trainingRepository)
        {
            foreach (Training t in trainingRepository._trainings)
            {
                TrainingList.Items.Add(new ListViewItem(new string[] { t.Id.ToString(), t.StartTime.ToString(), t.EndTime.ToString() })) ;
            }
        }

        private void LogOut(object sender, EventArgs e)
        {
            this.Hide();
            controller.LogOut();
        }

        private void ShowUserSettings(object sender, EventArgs e)
        {
            if(!controller.ShowPlayerSettings(player, playerRepository))
            {
                MessageBox.Show("Failed to update values");
            }
        }
    }
}
