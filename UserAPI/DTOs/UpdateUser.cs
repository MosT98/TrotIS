using MediatR;
using System;
using TrotIS.Shared;
using UserAPI.Data;

namespace UserAPI.DTOs
{
    public class UpdateUser: IRequest<User>
    {
        public Guid UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public int Number { get; set; }
    }
}
