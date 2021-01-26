using ClubManager.Models;

namespace ClubManager.BaseLib
{
    public interface IVerifyUserView
    {
        bool ShowModal(Player player, Trainer trainer);
    }
}