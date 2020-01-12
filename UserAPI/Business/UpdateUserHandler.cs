using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using TrotIS.Shared;
using UserAPI.Data;
using UserAPI.DTOs;

namespace UserAPI.Business
{
    public class UpdateUserHandler: IRequestHandler<UpdateUser, User>
    {
        private readonly Context context;
        public UpdateUserHandler(Context context)
        {
            this.context = context;
        }
        public async Task<User> Handle(UpdateUser request, CancellationToken cancellationToken)
        {
            var user = await context.Users.SingleOrDefaultAsync(u => u.UserId == request.UserId);
            if (user == null)
            {
                throw new Exception("User does not exists");
            }

            var address = user.Address;
            
            if(address==null)
            {
                address = Address.Create(request.Country, request.City, request.Street, request.Number);
                context.Addresses.Add(address);
                await context.SaveChangesAsync(cancellationToken);
            }
            else
            {
                address.Update(request.Country, request.City, request.Street, request.Number);
                await context.SaveChangesAsync(cancellationToken);
            }

            user.Update(request.FirstName, request.LastName, Shared.Utilities.sha256_hash(request.Password), address);

            await context.SaveChangesAsync(cancellationToken);
            return user;
        }
    }
}
