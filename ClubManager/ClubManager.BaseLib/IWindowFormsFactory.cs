﻿using ClubManager.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClubManager.BaseLib
{
    public interface IWindowFormsFactory
    {
        ILogInView LoginView();
        IRegisterView RegisterView();
        IPlayerView PlayerView();
        ITrainerView TrainerView();
        IAdminView AdminView();
        IVerifyUserView VerifyUserView(Player p, Trainer t);
        IAdminPlayerOptionsView AdminPlayerOptionsView(Player p);
        IAdminTrainerOptionsView AdminTrainerOptionsView(Trainer t);
    }
}
