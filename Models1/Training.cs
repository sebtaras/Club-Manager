using System;
using System.Collections.Generic;
using System.Text;

namespace ClubManager.Models
{
    public class Training : EntityBase<int>
    {
        public virtual DateTime StartTime { get; set; }
        public virtual DateTime EndTime { get; set; }
        public virtual int TeamId { get; set; }
        public virtual int TrainerId { get; set; }

        public Training(int id, DateTime startTime, TimeSpan duration, int teamId, int trainerId): base(id)
        {
            StartTime = startTime;
            EndTime = startTime + duration;
            TeamId = teamId;
            TrainerId = trainerId;
        }

        public Training()
        {

        }
    }
}
