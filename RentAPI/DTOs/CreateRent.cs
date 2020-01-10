using MediatR;
using RentAPI.Data;
using System;

namespace RentAPI.DTOs
{
    public class CreateRent: IRequest<Rent>
    {
        public string LocationId { get; set; }
        public string UserId { get; set; }
        public string ScooterInstanceId { get; set; }
        public DateTime RentDate { get; set; }
    }
}
