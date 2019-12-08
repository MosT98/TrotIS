using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using ScooterInstanceAPI.Data;
using ScooterInstanceAPI.DTOs;

namespace ScooterInstanceAPI.Controllers
{
    [ApiController]
    [Route("api/scooterinstance")]
    public class ScooterInstanceController : ControllerBase
    {

        //private readonly ILogger<ScooterInstanceController> _logger;

        //public ScooterInstanceController(ILogger<ScooterInstanceController> logger)
        //{
        //    _logger = logger;
        //}

        private readonly IMediator mediator;

        public ScooterInstanceController(IMediator mediator)
        {
            this.mediator = mediator;
        }


        [HttpGet]
        public async Task<ActionResult<ScooterInstance>> Get()
        {
            var scooterInstances = await mediator.Send(new GetScooterInstances());
            if (scooterInstances == null)
            {
                return NotFound();
            }

            return Ok(scooterInstances);
        }
    }
}
