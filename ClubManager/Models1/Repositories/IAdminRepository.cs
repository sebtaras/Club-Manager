using System;
using System.Collections.Generic;
using System.Text;

namespace ClubManager.Models.Repositories
{
    public interface IAdminRepository
    {
        bool Add(Admin admin);
    }
}
