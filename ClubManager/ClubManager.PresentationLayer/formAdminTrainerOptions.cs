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
    public partial class formAdminTrainerOptions : Form, IAdminTrainerOptionsView
    {
        public formAdminTrainerOptions(Trainer t)
        {
            InitializeComponent();
            SetTrainerValues(t);
        }

        public DialogResult ShowViewModal()
        {
            return this.ShowDialog();
        }

        public void SetTrainerValues(Trainer trainer)
        {
            FullName.Text = trainer.FirstName + " " + trainer.LastName;
            string teams = "";
            if (trainer._teams.Count > 1)
            {
                foreach (Team t in trainer._teams)
                {
                    teams += t._name + ", ";
                }
                teams = teams.Substring(0, teams.Length - 2);
            }
            else if (trainer._teams.Count == 1)
                teams = trainer._teams[0]._name;
            Teams.Text = teams;
        }
    }
}
