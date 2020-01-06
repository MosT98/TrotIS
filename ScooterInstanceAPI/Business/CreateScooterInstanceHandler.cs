using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Microsoft.EntityFrameworkCore;
using ScooterInstanceAPI.Data;
using ScooterInstanceAPI.DTOs;

namespace ScooterInstanceAPI.Business
{
    public class CreateScooterInstanceHandler : IRequestHandler<CreateScooterInstance, ScooterInstance>
    {
        private readonly Context context;

        public CreateScooterInstanceHandler(Context context)
        {
            this.context = context;
        }

        public async Task<ScooterInstance> Handle(CreateScooterInstance request, CancellationToken cancellationToken)
        {
            var actualScooter = await context.Scooters.SingleOrDefaultAsync(u => u.ScooterId == request.Scooter);
            var newScooterInstance = ScooterInstance.Create(request.ScooterAutonomy, request.Price, actualScooter); 

            context.ScooterInstances.Add(newScooterInstance);
            await context.SaveChangesAsync(cancellationToken);
            return newScooterInstance;
            
        }
    }
}
