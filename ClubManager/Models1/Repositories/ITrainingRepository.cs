using System;
using System.Collections.Generic;
using System.Text;

namespace ClubManager.Models.Repositories
{
    public interface ITrainingRepository
    {
        bool Add(Training training);
        void Delete(int id);
        List<Training> GetAll();
        int GetNextID();
    }
}
