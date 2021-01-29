using System;
using System.Collections.Generic;
using System.Text;

namespace ClubManager.Models.Repositories
{
    public interface ITransactionRepository
    {
        List<Transaction> GetAll();
        bool Add(Transaction transaction);
        int GetNextId();
        void Delete(Transaction transaction);
        Transaction GetTransactionById(int id);

    }
}
