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
            DisplayPlayerList(playerRepository);
            DisplayTrainerList(trainerRepository);
            this.Show();
            return true;
        }

        public void DisplayTeamList(TeamRepository teamRepository)
        {
            TeamList.Items.Clear();
            foreach (Team t in teamRepository._teamList)
            {
                string trainers = "";
                if (t._trainers.Count > 1)
                {
                    foreach (Trainer trainer in t._trainers)
                    {
                        trainers +=  trainer.FirstName + " " + trainer.LastName + ", ";
                    }
                    trainers = trainers.Substring(0, trainers.Length - 2);
                }
                if (t._trainers.Count == 0)
                    trainers = t._trainers[0].FirstName + " " + t._trainers[0].LastName;
                TeamList.Items.Add(new ListViewItem(new string[] { 
                    t._name, t._ageRange[0] + "-" + t._ageRange[t._ageRange.Count-1],
                    trainers }));
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

        public void DisplayPlayerList(PlayerRepository playerRepository)
        {
            PlayerList.Items.Clear();
            foreach (Player p in playerRepository._listPlayers)
            {
                if (p.Verified)
                    PlayerList.Items.Add(new ListViewItem(new string[] { p.FirstName + " " + p.LastName, p.Email, p.team != null ? p.team._name : "", p.Age.ToString() }));
            }
        }

        public void DisplayTrainerList(TrainerRepository trainerRepository)
        {
            TrainerList.Items.Clear();
            foreach (Trainer t in trainerRepository._listTrainers)
            {
                string teams = "";
                if (t._teams.Count > 1)
                {
                    foreach (Team team in t._teams)
                    {
                        teams += team._name + ", ";
                    }
                    teams = teams.Substring(0, teams.Length - 2);
                }
                else if (t._teams.Count == 1)
                    teams = t._teams[0]._name;
                if (t.Verified)
                    TrainerList.Items.Add(new ListViewItem(new string[] { t.FirstName + " " + t.LastName, t.Email, teams }));
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

        private void AdminPlayerOptionsForm(object sender, EventArgs e)
        {
            if(PlayerList.SelectedItems[0] != null)
            {
                string email = PlayerList.SelectedItems[0].SubItems[1].Text;
                Player p = playerRepository.GetPlayerByEmail(email);
                controller.ShowPlayerInfo(p);
            }
        }
    }
}
