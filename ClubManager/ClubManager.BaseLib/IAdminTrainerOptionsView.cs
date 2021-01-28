using ClubManager.DAL_File;
using ClubManager.Models;
using System.Windows.Forms;

namespace ClubManager.BaseLib
{
    public interface IAdminTrainerOptionsView
    {
        string NameAddTeam();
        string NameRemoveTeam();
        DialogResult ShowViewModal();
        void SetTrainerValues(Trainer trainer, TeamRepository teamRepository);
    }
}