using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TrotIS.Shared;

namespace TrotIS.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {

        private readonly ILogger<UserController> _logger;

        public UserController(ILogger<UserController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<User> Get()
        {
            Context context = new Context();
            return context.Users.Where(a => a.Email.EndsWith("gmail.com")).ToArray();
        }

        [HttpGet("{id}")]//api/user/ca1683f1-4935-44ef-bd66-eddf0956000d
        public User GetUserById(Guid id)
        {
            Context context = new Context();
            return context.Users.FirstOrDefault(u => u.UserId == id);
        }
        [HttpPost]
        public User AddUser([FromBody] User user)
        {
            Context context = new Context();
            context.Users.Add(user);
            if (context.Users.Find(user) != null)
                return user;
            else
                return null;
        }
    }
}
