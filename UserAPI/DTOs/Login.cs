using MediatR;
using TrotIS.Shared;
using UserAPI.Data;

namespace UserAPI.DTOs
{
    public class Login : IRequest<LoginObj>
    {
        public string Email { get; set; }
        public string Password { get; set; }
        
    }
}
