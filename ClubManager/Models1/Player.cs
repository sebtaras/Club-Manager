using System;
using System.Collections.Generic;
using System.Text;

namespace ClubManager.Models
{
    public class Player : Person
    {
        public int Age { get; set; }
        public bool Verified { get; set; }
        public Team team { get; set; }
        public List<Training> trainings {get; set;}

        public List<Transaction> transactions { get; set; }

        public Player(int id, string firstName, string lastName, string email, string password, int age, bool verified = true) 
            : base(id, firstName, lastName, email, password, 3) { 
            Age = age;
            Verified = verified;
            trainings = new List<Training>();
            transactions = new List<Transaction>();
        }

        public void CreateTransaction(Transaction transaction)
        {
            if (!transactions.Contains(transaction))
                transactions.Add(transaction);
        }

        public void AssignTeam(Team team)
        {
            this.team = team;
        }

        //Probably not the way to do it - TEMP
        public void AddTraining(Training training)
        {
            if (!trainings.Contains(training))
                trainings.Add(training);
        }

        public void AddTransaction(Transaction transaction)
        {
            if (!transactions.Contains(transaction))
                transactions.Add(transaction);
        }
    }
}
