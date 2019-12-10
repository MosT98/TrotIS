using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Microsoft.EntityFrameworkCore;
using ScooterInstanceAPI.Data;
using ScooterInstanceAPI.DTOs;

namespace ScooterInstanceAPI.Business
{
    public class GetScooterInstanceByIdHandler:IRequestHandler<GetScooterInstanceById, ScooterInstance>
    {
        private readonly Context context;

        public GetScooterInstanceByIdHandler(Context context)
        {
            this.context = context;
        }


        public async Task<ScooterInstance> Handle(GetScooterInstanceById request, CancellationToken cancellationToken)
        {
            var scooterInstance =
                await context.ScooterInstances.SingleOrDefaultAsync(s =>
                    s.ScooterInstanceId == request.ScooterInstanceId);
            return scooterInstance;
        }
    }
}
