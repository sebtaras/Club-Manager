using System;
using System.Collections.Generic;
using System.Text;

namespace ClubManager.Models.Repositories
{
    public interface IPlayerRepository
    {
        bool Add(Player player);
        void Delete(Player player);
        void Verify(Player player);
        List<Player> GetAll();
        //Player getPlayer();
        bool CheckPlayerExists(Player player);

    }
}
