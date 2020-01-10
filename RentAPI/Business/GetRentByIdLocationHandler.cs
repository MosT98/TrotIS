using MediatR;
using Microsoft.EntityFrameworkCore;
using RentAPI.Data;
using RentAPI.DTOs;
using System.Threading;
using System.Threading.Tasks;

namespace RentAPI.Business
{
    public class GetRentByIdLocationHandler : IRequestHandler<GetRentByIdLocation, Rent>
    {
        private readonly Context context;

        public GetRentByIdLocationHandler(Context context)
        {
            this.context = context;
        }

        public async Task<Rent> Handle(GetRentByIdLocation request, CancellationToken cancellationToken)
        {
            var rent = await context.Rents.SingleOrDefaultAsync(r => r.LocationId == request.LocationId);
            return rent;
        }
    }
}
