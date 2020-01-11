using LocationAPI.Data;
using MediatR;
using System.Collections.Generic;

namespace LocationAPI.DTOs
{
    public class GetLocations : IRequest<List<Location>>
    {

    }
}
