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
            int overlaps = 0;

            //ova provjera u neki kontroller vjv
            /*foreach(Training t in _trainings)
            {
                if (t._startTime <= training._startTime && t._endTime > training._endTime)
                    overlaps++;
                else if (training._endTime > t._startTime && training._endTime < t._endTime)
                    overlaps++;
                else if (training._startTime < t._startTime && training._endTime > t._endTime)
                    overlaps++;
                if (overlaps > 2)
                    return false;
            }*/
            _trainings.Add(training);
            return true;
        }

        public void Delete(Training training)
        {
            _trainings.Remove(training);
        }
    }
}
