using ClubManager.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace ClubManager.BaseLib
{
    public interface IAdminTransactionOptionsView
    {
        DialogResult ShowViewModal();
        void SetValues(Player player, Transaction transaction);

    }
}
