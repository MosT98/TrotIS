using LocationAPI.Data;
using MediatR;
using System.Collections.Generic;

namespace LocationAPI.DTOs
{
    public class AddScooterInstances : IRequest<List<LocationsToScooters>>
    {
        public string locationID { get; set; }
        public List<string> scooterInstanceIDs { get; set; }
    }
}
