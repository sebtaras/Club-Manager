using ClubManager.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace ClubManager.BaseLib
{
    public interface IAdminPlayerOptionsView
    {
        DialogResult ShowViewModal();
        void SetPlayerValues(Player player);
    }
}
