using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClubManager.BaseLib;
using ClubManager.DAL_File;
using ClubManager.Models;

namespace ClubManager.PresentationLayer
{
    public partial class formSettingsPlayer : Form, ISettingsPlayerView
    {
        public string Email => EmailInput.Text;

        public string PasswordCurrent => PasswordInputCurrent.Text;

        public string PasswordNew => PasswordInputNew.Text;

        public formSettingsPlayer(Player player)
        {
            InitializeComponent();
            ShowValues(player);
        }

        private void ShowValues(Player player)
        {
            EmailInput.Text = player.Email;
        }

        public DialogResult ShowViewModal()
        {
            return ShowDialog();
        }
    }
}
