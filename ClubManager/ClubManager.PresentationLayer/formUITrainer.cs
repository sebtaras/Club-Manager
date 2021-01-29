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
    public partial class formUITrainer : Form, ITrainerView
    {
        private IMainController controller;
        private Trainer trainer;
        private TeamRepository teamRepository;
        private TrainingRepository trainingRepository;
        private PlayerRepository playerRepository;

        public formUITrainer()
        {
            InitializeComponent();
        }

        public bool ShowViewModaless(IMainController inController, Trainer inTrainer, TeamRepository inTeamRepository, TrainingRepository inTrainingRepository, PlayerRepository inPlayerRepository)
        {
            controller = inController;
            trainer = inTrainer;
            teamRepository = inTeamRepository;
            trainingRepository = inTrainingRepository;
            playerRepository = inPlayerRepository;

            if (trainer.Verified)
            {
                HideVerificationLabel();
                DisplayTrainingList();
                DisplayPlayerList();
            }
            Show();
            return true;
        }

        private void DisplayPlayerList()
        {
            if (trainer.Verified == false)
                return;

            PlayerList.Items.Clear();
            foreach(int teamId in trainer._teamIds)
            {
                Team t = teamRepository.GetTeamById(teamId);
                foreach(int playerId in t._listPlayerIds)
                {
                    Player p = playerRepository.GetPlayerById(playerId);
                    PlayerList.Items.Add(new ListViewItem(new string[] { p.Id.ToString(), p.FirstName + " " + p.LastName, p.Age.ToString(), t._name }));
                }
            }
        }

        public void DisplayTrainingList()
        {
            if (trainer.Verified == false)
                return;

            TrainingList.Items.Clear();
            foreach(int teamId in trainer._teamIds)
            {
                Team t = teamRepository.GetTeamById(teamId);
                foreach(int trainingId in t._listTrainingIds)
                {
                    Training tr = trainingRepository.GetTrainingById(trainingId);
                    string start = tr.StartTime.ToLongDateString() + "  " + tr.StartTime.ToShortTimeString();
                    string end = tr.EndTime.ToLongDateString() + "  " +  tr.EndTime.ToShortTimeString();
                    TrainingList.Items.Add(new ListViewItem(new string[] { tr.Id.ToString(), t._name, start, end }));
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
            /*if (!controller.ShowPlayerSettings(trainer, trainerRepository))
                MessageBox.Show("Failed to update value");*/
        }

        private void CreateTraining(object sender, EventArgs e)
        {
            if (!controller.CreateTrainingView(trainer))
                MessageBox.Show("Failed to add training");
            else
                DisplayTrainingList();
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
