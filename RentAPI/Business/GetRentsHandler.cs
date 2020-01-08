using MediatR;
using Microsoft.EntityFrameworkCore;
using RentAPI.Data;
using RentAPI.DTOs;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace RentAPI.Business
{
    public class GetRentsHandler : IRequestHandler<GetRents, List<Rent>>
    {
        private readonly Context context;
        public GetRentsHandler(Context context)
        {
            this.context = context;
        }

        public async Task<List<Rent>> Handle(GetRents request, CancellationToken cancellationToken)
        {
            var rents = await context.Rents.ToListAsync();
            return rents;
        }
    }
}
