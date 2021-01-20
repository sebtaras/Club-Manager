using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

            if (!IsValidEmail(email))
            {
                MessageBox.Show("Enter a valid email");
            }
            // Validate login in db
            else if (true)
            {
                MessageBox.Show("Going to homepage");
                //=> go to user's homepage
            }

        }

        // Check valid email
        private bool IsValidEmail(string email)
        {
            try {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
    }
}
