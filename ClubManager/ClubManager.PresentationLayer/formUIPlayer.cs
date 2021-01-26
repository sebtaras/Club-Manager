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
    public partial class formUIPlayer : Form, IPlayerView
    {
        public IMainController controller;
        public Player player;
        

        public formUIPlayer()
        {
            InitializeComponent();
        }

        public bool ShowViewModaless(IMainController inController, Player inPlayer)
        {
            controller = inController;
            player = inPlayer;
            if (player.Verified)
            {
                HideVerificationLabel();
                DisplayTransactionList(player.transactions);
                DisplayTrainingList(player.trainings);
            }
            this.Show();
            return true;
        }

        public void HideVerificationLabel()
        {
            this.VerificationLabel.Hide();
        }

        public void DisplayTrainingList(List<Training> trainings)
        {

        }

        public void DisplayTransactionList(List<Transaction> transactions)
        {
            foreach(Transaction t in transactions) {
                listView1.Items.Add(new ListViewItem(new string[] {t.createdOn.Year.ToString(), t.createdOn.Month.ToString(), t.paid.ToString(),  t.amount.ToString() }));
            }
        }

        private void LogOut(object sender, EventArgs e)
        {
            this.Hide();
            controller.LogOut();
        }
    }
}
