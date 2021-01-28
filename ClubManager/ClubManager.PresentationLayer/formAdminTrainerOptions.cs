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
            var value = this.TeamNameAdd.SelectedValue;
            if (value != null)
                return this.TeamNameAdd.SelectedValue.ToString();
            else
                return "";
        }
        public string NameRemoveTeam()
        {
            var value = this.TeamNameRemove.SelectedValue;
            if (value != null)
                return this.TeamNameRemove.SelectedValue.ToString();
            else
                return "";
        }

        public formAdminTrainerOptions(Trainer t, TeamRepository teamRepository)
        {
            InitializeComponent();
            SetTrainerValues(t, teamRepository);
        }

        public DialogResult ShowViewModal()
        {
            return this.ShowDialog();
        }

        public void SetTrainerValues(Trainer trainer, TeamRepository teamRepository)
        {
            FullName.Text = "Name: " + trainer.FirstName + " " + trainer.LastName;

            string teams = "";
            if (trainer._teamIds.Count > 1)
            {
                foreach (int id in trainer._teamIds)
                {
                    teams += teamRepository.GetTeamById(id)._name + ", ";
                }
                teams = teams.Substring(0, teams.Length - 2);
            }
            else if (trainer._teamIds.Count == 1)
                teams = teamRepository.GetTeamById(trainer._teamIds[0])._name;
            Teams.Text = "Teams: " + teams;

            var dataAddCombo = new ComboItem[teamRepository._teamList.Count - trainer._teamIds.Count];
            var dataRemoveCombo = new ComboItem[trainer._teamIds.Count];
            int i = 0;
            int j = 0;
            foreach (Team t in teamRepository._teamList)
            {
                if(!trainer._teamIds.Contains(t.Id))
                    dataAddCombo[i++] = new ComboItem(t._name);
                if (trainer._teamIds.Contains(t.Id))
                    dataRemoveCombo[j++] = new ComboItem(t._name);
            }
            TeamNameAdd.DataSource = dataAddCombo;
            TeamNameRemove.DataSource = dataRemoveCombo;
        }
    }
}
