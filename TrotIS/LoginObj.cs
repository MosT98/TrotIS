using System;
using System.Collections.Generic;
using System.Text;

namespace TrotIS.Shared
{
    public class LoginObj
    {
        public string Hash { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public LoginObj(string hash, string firstName, string lastName)
        {
            Hash = hash;
            FirstName = firstName;
            LastName = lastName;
        }
    }
}
