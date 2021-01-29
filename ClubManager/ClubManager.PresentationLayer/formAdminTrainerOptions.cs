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
    public partial class formAdminTrainerOptions : Form, IAdminTrainerOptionsView
    {
        public string NameAddTeam()
        {
            var value = TeamNameAdd.SelectedValue;
            if (value != null)
                return TeamNameAdd.SelectedValue.ToString();
            else
                return "";
        }
        public string NameRemoveTeam()
        {
            var value = TeamNameRemove.SelectedValue;
            if (value != null)
                return TeamNameRemove.SelectedValue.ToString();
            else
                return "";
        }

        public formAdminTrainerOptions()
        {
            InitializeComponent();
        }

        public DialogResult ShowViewModal()
        {
            return ShowDialog();
        }

        public void SetTrainerValues(Trainer trainer, List<Team> teams)
        {
            List<string> nameList = new List<string>();

            if (trainer.TeamIds.Count > 1)
            {
                foreach (Team team in teams)
                {
                    if (trainer.TeamIds.Contains(team.Id))
                    {
                        nameList.Add(team.Name);
                    }
                }
            }

            var dataAddCombo = new ComboItem[teams.Count - trainer.TeamIds.Count];
            var dataRemoveCombo = new ComboItem[trainer.TeamIds.Count];
            int i = 0;
            int j = 0;

            foreach (Team team in teams)
            {
                if (!trainer.TeamIds.Contains(team.Id))
                    dataAddCombo[i++] = new ComboItem(team.Name);
                if (trainer.TeamIds.Contains(team.Id))
                    dataRemoveCombo[j++] = new ComboItem(team.Name);
            }

            TeamNameAdd.DataSource = dataAddCombo;
            TeamNameRemove.DataSource = dataRemoveCombo;
            FullName.Text = "Name: " + trainer.FirstName + " " + trainer.LastName;
            Teams.Text = "Teams: " + string.Join(", ", nameList);
        }
    }
}
