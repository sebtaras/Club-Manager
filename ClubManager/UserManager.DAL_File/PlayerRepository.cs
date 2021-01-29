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

        public Player GetPlayerById(int id)
        {
            return _listPlayers.Find(p => p.Id == id);
        }

        public Player GetPlayerByEmail(string email)
        {
            foreach(Player p in _listPlayers)
            {
                if (p.Email == email)
                    return p;
            }
            return null;
        }

        public bool UpdatePlayerValues(Player player, string email, string passwordCurrent, string passwordNew)
        {
            foreach(Player p in _listPlayers)
            {
                if(p.Id == player.Id)
                {
                    if (p.Password != passwordCurrent)
                        return false;
                    p.Email = email;
                    p.Password = passwordNew;
                    return true;
                }
            }
            return false;
        }

        public void Verify(Player player)
        {
            foreach (Player p in _listPlayers)
            {
                if (p.Email == player.Email)
                {
                    p.Verified = true;
                }
            }
        }

        public bool CheckPlayerExists(Player player)
        {
            foreach(Player p in _listPlayers)
            {
                if (p.Email == player.Email)
                    return true;
            }
            return false;
        }

        public void DeleteTransaction(Player player, Transaction t)
        {
            foreach(Player p in _listPlayers)
            {
                if (p.Id == player.Id)
                {
                    foreach (int id in p.TransactionIds)
                    {
                        if (id == t.Id)
                        {
                            p.TransactionIds.Remove(id);
                            return;
                        }
                    }
                }
            }
        }
    }
}
