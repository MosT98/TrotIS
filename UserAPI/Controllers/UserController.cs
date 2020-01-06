using System;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using TrotIS.Shared;
using UserAPI.Data;
using UserAPI.DTOs;

namespace UserAPI.Controllers
{
    [ApiController]
    [Route("api/user")]
    public class UserController : ControllerBase
    {

        //private readonly ILogger<UserController> _logger;

        //public UserController(ILogger<UserController> logger)
        //{
        //    _logger = logger;
        //}


        private readonly IMediator mediator;

        public UserController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpPost]
        public async Task<ActionResult<User>> Create([FromBody]CreateUser request)
        {
            var user = await mediator.Send(request);
            return user;
        }

        [Route("/login")]
        [HttpPost]
        public async Task<ActionResult<LoginObj>> Login([FromBody]Login request)
        {
            var loginObj = await mediator.Send(request);
            if(loginObj == null)
            {
                return NotFound();
            }
            
            return new ObjectResult(loginObj);
        }

        [HttpGet]
        public async Task<ActionResult<User>> Get()
        {
            var users = await mediator.Send(new GetUsers());
            if (users == null)
            {
                return NotFound();
            }
            return Ok(users);
        }

        [HttpGet ("{email}")]
        public async Task<ActionResult<User>> Get(Guid id)
        {
            var users = await mediator.Send(new GetUserDetail(id));
            if (users == null)
            {
                return NotFound();
            }
            return Ok(users);
        }

        [HttpDelete]
        public async Task<IActionResult> Delete([FromBody] DeleteUser request)
        {
            await mediator.Send(request);
            return NoContent();
        }

        [HttpPut]
        public async Task<ActionResult<User>> Update([FromBody] UpdateUser request)
        {
            var user = await mediator.Send(request);
            return user;
        }
    }
}
