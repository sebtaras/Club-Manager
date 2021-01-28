using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace ClubManager.BaseLib
{
    public interface IPlayerSettingsView
    {
        DialogResult ShowViewModal();
        string Email { get; }
        string PasswordCurrent { get; }
        string PasswordNew { get; }
    }
}
