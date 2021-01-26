using ClubManager.BaseLib;
using ClubManager.DAL_File;
using ClubManager.Models;
using ClubManager.Models.Repositories;
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
    public partial class formUIAdmin : Form, IAdminView
    {
        public IMainController controller;
        public PlayerRepository playerRepository;
        public TrainerRepository trainerRepository;
        public TeamRepository teamRepository;

        public formUIAdmin()
        {
            InitializeComponent();
        }

        public bool ShowViewModaless(IMainController inController, PlayerRepository inPlayerRepository, TrainerRepository inTrainerRepository, TeamRepository inTeamRepository)
        {
            controller = inController;
            playerRepository = inPlayerRepository;
            trainerRepository = inTrainerRepository;
            teamRepository = inTeamRepository;
            DisplayRegisterRequests(playerRepository, trainerRepository);
            DisplayTeamList(teamRepository);
            this.Show();
            return true;
        }

        private void DisplayTeamList(TeamRepository teamRepository)
        {
            foreach(Team t in teamRepository._teamList)
            {
                TeamList.Items.Add(new ListViewItem(new string[] { t._name, t._ageRange[0] + "-" + t._ageRange[t._ageRange.Count-1], t._trainer.FirstName + " " + t._trainer.LastName }));
            }
        }

        public void DisplayRegisterRequests(PlayerRepository playerRepository, TrainerRepository trainerRepository)
        {
            RegisterRequests.Items.Clear();
            foreach(Player p in playerRepository._listPlayers)
            {
                if(!p.Verified)
                    RegisterRequests.Items.Add(new ListViewItem(new string[] { p.FirstName + " " + p.LastName, p.Email, "Player", p.Age.ToString() }));
            }
            foreach (Trainer t in trainerRepository._listTrainers)
            {
                if (!t.Verified)
                    RegisterRequests.Items.Add(new ListViewItem(new string[] { t.FirstName + " " + t.LastName, t.Email, "Trainer", "" }));
            }
        }

        private void LogOut(object sender, EventArgs e)
        {
            this.Hide();
            controller.LogOut();
        }

        private void VerifyUser(object sender, EventArgs e)
        {
            if (RegisterRequests.SelectedItems[0] != null)
            {
                int ind = RegisterRequests.SelectedItems[0].Index;
                string email = RegisterRequests.SelectedItems[0].SubItems[1].Text;
                Player p = null;
                Trainer t = null;
                if (RegisterRequests.SelectedItems[0].SubItems[2].Text == "Player")
                    p = playerRepository.GetPlayerByEmail(email);
                else
                    t = trainerRepository.GetTrainerByEmail(email);

                if (p != null)
                    controller.ShowVerifyUserForm(p, null);
                else
                    controller.ShowVerifyUserForm(null, t);
            }
        }
    }
}
