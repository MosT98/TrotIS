using MediatR;
using RentAPI.Data;
using System;

namespace RentAPI.DTOs
{
    public class CreateRent: IRequest<Rent>
    {
        public string LocationID { get; set; }
        public string UserID { get; set; }
        public string ScooterInstanceID { get; set; }
        public DateTime RentDate { get; set; }
    }
}
