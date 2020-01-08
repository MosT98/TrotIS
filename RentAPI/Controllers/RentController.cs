using MediatR;
using Microsoft.AspNetCore.Mvc;
using RentAPI.Data;
using RentAPI.DTOs;
using System.Threading.Tasks;

namespace RentAPI.Controllers
{
    [Route("api/rent")]
    [ApiController]
    public class RentController : ControllerBase
    {
        private readonly IMediator mediator;

        public RentController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult<Rent>> Get()
        {
            var rents = await mediator.Send(new GetRents());
            if (rents == null)
            {
                return NotFound();
            }

            return Ok(rents);
        }

        // POST: api/Locations
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<Rent>> Create([FromBody]CreateRent request)
        {
            var location = await mediator.Send(request);
            return location;
        }

        //[Route("api/locations/scooter_instance")]
        //[HttpPost]
        //public async Task<ActionResult<LocationsToScooters>> AddScooterInstance([FromBody]AddScooterInstance request)
        //{
        //    var link = await mediator.Send(request);
        //    return link;
        //}

    }
}
