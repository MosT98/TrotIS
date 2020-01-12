using LocationAPI.Data;
using MediatR;
using System;

namespace LocationAPI.DTOs
{
    public class AddScooterInstance: IRequest<LocationsToScooters>
    {
        public Guid locationID { get; set; }
        public Guid scooterInstanceID { get; set; }
    }
}
