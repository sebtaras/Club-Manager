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

        public string Role => PlayerRB.Checked ? "Player" : TrainerRB.Checked ? "Trainer" : null;

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

    }
}
