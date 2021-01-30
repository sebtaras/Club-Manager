using System;
using System.Collections.Generic;
using System.Text;

namespace ClubManager.Models
{
    public class Trainer : Person
    {
        public bool Verified { get; set; }
        public List<Team> Teams { get; set; }
        public List<int> TeamIds { get; set; }

        public Trainer(int id, string firstName, string lastName, string email, string password, bool verified = true) 
            : base(id, firstName, lastName, email, password, 2)
        {
            Verified = verified;
            Teams = new List<Team>();
            TeamIds = new List<int>();
        }

        public Trainer(int id, string firstName, string lastName, string email, string password, Team team, bool verified = true)
            : base(id, firstName, lastName, email, password, 2)
        {
            Verified = verified;
            Teams = new List<Team>() { team };
        }
    }
}
