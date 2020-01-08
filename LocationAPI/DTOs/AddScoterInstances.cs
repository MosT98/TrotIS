using LocationAPI.Data;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LocationAPI.DTOs
{
    public class AddScooterInstances : IRequest<List<LocationsToScooters>>
    {
        public string locationID { get; set; }
        public List<string> scooterInstanceIDs { get; set; }
    }
}
