using System;

namespace ClubManager.Models
{
    public abstract class Person : EntityBase<int>
    {
        public virtual string FirstName { get; set; }
        public virtual string LastName { get; set; }
        public virtual string Email { get; set; }
        public virtual string Password { get; set; }
        public virtual bool Verified { get; set; }

        public Person(int id, string firstName, string lastName, string email, string password, bool verified) : base(id)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Password = password;
            Verified = verified;
        }

        public Person()
        {

        }
    }

    
}