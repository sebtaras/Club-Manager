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

        public void AddPlayerToTeam(Player player, IPlayerRepository playerRepository)
        {
            Team newTeam = null;
            foreach (Team t in _teamList)
            {
                if (!t.Players.Contains(player) && t.LowerAge <= player.Age && t.UpperAge >= player.Age)
                {
                    t.Players.Add(player);
                    newTeam = t;
                }
            }
            if (newTeam != null)
            {
                foreach (Player p in playerRepository.GetAll())
                {
                    if (p.Id == player.Id)
                    {
                        p.Team = newTeam;
                    }
                }
            }
        }

        public void RemovePlayerFromTeam(Player player, IPlayerRepository playerRepository)
        {
            foreach (Team t in _teamList)
            {
                if (t.LowerAge <= player.Age && t.UpperAge >= player.Age)
                {
                    t.Players.Remove(player);
                }
            }
            foreach (Player p in playerRepository.GetAll())
            {
                if (p.Id == player.Id)
                {
                    p.Team = null;
                }
            }
        }

        public void DeletePlayer(Player player, IPlayerRepository playerRepository)
        {
            foreach (Team t in _teamList)
            {
                if (t.LowerAge <= player.Age && t.UpperAge >= player.Age)
                {
                    t.Players.Remove(player);
                }
            }
            playerRepository.Delete(player);
        }

        public void AddTrainerToTeam(Trainer trainer, string teamName, ITrainerRepository trainerRepository)
        {
            Team newTeam = null;
            foreach (Team t in _teamList)
            {
                if (t.Name.ToLower() == teamName.ToLower() && !t.Trainers.Contains(trainer))
                {
                    t.Trainers.Add(trainer);
                    newTeam = t;
                }
            }
            if (newTeam != null)
            {
                foreach (Trainer t in trainerRepository.GetAll())
                {
                    if (t.Id == trainer.Id)
                    {
                        t.Teams.Add(newTeam);
                    }
                }
            }
        }

        public void RemoveTrainerFromTeam(Trainer trainer, string teamName, ITrainerRepository trainerRepository)
        {
            if(teamName == "" && trainer.Teams.Count == 1)
            {
                teamName = GetTeamById(trainer.Teams[0].Id).Name;
            }
            Team toRemove = null;
            foreach(Team t in _teamList)
            {
                if (t.Name.ToLower() == teamName.ToLower())
                {
                    t.Trainers.Remove(trainer);
                    toRemove = t;
                }
            }
            if (toRemove != null)
            {
                foreach (Trainer t in trainerRepository.GetAll())
                {
                    if (t.Teams.Contains(toRemove) && t.Id == trainer.Id)
                    {
                        t.Teams.Remove(toRemove);
                    }
                }
            }
        }

        public void DeleteTrainer(Trainer trainer, ITrainerRepository trainerRepository)
        {
            foreach(Team t in _teamList)
            {
                t.Trainers.Remove(trainer);
            }
            trainerRepository.Delete(trainer);
        }

        public int GetNextID()
        {
            return next_ID;
        }
    }
}
