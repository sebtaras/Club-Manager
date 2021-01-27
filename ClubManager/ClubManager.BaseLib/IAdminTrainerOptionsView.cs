using ClubManager.Models;
using System.Windows.Forms;

namespace ClubManager.BaseLib
{
    public interface IAdminTrainerOptionsView
    {
        DialogResult ShowViewModal();
        void SetTrainerValues(Trainer trainer);
    }
}