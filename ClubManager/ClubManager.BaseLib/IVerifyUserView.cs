using ClubManager.Models;

namespace ClubManager.BaseLib
{
    public interface IVerifyUserView
    {
        bool ShowViewModal();
        void SetPlayerValues(Player player);
        void SetTrainerValues(Trainer trainer);
    }
}