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
    public partial class formAdminShowTeam : Form, IAdminShowTeamView
    {
        public formAdminShowTeam(Team team, PlayerRepository playerRepository, TrainerRepository trainerRepository)
        {
            InitializeComponent();
            SetTeamValues(team, playerRepository, trainerRepository);
        }

        public void SetTeamValues(Team team, PlayerRepository playerRepository, TrainerRepository trainerRepository)
        {
            TrainerList.Items.Clear();
            PlayerList.Items.Clear();

            TeamName.Text = team._name;
            foreach(int id in team._listTrainerIds)
            {
                Trainer t = trainerRepository.GetTrainerById(id);
                TrainerList.Items.Add(new ListViewItem(new string[] { t.Id.ToString(), t.FirstName + " " + t.LastName, t.Email }));
            }

            foreach (int id in team._listPlayerIds)
            {
                Player p = playerRepository.GetPlayerById(id);
                PlayerList.Items.Add(new ListViewItem(new string[] { p.Id.ToString(), p.FirstName + " " + p.LastName, p.Email, p.Age.ToString() }));
            }

        }

        public DialogResult ShowViewModal()
        {
            return this.ShowDialog();
        }
    }
}
