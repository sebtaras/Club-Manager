using ClubManager.Models;
using ClubManager.Models.Repositories;
using System;
using System.Collections.Generic;

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

        public Trainer GetTrainerById(int id)
        {
            return _listTrainers.Find(t => t.Id == id);
        }

        public Trainer GetTrainerByEmail(string email)
        {
            foreach (Trainer t in _listTrainers)
            {
                if (t.Email == email)
                    return t;
            }
            return null;
        }

        public List<Trainer> GetAll()
        {
            return _listTrainers;
        }

        public void Verify(Trainer trainer)
        {
            foreach(Trainer t in _listTrainers)
            {
                if(t.Email == trainer.Email)
                {
                    t.Verified = true;
                }
            }
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

        public bool UpdatePlayerValues(Trainer trainer, string email, string passwordCurrent, string passwordNew)
        {
            foreach (Trainer t in _listTrainers)
            {
                if (t.Id == trainer.Id)
                {
                    if (t.Password != passwordCurrent)
                        return false;
                    t.Email = email;
                    t.Password = passwordNew;
                    return true;
                }
            }
            return false;
        }
    }
}
