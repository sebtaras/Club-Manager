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
            if (_teamList.IndexOf(team) < 0)
                return false;

            _teamList.Add(team);
            return true;
        }

        public void Delete(Team team)
        {
            throw new NotImplementedException();
        }
    }
}
