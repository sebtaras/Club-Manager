﻿using ClubManager.BaseLib;
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
    public partial class formUIPlayer : Form, IPlayerView
    {
        public IMainController controller;

        public formUIPlayer()
        {
            InitializeComponent();
        }

        public bool ShowViewModaless(IMainController inController)
        {
            controller = inController;
            this.Show();
            return true;
        }

        private void LogOut(object sender, EventArgs e)
        {
            this.Hide();
            controller.LogOut();
        }
    }
}