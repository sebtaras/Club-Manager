using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace ClubManager.BaseLib
{
    public interface IAdminCreateTransactionsView
    {
        DialogResult ShowViewModal();
        string GetYear();
        string Year { get; }
        string GetMonth();
        string Month { get; }
    }
}
