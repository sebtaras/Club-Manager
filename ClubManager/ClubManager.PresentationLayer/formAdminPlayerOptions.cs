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
    public partial class formAdminPlayerOptions : Form, IAdminPlayerOptionsView
    {
        public formAdminPlayerOptions(Player p)
        {
            InitializeComponent();
            SetPlayerValues(p);
        }

        public DialogResult ShowViewModal()
        {
            return this.ShowDialog();
        }

        public void SetPlayerValues(Player player)
        {
            FullName.Text = "Full name: " + player.FirstName + " " + player.LastName;
            Age.Text = "Age: " + player.Age.ToString();
            if (player.team != null)
                CurrentTeam.Text = "Team: " + player.team._name;
            else
                CurrentTeam.Visible = false;
        }
    }
}
