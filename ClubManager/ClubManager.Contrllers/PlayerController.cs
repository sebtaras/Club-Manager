using ClubManager.BaseLib;
using ClubManager.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClubManager.Contrllers
{
    class PlayerController
    {
        internal void Homepage(IPlayerView form, IMainController inController, Player player)
        {
            form.ShowViewModaless(inController, player);
        }
    }
}
