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
    public partial class FormSettingsAdmin : Form, ISettingsAdminView
    {
        public FormSettingsAdmin(Admin admin)
        {
            InitializeComponent();
            ShowValues(admin);
        }

        private void ShowValues(Admin admin)
        {
            EmailInput.Text = admin.Email;
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
