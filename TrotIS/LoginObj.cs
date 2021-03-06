﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TrotIS.Shared
{
    public class LoginObj
    {
        public string Hash { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool IsAdmin { get; set; }
        public Guid UserID { get; set; }

        public LoginObj(Guid userId, string hash, string firstName, string lastName, bool isAdmin)
        {
            Hash = hash;
            FirstName = firstName;
            LastName = lastName;
            IsAdmin = isAdmin;
            UserID = userId;
        }
    }
}
