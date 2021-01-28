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
    public partial class formAdminPlayerOptions : Form, IAdminPlayerOptionsView
    {
        public formAdminPlayerOptions(Player p, TeamRepository teamRepository)
        {
            InitializeComponent();
            SetPlayerValues(p, teamRepository);
        }

        public DialogResult ShowViewModal()
        {
            return this.ShowDialog();
        }

        public void SetPlayerValues(Player player, TeamRepository teamRepository)
        {
            FullName.Text = "Full name: " + player.FirstName + " " + player.LastName;
            Age.Text = "Age: " + player.Age.ToString();
            if (player.teamId != -1)
                CurrentTeam.Text = "Team: " + teamRepository.GetTeamById(player.teamId)._name;
            else
                CurrentTeam.Visible = false;
        }
    }
}
