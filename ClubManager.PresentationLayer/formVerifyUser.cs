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
    public partial class FormVerifyUser : Form, IVerifyUserView
    {
        public FormVerifyUser()
        {
            InitializeComponent();
        }

        public DialogResult ShowViewModal()
        {
            return ShowDialog();
        }

        public void SetPlayerValues(Player player)
        {
            FirstName.Text += ": " + player.FirstName;
            LastName.Text += ": " + player.LastName;
            Email.Text += ": " + player.Email;
            Role.Text += ": " + "Player";
            Age.Text += ": " + player.Age.ToString();
        }

        public void SetTrainerValues(Trainer trainer)
        {
            FirstName.Text += ": " + trainer.FirstName;
            LastName.Text += ": " + trainer.LastName;
            Email.Text += ": " + trainer.Email;
            Role.Text += ": " + "Trainer";
            Age.Visible = false;
        }
    }
}
