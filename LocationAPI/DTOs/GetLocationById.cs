using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;

namespace LocationAPI.DTOs
{
    public class GetLocationById : IRequest<string>
    {
        public Guid LocationId { get; set; }
        public GetLocationById(Guid locationId)
        {
            LocationId = locationId;
        }
    }
}
