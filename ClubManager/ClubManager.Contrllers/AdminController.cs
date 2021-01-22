using ClubManager.BaseLib;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClubManager.Contrllers
{
    class AdminController
    {
        internal void Homepage(IAdminView form, IMainController inController)
        {
            form.ShowViewModaless(inController);
        }
    }
}
