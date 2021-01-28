using System;
using System.Collections.Generic;
using System.Text;

namespace ClubManager.Models.Repositories
{
    public interface ITransactionRepository
    {
        void ChangeTransactionStatus(int id);
    }
}
