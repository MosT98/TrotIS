using MediatR;
using RentAPI.Data;
using System;

namespace RentAPI.DTOs
{
    public class GetRentByIdUser : IRequest<Rent>
    {
        public Guid UserId { get; set; }
        public GetRentByIdUser(Guid userId)
        {
            UserId = userId;
        }
    }
}
