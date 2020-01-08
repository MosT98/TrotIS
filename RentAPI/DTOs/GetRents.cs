using MediatR;
using RentAPI.Data;
using System.Collections.Generic;

namespace RentAPI.DTOs
{
    public class GetRents : IRequest<List<Rent>>
    {

    }
}
