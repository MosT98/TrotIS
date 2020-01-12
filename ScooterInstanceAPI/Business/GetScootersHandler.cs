using System;
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
    public class GetScootersHandler : IRequestHandler<GetScooters, List<Scooter>>
    {
        private readonly Context context;

        public GetScootersHandler(Context context)
        {
            this.context = context;
        }

        public async Task<List<Scooter>> Handle(GetScooters request, CancellationToken cancellationToken)
        {
            var scooters = await context.Scooters.ToListAsync();
            return scooters;
        }
    }
}
