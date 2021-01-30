using ClubManager.Models;
using ClubManager.Models.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClubManager.DAL_File
{
    public class TrainingRepository : ITrainingRepository
    {
        public int next_ID = 1;
        public List<Training> _trainings = new List<Training>();

        public bool Add(Training training)
        {
            training.Id = next_ID;
            next_ID++;
            _trainings.Add(training);
            return true;
        }

        public List<Training> GetAll()
        {
            return _trainings;
        }
        public int GetNextID()
        {
            return next_ID;
        }

        public void Delete(int id)
        {
            _trainings.RemoveAll(t => t.Id == id);
        }

        public Training GetTrainingById(int trainingId)
        {
            return _trainings.Find(t => t.Id == trainingId);
        }

    }
}
