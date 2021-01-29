using ClubManager.Models;
using ClubManager.Models.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClubManager.DAL_File
{
    public class TransactionRepository : ITransactionRepository
    {
        public int next_ID = 1;
        public List<Transaction> _listTransactions = new List<Transaction>();

        public bool Add(Transaction transaction)
        {
            transaction.Id = next_ID;
            next_ID++;
            _listTransactions.Add(transaction);
            return true;
        }

        public List<Transaction> GetAll()
        {
            return _listTransactions;
        }

        public int GetNextId()
        {
            return next_ID;
        }

        public void Delete(Transaction transaction)
        {
            _listTransactions.Remove(transaction);
        }

        public Transaction GetTransactionById(int id)
        {
            return _listTransactions.Find(t => t.Id == id);
        }

        public void ChangeTransactionStatus(Transaction transaction)
        {
            foreach(Transaction t in _listTransactions)
            {
                if(t.Id == transaction.Id)
                {
                    t.Paid = !t.Paid;
                        return;
                }
            }
        }
    }
}
