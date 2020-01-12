using System;
using TrotIS.Shared;

namespace UserAPI.Data
{

    public class User
    {
        public Guid UserId { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public DateTime BirthDay { get; set; }
        public EnumLists.SocialClass SocialClass { get; set; }
        public virtual Address Address { get; set; }
        public bool IsAdmin { get; set; }
        public DateTime DTE_CRE { get; set; }

        public static User Create(string email, string password, string firstName, string lastName,
            string phone, DateTime birthDay, EnumLists.SocialClass socialClass)
        {
            return new User
            {
                UserId = Guid.NewGuid(),
                Email = email,
                Password = password,
                FirstName = firstName,
                LastName = lastName,
                Phone = phone,
                BirthDay = birthDay,
                SocialClass = socialClass,
                IsAdmin = false,
                DTE_CRE = DateTime.UtcNow
            };
        }

        public User()
        {
            UserId = Guid.NewGuid();
        }

        public void Update(string firstName, string lastName, string password, Address address)
        {
            if(firstName!=string.Empty)
                FirstName = firstName;
            if(lastName!=string.Empty)
                LastName = lastName;
            if(password!=string.Empty)
                Password = password;
            Address = address;
        }

    }
}
