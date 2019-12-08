using MediatR;
using System;

namespace UserAPI.DTOs
{
    public class DeleteUser: IRequest 
    {
        public Guid UserId { get; set; }
    }
}
