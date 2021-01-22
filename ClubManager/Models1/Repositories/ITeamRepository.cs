using System;
using System.Collections.Generic;
using System.Text;

namespace ClubManager.Models.Repositories
{
    public interface ITeamRepository
    {
        bool Add(Team team);
        void Delete(Team team);
    }
}
