using ClubManager.DAL_File;
using ClubManager.Models;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ClubManager.BaseLib
{
    public interface IAdminShowTeamView
    {
        DialogResult ShowViewModal();
        void SetTeamValues(Team team, List<Player> players, List<Trainer> trainers);
    }
}