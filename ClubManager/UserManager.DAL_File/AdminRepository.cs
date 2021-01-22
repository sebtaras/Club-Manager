using ClubManager.Models;
using ClubManager.Models.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClubManager.DAL_File
{
    public class AdminRepository : IAdminRepository
    {
        public int next_ID = 1;
        public List<Admin> _listAdmins = new List<Admin>();

        public bool Add(Admin admin)
        {
            _listAdmins.Add(admin);
            return true;
        }
    }
}
