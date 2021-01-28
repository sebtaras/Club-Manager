using System;
using System.Collections.Generic;
using System.Text;

namespace ClubManager.Models
{
    public class Transaction : EntityBase<int>
    {
        public decimal _amount { get; set; }
        public int _year { get; set; }
        public int _month { get; set; }
        public int _playerId { get; set; }
        public bool _paid { get; set; }

        public Transaction(int id, decimal amount, int playerId, int year, int month) : base(id)
        {
            _amount = amount;
            _playerId = playerId;
            _year = year;
            _month = month;
            _paid = false;
        }
    }
}
