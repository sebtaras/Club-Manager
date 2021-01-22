using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using ClubManager.BaseLib;

namespace ClubManager
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void JumpToRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            new RegisterForm().Show();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            var email = EmailInput.Text;
            var password = PasswordInput.Text;

            if (!ValidationFunctions.IsValidEmail(email))
            {
                MessageBox.Show("Enter a valid email");
            }
            // Validate login in db
            else
            {
                MessageBox.Show("Going to homepage");
                // => go to user's homepage
            }

        }

    }
}
