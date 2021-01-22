using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ClubManager.BaseLib;

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

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            bool[] valid = { false, false, false, false, false};
            var email = EmailInput.Text;
            var password = PasswordInput.Text;
            var firstName = FirstNameInput.Text;
            var lastName = LastNameInput.Text;
            string[] names = { firstName, lastName };

            if (!ValidationFunctions.IsValidEmail(email)) 
                MessageBox.Show("Enter a valid email");
            else valid[0] = true;

            if (!ValidationFunctions.IsValidPassword(password))
                MessageBox.Show("Password must be over 6 characters long");
            else valid[1] = true;

            if (!ValidationFunctions.IsValidName(names))
                MessageBox.Show("Enter your first and last name");
            else valid[2] = true;

            if (!(PlayerRadioButton.Checked || TrainerRadioButton.Checked))
                MessageBox.Show("Please select a role");
            else valid[3] = true;

            if (PlayerRadioButton.Checked && !ValidationFunctions.IsValidAge(AgeInput.Text))
                MessageBox.Show("Age should be between 6 and 30");
            else valid[4] = true;

            if(PlayerRadioButton.Checked && valid[0] && valid[1] && valid[2] && valid[3] && valid[4])
            {
                MessageBox.Show("Adding player");
                // => add player to database
            }
            else if(TrainerRadioButton.Checked && valid[0] && valid[1] && valid[2] && valid[3])
            {
                MessageBox.Show("Adding trainer");
                // => add trainer to database
            }
        }
    }
}
