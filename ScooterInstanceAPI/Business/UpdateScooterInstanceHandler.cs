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
    public class UpdateScooterInstanceHandler : IRequestHandler<UpdateScooterInstance, ScooterInstance>
    {
        private readonly Context context;

        public UpdateScooterInstanceHandler(Context context)
        {
            this.context = context;
        }

        public async Task<ScooterInstance> Handle(UpdateScooterInstance request, CancellationToken cancellationToken)
        {
            var scooterInstance =
                await context.ScooterInstances.SingleOrDefaultAsync(s =>
                    s.ScooterInstanceId == request.ScooterInstanceId);
            if (scooterInstance==null)
            {
                throw new Exception("Scooter instance with this id does not exist");
            }
            
            scooterInstance.Update(request.ScooterAutonomy); // trebuie adaugat si scooter dupa ce se implementeaza
            await context.SaveChangesAsync(cancellationToken);
            return scooterInstance;
        }
    }
}
