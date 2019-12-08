using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
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
            if(user.Email!=request.Email) //try to change email address
            {
                if (await context.Users.SingleOrDefaultAsync(u => u.Email == request.Email) != null)
                    throw new Exception("Email already used. Try another email");
            }
            var address = context.Addresses.FirstOrDefault(a => a.AddressId == request.Address.AddressId);
            
            if(address==null)
            {
                address = Address.Create(request.Address.Country, request.Address.County, request.Address.City, request.Address.Street,
                    request.Address.Number, request.Address.Block, request.Address.Floor, request.Address.Apartment);
                context.Addresses.Add(address);
                await context.SaveChangesAsync(cancellationToken);
            }
            else
            {
                address.Update(request.Address.Country, request.Address.County, request.Address.City, request.Address.Street,
                    request.Address.Number, request.Address.Block, request.Address.Floor, request.Address.Apartment);
                await context.SaveChangesAsync(cancellationToken);
            }

            user.Update(request.Email, request.Password, request.FirstName, request.LastName, request.Phone,
                request.BirthDay, request.SocialClass, address);

            await context.SaveChangesAsync(cancellationToken);
            return user;
        }
    }
}
