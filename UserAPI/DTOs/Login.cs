using MediatR;
using UserAPI.Data;

namespace UserAPI.DTOs
{
    public class Login : IRequest<User>
    {
        public string Email { get; set; }
        public string Password { get; set; }
        
    }
}
