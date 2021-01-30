using ClubManager.DAL_File;
using ClubManager.Models;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ClubManager.BaseLib
{
    public interface IAdminTrainerOptionsView
    {
        string NameAddTeam();
        string NameRemoveTeam();
        DialogResult ShowViewModal();
        void SetTrainerValues(Trainer trainer, List<Team> teams);
    }
}