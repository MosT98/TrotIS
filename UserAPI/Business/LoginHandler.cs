using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TrotIS.Shared;
using UserAPI.Data;
using UserAPI.DTOs;

namespace UserAPI.Business
{
    public class LoginHandler : IRequestHandler<Login, LoginObj>
    {
        private readonly Context context;
        public LoginHandler(Context context)
        {
            this.context = context;
        }

        public async Task<LoginObj> Handle(Login request, CancellationToken cancellationToken)
        {
            var actualUser = await context.Users.SingleOrDefaultAsync(u => u.Email == request.Email);
            if (actualUser != null)
                if (actualUser.Password == Shared.Utilities.sha256_hash(request.Password))
                {
                    LoginObj loginObj = new LoginObj(Shared.Utilities.sha256_hash(actualUser.Email), actualUser.FirstName, actualUser.LastName);
                    return loginObj;
                }
            return null;
        }
    }
}
