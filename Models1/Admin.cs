using System;
using System.Collections.Generic;
using System.Text;

namespace ClubManager.Models
{
    public class Admin : Person
    {
        public Admin(int id, string firstName, string lastName, string email, string password) 
            : base(id, firstName, lastName, email, password, true)
        {

        }

        public Admin()
        {

        }
    }
}
