using ClubManager.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClubManager.BaseLib
{
    public interface ITrainerView
    {
        bool ShowViewModaless(IMainController inMainController, Trainer trainer);
    }
}
