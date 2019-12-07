using MediatR;
using System;
using TrotIS.Shared;
using UserAPI.Data;

namespace UserAPI.DTOs
{
    public class CreateUser: IRequest<User>
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public DateTime BirthDay { get; set; }
        public EnumLists.SocialClass SocialClass { get; set; }
    }
}
