using System;
using System.Collections.Generic;
using System.Text;

namespace ClubManager.Models
{
    public class Training : EntityBase<int>
    {
        public DateTime StartTime { get; set; }
        public TimeSpan Duration { get; set; }
        public DateTime EndTime { get; set; }
        public int TeamId { get; set; }
        public int TrainerId { get; set; }

        public Training(int id, DateTime startTime, TimeSpan duration, int teamId, int trainerId): base(id)
        {
            StartTime = startTime;
            Duration = duration;
            EndTime = startTime + duration;
            TeamId = teamId;
            TrainerId = trainerId;
        }
    }
}
