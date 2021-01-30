using System;

namespace ClubManager.Models
{
    public abstract class Person : EntityBase<int>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public Person(int id, string firstName, string lastName, string email, string password) : base(id)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Password = password;
        }
    }

    
}