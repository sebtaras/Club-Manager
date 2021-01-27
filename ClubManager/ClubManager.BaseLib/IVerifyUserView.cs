using ClubManager.Models;
using System.Windows.Forms;

namespace ClubManager.BaseLib
{
    public interface IVerifyUserView
    {
        DialogResult ShowViewModal();
        void SetPlayerValues(Player player);
        void SetTrainerValues(Trainer trainer);
    }
}