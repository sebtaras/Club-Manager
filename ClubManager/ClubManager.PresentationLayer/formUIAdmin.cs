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
        public TransactionRepository transactionRepository;

        public formUIAdmin()
        {
            InitializeComponent();
        }

        public bool ShowViewModaless(IMainController inController, PlayerRepository inPlayerRepository, TrainerRepository inTrainerRepository, TeamRepository inTeamRepository, TransactionRepository inTransactionRepository)
        {
            controller = inController;
            playerRepository = inPlayerRepository;
            trainerRepository = inTrainerRepository;
            teamRepository = inTeamRepository;
            transactionRepository = inTransactionRepository;
            DisplayRegisterRequests(playerRepository, trainerRepository);
            DisplayTeamList(teamRepository);
            DisplayPlayerList(playerRepository, teamRepository);
            DisplayTrainerList(trainerRepository, teamRepository);
            this.Show();
            return true;
        }

        public void DisplayTeamList(TeamRepository teamRepository)
        {
            TeamList.Items.Clear();
            foreach (Team t in teamRepository._teamList)
            {
                TeamList.Items.Add(new ListViewItem(new string[] { t.Id.ToString(), t._name, t._ages[0] + "-" + t._ages[t._ages.Count-1], t._listPlayerIds.Count.ToString(), t._listTrainerIds.Count.ToString() }));
            }
        }

        public void DisplayRegisterRequests(PlayerRepository playerRepository, TrainerRepository trainerRepository)
        {
            RegisterRequests.Items.Clear();
            foreach(Player p in playerRepository._listPlayers)
            {
                if(!p.Verified)
                    RegisterRequests.Items.Add(new ListViewItem(new string[] { p.Id.ToString(), p.FirstName + " " + p.LastName, p.Email, "Player" }));
            }
            foreach (Trainer t in trainerRepository._listTrainers)
            {
                if (!t.Verified)
                    RegisterRequests.Items.Add(new ListViewItem(new string[] { t.Id.ToString(), t.FirstName + " " + t.LastName, t.Email, "Trainer"}));
            }
        }

        public void DisplayPlayerList(PlayerRepository playerRepository, TeamRepository teamRepository)
        {
            
            PlayerList.Items.Clear();
            foreach (Player p in playerRepository._listPlayers)
            {
                if (p.Verified)
                {
                    string teamName = p.teamId != -1 ? teamRepository.GetTeamById(p.teamId)._name : "";
                    PlayerList.Items.Add(new ListViewItem(new string[] { p.Id.ToString(), p.FirstName + " " + p.LastName, p.Email, teamName, p.Age.ToString() }));
                }
            }
        }

        public void DisplayTrainerList(TrainerRepository trainerRepository, TeamRepository teamRepository)
        {
            TrainerList.Items.Clear();
            foreach (Trainer t in trainerRepository._listTrainers)
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
    }
}
