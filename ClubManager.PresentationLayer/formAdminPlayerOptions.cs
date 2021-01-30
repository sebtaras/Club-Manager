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
using ClubManager.Contrllers;
namespace ClubManager.PresentationLayer
{
    public partial class FormAdminPlayerOptions : Form, IAdminPlayerOptionsView
    {
        private Player player;
        private IAdminController _adminController;
        private IWindowFormsFactory _windowFormsFactory;


        public FormAdminPlayerOptions(Player inPlayer, IWindowFormsFactory windowFormsFactory, IAdminController inAdminController)
        {
            InitializeComponent();
            player = inPlayer;
            _adminController = inAdminController;
            _windowFormsFactory = windowFormsFactory;
        }

        public DialogResult ShowViewModal()
        {
            return ShowDialog();
        }

        public void SetPlayerValues(Player player, List<Team> teams)
        {
            FullName.Text = "Name: " + player.FirstName + " " + player.LastName;
            Age.Text = "Age: " + player.Age.ToString();
            foreach(Team team in teams)
            {
                if (team.ListPlayerIds.Contains(player.Id))
                {
                    CurrentTeam.Text = "Team: " + team.Name;
                    return;
                }
            }
            CurrentTeam.Visible = false;
        }

        public void AdminTransactionOptions(object sender, EventArgs e)
        {
            if (TransactionList.SelectedItems[0] != null)
            {
                int transactionId = int.Parse(TransactionList.SelectedItems[0].SubItems[0].Text);
                var form = _windowFormsFactory.AdminTransactionOptions();
                _adminController.AdminTransactionOptions(this, form, player, transactionId);
            }
        }

        public void DisplayTransactionList(List<Transaction> transactions)
        {
            TransactionList.Items.Clear();

            foreach(Transaction transaction in transactions)
            {
                if(transaction.PlayerId == player.Id)
                {
                    TransactionList.Items.Add(new ListViewItem(new string[] { 
                        transaction.Id.ToString(), 
                        transaction.Year.ToString(), 
                        transaction.Month.ToString(), 
                        transaction.Amount.ToString(), 
                        transaction.Paid.ToString() }));
                }
            }
        }
    }
}
