using ClubManager.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClubManager.Models.Repositories
{
    public interface ITrainerRepository
    {
        bool Add(Trainer trainer);
        void Delete(Trainer trainer);
        void Verify(Trainer trainer);
        List<Trainer> GetAll();
        //Trainer getTrainer();
        bool CheckTrainerExists(Trainer trainer);
    }
}
