using ClubManager.BaseLib;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClubManager.Contrllers
{
    class TrainerController
    {
        internal void Homepage(ITrainerView form, MainController inController)
        {
            form.ShowViewModaless(inController);
        }
    }
}
