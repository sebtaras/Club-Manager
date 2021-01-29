using ClubManager.BaseLib;
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
    public partial class formTrainerDeleteTraining : Form, ITrainerDeleteTrainingView
    {
        public formTrainerDeleteTraining(string teamName, string trainingStart)
        {
            InitializeComponent();
            TeamName.Text = teamName;
            TrainingTime.Text = trainingStart;
        }

        public DialogResult ShowViewModal()
        {
            return ShowDialog();
        }
    }
}
