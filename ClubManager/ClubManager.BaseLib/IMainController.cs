
using System;
using System.Collections.Generic;
using System.Text;

namespace ClubManager.BaseLib
{
    public interface IMainController
    {
        bool LogInUser(string email, string password);
        void LogOut();
        void SwitchToLogin(IRegisterView form);
        void SwitchToRegister(ILogInView form);
    }
}
