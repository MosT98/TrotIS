using LocationAPI.Data;
using LocationAPI.DTOs;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace LocationAPI.Business
{
    public class CreateLocationHandler : IRequestHandler<CreateLocation, Location>
    {
        private readonly Context context;
        public CreateLocationHandler(Context context)
        {
            this.context = context;
        }
        public async Task<Location> Handle(CreateLocation request, CancellationToken cancellationToken)
        {
            Location location = Location.Create(request.addressID);
            if (location != null)
            {
                context.Locations.Add(location);
                await context.SaveChangesAsync(cancellationToken);
                return location;
            }
            return null;
        }
    }
}
