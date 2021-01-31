﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ClubManager.Models
{
    public class Team : EntityBase<int>
    {
        public string Name { get; set; }
        public IList<int> Ages { get; set; }
        public IList<int> ListPlayerIds { get; set; }
        public IList<int> ListTrainingIds { get; set; }
        public IList<int> ListTrainerIds { get; set; }

        public Team(int id, string name, int lower, int upper): base(id)
        {
            Name = name;
            Ages = new List<int>();
            ListPlayerIds = new List<int>();
            ListTrainerIds = new List<int>();
            ListTrainingIds = new List<int>();
            for (int i = lower; i <= upper; i++)
            {
                Ages.Add(i);
            }
        }
        
    }
}
