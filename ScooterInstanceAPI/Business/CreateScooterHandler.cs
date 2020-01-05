using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Microsoft.EntityFrameworkCore;
using ScooterInstanceAPI.Data;
using ScooterInstanceAPI.DTOs;

namespace ScooterInstanceAPI.Business
{
    public class CreateScooterHandler : IRequestHandler<CreateScooter, Scooter>
    {
        private readonly Context context;

        public CreateScooterHandler(Context context)
        {
            this.context = context;
        }

        public async Task<Scooter> Handle(CreateScooter request, CancellationToken cancellationToken)
        {
            var newScooter = Scooter.Create(request.Brand, request.Model, request.BatteryLife, request.AgeLimitMin, request.AgeLimitMax, request.WeightMax, request.SpeedLimit, request.ClimbAngle);

            context.Scooters.Add(newScooter);
            await context.SaveChangesAsync(cancellationToken);
            return newScooter;

        }
    }
}