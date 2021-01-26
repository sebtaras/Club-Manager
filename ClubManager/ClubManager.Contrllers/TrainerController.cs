using ClubManager.BaseLib;
using ClubManager.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClubManager.Contrllers
{
    class TrainerController
    {
        internal void Homepage(ITrainerView form, MainController inController, Trainer inTrainer)
        {
            form.ShowViewModaless(inController, inTrainer);
        }
    }
}
