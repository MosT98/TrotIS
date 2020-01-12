using System.Threading;
using System.Threading.Tasks;
using LocationAPI.Data;
using LocationAPI.DTOs;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace LocationAPI.Business
{
    public class GetLocationByIdHandler : IRequestHandler<GetLocationById, string>
    {
        private readonly Context context;

        public GetLocationByIdHandler(Context context)
        {
            this.context = context;
        }

        public async Task<string> Handle(GetLocationById request, CancellationToken cancellationToken)
        {
            var location = await context.Locations.SingleOrDefaultAsync(l => l.LocationID==request.LocationId);
            return location.Comment;
        }
    }
}
