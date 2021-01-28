using System;
using System.Collections.Generic;
using System.Text;

namespace ClubManager.Models
{
    public class Transaction : EntityBase<int>
    {
        public decimal amount { get; set; }
        public DateTime createdOn {get; set;}
        public bool paid { get; set; }

        public Transaction(int id, decimal amount, DateTime createdOn) : base(id)
        {
            this.amount = amount;
            this.createdOn = createdOn;
            paid = false;
        }
    }
}
