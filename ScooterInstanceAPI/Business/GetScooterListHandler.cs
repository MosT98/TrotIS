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
    public class GetScooterListHandler: IRequestHandler<GetScooterList, List<Scooter>>
    {
        private readonly Context context;

        public GetScooterListHandler(Context context)
        {
            this.context = context;
        }


        public async Task<List<Scooter>> Handle(GetScooterList request, CancellationToken cancellationToken)
        {
            var scooterInstances = await context.ScooterInstances.ToListAsync();
            var myScootersInstances = scooterInstances.Where(a => request.ScooterInstancesList.Contains(a.ScooterInstanceId)).Select(a=>a.Scooter).ToList();
            var scooters = await context.Scooters.ToListAsync();
            var myScooters = scooters.Where(a => scooters.Contains(a)).Distinct().ToList();
            return myScooters;
        }
    }
}
