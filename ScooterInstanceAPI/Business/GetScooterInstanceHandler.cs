using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Microsoft.EntityFrameworkCore;
using ScooterInstanceAPI.Data;
using ScooterInstanceAPI.DTOs;

namespace ScooterInstanceAPI.Business
{
    public class GetScooterInstanceHandler: IRequestHandler<GetScooterInstances, List<ScooterInstance>>
    {
        private readonly Context context;

        public GetScooterInstanceHandler(Context context)
        {
            this.context = context;
        }

        public async Task<List<ScooterInstance>> Handle(GetScooterInstances request, CancellationToken cancellationToken)
        {
            var scooterInstances = await context.ScooterInstances.ToListAsync();
            var myScooters = scooterInstances.Where(a => request.ScooterList.Contains(a.ScooterInstanceId)).ToList();
            return myScooters;
        }
    }
}
