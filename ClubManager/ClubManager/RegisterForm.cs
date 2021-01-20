using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ClubManager
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void PlayerRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            AgeLabel.Visible = true;
            AgeInput.Visible = true;
        }

        private void TrainerRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            AgeLabel.Visible = false;
            AgeInput.Visible = false;
        }

        private void JumpToLogin_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            new LoginForm().Show();
        }
    }
}
