using LocationAPI.Data;
using LocationAPI.DTOs;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace LocationAPI.Business
{
    public class GetScooterInstancesIDsHandler: IRequestHandler<GetScooterInstancesIDs, List<Guid>>
    {
        private readonly Context context;
        public GetScooterInstancesIDsHandler(Context context)
        {
            this.context = context;
        }

        public async Task<List<Guid>> Handle(GetScooterInstancesIDs request, CancellationToken cancellationToken)
        {
            var locations = await context.LinkLocationsToScooterInstances.ToListAsync();
            var scooters =  locations.Where(a => a.LocationID == request.LocationID).Select(a => a.ScooterInstanceID).ToList();
            return scooters;
        }
    }
}
