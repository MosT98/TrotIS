using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;
using UserAPI.Data;
using UserAPI.DTOs;

namespace UserAPI.Business
{
    public class GetUserDetailHandler : IRequestHandler<GetUserDetail, User>
    {
        private readonly Context context;
        public GetUserDetailHandler(Context context)
        {
            this.context = context;
        }
        public async Task<User> Handle(GetUserDetail request, CancellationToken cancellationToken)
        {
            var user = await context.Users.SingleOrDefaultAsync(u => u.UserId == request.UserId);
            return user;
        }
        
    }
}
