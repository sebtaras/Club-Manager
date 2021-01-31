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
    public partial class FormUITrainer : Form, ITrainerView
    {
        private IMainController controller;
        private Trainer trainer;

        public FormUITrainer()
        {
            InitializeComponent();
        }

        public bool ShowViewModaless(IMainController inController, Trainer inTrainer)
        {
            controller = inController;
            trainer = inTrainer;

            if (trainer.Verified)
            {
                HideVerificationLabel();
            }
            Show();
            return true;
        }

        public void DisplayPlayerList(List<Player> players, List<Team> teams)
        {
            if (!trainer.Verified)
                return;

            PlayerList.Items.Clear();
            foreach(Team team in teams)
            {
                if (team.Trainers.Contains(trainer))
                {
                    foreach(Player player in players)
                    {
                        if (team.Players.Contains(player))
                        {
                            PlayerList.Items.Add(new ListViewItem(new string[] { player.Id.ToString(), player.FirstName + " " + player.LastName, player.Age.ToString(), team.Name }));
                        }
                    }
                }
            }
        }

        public void DisplayTrainingList(IList<Training> trainings, List<Team> teams)
        {
            TrainingList.Items.Clear();
            foreach (Team team in teams)
            {
                if (team.Trainers.Contains(trainer))
                {
                    foreach (Training training in trainings)
                    {
                        IList<Training> temp = team.Trainings;
                        if (team.Trainings.Contains(training))
                        {
                            string start = training.StartTime.ToLongDateString() + "  " + training.StartTime.ToShortTimeString();
                            string end = training.EndTime.ToLongDateString() + "  " + training.EndTime.ToShortTimeString();
                            TrainingList.Items.Add(new ListViewItem(new string[] { training.Id.ToString(), team.Name, start, end }));
                        }
                    }
                }
            }
        }

        public void HideVerificationLabel()
        {
            VerificationLabel.Hide();
            CreateTrainingButton.Show();
        }

        private void LogOut(object sender, EventArgs e)
        {
            Hide();
            controller.LogOut();
        }

        private void ShowUserSettings(object sender, EventArgs e)
        {
            if (!controller.ShowTrainerSettings(trainer.Id))
                MessageBox.Show("Failed to update value");
        }

        private void CreateTraining(object sender, EventArgs e)
        {
            controller.CreateTrainingView(this, trainer);
        }

        public void AlertFailedCreateTraining()
        {
            MessageBox.Show("Failed to create training");
        }

        private void DeleteTraining(object sender, EventArgs e)
        {
            if (TrainingList.SelectedItems[0] != null)
            {
                string trainingId = TrainingList.SelectedItems[0].SubItems[0].Text;
                string teamName = TrainingList.SelectedItems[0].SubItems[1].Text;
                string trainingTime = TrainingList.SelectedItems[0].SubItems[2].Text;
                controller.DeleteTraining(this, int.Parse(trainingId), teamName, trainingTime);
            }
        }

    }
}
