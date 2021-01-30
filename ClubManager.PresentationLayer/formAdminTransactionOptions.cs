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
using ClubManager.Models;

namespace ClubManager.PresentationLayer
{
    public partial class FormAdminTransactionOptions : Form, IAdminTransactionOptionsView
    {
        public FormAdminTransactionOptions()
        {
            InitializeComponent();
        }

        public void SetValues(Player p, Transaction t)
        {
            LabelName.Text = p.FirstName + " " + p.LastName;
            LabelYear.Text = "Year: " + t.Year.ToString();
            LabelMonth.Text = "Month: " + t.Month.ToString();
            string status = t.Paid ? "Yes" : "No";
            LabelPaid.Text = "Paid: " + status;
        }

        public DialogResult ShowViewModal()
        {
            return ShowDialog();
        }
    }
}
