using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Microsoft.EntityFrameworkCore;
using ScooterInstanceAPI.Data;
using ScooterInstanceAPI.DTOs;

namespace ScooterInstanceAPI.Business
{
    public class DeleteScooterInstanceHandler : IRequestHandler<DeleteScooterInstance>
    {
        private readonly Context context;

        public DeleteScooterInstanceHandler(Context context)
        {
            this.context = context;
        }

        public async Task<Unit> Handle(DeleteScooterInstance request, CancellationToken cancellationToken)
        {
            var scooterInstance =
                await context.ScooterInstances.SingleOrDefaultAsync(s =>
                    s.ScooterInstanceId == request.ScooterInstanceId);
            if (scooterInstance==null)
            {
                throw new Exception("Scooter instance with this id does not exist!");
            }

            context.ScooterInstances.Remove(scooterInstance);
            await context.SaveChangesAsync(cancellationToken);
            return Unit.Value;
        }
    }
}
