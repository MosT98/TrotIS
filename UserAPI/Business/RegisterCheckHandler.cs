using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using UserAPI.Data;
using UserAPI.DTOs;

namespace UserAPI.Business
{
    public class RegisterCheckHandler : IRequestHandler<RegisterCheck, string>
    {
        private readonly Context context;
        public RegisterCheckHandler(Context context)
        {
            this.context = context;
        }

        public async Task<string> Handle(RegisterCheck request, CancellationToken cancellationToken)
        {
            var email = await context.Users.FirstOrDefaultAsync(u=>u.Email==request.Email);
            var phone = await context.Users.FirstOrDefaultAsync(u => u.Phone == request.Phone);
            
            if (email != default(User) && phone != default(User))
                return "Email and Phone Number are already used!";

            if (email != default(User))
                return "Email already used. Try to register with another email, please!";

            if (email != default(User))
                return "Phone Number already used. Try to register with another Phone Number, please!";

            return null; 
        }
    }
}
