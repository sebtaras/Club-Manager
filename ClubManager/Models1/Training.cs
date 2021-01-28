using System;
using System.Collections.Generic;
using System.Text;

namespace ClubManager.Models
{
    public class Training : EntityBase<int>
    {
        public DateTime _startTime { get; set; }
        public TimeSpan _duration { get; set; }
        public DateTime _endTime { get; set; }
        public Team _team { get; set; }
        public int _teamId { get; set; }

        public Training(int id, DateTime startTime, TimeSpan duration, Team team, int teamId)
            : base(id)
        {
            _startTime = startTime;
            _duration = duration;
            _endTime = startTime + duration;
            _team = team;
            _teamId = teamId;
        }
    }
}
