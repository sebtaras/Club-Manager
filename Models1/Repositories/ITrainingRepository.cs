﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ClubManager.Models.Repositories
{
    public interface ITrainingRepository
    {
        bool Add(Training training);
        void Delete(Training training);
        IList<Training> GetAll();
        int GetNextID();
        Training GetTrainingById(int trainingId);
    }
}
