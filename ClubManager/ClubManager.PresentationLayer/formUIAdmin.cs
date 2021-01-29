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
        private Admin admin;

        public formUIAdmin()
        {
            InitializeComponent();
        }

        public bool ShowViewModaless(IMainController inController, Admin inAdmin, List<Player> inListPlayers, List<Trainer> inListTrainers, List<Team> inListTeams, List<Transaction> inListTransactions)
        {
            controller = inController;
            admin = inAdmin;
            DisplayRegisterRequests(inListPlayers, inListTrainers);
            DisplayTeamList(inListTeams);
            DisplayPlayerList(inListPlayers, inListTeams);
            DisplayTrainerList(inListTrainers, inListTeams);
            this.Show();
            return true;
        }

        public void DisplayTeamList(List<Team> teams)
        {
            TeamList.Items.Clear();
            foreach(Team team in teams)
            {
                TeamList.Items.Add(new ListViewItem(new string[] { 
                    team.Id.ToString(), 
                    team._name, team._ages[0] + " - " + team._ages[team._ages.Count - 1], 
                    team._listPlayerIds.Count.ToString(), 
                    team._listTrainerIds.Count.ToString() }));
            }
        }

        public void DisplayRegisterRequests(List<Player> players, List<Trainer> trainers)
        {
            RegisterRequests.Items.Clear();
            foreach(Player player in players)
            {
                if(!player.Verified)
                    RegisterRequests.Items.Add(new ListViewItem(new string[] { player.Id.ToString(), player.FirstName + " " + player.LastName, player.Email, "Player" }));
            }
            foreach (Trainer trainer in trainers)
            {
                if (!trainer.Verified)
                    RegisterRequests.Items.Add(new ListViewItem(new string[] { trainer.Id.ToString(), trainer.FirstName + " " + trainer.LastName, trainer.Email, "Trainer" }));
            }
        }

        public void DisplayPlayerList(List<Player> players, List<Team> teams)
        {
            PlayerList.Items.Clear();

            foreach(Player player in players)
            {
                if (player.Verified)
                {
                    string teamName = player.teamId == -1 ? "" : "placeholder";
                    foreach (Team team in teams)
                    {
                        if (team._listPlayerIds.Contains(player.Id)) teamName = team._name;
                    }
                    PlayerList.Items.Add(new ListViewItem(new string[] { player.Id.ToString(), player.FirstName + " " + player.LastName, player.Email, teamName, player.Age.ToString() }));
                }
            }
        }

        public void DisplayTrainerList(List<Trainer> trainers, List<Team> teams)
        {
            TrainerList.Items.Clear();
            foreach(Trainer trainer in trainers)
            {
                if (trainer.Verified)
                {
                    List<string> teamNames = new List<string>();
                    foreach(Team team in teams)
                    {
                        if (team._listTrainerIds.Contains(trainer.Id))
                        {
                            teamNames.Add(team._name);
                        }
                    }
                    TrainerList.Items.Add(new ListViewItem(new string[] { trainer.Id.ToString(), trainer.FirstName + " " + trainer.LastName, trainer.Email, string.Join(", ", teamNames) }));
                }
            }
        }

        private void LogOut(object sender, EventArgs e)
        {
            Hide();
            controller.LogOut();
        }

        private void VerifyUser(object sender, EventArgs e)
        {
            if (RegisterRequests.SelectedItems[0] != null)
            {
                int id = int.Parse(RegisterRequests.SelectedItems[0].SubItems[0].Text);
                if (RegisterRequests.SelectedItems[0].SubItems[3].Text == "Player")
                {
                    controller.ShowVerifyPlayerForm(id);
                }
                else
                {
                    controller.ShowVerifyTrainerForm(id);
                }
            }
        }

        private void AdminPlayerOptionsForm(object sender, EventArgs e)
        {
            if(PlayerList.SelectedItems[0] != null)
            {
                int playerId = int.Parse(PlayerList.SelectedItems[0].SubItems[0].Text);
                controller.ShowPlayerInfo(this, playerId);
            }
        }

        private void AdminTrainerOptionsForm(object sender, EventArgs e)
        {
            if (TrainerList.SelectedItems[0] != null)
            {
                int trainerId = int.Parse(TrainerList.SelectedItems[0].SubItems[0].Text);
                controller.ShowTrainerInfo(this, trainerId);
            }
        }

        private void ShowTeam(object sender, EventArgs e)
        {
            if (TeamList.SelectedItems[0] != null)
            {
                int teamId = int.Parse(TeamList.SelectedItems[0].SubItems[0].Text);
                controller.ShowTeamInfo(this, teamId);
            }
        }

        private void CreateTransactions(object sender, EventArgs e)
        {
            controller.CreateTransactionsView();
        }

        private void ShowUserSettings(object sender, EventArgs e)
        {
            if (!controller.ShowAdminSettings(admin.Id))
            {
                MessageBox.Show("Failed to update values");
            }
        }
    }
}
