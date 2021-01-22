using System;
using System.Collections.Generic;
using System.Text;

namespace Modelsaaaaaaaa.Repositories
{
    interface ITrainerRepository
    {
        bool Add(Trainer trainer);
        void Delete(Trainer trainer);
        void Verify(Trainer trainer);
        List<Trainer> getAll();
    }
}
