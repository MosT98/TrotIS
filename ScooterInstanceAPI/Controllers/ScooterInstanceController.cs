using System;
using System.Collections.Generic;
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

        [Route("get_all_scooters")]
        [HttpPost] 
        public async Task<ActionResult<List<Scooter>>> GetAllScooters([FromBody] List<Guid> ids)
        {
            var scooterInstances = await mediator.Send(new GetScooterInstances(ids));
            if (scooterInstances == null)
            {
                return NotFound();
            }

            return Ok(scooterInstances);
        }
        [HttpGet]
        public async Task<ActionResult<List<ScooterInstance>>> GetAllScootersInstances()
        {
            var scooterInstances = await mediator.Send(new GetAllScooterInstances());
            if (scooterInstances == null)
            {
                return NotFound();
            }

            return Ok(scooterInstances);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ScooterInstance>> GetById(Guid id)
        {
            var scooterInstance = await mediator.Send(new GetScooterInstanceById(id));
            if (scooterInstance==null)
            {
                return NotFound();
            }

            return Ok(scooterInstance);
        }

        [HttpPost]
        public async Task<ActionResult<ScooterInstance>> Create([FromBody] CreateScooterInstance request)
        {
            var newScooterInstance = await mediator.Send(request);
            return newScooterInstance;
        }

        [Route("/scooter")]
        [HttpGet]
        public async Task<ActionResult<Scooter>> Get()
        {
            var scooters = await mediator.Send(new GetScooters());
            if (scooters == null)
            {
                return NotFound();
            }

            return Ok(scooters);
        }

        [Route("/scooter")]
        [HttpPost]
        public async Task<ActionResult<Scooter>> Create([FromBody] CreateScooter request)
        {
            var newScooter = await mediator.Send(request);
            return newScooter;
        }

        [Route("/scooter/delete")]
        [HttpPost]
        public async Task<IActionResult> Delete([FromBody] Guid id)
        {
            await mediator.Send(new DeleteScooter(id));
            return NoContent();
        }

        [Route("/scooterinstance/delete")]
        [HttpPost]
        public async Task<IActionResult> DeleteScooterInstance([FromBody] Guid id)
        {
            await mediator.Send(new DeleteScooter(id));
            return NoContent();
        }

        [HttpPut]
        public async Task<ActionResult<ScooterInstance>> Update([FromBody] UpdateScooterInstance request)
        {
            var scooterInstance = await mediator.Send(request);
            return scooterInstance;
        }
    }
}
