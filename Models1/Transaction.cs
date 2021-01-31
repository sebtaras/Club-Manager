using System;
using System.Collections.Generic;
using System.Text;

namespace ClubManager.Models
{
    public class Transaction : EntityBase<int>
    {
        public virtual decimal Amount { get; set; }
        public virtual int Year { get; set; }
        public virtual int Month { get; set; }
        public virtual int PlayerId { get; set; }
        public virtual bool Paid { get; set; }

        public Transaction(int id, decimal amount, int playerId, int year, int month) : base(id)
        {
            Amount = amount;
            PlayerId = playerId;
            Year = year;
            Month = month;
            Paid = false;
        }

        public Transaction()
        {

        }
    }
}
