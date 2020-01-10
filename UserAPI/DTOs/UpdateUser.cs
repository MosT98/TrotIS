﻿using MediatR;
using System;
using TrotIS.Shared;
using UserAPI.Data;

namespace UserAPI.DTOs
{
    public class UpdateUser: IRequest<User>
    {
        public Guid UserId { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public DateTime BirthDay { get; set; }
        public EnumLists.SocialClass SocialClass { get; set; }
        public Address Address { get; set; }
        public bool IsAdmin { get; set; }

    }
}
