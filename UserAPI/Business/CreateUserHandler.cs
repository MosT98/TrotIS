using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using UserAPI.Data;
using UserAPI.DTOs;

namespace UserAPI.Business
{
    public class CreateUserHandler : IRequestHandler<CreateUser, User>
    {
        private readonly Context context;
        public CreateUserHandler(Context context)
        {
            this.context = context;
        }
        public async Task<User> Handle(CreateUser request, CancellationToken cancellationToken)
        {

            User user = User.Create(request.Email, request.Password,
                request.FirstName, request.LastName, request.Phone, request.BirthDay, request.SocialClass);
            if (context.Users.FirstOrDefault(u => u.Email == user.Email) == default(User))
            {
                context.Users.Add(user);
                await context.SaveChangesAsync(cancellationToken);
                return user;
            }
            else
                return null;
                
        }
    }
}
