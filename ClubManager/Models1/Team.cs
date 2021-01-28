using System;
using System.Collections.Generic;
using System.Text;

namespace ClubManager.Models
{
    public class Team : EntityBase<int>
    {
        public string _name { get; set; }
        public List<int> _ages { get; set; }
        public List<Player> _listPlayers { get; set; }
        public List<int> _listPlayerIds { get; set; }
        public List<int> _listTrainingIds { get; set; }
        public List<Trainer> _trainers { get; set; }
        public List<int> _listTrainerIds { get; set; }

        public Team(int id, string name, int lower, int upper): base(id)
        {
            _name = name;
            _ages = new List<int>();
            for (int i = lower; i <= upper; i++)
            {
                _ages.Add(i);
            }
            _trainers = new List<Trainer>();        //
            _listPlayers = new List<Player>();      //
            _listPlayerIds = new List<int>();
            _listTrainerIds = new List<int>();
            _listTrainingIds = new List<int>();
        }
        
    }
}
