using ClubManager.BaseLib;
using ClubManager.DAL_File;
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
    public partial class formAdminPlayerOptions : Form, IAdminPlayerOptionsView
    {
        public formAdminPlayerOptions(Player p, TeamRepository teamRepository, TransactionRepository transactionRepository)
        {
            InitializeComponent();
            SetPlayerValues(p, teamRepository, transactionRepository);
        }

        public DialogResult ShowViewModal()
        {
            return this.ShowDialog();
        }

        public void SetPlayerValues(Player player, TeamRepository teamRepository, TransactionRepository transactionRepository)
        {
            FullName.Text = "Full name: " + player.FirstName + " " + player.LastName;
            Age.Text = "Age: " + player.Age.ToString();
            if (player.teamId != -1)
                CurrentTeam.Text = "Team: " + teamRepository.GetTeamById(player.teamId)._name;
            else
                CurrentTeam.Visible = false;

            TransactionList.Items.Clear();
            foreach(Transaction t in transactionRepository._listTransactions)
            {
                if(t._playerId == player.Id)
                {
                    TransactionList.Items.Add(new ListViewItem(new string[] { t.Id.ToString(), t._year.ToString(), t._month.ToString(), t._amount.ToString(), t._paid.ToString() }));
                }
            }
        }
    }
}
