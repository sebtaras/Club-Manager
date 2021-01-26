using System;
using System.Collections.Generic;
using System.Text;

namespace ClubManager.Models
{
    public class Team : EntityBase<int>
    {
        public string _name { get; set; }
        public List<Player> _listPlayers { get; set; }
        public List<Training> _trainings { get; set; }
        public Trainer _trainer { get; set; }
        public List<int> _ageRange { get; set; }

        public Team(int id, string name, int lower, int upper, Trainer trainer, List<Player> listPlayers)
            : base(id)
        {
            _name = name;
            _trainer = trainer;
            _listPlayers = listPlayers;
            _ageRange = new List<int>();
            for(int i=lower; i<=upper; i++)
            {
                _ageRange.Add(i);
            }
        }

        public bool AddPlayerToTeam(Player player)
        {
            if (_listPlayers.IndexOf(player) > 0)
            {
                _listPlayers.Add(player);
                return true;
            }
            return false;
        }
    }
}
