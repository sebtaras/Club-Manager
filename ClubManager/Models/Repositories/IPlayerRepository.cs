using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClubManager.Repositories
{
    public interface IPlayerRepository
    {
        bool Add(Player player);
        void Delete(Player player);
        void Verify(Player player);
        List<Player> getAll();

    }
}
