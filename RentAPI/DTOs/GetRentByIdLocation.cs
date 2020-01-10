using MediatR;
using RentAPI.Data;
using System;

namespace RentAPI.DTOs
{
    public class GetRentByIdLocation: IRequest<Rent>
    {
        public Guid LocationId { get; set; }
        public GetRentByIdLocation(Guid locationId)
        {
            LocationId = locationId;
        }
    }
}
