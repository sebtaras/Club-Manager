using System;
using System.Collections.Generic;
using System.Text;

namespace ClubManager.Models
{
    public class Transaction : EntityBase<int>
    {
        public decimal Amount { get; set; }
        public int Year { get; set; }
        public int Month { get; set; }
        public int PlayerId { get; set; }
        public bool Paid { get; set; }

        public Transaction(int id, decimal amount, int playerId, int year, int month) : base(id)
        {
            Amount = amount;
            PlayerId = playerId;
            Year = year;
            Month = month;
            Paid = false;
        }
    }
}
