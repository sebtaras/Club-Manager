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

        public Admin GetAdminByEmail(string email)
        {
            foreach(Admin a in _listAdmins)
            {
                if (a.Email == email)
                    return a;
            }
            return null;
        }

        public List<Admin> GetAll()
        {
            return _listAdmins;
        }

        public Admin GetAdminById(int adminId)
        {
            return _listAdmins.Find(a => a.Id == adminId);
        }

        public bool UpdateAdminValues(Admin admin, string email, string passwordCurrent, string passwordNew)
        {
            foreach (Admin a in _listAdmins)
            {
                if (a.Id == admin.Id)
                {
                    if (a.Password != passwordCurrent)
                        return false;
                    a.Email = email;
                    a.Password = passwordNew;
                    return true;
                }
            }
            return false;
        }
    }
}
