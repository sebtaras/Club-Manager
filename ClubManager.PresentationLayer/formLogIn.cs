using ClubManager.BaseLib;
using ClubManager.Contrllers;
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
    public partial class FormLogIn : Form, ILogInView
    {
        private IMainController _controller;

        public FormLogIn()
        {
            InitializeComponent();
        }

        public FormLogIn(MainController inController)
        {
            _controller = inController;
            InitializeComponent();
        }

        public string Email => EmailInput.Text;

        public string Password => PasswordInput.Text;

        private void LogInUser(object sender, EventArgs e)
        {
            if (!_controller.LogInUser(EmailInput.Text, PasswordInput.Text))
                MessageBox.Show("Check your credentials.");
            else
            {
                Hide();
            }
        }

        private void SwitchToRegister(object sender, EventArgs e)
        {
            _controller.SwitchToRegister(this);
        }

        public void ShowViewModaless(IMainController inController)
        {
            _controller = inController;
            this.Show();
        }

        public void HideForm()
        {
            this.Hide();
        }
    }
}
