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
    public partial class formRegister : Form, IRegisterView
    {
        private IMainController _controller;

        public formRegister()
        {
            InitializeComponent();
        }

        public formRegister(MainController inController)
        {
            _controller = inController;
            InitializeComponent();
        }

        public string Email => EmailInput.Text;

        public string Password => PasswordInput.Text;

        public string FirstName => FirstNameInput.Text;

        public string LastName => LastNameInput.Text;

        public string Role => PlayerRB.Checked ? "Player" : TrainerRB.Checked ? "Trainer" : "";

        public string Age => AgeInput.Text;

        private void SwitchToLogin(object sender, EventArgs e)
        {
            _controller.SwitchToLogin(this);
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

        private void SelectedPlayerRole(object sender, EventArgs e)
        {
            _controller.ShowAgeInput(this);
        }

        private void SelectedTrainerRole(object sender, EventArgs e)
        {
            _controller.HideAgeInput(this);
        }

        public void HideAgeOption()
        {
            AgeInput.Visible = false;
            AgeLabel.Visible = false;
        }

        public void ShowAgeOption()
        {
            AgeInput.Visible = true;
            AgeLabel.Visible = true;
        }

        private void RegisterUser(object sender, EventArgs e)
        {
            if (!_controller.RegisterUser(Email, Password, FirstName, LastName, Role, Age))
                MessageBox.Show("Incorrect register input or email already in use.");
            else
            {
                MessageBox.Show("Registering");
            }
        }
    }
}
