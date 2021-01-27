using ClubManager.Models;
using ClubManager.Models.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClubManager.DAL_File
{
    public class TeamRepository : ITeamRepository
    {
        public int next_ID = 1;
        public List<Team> _teamList = new List<Team>();

        public bool Add(Team team)
        {
            team.Id = next_ID;
            next_ID++;
            _teamList.Add(team);
            return true;
        }

        public void Delete(Team team)
        {
            throw new NotImplementedException();
        }

        public void AddPlayerToTeam(Player player, PlayerRepository playerRepository)
        {
            Team newTeam = null;
            foreach (Team team in _teamList)
            {
                if (team._ageRange.IndexOf(player.Age) > -1)
                {
                    team._listPlayers.Add(player);
                    newTeam = team;
                }
            }
            if (newTeam != null)
            {
                foreach (Player p in playerRepository._listPlayers)
                {
                    if (p.Email == player.Email)
                    {
                        p.team = newTeam;
                    }
                }
            }
        }

        public void RemovePlayerFromTeam(Player player, PlayerRepository playerRepository)
        {
            foreach (Team team in _teamList)
            {
                if (team._ageRange.IndexOf(player.Age) > -1)
                {
                    team._listPlayers.Remove(player);
                }
            }
            foreach (Player p in playerRepository._listPlayers)
            {
                if (p.Email == player.Email)
                {
                    p.team = null;
                }
            }
        }

        public void DeletePlayer(Player player, PlayerRepository playerRepository)
        {
            foreach (Team team in _teamList)
            {
                if (team._ageRange.IndexOf(player.Age) > -1)
                {
                    team._listPlayers.Remove(player);
                }
            }
            playerRepository._listPlayers.Remove(player);
        }

        public void AddTrainerToTeam(Trainer trainer, TrainerRepository trainerRepository)
        {
            throw new NotImplementedException();
        }

        public void RemoveTrainerFromTeam(Trainer trainer, TrainerRepository trainerRepository)
        {
            throw new NotImplementedException();
        }

        public void DeleteTrainer(Trainer trainer, TrainerRepository trainerRepository)
        {
            throw new NotImplementedException();
        }
    }
}
