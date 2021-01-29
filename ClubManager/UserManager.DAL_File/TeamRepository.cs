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

        public List<Team> GetAll()
        {
            return _teamList;
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
                if (t.Ages.IndexOf(player.Age) > -1 && !t.ListPlayerIds.Contains(player.Id))
                {
                    t.ListPlayerIds.Add(player.Id);
                    newTeamID = t.Id;
                }
            }
            if (newTeamID != -1)
            {
                foreach (Player p in playerRepository._listPlayers)
                {
                    if (p.Id == player.Id)
                    {
                        p.TeamId = newTeamID;
                    }
                }
            }
        }

        public void RemovePlayerFromTeam(Player player, PlayerRepository playerRepository)
        {
            foreach (Team t in _teamList)
            {
                if (t.Ages.IndexOf(player.Age) > -1)
                {
                    t.ListPlayerIds.Remove(player.Id);
                }
            }
            foreach (Player p in playerRepository._listPlayers)
            {
                if (p.Id == player.Id)
                {
                    p.TeamId = -1;
                }
            }
        }

        public void DeletePlayer(Player player, PlayerRepository playerRepository)
        {
            foreach (Team t in _teamList)
            {
                if (t.Ages.Contains(player.Age))
                {
                    t.ListPlayerIds.Remove(player.Id);
                }
            }
            playerRepository.Delete(player);
        }

        public void AddTrainerToTeam(Trainer trainer, string teamName, TrainerRepository trainerRepository)
        {
            int newTeamID = -1;
            foreach (Team t in _teamList)
            {
                if (t.Name.ToLower() == teamName.ToLower() && !t.ListTrainerIds.Contains(trainer.Id))
                {
                    t.ListTrainerIds.Add(trainer.Id);
                    newTeamID = t.Id;
                }
            }
            if (newTeamID != -1)
            {
                foreach (Trainer t in trainerRepository._listTrainers)
                {
                    if (t.Id == trainer.Id)
                    {
                        t.TeamIds.Add(newTeamID);
                    }
                }
            }
        }

        public void RemoveTrainerFromTeam(Trainer trainer, string teamName, TrainerRepository trainerRepository)
        {
            if(teamName == "" && trainer.TeamIds.Count == 1)
            {
                teamName = GetTeamById(trainer.TeamIds[0]).Name;
            }
            int idToRemove = -1;
            foreach(Team t in _teamList)
            {
                if (t.Name.ToLower() == teamName.ToLower())
                {
                    t.ListTrainerIds.Remove(trainer.Id);
                    idToRemove = t.Id;
                }
            }
            if (idToRemove != -1)
            {
                foreach (Trainer t in trainerRepository._listTrainers)
                {
                    if (t.TeamIds.Contains(idToRemove) && t.Id == trainer.Id)
                    {
                        t.TeamIds.Remove(idToRemove);
                    }
                }
            }
        }

        public void DeleteTrainer(Trainer trainer, TrainerRepository trainerRepository)
        {
            foreach(Team t in _teamList)
            {
                t.ListTrainerIds.Remove(trainer.Id);
            }
            trainerRepository.Delete(trainer);
        }
    }
}
