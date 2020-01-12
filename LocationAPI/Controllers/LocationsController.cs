using System;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using LocationAPI.Data;
using LocationAPI.DTOs;
using System.Collections.Generic;

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

        [Route("scooter_instance")]
        [HttpPost]
        public async Task<ActionResult<LocationsToScooters>> AddScooterInstance([FromBody]AddScooterInstance request)
        {
            var link = await mediator.Send(request);
            return link;
        }

        [Route("scooter_instances")]
        [HttpPost]
        public async Task<ActionResult<List<LocationsToScooters>>> AddScooterInstance([FromBody]AddScooterInstances request)
        {
            var link = await mediator.Send(request);
            return link;
        }

        [HttpGet]
        public async Task<ActionResult<Location>> Get()
        {
            var locations = await mediator.Send(new GetLocations());
            if (locations == null)
            {
                return NotFound();
            }

            return Ok(locations);
        }

        [Route("scooters_ids_from_location")]
        [HttpGet]
        public async Task<ActionResult<List<Guid>>> GetScooters([FromBody] Guid id)
        {
            var scooters = await mediator.Send(new GetScooterInstancesIDs(id));
            if (scooters == null)
            {
                return NotFound();
            }
            return Ok(scooters);
        }

        [Route("delete")]
        [HttpPost]
        public async Task<IActionResult> Delete([FromBody]Guid id)
        {
            await mediator.Send(new DeleteLocation(id));
            return NoContent();
        }
    }
}
