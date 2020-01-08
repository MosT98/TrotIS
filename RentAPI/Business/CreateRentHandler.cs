using MediatR;
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
            Rent rent = Rent.Create(request.LocationID, request.UserID, request.ScooterInstanceID, request.RentDate);
            if (rent != null)
            {
                context.Rents.Add(rent);
                await context.SaveChangesAsync(cancellationToken);
                return rent;
            }
            return null;
        }
    }
}
