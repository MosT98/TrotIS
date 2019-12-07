using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using UserAPI.Data;
using UserAPI.DTOs;

namespace UserAPI.Business
{
    public class GetUsersHandler: IRequestHandler<GetUsers, List<User>>
    {
        private readonly Context context;
        public GetUsersHandler(Context context)
        {
            this.context = context;
        }
        public async Task<List<User>> Handle(GetUsers request, CancellationToken cancellationToken)
        {
            var users = await context.Users.ToListAsync();
            return users;
        }
    }
}
