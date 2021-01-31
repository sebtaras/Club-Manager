using System;
using System.Collections.Generic;
using System.Text;

namespace ClubManager.Models
{
    public class Player : Person
    {
        public int Age { get; set; }
        public bool Verified { get; set; }
        public int TeamId { get; set; }
        public IList<int> TransactionIds { get; set; }

        public Player(int id, string firstName, string lastName, string email, string password, int age, bool verified = true) 
            : base(id, firstName, lastName, email, password) { 
            Age = age;
            Verified = verified;
            TransactionIds = new List<int>();
            TeamId = -1;
        }
    }
}
