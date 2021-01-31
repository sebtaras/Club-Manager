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
    public partial class FormUIPlayer : Form, IPlayerView
    {
        public IMainController controller;
        private Player player;

        public FormUIPlayer()
        {
            InitializeComponent();
        }

        public bool ShowViewModaless(IMainController inController, Player inPlayer, IList<Transaction> inListTransactions, IList<Training> inListTrainings, List<Team> inListTeams, List<Trainer> inListTrainers)
        {
            controller = inController;
            player = inPlayer;
            if (inPlayer.Verified)
            {
                HideVerificationLabel();
                DisplayTransactionList(inListTransactions);
                DisplayTrainingList(inListTrainings, inListTeams, inListTrainers);
            }
            Show();
            return true;
        }

        public void HideVerificationLabel()
        {
            VerificationLabel.Hide();
        }

        public void DisplayTransactionList(IList<Transaction> inListTransactions)
        {
            TransactionList.Items.Clear();
            foreach (Transaction t in inListTransactions)
            {
                if (t.Player == player)
                {
                    TransactionList.Items.Add(new ListViewItem(new string[] { t.Id.ToString(), t.Year.ToString(), t.Month.ToString(), t.Amount.ToString(), t.Paid.ToString() }));
                }
            }
        }

        public void DisplayTrainingList(IList<Training> trainings, List<Team> teams, List<Trainer> trainers)
        {
            TrainingList.Items.Clear();
            foreach(Team team in teams)
            {
                if (team.Players.Contains(player))
                {
                    foreach(Training t in team.Trainings)
                    {
                        foreach(Training training in trainings)
                        {
                            if(training.Id == t.Id)
                            {
                                foreach (Trainer trainer in trainers)
                                {
                                    if (trainer == training.Trainer)
                                    {
                                        string trainerName = trainer.FirstName + " " + trainer.LastName;
                                        string startTime = training.StartTime.ToLongDateString() + "  " + training.StartTime.ToShortTimeString();
                                        string endTime = training.StartTime.ToLongDateString() + "  " + training.StartTime.ToShortTimeString();
                                        TrainingList.Items.Add(new ListViewItem(new string[] { training.Id.ToString(), trainerName, startTime, endTime }));
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private void LogOut(object sender, EventArgs e)
        {
            Hide();
            controller.LogOut();
        }

        private void ShowUserSettings(object sender, EventArgs e)
        {
            if (!controller.ShowPlayerSettings(player.Id))
            {
                MessageBox.Show("Failed to update values");
            }
        }
    }
}
