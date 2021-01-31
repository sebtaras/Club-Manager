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
    public partial class FormAdminShowTeam : Form, IAdminShowTeamView
    {
        public FormAdminShowTeam()
        {
            InitializeComponent();
        }

        public void SetTeamValues(Team team, List<Player> players, List<Trainer> trainers)
        {
            TrainerList.Items.Clear();
            PlayerList.Items.Clear();

            TeamName.Text = team.Name;
            foreach (Trainer trainer in trainers)
            {
                if (team.Trainers.Contains(trainer))
                {
                    TrainerList.Items.Add(new ListViewItem(new string[] {
                    trainer.Id.ToString(),
                    trainer.FirstName + " " + trainer.LastName,
                    trainer.Email}));
                }
            }
            foreach (Player player in players)
            {
                if (team.Players.Contains(player))
                {
                    PlayerList.Items.Add(new ListViewItem(new string[] {
                    player.Id.ToString(),
                    player.FirstName + " " + player.LastName,
                    player.Email,
                    player.Age.ToString() }));
                }
            }

        }

        public DialogResult ShowViewModal()
        {
            return this.ShowDialog();
        }
    }
}
