using ClubManager.BaseLib;
using ClubManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubManager.PresentationLayer
{
    public class WindowFormsFactory : IWindowFormsFactory
    {
        public ILogInView LoginView()
        {
            return new formLogIn();
        }

        public IRegisterView RegisterView()
        {
            return new formRegister();
        }

        public IAdminView AdminView()
        {
            return new formUIAdmin();
        }

        public IPlayerView PlayerView()
        {
            return new formUIPlayer();
        }

        public ITrainerView TrainerView()
        {
            return new formUITrainer();
        }

        public IVerifyUserView VerifyUserView(Player p, Trainer t)
        {
            return new formVerifyUser(p, t);
        }
    }
}
