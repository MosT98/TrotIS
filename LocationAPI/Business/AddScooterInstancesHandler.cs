using LocationAPI.Data;
using LocationAPI.DTOs;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace LocationAPI.Business
{
    public class AddScooterInstancesHandler : IRequestHandler<AddScooterInstances, List<LocationsToScooters>>
    {
        private readonly Context context;
        public AddScooterInstancesHandler(Context context)
        {
            this.context = context;
        }
        public async Task<List<LocationsToScooters>> Handle(AddScooterInstances request, CancellationToken cancellationToken)
        {
            List<LocationsToScooters> link = LocationsToScooters.CreateMany(request.locationID, request.scooterInstanceIDs);
            if (link != null)
            {
                await context.LinkLocationsToScooterInstances.AddRangeAsync(link);
                await context.SaveChangesAsync(cancellationToken);
                return link;
            }
            return null;
        }
    }
}
