using System;
using LocationAPI.Data;
using MediatR;
using System.Collections.Generic;

namespace LocationAPI.DTOs
{
    public class AddScooterInstances : IRequest<List<LocationsToScooters>>
    {
        public Guid locationID { get; set; }
        public List<Guid> scooterInstanceIDs { get; set; }
    }
}
