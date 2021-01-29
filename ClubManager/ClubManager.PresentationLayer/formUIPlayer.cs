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
        private Player player;

        public formUIPlayer()
        {
            InitializeComponent();
        }

        public bool ShowViewModaless(IMainController inController, Player inPlayer, List<Transaction> inListTransactions, List<Training> inListTrainings, List<Team> inListTeams, List<Trainer> inListTrainers)
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

        public void DisplayTransactionList(List<Transaction> inListTransactions)
        {
            TransactionList.Items.Clear();
            foreach (Transaction t in inListTransactions)
            {
                if (t._playerId == player.Id)
                {
                    TransactionList.Items.Add(new ListViewItem(new string[] { t.Id.ToString(), t._year.ToString(), t._month.ToString(), t._amount.ToString(), t._paid.ToString() }));
                }
            }
        }

        public void DisplayTrainingList(List<Training> trainings, List<Team> teams, List<Trainer> trainers)
        {
            TrainingList.Items.Clear();
            foreach(Team team in teams)
            {
                if (team._listPlayerIds.Contains(player.Id))
                {
                    foreach(int trainingId in team._listTrainingIds)
                    {
                        foreach(Training training in trainings)
                        {
                            if(training.Id == trainingId)
                            {
                                foreach (Trainer trainer in trainers)
                                {
                                    if (trainer.Id == training.TrainerId)
                                    {
                                        string trainerName = trainer.FirstName + " " + trainer.LastName;
                                        string startTime = training.StartTime.ToLongDateString() + "  " + training.StartTime.ToShortTimeString();
                                        string endTime = training.StartTime.ToLongDateString() + "  " + training.StartTime.ToShortTimeString();
                                        TrainingList.Items.Add(new ListViewItem(new string[] { trainingId.ToString(), trainerName, startTime, endTime }));
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
