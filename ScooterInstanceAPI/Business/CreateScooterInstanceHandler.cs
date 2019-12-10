using System.Threading;
using System.Threading.Tasks;
using MediatR;
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
            var newScooterInstance = ScooterInstance.Create(request.ScooterAutonomy); //mai trebuie adaugat si scooter dupa ce se implementeaza

            context.ScooterInstances.Add(newScooterInstance);
            await context.SaveChangesAsync(cancellationToken);
            return newScooterInstance;
            
        }
    }
}
