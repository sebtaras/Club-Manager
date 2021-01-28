using ClubManager.DAL_File;
using ClubManager.Models;
using System.Windows.Forms;

namespace ClubManager.BaseLib
{
    public interface IAdminShowTeamView
    {
        DialogResult ShowViewModal();
        void SetTeamValues(Team team, PlayerRepository playerRepository, TrainerRepository trainerRepository);
    }
}