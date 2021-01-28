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
    public partial class formAdminCreateTransactionsView : Form, IAdminCreateTransactionsView
    {
        private int YEAR_NUM = 5;
        private int YEAR_START = 2021;
        private int MON_NUM = 12;
        public string Year => YearCombo.SelectedValue.ToString();

        public string Month => MonthCombo.SelectedValue.ToString();


        public formAdminCreateTransactionsView()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            var yearData = new ComboItem[YEAR_NUM];
            var monthData = new ComboItem[MON_NUM];
            for (int i = 0; i < YEAR_NUM; i++)
            {
                yearData[i] = new ComboItem((YEAR_START+i).ToString());
            }
            for(int i=1; i <= MON_NUM; i++)
            {
                monthData[i-1] = new ComboItem(i.ToString());
            }
            YearCombo.DataSource = yearData;
            MonthCombo.DataSource = monthData;
        }

        public DialogResult ShowViewModal()
        {
            return this.ShowDialog();
        }

        public string GetMonth()
        {
            return MonthCombo.SelectedValue.ToString();
        }

        public string GetYear()
        {
            return YearCombo.SelectedValue.ToString();
        }
    }
}
