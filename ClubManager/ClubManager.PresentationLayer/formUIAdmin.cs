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
        public PlayerRepository playerRepository;
        public TrainerRepository trainerRepository;
        public TeamRepository teamRepository;
        public TransactionRepository transactionRepository;

        public formUIAdmin()
        {
            InitializeComponent();
        }

        public bool ShowViewModaless(IMainController inController, Admin inAdmin, PlayerRepository inPlayerRepository, TrainerRepository inTrainerRepository, TeamRepository inTeamRepository, TransactionRepository inTransactionRepository)
        {
            controller = inController;
            admin = inAdmin;
            playerRepository = inPlayerRepository;
            trainerRepository = inTrainerRepository;
            teamRepository = inTeamRepository;
            transactionRepository = inTransactionRepository;
            DisplayRegisterRequests(playerRepository._listPlayers, trainerRepository._listTrainers);
            DisplayTeamList(teamRepository._teamList);
            DisplayPlayerList(playerRepository._listPlayers, teamRepository._teamList);
            DisplayTrainerList(trainerRepository._listTrainers, teamRepository._teamList);
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
            /*foreach (Trainer t in trainerRepository._listTrainers)
            {
                string teamNames = "";
                if (t._teamIds.Count > 1)
                {
                    foreach(int id in t._teamIds)
                    {
                        teamNames += teamRepository.GetTeamById(id)._name + ", ";
                    }
                    teamNames = teamNames.Substring(0, teamNames.Length - 2);
                }
                else if (t._teamIds.Count == 1) teamNames = teamRepository.GetTeamById(t._teamIds[0])._name;

                if (t.Verified)
                    TrainerList.Items.Add(new ListViewItem(new string[] { t.Id.ToString(), t.FirstName + " " + t.LastName, t.Email, teamNames }));
            }*/
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
            this.Hide();
            controller.LogOut();
        }

        private void VerifyUser(object sender, EventArgs e)
        {
            if (RegisterRequests.SelectedItems[0] != null)
            {
                string id = RegisterRequests.SelectedItems[0].SubItems[0].Text;
                Player p = null;
                Trainer t = null;
                if (RegisterRequests.SelectedItems[0].SubItems[3].Text == "Player") 
                    p = playerRepository.GetPlayerById(int.Parse(id));
                else 
                    t = trainerRepository.GetTrainerById(int.Parse(id));

                if (p != null) controller.ShowVerifyUserForm(p, null);
                else controller.ShowVerifyUserForm(null, t);
            }
        }

        private void AdminPlayerOptionsForm(object sender, EventArgs e)
        {
            if(PlayerList.SelectedItems[0] != null)
            {
                string id= PlayerList.SelectedItems[0].SubItems[0].Text;
                Player p = playerRepository.GetPlayerById(int.Parse(id));
                controller.ShowPlayerInfo(p);
            }
        }

        private void AdminTrainerOptionsForm(object sender, EventArgs e)
        {
            if (TrainerList.SelectedItems[0] != null)
            {
                string id = TrainerList.SelectedItems[0].SubItems[0].Text;
                Trainer t = trainerRepository.GetTrainerById(int.Parse(id));
                controller.ShowTrainerInfo(t);
            }
        }

        private void ShowTeam(object sender, EventArgs e)
        {
            if (TeamList.SelectedItems[0] != null)
            {
                string id = TeamList.SelectedItems[0].SubItems[0].Text;
                Team t = teamRepository.GetTeamById(int.Parse(id));
                controller.ShowTeamInfo(t);
            }
        }

        private void CreateTransactions(object sender, EventArgs e)
        {
            controller.CreateTransactionsView(playerRepository, transactionRepository);
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
