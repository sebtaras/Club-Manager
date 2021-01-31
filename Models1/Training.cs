using System;
using System.Collections.Generic;
using System.Text;

namespace ClubManager.Models
{
    public class Training : EntityBase<int>
    {
        public virtual DateTime StartTime { get; set; }
        public virtual DateTime EndTime { get; set; }
        public virtual Team Team { get; set; }
        public virtual Trainer Trainer { get; set; }

        public Training(int id, DateTime startTime, TimeSpan duration, Team team, Trainer trainer): base(id)
        {
            StartTime = startTime;
            EndTime = startTime + duration;
            Team = team;
            Trainer = trainer;
        }

        public Training()
        {

        }
    }
}
