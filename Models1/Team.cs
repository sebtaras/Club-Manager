using System;
using System.Collections.Generic;
using System.Text;

namespace ClubManager.Models
{
    public class Team : EntityBase<int>
    {
        public virtual string Name { get; set; }
        public virtual int LowerAge { get; set; }
        public virtual int UpperAge { get; set; }
        public virtual IList<Player> Players { get; set; }
        public virtual IList<Training> Trainings { get; set; }
        public virtual IList<Trainer> Trainers { get; set; }

        public Team(int id, string name, int lower, int upper): base(id)
        {
            Name = name;
            LowerAge = lower;
            UpperAge = upper;
            Players = new List<Player>();
            Trainings = new List<Training>();
            Trainers = new List<Trainer>();
        }

        public Team()
        {

        }
    }
}
