using MediatR;
using System;
using TrotIS.Shared;
using UserAPI.Data;

namespace UserAPI.DTOs
{
    public class CreateUser: IRequest<User>
    {
        public string Email { get;}
        public string Password { get;}
        public string FirstName { get;}
        public string LastName { get;}
        public string Phone { get;}
        public DateTime BirthDay { get;}
        public EnumLists.SocialClass SocialClass { get;}
    }
}
