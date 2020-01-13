using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Microsoft.EntityFrameworkCore;
using ScooterInstanceAPI.Data;
using ScooterInstanceAPI.DTOs;

namespace ScooterInstanceAPI.Business
{
    public class GetAutonomyByIdHandler : IRequestHandler<GetAutonomyById, int>
    {
        private readonly Context context;

        public GetAutonomyByIdHandler(Context context)
        {
            this.context = context;
        }

        public async Task<int> Handle(GetAutonomyById request, CancellationToken cancellationToken)
        {
            var scooterInstance =
                await context.ScooterInstances.SingleOrDefaultAsync(a => a.ScooterInstanceId == request.ScooterInstanceId);
            return scooterInstance.ScooterAutonomy;
        }
    }
}
