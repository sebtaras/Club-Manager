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
    public partial class FormTrainerCreateTraining : Form, ITrainerCreateTrainingView
    {
        public FormTrainerCreateTraining()
        {
            InitializeComponent();
        }

        public void LoadData(Trainer trainer, List<Team> teams)
        {
            StartTimePicker.CustomFormat = "dd/MM/yyy HH:mm";
            StartTimePicker.Format = DateTimePickerFormat.Custom;
            StartTimePicker.ShowUpDown = true;

            var dataTeamCombo = new ComboItem[trainer.Teams.Count];

            int i = 0;
            foreach(Team team in teams)
            {
                if (trainer.Teams.Contains(team))
                    dataTeamCombo[i++] = new ComboItem(team.Name);
            }
            TeamCombo.DataSource = dataTeamCombo;
        }

        public DateTime StartTime => StartTimePicker.Value;

        public string Duration => DurationInput.Text;

        public string TeamName()
        {
            var value = TeamCombo.SelectedValue;
            if (value != null)
                return value.ToString();
            else
                return "";
        }

        public DialogResult ShowViewModal()
        {
            return ShowDialog();
        }

        private void CreateTraining(object sender, EventArgs e)
        {
            MessageBox.Show(StartTimePicker.Value.ToString());
        }

    }
}
