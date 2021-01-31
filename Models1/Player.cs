using System;
using System.Collections.Generic;
using System.Text;

namespace ClubManager.Models
{
    public class Player : Person
    {
        public virtual int? Age { get; set; }
        public virtual Team Team { get; set; }
        public virtual IList<Transaction> Transactions { get; set; }

        public Player(int id, string firstName, string lastName, string email, string password, int age, bool verified) 
            : base(id, firstName, lastName, email, password, verified) { 
            Age = age;
            Transactions = new List<Transaction>();
            Team = null;
        }

        public Player()
        {

        }
    }
}
