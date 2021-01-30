using ClubManager.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClubManager.Models.Repositories
{
    public interface ITrainerRepository
    {
        bool Add(Trainer trainer);
        Trainer GetTrainerByEmail(string email);
        void Delete(Trainer trainer);
        void Verify(Trainer trainer);
        List<Trainer> GetAll();
        Trainer GetTrainerById(int id);
        bool CheckTrainerExists(Trainer trainer);
        bool UpdateTrainerValues(Trainer trainer, string email, string passwordCurrent, string passwordNew);
    }
}
