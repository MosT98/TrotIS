using MediatR;
using Microsoft.EntityFrameworkCore;
using RentAPI.Data;
using RentAPI.DTOs;
using System.Threading;
using System.Threading.Tasks;

namespace RentAPI.Business
{
    public class CreateRentHandler : IRequestHandler<CreateRent, Rent>
    {
        private readonly Context context;

        public CreateRentHandler(Context context)
        {
            this.context = context;
        }

        public async Task<Rent> Handle(CreateRent request, CancellationToken cancellationToken)
        {
            var rent = Rent.Create(request.LocationId, request.UserId, request.ScooterInstanceId, request.StartDate, request.EndDate);
            if (rent != null)
            {
                var falseRent = await context.Rents.FirstOrDefaultAsync(a => a.UserId.ToString() == request.UserId && a.IsCancelled == false);
                if (falseRent == default(Rent))
                {
                    context.Rents.Add(rent);
                    await context.SaveChangesAsync(cancellationToken);
                    return rent;
                }
            }
            return null;
        }
    }
}
