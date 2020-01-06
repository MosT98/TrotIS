using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;
using UserAPI.Data;
using UserAPI.DTOs;

namespace UserAPI.Business
{
    public class LoginHandler : IRequestHandler<Login, User>
    {
        private readonly Context context;
        public LoginHandler(Context context)
        {
            this.context = context;
        }
        public async Task<User> Handle(Login request, CancellationToken cancellationToken)
        {
            var actualUser = await context.Users.SingleOrDefaultAsync(u => u.Email == request.Email);
            if (actualUser != null)
                if (actualUser.Password == request.Password)
                    return actualUser;
            return null;
        }
    }
}
