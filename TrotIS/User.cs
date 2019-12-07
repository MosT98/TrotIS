using System;

namespace TrotIS.Shared
{
    
    public class User
    {
        public Guid UserId { get; set; }
        public string Email { get;  set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string Phone { get; private set; }
        public DateTime BirthDay { get; private set; }
        public EnumLists.SocialClass SocialClass { get; private set; }
        public virtual Address Address { get; set; }

        public User(string email, string firstName, string lastName, string phone, DateTime birthDay, EnumLists.SocialClass socialClass)
        {
            UserId = Guid.NewGuid();
            Email = email;
            FirstName = firstName;
            LastName = lastName;
            Phone = phone;
            BirthDay = birthDay;
            SocialClass = socialClass;
        }



}
}
