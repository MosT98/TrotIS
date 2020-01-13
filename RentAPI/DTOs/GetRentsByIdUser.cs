using System;
using System.Collections.Generic;
using MediatR;
using RentAPI.Data;

namespace RentAPI.DTOs
{
    public class GetRentsByIdUser : IRequest<List<Rent>>
    {
        public Guid UserId { get; set; }
        public GetRentsByIdUser(Guid userId)
        {
            UserId = userId;
        }
    }
}
