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
    public partial class formVerifyUser : Form, IVerifyUserView
    {
        public formVerifyUser()
        {
            InitializeComponent();
        }

        public formVerifyUser(Player p, Trainer t)
        {
            InitializeComponent();
            if (p != null) SetPlayerValues(p);
            else SetTrainerValues(t);
        }

        public bool ShowViewModal()
        {
            if (this.ShowDialog() == DialogResult.OK)
            {
                return true;
            }
            else
            {
                return false;
            }
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
