using System;
using System.Collections.Generic;
using System.Text;

namespace ClubManager.Models
{
    public class Trainer : Person
    {
        public virtual IList<Team> Teams { get; set; }

        public Trainer(int id, string firstName, string lastName, string email, string password, bool verified) 
            : base(id, firstName, lastName, email, password, verified)
        {
            Teams = new List<Team>();
        }

        public Trainer()
        {

        }
    }
}
