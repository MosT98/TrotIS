using System;

namespace TrotIS.Shared
{
    
    public class User
    {
        public Guid UserId { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public DateTime BirthDay { get; set; }
        public EnumLists.SocialClass SocialClass { get; set; }
        public virtual Address Address { get; set; }
        s
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
