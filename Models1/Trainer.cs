using System;
using System.Collections.Generic;
using System.Text;

namespace ClubManager.Models
{
    public class Trainer : Person
    {
        public bool Verified { get; set; }
        public IList<int> TeamIds { get; set; }

        public Trainer(int id, string firstName, string lastName, string email, string password, bool verified = true) 
            : base(id, firstName, lastName, email, password)
        {
            Verified = verified;
            TeamIds = new List<int>();
        }
    }
}
