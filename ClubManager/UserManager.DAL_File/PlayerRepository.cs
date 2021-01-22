using ClubManager.Models;
using ClubManager.Models.Repositories;
using System;
using System.Collections.Generic;

namespace ClubManager.DAL_File
{
    public class PlayerRepository : IPlayerRepository
    {
        public int next_ID = 1;
        public List<Player> _listPlayers = new List<Player>();

        public bool Add(Player player)
        {
            player.Id = next_ID;
            next_ID++;
            _listPlayers.Add(player);
            return true;
        }

        public void Delete(Player player)
        {
            _listPlayers.Remove(player);
        }

        public List<Player> GetAll()
        {
            return _listPlayers;
        }

        public void Verify(Player player)
        {
            /*foreach(Player p in _listPlayers)
            {
                if(p.Email == player.Email)
                {
                    p.Verified = true;
                }
            }*/
        }

        public bool CheckPlayerExists(Player player)
        {
            if (_listPlayers.IndexOf(player) > -1)
                return true;
            return false;
        }

    }
}
