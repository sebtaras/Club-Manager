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
            _teamList.Remove(team);
            
        }
        public Team GetTeamById(int id)
        {
            return _teamList.Find(t => t.Id == id);
        }

        public void AddPlayerToTeam(Player player, PlayerRepository playerRepository)
        {
            int newTeamID = -1;
            foreach (Team t in _teamList)
            {
                if (t._ages.IndexOf(player.Age) > -1)
                {
                    t._listPlayerIds.Add(player.Id);
                    newTeamID = t.Id;
                }
            }
            if (newTeamID != -1)
            {
                foreach (Player p in playerRepository._listPlayers)
                {
                    if (p.Email == player.Email)
                    {
                        p.teamId = newTeamID;
                    }
                }
            }
        }

        public void RemovePlayerFromTeam(Player player, PlayerRepository playerRepository)
        {
            foreach (Team t in _teamList)
            {
                if (t._ages.IndexOf(player.Age) > -1)
                {
                    t._listPlayerIds.Remove(player.Id);
                }
            }
            foreach (Player p in playerRepository._listPlayers)
            {
                if (p.Id == player.Id)
                {
                    p.teamId = -1;
                }
            }
        }

        public void DeletePlayer(Player player, PlayerRepository playerRepository)
        {
            foreach (Team t in _teamList)
            {
                if (t._ages.Contains(player.Age))
                {
                    t._listPlayerIds.Remove(player.Id);
                }
            }
            playerRepository.Delete(player);
        }

        public void AddTrainerToTeam(Trainer trainer, string teamName, TrainerRepository trainerRepository)
        {
            int newTeamID = -1;
            foreach (Team t in _teamList)
            {
                if (t._name.ToLower() == teamName.ToLower() && !t._listTrainerIds.Contains(trainer.Id))
                {
                    t._listTrainerIds.Add(trainer.Id);
                    newTeamID = t.Id;
                }
            }
            if (newTeamID != -1)
            {
                foreach (Trainer t in trainerRepository._listTrainers)
                {
                    if (t.Id == trainer.Id)
                    {
                        t._teamIds.Add(newTeamID);
                    }
                }
            }
        }

        public void RemoveTrainerFromTeam(Trainer trainer, string teamName, TrainerRepository trainerRepository)
        {
            if(teamName == "" && trainer._teamIds.Count == 1)
            {
                teamName = GetTeamById(trainer._teamIds[0])._name;
            }
            int idToRemove = -1;
            foreach(Team t in _teamList)
            {
                if (t._name.ToLower() == teamName.ToLower())
                {
                    t._listTrainerIds.Remove(trainer.Id);
                    idToRemove = t.Id;
                }
            }
            if (idToRemove != -1)
            {
                foreach (Trainer t in trainerRepository._listTrainers)
                {
                    if (t._teamIds.Contains(idToRemove))
                    {
                        t._teamIds.Remove(idToRemove);
                    }
                }
            }
        }

        public void DeleteTrainer(Trainer trainer, TrainerRepository trainerRepository)
        {
            foreach(Team t in _teamList)
            {
                t._listTrainerIds.Remove(trainer.Id);
            }
            trainerRepository.Delete(trainer);
        }
    }
}
