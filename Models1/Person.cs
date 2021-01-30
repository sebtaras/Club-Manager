using System;

namespace ClubManager.Models
{
    public abstract class Person : EntityBase<int>
    {
        public static readonly int UndefinedAccID = -1;
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public UserType Type { get; set; }

        public Person(int id, string firstName, string lastName, string email, string password, int type) : base(id)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Password = password;
            Type = (UserType)type;
        }

        public Person() : base(UndefinedAccID)
        {

        }

        public enum UserType : int
        {
            ADMIN = 1,
            TRAINER = 2, 
            PLAYER = 3
        }

    }

    
}