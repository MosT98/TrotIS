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
    public class DeleteUserHandler: IRequestHandler<DeleteUser>
    {
        private readonly Context context;
        public DeleteUserHandler(Context context)
        {
            this.context = context;
        }
        public async Task<Unit> Handle(DeleteUser request, CancellationToken cancellationToken)
        {
            var user = await context.Users.SingleOrDefaultAsync(u => u.UserId == request.UserId);
            if (user==null)
            {
                throw new Exception("User does not exists");
            }
            context.Users.Remove(user);
            await context.SaveChangesAsync(cancellationToken);
            return Unit.Value;
        }
    }
}
