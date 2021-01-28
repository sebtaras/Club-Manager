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
    public partial class formTrainerCreateTraining : Form, ITrainerCreateTrainingView
    {
        public formTrainerCreateTraining(Trainer trainer, TrainingRepository trainingRepository, TeamRepository teamRepository)
        {
            InitializeComponent();
            LoadData(trainer, teamRepository);
        }

        private void LoadData(Trainer trainer, TeamRepository teamRepository)
        {
            StartTimePicker.CustomFormat = "MM/dd/yyy HH:mm";
            StartTimePicker.Format = DateTimePickerFormat.Custom;
            StartTimePicker.ShowUpDown = true;

            var dataTeamCombo = new ComboItem[trainer._teamIds.Count];

            int i = 0;
            foreach(Team t in teamRepository._teamList)
            {
                if (trainer._teamIds.Contains(t.Id))
                    dataTeamCombo[i++] = new ComboItem(t._name);
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
