using LocationAPI.Data;
using LocationAPI.DTOs;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace LocationAPI.Business
{
    public class AddScooterInstanceHandler: IRequestHandler<AddScooterInstance, LocationsToScooters>
    {
        private readonly Context context;
        public AddScooterInstanceHandler(Context context)
        {
            this.context = context;
        }
        public async Task<LocationsToScooters> Handle(AddScooterInstance request, CancellationToken cancellationToken)
        {
            LocationsToScooters link = LocationsToScooters.Create(request.locationID,request.scooterInstanceID);
            if (link != null)
            {
                context.LinkLocationsToScooterInstances.Add(link);
                await context.SaveChangesAsync(cancellationToken);
                return link;
            }
            return null;
        }
    }
}
