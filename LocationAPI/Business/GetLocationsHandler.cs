using LocationAPI.Data;
using LocationAPI.DTOs;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace LocationAPI.Business
{
    public class GetLocationsHandler: IRequestHandler<GetLocations, List<Location>>
    {
        private readonly Context context;
        public GetLocationsHandler(Context context)
        {
            this.context = context;
        }
        public async Task<List<Location>> Handle(GetLocations request, CancellationToken cancellationToken)
        {
            var locations = await context.Locations.ToListAsync();
            return locations;
        }
    }
}
