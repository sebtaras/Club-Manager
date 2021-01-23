using ClubManager.Models;
using ClubManager.Models.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClubManager.DAL_File
{
    public class TrainerRepository : ITrainerRepository
    {
        public int next_ID = 1;
        public List<Trainer> _listTrainers = new List<Trainer>();

        public bool Add(Trainer trainer)
        {
            trainer.Id = next_ID;
            next_ID++;
            _listTrainers.Add(trainer);
            return true;
        }

        public void Delete(Trainer trainer)
        {
            _listTrainers.Remove(trainer);
        }

        public List<Trainer> GetAll()
        {
            return _listTrainers;
        }

        public void Verify(Trainer trainer)
        {
            throw new NotImplementedException();
        }

        public bool CheckTrainerExists(Trainer trainer)
        {
            foreach(Trainer t in _listTrainers)
            {
                if (t.Email == trainer.Email)
                    return true;
            }
            return false;
        }
    }
}
