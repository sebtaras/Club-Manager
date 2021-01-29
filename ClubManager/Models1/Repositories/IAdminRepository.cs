using System;
using System.Collections.Generic;
using System.Text;

namespace ClubManager.Models.Repositories
{
    public interface IAdminRepository
    {
        bool Add(Admin admin);
        Admin GetAdminByEmail(string email);
        bool UpdateAdminValues(Admin admin, string email, string passwordCurrent, string passwordNew);
    }
}
