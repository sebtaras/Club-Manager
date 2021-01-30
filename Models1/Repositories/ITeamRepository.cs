using System;
using System.Collections.Generic;
using System.Text;

namespace ClubManager.Models.Repositories
{
    public interface ITeamRepository
    {
        bool Add(Team team);
        void Delete(Team team);
        List<Team> GetAll();
        int GetNextID();
        Team GetTeamById(int id);
        void AddPlayerToTeam(Player player, IPlayerRepository playerRepository);
        void RemovePlayerFromTeam(Player player, IPlayerRepository playerRepository);
        void DeletePlayer(Player player, IPlayerRepository playerRepository);
        void AddTrainerToTeam(Trainer trainer, string teamName, ITrainerRepository trainerRepository);
        void RemoveTrainerFromTeam(Trainer trainer, string teamName, ITrainerRepository trainerRepository);
        void DeleteTrainer(Trainer trainer, ITrainerRepository trainerRepository);

    }
}
