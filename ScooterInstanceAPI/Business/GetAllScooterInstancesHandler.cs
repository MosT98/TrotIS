using MediatR;
using Microsoft.EntityFrameworkCore;
using ScooterInstanceAPI.Data;
using ScooterInstanceAPI.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace ScooterInstanceAPI.Business
{
    public class GetAllScooterInstancesHandler : IRequestHandler<GetAllScooterInstances, List<ScooterInstance>>
    {
        private readonly Context context;

        public GetAllScooterInstancesHandler(Context context)
        {
            this.context = context;
        }

        public async Task<List<ScooterInstance>> Handle(GetAllScooterInstances request, CancellationToken cancellationToken)
        {
            var scooterInstances = await context.ScooterInstances.ToListAsync();
  
            return scooterInstances;
        }
    }
}
