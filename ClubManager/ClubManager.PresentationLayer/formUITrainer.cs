using ClubManager.BaseLib;
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
        public IMainController controller;
        public Trainer trainer;
        public formUITrainer()
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
                DisplayTrainingList(trainer._teams);
                DisplayPlayerList(trainer._teams);
            }
            this.Show();
            return true;
        }

        private void DisplayPlayerList(List<Team> teams)
        {

        }

        private void DisplayTrainingList(List<Team> teams)
        {

        }

        public void HideVerificationLabel()
        {
            this.VerificationLabel.Hide();
            this.CreateNewTrainingButton.Show();
        }

        private void LogOut(object sender, EventArgs e)
        {
            this.Hide();
            controller.LogOut();
        }
    }
}
