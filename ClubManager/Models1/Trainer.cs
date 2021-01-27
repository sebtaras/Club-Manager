using System;
using System.Collections.Generic;
using System.Text;

namespace ClubManager.Models
{
    public class Trainer : Person
    {
        public bool Verified { get; set; }
        public List<Team> _teams { get; set; }
        public List<int> _teamIds { get; set; }

        public Trainer(int id, string firstName, string lastName, string email, string password, bool verified = true) 
            : base(id, firstName, lastName, email, password, 2)
        {
            Verified = verified;
            _teams = new List<Team>();
        }

        public Trainer(int id, string firstName, string lastName, string email, string password, Team team, bool verified = true)
            : base(id, firstName, lastName, email, password, 2)
        {
            Verified = verified;
            _teams = new List<Team>() { team };
        }
    }
}
