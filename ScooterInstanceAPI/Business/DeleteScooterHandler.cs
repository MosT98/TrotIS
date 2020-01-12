using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Microsoft.EntityFrameworkCore;
using ScooterInstanceAPI.Data;
using ScooterInstanceAPI.DTOs;

namespace ScooterInstanceAPI.Business
{
    public class DeleteScooterHandler : IRequestHandler<DeleteScooter>
    {
        private readonly Context context;

        public DeleteScooterHandler(Context context)
        {
            this.context = context;
        }

        public async Task<Unit> Handle(DeleteScooter request, CancellationToken cancellationToken)
        {
            var scooter = await context.Scooters.SingleOrDefaultAsync(s => s.ScooterId == request.ScooterId);
            if (scooter == null)
            {
                throw new Exception("Scooter does not exist");
            }

            context.Scooters.Remove(scooter);
            await context.SaveChangesAsync(cancellationToken);
            return Unit.Value;
        }
    }
}
