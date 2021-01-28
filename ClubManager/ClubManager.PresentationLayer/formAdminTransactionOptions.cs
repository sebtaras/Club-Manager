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
    public partial class formAdminTransactionOptions : Form, IAdminTransactionOptionsView
    {
        public formAdminTransactionOptions(Player p, Transaction t)
        {
            InitializeComponent();
            SetValues(p, t);
        }

        private void SetValues(Player p, Transaction t)
        {
            LabelName.Text = p.FirstName + " " + p.LastName;
            LabelYear.Text = t._year.ToString();
            LabelMonth.Text = "Month: " + t._month.ToString();
            string status = t._paid ? "Yes" : "No";
            LabelPaid.Text = "Paid: " + status;
        }

        public DialogResult ShowViewModal()
        {
            return ShowDialog();
        }
    }
}
