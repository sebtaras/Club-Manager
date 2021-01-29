using ClubManager.Models;
using ClubManager.BaseLib;
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
    public partial class formSettingsTrainer : Form, ISettingsTrainerView
    {
        public formSettingsTrainer(Trainer trainer)
        {
            InitializeComponent();
            ShowValues(trainer);
        }

        private void ShowValues(Trainer trainer)
        {
            EmailInput.Text = trainer.Email;
        }

        public string Email => EmailInput.Text;

        public string PasswordCurrent => PasswordInputCurrent.Text;

        public string PasswordNew => PasswordInputNew.Text;

        public DialogResult ShowViewModal()
        {
            return ShowDialog();
        }
    }
}
