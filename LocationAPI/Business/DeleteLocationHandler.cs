using LocationAPI.Data;
using LocationAPI.DTOs;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace LocationAPI.Business
{
    public class DeleteLocationHandler : IRequestHandler<DeleteLocation>
    {
        private readonly Context context;
        public DeleteLocationHandler(Context context)
        {
            this.context = context;
        }
        public async Task<Unit> Handle(DeleteLocation request, CancellationToken cancellationToken)
        {
            var user = await context.Locations.SingleOrDefaultAsync(u => u.LocationID == request.LocationID);
            if (user == null)
            {
                throw new Exception("Location does not exists");
            }
            context.Locations.Remove(user);
            await context.SaveChangesAsync(cancellationToken);
            return Unit.Value;
        }
    }
}
