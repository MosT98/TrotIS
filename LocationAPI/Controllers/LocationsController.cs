using System;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using LocationAPI.Data;
using LocationAPI.DTOs;

namespace LocationAPI.Controllers
{
    [Route("api/locations")]
    [ApiController]
    public class LocationsController : ControllerBase
    {
        private readonly IMediator mediator;

        public LocationsController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        // POST: api/Locations
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<Location>> Create([FromBody]CreateLocation request)
        {
            var location = await mediator.Send(request);
            return location;
        }

        [Route("api/locations/scooter_instance")]
        [HttpPost]
        public async Task<ActionResult<LocationsToScooters>> AddScooterInstance([FromBody]AddScooterInstance request)
        {
            var link = await mediator.Send(request);
            return link;
        }

    }
}
