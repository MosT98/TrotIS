using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Microsoft.EntityFrameworkCore;
using RentAPI.Data;
using RentAPI.DTOs;

namespace RentAPI.Business
{
    public class GetRentsByIdUserHandler: IRequestHandler<GetRentsByIdUser, List<Rent>>
    {
        private readonly Context context;

        public GetRentsByIdUserHandler(Context context)
        {
            this.context = context;
        }


        public async Task<List<Rent>> Handle(GetRentsByIdUser request, CancellationToken cancellationToken)
        {
            var rents = await context.Rents.Where(r => r.UserId==request.UserId && r.IsCancelled==true).ToListAsync();
            return rents;
        }
    }
}
